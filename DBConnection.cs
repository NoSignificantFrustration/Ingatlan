using MySqlConnector;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Ingatlan
{
    class DBConnection
    {
        public readonly string connectionString;
        public static DBConnection Instance { get; private set; }

        public DBConnection(string server, string username, string pwd, string dbName)
        {
            Instance = this;
            MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder();
            connectionBuilder.Server = server;
            connectionBuilder.UserID = username;
            connectionBuilder.Password = pwd;
            connectionBuilder.Database = dbName;
            connectionBuilder.ConvertZeroDateTime = true;

            connectionString = connectionBuilder.ToString();

        }


        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = null;
            try
            {

                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (System.Exception ex)
            {
                string message = "Sikertelen adatbázis csatlakozás";
                MessageBox.Show(message, "Hiba", MessageBoxButtons.OK);
                Application.Exit();
            }

            return conn;
        }

        public UserInfo GetUserByAdojel(string adojel)
        {
            string commandString = "SELECT * FROM felhasznalok WHERE adojel = @adojel";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("adojel", adojel);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                reader.Read();

                return new UserInfo(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), reader.GetDateTime(5), reader.GetString(6), reader.GetInt32(9));
            }

        }


        public RegisterResult Register(string adojel, string passwd)
        {
            if (GetUserByAdojel(adojel) != null)
            {
                return RegisterResult.AdojelAlreadyTaken;
            }

            string passHash = PasswordUtility.GetHash(passwd);

            string commandString = "INSERT INTO felhasznalok (`adojel`, `jelszo`, `szerepkor`)" +
                " VALUES (?adojel, ?passwd, 0)";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?adojel", adojel);
                command.Parameters.AddWithValue("?passwd", passHash);
                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                    return RegisterResult.Fail;
                }

            }

            return RegisterResult.Success;
        }

        public void SetIsLoggedIn(string adojel, bool value)
        {
            string commandString = "UPDATE felhasznalok SET `be van-e jelentkezve` = ?value" +
                " WHERE `adojel` = ?adojel";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?adojel", adojel);
                command.Parameters.AddWithValue("?value", value);
                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }


            if (!value)
            {
                return;
            }

            commandString = "UPDATE felhasznalok SET `utolso belepes` = ?lastLogin" +
                " WHERE `adojel` = ?adojel";

            

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?adojel", adojel);
                command.Parameters.AddWithValue("?lastLogin", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void UpdateUserData(UserInfo userInfo)
        {
            string commandString = "UPDATE felhasznalok SET `nev` = ?name, `lakcim` = ?address, `telefonszam` = ?mobileNumber, `szuletesi datum` = ?dateOfBirth, `anyja neve` = ?mothersName" +
                " WHERE `adojel` = ?adojel";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?adojel", userInfo.adojel);
                command.Parameters.AddWithValue("?name", userInfo.name);
                command.Parameters.AddWithValue("?address", userInfo.address);
                command.Parameters.AddWithValue("?mobileNumber", userInfo.mobileNumber);
                command.Parameters.AddWithValue("?dateOfBirth", userInfo.dateOfBirth);
                command.Parameters.AddWithValue("?mothersName", userInfo.mothersName);
                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public enum RegisterResult
        {
            AdojelAlreadyTaken = 0, Success = 1, Fail = 2
        }


    }
}

using MySqlConnector;
using System;
using System.Collections.Generic;
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


        public InsertResult Register(string adojel, string passwd)
        {
            if (GetUserByAdojel(adojel) != null)
            {
                return InsertResult.AlreadyExists;
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
                    return InsertResult.Fail;
                }

            }

            return InsertResult.Success;
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

        public void GetPlotTypes(out Dictionary<string, int> dict)
        {
            dict = new Dictionary<string, int>();

            string commandString = "SELECT * FROM `telek jellegek`";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dict.Add(reader.GetString(1), reader.GetInt32(0));
                }

            }
        }

        public PlotInfo GetPlotByParcelNumber(string parcelNumber)
        {

            string commandString = "SELECT * FROM `telkek` WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", parcelNumber);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                reader.Read();

                return new PlotInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetUInt64(5), reader.GetUInt64(6));

            }
        }

        public InsertResult AddPlot(PlotInfo plot)
        {
            if (GetPlotByParcelNumber(plot.parcelNumber.ToString()) != null)
            {
                return InsertResult.AlreadyExists;
            }


            string commandString = "INSERT INTO `telkek` (`helyrajzi szam`, `jelleg`, `iranyitoszam`, `kozterulet`, `telepules`, `meret`, `becsult ertek`)" +
                " VALUES (?parcelNumber, ?plotType, ?zipCode, ?publicSpace, ?cityName, ?size, ?value)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plot.parcelNumber);
                command.Parameters.AddWithValue("?plotType", plot.plotType);
                command.Parameters.AddWithValue("?zipCode", plot.zipCode.ToString());
                command.Parameters.AddWithValue("?publicSpace", plot.publicSpace);
                command.Parameters.AddWithValue("?cityName", plot.city);
                command.Parameters.AddWithValue("?size", plot.size.ToString());
                command.Parameters.AddWithValue("?value", plot.value.ToString());

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                    return InsertResult.Fail;
                }

            }

            return InsertResult.Success;
        }

        public List<PlotInfo> GetPlots()
        {
            string commandString = "SELECT * FROM `telkek`";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                //command.Parameters.AddWithValue("?parcelNumber", parcelNumber);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                List<PlotInfo> plots = new List<PlotInfo>();


                while (reader.Read())
                {
                    plots.Add(new PlotInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetUInt64(5), reader.GetUInt64(6))); ;
                }
                

                return plots;

            }
        }

        public List<UserInfo> GetUsers()
        {
            string commandString = "SELECT * FROM `felhasznalok`";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                //command.Parameters.AddWithValue("?parcelNumber", parcelNumber);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                List<UserInfo> users = new List<UserInfo>();


                while (reader.Read())
                {
                    users.Add(new UserInfo(reader.GetInt64(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt64(4), reader.GetDateTime(5), reader.GetString(6), reader.GetInt32(9)));
                }


                return users;

            }
        }

        public OwnerInfo GetPlotOwnerInfo(string propertyID, string ownerID)
        {
            string commandString = "SELECT * FROM `telek tulajdonosok` WHERE `helyrajzi szam` = ?parcelNumber AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", propertyID);
                command.Parameters.AddWithValue("?ownerID", ownerID);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                reader.Read();

                return new OwnerInfo(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), reader.GetInt32(3));

            }
        }

        public InsertResult AddPlotOwner(OwnerInfo ownerInfo)
        {
            if (GetPlotOwnerInfo(ownerInfo.PropertyID.ToString(), ownerInfo.ownerID.ToString()) != null)
            {
                return InsertResult.AlreadyExists;
            }


            string commandString = "INSERT INTO `telek tulajdonosok` VALUES (?parcelNumber, ?ownerID, ?ownerSince, ?ownerPercentage)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);
                command.Parameters.AddWithValue("?ownerSince", ownerInfo.ownerSince.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("?ownerPercentage", ownerInfo.ownerPercentage);

                if (command.ExecuteNonQuery() < 0)
                {
                    return InsertResult.Fail;
                }

                return InsertResult.Success;

            }
        }

        public List<OwnerInfo> GetPlotOwners(string parcelNumber)
        {
            string commandString = "SELECT * FROM `telek tulajdonosok` WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", parcelNumber);
                MySqlDataReader reader = command.ExecuteReader();

                List<OwnerInfo> owners = new List<OwnerInfo>();
                while (reader.Read())
                {
                    owners.Add(new OwnerInfo(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), reader.GetInt32(3)));
                }

                return owners;
            }
        }

        public void UpdatePlot(PlotInfo plot)
        {
            string commandString = "UPDATE `telkek` SET `jelleg` = ?plotType, `iranyitoszam` = ?zipCode, `kozterulet` = ?publicSpace, `telepules` = ?cityName, `meret` = ?size, `becsult ertek` = ?value WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plot.parcelNumber);
                command.Parameters.AddWithValue("?plotType", plot.plotType);
                command.Parameters.AddWithValue("?zipCode", plot.zipCode.ToString());
                command.Parameters.AddWithValue("?publicSpace", plot.publicSpace);
                command.Parameters.AddWithValue("?cityName", plot.city);
                command.Parameters.AddWithValue("?size", plot.size.ToString());
                command.Parameters.AddWithValue("?value", plot.value.ToString());

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void UpdatePlotOwner(OwnerInfo ownerInfo)
        {
            string commandString = "UPDATE `telek tulajdonosok` SET `tulajdonhanyad` = ?ownerPercentage WHERE `helyrajzi szam` = ?parcelNumber AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?ownerPercentage", ownerInfo.ownerPercentage);
                command.Parameters.AddWithValue("?parcelNumber", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void RemovePlotOwner(OwnerInfo ownerInfo)
        {
            string commandString = "DELETE FROM `telek tulajdonosok` WHERE `helyrajzi szam` = ?parcelNumber AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void DeletePlot(PlotInfo plotInfo)
        {
            string commandString = "DELETE FROM `telek tulajdonosok` WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plotInfo.parcelNumber);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }


            commandString = "UPDATE `ingatlanok` SET `helyrajzi szam` = 0 WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plotInfo.parcelNumber);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }


            commandString = "DELETE FROM `telkek` WHERE `helyrajzi szam` = ?parcelNumber";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plotInfo.parcelNumber);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        

        public enum InsertResult
        {
            AlreadyExists = 0, Success = 1, Fail = 2
        }


    }
}

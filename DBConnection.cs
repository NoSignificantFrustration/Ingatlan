using MySqlConnector;
using System;
using System.Collections.Generic;
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
                string message = "Sikertelen adatbázis csatlakozás: " + ex.Message;
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

        public PlotInfo GetPlotById(int id)
        {

            string commandString = "SELECT * FROM `telkek` WHERE `azonosito` = ?id";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?id", id);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                reader.Read();

                return new PlotInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetUInt64(5), reader.GetUInt64(6));

            }
        }

        public PlotInfo GetPlotByParcelNumberCity(string parcelNumber, string city)
        {

            string commandString = "SELECT * FROM `telkek` WHERE `helyrajzi szam` = ?parcelNumber && UPPER(`telepules`) = UPPER(?city)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", parcelNumber);
                command.Parameters.AddWithValue("?city", city);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }

                reader.Read();

                return new PlotInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetUInt64(5), reader.GetUInt64(6));

            }
        }

        public InsertResult AddPlot(PlotInfo plot)
        {
            if (GetPlotByParcelNumberCity(plot.parcelNumber.ToString(), plot.city) != null)
            {
                return InsertResult.AlreadyExists;
            }


            string commandString = "INSERT INTO `telkek` (`helyrajzi szam`, `jelleg`, `iranyitoszam`, `telepules`, `meret`, `becsult ertek`)" +
                " VALUES (?parcelNumber, ?plotType, ?zipCode, ?cityName, ?size, ?value)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?parcelNumber", plot.parcelNumber);
                command.Parameters.AddWithValue("?plotType", plot.plotType);
                command.Parameters.AddWithValue("?zipCode", plot.zipCode.ToString());
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

                //if (!reader.HasRows)
                //{
                //    return null;
                //}

                List<PlotInfo> plots = new List<PlotInfo>();


                while (reader.Read())
                {
                    plots.Add(new PlotInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetUInt64(5), reader.GetUInt64(6))); ;
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
            string commandString = "SELECT * FROM `telek tulajdonosok` WHERE `telek azonosito` = ?plotId AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", propertyID);
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


            string commandString = "INSERT INTO `telek tulajdonosok` VALUES (?plotId, ?ownerID, ?ownerSince, ?ownerPercentage)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", ownerInfo.PropertyID);
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

        public List<OwnerInfo> GetPlotOwners(string plotId)
        {
            string commandString = "SELECT * FROM `telek tulajdonosok` WHERE `telek azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotId);
                MySqlDataReader reader = command.ExecuteReader();

                List<OwnerInfo> owners = new List<OwnerInfo>();
                while (reader.Read())
                {
                    owners.Add(new OwnerInfo(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), reader.GetInt32(3)));
                }

                return owners;
            }
        }

        public InsertResult UpdatePlot(PlotInfo plot)
        {

            if (GetPlotByParcelNumberCity(plot.parcelNumber.ToString(), plot.city) != null)
            {
                return InsertResult.AlreadyExists;
            }


            string commandString = "UPDATE `telkek` SET `jelleg` = ?plotType, `iranyitoszam` = ?zipCode, `telepules` = ?cityName, `meret` = ?size, `becsult ertek` = ?value WHERE `azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plot.id);
                command.Parameters.AddWithValue("?plotType", plot.plotType);
                command.Parameters.AddWithValue("?zipCode", plot.zipCode.ToString());
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

        public void UpdatePlotOwner(OwnerInfo ownerInfo)
        {
            string commandString = "UPDATE `telek tulajdonosok` SET `tulajdonhanyad` = ?ownerPercentage WHERE `telek azonosito` = ?plotId AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?ownerPercentage", ownerInfo.ownerPercentage);
                command.Parameters.AddWithValue("?plotId", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        

        public void RemovePlotOwner(OwnerInfo ownerInfo)
        {
            string commandString = "DELETE FROM `telek tulajdonosok` WHERE `telek azonosito` = ?plotId AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void DeletePlot(PlotInfo plotInfo)
        {

            string commandString = "DELETE FROM `ingatlan tulajdonosok` WHERE `ingatlan azonosito` IN(" +
                "SELECT `azonosito` FROM `ingatlanok` WHERE `telek azonosito` = ?plotId);" +
                "DELETE FROM `ingatlanok` WHERE `telek azonosito` = ?plotId";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotInfo.id);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }


            }



            commandString = "DELETE FROM `telek tulajdonosok` WHERE `telek azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotInfo.id);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }


            commandString = "DELETE FROM `telkek` WHERE `azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotInfo.id);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void GetBuildingTypes(out Dictionary<string, int> dict)
        {
            dict = new Dictionary<string, int>();

            string commandString = "SELECT * FROM `ingatlan jellegek`";


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

        public void AddBuilding(BuildingInfo buildingInfo)
        {



            string commandString = "INSERT INTO `ingatlanok` (`telek azonosito`, `jelleg`, `epites eve`, `kozterulet`, `hazszam`, `becsult ertek`)" +
                " VALUES (?plotId, ?buildingType, ?yearBuilt, ?publicSpace, ?streetNumber, ?value)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", buildingInfo.plotId);
                command.Parameters.AddWithValue("?buildingType", buildingInfo.buildingType);
                command.Parameters.AddWithValue("?yearBuilt", buildingInfo.yearBuilt.ToString());
                command.Parameters.AddWithValue("?publicSpace", buildingInfo.publicSpace);
                command.Parameters.AddWithValue("?streetNumber", buildingInfo.houseNumber);
                command.Parameters.AddWithValue("?value", buildingInfo.value.ToString());

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }

        }

        public void UpdateBuilding(BuildingInfo buildingInfo)
        {



            string commandString = "UPDATE `ingatlanok` SET `jelleg` = ?buildingType, `epites eve` = ?yearBuilt, `kozterulet` = ?publicSpace, `hazszam` = ?streetNumber, `becsult ertek` = ?value" +
                " WHERE `azonosito` = ?buildingId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?buildingId", buildingInfo.id);
                command.Parameters.AddWithValue("?buildingType", buildingInfo.buildingType);
                command.Parameters.AddWithValue("?yearBuilt", buildingInfo.yearBuilt.ToString());
                command.Parameters.AddWithValue("?publicSpace", buildingInfo.publicSpace);
                command.Parameters.AddWithValue("?streetNumber", buildingInfo.houseNumber);
                command.Parameters.AddWithValue("?value", buildingInfo.value.ToString());

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }

        }

        public int CountPlotBuildings(int plotId)
        {
            string commandString = "SELECT COUNT(*) FROM `ingatlanok` WHERE `telek azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotId);
                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return reader.GetInt32(0);
            }
        }

        public List<BuildingInfo> GetPlotBuildings(int plotId)
        {
            string commandString = "SELECT * FROM `ingatlanok` WHERE `telek azonosito` = ?plotId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", plotId);
                MySqlDataReader reader = command.ExecuteReader();

                List<BuildingInfo> buildings = new List<BuildingInfo>();
                while (reader.Read())
                {
                    buildings.Add(new BuildingInfo(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetUInt64(6)));
                }

                return buildings;
            }
        }

        public List<OwnerInfo> GetBuildingOwners(string buildingId)
        {
            string commandString = "SELECT * FROM `ingatlan tulajdonosok` WHERE `ingatlan azonosito` = ?buildingId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?buildingId", buildingId);
                MySqlDataReader reader = command.ExecuteReader();

                List<OwnerInfo> owners = new List<OwnerInfo>();
                while (reader.Read())
                {
                    owners.Add(new OwnerInfo(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), reader.GetInt32(3)));
                }

                return owners;
            }
        }

        public OwnerInfo GetBuildingOwnerInfo(string buildingId, string ownerId)
        {
            string commandString = "SELECT * FROM `ingatlan tulajdonosok` WHERE `ingatlan azonosito` = ?buildingId AND `tulajdonos adojel` = ?ownerId";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?buildingId", buildingId);
                command.Parameters.AddWithValue("?ownerId", ownerId);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    return null;
                }
                reader.Read();

                return new OwnerInfo(reader.GetInt32(0), reader.GetInt64(1), reader.GetDateTime(2), reader.GetInt32(3));



            }
        }

        public InsertResult AddBuildingOwner(OwnerInfo ownerInfo)
        {
            if (GetBuildingOwnerInfo(ownerInfo.PropertyID.ToString(), ownerInfo.ownerID.ToString()) != null)
            {
                return InsertResult.AlreadyExists;
            }


            string commandString = "INSERT INTO `ingatlan tulajdonosok` VALUES (?buildingId, ?ownerID, ?ownerSince, ?ownerPercentage)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?buildingId", ownerInfo.PropertyID);
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

        public void UpdateBuildingOwner(OwnerInfo ownerInfo)
        {
            string commandString = "UPDATE `ingatlan tulajdonosok` SET `tulajdonhanyad` = ?ownerPercentage WHERE `ingatlan azonosito` = ?plotId AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?ownerPercentage", ownerInfo.ownerPercentage);
                command.Parameters.AddWithValue("?plotId", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public void RemoveBuildingOwner(OwnerInfo ownerInfo)
        {
            string commandString = "DELETE FROM `ingatlan tulajdonosok` WHERE `ingatlan azonosito` = ?plotId AND `tulajdonos adojel` = ?ownerID";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?plotId", ownerInfo.PropertyID);
                command.Parameters.AddWithValue("?ownerID", ownerInfo.ownerID);


                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }

            }
        }

        public List<string[]> ListOwnedPlots(long ownerId)
        {
            string commandString = "SELECT `telkek`.`helyrajzi szam`, `telkek`.`telepules`, `telkek`.`becsult ertek`, `telek tulajdonosok`.`tulajdonba kerules datuma`, `telek tulajdonosok`.`tulajdonhanyad`, `telkek`.`jelleg` FROM `telek tulajdonosok`, `telkek` WHERE `telek tulajdonosok`.`tulajdonos adojel` = ?ownerId AND `telkek`.`azonosito` = `telek tulajdonosok`.`telek azonosito` ORDER BY `telkek`.`iranyitoszam` ASC, `telkek`.`telepules` ASC; ";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?ownerId", ownerId);
                MySqlDataReader reader = command.ExecuteReader();


                GetPlotTypes(out Dictionary<string, int> dict);

                Dictionary<int, string> reverseDict = new Dictionary<int, string>();

                foreach (KeyValuePair<string, int> item in dict)
                {
                    reverseDict.Add(item.Value, item.Key);
                }

                List<string[]> lines = new List<string[]>();
                while (reader.Read())
                {
                    ulong value = reader.GetUInt64(2);
                    int ownerPercentage = reader.GetInt32(4);

                    lines.Add(new string[] { reader.GetInt32(0).ToString(), reader.GetString(1), reverseDict[reader.GetInt32(5)], value.ToString(), reader.GetDateTime(3).ToString("yyyy-MM-dd"), ownerPercentage.ToString(), (value * (ulong)ownerPercentage * 0.01).ToString() });
                }

                return lines;
            }
        }

        public List<string[]> ListOwnedBuildings(long ownerId)
        {
            string commandString = "SELECT `telkek`.`helyrajzi szam`, `telkek`.`telepules`, `ingatlanok`.`kozterulet`, `ingatlanok`.`hazszam`, `ingatlanok`.`becsult ertek`, `ingatlan tulajdonosok`.`tulajdonba kerules datuma`, `ingatlan tulajdonosok`.`tulajdonhanyad`, `ingatlanok`.`jelleg`" +
                " FROM `ingatlan tulajdonosok`, `ingatlanok`, `telkek` " +
                "WHERE `ingatlan tulajdonosok`.`tulajdonos adojel` = ?ownerId " +
                "AND `ingatlanok`.`azonosito` = `ingatlan tulajdonosok`.`ingatlan azonosito` " +
                "AND `telkek`.`azonosito` = `ingatlanok`.`telek azonosito` " +
                "ORDER BY `telkek`.`iranyitoszam` ASC, `telkek`.`telepules` ASC, `ingatlanok`.`hazszam` ASC;";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?ownerId", ownerId);
                MySqlDataReader reader = command.ExecuteReader();


                GetBuildingTypes(out Dictionary<string, int> dict);

                Dictionary<int, string> reverseDict = new Dictionary<int, string>();

                foreach (KeyValuePair<string, int> item in dict)
                {
                    reverseDict.Add(item.Value, item.Key);
                }

                List<string[]> lines = new List<string[]>();
                while (reader.Read())
                {
                    ulong value = reader.GetUInt64(4);
                    int ownerPercentage = reader.GetInt32(6);

                    lines.Add(new string[] { reader.GetInt32(0).ToString(), reader.GetString(1), reverseDict[reader.GetInt32(7)], reader.GetString(2), reader.GetString(3), value.ToString(), reader.GetDateTime(5).ToString("yyyy-MM-dd"), ownerPercentage.ToString(), (value * (ulong)ownerPercentage * 0.01).ToString() });
                }

                return lines;
            }
        }

        public void DeleteBuilding(BuildingInfo buildingInfo)
        {
            string commandString = "DELETE FROM `ingatlan tulajdonosok` WHERE `ingatlan azonosito` = ?buildingID;" +
                " DELETE FROM `ingatlanok` WHERE `azonosito` = ?buildingID";

            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                command.Parameters.AddWithValue("?buildingID", buildingInfo.id);

                if (command.ExecuteNonQuery() < 0)
                {
                    Console.WriteLine("Error");
                }


            }
        }

        public List<string[]> GetMultiOwnedBuildings()
        {
            string commandString = "SELECT `telkek`.`helyrajzi szam`, `telkek`.`telepules`, `ingatlanok`.`kozterulet`, `ingatlanok`.`hazszam`, COUNT(`ingatlan tulajdonosok`.`tulajdonos adojel`)" +
                " FROM `ingatlan tulajdonosok`, `telkek`, `ingatlanok` WHERE `ingatlan tulajdonosok`.`ingatlan azonosito` = `ingatlanok`.`azonosito` AND `telkek`.`azonosito` = `ingatlanok`.`telek azonosito`" +
                " GROUP BY `telkek`.`telepules` ASC, `telkek`.`helyrajzi szam` ASC, `ingatlanok`.`kozterulet` ASC, `ingatlanok`.`hazszam` ASC" +
                " HAVING COUNT(`ingatlan tulajdonosok`.`tulajdonos adojel`) > 1 ";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                MySqlDataReader reader = command.ExecuteReader();


                List<string[]> lines = new List<string[]>();
                while (reader.Read())
                {

                    lines.Add(new string[] { reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4).ToString()});
                }

                return lines;
            }
        }

        public List<string[]> GetEmptyPlots()
        {
            string commandString = "SELECT DISTINCT `telkek`.`helyrajzi szam`, `telkek`.`telepules` " +
                "FROM `telkek`, `ingatlanok`" +
                " WHERE `telkek`.`azonosito` " +
                "NOT IN(SELECT `ingatlanok`.`telek azonosito` FROM `ingatlanok` WHERE `ingatlanok`.`telek azonosito` = `telkek`.`azonosito`)";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                MySqlDataReader reader = command.ExecuteReader();


                List<string[]> lines = new List<string[]>();
                while (reader.Read())
                {

                    lines.Add(new string[] { reader.GetInt32(0).ToString(), reader.GetString(1) });
                }

                return lines;
            }
        }


        public List<string[]> GetMultiBuildingPlots()
        {
            string commandString = "SELECT `telkek`.`helyrajzi szam`, `telkek`.`telepules`, `felhasznalok`.`adojel`, `felhasznalok`.`nev`, `telek tulajdonosok`.`tulajdonhanyad`" +
                " FROM `telkek`, `telek tulajdonosok`, `felhasznalok`" +
                " WHERE `telkek`.`azonosito` IN (SELECT `ingatlanok`.`telek azonosito` FROM `ingatlanok` GROUP BY `ingatlanok`.`telek azonosito` HAVING COUNT(`ingatlanok`.`telek azonosito`) > 1 )" +
                " AND `telek tulajdonosok`.`telek azonosito` = `telkek`.`azonosito`" +
                " AND `felhasznalok`.`adojel` = `telek tulajdonosok`.`tulajdonos adojel`" +
                " ORDER BY `telkek`.`telepules` ASC, `telkek`.`helyrajzi szam` ASC";


            using (MySqlConnection conn = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(commandString, conn);
                MySqlDataReader reader = command.ExecuteReader();


                List<string[]> lines = new List<string[]>();
                while (reader.Read())
                {

                    lines.Add(new string[] { $"[{reader.GetInt32(0)}] - {reader.GetString(1)}", reader.GetInt64(2).ToString(), reader.GetString(3), reader.GetInt32(4).ToString() });
                }

                return lines;
            }
        }


        public enum InsertResult
        {
            AlreadyExists = 0, Success = 1, Fail = 2
        }


    }
}

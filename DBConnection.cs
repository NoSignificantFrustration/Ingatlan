using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    class DBConnection
    {

        public static DBConnection Instance { get; private set; }
        public MySqlConnection conn;

        public DBConnection()
        {
            Instance = this;
            conn = new MySqlConnection();
        }
    }
}

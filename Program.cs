using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingatlan
{
    static class Program
    {
        static readonly string server = "127.0.0.1";
        static readonly string username = "ingatlanos";
        static readonly string password = "2PR!QTDP9.yt80(1";
        static readonly string dbName = "ingatlanok";
        public static UserInfo currentUser = null;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new DBConnection(server, username, password, dbName);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            Console.WriteLine("*******************************\nEXIT\n*******************************************");
            if (currentUser != null)
            {
                DBConnection.Instance.SetIsLoggedIn(currentUser.adojel.ToString(), false);
            }
        }
    }
}

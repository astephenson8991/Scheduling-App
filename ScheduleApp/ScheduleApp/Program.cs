using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LocalDBConnection.ConnectDB(); //CONNECT TO DB BEFORE STARTING APP
            Application.Run(new LoginForm());
            LocalDBConnection.DisconnectDB(); //DISCONNECT DB AFTER ENDING APP
        }
    }
}

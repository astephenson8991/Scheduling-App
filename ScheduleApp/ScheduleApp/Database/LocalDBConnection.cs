using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class LocalDBConnection
    {
        public static MySqlConnection Con { get; set; }

        //CONNECT TO DB CALLED IN PROGRAM.CS BEFORE RUN
        public static void ConnectDB()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            try {
                Con = new MySqlConnection(ConStr);
                Con.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DISCONNECT DB CALLED IN PROGRAM.CS AFTER RUN
        public static void DisconnectDB()
        {
            try
            {
                Con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

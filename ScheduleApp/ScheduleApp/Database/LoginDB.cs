using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class LoginDB
    {
        //VERIFY USER AND PASS MATCH DATABASE
        public static int CheckLogin(string username, string password)
        {
            string SQLString = $"SELECT * FROM user WHERE userName = '{username}' AND password = '{password}'";

            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return (int)reader[0];
                }
                else
                {
                    return 0;
                }
            }
            catch (MySqlException ex) 
                { 
                    MessageBox.Show(ex.Message); 
                    return 0; 
                }
            finally
            {
                reader.Close();
            }
        }
    }
}

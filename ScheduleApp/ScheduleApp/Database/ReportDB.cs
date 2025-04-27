using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class ReportDB
    {
        //GET ALL APPOINTMENTS FOR LOGGED IN USER FOR CHOSEN MONTH
        public static List<string> GetApptInMonth(string month, string UserID)
        {
            List<string> result = new List<string>();
            string SQLString = $"SELECT type, COUNT(*) FROM appointment WHERE MONTH(start) = '{month}' " +
                   $"AND userId = '{UserID}' GROUP BY type;";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();

                string type = (string)reader[0];
                string count = Convert.ToString(reader[1]);

                result.Add(type + " " + count);

                while (reader.Read())
                {
                    type = (string)reader[0];
                    count = Convert.ToString(reader[1]);

                    result.Add(type + " " + count);
                }
                reader.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n\nYour connection may be bad or there are no appointments for this user.", "Error!");
                result.Add("No appointments found.");
                return result;
            }
            finally
            {
                reader.Close();
            }
        }

        //GET USERS USERNAME TO APPEND TO SCHEDULE REPORT
        public static Dictionary<int, string> GetUserIDAndUserName()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            string SQLString = "SELECT userId, userName FROM client_schedule.user;";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();

                if (reader.HasRows)
                {
                    result.Add((int)reader[0], (string)reader[1]);

                    while (reader.Read())
                    {
                        result.Add((int)reader[0], (string)reader[1]);

                    }
                    reader.Close();
                    return result;
                }
                else
                {
                    reader.Close();
                    return result;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return result;
            }
            finally
            {
                reader.Close();
            }
        }

        //GET ALL USERS SCHEDULE FOR REPORT
        public static List<DateTime> GetUserSchedule(int UserID)
        {
            List<DateTime> result = new List<DateTime>();
            string SQLString = $"SELECT start FROM appointment WHERE userId = '{UserID}' ORDER BY start;";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();

                if (reader.HasRows)
                {
                    DateTime a = (DateTime)reader[0];
                    result.Add(a.ToLocalTime());

                    while (reader.Read())
                    {
                        a = (DateTime)reader[0];
                        result.Add(a.ToLocalTime());
                    }
                    reader.Close();
                    return result;
                }
                else
                {
                    reader.Close();
                    return result;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return result;
            }
            finally
            {
                reader.Close();
            }
        }

        //GET CUSTOMER APPOINTMENT COUNT REPORT
        public static List<string> GetCustomerApptCount(string UserID)
        {
            List<string> result = new List<string>();
            string SQLString = $"SELECT appointment.customerId, customer.customerName, Count(*) FROM client_schedule.appointment " +
                               $"INNER JOIN client_schedule.customer ON appointment.customerId = " +
                               $"customer.customerId WHERE appointment.userId = '{UserID}' GROUP BY customerId ORDER BY " +
                               $"customerName;";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();

                if (reader.HasRows)
                {
                    string a = (string)reader[1] + ": " + Convert.ToString(reader[2]);
                    result.Add(a);

                    while (reader.Read())
                    {
                        a = (string)reader[1] + ": " + Convert.ToString(reader[2]);
                        result.Add(a);
                    }
                    reader.Close();
                    return result;
                }
                else
                {
                    reader.Close();
                    return result;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return result;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

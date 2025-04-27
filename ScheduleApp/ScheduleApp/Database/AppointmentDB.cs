using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ScheduleApp.Database
{
    public class AppointmentDB
    {
        //GET ALL APPOINTMENTS THAT BELONG TO LOGGED IN USER
        public static DataTable ApptData(string UserID)
        {
            DataTable dt = new DataTable();

            try {
                string SQLString = $"SELECT appointment.appointmentId AS ID, appointment.type AS Type, customer.customerName AS Customer, " +
                                   $"appointment.start AS Start, appointment.end AS End FROM client_schedule.appointment " +
                                   $"INNER JOIN client_schedule.customer ON appointment.customerId = customer.customerId " +
                                   $"WHERE appointment.userId = '{UserID}';";
                MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
                MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
                dap.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return dt;
            }
        }

        //GET APPOINTMENTS BASED ON CALENDAR FILTER
        public static DataTable ApptFilter(string UserID, string date)
        {
            DataTable dt = new DataTable();

            try
            {
                string SqlString = $"SELECT appointment.appointmentId AS ID, appointment.type AS Type, customer.customerName AS Customer, " +
                                   $"appointment.start AS Start, appointment.end AS End FROM " +
                                   $"client_schedule.appointment INNER JOIN client_schedule.customer ON appointment.customerId = customer.customerId " +
                                   $"WHERE appointment.userId = '{UserID}' AND {date};";
                MySqlCommand cmd = new MySqlCommand(SqlString, LocalDBConnection.Con);
                MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
                dap.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return dt;
            }
        }

        //DELETE SELECTED APPOINTMENT
        public static void DeleteAppt(string id)
        {
            try
            {
                string SqlString = $"DELETE FROM appointment WHERE appointment.appointmentId = {id};";
                MySqlCommand cmd = new MySqlCommand(SqlString, LocalDBConnection.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        //CHECK DATETIMES ARE VALID
        public static bool DateIsValid(DateTime start, DateTime end)
        {
            //TIME MUST BE BETWEEN 9 - 5 EST MONDAY - FRIDAY
            //TIME IS COMPARED IN UNIVERSAL TIME
            TimeSpan HoursStart = new TimeSpan(14, 00, 00);
            TimeSpan HoursEnd = new TimeSpan(22, 00, 00);

            if (start.DayOfWeek == DayOfWeek.Sunday || start.DayOfWeek == DayOfWeek.Saturday ||
                    end.DayOfWeek == DayOfWeek.Sunday || end.DayOfWeek == DayOfWeek.Saturday)
            {
                return false;
            }
            else if (start.TimeOfDay < HoursStart || start.TimeOfDay > HoursEnd || end.TimeOfDay < HoursStart
                    || end.TimeOfDay > HoursEnd)
            {
                return false;
            }
            else if (start > end)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //CHECK APPOINTMENT TIMES DONT OVERLAP
        public static bool ApptOverlaps(DateTime start, DateTime end, string ID, string ApptID)
        {
            bool Overlaps = false;
            string SQLString = $"SELECT * FROM appointment WHERE userId = '{ID}' AND appointmentId != '{ApptID}'";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        reader.Read();
                        DateTime ApptStart = (DateTime)reader[9];
                        DateTime ApptEnd = (DateTime)reader[10];

                        if ((start >= ApptStart && start <= ApptEnd) || (end >= ApptStart && end <= ApptEnd) || (start <= ApptStart && end >= ApptEnd))
                        {
                            Overlaps = true;
                            break;
                        }

                        else { continue; }
                    }
                }
                return Overlaps;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return true;
            }
            finally { reader.Close(); }
        }

        //ADD APPOINTMENT
        public static void AddAppt(string type, string cust, string start, string end, string UserID)
        {
            try
            {
                string SQLString = $"INSERT INTO client_schedule.appointment(customerId, userId, " +
                                   $"title, description, location, contact, type, url, start, end, createDate, " +
                                   $"createdBy, lastUpdate, lastUpdateBy) VALUES ('{cust}', '{UserID}', 'title', " +
                                   $"'description', 'location', 'contact', '{type}', 'url', '{start}', " +
                                   $"'{end}', NOW(), 'me', NOW(), 'me');";
                MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        //CHANGE APPOINTMENT TABLE DATES TO LOCAL TIME
        public static DataTable LocalTimeDT(DataTable dt)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime start = dt.Rows[i].Field<DateTime>("Start");
                    DateTime end = dt.Rows[i].Field<DateTime>("End");
                    DateTime Start = start.ToLocalTime();
                    DateTime End = end.ToLocalTime();

                    dt.Rows[i].SetField("Start", Start);
                    dt.Rows[i].SetField("End", End);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        //UPDATE APPOINTMENT
        public static void UpdateAppt(string apptID, string type, string cust, string StartDB, string EndDB)
        {
            try
            {
                string SQLString = $"UPDATE client_schedule.appointment SET type = '{type}', customerId = '{cust}', " +
                                   $"start = '{StartDB}', end = '{EndDB}' WHERE appointmentId = '{apptID}';";
                MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}

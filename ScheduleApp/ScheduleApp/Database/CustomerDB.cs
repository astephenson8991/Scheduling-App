using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Database
{
    public class CustomerDB
    {
        //GET CUSTOMER NAME FROM CUSTOMER ID FOR APPOINTMENT REMINDER
        public static string GetCustName(int CustID)
        {
            string SQLString = $"SELECT * FROM customer WHERE customerid = '{CustID}'";

            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader.GetString(1);
                }
                else
                {
                    return "Not Found";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return "Customer name not found";
            }
            finally
            {
                reader.Close();
            }
        }

        //ADD CUSTOMER
        public static void AddCust(string name, string num, string street, string city,
                                   string country, string zip)
        {
            try
            {
                string SQLString = $"INSERT INTO client_schedule.country(country, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                   $"VALUES ('{country}', NOW(), 'me', NOW(), 'me');" +
                                   $"INSERT INTO client_schedule.city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                   $"VALUES ('{city}', LAST_INSERT_ID(), NOW(), 'me', NOW(), 'me');" +
                                   $"INSERT INTO client_schedule.address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                   $"VALUES ('{street}', 'Apt B', LAST_INSERT_ID(), '{zip}', '{num}', NOW(), 'me', NOW(), 'me');" +
                                   $"INSERT INTO client_schedule.customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                   $"VALUES ('{name}', LAST_INSERT_ID(), 1, NOW(), 'me', NOW(), 'me');";
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

        //CHECK IF CUSTOMER HAS APPOINTMENTS
        public static bool CheckCustAppts(int id)
        {
            string SqlString = $"SELECT * FROM appointment WHERE appointment.customerId = '{id}'";
            MySqlCommand cmd = new MySqlCommand(SqlString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                reader.Read();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return true;
            }
            finally { reader.Close(); }
        }

        //DELETE CUSTOMER
        public static void DeleteCust(int id)
        {
            try
            {
                string SqlString = $"DELETE customer, address, city, country FROM customer" +
                                   $" INNER JOIN address ON address.addressId = customer.addressId" +
                                   $" INNER JOIN city ON city.cityId = address.cityid" +
                                   $" INNER JOIN country ON country.countryId = city.countryId" +
                                   $" WHERE customerId = {id};";
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

        //GET ALL CUSTOMERS IN TABLE
        public static DataTable CustData()
        {
            DataTable dt = new DataTable();
            try
            {
                string SQLString = "SELECT customer.customerId AS ID, customer.customerName AS Name, address.phone AS Phone, address.address AS Street, " +
                       "city.city AS City, country.country AS Country, address.postalCode AS Zip\r\nFROM (((client_schedule.customer\r\n" +
                       "INNER JOIN client_schedule.address ON customer.addressId = address.addressId)\r\nINNER JOIN client_schedule.city " +
                       "ON address.cityId = city.cityId)\r\nINNER JOIN client_schedule.country ON city.countryId = country.countryId);";
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

        //UPDATE CUSTOMER
        public static void UpdateCust(int id, string name, string num, string street, string city,
                                      string country, string zip)
        {
            try
            {
                string SqlString = $"UPDATE customer, address, city, country SET customer.customerName = '{name}', " +
                                   $"address.address = '{street}', address.phone = '{num}', address.postalCode = '{zip}', " +
                                   $"city.city = '{city}', country.country = '{country}' " +
                                   $"WHERE country.countryId = city.countryId AND city.cityId = address.cityId " +
                                   $"AND address.addressId = customer.addressId AND customer.customerId = '{id}';";
                MySqlCommand cmd = new MySqlCommand(SqlString, LocalDBConnection.Con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //GET NAMES FOR APPOINTMENT DROP DOWN
        public static Dictionary<int, string> AllCustNames()
        {
            string SQLString = "SELECT customer.customerId, customer.customerName FROM customer;";

            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();
            Dictionary<int, string> CustData = new Dictionary<int, string>();

            try
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetString(0));
                    string name = reader.GetString(1);

                    CustData.Add(id, name);
                }
                return CustData;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!");
                return CustData;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

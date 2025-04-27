using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using ScheduleApp.Database;
using ScheduleApp.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly int UserID;
        private readonly string UserName;

        //INITIALIZE AND CALL APPTCHECK
        public MainForm(int UsID, string User)
        {
            InitializeComponent();

            UserID = UsID;
            UserName = User;

            ApptCheck(UsID);
        }

        //CHECK FOR AN APPOINTMENT AND DISPLAY IN LOCAL TIME
        private void ApptCheck(int ID)
        {
            DateTime now = DateTime.Now;
            string SQLString = $"SELECT * FROM appointment WHERE userId = '{ID}'";
            MySqlCommand cmd = new MySqlCommand(SQLString, LocalDBConnection.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DateTime start = (DateTime)reader[9];
                        start = start.ToLocalTime();
                        int CustID = (int)reader[1];
                        TimeSpan dif = start - now;

                        if (dif.TotalMinutes >= 0 && dif.TotalMinutes <= 15)
                        {
                            reader.Close();
                            string CustName = CustomerDB.GetCustName(CustID);
                            string time = start.ToString();
                            MessageBox.Show("You have an appointment at " + time + " with " + CustName + ".", "Alert!");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!"); }
            finally { reader.Close(); }
        }

        //APPOINTMENT LINK
        private void ApptLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ApptForm = new ApptForm(UserID);
            ApptForm.Show();
        }

        //CUSTOMER LINK
        private void CustLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var CustForm = new CustomerForm(UserID);
            CustForm.Show();
        }

        //REPORT LINK
        private void ReportsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ReportForm = new ReportForm(UserID);
            ReportForm.Show();
        }

        //LOGOUT BUTTON
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo);
            TimeZoneInfo tz = TimeZoneInfo.Local;

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //FILE LOCATED IN SCHEDULEAPP\BIN\DEBUG
                    string LogFileName = "Login_History.txt";
                    using (StreamWriter SWriter = new StreamWriter(LogFileName, true, Encoding.UTF8))
                    {
                        SWriter.WriteLine("User " + UserName + " logged out at " + DateTime.Now + " " + tz.Id + " and " +
                                          DateTime.UtcNow + " UTC.\n");
                    }
                }
                catch(Exception) { MessageBox.Show("Application failed to write login history to file.", "Log Failure"); };

                var LogForm = new LoginForm();
                LogForm.Show();
                this.Close();
            }
        }
    }
}

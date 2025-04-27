using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using ScheduleApp.Database;
using ScheduleApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScheduleApp
{
    public partial class LoginForm : Form
    {
        private int UserID = 0;

        private static TimeZoneInfo tz = TimeZoneInfo.Local;

        //CHECK TIMEZONE TO DISPLAY IN EITHER ENGLISH OR GERMAN AND CHANGE LABEL TO REFLECT TIMEZONE
        public LoginForm()
        {
            InitializeComponent();

            //CHECK REGION AND SET LANGUAGE
            try
            {
                if (tz.Id == "W. Europe Standard Time")
                {
                    RegionLabel.Text = "Westeuropäische Standardzeit";
                    LoginBtn.Text = "Einreichen";
                    LoginBtn.Width = 80;
                    SchedToolLabel.Text = "Zeitplan-Tool";
                    UserLabel.Text = "Nutzername";
                    PassLabel.Text = "Passwort";
                    ShowPass.Text = "Passwort anzeigen";
                    FailLabel.Text = "Benutzername und Passwort stimmten nicht überein. Bitte versuchen Sie es erneut.";
                }
                else
                {
                    RegionLabel.Text = tz.Id;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error!"); }
        }

        //LOGIN BUTTON CHECK FOR USER AND ADD TO LOG_HISTORY
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string Name = UserTextBox.Text;
            string Pass = PassTextBox.Text;

            UserID = LoginDB.CheckLogin(Name, Pass);
            if (UserID != 0)
            {
                //FILE LOCATED IN SCHEDULEAPP\BIN\DEBUG
                try
                {
                    string LogFileName = "Login_History.txt";
                    using (StreamWriter SWriter = new StreamWriter(LogFileName, true, Encoding.UTF8))
                    {
                        SWriter.WriteLine("User " + Name + " logged in at " + DateTime.Now + " " + tz.Id + " and " + 
                                          DateTime.UtcNow + " UTC.\n");
                    }
                }
                catch (Exception) { MessageBox.Show("Application failed to write login history to file.", "Log Failure"); };

                var MainForm = new MainForm(UserID, Name);
                MainForm.Show();
                Hide();
            }
            else
            {
                FailLabel.Visible = true;
                UserTextBox.Text = string.Empty;
                PassTextBox.Text = string.Empty;
            }
        }

        //SHOW OR HIDE PASSWORD
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked == true)
            {
                PassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassTextBox.UseSystemPasswordChar = true;
            }
        }

        //EXIT APPLICATION
        private void ExitAppBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to quit the application?", "Quit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

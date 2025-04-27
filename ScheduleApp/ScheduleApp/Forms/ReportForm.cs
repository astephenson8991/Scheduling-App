using MySqlX.XDevAPI.Common;
using ScheduleApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Forms
{
    public partial class ReportForm : Form
    {
        private readonly string UserID;
        private Dictionary<string, string> Months = new Dictionary<string, string>()
        {
            {"1", "January" },
            {"02", "February" },
            {"03", "March" },
            {"04", "April" },
            {"05", "May" },
            {"06", "June" },
            {"07", "July" },
            {"08", "August" },
            {"09", "September" },
            {"10", "October" },
            {"11", "November" },
            {"12", "December" }
        };
        public ReportForm(int UsID)
        {
            InitializeComponent();
            UserID = Convert.ToString(UsID);
            MonthComboBox.DataSource = new BindingSource(Months, null);
            MonthComboBox.ValueMember = "Key";
            MonthComboBox.DisplayMember = "Value";
        }

        //APPPOINTMENT TYPE REPORT SELECTED
        private void ApptReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportTextBox.Text = "Choose a month and a report will be generated here.";
            MonthComboBox.Visible = true;
            RunApptReport.Visible = true;
        }

        //GET MONTH SELECTED VALUE MEMBER
        private string GetMonthNumber()
        {
            var item = MonthComboBox.SelectedItem;
            var SelectedCustID = item.GetType().GetProperty("Key").GetValue(item, null);
            return SelectedCustID.ToString();
        }

        //RUN REPORT BUTTON
        private void RunApptReport_Click(object sender, EventArgs e)
        {
            string SelectedMonth = GetMonthNumber();
            List<string> Result = ReportDB.GetApptInMonth(SelectedMonth, UserID);
            ReportTextBox.Text = "Your appointment types for the month of " + MonthComboBox.Text + ":" + "\n\n";
            Result.ForEach(l => { ReportTextBox.AppendText("\t- " + l + "\n"); });
        }

        //SCHEDULE REPORT
        private void SchedReportLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MonthComboBox.Visible = false;
            RunApptReport.Visible = false;
            ReportTextBox.Text = string.Empty;
            Dictionary<int, string> CurrentUsers = ReportDB.GetUserIDAndUserName();

            foreach (var user in CurrentUsers)
            {
                ReportTextBox.AppendText("Schedule for " + user.Value + ":\n\n");
                List<DateTime> a = ReportDB.GetUserSchedule(user.Key);

                a.ForEach(appt => { ReportTextBox.AppendText("\t- " + appt + "\n"); });
                ReportTextBox.AppendText("\n");
            }
        }

        //CUSTOMER APPOINTMENT COUNT REPORT
        private void ReportsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MonthComboBox.Visible = false;
            RunApptReport.Visible = false;
            ReportTextBox.Text = string.Empty;
            List<string> CustomerCount = ReportDB.GetCustomerApptCount(UserID);
            ReportTextBox.Text = "The number of appointments with each customer are as follows:\n\n";
            CustomerCount.ForEach(c => { ReportTextBox.AppendText("\t- " + c + "\n"); });
        }
    }
}

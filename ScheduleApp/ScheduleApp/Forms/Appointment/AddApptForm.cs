using Org.BouncyCastle.Crypto.Operators;
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
    public partial class AddApptForm : Form
    {
        private readonly int UserID;
        private Dictionary<int, string> Customers;

        public AddApptForm(int UsID)
        {
            InitializeComponent();
            UserID = UsID;
            AddCustsToComboBox();
        }

        //ADD CUSTOMERS TO COMBO BOX
        private void AddCustsToComboBox()
        {
            Customers = CustomerDB.AllCustNames();

            AddApptCust.DataSource = new BindingSource(Customers, null);
            AddApptCust.ValueMember = "Key";
            AddApptCust.DisplayMember = "Value";
        }

        //GET SELECTED CUSTOMERS ID
        private string GetComboBoxCustID()
        {
            var item = AddApptCust.SelectedItem;
            var SelectedCustID = item.GetType().GetProperty("Key").GetValue(item, null);
            return SelectedCustID.ToString();
        }

        //CANCEL BUTTON CLOSES FORM
        private void CancelAddApptBtn_Click(object sender, EventArgs e)
        {
            var NewAppt = new ApptForm(UserID);
            NewAppt.Show();
            this.Hide();
        }

        //CHECK FOR VALID ENTRIES AND SUBMIT
        private void AddAptBtn_Click(object sender, EventArgs e)
        {
            string type;
            string cust = GetComboBoxCustID();
            string UsID = Convert.ToString(UserID);
            DateTime StartUTC;
            DateTime EndUTC;
            DateTime start = StartDate.Value.Date + StartTime.Value.TimeOfDay;
            DateTime end = StartDate.Value.Date + EndTime.Value.TimeOfDay;
            string num = "a";
            bool IsValidDate = AppointmentDB.DateIsValid(start.ToUniversalTime(), end.ToUniversalTime());
            bool Overlaps;
            
            //CHECK THAT A TYPE IS SELECTED
            if (ApptType.SelectedItem == null)
            {
                MessageBox.Show("You must select a meeting type.", "Type");
                return;
            }
            else
            {
                type = ApptType.GetItemText(ApptType.SelectedItem);
            }

            //CONVERT TO UTC AND COMPARE WITH VALUES IN DATABASE
            if (IsValidDate)
            {
                StartUTC = start.ToUniversalTime();
                EndUTC = end.ToUniversalTime();
                Overlaps = AppointmentDB.ApptOverlaps(StartUTC, EndUTC, UsID, num);
            }
            else
            {
                MessageBox.Show("Time values must be Monday - Friday 09:00 - 17:00 EST and the start time " +
                                "must be before the end time.", "Invalid Time");
                return;
            }

            //IF THE TIMES SELECTED DONT OVERLAP WITH OTHER APPOINTMENTS, SUBMIT
            if (!Overlaps)
            {
                string StartDB = StartUTC.ToString("yyyy-MM-dd HH:mm:ss");
                string EndDB = EndUTC.ToString("yyyy-MM-dd HH:mm:ss");
                AppointmentDB.AddAppt(type, cust, StartDB, EndDB, UsID);

                var NewAppt = new ApptForm(UserID);
                NewAppt.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The time input overlaps with another appointment. " +
                 "Please try a different time.", "Appointment Conflict");
            }
        }
    }
}

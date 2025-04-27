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
    public partial class UpdateApptForm : Form
    {
        private readonly int UserID;
        private Dictionary<int, string> Customers;
        private readonly int ApptID; 

        //PASS IN ALL DATA FROM SELECTED ROW IN APPTFORM DATAGRIDVIEW
        public UpdateApptForm(int UsID, int apptID, string apptType, string customer, DateTime start, DateTime end)
        {
            InitializeComponent();
            UserID = UsID;
            ApptID = apptID;
            AddCustsToComboBox();

            //SET VALUES OF SELECTED ITEM IN APPTFORM
            ApptType.SelectedItem = apptType;
            SelectCustComboBox(customer);

            StartDate.Value = start;
            StartTime.Value = start;
            EndTime.Value = end;
        }

        //ADD CUSTOMERS TO COMBO BOX
        private void AddCustsToComboBox()
        {
            Customers = CustomerDB.AllCustNames();

            ApptCust.DataSource = new BindingSource(Customers, null);
            ApptCust.ValueMember = "Key";
            ApptCust.DisplayMember = "Value";
        }

        //SET COMBO BOX TO SELECTION FROM APPTFORM
        private void SelectCustComboBox(string customer)
        {
            for (int i = 0; i < ApptCust.Items.Count; i++)
            {
                string value = ApptCust.GetItemText(ApptCust.Items[i]);
                if (value == customer)
                {
                    ApptCust.SelectedIndex = i;
                    return;
                }
            }
        }

        //CANCEL BUTTON
        private void CancelUpdateApptBtn_Click(object sender, EventArgs e)
        {
            var NewAppt = new ApptForm(UserID);
            NewAppt.Show();
            this.Close();
        }

        //GET THE KEY VALUE FROM THE COMBO BOX WHICH IS THE CUSTOMERID IN THE DATABASE
        private string GetCustIDFromCombo()
        {
            var item = ApptCust.SelectedItem;
            var SelectedCustID = item.GetType().GetProperty("Key").GetValue(item, null);
            return SelectedCustID.ToString();
        }

        //CHECK DATA INPUT AND SUBMIT UPDATES
        private void UpdateApptBtn_Click(object sender, EventArgs e)
        {
            string type;
            string cust = GetCustIDFromCombo();
            string UsID = Convert.ToString(UserID);
            string apptID = Convert.ToString(ApptID);
            DateTime start = StartDate.Value.Date + StartTime.Value.TimeOfDay;
            DateTime end = StartDate.Value.Date + EndTime.Value.TimeOfDay;
            DateTime StartUTC = start.ToUniversalTime();
            DateTime EndUTC = end.ToUniversalTime();
            bool IsValidDate = AppointmentDB.DateIsValid(StartUTC, EndUTC);
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
                Overlaps = AppointmentDB.ApptOverlaps(StartUTC, EndUTC, UsID, apptID);
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
                AppointmentDB.UpdateAppt(apptID, type, cust, StartDB, EndDB);

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

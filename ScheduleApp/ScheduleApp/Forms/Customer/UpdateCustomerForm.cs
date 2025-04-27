using Org.BouncyCastle.Bcpg;
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

namespace ScheduleApp.Forms.Customer
{
    public partial class UpdateCustomerForm : Form
    {
        private readonly int UserID;
        private int CustID;
        public UpdateCustomerForm(IDictionary<int, string> data, int UsID)
        {
            InitializeComponent();
            UserID = UsID;

            //FILL TEXT BOXES WITH SELECTED DATA
            CustID = Convert.ToInt32(data[1]);
            UpdateCustName.Text = data[2];
            UpdateCustPhone.Text = data[3];
            UpdateCustStreet.Text = data[4];
            UpdateCustCity.Text = data[5];
            UpdateCustCountry.Text = data[6];
            UpdateCustZip.Text = data[7];
        }
        //CANCEL BUTTON
        private void CancelUpdateCustBtn_Click(object sender, EventArgs e)
        {
            Close();
            var CustForm = new CustomerForm(UserID);
            CustForm.Show();
        }

        //SAVE BUTTON
        private void UpdateCustBtn_Click(object sender, EventArgs e)
        {
            string name = UpdateCustName.Text.Trim();
            string num = UpdateCustPhone.Text.Trim();
            string street = UpdateCustStreet.Text.Trim();
            string city = UpdateCustCity.Text.Trim();
            string country = UpdateCustCountry.Text.Trim();
            string zip = UpdateCustZip.Text.Trim();

            bool invalid = num.Any(x => x != ' ' && x != '-' && !char.IsDigit(x));

            if (name == string.Empty || num == string.Empty || street == string.Empty
                || city == string.Empty || country == string.Empty || zip == string.Empty)
            {
                MessageBox.Show("All fields must be filled out.", "Missing Information");
                return;
            }
            else if (invalid == true)
            {
                MessageBox.Show("The phone number can only contain numbers and dashes (-).", "Invalid Phone Number");
            }
            else
            {
                CustomerDB.UpdateCust(CustID, name, num, street, city, country, zip);
                Close();
                var CustForm = new CustomerForm(UserID);
                CustForm.Show();
            }
        }
    }
}

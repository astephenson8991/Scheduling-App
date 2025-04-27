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
    public partial class AddCustomerForm : Form
    {
        private readonly int UserID;
        public AddCustomerForm(int UsID)
        {
            InitializeComponent();

            UserID = UsID;
        }
        //CANCEL BUTTON
        private void CancelAddCustBtn_Click(object sender, EventArgs e)
        {
            Close();
            var CustForm = new CustomerForm(UserID);
            CustForm.Show();
        }
        
        //ADD BUTTON
        //CHECK INPUT VALUES THEN CALL ADDCUSTOMER IN CUSTOMERDB
        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            string name = AddCustName.Text.Trim();
            string num = AddCustPhone.Text.Trim();
            string street = AddCustStreet.Text.Trim();
            string city = AddCustCity.Text.Trim();
            string country = AddCustCountry.Text.Trim();
            string zip = AddCustZip.Text.Trim();

            bool invalid = num.Any(x => x != ' ' && x != '-' && !char.IsDigit(x));

            if (name == string.Empty || num == string.Empty || street == string.Empty
                || city == string.Empty || country == string.Empty || zip == string.Empty)
            {
                MessageBox.Show("All fields must be filled out.", "Missing Information");
                return;
            } 
            else if(invalid == true)
            {
                MessageBox.Show("The phone number can only contain numbers and dashes (-).", "Invalid Phone Number");
            }
            else
            {
                CustomerDB.AddCust(name, num, street, city, country, zip);
                Close();
                var CustForm = new CustomerForm(UserID);
                CustForm.Show();
            }
        }
    }
}

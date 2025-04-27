using MySql.Data.MySqlClient;
using ScheduleApp.Database;
using ScheduleApp.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly int UserID;

        //FILL DVG WITH CUSTOMER INFORMATION ON LOAD
        public CustomerForm(int UsID)
        {
            InitializeComponent();
            UserID = UsID;
            RefreshTable();
        }

        //REFRESH TABLE
        private void RefreshTable()
        {
            try
            {
                DataTable dt = CustomerDB.CustData();
                CustView.DataSource = dt;
                CustView.Update();
                CustView.Refresh();
                CustView.Columns[0].Visible = false;
                CustView.Sort(CustView.Columns["Name"], ListSortDirection.Ascending);
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ADD CUSTOMER BUTTON
        private void CustAddBtn_Click(object sender, EventArgs e)
        {
            var AddCust = new AddCustomerForm(UserID);
            AddCust.Show();
            this.Hide();
        }

        //UPDATE CUSTOMER BUTTON
        private void CustUpdateBtn_Click(object sender, EventArgs e)
        {
            IDictionary<int, string> data = new Dictionary<int, string>
            {
                { 1, Convert.ToString(CustView.CurrentRow.Cells[0].Value) },
                { 2, Convert.ToString(CustView.CurrentRow.Cells[1].Value) },
                { 3, Convert.ToString(CustView.CurrentRow.Cells[2].Value) },
                { 4, Convert.ToString(CustView.CurrentRow.Cells[3].Value) },
                { 5, Convert.ToString(CustView.CurrentRow.Cells[4].Value) },
                { 6, Convert.ToString(CustView.CurrentRow.Cells[5].Value) },
                { 7, Convert.ToString(CustView.CurrentRow.Cells[6].Value) }
            };

            var UpdateCust = new UpdateCustomerForm(data, UserID);
            UpdateCust.Show();
            this.Hide();
        }

        //DELETE CUSTOMER BUTTON
        private void CustDeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustView.SelectedRows == null || !CustView.CurrentRow.Selected)
            {
                MessageBox.Show("There is no customer selected.", "No Selection");
                return;
            }

            int id = Convert.ToInt32(CustView.CurrentRow.Cells[0].Value);

            bool HasAppts = CustomerDB.CheckCustAppts(id);
            if (HasAppts)
            {
                MessageBox.Show("There are appointments associated with this customer. Please delete related appointments.", "Error!");
                return;
            }
                var confirmResult = MessageBox.Show("Are you sure to delete this customer?", "Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                CustomerDB.DeleteCust(id);
            }

            RefreshTable();
        }
    }
}

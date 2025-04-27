using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleApp.Forms
{
    public partial class ApptForm : Form
    {
        private readonly int UserID;

        //LOAD FORM AND FILL TABLE
        public ApptForm(int usID)
        {
            InitializeComponent();
            UserID = usID;
            RefreshTable();
            ApptView.Sort(ApptView.Columns["Start"], ListSortDirection.Ascending);
        }

        //GET ALL APPOINTMENTS FOR USER AND CONVERT TO LOCAL TIME
        private void RefreshTable()
        {
            string id = Convert.ToString(UserID);
            try
            {
                DataTable DT = AppointmentDB.ApptData(id);

                DataTable dt =AppointmentDB.LocalTimeDT(DT);

                ApptView.DataSource = dt;
                ApptView.Update();
                ApptView.Refresh();
                ApptView.Columns[0].Visible = false;
                
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ADD APPOINTMENT BUTTON
        private void ApptAddBtn_Click(object sender, EventArgs e)
        {
            Close();
            var AddAppt = new AddApptForm(UserID);
            AddAppt.Show();
        }

        //UPDATE APPOINTMENT BUTTON
        private void ApptUpdateBtn_Click(object sender, EventArgs e)
        {
            int apptID = (int)ApptView.CurrentRow.Cells[0].Value;
            string apptType = (string)ApptView.CurrentRow.Cells[1].Value;
            string customer = (string)ApptView.CurrentRow.Cells[2].Value;
            DateTime start = (DateTime)ApptView.CurrentRow.Cells[3].Value;
            DateTime end = (DateTime)ApptView.CurrentRow.Cells[4].Value;

            Close();
            var UpdateAppt = new UpdateApptForm(UserID, apptID, apptType, customer, start, end);
            UpdateAppt.Show();
        }

        //DELETE APPOINTMENT BUTTON
        private void ApptDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApptView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("There is no appointment selected. Please select one and try again.", "No Selection");
                    return;
                }

                string id = Convert.ToString(ApptView.CurrentRow.Cells[0].Value);
                var confirmResult = MessageBox.Show("Are you sure to delete this appointment?", "Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    AppointmentDB.DeleteAppt(id);
                    RefreshTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        //RESET VIEW TO ALL APPOINTMENTS
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
            ResetBtn.Enabled = false;
            ApptView.Sort(ApptView.Columns["Start"], ListSortDirection.Ascending);
        }

        //SEARCH FOR APPOINTMENTS BASED UPON RADIO BUTTONS AND DATE SELECTED
        private void FindBtn_Click(object sender, EventArgs e)
        {
            string SQLDateString;

            if (DayRadioBtn.Checked)
            {
                DateTime m = MonthCal.SelectionStart;
                string m2 = m.ToString("dd");
                string id = Convert.ToString(UserID);
                SQLDateString = "DAY(appointment.start) = " + m2;

                try
                {
                    DataTable dt = AppointmentDB.ApptFilter(id, SQLDateString);
                    DataTable FilterDT = AppointmentDB.LocalTimeDT(dt);

                    ApptView.DataSource = FilterDT;
                    ApptView.Update();
                    ApptView.Refresh();
                    ApptView.Columns[0].Visible = false;
                    ResetBtn.Enabled = true;
                    ApptView.Sort(ApptView.Columns["Start"], ListSortDirection.Ascending);
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (WeekRadioBtn.Checked)
            {
                DateTime m = MonthCal.SelectionStart;
                string m2 = m.ToString("yyyy-MM-dd");
                string id = Convert.ToString(UserID);
                SQLDateString = "YEARWEEK(appointment.start) = YEARWEEK('" + m2 + "')";

                try
                {
                    DataTable dt = AppointmentDB.ApptFilter(id, SQLDateString);
                    DataTable FilterDT = AppointmentDB.LocalTimeDT(dt);

                    ApptView.DataSource = FilterDT;
                    ApptView.Update();
                    ApptView.Refresh();
                    ApptView.Columns[0].Visible = false;
                    ResetBtn.Enabled = true;
                    ApptView.Sort(ApptView.Columns["Start"], ListSortDirection.Ascending);
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (MonthRadioBtn.Checked)
            {
                DateTime m = MonthCal.SelectionStart;
                string m2 = m.ToString("MM");
                string id = Convert.ToString(UserID);
                SQLDateString = "MONTH(appointment.start) = " + m2;

                try
                {
                    DataTable dt = AppointmentDB.ApptFilter(id, SQLDateString);
                    DataTable FilterDT = AppointmentDB.LocalTimeDT(dt);

                    ApptView.DataSource = FilterDT;
                    ApptView.Update();
                    ApptView.Refresh();
                    ApptView.Columns[0].Visible = false;
                    ResetBtn.Enabled = true;
                    ApptView.Sort(ApptView.Columns["Start"], ListSortDirection.Ascending);
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

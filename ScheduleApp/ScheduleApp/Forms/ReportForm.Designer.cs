namespace ScheduleApp.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportsLink = new System.Windows.Forms.LinkLabel();
            this.ApptPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ApptReportLink = new System.Windows.Forms.LinkLabel();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.SchedReportLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ApptLabel = new System.Windows.Forms.Label();
            this.ReportTextBox = new System.Windows.Forms.RichTextBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.RunApptReport = new System.Windows.Forms.Button();
            this.ReportPanel.SuspendLayout();
            this.ApptPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReportPanel.Controls.Add(this.label3);
            this.ReportPanel.Controls.Add(this.ReportsLink);
            this.ReportPanel.Location = new System.Drawing.Point(12, 338);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(200, 100);
            this.ReportPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of appointmet by customer";
            // 
            // ReportsLink
            // 
            this.ReportsLink.AutoSize = true;
            this.ReportsLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLink.LinkColor = System.Drawing.Color.Black;
            this.ReportsLink.Location = new System.Drawing.Point(38, 36);
            this.ReportsLink.Name = "ReportsLink";
            this.ReportsLink.Size = new System.Drawing.Size(116, 25);
            this.ReportsLink.TabIndex = 3;
            this.ReportsLink.TabStop = true;
            this.ReportsLink.Text = "Customers";
            this.ReportsLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.ReportsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReportsLink_LinkClicked);
            // 
            // ApptPanel
            // 
            this.ApptPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.ApptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ApptPanel.Controls.Add(this.label1);
            this.ApptPanel.Controls.Add(this.ApptReportLink);
            this.ApptPanel.Location = new System.Drawing.Point(12, 62);
            this.ApptPanel.Name = "ApptPanel";
            this.ApptPanel.Size = new System.Drawing.Size(200, 100);
            this.ApptPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of appointments by their type.";
            // 
            // ApptReportLink
            // 
            this.ApptReportLink.AutoSize = true;
            this.ApptReportLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptReportLink.LinkColor = System.Drawing.Color.Black;
            this.ApptReportLink.Location = new System.Drawing.Point(25, 36);
            this.ApptReportLink.Name = "ApptReportLink";
            this.ApptReportLink.Size = new System.Drawing.Size(144, 25);
            this.ApptReportLink.TabIndex = 1;
            this.ApptReportLink.TabStop = true;
            this.ApptReportLink.Text = "Appointments";
            this.ApptReportLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApptReportLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.ApptReportLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ApptReportLink_LinkClicked);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.CustomersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomersPanel.Controls.Add(this.SchedReportLink);
            this.CustomersPanel.Controls.Add(this.label2);
            this.CustomersPanel.Location = new System.Drawing.Point(12, 200);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(200, 100);
            this.CustomersPanel.TabIndex = 3;
            // 
            // SchedReportLink
            // 
            this.SchedReportLink.AutoSize = true;
            this.SchedReportLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedReportLink.LinkColor = System.Drawing.Color.Black;
            this.SchedReportLink.Location = new System.Drawing.Point(21, 36);
            this.SchedReportLink.Name = "SchedReportLink";
            this.SchedReportLink.Size = new System.Drawing.Size(154, 25);
            this.SchedReportLink.TabIndex = 5;
            this.SchedReportLink.TabStop = true;
            this.SchedReportLink.Text = "User Schedule";
            this.SchedReportLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SchedReportLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.SchedReportLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SchedReportLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "View all user\'s schedule.";
            // 
            // ApptLabel
            // 
            this.ApptLabel.AutoSize = true;
            this.ApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptLabel.Location = new System.Drawing.Point(51, 9);
            this.ApptLabel.Name = "ApptLabel";
            this.ApptLabel.Size = new System.Drawing.Size(117, 31);
            this.ApptLabel.TabIndex = 8;
            this.ApptLabel.Text = "Reports";
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTextBox.Location = new System.Drawing.Point(354, 62);
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.Size = new System.Drawing.Size(434, 376);
            this.ReportTextBox.TabIndex = 9;
            this.ReportTextBox.Text = "Your report information will display here.";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(667, 35);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.MonthComboBox.TabIndex = 10;
            this.MonthComboBox.Visible = false;
            // 
            // RunApptReport
            // 
            this.RunApptReport.Location = new System.Drawing.Point(586, 35);
            this.RunApptReport.Name = "RunApptReport";
            this.RunApptReport.Size = new System.Drawing.Size(75, 23);
            this.RunApptReport.TabIndex = 11;
            this.RunApptReport.Text = "Run";
            this.RunApptReport.UseVisualStyleBackColor = true;
            this.RunApptReport.Visible = false;
            this.RunApptReport.Click += new System.EventHandler(this.RunApptReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunApptReport);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.ApptLabel);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.ApptPanel);
            this.Controls.Add(this.CustomersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.ApptPanel.ResumeLayout(false);
            this.ApptPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ReportsLink;
        private System.Windows.Forms.Panel ApptPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ApptReportLink;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.LinkLabel SchedReportLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ApptLabel;
        private System.Windows.Forms.RichTextBox ReportTextBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Button RunApptReport;
    }
}
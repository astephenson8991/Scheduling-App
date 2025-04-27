namespace ScheduleApp.Forms
{
    partial class AddApptForm
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
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.AddApptCust = new System.Windows.Forms.ComboBox();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAptBtn = new System.Windows.Forms.Button();
            this.CancelAddApptBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.ApptType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypeLabel.Location = new System.Drawing.Point(161, 92);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(33, 15);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "Type";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLabel.Location = new System.Drawing.Point(150, 205);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(63, 15);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Start Time";
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy-MM-dd";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(81, 223);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(100, 20);
            this.StartDate.TabIndex = 2;
            // 
            // AddApptCust
            // 
            this.AddApptCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddApptCust.FormattingEnabled = true;
            this.AddApptCust.Location = new System.Drawing.Point(81, 167);
            this.AddApptCust.Name = "AddApptCust";
            this.AddApptCust.Size = new System.Drawing.Size(206, 21);
            this.AddApptCust.TabIndex = 4;
            // 
            // StartTime
            // 
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(187, 223);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(100, 20);
            this.StartTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(153, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(150, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer";
            // 
            // AddAptBtn
            // 
            this.AddAptBtn.Location = new System.Drawing.Point(144, 361);
            this.AddAptBtn.Name = "AddAptBtn";
            this.AddAptBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAptBtn.TabIndex = 5;
            this.AddAptBtn.Text = "Save";
            this.AddAptBtn.UseVisualStyleBackColor = true;
            this.AddAptBtn.Click += new System.EventHandler(this.AddAptBtn_Click);
            // 
            // CancelAddApptBtn
            // 
            this.CancelAddApptBtn.Location = new System.Drawing.Point(144, 401);
            this.CancelAddApptBtn.Name = "CancelAddApptBtn";
            this.CancelAddApptBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelAddApptBtn.TabIndex = 6;
            this.CancelAddApptBtn.Text = "Cancel";
            this.CancelAddApptBtn.UseVisualStyleBackColor = true;
            this.CancelAddApptBtn.Click += new System.EventHandler(this.CancelAddApptBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Appointment";
            // 
            // EndTime
            // 
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(132, 286);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(100, 20);
            this.EndTime.TabIndex = 14;
            // 
            // ApptType
            // 
            this.ApptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptType.FormattingEnabled = true;
            this.ApptType.Items.AddRange(new object[] {
            "Presentation",
            "Scrum",
            "Meeting",
            "Consultation",
            "Other"});
            this.ApptType.Location = new System.Drawing.Point(132, 110);
            this.ApptType.Name = "ApptType";
            this.ApptType.Size = new System.Drawing.Size(100, 21);
            this.ApptType.TabIndex = 15;
            // 
            // AddApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ApptType);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelAddApptBtn);
            this.Controls.Add(this.AddAptBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.AddApptCust);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddApptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.ComboBox AddApptCust;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddAptBtn;
        private System.Windows.Forms.Button CancelAddApptBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.ComboBox ApptType;
    }
}
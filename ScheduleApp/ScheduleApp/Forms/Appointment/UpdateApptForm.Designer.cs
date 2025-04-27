namespace ScheduleApp.Forms
{
    partial class UpdateApptForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.CancelUpdateApptBtn = new System.Windows.Forms.Button();
            this.UpdateApptBtn = new System.Windows.Forms.Button();
            this.ApptType = new System.Windows.Forms.ComboBox();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.ApptCust = new System.Windows.Forms.ComboBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Update Appointment";
            // 
            // CancelUpdateApptBtn
            // 
            this.CancelUpdateApptBtn.Location = new System.Drawing.Point(146, 396);
            this.CancelUpdateApptBtn.Name = "CancelUpdateApptBtn";
            this.CancelUpdateApptBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelUpdateApptBtn.TabIndex = 6;
            this.CancelUpdateApptBtn.Text = "Cancel";
            this.CancelUpdateApptBtn.UseVisualStyleBackColor = true;
            this.CancelUpdateApptBtn.Click += new System.EventHandler(this.CancelUpdateApptBtn_Click);
            // 
            // UpdateApptBtn
            // 
            this.UpdateApptBtn.Location = new System.Drawing.Point(146, 356);
            this.UpdateApptBtn.Name = "UpdateApptBtn";
            this.UpdateApptBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateApptBtn.TabIndex = 5;
            this.UpdateApptBtn.Text = "Save";
            this.UpdateApptBtn.UseVisualStyleBackColor = true;
            this.UpdateApptBtn.Click += new System.EventHandler(this.UpdateApptBtn_Click);
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
            this.ApptType.Location = new System.Drawing.Point(131, 110);
            this.ApptType.Name = "ApptType";
            this.ApptType.Size = new System.Drawing.Size(100, 21);
            this.ApptType.TabIndex = 32;
            // 
            // EndTime
            // 
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTime.Location = new System.Drawing.Point(131, 286);
            this.EndTime.Name = "EndTime";
            this.EndTime.ShowUpDown = true;
            this.EndTime.Size = new System.Drawing.Size(100, 20);
            this.EndTime.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(149, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(152, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "End Time";
            // 
            // StartTime
            // 
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(186, 223);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(100, 20);
            this.StartTime.TabIndex = 26;
            // 
            // ApptCust
            // 
            this.ApptCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApptCust.FormattingEnabled = true;
            this.ApptCust.Location = new System.Drawing.Point(80, 167);
            this.ApptCust.Name = "ApptCust";
            this.ApptCust.Size = new System.Drawing.Size(206, 21);
            this.ApptCust.TabIndex = 27;
            // 
            // StartDate
            // 
            this.StartDate.CustomFormat = "yyyy-MM-dd";
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDate.Location = new System.Drawing.Point(80, 223);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(100, 20);
            this.StartDate.TabIndex = 24;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLabel.Location = new System.Drawing.Point(149, 205);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(63, 15);
            this.TimeLabel.TabIndex = 28;
            this.TimeLabel.Text = "Start Time";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypeLabel.Location = new System.Drawing.Point(160, 92);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(33, 15);
            this.TypeLabel.TabIndex = 25;
            this.TypeLabel.Text = "Type";
            // 
            // UpdateApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ApptType);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.ApptCust);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelUpdateApptBtn);
            this.Controls.Add(this.UpdateApptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UpdateApptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateApptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelUpdateApptBtn;
        private System.Windows.Forms.Button UpdateApptBtn;
        private System.Windows.Forms.ComboBox ApptType;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.ComboBox ApptCust;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TypeLabel;
    }
}
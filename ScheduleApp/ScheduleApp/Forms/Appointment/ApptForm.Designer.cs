namespace ScheduleApp.Forms
{
    partial class ApptForm
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
            this.ApptLabel = new System.Windows.Forms.Label();
            this.ApptView = new System.Windows.Forms.DataGridView();
            this.ApptAddBtn = new System.Windows.Forms.Button();
            this.ApptUpdateBtn = new System.Windows.Forms.Button();
            this.ApptDeleteBtn = new System.Windows.Forms.Button();
            this.MonthCal = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.WeekRadioBtn = new System.Windows.Forms.RadioButton();
            this.MonthRadioBtn = new System.Windows.Forms.RadioButton();
            this.DayRadioBtn = new System.Windows.Forms.RadioButton();
            this.FindBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ApptView)).BeginInit();
            this.SuspendLayout();
            // 
            // ApptLabel
            // 
            this.ApptLabel.AutoSize = true;
            this.ApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptLabel.Location = new System.Drawing.Point(429, 9);
            this.ApptLabel.Name = "ApptLabel";
            this.ApptLabel.Size = new System.Drawing.Size(192, 31);
            this.ApptLabel.TabIndex = 0;
            this.ApptLabel.Text = "Appointments";
            // 
            // ApptView
            // 
            this.ApptView.AllowUserToAddRows = false;
            this.ApptView.AllowUserToDeleteRows = false;
            this.ApptView.AllowUserToOrderColumns = true;
            this.ApptView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApptView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApptView.Location = new System.Drawing.Point(244, 43);
            this.ApptView.MultiSelect = false;
            this.ApptView.Name = "ApptView";
            this.ApptView.ReadOnly = true;
            this.ApptView.RowHeadersVisible = false;
            this.ApptView.RowTemplate.Height = 30;
            this.ApptView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApptView.Size = new System.Drawing.Size(544, 315);
            this.ApptView.TabIndex = 1;
            // 
            // ApptAddBtn
            // 
            this.ApptAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptAddBtn.Location = new System.Drawing.Point(244, 390);
            this.ApptAddBtn.Name = "ApptAddBtn";
            this.ApptAddBtn.Size = new System.Drawing.Size(101, 30);
            this.ApptAddBtn.TabIndex = 2;
            this.ApptAddBtn.Text = "Add";
            this.ApptAddBtn.UseVisualStyleBackColor = true;
            this.ApptAddBtn.Click += new System.EventHandler(this.ApptAddBtn_Click);
            // 
            // ApptUpdateBtn
            // 
            this.ApptUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptUpdateBtn.Location = new System.Drawing.Point(469, 390);
            this.ApptUpdateBtn.Name = "ApptUpdateBtn";
            this.ApptUpdateBtn.Size = new System.Drawing.Size(101, 30);
            this.ApptUpdateBtn.TabIndex = 3;
            this.ApptUpdateBtn.Text = "Update";
            this.ApptUpdateBtn.UseVisualStyleBackColor = true;
            this.ApptUpdateBtn.Click += new System.EventHandler(this.ApptUpdateBtn_Click);
            // 
            // ApptDeleteBtn
            // 
            this.ApptDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptDeleteBtn.Location = new System.Drawing.Point(687, 390);
            this.ApptDeleteBtn.Name = "ApptDeleteBtn";
            this.ApptDeleteBtn.Size = new System.Drawing.Size(101, 30);
            this.ApptDeleteBtn.TabIndex = 4;
            this.ApptDeleteBtn.Text = "Delete";
            this.ApptDeleteBtn.UseVisualStyleBackColor = true;
            this.ApptDeleteBtn.Click += new System.EventHandler(this.ApptDeleteBtn_Click);
            // 
            // MonthCal
            // 
            this.MonthCal.Location = new System.Drawing.Point(5, 146);
            this.MonthCal.MaxSelectionCount = 1;
            this.MonthCal.Name = "MonthCal";
            this.MonthCal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By Date";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Location = new System.Drawing.Point(80, 354);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // WeekRadioBtn
            // 
            this.WeekRadioBtn.AutoSize = true;
            this.WeekRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekRadioBtn.Location = new System.Drawing.Point(5, 90);
            this.WeekRadioBtn.Name = "WeekRadioBtn";
            this.WeekRadioBtn.Size = new System.Drawing.Size(60, 19);
            this.WeekRadioBtn.TabIndex = 9;
            this.WeekRadioBtn.Text = "Week";
            this.WeekRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MonthRadioBtn
            // 
            this.MonthRadioBtn.AutoSize = true;
            this.MonthRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthRadioBtn.Location = new System.Drawing.Point(5, 115);
            this.MonthRadioBtn.Name = "MonthRadioBtn";
            this.MonthRadioBtn.Size = new System.Drawing.Size(65, 19);
            this.MonthRadioBtn.TabIndex = 10;
            this.MonthRadioBtn.Text = "Month";
            this.MonthRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DayRadioBtn
            // 
            this.DayRadioBtn.AutoSize = true;
            this.DayRadioBtn.Checked = true;
            this.DayRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayRadioBtn.Location = new System.Drawing.Point(5, 65);
            this.DayRadioBtn.Name = "DayRadioBtn";
            this.DayRadioBtn.Size = new System.Drawing.Size(49, 19);
            this.DayRadioBtn.TabIndex = 11;
            this.DayRadioBtn.TabStop = true;
            this.DayRadioBtn.Text = "Day";
            this.DayRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(80, 320);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 12;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // ApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.DayRadioBtn);
            this.Controls.Add(this.MonthRadioBtn);
            this.Controls.Add(this.WeekRadioBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthCal);
            this.Controls.Add(this.ApptDeleteBtn);
            this.Controls.Add(this.ApptUpdateBtn);
            this.Controls.Add(this.ApptAddBtn);
            this.Controls.Add(this.ApptView);
            this.Controls.Add(this.ApptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ApptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.ApptView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApptLabel;
        private System.Windows.Forms.DataGridView ApptView;
        private System.Windows.Forms.Button ApptAddBtn;
        private System.Windows.Forms.Button ApptUpdateBtn;
        private System.Windows.Forms.Button ApptDeleteBtn;
        private System.Windows.Forms.MonthCalendar MonthCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.RadioButton WeekRadioBtn;
        private System.Windows.Forms.RadioButton MonthRadioBtn;
        private System.Windows.Forms.RadioButton DayRadioBtn;
        private System.Windows.Forms.Button FindBtn;
    }
}
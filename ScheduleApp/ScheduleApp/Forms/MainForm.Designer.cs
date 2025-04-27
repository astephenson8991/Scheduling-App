namespace ScheduleApp.Forms
{
    partial class MainForm
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
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CustLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ApptPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ApptLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GreetLabel = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CustomersPanel.SuspendLayout();
            this.ApptPanel.SuspendLayout();
            this.ReportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.CustomersPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomersPanel.Controls.Add(this.label2);
            this.CustomersPanel.Controls.Add(this.CustLinkLabel);
            this.CustomersPanel.Location = new System.Drawing.Point(28, 120);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(200, 100);
            this.CustomersPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add and manage your customers.";
            // 
            // CustLinkLabel
            // 
            this.CustLinkLabel.AutoSize = true;
            this.CustLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.CustLinkLabel.Location = new System.Drawing.Point(39, 36);
            this.CustLinkLabel.Name = "CustLinkLabel";
            this.CustLinkLabel.Size = new System.Drawing.Size(116, 25);
            this.CustLinkLabel.TabIndex = 2;
            this.CustLinkLabel.TabStop = true;
            this.CustLinkLabel.Text = "Customers";
            this.CustLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.CustLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustLinkLabel_LinkClicked);
            // 
            // ApptPanel
            // 
            this.ApptPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.ApptPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ApptPanel.Controls.Add(this.label1);
            this.ApptPanel.Controls.Add(this.ApptLinkLabel);
            this.ApptPanel.Location = new System.Drawing.Point(234, 120);
            this.ApptPanel.Name = "ApptPanel";
            this.ApptPanel.Size = new System.Drawing.Size(200, 100);
            this.ApptPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add and manage your appointments.";
            // 
            // ApptLinkLabel
            // 
            this.ApptLinkLabel.AutoSize = true;
            this.ApptLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ApptLinkLabel.Location = new System.Drawing.Point(25, 36);
            this.ApptLinkLabel.Name = "ApptLinkLabel";
            this.ApptLinkLabel.Size = new System.Drawing.Size(144, 25);
            this.ApptLinkLabel.TabIndex = 1;
            this.ApptLinkLabel.TabStop = true;
            this.ApptLinkLabel.Text = "Appointments";
            this.ApptLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApptLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.ApptLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ApptLinkLabel_LinkClicked);
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.ReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReportPanel.Controls.Add(this.label3);
            this.ReportPanel.Controls.Add(this.ReportsLinkLabel);
            this.ReportPanel.Location = new System.Drawing.Point(440, 120);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(200, 100);
            this.ReportPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "View reports about your appointments.";
            // 
            // ReportsLinkLabel
            // 
            this.ReportsLinkLabel.AutoSize = true;
            this.ReportsLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ReportsLinkLabel.Location = new System.Drawing.Point(57, 36);
            this.ReportsLinkLabel.Name = "ReportsLinkLabel";
            this.ReportsLinkLabel.Size = new System.Drawing.Size(86, 25);
            this.ReportsLinkLabel.TabIndex = 3;
            this.ReportsLinkLabel.TabStop = true;
            this.ReportsLinkLabel.Text = "Reports";
            this.ReportsLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReportsLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.ReportsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReportsLinkLabel_LinkClicked);
            // 
            // GreetLabel
            // 
            this.GreetLabel.AutoSize = true;
            this.GreetLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetLabel.Location = new System.Drawing.Point(238, 40);
            this.GreetLabel.Name = "GreetLabel";
            this.GreetLabel.Size = new System.Drawing.Size(196, 31);
            this.GreetLabel.TabIndex = 3;
            this.GreetLabel.Text = "DASHBOARD";
            this.GreetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.LogoutBtn.Location = new System.Drawing.Point(295, 288);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(663, 323);
            this.ControlBox = false;
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CustomersPanel);
            this.Controls.Add(this.ApptPanel);
            this.Controls.Add(this.ReportPanel);
            this.Controls.Add(this.GreetLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.ApptPanel.ResumeLayout(false);
            this.ApptPanel.PerformLayout();
            this.ReportPanel.ResumeLayout(false);
            this.ReportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Panel ApptPanel;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Label GreetLabel;
        private System.Windows.Forms.LinkLabel CustLinkLabel;
        private System.Windows.Forms.LinkLabel ApptLinkLabel;
        private System.Windows.Forms.LinkLabel ReportsLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogoutBtn;
    }
}
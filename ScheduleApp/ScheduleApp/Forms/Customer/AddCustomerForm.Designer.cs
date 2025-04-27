namespace ScheduleApp.Forms.Customer
{
    partial class AddCustomerForm
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
            this.CancelAddCustBtn = new System.Windows.Forms.Button();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddCustName = new System.Windows.Forms.TextBox();
            this.AddCustPhone = new System.Windows.Forms.TextBox();
            this.AddCustStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCustCity = new System.Windows.Forms.TextBox();
            this.AddCustCountry = new System.Windows.Forms.TextBox();
            this.AddCustZip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "New Customer";
            // 
            // CancelAddCustBtn
            // 
            this.CancelAddCustBtn.Location = new System.Drawing.Point(148, 398);
            this.CancelAddCustBtn.Name = "CancelAddCustBtn";
            this.CancelAddCustBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelAddCustBtn.TabIndex = 20;
            this.CancelAddCustBtn.Text = "Cancel";
            this.CancelAddCustBtn.UseVisualStyleBackColor = true;
            this.CancelAddCustBtn.Click += new System.EventHandler(this.CancelAddCustBtn_Click);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(148, 358);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCustBtn.TabIndex = 19;
            this.AddCustBtn.Text = "Save";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(169, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(165, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Street";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLabel.Location = new System.Drawing.Point(138, 120);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(91, 15);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.Text = "Phone Number";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypeLabel.Location = new System.Drawing.Point(163, 82);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(41, 15);
            this.TypeLabel.TabIndex = 14;
            this.TypeLabel.Text = "Name";
            // 
            // AddCustName
            // 
            this.AddCustName.Location = new System.Drawing.Point(135, 100);
            this.AddCustName.Name = "AddCustName";
            this.AddCustName.Size = new System.Drawing.Size(100, 20);
            this.AddCustName.TabIndex = 13;
            this.AddCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCustPhone
            // 
            this.AddCustPhone.Location = new System.Drawing.Point(135, 138);
            this.AddCustPhone.Name = "AddCustPhone";
            this.AddCustPhone.Size = new System.Drawing.Size(100, 20);
            this.AddCustPhone.TabIndex = 14;
            this.AddCustPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCustStreet
            // 
            this.AddCustStreet.Location = new System.Drawing.Point(135, 178);
            this.AddCustStreet.Name = "AddCustStreet";
            this.AddCustStreet.Size = new System.Drawing.Size(100, 20);
            this.AddCustStreet.TabIndex = 15;
            this.AddCustStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(160, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Country";
            // 
            // AddCustCity
            // 
            this.AddCustCity.Location = new System.Drawing.Point(135, 219);
            this.AddCustCity.Name = "AddCustCity";
            this.AddCustCity.Size = new System.Drawing.Size(100, 20);
            this.AddCustCity.TabIndex = 16;
            this.AddCustCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCustCountry
            // 
            this.AddCustCountry.Location = new System.Drawing.Point(135, 259);
            this.AddCustCountry.Name = "AddCustCountry";
            this.AddCustCountry.Size = new System.Drawing.Size(100, 20);
            this.AddCustCountry.TabIndex = 17;
            this.AddCustCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCustZip
            // 
            this.AddCustZip.Location = new System.Drawing.Point(135, 299);
            this.AddCustZip.Name = "AddCustZip";
            this.AddCustZip.Size = new System.Drawing.Size(100, 20);
            this.AddCustZip.TabIndex = 18;
            this.AddCustZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(171, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Zip";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(372, 454);
            this.ControlBox = false;
            this.Controls.Add(this.AddCustZip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddCustCountry);
            this.Controls.Add(this.AddCustCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddCustStreet);
            this.Controls.Add(this.AddCustPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelAddCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AddCustName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelAddCustBtn;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox AddCustName;
        private System.Windows.Forms.TextBox AddCustPhone;
        private System.Windows.Forms.TextBox AddCustStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddCustCity;
        private System.Windows.Forms.TextBox AddCustCountry;
        private System.Windows.Forms.TextBox AddCustZip;
        private System.Windows.Forms.Label label5;
    }
}
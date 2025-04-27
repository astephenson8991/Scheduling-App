namespace ScheduleApp
{
    partial class LoginForm
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
            this.SchedToolLabel = new System.Windows.Forms.Label();
            this.LoginBG = new System.Windows.Forms.Panel();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FailLabel = new System.Windows.Forms.Label();
            this.ExitAppBtn = new System.Windows.Forms.Button();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.LoginBG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchedToolLabel
            // 
            this.SchedToolLabel.AutoSize = true;
            this.SchedToolLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SchedToolLabel.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedToolLabel.ForeColor = System.Drawing.Color.Black;
            this.SchedToolLabel.Location = new System.Drawing.Point(143, 11);
            this.SchedToolLabel.Name = "SchedToolLabel";
            this.SchedToolLabel.Size = new System.Drawing.Size(202, 32);
            this.SchedToolLabel.TabIndex = 0;
            this.SchedToolLabel.Text = "Schedule Tool";
            // 
            // LoginBG
            // 
            this.LoginBG.BackColor = System.Drawing.Color.DarkGray;
            this.LoginBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginBG.Controls.Add(this.ShowPass);
            this.LoginBG.Controls.Add(this.LoginBtn);
            this.LoginBG.Controls.Add(this.PassLabel);
            this.LoginBG.Controls.Add(this.UserLabel);
            this.LoginBG.Controls.Add(this.UserTextBox);
            this.LoginBG.Controls.Add(this.PassTextBox);
            this.LoginBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBG.Location = new System.Drawing.Point(12, 11);
            this.LoginBG.Name = "LoginBG";
            this.LoginBG.Size = new System.Drawing.Size(275, 157);
            this.LoginBG.TabIndex = 1;
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPass.Location = new System.Drawing.Point(85, 106);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(102, 17);
            this.ShowPass.TabIndex = 3;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Location = new System.Drawing.Point(107, 129);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(52, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Submit";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PassLabel.Location = new System.Drawing.Point(102, 62);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(61, 15);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLabel.Location = new System.Drawing.Point(100, 17);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(65, 15);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Username";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(82, 35);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(100, 20);
            this.UserTextBox.TabIndex = 0;
            this.UserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(82, 80);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.Size = new System.Drawing.Size(100, 20);
            this.PassTextBox.TabIndex = 2;
            this.PassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTextBox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LoginBG);
            this.panel1.Location = new System.Drawing.Point(95, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 179);
            this.panel1.TabIndex = 2;
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.ForeColor = System.Drawing.Color.Red;
            this.FailLabel.Location = new System.Drawing.Point(107, 268);
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(275, 13);
            this.FailLabel.TabIndex = 4;
            this.FailLabel.Text = "Username and password did not match. Please try again.";
            this.FailLabel.Visible = false;
            // 
            // ExitAppBtn
            // 
            this.ExitAppBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitAppBtn.Location = new System.Drawing.Point(204, 296);
            this.ExitAppBtn.Name = "ExitAppBtn";
            this.ExitAppBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitAppBtn.TabIndex = 5;
            this.ExitAppBtn.Text = "EXIT";
            this.ExitAppBtn.UseVisualStyleBackColor = true;
            this.ExitAppBtn.Click += new System.EventHandler(this.ExitAppBtn_Click);
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Location = new System.Drawing.Point(12, 9);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(41, 13);
            this.RegionLabel.TabIndex = 6;
            this.RegionLabel.Text = "Region";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(497, 331);
            this.ControlBox = false;
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.ExitAppBtn);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SchedToolLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.LoginBG.ResumeLayout(false);
            this.LoginBG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SchedToolLabel;
        private System.Windows.Forms.Panel LoginBG;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label FailLabel;
        private System.Windows.Forms.CheckBox ShowPass;
        private System.Windows.Forms.Button ExitAppBtn;
        private System.Windows.Forms.Label RegionLabel;
    }
}


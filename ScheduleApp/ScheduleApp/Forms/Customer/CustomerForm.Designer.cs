namespace ScheduleApp.Forms
{
    partial class CustomerForm
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
            this.CustDeleteBtn = new System.Windows.Forms.Button();
            this.CustUpdateBtn = new System.Windows.Forms.Button();
            this.CustAddBtn = new System.Windows.Forms.Button();
            this.CustView = new System.Windows.Forms.DataGridView();
            this.ApptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustDeleteBtn
            // 
            this.CustDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDeleteBtn.Location = new System.Drawing.Point(602, 396);
            this.CustDeleteBtn.Name = "CustDeleteBtn";
            this.CustDeleteBtn.Size = new System.Drawing.Size(101, 30);
            this.CustDeleteBtn.TabIndex = 11;
            this.CustDeleteBtn.Text = "Delete";
            this.CustDeleteBtn.UseVisualStyleBackColor = true;
            this.CustDeleteBtn.Click += new System.EventHandler(this.CustDeleteBtn_Click);
            // 
            // CustUpdateBtn
            // 
            this.CustUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustUpdateBtn.Location = new System.Drawing.Point(348, 396);
            this.CustUpdateBtn.Name = "CustUpdateBtn";
            this.CustUpdateBtn.Size = new System.Drawing.Size(101, 30);
            this.CustUpdateBtn.TabIndex = 10;
            this.CustUpdateBtn.Text = "Update";
            this.CustUpdateBtn.UseVisualStyleBackColor = true;
            this.CustUpdateBtn.Click += new System.EventHandler(this.CustUpdateBtn_Click);
            // 
            // CustAddBtn
            // 
            this.CustAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddBtn.Location = new System.Drawing.Point(98, 396);
            this.CustAddBtn.Name = "CustAddBtn";
            this.CustAddBtn.Size = new System.Drawing.Size(101, 30);
            this.CustAddBtn.TabIndex = 9;
            this.CustAddBtn.Text = "Add";
            this.CustAddBtn.UseVisualStyleBackColor = true;
            this.CustAddBtn.Click += new System.EventHandler(this.CustAddBtn_Click);
            // 
            // CustView
            // 
            this.CustView.AllowUserToAddRows = false;
            this.CustView.AllowUserToDeleteRows = false;
            this.CustView.AllowUserToOrderColumns = true;
            this.CustView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustView.Location = new System.Drawing.Point(98, 77);
            this.CustView.MultiSelect = false;
            this.CustView.Name = "CustView";
            this.CustView.ReadOnly = true;
            this.CustView.RowHeadersVisible = false;
            this.CustView.RowTemplate.Height = 30;
            this.CustView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustView.Size = new System.Drawing.Size(605, 287);
            this.CustView.TabIndex = 8;
            // 
            // ApptLabel
            // 
            this.ApptLabel.AutoSize = true;
            this.ApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptLabel.Location = new System.Drawing.Point(315, 23);
            this.ApptLabel.Name = "ApptLabel";
            this.ApptLabel.Size = new System.Drawing.Size(155, 31);
            this.ApptLabel.TabIndex = 7;
            this.ApptLabel.Text = "Customers";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustDeleteBtn);
            this.Controls.Add(this.CustUpdateBtn);
            this.Controls.Add(this.CustAddBtn);
            this.Controls.Add(this.CustView);
            this.Controls.Add(this.ApptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CustDeleteBtn;
        private System.Windows.Forms.Button CustUpdateBtn;
        private System.Windows.Forms.Button CustAddBtn;
        public System.Windows.Forms.DataGridView CustView;
        private System.Windows.Forms.Label ApptLabel;
    }
}
namespace Password_Manager
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.roundedButton1 = new Password_Manager.Scripts.UI.RoundedButton();
            this.roundedButton2 = new Password_Manager.Scripts.UI.RoundedButton();
            this.roundedButton3 = new Password_Manager.Scripts.UI.RoundedButton();
            this.roundedPanel1 = new Password_Manager.Scripts.UI.RoundedPanel();
            this.roundedPanel2 = new Password_Manager.Scripts.UI.RoundedPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOrPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.roundedButton1.cornerRadiusX = 10;
            this.roundedButton1.cornerRadiusY = 10;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.roundedButton1.Image = global::Password_Manager.Properties.Resources.add_dark;
            this.roundedButton1.Location = new System.Drawing.Point(5, 5);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(44, 37);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.roundedButton2.cornerRadiusX = 10;
            this.roundedButton2.cornerRadiusY = 10;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.roundedButton2.Image = global::Password_Manager.Properties.Resources.remove_dark;
            this.roundedButton2.Location = new System.Drawing.Point(5, 48);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(44, 37);
            this.roundedButton2.TabIndex = 1;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.roundedButton3.cornerRadiusX = 10;
            this.roundedButton3.cornerRadiusY = 10;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.roundedButton3.Image = global::Password_Manager.Properties.Resources.save_dark;
            this.roundedButton3.Location = new System.Drawing.Point(5, 91);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(44, 37);
            this.roundedButton3.TabIndex = 2;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedPanel1.Controls.Add(this.roundedButton1);
            this.roundedPanel1.Controls.Add(this.roundedButton3);
            this.roundedPanel1.Controls.Add(this.roundedButton2);
            this.roundedPanel1.cornerRadiusX = 10;
            this.roundedPanel1.cornerRadiusY = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(4, 3);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(55, 422);
            this.roundedPanel1.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundedPanel2.Controls.Add(this.dataGridView1);
            this.roundedPanel2.cornerRadiusX = 10;
            this.roundedPanel2.cornerRadiusY = 10;
            this.roundedPanel2.Location = new System.Drawing.Point(65, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(741, 422);
            this.roundedPanel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Service, this.EmailOrPhone, this.Password });
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(721, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            // 
            // EmailOrPhone
            // 
            this.EmailOrPhone.HeaderText = "Email (Phone)";
            this.EmailOrPhone.Name = "EmailOrPhone";
            this.EmailOrPhone.Width = 250;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 300;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(810, 428);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Password Manager @jayhook";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn EmailOrPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;

        private System.Windows.Forms.DataGridViewTextBoxColumn Service;

        private System.Windows.Forms.DataGridView dataGridView1;

        private Password_Manager.Scripts.UI.RoundedPanel roundedPanel2;

        private Password_Manager.Scripts.UI.RoundedPanel roundedPanel1;

        private Password_Manager.Scripts.UI.RoundedButton roundedButton2;
        private Password_Manager.Scripts.UI.RoundedButton roundedButton3;

        private Password_Manager.Scripts.UI.RoundedButton roundedButton1;

        #endregion
    }
}
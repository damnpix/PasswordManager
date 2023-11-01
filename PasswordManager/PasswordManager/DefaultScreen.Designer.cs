namespace PasswordManager
{
    partial class DefaultScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultScreen));
            this.tEstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailOrPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedButton3 = new PasswordManager.UI.RoundedButton();
            this.roundedButton2 = new PasswordManager.UI.RoundedButton();
            this.roundedButton1 = new PasswordManager.UI.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tEstToolStripMenuItem
            // 
            this.tEstToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.tEstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesToolStripMenuItem,
            this.tesToolStripMenuItem1});
            this.tEstToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tEstToolStripMenuItem.Name = "tEstToolStripMenuItem";
            this.tEstToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.tEstToolStripMenuItem.Text = "TEst";
            // 
            // tesToolStripMenuItem
            // 
            this.tesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tesToolStripMenuItem.Name = "tesToolStripMenuItem";
            this.tesToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.tesToolStripMenuItem.Text = "tes";
            // 
            // tesToolStripMenuItem1
            // 
            this.tesToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tesToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tesToolStripMenuItem1.Name = "tesToolStripMenuItem1";
            this.tesToolStripMenuItem1.Size = new System.Drawing.Size(89, 22);
            this.tesToolStripMenuItem1.Text = "tes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.EmailOrPhone,
            this.Password});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(49)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(987, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            // 
            // EmailOrPhone
            // 
            this.EmailOrPhone.HeaderText = "Email or phone";
            this.EmailOrPhone.Name = "EmailOrPhone";
            this.EmailOrPhone.Width = 200;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 500;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(49)))));
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton3.Location = new System.Drawing.Point(171, 9);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.RoundX = 15;
            this.roundedButton3.RoundY = 15;
            this.roundedButton3.Size = new System.Drawing.Size(153, 33);
            this.roundedButton3.TabIndex = 6;
            this.roundedButton3.Text = "Remove";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(49)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton2.Location = new System.Drawing.Point(12, 9);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.RoundX = 15;
            this.roundedButton2.RoundY = 15;
            this.roundedButton2.Size = new System.Drawing.Size(153, 33);
            this.roundedButton2.TabIndex = 5;
            this.roundedButton2.Text = "Add";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(49)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roundedButton1.Location = new System.Drawing.Point(330, 9);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.RoundX = 15;
            this.roundedButton1.RoundY = 15;
            this.roundedButton1.Size = new System.Drawing.Size(153, 33);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "Save";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // DefaultScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1011, 512);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultScreen";
            this.Text = "Password Manager @hexsparky";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tEstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailOrPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private UI.RoundedButton roundedButton1;
        private UI.RoundedButton roundedButton2;
        private UI.RoundedButton roundedButton3;
    }
}


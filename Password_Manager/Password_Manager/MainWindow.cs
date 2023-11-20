using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Manager.Scripts.Interaction;

namespace Password_Manager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            DataGridViewStyle();
            if (File.Exists("Data.bin"))
            {
                Functions.LoadAll(dataGridView1);
            }

            roundedButton1.Click += (sender, e) => { Functions.AddPassword(dataGridView1); };
            roundedButton2.Click += (sender, e) => { Functions.RemoveSelectedRow(dataGridView1); };
            roundedButton3.Click += (sender, e) => { Functions.SaveAll(dataGridView1); };
        }

        void DataGridViewStyle()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DefaultCellStyle.BackColor = ColorPalette.Dark_NotificationBackgroundColor();
            dataGridView1.DefaultCellStyle.ForeColor = ColorPalette.Dark_NotificationForegroundColor();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorPalette.Dark_NotificationBackgroundColor();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = ColorPalette.Dark_MessageSecondaryButtonBackgroundColor();
            dataGridView1.DefaultCellStyle.SelectionForeColor = ColorPalette.Dark_MessageSecondaryButtonForegroundColor();
            dataGridView1.BackColor = ColorPalette.Dark_MessageBackgroundColor();
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = ColorPalette.Dark_MessageBackgroundColor();
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = ColorPalette.Dark_MessageSecondaryButtonBackgroundColor();
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.Dark_MessageBackgroundColor();
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.Dark_MessageForegroundColor();
        }
    }
}
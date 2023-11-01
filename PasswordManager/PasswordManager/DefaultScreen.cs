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
using PasswordManager.Class;

namespace PasswordManager
{
    public partial class DefaultScreen : Form
    {
        public DefaultScreen()
        {
            InitializeComponent();

            if (File.Exists("_pass_log_x.bin"))
            {
                LoadBin.Load(dataGridView1);
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            AddPassword.AddPasswordFunction(dataGridView1);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            RemoveSelectedRow.Remove(dataGridView1);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            SaveAll.Save(dataGridView1);
        }
    }
}

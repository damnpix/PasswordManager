using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PasswordManager.Class
{
    internal class RemoveSelectedRow
    {
        public static void Remove(DataGridView _dataGridView)
        {
            if (_dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = _dataGridView.SelectedRows[0];
                _dataGridView.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select one row!");
            }
        }
    }
}

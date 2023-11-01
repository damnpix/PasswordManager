using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Class
{
    internal class SaveAll
    {
        public static void Save(DataGridView _dataGridView)
        {
            string file = "_pass_log_x.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(_dataGridView.Columns.Count);
                bw.Write(_dataGridView.Rows.Count);
                foreach (DataGridViewRow dgvR in _dataGridView.Rows)
                {
                    for (int j = 0; j < _dataGridView.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
                MessageBox.Show("Saved!");
            }
        }
    }
}

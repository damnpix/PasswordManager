using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace PasswordManager.Class
{
    internal class LoadBin
    {

        public static void Load(DataGridView _dataGridView)
        {
            _dataGridView.Rows.Clear();
            string file = "_pass_log_x.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    _dataGridView.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            _dataGridView.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }

    }
}

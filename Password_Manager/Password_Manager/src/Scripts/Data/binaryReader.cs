using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Scripts.Data
{
    public class binaryReader
    {
        public static void Read(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            string file = "Data.bin";
            using (BinaryReader bw = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                int n = bw.ReadInt32();
                int m = bw.ReadInt32();
                for (int i = 0; i < m; ++i)
                {
                    dataGridView.Rows.Add();
                    for (int j = 0; j < n; ++j)
                    {
                        if (bw.ReadBoolean())
                        {
                            dataGridView.Rows[i].Cells[j].Value = bw.ReadString();
                        }
                        else bw.ReadBoolean();
                    }
                }
            }
        }
    }
}
using System.IO;
using System.Windows.Forms;

namespace Password_Manager.Scripts.Data
{
    public class binaryWriter
    {
        public static void Write(DataGridView dataGridView)
        {
            string file = "Data.bin";
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("Data.bin", FileMode.OpenOrCreate)))
            {
                binaryWriter.Write(dataGridView.Columns.Count);
                binaryWriter.Write(dataGridView.Rows.Count);
                foreach (DataGridViewRow dgvR in dataGridView.Rows)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            binaryWriter.Write(false);
                            binaryWriter.Write(false);
                        }
                        else
                        {
                            binaryWriter.Write(true);
                            binaryWriter.Write(val.ToString());
                        }
                    }
                }
                MessageBox.Show("Saved!");
            }
        }
    }
}
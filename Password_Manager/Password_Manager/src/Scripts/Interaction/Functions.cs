using System.Windows.Forms;
using Password_Manager.Scripts.Data;

namespace Password_Manager.Scripts.Interaction
{
    public class Functions
    {
        public static void AddPassword(DataGridView dataGridView)
        {
            dataGridView.Rows.Add("Write service", "Write email or phone number", "Write password");
        }
        
        public static void SaveAll(DataGridView dataGridView)
        {
            binaryWriter.Write(dataGridView);
        }
        
        public static void LoadAll(DataGridView dataGridView)
        {
            binaryReader.Read(dataGridView);
        }
        
        public static void RemoveSelectedRow(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                dataGridView.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Please select one row!");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Class
{
    internal class AddPassword
    {
        static InputBoxItem[] items = new InputBoxItem[] {
                new InputBoxItem("Service"),
                new InputBoxItem("Email or phone number"),
                new InputBoxItem("Password", true)
                };

        public static void AddPasswordFunction(DataGridView _dataGridView)
        {
            InputBox _inputBox = InputBox.Show("Input", items, InputBoxButtons.OK);
            if (_inputBox.Result == InputBoxResult.OK)
            {
                _dataGridView.Rows.Add( _inputBox.Items["Service"].ToString(), _inputBox.Items["Email or phone number"].ToString(), _inputBox.Items["Password"].ToString());
            }
        }
    }
}

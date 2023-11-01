using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PasswordManager.UI
{

    public partial class RoundedButton : Button
    {
        public int RoundX { get; set; } = 10;

        public int RoundY { get; set; } = 10;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr roundedPanel(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public RoundedButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = roundedPanel(0, 0, Width, Height, RoundX, RoundY);
            Region = Region.FromHrgn(ptr);
        }
    }
}

using System.Windows.Forms;
using Password_Manager.Scripts.Data;
using System;
using System.Drawing;

namespace Password_Manager.Scripts.UI
{
    public partial class RoundedButton : Button
    {
        public int cornerRadiusX { get; set; } = 10;
        public int cornerRadiusY { get; set; } = 10;
        
        public RoundedButton()
        {
            InitializeComponent();
            BackColor = ColorPalette.Dark_MessageMainButtonBackgroundColor();
            ForeColor = ColorPalette.Dark_MessageMainButtonForegroundColor();
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(1, 1, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
    }
}
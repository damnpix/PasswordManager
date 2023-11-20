using System.Windows.Forms;
using Password_Manager.Scripts.Data;
using System;
using System.Drawing;


namespace Password_Manager.Scripts.UI
{
    public partial class RoundedPanel : Panel
    {
        public int cornerRadiusX { get; set; } = 10;
        public int cornerRadiusY { get; set; } = 10;
        
        public RoundedPanel()
        {
            InitializeComponent();
            BackColor = ColorPalette.Dark_MessageBackgroundColor();
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            IntPtr ptr = gdi32.CornerRadius(0, 0, Width, Height, cornerRadiusX, cornerRadiusY);
            Region = Region.FromHrgn(ptr);
        }
    }
}
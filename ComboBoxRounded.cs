using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TextBox3
{
    class ComboBoxRounded : ComboBox
    {
        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
        private Brush DropButtonBrush = new SolidBrush(SystemColors.Control);
        private Brush BorderBrush = new SolidBrush(SystemColors.Window);
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.DarkOrange;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        public Color colorTop { get; set; }
        public Color colorBottom { get; set; }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                        var d = FlatStyle == FlatStyle.Popup ? 1 : 0;
                        g.DrawLine(p, Width - buttonWidth - d,
                            0, Width - buttonWidth - d, Height);
                    }
                }
            }
            Graphics gg = this.CreateGraphics();
            GraphicsPath pth = new GraphicsPath();
            PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
            PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
            PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
            pth.AddLine(TopLeft, TopRight);
            pth.AddLine(TopRight, Bottom);
            gg.SmoothingMode = SmoothingMode.HighQuality;
            gg.FillPath(ArrowBrush, pth);
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // coordenada X
            int nTopRect,// coordenada Y
            int nRightRect, // ancho
            int nBottomRect,// altura
            int nheightRect, //altura Elipse 
            int nweightRect //ancho Elipse
        );

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(this.ForeColor);
            LinearGradientBrush lb = new LinearGradientBrush(this.ClientRectangle, colorTop, colorBottom, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, this.ClientRectangle);
            e.Graphics.DrawString(this.Text, this.Font, sb, 0f, 0f);
            sb.Dispose();
            lb.Dispose();
        }

        protected override void OnCreateControl()
        {
            if (IsHandleCreated)
            {
                SetStyle(ControlStyles.UserPaint, true);
            }
            base.OnCreateControl();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(1, 1, this.Width, this.Height-5, 15, 15));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Proyecto_de_Pruebas
{
    class DataGridViewGradient : DataGridView
    {
        public DataGridViewGradient()
        {
            this.BorderStyle = BorderStyle.None;
            this.RowHeadersVisible = false;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised; 
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 243, 243);
            this.EnableHeadersVisualStyles = false;
        }
        protected override void PaintBackground(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle gridBounds)
        { 
            Rectangle rc = new Rectangle(0, 0, Width, Height);

            using (LinearGradientBrush G_Color = new LinearGradientBrush(rc, Color.AliceBlue, Color.LightBlue, System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                G_Color.GammaCorrection = true;

                Color[] _colors = { Color.FromArgb(243,243,243), Color.FromArgb(243, 243, 243), Color.White };
                float[] relativePositions = { 0f, 0.35f, 1f };

                ColorBlend _mixedcolors = new ColorBlend();
                _mixedcolors.Colors = _colors;
                _mixedcolors.Positions = relativePositions;
                G_Color.InterpolationColors = _mixedcolors;
                graphics.FillRectangle(G_Color, rc);
            }
        }
    }
}

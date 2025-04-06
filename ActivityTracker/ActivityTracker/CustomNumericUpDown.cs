using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    internal class CustomNumericUpDown : NumericUpDown
    {
        public CustomNumericUpDown()
        {
            SetStyle(ControlStyles.UserPaint, true);
            Controls[0].Paint += CustomNumericUpDown_Paint;
        }

        private void CustomNumericUpDown_Paint(object sender, PaintEventArgs e)
        {
            Control upDownButtons = Controls[0];
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle upRect = new Rectangle(0, 0, upDownButtons.Width, upDownButtons.Height / 2);
            Rectangle downRect = new Rectangle(0, upDownButtons.Height / 2, upDownButtons.Width, upDownButtons.Height / 2);

            using (SolidBrush upBrush = new SolidBrush(GeneralValues.AccentColor))
            using (SolidBrush downBrush = new SolidBrush(GeneralValues.AccentColor))
            {
                g.FillRectangle(upBrush, upRect);
                g.FillRectangle(downBrush, downRect);
            }

            // Draw up arrow
            Point[] upArrow = {
            new Point(upRect.Left + upRect.Width / 2, upRect.Top + 4),
            new Point(upRect.Left + 4, upRect.Bottom - 4),
            new Point(upRect.Right - 4, upRect.Bottom - 4)
        };

            // Draw down arrow
            Point[] downArrow = {
            new Point(downRect.Left + 4, downRect.Top + 4),
            new Point(downRect.Right - 4, downRect.Top + 4),
            new Point(downRect.Left + downRect.Width / 2, downRect.Bottom - 4)
        };

            g.FillPolygon(new SolidBrush(Color.White), upArrow);
            g.FillPolygon(new SolidBrush(Color.White), downArrow);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            //rect.Inflate(-1, -1); // Fix border clipping

            using (GraphicsPath path = GeneralValues.GetRoundedRectanglePath(rect, GeneralValues.CornerRadius))
            using (SolidBrush gradientBrush = new SolidBrush(GeneralValues.SecondaryBackgroundColor))
            using (Pen borderPen = new Pen(GeneralValues.BorderColor, 1)) // Change border color & thickness
            {
                this.Region = new Region(path);
                g.FillPath(gradientBrush, path); // Fill background
                g.DrawPath(borderPen, path); // Draw border
            }
          
        }

    }
}

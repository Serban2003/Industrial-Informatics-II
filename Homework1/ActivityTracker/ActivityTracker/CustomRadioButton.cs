using System.Drawing.Drawing2D;

namespace ActivityTracker
{
    internal class CustomRadioButton : RadioButton
    {
        private Color checkedColor = GeneralValues.AccentColor;
        private Color unCheckedColor = GeneralValues.BorderColor;

        public Color CheckedColor
        {
            get { return checkedColor; }
            set
            {
                checkedColor = value;
                Invalidate();
            }
        }
        public Color UnCheckedColor
        {
            get { return unCheckedColor; }
            set
            {
                unCheckedColor = value;
                Invalidate();
            }
        }

        public CustomRadioButton()
        {
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 14F;
            float rbCheckSize = 8F;

            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (Height - rbBorderSize) / 2,
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), 
                Y = (Height - rbCheckSize) / 2, 
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(ForeColor))
            {
                graphics.Clear(BackColor);
                
                if (Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                    graphics.FillEllipse(brushRbCheck, rectRbCheck);
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder);
                }
                
                graphics.DrawString(Text, Font, brushText, rbBorderSize + 8, (Height - TextRenderer.MeasureText(Text, Font).Height) / 2);
            }
        }
    }
}

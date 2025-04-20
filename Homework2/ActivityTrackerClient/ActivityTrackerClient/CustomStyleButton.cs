using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    internal class CustomStyleButton : Button
    {
        private bool isHovering;
        private bool isPressed;
        private System.Windows.Forms.Timer transitionTimer;
        private Color currentBackColor;
        private Color targetBackColor;

        public CustomStyleButton(): base()
        {
            base.Font = GeneralValues.BodyFont;
            base.BackColor = Color.Transparent;
            base.ForeColor = GeneralValues.ButtonTextColor;
            base.FlatAppearance.BorderSize = 0;
            base.FlatAppearance.MouseOverBackColor = Color.Transparent;
            base.FlatAppearance.MouseDownBackColor = Color.Transparent;
            base.FlatStyle = FlatStyle.Flat;
            base.Cursor = Cursors.Hand;

            currentBackColor = GeneralValues.AccentColor;

            transitionTimer = new System.Windows.Forms.Timer();
            transitionTimer.Interval = GeneralValues.AnimationTransitionSpeed;
            transitionTimer.Tick += TransitionStep;

            MouseEnter += (s, e) =>
            {
                isHovering = true;
                UpdateTargetColor();
            };
            MouseLeave += (s, e) =>
            {
                isHovering = false;
                isPressed = false;
                UpdateTargetColor();
            };
            MouseDown += (s, e) =>
            {
                isPressed = true;
                UpdateTargetColor();
            };
            MouseUp += (s, e) =>
            {
                isPressed = false;
                UpdateTargetColor();
            };
        }

        private void UpdateTargetColor()
        {
            if(isPressed)
                targetBackColor = GeneralValues.AccentColorPressed;
            else if (isHovering)
                targetBackColor = GeneralValues.AccentColorHover;
            else
                targetBackColor = GeneralValues.AccentColor;

            transitionTimer.Start();
        }

        private void TransitionStep(object sender, EventArgs e)
        {
            int r = Lerp(currentBackColor.R, targetBackColor.R, 0.2f);
            int g = Lerp(currentBackColor.G, targetBackColor.G, 0.2f);
            int b = Lerp(currentBackColor.B, targetBackColor.B, 0.2f);

            Color nextColor = Color.FromArgb(r, g, b);

            if (nextColor == currentBackColor)
            {
                transitionTimer.Stop();
            }

            currentBackColor = nextColor;
            Invalidate();
        }

        private int Lerp(int start, int end, float amount)
        {
            return (int)(start + (end - start) * amount);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            rect.Inflate(-1, -1);

            using (GraphicsPath path = GeneralValues.GetRoundedRectanglePath(rect, GeneralValues.CornerRadius))
            using (SolidBrush gradientBrush = new SolidBrush(currentBackColor))
            using (Pen borderPen = new Pen(GeneralValues.BorderColor, 1))
            {
                g.FillPath(gradientBrush, path);
                g.DrawPath(borderPen, path);
            }
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rect,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}

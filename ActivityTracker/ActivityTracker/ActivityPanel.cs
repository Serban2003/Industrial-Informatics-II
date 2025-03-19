using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityTracker
{
    public enum ActivityType
    {
        Workout,
        Run,
        Hike,
        Bike_Ride
    }

    public class ActivityPanel : Panel
    {
        Activity activity;
        Label titleLabel;
        Label dateLabel;
        Label descriptionLabel;
        Label typeLabel;
        Label durationLabel;
        Label durationValueLabel;
        Label avgHRLabel;
        Label avgHRValueLabel;
        Label caloriesLabel;
        Label caloriesValueLabel;

        public int CornerRadius { get; set; } = 10;
        public Color GradientColor1 {  get; set; } = Color.FromArgb(255, 147, 241, 254);
        public Color GradientColor2 { get; set; } = Color.FromArgb(255, 112, 173, 251);
        public Color CustomBorderColor { get; set; } = Color.FromArgb(255, 204, 228, 244);

        public ActivityPanel(Activity activity)
        {
            this.Size = new Size(570, 100);
            this.Cursor = Cursors.Hand;
            this.activity = activity;
            

            this.titleLabel = new Label();
            titleLabel.Text = activity.Title; 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(10, 10);
            titleLabel.TabIndex = 1;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Outfit", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(titleLabel);

            this.dateLabel = new Label();
            this.dateLabel.Text = activity.Date.ToString("dd MMM yyyy, HH:mm");
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(10, 40);
            dateLabel.TabIndex = 1;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Outfit", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(dateLabel);

            this.typeLabel = new Label();
            typeLabel.Text = " - " + activity.Type.ToString();
            typeLabel.Location = new Point(dateLabel.Width + 5, 40);
            typeLabel.TabIndex = 1;
            typeLabel.BackColor = Color.Transparent;
            typeLabel.Font = new Font("Outfit", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(typeLabel);

            this.descriptionLabel = new Label();
            descriptionLabel.Text = activity.Description;
            descriptionLabel.AutoSize = false;
            descriptionLabel.Width = 250;
            descriptionLabel.Location = new Point(10, 60);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.AutoEllipsis = true;
            this.Controls.Add(descriptionLabel);

            this.durationLabel = new Label();
            durationLabel.Text = "Time";
            durationLabel.AutoSize = false;
            durationLabel.Width = 50;
            durationLabel.TextAlign = ContentAlignment.MiddleCenter;
            durationLabel.Location = new Point(300, 15);
            durationLabel.TabIndex = 1;
            durationLabel.BackColor = Color.Transparent;
            this.Controls.Add(durationLabel);

            this.durationValueLabel = new Label();
            durationValueLabel.Text = activity.FormatedDuration.ToString();
            durationValueLabel.AutoSize = false;
            durationValueLabel.Width = 90;
            durationValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            durationValueLabel.Location = new Point(280, 35);
            durationValueLabel.TabIndex = 1;
            durationValueLabel.BackColor = Color.Transparent;
            durationValueLabel.Font = new Font("Outfit", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(durationValueLabel);

            this.avgHRLabel = new Label();
            avgHRLabel.Text = "Avg HR";
            avgHRLabel.AutoSize = false;
            avgHRLabel.Width = 70;
            avgHRLabel.TextAlign = ContentAlignment.MiddleCenter;
            avgHRLabel.Location = new Point(durationLabel.Location.X + durationLabel.Width + 40, 15);
            avgHRLabel.TabIndex = 1;
            avgHRLabel.BackColor = Color.Transparent;
            this.Controls.Add(avgHRLabel);

            this.avgHRValueLabel = new Label();
            avgHRValueLabel.Text = activity.AvgHR.ToString() + " bpm";
            avgHRValueLabel.AutoSize = false;
            avgHRValueLabel.Width = 90;
            avgHRValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            avgHRValueLabel.Location = new Point(durationLabel.Location.X + durationLabel.Width + (40 - (avgHRValueLabel.Width - avgHRLabel.Width) / 2), 35);
            avgHRValueLabel.TabIndex = 1;
            avgHRValueLabel.BackColor = Color.Transparent;
            avgHRValueLabel.Font = new Font("Outfit", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(avgHRValueLabel);

            this.caloriesLabel = new Label();
            caloriesLabel.Text = "Cal";
            caloriesLabel.AutoSize = false;
            caloriesLabel.Width = 50;
            caloriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            caloriesLabel.Location = new Point(avgHRLabel.Location.X + avgHRLabel.Width + 40, 15);
            caloriesLabel.TabIndex = 1;
            caloriesLabel.BackColor = Color.Transparent;
            this.Controls.Add(caloriesLabel);

            this.caloriesValueLabel = new Label();
            caloriesValueLabel.Text = activity.Calories.ToString() + " Cal";
            caloriesValueLabel.AutoSize = false;
            caloriesValueLabel.Width = 70;
            caloriesValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            caloriesValueLabel.Location = new Point(avgHRLabel.Location.X + avgHRLabel.Width + (40 - (caloriesValueLabel.Width - caloriesLabel.Width) / 2), 35);
            caloriesValueLabel.TabIndex = 1;
            caloriesValueLabel.BackColor = Color.Transparent;
            caloriesValueLabel.Font = new Font("Outfit", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Controls.Add(caloriesValueLabel);
        }
        [System.ComponentModel.DefaultValue(typeof(DockStyle), "Fill")]
        public override DockStyle Dock
        {
            get { return base.Dock; }
            set { base.Dock = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, CornerRadius))
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, GradientColor1, GradientColor2, LinearGradientMode.ForwardDiagonal))
            using (Pen borderPen = new Pen(CustomBorderColor, 1)) // Change border color & thickness
            {
                g.FillPath(gradientBrush, path); // Fill background
                g.DrawPath(borderPen, path); // Draw border
            }
        }
        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90); // Top-left corner
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90); // Top-right corner
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90); // Bottom-left
            path.CloseFigure();
            return path;
        }
    }
}
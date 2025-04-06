using System.Drawing.Drawing2D;

namespace ActivityTracker
{
    public class ActivityPanel : TableLayoutPanel
    {        
        Activity activity;
        Label titleLabel;
        Label dateLabel;
        Label descriptionLabel;
        TableLayoutPanel statsTableLayoutPanel;

        public ActivityPanel(Activity activity)
        {
            // ActivityPanel
            this.activity = activity;
            Dock = DockStyle.Top;
            AutoSize = true;
            Cursor = Cursors.Hand;
            Padding = new Padding(GeneralValues.PaddingValue);
            Font = GeneralValues.BodyFont;
            ForeColor = GeneralValues.PrimaryTextColor;
            Click += new EventHandler(openActivityForm);

            // titlePanel
            titleLabel = new Label();
            titleLabel.Text = activity.Title; 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = GeneralValues.TitleFont;
            Controls.Add(titleLabel);
        
            // dateLabel
            dateLabel = new Label();
            dateLabel.Text = activity.Date.ToString("dd MMM yyyy, HH: mm") + " - " + activity.Type.ToString();;
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = GeneralValues.BodyFontSmall;
            dateLabel.ForeColor = GeneralValues.SecondaryTextColor;
            Controls.Add(dateLabel);
            
            // descriptionLabel
            descriptionLabel = new Label();
            descriptionLabel.Text = activity.Description;
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Margin = new Padding(0, GeneralValues.PaddingValue, 0, 0);
            Controls.Add(descriptionLabel);

            // statsTableLayoutPanel
            statsTableLayoutPanel = new TableLayoutPanel();
            statsTableLayoutPanel.ColumnCount = 4;
            statsTableLayoutPanel.RowCount = 2;
            statsTableLayoutPanel.Anchor = AnchorStyles.None;
            statsTableLayoutPanel.Dock = DockStyle.Fill;
            statsTableLayoutPanel.AutoSize = true;
            statsTableLayoutPanel.BackColor = Color.Transparent;
            statsTableLayoutPanel.Margin = new Padding(0, GeneralValues.PaddingValue, 0, 0);
            Controls.Add(statsTableLayoutPanel);

            for (int i = 0; i < statsTableLayoutPanel.ColumnCount; ++i)
                statsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int i = 0; i < statsTableLayoutPanel.RowCount; ++i)
                statsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            createActivityFields("Duration", activity.FormatedDuration, "", 0);
            createActivityFields("Avg HR", activity.AvgHR.ToString(), "bpm", 1);
            createActivityFields("Cal", activity.Calories.ToString(), "Cal", 2);
        }

        public ActivityPanel(HikeActivity activity) : this((Activity)activity)
        {
            this.activity = activity;
            createActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
        }
        public ActivityPanel(RunActivity activity) : this((Activity)activity)
        {
            this.activity = activity;
            createActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
        }
        public ActivityPanel(BikeRideActivity activity) : this((Activity)activity)
        {
            this.activity = activity;
            createActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
        }
        public ActivityPanel(WorkoutActivity activity) : this((Activity)activity)
        {
            this.activity = activity;
            createActivityFields("No. of Sets", activity.NumberOfSets.ToString(), "", 3);
        }

        private void createActivityFields(String title, String value, String unit, Int32 position)
        {
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.AutoSize = true;
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.BackColor = Color.Transparent;
            statsTableLayoutPanel.Controls.Add(titleLabel, position, 0);

            Label valueLabel = new Label();
            valueLabel.Text = value + " " + unit;
            valueLabel.Anchor = AnchorStyles.None;
            valueLabel.AutoSize = true;
            valueLabel.BackColor = Color.Transparent;
            valueLabel.Font = GeneralValues.SubtitleFont;
            statsTableLayoutPanel.Controls.Add(valueLabel, position, 1);
        }

        private void openActivityForm(Object obj, EventArgs e)
        {
            ActivityForm activityForm = new ActivityForm(activity);
            activityForm.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            rect.Inflate(-1, -1);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, GeneralValues.CornerRadius))
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, GeneralValues.GradientColor1, GeneralValues.GradientColor2, LinearGradientMode.ForwardDiagonal))
            using (Pen borderPen = new Pen(GeneralValues.BorderColor, 1)) // Change border color & thickness
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
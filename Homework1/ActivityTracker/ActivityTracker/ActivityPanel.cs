using System.Drawing.Drawing2D;

namespace ActivityTracker
{
    public class ActivityPanel : TableLayoutPanel
    {        
        Label titleLabel;
        Label dateLabel;
        Label descriptionLabel;
        TableLayoutPanel statsTableLayoutPanel;

        public ActivityPanel(Activity activity)
        {
            // ActivityPanel
            Dock = DockStyle.Top;
            AutoSize = true;
            Cursor = Cursors.Hand;
            Padding = new Padding(GeneralValues.PaddingValue);
            Font = GeneralValues.BodyFont;
            ForeColor = GeneralValues.PrimaryTextColor;

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

            CreateActivityFields("Duration", activity.FormatedDuration, "", 0);
            CreateActivityFields("Avg HR", activity.AvgHR.ToString(), "bpm", 1);
            CreateActivityFields("Cal", activity.Calories.ToString(), "Cal", 2);
        }

        public ActivityPanel(HikeActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
            Click += (sender, e) => {
                new ActivityForm(activity).ShowDialog();
            };
        }
        public ActivityPanel(RunActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
            Click += (sender, e) => {
                new ActivityForm(activity).ShowDialog();
            };
        }
        public ActivityPanel(BikeRideActivity activity) : this((Activity)activity)
        {

            CreateActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
            Click += (sender, e) => {
                new ActivityForm(activity).ShowDialog();
            };
        }
        public ActivityPanel(WorkoutActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("No. of Sets", activity.NumberOfSets.ToString(), "", 3);
            Click += (sender, e) => {
                new ActivityForm(activity).ShowDialog();
            };
        }

        private void CreateActivityFields(String title, String value, String unit, Int32 position)
        {
            // titleLabel
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.AutoSize = true;
            titleLabel.Anchor = AnchorStyles.None;
            titleLabel.BackColor = Color.Transparent;
            statsTableLayoutPanel.Controls.Add(titleLabel, position, 0);

            // valueLabel
            Label valueLabel = new Label();
            valueLabel.Text = value + " " + unit;
            valueLabel.Anchor = AnchorStyles.None;
            valueLabel.AutoSize = true;
            valueLabel.BackColor = Color.Transparent;
            valueLabel.Font = GeneralValues.SubtitleFont;
            statsTableLayoutPanel.Controls.Add(valueLabel, position, 1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width, Height);
            rect.Inflate(-1, -1);
            using (GraphicsPath path = GeneralValues.GetRoundedRectanglePath(rect, GeneralValues.CornerRadius))
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, GeneralValues.GradientColor1, GeneralValues.GradientColor2, LinearGradientMode.ForwardDiagonal))
            using (Pen borderPen = new Pen(GeneralValues.BorderColor, 1))
            {
                g.FillPath(gradientBrush, path); 
                g.DrawPath(borderPen, path); 
            }
        }
    }
}
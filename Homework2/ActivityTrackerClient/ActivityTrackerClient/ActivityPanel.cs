using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ActivityTrackerClient
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

            Click += (sender, e) =>
            {
                new ActivityForm(activity).ShowDialog();
            };

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
            statsTableLayoutPanel.Padding = new Padding(0, GeneralValues.PaddingValue, 0, 0);
            statsTableLayoutPanel.CellPaint += CustomCellPaint;
            Controls.Add(statsTableLayoutPanel);

            for (int i = 0; i < statsTableLayoutPanel.ColumnCount; ++i)
                statsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            for (int i = 0; i < statsTableLayoutPanel.RowCount; ++i)
                statsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            CreateActivityFields("Duration", activity.Duration.ToString(), "", 0);
            CreateActivityFields("Avg HR", activity.AvgHR.ToString(), "bpm", 1);
            CreateActivityFields("Cal", activity.Calories.ToString(), "Cal", 2);

            if(activity.Type == Activity.ActivityType.Workout)
            {
                CreateActivityFields("No. of Sets", activity.NumberOfSets.ToString(), "", 3);
            }
            else CreateActivityFields("Distance", activity.Distance.ToString(), "Km", 3);
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
        private void CustomCellPaint(Object sender, TableLayoutCellPaintEventArgs e)
        {
            var panel = sender as TableLayoutPanel;
            if (e.Row == 0)
            {
                using (var pen = new Pen(GeneralValues.AccentColor, 2))
                {
                    if (e.Column == 1)
                    {
                        int topY = e.CellBounds.Top;
                        e.Graphics.DrawLine(pen, 0, topY - GeneralValues.PaddingValue / 2, 1.5F * panel.GetColumnWidths()[0], topY - GeneralValues.PaddingValue / 2);
                    }
                }
            }
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
namespace ActivityTracker
{
    public partial class ActivityForm : Form
    {
        TableLayoutPanel mainTableLayoutPanel;
        Label activityTitleLabel;
        Label activityDescriptionLabel;
        Label activityDateLabel;

        public ActivityForm(Activity activity)
        {
            InitializeComponent();

            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.Padding = new Padding(GeneralValues.PaddingValue);
            mainTableLayoutPanel.BackColor = GeneralValues.PrimaryBackgroundColor;
            Controls.Add(mainTableLayoutPanel);

            activityTitleLabel = new Label();
            activityTitleLabel.Text = activity.Title;
            activityTitleLabel.Font = GeneralValues.TitleFont;
            activityTitleLabel.AutoSize = true;

            mainTableLayoutPanel.Controls.Add(activityTitleLabel, 0, 0);
            mainTableLayoutPanel.SetColumnSpan(activityTitleLabel, 3);

            activityDateLabel = new Label();
            activityDateLabel.Text = activity.Date.ToString("dd MMM yyyy, HH:mm") + " - " + activity.Type.ToString();
            activityDateLabel.Font = GeneralValues.BodyFontSmall;
            activityDateLabel.AutoSize = true;
            activityDateLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);

            mainTableLayoutPanel.Controls.Add(activityDateLabel, 0, 1);
            mainTableLayoutPanel.SetColumnSpan(activityDateLabel, 3);

            activityDescriptionLabel = new Label();
            activityDescriptionLabel.Text = activity.Description;
            activityDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);

            mainTableLayoutPanel.Controls.Add(activityDescriptionLabel, 0, 2);
            mainTableLayoutPanel.SetColumnSpan(activityDescriptionLabel, 3);

            Panel dividerPanel = new Panel();
            dividerPanel.Height = 2;
            dividerPanel.BackColor = GeneralValues.AccentColor;
            dividerPanel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);

            mainTableLayoutPanel.Controls.Add(dividerPanel, 0, 3);
            mainTableLayoutPanel.SetColumnSpan(dividerPanel, 3);

            mainTableLayoutPanel.RowCount = 4;

            createActivityFields("Duration", activity.FormatedDuration, "(hh:mm:ss)");
            createActivityFields("Calories", activity.Calories.ToString(), "Cals");
            createActivityFields("Average Heart Rate", activity.Calories.ToString(), "bpm");
        }

        public ActivityForm(RunActivity activity) : this((Activity)activity)
        {
            createActivityFields("Distance", activity.Distance.ToString(), "Km");
            createActivityFields("Elevation", activity.Elevation.ToString(), "m");
            createActivityFields("Average Pace", activity.FormatedAvgPace, "min/Km");
            createActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
        }
        public ActivityForm(HikeActivity activity) : this((Activity)activity)
        {
            createActivityFields("Distance", activity.Distance.ToString(), "Km");
            createActivityFields("Elevation", activity.Elevation.ToString(), "m");
            createActivityFields("Average Pace", activity.FormatedAvgPace, "min/Km");
            createActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
        }
        public ActivityForm(BikeRideActivity activity) : this((Activity)activity)
        {
            createActivityFields("Distance", activity.Distance.ToString(), "Km");
            createActivityFields("Elevation", activity.Elevation.ToString(), "m");
            createActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
        }
        public ActivityForm(WorkoutActivity activity) : this((Activity)activity)
        {
            createActivityFields("Distance", activity.NumberOfSets.ToString(), "");
        }

        private void createActivityFields(String title, String value, String unit)
        {
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = GeneralValues.BodyFont;
            titleLabel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(titleLabel, 0, mainTableLayoutPanel.RowCount);

            Label dividerLabel = new Label();
            dividerLabel.Text = "•";
            dividerLabel.Font = GeneralValues.BodyFont;
            dividerLabel.AutoSize = true;
            dividerLabel.ForeColor = GeneralValues.AccentColor;
            mainTableLayoutPanel.Controls.Add(dividerLabel, 1, mainTableLayoutPanel.RowCount);

            Label valueLabel = new Label();
            valueLabel.Text = value + " " + unit;
            valueLabel.Font = GeneralValues.BodyFont;
            valueLabel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(valueLabel, 2, mainTableLayoutPanel.RowCount);

            mainTableLayoutPanel.RowCount += 1;
        }
    }
}

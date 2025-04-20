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

            // mainTableLayout
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.ColumnCount = 4;
            mainTableLayoutPanel.Padding = new Padding(GeneralValues.PaddingValue);
            mainTableLayoutPanel.BackColor = GeneralValues.PrimaryBackgroundColor;
            Controls.Add(mainTableLayoutPanel);

            // activityTitleLabel
            activityTitleLabel = new Label();
            activityTitleLabel.Text = activity.Title;
            activityTitleLabel.Font = GeneralValues.TitleFont;
            activityTitleLabel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(activityTitleLabel, 0, 0);
            mainTableLayoutPanel.SetColumnSpan(activityTitleLabel, 3);

            // activityDateLabel
            activityDateLabel = new Label();
            activityDateLabel.Text = activity.Date.ToString("dd MMM yyyy, HH:mm") + " - " + activity.Type.ToString();
            activityDateLabel.Font = GeneralValues.BodyFontSmall;
            activityDateLabel.AutoSize = true;
            activityDateLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(activityDateLabel, 0, 1);
            mainTableLayoutPanel.SetColumnSpan(activityDateLabel, 3);

            // activityDescriptionLabel
            activityDescriptionLabel = new Label();
            activityDescriptionLabel.Text = activity.Description;
            activityDescriptionLabel.Font = GeneralValues.SubtitleFont;
            activityDescriptionLabel.AutoSize = true;
            activityDescriptionLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(activityDescriptionLabel, 0, 2);
            mainTableLayoutPanel.SetColumnSpan(activityDescriptionLabel, 3);

            // dividerPanel
            Panel dividerPanel = new Panel();
            dividerPanel.Height = 2;
            dividerPanel.BackColor = GeneralValues.AccentColor;
            dividerPanel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(dividerPanel, 0, 3);
            mainTableLayoutPanel.SetColumnSpan(dividerPanel, 3);

            mainTableLayoutPanel.RowCount = 4;

            CreateActivityFields("Duration", activity.FormatedDuration, "(hh:mm:ss)");
            CreateActivityFields("Calories", activity.Calories.ToString(), "Cals");
            CreateActivityFields("Average Heart Rate", activity.AvgHR.ToString(), "bpm");
        }

        public ActivityForm(RunActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("Distance", activity.Distance.ToString(), "Km");
            CreateActivityFields("Elevation", activity.Elevation.ToString(), "m");
            CreateActivityFields("Average Pace", activity.FormatedAvgPace, "min/Km");
            CreateActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
            CreateGPXMap(activity.GpxFile);
        }
        public ActivityForm(HikeActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("Distance", activity.Distance.ToString(), "Km");
            CreateActivityFields("Elevation", activity.Elevation.ToString(), "m");
            CreateActivityFields("Average Pace", activity.FormatedAvgPace, "min/Km");
            CreateActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
            CreateGPXMap(activity.GpxFile);
        }
        public ActivityForm(BikeRideActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("Distance", activity.Distance.ToString(), "Km");
            CreateActivityFields("Elevation", activity.Elevation.ToString(), "m");
            CreateActivityFields("Average Speed", activity.AvgSpeed.ToString(), "Km/h");
            CreateGPXMap(activity.GpxFile);
        }
        public ActivityForm(WorkoutActivity activity) : this((Activity)activity)
        {
            CreateActivityFields("No. of Sets", activity.NumberOfSets.ToString(), "");
        }

        private void CreateActivityFields(String title, String value, String unit)
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

        private void CreateGPXMap(String gpxFile)
        {
            // gpcMapLabel
            Label gpxMapLabel = new Label();
            gpxMapLabel.Font = GeneralValues.BodyFont;
            gpxMapLabel.AutoSize = true;

            if (gpxFile == null || gpxFile == "") { 
                gpxMapLabel.Text = "No GPX data available!";
                mainTableLayoutPanel.Controls.Add(gpxMapLabel, 0, mainTableLayoutPanel.RowCount);
                mainTableLayoutPanel.RowCount += 1;
                mainTableLayoutPanel.SetColumnSpan(gpxMapLabel, 3);
            }
            else
            {
                gpxMapLabel.Text = "GPX Map";
                gpxMapLabel.Padding = new Padding(0, 0, 0, 5);
                mainTableLayoutPanel.Controls.Add(gpxMapLabel, 3, 4);

                // gpxPanel
                GPXPanel gpxPanel = new GPXPanel(gpxFile);
                mainTableLayoutPanel.Controls.Add(gpxPanel, 3, 5);
                mainTableLayoutPanel.SetRowSpan(gpxPanel, mainTableLayoutPanel.RowCount);

                mainTableLayoutPanel.RowCount += 1;
            }
        }
    }
}

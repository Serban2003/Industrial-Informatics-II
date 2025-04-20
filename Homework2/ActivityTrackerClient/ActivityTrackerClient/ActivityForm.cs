using System;
using System.ServiceModel.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace ActivityTrackerClient
{
    public partial class ActivityForm : Form
    {
        Activity activity;
        TableLayoutPanel mainTableLayoutPanel;
        Label activityTitleLabel;
        Label activityDescriptionLabel;
        Label activityDateLabel;
        Button deleteActivityButton;

        public ActivityForm(Activity activity)
        {
            InitializeComponent();
            this.activity = activity;

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

            // deleteActivityButton
            deleteActivityButton = new CustomStyleButton();
            deleteActivityButton.Text = "Delete Activity";
            deleteActivityButton.AutoSize = true;
            deleteActivityButton.Anchor = AnchorStyles.Right;
            deleteActivityButton.Font = GeneralValues.BodyFont;
            deleteActivityButton.Click += DeleteActivity;
            mainTableLayoutPanel.Controls.Add(deleteActivityButton, 3, 0);

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

            CreateActivityFields("Duration", activity.Duration.ToString(), "(hh:mm:ss)");
            CreateActivityFields("Calories", activity.Calories.ToString(), "Cals");
            CreateActivityFields("Average Heart Rate", activity.AvgHR.ToString(), "bpm");

            if (activity.Type == Activity.ActivityType.Workout)
            {
                CreateActivityFields("No. of Sets", activity.NumberOfSets.ToString(), "");
            }
            else if (activity.Type == Activity.ActivityType.Bike_Ride)
            {
                CreateActivityFields("Distance", activity.Distance.ToString(), "Km");
                CreateActivityFields("Elevation", activity.Elevation.ToString(), "m");
                CreateActivityFields("Average Speed", activity.GetAvgSpeed(), "Km/h");
                CreateGPXMap(activity.GpxFile);
            }
            else
            {
                CreateActivityFields("Distance", activity.Distance.ToString(), "Km");
                CreateActivityFields("Elevation", activity.Elevation.ToString(), "m");
                CreateActivityFields("Average Pace", activity.GetAvgPace(), "min/Km");
                CreateActivityFields("Average Speed", activity.GetAvgSpeed(), "Km/h");
                CreateGPXMap(activity.GpxFile);
            }
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
            XmlDocument gpxDoc = new XmlDocument();

            try
            {
                gpxDoc.Load(gpxFile);
                gpxMapLabel.Text = "GPX Map";
                gpxMapLabel.Padding = new Padding(0, 0, 0, 5);
                mainTableLayoutPanel.Controls.Add(gpxMapLabel, 3, 4);

                // gpxPanel
                GPXPanel gpxPanel = new GPXPanel(gpxDoc);
                mainTableLayoutPanel.Controls.Add(gpxPanel, 3, 5);
                mainTableLayoutPanel.SetRowSpan(gpxPanel, mainTableLayoutPanel.RowCount);

                mainTableLayoutPanel.RowCount += 1;
            }
            catch
            {
                gpxMapLabel.Text = "No GPX data available!";
                mainTableLayoutPanel.Controls.Add(gpxMapLabel, 0, mainTableLayoutPanel.RowCount);
                mainTableLayoutPanel.RowCount += 1;
                mainTableLayoutPanel.SetColumnSpan(gpxMapLabel, 3);
            }
        }

        private void DeleteActivity(Object o, EventArgs e)
        {
            if (Program.service.DeleteActivity(activity.A_Id))
            {
                MessageBox.Show("Activity deleted!");
                ActivityTracker.UpdateUI();
                Close();
            }
            else
            {
                MessageBox.Show("Couldn't delete activity!");
            }
        }
    }
}

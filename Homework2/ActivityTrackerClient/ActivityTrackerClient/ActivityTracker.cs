using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    public partial class ActivityTracker : Form
    {
        TableLayoutPanel mainTableLayoutPanel;
        MenuStrip mainMenuStrip;
        static ToolStripMenuItem uploadActivityStripMenuItem;
        static ToolStripMenuItem loginUserStripMenuItem;
        FlowLayoutPanel activityTypeFilterFlowLayoutPanel;
        Label activityTypeFilterLabel;
        static ComboBox activityTypeFilterComboBox;
        Label activitiesTitle;
        static TableLayoutPanel activitiesTableLayoutPanel;
        static Label noActivitiesLabel;

        public ActivityTracker()
        {
            //CreateFileWatcher(GeneralValues.AppFolder);
            InitializeComponent();

            // ActivityTracker
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;
            Font = GeneralValues.BodyFont;

            // uploadActivityStripMenuItem
            uploadActivityStripMenuItem = new ToolStripMenuItem();
            uploadActivityStripMenuItem.AutoSize = true;
            uploadActivityStripMenuItem.Text = "Upload Activity";
            uploadActivityStripMenuItem.Click += new EventHandler(ShowUploadActivityForm);

            // loginUserStripMenuItem
            loginUserStripMenuItem = new ToolStripMenuItem();
            loginUserStripMenuItem.AutoSize = true;
            loginUserStripMenuItem.Text = "Login";
            loginUserStripMenuItem.Click += new EventHandler(ShowUserForm);

            // mainMenuStrip
            mainMenuStrip = new MenuStrip();
            mainMenuStrip.Items.AddRange(new ToolStripItem[] {uploadActivityStripMenuItem, loginUserStripMenuItem});
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Text = "Main Menu";
            mainMenuStrip.Font = GeneralValues.BodyFontSmall;
            mainMenuStrip.ForeColor = GeneralValues.PrimaryTextColor;
            mainMenuStrip.Cursor = Cursors.Hand;
            mainMenuStrip.Renderer = new MenuStripRenderer();
            Controls.Add(mainMenuStrip);

            // mainFlowLayoutPanel
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Padding = new Padding(GeneralValues.PaddingValue, GeneralValues.PaddingValue + mainMenuStrip.Size.Height, GeneralValues.PaddingValue, GeneralValues.PaddingValue);
            Controls.Add(mainTableLayoutPanel);

            // activitiesTitle
            activitiesTitle = new Label();
            activitiesTitle.AutoSize = true;
            activitiesTitle.Font = GeneralValues.TitleFont;
            activitiesTitle.Text = "Your activities";
            mainTableLayoutPanel.Controls.Add(activitiesTitle, 0, 0);

            // activityTypeFilterFlowLayoutPanel
            activityTypeFilterFlowLayoutPanel = new FlowLayoutPanel();
            activityTypeFilterFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            activityTypeFilterFlowLayoutPanel.AutoSize = true;
            activityTypeFilterFlowLayoutPanel.Anchor = AnchorStyles.Right;
            mainTableLayoutPanel.Controls.Add(activityTypeFilterFlowLayoutPanel, 1, 0);

            // activityTypeFilterLabel
            activityTypeFilterLabel = new Label();
            activityTypeFilterLabel.AutoSize = true;
            activityTypeFilterLabel.Text = "Filter: ";
            activityTypeFilterLabel.Anchor = AnchorStyles.None;
            activityTypeFilterFlowLayoutPanel.Controls.Add(activityTypeFilterLabel);

            // activityTypeFilterComboBox
            activityTypeFilterComboBox = new CustomComboBox();
            activityTypeFilterComboBox.AutoSize = true;
            activityTypeFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            activityTypeFilterComboBox.Anchor = AnchorStyles.None;
            activityTypeFilterFlowLayoutPanel.Controls.Add(activityTypeFilterComboBox);

            foreach (Activity.ActivityType type in Enum.GetValues(typeof(Activity.ActivityType)))
                activityTypeFilterComboBox.Items.Add(type);

            activityTypeFilterComboBox.SelectedIndex = 0;
            activityTypeFilterComboBox.SelectedIndexChanged += FilterActivities;

            // activitiesTableLayoutPanel
            activitiesTableLayoutPanel = new TableLayoutPanel();
            activitiesTableLayoutPanel.Dock = DockStyle.Fill;
            activitiesTableLayoutPanel.AutoScroll = true;
            activitiesTableLayoutPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            mainTableLayoutPanel.Controls.Add(activitiesTableLayoutPanel, 0, 1);
            mainTableLayoutPanel.SetColumnSpan(activitiesTableLayoutPanel, 2);
        }

        private void ActivityTracker_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }
        private void ShowUploadActivityForm(object sender, EventArgs e)
        {
            UploadActivityForm uploadActivityForm = new UploadActivityForm();
            uploadActivityForm.ShowDialog();
        }

        private void ShowUserForm(object sender, EventArgs e)
        {
            new UserForm().ShowDialog();
        }

        public static void UpdateUI()
        {
            if (Program.currentSession.IsAuthenticated)
            {
                loginUserStripMenuItem.Text = Program.currentSession.CurrentUser.Firstname + Program.currentSession.CurrentUser.Lastname;
                UpdateActivities(Activity.ActivityType.All);
                uploadActivityStripMenuItem.Enabled = true;
                activityTypeFilterComboBox.Enabled = true;
            }
            else
            {
                uploadActivityStripMenuItem.Enabled = false;
                activityTypeFilterComboBox.Enabled = false;
                loginUserStripMenuItem.Text = "Login";
                activitiesTableLayoutPanel.Controls.Clear();

                // noActivitiesLabel
                noActivitiesLabel = new Label();
                noActivitiesLabel.Text = "Please login or create an account!";
                noActivitiesLabel.AutoSize = true;
                noActivitiesLabel.Font = GeneralValues.SubtitleFont;
                activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                activitiesTableLayoutPanel.Controls.Add(noActivitiesLabel, 0, 0);
            }
        }

        private void FilterActivities(object sender, EventArgs e)
        {
            if (activityTypeFilterComboBox.SelectedIndex == (int)Activity.ActivityType.Workout)
            {
                UpdateActivities(Activity.ActivityType.Workout);
            }
            else if (activityTypeFilterComboBox.SelectedIndex == (int)Activity.ActivityType.Run)
            {
                UpdateActivities(Activity.ActivityType.Run);
            }
            else if (activityTypeFilterComboBox.SelectedIndex == (int)Activity.ActivityType.Hike)
            {
                UpdateActivities(Activity.ActivityType.Hike);
            }
            else if (activityTypeFilterComboBox.SelectedIndex == (int)Activity.ActivityType.Bike_Ride)
            {
                UpdateActivities(Activity.ActivityType.Bike_Ride);
            }
            else
            {
                UpdateActivities(Activity.ActivityType.All);
            }
        }
        
        private static void UpdateActivities(Activity.ActivityType filter)
        {
            activitiesTableLayoutPanel.Controls.Clear();
            List<Activity> activityList = JsonSerializer.Deserialize < List<Activity> > (Program.service.GetActivities(Program.currentSession.CurrentUser.Id, ((int)filter).ToString()));

            Int32 numberOfActivities = activityList.Count;

            for (int i = 0; i < numberOfActivities; i++)
            {
                ActivityPanel activityPanel = new ActivityPanel(activityList[i]);
                activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
            }

            if (numberOfActivities == 0)
            {
                // noActivitiesLabel
                noActivitiesLabel = new Label();
                noActivitiesLabel.Text = "You don't have any activities yet!";
                noActivitiesLabel.AutoSize = true;
                noActivitiesLabel.Font = GeneralValues.SubtitleFont;
                activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                activitiesTableLayoutPanel.Controls.Add(noActivitiesLabel, 0, 0);
            }
        }
    }
}

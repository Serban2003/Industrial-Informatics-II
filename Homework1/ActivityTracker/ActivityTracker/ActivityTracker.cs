namespace ActivityTracker
{
    public partial class ActivityTracker : Form
    {
        static List<Object> activitiesList;
        TableLayoutPanel mainTableLayoutPanel;
        MenuStrip mainMenuStrip;
        ToolStripMenuItem uploadActivityStripMenuItem;
        FlowLayoutPanel activityTypeFilterFlowLayoutPanel;
        Label activityTypeFilterLabel;
        ComboBox activityTypeFilterComboBox;
        Label activitiesTitle;
        static TableLayoutPanel activitiesTableLayoutPanel;
        static Label noActivitiesLabel;

        public ActivityTracker()
        {
            CreateFileWatcher(GeneralValues.AppFolder);
            InitializeComponent();

            // ActivityTracker
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;
            Font = GeneralValues.BodyFont;
            Size = new Size(1000, 1000);

            // uploadActivityStripMenuItem
            uploadActivityStripMenuItem = new ToolStripMenuItem();
            uploadActivityStripMenuItem.AutoSize = true;
            uploadActivityStripMenuItem.Text = "Upload Activity";
            uploadActivityStripMenuItem.Click += new EventHandler(ShowUploadActivityForm);

            // mainMenuStrip
            mainMenuStrip = new MenuStrip();
            mainMenuStrip.Items.AddRange(new ToolStripItem[] {uploadActivityStripMenuItem});
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
            UpdateActivities(Activity.ActivityType.All);
        }
        private void ShowUploadActivityForm(object sender, EventArgs e)
        {
            UploadActivityForm uploadActivityForm = new UploadActivityForm();
            uploadActivityForm.ShowDialog();
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

        public void CreateFileWatcher(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.Filter = "*.csv";
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);

            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateActivities(Activity.ActivityType.All)));
                return;
            }
        }

        private static void UpdateActivities(Activity.ActivityType filter)
        {
            activitiesTableLayoutPanel.Controls.Clear();
            activitiesList = Activity.parseActivityFile(GeneralValues.ActivitiesDatabase);

            Int32 numberOfActivities = 0;

            for (int i = 0; i < activitiesList.Count; i++)
            {
                ActivityPanel activityPanel = null;
                if (activitiesList[i] is WorkoutActivity && (filter == Activity.ActivityType.Workout || filter == Activity.ActivityType.All))
                {
                    WorkoutActivity activity = (WorkoutActivity)activitiesList[i];
                    activityPanel = new ActivityPanel(activity);
                    activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
                    numberOfActivities++;
                }
                else if (activitiesList[i] is RunActivity && (filter == Activity.ActivityType.Run || filter == Activity.ActivityType.All))
                {
                    RunActivity activity = (RunActivity)activitiesList[i];
                    activityPanel = new ActivityPanel(activity);
                    activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
                    numberOfActivities++;
                }
                else if (activitiesList[i] is HikeActivity && (filter == Activity.ActivityType.Hike || filter == Activity.ActivityType.All))
                {
                    HikeActivity activity = (HikeActivity)activitiesList[i];
                    activityPanel = new ActivityPanel(activity);
                    activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
                    numberOfActivities++;
                }
                else if (activitiesList[i] is BikeRideActivity && (filter == Activity.ActivityType.Bike_Ride || filter == Activity.ActivityType.All))
                {
                    BikeRideActivity activity = (BikeRideActivity)activitiesList[i];
                    activityPanel = new ActivityPanel(activity);
                    activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
                    numberOfActivities++;
                }
            }
            
            if(numberOfActivities == 0)
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

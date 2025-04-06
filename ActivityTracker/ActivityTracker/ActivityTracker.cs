namespace ActivityTracker
{
    public partial class ActivityTracker : Form
    {
        static List<Object> activitiesList;
        public ActivityTracker()
        {
            CreateFileWatcher(GeneralValues.appFolder);
            InitializeComponent();

            // ActivityTracker
            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;
            Font = GeneralValues.BodyFont;
            Size = new Size(1000, 1000);

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

            // uploadActivityStripMenuItem
            uploadActivityStripMenuItem = new ToolStripMenuItem();
            uploadActivityStripMenuItem.AutoSize = true;
            uploadActivityStripMenuItem.Text = "Upload Activity";
            uploadActivityStripMenuItem.Click += new EventHandler(ShowUploadActivityForm);

            // mainFlowLayoutPanel
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Padding = new Padding(GeneralValues.PaddingValue, GeneralValues.PaddingValue + mainMenuStrip.Size.Height, GeneralValues.PaddingValue, GeneralValues.PaddingValue);
            Controls.Add(mainTableLayoutPanel);

            // activitiesTitle
            activitiesTitle = new Label();
            activitiesTitle.AutoSize = true;
            activitiesTitle.Font = GeneralValues.TitleFont;
            activitiesTitle.Text = "Your activities";
            mainTableLayoutPanel.Controls.Add(activitiesTitle, 0, 0);

            // activitiesTableLayoutPanel
            activitiesTableLayoutPanel = new TableLayoutPanel();
            activitiesTableLayoutPanel.Dock = DockStyle.Fill;
            activitiesTableLayoutPanel.AutoScroll = true;
            activitiesTableLayoutPanel.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            mainTableLayoutPanel.Controls.Add(activitiesTableLayoutPanel, 0, 1);
        }

        private void ActivityTracker_Load(object sender, EventArgs e)
        {
            UpdateActivities();
        }
        private void ShowUploadActivityForm(object sender, EventArgs e)
        {
            UploadActivityForm uploadActivityForm = new UploadActivityForm();
            uploadActivityForm.ShowDialog();
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
                Invoke(new Action(() => UpdateActivities()));
                return;
            }
        }

        private static void UpdateActivities()
        {
            activitiesTableLayoutPanel.Controls.Clear();
            activitiesList = Activity.parseActivityFile(GeneralValues.activitiesDatabase);

            if (activitiesList.Count > 0)
            {
                for (int i = 0; i < activitiesList.Count; i++)
                {
                    ActivityPanel activityPanel = null;
                    if (activitiesList[i] is WorkoutActivity)
                    {
                        WorkoutActivity activity = (WorkoutActivity)activitiesList[i];
                        activityPanel = new ActivityPanel(activity);
                    }
                    else if (activitiesList[i] is RunActivity)
                    {
                        RunActivity activity = (RunActivity)activitiesList[i];
                        activityPanel = new ActivityPanel(activity);
                    }
                    else if (activitiesList[i] is HikeActivity)
                    {
                        HikeActivity activity = (HikeActivity)activitiesList[i];
                        activityPanel = new ActivityPanel(activity);
                    }
                    else if (activitiesList[i] is BikeRideActivity)
                    {
                        BikeRideActivity activity = (BikeRideActivity)activitiesList[i];
                        activityPanel = new ActivityPanel(activity);
                    }

                    activitiesTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    activitiesTableLayoutPanel.Controls.Add(activityPanel, 0, i);
                }
            }
            else
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

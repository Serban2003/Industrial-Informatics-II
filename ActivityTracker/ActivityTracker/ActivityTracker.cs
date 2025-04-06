using System.Diagnostics;

namespace ActivityTracker
{
    public partial class ActivityTracker : Form
    {
        static List<Activity> activitiesList;
        public ActivityTracker()
        {
            CreateFileWatcher(GeneralValues.appFolder);
            InitializeComponent();

            BackColor = GeneralValues.PrimaryBackgroundColor;
            ForeColor = GeneralValues.PrimaryTextColor;

            mainMenuStrip = new MenuStrip();
            uploadActivityStripMenuItem = new ToolStripMenuItem();

            // mainMenuStrip
            mainMenuStrip.Items.AddRange(new ToolStripItem[] {uploadActivityStripMenuItem});
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Text = "Main Menu";
            mainMenuStrip.Font = GeneralValues.BodyFontSmall;
            mainMenuStrip.ForeColor = GeneralValues.PrimaryTextColor;
            mainMenuStrip.Cursor = Cursors.Hand;
            mainMenuStrip.Renderer = new MenuStripRenderer();
            Controls.Add(mainMenuStrip);

            // uploadActivityStripMenuItem
            uploadActivityStripMenuItem.AutoSize = true;
            uploadActivityStripMenuItem.Text = "Upload Activity";
            uploadActivityStripMenuItem.Click += new EventHandler(showUploadActivityForm);

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
            //activitiesTableLayoutPanel.MinimumSize = new Size(mainFlowLayoutPanel.Width - 3 * (mainFlowLayoutPanel.Padding.Right + mainFlowLayoutPanel.Padding.Left), 0);
            mainTableLayoutPanel.Controls.Add(activitiesTableLayoutPanel, 0, 1);

            Font = GeneralValues.BodyFont;
            Size = new Size(1000, 1000);
        }

        private void ActivityTracker_Load(object sender, EventArgs e)
        {
            updateActivities();
        }
        private void showUploadActivityForm(object sender, EventArgs e)
        {
            UploadActivityForm uploadActivityForm = new UploadActivityForm();
            uploadActivityForm.ShowDialog();
        }

        public void CreateFileWatcher(string path)
        {
            // Create a new FileSystemWatcher and set its properties.
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.Filter = "*.csv";
            /* Watch for changes in LastAccess and LastWrite times, and 
               the renaming of files or directories. */
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => updateActivities()));
                return;
            }
        }

        private static void updateActivities()
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

namespace ActivityTracker
{
    public partial class ActivityTracker : Form
    {
        public ActivityTracker()
        {
            InitializeComponent();
            Font = new Font("Outfit", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }

        private void ActivityTracker_Load(object sender, EventArgs e)
        {
            Activity activity1 = new WorkoutActivity("Workout", "Ala bala portocala tu mi-ai mancat banana", new DateTime(), 100000, 125, 180);
            ActivityPanel activityPanel = new ActivityPanel(activity1);
            activityPanel.Location = new Point(15, 70);
            
            this.Controls.Add(activityPanel);
        }
    }
}

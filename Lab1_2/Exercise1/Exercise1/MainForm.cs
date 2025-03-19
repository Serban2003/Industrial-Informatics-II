namespace Exercise1
{
    public partial class MainForm : Form
    {
        String username = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WelcomeMessage.Text = $"Hello, {username}!";
        }

        public void setUsername(String username)
        {
            this.username = username;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

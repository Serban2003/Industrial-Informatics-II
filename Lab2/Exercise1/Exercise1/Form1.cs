namespace Exercise1
{
    public partial class LoginForm : Form
    {
        String username;
        String password;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "credentials.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    if (words.Length == 2)
                    {
                        username = words[0];
                        password = words[1];
                    }
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String inputUsername = UsernameTextBox.Text;
            String inputPassword = PasswordTextBox.Text;

            if (username == inputUsername && password == inputPassword)
            {
                ErrorMessage.Visible = false;
                MainForm mainForm = new MainForm();
                mainForm.setUsername(username);
                mainForm.ShowDialog();
            }
            else
            {
                ErrorMessage.Visible = true;
            }
        }
    }
}

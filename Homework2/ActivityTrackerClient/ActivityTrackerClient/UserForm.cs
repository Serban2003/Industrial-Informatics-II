using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerClient
{
    public partial class UserForm : Form
    {
        TableLayoutPanel mainTableLayoutPanel;
        Label loginTitleLabel;
        Label registerTitleLabel;
        Label loginEmailLabel;
        TextBox loginEmailTextBox;
        Label loginPasswordLabel;
        TextBox loginPasswordTextBox;
        Button loginButton;
        Label registerFirstnameLabel;
        TextBox registerFirstnameTextBox;
        Label registerLastnameLabel;
        TextBox registerLastnameTextBox;
        Label registerEmailLabel;
        TextBox registerEmailTextBox;
        Label registerPasswordLabel;
        TextBox registerPasswordTextBox;
        Button registerButton;

        Label accountTitleLabel;
        Label accountFirstnameLabel;
        Label accountLastnameLabel;
        Label accountEmailLabel;
        Button logoutButton;
        Label changePasswordLabel;
        Label newPasswordLabel;
        TextBox newPasswordTextBox;
        Button changePasswordButton;

        public UserForm()
        {
            InitializeComponent();
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // mainTableLayoutPanel
            mainTableLayoutPanel = new TableLayoutPanel();
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Padding = new Padding(GeneralValues.PaddingValue);
            mainTableLayoutPanel.BackColor = GeneralValues.PrimaryBackgroundColor;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            mainTableLayoutPanel.CellPaint += CustomCellPaint;

            Controls.Add(mainTableLayoutPanel);

            if (Program.currentSession.IsAuthenticated)
            {
                CreateAccountDetails();
                CreateChangePasswordPanel();
            }
            else
            {
                CreateLoginPanel();
                CreateRegisterPanel();
            }
        }

        private void CreateAccountDetails()
        {
            // accountTitleLabel
            accountTitleLabel = new Label();
            accountTitleLabel.AutoSize = true;
            accountTitleLabel.Text = "Account Details";
            accountTitleLabel.Anchor = AnchorStyles.None;
            accountTitleLabel.Font = GeneralValues.SubtitleFont;
            accountTitleLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(accountTitleLabel, 0, 0);

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 1);

            // accountFirstnameLabel
            accountFirstnameLabel = new Label();
            accountFirstnameLabel.AutoSize = true;
            accountFirstnameLabel.Text = $"Firstname: {Program.currentSession.CurrentUser.Firstname}";
            accountFirstnameLabel.Font = GeneralValues.BodyFont;
            flowLayoutPanel.Controls.Add(accountFirstnameLabel);

            // accountLastnameLabel
            accountLastnameLabel = new Label();
            accountLastnameLabel.AutoSize = true;
            accountLastnameLabel.Text = $"Lastname: {Program.currentSession.CurrentUser.Lastname}";
            accountLastnameLabel.Font = GeneralValues.BodyFont;
            flowLayoutPanel.Controls.Add(accountLastnameLabel);

            // accountEmailLabel
            accountEmailLabel = new Label();
            accountEmailLabel.AutoSize = true;
            accountEmailLabel.Text = $"Email: {Program.currentSession.CurrentUser.Email}";
            accountEmailLabel.Font = GeneralValues.BodyFont;
            flowLayoutPanel.Controls.Add(accountEmailLabel);

            // logoutButton
            logoutButton = new CustomStyleButton();
            logoutButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logoutButton.AutoSize = true;
            logoutButton.Text = "Logout";
            logoutButton.Click += LogoutUser;
            mainTableLayoutPanel.Controls.Add(logoutButton, 0, 2);

            foreach (Control control in mainTableLayoutPanel.Controls)
            {
                if (mainTableLayoutPanel.GetColumn(control) == 0)
                {
                    var m = control.Margin;
                    control.Margin = new Padding(m.Left, m.Top, GeneralValues.PaddingValue, m.Bottom);
                }
            }
        }

        private void CreateChangePasswordPanel()
        {
            // forgotPasswordLabel
            changePasswordLabel = new Label();
            changePasswordLabel.AutoSize = true;
            changePasswordLabel.Anchor = AnchorStyles.None;
            changePasswordLabel.Text = "Change Password?";
            changePasswordLabel.Font = GeneralValues.SubtitleFont;
            changePasswordLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(changePasswordLabel, 1, 0);

            // newPasswordFlowLayoutPanel
            TableLayoutPanel newPasswordTableLayoutPanel = new TableLayoutPanel();
            newPasswordTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            newPasswordTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(newPasswordTableLayoutPanel, 1, 1);

            // newPasswordLabel
            newPasswordLabel = new Label();
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Text = "New Password";
            newPasswordLabel.Font = GeneralValues.BodyFont;
            newPasswordTableLayoutPanel.Controls.Add(newPasswordLabel, 0, 0);

            // newPasswordTextBox
            newPasswordTextBox = new TextBox();
            newPasswordTextBox.Dock = DockStyle.Fill;
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTableLayoutPanel.Controls.Add(newPasswordTextBox, 0, 1);

            // changePasswordButton
            changePasswordButton = new CustomStyleButton();
            changePasswordButton.AutoSize = true;
            changePasswordButton.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            changePasswordButton.Text = "Change Password";
            changePasswordButton.Click += ChangePassword;
            mainTableLayoutPanel.Controls.Add(changePasswordButton, 1, 2);

            foreach (Control control in mainTableLayoutPanel.Controls)
            {
                if (mainTableLayoutPanel.GetColumn(control) == 1)
                {
                    var m = control.Margin;
                    control.Margin = new Padding(GeneralValues.PaddingValue, m.Top, m.Right, m.Bottom);
                }
            }
        }

        private void CreateLoginPanel()
        {
            // loginTitleLabel
            loginTitleLabel = new Label();
            loginTitleLabel.AutoSize = true;
            loginTitleLabel.Anchor = AnchorStyles.None;
            loginTitleLabel.Text = "Login";
            loginTitleLabel.Font = GeneralValues.SubtitleFont;
            loginTitleLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(loginTitleLabel, 0, 0);

            // emailTableLayoutPanel
            TableLayoutPanel emailTableLayoutPanel = new TableLayoutPanel();
            emailTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(emailTableLayoutPanel, 0, 1);

            // loginEmailLabel
            loginEmailLabel = new Label();
            loginEmailLabel.Width = 200;
            loginEmailLabel.Text = "Email";
            loginEmailLabel.Font = GeneralValues.BodyFont;
            emailTableLayoutPanel.Controls.Add(loginEmailLabel, 0, 0);

            // loginEmailTextBox
            loginEmailTextBox = new TextBox();
            loginEmailTextBox.Dock = DockStyle.Fill;
            emailTableLayoutPanel.Controls.Add(loginEmailTextBox, 0, 1);

            // passwordFlowLayoutPanel
            TableLayoutPanel passwordTableLayoutPanel = new TableLayoutPanel();
            passwordTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(passwordTableLayoutPanel, 0, 2);

            // loginPasswordLabel
            loginPasswordLabel = new Label();
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Text = "Password";
            loginPasswordLabel.Font = GeneralValues.BodyFont;
            passwordTableLayoutPanel.Controls.Add(loginPasswordLabel, 0, 0);

            // loginPasswordTextBox
            loginPasswordTextBox = new TextBox();
            loginPasswordTextBox.Dock = DockStyle.Fill;
            loginPasswordTextBox.PasswordChar = '*';
            passwordTableLayoutPanel.Controls.Add(loginPasswordTextBox, 0, 1);

            // loginButton
            loginButton = new CustomStyleButton();
            loginButton.AutoSize = true;
            loginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            loginButton.Text = "Login";
            loginButton.Click += LoginUser;
            mainTableLayoutPanel.Controls.Add(loginButton, 0, 3);

            foreach (Control control in mainTableLayoutPanel.Controls)
            {
                if (mainTableLayoutPanel.GetColumn(control) == 0)
                {
                    var m = control.Margin;
                    control.Margin = new Padding(m.Left, m.Top, GeneralValues.PaddingValue, m.Bottom);
                }
            }
        }

        private void CreateRegisterPanel()
        { 
            // registerTitleLabel
            registerTitleLabel = new Label();
            registerTitleLabel.AutoSize = true;
            registerTitleLabel.Anchor = AnchorStyles.None;
            registerTitleLabel.Text = "Register";
            registerTitleLabel.Font = GeneralValues.SubtitleFont;
            registerTitleLabel.Margin = new Padding(0, 0, 0, GeneralValues.PaddingValue);
            mainTableLayoutPanel.Controls.Add(registerTitleLabel, 1, 0);

            // firstnameTableLayoutPanel
            TableLayoutPanel firstnameTableLayoutPanel = new TableLayoutPanel();
            firstnameTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            firstnameTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(firstnameTableLayoutPanel, 1, 1);

            // registerFirstnameLabel
            registerFirstnameLabel = new Label();
            registerFirstnameLabel.AutoSize = true;
            registerFirstnameLabel.Text = "Firstname";
            registerFirstnameLabel.Font = GeneralValues.BodyFont;
            firstnameTableLayoutPanel.Controls.Add(registerFirstnameLabel, 0, 0);

            // registerFirstnameTextBox
            registerFirstnameTextBox = new TextBox();
            registerFirstnameTextBox.Dock = DockStyle.Fill;
            firstnameTableLayoutPanel.Controls.Add(registerFirstnameTextBox, 0, 1);

            // lastnameTableLayoutPanel
            TableLayoutPanel lastnameTableLayoutPanel = new TableLayoutPanel();
            lastnameTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lastnameTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(lastnameTableLayoutPanel, 1, 2);

            // registerLastnameLabel
            registerLastnameLabel = new Label();
            registerLastnameLabel.AutoSize = true;
            registerLastnameLabel.Text = "Lastname";
            registerLastnameLabel.Font = GeneralValues.BodyFont;
            lastnameTableLayoutPanel.Controls.Add(registerLastnameLabel, 0, 0);

            // registerLastnameTextBox
            registerLastnameTextBox = new TextBox();
            registerLastnameTextBox.Dock = DockStyle.Fill;
            lastnameTableLayoutPanel.Controls.Add(registerLastnameTextBox, 0, 1);

            // emailTableLayoutPanel
            TableLayoutPanel emailTableLayoutPanel = new TableLayoutPanel();
            emailTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(emailTableLayoutPanel, 1, 3);

            // registerEmailLabel
            registerEmailLabel = new Label();
            registerEmailLabel.AutoSize = true;
            registerEmailLabel.Text = "Email";
            registerEmailLabel.Font = GeneralValues.BodyFont;
            emailTableLayoutPanel.Controls.Add(registerEmailLabel, 0, 0);

            // registerEmailTextBox
            registerEmailTextBox = new TextBox();
            registerEmailTextBox.Dock = DockStyle.Fill;
            emailTableLayoutPanel.Controls.Add(registerEmailTextBox, 0, 1);

            // passwordFlowLayoutPanel
            TableLayoutPanel passwordTableLayoutPanel = new TableLayoutPanel();
            passwordTableLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.Controls.Add(passwordTableLayoutPanel, 1, 4);

            // registerPasswordLabel
            registerPasswordLabel = new Label();
            registerPasswordLabel.AutoSize = true;
            registerPasswordLabel.Text = "Password";
            registerPasswordLabel.Font = GeneralValues.BodyFont;
            passwordTableLayoutPanel.Controls.Add(registerPasswordLabel, 0, 0);

            // registerPasswordTextBox
            registerPasswordTextBox = new TextBox();
            registerPasswordTextBox.Dock = DockStyle.Fill;
            registerPasswordTextBox.PasswordChar = '*';
            passwordTableLayoutPanel.Controls.Add(registerPasswordTextBox, 0, 1);

            // registerButton
            registerButton = new CustomStyleButton();
            registerButton.AutoSize = true;
            registerButton.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            registerButton.Text = "Register";
            registerButton.Click += RegisterUser;
            mainTableLayoutPanel.Controls.Add(registerButton, 1, 5);

            foreach (Control control in mainTableLayoutPanel.Controls)
            {
                if (mainTableLayoutPanel.GetColumn(control) == 1)
                {
                    var m = control.Margin;
                    control.Margin = new Padding(GeneralValues.PaddingValue, m.Top, m.Right, m.Bottom);
                }
            }
        }

        public void ChangePassword(Object o, EventArgs e)
        {
            String newPassword = newPasswordTextBox.Text;
            if(Program.service.ChangePassword(Program.currentSession.CurrentUser.ToJson(), newPassword))
            {
                MessageBox.Show("Password successfully updated!");
            }
            else
            {
                MessageBox.Show("Couldn't update password!");
            }
        }
        public void LoginUser(Object o, EventArgs e)
        {
            String email = loginEmailTextBox.Text;
            String password = loginPasswordTextBox.Text;

            var response = Program.service.GetUser(email, password);
            if (response == null) {
                MessageBox.Show("Incorrect email or password!");
            }
            else
            {
                Program.currentSession = new Session(true, User.FromJson(response));
                GeneralValues.UpdateSessionInfo();
                ActivityTracker.UpdateUI();
                MessageBox.Show("Successfully authenticated!");
                Close();
            }
        }

        public void RegisterUser(Object o, EventArgs e)
        {
            String firstname = registerFirstnameTextBox.Text;
            String lastname = registerLastnameTextBox.Text;
            String email = registerEmailTextBox.Text;
            String password = registerPasswordTextBox.Text;

            if(Program.service.CreateUser(new User(0, firstname, lastname, email, password).ToJson()))
            {
                User user = User.FromJson(Program.service.GetUser(email, password));
                Program.currentSession = new Session(true, user);
                GeneralValues.UpdateSessionInfo();
                ActivityTracker.UpdateUI();
                MessageBox.Show("Successfully authenticated!");
                Close();
            }
            else
            {
                MessageBox.Show("Couldn't create account!");
            }
        }
        public void LogoutUser(Object o,  EventArgs e)
        {
            Program.currentSession = new Session();
            GeneralValues.UpdateSessionInfo();
            ActivityTracker.UpdateUI();
            MessageBox.Show("Successfully disconnected!");
            Close();
        }
        private void CustomCellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 1)
            {
                using (var pen = new Pen(GeneralValues.BorderColor, 2))
                {
                    int x = e.CellBounds.Left;
                    e.Graphics.DrawLine(pen, x, e.CellBounds.Top, x, e.CellBounds.Bottom);
                }
            }
        }
    }
}

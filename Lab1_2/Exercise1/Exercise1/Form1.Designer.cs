namespace Exercise1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LoginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ErrorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 21);
            label1.Name = "label1";
            label1.Size = new Size(268, 65);
            label1.TabIndex = 0;
            label1.Text = "Login Form";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(120, 308);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(338, 40);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 114);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 211);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(120, 147);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(338, 35);
            UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(120, 244);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(338, 35);
            PasswordTextBox.TabIndex = 5;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(120, 351);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(316, 30);
            ErrorMessage.TabIndex = 6;
            ErrorMessage.Text = "Incorrect username or password!";
            ErrorMessage.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 450);
            Controls.Add(ErrorMessage);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LoginButton;
        private Label label2;
        private Label label3;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label ErrorMessage;
    }
}

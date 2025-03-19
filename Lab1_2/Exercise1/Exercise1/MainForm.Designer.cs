namespace Exercise1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WelcomeMessage = new Label();
            Exit = new Button();
            SuspendLayout();
            // 
            // WelcomeMessage
            // 
            WelcomeMessage.AutoSize = true;
            WelcomeMessage.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeMessage.Location = new Point(118, 44);
            WelcomeMessage.Name = "WelcomeMessage";
            WelcomeMessage.Size = new Size(0, 45);
            WelcomeMessage.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.Location = new Point(268, 140);
            Exit.Name = "Exit";
            Exit.Size = new Size(131, 40);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 213);
            Controls.Add(Exit);
            Controls.Add(WelcomeMessage);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeMessage;
        private Button Exit;
    }
}
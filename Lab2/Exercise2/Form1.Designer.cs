namespace Exercise2
{
    partial class Form1
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
            InitialList = new ListBox();
            OtherList = new ListBox();
            CopyButton = new Button();
            DeleteButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // InitialList
            // 
            InitialList.FormattingEnabled = true;
            InitialList.ItemHeight = 30;
            InitialList.Location = new Point(79, 90);
            InitialList.Name = "InitialList";
            InitialList.Size = new Size(210, 154);
            InitialList.TabIndex = 0;
            // 
            // OtherList
            // 
            OtherList.FormattingEnabled = true;
            OtherList.ItemHeight = 30;
            OtherList.Location = new Point(488, 90);
            OtherList.Name = "OtherList";
            OtherList.Size = new Size(210, 154);
            OtherList.TabIndex = 1;
            // 
            // CopyButton
            // 
            CopyButton.AllowDrop = true;
            CopyButton.Location = new Point(324, 90);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(131, 40);
            CopyButton.TabIndex = 2;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(324, 147);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(131, 40);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(324, 204);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 40);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 331);
            Controls.Add(ExitButton);
            Controls.Add(DeleteButton);
            Controls.Add(CopyButton);
            Controls.Add(OtherList);
            Controls.Add(InitialList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox InitialList;
        private ListBox OtherList;
        private Button CopyButton;
        private Button DeleteButton;
        private Button ExitButton;
    }
}

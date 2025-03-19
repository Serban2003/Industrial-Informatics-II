namespace Exercise2
{
    partial class ListSelector
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // InitialList
            // 
            InitialList.FormattingEnabled = true;
            InitialList.ItemHeight = 15;
            InitialList.Location = new Point(46, 45);
            InitialList.Margin = new Padding(2, 2, 2, 2);
            InitialList.Name = "InitialList";
            InitialList.Size = new Size(124, 79);
            InitialList.TabIndex = 0;
            // 
            // OtherList
            // 
            OtherList.FormattingEnabled = true;
            OtherList.ItemHeight = 15;
            OtherList.Location = new Point(285, 45);
            OtherList.Margin = new Padding(2, 2, 2, 2);
            OtherList.Name = "OtherList";
            OtherList.Size = new Size(124, 79);
            OtherList.TabIndex = 1;
            // 
            // CopyButton
            // 
            CopyButton.AllowDrop = true;
            CopyButton.Location = new Point(189, 45);
            CopyButton.Margin = new Padding(2, 2, 2, 2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(76, 20);
            CopyButton.TabIndex = 2;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(189, 74);
            DeleteButton.Margin = new Padding(2, 2, 2, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(76, 20);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(189, 102);
            ExitButton.Margin = new Padding(2, 2, 2, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(76, 20);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ListSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 166);
            Controls.Add(ExitButton);
            Controls.Add(DeleteButton);
            Controls.Add(CopyButton);
            Controls.Add(OtherList);
            Controls.Add(InitialList);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ListSelector";
            Text = "ListSelector";
            ResumeLayout(false);
        }

        #endregion

        private ListBox InitialList;
        private ListBox OtherList;
        private Button CopyButton;
        private Button DeleteButton;
        private Button ExitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

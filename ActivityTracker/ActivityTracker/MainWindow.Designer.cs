namespace ActivityTracker
{
    partial class ActivityTracker
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
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, accountToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Font = new Font("Outfit", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(62, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // accountToolStripMenuItem1
            // 
            accountToolStripMenuItem1.Font = new Font("Outfit", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            accountToolStripMenuItem1.Size = new Size(63, 20);
            accountToolStripMenuItem1.Text = "Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Outfit", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 30);
            label1.Name = "Title";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 1;
            label1.Text = "Your activities";
            // 
            // ActivityTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ActivityTracker";
            Text = "ActivityTracker";
            Load += ActivityTracker_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private Label label1;
    }
}

namespace Exercise3
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
            Number1TextBox = new TextBox();
            Number2TextBox = new TextBox();
            ResultTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            subToolStripMenuItem = new ToolStripMenuItem();
            multToolStripMenuItem1 = new ToolStripMenuItem();
            divToolStripMenuItem = new ToolStripMenuItem();
            modToolStripMenuItem = new ToolStripMenuItem();
            diffToolStripMenuItem = new ToolStripMenuItem();
            aNDToolStripMenuItem = new ToolStripMenuItem();
            oRToolStripMenuItem = new ToolStripMenuItem();
            xORToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Number1TextBox
            // 
            Number1TextBox.Location = new Point(184, 93);
            Number1TextBox.Name = "Number1TextBox";
            Number1TextBox.Size = new Size(175, 35);
            Number1TextBox.TabIndex = 0;
            // 
            // Number2TextBox
            // 
            Number2TextBox.Location = new Point(184, 148);
            Number2TextBox.Name = "Number2TextBox";
            Number2TextBox.Size = new Size(175, 35);
            Number2TextBox.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(520, 118);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(175, 35);
            ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 96);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 3;
            label1.Text = "Number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 153);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 4;
            label2.Text = "Number 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 118);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 5;
            label3.Text = "Result:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, diffToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(746, 38);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, subToolStripMenuItem, multToolStripMenuItem1, divToolStripMenuItem, modToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(127, 34);
            toolStripMenuItem1.Text = "Arithmetic";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(209, 40);
            addToolStripMenuItem.Text = "Add (+)";
            addToolStripMenuItem.Click += AddNumbers;
            // 
            // subToolStripMenuItem
            // 
            subToolStripMenuItem.Name = "subToolStripMenuItem";
            subToolStripMenuItem.Size = new Size(209, 40);
            subToolStripMenuItem.Text = "Sub (-)";
            subToolStripMenuItem.Click += SubtractNumbers;
            // 
            // multToolStripMenuItem1
            // 
            multToolStripMenuItem1.Name = "multToolStripMenuItem1";
            multToolStripMenuItem1.Size = new Size(209, 40);
            multToolStripMenuItem1.Text = "Mult (*)";
            multToolStripMenuItem1.Click += MultiplyNumbers;
            // 
            // divToolStripMenuItem
            // 
            divToolStripMenuItem.Name = "divToolStripMenuItem";
            divToolStripMenuItem.Size = new Size(209, 40);
            divToolStripMenuItem.Text = "Div (/)";
            divToolStripMenuItem.Click += DivideNumbers;
            // 
            // modToolStripMenuItem
            // 
            modToolStripMenuItem.Name = "modToolStripMenuItem";
            modToolStripMenuItem.Size = new Size(209, 40);
            modToolStripMenuItem.Text = "Mod (%)";
            modToolStripMenuItem.Click += ModulusNumbers;
            // 
            // diffToolStripMenuItem
            // 
            diffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aNDToolStripMenuItem, oRToolStripMenuItem, xORToolStripMenuItem });
            diffToolStripMenuItem.Name = "diffToolStripMenuItem";
            diffToolStripMenuItem.Size = new Size(95, 34);
            diffToolStripMenuItem.Text = "Bitwise";
            // 
            // aNDToolStripMenuItem
            // 
            aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            aNDToolStripMenuItem.Size = new Size(315, 40);
            aNDToolStripMenuItem.Text = "AND";
            aNDToolStripMenuItem.Click += ANDNumbers;
            // 
            // oRToolStripMenuItem
            // 
            oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            oRToolStripMenuItem.Size = new Size(315, 40);
            oRToolStripMenuItem.Text = "OR (|)";
            oRToolStripMenuItem.Click += ORNumbers;
            // 
            // xORToolStripMenuItem
            // 
            xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            xORToolStripMenuItem.Size = new Size(315, 40);
            xORToolStripMenuItem.Text = "XOR (^)";
            xORToolStripMenuItem.Click += XORNumbers;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 241);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultTextBox);
            Controls.Add(Number2TextBox);
            Controls.Add(Number1TextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Number1TextBox;
        private TextBox Number2TextBox;
        private TextBox ResultTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem diffToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem subToolStripMenuItem;
        private ToolStripMenuItem multToolStripMenuItem1;
        private ToolStripMenuItem divToolStripMenuItem;
        private ToolStripMenuItem modToolStripMenuItem;
        private ToolStripMenuItem aNDToolStripMenuItem;
        private ToolStripMenuItem oRToolStripMenuItem;
        private ToolStripMenuItem xORToolStripMenuItem;
    }
}

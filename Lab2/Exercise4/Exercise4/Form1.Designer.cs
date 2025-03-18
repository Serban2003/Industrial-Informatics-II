namespace Exercise4
{
    partial class Exercise4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            ItemList = new ListBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            ResultTextBox = new TextBox();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(518, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(ItemList);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "Images";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(510, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(258, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 154);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.ItemHeight = 30;
            ItemList.Location = new Point(16, 21);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(210, 154);
            ItemList.TabIndex = 0;
            ItemList.SelectedIndexChanged += ItemList_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(ResultTextBox);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "Radios";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(510, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 206);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 6;
            label1.Text = "Result";
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(33, 249);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(439, 35);
            ResultTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(276, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 168);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lastname";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(43, 34);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(115, 34);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Popescu";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
         
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(43, 114);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(92, 34);
            radioButton5.TabIndex = 2;
            radioButton5.Text = "Rosca";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(43, 74);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(102, 34);
            radioButton6.TabIndex = 1;
            radioButton6.Text = "Serban";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(33, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 168);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Firstname";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(43, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mihai";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(43, 114);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 34);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Ana";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(43, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 34);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Andrei";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
          
            // 
            // Exercise4
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(tabControl1);
            Name = "Exercise4";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox ItemList;
        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private TextBox ResultTextBox;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label1;
    }
}

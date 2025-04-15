namespace WindowsFormsClient
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addListButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.convertFToCButton = new System.Windows.Forms.Button();
            this.convertCToFButton = new System.Windows.Forms.Button();
            this.FTempTextBox = new System.Windows.Forms.TextBox();
            this.CTempTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.convertCurrencyButton = new System.Windows.Forms.Button();
            this.euroTextBox = new System.Windows.Forms.TextBox();
            this.ronTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(6, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(188, 148);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temp. C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addListButton);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Viewer";
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(6, 182);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(188, 39);
            this.addListButton.TabIndex = 6;
            this.addListButton.Text = "Add List";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.convertFToCButton);
            this.groupBox2.Controls.Add(this.convertCToFButton);
            this.groupBox2.Controls.Add(this.FTempTextBox);
            this.groupBox2.Controls.Add(this.CTempTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(233, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperature Conversion";
            // 
            // convertFToCButton
            // 
            this.convertFToCButton.Location = new System.Drawing.Point(133, 120);
            this.convertFToCButton.Name = "convertFToCButton";
            this.convertFToCButton.Size = new System.Drawing.Size(113, 39);
            this.convertFToCButton.TabIndex = 6;
            this.convertFToCButton.Text = "F to C";
            this.convertFToCButton.UseVisualStyleBackColor = true;
            this.convertFToCButton.Click += new System.EventHandler(this.convertFToCButton_Click);
            // 
            // convertCToFButton
            // 
            this.convertCToFButton.Location = new System.Drawing.Point(11, 120);
            this.convertCToFButton.Name = "convertCToFButton";
            this.convertCToFButton.Size = new System.Drawing.Size(113, 39);
            this.convertCToFButton.TabIndex = 5;
            this.convertCToFButton.Text = "C to F";
            this.convertCToFButton.UseVisualStyleBackColor = true;
            this.convertCToFButton.Click += new System.EventHandler(this.convertCToFButton_Click);
            // 
            // FTempTextBox
            // 
            this.FTempTextBox.Location = new System.Drawing.Point(100, 76);
            this.FTempTextBox.Name = "FTempTextBox";
            this.FTempTextBox.Size = new System.Drawing.Size(151, 29);
            this.FTempTextBox.TabIndex = 4;
            // 
            // CTempTextBox
            // 
            this.CTempTextBox.Location = new System.Drawing.Point(100, 35);
            this.CTempTextBox.Name = "CTempTextBox";
            this.CTempTextBox.Size = new System.Drawing.Size(151, 29);
            this.CTempTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Temp. F";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.convertCurrencyButton);
            this.groupBox3.Controls.Add(this.euroTextBox);
            this.groupBox3.Controls.Add(this.ronTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(511, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 165);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Currency Conversion";
            // 
            // convertCurrencyButton
            // 
            this.convertCurrencyButton.Location = new System.Drawing.Point(11, 120);
            this.convertCurrencyButton.Name = "convertCurrencyButton";
            this.convertCurrencyButton.Size = new System.Drawing.Size(240, 39);
            this.convertCurrencyButton.TabIndex = 5;
            this.convertCurrencyButton.Text = "Convert";
            this.convertCurrencyButton.UseVisualStyleBackColor = true;
            this.convertCurrencyButton.Click += new System.EventHandler(this.convertCurrencyButton_Click);
            // 
            // euroTextBox
            // 
            this.euroTextBox.Enabled = false;
            this.euroTextBox.Location = new System.Drawing.Point(100, 76);
            this.euroTextBox.Name = "euroTextBox";
            this.euroTextBox.Size = new System.Drawing.Size(151, 29);
            this.euroTextBox.TabIndex = 4;
            // 
            // ronTextBox
            // 
            this.ronTextBox.Location = new System.Drawing.Point(100, 35);
            this.ronTextBox.Name = "ronTextBox";
            this.ronTextBox.Size = new System.Drawing.Size(151, 29);
            this.ronTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "EURO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "RON";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimeLabel);
            this.groupBox4.Location = new System.Drawing.Point(233, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 60);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date and Time";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(6, 25);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(209, 25);
            this.dateTimeLabel.TabIndex = 0;
            this.dateTimeLabel.Text = "dd:mm:yyyy hh:mm:ss";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 252);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button convertCToFButton;
        private System.Windows.Forms.TextBox FTempTextBox;
        private System.Windows.Forms.TextBox CTempTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button convertCurrencyButton;
        private System.Windows.Forms.TextBox euroTextBox;
        private System.Windows.Forms.TextBox ronTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button addListButton;
        private System.Windows.Forms.Button convertFToCButton;
        private System.Windows.Forms.Timer timer;
    }
}


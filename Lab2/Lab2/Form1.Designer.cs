namespace Lab2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listFaculties = new System.Windows.Forms.ListBox();
            this.listUniversities = new System.Windows.Forms.ListBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Lab2.DatabaseDataSet();
            this.facultiesTableAdapter = new Lab2.DatabaseDataSetTableAdapters.FacultiesTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.add_Button = new System.Windows.Forms.Button();
            this.add_City_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_Code_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_Name_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.delete_ID_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.update_Button = new System.Windows.Forms.Button();
            this.update_ID_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.update_City_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.update_Code_TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.update_Name_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listFaculties);
            this.groupBox1.Controls.Add(this.listUniversities);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB Exemple";
            // 
            // listFaculties
            // 
            this.listFaculties.FormattingEnabled = true;
            this.listFaculties.Location = new System.Drawing.Point(205, 50);
            this.listFaculties.Margin = new System.Windows.Forms.Padding(2);
            this.listFaculties.Name = "listFaculties";
            this.listFaculties.Size = new System.Drawing.Size(146, 56);
            this.listFaculties.TabIndex = 9;
            // 
            // listUniversities
            // 
            this.listUniversities.FormattingEnabled = true;
            this.listUniversities.Location = new System.Drawing.Point(16, 50);
            this.listUniversities.Margin = new System.Windows.Forms.Padding(2);
            this.listUniversities.Name = "listUniversities";
            this.listUniversities.Size = new System.Drawing.Size(179, 147);
            this.listUniversities.TabIndex = 8;
            this.listUniversities.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(205, 174);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(146, 20);
            this.codeTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(205, 132);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(146, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universities";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("AllowUserToAddRows", this.facultiesBindingSource, "Name", true));
            this.dataGridView1.DataSource = this.facultiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 528);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(368, 100);
            this.dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 175;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 175;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 175;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.add_Button);
            this.groupBox2.Controls.Add(this.add_City_TextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.add_Code_TextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.add_Name_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(26, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(368, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add University";
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(16, 57);
            this.add_Button.Margin = new System.Windows.Forms.Padding(2);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(93, 21);
            this.add_Button.TabIndex = 8;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // add_City_TextBox
            // 
            this.add_City_TextBox.Location = new System.Drawing.Point(97, 38);
            this.add_City_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.add_City_TextBox.Name = "add_City_TextBox";
            this.add_City_TextBox.Size = new System.Drawing.Size(60, 20);
            this.add_City_TextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Code";
            // 
            // add_Code_TextBox
            // 
            this.add_Code_TextBox.Location = new System.Drawing.Point(179, 38);
            this.add_Code_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.add_Code_TextBox.Name = "add_Code_TextBox";
            this.add_Code_TextBox.Size = new System.Drawing.Size(60, 20);
            this.add_Code_TextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // add_Name_TextBox
            // 
            this.add_Name_TextBox.Location = new System.Drawing.Point(16, 38);
            this.add_Name_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.add_Name_TextBox.Name = "add_Name_TextBox";
            this.add_Name_TextBox.Size = new System.Drawing.Size(60, 20);
            this.add_Name_TextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delete_Button);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.delete_ID_TextBox);
            this.groupBox3.Location = new System.Drawing.Point(26, 343);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(368, 68);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete University";
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(95, 34);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(93, 21);
            this.delete_Button.TabIndex = 8;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ID";
            // 
            // delete_ID_TextBox
            // 
            this.delete_ID_TextBox.Location = new System.Drawing.Point(16, 39);
            this.delete_ID_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.delete_ID_TextBox.Name = "delete_ID_TextBox";
            this.delete_ID_TextBox.Size = new System.Drawing.Size(60, 20);
            this.delete_ID_TextBox.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.update_Button);
            this.groupBox4.Controls.Add(this.update_ID_TextBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.update_City_TextBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.update_Code_TextBox);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.update_Name_TextBox);
            this.groupBox4.Location = new System.Drawing.Point(26, 425);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(368, 92);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update University";
            // 
            // update_Button
            // 
            this.update_Button.Location = new System.Drawing.Point(16, 57);
            this.update_Button.Margin = new System.Windows.Forms.Padding(2);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(93, 21);
            this.update_Button.TabIndex = 8;
            this.update_Button.Text = "Update";
            this.update_Button.UseVisualStyleBackColor = true;
            this.update_Button.Click += new System.EventHandler(this.update_Button_Click);
            // 
            // update_ID_TextBox
            // 
            this.update_ID_TextBox.Location = new System.Drawing.Point(16, 38);
            this.update_ID_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.update_ID_TextBox.Name = "update_ID_TextBox";
            this.update_ID_TextBox.Size = new System.Drawing.Size(60, 20);
            this.update_ID_TextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID";
            // 
            // update_City_TextBox
            // 
            this.update_City_TextBox.Location = new System.Drawing.Point(179, 38);
            this.update_City_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.update_City_TextBox.Name = "update_City_TextBox";
            this.update_City_TextBox.Size = new System.Drawing.Size(60, 20);
            this.update_City_TextBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Code";
            // 
            // update_Code_TextBox
            // 
            this.update_Code_TextBox.Location = new System.Drawing.Point(261, 38);
            this.update_Code_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.update_Code_TextBox.Name = "update_Code_TextBox";
            this.update_Code_TextBox.Size = new System.Drawing.Size(60, 20);
            this.update_Code_TextBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "City";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(92, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Name";
            // 
            // update_Name_TextBox
            // 
            this.update_Name_TextBox.Location = new System.Drawing.Point(95, 38);
            this.update_Name_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.update_Name_TextBox.Name = "update_Name_TextBox";
            this.update_Name_TextBox.Size = new System.Drawing.Size(60, 20);
            this.update_Name_TextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ListBox listFaculties;
        private System.Windows.Forms.ListBox listUniversities;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private DatabaseDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_Name_TextBox;
        private System.Windows.Forms.TextBox add_City_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_Code_TextBox;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox delete_ID_TextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button update_Button;
        private System.Windows.Forms.TextBox update_ID_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox update_City_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox update_Code_TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox update_Name_TextBox;
    }
}


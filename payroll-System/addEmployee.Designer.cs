namespace payroll_System
{
    partial class addEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox4_BR = new System.Windows.Forms.ComboBox();
            this.comboBox3_Position = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox6_SSS = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox5_Tel = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox4_Phone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1_status = new System.Windows.Forms.Label();
            this.comboBox2_Status = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3_Address = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2_LN = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1_FN = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1_search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1_EmpData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_EmpData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employee";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.button1.Location = new System.Drawing.Point(311, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox4_BR);
            this.panel2.Controls.Add(this.comboBox3_Position);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(381, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 456);
            this.panel2.TabIndex = 1;
            // 
            // comboBox4_BR
            // 
            this.comboBox4_BR.ForeColor = System.Drawing.Color.Gray;
            this.comboBox4_BR.FormattingEnabled = true;
            this.comboBox4_BR.Items.AddRange(new object[] {
            "500",
            "600",
            "700",
            "800",
            "1000",
            "1500",
            "2000",
            "2500"});
            this.comboBox4_BR.Location = new System.Drawing.Point(122, 259);
            this.comboBox4_BR.Name = "comboBox4_BR";
            this.comboBox4_BR.Size = new System.Drawing.Size(151, 28);
            this.comboBox4_BR.TabIndex = 6;
            this.comboBox4_BR.Text = "Basic Rate";
            this.comboBox4_BR.SelectedIndexChanged += new System.EventHandler(this.comboBox4_BR_SelectedIndexChanged);
            // 
            // comboBox3_Position
            // 
            this.comboBox3_Position.ForeColor = System.Drawing.Color.Gray;
            this.comboBox3_Position.FormattingEnabled = true;
            this.comboBox3_Position.Items.AddRange(new object[] {
            "IT Head",
            "IT Specialists",
            "Database Administrator",
            "Cybersecurity Assistant",
            "Graphic Designer",
            "Data Scientist",
            "Data Analyst",
            "Network Administrator"});
            this.comboBox3_Position.Location = new System.Drawing.Point(122, 225);
            this.comboBox3_Position.Name = "comboBox3_Position";
            this.comboBox3_Position.Size = new System.Drawing.Size(151, 28);
            this.comboBox3_Position.TabIndex = 5;
            this.comboBox3_Position.Text = "Position";
            this.comboBox3_Position.SelectedIndexChanged += new System.EventHandler(this.comboBox3_Position_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.textBox6_SSS);
            this.panel9.Location = new System.Drawing.Point(31, 155);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 38);
            this.panel9.TabIndex = 4;
            // 
            // textBox6_SSS
            // 
            this.textBox6_SSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6_SSS.ForeColor = System.Drawing.Color.Gray;
            this.textBox6_SSS.Location = new System.Drawing.Point(8, 4);
            this.textBox6_SSS.Multiline = true;
            this.textBox6_SSS.Name = "textBox6_SSS";
            this.textBox6_SSS.Size = new System.Drawing.Size(266, 30);
            this.textBox6_SSS.TabIndex = 5;
            this.textBox6_SSS.Text = "SSS";
            this.textBox6_SSS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SSS_click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.textBox5_Tel);
            this.panel8.Location = new System.Drawing.Point(31, 91);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 38);
            this.panel8.TabIndex = 3;
            // 
            // textBox5_Tel
            // 
            this.textBox5_Tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5_Tel.ForeColor = System.Drawing.Color.Gray;
            this.textBox5_Tel.Location = new System.Drawing.Point(8, 4);
            this.textBox5_Tel.Multiline = true;
            this.textBox5_Tel.Name = "textBox5_Tel";
            this.textBox5_Tel.Size = new System.Drawing.Size(266, 30);
            this.textBox5_Tel.TabIndex = 5;
            this.textBox5_Tel.Text = "Telephone Number";
            this.textBox5_Tel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TN_click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.textBox4_Phone);
            this.panel7.Location = new System.Drawing.Point(31, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(284, 38);
            this.panel7.TabIndex = 2;
            // 
            // textBox4_Phone
            // 
            this.textBox4_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4_Phone.ForeColor = System.Drawing.Color.Gray;
            this.textBox4_Phone.Location = new System.Drawing.Point(8, 4);
            this.textBox4_Phone.Multiline = true;
            this.textBox4_Phone.Name = "textBox4_Phone";
            this.textBox4_Phone.Size = new System.Drawing.Size(266, 30);
            this.textBox4_Phone.TabIndex = 5;
            this.textBox4_Phone.Text = "Phone Number";
            this.textBox4_Phone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PN_click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1_status);
            this.panel1.Controls.Add(this.comboBox2_Status);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 456);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1_status
            // 
            this.label1_status.AutoSize = true;
            this.label1_status.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1_status.ForeColor = System.Drawing.Color.Silver;
            this.label1_status.Location = new System.Drawing.Point(33, 68);
            this.label1_status.Name = "label1_status";
            this.label1_status.Size = new System.Drawing.Size(58, 17);
            this.label1_status.TabIndex = 3;
            this.label1_status.Text = "ID status";
            this.label1_status.Visible = false;
            // 
            // comboBox2_Status
            // 
            this.comboBox2_Status.ForeColor = System.Drawing.Color.Gray;
            this.comboBox2_Status.FormattingEnabled = true;
            this.comboBox2_Status.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed"});
            this.comboBox2_Status.Location = new System.Drawing.Point(98, 401);
            this.comboBox2_Status.Name = "comboBox2_Status";
            this.comboBox2_Status.Size = new System.Drawing.Size(151, 28);
            this.comboBox2_Status.TabIndex = 5;
            this.comboBox2_Status.Text = "Status";
            this.comboBox2_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox2_Status_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(98, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Gender";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.textBox3_Address);
            this.panel6.Location = new System.Drawing.Point(33, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 118);
            this.panel6.TabIndex = 4;
            // 
            // textBox3_Address
            // 
            this.textBox3_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3_Address.ForeColor = System.Drawing.Color.Gray;
            this.textBox3_Address.Location = new System.Drawing.Point(8, 4);
            this.textBox3_Address.Multiline = true;
            this.textBox3_Address.Name = "textBox3_Address";
            this.textBox3_Address.Size = new System.Drawing.Size(266, 111);
            this.textBox3_Address.TabIndex = 5;
            this.textBox3_Address.Text = "Address";
            this.textBox3_Address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Address_click);
            this.textBox3_Address.TextChanged += new System.EventHandler(this.textBox3_Address_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBox2_LN);
            this.panel5.Location = new System.Drawing.Point(33, 159);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 38);
            this.panel5.TabIndex = 3;
            // 
            // textBox2_LN
            // 
            this.textBox2_LN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_LN.ForeColor = System.Drawing.Color.Gray;
            this.textBox2_LN.Location = new System.Drawing.Point(8, 4);
            this.textBox2_LN.Multiline = true;
            this.textBox2_LN.Name = "textBox2_LN";
            this.textBox2_LN.Size = new System.Drawing.Size(266, 30);
            this.textBox2_LN.TabIndex = 5;
            this.textBox2_LN.Text = "Last Name";
            this.textBox2_LN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LN_click);
            this.textBox2_LN.TextChanged += new System.EventHandler(this.textBox2_LN_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBox1_FN);
            this.panel4.Location = new System.Drawing.Point(33, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 38);
            this.panel4.TabIndex = 2;
            // 
            // textBox1_FN
            // 
            this.textBox1_FN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_FN.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_FN.Location = new System.Drawing.Point(8, 4);
            this.textBox1_FN.Multiline = true;
            this.textBox1_FN.Name = "textBox1_FN";
            this.textBox1_FN.Size = new System.Drawing.Size(266, 30);
            this.textBox1_FN.TabIndex = 5;
            this.textBox1_FN.Text = "First Name";
            this.textBox1_FN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FN_click);
            this.textBox1_FN.TextChanged += new System.EventHandler(this.textBox1_FN_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox_userID);
            this.panel3.Location = new System.Drawing.Point(33, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 38);
            this.panel3.TabIndex = 1;
            // 
            // textBox_userID
            // 
            this.textBox_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_userID.ForeColor = System.Drawing.Color.Gray;
            this.textBox_userID.Location = new System.Drawing.Point(8, 4);
            this.textBox_userID.Multiline = true;
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(266, 30);
            this.textBox_userID.TabIndex = 5;
            this.textBox_userID.Text = "ID";
            this.textBox_userID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userID_click);
            this.textBox_userID.TextChanged += new System.EventHandler(this.textBox_userID_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox1_search);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1_EmpData);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(745, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee";
            this.tabPage2.Click += new System.EventHandler(this.tab_EmpData);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(597, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1_search
            // 
            this.textBox1_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_search.Location = new System.Drawing.Point(471, 8);
            this.textBox1_search.Multiline = true;
            this.textBox1_search.Name = "textBox1_search";
            this.textBox1_search.Size = new System.Drawing.Size(257, 28);
            this.textBox1_search.TabIndex = 5;
            this.textBox1_search.Text = "Search";
            this.textBox1_search.Click += new System.EventHandler(this.search_Click);
            this.textBox1_search.TextChanged += new System.EventHandler(this.textBox1_search_TextChanged);
            this.textBox1_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_textBox);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(16, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1_EmpData
            // 
            this.dataGridView1_EmpData.AllowUserToAddRows = false;
            this.dataGridView1_EmpData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1_EmpData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_EmpData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_EmpData.ColumnHeadersHeight = 25;
            this.dataGridView1_EmpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1_EmpData.EnableHeadersVisualStyles = false;
            this.dataGridView1_EmpData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1_EmpData.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1_EmpData.Name = "dataGridView1_EmpData";
            this.dataGridView1_EmpData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1_EmpData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_EmpData.RowTemplate.Height = 29;
            this.dataGridView1_EmpData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_EmpData.Size = new System.Drawing.Size(739, 440);
            this.dataGridView1_EmpData.TabIndex = 2;
            this.dataGridView1_EmpData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_EmpData_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 601);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addEmployee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_EmpData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dataGridView1_Table;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TabPage tabPage2;
        private Button button2;
        private Button button3;
        public DataGridView dataGridView1_EmpData;
        public TabControl tabControl1;
        public ComboBox comboBox2_Status;
        public ComboBox comboBox1;
        public TextBox textBox3_Address;
        public TextBox textBox2_LN;
        public TextBox textBox1_FN;
        public TextBox textBox_userID;
        public ComboBox comboBox4_BR;
        public ComboBox comboBox3_Position;
        public TextBox textBox6_SSS;
        public TextBox textBox5_Tel;
        public TextBox textBox4_Phone;
        public TextBox textBox1_search;
        public Label label1_status;
    }
}
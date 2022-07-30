namespace payroll_System
{
    partial class payroll_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1_OT = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox3_TOT = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox7_TS = new System.Windows.Forms.TextBox();
            this.compute_button1 = new System.Windows.Forms.Button();
            this.clear_button1 = new System.Windows.Forms.Button();
            this.exit_button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4_dash = new System.Windows.Forms.Label();
            this.dataGridView1_payroll = new System.Windows.Forms.DataGridView();
            this.panel16 = new System.Windows.Forms.Panel();
            this.textBox4_First = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox3_Last = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox2_Date = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox1_Time = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBox1_SSS = new System.Windows.Forms.TextBox();
            this.button1_print = new System.Windows.Forms.Button();
            this.button1_saverec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox5_Absent = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox6_TD = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox2_Late = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox4_TOL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_WD = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2_TSPD = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1_SPD = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_payroll)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "OVERTIME";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.textBox1_OT);
            this.panel6.Location = new System.Drawing.Point(18, 184);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 38);
            this.panel6.TabIndex = 7;
            // 
            // textBox1_OT
            // 
            this.textBox1_OT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_OT.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_OT.Location = new System.Drawing.Point(8, 4);
            this.textBox1_OT.Multiline = true;
            this.textBox1_OT.Name = "textBox1_OT";
            this.textBox1_OT.Size = new System.Drawing.Size(266, 30);
            this.textBox1_OT.TabIndex = 5;
            this.textBox1_OT.Text = "Regular OT (hr/s)";
            this.textBox1_OT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_OT_MouseClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.textBox3_TOT);
            this.panel8.Location = new System.Drawing.Point(18, 235);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(284, 38);
            this.panel8.TabIndex = 8;
            // 
            // textBox3_TOT
            // 
            this.textBox3_TOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3_TOT.ForeColor = System.Drawing.Color.Gray;
            this.textBox3_TOT.Location = new System.Drawing.Point(8, 4);
            this.textBox3_TOT.Multiline = true;
            this.textBox3_TOT.Name = "textBox3_TOT";
            this.textBox3_TOT.Size = new System.Drawing.Size(266, 30);
            this.textBox3_TOT.TabIndex = 5;
            this.textBox3_TOT.Text = "Total amount of OT";
            this.textBox3_TOT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_TOT_MouseClick);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Controls.Add(this.textBox7_TS);
            this.panel13.Location = new System.Drawing.Point(200, 429);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(284, 38);
            this.panel13.TabIndex = 13;
            // 
            // textBox7_TS
            // 
            this.textBox7_TS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7_TS.ForeColor = System.Drawing.Color.Gray;
            this.textBox7_TS.Location = new System.Drawing.Point(8, 4);
            this.textBox7_TS.Multiline = true;
            this.textBox7_TS.Name = "textBox7_TS";
            this.textBox7_TS.Size = new System.Drawing.Size(266, 30);
            this.textBox7_TS.TabIndex = 5;
            this.textBox7_TS.Text = "Total Salary";
            this.textBox7_TS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox7_TS_MouseClick);
            // 
            // compute_button1
            // 
            this.compute_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.compute_button1.Enabled = false;
            this.compute_button1.ForeColor = System.Drawing.Color.White;
            this.compute_button1.Location = new System.Drawing.Point(288, 480);
            this.compute_button1.Name = "compute_button1";
            this.compute_button1.Size = new System.Drawing.Size(131, 33);
            this.compute_button1.TabIndex = 14;
            this.compute_button1.Text = "Compute";
            this.compute_button1.UseVisualStyleBackColor = false;
            this.compute_button1.Click += new System.EventHandler(this.compute_button1_Click);
            // 
            // clear_button1
            // 
            this.clear_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.clear_button1.ForeColor = System.Drawing.Color.White;
            this.clear_button1.Location = new System.Drawing.Point(288, 571);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(131, 33);
            this.clear_button1.TabIndex = 15;
            this.clear_button1.Text = "Clear";
            this.clear_button1.UseVisualStyleBackColor = false;
            this.clear_button1.Click += new System.EventHandler(this.clear_button1_Click);
            // 
            // exit_button2
            // 
            this.exit_button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.exit_button2.ForeColor = System.Drawing.Color.White;
            this.exit_button2.Location = new System.Drawing.Point(288, 604);
            this.exit_button2.Name = "exit_button2";
            this.exit_button2.Size = new System.Drawing.Size(131, 33);
            this.exit_button2.TabIndex = 16;
            this.exit_button2.Text = "Back";
            this.exit_button2.UseVisualStyleBackColor = false;
            this.exit_button2.Click += new System.EventHandler(this.exit_button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 667);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLOYEE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4_dash);
            this.panel2.Controls.Add(this.dataGridView1_payroll);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(16, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 625);
            this.panel2.TabIndex = 0;
            // 
            // label4_dash
            // 
            this.label4_dash.AutoSize = true;
            this.label4_dash.Enabled = false;
            this.label4_dash.ForeColor = System.Drawing.Color.Black;
            this.label4_dash.Location = new System.Drawing.Point(304, 618);
            this.label4_dash.Name = "label4_dash";
            this.label4_dash.Size = new System.Drawing.Size(699, 20);
            this.label4_dash.TabIndex = 1;
            this.label4_dash.Text = "_________________________________________________________________________________" +
    "__________________________________";
            // 
            // dataGridView1_payroll
            // 
            this.dataGridView1_payroll.AllowUserToAddRows = false;
            this.dataGridView1_payroll.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1_payroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1_payroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1_payroll.ColumnHeadersHeight = 25;
            this.dataGridView1_payroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1_payroll.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1_payroll.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1_payroll.Name = "dataGridView1_payroll";
            this.dataGridView1_payroll.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1_payroll.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1_payroll.RowTemplate.Height = 29;
            this.dataGridView1_payroll.Size = new System.Drawing.Size(382, 498);
            this.dataGridView1_payroll.TabIndex = 11;
            this.dataGridView1_payroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_payroll_CellContentClick);
            this.dataGridView1_payroll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPayroll);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.textBox4_First);
            this.panel16.Location = new System.Drawing.Point(12, 64);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(173, 38);
            this.panel16.TabIndex = 9;
            // 
            // textBox4_First
            // 
            this.textBox4_First.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4_First.ForeColor = System.Drawing.Color.Gray;
            this.textBox4_First.Location = new System.Drawing.Point(8, 4);
            this.textBox4_First.Multiline = true;
            this.textBox4_First.Name = "textBox4_First";
            this.textBox4_First.Size = new System.Drawing.Size(162, 30);
            this.textBox4_First.TabIndex = 5;
            this.textBox4_First.Text = "First Name";
            this.textBox4_First.TextChanged += new System.EventHandler(this.textBox4_First_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Controls.Add(this.textBox3_Last);
            this.panel15.Location = new System.Drawing.Point(221, 64);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(173, 38);
            this.panel15.TabIndex = 10;
            // 
            // textBox3_Last
            // 
            this.textBox3_Last.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3_Last.ForeColor = System.Drawing.Color.Gray;
            this.textBox3_Last.Location = new System.Drawing.Point(8, 4);
            this.textBox3_Last.Multiline = true;
            this.textBox3_Last.Name = "textBox3_Last";
            this.textBox3_Last.Size = new System.Drawing.Size(162, 30);
            this.textBox3_Last.TabIndex = 5;
            this.textBox3_Last.Text = "Last Name";
            this.textBox3_Last.TextChanged += new System.EventHandler(this.textBox3_Last_TextChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.textBox2_Date);
            this.panel14.Location = new System.Drawing.Point(221, 15);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(173, 38);
            this.panel14.TabIndex = 9;
            // 
            // textBox2_Date
            // 
            this.textBox2_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_Date.ForeColor = System.Drawing.Color.Gray;
            this.textBox2_Date.Location = new System.Drawing.Point(8, 4);
            this.textBox2_Date.Multiline = true;
            this.textBox2_Date.Name = "textBox2_Date";
            this.textBox2_Date.Size = new System.Drawing.Size(162, 30);
            this.textBox2_Date.TabIndex = 5;
            this.textBox2_Date.Text = "Date";
            this.textBox2_Date.TextChanged += new System.EventHandler(this.textBox2_Date_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.textBox1_Time);
            this.panel7.Location = new System.Drawing.Point(12, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(173, 38);
            this.panel7.TabIndex = 8;
            // 
            // textBox1_Time
            // 
            this.textBox1_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_Time.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_Time.Location = new System.Drawing.Point(8, 4);
            this.textBox1_Time.Multiline = true;
            this.textBox1_Time.Name = "textBox1_Time";
            this.textBox1_Time.Size = new System.Drawing.Size(162, 30);
            this.textBox1_Time.TabIndex = 5;
            this.textBox1_Time.Text = "Time";
            this.textBox1_Time.TextChanged += new System.EventHandler(this.textBox1_Time_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(459, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 667);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INCOME";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.button1_print);
            this.panel1.Controls.Add(this.button1_saverec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.compute_button1);
            this.panel1.Controls.Add(this.clear_button1);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.exit_button2);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 649);
            this.panel1.TabIndex = 10;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Controls.Add(this.textBox1_SSS);
            this.panel17.Location = new System.Drawing.Point(326, 312);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(284, 38);
            this.panel17.TabIndex = 22;
            // 
            // textBox1_SSS
            // 
            this.textBox1_SSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_SSS.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_SSS.Location = new System.Drawing.Point(8, 4);
            this.textBox1_SSS.Multiline = true;
            this.textBox1_SSS.Name = "textBox1_SSS";
            this.textBox1_SSS.Size = new System.Drawing.Size(266, 30);
            this.textBox1_SSS.TabIndex = 5;
            this.textBox1_SSS.Text = "SSS Deduction";
            this.textBox1_SSS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_SSS_MouseClick);
            this.textBox1_SSS.TextChanged += new System.EventHandler(this.textBox1_SSS_TextChanged);
            // 
            // button1_print
            // 
            this.button1_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.button1_print.Enabled = false;
            this.button1_print.ForeColor = System.Drawing.Color.White;
            this.button1_print.Location = new System.Drawing.Point(288, 541);
            this.button1_print.Name = "button1_print";
            this.button1_print.Size = new System.Drawing.Size(131, 33);
            this.button1_print.TabIndex = 21;
            this.button1_print.Text = "Print";
            this.button1_print.UseVisualStyleBackColor = false;
            this.button1_print.Click += new System.EventHandler(this.button1_print_Click);
            // 
            // button1_saverec
            // 
            this.button1_saverec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(34)))), ((int)(((byte)(81)))));
            this.button1_saverec.ForeColor = System.Drawing.Color.White;
            this.button1_saverec.Location = new System.Drawing.Point(288, 511);
            this.button1_saverec.Name = "button1_saverec";
            this.button1_saverec.Size = new System.Drawing.Size(131, 33);
            this.button1_saverec.TabIndex = 20;
            this.button1_saverec.Text = "Save Record";
            this.button1_saverec.UseVisualStyleBackColor = false;
            this.button1_saverec.Click += new System.EventHandler(this.button1_saverec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(200, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "TOTAL SALARY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(326, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "DEDUCTION";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.textBox5_Absent);
            this.panel11.Location = new System.Drawing.Point(326, 268);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(284, 38);
            this.panel11.TabIndex = 16;
            // 
            // textBox5_Absent
            // 
            this.textBox5_Absent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5_Absent.ForeColor = System.Drawing.Color.Gray;
            this.textBox5_Absent.Location = new System.Drawing.Point(8, 4);
            this.textBox5_Absent.Multiline = true;
            this.textBox5_Absent.Name = "textBox5_Absent";
            this.textBox5_Absent.Size = new System.Drawing.Size(266, 30);
            this.textBox5_Absent.TabIndex = 5;
            this.textBox5_Absent.Text = "Absent";
            this.textBox5_Absent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox5_Absent_MouseClick);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Controls.Add(this.textBox6_TD);
            this.panel12.Location = new System.Drawing.Point(326, 356);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(284, 38);
            this.panel12.TabIndex = 17;
            // 
            // textBox6_TD
            // 
            this.textBox6_TD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6_TD.ForeColor = System.Drawing.Color.Gray;
            this.textBox6_TD.Location = new System.Drawing.Point(8, 4);
            this.textBox6_TD.Multiline = true;
            this.textBox6_TD.Name = "textBox6_TD";
            this.textBox6_TD.Size = new System.Drawing.Size(266, 30);
            this.textBox6_TD.TabIndex = 5;
            this.textBox6_TD.Text = "Total Deduction";
            this.textBox6_TD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_TD_MouseClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.textBox2_Late);
            this.panel9.Location = new System.Drawing.Point(326, 180);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 38);
            this.panel9.TabIndex = 14;
            // 
            // textBox2_Late
            // 
            this.textBox2_Late.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_Late.ForeColor = System.Drawing.Color.Gray;
            this.textBox2_Late.Location = new System.Drawing.Point(8, 4);
            this.textBox2_Late.Multiline = true;
            this.textBox2_Late.Name = "textBox2_Late";
            this.textBox2_Late.Size = new System.Drawing.Size(266, 30);
            this.textBox2_Late.TabIndex = 5;
            this.textBox2_Late.Text = "Late (hr/s)";
            this.textBox2_Late.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_Late_MouseClick);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.textBox4_TOL);
            this.panel10.Location = new System.Drawing.Point(326, 224);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(284, 38);
            this.panel10.TabIndex = 15;
            // 
            // textBox4_TOL
            // 
            this.textBox4_TOL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4_TOL.ForeColor = System.Drawing.Color.Gray;
            this.textBox4_TOL.Location = new System.Drawing.Point(8, 4);
            this.textBox4_TOL.Multiline = true;
            this.textBox4_TOL.Name = "textBox4_TOL";
            this.textBox4_TOL.Size = new System.Drawing.Size(266, 30);
            this.textBox4_TOL.TabIndex = 5;
            this.textBox4_TOL.Text = "Total amount of Late";
            this.textBox4_TOL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_TOL_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox_WD);
            this.panel3.Location = new System.Drawing.Point(200, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 38);
            this.panel3.TabIndex = 7;
            // 
            // textBox_WD
            // 
            this.textBox_WD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_WD.ForeColor = System.Drawing.Color.Gray;
            this.textBox_WD.Location = new System.Drawing.Point(8, 4);
            this.textBox_WD.Multiline = true;
            this.textBox_WD.Name = "textBox_WD";
            this.textBox_WD.Size = new System.Drawing.Size(266, 30);
            this.textBox_WD.TabIndex = 5;
            this.textBox_WD.Text = "No. of Working Days";
            this.textBox_WD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_WD_MouseClick);
            this.textBox_WD.TextChanged += new System.EventHandler(this.textBox_WD_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBox2_TSPD);
            this.panel5.Location = new System.Drawing.Point(200, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(284, 38);
            this.panel5.TabIndex = 9;
            // 
            // textBox2_TSPD
            // 
            this.textBox2_TSPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_TSPD.ForeColor = System.Drawing.Color.Gray;
            this.textBox2_TSPD.Location = new System.Drawing.Point(8, 4);
            this.textBox2_TSPD.Multiline = true;
            this.textBox2_TSPD.Name = "textBox2_TSPD";
            this.textBox2_TSPD.Size = new System.Drawing.Size(266, 30);
            this.textBox2_TSPD.TabIndex = 5;
            this.textBox2_TSPD.Text = "Total Salary per day";
            this.textBox2_TSPD.Click += new System.EventHandler(this.textBox2_TSPD_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.textBox1_SPD);
            this.panel4.Location = new System.Drawing.Point(200, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 38);
            this.panel4.TabIndex = 8;
            // 
            // textBox1_SPD
            // 
            this.textBox1_SPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_SPD.ForeColor = System.Drawing.Color.Gray;
            this.textBox1_SPD.Location = new System.Drawing.Point(8, 4);
            this.textBox1_SPD.Multiline = true;
            this.textBox1_SPD.Name = "textBox1_SPD";
            this.textBox1_SPD.Size = new System.Drawing.Size(266, 30);
            this.textBox1_SPD.TabIndex = 5;
            this.textBox1_SPD.Text = "Salary per day";
            this.textBox1_SPD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_SPD_MouseClick);
            this.textBox1_SPD.TextChanged += new System.EventHandler(this.textBox1_SPD_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // payroll_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 702);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payroll_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payroll_form";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_payroll)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Panel panel6;
        public TextBox textBox1_OT;
        private Panel panel8;
        public TextBox textBox3_TOT;
        private Panel panel13;
        public TextBox textBox7_TS;
        public Button compute_button1;
        public Button clear_button1;
        public Button exit_button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private DataGridView dataGridView1_payroll;
        private Panel panel16;
        public TextBox textBox4_First;
        private Panel panel15;
        public TextBox textBox3_Last;
        private Panel panel14;
        public TextBox textBox2_Date;
        private Panel panel7;
        public TextBox textBox1_Time;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Panel panel11;
        public TextBox textBox5_Absent;
        private Panel panel12;
        public TextBox textBox6_TD;
        private Panel panel9;
        public TextBox textBox2_Late;
        private Panel panel10;
        public TextBox textBox4_TOL;
        private Panel panel3;
        public TextBox textBox_WD;
        private Panel panel5;
        public TextBox textBox2_TSPD;
        private Panel panel4;
        public TextBox textBox1_SPD;
        private System.Windows.Forms.Timer timer1;
        public Button button1_saverec;
        public Button button1_print;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label4_dash;
        private Panel panel17;
        public TextBox textBox1_SSS;
    }
}
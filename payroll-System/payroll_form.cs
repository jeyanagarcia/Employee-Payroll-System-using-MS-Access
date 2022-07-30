using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace payroll_System
{
    public partial class payroll_form : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public OleDbConnection microsoftAccessDatabaseOleDbConnection = null;
        public string idno;


        //_><
        public menu_form main_menu;
        public payroll_form(menu_form orig)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\jeyan\source\repos\payroll-System\database.accdb; Persist Security Info=False;";
            main_menu = orig;
            dataGridView1_payroll.DataSource = GetEmployeesList();
            

        }
        public void computation()
        {
            //number of work days
            string a = textBox_WD.Text;
            int noworkday = int.Parse(a);
            //converting into int 

            string b = textBox1_SPD.Text;
            int salaryperday = int.Parse(b);

            int totalsalaryperday = noworkday * salaryperday;

            textBox2_TSPD.Text = totalsalaryperday.ToString();
            //result shared to textbox

           

            //overtime
            string c = textBox1_OT.Text;
            int ot = int.Parse(c);

            int totalot = ot * 50;
            //50 pesos every hour 

            textBox3_TOT.Text = totalot.ToString();



            //deductions 
            string d = textBox2_Late.Text;
            int late = int.Parse(d);

            int totallate = late * 20;
            //late would be minus 20 to the salary

            textBox4_TOL.Text = totallate.ToString();

            string f = textBox5_Absent.Text;
            //error e because its a default variable in the visual 

            int absent = int.Parse(f);
            int totalabsent = absent * totalsalaryperday;


            string h = textBox1_SSS.Text;
            int sss = int.Parse(h);

            int totaldeduction = (totallate + totalabsent) + sss;

            textBox6_TD.Text = totaldeduction.ToString();
            
            //just to set default value so that it will not cause an error for variable not initiated
            idno = "";

            //total salary
            int totalsalary = (totalsalaryperday + totalot) - totaldeduction;

            textBox7_TS.Text = totalsalary.ToString();

        }
        private void compute_button1_Click(object sender, EventArgs e)
        {
            button1_print.Enabled = true;

            if (textBox1_OT.Text == "" && textBox4_TOL.Text == "" && textBox5_Absent.Text == "")
            {
                textBox1_OT.Text = "0";
                textBox4_TOL.Text = "0";
                textBox5_Absent.Text = "0";

                //if the textbox is empty then their values were equals to zero
            }
            if (textBox1_OT.Text == "")
            {
                textBox1_OT.Text = "0";
            }
            if (textBox4_TOL.Text == "0")
            {
                textBox4_TOL.Text = "0";
            }
            if (textBox5_Absent.Text == "0") ;
            {
                textBox5_Absent.Text = "0";
            }
            computation();

        }

        private void clear_button1_Click(object sender, EventArgs e)
        {
            textBox_WD.Text = "";
            textBox1_SPD.Text = "";
            textBox1_OT.Text = "";
            textBox2_Late.Text = "";
            textBox5_Absent.Text = "";

            textBox7_TS.Text = "0";
            textBox3_TOT.Text = "0";
            textBox2_TSPD.Text = "0";
            textBox4_TOL.Text = "0";
            textBox6_TD.Text = "0"; 


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1_Time.Text = DateTime.Now.ToLongTimeString();
            textBox2_Date.Text = DateTime.Now.ToLongDateString();
        }

        private DataTable GetEmployeesList()
        {
            OleDbCommand command;
            DataTable dt = new DataTable();
            using (command = new OleDbCommand("SELECT IDno, FirstName, LastName, BasicRate FROM EmployeeData"))
            {
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                dt.Load(reader);
                connection.Close();
            }
            return dt;

        }

        private void datagridPayroll(object sender, DataGridViewCellEventArgs e)
        {
            compute_button1.Enabled = true;
            timer1.Start();

            
            idno = this.dataGridView1_payroll.CurrentRow.Cells[0].Value.ToString();
            textBox4_First.Text = this.dataGridView1_payroll.CurrentRow.Cells[1].Value.ToString();
            textBox3_Last.Text = this.dataGridView1_payroll.CurrentRow.Cells[2].Value.ToString();
            textBox1_SPD.Text = this.dataGridView1_payroll.CurrentRow.Cells[3].Value.ToString();
            if (textBox1_SSS.Text == "")
            {
                textBox1_SSS.Text = "0";
            }
            else
            {
                textBox1_SSS.Text = "200";
            }
        }

        private void button1_saverec_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                //to know in which connection it has to execute the command

                command.Connection = connection;
                command.CommandText = "INSERT INTO PayRoll([Time], [Date], IDno, FirstName, LastName, NoOfWorkDays, SalaryPerDay, TotalSalaryPerDay, RegularOT, TotalOT, Late, TotalLate, Absent, TotalDeduction, TotalSalary) VALUES ('" + textBox1_Time.Text + "', '" + textBox2_Date.Text + "', '" + idno + "', '" + textBox4_First.Text + "', '" + textBox3_Last.Text + "', '" + int.Parse(textBox_WD.Text) + "', '" + int.Parse(textBox1_SPD.Text) + "','" + int.Parse(textBox2_TSPD.Text) + "', '" + int.Parse(textBox1_OT.Text) + "', '" + int.Parse(textBox3_TOT.Text) + "', '" + int.Parse(textBox2_Late.Text) + "', '" + int.Parse(textBox4_TOL.Text) + "', '" + int.Parse(textBox5_Absent.Text) + "', '" + int.Parse(textBox6_TD.Text) + "', '" + int.Parse(textBox7_TS.Text) + "')";


                //query wherein select from database 
                //insert into your table name and inside the parenthesis, I want to give the name of the columns in which you want to insert the data and then values you want to insert the database  

                MessageBox.Show("Record Saved");
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error in Input");
            }
            //query command for inserting, updating and deleting data 
        }

        private void button1_print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Payroll Slip", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(320, 50));
            

            //Time and Date
            e.Graphics.DrawString("Time: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("Date: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 270));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(30, 290));

            //Name
            e.Graphics.DrawString("First Name: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 310));
            e.Graphics.DrawString("Last Name: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 330));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(30, 350));

            //Salary
            e.Graphics.DrawString("No. of Work Day(s): ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("Basic Rate: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 390));
            e.Graphics.DrawString("Total Basic Rate: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 410));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(30, 430));

            //Overtime
            e.Graphics.DrawString("Regular OT (hr/s): ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("Total amount of OT: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 470));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(30, 490));
            
            //Deduction
            e.Graphics.DrawString("Late: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 510));
            e.Graphics.DrawString("Total amount of late: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 530));
            e.Graphics.DrawString("Absent: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 550));
            e.Graphics.DrawString("Total Deduction: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 570));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(30, 590));

            //Total Salary
            e.Graphics.DrawString("Total Salary: ", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(50, 610));






            //Data

            //Time and Date
            e.Graphics.DrawString(textBox1_Time.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString(textBox2_Date.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 270));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(300, 290));

            //Name
            e.Graphics.DrawString(textBox4_First.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 310));
            e.Graphics.DrawString(textBox3_Last.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 330));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(300, 350));

            //Salary
            e.Graphics.DrawString(textBox_WD.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 370));
            e.Graphics.DrawString(textBox1_SPD.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 390));
            e.Graphics.DrawString(textBox2_TSPD.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 410));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(300, 430));

            //Overtime
            e.Graphics.DrawString(textBox1_OT.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 450));
            e.Graphics.DrawString(textBox3_TOT.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 470));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(300, 490));

            //Deduction
            e.Graphics.DrawString(textBox2_Late.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 510));
            e.Graphics.DrawString(textBox4_TOL.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 530));
            e.Graphics.DrawString(textBox5_Absent.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 550));
            e.Graphics.DrawString(textBox6_TD.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 570));
            e.Graphics.DrawString(label4_dash.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(300, 590));

            //Total Salary
            e.Graphics.DrawString(textBox7_TS.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(300, 610));


        }

        private void exit_button2_Click(object sender, EventArgs e)
        {
            //_><
            main_menu.Show();
            this.Hide();
        }

        private void textBox1_Time_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox2_Date_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_First_TextChanged(object sender, EventArgs e)
        {
            textBox4_First.ForeColor = Color.Black;
        }

        private void textBox3_Last_TextChanged(object sender, EventArgs e)
        {
            textBox3_Last.ForeColor = Color.Black;
        }

        private void dataGridView1_payroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox_WD_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_SPD_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_WD_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_WD.Text = "";
            textBox_WD.ForeColor = Color.Black;
        }

        private void textBox1_SPD_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_SPD.Text = "";
            textBox1_SPD.ForeColor = Color.Black;
        }

        private void textBox2_TSPD_Click(object sender, EventArgs e)
        {
           
            textBox2_TSPD.ForeColor = Color.Black;
        }

        private void textBox1_OT_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_OT.Text = "";
            textBox1_OT.ForeColor = Color.Black;
        }

        private void textBox3_TOT_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3_TOT.Text = "";
            textBox3_TOT.ForeColor = Color.Black;
        }

        private void textBox2_Late_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2_Late.Text = "";
            textBox2_Late.ForeColor = Color.Black;
        }

        private void textBox4_TOL_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4_TOL.Text = "";
            textBox4_TOL.ForeColor = Color.Black;

        }

        private void textBox5_Absent_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5_Absent.Text = "";
            textBox5_Absent.ForeColor = Color.Black;
        }

        private void textBox1_SSS_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1_SSS.Text = "";
            textBox1_SSS.ForeColor = Color.Black;
        }

        private void textBox6_TD_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6_TD.Text = "";
            textBox6_TD.ForeColor = Color.Black;
        }

        private void textBox7_TS_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7_TS.Text = "";
            textBox7_TS.ForeColor = Color.Black;
        }

        private void textBox1_SSS_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


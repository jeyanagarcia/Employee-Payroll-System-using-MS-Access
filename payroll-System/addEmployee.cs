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
using payroll_Func;


namespace payroll_System
{
    public partial class addEmployee : Form
    {
        function _func;
        dataFunction dfunc = new payroll_Func.dataFunction();
        private OleDbConnection connection = new OleDbConnection();
        menu_form _main;
        public OleDbConnection microsoftAccessDatabaseOleDbConnection = null;

        public addEmployee()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\jeyan\source\repos\payroll-System\database.accdb; Persist Security Info=False;";
           
            _func = new function();
            _main = new menu_form();
            dataGridView1_EmpData.DataSource = dfunc.GetEmployeesList();

        }
        public addEmployee(menu_form mainmenu)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\jeyan\source\repos\payroll-System\database.accdb; Persist Security Info=False;";

            _func = new function();
            _main = mainmenu;
            dataGridView1_EmpData.DataSource = dfunc.GetEmployeesList();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox1.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] data = new string[11];
            data[0] = textBox_userID.Text;
            data[1] = textBox1_FN.Text;
            data[2] = textBox2_LN.Text;
            data[3] = textBox3_Address.Text;
            data[4] = comboBox1.Text;
            data[5] = comboBox2_Status.Text;
            data[6] = textBox4_Phone.Text;
            data[7] = textBox5_Tel.Text;
            data[8] = textBox6_SSS.Text;
            data[9] = comboBox3_Position.Text;
            data[10] = comboBox4_BR.Text;

            dfunc.addEmpFunc(data);

        }

        private void textBox_userID_TextChanged(object sender, EventArgs e)
        {
            _func.verifyifregistered(this);
            
        }
        private void textBox1_FN_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_LN_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_Address_TextChanged(object sender, EventArgs e)
        {
        }

        private void userID_click(object sender, MouseEventArgs e)
        {
            textBox_userID.Text = "";
            textBox_userID.ForeColor = Color.Black;
        }

        private void FN_click(object sender, MouseEventArgs e)
        {
            textBox1_FN.Text = "";
            textBox1_FN.ForeColor = Color.Black;
        }

        private void LN_click(object sender, MouseEventArgs e)
        {
            textBox2_LN.Text = "";
            textBox2_LN.ForeColor = Color.Black;
        }

        private void Address_click(object sender, MouseEventArgs e)
        {
            textBox3_Address.Text = "";
            textBox3_Address.ForeColor = Color.Black;
        }

        private void comboBox2_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2_Status.Text = "";
            comboBox2_Status.ForeColor = Color.Black;
        }

        private void PN_click(object sender, MouseEventArgs e)
        {
            textBox4_Phone.Text = "";
            textBox4_Phone.ForeColor = Color.Black;
        }

        private void TN_click(object sender, MouseEventArgs e)
        {
            textBox5_Tel.Text = "";
            textBox5_Tel.ForeColor = Color.Black;
        }

        private void SSS_click(object sender, MouseEventArgs e)
        {
            textBox6_SSS.Text = "";
            textBox6_SSS.ForeColor = Color.Black;
        }

        private void comboBox3_Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3_Position.Text = "";
            comboBox3_Position.ForeColor = Color.Black;

        }

        private void comboBox4_BR_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4_BR.Text = "";
            comboBox4_BR.ForeColor = Color.Black;
        }

        private void tab_EmpData(object sender, EventArgs e)
        {
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            _func.deleteEmp(this.dataGridView1_EmpData.CurrentRow.Cells[1].Value.ToString());

            this.dataGridView1_EmpData.DataSource = dfunc.GetEmployeesList();
            //have to refresh the datagrid, so the data deleted will no longer in grid

        }

        private void clearInputFields()
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] editData = new string[11];
            editData[0] = this.dataGridView1_EmpData.CurrentRow.Cells[1].Value.ToString();
            editData[1] = this.dataGridView1_EmpData.CurrentRow.Cells[2].Value.ToString();
            editData[2] = this.dataGridView1_EmpData.CurrentRow.Cells[3].Value.ToString();
            editData[3] = this.dataGridView1_EmpData.CurrentRow.Cells[11].Value.ToString();
            editData[4] = this.dataGridView1_EmpData.CurrentRow.Cells[4].Value.ToString();
            editData[5] = this.dataGridView1_EmpData.CurrentRow.Cells[5].Value.ToString();
            editData[6] = this.dataGridView1_EmpData.CurrentRow.Cells[7].Value.ToString();
            editData[7] = this.dataGridView1_EmpData.CurrentRow.Cells[8].Value.ToString();
            editData[8] = this.dataGridView1_EmpData.CurrentRow.Cells[6].Value.ToString();
            editData[9] = this.dataGridView1_EmpData.CurrentRow.Cells[9].Value.ToString();
            editData[10] = this.dataGridView1_EmpData.CurrentRow.Cells[10].Value.ToString();

            _func.editEmp(editData,_main);

            this.dataGridView1_EmpData.DataSource = dfunc.GetEmployeesList();
        }

        private void search_textBox(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_search_TextChanged(object sender, EventArgs e)
        {
            _func.search(this);
        }

        private void search_Click(object sender, EventArgs e)
        {
            textBox1_search.Text = "";
            textBox1_search.ForeColor = Color.Black;

        }

        private void dataGridView1_EmpData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            dfunc.GetEmployeesList();
        }

        private void button4_back_Click(object sender, EventArgs e)
        {
            this.Close();
            addEmployee back = new addEmployee();
            back.Show();
        }
    }
}


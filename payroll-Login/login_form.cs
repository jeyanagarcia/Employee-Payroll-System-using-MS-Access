using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using payroll_System;

namespace payroll_Login
{
    

    public partial class Form1 : Form
    {
        function _func;
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = label1;
            _func = new function();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {   
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            userID.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            userPass.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            userPass.Text = "";
            //set to no text

            userPass.PasswordChar = '*';
            //the password character is an asterisk
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            userID.ForeColor = Color.Black;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            userPass.ForeColor = Color.Black;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calls the function from function class
            _func.login(userID.Text,userPass.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
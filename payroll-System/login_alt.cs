using System.Data;
//Represents a set of SQL commands and a database connection that are used to fill the DataSet and update the data source.
using System.Data.OleDb;
//	Represents an SQL statement or stored procedure to execute against a data source.
using System.Linq;
//Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.
using System.Threading.Tasks;
using System.Drawing;
//graphics basic functionality
using System.Data.SqlClient;
//Represents a Transact-SQL statement or stored procedure to execute against a SQL Server database.
using System.Windows.Forms;

namespace payroll_System
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
    }
}
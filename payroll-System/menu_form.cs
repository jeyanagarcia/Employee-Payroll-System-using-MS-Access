using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_System
{
    public partial class menu_form : Form
    {
        function _func;
        public menu_form()
        {
            InitializeComponent();
            _func = new function();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _func.ShowAddEmp(this);
        }

        private void button1_LogOut_Click(object sender, EventArgs e)
        {
            _func.Logout(this);
        }

        private void label3_close_Click(object sender, EventArgs e)
        {
            
        }
        private void button4_Payroll_Click(object sender, EventArgs e)
        {

            _func.ShowPayroll(this);
        }

        private void button3_Home_Click(object sender, EventArgs e)
        {
            _func.ShowHome(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}

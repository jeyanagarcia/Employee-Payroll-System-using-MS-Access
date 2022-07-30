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
    public partial class update_form : Form
    {
        function _func;
        private OleDbConnection connection = new OleDbConnection();
        public update_form()
        {
            InitializeComponent();
            _func = new function();
        }
        
        private void update_button1_Click(object sender, EventArgs e)
        {

            _func.updateEmp(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textBox6_SSS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

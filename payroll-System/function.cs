using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using payroll_Func;

namespace payroll_System
{
    public class function
    {
        private OleDbConnection connection = new OleDbConnection();
        dataFunction dfunc;
        //On Log in form there is only 1 function which is Login
        //Encapsulation
        public function()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Program\payroll-System\database.accdb; Persist Security Info=False;";
            dfunc = new payroll_Func.dataFunction();
        }
        public void login(string user, string pass)
        {
            //check if password and username 3
            //if right 4
            //proceed next form 2
            //show form menu 1
            if (dfunc.auth(user, pass) == true)
            {
                menu_form frm = new menu_form();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }
        
        

        //MENU FUNCTION

        public void ShowHome(menu_form menu)
        {
            menu.panel3.Controls.Clear();
        }

        public void ShowAddEmp(menu_form menu)
        {
            //task 1 create an new object which is add employee form /
            //task 2 put add employee to panel to show the form insdie the panel /
            //taSK 3 IS HOW CAN WE PUT EMPLOYEE FORM TO MENU PANEL USING THIS METHOD
            // THEREFORE WE SHOULD CALL MENU PANEL FROM MENU TO HERE

            addEmployee f4 = new addEmployee(menu);
            f4.TopLevel = false;
            f4.AutoScroll = true;
            menu.panel3.Controls.Add(f4);
            f4.Show();
        }

        public void ShowPayroll(menu_form menu)
        {
            payroll_form f5 = new payroll_form(menu);
            f5.Show();
        }

        public void Logout(menu_form menu)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                menu.Close();
                payroll_System.Form1 f2 = new payroll_System.Form1();
                f2.Show();
            }

            else if (result == DialogResult.No)
            {

            }
        }


        //AddEmp Function
        

        public void verifyifregistered(addEmployee Currentform)
        {
            if (!string.IsNullOrEmpty(Currentform.textBox_userID.Text))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM EmployeeData WHERE IDno = @Name", connection);
                command.Parameters.AddWithValue("@Name", Currentform.textBox_userID.Text);

                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Currentform.label1_status.Visible = true;
                    Currentform.label1_status.Text = "ID is already taken.";
                    Currentform.label1_status.ForeColor = Color.Red;
                }
                else if (Currentform.textBox_userID.Text == "")
                {
                    Currentform.label1_status.Visible = false;
                }
                else
                {
                    Currentform.label1_status.Visible = true;
                    Currentform.label1_status.Text = "This ID is available";
                    Currentform.label1_status.ForeColor = Color.Green;
                }
                connection.Close();
            }
        }

        


        //First tab of Add emp:tab 2 function 
        public void editEmp(String[] data, menu_form main)
        {
            update_form frm = new update_form();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.textBox_userID.Text = data[0];
            frm.textBox1_FN.Text = data[1];
            frm.textBox2_LN.Text = data[2];
            frm.textBox3_Address.Text = data[3];
            frm.comboBox1.Text = data[4];
            frm.comboBox2_Status.Text = data[5];
            frm.textBox4_Phone.Text = data[6];
            frm.textBox5_Tel.Text = data[7];
            frm.textBox6_SSS.Text = data[8];
            frm.comboBox3_Position.Text = data[9];
            frm.comboBox4_BR.Text = data[10];


            main.panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        public void deleteEmp(string idno)
        {
            try
            {
                string DeleteDataFromMicrosoftAccessDatabaseQuery = "DELETE from EmployeeData WHERE IDno = ?";

                if (String.IsNullOrEmpty(idno))
                {
                    MessageBox.Show("ID field is empty, click on datagrid row cell first.");
                }
                else
                {
                    connection.Close();
                    OleDbCommand command = new OleDbCommand();


                    command.Connection = connection;


                    command = new OleDbCommand(DeleteDataFromMicrosoftAccessDatabaseQuery, connection);
                    command.Parameters.AddWithValue("IDno", OleDbType.Integer).Value = idno.ToString();
                    connection.Open();
                    MessageBox.Show(DeleteDataFromMicrosoftAccessDatabaseQuery);

                    int deleteDataFromMicrosoftAccess = command.ExecuteNonQuery();

                    if (deleteDataFromMicrosoftAccess > 0)
                    {
                        MessageBox.Show("Data deleted");

                        clearInput();

                        connection.Close();
                        //have to refresh the datagrid, so the data deleted will no longer in grid

                    }
                    else
                    {
                        MessageBox.Show("Error updating.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void search(addEmployee Currentform)
        {
            connection.Close();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command = new OleDbCommand("SELECT IDno, FirstName, LastName, Address, Gender, Status, PhoneNumber, TelephoneNumber, SSS, `Position`, BasicRate FROM EmployeeData WHERE IDno like '%" + Currentform.textBox1_search.Text + "%'", connection);
            connection.Open();

            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = command;
            da.Fill(dt);
            Currentform.dataGridView1_EmpData.DataSource = dt;

            connection.Close();
        }
        public void clearInput()
        {
            addEmployee f4 = new addEmployee();

            //checking if all input fields are empty
            if (String.IsNullOrEmpty(f4.textBox_userID.Text) && String.IsNullOrEmpty(f4.textBox1_FN.Text) && String.IsNullOrEmpty(f4.textBox2_LN.Text) && String.IsNullOrEmpty(f4.textBox3_Address.Text) && String.IsNullOrEmpty(f4.comboBox1.Text) && String.IsNullOrEmpty(f4.comboBox2_Status.Text) && String.IsNullOrEmpty(f4.textBox4_Phone.Text) && String.IsNullOrEmpty(f4.textBox5_Tel.Text) && String.IsNullOrEmpty(f4.textBox6_SSS.Text) && String.IsNullOrEmpty(f4.comboBox3_Position.Text) && String.IsNullOrEmpty(f4.comboBox4_BR.Text))
            {
                MessageBox.Show("All input fields are empty.");
            }
            else
            {

                //clearing
                //so, in this code i experienced some errors because i dont put .text into the code
                //it tried to change the textbox itself insead of text
                f4.textBox_userID.Text = String.Empty;
                f4.textBox1_FN.Text = String.Empty;
                f4.textBox2_LN.Text = String.Empty;
                f4.textBox3_Address.Text = String.Empty;
                f4.comboBox1.Text = String.Empty;
                f4.comboBox2_Status.Text = String.Empty;
                f4.textBox4_Phone.Text = String.Empty;
                f4.textBox5_Tel.Text = String.Empty;
                f4.textBox5_Tel.Text = String.Empty;
                f4.comboBox3_Position.Text = String.Empty;
                f4.comboBox4_BR.Text = String.Empty;
            }
        }

        //edit addemp func proceed to update form 
        public void updateEmp(update_form thisform)
        {
            string UpdateDataFromMicrosoftAccessDatabaseQuery = "UPDATE EmployeeData SET IDno = ?, FirstName = ?, LastName = ?, Address = ?, Gender = ?, Status = ?, PhoneNumber = ?, TelephoneNumber = ?, SSS = ?, `Position` = ?, BasicRate = ? WHERE IDno = ?";
            if (String.IsNullOrEmpty(thisform.textBox_userID.Text))
            {
                MessageBox.Show("Click on data.");
            }
            else
            {
                connection.Close();
                OleDbCommand command = new OleDbCommand();
                //to know in which connection it has to execute the command

                //to know in which connection it has to execute the command
                command.Connection = connection;

                command = new OleDbCommand(UpdateDataFromMicrosoftAccessDatabaseQuery, connection);
                command.Parameters.AddWithValue("IDno", OleDbType.Integer).Value = thisform.textBox_userID.Text;
                command.Parameters.AddWithValue("FirstName", OleDbType.VarChar).Value = thisform.textBox1_FN.Text;
                command.Parameters.AddWithValue("LastName", OleDbType.VarChar).Value = thisform.textBox2_LN.Text;
                command.Parameters.AddWithValue("Address", OleDbType.VarChar).Value = thisform.textBox3_Address.Text;
                command.Parameters.AddWithValue("Gender", OleDbType.VarChar).Value = thisform.comboBox1.Text;
                command.Parameters.AddWithValue("Status", OleDbType.VarChar).Value = thisform.comboBox2_Status.Text;
                command.Parameters.AddWithValue("PhoneNumber", OleDbType.Integer).Value = thisform.textBox4_Phone.Text;
                command.Parameters.AddWithValue("TelephoneNumber", OleDbType.Integer).Value = thisform.textBox5_Tel.Text;
                command.Parameters.AddWithValue("SSS", OleDbType.Integer).Value = thisform.textBox6_SSS.Text;
                command.Parameters.AddWithValue("Position", OleDbType.VarChar).Value = thisform.comboBox3_Position.Text;
                command.Parameters.AddWithValue("BasicRate", OleDbType.Integer).Value = thisform.comboBox4_BR.Text;
                command.Parameters.AddWithValue("IDno", OleDbType.Integer).Value = thisform.textBox_userID.Text;

                connection.Open();
                //open microdoft database connection

                int updateDataFromMicrosoftAccess = command.ExecuteNonQuery();

                if (updateDataFromMicrosoftAccess > 0)
                {
                    MessageBox.Show("Data updated to data grid and database.");

                    //clear input fields

                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Error in updating.");
                }

            }

        }
        public void updateBack()
        {
            update_form f6 = new update_form();
            f6.Close();

            addEmployee back = new addEmployee();
            back.Show();
        }
    }

}

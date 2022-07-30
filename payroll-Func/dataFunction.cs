using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace payroll_Func
{
    public class dataFunction
    {

        private OleDbConnection connection = new OleDbConnection();
        public dataFunction()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\Program\payroll-System\database.accdb; Persist Security Info=False;";
        }
        public Boolean auth(string user, string pass)
        {
            //Returns true or false for authentication
            //Database Authetication
            if (DbAuth(user, pass) == true)
            {
                return true;
            }
            return false;
        }

        public Boolean DbAuth(string user, string pass)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            //to know in which connection it has to execute the command
            command.Connection = connection;
            command.CommandText = "select * from Account where Username= '" + user + "' and Password = '" + pass + "'";
            //query wherein select from database 
            //whenever you want to select or whenever want to execute a select query which will give you some data 
            OleDbDataReader reader = command.ExecuteReader();
            //query command that gives some values

            int count = 0;
            // to count the number of result which are coming from the execution of the query 
            while (reader.Read())
            // read all your datas 
            {
                count = count + 1;
                //count ++
                //query will goes here, if the query is equal to one then its in the next line of code
            }
            connection.Close();

            if (count == 1) //we have only single one entry in our database user has entered
            {
                return true;
                //this will open our form 2

            }
            else
            {
                return false;
            }
        }

        public void addEmpFunc(String[] data)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                //to know in which connection it has to execute the command

                command.Connection = connection;
                command.CommandText = "INSERT INTO EmployeeData(IDno, FirstName, LastName, Address, Gender, Status, PhoneNumber, TelephoneNumber, SSS, `Position`, BasicRate) VALUES " +
                    "('" + data[0] + "', '" + data[1] + "', '" + data[2] + "', '" + data[3] + "', '" + data[4] + "', '" + data[5] + "','" + int.Parse(data[6]) + "', '" + int.Parse(data[7]) + "', '" + data[8] + "', '" + data[9] + "', '" + int.Parse(data[10]) + "')";
                //query wherein insert from database 
                //insert table name and inside the parenthesis, I want to give the name of the columns in which you want to insert the data and then values you want to insert the database  

                MessageBox.Show("Data Saved");
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error in Input");
            }
           
        }

        public DataTable GetEmployeesList()
        {

            DataTable dt = new DataTable();
            using (OleDbCommand command = new OleDbCommand("SELECT * FROM EmployeeData"))
            {
                command.Connection = connection;
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                dt.Load(reader);
                connection.Close();
            }

            return dt;
        }







    }

}

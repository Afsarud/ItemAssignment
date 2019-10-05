using CoffeeShopAssignmentUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAssignmentUI.Repository
{
    class CustomerRepository
    {
        Customer _customer = new Customer();

        public void addCustomer(Customer customer)
        {
            
            try
            {

                //Connectionstring
                string connectionString = @"server=DESKTOP-U56OU4N\SA; database= CoffeeShopAssignmentUI; Integrated Security= True";
                SqlConnection sqlconnection = new SqlConnection(connectionString);


                /* CommandString*/
                string sqlcommand = @"insert into Customers values ('" + customer.Name + "', '" + customer.Contact + "', '" +customer.Address + "','"+customer.District+"');";
                SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlconnection);

                //connection Open

                sqlconnection.Open();

                int isExecute = sqlCommand.ExecuteNonQuery();
                sqlconnection.Close();

                if (isExecute > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not saved");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("exception error");
            }
        }
        public bool IsNameExsist(Customer customer)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Items WHERE Name='" + customer.Name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return exists;
        }
        public DataTable Display()
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customers";
                //string commandString = @"Select * FROM OrdersDetailsView";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                //if (dataTable.Rows.Count > 0)
                //{
                //    showDataGridView.DataSource = dataTable;
                //}
                //else
                //{
                //    MessageBox.Show("No Data Found");
                //}

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }
    }
}

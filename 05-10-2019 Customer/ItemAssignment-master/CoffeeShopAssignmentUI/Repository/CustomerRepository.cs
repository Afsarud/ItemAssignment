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

        public bool AddCustomer(Customer customer)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @" Insert into Customers values( '" + customer.Code + "'+'" + customer.Name+"','"+customer.Address+"','"+customer.Contact+"','"+customer.District+"')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }
                
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            return isAdded;

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
                string commandString = @"SELECT * FROM Items WHERE Name='" + customer.Contact + "'";
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
              
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return dataTable;
        }

       public DataTable CustomerComboBox()
        {
            DataTable dataTable = new DataTable();
           
            string ConnectioString = @"Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectioString);

            string CommandString = @"SELECT Id, District FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        
        }
        public DataTable CustomerSearch(Customer customer)
        {
            DataTable dataTable = new DataTable();
            try
            {

                string ConnectioString = @"Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(ConnectioString);

                string CommandString = @"SELECT * FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();

              
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return dataTable;

        }
        public bool Update(Customer customer)
        {
            try
            {
                //Connection
                string connectionString = @"Server= Server=DESKTOP-U56OU4N\SA; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Items SET Name =  '" + customer.Id + "' ,'" + customer.Name + "' , Price = " + customer.Address + " , Price = " + customer.Contact + " WHERE ID = " + customer.Id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            return false;
        }
    }
}

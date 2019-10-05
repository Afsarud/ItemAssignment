using CoffeeShopAssignmentUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAssignmentUI.Repository
{
   public class OrderRepository
    {
        public DataTable GetAllItem()
        {
            DataTable dataTable = new DataTable();
            
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-GIE8L6J; Database= CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT Id,Name FROM Items";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
               
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
               
                

            }
            catch (Exception exeption)
            {
               MessageBox.Show(exeption.Message);
            }


            return dataTable;
        }
        public DataTable GetAllCustomer()
        {
            DataTable dataTable = new DataTable();

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-GIE8L6J; Database= CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT Id,Name FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();



            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }


            return dataTable;
        }
        public bool AddOrder(Order order)
        {
            bool isAdded = false;

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-GIE8L6J; Database= CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"INSERT INTO Orders VALUES (" + order.CustomerId + ", " + order.ItemId + "," + order.Quantity + ", " + order.TotalPrice + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isisAdded = sqlCommand.ExecuteNonQuery();
                if (isisAdded > 0)
                {
                    isAdded = true;
                }
            
               
                sqlConnection.Close();



            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }


            return isAdded;
        }
        public bool IsNullOrEmpty( Order order)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-GIE8L6J; Database=CoffeeShopAssignmentUI; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Items WHERE Quantity ='" + order.Quantity + "'";
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
    }
}

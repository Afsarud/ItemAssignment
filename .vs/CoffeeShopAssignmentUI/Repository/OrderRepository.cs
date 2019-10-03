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
                string connectionString = @"Server=DESKTOP-U56OU4N\SA; Database= CoffeeShopAssignmentUI; Integrated Security=True";
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
               //MessageBox.Show(exeption.Message);
            }


            return dataTable;
        }
        public DataTable GetAllCustomer()
        {
            DataTable dataTable = new DataTable();

            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-U56OU4N\SA; Database= CoffeeShopAssignmentUI; Integrated Security=True";
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
                //MessageBox.Show(exeption.Message);
            }


            return dataTable;
        }
    }
}

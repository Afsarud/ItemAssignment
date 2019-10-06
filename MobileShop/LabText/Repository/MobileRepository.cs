using LabText.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabText.Repository
{
    class MobileRepository
    {
       public bool Add(Mobile mobile)
        {
            bool IsAdded = true;
            //Connection 
            string connectionString = @"server = DESKTOP-GIE8L6J; Database= MobileShop; Integrated Security= True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Command 
            string commandString = @"insert into Mobile values('"+ mobile.Name+ "','"+mobile.IMEI+"','"+mobile.Price+"')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            int IsExecute = sqlCommand.ExecuteNonQuery();

            //if (IsExecute > 0)
            //{
            //    MessageBox.Show("Save");
            //}
            sqlConnection.Close();
            return IsAdded;
        }
    }
}

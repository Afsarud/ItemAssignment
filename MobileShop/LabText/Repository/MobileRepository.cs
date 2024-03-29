﻿using LabText.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                bool IsAdded = false;
                    try
                        {
                            //Connection 
                            string connectionString = @"server = DESKTOP-GIE8L6J; Database= MobileShop; Integrated Security= True ";
                            SqlConnection sqlConnection = new SqlConnection(connectionString);

                            // Command 
                            string commandString = @"insert into Mobile values('" + mobile.Name + "','" + mobile.IMEI + "','" + mobile.Price + "')";
                            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                            sqlConnection.Open();


                            int isExecuted = sqlCommand.ExecuteNonQuery();

                            if (isExecuted > 0)
                            {
                                IsAdded = true;
                            }
                            sqlConnection.Close();
                
                        }
                        catch (Exception exception)
                        {

                            MessageBox.Show(exception.Message);
                        }
                return IsAdded;
            }

        public bool IsEMEIExist(Mobile mobile)
        {
            bool IsExist = false;
                try
                {
                    //Connection 
                    string connectionString = @"server = DESKTOP-GIE8L6J; Database= MobileShop; Integrated Security= True ";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    // Command 

                    string commandString = @"select * from Mobile where IMEI = '" + mobile.IMEI + "'";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);
                    sqlConnection.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        IsExist = true;
                    }
                
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            return IsExist;
        }

        public DataTable SearchValue(Mobile mobile)
        {
            DataTable dataTable = new DataTable();
            
            //SqlConnection
            string connectionString = @"server = DESKTOP-GIE8L6J; Database= MobileShop; Integrated Security= True ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Command 

            string commandString = @"Select * from  Mobile where Price between '"+mobile.PriceFrom+"' AND '"+mobile.PriceTo+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
           

            //Close
            sqlConnection.Close();
            return dataTable;
        }


    }
}

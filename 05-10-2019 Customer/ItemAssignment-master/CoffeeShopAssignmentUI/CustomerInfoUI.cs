using CoffeeShopAssignmentUI.BLL;
using CoffeeShopAssignmentUI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAssignmentUI
{
    public partial class CustomerInfoUI : Form
    {
        CustomerManager _CustomerManager = new CustomerManager();
        Customer _customer = new Customer();
        public CustomerInfoUI()
        {
            InitializeComponent();
        }

        private void CustomerInfoUI_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _CustomerManager.CustomerComboBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _customer.Name = nameTextBox.Text;
            //Check UNIQUE
            if (_CustomerManager.IsNameExsist(_customer))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exists!");
                return;
            }
           
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(_customer.Name))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }
            
            _customer.Contact =contactTextBox.Text;

            if (String.IsNullOrEmpty(_customer.Contact))
            {
                MessageBox.Show("Contact Can not be Empty!!!");
                return;
            }
            else if (_customer.Contact.Length!=11)
            {
                MessageBox.Show("Contact Can not be less then 11 !!!");
                return;
            }

             _customer.Address = addressTextBox.Text;
            //ComboBox value
            _customer.District = districtComboBox.Text;
            showDataGridView.DataSource="District" + districtComboBox.SelectedValue;
            
        
            //Add/Insert Item
            bool isAdded = _CustomerManager.AddCustomer(_customer);

            if (isAdded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
          
            showDataGridView.DataSource = _CustomerManager.Display();
            nameTextBox.Clear();
            nameTextBox.Clear();
            contactTextBox.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _customer.Id =Convert.ToInt32 (_customer);
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Feild id Empty !!");
                return;
            }

            showDataGridView.DataSource = _CustomerManager.CustomerSearch();
            nameTextBox.Clear();
            nameTextBox.Clear();
            contactTextBox.Clear();
        }
    }
}

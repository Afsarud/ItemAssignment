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

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //int Id = Convert.ToInt32(idTextBox.Text);
            //string Name = nameTextBox.Text;
            ////string Contact = contactTextBox.Text;
            //string Address = addressTextBox.Text;
            //string District = districtComboBox.Text;
            

            _customer.Name = nameTextBox.Text;
            //Check UNIQUE
            if (_CustomerManager.IsNameExsist(_customer))
            {
                MessageBox.Show(nameTextBox.Text + "Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            //Add/Insert Item
            _CustomerManager.addCustomer(_customer);

            //if (isAdded)
            //{
            //    MessageBox.Show("Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Not Saved");
            //}
            showDataGridView.DataSource = _CustomerManager.Display();
            nameTextBox.Clear();
            contactTextBox.Clear();
            addressTextBox.Clear();

        }
    }
}

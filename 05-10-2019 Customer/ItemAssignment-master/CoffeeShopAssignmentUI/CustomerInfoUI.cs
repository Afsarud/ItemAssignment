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
            updateButton.Hide();
        }

        private void CustomerInfoUI_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _CustomerManager.CustomerComboBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            if (_CustomerManager.IsNameExsist(_customer))
            {
                _customer.Id = Convert.ToInt32(codeTextBox.Text);
                MessageBox.Show("Code is dublicat !!");
                return;
            }
            
            if(codeTextBox.Text.Length!=4)
            {
                MessageBox.Show("length 4 digit");
                return;
            }
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
            //Mandatory
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Feild id Empty !!");
                return;
            }

            showDataGridView.DataSource = _CustomerManager.CustomerSearch(_customer);
            nameTextBox.Clear();
            nameTextBox.Clear();
            contactTextBox.Clear();
        }

        private void showDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                saveButton.Hide();
                updateButton.Text.Count();
                showDataGridView.CurrentRow.Selected = true;
                //string id = showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                //var st = (from s in db._customer where s.ID == int.Parse(id) select ToString());
                //db.MyInfotabs.DeleteOnSubmit(st);
                //db.submitChanges();
                //MessageBox.Show("Delete successfull");
                //loaddata();
                
                codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                districtComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["District"].FormattedValue.ToString();
            }
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            saveButton.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Unique Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }
            _customer.Name = nameTextBox.Text;
            _customer.Contact = contactTextBox.Text;
            _customer.Address = addressTextBox.Text;
            if (_CustomerManager.Update(_customer))
            {
                MessageBox.Show("Updated");
                showDataGridView.DataSource = _CustomerManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }
    }
}

﻿using CoffeeShopAssignmentUI.BLL;
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
    public partial class OrderAssignmentUI : Form
    {
        OrderManager _orderManager = new OrderManager();
        Order _order = new Order();
        public OrderAssignmentUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _order.ItemId = Convert.ToInt32(itemComboBox.SelectedValue);
            MessageBox.Show(""+_order.ItemId);
            _order.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
            MessageBox.Show("" + _order.CustomerId);
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int totalPrice = Convert.ToInt32(totalPriceTextBox.Text);
            totalPrice = _order.ItemId * quantity;
            dataGridView1.DataSource = totalPrice+""+ _order.ItemId+""+ _order.CustomerId+""+ quantity;
        
        }

        private void OrderAssignmentUI_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _orderManager.GetAllItem();
            customerComboBox.DataSource = _orderManager.GetAllCustomer();
        }
    }
}

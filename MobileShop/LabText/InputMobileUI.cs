using System;
using LabText.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabText.Model;

namespace LabText
{
    public partial class InputMobileUI : Form
    {
        public InputMobileUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MobileManager _mobileManager = new MobileManager();
            Mobile _mobile = new Mobile();

            //Mandetory
            _mobile.Name = nameTextBox.Text;
            if (string.IsNullOrEmpty(_mobile.Name))
            {
                MessageBox.Show("Empty name not possible!!");
                return;
            }
            
            //Mandetory
            _mobile.IMEI = imeiTextBox.Text;
            if (string.IsNullOrEmpty(_mobile.IMEI))
            {
                MessageBox.Show("Empty IMEI not possible!!");
                return;
            }
            
            if (_mobile.IMEI.Length != 11)
            {
                MessageBox.Show("Please enter 11 digit !!");
                return;
            }

            if (_mobileManager.IsEMEIExist(_mobile))
            {
                MessageBox.Show(_mobile.IMEI + "Already Exist !!!");
                return;
            }

            // unique
            //_item.Name = nameTextBox.Text;
            ////Check UNIQUE
            //if (_itemManager.IsNameExists(_item))
            //{
            // MessageBox.Show(nameTextBox.Text + "Already Exists!");
            // return;
            //}


            //Mandetory
            _mobile.Price = Convert.ToInt32(priceTextBox.Text);
            
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Empty Price not possible!!");
                return;
            }

            //bool IsInsert = _mobileManager.Add(_mobile);

            if (_mobileManager.Add(_mobile))
            {
                MessageBox.Show("Saved");
            }

            nameTextBox.Clear();
            imeiTextBox.Clear();
            priceTextBox.Clear();
        }
    }
}

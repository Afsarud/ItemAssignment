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

            try
            {
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

                if (_mobile.IMEI.Length != 15)
                {
                    MessageBox.Show("Please enter 15 digit !!");
                    return;
                }
                //Unique
                if (_mobileManager.IsEMEIExist(_mobile))
                {
                    MessageBox.Show(_mobile.IMEI + "Already Exist !!!");
                    return;
                }

                //Mandetory
                _mobile.Price = Convert.ToInt32(priceTextBox.Text);

                if (string.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Empty Price not possible!!");
                    return;
                }

                if (_mobileManager.Add(_mobile))
                {
                    MessageBox.Show("Saved");
                }

                nameTextBox.Clear();
                imeiTextBox.Clear();
                priceTextBox.Clear();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            
        }
    }
}

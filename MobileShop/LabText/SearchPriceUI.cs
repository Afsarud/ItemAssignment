using LabText.BLL;
using LabText.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabText
{
    public partial class SearchPriceUI : Form
    {
        public SearchPriceUI()
        {
            InitializeComponent();
        }

        private void priceSearchButton_Click(object sender, EventArgs e)
        {

            MobileManager _mobileManager = new MobileManager();
            Mobile mobile = new Mobile();

            int PriceFrom = Convert.ToInt32(priceFromFieldTextBox.Text);
            int PriceTo = Convert.ToInt32(priceToFieldTextBox.Text);

            mobile.PriceFrom = Convert.ToInt32(priceFromFieldTextBox.Text);
            mobile.PriceTo = Convert.ToInt32(priceToFieldTextBox.Text);

            resultDataGridView.DataSource = _mobileManager.SearchValue(mobile);

        }

        private void resultDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            resultDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();

            //this.showDataGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }
    }
}

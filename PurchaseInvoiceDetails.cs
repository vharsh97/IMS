using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        Retrieval r = new Retrieval();

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void purDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(purDD.SelectedIndex != -1 && purDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purDD.SelectedValue.ToString()), dataGridView1, productIDGV, productNameGV, quantityGV, perUnitPriceGV, totalAmountGV);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
        }
    }
}

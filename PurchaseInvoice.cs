using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoice : Sample2
    {
        Retrieval r = new Retrieval();
        int productID;
        string[] productArr = new string[4];
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", suplierDD, "Company", "ID");
        }

        private void barcodeTxt_TextChanged(object sender, EventArgs e)
        {
            if (barcodeTxt.Text != "")
            {
                productArr = r.getProductsWRTBarcode(barcodeTxt.Text);
                productID = Convert.ToInt32(productArr[0]);
                productTxt.Text = productArr[1];
                perUnitTxt.Text = productArr[2];
                string barco = productArr[3];
                productTxt.Enabled = false;
                perUnitTxt.Enabled = false;
                if(barco != null)
                {
                    quantityTxt.Focus();
                }
            }
            else
            {
                productID = 0;
                productTxt.Text = "";
                perUnitTxt.Text = "";
                Array.Clear(productArr, 0, productArr.Length);
            }
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            if(quantityTxt.Text != "")
            {
                if (rg.Match(quantityTxt.Text).Success)
                {
                    float quan, price, total;
                    quan = Convert.ToSingle(quantityTxt.Text);
                    price = Convert.ToSingle(perUnitTxt.Text);
                    total = quan * price;
                    totLabel.Text = total.ToString("###########.##");
                }
                else
                {
                    quantityTxt.SelectAll();
                }
            }
            else
            {
                totLabel.Text = "0.00";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (suplierDD.SelectedIndex == -1) { supplierErrorLabel.Visible = true; } else { supplierErrorLabel.Visible = false; }
            if (quantityTxt.Text == "") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false; }
            if (barcodeTxt.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (supplierErrorLabel.Visible || quantityErrorLabel.Visible || barcodeErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTxt.Text, quantityTxt.Text, perUnitTxt.Text, totLabel.Text);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoice : Sample2
    {
        Retrieval r = new Retrieval();
        int productID;
        float gt;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        int co;
        Updation u = new Updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                Insertion i = new Insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, Retrieval.USER_ID, Convert.ToInt32(suplierDD.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString()));
                        if (r.checkProductPriceExistance(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString())))
                        {
                            u.updateProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["perUnitPriceGV"].Value.ToString()));
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()));
                        }
                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                        if(ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        MainClass.showMSG("Purchase Invoice Created Successfully", "Success", "Success");
                    }
                    else
                    {
                        MainClass.showMSG("Unable to create Purchase Invoice", "Error", "Error");
                    }
                    sc.Complete();
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);

        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", suplierDD, "Company", "ID");
        }

        string[] productArr = new string[6];
        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {

            if (barcodeTxt.Text != "")
            {
                productArr = r.getProductsWRTBarcode(barcodeTxt.Text);
                productID = Convert.ToInt32(productArr[0]);
                productTxt.Text = productArr[1];
                string barco = productArr[2];
                productTxt.Enabled = false;
                if (barco != null)
                {
                    perUnitTxt.Focus();
                }
            }
            else
            {
                productID = 0;
                productTxt.Text = "";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void perUnitTxt_TextChanged(object sender, EventArgs e)
        {
            if(perUnitTxt.Text != "")
            {
                if (!rg.Match(perUnitTxt.Text).Success)
                {
                    perUnitTxt.Text = "";
                    perUnitTxt.Focus();
                }
            }
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
                gt += Convert.ToSingle(totLabel.Text);
                grossLabel.Text = gt.ToString();
                productID = 0;
                productTxt.Text = "";
                perUnitTxt.Text = "";
                barcodeTxt.Text = "";
                quantityTxt.Text = "";
                totLabel.Text = "0.00";
                Array.Clear(productArr, 0, productArr.Length);
            }
        }
    }
}

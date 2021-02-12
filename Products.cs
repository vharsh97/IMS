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
    public partial class Products : Sample2
    {
        int edit = 0; // This 0 is an indication to save operation and 1 is an indication to update operation.
        int productID;
        Retrieval r = new Retrieval();
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (productText.Text == "") { productErrorLabel.Visible = true; } else { productErrorLabel.Visible = false; }
            if (barcodeText.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryDatePicker.Value < DateTime.Now) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "Invalid Date"; } else { expiryErrorLabel.Visible = false; }
            if(expiryDatePicker.Value.Date == DateTime.Now.Date) { expiryErrorLabel.Visible = false; }
            if (priceText.Text == "") { priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
            if (productErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || priceErrorLabel.Visible || categoryErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                if (edit == 0) //code for save operation
                {
                    Insertion i = new Insertion();
                    if(expiryDatePicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(productText.Text, barcodeText.Text, Convert.ToSingle(priceText.Text), Convert.ToInt32(categoryDD.SelectedValue), null);
                    }
                    else
                    {
                        i.insertProduct(productText.Text, barcodeText.Text, Convert.ToSingle(priceText.Text), Convert.ToInt32(categoryDD.SelectedValue), expiryDatePicker.Value);
                    }
                    r.showProducts(dataGridView1, productIDGV, productNameGV, expiryGV, categoryGV, priceGV, barcodeGV, categoryIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //code for edit operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (expiryDatePicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(productID, productText.Text, barcodeText.Text, Convert.ToSingle(priceText.Text), Convert.ToInt32(categoryDD.SelectedValue), null);
                        }
                        else
                        {
                            u.updateProduct(productID, productText.Text, barcodeText.Text, Convert.ToSingle(priceText.Text), Convert.ToInt32(categoryDD.SelectedValue), expiryDatePicker.Value);
                        }
                        r.showProducts(dataGridView1, productIDGV, productNameGV, expiryGV, categoryGV, priceGV, barcodeGV, categoryIDGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(productID, "st_productDelete", "@proID");
                    r.showProducts(dataGridView1, productIDGV, productNameGV, expiryGV, categoryGV, priceGV, barcodeGV, categoryIDGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, productIDGV, productNameGV, expiryGV, categoryGV, priceGV, barcodeGV, categoryIDGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["productIDGV"].Value.ToString());
                productText.Text = row.Cells["productNameGV"].Value.ToString();
                priceText.Text = row.Cells["priceGV"].Value.ToString();
                barcodeText.Text = row.Cells["barcodeGV"].Value.ToString();
                if(row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expiryDatePicker.Value = DateTime.Now;
                }
                else
                {
                    expiryDatePicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
                categoryDD.SelectedValue = row.Cells["categoryIDGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void productText_TextChanged(object sender, EventArgs e)
        {
            if (productText.Text == "") { productErrorLabel.Visible = true; } else { productErrorLabel.Visible = false; }
        }

        private void barcodeText_TextChanged(object sender, EventArgs e)
        {
            if (barcodeText.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {
            if (priceText.Text == "") { priceErrorLabel.Visible = true; } else { priceErrorLabel.Visible = false; }
        }
    }
}

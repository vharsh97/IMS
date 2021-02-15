using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
        Insertion i = new Insertion();
        Updation u = new Updation();
        Deletion d = new Deletion();

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
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purDD.SelectedValue.ToString()), dataGridView1, mPIDGV, productIDGV, productNameGV, quantityGV, perUnitPriceGV, totalAmountGV);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure, you want to delete " + row.Cells["productNameGV"].Value.ToString() + " from purchase invoice?\n\t\tWARNING\nDELETION OF PRODUCT WILL EFFECT STOCK", "Questions...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Retrieval.USER_ID, DateTime.Today);
                            int q;
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                                grossLabel.Text = tot.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                    }
                }
            }
        }
    }
}

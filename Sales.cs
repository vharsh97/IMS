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
    public partial class Sales : Sample2
    {
        Retrieval r = new Retrieval();
        string[] productArr = new string[6];
        float GROSS;

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        bool productCheck;
        private void barcodeTxt_Validating(object sender, CancelEventArgs e)
        {
            if(barcodeTxt.Text != "")
            {
                productArr = r.getProductsWRTBarcode(barcodeTxt.Text);
                if(dataGridView1.RowCount == 0)
                {
                    dataGridView1.Rows.Add(Convert.ToInt32(productArr[0]), productArr[1], 1, Convert.ToSingle(productArr[3]), productArr[4], Convert.ToSingle(productArr[5]));
                }
                else
                {
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        if(row.Cells["productIDGV"].Value.ToString() == productArr[0])
                        {
                            productCheck = true;
                            break;
                        }
                        else
                        {
                            productCheck = false;
                        }
                    }
                    if (productCheck == true)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if(row.Cells["productIDGV"].Value.ToString() == productArr[0])
                            {
                                float disc = 0;
                                row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                if (row.Cells["discGV"].Value.ToString() != null)
                                {
                                    disc += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                    row.Cells["discGV"].Value = disc;
                                }

                                float tot = (Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                                row.Cells["totalAmountGV"].Value = tot;
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(productArr[0]), productArr[1], 1, Convert.ToSingle(productArr[3]), productArr[4], Convert.ToSingle(productArr[5]));
                    }
                }
                foreach(DataGridViewRow item in dataGridView1.Rows)
                {
                    GROSS += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                }
                grossLabel.Text = GROSS.ToString();
                GROSS = 0;
                barcodeTxt.Focus();
                barcodeTxt.Text = "";
            }
        }
    }
}

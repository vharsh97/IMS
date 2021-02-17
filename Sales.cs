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
    public partial class Sales : Sample2
    {
        Retrieval r = new Retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        string[] productArr = new string[6];
        float GROSS=0;

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
                grossTxt.Text = "";
                totDiscountTxt.Text = "";
                amtGivenTxt.Text = "";
                changeGivenTxt.Text = "";   
                int qCount = 0, sQuant = 0, nCount=0 ;
                productArr = r.getProductsWRTBarcode(barcodeTxt.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(productArr[0] == row.Cells["productIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt32(productArr[0])));
                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(productArr[0]), productArr[1], 1, Convert.ToSingle(productArr[3]), productArr[4], Convert.ToSingle(productArr[5]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["productIDGV"].Value.ToString() == productArr[0])
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
                                if (row.Cells["productIDGV"].Value.ToString() == productArr[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["discGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["discGV"].Value = disc;
                                    }

                                    float tot = (Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString())) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                    row.Cells["totalAmountGV"].Value = tot;
                                }
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(productArr[0]), productArr[1], 1, Convert.ToSingle(productArr[3]), productArr[4], Convert.ToSingle(productArr[5]));
                        }
                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                    }
                    grossLabel.Text = Math.Round(GROSS,0).ToString();
                    GROSS = 0;
                    barcodeTxt.Focus();
                    barcodeTxt.Text = "";
                }  
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 6)
                {
                    grossTxt.Text = "";
                    totDiscountTxt.Text = "";
                    amtGivenTxt.Text = "";
                    changeGivenTxt.Text = "";
                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if(q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["quantityGV"].Value = q;
                        dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(productArr[4]);
                        row.Cells["discGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) - dis;
                        row.Cells["totalAmountGV"].Value = tot;
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                        }
                        grossLabel.Text = GROSS.ToString();
                        GROSS = 0;

                    }
                }
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                float dis = 0, gross = 0 ;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                grossTxt.Text = Math.Round(gross, 0).ToString();
                totDiscountTxt.Text = Math.Round(dis, 0).ToString();
            }
        }

        private void amtGivenTxt_TextChanged(object sender, EventArgs e)
        {
            if(amtGivenTxt.Text != "")
            {
                if (!rg.Match(amtGivenTxt.Text).Success)
                {
                    amtGivenTxt.Text = "";
                    amtGivenTxt.Focus();
                }
            }
            else
            {
                changeGivenTxt.Text = "";
            }
        }

        private void amtGivenTxt_Validating(object sender, CancelEventArgs e)
        {
            if (amtGivenTxt.Text != "" && grossTxt.Text != "")
            {
                if (!(Convert.ToSingle(grossTxt.Text) <= Convert.ToSingle(amtGivenTxt.Text)))
                {
                    amtGivenTxt.Text = "";
                    changeGivenTxt.Text = "";
                    amtGivenTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amtGivenTxt.Text);
                    float amoutnToReturn = amountGiven - Convert.ToSingle(grossTxt.Text);
                    changeGivenTxt.Text = Math.Round(amoutnToReturn, 0).ToString();
                }
            }
        }

        Insertion i = new Insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if(amtGivenTxt.Text != "" && totDiscountTxt.Text != "" && grossTxt.Text != "" && payDD.SelectedIndex != -1 && changeGivenTxt.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\t\tTotal Amount : "+grossTxt.Text+ "\n\t\tTotal Discount : "+totDiscountTxt.Text + "\n\t\tAmount Given : " + amtGivenTxt.Text + "\n\t\tAmount Returned : " + changeGivenTxt.Text + "\n\nAre you Sure, Submit Current Sales?\n", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "productIDGV", "quantityGV", Retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTxt.Text), Convert.ToSingle(totDiscountTxt.Text), Convert.ToSingle(amtGivenTxt.Text), Convert.ToSingle(changeGivenTxt.Text));
                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";
                }
            }
        }
    }
}

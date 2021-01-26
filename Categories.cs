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
    public partial class Categories : Sample2
    {
        int edit = 0; // This 0 is an indication to save operation and 1 is an indication to update operation.
        int categoryID;
        short stat;
        Retrieval r = new Retrieval();
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
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
            if (categoryText.Text == "") { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
            if (categoryIsactiveDD.SelectedIndex == -1) { isactiveErrorLabel.Visible = true; } else { isactiveErrorLabel.Visible = false; }
            if (categoryErrorLabel.Visible || isactiveErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                if (categoryIsactiveDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (categoryIsactiveDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //code for save operation
                {
                    Insertion i = new Insertion();
                    i.insertCategory(categoryText.Text, stat);
                    r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //code for edit operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateCategory(categoryID, categoryText.Text, stat);
                        r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV);
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
                    d.delete(categoryID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV);
                }
            }
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            if (searchText.Text != "")
            {
                r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV, searchText.Text);
            }
            else
            {
                r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, categoryIDGV, categoryNameGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                categoryID = Convert.ToInt32(row.Cells["categoryIDGV"].Value.ToString());
                categoryText.Text = row.Cells["categoryNameGV"].Value.ToString();
                categoryIsactiveDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void categoryText_TextChanged(object sender, EventArgs e)
        {
            if (categoryText.Text == "") { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
        }
    }
}

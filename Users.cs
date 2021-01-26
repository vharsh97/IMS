using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : Sample2
    {
        int edit = 0; // This 0 is an indication to save operation and 1 is an indication to update operation.
        int userID;
        short stat;
        Retrieval r = new Retrieval();
        public Users()
        {
            InitializeComponent();
        }
        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
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
            if (nameText.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameText.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (emailText.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (phoneText.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if(statusDropdown.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                if (statusDropdown.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDropdown.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //code for save operation
                {
                    Insertion i = new Insertion();
                    i.insertUser(nameText.Text, usernameText.Text, passwordText.Text, phoneText.Text, emailText.Text,stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //code for edit operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.updateUser(userID, nameText.Text, usernameText.Text, passwordText.Text, phoneText.Text, emailText.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(userID, "st_deleteUsers", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                }
            }
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            if(searchText.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV, searchText.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameText.Text = row.Cells["NameGV"].Value.ToString();
                usernameText.Text = row.Cells["usernameGV"].Value.ToString();
                passwordText.Text = row.Cells["passwordGV"].Value.ToString();
                phoneText.Text = row.Cells["phoneGV"].Value.ToString();
                emailText.Text = row.Cells["emailGV"].Value.ToString();
                statusDropdown.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (nameText.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameText.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            if (phoneText.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
        }
        private void emailText_TextChanged(object sender, EventArgs e)
        {
            if (emailText.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
        }
    }
}

﻿using System;
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
        public Users()
        {
            InitializeComponent();
        }

        Retrieval r = new Retrieval();

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
            r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameText.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameText.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (emailText.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (phoneText.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                if (edit == 0) //code for save operation
                {
                    Insertion i = new Insertion();
                    i.insertUser(nameText.Text, usernameText.Text, passwordText.Text, phoneText.Text, emailText.Text);
                    r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) //code for edit operation
                {
                    Updation u = new Updation();                  
                    u.updateUser(0, nameText.Text, usernameText.Text, passwordText.Text, phoneText.Text, emailText.Text);
                    r.showUsers(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userText.Enabled = false;
                passwordText.Enabled = false;
                userText.Text = "";
                passwordText.Text = "";
            }
            else
            {
                userText.Enabled = true;
                passwordText.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            if (isCB.Checked)
            {
                if (serverText.Text != "" && databaseText.Text != "")
                {
                    s = "Data Source=" + serverText.Text + ";Initial Catalog=" + databaseText.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                if (serverText.Text != "" && databaseText.Text != "" && userText.Text != "" && passwordText.Text != "")
                {
                    s = "Data Source=" + serverText.Text + ";Initial Catalog=" + databaseText.Text + ";User ID=" + userText.Text + ";Password=" + passwordText.Text + ";";
                    File.WriteAllText(path + "\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings saved successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
        }
    }
}

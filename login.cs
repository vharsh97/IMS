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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (usernameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message.
            }
            else
            {
                if (Retrieval.getUserDetails(usernameText.Text, passwordText.Text))
                {
                    HomeScreen obj = new HomeScreen();
                    MainClass.showWindow(obj, this, MDI.ActiveForm);
                }
                else
                {

                }
            }
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (usernameText.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }
    }
}

﻿using System;
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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void productDD_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }
    }
}

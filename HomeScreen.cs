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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI.logoutToolStripMenuItem.Enabled = true;
            userLabel.Text = Retrieval.EMP_NAME;
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

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void purchaseInvoiceBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pr = new PurchaseInvoice();
            MainClass.showWindow(pr, this, MDI.ActiveForm);
        }
    }
}

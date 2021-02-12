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
    public partial class PurchaseInvoice : Sample2
    {
        Retrieval r = new Retrieval();

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", suplierDD, "Company", "ID");
        }
    }
}

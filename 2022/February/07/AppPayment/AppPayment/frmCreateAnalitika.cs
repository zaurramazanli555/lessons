using AppPayment.DBModel;
using AppPayment.ModelCLass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPayment
{
    public partial class frmCreateAnalitika : Form
    {
        public frmCreateAnalitika()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (PaymentContext context= new PaymentContext())
            {
                string name = txtanalitikakod.Text;
                string desc = txtDescription.Text;
                Vendor vendor = new Vendor();
                vendor.Name = name;
                vendor.Decription = desc;
                context.Vendors.Add(vendor);
                context.SaveChanges();
                MessageBox.Show("Successfully");
            }  
        }
    }
}

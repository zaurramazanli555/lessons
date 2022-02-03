using System;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmAbout : DevExpress.XtraEditors.XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
            string version = Application.ProductVersion.Substring(0, 3);
            this.Text = "About " + Application.ProductName;
            product.Text = Application.ProductName;
            this.version.Text = version;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + linkLabel1.Text);
        }
    }
}
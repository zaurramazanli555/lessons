using System;
using System.Drawing;
using FastReport;
using System.Windows.Forms;

namespace CASHBOOK
{
    public partial class frmPrintPreview : DevExpress.XtraEditors.XtraForm
    {
        private string f_user;
        public frmPrintPreview(FastReport.Report report, Font font, string user)
        {
            InitializeComponent();
            f_user = user;

            try
            {
                FastReport.Preview.PreviewControl PreviewControl1 = new FastReport.Preview.PreviewControl();
                PreviewControl1.Dock = DockStyle.Fill;
                this.Controls.Add(PreviewControl1);
                report.Preview = PreviewControl1;

                report.Refresh();
                report.Show();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
            }
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

        private void frmPrintPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
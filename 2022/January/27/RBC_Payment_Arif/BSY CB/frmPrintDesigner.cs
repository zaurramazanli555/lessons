using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;

namespace CASHBOOK
{
    public partial class frmPrintDesigner : DevExpress.XtraEditors.XtraForm
    {
        private frmMain f_mainform;
        private string F_replocation;

        public frmPrintDesigner(frmMain f_mainform)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.f_mainform = f_mainform;
        }

        private void frmPrintDesigner_Load(object sender, EventArgs e)
        {
            string sqlcommand = "SELECT DF_CODE AS Form, DF_NAME AS Name FROM DocumentFormat ORDER BY DF_CODE";
            DataTable dt = clsConnection.reader(sqlcommand);
            replkp.Properties.DataSource = dt;
            replkp.Properties.DisplayMember = "Form";
            replkp.Properties.ValueMember = "Form";
            replkp.Properties.DropDownRows = dt.Rows.Count;
            replkp.EditValueChanged += new System.EventHandler(this.replkp_EditValueChanged);
            amendbtn.Enabled = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                f_mainform.statuscaption("");
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void amendbtn_Click(object sender, EventArgs e)
        {
            if (replkp.EditValue.ToString() != "" & replkp.EditValue != null)
            {
                try
                {
                    DataRowView row = replkp.Properties.GetDataSourceRowByKeyValue(replkp.EditValue) as DataRowView;
                    string repname = clsConnection.trimSql(row["Form"].ToString());
                    string sqlcommand = "SELECT PATH FROM DocumentFormat WHERE (DF_CODE = N'" + repname + "')";
                    string replocation = clsConnection.singleReader(sqlcommand);
                    F_replocation = replocation;
                    Report report = new Report();
                    report.Load(replocation);
                    report.Design();
                }
                catch (System.IO.FileNotFoundException)
                {
                    XtraMessageBox.Show("File not found: \r\n" + F_replocation);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
                }
            }
        }

        private void replkp_EditValueChanged(object sender, EventArgs e)
        {
            amendbtn.Enabled = true;
        }
    }
}
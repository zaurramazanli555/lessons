using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace CASHBOOK
{
    public partial class frmLocalBankDetails : DevExpress.XtraEditors.XtraForm
    {
        private string F_UID;
        private string F_BANK;
        private string F_TAX;
        private string F_SWIFT;
        private string F_CORR;
        private string F_STATUS;

        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmLocalBankDetails(string UID, string BANK, string TAX, string SWIFT, string CORR, string STATUS, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_UID = UID;
            F_BANK = BANK;
            F_TAX = TAX;
            F_SWIFT = SWIFT;
            F_CORR = CORR;
            F_STATUS = STATUS;

            F_TYPE = TYPE;
            f_user = USER;
            this.f_mainform = f_mainform;
            this.Text = "Local Bank Details Maintenance";
            f_mainform.statuscaption("");
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

        private void frmBank_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            statuslkp.Properties.DataSource = clsTransaction.status_list();
            statuslkp.Properties.DropDownRows = clsTransaction.status_list().Count;

            if (F_TYPE == "NEW")
            {
                bankbox.Text = "";
                swiftbox.Text = "";
                corrbox.Text = "";
                banktaxbox.Text = "";
                statuslkp.EditValue = "Open";
            }
            else
            {
                bankbox.Text = F_BANK;
                swiftbox.Text = F_SWIFT;
                corrbox.Text = F_CORR;
                banktaxbox.Text = F_TAX;
                statuslkp.EditValue = F_STATUS;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string BANK = clsConnection.trimSql(bankbox.Text);
                string TAX = clsConnection.trimSql(banktaxbox.Text);
                string SWIFT = clsConnection.trimSql(swiftbox.Text);
                string CORR = clsConnection.trimSql(corrbox.Text);
                string STATUS = clsTransaction.status_bool(statuslkp.EditValue.ToString());

                if (BANK.Length == 0)
                {
                    XtraMessageBox.Show("Bank Name field is mandatory");
                    bankbox.Focus();
                    return;
                }

                string sqlcommand = "";

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(BA_CODE) FROM LocalBankDetails WHERE BA_CODE = N'" + BANK + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        bankbox.Focus();
                        return;
                    }

                    sqlcommand = @"INSERT INTO LocalBankDetails(BA_CODE, TAX_ID, SWIFT, CORR_ACC, STATUS, UPDATED_USER) 
                    VALUES (N'" + BANK + "', N'" + TAX + "', N'" + SWIFT + "', N'" + CORR + "', " + STATUS + ", N'" + f_user + "')";
                    clsConnection.singleExecute(sqlcommand);
                    cancellation = "0";
                    f_mainform.statuscaption("Record was created");
                    this.Close();
                }
                else
                {
                    sqlcommand = "SELECT COUNT(BA_CODE) FROM LocalBankDetails WHERE BA_CODE = N'" + BANK + "' AND UID <> '" + F_UID + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        bankbox.Focus();
                        return;
                    }

                    sqlcommand = @"UPDATE LocalBankDetails SET [BA_CODE] = N'" + BANK + "', [TAX_ID] = N'" + TAX + "', [SWIFT] = N'" + SWIFT +
                    "', [CORR_ACC] = N'" + CORR + "', [STATUS] = " + STATUS + ", [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (UID = N'" + F_UID + "')";
                    clsConnection.singleExecute(sqlcommand);
                    cancellation = "0";
                    f_mainform.statuscaption("Record was updated");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
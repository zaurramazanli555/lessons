using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace CASHBOOK
{
    public partial class frmCashAccount : DevExpress.XtraEditors.XtraForm
    {
        private string F_CODE;
        private string F_STATUS;

        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmCashAccount(string TEXT, string CODE, string STATUS, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_CODE = CODE;
            F_STATUS = STATUS;

            F_TYPE = TYPE;
            f_user = USER;
            this.f_mainform = f_mainform;
            this.Text = TEXT;
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

        private void frmCashAccount_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            statuslkp.Properties.DataSource = clsTransaction.status_list();
            statuslkp.Properties.DropDownRows = clsTransaction.status_list().Count;

            if (F_TYPE == "NEW")
            {
                codebox.Text = "";
                statuslkp.EditValue = "Open";
            }
            else
            {
                codebox.Enabled = false;
                codebox.Text = F_CODE;
                statuslkp.EditValue = F_STATUS;

            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CODE = clsConnection.trimSql(codebox.Text);
                string STATUS = clsTransaction.status_bool(statuslkp.EditValue.ToString());

                if (CODE.Length == 0)
                {
                    XtraMessageBox.Show("Account code field is mandatory");
                    codebox.Focus();
                    return;
                }

                string sqlcommand = "";

                sqlcommand = "SELECT COUNT([Account Code]) FROM V_ChartOfAccounts_SunSystems WHERE [Account Code] = N'" + CODE + "' AND Status = 'Open'";
                int count = clsConnection.countReader(sqlcommand);
                if (count == 0)
                {
                    XtraMessageBox.Show("Acount code can not be used");
                    codebox.Focus();
                    sqlcommand = @"UPDATE CashAccount SET [STATUS] = 0, [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE CA_CODE = N'" + CODE + "'";
                    clsConnection.singleExecute(sqlcommand);
                    cancellation = "0";
                    this.Close();
                    return;
                }

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(CA_CODE) FROM CashAccount WHERE CA_CODE = N'" + CODE + "'";
                    count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        codebox.Focus();
                        return;
                    }
                    else
                    {
                        sqlcommand = @"INSERT INTO CashAccount (CA_CODE, STATUS, UPDATED_USER) 
                        VALUES (N'" + CODE + "', N'" + STATUS + "', N'" + f_user + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("Record was created");
                        this.Close();
                    }
                }
                else
                {
                    sqlcommand = @"UPDATE CashAccount SET [STATUS] = " + STATUS + ", [UPDATED_USER] = N'" + f_user +
                    "', [UPDATED_DATE] = GETDATE() WHERE CA_CODE = N'" + CODE + "'";
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
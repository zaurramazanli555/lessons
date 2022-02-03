using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace CASHBOOK
{
    public partial class frmCashAnalysis : DevExpress.XtraEditors.XtraForm
    {
        private string F_UID;
        private string F_ANL_TYPE;
        private string F_ANL;
        private string F_DESC;
        private string F_CP_TYPE;
        private string F_STATUS;

        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmCashAnalysis(string TEXT, string UID, string COL_TEXT, string ANL_TYPE, string ANL, string DESC, string CP_TYPE, string STATUS, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_UID = UID;
            codelbl.Text = COL_TEXT + ":";
            F_ANL = ANL;
            F_ANL_TYPE = ANL_TYPE;
            F_DESC = DESC;
            F_CP_TYPE = CP_TYPE;
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

        private void frmCashAnalysis_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            statuslkp.Properties.DataSource = clsTransaction.status_list();
            statuslkp.Properties.DropDownRows = clsTransaction.status_list().Count;
            typelkp.Properties.DataSource = clsTransaction.cash_type2_list();
            typelkp.Properties.DropDownRows = clsTransaction.cash_type2_list().Count;

            if (F_TYPE == "NEW")
            {
                codebox.Text = "";
                descbox.Text = "";
                statuslkp.EditValue = "Open";
                typelkp.EditValue = "Both";
            }
            else
            {
                codebox.Text = F_ANL;
                descbox.Text = F_DESC;
                statuslkp.EditValue = F_STATUS;
                typelkp.EditValue = F_CP_TYPE;

                string sqlcommand = "SELECT COUNT(UID) FROM Cash WHERE " + F_ANL_TYPE + "_ANL_UID = '" + F_UID + "'";
                int count = clsConnection.countReader(sqlcommand);
                if (count > 0)
                    codebox.Enabled = false;
            }

            if (F_ANL_TYPE == "C")
                descbox.Properties.MaxLength = 50;
            else
                descbox.Properties.MaxLength = 30;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CODE = clsConnection.trimSql(codebox.Text);
                string DESC = clsConnection.trimSql(descbox.Text);
                string TYPE = clsConnection.trimSql(typelkp.EditValue.ToString());
                string STATUS = clsTransaction.status_bool(statuslkp.EditValue.ToString());

                if (CODE.Length == 0)
                {
                    XtraMessageBox.Show(codelbl.Text.Substring(0, codelbl.Text.Length - 1) + " field is mandatory");
                    codebox.Focus();
                    return;
                }

                if (DESC.Length == 0)
                {
                    XtraMessageBox.Show("Description field is mandatory");
                    descbox.Focus();
                    return;
                }

                string sqlcommand = "";

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(ANL_CODE) FROM CashAnalysis WHERE ANL_TYPE = N'" + F_ANL_TYPE + "' AND ANL_CODE = N'" + CODE + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        codebox.Focus();
                        return;
                    }
                    else
                    {
                        sqlcommand = @"INSERT INTO CashAnalysis (ANL_TYPE, ANL_CODE, DESCR, TYPE, STATUS, UPDATED_USER) 
                        VALUES (N'" + F_ANL_TYPE + "', N'" + CODE + "',N'" + DESC + "', N'" + TYPE + "', N'" + STATUS + "', N'" + f_user + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("Record was created");
                        this.Close();
                    }
                }
                else
                {
                    sqlcommand = @"UPDATE CashAnalysis SET [ANL_CODE] = N'" + CODE + "', [DESCR] = N'" + DESC +
                       "', [TYPE] = '" + TYPE + "', [STATUS] = " + STATUS + ", [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE ANL_TYPE = N'" + F_ANL_TYPE + "' AND UID = '" + F_UID + "'";
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
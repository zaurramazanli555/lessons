using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;

namespace CASHBOOK
{
    public partial class frmPaymentProfiles : DevExpress.XtraEditors.XtraForm
    {
        private string F_UID;
        private string F_CODE;
        private string F_NAME;
        private string F_CURR;
        private string F_ADDR;
        private string F_TAX;
        private string F_STATUS;
        private string F_BANK_ACC;

        private string F_BANK;
        private string F_BANK_ADDR;
        private string F_BANK_TAX;
        private string F_SWIFT;
        private string F_CORR;
        private string F_SORT;

        private string F_BANK_TYPE;
        private string F_LOC_BANK;
        private string F_LOC_BRANCH;
        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";
        public int loaded = 0;

        public frmPaymentProfiles(string UID, string CODE, string NAME, string STATUS, string BANK_TYPE, string LOC_BANK, string LOC_BRANCH, string CURR, string ADDR, string TAX, string BANK_ACC, string BANK, string BANK_ADDR, string BANK_TAX, string SWIFT, string CORR, string SORT, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_UID = UID;
            F_CODE = CODE;
            F_NAME = NAME;
            F_CURR = CURR;
            F_ADDR = ADDR;
            F_TAX = TAX;
            F_BANK_ACC = BANK_ACC;

            F_BANK = BANK;
            F_BANK_ADDR = BANK_ADDR;
            F_BANK_TAX = BANK_TAX;
            F_SWIFT = SWIFT;
            F_CORR = CORR;
            F_SORT = SORT;

            F_BANK_TYPE = BANK_TYPE;
            F_LOC_BANK = LOC_BANK;
            F_LOC_BRANCH = LOC_BRANCH;
            F_STATUS = STATUS;
            F_TYPE = TYPE;
            f_user = USER;
            this.f_mainform = f_mainform;
            this.Text = "Payment Profiles Maintenance";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private void frmPaymentProfiles_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            statuslkp.Properties.DataSource = clsTransaction.status_list();
            statuslkp.Properties.DropDownRows = clsTransaction.status_list().Count;

            List<string> typelist = new List<string>();
            typelist.Add("Abroad");
            typelist.Add("Local");
            typelkp.Properties.DataSource = typelist;

            if (F_TYPE == "NEW")
            {
                acnt_lkp("SELECT * FROM V_ChartOfAccounts_PaymentProfiles WHERE Status = 'Open' ORDER BY 1");
                curr_lkp("SELECT * FROM V_CurrencyCodes WHERE Status = 'Open' ORDER BY 1");
                locbank_lkp("SELECT * FROM V_LocalBankDetails WHERE Status = 'Open' ORDER BY 2");
            }
            else
            {
                acnt_lkp("SELECT * FROM V_ChartOfAccounts_PaymentProfiles ORDER BY 1");
                curr_lkp("SELECT * FROM V_CurrencyCodes ORDER BY 1");
                locbank_lkp("SELECT * FROM V_LocalBankDetails ORDER BY 2");
            }

            if (F_TYPE == "NEW")
            {
                acntlkp.EditValue = null;
                acntlkp.Enabled = true;
                namebox.Text = "";
                currlkp.EditValue = null;
                addrbox.Text = "";
                taxbox.Text = "";
                bankaccbox.Text = "";

                sortbox.Text = "";
                swiftbox.Text = "";
                corrbox.Text = "";
                banktaxbox.Text = "";
                bankaddrbox.Text = "";
                bankbox.Text = "";

                typelkp.EditValue = "Local";
                statuslkp.EditValue = "Open";
            }
            else
            {
                acntlkp.EditValue = F_CODE;
                acntlkp.Enabled = false;
                namebox.Text = F_NAME;
                currlkp.EditValue = F_CURR;
                addrbox.Text = F_ADDR;
                taxbox.Text = F_TAX;
                bankaccbox.Text = F_BANK_ACC;

                sortbox.Text = F_SORT;
                swiftbox.Text = F_SWIFT;
                corrbox.Text = F_CORR;
                banktaxbox.Text = F_BANK_TAX;
                bankaddrbox.Text = F_BANK_ADDR;
                typelkp.EditValue = F_BANK_TYPE;
                statuslkp.EditValue = F_STATUS;

                typelkp.EditValue = F_BANK_TYPE;

                if (F_BANK_TYPE == "Local")
                {
                    locbanklkp.EditValue = F_LOC_BANK;
                    bankbox.Text = F_LOC_BRANCH;
                }
                else
                    bankbox.Text = F_BANK;
            }

            acntlkp.Properties.ShowHeader = true;
            currlkp.Properties.ShowHeader = true;
            loaded = 1;
        }

        private void acnt_lkp(string sqlcommand)
        {
            DataTable dt = clsConnection.reader(sqlcommand);
            acntlkp.Properties.DataSource = dt;
            acntlkp.Properties.DisplayMember = "Account Code";
            acntlkp.Properties.ValueMember = "Account Code";
            acntlkp.Properties.PopulateColumns();
            acntlkp.Properties.Columns["Status"].Visible = false;
            acntlkp.Properties.DropDownRows = dt.Rows.Count;
        }

        private void curr_lkp(string sqlcommand)
        {
            DataTable dt = clsConnection.reader(sqlcommand);
            currlkp.Properties.DataSource = dt;
            currlkp.Properties.DisplayMember = "Currency Code";
            currlkp.Properties.ValueMember = "Currency Code";
            currlkp.Properties.PopulateColumns();
            currlkp.Properties.Columns["Status"].Visible = false;
            currlkp.Properties.DropDownRows = dt.Rows.Count;
        }

        private void locbank_lkp(string sqlcommand)
        {
            DataTable dt = clsConnection.reader(sqlcommand);
            locbanklkp.Properties.DataSource = dt;
            locbanklkp.Properties.DisplayMember = "Bank Name";
            locbanklkp.Properties.ValueMember = "Bank Name";
            locbanklkp.Properties.PopulateColumns();
            locbanklkp.Properties.Columns["UID"].Visible = false;
            locbanklkp.Properties.Columns["Tax ID"].Visible = false;
            locbanklkp.Properties.Columns["SWIFT"].Visible = false;
            locbanklkp.Properties.Columns["Corr. Account"].Visible = false;
            locbanklkp.Properties.Columns["Status"].Visible = false;
            locbanklkp.Properties.DropDownRows = 20;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string BANK_TYPE = typelkp.EditValue.ToString();

                if (acntlkp.Text == "" | acntlkp.EditValue == null)
                {
                    XtraMessageBox.Show("Code field is mandatory");
                    acntlkp.Focus();
                    return;
                }

                if (currlkp.Text == "" | currlkp.EditValue == null)
                {
                    XtraMessageBox.Show("Currency field is mandatory");
                    currlkp.Focus();
                    return;
                }

                if (BANK_TYPE == "Local")
                {
                    if (locbanklkp.Text == "" | locbanklkp.EditValue == null)
                    {
                        XtraMessageBox.Show("Local Bank field is mandatory");
                        locbanklkp.Focus();
                        return;
                    }
                }

                DataRowView row = acntlkp.Properties.GetDataSourceRowByKeyValue(acntlkp.EditValue) as DataRowView;
                string CODE = clsConnection.trimSql(row["Account Code"].ToString());
                string CODE_N = clsConnection.trimSql(row["Account Name"].ToString());
                string NAME = clsConnection.trimSql(namebox.Text);
                row = currlkp.Properties.GetDataSourceRowByKeyValue(currlkp.EditValue) as DataRowView;
                string CURR = clsConnection.trimSql(row["Currency Code"].ToString());
                string ADDR = clsConnection.trimSql(addrbox.Text);
                string TAX = clsConnection.trimSql(taxbox.Text);
                string BANK_ACC = clsConnection.trimSql(bankaccbox.Text);

                string BANK = clsConnection.trimSql(bankbox.Text);
                string BANK_ADDR = clsConnection.trimSql(bankaddrbox.Text);
                string BANK_TAX = clsConnection.trimSql(banktaxbox.Text);
                string SWIFT = clsConnection.trimSql(swiftbox.Text);
                string CORR = clsConnection.trimSql(corrbox.Text);
                string SORT = clsConnection.trimSql(sortbox.Text);

                string STATUS = clsTransaction.status_bool(statuslkp.EditValue.ToString());

                if (NAME.Length == 0)
                {
                    XtraMessageBox.Show("Name field is mandatory");
                    namebox.Focus();
                    return;
                }

                if (BANK_ACC.Length == 0)
                {
                    XtraMessageBox.Show("Bank Account field is mandatory");
                    bankaccbox.Focus();
                    return;
                }

                if (BANK_TYPE == "Local")
                {
                    if (BANK.Length == 0)
                    {
                        XtraMessageBox.Show("Branch field is mandatory");
                        bankbox.Focus();
                        return;
                    }
                }
                else
                {
                    if (BANK.Length == 0)
                    {
                        XtraMessageBox.Show("Bank Name field is mandatory");
                        bankbox.Focus();
                        return;
                    }
                }

                string sqlcommand = "";

                sqlcommand = "SELECT COUNT(CU_CODE) FROM CurrencyCodes WHERE STATUS <> 0 AND [CU_CODE] = N'" + CURR + "'";
                int count = clsConnection.countReader(sqlcommand);
                if (count != 1)
                {
                    XtraMessageBox.Show("Currency code is closed");
                    currlkp.Focus();
                    return;
                }

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(BD_CODE) FROM BeneficiaryDetails WHERE BD_CODE = N'" + CODE + "' AND OWN_COMPANY = 1";
                    count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        acntlkp.Focus();
                        return;
                    }

                    if (BANK_TYPE == "Local")
                    {
                        row = locbanklkp.Properties.GetDataSourceRowByKeyValue(locbanklkp.EditValue) as DataRowView;
                        string LOC_BANK_UID = clsConnection.trimSql(row["UID"].ToString());

                        sqlcommand = "', NULL, N'" + LOC_BANK_UID + "', N'" + BANK + "', N'";
                    }
                    else
                        sqlcommand = "', N'" + BANK + "', NULL, NULL, N'";

                    sqlcommand = @"INSERT INTO BeneficiaryDetails (OWN_COMPANY, BD_CODE, BD_NAME, CA_CODE, CU_CODE, TAX_ID, ADDRESS, BANK_ACC, BANK_TYPE, BA_CODE, LOCAL_BA_UID, LOCAL_BRANCH, SORT_CODE, BANK_TAX_ID, SWIFT, CORR_ACC, BANK_ADDRESS, STATUS, UPDATED_USER) 
                    VALUES (1, N'" + CODE + "', N'" + NAME + "', N'" + CODE + "', N'" + CURR + "', N'" + TAX + "', N'" + ADDR + "', N'" +
                    BANK_ACC + "', N'" + BANK_TYPE + sqlcommand + SORT + "', N'" + BANK_TAX + "', N'" + SWIFT + "', N'" + CORR +
                     "', N'" + BANK_ADDR + "', " + STATUS + ", N'" + f_user + "')";
                    clsConnection.singleExecute(sqlcommand);
                    cancellation = "0";
                    f_mainform.statuscaption("Record was created");
                    this.Close();
                }
                else
                {
                    if (BANK_TYPE == "Local")
                    {
                        row = locbanklkp.Properties.GetDataSourceRowByKeyValue(locbanklkp.EditValue) as DataRowView;
                        string LOC_BANK_UID = clsConnection.trimSql(row["UID"].ToString());
                        sqlcommand = "', BA_CODE = NULL, LOCAL_BA_UID = N'" + LOC_BANK_UID + "', LOCAL_BRANCH = N'" + BANK + "', ";
                    }
                    else
                        sqlcommand = "', BA_CODE = N'" + BANK + "', LOCAL_BA_UID = NULL, LOCAL_BRANCH = NULL, ";

                    sqlcommand = @"UPDATE BeneficiaryDetails SET [STATUS] = " + STATUS + ", [BD_NAME] = N'" + NAME +
         "', [CU_CODE] = N'" + CURR + "', [TAX_ID] = N'" + TAX + "', [ADDRESS] = N'" + ADDR + "', [BANK_ACC] = N'" + BANK_ACC +
        "', BANK_TYPE = N'" + BANK_TYPE + sqlcommand + "[SORT_CODE] = N'" + SORT + "', [BANK_TAX_ID] = N'" + BANK_TAX + "', [SWIFT] = N'" + SWIFT +
        "', [CORR_ACC] = N'" + CORR + "', [BANK_ADDRESS] = N'" + BANK_ADDR +
        "', [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (UID = N'" + F_UID + "')";
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

        private void acntlkp_EditValueChanged(object sender, EventArgs e)
        {
            if (loaded > 0)
            {
                if (acntlkp.Enabled == true)
                {
                    if (acntlkp.Text != "" | acntlkp.EditValue != null)
                    {
                        DataRowView row = acntlkp.Properties.GetDataSourceRowByKeyValue(acntlkp.EditValue) as DataRowView;
                        namebox.Text = row["Account Name"].ToString();
                    }
                }
            }
        }

        private void typelkp_EditValueChanged(object sender, EventArgs e)
        {
            if (typelkp.EditValue.ToString() == "Local")
            {
                banklbl.Text = "Branch:";
                locbanklbl.Visible = true;
                locbanklkp.Visible = true;
            }
            else
            {
                banklbl.Text = "Bank Name:";
                locbanklbl.Visible = false;
                locbanklkp.Visible = false;
            }

            if (loaded > 0)
                locbanklkp.EditValue = null;
        }

        private void locbanklkp_EditValueChanged(object sender, EventArgs e)
        {
            if (loaded > 0)
            {
                if (locbanklkp.Text != "" | locbanklkp.EditValue != null)
                {
                    DataRowView row = locbanklkp.Properties.GetDataSourceRowByKeyValue(locbanklkp.EditValue) as DataRowView;
                    banktaxbox.Text = row["Tax ID"].ToString();
                    swiftbox.Text = row["SWIFT"].ToString();
                    corrbox.Text = row["Corr. Account"].ToString();
                }
            }
            /*else
            {
                bankbox.Text = "";
                banktaxbox.Text = "";
                swiftbox.Text = "";
                corrbox.Text = "";
            }*/
        }
    }
}
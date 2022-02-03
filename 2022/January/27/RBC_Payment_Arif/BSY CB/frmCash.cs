using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using System.Globalization;
using System.Linq;
using FastReport;

namespace CASHBOOK
{
    public partial class frmCash : DevExpress.XtraEditors.XtraForm
    {
        private string F_DOC_NO;
        private string F_DOC_NEW_OLD = "";
        private string f_user;
        private string f_user_post;
        private Font F_FONT;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmCash()
        {
            InitializeComponent();
        }

        public frmCash(string doc_no, string formtext, Font font, string user, string user_post, frmMain f_mainform)
        {
            InitializeComponent();
            F_DOC_NO = doc_no;
            f_user = user;
            f_user_post = user_post;
            F_FONT = font;
            this.f_mainform = f_mainform;
            this.Text = formtext;
        }

        private void frmCash_Load(object sender, EventArgs e)
        {
            periodbox.Text = "";
            periodbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            periodbox.Properties.Appearance.Options.UseTextOptions = true;
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            datebox.DateTime = DateTime.Today;

            typelkp.Properties.DataSource = clsTransaction.cash_type_list();
            typelkp.Properties.DropDownRows = clsTransaction.cash_type_list().Count;

            if (F_DOC_NO.Length > 1)
                F_DOC_NEW_OLD = "OLD";
            else
                F_DOC_NEW_OLD = "NEW";

            acnt_lkp();
            expacnt_lkp();
            acntlkp.Enabled = false;

            if (F_DOC_NEW_OLD == "OLD")
            {
                typelkp.ReadOnly = true;
                internalchk.ReadOnly = true;
                getDetails();
            }
            else
            {
                expacntlkp.Visible = false;
                expacntlbl.Visible = false;
            }
        }

        private void getDetails()
        {
            try
            {
                string query = "";
                orderbox.Text = F_DOC_NO;

                query = @"SELECT CASH_TYPE FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                typelkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT CONVERT(VARCHAR(10), CASH_DATE, 112) FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                datebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                query = @"SELECT CASH_PERIOD FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                periodbox.Text = clsConnection.singleReader(query);

                query = @"SELECT AMT FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                amtbox.Text = clsConnection.singleReader(query);

                query = @"SELECT COUNT(P_ANL_UID) FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "' AND P_ANL_UID IS NOT NULL";
                string chk = clsConnection.singleReader(query);

                if (chk == "0")
                {
                    internalchk.Checked = true;
                    query = @"SELECT V_Cash_PaymentProfiles.[Profile Name] FROM Cash INNER JOIN
                    V_Cash_PaymentProfiles ON Cash.BANK_PP_UID = V_Cash_PaymentProfiles.UID WHERE Cash.CASH_TXN_REF = N'" + F_DOC_NO + "'";
                }
                else
                {
                    query = @"SELECT V_CashAnalysisPerson.Name FROM Cash INNER JOIN 
                    V_CashAnalysisPerson ON Cash.P_ANL_UID = V_CashAnalysisPerson.UID WHERE Cash.CASH_TXN_REF = N'" + F_DOC_NO + "'";
                }

                string query_ = @"SELECT V_ChartOfAccounts_Cash.[Account Name] FROM V_ChartOfAccounts_Cash INNER JOIN
                Cash ON V_ChartOfAccounts_Cash.[Account Code] = Cash.CASH_CA_CODE WHERE Cash.CASH_TXN_REF = N'" + F_DOC_NO + "'";
                acntlkp.EditValue = clsConnection.singleReader(query_);

                personlkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT USD_CA_CODE FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                string acnt = clsConnection.singleReader(query);
                if (acnt.Length > 1)
                    expacntlkp.EditValue = acnt;

                query = @"SELECT V_CashAnalysisCategory.Category FROM Cash INNER JOIN 
                V_CashAnalysisCategory ON Cash.C_ANL_UID = V_CashAnalysisCategory.UID WHERE Cash.CASH_TXN_REF = N'" + F_DOC_NO + "'";
                catlkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT PRINTFIELD_1 FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                descbox.Text = clsConnection.singleReader(query);

                query = @"SELECT PRINTFIELD_2 FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                docbox.Text = clsConnection.singleReader(query);

                savebtn.Text = "Update";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                savebtn.Enabled = false;
                printbtn.Enabled = false;
                postbtn.Enabled = false;
            }
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

        private void SetFormat(string format)
        {
            datebox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            datebox.Properties.Mask.EditMask = format;
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void datebox_EditValueChanged(object sender, EventArgs e)
        {
            if (datebox.Text == "" | datebox.Text == null)
            {
                datebox.DateTime = DateTime.Today;
                periodbox.Text = "";
            }
            else
            {
                periodbox.Text = GetPeriodFromDate(datebox.DateTime);
            }
            string format = @"dd\/MM\/yyyy";
            SetFormat(format);
        }

        public string GetPeriodFromDate(DateTime dt)
        {
            string Expression = dt.Month.ToString();
            string str1 = dt.Year.ToString();
            string str2;
            switch (Expression.Length)
            {
                case 1:
                    str2 = "00" + Expression;
                    break;
                case 2:
                    str2 = "0" + Expression;
                    break;
                default:
                    str2 = "000";
                    break;
            }
            return str1 + str2;
        }

        private void acnt_lkp()
        {
            string where = "";
            /*  if (F_DOC_NEW_OLD == "OLD")
                  where = " ORDER BY 1";
              else*/
            where = " WHERE Status = 'Open' ORDER BY 1";

            string sqlcommand = "SELECT * FROM V_ChartOfAccounts_Cash" + where;
            DataTable dt = clsConnection.reader(sqlcommand);
            acntlkp.Properties.DataSource = dt;
            acntlkp.Properties.DisplayMember = "Account Name";
            acntlkp.Properties.ValueMember = "Account Name";
            acntlkp.Properties.PopulateColumns();
            acntlkp.Properties.Columns["Status"].Visible = false;
            acntlkp.Properties.Columns["Currency"].Visible = false;
            acntlkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                acntlkp.EditValue = acntlkp.ItemIndex = 0;
        }

        private void expacnt_lkp()
        {
            string sqlcommand = "SELECT [Account Code], [Account Name] FROM V_CashAccount WHERE (Status = 'Open') ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            expacntlkp.Properties.DataSource = dt;
            expacntlkp.Properties.DisplayMember = "Account Code";
            expacntlkp.Properties.ValueMember = "Account Code";
            expacntlkp.Properties.PopulateColumns();
            expacntlkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                expacntlkp.EditValue = expacntlkp.ItemIndex = 0;
            expacntlkp.Properties.ShowHeader = true;
        }

        private void bank_acnt_lkp(string currency)
        {
            string where = "";
            /* if (F_DOC_NEW_OLD == "OLD")
                 where = " WHERE Currency = '" + currency + "' ORDER BY 2";
             else*/
            where = " WHERE Currency = '" + currency + "' AND Status = 'Open' ORDER BY 2";

            string sqlcommand = "SELECT * FROM V_Cash_PaymentProfiles" + where;
            DataTable dt = clsConnection.reader(sqlcommand);
            personlkp.Properties.DataSource = dt;
            personlkp.Properties.DisplayMember = "Profile Name";
            personlkp.Properties.ValueMember = "Profile Name";

            personlkp.Properties.PopulateColumns();
            personlkp.Properties.Columns["Status"].Visible = false;
            personlkp.Properties.Columns["UID"].Visible = false;
            personlkp.Properties.Columns["Currency"].Visible = false;
            personlkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                personlkp.EditValue = personlkp.ItemIndex = 0;
            personlkp.Properties.ShowHeader = true;
        }

        private void cat_lkp(string cash_type)
        {
            string where = "";
            /*if (F_DOC_NEW_OLD == "OLD")
                where = " WHERE [Use] IN ('Both', N'" + cash_type + "') ORDER BY 1";
            else*/
            where = " WHERE [Use] IN ('Both', N'" + cash_type + "') AND Status = 'Open' ORDER BY 1";

            string sqlcommand = "SELECT * FROM V_CashAnalysisCategory" + where;
            DataTable dt = clsConnection.reader(sqlcommand);
            catlkp.Properties.DataSource = dt;
            catlkp.Properties.DisplayMember = "Category";
            catlkp.Properties.ValueMember = "Category";
            catlkp.Properties.PopulateColumns();
            catlkp.Properties.Columns["Status"].Visible = false;
            catlkp.Properties.Columns["Description"].Visible = false;
            catlkp.Properties.Columns["Use"].Visible = false;
            catlkp.Properties.Columns["UID"].Visible = false;
            catlkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                catlkp.EditValue = catlkp.ItemIndex = 0;
        }

        private void person_lkp(string cash_type)
        {
            string where = "";
            /*if (F_DOC_NEW_OLD == "OLD")
                where = " WHERE [Use] IN ('Both', N'" + cash_type + "') ORDER BY 1";
            else*/
            where = " WHERE [Use] IN ('Both', N'" + cash_type + "') AND Status = 'Open' ORDER BY 1";

            string sqlcommand = "SELECT * FROM V_CashAnalysisPerson" + where;
            DataTable dt = clsConnection.reader(sqlcommand);
            personlkp.Properties.DataSource = dt;
            personlkp.Properties.DisplayMember = "Name";
            personlkp.Properties.ValueMember = "Name";
            personlkp.Properties.PopulateColumns();
            personlkp.Properties.Columns["Status"].Visible = false;
            personlkp.Properties.Columns["Use"].Visible = false;
            personlkp.Properties.Columns["UID"].Visible = false;
            personlkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                personlkp.EditValue = personlkp.ItemIndex = 0;
            personlkp.Properties.ShowHeader = true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (typelkp.Text == "" | typelkp.EditValue == null)
                {
                    XtraMessageBox.Show("Operation field is mandatory");
                    typelkp.Focus();
                    return;
                }

                if (datebox.Text == "" | datebox.Text == null)
                {
                    XtraMessageBox.Show("Date field is mandatory");
                    datebox.Focus();
                    return;
                }

                string amt = amtbox.Text.Replace(",", ".");
                double amount = 0;

                if (!double.TryParse(amt, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amount))
                {

                    XtraMessageBox.Show("Incorrect amount");
                    amtbox.Focus();
                    return;
                }
                else
                {
                    if (amount == 0)
                    {
                        XtraMessageBox.Show("Incorrect amount");
                        amtbox.Focus();
                        return;
                    }
                }

                if (acntlkp.Text == "" | acntlkp.EditValue == null)
                {
                    XtraMessageBox.Show("Cash Account field is mandatory");
                    acntlkp.Focus();
                    return;
                }

                if (personlkp.Text == "" | personlkp.EditValue == null)
                {
                    XtraMessageBox.Show("Focused field is mandatory");
                    personlkp.Focus();
                    return;
                }

                if (catlkp.Text == "" | catlkp.EditValue == null)
                {
                    XtraMessageBox.Show("Category field is mandatory");
                    catlkp.Focus();
                    return;
                }

                string type = typelkp.EditValue.ToString().Trim();
                string date = datebox.Text.Trim();
                string period = periodbox.Text.Trim();

                DataRowView row = acntlkp.Properties.GetDataSourceRowByKeyValue(acntlkp.EditValue) as DataRowView;
                string cash_ca_code = clsConnection.trimSql(row["Account Code"].ToString());

                string sql_text = "";
                string p_anl_uid = "";
                string bank_pp_uid = "";
                row = personlkp.Properties.GetDataSourceRowByKeyValue(personlkp.EditValue) as DataRowView;

                if (internalchk.Checked == true)
                {
                    bank_pp_uid = row["UID"].ToString();
                    sql_text = "', '" + bank_pp_uid + "', NULL, '";
                }
                else
                {
                    p_anl_uid = row["UID"].ToString();
                    sql_text = "', NULL, '" + p_anl_uid + "', '";
                }

                row = catlkp.Properties.GetDataSourceRowByKeyValue(catlkp.EditValue) as DataRowView;
                string c_anl_uid = row["UID"].ToString();
                string print1 = clsConnection.trimSql(descbox.Text);
                string print2 = clsConnection.trimSql(docbox.Text);

                string query = "";

                query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = N'" + currlbl.Text + "'";
                string unit = clsConnection.singleReader(query);

                query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = N'" + currlbl.Text + "'";
                string subunit = clsConnection.singleReader(query);

                string amt_word = clsTransaction.amount2Text(amount.ToString(), unit, subunit);

                string azn_amount = amount.ToString();
                string azn_word = amt_word;
                string usd_conv_rate = "1";
                string usd_ca_code = "";

                if (currlbl.Text != "AZN")
                {
                    if (clsTransaction.checkRate(F_DOC_NO, currlbl.Text, date, "CASH") == false)
                    {
                        XtraMessageBox.Show("Please check currency rate");
                        return;
                    }
                    else
                    {
                        query = "SET DATEFORMAT DMY SELECT dbo.GET_CONVERTED_AMT(N'" + currlbl.Text + "', '" + date + "', " + amount + ")";
                        azn_amount = clsConnection.singleReader(query);
                        azn_amount = azn_amount.Replace(",", ".");

                        query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE =  N'AZN'";
                        unit = clsConnection.singleReader(query);

                        query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = N'AZN'";
                        subunit = clsConnection.singleReader(query);

                        azn_word = clsTransaction.amount2Text(azn_amount, unit, subunit);

                        query = "SET DATEFORMAT DMY SELECT dbo.GET_RATE(N'" + currlbl.Text + "', '" + date + "')";
                        usd_conv_rate = clsConnection.singleReader(query);
                        usd_conv_rate = usd_conv_rate.Replace(",", ".");

                        if (expacntlkp.Text == "" | expacntlkp.EditValue == null)
                        {
                            XtraMessageBox.Show("Expense Account field is mandatory");
                            expacntlkp.Focus();
                            return;
                        }
                        else
                            usd_ca_code = clsConnection.trimSql(expacntlkp.EditValue.ToString());
                    }
                }

                if (orderbox.Text.Trim().Length > 2)
                {
                    string cash_txn_ref = clsConnection.trimSql(orderbox.Text);
                    string sqlcommand = "SELECT TOP 1 POST_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + cash_txn_ref + "'";
                    string status = clsConnection.singleReader(sqlcommand);

                    if (status != "0")
                    {
                        XtraMessageBox.Show("Only draft cash vouchers can be updated");
                        return;
                    }
                    else
                    {
                        UpdateCash(type, currlbl.Text, cash_ca_code, bank_pp_uid, c_anl_uid, p_anl_uid, date, period, amount, amt_word, print1, print2, azn_amount, azn_word, usd_conv_rate, usd_ca_code);
                    }
                }
                else
                {
                    query = "SET DATEFORMAT DMY EXECUTE [dbo].[CashCreate] '" + type + "', " + amount + ", " + azn_amount + ", " + period + ", '" + date +
                        "', N'" + currlbl.Text + "', N'" + cash_ca_code + sql_text +
                        c_anl_uid + "', N'" + amt_word + "', N'" + azn_word + "', N'" + usd_conv_rate + "', N'" + usd_ca_code + "', N'" + print1 + "', N'" + print2 + "', N'" + f_user + "'";
                    clsConnection.singleExecute(query);

                    string opr = "CR";
                    if (type == "Payment")
                        opr = "CP";

                    query = "SELECT TXN_REF FROM TransactionReference WHERE OPR_TYPE = '" + opr + "'";
                    string cash_txn_ref = clsConnection.singleReader(query);
                    orderbox.Text = cash_txn_ref;
                    f_mainform.statuscaption("Cash Voucher was saved");

                    printbtn.Enabled = true;
                    postbtn.Enabled = false;
                    savebtn.Text = "Update";
                    typelkp.ReadOnly = true;
                    internalchk.ReadOnly = true;

                    if (type == "Receipt")
                    {
                        clsPrint.updateStatus("Cash", "CASH_TXN_REF", cash_txn_ref);
                        printbtn.Enabled = false;
                        if (f_user_post != "False")
                            postbtn.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                printbtn.Enabled = false;
                postbtn.Enabled = false;
                savebtn.Enabled = false;
                return;
            }
        }

        public void UpdateCash(string type, string curr, string cash_ca_code, string bank_pp_uid, string c_anl_uid, string p_anl_uid, string date, string period, double amount, string amt_word, string print1, string print2, string azn_amount, string azn_word, string usd_conv_rate, string usd_ca_code)
        {
            try
            {
                string cash_txn_ref = clsConnection.trimSql(TXN_REF());
                string sql_text = "";

                if (bank_pp_uid == "")
                    sql_text = "', BANK_PP_UID = NULL, P_ANL_UID = '" + p_anl_uid + "'";
                else
                    sql_text = "', BANK_PP_UID = '" + bank_pp_uid + "', P_ANL_UID = NULL";

                string query = "SET DATEFORMAT DMY UPDATE Cash SET CU_CODE = '" + curr + "', CASH_CA_CODE = N'" + cash_ca_code +
                sql_text + ", C_ANL_UID = '" + c_anl_uid + "', CASH_DATE = '" + date + "', CASH_PERIOD = " + period +
                ", AMT = " + amount + ", AMT_TEXT = N'" + amt_word +
                "',	AZN_AMT = N'" + azn_amount + "', AZN_AMT_TEXT = N'" + azn_word + "', USD_CONV_RATE = N'" + usd_conv_rate + "', USD_CA_CODE = N'" + usd_ca_code +
                "', PRINTFIELD_1 = N'" + print1 + "', PRINTFIELD_2 = N'" + print2 + "', PRINT_STATUS = 0, UPDATED_USER = N'" + f_user +
                "', UPDATED_DATE = GETDATE() WHERE CASH_TXN_REF = N'" + cash_txn_ref + "'";
                clsConnection.singleExecute(query);

                query = "UPDATE Cash SET DF_CODE = (SELECT DF_CODE FROM DocumentFormat WHERE DF_CODE LIKE '%CASH%' AND DF_CODE LIKE '%'+ '" + curr + "' AND STATUS = 1) WHERE CASH_TXN_REF = N'" + cash_txn_ref + "'";
                clsConnection.singleExecute(query);

                cancellation = "0";
                f_mainform.statuscaption("Cash voucher was updated");
                printbtn.Enabled = true;
                postbtn.Enabled = false;

                if (type == "Receipt")
                {
                    clsPrint.updateStatus("Cash", "CASH_TXN_REF", cash_txn_ref);
                    printbtn.Enabled = false;
                    if (f_user_post != "False")
                        postbtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                printbtn.Enabled = false;
                postbtn.Enabled = false;
                return;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCash_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }

        private void amtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private string TXN_REF()
        {
            return orderbox.Text.Trim();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (orderbox.Text.Trim() == "" | orderbox.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Cash Voucher was not saved");
                orderbox.Focus();
                return;
            }

            if (TXN_REF() != "")
            {
                try
                {
                    string cash_txn_ref = clsConnection.trimSql(TXN_REF());
                    Report report = clsPrint.printCash(cash_txn_ref);
                    if (report != null)
                    {
                        clsPrint.updateStatus("Cash", "CASH_TXN_REF", cash_txn_ref);
                        frmPrintPreview form1 = new frmPrintPreview(report, F_FONT, f_user);
                        form1.StartPosition = FormStartPosition.CenterScreen;
                        form1.MdiParent = f_mainform;
                        form1.Show();
                        f_mainform.statuscaption("Cash Voucher was printed");

                        if (f_user_post != "False")
                            postbtn.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    postbtn.Enabled = false;
                    return;
                }
            }
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cash_txn_ref = clsConnection.trimSql(TXN_REF());
                if (clsPost.postCash(cash_txn_ref) == true)
                {
                    frmPost form = new frmPost(false, cash_txn_ref, "CASH", "Cash Voucher Post - " + cash_txn_ref, F_FONT, f_user, f_user_post, f_mainform);
                    form.MdiParent = f_mainform;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                return;
            }
        }

        private void typelkp_EditValueChanged(object sender, EventArgs e)
        {
            acntlkp.Enabled = true;
            string text = "Beneficiary: ";
            string cash_type = typelkp.EditValue.ToString();

            if (cash_type == "Receipt")
            {
                internalchk.Visible = true;
                internalchk.Checked = false;
                text = "Payer: ";
            }
            else
            {
                internalchk.Visible = false;
                internalchk.Checked = false;
            }

            acntlkp.EditValue = null;
            personlbl.Text = text;
            cat_lkp(cash_type);
        }

        private void internalchk_CheckedChanged(object sender, EventArgs e)
        {
            if (internalchk.Visible == true)
            {
                string text = "Payer: ";
                if (internalchk.Checked == true)
                    text = "Bank Account:";

                acntlkp.EditValue = null;
                personlbl.Text = text;
            }
        }

        private void acntlkp_EditValueChanged(object sender, EventArgs e)
        {

            personlkp.EditValue = null;
            personlkp.Properties.DataSource = null;
            personlkp.Properties.Columns.Clear();

            if (acntlkp.Text != "" | acntlkp.EditValue != null)
            {
                DataRowView row = acntlkp.Properties.GetDataSourceRowByKeyValue(acntlkp.EditValue) as DataRowView;
                string curr = row["Currency"].ToString();
                currlbl.Text = curr;

                if (internalchk.Checked == true)
                {
                    bank_acnt_lkp(curr);
                }
                else
                {
                    string cash_type = typelkp.EditValue.ToString();
                    person_lkp(cash_type);
                }
            }
            else
                currlbl.Text = "";
        }

        private void currlbl_TextChanged(object sender, EventArgs e)
        {
            if (currlbl.Text == "USD")
            {
                expacntlkp.Visible = true;
                expacntlbl.Visible = true;
            }
            else
            {
                expacntlkp.Visible = false;
                expacntlbl.Visible = false;
            }
        }
    }
}
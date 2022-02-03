using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using FastReport;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace CASHBOOK
{
    public partial class frmPaymentGenerate : DevExpress.XtraEditors.XtraForm
    {
        private string F_ACNT;
        private string F_SUPPLIER;
        private string F_GRID_COL;
        private string F_SQLSTRING;
        private string f_user;
        private string f_user_post;
        private frmMain f_mainform;
        private Font F_FONT85;

        public frmPaymentGenerate(string supplier, string account, string sql_string, string grid_col, string text, Font font, string user, string user_post, frmMain f_mainform)
        {
            InitializeComponent();
            this.Text = text;
            suppbox.Text = account;
            F_ACNT = account;
            F_SUPPLIER = supplier;
            F_GRID_COL = grid_col;
            F_SQLSTRING = sql_string;
            f_user = user;
            f_user_post = user_post;
            F_FONT85 = font;
            this.f_mainform = f_mainform;
            f_mainform.statuscaption("");

            budlevlbl.Left = basebox.Right + 130;
            budcatlbl.Left = budlevlbl.Left;
            preplbl.Left = budlevlbl.Left;
            prepaymentlkp.Left = budlevlbl.Right + 10;
            banklbl.Left = preplbl.Left;
            ownbanklkp.Left = prepaymentlkp.Left;
            replbl.Left = preplbl.Left;
            doclkp.Left = prepaymentlkp.Left;
            supplbl.Left = preplbl.Left;
            supplkp.Left = prepaymentlkp.Left;
            prepaymentchk.Left = prepaymentlkp.Right + 8;

            print3box.Left = prepaymentlkp.Left;
            print4box.Left = prepaymentlkp.Left;

            savebtn.Left = ownbanklkp.Right + 150;
            printbtn.Left = ownbanklkp.Right + 150;
            postbtn.Left = ownbanklkp.Right + 150;
            cancelbtn.Left = ownbanklkp.Right + 150;

            oblbl.Left = ownbanklkp.Right + 10;
            sblbl.Left = ownbanklkp.Right + 10;

            panel2.Width = this.Width;
            datebox.Select();
            datebox.Focus();
        }

        private void frmPaymentGenerate_Load(object sender, EventArgs e)
        {
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;

            grid.Font = F_FONT85;
            gridview.Appearance.FilterPanel.Font = F_FONT85;
            gridview.Appearance.FilterPanel.Options.UseFont = true;
            gridview.Appearance.HeaderPanel.Font = F_FONT85;
            gridview.Appearance.HeaderPanel.Options.UseFont = true;
            gridview.Appearance.Row.Font = F_FONT85;
            gridview.Appearance.Row.Options.UseFont = true;

            suppbox.ReadOnly = true;
            suppbox.Enabled = false;
            suppbox.ForeColor = Color.Black;
            periodbox.ReadOnly = true;
            periodbox.Enabled = false;
            periodbox.ForeColor = Color.Black;
            basebox.ReadOnly = true;
            basebox.Enabled = false;
            basebox.ForeColor = Color.Black;
            trbox.ReadOnly = true;
            trbox.Enabled = false;
            trbox.ForeColor = Color.Black;
            currbox.ReadOnly = true;
            currbox.Enabled = false;
            currbox.ForeColor = Color.Black;
            pobox.ReadOnly = true;
            pobox.Enabled = false;
            pobox.ForeColor = Color.Black;
            prepaymentchk.Checked = false;
            prepaymentlkp.Enabled = false;

            //periodbox.Font = new Font(periodbox.Font, FontStyle.Bold);
            periodbox.Text = "";
            periodbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            periodbox.Properties.Appearance.Options.UseTextOptions = true;
            suppbox.Font = new Font(suppbox.Font, FontStyle.Bold);
            suppbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            suppbox.Properties.Appearance.Options.UseTextOptions = true;
            pobox.Font = new Font(pobox.Font, FontStyle.Bold);
            pobox.Text = "";
            pobox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            pobox.Properties.Appearance.Options.UseTextOptions = true;
            basebox.Font = new Font(basebox.Font, FontStyle.Bold);
            basebox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            basebox.Properties.Appearance.Options.UseTextOptions = true;
            trbox.Font = new Font(trbox.Font, FontStyle.Bold);
            trbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            trbox.Properties.Appearance.Options.UseTextOptions = true;
            currbox.Font = new Font(currbox.Font, FontStyle.Bold);
            currbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            currbox.Properties.Appearance.Options.UseTextOptions = true;

            ownbanklkp.Properties.ShowHeader = true;
            supplkp.Properties.ShowHeader = true;
            prepaymentlkp.Properties.ShowHeader = true;

            LoadData();
            datebox.DateTime = DateTime.Today;
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

        private void prepaymentchk_CheckedChanged(object sender, EventArgs e)
        {
            if (prepaymentchk.Checked)
                prepaymentlkp.Enabled = true;
            else
            {
                prepaymentlkp.Enabled = false;
                prepaymentlkp.EditValue = null;
            }
        }

        private void ownbank_lkp(string currency)
        {
            string sqlcommand = "SELECT * FROM V_Payment_PaymentProfiles WHERE Currency = 'AZN' OR Currency = '" + currency + "' ORDER BY 2";
            
            string sqlcommand2 = "SELECT COUNT(ACNT_CODE) FROM SUNDATA.dbo.BSC_ACNT_ANL_CAT WHERE ANL_CAT_ID = 24 AND ANL_CODE = 'T16002' AND ACNT_CODE = N'" + F_ACNT + "'";

            int count = clsConnection.countReader(sqlcommand2);

            if (count == 1)
            {
                sqlcommand = "SELECT * FROM V_Payment_PaymentProfiles WHERE Currency = '" + currency + "' ORDER BY 2";
            }

            DataTable dt = clsConnection.reader(sqlcommand);
            ownbanklkp.Properties.DataSource = dt;

            ownbanklkp.Properties.DisplayMember = "Profile Name";
            ownbanklkp.Properties.ValueMember = "Currency";

            if (dt.AsEnumerable().Any(row => currency == row.Field<String>("Currency")) & (dt.Rows.Count == 1))
                ownbanklkp.EditValue = currency;
            ownbanklkp.Properties.ValueMember = "UID";

            ownbanklkp.Properties.PopulateColumns();
            ownbanklkp.Properties.Columns["UID"].Visible = false;
            ownbanklkp.Properties.Columns["Currency"].Visible = true;
            ownbanklkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                ownbanklkp.EditValue = ownbanklkp.ItemIndex = 0;
        }

        private void suppbank_lkp(string currency)
        {
            string sqlcommand = "SELECT * FROM V_Payment_BeneficiaryDetails WHERE [Beneficiary Code] = N'" + F_ACNT + "' AND Currency = 'AZN' OR [Beneficiary Code] = N'" + F_ACNT + "' AND Currency = '" + currency + "' ORDER BY 2";
            DataTable dt = clsConnection.reader(sqlcommand);
            supplkp.Properties.DataSource = dt;
            supplkp.Properties.DisplayMember = "Bank Name";
            supplkp.Properties.ValueMember = "Currency";

            if (dt.AsEnumerable().Any(row => currency == row.Field<String>("Currency")) & (dt.Rows.Count == 1))
                supplkp.EditValue = currency;
            supplkp.Properties.ValueMember = "UID";

            supplkp.Properties.PopulateColumns();
            supplkp.Properties.Columns["UID"].Visible = false;
            supplkp.Properties.Columns["Beneficiary Code"].Visible = false;
            supplkp.Properties.Columns["Bank Type"].Visible = false;
            supplkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                supplkp.EditValue = supplkp.ItemIndex = 0;
        }

        private void doc_lkp(string type, string pp_uid)
        {
            string sqlcommand = "SELECT * FROM V_Payment_DocumentFormat WHERE [Type] = N'" + type + "' AND BANK = (SELECT BANK FROM BeneficiaryDetails WHERE UID = '" + pp_uid + "') ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            doclkp.Properties.DataSource = dt;
            doclkp.Properties.DisplayMember = "Name";
            doclkp.Properties.ValueMember = "Name";
            doclkp.Properties.PopulateColumns();
            doclkp.Properties.Columns["Code"].Visible = false;
            doclkp.Properties.Columns["Type"].Visible = false;
            doclkp.Properties.Columns["BANK"].Visible = false;
            doclkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                doclkp.EditValue = doclkp.ItemIndex = 0;
        }

        private void prepayment_lkp()
        {
            string sqlcommand = "SELECT * FROM V_Payment_Prepayment ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            prepaymentlkp.Properties.DataSource = dt;
            prepaymentlkp.Properties.DisplayMember = "Account Code";
            prepaymentlkp.Properties.ValueMember = "Account Code";
            prepaymentlkp.Properties.PopulateColumns();
            prepaymentlkp.Properties.DropDownRows = dt.Rows.Count;
        }

        private void prepayment_chk()
        {
            string query = @"SELECT COUNT(*) FROM V_ChartOfAccounts_Prepayment WHERE [Account Code] IN (SELECT ANAL_T0 FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "')";
            string count = clsConnection.singleReader(query);

            if (count != "0")
            {
                prepaymentchk.Checked = true;

                query = @"SELECT TOP 1 ANAL_T0 FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "' AND ANAL_T0 IN (SELECT [Account Code] FROM V_ChartOfAccounts_Prepayment)";
                string acnt = clsConnection.singleReader(query);
                prepaymentlkp.EditValue = acnt;
            }
        }

        public void LoadData()
        {
            try
            {
                double num1 = 0.0;
                double num2 = 0.0;

                grid.DataSource = null;
                gridview.Columns.Clear();
                string sqlselect = F_SQLSTRING;
                grid.DataSource = clsConnection.reader(sqlselect);

                gridview.Columns[F_GRID_COL].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridview.Columns[F_GRID_COL].SummaryItem.DisplayFormat = "{0}";
                gridview.Columns["REMARK"].Visible = false;
                gridview.Columns["Or. Tr. Amount"].Visible = false;
                gridview.Columns["Or. Base Amount"].Visible = false;
                gridview.BestFitColumns();

                if (gridview.RowCount > 0)
                {
                    string query = "SELECT dbo.PAYM_GET_TREFERENCE (N'" + f_user + "')";
                    print1box.Text = clsConnection.singleReader(query);

                    query = @"SELECT CASE WHEN (SELECT COUNT(DISTINCT CONV_CODE) FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "') = 1 " +
                    "THEN (SELECT TOP 1 CONV_CODE FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "') ELSE '-' END";
                    currbox.Text = clsConnection.singleReader(query);

                    query = "SELECT SUM(AMOUNT) FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "'";
                    num1 = Convert.ToDouble(clsConnection.singleReader(query));

                    query = "SELECT SUM(OTHER_AMT) FROM PaymentOrderDetails WHERE REMARK = N'" + f_user + "'";
                    num2 = Convert.ToDouble(clsConnection.singleReader(query));

                    basebox.Text = num1.ToString("#,###,###,###.00");
                    trbox.Text = num2.ToString("#,###,###,###.00");

                    string currency = currbox.Text.Trim();
                    ownbank_lkp(currency);
                    suppbank_lkp(currency);
                    prepayment_lkp();
                    prepayment_chk();
                }
                else
                {
                    XtraMessageBox.Show("Unknown error");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                print1box.Text = "";
                currbox.Text = "";
                basebox.Text = "0.00";
                trbox.Text = "0.00";
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (datebox.Text == "" | datebox.Text == null | periodbox.Text.Length < 7)
                {
                    XtraMessageBox.Show("Payment date wasn't specified");
                    datebox.Focus();
                    return;
                }

                if (ownbanklkp.Text == "" | ownbanklkp.EditValue == null)
                {
                    XtraMessageBox.Show("Company's Bank field is mandatory");
                    ownbanklkp.Focus();
                    return;
                }

                if (supplkp.Text == "" | supplkp.EditValue == null)
                {
                    XtraMessageBox.Show("Supplier's Bank field is mandatory");
                    supplkp.Focus();
                    return;
                }

                if (prepaymentchk.Checked == true)
                {
                    if (prepaymentlkp.Text == "" | prepaymentlkp.EditValue == null)
                    {
                        XtraMessageBox.Show("Prepayment account wasn't specified");
                        prepaymentlkp.Focus();
                        return;
                    }
                }

                if (doclkp.Text == "" | doclkp.EditValue == null)
                {
                    XtraMessageBox.Show("Report format wasn't specified");
                    doclkp.Focus();
                    return;
                }

                double base_amt = 0;
                string amt = basebox.Text;

                if (double.TryParse(amt, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out base_amt))
                {
                    if (base_amt == 0)
                    {
                        XtraMessageBox.Show("Incorrect base amount");
                        basebox.Focus();
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Incorrect base amount");
                    basebox.Focus();
                    return;
                }

                double tr_amt = 0;
                string amt2 = trbox.Text;
                if (double.TryParse(amt2, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out tr_amt))
                {
                    if (tr_amt == 0)
                    {
                        XtraMessageBox.Show("Incorrect transaction amount");
                        trbox.Focus();
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Incorrect transaction amount");
                    trbox.Focus();
                    return;
                }

                if (pobox.Text.Trim().Length > 2)
                {
                    string paym_txn_ref = clsConnection.trimSql(pobox.Text);
                    string sqlcommand = "SELECT TOP 1 POST_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + paym_txn_ref + "'";
                    string status = clsConnection.singleReader(sqlcommand);

                    if (status != "0")
                    {
                        XtraMessageBox.Show("Only draft payment orders can be updated");
                        return;
                    }
                    else
                    {
                        UpdatePO();
                    }
                }
                else
                {
                    string date = datebox.Text.Trim();
                    string period = periodbox.Text.Trim();

                    DataRowView row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                    string ownbank_uid = row["UID"].ToString();
                    row = supplkp.Properties.GetDataSourceRowByKeyValue(supplkp.EditValue) as DataRowView;
                    string supp_uid = row["UID"].ToString();
                    row = doclkp.Properties.GetDataSourceRowByKeyValue(doclkp.EditValue) as DataRowView;
                    string df_code = clsConnection.trimSql(row["Code"].ToString());

                    string print1 = clsConnection.trimSql(print1box.Text);
                    string print2 = clsConnection.trimSql(print2box.Text);
                    string print3 = clsConnection.trimSql(print3box.Text);
                    string print4 = clsConnection.trimSql(print4box.Text);
                    string curr = clsConnection.trimSql(currbox.Text.Trim());

                    int prepayment = 0;
                    string prepayment_acnt = "NULL";

                    if (prepaymentchk.Checked == true)
                    {
                        prepayment = 1;
                        row = prepaymentlkp.Properties.GetDataSourceRowByKeyValue(prepaymentlkp.EditValue) as DataRowView;
                        prepayment_acnt = "N'" + clsConnection.trimSql(row["Account Code"].ToString()) + "'";
                    }

                    string query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = 'AZN'";
                    string unit = clsConnection.singleReader(query);

                    query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = 'AZN'";
                    string subunit = clsConnection.singleReader(query);

                    string amount_word = clsTransaction.amount2Text(basebox.Text, unit, subunit);
                    string curr2 = curr;
                    if (curr2 == "-")
                        curr2 = "AZN";

                    query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = N'" + curr2 + "'";
                    unit = clsConnection.singleReader(query);

                    query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = N'" + curr2 + "'";
                    subunit = clsConnection.singleReader(query);

                    string other_amt_word = clsTransaction.amount2Text(trbox.Text, unit, subunit);

                    query = "SET DATEFORMAT DMY EXECUTE [dbo].[PaymentCreate] N'" + F_ACNT + "', " + base_amt + ", " + tr_amt + ", N'" + curr + "', " + period + ", '" + date + "', '" + ownbank_uid + "', '" + supp_uid + "', N'" + df_code + "', N'" + amount_word + "', N'" + other_amt_word + "', N'" + print1 + "', N'" + print2 + "', N'" + print3 + "', N'" + print4 + "', N'" + f_user + "'";
                    clsConnection.singleExecute(query);

                    query = "SELECT TXN_REF FROM TransactionReference WHERE OPR_TYPE = 'PAYM'";
                    string paym_txn_ref = clsConnection.singleReader(query);

                    query = "UPDATE PaymentOrder SET PREPAYMENT_STATUS = " + prepayment + ", PREPAYMENT_CA_CODE = " + prepayment_acnt + " WHERE PAYM_TXN_REF = N'" + paym_txn_ref + "'";
                    clsConnection.singleExecute(query);

                    f_mainform.statuscaption("Payment order was saved");
                    pobox.Text = paym_txn_ref;
                    deletePrevLines();
                    printbtn.Enabled = true;
                    postbtn.Enabled = false;
                    savebtn.Text = "Update";
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

        public void UpdatePO()
        {
            try
            {
                string date = datebox.Text.Trim();
                string period = periodbox.Text.Trim();
                DataRowView row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string ownbank_uid = row["UID"].ToString();
                row = supplkp.Properties.GetDataSourceRowByKeyValue(supplkp.EditValue) as DataRowView;
                string supp_uid = row["UID"].ToString();
                row = doclkp.Properties.GetDataSourceRowByKeyValue(doclkp.EditValue) as DataRowView;
                string df_code = clsConnection.trimSql(row["Code"].ToString());

                string print1 = clsConnection.trimSql(print1box.Text);
                string print2 = clsConnection.trimSql(print2box.Text);
                string print3 = clsConnection.trimSql(print3box.Text);
                string print4 = clsConnection.trimSql(print4box.Text);
                string paym_txn_ref = clsConnection.trimSql(pobox.Text);

                int prepayment = 0;
                string prepayment_acnt = "NULL";

                if (prepaymentchk.Checked == true)
                {
                    prepayment = 1;
                    row = prepaymentlkp.Properties.GetDataSourceRowByKeyValue(prepaymentlkp.EditValue) as DataRowView;
                    prepayment_acnt = "N'" + clsConnection.trimSql(row["Account Code"].ToString()) + "'";
                }

                string query = "SET DATEFORMAT DMY UPDATE PaymentOrder SET BD_UID = '" + supp_uid + "', PP_UID = '" + ownbank_uid + "', PAYM_DATE = '" + date + "', PAYM_PERIOD = " + period + ", PRINTFIELD_1 = N'" + print1 + "', PRINTFIELD_2 = N'" + print2 + "', PRINTFIELD_3 = N'" + print3 + "', PRINTFIELD_4 = N'" + print4 + "', DF_CODE = N'" + df_code + "', PRINT_STATUS = 0, PREPAYMENT_STATUS = " + prepayment + ", PREPAYMENT_CA_CODE = " + prepayment_acnt + ", UPDATED_USER = N'" + f_user + "', UPDATED_DATE = GETDATE() WHERE PAYM_TXN_REF = N'" + paym_txn_ref + "'";
                clsConnection.singleExecute(query);

                f_mainform.statuscaption("Payment order was updated");
                printbtn.Enabled = true;
                postbtn.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                printbtn.Enabled = false;
                postbtn.Enabled = false;
                return;
            }
        }

        private string TXN_REF()
        {
            return pobox.Text.Trim();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (pobox.Text.Trim() == "" | pobox.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Payment order was not saved");
                pobox.Focus();
                return;
            }

            if (TXN_REF() != "")
            {
                try
                {
                    string paym_txn_ref = clsConnection.trimSql(TXN_REF());
                    Report report = clsPrint.printPayment(paym_txn_ref);
                    if (report != null)
                    {
                        clsPrint.updateStatus("PaymentOrder", "PAYM_TXN_REF", paym_txn_ref);
                        frmPrintPreview form1 = new frmPrintPreview(report, F_FONT85, f_user);
                        form1.StartPosition = FormStartPosition.CenterScreen;
                        form1.MdiParent = f_mainform;
                        form1.Show();
                        f_mainform.statuscaption("Payment Order was printed");

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
                string paym_txn_ref = clsConnection.trimSql(TXN_REF());
                if (clsPost.postPayment(paym_txn_ref) == true)
                {
                    frmPost form = new frmPost(false, paym_txn_ref, "PAYM", "Payment Order Post - " + paym_txn_ref, F_FONT85, f_user, f_user_post, f_mainform);
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

        public void deletePrevLines()
        {
            try
            {
                string query = "EXECUTE dbo.PaymentDeletePreview N'" + f_user + "'";
                clsConnection.singleExecute(query);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaymentGenerate_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }

        private void ownbanklkp_EditValueChanged(object sender, EventArgs e)
        {
            if (ownbanklkp.Text != "" | ownbanklkp.EditValue != null)
            {
                DataRowView row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string curr = row["Currency"].ToString();
                oblbl.Text = curr;
            }
            else
            {
                oblbl.Text = "";
            }

            if (ownbanklkp.Text != "" & ownbanklkp.EditValue != null & supplkp.Text != "" & supplkp.EditValue != null)
            {
                DataRowView row = supplkp.Properties.GetDataSourceRowByKeyValue(supplkp.EditValue) as DataRowView;
                string type = row["Bank Type"].ToString();
                row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string pp_uid = row["UID"].ToString();

                doclkp.EditValue = null;
                doc_lkp(type, pp_uid);
            }
        }

        private void supplkp_EditValueChanged(object sender, EventArgs e)
        {
            if (supplkp.Text != "" | supplkp.EditValue != null)
            {
                DataRowView row = supplkp.Properties.GetDataSourceRowByKeyValue(supplkp.EditValue) as DataRowView;
                string curr = row["Currency"].ToString();
                sblbl.Text = curr;
            }
            else
            {
                sblbl.Text = "";
            }

            if (ownbanklkp.Text != "" & ownbanklkp.EditValue != null & supplkp.Text != "" & supplkp.EditValue != null)
            {
                DataRowView row = supplkp.Properties.GetDataSourceRowByKeyValue(supplkp.EditValue) as DataRowView;
                string type = row["Bank Type"].ToString();
                row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string pp_uid = row["UID"].ToString();

                doclkp.EditValue = null;
                doc_lkp(type, pp_uid);
            }
        }

        private void frmPaymentGenerate_Resize(object sender, EventArgs e)
        {
            panel2.Width = this.Width;
            datebox.Select();
            datebox.Focus();
        }

        private void print4box_Leave(object sender, EventArgs e)
        {
            savebtn.Select();
            savebtn.Focus();
        }

        private void doclkp_Leave(object sender, EventArgs e)
        {
            print1box.Select();
        }

        private void cancelbtn_Leave(object sender, EventArgs e)
        {
            datebox.Select();
            datebox.Focus();
        }
    }
}
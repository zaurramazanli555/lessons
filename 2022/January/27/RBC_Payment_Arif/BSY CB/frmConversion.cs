using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using System.Globalization;
using FastReport;

namespace CASHBOOK
{
    public partial class frmConversion : DevExpress.XtraEditors.XtraForm
    {
        private string F_DOC_NO;
        private string f_user;
        private string f_user_post;
        private Font F_FONT;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmConversion()
        {
            InitializeComponent();
        }

        public frmConversion(string doc_no, string formtext, Font font, string user, string user_post, frmMain f_mainform)
        {
            InitializeComponent();
            F_DOC_NO = doc_no;
            f_user = user;
            f_user_post = user_post;
            F_FONT = font;
            this.f_mainform = f_mainform;
            this.Text = formtext;
        }

        private void frmConversion_Load(object sender, EventArgs e)
        {
            periodbox.Text = "";
            periodbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            periodbox.Properties.Appearance.Options.UseTextOptions = true;
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            datebox.DateTime = DateTime.Today;

            validdatebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            validdatebox.DateTime = DateTime.Today;

            typelkp.Properties.DataSource = clsTransaction.conversion_list();
            typelkp.Properties.DropDownRows = clsTransaction.conversion_list().Count;
            ownbank_lkp();

            if (F_DOC_NO.Length > 1)
                getDetails();
            else
            {
                ownbanklkp.Properties.ValueMember = "UID";
                ownbank2lkp.Properties.ValueMember = "UID";
            }
        }

        private void getDetails()
        {
            try
            {
                string query = "";
                orderbox.Text = F_DOC_NO;

                query = @"SELECT CONV_TYPE FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                typelkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT CONVERT(VARCHAR(10), CONV_DATE, 112) FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                datebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                query = @"SELECT CONVERT(VARCHAR(10), CONV_VALID_DATE, 112) FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                validdatebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                query = @"SELECT CONV_PERIOD FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                periodbox.Text = clsConnection.singleReader(query);

                query = @"SELECT AMT FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                amtbox.Text = clsConnection.singleReader(query);

                query = @"SELECT BD_NAME FROM BeneficiaryDetails WHERE UID = (SELECT PP_UID FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "')";
                ownbanklkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT BD_NAME FROM BeneficiaryDetails WHERE UID = (SELECT PP_UID2 FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "')";
                ownbank2lkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT PRINTFIELD_1 FROM Conversion WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                descbox.Text = clsConnection.singleReader(query);

                savebtn.Text = "Update";
                ownbanklkp.Properties.ValueMember = "UID";
                ownbank2lkp.Properties.ValueMember = "UID";
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

            validdatebox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            validdatebox.Properties.Mask.EditMask = format;
            validdatebox.Properties.Mask.UseMaskAsDisplayFormat = true;
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

        private void validdatebox_EditValueChanged(object sender, EventArgs e)
        {
            if (validdatebox.Text == "" | validdatebox.Text == null)
                validdatebox.DateTime = DateTime.Today;

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

        private void ownbank_lkp()
        {
            string sqlcommand = "SELECT * FROM V_Conversion_PaymentProfiles ORDER BY 2";
            DataTable dt = clsConnection.reader(sqlcommand);
            ownbanklkp.Properties.DataSource = dt;
            ownbanklkp.Properties.DisplayMember = "Profile Name";
            ownbanklkp.Properties.ValueMember = "Profile Name";
            ownbanklkp.Properties.PopulateColumns();
            ownbanklkp.Properties.Columns["UID"].Visible = false;
            ownbanklkp.Properties.Columns["Currency"].Visible = false;
            ownbanklkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                ownbanklkp.EditValue = ownbanklkp.ItemIndex = 0;
        }

        private void ownbank2_lkp(string pp_uid)
        {
            ownbank2lkp.Properties.DataSource = null;
            string sqlcommand = "SELECT * FROM V_Conversion_PaymentProfiles WHERE UID IN (SELECT UID FROM BeneficiaryDetails WHERE BANK IN (SELECT BANK FROM BeneficiaryDetails WHERE UID = '" + pp_uid + "')) AND UID <> '" + pp_uid + "' ORDER BY 2";
            DataTable dt = clsConnection.reader(sqlcommand);
            ownbank2lkp.Properties.DataSource = dt;
            ownbank2lkp.Properties.DisplayMember = "Profile Name";
            ownbank2lkp.Properties.ValueMember = "Profile Name";
            ownbank2lkp.Properties.PopulateColumns();
            ownbank2lkp.Properties.Columns["UID"].Visible = false;
            ownbank2lkp.Properties.Columns["Currency"].Visible = false;
            ownbank2lkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                ownbank2lkp.EditValue = ownbank2lkp.ItemIndex = 0;
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

                if (validdatebox.Text == "" | validdatebox.Text == null)
                {
                    XtraMessageBox.Show("Valid Date field is mandatory");
                    validdatebox.Focus();
                    return;
                }

                if (datebox.DateTime > validdatebox.DateTime)
                {
                    XtraMessageBox.Show("Valid date can not be less than conversion date");
                    validdatebox.Focus();
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

                if (ownbanklkp.Text == "" | ownbanklkp.EditValue == null)
                {
                    ownbanklkp.Focus();
                    return;
                }

                if (ownbank2lkp.Text == "" | ownbank2lkp.EditValue == null)
                {
                    ownbank2lkp.Focus();
                    return;
                }

                if (ownbank2lkp.EditValue.ToString() == ownbanklkp.EditValue.ToString())
                {
                    XtraMessageBox.Show("Duplicate: " + ownbanklkp.Text);
                    ownbank2lkp.Focus();
                    return;
                }

                string date = datebox.Text.Trim();
                string validdate = validdatebox.Text.Trim();
                string period = periodbox.Text.Trim();

                DataRowView row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string from_uid = row["UID"].ToString();
                row = ownbank2lkp.Properties.GetDataSourceRowByKeyValue(ownbank2lkp.EditValue) as DataRowView;
                string to_uid = row["UID"].ToString();

                string type = typelkp.EditValue.ToString().Trim();
                string print1 = clsConnection.trimSql(descbox.Text);
                string query = "";

                query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = (SELECT CU_CODE FROM BeneficiaryDetails WHERE UID = '" + from_uid + "')";
                string unit = clsConnection.singleReader(query);

                query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = (SELECT CU_CODE FROM BeneficiaryDetails WHERE UID = '" + from_uid + "')";
                string subunit = clsConnection.singleReader(query);

                string amt_word = clsTransaction.amount2Text(amount.ToString(), unit, subunit);

                if (orderbox.Text.Trim().Length > 2)
                {
                    string conv_txn_ref = clsConnection.trimSql(orderbox.Text);
                    string sqlcommand = "SELECT TOP 1 POST_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + conv_txn_ref + "'";
                    string status = clsConnection.singleReader(sqlcommand);

                    if (status != "0")
                    {
                        XtraMessageBox.Show("Only draft conversions can be updated");
                        return;
                    }
                    else
                    {
                        UpdateConversion(type, from_uid, to_uid, date, validdate, period, amount, amt_word, print1);
                    }
                }
                else
                {
                    query = "SET DATEFORMAT DMY EXECUTE [dbo].[ConversionCreate] '" + type + "', " + amount + ", " + period + ", '" + date + "', '" + validdate + "', '" + from_uid + "', '" + to_uid + "', N'" + amt_word + "', N'" + print1 + "', N'" + f_user + "'";
                    clsConnection.singleExecute(query);

                    query = "SELECT TXN_REF FROM TransactionReference WHERE OPR_TYPE = 'CONV'";
                    string conv_txn_ref = clsConnection.singleReader(query);
                    orderbox.Text = conv_txn_ref;
                    f_mainform.statuscaption("Conversion was saved");
                }

                printbtn.Enabled = true;
                postbtn.Enabled = false;
                savebtn.Text = "Update";
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

        public void UpdateConversion(string type, string from_uid, string to_uid, string date, string validdate, string period, double amount, string amt_word, string print1)
        {
            try
            {
                string conv_txn_ref = clsConnection.trimSql(TXN_REF());
                string query = "SET DATEFORMAT DMY UPDATE Conversion SET CONV_TYPE = '" + type + "', PP_UID = '" + from_uid + "', PP_UID2 = '" +
                    to_uid + "', CONV_DATE = '" + date + "', CONV_VALID_DATE = '" + validdate + "', CONV_PERIOD = " + period + ", AMT = " + amount + ", AMT_TEXT = N'" +
                    amt_word + "', DF_CODE = (SELECT DF_CODE FROM DocumentFormat WHERE BANK = (SELECT BANK FROM BeneficiaryDetails WHERE UID = '" + from_uid + "' AND DF_CODE LIKE '%CONV%' AND STATUS = 1)), PRINTFIELD_1 = N'" + print1 + "', PRINT_STATUS = 0, UPDATED_USER = N'" + f_user + "', UPDATED_DATE = GETDATE() WHERE CONV_TXN_REF = N'" + conv_txn_ref + "'";
                clsConnection.singleExecute(query);

                query = "UPDATE Conversion SET CU_CODE = (SELECT CU_CODE FROM BeneficiaryDetails WHERE UID = (SELECT PP_UID FROM Conversion WHERE CONV_TXN_REF = N'" + conv_txn_ref + "')), " +
                "CU_CODE2 = (SELECT CU_CODE FROM BeneficiaryDetails WHERE UID = (SELECT PP_UID2 FROM Conversion WHERE CONV_TXN_REF = N'" + conv_txn_ref + "')) WHERE CONV_TXN_REF = N'" + conv_txn_ref + "'";
                clsConnection.singleExecute(query);

                cancellation = "0";
                f_mainform.statuscaption("Conversion was updated");
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConversion_FormClosing(object sender, FormClosingEventArgs e)
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
                XtraMessageBox.Show("Conversion was not saved");
                orderbox.Focus();
                return;
            }

            if (TXN_REF() != "")
            {
                try
                {
                    string conv_txn_ref = clsConnection.trimSql(TXN_REF());
                    Report report = clsPrint.printConversion(conv_txn_ref);
                    if (report != null)
                    {
                        clsPrint.updateStatus("Conversion", "CONV_TXN_REF", conv_txn_ref);
                        frmPrintPreview form1 = new frmPrintPreview(report, F_FONT, f_user);
                        form1.StartPosition = FormStartPosition.CenterScreen;
                        form1.MdiParent = f_mainform;
                        form1.Show();
                        f_mainform.statuscaption("Conversion was printed");

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
                string conv_txn_ref = clsConnection.trimSql(TXN_REF());
                if (clsPost.postConversion(conv_txn_ref) == true)
                {
                    frmPost form = new frmPost(false, conv_txn_ref, "CONV", "Conversion Post - " + conv_txn_ref, F_FONT, f_user, f_user_post, f_mainform);
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
            string p = "Purchase Acc.:";
            string s = "Sale Acc.:";
            try
            {
                string type = clsConnection.trimSql(typelkp.EditValue.ToString());
                descbox.Text = clsConnection.singleReader("SELECT dbo.GET_DEFAULT_TEXT('CONV', N'" + type + "')");

                if (type == "Purchase")
                {
                    lblfrom.Text = p;
                    lblto.Text = s;
                }
                else
                {
                    lblfrom.Text = s;
                    lblto.Text = p;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                return;
            }
        }

        private void ownbanklkp_EditValueChanged(object sender, EventArgs e)
        {
            if (ownbanklkp.Text != "" & ownbanklkp.EditValue != null)
            {
                DataRowView row = ownbanklkp.Properties.GetDataSourceRowByKeyValue(ownbanklkp.EditValue) as DataRowView;
                string pp_uid = row["UID"].ToString();
                ownbank2_lkp(pp_uid);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using System.Globalization;

namespace CASHBOOK
{
    public partial class frmDocumentUpdate : DevExpress.XtraEditors.XtraForm
    {
        private string F_TYPE = "";
        private string F_DOC_NO;
        private string F_TABLE = "";
        private string F_COLUMN = "";
        private string F_COLUMN_DATE = "";
        private string F_COLUMN_PERIOD = "";
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmDocumentUpdate()
        {
            InitializeComponent();
        }

        public frmDocumentUpdate(string type, string text, frmMain f_mainform, string USER)
        {
            InitializeComponent();
            f_user = USER;
            F_TYPE = type;
            this.f_mainform = f_mainform;
            this.Text = text;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            f_mainform.statuscaption("");
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

        private void frmDocumentUpdate_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            periodbox.Text = "";
            periodbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            periodbox.Properties.Appearance.Options.UseTextOptions = true;
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;

            List<string> op_list = new List<string>();

            op_list.Add("Cash Voucher");
            op_list.Add("Conversion");
            op_list.Add("Payment Order");

            typelkp.Properties.DataSource = op_list;
            typelkp.Properties.DropDownRows = op_list.Count;

            if (F_TYPE == "PAYM")
                typelkp.EditValue = "Payment Order";

            if (F_TYPE == "CONV")
                typelkp.EditValue = "Conversion";

            if (F_TYPE == "CASH")
                typelkp.EditValue = "Cash Voucher";

            typelkp.Enabled = false;
            docbox.Enabled = true;
            docbox.ReadOnly = false;
            datebox.Enabled = false;
            print1box.ReadOnly = true;
            openbtn.Enabled = true;
            savebtn.Enabled = false;
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (datebox.Text == "" | datebox.Text == null | periodbox.Text.Length < 7)
                {
                    XtraMessageBox.Show("Date wasn't specified");
                    datebox.Focus();
                    return;
                }

                string date = datebox.Text.Trim();
                string print1 = clsConnection.trimSql(print1box.Text);
                string period = periodbox.Text.Trim();

                string sqlcommand = "SELECT COUNT(DISTINCT POST_STATUS) FROM " + F_TABLE + " WHERE POST_STATUS = 0 AND " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                string status = clsConnection.singleReader(sqlcommand);
                if (status != "0")
                {
                    string query = @"SET DATEFORMAT DMY UPDATE " + F_TABLE + " SET " + F_COLUMN_DATE + " = '" + date + "', " + F_COLUMN_PERIOD + " = '" + period + "', PRINTFIELD_1 = N'" + print1 + "', UPDATED_USER = N'" + f_user + "', UPDATED_DATE = GETDATE() WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                    clsConnection.singleExecute(query);
                    f_mainform.statuscaption("Document was updated");
                    savebtn.Enabled = false;
                    datebox.Enabled = false;
                    print1box.ReadOnly = true;
                }
                else
                {
                    XtraMessageBox.Show("Only draft documents can be amended");
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                savebtn.Enabled = false;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDocumentUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            F_DOC_NO = clsConnection.trimSql(docbox.Text.ToString());

            if (F_DOC_NO.Length == 0)
                return;

            if (typelkp.Text == "" | typelkp.EditValue == null)
                return;

            switch (typelkp.EditValue.ToString())
            {
                case "Payment Order":
                    F_TABLE = "PaymentOrder";
                    F_COLUMN = "PAYM_TXN_REF";
                    F_COLUMN_DATE = "PAYM_DATE";
                    F_COLUMN_PERIOD = "PAYM_PERIOD";
                    break;

                case "Conversion":
                    F_TABLE = "Conversion";
                    F_COLUMN = "CONV_TXN_REF";
                    F_COLUMN_DATE = "CONV_DATE";
                    F_COLUMN_PERIOD = "CONV_PERIOD";
                    break;

                case "Cash Voucher":
                    F_TABLE = "Cash";
                    F_COLUMN = "CASH_TXN_REF";
                    F_COLUMN_DATE = "CASH_DATE";
                    F_COLUMN_PERIOD = "CASH_PERIOD";
                    break;
            }
            string query = @"SELECT COUNT(*) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
            string count = clsConnection.singleReader(query);
            if (count == "1")
                getDetails();
            else
                XtraMessageBox.Show("Document wasn't found");
        }

        private void getDetails()
        {
            try
            {
                if (clsTransaction.checkYear(F_DOC_NO, F_TABLE, F_COLUMN) == "0")
                {
                    string sqlcommand = "SELECT COUNT(DISTINCT POST_STATUS) FROM " + F_TABLE + " WHERE POST_STATUS = 0 AND " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                    string status = clsConnection.singleReader(sqlcommand);
                    if (status != "0")
                    {
                        string query = "";
                        query = @"SELECT PRINTFIELD_1 FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                        print1box.Text = clsConnection.singleReader(query);

                        query = @"SELECT CONVERT(VARCHAR(10), " + F_COLUMN_DATE + ", 112) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                        datebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                        query = @"SELECT " + F_COLUMN_PERIOD + " FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                        periodbox.Text = clsConnection.singleReader(query);

                        docbox.Enabled = false;
                        docbox.ReadOnly = true;
                        typelkp.Enabled = false;
                        datebox.Enabled = true;
                        print1box.ReadOnly = false;
                        openbtn.Enabled = false;
                        savebtn.Enabled = true;
                        docbox.Font = new Font(docbox.Font, FontStyle.Bold);
                    }
                    else
                    {
                        XtraMessageBox.Show("Only draft documents can be amended");
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Document can't be amended");
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                docbox.Enabled = true;
                docbox.ReadOnly = false;
                typelkp.Enabled = true;
                datebox.Enabled = false;
                print1box.ReadOnly = true;
                openbtn.Enabled = true;
                savebtn.Enabled = false;
            }
        }
    }
}
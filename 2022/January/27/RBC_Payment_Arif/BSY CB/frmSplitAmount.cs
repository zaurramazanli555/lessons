using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmSplitAmount : DevExpress.XtraEditors.XtraForm
    {
        private string F_JRNAL_NO;
        private string F_JRNAL_LINE;
        private string F_TREFERENCE;
        private double F_AMOUNT;
        private string F_CURRENCY;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmSplitAmount(string JRNAL_NO, string JRNAL_LINE, string TREFERENCE, double AMOUNT, string CURRENCY, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_JRNAL_NO = JRNAL_NO;
            F_JRNAL_LINE = JRNAL_LINE;
            F_TREFERENCE = TREFERENCE;
            F_AMOUNT = AMOUNT;
            F_CURRENCY = CURRENCY;
            f_user = USER;
            this.f_mainform = f_mainform;
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

        private void frmSplitAmount_Load(object sender, EventArgs e)
        {
            lblJrnal_no.Text = F_JRNAL_NO;
            lblJrnal_line.Text = F_JRNAL_LINE;
            lblTreference.Text = F_TREFERENCE;
            lblAmount.Text = F_AMOUNT.ToString("#,###,###,###.00") + " " + F_CURRENCY;
            amtbox.Text = "1";
        }

        private void splitbtn_Click(object sender, EventArgs e)
        {
            split();
        }

        private void split()
        {
            try
            {
                double amount = 0;
                string amt = amtbox.Text.Replace(",", ".");

                if (double.TryParse(amt, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amount))
                {
                    if (amount == 0 | amount == F_AMOUNT)
                    {
                        XtraMessageBox.Show("Incorrect amount");
                        amtbox.Focus();
                        return;
                    }

                    else if (amount < 0 & F_AMOUNT > 0)
                    {
                        XtraMessageBox.Show("Incorrect amount");
                        amtbox.Focus();
                        return;
                    }

                    else if (amount > 0 & F_AMOUNT < 0)
                    {
                        XtraMessageBox.Show("Incorrect amount");
                        amtbox.Focus();
                        return;
                    }

                    else if (amount > 0 & amount > F_AMOUNT)
                    {
                        XtraMessageBox.Show("Splitted amount must be less than source amount");
                        amtbox.Focus();
                        return;
                    }

                    else if (amount < 0 & amount < F_AMOUNT)
                    {
                        XtraMessageBox.Show("Splitted amount must be less than source amount");
                        amtbox.Focus();
                        return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Incorrect amount");
                    amtbox.Focus();
                    return;
                }

                string sqlcommand = "EXEC PaymentSplitAmount " + F_JRNAL_NO + ", " + F_JRNAL_LINE + ", " + amount;
                clsConnection.singleExecute(sqlcommand);
                cancellation = "0";
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
            }
        }


        private void amtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-')  && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
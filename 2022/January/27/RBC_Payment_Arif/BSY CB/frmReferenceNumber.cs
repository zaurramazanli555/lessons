using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace CASHBOOK
{
    public partial class frmReferenceNumber : DevExpress.XtraEditors.XtraForm
    {
        private frmMain f_mainform;
        private string f_user;

        public frmReferenceNumber(frmMain f_mainform, string USER)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.f_mainform = f_mainform;
            f_user = USER;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmReferenceNumber_Load(object sender, EventArgs e)
        {
            operationlkp.Properties.ShowHeader = true;
            string sqlcommand = "SELECT RTRIM(OPR_TYPE) AS [Operation Type], RTRIM(OPR_NAME) AS Name, HIGH_NUM + 1 AS [Next Number] FROM TransactionReference";
            DataTable dt = clsConnection.reader(sqlcommand);
            operationlkp.Properties.DataSource = dt;
            operationlkp.Properties.PopulateColumns();
            operationlkp.Properties.DisplayMember = "Name";
            operationlkp.Properties.ValueMember = "Name";
            operationlkp.Properties.Columns[0].Visible = false;
            operationlkp.Properties.DropDownRows = dt.Rows.Count;
            amtbox.Properties.MaxLength = 6;
        }

        private void operationlkp_EditValueChanged(object sender, EventArgs e)
        {
            if (operationlkp.EditValue != null)
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                string value = row["Next Number"].ToString();
                amtbox.Text = value;
                amendbtn.Enabled = true;
            }
        }

        private void amendbtn_Click(object sender, EventArgs e)
        {
            savebtn.Enabled = true;
            amtbox.Properties.ReadOnly = false;
            operationlkp.ReadOnly = true;
            amendbtn.Enabled = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            DataRowView row = operationlkp.Properties.GetDataSourceRowByKeyValue(operationlkp.EditValue) as DataRowView;
            string type = row["Operation Type"].ToString();

            int num_current = 0;
            if (checknumber() != 0)
            {
                num_current = checknumber();
                string table = "";
                string sqlcommand = "";

                if (type == "PAYM")
                {
                    table = "PaymentOrder";
                    sqlcommand = @"SELECT COUNT(ORIG_REF) AS COUNT FROM " + table + " WHERE ORIG_REF >= " + num_current.ToString();
                }
                else if (type == "CONV")
                {
                    table = "Conversion";
                    sqlcommand = @"SELECT COUNT(ORIG_REF) AS COUNT FROM " + table + " WHERE ORIG_REF >= " + num_current.ToString();
                }
                else if (type == "CR")
                {
                    table = "Cash";
                    sqlcommand = @"SELECT COUNT(ORIG_REF) AS COUNT FROM " + table + " WHERE CASH_TYPE = 'Receipt' AND ORIG_REF >= " + num_current.ToString();
                }
                else if (type == "CP")
                {
                    table = "Cash";
                    sqlcommand = @"SELECT COUNT(ORIG_REF) AS COUNT FROM " + table + " WHERE CASH_TYPE = 'Payment' AND ORIG_REF >= " + num_current.ToString();
                }

                int count = clsConnection.countReader(sqlcommand);

                if (count > 0)
                {
                    XtraMessageBox.Show("Number is in use");
                    amtbox.Focus();
                    return;
                }
                else
                {
                    num_current = checknumber() - 1;
                    sqlcommand = @"UPDATE TOP (1) TransactionReference SET HIGH_NUM = " + num_current.ToString() + ", [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE OPR_TYPE = N'" + type + "'";
                    clsConnection.singleExecute(sqlcommand);
                    f_mainform.statuscaption("Number was saved");
                    savebtn.Enabled = false;
                    amtbox.Properties.ReadOnly = true;
                }
            }
            else
            {
                XtraMessageBox.Show("Number is not correct");
                amtbox.Focus();
                return;
            }
        }

        private int checknumber()
        {
            int num = 0;
            try
            {
                num = int.Parse(amtbox.Text, CultureInfo.InvariantCulture);
            }
            catch
            {
                num = 0;
            }
            return num;
        }

        private void amtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmReferenceNumber_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmTransactionFormat : DevExpress.XtraEditors.XtraForm
    {
        private frmMain f_mainform;
        private string f_user;

        public frmTransactionFormat(frmMain f_mainform, string USER)
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

        private void frmTransactionFormat_Load(object sender, EventArgs e)
        {
            operationlkp.Properties.ShowHeader = true;
            string sqlcommand = "SELECT RTRIM(OPR_TYPE) AS [Operation Type], RTRIM(OPR_NAME) AS Name, MASK AS Format FROM TransactionReference";
            DataTable dt = clsConnection.reader(sqlcommand);
            operationlkp.Properties.DataSource = dt;
            operationlkp.Properties.PopulateColumns();
            operationlkp.Properties.DisplayMember = "Operation Type";
            operationlkp.Properties.ValueMember = "Operation Type";
            operationlkp.Properties.DropDownRows = dt.Rows.Count;

            format_text.Text = "-";
            lbl1.Text = "4y - " + DateTime.Now.Year.ToString();
            lbl2.Text = "2y - " + DateTime.Now.Year.ToString().Substring(2, 2);
        }

        private void operationlkp_EditValueChanged(object sender, EventArgs e)
        {
            if (operationlkp.EditValue != null)
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                string value = row["Format"].ToString();
                formatbox.Text = value.Trim();
            }
        }

        private void formatbox_TextChanged(object sender, EventArgs e)
        {
            if (formatbox.Text != null | formatbox.Text != "")
            {
                if (operationlkp.ReadOnly == false)
                    amendbtn.Enabled = true;
            }
            mask2text(formatbox.Text.Trim());
        }

        private void amendbtn_Click(object sender, EventArgs e)
        {
            amendbtn.Enabled = false;
            savebtn.Enabled = true;
            formatbox.Properties.ReadOnly = false;
            operationlkp.ReadOnly = true;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            DataRowView row = operationlkp.Properties.GetDataSourceRowByKeyValue(operationlkp.EditValue) as DataRowView;
            string type = row["Operation Type"].ToString();

            if (format_text.Text != "-")
            {
                if (format_text.Text.Length <= 15)
                {
                    string sqlcommand = @"UPDATE TOP (1) TransactionReference SET MASK = N'" + formatbox.Text.Trim() + "', [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (OPR_TYPE = N'" + type + "') ";
                    clsConnection.singleExecute(sqlcommand);
                    f_mainform.statuscaption("Information was updated");
                    savebtn.Enabled = false;
                    formatbox.ReadOnly = true;
                }
                else
                {
                    XtraMessageBox.Show("Maximum length is 15 symbols");
                }
            }
        }

        private void mask2text(string str)
        {
            try
            {
                string result = "";
                string part_id = "";

                for (int i = 0; i < str.Length - 2; i++)
                {
                    result = result + str[i];
                    if (str[i].ToString() == "y")
                    {
                        string y_value = str[i - 1] + "y";
                        result = result.Remove(result.Length - 2);
                        if (y_value == "2y")
                            result = result + DateTime.Now.ToString("yy");

                        if (y_value == "4y")
                        {
                            result = result + DateTime.Now.ToString("yyyy");
                        }
                    }
                }

                string id = str.Substring(str.Length - 2);
                if (id == "1*")
                    part_id = "1";
                else if (id == "2*")
                    part_id = "01";
                else if (id == "3*")
                    part_id = "001";
                else if (id == "4*")
                    part_id = "0001";
                else if (id == "5*")
                    part_id = "00001";
                else
                {
                    format_text.Text = "-";
                    return;
                }
                result = result + part_id;
                format_text.Text = result;
            }
            catch
            {
                format_text.Text = "-";
            }
        }

        private void format_text_TextChanged(object sender, EventArgs e)
        {
            if (format_text.Text != "-")
            {
                if (operationlkp.ReadOnly == true)
                    savebtn.Enabled = true;
            }
            else
            {
                if (operationlkp.ReadOnly == true)
                    savebtn.Enabled = false;
            }
        }

        private void frmTransactionFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmDocumentFormat : DevExpress.XtraEditors.XtraForm
    {
        private string F_CODE;
        private string F_NAME;
        private string F_TYPELKP;
        private string F_PATH;
        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmDocumentFormat(string CODE, string NAME, string TYPELKP, string PATH, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_CODE = CODE;
            F_NAME = NAME;
            F_PATH = PATH;
            F_TYPELKP = TYPELKP;
            F_TYPE = TYPE;
            f_user = USER;
            this.f_mainform = f_mainform;
            this.Text = "Document Format Maintenance";
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

        private void frmDocumentFormat_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            typelkp.Properties.DataSource = clsTransaction.rep_type_list();
            typelkp.Properties.DropDownRows = clsTransaction.rep_type_list().Count;

            if (F_TYPE == "NEW")
            {
                codebox.Text = "";
                namebox.Text = "";
                pathbox.Text = "";
                typelkp.EditValue = "N/A";
                codebox.Enabled = true;
            }
            else
            {
                codebox.Text = F_CODE;
                namebox.Text = F_NAME;
                pathbox.Text = F_PATH;
                typelkp.EditValue = F_TYPELKP;
                codebox.Enabled = false;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CODE = clsConnection.trimSql(codebox.Text);
                string NAME = clsConnection.trimSql(namebox.Text);
                string PATH = clsConnection.trimSql(pathbox.Text);
                string TYPE = typelkp.EditValue.ToString();


                if (CODE.Length == 0)
                {
                    XtraMessageBox.Show("Code field is mandatory");
                    codebox.Focus();
                    return;
                }

                if (NAME.Length == 0)
                {
                    XtraMessageBox.Show("Name field is mandatory");
                    namebox.Focus();
                    return;
                }

                if (PATH.Length == 0)
                {
                    XtraMessageBox.Show("File path field is mandatory");
                    pathbox.Focus();
                    return;
                }

                string sqlcommand = "";

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(DF_CODE) FROM DocumentFormat WHERE DF_CODE = N'" + CODE + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Record already exists");
                        codebox.Focus();
                        return;
                    }
                    else
                    {
                        sqlcommand = @"INSERT INTO DocumentFormat ([DF_CODE],[DF_NAME],[TYPE],[PATH],[UPDATED_USER]) 
                        VALUES (N'" + CODE + "', N'" + NAME + "',N'" + TYPE + "', N'" + PATH + "', N'" + f_user + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("Record was created");
                        this.Close();
                    }
                }
                else
                {
                    sqlcommand = @"UPDATE DocumentFormat SET [DF_NAME] = N'" + NAME + "', [TYPE] = N'" + TYPE + "', [PATH] = N'" + PATH +
                    "', [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (DF_CODE = N'" + CODE + "')";
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

        private void frmDocumentFormat_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}
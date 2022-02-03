using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmSecurityGroups : DevExpress.XtraEditors.XtraForm
    {
        private string F_user_admin = "False";
        private string F_user_admin_system = "False";
        private string F_user_cash = "False";
        private string F_user_cash_appr = "False";
        private string F_user_cash_ref = "False";
        private string F_user_conv = "False";
        private string F_user_conv_appr = "False";
        private string F_user_conv_ref = "False";
        private string F_user_paym = "False";
        private string F_user_paym_appr = "False";
        private string F_user_paym_ref = "False";
        private string F_user_admin_create = "False";
        private string F_user_admin_amend = "False";
        private string F_user_admin_delete = "False";
        private string F_user_cash_create = "False";
        private string F_user_cash_amend = "False";
        private string F_user_cash_delete = "False";
        private string F_user_cash_post = "False";
        private string F_user_cash_ref_create = "False";
        private string F_user_cash_ref_amend = "False";
        private string F_user_cash_ref_delete = "False";
        private string F_user_conv_create = "False";
        private string F_user_conv_amend = "False";
        private string F_user_conv_delete = "False";
        private string F_user_conv_post = "False";
        private string F_user_conv_ref_create = "False";
        private string F_user_conv_ref_amend = "False";
        private string F_user_conv_ref_delete = "False";
        private string F_user_paym_create = "False";
        private string F_user_paym_amend = "False";
        private string F_user_paym_delete = "False";
        private string F_user_paym_post = "False";
        private string F_user_paym_ref_create = "False";
        private string F_user_paym_ref_amend = "False";
        private string F_user_paym_ref_delete = "False";

        private string F_CODE = "";
        private string F_DESC = "";

        private string F_UID;
        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmSecurityGroups(string UID, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            F_UID = UID;
            F_TYPE = TYPE;
            f_user = USER;

            this.f_mainform = f_mainform;
            this.Text = "Group Maintenance";
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

        private void frmSecurityGroups_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            SetSource();
            GetDetails();
        }

        private void SetSource()
        {
            user_admin_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_admin_system_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_appr_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_ref_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_appr_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_ref_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_appr_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_ref_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_admin_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_admin_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_admin_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_post_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_ref_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_ref_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_cash_ref_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_post_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_ref_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_ref_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_conv_ref_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_post_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_ref_create_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_ref_amend_lkp.Properties.DataSource = clsTransaction.status2_list();
            user_paym_ref_delete_lkp.Properties.DataSource = clsTransaction.status2_list();
        }

        private void GetDetails()
        {
            if (F_UID != null)
            {
                string sqlcommand = @"SELECT GROUP_CODE, GROUP_DESCR, ADMIN_ACCESS, ADMIN_SYSTEM, CASH_ACCESS, CASH_APPR, CASH_REF_ACCESS, CONV_ACCESS, CONV_APPR, CONV_REF_ACCESS, PAYM_ACCESS, PAYM_APPR, PAYM_REF_ACCESS, 
                      ADMIN_CREATE, ADMIN_AMEND, ADMIN_DELETE, CASH_CREATE, CASH_AMEND, CASH_DELETE, CASH_POST, CASH_REF_CREATE, CASH_REF_AMEND, CASH_REF_DELETE, CONV_CREATE, 
                      CONV_AMEND, CONV_DELETE, CONV_POST, CONV_REF_CREATE, CONV_REF_AMEND, CONV_REF_DELETE, PAYM_CREATE, PAYM_AMEND, PAYM_DELETE, PAYM_POST, PAYM_REF_CREATE, 
                      PAYM_REF_AMEND, PAYM_REF_DELETE
                      FROM SecurityGroups
                      WHERE (UID = N'" + F_UID + "')";
                DataTable dt = new DataTable();
                dt = clsConnection.reader(sqlcommand);

                F_user_admin = dt.Rows[0]["ADMIN_ACCESS"].ToString();
                F_user_admin_system = dt.Rows[0]["ADMIN_SYSTEM"].ToString();
                F_user_cash = dt.Rows[0]["CASH_ACCESS"].ToString();
                F_user_cash_appr = dt.Rows[0]["CASH_APPR"].ToString();
                F_user_cash_ref = dt.Rows[0]["CASH_REF_ACCESS"].ToString();
                F_user_conv = dt.Rows[0]["CONV_ACCESS"].ToString();
                F_user_conv_appr = dt.Rows[0]["CONV_APPR"].ToString();
                F_user_conv_ref = dt.Rows[0]["CONV_REF_ACCESS"].ToString();
                F_user_paym = dt.Rows[0]["PAYM_ACCESS"].ToString();
                F_user_paym_appr = dt.Rows[0]["PAYM_APPR"].ToString();
                F_user_paym_ref = dt.Rows[0]["PAYM_REF_ACCESS"].ToString();
                F_user_admin_create = dt.Rows[0]["ADMIN_CREATE"].ToString();
                F_user_admin_amend = dt.Rows[0]["ADMIN_AMEND"].ToString();
                F_user_admin_delete = dt.Rows[0]["ADMIN_DELETE"].ToString();
                F_user_cash_create = dt.Rows[0]["CASH_CREATE"].ToString();
                F_user_cash_amend = dt.Rows[0]["CASH_AMEND"].ToString();
                F_user_cash_delete = dt.Rows[0]["CASH_DELETE"].ToString();
                F_user_cash_post = dt.Rows[0]["CASH_POST"].ToString();
                F_user_cash_ref_create = dt.Rows[0]["CASH_REF_CREATE"].ToString();
                F_user_cash_ref_amend = dt.Rows[0]["CASH_REF_AMEND"].ToString();
                F_user_cash_ref_delete = dt.Rows[0]["CASH_REF_DELETE"].ToString();
                F_user_conv_create = dt.Rows[0]["CONV_CREATE"].ToString();
                F_user_conv_amend = dt.Rows[0]["CONV_AMEND"].ToString();
                F_user_conv_delete = dt.Rows[0]["CONV_DELETE"].ToString();
                F_user_conv_post = dt.Rows[0]["CONV_POST"].ToString();
                F_user_conv_ref_create = dt.Rows[0]["CONV_REF_CREATE"].ToString();
                F_user_conv_ref_amend = dt.Rows[0]["CONV_REF_AMEND"].ToString();
                F_user_conv_ref_delete = dt.Rows[0]["CONV_REF_DELETE"].ToString();
                F_user_paym_create = dt.Rows[0]["PAYM_CREATE"].ToString();
                F_user_paym_amend = dt.Rows[0]["PAYM_AMEND"].ToString();
                F_user_paym_delete = dt.Rows[0]["PAYM_DELETE"].ToString();
                F_user_paym_post = dt.Rows[0]["PAYM_POST"].ToString();
                F_user_paym_ref_create = dt.Rows[0]["PAYM_REF_CREATE"].ToString();
                F_user_paym_ref_amend = dt.Rows[0]["PAYM_REF_AMEND"].ToString();
                F_user_paym_ref_delete = dt.Rows[0]["PAYM_REF_DELETE"].ToString();

                F_CODE = dt.Rows[0]["GROUP_CODE"].ToString();
                F_DESC = dt.Rows[0]["GROUP_DESCR"].ToString();
                codebox.Enabled = false;
            }

            user_admin_lkp.EditValue = F_user_admin;
            user_admin_system_lkp.EditValue = F_user_admin_system;
            user_cash_lkp.EditValue = F_user_cash;
            user_cash_appr_lkp.EditValue = F_user_cash_appr;
            user_cash_ref_lkp.EditValue = F_user_cash_ref;
            user_conv_lkp.EditValue = F_user_conv;
            user_conv_appr_lkp.EditValue = F_user_conv_appr;
            user_conv_ref_lkp.EditValue = F_user_conv_ref;
            user_paym_lkp.EditValue = F_user_paym;
            user_paym_appr_lkp.EditValue = F_user_paym_appr;
            user_paym_ref_lkp.EditValue = F_user_paym_ref;
            user_admin_create_lkp.EditValue = F_user_admin_create;
            user_admin_amend_lkp.EditValue = F_user_admin_amend;
            user_admin_delete_lkp.EditValue = F_user_admin_delete;
            user_cash_create_lkp.EditValue = F_user_cash_create;
            user_cash_amend_lkp.EditValue = F_user_cash_amend;
            user_cash_delete_lkp.EditValue = F_user_cash_delete;
            user_cash_post_lkp.EditValue = F_user_cash_post;
            user_cash_ref_create_lkp.EditValue = F_user_cash_ref_create;
            user_cash_ref_amend_lkp.EditValue = F_user_cash_ref_amend;
            user_cash_ref_delete_lkp.EditValue = F_user_cash_ref_delete;
            user_conv_create_lkp.EditValue = F_user_conv_create;
            user_conv_amend_lkp.EditValue = F_user_conv_amend;
            user_conv_delete_lkp.EditValue = F_user_conv_delete;
            user_conv_post_lkp.EditValue = F_user_conv_post;
            user_conv_ref_create_lkp.EditValue = F_user_conv_ref_create;
            user_conv_ref_amend_lkp.EditValue = F_user_conv_ref_amend;
            user_conv_ref_delete_lkp.EditValue = F_user_conv_ref_delete;
            user_paym_create_lkp.EditValue = F_user_paym_create;
            user_paym_amend_lkp.EditValue = F_user_paym_amend;
            user_paym_delete_lkp.EditValue = F_user_paym_delete;
            user_paym_post_lkp.EditValue = F_user_paym_post;
            user_paym_ref_create_lkp.EditValue = F_user_paym_ref_create;
            user_paym_ref_amend_lkp.EditValue = F_user_paym_ref_amend;
            user_paym_ref_delete_lkp.EditValue = F_user_paym_ref_delete;

            codebox.Text = F_CODE;
            descbox.Text = F_DESC;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string CODE = clsConnection.trimSql(codebox.Text);
                string DESC = clsConnection.trimSql(descbox.Text);

                F_user_admin = user_admin_lkp.EditValue.ToString();
                F_user_admin_system = user_admin_system_lkp.EditValue.ToString();
                F_user_cash = user_cash_lkp.EditValue.ToString();
                F_user_cash_appr = user_cash_appr_lkp.EditValue.ToString();
                F_user_cash_ref = user_cash_ref_lkp.EditValue.ToString();
                F_user_conv = user_conv_lkp.EditValue.ToString();
                F_user_conv_appr = user_conv_appr_lkp.EditValue.ToString();
                F_user_conv_ref = user_conv_ref_lkp.EditValue.ToString();
                F_user_paym = user_paym_lkp.EditValue.ToString();
                F_user_paym_appr = user_paym_appr_lkp.EditValue.ToString();
                F_user_paym_ref = user_paym_ref_lkp.EditValue.ToString();
                F_user_admin_create = user_admin_create_lkp.EditValue.ToString();
                F_user_admin_amend = user_admin_amend_lkp.EditValue.ToString();
                F_user_admin_delete = user_admin_delete_lkp.EditValue.ToString();
                F_user_cash_create = user_cash_create_lkp.EditValue.ToString();
                F_user_cash_amend = user_cash_amend_lkp.EditValue.ToString();
                F_user_cash_delete = user_cash_delete_lkp.EditValue.ToString();
                F_user_cash_post = user_cash_post_lkp.EditValue.ToString();
                F_user_cash_ref_create = user_cash_ref_create_lkp.EditValue.ToString();
                F_user_cash_ref_amend = user_cash_ref_amend_lkp.EditValue.ToString();
                F_user_cash_ref_delete = user_cash_ref_delete_lkp.EditValue.ToString();
                F_user_conv_create = user_conv_create_lkp.EditValue.ToString();
                F_user_conv_amend = user_conv_amend_lkp.EditValue.ToString();
                F_user_conv_delete = user_conv_delete_lkp.EditValue.ToString();
                F_user_conv_post = user_conv_post_lkp.EditValue.ToString();
                F_user_conv_ref_create = user_conv_ref_create_lkp.EditValue.ToString();
                F_user_conv_ref_amend = user_conv_ref_amend_lkp.EditValue.ToString();
                F_user_conv_ref_delete = user_conv_ref_delete_lkp.EditValue.ToString();
                F_user_paym_create = user_paym_create_lkp.EditValue.ToString();
                F_user_paym_amend = user_paym_amend_lkp.EditValue.ToString();
                F_user_paym_delete = user_paym_delete_lkp.EditValue.ToString();
                F_user_paym_post = user_paym_post_lkp.EditValue.ToString();
                F_user_paym_ref_create = user_paym_ref_create_lkp.EditValue.ToString();
                F_user_paym_ref_amend = user_paym_ref_amend_lkp.EditValue.ToString();
                F_user_paym_ref_delete = user_paym_ref_delete_lkp.EditValue.ToString();

                if (CODE.Length == 0)
                {
                    XtraMessageBox.Show("Group Code field is mandatory");
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
                string caption = "Group was updated";

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(GROUP_CODE) FROM SecurityGroups WHERE GROUP_CODE = N'" + CODE + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("Group already exists");
                        codebox.Focus();
                        return;
                    }
                    caption = "Group was created";
                }

                sqlcommand = @"EXEC [dbo].[XM_Group] N'" + CODE + "', N'" + DESC + "', " +
F_user_admin + ", " + F_user_admin_system + ", " + F_user_admin_create + ", " + F_user_admin_amend + ", " + F_user_admin_delete + ", " + F_user_cash + ", " +
F_user_cash_appr + ", " + F_user_cash_create + ", " + F_user_cash_amend + ", " + F_user_cash_delete + ", " + F_user_cash_post + ", " +
F_user_cash_ref + ", " + F_user_cash_ref_create + ", " + F_user_cash_ref_amend + ", " + F_user_cash_ref_delete + ", " +
F_user_conv + ", " + F_user_conv_appr + ", " + F_user_conv_create + ", " + F_user_conv_amend + ", " + F_user_conv_delete + ", " +
F_user_conv_post + ", " + F_user_conv_ref + ", " + F_user_conv_ref_create + ", " + F_user_conv_ref_amend + ", " +
F_user_conv_ref_delete + ", " + F_user_paym + ", " + F_user_paym_appr + ", " + F_user_paym_create + ", " +
F_user_paym_amend + ", " + F_user_paym_delete + ", " + F_user_paym_post + ", " + F_user_paym_ref + ", " +
F_user_paym_ref_create + ", " + F_user_paym_ref_amend + ", " + F_user_paym_ref_delete + ", N'" + f_user + "'";

                clsConnection.singleExecute(sqlcommand);

                cancellation = "0";
                f_mainform.statuscaption(caption);
                this.Close();

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;

namespace CASHBOOK
{
    public partial class frmSecurityUsers : DevExpress.XtraEditors.XtraForm
    {
        private string f_USERNAME;
        private string f_FULLNAME;
        private string F_ACCESS;
        private string F_GROUP;
        private string F_TYPE;
        private string f_user;
        private frmMain f_mainform;
        public string cancellation = "1";

        public frmSecurityUsers()
        {
            InitializeComponent();
        }

        public frmSecurityUsers(string USERNAME, string FULLNAME, string ACCESS, string GROUP, string TYPE, string USER, frmMain f_mainform)
        {
            InitializeComponent();
            f_USERNAME = USERNAME;
            f_FULLNAME = FULLNAME;
            F_ACCESS = ACCESS;
            F_GROUP = GROUP;
            F_TYPE = TYPE;
            f_user = USER;

            this.f_mainform = f_mainform;
            this.Text = "User Maintenance";
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

        private void frmSecurityUsers_Load(object sender, EventArgs e)
        {
            lookup();
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            List<string> yesno = new List<string>();
            yesno.Add("True");
            yesno.Add("False");
            accesslkp.Properties.DataSource = yesno;

            if (F_TYPE == "NEW")
            {
                userbox.Enabled = true;
                userbox.Text = "";
                usernamebox.Text = "";
                accesslkp.EditValue = "True";
                grouplkp.EditValue = null;
                resetpassbtn.Enabled = false;
                resetpassbox.Enabled = true;
            }
            else
            {
                userbox.Enabled = false;
                userbox.Text = f_USERNAME;
                usernamebox.Text = f_FULLNAME;
                accesslkp.EditValue = F_ACCESS;
                grouplkp.EditValue = F_GROUP;
                resetpassbtn.Enabled = true;
                resetpassbox.Enabled = false;
            }
        }

        private void lookup()
        {
            string sqlcommand = "SELECT GROUP_CODE AS [Group Code] FROM SecurityGroups ORDER BY GROUP_CODE";
            DataTable dt = clsConnection.reader(sqlcommand);

            grouplkp.Properties.DataSource = dt;
            grouplkp.Properties.DisplayMember = "Group Code";
            grouplkp.Properties.ValueMember = "Group Code";
            grouplkp.Properties.PopulateColumns();
            grouplkp.Properties.DropDownRows = dt.Rows.Count;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (grouplkp.Text == "" | grouplkp.EditValue == null)
                {
                    XtraMessageBox.Show("Group Code field is mandatory");
                    grouplkp.Focus();
                    return;
                }

                var user = userbox.Text;
                var user2 = new string(user.Where(c => Char.IsLetter(c)).ToArray());
                string username = clsConnection.trimSql(user2.ToString());
                string fullname = clsConnection.trimSql(usernamebox.Text);
                string access = accesslkp.EditValue.ToString();
                string passwd = resetpassbox.Text.Trim();
                DataRowView row = grouplkp.Properties.GetDataSourceRowByKeyValue(grouplkp.EditValue) as DataRowView;
                string group = clsConnection.trimSql(row["Group Code"].ToString());

                if (F_TYPE == "OLD" & resetpassbox.Enabled == true)
                {
                    if (passwd.Length == 0)
                    {
                        XtraMessageBox.Show("Password field is mandatory");
                        resetpassbox.Focus();
                        return;
                    }
                }

                if (F_TYPE == "NEW")
                {
                    if (passwd.Length == 0)
                    {
                        XtraMessageBox.Show("Password field is mandatory");
                        resetpassbox.Focus();
                        return;
                    }
                }

                if (username.Length != 3)
                {
                    XtraMessageBox.Show("User name field is mandatory");
                    userbox.Focus();
                    return;
                }

                if (fullname.Length == 0)
                {
                    XtraMessageBox.Show("Full name field is mandatory");
                    usernamebox.Focus();
                    return;
                }

                string sqlcommand = "";

                passwd = Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(Encoding.ASCII.EncodingName, new EncoderReplacementFallback(String.Empty), new DecoderExceptionFallback()), Encoding.UTF8.GetBytes(passwd)));

                string hashedPassword = clsHash.Encrypt(passwd + username);

                if (F_TYPE == "NEW")
                {
                    sqlcommand = "SELECT COUNT(USERNAME) AS CNT FROM SecurityUsers WHERE USERNAME = N'" + username + "'";
                    int count = clsConnection.countReader(sqlcommand);
                    if (count > 0)
                    {
                        XtraMessageBox.Show("User already exists");
                        userbox.Focus();
                        return;
                    }
                    else
                    {
                        sqlcommand = @"INSERT INTO [dbo].[SecurityUsers] ([USERNAME],[FULLNAME],[PASSWORD],[STATUS],[GROUP_CODE],[UPDATED_USER])
                        VALUES (N'" + username + "', N'" + fullname + "', N'" + hashedPassword + "','" + access + "', N'" + group + "', N'" + f_user + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("User was created");
                        this.Close();
                    }
                }
                else
                {
                    if (resetpassbox.Enabled == true)
                    {
                        sqlcommand = @"UPDATE [SecurityUsers] SET [FULLNAME] = N'" + fullname + "', [STATUS] = '" + access + "', [PASSWORD] = N'" + hashedPassword + "', [GROUP_CODE] = N'" + group +
                        "', [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (USERNAME = N'" + username + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("User was updated");
                        this.Close();
                    }
                    else
                    {
                        sqlcommand = @"UPDATE [SecurityUsers] SET [FULLNAME] = N'" + fullname + "', [STATUS] = '" + access + "', [GROUP_CODE] = N'" + group +
                        "', [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE (USERNAME = N'" + username + "')";
                        clsConnection.singleExecute(sqlcommand);
                        cancellation = "0";
                        f_mainform.statuscaption("User was updated");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
        }

        private void resetpassbtn_Click(object sender, EventArgs e)
        {
            if (F_TYPE == "OLD")
                resetpassbox.Enabled = true;
        }

        public static string GeneratePassword(string password)
        {
            return clsHash.GenerateSaltedPassword(password);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSecurityUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void userbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
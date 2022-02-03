using System;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmPassword : DevExpress.XtraEditors.XtraForm
    {
        private frmMain f_mainform;

        private void frmPassword_Load(object sender, EventArgs e)
        {
        }

        public frmPassword(frmMain mainform, string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.f_mainform = mainform;
            userbox.Text = clsConnection.trimSqlReverse(username);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            var username = userbox.Text;
            var oldpassword = oldpassbox.Text.Trim();
            var newpassword = newpassbox.Text.Trim();

            if (username.Length > 0 & oldpassword.Length > 0 & newpassword.Length > 0)
            {
                oldpassword = Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(Encoding.ASCII.EncodingName, new EncoderReplacementFallback(String.Empty), new DecoderExceptionFallback()), Encoding.UTF8.GetBytes(oldpassword)));
                newpassword = Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(Encoding.ASCII.EncodingName, new EncoderReplacementFallback(String.Empty), new DecoderExceptionFallback()), Encoding.UTF8.GetBytes(newpassword)));

                if (clsUserManager.CheckUserLogin(username, oldpassword) == "success")
                {
                    string hashedPassword = clsHash.Encrypt(newpassword + username);
                    string sqlcommand = "UPDATE SecurityUsers SET PASSWORD = N'" + hashedPassword + "' WHERE (USERNAME = N'" + username + "')";
                    clsConnection.singleExecute(sqlcommand);
                    f_mainform.statuscaption("New password was saved");
                    savebtn.Enabled = false;
                    oldpassbox.Enabled = false;
                    newpassbox.Enabled = false;
                }
            }
            else
            {
                XtraMessageBox.Show("All fields are mandatory");
                if (oldpassword.Length == 0)
                    oldpassbox.Focus();
                else
                    newpassbox.Focus();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
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

        private void frmPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}
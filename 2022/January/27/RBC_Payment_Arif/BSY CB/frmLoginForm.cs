using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public string username = "";

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
        }

        public frmLoginForm()
        {
            InitializeComponent();
            loginbox.Text = UserSettings.Default.Username;
            if (loginbox.Text.Trim().Length > 0)
            {
                passbox.Focus();
            }
            else
            {
                loginbox.Focus();
                loginbox.SelectionStart = loginbox.Text.Length;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            if (keyData == Keys.Enter)
            {
                login();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var user = clsConnection.trimSql(loginbox.Text.ToUpper());
            var password = passbox.Text.Trim();
            password = Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(Encoding.ASCII.EncodingName, new EncoderReplacementFallback(String.Empty), new DecoderExceptionFallback()), Encoding.UTF8.GetBytes(password)));
            if (clsUserManager.CheckUserLogin(user, password) == "success")
            {
                username = user;
                clsUserManager.Logon(username);
                UserSettings.Default.Username = username;
                UserSettings.Default.Save();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                loginbox.Focus();
            }
        }
    }
}
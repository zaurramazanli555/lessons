using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    static class clsUserManager
    {
        public static string CheckUserLogin(string username, string password)
        {
            string result = "failure";
            try
            {
                string hashedPassword = clsHash.Encrypt(password + username);
                string sqlcommand = "SELECT COUNT(USERNAME) AS CNT FROM [SecurityUsers] WHERE USERNAME = N'" + username + "' AND PASSWORD = N'" + hashedPassword + "' AND STATUS = 1";
                int count = clsConnection.countReader(sqlcommand);

                if (count == 1)
                    result = "success";
                else
                    XtraMessageBox.Show("The username or password you entered is invalid");
            }
            catch
            {
            }
            return result;
        }

        public static string GetUserInformation(string username, frmMain f_mainform)
        {
            string result = "";
            try
            {
                string sqlcommand = "SELECT RTRIM(FULLNAME) FROM SecurityUsers WHERE (USERNAME = N'" + username + "')";
                string fullname = clsConnection.singleReader(sqlcommand);

                f_mainform.fullnamecaption(fullname);

                sqlcommand = @"SELECT ADMIN_ACCESS, ADMIN_SYSTEM, CASH_ACCESS, CASH_APPR, CASH_REF_ACCESS, CONV_ACCESS, CONV_APPR, CONV_REF_ACCESS, PAYM_ACCESS, PAYM_APPR, PAYM_REF_ACCESS, 
                      ADMIN_CREATE, ADMIN_AMEND, ADMIN_DELETE, CASH_CREATE, CASH_AMEND, CASH_DELETE, CASH_POST, CASH_REF_CREATE, CASH_REF_AMEND, CASH_REF_DELETE, CONV_CREATE, 
                      CONV_AMEND, CONV_DELETE, CONV_POST, CONV_REF_CREATE, CONV_REF_AMEND, CONV_REF_DELETE, PAYM_CREATE, PAYM_AMEND, PAYM_DELETE, PAYM_POST, PAYM_REF_CREATE, 
                      PAYM_REF_AMEND, PAYM_REF_DELETE
                      FROM SecurityGroups
                      WHERE GROUP_CODE = (SELECT GROUP_CODE FROM SecurityUsers WHERE (USERNAME = N'" + username + "'))";
                DataTable dt = new DataTable();
                dt = clsConnection.reader(sqlcommand);

                frmMain main = f_mainform;
                main.user_admin = dt.Rows[0]["ADMIN_ACCESS"].ToString();
                main.user_admin_system = dt.Rows[0]["ADMIN_SYSTEM"].ToString();
                main.user_cash = dt.Rows[0]["CASH_ACCESS"].ToString();
                main.user_cash_appr = dt.Rows[0]["CASH_APPR"].ToString();
                main.user_cash_ref = dt.Rows[0]["CASH_REF_ACCESS"].ToString();
                main.user_conv = dt.Rows[0]["CONV_ACCESS"].ToString();
                main.user_conv_appr = dt.Rows[0]["CONV_APPR"].ToString();
                main.user_conv_ref = dt.Rows[0]["CONV_REF_ACCESS"].ToString();
                main.user_paym = dt.Rows[0]["PAYM_ACCESS"].ToString();
                main.user_paym_appr = dt.Rows[0]["PAYM_APPR"].ToString();
                main.user_paym_ref = dt.Rows[0]["PAYM_REF_ACCESS"].ToString();
                main.user_admin_create = dt.Rows[0]["ADMIN_CREATE"].ToString();
                main.user_admin_amend = dt.Rows[0]["ADMIN_AMEND"].ToString();
                main.user_admin_delete = dt.Rows[0]["ADMIN_DELETE"].ToString();
                main.user_cash_create = dt.Rows[0]["CASH_CREATE"].ToString();
                main.user_cash_amend = dt.Rows[0]["CASH_AMEND"].ToString();
                main.user_cash_delete = dt.Rows[0]["CASH_DELETE"].ToString();
                main.user_cash_post = dt.Rows[0]["CASH_POST"].ToString();
                main.user_cash_ref_create = dt.Rows[0]["CASH_REF_CREATE"].ToString();
                main.user_cash_ref_amend = dt.Rows[0]["CASH_REF_AMEND"].ToString();
                main.user_cash_ref_delete = dt.Rows[0]["CASH_REF_DELETE"].ToString();
                main.user_conv_create = dt.Rows[0]["CONV_CREATE"].ToString();
                main.user_conv_amend = dt.Rows[0]["CONV_AMEND"].ToString();
                main.user_conv_delete = dt.Rows[0]["CONV_DELETE"].ToString();
                main.user_conv_post = dt.Rows[0]["CONV_POST"].ToString();
                main.user_conv_ref_create = dt.Rows[0]["CONV_REF_CREATE"].ToString();
                main.user_conv_ref_amend = dt.Rows[0]["CONV_REF_AMEND"].ToString();
                main.user_conv_ref_delete = dt.Rows[0]["CONV_REF_DELETE"].ToString();
                main.user_paym_create = dt.Rows[0]["PAYM_CREATE"].ToString();
                main.user_paym_amend = dt.Rows[0]["PAYM_AMEND"].ToString();
                main.user_paym_delete = dt.Rows[0]["PAYM_DELETE"].ToString();
                main.user_paym_post = dt.Rows[0]["PAYM_POST"].ToString();
                main.user_paym_ref_create = dt.Rows[0]["PAYM_REF_CREATE"].ToString();
                main.user_paym_ref_amend = dt.Rows[0]["PAYM_REF_AMEND"].ToString();
                main.user_paym_ref_delete = dt.Rows[0]["PAYM_REF_DELETE"].ToString();

                result = "success";
            }
            catch
            {
            }
            return result;
        }

        public static void Logon(string username)
        {
            string sqlcommand = "UPDATE SecurityUsers SET LOGIN_DATE = GETDATE(), LOGIN_STATUS = 1 WHERE USERNAME = N'" + username + "'";
            clsConnection.singleExecuteDelete(sqlcommand);
        }

        public static void Logoff(string username)
        {
            string sqlcommand = "UPDATE SecurityUsers SET LOGIN_STATUS = 0 WHERE USERNAME = N'" + username + "'";
            clsConnection.singleExecuteDelete(sqlcommand);
        }
    }
}
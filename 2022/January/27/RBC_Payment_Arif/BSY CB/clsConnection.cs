using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    static class clsConnection
    {
        public static string connectionString()
        {
            string str = "Server=" + Properties.Settings.Default.SERVER + "; Database=" + Properties.Settings.Default.DATABASE + ";Integrated Security=True;MultipleActiveResultSets=True;";
            return str;
        }

        public static DataTable reader(string sqlcommand)
        {
            SqlConnection conn = new SqlConnection(clsConnection.connectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.CommandTimeout = 300;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            conn.Close();
            dr.Dispose();
            return dt;
        }

        public static string singleReader(string sqlcommand)
        {
            string result = "";
            SqlConnection conn = new SqlConnection(clsConnection.connectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.CommandTimeout = 300;
            if (cmd.ExecuteScalar() != null)
            {
                result = cmd.ExecuteScalar().ToString();
            }
            else
            {
                result = "";
            }
            conn.Close();
            return result;
        }

        public static void singleExecute(string sqlcommand)
        {
            SqlConnection conn = new SqlConnection(clsConnection.connectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.CommandTimeout = 300;
            cmd.ExecuteScalar();
            conn.Close();
        }

        public static void singleExecuteDelete(string sqlcommand)
        {
            SqlConnection conn = new SqlConnection(clsConnection.connectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.CommandTimeout = 300;
            cmd.ExecuteScalar();
            conn.Close();
        }

        public static int countReader(string sqlcommand)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(clsConnection.connectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.CommandTimeout = 300;
            if (cmd.ExecuteScalar() != null)
            {
                result = (int)cmd.ExecuteScalar();
            }
            else
            {
                result = 0;
            }
            conn.Close();
            return result;
        }

        public static string trimSql(string text)
        {
            text = text.Replace("'", "''").Trim();
            return text;
        }

        public static string trimSqlReverse(string text)
        {
            text = text.Replace("''", "'").Trim();
            return text;
        }
    }
}

using System;
using DevExpress.XtraEditors;
using FastReport;

namespace CASHBOOK
{
    class clsPrint
    {
        public static void updateStatus(string table, string column, string doc_no)
        {
            if (table == "PaymentOrder")
            {
                string query = @"SELECT COUNT(PAYM_TXN_REF) FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "' AND CU_CODE <> PRINT_CU_CODE";
                string count = clsConnection.singleReader(query);

                if (count == "1")
                {
                    query = @"SELECT PRINT_CU_CODE FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                    string currency = clsConnection.singleReader(query);

                    query = @"SELECT PRINT_AMOUNT FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                    string amount = clsConnection.singleReader(query);

                    query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = '" + currency + "'";
                    string unit = clsConnection.singleReader(query);

                    query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = '" + currency + "'";
                    string subunit = clsConnection.singleReader(query);

                    string amount_word = clsTransaction.amount2Text(amount, unit, subunit);

                    query = @"UPDATE PaymentOrder SET PRINT_TEXT = N'" + amount_word + "' WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                    clsConnection.singleExecute(query);
                }
            }
            clsConnection.singleExecute("UPDATE " + table + " SET PRINT_STATUS = 1 WHERE " + column + " = N'" + doc_no + "'");
        }

        public static Report printPayment(string doc_no)
        {
            Report report = new Report();

            string sqlcommand = "SELECT POST_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "2")
            {
                XtraMessageBox.Show("Rejected payment orders cannot be printed");
                report = null;
            }
            else
            {
                sqlcommand = "SELECT RTRIM(PATH) FROM DocumentFormat WHERE DF_CODE = (SELECT dbo.GET_DF_CODE (N'" + doc_no + "', 'PAYM'))";
                string path = clsConnection.singleReader(sqlcommand);

                report.Load(path);
                report.Dictionary.Connections[0].ConnectionString = clsConnection.connectionString();
                report.SetParameterValue("PayNo", doc_no);
            }
            return report;
        }



        public static Report printConversion(string doc_no)
        {
            Report report = new Report();

            string sqlcommand = "SELECT POST_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "2")
            {
                XtraMessageBox.Show("Rejected conversions cannot be printed");
                report = null;
            }
            else
            {
                sqlcommand = "SELECT RTRIM(PATH) FROM DocumentFormat WHERE DF_CODE = (SELECT dbo.GET_DF_CODE (N'" + doc_no + "', 'CONV'))";
                string path = clsConnection.singleReader(sqlcommand);

                report.Load(path);
                report.Dictionary.Connections[0].ConnectionString = clsConnection.connectionString();
                report.SetParameterValue("PayNo", doc_no);
            }
            return report;
        }

        public static Report printCash(string doc_no)
        {
            Report report = new Report();

            string sqlcommand = "SELECT POST_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            sqlcommand = @"SELECT CASH_TYPE FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
            string type = clsConnection.singleReader(sqlcommand);

            if (status == "2")
            {
                XtraMessageBox.Show("Rejected cash vouchers cannot be printed");
                report = null;
            }
            else
            {
                if (type == "Receipt")
                {
                    XtraMessageBox.Show("Cash receipt vouchers cannot be printed");
                    report = null;
                }
                else
                {
                    sqlcommand = "SELECT RTRIM(PATH) FROM DocumentFormat WHERE DF_CODE = (SELECT dbo.GET_DF_CODE (N'" + doc_no + "', 'CASH'))";
                    string path = clsConnection.singleReader(sqlcommand);

                    report.Load(path);
                    report.Dictionary.Connections[0].ConnectionString = clsConnection.connectionString();
                    report.SetParameterValue("PayNo", doc_no);
                }
            }
            return report;
        }
    }
}

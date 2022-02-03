using System;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    class clsPost
    {
        public static bool postPayment(string doc_no)
        {
            bool result = false;
            string F_TABLE = "PaymentOrder";
            string F_COLUMN = "PAYM_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed payment orders can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "0")
                {
                    XtraMessageBox.Show("Only draft payment orders can be posted");
                }
                else
                    result = true;

                if (result)
                {
                    if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                    {
                        result = false;
                    }
                }

            }
            return result;
        }

        public static bool repostPayment(string doc_no)
        {
            bool result = false;
            string F_TABLE = "PaymentOrder";
            string F_COLUMN = "PAYM_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed payment orders can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "1")
                {
                    XtraMessageBox.Show("Only posted payment orders can be reposted");
                }
                else
                {
                    sqlcommand = "SELECT TOP 1 PREPAYMENT_STATUS FROM PaymentOrder WHERE PAYM_TXN_REF = N'" + doc_no + "'";
                    status = clsConnection.singleReader(sqlcommand);

                    if (status != "False")
                    {
                        XtraMessageBox.Show("Payment orders based on prepayment can't be reposted");
                    }
                    else
                    {
                        result = true;
                    }
                }
            }

            if (result)
            {
                if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool postConversion(string doc_no)
        {
            bool result = false;
            string F_TABLE = "Conversion";
            string F_COLUMN = "CONV_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed conversions can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "0")
                {
                    XtraMessageBox.Show("Only draft conversions can be posted");
                }
                else
                    result = true;
            }

            if (result)
            {
                if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool repostConversion(string doc_no)
        {
            bool result = false;
            string F_TABLE = "Conversion";
            string F_COLUMN = "CONV_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed conversions can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "1")
                {
                    XtraMessageBox.Show("Only posted conversions can be posted");
                }
                else
                    result = true;
            }

            if (result)
            {
                if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool postCash(string doc_no)
        {
            bool result = false;
            string F_TABLE = "Cash";
            string F_COLUMN = "CASH_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed cash vouchers can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "0")
                {
                    XtraMessageBox.Show("Only draft cash vouchers can be posted");
                }
                else
                    result = true;
            }

            if (result)
            {
                if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool repostCash(string doc_no)
        {
            bool result = false;
            string F_TABLE = "Cash";
            string F_COLUMN = "CASH_TXN_REF";

            string sqlcommand = "SELECT TOP 1 PRINT_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
            string status = clsConnection.singleReader(sqlcommand);

            if (status == "False")
                XtraMessageBox.Show("Only printed cash vouchers can be posted");
            else
            {
                sqlcommand = "SELECT TOP 1 POST_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + doc_no + "'";
                status = clsConnection.singleReader(sqlcommand);

                if (status != "1")
                {
                    XtraMessageBox.Show("Only posted cash vouchers can be posted");
                }
                else
                    result = true;
            }

            if (result)
            {
                if (clsTransaction.checkYear(doc_no, F_TABLE, F_COLUMN) != "0")
                {
                    result = false;
                }
            }

            return result;
        }
    }
}

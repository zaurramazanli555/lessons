using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;

namespace CASHBOOK
{
    class clsTransaction
    {

        public static string GEN_TXN_REF(string opr_type)
        {
            string result = "";
            string part_id = "";

            string sqlcommand = "SELECT TOP 1 MASK FROM TransactionReference WHERE (OPR_TYPE = '" + opr_type + "')";
            string mask = clsConnection.singleReader(sqlcommand);
            sqlcommand = "SELECT TOP 1 HIGH_NUM + 1 AS HIGH_NUM FROM TransactionReference WHERE (OPR_TYPE = '" + opr_type + "')";
            string high_id = clsConnection.singleReader(sqlcommand);

            for (int i = 0; i < mask.Length - 2; i++)
            {
                result = result + mask[i];
                if (mask[i].ToString() == "y")
                {
                    string y_value = mask[i - 1] + "y";
                    result = result.Remove(result.Length - 2);
                    if (y_value == "2y")
                        result = result + DateTime.Now.ToString("yy");

                    if (y_value == "4y")
                    {
                        result = result + DateTime.Now.ToString("yyyy");
                    }
                }
            }

            string mask_id = mask.Substring(mask.Length - 2);
            if (mask_id == "1*")
                part_id = "1";
            else if (mask_id == "2*")
                part_id = "01";
            else if (mask_id == "3*")
                part_id = "001";
            else if (mask_id == "4*")
                part_id = "0001";
            else if (mask_id == "5*")
                part_id = "00001";

            if (part_id.Length < high_id.Length)
            {
                part_id = high_id;
            }

            if (part_id.Length == high_id.Length)
            {
                part_id = high_id;
            }

            if (part_id.Length > high_id.Length)
            {
                int diff = part_id.Length - high_id.Length;
                part_id = part_id.Substring(0, diff) + high_id;
            }

            result = result + part_id;
            return result;
        }

        public static string num2Word(long number)
        {
            if (number == 0)
                return "sıfır";

            if (number < 0)
                return "mənfi" + num2Word(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += num2Word(number / 1000000) + " milyon ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += num2Word(number / 1000) + " min ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += num2Word(number / 100) + " yüz ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "";

                var unitsMap = new[] { "sıfır", "bir", "iki", "üç", "dörd", "beş", "altı", "yeddi", "səkkiz", "doqquz", "on" };
                var tensMap = new[] { "sıfır", "on", "iyirmi", "otuz", "qırx", "əlli", "altmış", "yetmiş", "səksən", "doxsan" };

                if (number < 10)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }

        public static string amount2Text(string amt, string P1, string P2)
        {
            string first_part = "";
            string second_part = "";
            double number;

            if (double.TryParse(amt, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out number))
            {
                number = Math.Round(number, 2);
                long intPart = (long)number;
                first_part = num2Word(intPart) + " " + P1 + " ";
                second_part = "";

                if ((number % 1) != 0)
                {

                    string fractionalPart = amt.Substring(amt.LastIndexOf('.') + 1);
                    if (fractionalPart.Length == 0)
                        fractionalPart = amt.Substring(amt.LastIndexOf(',') + 1);
                    if (fractionalPart.Length == 1)
                        fractionalPart = fractionalPart + "0";
                    if (fractionalPart.Length == 3)
                        fractionalPart = fractionalPart.Substring(0, 2);
                    second_part = fractionalPart + " " + P2;
                }
                else
                    second_part = "00 " + P2;
            }
            return capitalizeFirstLetter(first_part + second_part);
        }

        private static string capitalizeFirstLetter(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            if (s.Length == 1)
                return s.ToUpper();
            return s.Remove(1).ToUpper() + s.Substring(1);
        }

        public static bool checkRate(string doc_no, string currency, string date, string type)
        {
            bool result = false;
            string sqlcommand = "SET DATEFORMAT DMY SELECT dbo.CHECK_RATE ('" + doc_no + "', '" + currency + "', '" + date + "', '" + type + "')";
            string cmd = clsConnection.singleReader(sqlcommand);

            if (cmd == "1")
                result = true;

            return result;
        }

        public static string checkYear(string F_DOC_NO, string F_TABLE, string F_COLUMN)
        {
            string sqlcommand = "SELECT COUNT(DISTINCT POST_STATUS) FROM " + F_TABLE + " WHERE CAST(YEAR(CREATED_DATE)AS INT) < (SELECT dbo.OPEN_FROM_YEAR()) AND " + F_COLUMN + " = N'" + F_DOC_NO + "'";
            return clsConnection.singleReader(sqlcommand);
        }

        public static bool checkDate(string currency, string date, string type)
        {
            bool result = true;
            //if (currency == "AZN")
            if (Int32.Parse(date) > Int32.Parse(DateTime.Now.ToString("yyyyMMdd")))
                result = false;

            return result;
        }

        public static List<String> status_list()
        {
            List<string> list = new List<string>();
            list.Add("Open");
            list.Add("Closed");
            return list;
        }

        public static List<String> status2_list()
        {
            List<string> list = new List<string>();
            list.Add("True");
            list.Add("False");
            return list;
        }

        public static List<String> reason_status_list()
        {
            List<string> list = new List<string>();
            list.Add("Change");
            list.Add("Addition");
            list.Add("New");
            return list;
        }

        public static List<String> conversion_list()
        {
            List<string> list = new List<string>();
            list.Add("Purchase");
            list.Add("Sale");
            return list;
        }

        public static List<String> cash_type_list()
        {
            List<string> list = new List<string>();
            list.Add("Payment");
            list.Add("Receipt");
            return list;
        }

        public static List<String> cash_type2_list()
        {
            List<string> list = new List<string>();
            list.Add("Both");
            list.Add("Payment");
            list.Add("Receipt");
            return list;
        }

        public static List<String> type_list()
        {
            List<string> list = new List<string>();
            list.Add("Abroad");
            list.Add("Local");
            return list;
        }


        public static List<String> rep_type_list()
        {
            List<string> list = new List<string>();
            list.Add("N/A");
            list.Add("Abroad");
            list.Add("Local");
            return list;
        }

        public static string status_bool(string status)
        {
            string result = "0";
            if (status == "Open")
                result = "1";
            return result;
        }
    }
}

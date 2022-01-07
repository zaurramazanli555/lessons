using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default parameter values
            ShowDate(DateTime.Now.Day, DateTime.Now.Month);
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, 2023);
            #endregion

            #region Ref and Out keywords
            int num1 = 0;
            SetRef(ref num1);

            int num2;
            SetOut(out num2);
            #endregion

            #region Flexible (N) sayda parametr alan method
            Addition("orkhan", 10, 20, 30, 40);
            #endregion

            #region Method overloading
            AdditionNums(10, 20);
            AdditionNums(2.4M, 20.1M);
            AdditionNums("10.2", "15.8");
            #endregion

            #region Using method as parameter
            //long version
            decimal s = Substraction(15.5M, 2.5M);
            ShowValue(s);

            //short version
            ShowValue(Substraction(15.5M, 2.5M));
            #endregion

            #region Local functions
            AdditionWithLocalFunc(20, 20);
            #endregion
            
            Console.Clear();

            Console.ReadLine();
        }

        #region Default parameter values
        public static void ShowDate(int day, int month, int year = 2022)
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }
        #endregion

        #region Ref and Out keywords
        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }
        #endregion

        #region Flexible (N) sayda parametr alan method
        static void Addition(string name, params int[] numbers)
        {
            Console.WriteLine(name);
            Console.WriteLine(numbers.Length);
            Console.WriteLine("{0} {1} {2}", "salam", 4, 2);
        }
        #endregion

        #region Method overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("Integer toplam: " + total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine("Decimal toplam: " + total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine("String toplam: " + total);
        }
        #endregion

        #region Using method as parameter
        static void ShowValue(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static decimal Substraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion

        #region Local functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int AdditionLocal(int num1L, int num2L)
            {
                int Subs(int subNum1, int subNum2)
                {
                    return num1L + num2L;
                }

                return Subs(num1L, num2L);
            }
            int result = AdditionLocal(num1, num2);

            Console.WriteLine(result);
        }
        #endregion
    }
}

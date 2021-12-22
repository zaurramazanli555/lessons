using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart3_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            {
                //Boxing
                int n = 522;
                object obj = n; //(implicit boxing)

                Int32 a = 15;
                object obj2 = (object)a; //(explicit boxing)

                //Unboxing
                int i = 12;
                object o = i;

                int r = (int)o; //(explicit unboxing)
            }
            #endregion

            #region Convert, Parse and TryParse
            {
                string textNumber = "100";
                int intNumber = int.Parse(textNumber);
                int intNumber2 = Convert.ToInt32(textNumber);

                decimal output;
                string badDecimalString = "0..5";
                bool badResult = decimal.TryParse(badDecimalString, out output);
                string goodDecimalString = "0.5";
                bool goodResult = decimal.TryParse(goodDecimalString, out output);

                int falseVal = 0;
                int trueVal = 1;
                //bool falseBool = falseVal; //Cannot implicitly convert type int to bool
                //bool trueBool = trueVal; //Cannot implicitly convert type int to bool

                bool trueBool = Convert.ToBoolean(trueVal);

                string trueText = "True";
                string trueText2 = "1";
                bool trueFromText = Convert.ToBoolean(trueText);
                //bool trueFromText3 = bool.Parse(trueText2);

                DateTime now = DateTime.Now;
                object objDate = now;
                var dateFromObject = Convert.ToDateTime(objDate);

                #region Task 1
                byte[] byteArray = { 4, 8, 16, 32, 64, 128 };
                Console.WriteLine(BitConverter.ToString(byteArray));
                string baseString = Convert.ToBase64String(byteArray);
                Console.WriteLine(baseString);
                byte[] byteArrayFromBaseString = Convert.FromBase64String(baseString);
                Console.WriteLine(BitConverter.ToString(byteArrayFromBaseString));
                #endregion

                #region Var
                {
                    var intVar = 5;
                    var boolVar = true;
                    var stringVar = "Hello";
                    var doubleVar = 15.5;

                    object intObject = 5;
                    object boolObject = true;
                    object stringObject = "Hello";
                    object doubleObject = 15.5;

                    //intVar = boolVar; // error
                    intObject = boolObject;
                }
                #endregion

                #region Operators
                //+
                int num1 = 1;
                string text1 = " test ";

                var numNum = num1 + num1;
                var textNum = text1 + num1 + 4;
                var numText = num1 + text1 + 5;
                var textText = text1 + text1;

                string hello = "Hello ";
                int i10 = 10;
                string sumText = hello + i10;

                //-
                int intMinus = -2147483648;
                int intMinus2 = 100;
                int intResult = intMinus - intMinus2;

                string str = "Hi";
                string str1 = "Man";
                //string strRes = str - str1;

                //*
                double d1 = 15.4;
                double d2 = 20.2;

                double dRes = d1 * d2;
                int dResInt = (int)(d1 * d2);

                // /
                int i20 = 20;
                int i2 = 2;
                int iResult = i20 / i2;

                int i0 = 0;
                int iResult2 = i20 / i0;
                #endregion

                #region HomeWork 1
                string[] values = { null, "1526", "911.0", "Orkhan", "   - ", "+000", "(100)", true.ToString(), 000.ToString() };

                foreach (var value in values)
                {
                    int no;
                    Console.WriteLine("Conversion result for value: '" + value + "'" + " is ");
                    //Conversion result for value: '1526' is true/false
                    //Conversion result for value: '+000' is true/false
                }
                #endregion

                #region HomeWork 2
                //Console app yazın.
                //İstifadəçidən Ad, Soyad, Ata Adı, Doğulduğu ölkənin adı və yaşını soruşsun. Sonra bütün bu məlumatları ekranda göstərsin.
                //Yaşını əgər adam hərf olaraq daxil edibsə, ekranda boş görsənsin. Əgər doğru (rəqəm) olaraq daxil edibsə o zaman yaşını göstərsin.
                //Məlumatları aldıqdan sonra məlumatları göstərmədən öncə ekranı təmizləyin.
                #endregion

                #region HomeWork 3
                string textBool = "True";
                //Yuxarıdakı textBool dəyişənini iki ayrı conversion növü ilə convert etməyə çalışın.
                //bool a =
                //bool b =

                //Int tipində bir dəyişəniniz olsun dəyəri 158. Bu rəqəmi byte və float tiplərinə çevirin. Ancaq sadəcə 1 dəfə helper classdan,
                //və ya parsing dən istifadə etmək haqqınız var.

                //İki ayrı byte tipində olan dəyişənləri toplayıb bir başqa byte dəyişəninə verin.
                #endregion

                #region HomeWork (Ruslan)
                {
                    var stringVar = "Hello";
                    object stringObject = "Hello";
                }
                #endregion
            }
            #endregion
        }
    }
}

using ExceptionHandling.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            //Console.WriteLine("Bir eded daxil edin:");
            //int outVal;
            //int.TryParse(Console.ReadLine(), out outVal);

            //Console.WriteLine("Bir eded daxil edin: ");
            //int num1 = int.Parse(Console.ReadLine()); //burada exception cixacaq
            //Console.WriteLine("Input string was not a correct format"); //bu kod setirini ve sonrasini oxumasi qismet olmayacaq cunku int.Parse'da exception atacaq
            //var a = 5;

            //try
            //{
            //    Console.WriteLine("Bir eded daxil edin: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("hello man");
            //var a = 5;
            #endregion

            #region Exception Types

            #region NullReferenceException
            //string[] names = null;
            //var firstElement = names[1].Length;
            //var notReadableCode = 0;

            //try
            //{
            //    var firstElement = names[1].Length;
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("Array bosdur!");
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            //var readableCode = 0;
            #endregion

            #region DivideByZeroException
            //try
            //{
            //    Console.WriteLine("Bolmek istediyiniz ededleri daxil edin: ");
            //    var i1 = Convert.ToInt32(Console.ReadLine());
            //    var i2 = Convert.ToInt32(Console.ReadLine());
            //    decimal divideResult = i1 / i2;
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("NullReferenceException");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Eded 0-a bolune bilmez!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Yuxaridaki catch'lara girmediyi zaman bura girecek.");
            //}
            #endregion

            #region KeyNotFoundException
            //try
            //{
            //    var keyValuePair = new Dictionary<string, string>();
            //    keyValuePair.Add("one", "bir");
            //    keyValuePair.Add("two", "iki");
            //    keyValuePair.Add("three", "uc");

            //    var one = keyValuePair["one"];
            //    var five = keyValuePair["five"];
            //}
            //catch (KeyNotFoundException ex)
            //{
            //    Console.WriteLine("Axtardiginiz key movcud deyil");
            //}

            #endregion

            #region IndexOutOfRangeException
            //try
            //{
            //    int[] intArray = new int[10];
            //    for (int i = 0; i < 20; i++)
            //    {
            //        intArray[i] = i;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Array'in index araligindan kenar bir index'e deyer menimsetmeye calisdiniz!");
            //}
            #endregion

            #endregion

            #region When
            //try
            //{
            //    Console.WriteLine("Zehmet olmasa cut reqem daxil edin: ");
            //    var input = int.Parse(Console.ReadLine());

            //    if (input % 2 != 0)
            //        throw new FormatException("NotDoubleDigit");

            //    if(!(input >= 20 && input <= 30))
            //        throw new FormatException("NotCorrectRange");
            //}
            //catch (FormatException ex) when (ex.Message == "NotDoubleDigit")
            //{
            //    Console.WriteLine("Daxil edilen reqem cut reqem deyil!");
            //    throw;
            //}
            //catch (FormatException ex) when (ex.Message == "NotCorrectRange")
            //{
            //    Console.WriteLine("Daxil edilen reqem cutdur, ancaq 20-30 araliginda deyil!");
            //    throw;
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Xahis olunur reqem daxil edin!");
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw;
            //}
            #endregion

            #region Finally
            //try
            //{
            //    Console.WriteLine("Connected");
            //    Console.WriteLine("Database connection is open...");
            //    Console.WriteLine("Database'den Id deyeri nece olan user'i goturmek isteyirsiniz?");
            //    var userInput = int.Parse(Console.ReadLine());

            //    var connection = "Closing connection here will not work!";
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Daxil edilen deyer reqem deyil!");
            //    Console.WriteLine("Write to log: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Her hansisa bir xeta bas verdi!");
            //    Console.WriteLine("Write to log: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("test");
            //}

            //var connection1 = "Closing connection here will not work!";
            #endregion

            #region Custom Exceptions
            try
            {
                int ageOfUser = int.Parse(Console.ReadLine());

                if (ageOfUser < 18)
                    throw new AgeNotAllowedException();
            }
            catch (AgeNotAllowedException ex)
            {
                Console.WriteLine("Istifadeci 18 yasindan kicik ola bilmez!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Daxil edilen deyer duzgun deyil!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi!");
                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For loop
            {
                //for (int i = 0; i < 100; i++)
                //{
                //    Console.WriteLine("Hello");
                //}
            }
            #endregion

            #region 1 - 100 arasındakı cüt rəqəmləri ekrana çıxarmaq
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i + " - cüt rəqəmdir");
            //}
            #endregion

            #region 1 - 100 arasındakı cüt rəqəmlərin toplamı
            //int total = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        // total = total + i;
            //        total += i;
            //    }
            //}

            //Console.WriteLine("1 ilə 100 arasındakı cüt rəqəmlərin toplamı: {0}", total);
            #endregion

            #region Faktorial
            //int faktorial = 1;

            //Console.WriteLine("Faktorial hesablamaq istədiyiniz dəyəri ekrana yazın: ");
            //string input = Console.ReadLine();
            //int inputNumber = int.Parse(input);

            //for (int i = inputNumber; i > 1; i--)
            //{
            //    faktorial = faktorial * i;
            //    //faktorial *= i;
            //}
            //Console.WriteLine("{0} dəyərinin faktorial nəticəsi : {1}", input, faktorial);
            #endregion

            #region Sonsuz döngü
            //int infinity = 0;
            //for (; ;)
            //{
            //    infinity++;

            //    if (infinity == 50)
            //        break;

            //    if (infinity == 5)
            //        continue;

            //    Console.WriteLine(infinity);
            //}
            #endregion

            #region Vurma cədvəli
            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    int result = i * y;
                    Console.Write("{0}*{1}={2}\t", i, y, result);
                }
                Console.WriteLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}

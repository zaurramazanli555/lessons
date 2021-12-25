using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            {
                //IF section
                /*
                 * &&
                 * ||
                 */
                int a = 15;
                int b = 25;

                if (a > b)
                {
                    Console.WriteLine("A is greather than B");
                }

                if (a < b)
                {
                    Console.WriteLine("B is greather than A");
                }

                bool resAB = a < b;

                if (resAB)
                {
                    Console.WriteLine("B is greather than A");
                }
            
                //Else section
                int x = 400;
                if(x > 500)
                {
                    Console.WriteLine("X is greather than 500");
                }
                else
                {
                    Console.WriteLine("X is not greather than 500");
                }

                //More If Else section
                int y = 60;
                if(y > 65)
                {
                    Console.WriteLine("Yasli");
                }else if(y > 50)
                {
                    Console.WriteLine("Orta yasli");
                }else if(y > 35)
                {
                    Console.WriteLine("Gencliye elvida");
                }else if(y > 20)
                {
                    Console.WriteLine("Genc");
                }else if(y < 20)
                {
                    Console.WriteLine("Cox genc");
                }

                bool test = true;
                if (test)
                {
                    Console.WriteLine("Test is true");
                }

                if ((!test) || test && (test || !test))
                {
                    Console.WriteLine("Test is true");
                }
            }
            #endregion

            #region Switch Case
            {
                string lang = "C#";
                switch (lang)
                {
                    case "ASP.NET":
                        Console.WriteLine("Microsoft");
                        break;
                    case "F#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "C#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "Java":
                        Console.WriteLine("Oracle");
                        break;
                    default:
                        break;
                }

                string lang2 = "German";
                switch (lang2)
                {
                    case "German":
                        Console.WriteLine("+49");
                        break;
                    case "English(USA)":
                        Console.WriteLine("+1");
                        break;
                    case "English(GB)":
                        Console.WriteLine("+44");
                        break;
                    case "Turkish":
                        Console.WriteLine("+90");
                        break;
                    default:
                        break;
                }
            }
            #endregion

            #region Basic Calculator
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Cixma");
                Console.WriteLine("3 - Vurma");
                Console.WriteLine("4 - Bolme");
                Console.WriteLine("Etmek istediyiniz emeliyyati secin: ");
                var choose = Console.ReadLine();
                string a, b;
                double a1 = 0, b1 = 0, sum = 0;

                if(choose == "1" || choose == "2" || choose == "3" || choose == "4")
                {
                    Console.WriteLine("A deyerini daxil edin: ");
                    a = Console.ReadLine();

                    Console.WriteLine("B deyerini daxil edin: ");
                    b = Console.ReadLine();

                    a1 = Convert.ToDouble(a);
                    b1 = Convert.ToDouble(b);
                }
                else
                {
                    Console.WriteLine("Emeliyyat duzgun secilmeyib!");
                }

                if(choose == "1")
                {
                    sum = a1 + b1;
                    Console.WriteLine("Toplama neticesi: " + sum);
                }else if(choose == "2")
                {
                    sum = a1 - b1;
                    Console.WriteLine("Cixma neticesi: " + sum);
                }else if(choose == "3")
                {
                    sum = a1 * b1;
                    Console.WriteLine("Vurma neticesi: " + sum);
                }else if(choose == "4")
                {
                    if(b1 == 0)
                    {
                        Console.WriteLine("Bolen deyer 0 ola bilmez!");
                    }
                    else
                    {
                        sum = a1 / b1;
                        Console.WriteLine("Bolme neticesi: " + sum);
                    }
                }
            }
            
            #endregion
        }
    }
}

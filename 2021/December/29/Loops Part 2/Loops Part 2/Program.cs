using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach
            #region Foreach example
            //string[] names = new[] { "Orkhan", "Ruslan", "Zaur", "Samir", "Jeykhun" };

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Foreach loop ilə bir arrayı doldurub içindəki dataları göstərmək və sum, ortalama kimi məlumatları ekrana çıxartmaq.
            //Console.WriteLine("Yaratmaq istediyiniz array'in olcusunu daxil edin: ");
            //string arrayLength = Console.ReadLine();

            //int arrayLengthParsed = int.Parse(arrayLength);

            //int[] array = new int[arrayLengthParsed];

            //double a = 0, avrg = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("{0}. index deyerini daxil edin: ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Clear();
            //Console.WriteLine("Array dolduruldu!");

            //Console.WriteLine("Arrayin icindeki data: ");

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //    a = a + item;
            //}

            //Console.WriteLine("-------------------------------------");

            //Console.WriteLine("Total: {0}", a);

            //Console.WriteLine("Arrayin element sayi: {0}", array.Length);

            //avrg = a / array.Length;

            //Console.WriteLine("Ortalama deyer: {0}", avrg);
            #endregion

            #region Random number
            //{
            //    Random rand = new Random();
            //    int[] arr = new int[50];

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = rand.Next(1, 10);
            //    }

            //    int count = 0;

            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //        if (item == 4)
            //            count++;
            //    }

            //    Console.WriteLine("Array'in icinde {0} eded 4 reqemi var.", count);
            //}
            #endregion
            #endregion

            #region While
            #region For vs While
            //{
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    int count = 0;
            //    while (count <= 10)
            //    {
            //        Console.WriteLine(count);
            //        count++;
            //    }
            //}
            #endregion

            #region Istifadecinin daxil etdiyi reqemden geriye saymaq
            //Console.WriteLine("Bir reqem daxil edin: ");
            //string c = Console.ReadLine();
            //Console.WriteLine("--------------------------------------");
            //int counter = int.Parse(c);

            //while (counter != -1)
            //{
            //    Console.WriteLine(counter);
            //    counter--;
            //}
            #endregion

            #region Break istifadesi
            //{
            //    Console.WriteLine("Bir reqem daxil edin: ");
            //    int stop = int.Parse(Console.ReadLine());
            //    int counter = 0;

            //    while (true)
            //    {
            //        Console.WriteLine(counter);
            //        if(counter >= stop)
            //        {
            //            break;
            //        }
            //        counter++;
            //    }
            //}
            #endregion

            #region Istifadeci menfi deyer daxil edene qeder, daxil etdiyi butun musbet reqemleri toplamaq ve neticeni gostermek.
            //{
            //    Console.WriteLine("Toplamaq istediyiniz reqemleri daxil edin: ");
            //    Console.WriteLine("Qeyd: Neticeni gormek ucun menfi deyer daxil edin.");

            //    int sum = 0;
            //    while (true)
            //    {
            //        int value = int.Parse(Console.ReadLine());

            //        if (value < 0)
            //            break;
            //        else
            //            sum += value;
            //    }
            //    Console.WriteLine("Toplam: {0}", sum);
            //}
            #endregion
            #endregion

            #region Do While
            #region General
            while (1 == 2)
            {
                Console.WriteLine("While: Bir beraberdir iki");
            }

            do
            {
                Console.WriteLine("Do-While: Bir beraberdir iki");
            } while (1 == 2);

            int s = 10;
            do
            {
                Console.WriteLine("s=" + s);
                s--;
            } while (s >= 0);

            #endregion
            #endregion
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 5 elementli array
             * 
             * [0]
             * [1]
             * [2]
             * [3]
             * [4]
             */

            #region String Array
            {
                string[] studentNameList = new string[5];

                studentNameList[0] = "Samir Samirov";
                studentNameList[1] = "Ceyhun Ceyhunov";
                studentNameList[2] = "Kamal Kamalov";
                studentNameList[3] = "John John";
                studentNameList[4] = "Eric Eric";

                //Console.WriteLine(studentNameList[1]);

                foreach (var item in studentNameList)
                {
                    Console.WriteLine(item);
                }

                for (int i = 0; i < studentNameList.Length; i++)
                {
                    Console.WriteLine(studentNameList[i]);
                }
            }
            #endregion

            #region Integer and Boolean Array
            {
                int[] numbers = new int[10];

                bool[] boolArr = new bool[] {
                    true,
                    false,
                    false,
                    true,
                    true
                };

                numbers[0] = 100;
                numbers[1] = 200;
                numbers[2] = 300;
                numbers[3] = 400;
                numbers[4] = 500;
                numbers[5] = 600;
                numbers[6] = 700;
                numbers[7] = 800;
                numbers[8] = 900;
                numbers[9] = 1000;

                Console.WriteLine(numbers[1]);

                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    int num = numbers[i];
                    Console.WriteLine(num);
                }
            }
            #endregion

            #region HomeWork
            {
                Console.WriteLine("Xahis olunur massivin elementlerinin sayini daxil edin: ");
                int arrayLength = int.Parse(Console.ReadLine());

                Console.WriteLine("Massivin minimum deyerini daxil edin: ");
                int startNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Massivin maksimum daxil edin: ");
                int endNumber = int.Parse(Console.ReadLine());

                int[] numbers = new int[arrayLength];
                bool[] bools = new bool[arrayLength];

                Random rand = new Random();

                for (int i = 0; i < arrayLength; i++)
                {
                    numbers[i] = rand.Next(startNumber, endNumber);
                    bools[i] = Convert.ToBoolean(rand.Next(0, 2));

                    if (numbers[i] % 2 == 0 && bools[i])
                        Console.WriteLine(numbers[i] + " - " + bools[i]);
                }
                
                Console.ReadLine();
            }
            #endregion

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before Generic Collections
            VirtualDatabase virtualDatabase = new VirtualDatabase();
            virtualDatabase.Add(10);
            virtualDatabase.Add(20);
            #endregion

            #region Using simple Generic Collections
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //<T> : T tipi, .NET famework'unun tiplərini və öz yaratdığımız tipləri qəbul edir (T = type)
            List<int> genericList = new List<int>(); //strong type generic list
            genericList.Add(1); //int
            genericList.Add(5); //int
            //genericList.Add("test") //can't pass string

            List<string> names = new List<string>();
            names.Add("Orkhan");
            names.Add("Ruslan");
            names.Add("Zaur");

            List<bool?> booleanGC = new List<bool?>();
            booleanGC.Add(true);
            booleanGC.Add(false);
            booleanGC.Add(null);
            #endregion

            #region Using custom types with Generic Collection and Linq methods
            List<Student> students = new List<Student>();

            students.Add(new Student() {
                Id = 1,
                Name = "Seymur",
                Surname = "Seymurov",
                Age = 25
            });

            Student student = new Student //can use only if constructor of class is parameterless
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Hasanov",
                Age = 23
            };

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                    students[i].Id, students[i].Name, students[i].Surname, students[i].Age);
            }

            foreach (var item in students)
            {
                Console.WriteLine("ID: {0} \r\nName: {1} \r\nSurname: {2} \r\nAge: {3}",
                    item.Id, item.Name, item.Surname, item.Age);
            }
            #endregion

            #region Task in lesson 1
            {
                List<int> numbers = new List<int>();
                numbers.Add(1);

                int[] numbersToAdd = new int[10];
                numbersToAdd[0] = 10;
                numbersToAdd[1] = 20;
                numbersToAdd[2] = 30;
                numbersToAdd[3] = 40;
                numbersToAdd[4] = 50;
                numbersToAdd[5] = 60;
                numbersToAdd[6] = 70;
                numbersToAdd[7] = 80;
                numbersToAdd[8] = 90;
                numbersToAdd[9] = 100;

                //1. yol
                for (int i = 0; i < numbersToAdd.Length; i++)
                {
                    numbers.Add(numbersToAdd[i]);
                }

                //2. yol
                numbers.AddRange(numbersToAdd);

                List<double> doubleList = new List<double>();
                doubleList.Add(10.1);//2
                doubleList.Add(20.1);//2
                doubleList.Add(30.1);//4
                doubleList.Add(40.1);//4

                var capacityOfDoubleList = doubleList.Capacity; //4
                var countOfDoubleList = doubleList.Count;//4

                doubleList.Add(50.1);//8

                var secondCapacityOfDoubleList = doubleList.Capacity;//8
                var secondCountOfDoubleList = doubleList.Count;//5

                doubleList.TrimExcess();

                var a = doubleList.Capacity;
                var b = doubleList.Count;
                Console.Clear();

                doubleList.ForEach(i => Console.WriteLine(i));
            }
            #endregion

            #region Generic Collections general
            {
                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(6);
                numbers.Add(7);
                numbers.Add(8);

                int secondNumber = numbers[1];
                numbers.Insert(1, 25);

                var control1 = numbers.Any();
                var control2 = numbers.Any(i => i > 25);

                numbers.Sort(); //A-Z ve ya 1-N qeder siralama
                //numbers.Reverse(); //Z-A ve ya N-1 qeder siralama

                //bool delResult = numbers.Remove(5);

                //numbers.RemoveAt(2);
                //int removedItemCount = numbers.RemoveAll(i => i > 4);
                //numbers.Clear();

                int minValue = numbers.Min();
                int maxValue = numbers.Max();
                int sumValue = numbers.Sum();
            }
            #endregion
            Console.ReadLine();
        }
    }
}

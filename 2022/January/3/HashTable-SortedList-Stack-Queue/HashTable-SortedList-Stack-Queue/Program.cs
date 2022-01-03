using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable nədir? Necə istifadə olunur?
            //{
            //    Hashtable ht = new Hashtable();

            //    ht.Add("Human", "Insan");
            //    ht.Add("House", "Ev");

            //    ht.Add("You", "Sen");

            //    bool ct = ht.Contains("Human");
            //    bool ct2 = ht.Contains("Ev");

            //    bool ctKey = ht.ContainsKey("Human");
            //    bool ctKey2 = ht.ContainsKey("House");

            //    bool ctVal = ht.ContainsValue("Insan");
            //    bool ctVal2 = ht.ContainsValue("Ev");

            //    ht["House"] = "Villa";
            //    ht.Remove("House");

            //    int count = ht.Count;
            //    ht.Clear();
            //}
            #endregion

            #region Task in lesson (Mini translator)
            //Hashtable translateBase = new Hashtable();

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Elave etmek istediyiniz tercume sozunu yazin");
            //    Console.WriteLine("ENG: ");
            //    string eng = Console.ReadLine();

            //    bool check = translateBase.ContainsKey(eng);

            //    if (check)
            //    {
            //        Console.WriteLine("Elave etmek istediyiniz soz {0} artiq sistemde movcuddur. {1} deyerinin qarsiligidir.", eng, translateBase[eng].ToString());
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} sozunun tercumesini daxil edin: ", eng);
            //        string az = Console.ReadLine();
            //        translateBase.Add(eng, az);
            //        Console.WriteLine("Elave edildi!");
            //    }

            //    Console.WriteLine("Yeni soz elave etmek isteyirsiniz? (H/Y)");
            //} while (Console.ReadLine().ToUpper() != "Y");

            //Console.Clear();

            //foreach (var item in translateBase)
            //{
            //    Console.WriteLine("ENG: {0} - AZ: {1}", ((DictionaryEntry)item).Key, ((DictionaryEntry)item).Value);
            //}

            //Console.WriteLine("-------------------------------------------------");

            //foreach (DictionaryEntry item in translateBase)
            //{
            //    Console.WriteLine("ENG: {0} - AZ: {1}", item.Key, item.Value);
            //}
            //Console.ReadLine();
            #endregion

            #region SortedList
            SortedList sortedListEngAz = new SortedList();
            sortedListEngAz.Add("Hello", "Salam");
            sortedListEngAz.Add("Car", "Avtomobil");
            sortedListEngAz.Add("Home", "Ev");
            sortedListEngAz.Add("One", "Bir");
            sortedListEngAz.Add("All", "Hamisi");
            #endregion

            #region Stack
            Stack stack = new Stack();
            Stack stackWithInitialCapacity = new Stack(10);

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");

            object o1 = stack.Pop(); //Pop sonuncunu gonderir ve ozunden remove edir
            object o2 = stack.Peek(); //Peek ise sonuncu datani mene gonderir ancaq collection icinden remove etmir
            #endregion

            #region Queue
            Queue queue = new Queue();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            object obj = queue.Peek(); //Ilk deyeri qaytarir ve deyeri saxlayir yeni siralamadan silmir
            object obj1 = queue.Dequeue(); //ilk deyeri gonderdikden sonra deyeri silir ve siralamadan cixardir
            #endregion
        }
    }
}

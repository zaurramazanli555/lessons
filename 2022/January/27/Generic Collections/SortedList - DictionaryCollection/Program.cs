using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList___DictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary Generic Collection
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "salam");
            hashtable.Add(2, "salam");
            //hashtable.Add(2, "salam"); //runtime error
            //Key/Value Pair

            //Dictionary<>
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(1, "salam");
            dictionary1.Add(2, "sagol");
            dictionary1.Add(3, "necesen");
            //dictionary1.Add(3, "test"); //runtime error

            Dictionary<bool, char> dictionary2 = new Dictionary<bool, char>();
            dictionary2.Add(true, 'd');
            dictionary2.Add(false, 'r');

            Dictionary<decimal, long> dictionary3 = new Dictionary<decimal, long>();
            dictionary3.Add(20.0M, 15156156156156156);
            dictionary3.Add(30.0M, 156156165156156156);

            bool deleteResult = dictionary1.Remove(2);
            if(deleteResult)
                Console.WriteLine("Deyer dictionary collection'dan silindi!");
            else
                Console.WriteLine("Deyer dictionary collection'da tapilmadi!");

            hashtable[1] = 100;
            dictionary1[10] = "changed value";

            //var t = dictionary1[100]; //KeyNotFound exception

            bool key100Exist = dictionary1.ContainsKey(100);
            if (key100Exist)
            {
                var test = dictionary1[100];
            }
            else
            {
                Console.WriteLine("100-cu index movcud deyil!");
            }

            bool valSalamExist = dictionary1.ContainsValue("salam");
            if(valSalamExist)
                Console.WriteLine("Salam deyeri tapildi!");
            else
                Console.WriteLine("Salam deyeri tapilmadi!");

            foreach (KeyValuePair<int, string> item in dictionary1)
            {
                Console.WriteLine("Acar: {0} |||| Deyer: {1}", item.Key, item.Value);
            }
            #endregion

            #region SortedList & SortedDictionary Generic Collection
            Console.Clear();
            SortedList<int, string> sortedListCollection = new SortedList<int, string>();
            sortedListCollection.Add(10, "salam");
            sortedListCollection.Add(5, "sagol");
            sortedListCollection.Add(9, "necesen");

            SortedDictionary<int, string> sortedDictionaryCollection = new SortedDictionary<int, string>();
            sortedDictionaryCollection.Add(70, "salam");
            sortedDictionaryCollection.Add(35, "sagol");
            sortedDictionaryCollection.Add(4, "necesen");
            #endregion
            Console.ReadLine();
        }
    }
}

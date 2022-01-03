using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adding value to ArrayList and capacity
            object[] arr = new object[10];
            arr[0] = "Name";
            arr[1] = 5;

            ArrayList arrayList = new ArrayList();

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();
            students.Add("Samir");
            students.Add("Javid");
            students.Add("Yashar");
            students.Add("Teymur");
            students.Add("Gunel");
            students.Add("Arif");
            students.Add("Gunel");
            students.Add("Arif");

            capacity = students.Capacity;
            count = students.Count;

            students.Add(5);
            students.Add(true);
            #endregion

            #region ArrayList AddRange
            //A1 sinifi
            ArrayList a1 = new ArrayList();
            a1.Add("Samir");
            a1.Add("Javid");
            a1.Add("Yashar");
            a1.Add("Teymur");
            a1.Add("Gunel");

            //A2 sinifi
            ArrayList a2 = new ArrayList();
            a2.Add("Dadash");
            a2.Add("Emil");
            a2.Add("Ferec");

            //Merge classes
            a1.AddRange(a2);
            #endregion

            #region Getting values
            var javid = a1[1];
            object teymur = a1[3];
            string samir = a1[0].ToString();
            #endregion

            #region Sorting
            //a1.Reverse();
            //a1.Sort();
            #endregion

            #region Delete data
            //a1.Remove("Samir");
            //a1.RemoveAt(2);
            //a1.RemoveRange(2, 2);
            #endregion

            #region Check data
            a1.Add("Malik");

            bool ct = a1.Contains("Malik");

            if (a1.Contains("Malik"))
            {
                int index = a1.IndexOf("Malik");
                a1.RemoveAt(index);
            }
            #endregion

            #region Clearing Array
            a1.Clear();
            //a1.Add("Test");
            a1.TrimToSize();
            #endregion

            Console.ReadLine();
        }
    }
}

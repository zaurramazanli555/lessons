using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1NumberFind
{
    class Program
    {
        //Daxil olunmus reqemi nece cehdde tapdigini yazan proqram
        static void Main(string[] args)
        {
            Additional(10, 20, 30);
            Console.ReadLine();
        }
        static void Additional(params int [] numbers)
        {
           
            Console.WriteLine(numbers.Sum());
        }
    }
}

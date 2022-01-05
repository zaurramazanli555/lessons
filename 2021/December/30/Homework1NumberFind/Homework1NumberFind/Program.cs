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
            Random q = new Random();
            int rand = q.Next(1, 11);
            bool check = false;
            int count = 0;
            do
            {
                count++;
                Console.WriteLine(count+" cehd");
                Console.WriteLine("Zehmet olmasa mueyyen olunmus ededi tapmaq ucun eded daxil edin");
                int eded = int.Parse(Console.ReadLine());
                if (eded==rand) 
                {
                    check = true;
                    Console.WriteLine("Dogrudur");
                }
                else Console.WriteLine("Yanlisdir");

            } while (check==false);
            Console.ReadLine();
        }
    }
}

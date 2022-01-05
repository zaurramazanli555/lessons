using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2UserLogin
{
    class Program
    {
        //username and password check demo/demo 
        static void Main(string[] args)
        {
            bool check = false;
            do
            {
                Console.WriteLine("Zehmet olmasa username daxil edin");
                string username = Console.ReadLine().ToLower();
                Console.WriteLine("Zehmet olmasa parolunuzu daxil edin");
                string password = Console.ReadLine().ToLower();
                if (username=="demo" && password=="demo")
                {
                    Console.WriteLine("User login succesfully");
                    check = true;
                }
                else Console.WriteLine("Daxil elediyiniz username veya parol sehcvdir,zehmet olmasa yenidaen cehd edin");
            } while (check==false);
            Console.ReadLine();
        }
    }
}

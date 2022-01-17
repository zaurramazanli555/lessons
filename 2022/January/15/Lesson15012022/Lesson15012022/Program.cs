using System;

namespace Lesson15012022
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff.domain = "oxu.az";
            Staff staff1 = new Staff() { Name = "Zaur", SurName = "Ramazanli", Gender = 1 };
            Console.WriteLine(staff1.Email);
            Console.ReadLine();
        }
    }
}

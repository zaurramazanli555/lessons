using System;

namespace Inheritance_Part_2
{
    public class Student : Person
    {
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; } //davamiyyet 100 uzerinden deyerlendirilir.

        public Student()
        {
            Console.WriteLine("Constructor of Student class");
            //GoodPerson(); //access to base class methods
        }

        //static Student()
        //{
        //    Console.WriteLine("Test static constructor of Student");
        //}
    }
}

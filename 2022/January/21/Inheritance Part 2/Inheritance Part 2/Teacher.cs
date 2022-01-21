using System;

namespace Inheritance_Part_2
{
    public class Teacher : Person
    {
        public string Branch { get; set; }
        public string Level { get; set; }
        public bool IsProfessor { get; set; }

        public Teacher()
        {
            Console.WriteLine("Constructor of Teacher class");
            //GoodPerson(); //access to base class methods
        }
    }
}

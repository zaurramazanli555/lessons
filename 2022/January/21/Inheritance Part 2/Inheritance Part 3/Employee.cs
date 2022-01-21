using System;

namespace Inheritance_Part_3
{
    public class Employee : Person
    {
        #region Sealed class
        public string Sector { get; set; }
        public int WorkType { get; set; } //Part-time=1 / Full-time=0
        public decimal Salary { get; set; }

        public Employee()
        {
            Console.WriteLine("CTOR: Employee class");
        }
        #endregion
    }
}

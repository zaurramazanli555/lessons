using System;

namespace Inheritance_Part_3
{
    public sealed class Student : Person
    {
        #region Sealed class
        public string Degree { get; set; }
        public string ClassName { get; set; }
        public decimal Attendance { get; set; } //davamiyyet 100 uzerinden deyerlendirilir.

        public Student()
        {
            Console.WriteLine("CTOR: Student class");
            MyProtectedMethod();
            MyPublicMethod();
        }
        #endregion
    }
}

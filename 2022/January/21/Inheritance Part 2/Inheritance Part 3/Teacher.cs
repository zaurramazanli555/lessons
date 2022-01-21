using System;

namespace Inheritance_Part_3
{
    public sealed class Teacher : Person
    {
        #region Sealed class
        public string Branch { get; set; }
        public string Level { get; set; }
        public bool IsProfessor { get; set; }

        public Teacher()
        {
            Console.WriteLine("CTOR: Teacher class");
        }
        #endregion
    }
}

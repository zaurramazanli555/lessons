using System;

namespace OOP___Inheritance_Part_1
{
    public class Teacher : Person
    {
        //public int Id { get; set; } //This property comes from BaseClass
        //public string Name { get; set; } //This property comes from Person
        //public string Surname { get; set; } //This property comes from Person
        //public int Age { get; set; } //This property comes from Person
        public string Branch { get; set; }
        public bool IsProfessor { get; set; }
        //public DateTime RegDate { get; set; } //This property comes from BaseClass
        //public DateTime? EditDate { get; set; } //This property comes from BaseClass
    }
}

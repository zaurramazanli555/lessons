using System;

namespace Inheritance_Part_2
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("Constructor of Person class");
        }

        //static Person()
        //{
        //    Console.WriteLine("Test static constructor of Person");
        //}

        private void GenerateId()
        {
            Random rand = new Random();
            this.Id = rand.Next(1, 999999);
        }

        internal void GoodPerson()
        {
            Console.WriteLine("Good Person!");
        }
    }
}

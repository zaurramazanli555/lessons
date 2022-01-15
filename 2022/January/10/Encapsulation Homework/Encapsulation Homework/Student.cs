using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Homework
{
    public class Student
    {
        private int id { get; set; }
        public int Id {
            get {
                return this.id;
            }
            private set { }
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student()
        {
            this.id = GenerateId();
        }

        private int GenerateId() {
            Random rand = new Random();
            return rand.Next(1, 10000);
        }
    }
}

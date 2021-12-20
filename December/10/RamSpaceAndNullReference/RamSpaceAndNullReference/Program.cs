using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamSpaceAndNullReference
{
    class Program
    {


        static void Main(string[] args)
        {
            //value type in stack area (2).png
            int a;
            a = 5;

            int b;
            b = 15;
            b = 12;

            int c;
            c = 5200;
            c = 2147483647;

            int _int = 2147483647;

            float _float = 21474835000.20f; //2.14748344E+10
            double _double = 21474835000.55; //21474835000.55

            _double = (double)_float;

            _float = (float)_double;
            _double = _float;








            //referance type in heap area (3).png
            Student student;

            student = new Student();
            //student.Class = new ClassRoom();
            var studentClassNumber = student.Class.Number;

            student.Name = "Ceyhun";
            student.Age = 27;
            student.Point = 78.5d;

            Student otherStudent = new Student();
            otherStudent.Name = "Samir";
            otherStudent.Age = 29;
            otherStudent.Point = 75.2d;
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Point { get; set; }
            public ClassRoom Class { get; set; }
        }

        public class ClassRoom
        {
            public int Floor { get; set; }
            public int Number { get; set; }
        }
        #region Naming Convention
        private int _age { get; set; } //private property

        public static void NC()
        {
            var nameSurname = "";
            var person = "";
            var anotherPerson = 1;
            var redCarName = "";
        }

        public static void MyMethod()
        {

        }

        public static void Hesabla() //wrong
        {

        }

        public static void Calculate() //true
        {

        }

        public static void MethodWithParametr(string name, int age)
        {

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mod Operator
            int i1 = 11;
            int i2 = 2;
            int resultOfMod = i1 % i2;

            //++
            int a1 = 25;
            int a2 = a1++;
            //int a3 = ++a1;
            //int a4 = a1 + 1;

            //--
            int b1 = 50;
            int b2 = b1--;
            int b3 = --b1;
            int b4 = b1 - 1;

            #region Match Operators
            //>
            int c1 = 150;
            int c2 = 500;
            bool resultC = c1 > c2;

            //<
            int d1 = 45;
            int d2 = 100;
            bool resultD = d1 < d2;

            // = (assignment)
            int e1 = 10;

            // == (is equal)
            int f1 = 55;
            int f2 = 55;
            bool resultF = f1 == f2;

            // ! (is not)
            int g1 = 55;
            int g2 = 55;
            bool resultG = f1 != f2;
            bool resultZ = !true;

            // >=
            int h1 = 42;
            int h2 = 66;
            bool resultH = h1 >= h2;

            // <=
            int j1 = 42;
            int j2 = 66;
            bool resultJ = j1 <= j2;

            //is operator
            int num1 = 20;
            int num2 = 30;
            object obj = num1;
            Console.WriteLine(obj);
            num1 = (int)obj;
            //num1 = (byte)obj; error
            bool isControl = obj is int;
            bool isControl2 = obj is byte;
            bool isControl3 = obj is DateTime;

            //as
            Student st = new Student()
            {
                Name = "Student",
                Surname = "Student",
                Classroom = 1
            };
            object objectStr = st;
            Teacher tch = new Teacher()
            {
                Name = "Teacher",
                Surname = "Teacher",
                Lesson = 5
            };
            var myA = st as Person;
            var c = ((Student)myA).Classroom;


            //Logical operator && (and)
            //Logical operator || (or)
            string username = "admin";
            string pass = "1234";
            string key = "5A";

            bool result = username == "admin" && pass == "1234" && key == "5A";
            bool result1 = username == "wrong" || pass == "wrong" && key == "5A";
            bool result2 = username == "wrong" && pass == "wrong" || key == "5A";
            #endregion
        }
    }

    public class Person {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class Teacher : Person {
        public int Lesson { get; set; }
    }

    public class Student : Person {
        public int Classroom { get; set; }
    }
}

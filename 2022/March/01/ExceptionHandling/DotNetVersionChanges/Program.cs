using System;
using System.Collections.Generic;

namespace DotNetVersionChanges
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Interpolation
            //string name = "Orkhan";
            //string surname = "Farajov";
            //int age = 27;
            //string job = "Software Developer";

            ////Before string interpolation
            //var personInfo = name + " " + surname + " is " + age.ToString() + " years old and works as a " + job;
            //var personInfo1 = string.Format("{0} {1} is {2} years old and works as a {3}", name, surname, age, job);

            ////After string interpolation
            //var personInfoNewVers = $"{name} {surname} is {age.ToString()} years old and works as a {job}";
            //var personInfoNewVers2 = $"{name} {surname,20}";
            #endregion

            #region Var keyword
            //string fullname = "Orkhan Farajov";
            //Console.WriteLine(fullname);

            //string car = "Mercedes";
            //var model = "S500";

            //Student st1 = new Student()
            //{
            //    Id = 1,
            //    Name = "Orkhan",
            //    Surname = "Farajov",
            //    Age = 27
            //};

            //var st2 = new
            //{
            //    Id = 1,
            //    Name = "Orkhan",
            //    Surname = "Farajov",
            //    Age = 27
            //};
            #endregion

            #region Local functions
            //float Math(int a, int b, MathOperandEnum operand) {
            //    switch (operand)
            //    {
            //        case MathOperandEnum.Addition:
            //            return a + b;
            //        case MathOperandEnum.Substraction:
            //            return a - b;
            //        case MathOperandEnum.Multiplication:
            //            return a * b;
            //        case MathOperandEnum.Division:
            //            if (b > 0)
            //                return a / b;
            //            else
            //                return 0;
            //        case MathOperandEnum.EqualsTo:
            //            if (a == b)
            //                return 1;
            //            else
            //                return 0;
            //        default:
            //            throw new ArgumentOutOfRangeException();
            //    }
            //}

            //var val = Math(5, 10, MathOperandEnum.Addition);
            #endregion

            #region Default values
            ////method(2, 5); result: 10;
            ////method(2); result: 20;

            //float multiplication(float a, float b = 10)
            //{
            //    return a * b;
            //}
            //float multiplication1(float a, float b = 10, int c = 5)
            //{
            //    return a * b;
            //}

            //var x = multiplication(20, 5);
            //var y = multiplication(20);

            //var t = multiplication1(15, c:90);
            #endregion

            #region Tuple use
            Tuple<string, string, int, string, List<Student>, string> tupleVariable =
                new Tuple<string, string, int, string, List<Student>, string>("Orkhan", "Farajov", 27, "Software Developer", new List<Student>(), "7-8");

            var tplName = tupleVariable.Item1;
            var tplSurname = tupleVariable.Item2;
            var tplAge = tupleVariable.Item3;
            var tplJob = tupleVariable.Item4;
            var tplStudents = tupleVariable.Item5;
            var tplExperience = tupleVariable.Item6;

            Tuple<string, string> getPerson()
            {
                return new Tuple<string, string>("Orkhan", "Farajov");
            }

            Tuple<string, string> person = getPerson();
            Console.WriteLine($"Name: {person.Item1} Surname: {person.Item2}");

            (string Name, string Surname) getPerson1()
            {
                return ("Orkhan", "Farajov");
            }

            (string, string) person1 = getPerson1();
            Console.WriteLine($"Name: {person1.Item1} Surname: {person1.Item2}");
            #endregion
        }
    }
}

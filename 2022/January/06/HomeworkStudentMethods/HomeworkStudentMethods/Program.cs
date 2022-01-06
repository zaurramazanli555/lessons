using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Zehmet olmasa adinizi daxil ederdiniz!");
            student.Name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadinizi daxil ederdiniz!");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa 1ci imtahanda yigdiginiz imtahan balinizi daxil ederdiniz!");
            student.Exam1 =decimal.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa 2ci imtahanda yigdiginiz imtahan balinizi daxil ederdiniz!");
            student.Exam2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa 3ci imtahanda yigdiginiz imtahan balinizi daxil ederdiniz!");
            student.Exam3 = decimal.Parse(Console.ReadLine());
           // Console.WriteLine(student.CalcAverage(student));
            Console.WriteLine(student.CalcAverage());

            Console.ReadLine();
        }
    }
}

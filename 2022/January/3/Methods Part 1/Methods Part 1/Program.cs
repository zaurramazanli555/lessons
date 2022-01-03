using System;

namespace Methods_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General methods
            SayHello();

            Student student = new Student();
            student.HelloStudent();
            student.ShowHasan();
            #endregion
        }

        static void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}

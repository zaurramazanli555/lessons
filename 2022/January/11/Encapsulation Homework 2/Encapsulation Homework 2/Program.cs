using System;

namespace Encapsulation_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DocumentNumber = "12345678";
            student.DocumentSerial = "AA";

            if(student.DocumentNumber != null && student.DocumentSerial != null)
            {
                string docNumber = student.DocumentNumber;
                string docSerial = student.DocumentSerial;
                Console.WriteLine("Student Document Info: {0}{1}", student.DocumentSerial, student.DocumentNumber);
            }
            
        }
    }
}

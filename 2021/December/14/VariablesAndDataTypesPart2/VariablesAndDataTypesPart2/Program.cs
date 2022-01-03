using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Basic Form Application
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Xoş gəlmisiniz!");

            //Console.WriteLine("Adınızı daxil edin: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Soyadınızı daxil edin: ");
            //string surname = Console.ReadLine();

            //Console.WriteLine("Doğum yerinizi daxil edin: ");
            //string country = Console.ReadLine();

            //Console.WriteLine("Boyunuzu daxil edin: ");
            //string height = Console.ReadLine();

            //Console.WriteLine("Çəkinizi daxil edin: ");
            //string weight = Console.ReadLine();

            //Console.Clear();

            //Console.WriteLine("Ad: " + name);
            //Console.WriteLine("Soyad: " + surname);
            //Console.WriteLine("Ölkə: " + country);
            //Console.WriteLine("Boy: " + height);
            //Console.WriteLine("Çəki: " + weight);
            //Console.ReadLine();
            #endregion

            #region Type Conversion

            #region Implicit Type Conversion
            byte byteNum1 = 100;
            byte byteMin = byte.MinValue; //0
            byte byteMax = byte.MaxValue; //255

            //byteNum1 = 255;


            int intNum1 = 256;
            int intMin = int.MinValue; //-2147483648
            int intMax = int.MaxValue; // 2147483647

            int num3 = byteNum1;

            int intNum2 = int.MaxValue;
            long longNum1 = intNum2;

            int intNum3 = 123;
            decimal decimalNum1 = intNum3;

            short shortNum1 = 241;
            double doubleNum1 = shortNum1;


            double doubleNum2 = 125.02;
            int intNum4 = (int)doubleNum2;
            //int intNum4 = int.Parse("150");
            //int ss;
            //bool intNum55 = int.TryParse("1", out ss);

            int falseInt = 0;
            int trueInt = 1;
            //bool falseBoolean = falseInt;
            //bool trueBoolean = trueInt;

            string numberString = "15";
            //int stringToInt = numberString;
            //short shortNum2 = numberString;
            //long longNum2 = numberString;

            char c = '1';
            int i = c;

            int i2 = 1111;
            long l = i2;

            long l2 = 156156;
            float f = l2;

            float f2 = 25.6F;
            double d = f2;
            //char
            //int
            //long
            //float
            //double
            #endregion

            #region Explicit Type Conversion
            double d2 = 758.22;
            //float f3 = d2; //Error
            float f3 = (float)d2;

            float f4 = 24.5F;
            long l3 = (long)f4;

            int i3 = 1;
            char c1 = (char)i3;
            //double
            //float
            //long
            //int
            //char
            float f5 = 24.5F;
            int i4 = (int)f5;
            #endregion

            #region Helper Class (Convert class'ı)
            int falseIntValue = 0;
            int trueIntValue = 1;
            //bool falseBool = falseIntValue; //error
            //bool trueBool = trueIntValue; //error
            bool falseBool = Convert.ToBoolean(falseIntValue);
            bool trueBool = Convert.ToBoolean(trueIntValue);

            string numString = "45";

            short stringToShort = Convert.ToInt16(numString);
            int stringToInt = Convert.ToInt32(numString);
            long stringToLong = Convert.ToInt64(numString);
            #endregion

            #region User Defined Type Conversion

            #endregion
            Student student = new Student("Əli", "Hümbətov", 21);
            string strStudent = student;
            string strStudentCast = (Student)student;
            string strStudentToString = student.ToString();

            #endregion
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Student(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public static implicit operator string(Student s) => s.Name + " " + s.Surname + " " + s.Age;

        public override string ToString() => Name + " " + Surname + " " + Age.ToString();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStudentAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty, surname = string.Empty;
            decimal p1 = 0, p2 = 0, p3 = 0, average = 0;

            Console.WriteLine("Zehmet olmasa telebe melumatlarini daxil edin.");

            Console.Write("Ad : ");
            name = Console.ReadLine();

            Console.Write("Soyad : ");
            surname = Console.ReadLine();

            Console.Write("Qiymet 1 : ");
            p1 = decimal.Parse(Console.ReadLine());

            Console.Write("Qiymet 2 : ");
            p2 = decimal.Parse(Console.ReadLine());

            Console.Write("Qiymet 3 : ");
            p3 = decimal.Parse(Console.ReadLine());

            Student student = new Student();
            student.CalcAverage(name, surname, p1, p2, p3);

            Console.ReadLine();
        }
    }

    public class Student
    {
        public void CalcAverage(string name, string surname, decimal p1, decimal p2, decimal p3 = 45)
        {
            Console.WriteLine("Telebe melumatlari: ");
            Console.WriteLine("Ad Soyad : {0} {1}", name, surname);

            //birinci yazi qaydasi
            //decimal average = CalcAverage(p1, p2, p3);
            //RateAverage(average);

            //ikinci yazi qaydasi
            RateAverage(CalcAverage(p1, p2, p3));
        }

        void RateAverage(decimal avrg)
        {
            if (avrg < 45)
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kesildiniz!", avrg);
            else
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kecdiniz!", avrg);
        }

        private decimal CalcAverage(decimal p1, decimal p2, decimal p3)
        {
            return (p1 + p2 + p3) / 3;
        }
    }
}

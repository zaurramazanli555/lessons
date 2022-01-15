using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudentMethods
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Exam1 { get; set; }
        public decimal Exam2 { get; set; }
        public decimal Exam3 { get; set; }
        public  decimal SumExam()
        {
            return Exam1 + Exam2 + Exam3;
        }
        private  bool RateAverage()
        {
            decimal sumexam = SumExam()/3;
            if (sumexam > 45) return true;
            return false;
        }
        public string CalcAverage(Student student)
        {

            if (student.RateAverage()) return "Tebrikler " + student.Name + " " + student.Surname + ".Siz imtahandan ugurla kecdiniz";
            return "Teesufler olsun " + student.Name + " " + student.Surname + ".Siz imtahandan kesildiniz";
        }
        public string CalcAverage()
        {

            if (RateAverage()) return "Tebrikler " + this.Name + " " + this.Surname + ".Siz ortalama " +Math.Round((SumExam()/3),2)+ " bal ile imtahandan ugurla kecdiniz";
            return "Tessuler olsun " + this.Name + " " + this.Surname + ".Siz ortalama " + Math.Round((SumExam() / 3),2) + " bal ile imtahandan kesildiniz";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_1
{
    class Student
    {
        /*
         [access modifier] [return type] [method name] (parameters){
            methodun icinde gorulecek isler
         }

        [access modifiers]

        Public

        Private
        
        -Protected
        -Internal
        -Internal Protected
         */
        public void HelloStudent()
        {
            Console.WriteLine("Salam telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowHasan()
        {
            ShowStudentInfo("Hesen", "Haciyev");
        }
    }
}

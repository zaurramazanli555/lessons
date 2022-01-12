using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Encapsulation
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Orkhan";
            customer.Surname = "Farajov";
            customer.Email = "orkhankhf@gmail.com";

            var email = customer.Email;
            #endregion

            #region Using Encapsulation
            Student student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            var email1 = student.Email;

            Student student2 = new Student();
            student2.Name = "Ruslan";
            student2.Surname = "Valiyev";
            var email2 = student2.Email;
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is static
            Student student;
            //student.Name = "a"; //non-static fields, properties and methods can't use before creating an instance of class
            Student.Test1();

            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();
            #endregion

            #region Where and why to use static
            var fullname = StringHelper.CheckFullname("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullname("OrkhanOrkhanOrkhan", "Farajov");
            #endregion

            #region Example static field
            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan@gmail.com"; //set etmesen islemeyecek
            st.Gender = 1;

            #endregion

            #region Example static method
            Staff st1 = new Staff();
            st1.Name = "Samir";
            st1.Surname = "Samirov";
            st1.Email = "";
            st1.Gender = 1;

            EmailHelper.SendWelcomeMail(st1.Email);
            EmailHelper.SendPasswordChangedMail(st1.Email);
            #endregion

            #region Static class
            //Helper helper = new Helper(); //static bir class'in instance'i yaradila bilmez

            #endregion
            
            #region Constructor of static class
            var someProp = ExampleConstructorClass.SomeProp; //constructor ise dusecek
            var someProp2 = ExampleConstructorClass.SomeProp; //constructor ise DUSMEYECEK
            Console.Clear();

            var domain = Employee.domain;

            Employee emp = new Employee();
            emp.Name = "Javid";
            emp.Surname = "Gafarov";
            emp.Email = "javid";

            Employee emp2 = new Employee();
            emp2.Name = "Orkhan";
            emp2.Surname = "Farajov";
            emp2.Email = "orkhan";
            #endregion
        }
    }
    #region What is static
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Test()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i yaradilmalidir.");
            Test1();
        }

        public static void Test1()
        {
            Console.WriteLine("Bu methodu istifade etmek ucun Student class'inin instance'i YARADILMAMALIDIR!");
        }
    }
    #endregion

    #region Where and why to use static
    public class StringHelper
    {
        public static string CheckFullname(string name, string surname)
        {
            string fullname;
            if((name+surname).Length > 20)
            {
                fullname = name[0] + ". " + surname;
                return fullname;
            }
            return name + " " + surname;
        }
    }
    #endregion

    #region Example static field
    public class Staff
    {
        public static string domain = "oxu.az";
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        private string _email;

        public string Email
        {
            get { return this._email; }
            set {
                this._email = Name.ToLower() + "." + Surname.ToLower() + "@" + Staff.domain;
            }
        }
    }
    #endregion

    #region Example static method
    public class EmailHelper
    {
        public static void SendWelcomeMail(string receiver)
        {
            Console.WriteLine("Bu methodda xos geldiniz emaili gonderilir...");
        }

        public static void SendPasswordChangedMail(string receiver)
        {
            Console.WriteLine("Bu methodda sifre deyisdi emaili gonderilir...");
        }
    }
    #endregion

    #region Static class
    public static class Helper
    {
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    #endregion

    #region Constructor of static class
    public static class ExampleConstructorClass
    {
        public static int SomeProp { get; set; } = 500;
        //public ExampleConstructorClass()
        //{

        //}
        static ExampleConstructorClass()
        {
            Console.WriteLine("Constructor isledi!");
        }
    }

    public class Employee
    {
        public static string domain;
        public string Name { get; set; }
        public string Surname { get; set; }

        private string _email;

        public string Email
        {
            get { return this._email; }
            set
            {
                this._email = value.ToLower() + "@" + Employee.domain;
            }
        }

        public Employee()
        {
            Console.WriteLine("Bu constructor her instance yaradilan zaman isleyecek.");
        }

        static Employee()
        {
            Console.WriteLine("Static constructor isledi!");
            domain = "google.az";
        }
    }
    #endregion
}

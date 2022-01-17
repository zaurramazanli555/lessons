using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Inheritance?
            Car car = new Car();
            var tostring = car.ToString();

            Student student = new Student();
            student.Id = 1; //BaseClass.Id
            student.Name = "Orkhan"; //Person.Name
            student.Surname = "Farajov"; //Person.Surname
            student.Age = 26; //Person.Age
            student.ClassName = "11A"; //Student.ClassName
            student.Degree = "4"; //Student.Degree
            student.RegDate = DateTime.Now; //BaseClass.RegDate
            student.EditDate = null; //BaseClass.EditDate

            Teacher teacher = new Teacher();
            teacher.Id = 2; //BaseClass.Id
            teacher.Name = "Cavid"; //Person.Name
            teacher.Surname = "Cavidov"; //Person.Surname
            teacher.Age = 50; //Person.Age
            teacher.Branch = "Tibb"; //Teacher.Branch
            teacher.IsProfessor = true; //Teacher.IsProfessor
            student.RegDate = DateTime.Now; //BaseClass.RegDate
            student.EditDate = null; //BaseClass.EditDate

            Car audi = new Car();
            audi.Id = 3; //BaseClass.Id
            audi.Model = "Audi A5"; //Car.Model
            audi.Color = "Black"; //Car.Color
            audi.EnginePower = 5000; //Car.EnginePower
            audi.RegDate = DateTime.Now; //BaseClass.RegDate
            audi.EditDate = null; //BaseClass.EditDate
            #endregion

            #region Homework 2
            /*
            HomeWork:
            Aşağıda yazdığım class'ların property'lərini base class'a çıxardıb inherit almaq lazımdır. Nəyi necə edəcəyinizə qarışmıram özünüz qərar verin...
Employee: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, RegUser, RegDate, EditUser, EditDate, Deleted
Teacher: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking, RestDays, Branch, Level, RegUser, RegDate, EditUser, EditDate, Deleted
Student: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, Department, Level, RegUser, RegDate, EditUser, EditDate, Deleted
             */
            #endregion
        }
    }
}

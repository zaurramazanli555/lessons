using System;

namespace Inheritance_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region constructor methods while inheritance
            Person person = new Person();
            //person.GoodPerson();

            Teacher teacher = new Teacher();
            //teacher.GoodPerson(); //access to base class methods

            Student student = new Student();
            //student.GoodPerson(); //access to base class methods
            #endregion

            #region Boxing and Unboxing
            Student student1 = new Student();
            object obj = student1; //boxing

            //Student s1 = obj;
            Student s1 = (Student)obj; //unboxing

            Person p1;
            p1 = s1;
            p1 = new Teacher(); //boxing

            //s1 = new Person(); //error
            s1 = (Student)p1; /* və ya */ s1 = (Student)new Person(); //unboxing

            object objPerson = new Person();
            object objTeacher = new Teacher();
            object objStudent = new Student();
            #endregion
            
            Console.ReadLine();
        }
    }
}

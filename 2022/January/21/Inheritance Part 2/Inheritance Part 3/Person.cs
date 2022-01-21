using System;

namespace Inheritance_Part_3
{
    public class Person
    {
        #region Sealed class
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Person()
        {
            Console.WriteLine("CTOR: Person");
        }
        #endregion

        #region Protected access modifier
        protected void MyProtectedMethod()
        {
            Console.WriteLine("This method is protected");
        }
        private void MyPrivateMethod()
        {
            Console.WriteLine("This method is private");
        }
        public void MyPublicMethod()
        {
            MyPrivateMethod();
            MyProtectedMethod();
        }
        #endregion
    }
}

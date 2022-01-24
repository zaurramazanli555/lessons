using System;

namespace Abstract_Interface
{
    public class Customer : BaseClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer()
        {
            Console.WriteLine("Customer constructor");
        }

        public override void ShowTime()
        {
            Console.WriteLine("Tarix ve saat: " + DateTime.Now.ToLongTimeString());
        }
        public static void ShowTime2()
        {
            Console.WriteLine("ddvc");
        }
    }
}

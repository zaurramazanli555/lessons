using System;

namespace Virtual_Methods
{
    public class Item : BaseClass
    {
        public override void ShowText(string text)
        {
            Console.WriteLine("ShowText method overrided from Item class!");
        }
    }
}

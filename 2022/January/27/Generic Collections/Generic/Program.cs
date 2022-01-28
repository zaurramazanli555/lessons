using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is NOT Generic Class
            Customer customer = new Customer();

            GenericCustomer<string> gCustomer = new GenericCustomer<string>();
            gCustomer.Id = 5;
            gCustomer.Name = "Orkhan";
            gCustomer.Surname = "Farajov";
            gCustomer.DateOfBirth = new DateTime(1995, 12, 24);
            gCustomer.DocumentNo = "123456";
            gCustomer.DocumentSerial = "AZ";
            gCustomer.PlaceOfBirth = "Baku";

            MultipleGenericClass<string, int, DateTime> multiGeneric = new MultipleGenericClass<string, int, DateTime>();
            multiGeneric.Id = 1;
            multiGeneric.Name = "Orkhan";
            multiGeneric.Surname = "Farajov";
            multiGeneric.DateOfBirth = new DateTime(1995, 12, 24);

            string name = multiGeneric.GetName();
            #endregion

            #region What is Generic Class
            //Database      |    App
            //MsSQL         |    C#
            //Table = Class
            //Column = Class Property

            GenericRepository<Customer> customerRepository = new GenericRepository<Customer>();
            List<Customer> customers = customerRepository.Get();

            GenericRepository<Item> itemRepository = new GenericRepository<Item>();
            List<Item> items = itemRepository.Get();

            Customer cust = new Customer();
            Item item = new Item();
            customerRepository.Add(cust);
            itemRepository.Add(item);




            //GenericRepository<int> intRepository = new GenericRepository<int>();
            //ok: GenericRepository<Customer>
            //ok: GenericRepository<Item>
            //error: GenericRepository<int>
            #endregion
        }
    }
}

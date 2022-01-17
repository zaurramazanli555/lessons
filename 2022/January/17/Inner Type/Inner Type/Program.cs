using System;

namespace Inner_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General
            /*
              Database designer online tool: https://app.dbdesigner.net/
              Nümunə:
                    Customer: Id, Name, Surname, DocumentNo, BirthDate, ContactId, CreateDate, EditDate
                    Contact: Id, PhoneNumber, Email, CreateDate, EditDate
                    Address: Id, No, Building, Street, Distinct, CityId, CustomerId, CreateDate, EditDate
                    Cities: Id, Name, CountryId CreateDate, EditDate
                    Countries: Id, Name, CreateDate, EditDate
                    Orders: Id, OrderDetails, CustomerId, CreateDate, EditDate
             */

            Customer customer = new Customer()
            {
                Id = 1,
                Name = "Orkhan",
                Surname = "Farajov",
                DocumentNo = 555555,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            Country country = new Country()
            {
                Id = 100,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now,
                EditDate = null
            };

            City city = new City()
            {
                Id = 50,
                Name = "Baku",
                County = country,
                CreateDate = DateTime.Now,
                EditDate = null
            };

            customer.Contacts[0] = new Contact()
            {
                Id = 200,
                Email = "orkhankhf@gmail.com",
                PhoneNumber = "+994555810872",
                CreateDate = DateTime.Now
            };

            customer.Addresses[0] = new Address()
            {
                Id = 250,
                No = 15,
                Building = "MyBuilding",
                Street = "MyStreet",
                Distinct = "MyDistinct",
                City = city,
                CreateDate = DateTime.Now
            };

            customer.Orders[0] = new Order()
            {
                Id = 620,
                OrderDetails = "Samsung Galaxy S9+, 600usd",
                CreateDate = DateTime.Now
            };

            Order laptopOrder = new Order()
            {
                Id = 621,
                OrderDetails = "Asus Tuf fx705 GM, 3800 usd",
                CreateDate = DateTime.Now
            };

            customer.Orders[1] = laptopOrder;
            #endregion

            #region Homework 1
            /*
               Customer içində bir neçə methodunuz olacaq. Həmin method'lar Customer'in öz məlumatlarını, Order'lərini,
               Contact'larını və Address'lərini ekrana yazdırsın.
               Məsələn Contact üzərindən bir nümunə verim.
               customer.ShowContacts() method'u ekrana bu şəkildə çıxmalıdır:
               Id: 1
               Email: orkhankhf@gmail.com
               PhoneNumber: +994555810872
               CreateDate: 12.12.2014
               EditDate: Data is not edited və ya 12.12.2018

               (əgər 2-ci Contact varsa aşağıdakı da çıxsın)
               Id: 2
               Email: test@gmail.com
               PhoneNumber: +994551231212
               CreateDate: 12.12.2015
               EditDate: Data is not edited və ya 12.12.2018
             */
            #endregion
        }
    }
}

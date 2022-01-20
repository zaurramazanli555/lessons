using System;

namespace Inner_Type
{
    public class Customer
    {
        #region Single Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        #endregion

        #region Inner Type required Fields
        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;
        #endregion

        #region Constructor
        public Customer()
        {
            this.Contacts = new Contact[100];
            this.Addresses = new Address[100];
            this.Orders = new Order[100];
        }
        #endregion

        public void ShowContacts()
        {
            Console.WriteLine("Contacts Information");
            foreach (var item in Contacts)
            {
                if (item != null)
                {
                    Console.WriteLine("Id  " + item.Id);
                    Console.WriteLine("Email  " + item.Email);
                    Console.WriteLine("PhoneNumber  " + item.PhoneNumber);
                    Console.WriteLine("CreateDate  " + item.CreateDate);
                    if (item.EditDate != null)
                        Console.WriteLine("EditDate " + item.EditDate);
                    else
                        Console.WriteLine("Data is not edited");
                    Console.WriteLine();
                }
                else
                    break;          
            }
        }
        public void ShowAdresses()
        {
            Console.WriteLine("Addresses Information");
            foreach (var item in Addresses)
            {
                if (item != null)
                {
                    Console.WriteLine("Id  " + item.Id);
                    Console.WriteLine("No  " + item.No);
                    Console.WriteLine("Building  " + item.Building);
                    Console.WriteLine("Street  " + item.Street);
                    Console.WriteLine("Dstinct  " + item.Distinct);
                    Console.WriteLine("CreateDate  " + item.CreateDate);
                    if (item.EditDate != null)
                        Console.WriteLine("EditDate " + item.EditDate);
                    else
                        Console.WriteLine("Data is not edited");
                    Console.WriteLine("City Information");
                    Console.WriteLine("City Id " + item.City.Id);
                    Console.WriteLine("City Name " + item.City.Name);
                    Console.WriteLine("City CountryName " + item.City.County.Name);
                    if (item.City.EditDate!=null)
                        Console.WriteLine("City EditDate " + item.City.EditDate);
                    else
                        Console.WriteLine("Data is not edited"); 
                   
                    Console.WriteLine();
                }
                else
                    break;
            }
        }
        public void ShowOrders()
        {
            Console.WriteLine("Orders Information");
            foreach (var item in Orders)
            {
                if (item != null)
                {
                    Console.WriteLine("Id  " + item.Id);
                    Console.WriteLine("OrderDetails  " + item.OrderDetails);
                    Console.WriteLine("CreateDate  " + item.CreateDate);
                    if (item.EditDate != null)
                        Console.WriteLine("EditDate " + item.EditDate);
                    else
                        Console.WriteLine("Data is not edited");
                    Console.WriteLine();
                }
                else
                    break;
            }
        }
    }
}

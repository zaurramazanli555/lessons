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
    }
}

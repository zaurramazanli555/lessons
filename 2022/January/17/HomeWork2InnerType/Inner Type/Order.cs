using System;

namespace Inner_Type
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}

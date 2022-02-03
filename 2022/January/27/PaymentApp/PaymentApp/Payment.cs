using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApp
{
    internal class Payment
    {
        public int Id { get; set; }
        public Documentcs Document { get; set; }
        public string Description { get; set; }
        public DateTime PaidDate { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string ReferenceNo { get; set; }
    }
}

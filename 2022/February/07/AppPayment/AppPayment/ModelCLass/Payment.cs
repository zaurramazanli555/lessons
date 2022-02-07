using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPayment.ModelCLass
{
    internal class Payment
    {
        public int Id { get; set; }
        public DocumentPayment DocumentPayment { get; set; }
        public string Description { get; set; }
        public DateTime PaidDate { get; set; }
        public User UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string ReferenceNo { get; set; }
    }
}

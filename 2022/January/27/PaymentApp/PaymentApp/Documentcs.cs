using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApp
{
    internal class Documentcs
    {
        public int Id { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Note { get; set; }
        public string Qeyd { get; set; }
        public User CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string CurrrencyCode { get; set; }
        public decimal Amount { get; set; }
        public Vendor Vendor { get; set; }
        public Company Company { get; set; }
        public Destinition Destinition { get; set; }
        public Department Department { get; set; }
        public DocStatus DocStatus { get; set; }
        public PaymentStatus OdenisStatusId { get; set; }
        public int PaymentTypeId { get; set; }
        ICollection<Payment> payments { get; set; }
        public DateTime EditDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}

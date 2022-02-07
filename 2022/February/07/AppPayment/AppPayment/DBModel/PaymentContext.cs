using AppPayment.ModelCLass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPayment.DBModel
{
    internal class PaymentContext :DbContext
    {
        public PaymentContext(): base("MyPaymentCon")
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Destinition> Destinitions { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DocumentPayment> DocumentPayments { get; set; }
        public DbSet<FileClass> Files { get; set; }
        public DbSet<Stage> Stages { get; set; }

    }
}

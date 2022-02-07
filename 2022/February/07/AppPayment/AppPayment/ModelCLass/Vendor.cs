using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPayment.ModelCLass
{
    internal class Vendor
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Decription { get; set; }
        public string TestName { get; set; }
    }

}

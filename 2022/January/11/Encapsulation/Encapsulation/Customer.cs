using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    #region MyRegion
    internal class Customer
    {
        public int Id;
        public string Name;
        public string Surname;
        private string email;
        public string Email {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
    }
    #endregion
}

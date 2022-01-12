using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Student
    {
        public string _name;
        private string _surname;
        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            private set { }
        }

        public string Surname
        {
            get
            {
                return this._surname;
            }
            set
            {
                this._surname = value;
                if (!string.IsNullOrEmpty(_name))
                    this._email = string.Format("{0}.{1}@company.com", _name.ToLower(), _surname.ToLower());
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                if (!string.IsNullOrEmpty(_surname))
                    this._email = string.Format("{0}.{1}@company.com", _name.ToLower(), _surname.ToLower());
            }
        }
    }
}

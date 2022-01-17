using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15012022
{
    class Staff
    {
        public static string domain { get; set; }
        public string Name {
            get 
            {
                
            } 
            set
            {

            }
        }
        public string SurName { get; set; }
        public int Gender { get; set; }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = Name + "." + SurName + "@" + domain;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2Student
{
    class Student
    {
        /*
        
        Elave olaraq private bir GenerateId methodunuz olsun 
        ve burada random bir deyeri id deyerine vermelisiniz. Eyni zamanda da,
        Main terefde bu class'in instance'ini yaradib auto generate olunmus Id deyeri alina bilsin. 
         */
        private  int _id;
        public int Id
        {
            get
            {
                GenerateId();
                return _id;
            }
        }
        private void GenerateId()
        {
            Random q = new Random();
            _id = q.Next(1, 1000);
        }

    }
}

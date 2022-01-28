using System.Collections.Generic;

namespace Generic
{
    public class GenericRepository <T> where T:class
    {
        public virtual List<T> Get()
        {
            /*
             Db dan data getir
             */
            return null;
        }

        public virtual void Add(T data)
        {
            /*
             Db ya elave et
             */
        }
    }
}

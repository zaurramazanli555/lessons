using System.Collections;

namespace Generic_Collections
{
    public class VirtualDatabase
    {
        private ArrayList _db = new ArrayList();

        public void Add(int data)
        {
            _db.Add(data);
        }
    }
}

using System;

namespace Generic
{
    public class GenericCustomer<T>
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string DocumentSerial { get; set; }
        //public string DocumentNo { get; set; }
        //public string PlaceOfBirth { get; set; }

        public int Id { get; set; }
        public T Name { get; set; }
        public T Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public T DocumentSerial { get; set; }
        public T DocumentNo { get; set; }
        public T PlaceOfBirth { get; set; }
    }
}

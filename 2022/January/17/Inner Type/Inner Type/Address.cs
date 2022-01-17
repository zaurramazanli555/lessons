using System;

namespace Inner_Type
{
    public class Address
    {
        #region Single Fields
        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Distinct { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        #endregion

        #region Inner Type required Fields
        public City City { get; set; }
        #endregion

    }
}

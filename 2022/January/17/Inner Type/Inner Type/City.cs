using System;

namespace Inner_Type
{
    public class City
    {
        #region Single Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        #endregion

        #region Inner Type required Fields
        public Country County;
        #endregion
    }
}

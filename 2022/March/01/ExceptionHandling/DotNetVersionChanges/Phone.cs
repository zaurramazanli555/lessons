namespace DotNetVersionChanges
{
    public class Phone
    {
        #region Auto Properties
        //Not Auto Property:
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value;  } //Bu yontem encapsulation ucun istifade oluna biler
        }

        //Auto Property:
        public string Model { get; set; } //Bu yontem ise encapsulation ucun yararsizdir

        //ve ya (Auto Property):
        public const string SomeProperty = "Some Value";
        public string SomeAutoProperty { get; } = SomeProperty;
        #endregion
    }
}

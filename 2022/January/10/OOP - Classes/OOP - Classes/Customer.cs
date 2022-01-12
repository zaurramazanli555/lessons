namespace OOP___Classes
{
    class Customer
    {
        public string Name;
        public string Surname;
        public int Gender; //1: Kisi - 0: Qadin
        public string DocumentSerial;
        public string DocumentNumber;
        public string Address;

        #region Constructor methods
        public Customer()
        {
            DocumentSerial = "AZ";
            DocumentNumber = "000000";
        }

        //Overload 1
        public Customer(string documentNumber)
        {
            this.DocumentNumber = documentNumber;
        }

        //Overload 2
        public Customer(string documentNumber, string documentSerial)
        {
            this.DocumentNumber = documentNumber;
            this.DocumentSerial = documentSerial;
        }

        //Overload 3
        public Customer(string documentNumber, string documentSerial, string name, string surname)
        {
            this.DocumentNumber = documentNumber;
            this.DocumentSerial = documentSerial;
            this.Name = name;
            this.Surname = surname;
        }

        //Overload 4
        public Customer(int gender, string name, string surname)
        {
            this.Gender = gender;
            this.Name = name;
            this.Surname = surname;
        }

        //Overload 5
        public Customer(string documentNumber, string documentSerial, int gender, string name, string surname, string address)
        {
            this.DocumentNumber = documentNumber;
            this.DocumentSerial = documentSerial;
            this.Gender = gender;
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
        }
        #endregion

        #region Methods in Classes
        internal bool CheckCustomerFromDb()
        {
            return true;
        }

        public bool CheckCustomer()
        {
            bool result = CheckCustomerFromDb();
            return result;
        }
        #endregion
    }
}

namespace Abstract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is Abstract and Interface
            //BaseClass bc = new BaseClass();

            Customer customer = new Customer();
            customer.ShowTime();

            //CRUD = Create Read Update Delete

            VipCustomer vipCustomer = new VipCustomer();
            vipCustomer.ShowTime();

            #region HomeWork
            /*
             Interface və Abstract'ı araşdırın.
             Araşdırma nəticənizi göstərmək üçün özünüzdən bir nümunə hazırlayın.
             */
            #endregion
        }
    }
}

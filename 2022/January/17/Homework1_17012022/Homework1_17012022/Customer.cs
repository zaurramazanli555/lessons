using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_17012022
{
    //Mikroservisler bareside

    /*
     
       Birdə password üçün həm field həm də property olacaq demişdim (encapsulation üçün).
       Property'nin getter'ində field return olacaq, setter'ində isə password'un valid olub olmaması 
       yoxlanılacaq. Bunun üçün bir method yazın hansı ki, şifrəni validate etsin.
       Şifrə minimum 8 simvol, ən az 1 böyük hərf və 1 rəqəm olmalıdır.
       Deyilsə, "Sifre en az 8 simvoldan ibaret, icinde en az 1 boyuk herf ve 1 reqem olmalidir." mesajı çıxsın.
       Customer məlumatlarını elə Main method'unun içində kod tərəfdə yazmaq kifayətdir. 
       Console ekranından userdən soruşmağa ehtiyyac yoxdur.
        */

    class Customer
    {
        static Customer()
        {
            customers = new ArrayList();
            Customer c1 = new Customer() { Name = "Zaur", Email = "Z.Ramazanli@gmail.com", Surname = "Ramazanli", UserName = "zramazanli", Id = 1, Password = "Zaur1234" };
            Customer c2 = new Customer() { Name = "Vusal", Email = "VQuliyev@gmail.com", Surname = "Quliyev", UserName = "vquliyev", Id = 1, Password = "vusaL1234" };
            
            customers.Add(c1);
            customers.Add(c2);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private string _email;
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                string valemail = value.ToString().Trim();
               // if (valemail == "") valemail = null;
                bool dd = string.IsNullOrEmpty(valemail);
                if (CheckUserEmail(valemail) == false && string.IsNullOrEmpty(valemail) ==false)
                    _email = value;
                else if (CheckUserEmail(valemail) == true && string.IsNullOrEmpty(valemail) ==false)
                    throw new Exception("Elave etmek istediyiniz email artiq sistemde movcuddur!");
                else
                    throw new Exception("Zehmet olmasa duzgun email yazin!");

            }
        }
        private string _username;
        public string UserName
        { 
            get
            {
                return _username;
            }
            set
            {
                string valusername = value.ToString().Trim();
                bool dd = string.IsNullOrEmpty(valusername);
                if (CheckUserName(valusername) == false && string.IsNullOrEmpty(valusername) == false)
                    _username = value;
                else if (CheckUserEmail(valusername) == true && string.IsNullOrEmpty(valusername) == false)
                    throw new Exception("Elave etmek istediyiniz username artiq sistemde movcuddur!");
                else
                    throw new Exception("Zehmet olmasa duzgun username yazin!"); ;
            }
        }
        private string _password;
        public string Password 
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPasswordNumber(value) && CheckPasswordUpperLetter(value) && value.Length >= 8)
                    _password = value;
                else
                    throw new Exception("Xahis olunur duzgun parol daxil edesiniz!");

            }
        }//field
        private bool CheckPasswordNumber(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i])) return true; 
            }
            return false;
        }
        private bool CheckPasswordUpperLetter(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i])) return true;
            }
            return false;
        }
        private static ArrayList customers;
        private static bool CheckUserName(string username)
        {
            foreach (Customer item in Customer.customers)
            {
                if (((Customer)item).UserName == username)
                    return true;

            }

            return false;
        }
        private static bool CheckUserEmail(string email)
        {
            foreach (Customer item in Customer.customers)
            {
                if (((Customer)item).Email == email)
                    return true;

            }
            return false;
        }
        public static void AddCustomer(Customer customer)
        {

            if (customer == null)
                throw new Exception("Xahis olunur Customer classinin obyektini yaradib insert edesiniz!!!");
            customers.Add(customer);
            Console.WriteLine("Yeni musteri elave edildi");
           // bool checkemail = CheckUserEmail(customer.Email); Ehtiyac yoxdur cunki propertyde yoxlayir
        }
        
    }
}

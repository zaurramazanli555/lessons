using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region General
            /*
             -Müştəri
             -Satış təmsilçisi
             -Satılacaq məhsul (Avtomobil, motosiklet və s.)
             -Təklif
             -Sifariş
             -Qəbz

             -Müştəri
                -Ad
                -Soyad
                -Cinsiyyət
                -Pasportun seriyası və nömrəsi
                -Ünvanı və s.
             -Məhsul
                -Marka
                -Model
                -İl
                -Km
                -Yanacaq növü
                -Ban növü
             -Təklif
                -Təklif nömrəsi
                -Müştəri
                -Satıcı
                -Məhsul
                -Qiymət
             -Sifariş
                -Sifariş nömrəsi
                -Təklif
                -Qiymət
             -Qəbz
                -Vergi nömrəsi
                -Qəbz nömrəsi
                -Seriya
                -Təklif
                -Müştəri
                və s.
             */

            {
                Console.WriteLine("I am software developer");
                string name = "Orkhan";
            }
            #endregion

            #region Create a class
            /*
             1. Project right click -> Add -> New Item
             2. Project right click -> Add -> Class
             3. Program class'ından sonra əlavə bir class yaratmaq.
             */
            #endregion

            #region Use Classes
            {
                Customer customer = new Customer();
                customer.Name = "Babek";
                customer.Surname = "Babekov";
                customer.Gender = 1;
                customer.DocumentSerial = "AZ";
                customer.DocumentNumber = "123456";
                customer.Address = "Baki seh., Nerimanov r-nu., Rasim Muxtarov kuc., NO:5";

                Customer otherCustomer = new Customer();
                otherCustomer = customer;

                customer = null;
                otherCustomer = null;

                //string customerName = customer.Name;
                //string otherCustomerName = otherCustomer.Name;
            }
            #endregion

            #region Constructor methods
            {
                Customer customer = new Customer();

                Customer defaultConstructorMethod = new Customer();

                Customer overload1 = new Customer("123456");
                Customer overload2 = new Customer("123456", "AA");
                Customer overload3 = new Customer("123456", "AA", "Hasan", "Babayev");
                Customer overload4 = new Customer(1, "Hasan", "Babayev");
                Customer overload5 = new Customer("123456", "AA", 1, "Hasan", "Babayev", "Bakı şəh., Nərimanov r-nu., Rasim Muxtarov küç., NO 5");
            }
            #endregion

            #region Methods in Classes
            Customer customer10 = new Customer();
            customer10.CheckCustomer();
            
            customer10.CheckCustomerFromDb();
            #endregion

            /*
             Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor methodları olacaq.

            Class detail:
             Marka
             Model
             İstehsal ili
             Km
             Yanacaq növü
             Sürətlər qutusu
             Alış qiyməti
             Satış qiyməti
             Max endirim məbləği
             Qiymət

            Constructor details:
             1. marka, model
             2. marka, model, istehsal ili
             3. marka, model, istehsal ili, km
             4. bütün property'lər

            əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
            satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər olmalıdır.
            Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
            Məsələn:
            Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata satmağa
            çalışsam xəta mesajı yazsın ekrana (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
             */

            Vehicle vehicle = new Vehicle("Mercedes-Benz", "ML350", 2010, 20000);
            vehicle.BuyPrice = 15000;
            vehicle.SellPrice = 20000;
            vehicle.MaxDiscount = 1500;
            vehicle.SetPrice(20000);
            vehicle.ShowVehicleInfo();
        }
    }
}

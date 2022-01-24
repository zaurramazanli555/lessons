using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Name = "Orkhan";
            //customer.Surname = "Farajov";
            //var toString = customer.ToString();
            //Console.WriteLine(toString);

            Item item = new Item();
            item.WriteText("WriteText called via Item");

            BaseClass bc = new BaseClass();
            bc.WriteText("WriteText called via BaseClass");

            item.ShowText("Hi!");
            bc.ShowText("Hi Hitler!");
            Console.ReadLine();

            #region HomeWork
            /*
             Ev tapşırığı olaraq Virtual method və virtual method'ları override etməyi verirəm.
             Task'ı bu dəfə mən verməyəcəyəm özünüz mənə bir nümunə generate edin mövzu ilə bağlı.
             Mən istəyirəm ki, virtual və override'ı harada istifadə edə bilərəm və harda necə bir
             task'da mənə lazım ola bilər bunu siz düşünəsiniz. Təbii ki, bunu araşdırmanızın
             nəticəsində edin. Əvvəlcə araşdırın sonra harada və necə istifadə edilə biləcəyinə
             dair bir nümunə hazırlayın. Bu bir kiçik kitabxana app'ı ola bilər, calculator və ya
             hər hansısa bir kiçik task ola bilər.
             */
            #endregion
        }
    }
}

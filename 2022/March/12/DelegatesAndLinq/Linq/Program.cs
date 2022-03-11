using Linq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Customer classı yaradın.
             Id, Name, Surname, Age.
             DataSource adinda bir class'da bir List olsun ve o liste FakeData ile 100000 fake data elave edin.
             Sonra dataSource'un icinde iki method yaradin ve birinci method parametr olaraq herf qebul edecek ve o herfle adi baslayan adamlari list olaraq qaytaracaq.
             Ikinci method ise bir yas araligi alacaq ve o yas araliginda olan adamlari qaytaracaq. Meselen 18-25 yas arasi.
             */

            DataSource ds = new DataSource();

            //Without Linq
            var age18_25 = ds.GetCustomersByAge(18, 25);
            var namesStartsWithB = ds.GetCustomersByFirstLetterOfName('B');

            //With Linq
            var ageFilter = ds.GetCustomersByAgeLinq(18, 25);
            var nameFilter = ds.GetCustomersByFirstLetterOfNameLinq('B');

            //----System.Linq----
            // 1. ds.Customers.Where()
            // 2. ds.Customers.FirstOrDefault()
            // 3. ds.Customers.Max()

            //----System.Collections.Generic----
            // 1. ds.Customers.Add()
            // 2. ds.Customers.AddRange()
            // 3. ds.Customers.GetEnumerator()
            //ds.Customers.Where()

            var maleCustomers = ds.Customers.Where(m => m.Gender == GenderEnum.Male);

            //(Musteri sayisini almaq)
            var countOfCustomers = ds.Customers.Count; //System.Collections.Generic

            //(Olkesi Almaniya olmayanlari goturmek)
            var notFromGermany = ds.Customers.Where(m => m.Country != "Germany");

            //(Olkesi Turkiye olanlari goturmek)
            var fromTurkey = ds.Customers.Where(m => m.Country == "Turkey");

            //(Olkesi Almaniya olmayan ve yasi 20-den boyuk olanlari goturmek)
            var notFromGermanyAndOver20 = ds.Customers.Where(m => m.Country != "Germany" && m.Age > 20);

            //(Adi t ile baslayib, soyadi n ile bitenleri goturmek)
            var startsT_endsN = ds.Customers.Where(m => 
                m.Name.ToLower().StartsWith("t") &&
                m.Surname.ToLower().EndsWith("n"));

            var notFromGermanyArr = notFromGermany.ToArray();
            var fromTurkeyList = fromTurkey.ToList();

            //IEnumerable, Lazy Loading'i desteklemir
            //IQueryable, Lazy Loading'i destekleyir

            //(IEnumerable System.Collections.Generic'den gelir)
            IEnumerable<Customer> badQuery = ds.Customers.Where(p => p.Name.StartsWith("N"));
            badQuery = badQuery.Take<Customer>(1);

            //(IQueryable ise System.Linq'dan gelir)
            IQueryable<Customer> goodQuery = ds.Customers.AsQueryable().Where(p => p.Name.StartsWith("N"));
            goodQuery = goodQuery.Take<Customer>(1);

            var methodSyntax = ds.Customers.Where(m =>
                m.Name.StartsWith("A") &&
                m.Age >= 45 &&
                m.Age <= 55)
                .Count();

            var querySyntax = (from a in ds.Customers where
                               a.Name.StartsWith("A") &&
                               a.Age >= 45 &&
                               a.Age <= 55
                               select a)
                               .Count();

            #region Practise Linq
            //1. Olkesinin adinda b herfi olan ve seherinin adi c ile baslayan
            IEnumerable<Customer> query1 = ds.Customers.Where(m =>
                m.Country.ToLower().Contains("b") &&
                m.City.ToLower().StartsWith("c"));

            //2. Seherin adi a ile baslayib e ile biten
            IEnumerable<Customer> query2 = ds.Customers.Where(m =>
                m.City.StartsWith("a") &&
                m.City.EndsWith("e"));

            //3. Adi Jack olan customer'ler
            List<Customer> customers = ds.Customers.Where(m => m.Name == "Jack")
                .ToList();

            //4. Telefon nomresi 0555555555 olan bir nefer
            Customer customer = ds.Customers.FirstOrDefault(m => m.Phone == "0555555555");

            //5. Dogum tarixi 1990-ci il olanlar
            var query3 = ds.Customers.Where(m => m.DateOfBirth.Year == 1990).ToList();

            //6. Doguldugu ay dekabr olanlardan 2 neferi al
            var query4 = ds.Customers.Where(m => m.DateOfBirth.Month == 12).Take(2).ToList();
            #endregion

            #region Func Delegate
            //1. Lambda expression
            var q1 = ds.Customers.Where(m => m.Email.StartsWith("A"));

            //2. Standart Delegate with method
            bool StartsWithA(Customer m)
            {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            }

            Func<Customer, bool> startsWithA_delegate = new Func<Customer, bool>(StartsWithA);
            var q2 = ds.Customers.Where(startsWithA_delegate);

            //3. Pass method directly to where with func<>
            var q3 = ds.Customers.Where(new Func<Customer, bool>(StartsWithA));

            //4. Write without Func<>
            var q4 = ds.Customers.Where(delegate (Customer m) {
                if (m.Email[0] == 'A')
                    return true;
                else
                    return false;
            });

            //5. Write without delegate
            var q5 = ds.Customers.Where((Customer m) => { return m.Email[0] == 'A' ? true : false; });

            //6. Write without object type
            var q6 = ds.Customers.Where((m) => { return m.Email[0] == 'A' ? true : false; });

            //7. Again lambda ex.
            var q7 = ds.Customers.Where(m => m.Email.StartsWith("A"));
            #endregion

            #region Predicate Delegate
            //1. Normal FindAll method
            var p1 = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            //2. Long version
            bool predicateDelegateMethod(Customer m)
            {
                if (m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12))
                    return true;
                else
                    return false;
            }

            Predicate<Customer> predicate = new Predicate<Customer>(predicateDelegateMethod);

            var delegate1 = ds.Customers.FindAll(predicate);

            //3. Short versions
            var delegate2 = ds.Customers.FindAll(new Predicate<Customer>(predicateDelegateMethod));

            var delegate3 = ds.Customers.FindAll(delegate (Customer m) { return m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12); });

            var delegate4 = ds.Customers.FindAll((Customer m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            var delegate5 = ds.Customers.FindAll((m) => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));

            //4. Shortest version
            var delegateLambda = ds.Customers.FindAll(m => m.Country == "Azerbaijan" && m.DateOfBirth > new DateTime(1900, 12, 12));
            #endregion

            #region Action Delegate
            //1. Normal Foreach
            foreach (var item in ds.Customers)
            {
                Console.WriteLine($"{item.Name} {item.Surname} is {item.Age} years old.");
            }

            //2. With ForEach method which is in Collections Generic
            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            //3. Long Action delegate
            void ShowCustomerInfo(Customer m)
            {
                Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old.");
            }

            Action<Customer> action = new Action<Customer>(ShowCustomerInfo);
            ds.Customers.ForEach(action);

            //4. Short versions
            ds.Customers.ForEach(new Action<Customer>(ShowCustomerInfo));

            ds.Customers.ForEach(delegate (Customer m) { Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."); });
            
            ds.Customers.ForEach((Customer m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            ds.Customers.ForEach((m) => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));

            ds.Customers.ForEach(m => Console.WriteLine($"{m.Name} {m.Surname} is {m.Age} years old."));
            #endregion
        }
    }
}

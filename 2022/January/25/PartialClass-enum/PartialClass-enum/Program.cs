using PartialClass_enum.Enum;
using System;

namespace PartialClass_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            Book book = new Book();
            book.Id = 1;
            book.CreateDate = DateTime.Now;
            book.CreateUser = 100;
            book.Code = 123456789;
            book.Genre = "Some Genre";
            book.Publisher = "Some Publisher";
            book.Cover = "Karton";
            book.Author = "Some Author";
            book.Page = 356;
            book.Language = "ENG";
            book.Add(book);
            book.Update(book);
            book.Delete(1);
            book.Method1(); //Comes from Car.cs
            book.Method11(); //Comes from Car.cs
            book.Method21(); //Comes from Car.cs


            Car car = new Car();
            car.Id = 5;
            car.CreateDate = DateTime.Now;
            car.CreateUser = 100;
            car.Brand = "Mercedes";
            car.Model = "GL500";
            car.Year = 2021;
            car.SeatCount = 6;
            car.SeatMaterial = "Deri";
            car.Door = 5;
            car.Engine = 5000;
            car.FuelType = "Benzin";
            car.Add(car);
            car.Update(car);
            car.Delete(5);
            car.MyMethod1(); //Comes from CarProcedureMethods.cs (Partial Car class)
            car.MyMethod11(); //Comes from CarFunctionalMethods.cs (Partial Car class)
            car.MyMethod21(); //Comes from CarOtherMethods.cs (Partial Car class)

            //Physical class names can't be same! You can't create 3x Car.cs in solution!
            #endregion

            #region Enum
            Person person = new Person();
            person.Id = 300;
            person.CreateDate = DateTime.Now;
            person.CreateUser = 7;
            person.Name = "Orkhan";
            person.Surname = "Farajov";
            person.DateOfBirth = new DateTime(1995, 12, 24);
            person.Gender = GenderEnum.Male; //Property Type: GenderEnum
            person.GenderInteger = (int)GenderEnum.Male; //Property Type: int

            if(person.Gender == GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");

            if(person.Gender.Equals(GenderEnum.Male))
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");

            if(person.GenderInteger == (int)GenderEnum.Male)
                Console.WriteLine("Person is Male");
            else
                Console.WriteLine("Person is Female");
            #endregion

            #region Homework
            /*
             Deməli bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
             müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
             məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
             Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
             etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
             da yazın.
             */
            #endregion
        }
    }
}

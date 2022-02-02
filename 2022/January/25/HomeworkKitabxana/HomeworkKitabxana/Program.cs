using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkKitabxana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Deməli bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
             müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
             məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
             Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
             etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
             da yazın.
             */
            string enternumberauthor = "1";           
            while (enternumberauthor == "1")
            {
                Author author = new Author();       
                Console.WriteLine("Muellifin adini daxil edin");
                author.Name = Console.ReadLine();
                Console.WriteLine("Muellifin yasini daxil edin");
                author.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Muellifin adresini daxil edin");
                author.Adress = Console.ReadLine();
                Database.AddAuthor(author);
                ArrayList alist = Database.GetAuthors();
                Console.WriteLine("Yeniden muellif daxil etmek isteyirsinizse 1 duymesini daxil ,eks halda 2 duymesini daxil edin");
                enternumberauthor = Console.ReadLine();
            }

            string enternumberbook = "1";
            while (enternumberbook == "1")
            {
                Book book = new Book();
                Console.WriteLine("Kitabin adini daxil edin");
                book.Name = Console.ReadLine();
                Console.WriteLine("Kitabin novunu daxil edin");
                book.Type = Console.ReadLine();
                Console.WriteLine("Kitabin hansi tarixde yazildigini daxil edin");
                book.WriteDate = DateTime.Now;
                Console.WriteLine("Zehmet olmasa bu kitabin muellifi kimi siralanan muelliflerden birini Id-sini  secin.");
                for (int i = 0; i < Database.GetAuthors().Count; i++)
                {
                    ArrayList authors = Database.GetAuthors();
                    Author author =(Author) authors[i];
                    Console.WriteLine((i+1) + ") " + author.Id + " " + author.Name + " " + author.Adress + " " + author.Age);
                }
                int enterId=int.Parse( Console.ReadLine());
                ArrayList authorbooks = Database.GetAuthors();
                foreach (var item in authorbooks)
                {
                    Author author = (Author)item;
                    if (author.Id==enterId)
                    {
                        book.Author = author;
                        break;
                    }
                }
                Database.AddBook(book);
                ArrayList alist = Database.GetBooks();
                Console.WriteLine("Yeniden muellif daxil etmek isteyirsinizse 1 duymesini daxil ,eks halda 2 duymesini daxil edin");
                enternumberbook = Console.ReadLine();
            }
            int say = 0;
            foreach (var item in Database.GetAuthors())
            {
                
                //ArrayList authors = Database.GetAuthors();
                Author author = (Author)item;
                Console.WriteLine();
                Console.WriteLine(author.Id + " " + author.Name + " " + author.Adress + " " + author.Age);
                Console.WriteLine("Eserleri asagidakilardir!!!");
                foreach (var itembook in Database.GetBooks())
                {
                    Book book = (Book)itembook;
                    if (book.Author.Id==author.Id)
                        Console.WriteLine(book.Name + " " + book.Type + " " + book.WriteDate);

                }
                say++;
            }
            Console.WriteLine("Is yekunlasdi");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkKitabxana
{
    internal static class  Database
    {
        /*
            Deməli bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
            müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
            məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
            Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
            etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
            da yazın.
            */
        private static ArrayList _authors;
        private static ArrayList _books;
        public static ArrayList GetAuthors()
        {
            return _authors;
        }
        public static ArrayList GetBooks()
        {
            return _books;
        }
        static Database()
        {
            _authors = new ArrayList();
            _books = new ArrayList();
        }
        public static void AddAuthor(Author author)
        {
            _authors.Add(author);
        }
        public static void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}

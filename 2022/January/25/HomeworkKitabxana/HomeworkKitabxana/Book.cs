using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkKitabxana
{
    internal class Book
    {
        public Book()
        {
            Id = 5;
        }
        /*
             Deməli bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
             müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
             məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
             Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
             etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
             da yazın.
             */
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = Database.GetBooks().Count + 1;

            }
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime WriteDate { get; set; }
        public Author Author { get; set; }
    }
}

using System.Collections.Generic;

namespace WindowsFormsAppPart5
{
    public class VirtualDatabase
    {
        public static List<Book> BooksTable = new List<Book>()
        {
            new Book()
            {
                Id=1,
                Name = "Dünyanın ən böyük sirri",
                Author = "Og Mandino",
                Category = "Psixologiya",
                Count = 350,
                Description = "Cəmi 45 həftəyə həyatınızın kökündən dəyişəcəyini təsəvvür edirsiniz? İnanmaya bilərsiniz. Çünki doğrudan da inandırıcı deyil. Amma bu mümkündür? Əlinizdə tutduğunuz bu kitabdakı nəsihətlərə əməl edərək üzləşdiyiniz möcüzələr sayəsində zəngin, xoşbəxt, uğurlu və ən əsası rahat bir insana çevriləcəksiniz. Hətta bunun necə asan baş verməsi sizi heyrətləndirəcək. Kitabda min illərin ticarət münasibətlərindən süzülüb gələn qayda və prinsiplər təqdim edilib. Tarix boyu bu qaydalar gizli saxlanılıb və qorunaraq nəsildən-nəslə ötürülüb. İndi sirlər sizin üçün açılır...",
                ImagePath = @"C:\Users\Education\Desktop\dunyanin-en-boyuk-sirri.jpg"
            },
            new Book()
            {
                Id=2,
                Name = "Daş Evlər",
                Author = "Seyran Səxavət",
                Category = "Roman",
                Count = 700,
                Description = "Oxucu Daş evlər romanında müxtəlif taleli insanlarla – müharibə veteranı Fərhad kişi, tələbə Akif, evdar qadın Zəkiyyə xala, taksi sürücüsü Əhməd, professor Əsgərzadə, tələbə qız Reyhan kimi maraqlı surətlərlə rastlaşır. Yazıçı onların qaynar həyatını maraqla təsvir edir.",
                ImagePath = @"C:\Users\Education\Desktop\das-evler.jpg"
            },
            new Book()
            {
                Id=3,
                Name = "3-cu Dünyanın ən böyük sirri",
                Author = "3Og Mandino",
                Category = "3Psixologiya",
                Count = 353,
                Description = "3Cəmi 45 həftəyə həyatınızın kökündən dəyişəcəyini təsəvvür edirsiniz? İnanmaya bilərsiniz. Çünki doğrudan da inandırıcı deyil. Amma bu mümkündür? Əlinizdə tutduğunuz bu kitabdakı nəsihətlərə əməl edərək üzləşdiyiniz möcüzələr sayəsində zəngin, xoşbəxt, uğurlu və ən əsası rahat bir insana çevriləcəksiniz. Hətta bunun necə asan baş verməsi sizi heyrətləndirəcək. Kitabda min illərin ticarət münasibətlərindən süzülüb gələn qayda və prinsiplər təqdim edilib. Tarix boyu bu qaydalar gizli saxlanılıb və qorunaraq nəsildən-nəslə ötürülüb. İndi sirlər sizin üçün açılır...",
                ImagePath = @"C:\Users\Education\Desktop\dunyanin-en-boyuk-sirri.jpg"
            },
            new Book()
            {
                Id=4,
                Name = "4-cu Daş Evlər",
                Author = "4Seyran Səxavət",
                Category = "4Roman",
                Count = 704,
                Description = "4Oxucu Daş evlər romanında müxtəlif taleli insanlarla – müharibə veteranı Fərhad kişi, tələbə Akif, evdar qadın Zəkiyyə xala, taksi sürücüsü Əhməd, professor Əsgərzadə, tələbə qız Reyhan kimi maraqlı surətlərlə rastlaşır. Yazıçı onların qaynar həyatını maraqla təsvir edir.",
                ImagePath = @"C:\Users\Education\Desktop\das-evler.jpg"
            }
        };
    }
}

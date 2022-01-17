using System;

namespace HomeworkDocument
{
    class Program
    {
        /*
         * Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial 
         * və DocumentNumber olaraq adlandıra bilərsiniz.
        Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.
        Validation və xəta mesajlarını deyirəm...
        Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi? Deyilsə
        "Vesiqenin seriyasinin uzunlugu 2 olmalidir!" xətası çıxmalıdır.
        Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir? Deyilsə
        "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.
        bu seriya üçündü. Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki,
        uzunluğu 8 ə bərabər dir mi?
        Deyilsə "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxacaq birdə nömrənin rəqəmlərdən 
        ibarət olub-olmamasını yoxlayacaq orda da deyilsə 
        "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.
        Bu validation'lara əlavə olaraqda vəsiqənin nömrəsi get olan zaman ilk 3
        xana user'ə göstəriləcək ancaq digər xanalar ulduz olaraq çıxacaq. Orda elə etmək lazımdır ki,
        3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik 4 simvol görsənsin
        və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və
        2 simvol ulduz olaraq çıxsın və s....
         */
        static void Main(string[] args)
        {
            string programexit = "continue";
            Document dc = new Document();
            while (dc.DocumentSerial == null)
            {
                Console.WriteLine("Vesiqenin seria kodunu daxil edin");
                string seria = Console.ReadLine();                
                dc.DocumentSerial = seria;
            }
            while (dc.DocumentNumber == null)
            {
                Console.WriteLine("Vesiqe nomresini daxil edin");
                string number = Console.ReadLine();
                dc.DocumentNumber = number;
            }
            while (programexit=="continue")
            {
                Console.WriteLine("Vesiqe nomresinin ilk nece reqeminin gorsenmesini isteyirsiniz");
                
                int firstnumber =int.Parse(Console.ReadLine());
                Console.WriteLine(dc.DocumentSerial+" "+ dc.SHowDocumentNumber(firstnumber)); 
            }

            Console.ReadLine();
        }
    }
}

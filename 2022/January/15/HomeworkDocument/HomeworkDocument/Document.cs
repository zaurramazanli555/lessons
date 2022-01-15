using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDocument
{
    class Document
    {
        /*
        
        Bu validation'lara əlavə olaraqda vəsiqənin nömrəsi get olan zaman ilk 3
        xana user'ə göstəriləcək ancaq digər xanalar ulduz olaraq çıxacaq. Orda elə etmək lazımdır ki,
        3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik 4 simvol görsənsin
        və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və
        2 simvol ulduz olaraq çıxsın və s....
         */
        private string _documentSerial;
        private string _documentNumber;
        public string DocumentSerial
        {
            get
            {
                return _documentSerial;
            }
            set
            {
                if (value.Length==2)
                {
                    if (CheckSeriaAlfabeth(value))
                    {
                        _documentSerial = value;
                        Console.WriteLine("Duzgun daxil edilmisdir");
                    }
                    else Console.WriteLine("Vesiqe Seriyasi ancaq herflerde ibaret ola biler!!!Xais edirik duzgun daxil edin\n");
                }
                else Console.WriteLine("Vesiqe Seriyasinin simvol sayi 2 herfli ola biler!!!Xahis edirik duzgun daxil edin\n");
            }
        }
        public string DocumentNumber
        {
            get
            {
                return _documentNumber;
            }
            set
            {
                if (value.Length == 8)
                {
                    if (CheckDocumentNumber(value))
                    {
                        _documentNumber = value;
                        Console.WriteLine("Duzgun daxil edilmisdir");
                    }
                    else Console.WriteLine("Vesiqe Nomresi ancaq reqemlerden ibaret ola biler!!!Xais edirik duzgun daxil edin\n");
                }
                else Console.WriteLine("Vesiqe Nomresinin   8 reqemden ibaret ola biler!!!Xahis edirik duzgun daxil edin\n");
            }
        }

        private bool CheckSeriaAlfabeth(string metn)
        {
            metn = metn.ToUpper();
            bool result = true;
            for (int i = 0; i < metn.Length; i++)
            {
                if (metn[i] < 65 || metn[i] > 90)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool CheckDocumentNumber(string metn)
        {
            bool result = true;
            for (int i = 0; i < metn.Length; i++)
            {
                if (metn[i] < 48 || metn[i] > 57)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public string SHowDocumentNumber(int firstnum)
        {
            string showdocnum = _documentNumber.Substring(0,firstnum);
            for (int i = 0; i < 8 - firstnum; i++)
            {
                showdocnum = showdocnum + "*";
            }
            return showdocnum;
        }


        /*
       
        */

    }
}

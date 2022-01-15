using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Homework_2
{
    public class Student
    {
        private string _documentSerial;
        private string _documentNumber;

        public string DocumentSerial {
            get
            {
                return _documentSerial;
            }
            set
            {
                if(value.Length == 2)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsLetter(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                    else
                        this._documentSerial = value;
                }
                else
                    Console.WriteLine("Vesiqenin seriyasi 2 herfden ibaret olmalidir!");
            }
        }

        public string DocumentNumber {
            get
            {
                if(_documentNumber != null)
                {
                    var length = _documentNumber.Length;
                    var showFirstLetter = 2;
                    var hiddenString = "";

                    for (int i = 0; i < (length - showFirstLetter); i++)
                    {
                        hiddenString += "*";
                    }

                    return _documentNumber.Substring(0, showFirstLetter) + hiddenString;
                }
                return null;
            }
            set
            {
                if (value.Length == 8)
                {
                    bool checkResult = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool badCharacter = !char.IsNumber(value[i]);
                        if (badCharacter)
                        {
                            checkResult = true;
                            break;
                        }
                    }

                    if (checkResult)
                        Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                    else
                        this._documentNumber = value;
                }
                else
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir!");
            }
        }
    }
}

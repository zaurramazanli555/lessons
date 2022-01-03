using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvIsi30122021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zəhmət olmasa aşağıdakı menulardan birini seçəsiniz");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Element elave ");
            Console.WriteLine("2 - Elementleri goster");
            Console.WriteLine("3 - Element axtar");
            Console.WriteLine("4 - Element editle");
            Console.WriteLine("5 - Element sil");
            Console.WriteLine("6 - Exit");
            ArrayList elements = new ArrayList();
            elements.Add(15);
            elements.Add("Salam");
            elements.Add("Hi");
            bool menuexit = true;
            while (menuexit)
            {
                Console.WriteLine("Zəhmət olmasa aşağıdakı menulardan birini seçəsiniz");
                string menunumber = Console.ReadLine();
                switch (menunumber)
                {
                    case "1":
                        Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin:");
                        string addelement = Console.ReadLine();
                        elements.Add(addelement);
                        Console.WriteLine("Element elave olundu");
                        break;
                    case "2":
                        for (int i = 0; i < elements.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Element = " + elements[i]);
                        }
                        break;
                    case "3":
                        bool boolsearch = false;
                        int say = -1;
                        Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin:");
                        string searchelement = Console.ReadLine();
                        foreach (var item in elements)
                        {
                            say++;
                            if (item.ToString() == searchelement)
                            {
                                boolsearch = true;
                                break;
                            }
                        }
                        if (boolsearch) Console.WriteLine("Axtardiginiz element tapidi,indexi {0} ,deyeri ise {1}",say, searchelement);
                        else Console.WriteLine("Axtardiginiz element tapilmadi");
                        break;
                    case "4":
                        bool boolsearchedit = false;
                        int index = -1;
                        Console.WriteLine("Editlemek istediyiniz elementi daxil edin:");
                        string searchelementEdit = Console.ReadLine();
                        foreach (var item in elements)
                        {
                            index++;
                            if (item.ToString() == searchelementEdit)
                            {
                                boolsearchedit = true;
                                break;
                            }
                        }
                        if (boolsearchedit)
                        {
                            Console.WriteLine("{0} elementi ne ile evez etmek isteyirsiniz zehmet olmasa daxil edin", searchelementEdit);
                            string elementreplace = Console.ReadLine();
                            elements[index] = elementreplace;
                            Console.WriteLine("Element edit edildi");
                        }
                        else Console.WriteLine("Axtardiginiz element tapilmadi");
                        break;
                        
                    case "5":
                        Console.WriteLine("Butun elementleri silmek isteyirsinizse {0} duymesini,ekshalda {1} duymesini secin ", "H", "Y");
                        string allremove = Console.ReadLine();
                        if (allremove=="H") 
                        {
                            for (int i = 0; i < elements.Count; i++)
                            {
                                elements.RemoveAt(i);
                            }
                        }
                        else
                        {
                            bool boolsearchremove = false;
                            int indexremove = -1;
                            Console.WriteLine("Silmek  istediyiniz elementi daxil edin:");
                            string searchelemenRemove = Console.ReadLine();
                            foreach (var item in elements)
                            {
                                indexremove++;
                                if (item.ToString() == searchelemenRemove)
                                {
                                    boolsearchremove = true;
                                    break;
                                }
                            }
                            if (boolsearchremove)
                            {
                                elements.RemoveAt(indexremove);
                                Console.WriteLine("Element silindi");
                            }
                            else Console.WriteLine("Silmek istediyiniz element tapilmadi");
                        }
                        
                        break;
                    case "6":
                        Console.WriteLine("Exit");
                        menuexit = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Proqramdan cixilmisdir");
            Console.ReadLine();
        }
    }
}

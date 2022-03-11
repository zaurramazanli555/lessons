using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Delegate?

            #region Calc without delegate
            void Addition(int a, int b)
            {
                Console.WriteLine($"Toplama neticesi: {(a + b)}");
            }

            void Subtraction(int a, int b)
            {
                Console.WriteLine($"Cixmanin neticesi: " + (a-b));
            }

            void Multiplication(int a, int b)
            {
                Console.WriteLine($"Vurmanin neticesi: " + (a*b));
            }

            void Division(int a, int b)
            {
                Console.WriteLine($"Bolmenin neticesi: " + (a/b));
            }

            //Addition(10, 20);
            //Subtraction(50, 35);
            //Multiplication(2, 40);
            //Division(100, 4);
            #endregion

            #region Calc with delegate
            Calc delegateCalc = new Calc(Addition);
            delegateCalc += Subtraction;
            delegateCalc += Multiplication;
            delegateCalc += Division;
            delegateCalc.Invoke(10, 20);

            int otherMethod(int a, int b)
            {
                return 0;
            }

            //delegateCalc += otherMethod; //wrong

            Delegate[] delegates = delegateCalc.GetInvocationList();

            foreach (var item in delegates)
            {
                Console.WriteLine($"Method Name: " + item.Method.Name);
                Console.WriteLine($"Return Type: " + item.Method.ReturnType);
                Console.WriteLine($"Is Static: " + item.Method.IsStatic);
                Console.WriteLine($"Is Virtual: " + item.Method.IsVirtual);
                Console.WriteLine($"Is Private: " + item.Method.IsPrivate);
                Console.WriteLine($"Is Ctor: " + item.Method.IsConstructor);
                Console.WriteLine($"Is Abstract: " + item.Method.IsAbstract);
            }

            delegateCalc -= Subtraction;

            foreach (var item in delegateCalc.GetInvocationList())
            {
                Console.WriteLine($"Method Name: " + item.Method.Name);
            }
            #endregion
            
            ShowPersonInfo delegateWithLambda = (Person p) => Console.WriteLine($"Name: {p.Name} Surname: {p.Surname}");
            Person person = new Person("Orkhan", "Farajov", 27, "orkhankhf@gmail.com");
            delegateWithLambda.Invoke(person);

            delegateWithLambda = (Person p) => Console.WriteLine($"{p.Name} is {p.Age} years old. Contact: {p.Email}");
            delegateWithLambda(person); //1-ci versiya
            delegateWithLambda.Invoke(person); //2-ci versiya
            
            Console.Clear();

            //Adsiz method ile istifade
            ShowPersonInfo delegateWithUnnamedMethod = new ShowPersonInfo(delegate (Person p)
            {
                Console.WriteLine($"Hello {p.Name} {p.Surname}");
                Console.WriteLine($"You are {p.Age} years old and your email address is {p.Email}");
            });
            delegateWithUnnamedMethod(person);

            FindAll((Person p) => Console.WriteLine($"Name: {p.Name} Surname: {p.Surname}"));
            #endregion
        }

        delegate void Calc(int a, int b);

        public delegate void ShowPersonInfo(Person person);

        public static void FindAll(ShowPersonInfo p)
        {

        }
    }
}

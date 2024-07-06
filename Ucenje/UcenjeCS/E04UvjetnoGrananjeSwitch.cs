using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {

        public static void Izvedi()
        {

            // switch je višestruko grananje

            int i = 0;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;
            }

            // switch radi s int, string, char i drugi https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements#1383-the-switch-statement


            char znak = '@';
            Console.WriteLine(znak);
            Console.WriteLine((int) znak);


        }


    }
}

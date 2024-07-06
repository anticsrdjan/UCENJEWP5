using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {

        public static void Izvedi()
        {
            // pojam ulaska u petlju
            // u for petlju se ne mora ući
            int brojDo = 0; // ovo može unijeti korisnik

            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************");

            // if radi s bool tipom podatke
            // switch rad s brojevima, char i string
            // while radi s bool tipom podatka
            // beskonačna petlja
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(new Random().Next() + " ");
                }
                Console.WriteLine();
                Thread.Sleep(100);
                break;
            }
            Console.WriteLine("**************************");

            brojDo = 10;
            while (brojDo-- > 0)
            {
                Console.WriteLine(brojDo);
            }

            Console.WriteLine("**************************");

            int j = 2;
            while(brojDo<10 && j == 2)
            {
                Console.WriteLine(brojDo++);
            }


            Console.WriteLine("**************************");

            brojDo = 0;
            while (brojDo < 10)
            {
                if(++brojDo ==2)
                {
                    continue;
                }
                Console.WriteLine(brojDo);
                //brojDo++;
                //brojDo += 1;
                //brojDo = brojDo + 1;
            }


            Console.WriteLine("**************************");
            brojDo = 1;
            
            while(brojDo <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.Write(brojDo * j++ + "\t");
                }
                Console.WriteLine();
                brojDo++;
            }
            Console.WriteLine("**************************");

            // hoće li se uvijek ući u while petlju?
            // NEĆE

            brojDo = 0;
            while (brojDo > 0) 
            {
                Console.WriteLine(brojDo); // ovo se neće ispisati
            }


        }

    }
}

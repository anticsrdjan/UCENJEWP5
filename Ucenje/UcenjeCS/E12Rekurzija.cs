using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {

        // Rekurzija je kada metoda zove samu sebe
        // UZ UVIJET PREKIDA REKURZIJE

        public static void Izvedi()
        {
            // Metoda(); ovo producira StackOverflow exception
            Console.WriteLine(Zbroji(100));

            int broj = Izracunaj("Koji je broj",2);

        }

        private static int Izracunaj(string tekst, int broj)
        {
            return 0;
        }

        private static void Metoda()
        {
            Metoda();
        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj - 1);
        }
    }
}

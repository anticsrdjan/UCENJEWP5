using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {

        public static void Izvedi()
        {

            // motivacija: treba ti 12 varijabli za 12 temperatura različitih mjeseci
            // ono što znamo
            int temp1, temp2, t3, t4; // -> OVO JE LOŠE


            // eng. Arrays
            // još na HR polja

            // jednodimenzionalni nizovi
            // [ je ALTGr + F
            int[] temperature = new int[12]; // najveći problem nizova je što na početku moram znati koliko ima elemenata

            // nizovi počinju s indexom 0
            // 1. element niza je na indexu 0
            temperature[0] = -2; // Siječanj
            temperature[1] = 0;
            //..
            temperature[11] = -3; //Prosinac

            // dužina niza
            Console.WriteLine(temperature.Length); // ukupan broj elemenata

            // zadnji se u pravilu ovako postavlja
            temperature[temperature.Length - 1] = 0;

            Console.WriteLine(temperature[1]); // 0

            // temperature[12] = 1; - GREŠKA PRILIKOM IZVOĐENJA


            Console.WriteLine(temperature);

            // ispisati sve elemente niza
            Console.WriteLine(string.Join(",", temperature));


            // skeraćeniji način
            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            // ispisati 56
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo", "Belišće" };

            // ispisati zadnji grad
            Console.WriteLine(gradovi[gradovi.Length - 1]);



            int[,] tablica = {
            { 1,2,3 },
            { 4,5,6 },
            { 7,8,9 }
            };

            // ispiši 6
            // ispiši 9



            // trodimenzionalni niz
            int[,,] kocka = { };


            // tesaarect - 4 dimenzije

            int[,,,] tesaarect = { };

            // multiverse
            int[,,,,,,] multiverse = { };


            // nizovi mogu imati i različite tipove podataka

            object[] objekti = { "ovo", 3, 2.6, true };

        }

    }
}

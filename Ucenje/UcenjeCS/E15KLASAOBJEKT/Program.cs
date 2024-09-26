using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E15KlasaObjekt.edunova;

namespace UcenjeCS.E15KlasaObjekt
{
    internal class Program
    {

        public static void Izvedi()
        {
            Console.WriteLine("Hello OOP");

            // Objekt je instanca (pojavnost) klase

            // Osoba je ime klase
            // osoba je ime objekta (instance / pojavnosti) - varijabla

            Osoba osoba; // deklariran, bez instance

            osoba = new Osoba(); // konstruiranje objekta - RAĐA se, kreira se - zauzima memoriju

            osoba.Ime = "Pero"; // objekt živi i posjeduje vrijednosti - postavljamo ih

            Console.WriteLine(osoba.Ime); // objekt živi i posjeduje vrijednosti koje se konzumiraju

            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime()); // metoda ImePrezime nije statična jer nju zovem na objektu
            
            // a kraju objekt (osoba) umire - UNIŠTAVA GA/ČISTI iz memorije
            // MI NE UNIŠTAVAMO objekt, to radi Garbagge collector


            // drugi načini kreiranja objekta

            Osoba ravnatelj = new Osoba
            {
                Sifra=1,
                Ime="Marko",
                Prezime="Kas"
            };

            var direktor = new Osoba { Ime = "Edo" }; // dobra praksa

            Osoba profesor = new() { Prezime="Reh", Ime="Klara" };

            Console.WriteLine(profesor.Ime?.ToUpper());
            // https://gunnarpeipman.com/csharp-question-marks/
            // https://blog.wordbot.io/tech/what-do-two-question-marks-together-mean-in-c/
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-


            var o = new Osoba()
            {
                Ime="Marija",
                Mjesto = new() { Naziv="Osijek",PostanskiBroj="31000"}
            };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            // dugi način

            Zupanija obz = new Zupanija();
            obz.Naziv = "Osječko-baranjska županija";

            Mjesto os = new Mjesto();
            os.Naziv = "Osijek";

            os.Zupanija = obz;

            Osoba ja = new Osoba();
            ja.Ime = "Tomislav";
            ja.Mjesto= os;

            // Ispišite u konzoli iz objekta ja vrijednost Osječko-baranjska županija

            Console.WriteLine(ja.Mjesto?.Zupanija?.Naziv);



            // objketi iz edunova klasa

            var smjer = new Smjer() { Sifra=E11Metode.UcitajCijeliBroj("Unesi šifru",1,10000), Naziv="Web" };

            var grupa = new Grupa() { Naziv="WP5",Smjer=smjer };

            // zadatak: ispiši šifru smjera na grupi WP5
            Console.WriteLine(grupa.Smjer.Sifra);

        }
    }
}

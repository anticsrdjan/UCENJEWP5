using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E15KlasaObjekt
{
    // Klasa je opisnik objekta - OVO NAUČITI NAPAMET
    internal class Osoba
    {

        // klasa sadrži svojstva (property)
        public int? Sifra { get; set; } // OOP princip učahurivanja
        public string? Ime { get; set; } // ? označava kako Ime može biti null

        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }




        // klasa sadrži metode
        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }
    }
}

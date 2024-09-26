using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    // apstraktna klasa je ona klasa koja se ne može instancirati
    // ona se kreira da bi ju druge klase nasljedile i nadopunile
    internal abstract class Entitet : Object  // ovo se podrazumjeva i ne mora se pisati
    {

        public int? Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Smjer : Entitet // Klasa smjer nasljeđuje javna i zaštićena svojstva i metode klase Entitet
    {
        public string? Naziv { get; set; }

        public override string ToString()
        {
            return  Naziv;
        }
    }
}

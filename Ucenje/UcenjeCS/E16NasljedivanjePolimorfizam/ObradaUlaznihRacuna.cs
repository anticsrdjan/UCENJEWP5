using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class ObradaUlaznihRacuna : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Plati preko banke");
        }
    }
}

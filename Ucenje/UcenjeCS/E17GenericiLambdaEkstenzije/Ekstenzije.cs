using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal static class Ekstenzije
    {

        public static void OdradiPosao(this Entitet e)
        {
            Console.WriteLine(e.Sifra);
        }

        public static void PrikazRadaSSuceljem(this ISucelje sucelje)
        {
            sucelje.Posao();
        }

    }
}

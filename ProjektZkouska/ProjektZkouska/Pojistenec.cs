using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Pojistenec
    {
        public string Jmeno { get; private set;}
        public string Prijmeni { get; private set;}
        public int TelefonniCislo { get; private set;}
        public int Vek { get; private set;}

        public Pojistenec (string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
        public override string ToString()
        {
            return Jmeno.PadRight(10) + Prijmeni.PadRight(10) + Vek.ToString().PadRight(10) + TelefonniCislo;
        }
    }
}

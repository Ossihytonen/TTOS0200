using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija_ohjelma
{
    class Lab02
    {
        public class Opiskelija
        {
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string Kokonimi { get; set; }
            public string Henkilotunnus { get; set; }
            public string Opiskelijanumero { get; set; }
            public string etunimi()
            {
                return Etunimi;
            }
            public string sukunimi()
            {
                return Sukunimi;
            }
            public string kokonimi()
            {
                return Etunimi + Sukunimi;
            }
            public string henkilotunnus()
            {
                return Henkilotunnus;
            }
            public string opiskelijanumero()
            {
                return Opiskelijanumero;
            }
            public string tiedot()
            {
                return "Nimi: " + Etunimi + " " + Sukunimi + " Henkilötunnus: " + Henkilotunnus + " Opiskelijanumero: " + Opiskelijanumero; 
            }
        }
    }
}

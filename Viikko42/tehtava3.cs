using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko42
{
    class tehtava3
    {
        public class Pelaaja
        {
            public string Nimi { get; set; }
            public string Pelipaikka { get; set; }
            public string Kätisyys { get; set; }

            public Pelaaja()
            {
            }
            public Pelaaja(string nimi, string pelipaikka, string kätisyys)
            {
                Nimi = nimi;
                Pelipaikka = pelipaikka;
                Kätisyys = kätisyys;
            }
            public override string ToString()
            {
                return Nimi + " |pelipaikka: " + Pelipaikka + " |kätisyys: " + Kätisyys;
            }
        }
        public class PeliSeura
        {
            public string Name { get; set; }
            public List<Pelaaja> pelaajat;
            public PeliSeura()
            {
                pelaajat = new List<Pelaaja>();

            }
            public override string ToString()
            {
                string retval = Name + " sisältö\n";
                foreach (Pelaaja item in pelaajat)
                {
                    retval += item.ToString() + "\n";
                }
                return retval;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra11._2
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
    }
    public class PeliSeura
    {
        //public List<Pelaaja> pelaajat;
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            PeliSeura JYP = new PeliSeura();
            pelaajat.Add(new Pelaaja("Lauri Möttö", "Hyökkääjä", "Right"));
            pelaajat.Add(new Pelaaja("Kalle Kankkunen", "Hyökkääjä", "Right"));
            pelaajat.Add(new Pelaaja("J.P Hytönen", "Puolustaja", "Right"));
            pelaajat.Add(new Pelaaja("Pasi Pakki", "Maalivahti", "Right"));
            return pelaajat;

        }
    }
}

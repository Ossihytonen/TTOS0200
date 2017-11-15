using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotalli
{
    public static class AutoTalli
    {
        public static List<Auto> HaeAuto()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitääm nuutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 1909;
            a.KM = 20000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);
            // toinen auto
            Auto b = new Auto() { Merkki = "Audi", Malli = "A4", VM = 2006, KM = 100000, Hinta = 20000, URL = "AudiA4.png" };
            autot.Add(b);
            Auto c = new Auto() { Merkki = "Saab", Malli = "99", VM = 2000, KM = 20000099, Hinta = 100, URL=""};
            autot.Add(c);
            Auto d = new Auto() { Merkki = "Laurin", Malli = "Auto", VM = 1800, KM = 999999999, Hinta = 1, URL = "Golf.jpg" };
            autot.Add(d);
            //palautus
            return autot;
        }
    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }

    }
}

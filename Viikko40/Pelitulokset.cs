using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko40
{
    class Pelitulokset
    {
        public class Peli
        {
            public string OtteluPaiva { get; set; }
            public string Koti { get; set; }
            public string Vieras { get; set; }
            public string Voittaja { get; set; }
            public string Pisteet { get; set; }
            public override string ToString()
            {
                return "|Nimi: " + OtteluPaiva + " |Kotijoukkue: " + Koti + " |Vierasjoukkue: " + Vieras + " |Voittaja: " + Voittaja +" |Pelin lopputulos; "+ Pisteet;
            }
        }
        public class Jaakiekko : Peli
        {

        }
        public class Pesapallo : Peli
        {

        }
        public class Jalkapallo : Peli
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko40
{
    class Pelitulokset
    {
        public class Jalkapallo
        {
            public string OtteluPaiva { get; set; }
            public string Koti { get; set; }
            public string Vieras { get; set; }
            public string Voittaja { get; set; }
            public string Pisteet { get; set; }
            public override string ToString()
            {
                return "|Nimi: " + OtteluPaiva + " |Valmistaja: " + Koti + " |Valmistus aika: " + Vieras + " |Hinta: " + Voittaja + Pisteet;
            }
        }
        public class Jaakiekko : Jalkapallo
        {

        }
        public class Pesapallo : Jaakiekko
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko40
{
    class Kirjahyllyssa
    {
        public class Kirja
        {
            public string Name { get; set; }
            public string Producer { get; set; }
            public int ProductionYear { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return "|Nimi: " + Name + " |Valmistaja: " + Producer + " |Valmistus aika: " + ProductionYear + " |Hinta: " + Price;
            }
        }
        public class Lehti : Kirja
        {

        }
        public class CD : Kirja
        {

        }
        public class DVD : Kirja
        {

        }
        public class Bluray : Kirja
        {

        }
        public class Puhelin : Kirja
        {

        }
        public class Lappari : Kirja
        {

        }
    }
}

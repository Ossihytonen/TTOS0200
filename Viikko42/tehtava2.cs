using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko42
{
    class tehtava2
    {
        public class Jaakaappi
        {
            public string Name { get; set; }
            public List<Asia> sisältö;
            public Jaakaappi()
            {
                sisältö = new List<Asia>();

            }
            public override string ToString()
            {
                string retval = Name + " sisältö\n";
                foreach (Asia item in sisältö)
                {
                    retval += item.ToString() + "\n";
                }
                return retval;
            }
        }
        public class Asia
        {
            public string Nimi { get; set; }
            public string Sijainti { get; set; }

            public Asia()
            {
            }
            public Asia(string nimi, string sijainti)
            {
                Nimi = nimi;
                Sijainti = sijainti;
            }
            public override string ToString()
            {
                return Nimi + " on " + Sijainti;
            }
        }
    }
}

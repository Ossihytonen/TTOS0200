using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44._1
{
    public class Asiakas
    {
        public string Nimi { get; set; }
        public List<Ostoskori> Sisältö = new List<Ostoskori>();

        public Asiakas(string nimi)
        {
            Nimi = nimi;
        }
        public override string ToString()
        {
            string retval = "";
            retval += string.Format("Asiakkaan Tilin tiedot \n\n Asiakas {0} :\n", Nimi);
            double yhteensä = 0;
            foreach (Ostoskori tuote in Sisältö)
            {
                retval += string.Format("-Tuote: {0} Määrä: {1}kpl Hinta: {2}e Yhteensä: {3} \n",
                    tuote.Tuote, tuote.Määrä, tuote.Hinta, tuote.Yhteishinta );
                retval += string.Format("-------------------------------------------------------------\n");
                yhteensä += tuote.Yhteishinta;
            }
            retval += string.Format("Laskulla: {0} euroa \n", yhteensä);
            return retval;
        }
    }
    public class Ostoskori
    {
        public string Tuote { get; set; }
        public int Määrä { get; set; }
        public double Hinta { get; set; }
        public double Yhteishinta { get; set; }
        public Ostoskori()
        {

        }
        public Ostoskori(string tuote, int määrä, double hinta, double yhteishinta, double laskulla)
        {
            this.Tuote = tuote;
            this.Määrä = määrä;
            this.Hinta = hinta;
            this.Yhteishinta = Määrä*Hinta;

        }

    }
}

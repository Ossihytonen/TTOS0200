using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class TestaaCD
    {
        static void Testaa()
        {
            CD pop = new CD();
            pop.LevynNimi = "Klassikkohitit";
            pop.Artisti = "Piirainen";
            //luodaan List-tyyppinen lista
            List<CD> kappaleet = new List<CD>();
            kappaleet.Add(new CD { Biisit = "Räpätessä roiskuu", Kesto = "4.32" });
            kappaleet.Add(new CD { Biisit = "Runopoika", Kesto = "1.32" });
            kappaleet.Add(new CD { Biisit = "Piippolanvaari", Kesto = "43.12" });
            kappaleet.Add(new CD { Biisit = "Maijjalla oli karitsa", Kesto = "22.12" });
            kappaleet.Add(new CD { Biisit = "Hippulat vinkuu", Kesto = "5.12" });
            kappaleet.Add(new CD { Biisit = "Vielä keksii", Kesto = "6.12" });
            kappaleet.Add(new CD { Biisit = "Ei enää", Kesto = "2.12" });
            //KAikkien tiedot
            Console.WriteLine("CD data:\n" + "- name: " + pop.LevynNimi + "\n- artist: " + pop.Artisti + "\n- songs: ");
            foreach (CD cd in kappaleet)
            {
                Console.WriteLine(" -" + cd.ToString());
            }
            /*//luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //TEstin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi//");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A12434"));
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "MASA", AsioID = "A1231" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Tepo", Sukunimi = "TEsi", AsioID = "T1231", Ryhmä = "TTV#¤S" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "asda"; kalle.AsioID = "sada";
            opiskelijat.Add(kalle);
            Console.WriteLine("Anna numero väliltä 1-5 >>");
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count)
            {
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());

            }
            else
            {
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", i);
            }
            //KAikkien opiskelijoiden tiedot
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MiniASIOn opiskelijat");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //Kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            //shortataan oliot sukunimen mukaiseen järjestykseen
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MiniASIOn opiskelijat aakkosittain");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelija lisäys + takistus ettei asio id ole olemasas
            Console.WriteLine("Anna AsioID >>");
            string asioid = Console.ReadLine();
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan Etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan Sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan Ryhmä");
                string ryhma = Console.ReadLine();
                //uusi olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn opiskelijat {0}", opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }*/
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}

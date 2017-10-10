using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko42
{
    class Program
    {
        static void Main(string[] args)
        {
            //tehtava1.TestClass();
            /*Viikko42.tehtava2.Jaakaappi Samsung = new Viikko42.tehtava2.Jaakaappi();
            Samsung.Name = "Jääkaapin ";
            Samsung.sisältö.Add(new tehtava2.Asia("Maito", "Keskellä"));
            Samsung.sisältö.Add(new tehtava2.Asia("Rypäleet", "Ovessa"));
            Samsung.sisältö.Add(new tehtava2.Asia("Sokeri", "Vihanneslaatikossa"));
            Samsung.sisältö.Add(new tehtava2.Asia("Kahvi", "Pakastimessa"));
            Samsung.sisältö.Add(new tehtava2.Asia("Juusto", "Ulkona"));
            Console.WriteLine(Samsung.ToString());*/
            tehtava3.PeliSeura JYP = new tehtava3.PeliSeura();
            JYP.Name = "JYP";
            JYP.pelaajat.Add(new tehtava3.Pelaaja("Lauri Piirainen", "Hyökkääjä", "Right"));
            JYP.pelaajat.Add(new tehtava3.Pelaaja("J.P Hytönen", "Puolustaja", "Right"));
            JYP.pelaajat.Add(new tehtava3.Pelaaja("Pasi Pakki", "Maalivahti", "Right"));

            tehtava3.PeliSeura Kalpa = new tehtava3.PeliSeura();
            Kalpa.Name = "Kalpa";
            Kalpa.pelaajat.Add(new tehtava3.Pelaaja("Joni Aho", "Maalivahti", "Right"));
            Kalpa.pelaajat.Add(new tehtava3.Pelaaja("Sami Kato", "Maalivahti", "Right"));
            Kalpa.pelaajat.Add(new tehtava3.Pelaaja("Pekka Varis", "Maalivahti", "Left"));

            tehtava3.PeliSeura Tappara = new tehtava3.PeliSeura();
            Tappara.Name = "Tappara";
            Tappara.pelaajat.Add(new tehtava3.Pelaaja("Antti Anttonen", "Hyökkääjä", "Right"));
            Tappara.pelaajat.Add(new tehtava3.Pelaaja("Antti Mikkonen", "Hyökkääjä", "Right"));
            Tappara.pelaajat.Add(new tehtava3.Pelaaja("Antti Kaikkonen", "Puolustaja", "Right"));

            Console.WriteLine("Minkä pelaajatiedot haluat tulostaa  1.Jyp  2.Kalpa 3.Tappara");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(JYP.ToString());
            }
            else if (valinta == 2)
            {
                Console.WriteLine(Kalpa.ToString());
            }
            else if (valinta == 3)
            {
                Console.WriteLine(Tappara.ToString());
            }
            else
            {
                Console.WriteLine("Ei valintaa");
            }

        }
    }
    
}

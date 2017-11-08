using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44._1
{
    class Program
    {
        static void KalastajanTiedot()
        {
            try
            { 
                Kalastaja paikka1 = new Kalastaja("Kirsi Kernel", "020-12345678");
                Console.WriteLine("Uusi kalastaja lisätty: \n - Kalastaja: {0} Puhelin {1} \n", paikka1.Nimi, paikka1.PuhelinNumero);
                Console.WriteLine("------------------------------------------\n");
                Kala Ahven = new Kala("Ahven", 100, 40, "Järvi", "Keski-suomi");
                Console.WriteLine("Kalastaja: {0} Sai uuden kalan: \n - Laji: {1} {2} cm {3} g \n - Paikka: {4} \n - Paikan nimi: {5} \n",
                    paikka1.Nimi, Ahven.Laji, Ahven.Pituus, Ahven.Paino, Ahven.Paikka, Ahven.PaikanNimi);
                Console.WriteLine("------------------------------------------\n");
                paikka1.Saalis.Add(Ahven);

                Kala Kuha = new Kala("Kuha", 500, 54, "Rovaniemi", "Lappi");
                Console.WriteLine("Kalastaja: {0} Sai uuden kalan: \n - Laji: {1} {2} cm {3} g \n - Paikka: {4} \n - Paikan nimi: {5} \n",
                    paikka1.Nimi, Kuha.Laji, Kuha.Pituus, Kuha.Paino, Kuha.Paikka, Kuha.PaikanNimi);
                Console.WriteLine("------------------------------------------\n");
                paikka1.Saalis.Add(Kuha);

                Console.WriteLine(paikka1.ToString());
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("Suurimmasta pienimpään: \n");
                Console.WriteLine(paikka1.Kaanteinnen());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void OstajanTiedot()
        {
            try
            {
                Asiakas paikka1 = new Asiakas("Kirsi Kernel");
                Ostoskori ostos1 = new Ostoskori("Maitoa", 2, 1.19, 0,0);
                paikka1.Sisältö.Add(ostos1);
                Ostoskori ostos2 = new Ostoskori("Leipää", 1, 0.49, 0, 0);
                paikka1.Sisältö.Add(ostos2);

                Console.WriteLine(paikka1.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void Main(string[] args)
        {
            //OstajanTiedot();
            KalastajanTiedot();
        }
    }
}
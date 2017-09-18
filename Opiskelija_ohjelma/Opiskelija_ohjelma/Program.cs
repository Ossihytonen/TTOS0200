using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lab02.Opiskelija opiskelija1 = new Lab02.Opiskelija();
            opiskelija1.Etunimi = "Matti";
            opiskelija1.Sukunimi = "Patti";
            opiskelija1.Henkilotunnus = "121288-2334";
            opiskelija1.Opiskelijanumero = "K3214";

            Lab02.Opiskelija opiskelija2 = new Lab02.Opiskelija();
            opiskelija2.Etunimi = "Hatti";
            opiskelija2.Sukunimi = "Katti";
            opiskelija2.Henkilotunnus = "121288-2334";
            opiskelija2.Opiskelijanumero = "K3214";

            Lab02.Opiskelija opiskelija3 = new Lab02.Opiskelija();
            opiskelija3.Etunimi = "Satti";
            opiskelija3.Sukunimi = "Natti";
            opiskelija3.Henkilotunnus = "121288-2334";
            opiskelija3.Opiskelijanumero = "K3214";

            Lab02.Opiskelija opiskelija4 = new Lab02.Opiskelija();
            opiskelija4.Etunimi = "Pakki";
            opiskelija4.Sukunimi = "Happi";
            opiskelija4.Henkilotunnus = "121288-2334";
            opiskelija4.Opiskelijanumero = "K3214";

            Lab02.Opiskelija opiskelija5 = new Lab02.Opiskelija();
            opiskelija5.Etunimi = "Tutti";
            opiskelija5.Sukunimi = "Ratti";
            opiskelija5.Henkilotunnus = "121288-2334";
            opiskelija5.Opiskelijanumero = "K3214";

            Console.WriteLine(opiskelija1.tiedot());
            Console.WriteLine(opiskelija2.tiedot());
            Console.WriteLine(opiskelija3.tiedot());
            Console.WriteLine(opiskelija4.tiedot());
            Console.WriteLine(opiskelija5.tiedot());
            */
            string[] opiskelijat = new string[5];

            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Lab02.Opiskelija Opis = new Lab02.Opiskelija();
                Console.WriteLine("====UUSIOPISKELIJA====");

                Console.WriteLine("Anna Etunimi>");
                Opis.Etunimi = Console.ReadLine();

                Console.WriteLine("Anna Sukunimi>");
                Opis.Sukunimi = Console.ReadLine();

                Console.WriteLine("Anna opiskelijatunnus>");
                Opis.Opiskelijanumero = Console.ReadLine();

                Console.WriteLine("Anna henkilötunnus>");
                Opis.Henkilotunnus = Console.ReadLine();

                opiskelijat[i] = Opis.tiedot();
            }
            Console.WriteLine("Kirjatut opiskelijat");
            for (int i = 0; i < opiskelijat.Length; i++)
            {
                Console.WriteLine(opiskelijat[i]);
                Console.WriteLine("...........................");
            }
        }
    }
}

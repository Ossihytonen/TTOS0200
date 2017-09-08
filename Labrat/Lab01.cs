using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab01
    {
        public static void Tehtava1()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int luku;
            Console.WriteLine("Anna luku>> ");
            luku = int.Parse(Console.ReadLine());
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            else if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            else if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else
            {
                Console.WriteLine("Joku muu luku");
            }
        }
        public static void Tehtava2()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int luku;
            Console.WriteLine("Anna Pietemaara>> ");
            luku = int.Parse(Console.ReadLine());
            if (luku >= 0 && luku <= 1)
            {
                Console.WriteLine("Kolunumeo on 0");
            }
            else if (luku >= 2 && luku <= 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }
            else if (luku >= 4 && luku <= 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }
            else if (luku >= 6 && luku <= 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }
            else if (luku >= 8 && luku <= 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }
            else if (luku >= 10 && luku <= 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }
            else
            {
                Console.WriteLine("Vaara lukuarvo");
            }
        }
        public static void Tehtava3()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int luku, luku2, luku3, yhteen;
            double keskia;
            Console.WriteLine("Anna ensimmainen luku ja paina entteria>> ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku ja paina entteria>> ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku>> ");
            luku3 = int.Parse(Console.ReadLine());
            // Laskee summan
            yhteen = luku + luku2 + luku3;
            // Laskee keskiarvon
            float dividend = 3;
            keskia = (luku + luku2 + luku3) / dividend;
            Console.WriteLine("Numeroiden summa on {0}", yhteen);
            Console.WriteLine("Numeroiden keskiarvo on " + keskia);
        }
        public static void Tehtava4()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int ika;
            Console.WriteLine("Anna ikasi ja paina entteria>> ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (ika >= 18 && ika <=65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }
        public static void Tehtava5()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            int luku, tunnit, minuutit, sekunnit;
            Console.WriteLine("Anna sekuntit >> ");
            luku = int.Parse(Console.ReadLine());
            tunnit = luku / 3600;
            minuutit = (luku % 3600) / 60;
            sekunnit = ((luku % 3600) % 60);
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmaista muodossa: " + tunnit + " tuntia " + minuutit + " minuuttia ja " + sekunnit + " sekuntia");

        }
    }
}

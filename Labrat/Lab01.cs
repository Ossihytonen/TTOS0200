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
            else if (ika >= 18 && ika <= 65)
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
        public static void Tehtava6()
        {
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua 
            double luku, kulutus, hinta;
            Console.WriteLine("Anna matka >> ");
            luku = double.Parse(Console.ReadLine());
            kulutus = (7.02 / 100) * luku;
            hinta = 1.595 * kulutus;
            Console.WriteLine("Bensaa kuluu {0:.##} litraa, kustannus {1:.##} euroa", kulutus, hinta);
        }
        public static void Tehtava7()
        {
            double luku;
            Console.WriteLine("Anna vuosi >> ");
            luku = double.Parse(Console.ReadLine());
            if ((luku % 4 == 0 && luku % 100 != 0) || (luku % 400 == 0))
            {
                Console.WriteLine("{0} on karkausvuosi", luku);
            }
            else
            {
                Console.WriteLine("{0} ei ole karkausvuosi", luku);
            }
        }
        /*public static void Tehtava8()
        {
            /*int luku, luku2, luku3;
            Console.WriteLine("Anna luku >> ");
            luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku >> ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku >> ");
            luku3 = int.Parse(Console.ReadLine());
            int[] jono = { luku, luku2, luku3 };
            int maks = jono.Max();
            jono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sss"+jono);
            int[] = new arrayarr
            if (arr.Length > 0)
            {
                int small = arr[0];
                int large = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (large < arr[i])
                    {
                        int tmp = large;
                        large = arr[i];
                        arr[i] = large;
                    }
                    if (small > arr[i])
                    {
                        int tmp = small;
                        small = arr[i];
                        arr[i] = small;
                    }
                }
                Console.WriteLine("Smallest is {0}", small);
                Console.WriteLine("Largest is {0}", large);
            }
        }*/
        public static void Tehtava9()
        {
            int i, luku, kokonais;
            kokonais = 0;
            i = 1;
            while (i != 0)
            {
                Console.WriteLine("Anna luku >> ");
                luku = int.Parse(Console.ReadLine());
                kokonais += luku;
                if (luku == 0)
                {
                    Console.WriteLine("Summa on " + kokonais);
                    i = 0;
                }
            }
        }
        public static void Tehtava10()
        {

        }

    }
}

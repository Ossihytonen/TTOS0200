using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public class Kiuas
        {
            public int Virta { get; set; }
            public int Lampotila { get; set; }
            public int Kosteus { get; set; }

            public void virta()
            {
                if (Virta == 1)
                {
                    Console.WriteLine("Kiuas on Päällä");
                }
                else
                {
                    Console.WriteLine("kiuas ei ole Päällä");
                }
            }
            public void lampotila()
            {
                Console.WriteLine("Lämpötila on {0} astetta", Lampotila);
            }
            public void kosteus()
            {
                if (Kosteus > 0)
                {
                    Lampotila += 5;
                    Console.WriteLine("Heitit löylyä lämpötila nousi {0} asteeseen", Lampotila);
                }
                else
                {
                    Console.WriteLine("Lämpötila laski {0} asteeseen", Lampotila);
                }
            }
        }
        public class Pesukone
        {
            public int Virta { get; set; }
            public int Lampotila { get; set; }
            public int Aika { get; set; }
            public int Pesuaine { get; set; }
            public int Ohjelma { get; set; }

            public void virta()
            {
                if (Virta == 1)
                {
                    Console.WriteLine("Pesukone on Päällä");
                }
                else
                {
                    Console.WriteLine("Pesukone ei ole Päällä");
                }
            }
            public void lampotila()
            {
                Console.WriteLine("Lämpötila on {0} astetta", Lampotila);
            }
            public void aika()
            {
                if (Aika > 0)
                {
                    int tunnit = Aika / 60;
                    int minuutit = Aika % 60;
                    Console.WriteLine("Ohjelman kesto on {0} tuntia ja {1} minuuttia ", tunnit, minuutit);
                }
                else
                {
                    Console.WriteLine("Aikaa ei asetettu ohjelma sammuu");
                    Console.Clear();
                }
            }
            public void pesuaine()
            {
                Console.WriteLine("Annoit pesuainetta {0} millilitraa",Pesuaine);
            }
            public void ohjelma()
            {
                if (Ohjelma == 1)
                {
                    Console.WriteLine("Pesuohjelma käynnistetty.");
                }
                else
                {
                    Console.WriteLine("Pesuohjelma Pysähtyi.");
                }
            }
        }
        public class TV
        {
            public int Virta { get; set; }
            public int Kanava { get; set; }
            public int Aanenvoimakkuus { get; set; }

            public void virta()
            {
                if (Virta == 1)
                {
                    Console.WriteLine("TV on Päällä");
                }
                else
                {
                    Console.WriteLine("...........Epämääräistä siritystä");
                }
            }
            public void kanava()
            {
                Console.WriteLine("Kanava vaihtui ohjelmapaikalle {0}", Kanava);
            }
            public void aanenvoimakkuus()
            {
                if (Aanenvoimakkuus < 0)
                {
                    Console.WriteLine("ÄÄnenvoimakkuus pienenee {0} yksikköä", Aanenvoimakkuus);
                }
                if (Aanenvoimakkuus > 0)
                {
                    Console.WriteLine("ÄÄnenvoimakkuus nousee {0} yksikköä",Aanenvoimakkuus);
                }
            }
        }
        public class Vehicle
        {
            public string Name { get; set; }
            public int Speed { get; set; }
            public int Tyres { get; set; }
            public string name()
            {
                return Name;
            }
            public int speed()
            {
                return Speed;
            }
            public int tyres()
            {
                return Tyres;
            }
            public void PrintData()
            {
                Console.WriteLine("Nimi = {0}", Name);
                Console.WriteLine("Nopeus = {0}", Speed);
                Console.WriteLine("renkaat = {0}", Tyres);
            }
            public Tuple<string, int , int> ToString()
            {
                return Tuple.Create(Name, Speed, Tyres);
            }
        }
    }
}
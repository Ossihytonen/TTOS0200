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
            public Kiuas(int Lampotila, int Virta, int Kosteus) : base()
            {
                this.Virta = Virta;
                this.Lampotila = Lampotila;
                this.Kosteus = Kosteus;
            }
            public Kiuas()
            {
            }
        }
        public class KiuasKaytto
        {
            public static void TestaaKiuas()
            {
                do
                {
                Kiuas OssinKiuas = new Kiuas();
                Console.WriteLine("Pidetäänkö kiukaassa virta vai ei ?? 1 = päälle, Muu = poispäältä");
                OssinKiuas.Virta = int.Parse(Console.ReadLine());
                Console.Clear();
                if (OssinKiuas.Virta == 1)
                {
                    Console.WriteLine("Mihin lämpötilaan haluat kiukaan nostaa ? >>");
                    OssinKiuas.Lampotila = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Kiukaan teho on nyt " + OssinKiuas.Lampotila);
                    Console.WriteLine("Anna kosteus prosentti. (0-100)");
                    OssinKiuas.Kosteus = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Kiukaan kosteus on nyt " + OssinKiuas.Kosteus);
                }
                else
                {
                    Console.WriteLine("Kiuas on pois päältä");
                        break;
                }
                } while (true);
            }
        }
        public class Pesukone
        {
            public int Virta { get; set; }
            public int Lampotila { get; set; }
            public int Aika { get; set; }
            public int Pesuaine { get; set; }
            public int Ohjelma { get; set; }
            public Pesukone(int Virta, int Lampotila, int Aika, int Pesuaine) : base()
            {
                this.Virta = 0;
                this.Lampotila = Lampotila;
                this.Aika = Aika;
                this.Pesuaine = Pesuaine;
                this.Ohjelma = Ohjelma;
            }
            public Pesukone()
            {
            }
        }
        public class PesukoneKaytto
        {
            public static void TestaaPesukone()
            {
                do
                {
                    Pesukone OssinPesukone = new Pesukone();
                    Console.WriteLine("Pestäänko pyykkia ?? 1 = Pestään, 0 = ei pestä");
                    OssinPesukone.Virta = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (OssinPesukone.Virta == 1)
                    {
                        Console.WriteLine("Syötä lämpötila >>");
                        OssinPesukone.Lampotila = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Pesukoneen lämpötila on asetettu " + OssinPesukone.Lampotila + " asteeseen");
                        Console.WriteLine("Syötä pesuohjelman kesto >>");
                        OssinPesukone.Aika = int.Parse(Console.ReadLine());
                        int Tunnit = OssinPesukone.Aika / 60;
                        int Minuutit = OssinPesukone.Aika % 60;
                        Console.WriteLine("Syötä pesuaineen määrä (ml) >>");
                        OssinPesukone.Pesuaine = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Pesukoneen lämpötila on asetettu " + OssinPesukone.Lampotila + " asteeseen");
                        Console.WriteLine("Pesuohjelman Kesto on " + Tunnit + " tuntia ja " + Minuutit + " minuuttia ");
                        Console.WriteLine("Pesuainetta syötetty " + OssinPesukone.Pesuaine + " ml");
                        Console.WriteLine("Käynnistetäänkö pesuohjelma?(1/0) >> ");
                        OssinPesukone.Ohjelma = int.Parse(Console.ReadLine());
                        if (OssinPesukone.Ohjelma == 1)
                        {
                            Console.WriteLine("Pyykki pesty");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Pesuohjelma sammutettiin");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pesukone pois päältä");
                        break;
                    }
                } while (true);
            }
        }
        public class TV
        {
            public int Virta { get; set; }
            public int Kanava { get; set; }
            public int Aanenvoimakkuus { get; set; }
            public TV(int virta, int kanava, int aanenvoimakkuus) : base()
            {
                this.Virta = virta;
                this.Kanava = kanava;
                this.Aanenvoimakkuus = aanenvoimakkuus;
            }
            public TV()
            {
            }
        }
        public class TVkaytto
        {
            
        }
    }
}
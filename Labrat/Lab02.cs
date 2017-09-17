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
    }
}
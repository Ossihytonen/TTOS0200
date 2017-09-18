using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lab02.Kiuas uus = new Lab02.Kiuas();

            Console.WriteLine("Onko kiuas päällä (1/0)? >>");
            uus.Virta = int.Parse(Console.ReadLine());
            uus.virta();
            Console.WriteLine("Anna kiukaan lämpötila >>");
            uus.Lampotila = int.Parse(Console.ReadLine());
            uus.lampotila();
            Console.WriteLine("Kuinka monta kertaa kiukaalle heitetään vettä ? >>");
            uus.Kosteus = int.Parse(Console.ReadLine());
            uus.kosteus();*/

            /*Lab02.Pesukone uus = new Lab02.Pesukone();

            Console.WriteLine("Onko Pesukone päällä (1/0)? >>");
            uus.Virta = int.Parse(Console.ReadLine());
            uus.virta();
            Console.WriteLine("Anna Pesu lämpötila >>");
            uus.Lampotila = int.Parse(Console.ReadLine());
            uus.lampotila();
            Console.WriteLine("Kuinka Pitkän ohjelman haluat (min) ? >>");
            uus.Aika = int.Parse(Console.ReadLine());
            uus.aika();
            Console.WriteLine("Kuinka paljon laitetaaan pesuainetta (ml) ? >>");
            uus.Pesuaine = int.Parse(Console.ReadLine());
            uus.pesuaine();
            Console.WriteLine("Käynnistetäänkö pesuohjelma (1/0) ? >>");
            uus.Ohjelma = int.Parse(Console.ReadLine());
            uus.ohjelma();*/

            /*Lab02.TV uus = new Lab02.TV();

            Console.WriteLine("Laitetaanko TV päälle (1/0)? >>");
            uus.Virta = int.Parse(Console.ReadLine());
            uus.virta();
            Console.WriteLine("Anna kanava >>");
            uus.Kanava = int.Parse(Console.ReadLine());
            uus.kanava();
            Console.WriteLine("Muutetaanko äänenvoimakkuutta (-1 niin pienenee +1 niin suurenee) ? >>");
            uus.Aanenvoimakkuus = int.Parse(Console.ReadLine());
            uus.aanenvoimakkuus();*/

            Lab02.Vehicle uus = new Lab02.Vehicle();

            uus.Name = "Audi";
            uus.Speed = 300;
            uus.Tyres = 2144;
            Console.WriteLine(uus.name());
            Console.WriteLine(uus.speed());
            Console.WriteLine(uus.tyres());
            uus.PrintData();
            Console.WriteLine(uus.ToString());

        }
    }
}
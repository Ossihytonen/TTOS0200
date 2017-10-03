using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko40
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjahyllyssa.Kirja kirja = new Kirjahyllyssa.Kirja();
            kirja.Name = "Kukkia ja mehiläisiä";
            kirja.Producer = "Otava";
            kirja.ProductionYear = 2000;
            kirja.Price = 20;
            Console.WriteLine(kirja.ToString());
            Kirjahyllyssa.Kirja lehti = new Kirjahyllyssa.Kirja();
            lehti.Name = "Iltasanomat";
            lehti.Producer = "Alma";
            lehti.ProductionYear = 2017;
            lehti.Price = 2;
            Console.WriteLine(lehti.ToString());
            
        }
    }
}

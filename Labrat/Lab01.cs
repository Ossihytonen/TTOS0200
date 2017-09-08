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
    }
}

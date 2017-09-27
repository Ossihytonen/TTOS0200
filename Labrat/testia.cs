using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Vahvistin2
    {
        private readonly int Maxvolume = 100;
        private readonly int Minvolume = 0;
        public string viesti;
        public string Viesti
        {
            get { return viesti; }
        }

        private int volume;
        public bool SaadaAanenvoimakkuutta(int arvo)
        {
            if (arvo >= Minvolume && arvo <= Maxvolume)
            {
                viesti = "Volyymit annetulla välillä";
                volume = arvo;
                return true;
            } 
            else
            {
                viesti = "volyymit ei annetulla väilii";
                return false;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Maxvolume && value >= Minvolume) volume = value;
                else if (value > Maxvolume)
                {
                    Console.WriteLine("Ikkunat paukkuu, laita hiljemmallee :D");
                    volume = Maxvolume;
                }
                else if (value < Minvolume)
                {
                    Console.WriteLine("Ootko mies vai hiiri? Laita kovemmallee :D");
                    volume = Minvolume;
                }
            }
        }
    }
    class TestaaVahvari
    {
        static void saks(string[] arg)
        {
            Vahvistin2 sony = new Vahvistin2();
            /*sony.Volume = 50;
            Console.WriteLine(sony.Volume);
            sony.volume = 5550;
            Console.WriteLine(sony.Volume);*/
            if (sony.SaadaAanenvoimakkuutta(22))
                Console.WriteLine("volumit"+sony.Volume);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK_Sovellus
{
    public class AMK
    {
        public string Ammattikoulu { get; set; }
        public List<Tutkinto> Tutkinnot { get; set; }
        public string TutkinnonNimi { get; set; }
        public AMK(string ammattikoulu/*, string tutkinnonnimi*/)
        {
            Ammattikoulu = ammattikoulu;
            //TutkinnonNimi = tutkinnonnimi;
            //Tutkinnot = new List<Tutkinto>();
            Tutkinnot.Add(new Tutkinto(TutkinnonNimi));
        }
        public static void HaeTutkinnot()
        {
            foreach (var tutkinto in Tutkinnot)
            {
                Console.WriteLine(tutkinto.TutkinnonNimi);
            }

        }

        static void Main(string[] args)
        {
            AMK jamk = new AMK("jamk");
            jamk.Tutkinnot.Add = "";
            AMK.HaeTutkinnot();
            Tutkinto.HaeOpintojaksot();

        }
        
    }
    public class Tutkinto
    {
        
        public string TutkinnonNimi { get; set; }
        public List<Opintojakso> Opintojaksot { get; set; }
        public Tutkinto(string tutkinto)
        {
            TutkinnonNimi = tutkinto;
            Opintojaksot = new List<Opintojakso>();
            Opintojaksot.Add(new Tutkinto(TutkinnonNimi));
        }

        public static void HaeOpintojaksot()
        {
            foreach (var opintojakso in Opintojaksot)
            {
                Console.WriteLine(opintojakso.OpintojaksonNimi);
            }

        }
    }
    public class Opintojakso
    {
        public string OpintojaksonNimi { get; set; }
        public List<Opettaja> OpintojaksonOpettaja { get; set; }
        public List<Opiskelija> OpintojaksonOpiskelijat { get; set; }
        public Opintojakso(string opintojaksonnimi)
        {
            OpintojaksonNimi = opintojaksonnimi;
        }
        public void Haehenkilöt()
        {
            Console.WriteLine(OpintojaksonOpettaja);
            foreach (var opiskelijat in OpintojaksonOpiskelijat)
            {
                Console.WriteLine(opiskelijat.Name);
            }

        }

    }
    public class Opettaja
    {
        public string Name { get; set; }
    }
    public class Opiskelija
    {
        public string Name { get; set; }
    }
}

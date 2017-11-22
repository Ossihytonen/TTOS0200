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
        public AMK(string ammattikoulu)
        {
            Ammattikoulu = ammattikoulu;
            Tutkinnot = new List<Tutkinto>();
        }
        public override string ToString()
        {
            string s = "";
            foreach (var tutkinto in Tutkinnot)
            {
                s += tutkinto.TutkinnonNimi + " \n";
            }
            return s;
        }

        static void Main(string[] args)
        {
            Opiskelija op1 = new Opiskelija("Matti EEEE");
            Opiskelija op2 = new Opiskelija("Matti AAAA");
            Opiskelija op3 = new Opiskelija("Matti BBBB");
            Opiskelija op4 = new Opiskelija("Matti CCCC");
            Opiskelija op5 = new Opiskelija("Likka EEEE");
            Opiskelija op6 = new Opiskelija("Likka AAAA");
            Opiskelija op7 = new Opiskelija("Likka BBBB");
            Opiskelija op8 = new Opiskelija("Likka CCCC");
            Opiskelija op9 = new Opiskelija("Teppo EEEE");
            Opiskelija op10 = new Opiskelija("Teppo AAAA");
            Opiskelija op11 = new Opiskelija("Teppo BBBB");
            Opiskelija op12 = new Opiskelija("Teppo CCCC");

            Opettaja ope1 = new Opettaja("Matti Ope");
            Opettaja ope2 = new Opettaja("Matti Ope");
            Opettaja ope3 = new Opettaja("Matti Ope");
            Opettaja ope4 = new Opettaja("Matti Ope");
            Opettaja ope5 = new Opettaja("Matti Ope");

            Opintojakso opint1 = new Opintojakso("Windows serverit");
            Opintojakso opint2 = new Opintojakso("Linux serverit");
            Opintojakso opint3 = new Opintojakso("Viestintä");
            Opintojakso opint4 = new Opintojakso("Rakentaminen");
            Opintojakso opint5 = new Opintojakso("Hoitaminen");

            Tutkinto tut1 = new Tutkinto("Tieto ja viestintätekniikka");
            Tutkinto tut2 = new Tutkinto("Rakennustekniikka YAMK");
            Tutkinto tut3 = new Tutkinto("Hoitotyö");

            AMK jamk = new AMK("jamk");
            AMK jyamk = new AMK("jyamk");

            Console.WriteLine("--------Ammattikorkeakoulun {0} rekisteri--------", jamk.Ammattikoulu);
            Console.WriteLine("--------Tutkintohaarat--------");
            Console.WriteLine(jamk.Ammattikoulu);
            Console.WriteLine(jyamk.Ammattikoulu);

            jamk.Tutkinnot.Add(tut1);
            jamk.Tutkinnot.Add(tut2);
            jamk.Tutkinnot.Add(tut3);
            Console.WriteLine("--------Tutkinnot Ammattikorkeakoulussa {0}--------", jamk.Ammattikoulu);
            Console.WriteLine(jamk.ToString());
            Console.WriteLine("--------Tutkinnot Ammattikorkeakoulussa {0}--------", jyamk.Ammattikoulu);
            Console.WriteLine(jyamk.ToString());

            tut1.Opintojaksot.Add(opint1);
            tut1.Opintojaksot.Add(opint2);
            tut1.Opintojaksot.Add(opint3);
            tut2.Opintojaksot.Add(opint4);
            tut3.Opintojaksot.Add(opint5);
            Console.WriteLine("--------Opintojaksot tutkinnossa {0}--------", tut1.TutkinnonNimi);
            Console.WriteLine(tut1.ToString());
            Console.WriteLine("--------Opintojaksot tutkinnossa {0}--------", tut2.TutkinnonNimi);
            Console.WriteLine(tut2.ToString());
            Console.WriteLine("--------Opintojaksot tutkinnossa {0}--------", tut3.TutkinnonNimi);
            Console.WriteLine(tut3.ToString());

            opint1.OpintojaksonOpiskelijat.Add(op1);
            opint1.OpintojaksonOpiskelijat.Add(op2);
            opint1.OpintojaksonOpiskelijat.Add(op3);
            opint1.OpintojaksonOpiskelijat.Add(op4);
            opint1.OpintojaksonOpiskelijat.Add(op4);
            opint2.OpintojaksonOpiskelijat.Add(op5);
            opint2.OpintojaksonOpiskelijat.Add(op6);
            opint2.OpintojaksonOpiskelijat.Add(op7);
            opint2.OpintojaksonOpiskelijat.Add(op8);
            opint1.OpintojaksonOpettaja.Add(ope1);
            opint2.OpintojaksonOpettaja.Add(ope1);
            Console.WriteLine("--------Opintojaksolla {2} olevat opiskelijat {0} ja opettajat {1} --------", opint1.OpintojaksonOpiskelijat.Count, opint1.OpintojaksonOpettaja.Count, opint1.OpintojaksonNimi);
            Console.WriteLine(opint1.ToString());
            Console.WriteLine("--------Opintojaksolla {2} olevat opiskelijat {0} ja opettajat {1} --------", opint2.OpintojaksonOpiskelijat.Count, opint2.OpintojaksonOpettaja.Count, opint2.OpintojaksonNimi);
            Console.WriteLine(opint2.ToString());
            Console.WriteLine("--------Opintojaksolla {2} olevat opiskelijat {0} ja opettajat {1} --------", opint3.OpintojaksonOpiskelijat.Count, opint3.OpintojaksonOpettaja.Count, opint3.OpintojaksonNimi);
            Console.WriteLine(opint3.ToString());


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
        }

        public override string ToString()
        {
            string s = "";
            foreach (var tutkinto in Opintojaksot)
            {
                s += tutkinto.OpintojaksonNimi + " \n";
            }
            return s;
        }
    }
    public class Opintojakso
    {
        public string OpintojaksonNimi { get; set; }
        public List<Opettaja> OpintojaksonOpettaja { get; set; }
        public List<Opiskelija> OpintojaksonOpiskelijat { get; set; }
        //Maara laskee kuinka monta Opiskelijaa lisätään opintojaksoon
        private static int Maara = 0;
        public Opintojakso(string opintojaksonnimi)
        {
            OpintojaksonNimi = opintojaksonnimi;
            OpintojaksonOpiskelijat = new List<Opiskelija>();
            OpintojaksonOpettaja = new List<Opettaja>();
        }
        public override string ToString()
        {
            string s = " \n|| Opintojakson opiskelijat: ";
            foreach (var opiskelija in OpintojaksonOpiskelijat)
            {
                s += opiskelija.Nimi + " ,";
                ++Maara;
            }
            s += " \n|| Opintojakson opettaja: ";
            foreach (var ope in OpintojaksonOpettaja)
            {
                s += ope.OpNimi + " ,";
            }
            s += " \n|| Opintojaksolla on "+Maara+" Opiskelijaa";
            Maara = 0;
            return s;
        }
    }
    public class Opettaja
    {
        public string OpNimi { get; set; }
        public Opettaja(string opnimi)
        {
            OpNimi = opnimi;
        }
    }
    public class Opiskelija
    {
        
        public string Nimi { get; set; }
        public static int OpiskMaara = 0;
        public Opiskelija(string nimi)
        {
            Nimi = nimi;
            ++OpiskMaara;
        }
        //Laskee kuinka monta opiskelija oliota on yhteensä tehty
        public static int Montako()
        {
            return OpiskMaara;
        }

    }
}

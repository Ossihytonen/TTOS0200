using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra11._3
{
    public abstract class Lottery
    {
        public abstract string PelinNimi { get; }
        public Random rng = new Random();
        public List<int> ArvotutNumerot = new List<int>();
        //mahdolliset lisänumerot
        public List<int> Lisanumerot = new List<int>();
        public abstract void Arvonta();

        public string Tulostus()
        {
            ArvotutNumerot.Sort();
            string s = "";
            foreach (int i in ArvotutNumerot)
            {
                s += i.ToString() + ", ";
            }
            if (PelinNimi == "Eurojackpot")
            {
                s += "|| Lisänumerot: ";
                foreach (int i in Lisanumerot)
                {
                    s += i.ToString() + ", ";
                }
            }
            return s;
        }
    }
    public class Lotto : Lottery
    {
        public override string PelinNimi { get { return "Lotto"; } }
        public override void Arvonta()
        {
            ArvotutNumerot.Clear();
            ArvotutNumerot = Enumerable.Range(1, 39 + 1).OrderBy(x => rng.Next()).Take(7).ToList();


        }
        public override string ToString()
        {
            return PelinNimi;
        }
    }
    public class Vikinglotto : Lottery
    {
        public override string PelinNimi { get { return "Vikinglotto"; } }
        public override void Arvonta()
        {
            ArvotutNumerot.Clear();
            ArvotutNumerot = Enumerable.Range(1, 48 + 1).OrderBy(x => rng.Next()).Take(6).ToList();
            
        }
        public override string ToString()
        {
            return PelinNimi;
        }
    }
    public class Eurojackpot : Lottery
    {
        public override string PelinNimi { get { return "Eurojackpot"; } }
        public override void Arvonta()
        {
            ArvotutNumerot.Clear();
            Lisanumerot = Enumerable.Range(1, 11).OrderBy(x => rng.Next()).Take(2).ToList();
            ArvotutNumerot = Enumerable.Range(1, 50 + 1).OrderBy(x => rng.Next()).Take(5).ToList();
        }
        public override string ToString()
        {
            return PelinNimi;
        }
    }
}

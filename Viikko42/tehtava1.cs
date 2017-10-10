using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko42
{
    class tehtava1
    {
        public static void TestClass()
        {
            Kulkuneuvo auto = new Kulkuneuvo();

            auto.Model = "t68";
            auto.Name = "Lada";
            auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R16"));
            auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R17"));
            auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R18"));
            auto.Renkaat.Add(new Rengas("Nokia", "Hakkapeliitta", "205R19"));

            Console.WriteLine(auto.ToString());

            Kulkuneuvo bike = new Kulkuneuvo();

            bike.Model = "Cr";
            bike.Name = "Honda";
            bike.Renkaat.Add(new Rengas("MIC", "Pilot", "120R14"));
            bike.Renkaat.Add(new Rengas("MIC", "Pilot", "120R14"));

            Console.WriteLine(bike.ToString());
        }
        public class Rengas
        {
            public string TyreModel { get; set; }
            public string Type { get; set; }
            public string Size { get; set; }
            public Rengas()
            {

            }
            public Rengas(string tmodel, string type, string size)
            {
                TyreModel = tmodel;
                Type = type;
                Size = size;
            }
            public override string ToString()
            {
                return "Name: " + TyreModel + " Type: "+ Type + " Size: " + Size + " ";
            }
        }
        public class Kulkuneuvo
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public List<Rengas> Renkaat;
            public Kulkuneuvo()
            {
                Renkaat = new List<Rengas>();
            }
            public override string ToString()
            {
                string retval = "Model: " + Model + " Name: " + Name + "\n";
                foreach (Rengas item in Renkaat)
                {
                    retval += item.ToString() + "\n";
                }
                return retval;
            }
        }
    }
}

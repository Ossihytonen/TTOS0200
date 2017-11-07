using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44
{
    /*public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float VoittoPros;
    }*/
    class Program
    {
        /*static void LueOhjastajatVer2()
        {
            try
            {
                //Luetaan CSV-tiedostosta tiedot ja tallennetaan structeihin
                string erotin = ";";
                //luetaan kaikki rivit muuttujaan
                string[] rivit = System.IO.File.ReadAllLines("tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteensä {0}", lkm - 1);
                //käydään muistiin kirjoitetut rivit läpi
                for (int i = 1; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (int.TryParse(sanat[2], out int apu))
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                        Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}",i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.VoittoPros);
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1]+" "+ sanat[2];
                        kuski.Startit = int.Parse(sanat[3]);
                        kuski.Voitot = int.Parse(sanat[4]);
                        kuski.VoittoPros = (100F * kuski.Voitot / kuski.Startit);
                        Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}",i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.VoittoPros);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void LueOhjastajatVer1()
        {
            try
            {
                int counter = 1;
                string line;
                System.IO.StreamReader stream = new System.IO.StreamReader(@"doc1.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ":" + line);
                    counter++;
                }
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
        static void Main(string[] args)
        {
            try
            {
                Noppa noppa = new Noppa();
                Console.WriteLine("How many times you want to throw a dice?: ");
                int throwamount = int.Parse(Console.ReadLine());
                noppa.Throw(throwamount);
                Console.WriteLine("Average: " + noppa.Throws.Average());
                for (int x = 1; x < 7; x++)
                {
                    int count = 0;
                    foreach (int i in noppa.Throws)
                    {
                        if (i == x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0} count is: {1}", x, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //-----------------------------------------------------------------------------------------------s
            /*List<Product> Ostoskarryt = new List<Product>();
            Ostoskarryt.Add(new Product("Milk", "1.4"));
            Ostoskarryt.Add(new Product("Yoghurt", "0.8"));
            Ostoskarryt.Add(new Product("Juice", "2.5"));
            Console.WriteLine("All products in collection: ");
            foreach (Product asia in Ostoskarryt)
            {
                Console.WriteLine("-product: {0} {1}e", asia.Tuote, asia.Hinta);
            }*/
            //------------------------------------------------------------------------------------------------¤
            /*try
            {
                List<Shape> list = new List<Shape>();
                list.Add(new Circle("Ympyrä ", 5));
                list.Add(new Rectangle("Suorakulmio ", 4, 6));
                list.Add(new Circle("Ympyrä ", 8));
                list.Add(new Rectangle("Suorakulmio ", 3, 70));

                foreach (Shape kappale in list)
                {
                    Console.WriteLine(kappale.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            /*double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            ArrayCalcs.Sum1(array);
            ArrayCalcs.Ave(array);
            ArrayCalcs.Maximi(array);
            ArrayCalcs.Minimi(array);*/
        }
    }
}

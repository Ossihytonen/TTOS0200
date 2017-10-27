using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko43
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float numero;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\temp.txt";
                //kirjoitetaan käyttäjän antamat rivit tiedostoon
                //Luodaan streamWriter tyyppinne olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero > 4)
                    {
                        sw.WriteLine(numero + "\n");
                    }
                } while (numero>9000);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*string filu = @"nimet.txt";
            try
            {
                if (File.Exists(filu))
                {
                    string[] l2 = System.IO.File.ReadAllLines(filu);
                    var maara = l2.ToList();
                    maara.Sort();
                    var a = maara.GroupBy(i => i).ToList();
                    Console.WriteLine("Rivien määrä on " + maara.Count);
                    Console.WriteLine("Nimien määrä on " + a.Count);
                    foreach (var nimi in a)
                    {
                        Console.WriteLine("Nimi " + nimi.Key + " esiintyi " + nimi.Count() + " kertaa");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Tiedostoa ei ole tai on muuta ongelmaa");
            }*/
            /*//KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\temp.txt";
                //kirjoitetaan käyttäjän antamat rivit tiedostoon
                //Luodaan streamWriter tyyppinne olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa): ");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään konsolissa
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}

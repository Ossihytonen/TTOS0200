using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Viikko43
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /*List<Ohjelmisto> uusiohjelmisto = new List<Ohjelmisto>();
                uusiohjelmisto.Add(new Ohjelmisto { Kanava = "2", OhjelmanNimi = "Pikkukakkonen", AlkuAika = "17:00", Loppuaika = "18:00", Info = "Lastenohjelma tarkoitettu lapsille. Ransu viihdyttää." });
                uusiohjelmisto.Add(new Ohjelmisto { Kanava = "3", OhjelmanNimi = "Vain Elämää", AlkuAika = "20:00", Loppuaika = "22:00", Info = "Aikuisten ohjelma, jossa itketään." });

                // create a file for ohjelmat
                Stream writeMultipleStream = new FileStream("MyPersons.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                // write persons array to disk, note: uses formatter using System.Runtime.Serialization.OssiyHytönen;
                //using System.Runtime.Serialization.Formatters.Binary;
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeMultipleStream, uusiohjelmisto);
                // close file
                writeMultipleStream.Close();

                // create stream for reading ohjelmat
                Stream openStream = new FileStream("MyPersons.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                // create a list and read ohjelmat into it from disk
                List<Ohjelmisto> readUusiohjelmisto = (List<Ohjelmisto>)formatter.Deserialize(openStream);
                // close stream
                openStream.Close();

                // Näyttäminen
                foreach (Ohjelmisto o in readUusiohjelmisto)
                {
                    Console.WriteLine("......................................");
                    Console.WriteLine("Kanavalla: {0} \nOhjelma: {1} \nAlkuaika: {2} \nLoppuaika: {3} \nInfo: {4} ", o.Kanava, o.OhjelmanNimi, o.AlkuAika, o.Loppuaika, o.Info);
                }


                *//*{

                    try
                    {
                        System.IO.StreamWriter KokoLuku = new System.IO.StreamWriter("Koko.txt");
                        System.IO.StreamWriter RealLuku = new System.IO.StreamWriter("Real.txt");
                        double i;
                        int j;
                        string luku;

                        do
                        {
                            Console.WriteLine("Give a number (enter or not a number ends) : ");
                            luku = Console.ReadLine();
                            if (int.TryParse(luku, out j))
                            {
                                KokoLuku.WriteLine(luku);
                            }
                            else if (Double.TryParse(luku, out i))
                            {
                                RealLuku.WriteLine(luku);
                            }
                            else
                            {
                                Console.WriteLine("Lopetetaan");
                                break;
                            }
                        }

                        while (Double.TryParse(luku, out i) || int.TryParse(luku, out j));
                        KokoLuku.Close();
                        RealLuku.Close();

                        Console.WriteLine("Contents of Koko.txt");
                        string text1 = System.IO.File.ReadAllText(@"Koko.txt");
                        System.Console.WriteLine(text1);

                        Console.WriteLine("Contents of Real.txt");
                        string text2 = System.IO.File.ReadAllText(@"Real.txt");
                        System.Console.WriteLine(text2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ilmeni seuraava virhe" + ex);
                    }

                }*/

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

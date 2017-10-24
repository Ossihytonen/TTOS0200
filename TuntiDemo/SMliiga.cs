using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Pelaaja
    {
        #region PROPERTIES
        public int ID { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Kätisyys { get; set; }
        public int PeliNumero { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Pelaaja()
        { }
        public Pelaaja(int id, string etunimi,string sukunimi, string kätisyys, int pelinumero)
        {
            ID = id;
            Etunimi= etunimi;
            Sukunimi = sukunimi;
            Kätisyys = kätisyys;
            PeliNumero = pelinumero;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Format("ID: {4} |Pelaaja :{0} {1} |Kätisyys: {2} |Pelinumero: {3}\n", Etunimi, Sukunimi, Kätisyys, PeliNumero, ID);
        }
        #endregion
    }
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> pelaajat;
        public Joukkue(string nimi, string kotikaupunki)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            pelaajat = new List<Pelaaja>();
        }
        public override string ToString()
        {
            return Nimi + " " + Kotikaupunki;
        }


    }
}

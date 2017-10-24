using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Korttipakka
    {
        #region PROPERTIES
        public string Maa { get; set; }
        public int Luku { get; set; }

        #endregion

        #region CONSTRUCTORS
        public Korttipakka()
        { }
        public Korttipakka(string maa, int luku, int paikka)
        {
            Maa = maa;
            Luku = luku;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1}", Maa, Luku);
        }
        #endregion
    }
}

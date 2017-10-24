using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class CD
    {
        #region PROPERTIES
        public string LevynNimi { get; set; }
        public string Artisti { get; set; }
        public string Biisit { get; set; }
        public string Kesto { get; set; }

        #endregion

        #region CONSTRUCTORS
        public CD()
        { }
        public CD(string levynnimi, string artisti)
        {
            LevynNimi = levynnimi;
            Artisti = artisti;
        }
        public CD(string levynnimi, string artisti, string biisit) : this(levynnimi, artisti)
        {
            Biisit = biisit;
        }
        public CD(string levynnimi, string artisti, string biisit, string kesto) : this(levynnimi, artisti, biisit)
        {
            Kesto = kesto;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", LevynNimi, Artisti, Biisit, Kesto);
        }
        #endregion
    }
}

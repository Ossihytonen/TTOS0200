using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko43
{
    [Serializable]
    public class Ohjelmisto
    {
        #region PROPERTIES
        public string Kanava { get; set; }
        public string OhjelmanNimi { get; set; }
        public string AlkuAika { get; set; }
        public string Loppuaika { get; set; }
        public string Info { get; set; }

        #endregion

        #region CONSTRUCTORS
        public Ohjelmisto()
        { }
        public Ohjelmisto(string kanava, string ohjelmannimi, string alkuaika, string loppuaika, string info)
        {
            Kanava = kanava;
            OhjelmanNimi = ohjelmannimi;
            AlkuAika = alkuaika;
            Loppuaika = loppuaika;
            Info = info;
        }
        #endregion

        #region METHODS
        
        #endregion
    }
}

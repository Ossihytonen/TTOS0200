using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko44
{
    public class Product
    {
        public string Tuote { get; set; }
        public string Hinta { get; set; }

        public Product(string tuote, string hinta)
        {
            Hinta = hinta;
            Tuote = tuote;
        }
    }
}

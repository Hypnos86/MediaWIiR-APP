using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class HeatData
    {
        public decimal Heat { get; set; } //Ciepło i zmienna przesyl GJ
        public int Power { get; set; } // stala zmienna i zamowiona moc MW
        public int Month { get; set; } //Mc
        public int Carrier { get; set; } // Nośnik m3
    }
}

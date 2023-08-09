using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class GasData
    {
        public string Tariff { get; set; }
        public int Gas { get; set; }
        public int Month { get; set; }
        public int Power { get; set; }
        public decimal Conversion { get; set; }
    }
}

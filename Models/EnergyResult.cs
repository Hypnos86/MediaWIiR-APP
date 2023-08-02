using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class EnergyResult: EnergyTariff
    {
        public decimal SumNettoOsd { get; set; }
        public decimal SumBruttoOsd { get; set; }
        public decimal SumNettoSell { get; set; }
        public decimal SumBruttoSell { get; set; }
        public int SumKwh { get; set; }
    }
}

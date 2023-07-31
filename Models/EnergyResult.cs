using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class EnergyResult: EnergyTariff
    {
        public decimal SumNetto { get; set; }
        public decimal SumVat { get; set; }
        public int SumKwh { get; set; }
    }
}

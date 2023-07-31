using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    internal class WaterResult: WaterTariff
    {
        public decimal SumNetto { get; set; }
        public decimal SumVat { get; set; }
        public int SumWater { get; set; }
    }
}

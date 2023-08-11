using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class GasResult : GasTariff
    {
        public decimal SumNetto { get; set; }
        public decimal SumBrutto { get; set; }
        public decimal SumKwh { get; set; }
        public decimal SumM3 { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class HeatResult: HeatTariff
    {
        public decimal SumNetto { get; set; }
        public decimal SumBrutto { get; set; }
        public int SumGj { get; set; }
    }
}

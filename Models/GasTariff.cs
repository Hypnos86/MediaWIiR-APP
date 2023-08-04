using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class GasTariff
    {
        public decimal Gas { get; set; }
        public decimal Subscribe { get; set; }
        public string Tariff { get; set; }
        public decimal FixedDistribution { get; set; }
        public decimal VariableDistribution { get; set; }
    }
}

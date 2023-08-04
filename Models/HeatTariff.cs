using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class HeatTariff
    { 
        public string Tariff { get; set; }
        public decimal HeatFee { get; set; }
        public decimal FixedShippingFee { get; set; }
        public decimal VariableShippingFee { get; set; }
        public decimal SubscriptionFee { get; set; }
        public decimal CarrerFee { get; set; }
        public decimal OrderedThermalPower { get; set; }
        public int VatValue { get; set; }
    }
}

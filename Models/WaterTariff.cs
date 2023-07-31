using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class WaterTariff
    {
        public string Tariff { get; set; } //taryfa
        public decimal Water { get; set; } //woda
        public decimal Sewage { get; set; } //ścieki
        public decimal SubscriptionWater { get; set; } //abonament woda
        public decimal SubscriptionSewage { get; set; } //abonament ścieki
        public int VatValue { get; set; } //vat
    }
}

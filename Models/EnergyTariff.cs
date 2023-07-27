using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    public class EnergyTariff
    {
        public string Tariff { get; set; } //taryfa
        public decimal FixedNetworkFee { get; set; } //opłata stała sieciowa
        public decimal TransitionFee { get; set; } //opłata przejściowa
        public decimal CapacirtFee { get; set; } //opłata mocowa
        public decimal NetworkVariableFee { get; set; } //opłata zmienna sieciowa
        public decimal QualityFee { get; set; } //opłata jakościowa
        public decimal RenewableEnergySourcesFee { get; set; } //opłata oze
        public decimal CogenerationFee { get; set; } //opłata kogeneracyjna
        public decimal SubscriptionFee { get; set; } //opłata abonamentowa
    }
}

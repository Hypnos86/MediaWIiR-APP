using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaWIiR_APP.Models
{
    internal class EnergyTariff
    {
        decimal FixedNetworkFee { get; set; } //opłata stała sieciowa
        decimal TransitionFee { get; set; } //opłata przejściowa
        decimal CapacirtFee { get; set; } //opłata mocowa
        decimal NetworkVariableFee { get; set; } //opłata zmienna sieciowa
        decimal QualityFee { get; set; } //opłata jakościowa
        decimal RenewableEnergySourcesFee { get; set; } //opłata oze
        decimal CogenerationFee { get; set; } //opłata kogeneracyjna
        decimal SubscriptionFee { get; set; } //opłata abonamentowa
    }
}

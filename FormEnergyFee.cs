using MediaWIiR_APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaWIiR_APP
{
    public partial class FormEnergyFee : Form
    {
        public FormEnergyFee(EnergyTariff energyTariff)
        {
            InitializeComponent();
            if (energyTariff != null)
            {
                tariff_input.Text = energyTariff.Tariff;
                fixed_network_fee_input.Text = energyTariff.FixedNetworkFee.ToString();
                transition_fee_input.Text = energyTariff.TransitionFee.ToString();
                capacirt_fee_input.Text = energyTariff.CapacirtFee.ToString();
                network_variable_fee_input.Text = energyTariff.NetworkVariableFee.ToString();
                quality_fee_input.Text = energyTariff.QualityFee.ToString();
                renewable_energy_sources_fee_input.Text = energyTariff.RenewableEnergySourcesFee.ToString();
                cogeneration_fee_input.Text = energyTariff.CogenerationFee.ToString();
                subscription_fee_input.Text = energyTariff.SubscriptionFee.ToString();
                vatComboBox.SelectedItem = energyTariff.VatValue.ToString();

            }
        }



        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_tariff_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();

            //bool tariff = service.validating_data_fee(tariff_input, tariff_error, out string tariff_value);
            bool fixed_network_fee = service.validating_data_fee(fixed_network_fee_input, fixed_network_error, out decimal fixed_network_fee_value);
            bool transition_fee = service.validating_data_fee(transition_fee_input, transation_error, out decimal transition_fee_value);
            bool capacirt_fee = service.validating_data_fee(capacirt_fee_input, capacirt_error, out decimal capacirt_fee_value);
            bool network_variable_fee = service.validating_data_fee(network_variable_fee_input, network_variable_error, out decimal network_variable_fee_value);
            bool quality_fee = service.validating_data_fee(quality_fee_input, quality_error, out decimal quality_fee_value);
            bool renewable_energy_sources_fee = service.validating_data_fee(renewable_energy_sources_fee_input, oze_error, out decimal renewable_energy_sources_fee_value);
            bool cogeneration_fee = service.validating_data_fee(cogeneration_fee_input, cogeneration_error, out decimal cogeneration_fee_value);
            bool subscription_fee = service.validating_data_fee(subscription_fee_input, subscription_error, out decimal subscription_fee_value);
            bool vat_fee = service.validating_selectors(vatComboBox, vat_error);

            if (fixed_network_fee && transition_fee && capacirt_fee && network_variable_fee && quality_fee && renewable_energy_sources_fee && cogeneration_fee && subscription_fee && vat_fee)
            {
                MainForm.EnergyTariff = new EnergyTariff();
                MainForm.EnergyTariff.Tariff = tariff_input.Text;
                MainForm.EnergyTariff.FixedNetworkFee = fixed_network_fee_value;
                MainForm.EnergyTariff.TransitionFee = transition_fee_value;
                MainForm.EnergyTariff.CogenerationFee = cogeneration_fee_value;
                MainForm.EnergyTariff.NetworkVariableFee = network_variable_fee_value;
                MainForm.EnergyTariff.QualityFee = quality_fee_value;
                MainForm.EnergyTariff.RenewableEnergySourcesFee = renewable_energy_sources_fee_value;
                MainForm.EnergyTariff.CapacirtFee = capacirt_fee_value;
                MainForm.EnergyTariff.SubscriptionFee = subscription_fee_value;
                MainForm.EnergyTariff.VatValue = Convert.ToInt32(vatComboBox.SelectedItem);

                MessageBox.Show("Dane zostałyzapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

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
    public partial class FormHeatFee : Form
    {
        public FormHeatFee(HeatTariff heatTariff)
        {
            InitializeComponent();
            if (heatTariff != null)
            {
                tariff_input.Text = heatTariff.Tariff.ToString();
                heat_fee_input.Text = heatTariff.HeatFee.ToString();
                fixed_shipping_fee_input.Text = heatTariff.FixedShippingFee.ToString();
                variable_shipping_fee_input.Text = heatTariff.VariableShippingFee.ToString();
                subscription_fee_input.Text = heatTariff.SubscriptionFee.ToString();
                carrer_fee_input.Text = heatTariff.CarrerFee.ToString();
                ordered_thermal_power_input.Text = heatTariff.OrderedThermalPower.ToString();
                vatComboBox.SelectedItem = heatTariff.VatValue.ToString();
            }
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();

            //bool tariff = service.validating_data_fee(tariff_input, tariff_error, out string tariff_value);
            bool heat_fee = service.validating_data_fee(heat_fee_input, heat_fee_error, out decimal heatFeeValue);
            bool fixed_shipping_fee = service.validating_data_fee(fixed_shipping_fee_input, fixed_shipping_fee_error, out decimal fixedShippingFeeValue);
            bool variable_shipping_fee = service.validating_data_fee(variable_shipping_fee_input, variable_shipping_fee_error, out decimal variableShippingFeeValue);
            bool subscription_fee = service.validating_data_fee(subscription_fee_input, subscription_fee_error, out decimal subscriptionFeeValue);
            bool carrer_fee = service.validating_data_fee(carrer_fee_input, carrer_fee_error, out decimal carrerFeeValue);
            bool ordered_thermal_power = service.validating_data_fee(ordered_thermal_power_input, ordered_thermal_power_error, out decimal orderedThermalPowerValue);
            bool vat = service.validating_selectors(vatComboBox, vat_error);


            if (heat_fee && fixed_shipping_fee && variable_shipping_fee && subscription_fee && carrer_fee && ordered_thermal_power && vat)
            {
                MainForm.HeatTariff = new HeatTariff();
                MainForm.HeatTariff.Tariff = tariff_input.Text;
                MainForm.HeatTariff.HeatFee = heatFeeValue;
                MainForm.HeatTariff.FixedShippingFee = fixedShippingFeeValue;
                MainForm.HeatTariff.VariableShippingFee = variableShippingFeeValue;
                MainForm.HeatTariff.SubscriptionFee = subscriptionFeeValue;
                MainForm.HeatTariff.CarrerFee = carrerFeeValue;
                MainForm.HeatTariff.OrderedThermalPower = orderedThermalPowerValue;
                MainForm.HeatTariff.VatValue = Convert.ToInt32(vatComboBox.SelectedItem);


                MessageBox.Show("Dane zostałyzapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}

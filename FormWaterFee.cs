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
    public partial class FormWaterFee : Form
    {
        public FormWaterFee(WaterTariff waterTariff)
        {
            InitializeComponent();
            if (waterTariff != null)
            {
                tariff_input.Text = waterTariff.Tariff.ToString();
                water_input.Text = waterTariff.Water.ToString();
                sewage_input.Text = waterTariff.Sewage.ToString();
                subscriptionSewage_input.Text = waterTariff.SubscriptionSewage.ToString();
                subscriptionWater_input.Text = waterTariff.SubscriptionWater.ToString();
                vat_input.SelectedItem = waterTariff.VatValue.ToString();
            }
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool water = service.validating_data_fee(water_input, water_error, out decimal waterValue);
            bool sewage = service.validating_data_fee(sewage_input, sewage_error, out decimal sewageValue);
            bool seubscribeWater = service.validating_data_fee(subscriptionWater_input, subscriptionWater_error, out decimal subscriptionWaterValue);
            bool subscribebeSewage = service.validating_data_fee(subscriptionSewage_input, subscriptionSewage_error, out decimal subscribeSewageValue);
            bool vat = service.validating_selectors(vat_input, vat_error);

            if (water && sewage && subscribebeSewage && seubscribeWater)
            {
                MainForm.WaterTariff = new WaterTariff();
                MainForm.WaterTariff.Tariff = tariff_input.Text;
                MainForm.WaterTariff.Water = waterValue;
                MainForm.WaterTariff.Sewage = sewageValue;
                MainForm.WaterTariff.SubscriptionSewage = subscribeSewageValue;
                MainForm.WaterTariff.SubscriptionWater = subscriptionWaterValue;
                MainForm.WaterTariff.VatValue = Convert.ToInt32(vat_input.SelectedItem);

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

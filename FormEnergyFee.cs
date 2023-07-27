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
        public FormEnergyFee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_tariff_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();

            //bool tariff = service.validating_data_fee(tariff_input, tariff_error, out decimal tariff_value);
            bool fixed_network_fee = service.validating_data_fee(fixed_network_fee_input, fixed_network_error, out decimal fixed_network_fee_value);
            bool transition_fee = service.validating_data_fee(transition_fee_input, transation_error, out decimal transition_fee_value);
            bool capacirt_fee = service.validating_data_fee(capacirt_fee_input, capacirt_error, out decimal capacirt_fee_value);
            bool network_variable_fee = service.validating_data_fee(network_variable_fee_input, network_variable_error, out decimal network_variable_fee_value);
            bool quality_fee = service.validating_data_fee(quality_fee_input, quality_error, out decimal quality_fee_value);
            bool renewable_energy_sources_fee = service.validating_data_fee(renewable_energy_sources_fee_input, oze_error, out decimal renewable_energy_sources_fee_value);
            bool cogeneration_fee = service.validating_data_fee(cogeneration_fee_input, cogeneration_error, out decimal cogeneration_fee_value);
            bool subscription_fee = service.validating_data_fee(subscription_fee_input, subscription_error, out decimal subscription_fee_value);

            if (fixed_network_fee && transition_fee && capacirt_fee && network_variable_fee && quality_fee && renewable_energy_sources_fee && cogeneration_fee && subscription_fee)
            {
                MessageBox.Show("Dane zostałyzapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

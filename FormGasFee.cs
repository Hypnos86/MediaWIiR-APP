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
    public partial class FormGasFee : Form
    {
        public FormGasFee(GasTariff gasTariff, GasData gasData)
        {
            InitializeComponent();
            if (gasTariff != null)
            {
                gasFeeInput.Text = gasTariff.Gas.ToString();
                subscribeFeeInput.Text = gasTariff.Subscribe.ToString();
                fixedDistributionFeeInput.Text = gasTariff.FixedDistribution.ToString();
                variableDistributionFeeInput.Text = gasTariff.VariableDistribution.ToString();
                vatComboBox.SelectedItem = gasTariff.VatValue.ToString();
            }

            if (gasData == null)
            {
                gasFeeInput.ReadOnly = true;
                gasFeeInput.PlaceholderText = "Wybież taryfę";
                subscribeFeeInput.ReadOnly = true;
                subscribeFeeInput.PlaceholderText = "Wbież taryfę";
                fixedDistributionFeeInput.ReadOnly = true;
                fixedDistributionFeeInput.PlaceholderText = "Wybież taryfę";
                variableDistributionFeeInput.ReadOnly = true;
                variableDistributionFeeInput.PlaceholderText = "Wybież taryfę";
                vatComboBox.Visible = false;
            }
            else if (gasData.Tariff != null && gasData.Tariff == "W-5")
            {

                tariffGroupBox.Text = string.Format("Dane taryfy {0}", gasData.Tariff.ToString());
                gasFeeLabel.Text = "Opłata za paliwo gazowe [zł]:";
                subscribeFeeLabel.Text = "Opłata abonamentowa - gaz [zł]:";
                fixedDistributionFeeLabel.Text = "Dystrybucja stała [gr]:";
                variableDistributionFeeLabel.Text = "Dystrybucja zmienna [gr]:";
            }
            else if (gasData.Tariff != null && gasData.Tariff != "W-5")
            {
                tariffGroupBox.Text = string.Format("Dane taryfy {0}", gasData.Tariff.ToString());
                gasFeeLabel.Text = "Opłata za paliwo gazowe [zł]:";
                subscribeFeeLabel.Text = "Opłata abonamentowa - gaz [zł]:";
                fixedDistributionFeeLabel.Text = "Dystrybucja stała [zł]:";
                variableDistributionFeeLabel.Text = "Dystrybucja zmienna [gr]:";
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool gas = service.validating_data_forms_decimal(gasFeeInput, gasError, out decimal gasValue);
            bool subscribe = service.validating_data_forms_decimal(subscribeFeeInput, subscribeFeeError, out decimal subscribeValue);
            bool fixedDistribution = service.validating_data_forms_decimal(fixedDistributionFeeInput, fixedDistributionFeeError, out decimal fixedDistributionValue);
            bool variableDistribution = service.validating_data_forms_decimal(variableDistributionFeeInput, variableDistributionFeeError, out decimal variableDistributionValue);
            bool vat = service.validating_selectors(vatComboBox, vatError);

            if (gas && subscribe && subscribe && fixedDistribution && variableDistribution && vat)
            {
                MainForm.GasTariff = new GasTariff();
                MainForm.GasTariff.Gas = gasValue;
                MainForm.GasTariff.Subscribe = subscribeValue;
                MainForm.GasTariff.FixedDistribution = fixedDistributionValue;
                MainForm.GasTariff.VariableDistribution = variableDistributionValue;
                MainForm.GasTariff.VatValue = Convert.ToInt32(vatComboBox.SelectedItem);
                MessageBox.Show("Dane zostałyzapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

using MediaWIiR_APP.Models;
using Microsoft.VisualBasic;
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
    public partial class FormGasData : Form
    {
        public FormGasData(GasData gasData)
        {
            InitializeComponent();
            if (gasData != null)
            {
                tariff_input.SelectedItem = gasData.Tariff.ToString();
                gas_input.Text = gasData.Gas.ToString();
                month_input.Text = gasData.Month.ToString();
                power_input.Text = gasData.Power.ToString();
                conversion_input.Text = gasData.Conversion.ToString();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            //tworzenie konstruktora dla serwisu
            Service service = new Service();

            //validacja pól pierwszych bez taryfy W-5
            bool tariff = service.validating_selectors(tariff_input, tariff_error);
            bool gas = service.validating_data_forms_int(gas_input, gas_error, out int gasValue);
            bool month = service.validating_data_forms_int(month_input, month_error, out int monthValue);

            //sprawdzanie czy wybrana taryfa to W-5
            if (tariff && tariff_input.SelectedItem.ToString() == "W-5")
            {
                bool power = service.validating_data_forms_int(power_input, power_error, out int powerValue);
                bool conversion = service.validating_data_forms_decimal(conversion_input, conversion_error, out decimal conversionValue);

                if (gas && month && power && conversion)
                {
                    MainForm.GasData = new GasData();
                    MainForm.GasData.Tariff = tariff_input.SelectedItem.ToString();
                    MainForm.GasData.Gas = gasValue;
                    MainForm.GasData.Month = monthValue;
                    MainForm.GasData.Power = powerValue;
                    MainForm.GasData.Conversion = conversionValue;

                    MessageBox.Show("Dane zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {   //warunek jesli wybrana taryfa to nie W-5
                if (gas && month)
                {
                    MainForm.GasData = new GasData();
                    MainForm.GasData.Tariff = tariff_input.SelectedItem.ToString();
                    MainForm.GasData.Gas = gasValue;
                    MainForm.GasData.Month = monthValue;

                    MessageBox.Show("Dane zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void tariff_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tariff_input.SelectedItem.ToString() == "W-5")
            {
                power_need_label.Visible = true;
                power_input.Visible = true;
                conversion_input.Visible = true;
                conversion_label.Visible = true;
            }
            else
            {
                power_need_label.Visible = false;
                power_input.Visible = false;
                conversion_input.Visible = false;
                conversion_label.Visible = false;
            }
        }
    }
}

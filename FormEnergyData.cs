using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaWIiR_APP.Models;

namespace MediaWIiR_APP
{
    public partial class FormEnergyData : Form
    {
        public FormEnergyData(EnergyData energyData)
        {

            InitializeComponent();
            if (energyData != null)
            {
                kwh_input.Text = energyData.Kwh.ToString();
                power_input.Text = energyData.Power.ToString();
                month_input.Text = energyData.Month.ToString();
            }


        }
        public void accept_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool kwh = service.validating_data_forms_int(kwh_input, text_error_kwh, out int kwhValue);
            bool power = service.validating_data_forms_int(power_input, text_error_power, out int powerValue);
            bool month = service.validating_data_forms_int(month_input, text_error_month, out int monthValue);

            if (kwh && power && month)
            {
                MainForm.EnergyData = new EnergyData();
                MainForm.EnergyData.Kwh = kwhValue;
                MainForm.EnergyData.Power = powerValue;
                MainForm.EnergyData.Month = monthValue;

                // Dane zostały wczytane do prywatnych pól, możemy je wykorzystać np. do zapisania do bazy danych
                // W tym przypadku wykorzystujemy tylko MessageBox do pokazania komunikatu
                MessageBox.Show("Dane zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            //zamkniecie okienka
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

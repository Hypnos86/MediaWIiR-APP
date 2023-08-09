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
    public partial class FormHeatData : Form
    {
        public FormHeatData(HeatData heatData)
        {
            InitializeComponent();
            if (heatData != null )
            {
                heat_input.Text = heatData.Heat.ToString();
                power_input.Text = heatData.Power.ToString();
                carrier_input.Text = heatData.Carrier.ToString();
                month_input.Text = heatData.Month.ToString();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool heat = service.validating_data_forms_decimal(heat_input, heat_error, out decimal heatValue);
            bool power = service.validating_data_forms_int(power_input, power_error, out int powerValue);
            bool carrer = service.validating_data_forms_int(carrier_input, carrer_error, out int carrerValue);
            bool month = service.validating_data_forms_int(month_input, mont_error, out int monthValue);

            if (heat && power && carrer && month)
            {
                MainForm.HeatData = new HeatData();
                MainForm.HeatData.Heat = heatValue;
                MainForm.HeatData.Power = powerValue;
                MainForm.HeatData.Carrier = carrerValue;
                MainForm.HeatData.Month = monthValue;

                // Dane zostały wczytane do prywatnych pól, możemy je wykorzystać np. do zapisania do bazy danych
                // W tym przypadku wykorzystujemy tylko MessageBox do pokazania komunikatu
                MessageBox.Show("Dane zostały zapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

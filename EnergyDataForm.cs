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
    public partial class EnergyDataForm : Form
    {
        public EnergyDataForm()
        {
            InitializeComponent();
        }

        private void kwh_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void month_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void power_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool kwh = service.validating_data_forms(kwh_input, text_error_kwh, out int kwh_value);
            bool power = service.validating_data_forms(power_input, text_error_power, out int power_value);
            bool month = service.validating_data_forms(month_input, text_error_month, out int month_value);

            if (kwh && power && month)
            {
                MessageBox.Show("Dane zostałyzapisane", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }


        private void cancel_button_Click(object sender, EventArgs e)
        {
            //zamkniecie okienka
            this.Close();
        }
    }
}

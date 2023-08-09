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
    public partial class FormWaterData : Form
    {
        public FormWaterData(WaterData waterData)
        {
            InitializeComponent();
            if (waterData != null)
            {
                water_input.Text = waterData.WaterAmount.ToString();
                month_input.Text = waterData.Month.ToString();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            bool water = service.validating_data_forms_int(water_input, water_error, out int waterAmountValue);
            bool month = service.validating_data_forms_int(month_input, month_error, out int monthValue);

            if (water && month)
            {
                MainForm.WaterData = new WaterData();
                MainForm.WaterData.WaterAmount = waterAmountValue;
                MainForm.WaterData.Month = monthValue;
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

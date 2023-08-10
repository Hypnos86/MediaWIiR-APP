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
    public partial class FormGasEstimation : Form
    {
        public FormGasEstimation()
        {
            InitializeComponent();
            Service service = new Service();


            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);

            tariff_text.Text = MainForm.GasData.Tariff.ToString();
            month_text.Text = MainForm.GasData.Month.ToString();
            gas_text.Text = string.Format("{0} m3", MainForm.GasData.Gas.ToString());
            power_text.Text = string.Format("{0} kW", MainForm.GasData.Power.ToString());
            confersion_text.Text = MainForm.GasData.Conversion.ToString();

            vat_text.Text = MainForm.GasTariff.VatValue.ToString();



        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {

        }
    }
}

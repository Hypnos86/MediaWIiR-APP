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
    public partial class FormHeatEstimation : Form
    {
        public FormHeatEstimation()
        {
            InitializeComponent();

            Service service = new Service();
            /*
            HeatResult heatResult = service.
            EnergyResult energyResult = service.estimating_energy(MainForm.EnergyData, MainForm.EnergyTariff);

            //Dane z MainForm gdzie przechowywane są wartosci zmiennych tylko do wyswietlania
            kwh_text.Text = string.Format("{0} kWh", MainForm.EnergyData.Kwh.ToString());
            power_text.Text = string.Format("{0} kW", MainForm.EnergyData.Power.ToString());
            month_text.Text = MainForm.EnergyData.Month.ToString();*/











            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);
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

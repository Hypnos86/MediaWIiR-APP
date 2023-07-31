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
    public partial class FormWaterEstimation : Form
    {
        public FormWaterEstimation()
        {
            InitializeComponent();
            Service service = new Service();
            WaterResult waterResult = service.estimating_water(MainForm.WaterData, MainForm.WaterTariff);

            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);

            tariff_text.Text = MainForm.WaterTariff.Tariff.ToString();
            month_text.Text = MainForm.WaterData.Month.ToString();
            estimate_text.Text = MainForm.WaterData.WaterAmount.ToString();
            vat_text.Text = MainForm.WaterTariff.VatValue.ToString();
            water_text.Text = MainForm.WaterTariff.Water.ToString();
            sewage_text.Text = MainForm.WaterTariff.Sewage.ToString();
            water_subscription_text.Text = MainForm.WaterTariff.SubscriptionWater.ToString();
            sewage_subscription_text.Text = MainForm.WaterTariff.SubscriptionSewage.ToString();

            water_result.Text = waterResult.Water.ToString();
            sewage_result.Text = waterResult.Sewage.ToString();
            water_subscribe_result.Text = waterResult.SubscriptionWater.ToString();
            sewage_subscribtion_result.Text = waterResult.SubscriptionSewage.ToString();
            netto_label.Text = waterResult.SumNetto.ToString();
            brutto_label.Text = waterResult.SumVat.ToString();
            water_sum_text.Text = waterResult.SumWater.ToString();


        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MediaWIiR_APP;
using MediaWIiR_APP.Models;

namespace MediaWIiR_APP
{
    public partial class MainForm : Form
    {
        public static Unit Unit { get; set; }
        public static EnergyData? EnergyData { get; set; } = null;
        public static EnergyTariff? EnergyTariff { get; set; } = null;
        public static WaterData? WaterData { get; set; } = null;
        public static WaterTariff? WaterTariff { get; set; } = null;
        public static HeatData? HeatData { get; set; } = null;
        public static HeatTariff? HeatTariff { get; set; } = null;
        public static GasData? GasData { get; set; } = null;
        public static GasTariff? GasTariff { get; set; } = null;

        public static string estimationDate { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();


            estimation_date.Value = DateTime.Now;
            estimationDate = estimation_date.Value.ToString("dd.MM.yyyy");
        }

        private void estimate_click_Click(object sender, EventArgs e)
        {
            //tworzenie konstruktora
            Service servis = new Service();
            //Walidacja usupenionych selektów
            bool unit_validator = servis.validating_selectors(unit_type_input, select_unit_type_error);
            bool media_type_validator = servis.validating_selectors(media_type_select, select_media_error);
            bool county_validator = servis.validating_selectors(county_input, select_county_error);
            bool zip_code_validator = servis.validating_zip_code(zip_code_input, zip_code_error);
            bool city_validator = servis.validating_text(city_input, city_error);
            bool address_validator = servis.validating_text(address_input, address_error);
            int option = media_type_select.SelectedIndex;

            if (unit_validator && media_type_validator && county_validator && zip_code_validator && city_validator && address_validator && ((option == 0 && EnergyData != null && EnergyTariff != null) || (option == 1 && HeatData != null && HeatTariff != null) || (option == 2 && WaterData != null && WaterTariff != null) || (option == 3 && GasData != null && GasTariff != null)))
            {
                Unit = new Unit();
                Unit.City = city_input.Text;
                Unit.Address = address_input.Text;
                Unit.ZipCode = zip_code_input.Text;
                Unit.County = county_input.Text;
                Unit.UnitType = unit_type_input.Text;
                estimationDate = estimation_date.Value.ToString("dd.MM.yyyy");


                switch (option)
                {
                    case 0:
                        FormEnergyEstimation formEnergyEstimation = new FormEnergyEstimation();
                        this.DialogResult = DialogResult.OK;
                        formEnergyEstimation.Show();
                        break;
                    case 1:
                        FormHeatEstimation formHeatingEstimation = new FormHeatEstimation();
                        this.DialogResult = DialogResult.OK;
                        formHeatingEstimation.Show();
                        break;
                    case 2:
                        FormWaterEstimation formWaterEstimation = new FormWaterEstimation();
                        this.DialogResult = DialogResult.OK;
                        formWaterEstimation.Show();
                        break;
                    case 3:
                        FormGasEstimation formGasEstimation = new FormGasEstimation();
                        this.DialogResult = DialogResult.OK;
                        formGasEstimation.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Uzupe³nij wszystkie pola i formularze - Dane i Op³aty", "Upss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void media_type_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (media_type_select.SelectedIndex != -1)
            {
                add_data_button.Enabled = true;
                add_fee_button.Enabled = true;
                estimate_click.Enabled = true;
            }
        }
        private void add_fee_button_Click(object sender, EventArgs e)
        {
            int option = media_type_select.SelectedIndex;
            Service service = new Service();

            switch (option)
            {
                case 0: //energia elektryczna
                    FormEnergyFee formEnergyFee = new FormEnergyFee(EnergyTariff);
                    formEnergyFee.ShowDialog();
                    break;

                case 1://co
                    FormHeatFee formHeatingFee = new FormHeatFee(HeatTariff);
                    formHeatingFee.ShowDialog();
                    break;

                case 2: //woda
                    FormWaterFee formWaterFee = new FormWaterFee(WaterTariff);
                    formWaterFee.ShowDialog();
                    break;

                case 3: //gaz
                    FormGasFee formGasFee = new FormGasFee(GasTariff, GasData);
                    formGasFee.ShowDialog();
                    break;
            }
        }
        private void add_data_Click(object sender, EventArgs e)
        {
            int option = media_type_select.SelectedIndex;

            switch (option)
            {
                case 0: //energia elektryczna
                    FormEnergyData formEnergyData = new FormEnergyData(EnergyData);
                    formEnergyData.ShowDialog(); //otwieranie okienka
                    break;

                case 1: //co
                    FormHeatData formHeatingData = new FormHeatData(HeatData);
                    formHeatingData.ShowDialog();
                    break;
                case 2: //woda


                    FormWaterData formWaterData = new FormWaterData(WaterData);
                    formWaterData.ShowDialog();
                    break;
                case 3: //gaz
                    FormGasData formGasData = new FormGasData(GasData);
                    formGasData.ShowDialog();
                    break;
            }
        }

        private void StripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
    }
}
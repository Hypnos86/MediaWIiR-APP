using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MediaWIiR_APP;
using MediaWIiR_APP.Models;

namespace MediaWIiR_APP
{
    public partial class MainForm : Form
    {
        internal Unit Unit { get; set; }

        public static EnergyData? EnergyData { get; set; } = null;
        public static EnergyTariff? EnergyTariff { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void unit_type_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zip_code_input_TextChanged(object sender, EventArgs e)
        {

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


            if (unit_validator && media_type_validator && county_validator && zip_code_validator && city_validator && address_validator)
            {
                this.Unit = new Unit();
                Unit.City = city_input.Text;
                Unit.Address = address_input.Text;
                Unit.ZipCode = zip_code_input.Text;
                Unit.County = county_input.Text;
                Unit.UnitType = unit_type_input.Text;

                FormEnergyEstimation formEnergyEstimation = new FormEnergyEstimation();
                formEnergyEstimation.Show();

            }
            else
            {
                MessageBox.Show("Uzupe³nij brakuj¹ce pola", "Upss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void county_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void media_type_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (media_type_select.SelectedIndex != -1)
            {
                add_data_button.Enabled = true;
                add_fee_button.Enabled = true;
            }
        }

        private void select_media_error_Click(object sender, EventArgs e)
        {

        }

        private void address_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void unit_info_groubpox_Enter(object sender, EventArgs e)
        {

        }

        private void add_fee_button_Click(object sender, EventArgs e)
        {
            int option = media_type_select.SelectedIndex;

            switch (option)
            {
                case 0: //energia elektryczna
                    FormEnergyFee formEnergyFee = new FormEnergyFee(EnergyTariff);
                    formEnergyFee.ShowDialog();
                    break;

                case 1://co
                    FormHeatingFee formHeatingFee = new FormHeatingFee();
                    formHeatingFee.ShowDialog();
                    break;

                case 2: //woda
                    FormWaterFee formWaterFee = new FormWaterFee();
                    formWaterFee.ShowDialog();
                    break;

                case 3: //gaz
                    FormGasFee formGasFee = new FormGasFee();
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
                    FormHeatingData formHeatingData = new FormHeatingData();
                    formHeatingData.ShowDialog();
                    break;
                case 2: //woda
                    FormWaterData formWaterData = new FormWaterData();
                    formWaterData.ShowDialog();
                    break;
                case 3: //gaz
                    FormGasData formGasData = new FormGasData();
                    formGasData.ShowDialog();
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using MediaWIiR_APP;
using MediaWIiR_APP.Models;

namespace MediaWIiR_APP
{
    public partial class MainForm : Form
    {
        internal Unit Unit { get; set; }

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
            //Walidacja usupenionych selekt�w
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
                save_to_pdf_click.Enabled = true;
            }
            else
            {
                MessageBox.Show("Uzupe�nij brakuj�ce pola", "Upss", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument(); // Create a new PDF doc ument
            PdfSharp.Pdf.PdfPage page = document.AddPage(); // Create an empty page
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page); // Get an XGraphics object for drawing
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular); // Create a font

            //Elementy na stronie
            DateTime estimateDate = estimation_date.Value;
            string title = $"Za��cznik do notatki z szacowania koszt�w medi�w {estimateDate.ToString("dd.MM.yyyy")}";
            string county = $"Powiat: {county_input.Text}";
            string unit_type = $"Rodzaj jednostki: {unit_type_input.Text}";
            string address = $"Adres: {address_input.Text}, {zip_code_input.Text} {city_input.Text}";



            // po��czone stringi z enterem mi�dzy wierszami
            string wroteText = string.Join("\n", title, county, unit_type, address);

            // Draw the text
            // formatowanie tekstu, bez tego nie wstawi entera
            PdfSharp.Drawing.Layout.XTextFormatter tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);

            tf.DrawString(wroteText, font, PdfSharp.Drawing.XBrushes.Black,
              new PdfSharp.Drawing.XRect(
                  // pocz�tek x (margines lewy)
                  (int)(page.Width * 0.1),
                  // pocz�tek y (margines g�rny)
                  (int)(page.Height * 0.1),
                  // wysoko�� pola
                  (int)(page.Width * 0.8),
                  // szeroko�� pola
                  (int)(page.Height * 0.8)),
                  // gdzie ma zacz��
                  PdfSharp.Drawing.XStringFormat.TopLeft);

            //gfx.DrawString(textToWrite2, font, PdfSharp.Drawing.XBrushes.Black,
            //    new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height),
            //    PdfSharp.Drawing.XStringFormat.TopLeft);

            // Save the document...
            string filename = $"Szacowanie z dnia {estimateDate.ToString("dd.MM.yyyy")}.pdf";
            document.Save(filename);
            MessageBox.Show($"Tw�j plik {filename} jest gotowy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ...and start a viewer.
            // System.Diagnostics.Process.Start(filename);

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
                    FormEnergyFee formEnergyFee = new FormEnergyFee();
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
                    EnergyData energyData = new EnergyData();

                   

                    FormEnergyData formEnergyData = new FormEnergyData();

                    if (formEnergyData.ShowDialog() == DialogResult.OK)
                    {
                        
                        formEnergyData.ShowDialog();

                    }

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
    }
}
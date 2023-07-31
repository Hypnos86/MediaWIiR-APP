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
    public partial class FormEnergyEstimation : Form
    {
        public FormEnergyEstimation()
        {
            InitializeComponent();

            Service service = new Service();
            EnergyResult energyResult = service.estimating_energy(MainForm.EnergyData, MainForm.EnergyTariff);

            //Dane z MainForm gdzie przechowywane są wartosci zmiennych tylko do wyswietlania
            kwh_text.Text = string.Format("{0} kWh", MainForm.EnergyData.Kwh.ToString());
            power_text.Text = string.Format("{0} kW", MainForm.EnergyData.Power.ToString());
            month_text.Text = MainForm.EnergyData.Month.ToString();

            tariff_text.Text = MainForm.EnergyTariff.Tariff;
            fixedNetworkFee_text.Text = MainForm.EnergyTariff.FixedNetworkFee.ToString();
            transitionFee_text.Text = MainForm.EnergyTariff.TransitionFee.ToString();
            capacirtFee_text.Text = MainForm.EnergyTariff.CapacirtFee.ToString();
            networkVariableFee_text.Text = MainForm.EnergyTariff.NetworkVariableFee.ToString();
            qualityFee_text.Text = MainForm.EnergyTariff.QualityFee.ToString();
            vat_text.Text = string.Format("{0}%", MainForm.EnergyTariff.VatValue.ToString());
            renewableEnergySourcesFee_text.Text = MainForm.EnergyTariff.QualityFee.ToString();
            cogenerationFee_text.Text = MainForm.EnergyTariff.CogenerationFee.ToString();
            subscriptionFee_text.Text = MainForm.EnergyTariff.SubscriptionFee.ToString();

            //przypisywanie wynikow do wyswietlenia
            cogenerationFee_result.Text = energyResult.CogenerationFee.ToString();
            capacirtFee_result.Text = energyResult.CapacirtFee.ToString();
            fixedNetworkFee_result.Text = energyResult.FixedNetworkFee.ToString();
            networkVariableFee_result.Text = energyResult.NetworkVariableFee.ToString();
            qualityFee_result.Text = energyResult.QualityFee.ToString();
            subscriptionFee_result.Text = energyResult.SubscriptionFee.ToString();
            renewableEnergySourcesFee_result.Text = energyResult.RenewableEnergySourcesFee.ToString();
            transitionFee_result.Text = energyResult.TransitionFee.ToString();

            netto_label.Text = String.Format("{0} zł", energyResult.SumNetto.ToString());
            brutto_label.Text = String.Format("{0} zł", energyResult.SumVat.ToString());
            kwh_sum_text.Text = energyResult.SumKwh.ToString();

            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);

        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Wymirz miejsce";
            saveFileDialog.FileName = "Nazwa pliku.pdf";

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Tutaj możesz użyć ścieżki `filePath` do zapisania danych do wybranego pliku.
                // Na przykład:
                // File.WriteAllText(filePath, "To jest zawartość pliku.");
            }
            /*
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument(); // Create a new PDF doc ument
            PdfSharp.Pdf.PdfPage page = document.AddPage(); // Create an empty page
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page); // Get an XGraphics object for drawing
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular); // Create a font


            //Elementy na stronie
            DateTime date = DateTime.Now;
            string title = $"Załącznik do notatki z szacowania kosztów mediów {date.ToString("dd.MM.yyyy")}";
            string county = $"Powiat: {MainForm.Unit.County}";
            string unit_type = $"Rodzaj jednostki: {MainForm.Unit.UnitType}";
            string address = $"Adres: {MainForm.Unit.Address}, {MainForm.Unit.ZipCode} {MainForm.Unit.City}";



            // połączone stringi z enterem między wierszami
            string wroteText = string.Join("\n", title, county, unit_type, address);

            // Draw the text
            // formatowanie tekstu, bez tego nie wstawi entera
            PdfSharp.Drawing.Layout.XTextFormatter tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);

            tf.DrawString(wroteText, font, PdfSharp.Drawing.XBrushes.Black,
              new PdfSharp.Drawing.XRect(
                  // początek x (margines lewy)
                  (int)(page.Width * 0.1),
                  // początek y (margines górny)
                  (int)(page.Height * 0.1),
                  // wysokość pola
                  (int)(page.Width * 0.8),
                  // szerokość pola
                  (int)(page.Height * 0.8)),
                  // gdzie ma zacząć
                  PdfSharp.Drawing.XStringFormat.TopLeft);

            gfx.DrawString(wroteText, font, PdfSharp.Drawing.XBrushes.Black,
               new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height),
                PdfSharp.Drawing.XStringFormat.TopLeft);

            // Save the document...
            string filename = $"Szacowanie z dnia {date.ToString("dd.MM.yyyy")}.pdf";
            document.Save(filename);
            MessageBox.Show($"Twój plik {filename} jest gotowy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ...and start a viewer.
            // System.Diagnostics.Process.Start(filename);

            */

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void power_label_Click(object sender, EventArgs e)
        {

        }

        private void fixedNetworkFee_result_Click(object sender, EventArgs e)
        {

        }
    }
}

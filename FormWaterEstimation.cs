using MediaWIiR_APP.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unit = MigraDoc.DocumentObjectModel.Unit;

namespace MediaWIiR_APP
{
    public partial class FormWaterEstimation : Form
    {
        public FormWaterEstimation()
        {
            InitializeComponent();
            Service service = new Service();
            WaterResult waterResult = service.estimating_water(MainForm.WaterData, MainForm.WaterTariff);

            unit_text.Text = string.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);

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
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
           

            // Tworzenie dokumentu
            MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();
            Section section = document.AddSection();
            

            // Dodawanie paragrafu z tytulem
            Paragraph title = section.AddParagraph();
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 16); // Nazwa fontu (bez rozszerzenia)
            title.AddText(string.Format("Załącznik do notatki z szacowania z dnia {0} r.", MainForm.estimationDate));
            title.Format.SpaceAfter = Unit.FromPoint(40); //puste miejscemiedzy elementami
            //Dodawanie paragrafu z danymi doszacowania
            Paragraph unit = section.AddParagraph();
            unit.Format.Alignment = ParagraphAlignment.Left;
            unit.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial",13); // Nazwa fontu (bez rozszerzenia)
            unit.AddText(string.Format("Jednostka: {0} {1}, {2} {3}\nPowiat: {4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County));

            // Zapisywanie dokumentu do formatu PDF
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true); // true - włączenie UTF-8
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            // Okno dialogowe wyboru ścieżki do zapisu pliku PDF
            Service service = new Service();
            string now = service.genering_date_now();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Wybierz miejsce zapisu";
            saveFileDialog.FileName = String.Format("Szacowanie kosztów Wody dla {0} {1} - {2}.pdf", MainForm.Unit.UnitType, MainForm.Unit.City, now);

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Zapisywanie pliku PDF
                pdfRenderer.PdfDocument.Save(filePath);
                MessageBox.Show("Plik został zapisany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

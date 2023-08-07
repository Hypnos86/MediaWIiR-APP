using MediaWIiR_APP.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
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
            estimate_text.Text = string.Format("{0} m3", MainForm.WaterData.WaterAmount.ToString());
            vat_text.Text = string.Format("{0}%", MainForm.WaterTariff.VatValue.ToString());
            water_text.Text = string.Format("{0} zł", MainForm.WaterTariff.Water.ToString());
            sewage_text.Text = string.Format("{0} zł", MainForm.WaterTariff.Sewage.ToString());
            water_subscription_text.Text = string.Format("{0} zł", MainForm.WaterTariff.SubscriptionWater.ToString());
            sewage_subscription_text.Text = string.Format("{0} zł", MainForm.WaterTariff.SubscriptionSewage.ToString());

            water_result.Text = string.Format("{0} zł", waterResult.Water.ToString());
            sewage_result.Text = string.Format("{0} zł", waterResult.Sewage.ToString());
            water_subscribe_result.Text = string.Format("{0} zł", waterResult.SubscriptionWater.ToString());
            sewage_subscribtion_result.Text = string.Format("{0} zł", waterResult.SubscriptionSewage.ToString());
            netto_label.Text = string.Format("{0} zł", waterResult.SumNetto.ToString());
            brutto_label.Text = string.Format("{0} zł", waterResult.SumBrutto.ToString());
            water_sum_text.Text = waterResult.SumWater.ToString();


        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            // Tworzenie konstruktora serwisu
            Service service = new Service();

            // Tworzenie konsuktora dla wyników szacowania
            WaterResult waterResult = service.estimating_water(MainForm.WaterData, MainForm.WaterTariff);

            // Tworzenie dokumentu
            MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();
            Section section = document.AddSection();

            // Dodawanie paragrafu z tytulem
            Paragraph title = section.AddParagraph();
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 16); // Nazwa fontu (bez rozszerzenia)
            title.AddText(string.Format("Załącznik do notatki z szacowania z dnia {0} r.", MainForm.estimationDate));
            title.Format.SpaceAfter = Unit.FromPoint(40); //puste miejscemiedzy elementami

            // Dodawanie paragrafu z danymi doszacowania
            Paragraph unit = section.AddParagraph();
            unit.Format.Alignment = ParagraphAlignment.Left;
            unit.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12); ;
            unit.AddText(string.Format("Szacowanie kosztów wody dla jednostki:\n{0} {1}, {2} {3}\nPowiat: {4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County));
            unit.Format.SpaceAfter = Unit.FromPoint(30); //puste miejscemiedzy elementami

            // Dane do szacowania
            Paragraph estimationData = section.AddParagraph();
            estimationData.Format.Alignment = ParagraphAlignment.Left;
            estimationData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationData.AddText(string.Format("Szacunkowe zużycie na miesiąć: {0} m3\n", MainForm.WaterData.WaterAmount.ToString()));
            estimationData.AddText(string.Format("Szacowanie na okres {0} miesięcy\n", MainForm.WaterData.Month.ToString()));
            estimationData.AddText(string.Format("Zużycie w ciągu {0} miesięcy: {1} m3 ", MainForm.WaterData.Month.ToString(), waterResult.SumWater.ToString()));
            estimationData.Format.SpaceAfter = Unit.FromPoint(40); //puste miejscemiedzy elementami

            // Dane do obliczenia - tytul
            Paragraph feeDataTitle = section.AddParagraph();
            feeDataTitle.Format.Alignment = ParagraphAlignment.Left;
            feeDataTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            feeDataTitle.AddText(string.Format("Wartości kosztów przyjęte do szacowania"));
            feeDataTitle.Format.Font.Bold = true;

            //Dane do obliczen
            Paragraph feeData = section.AddParagraph();
            feeData.Format.Alignment = ParagraphAlignment.Left;
            feeData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            if (!String.IsNullOrEmpty(MainForm.WaterTariff.Tariff))
            {
                feeData.AddText(string.Format("Na podstawie taryfy: {0}\n", MainForm.WaterTariff.Tariff.ToString()));
            }
            feeData.AddText(string.Format("Koszt m3 wody netto: {0} zł\n", MainForm.WaterTariff.Water.ToString()));
            feeData.AddText(string.Format("Koszt m3 ścieków netto: {0} zł\n", MainForm.WaterTariff.Sewage.ToString()));
            feeData.AddText(string.Format("Abonament Woda 1 mc netto: {0} zł\n", MainForm.WaterTariff.SubscriptionWater.ToString()));
            feeData.AddText(string.Format("Abonament Ścieki 1 mc netto: {0} zł\n", MainForm.WaterTariff.SubscriptionSewage.ToString()));
            feeData.Format.SpaceAfter = Unit.FromPoint(30);

            //Dodanie tytulu kolejnego akapitu
            Paragraph estimationTitle = section.AddParagraph();
            estimationTitle.Format.Alignment = ParagraphAlignment.Left;
            estimationTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            estimationTitle.AddText(string.Format("Oszacowanie kosztów"));
            estimationTitle.Format.Font.Bold = true;

            // Obliczenia szacunku
            Paragraph estimationResult = section.AddParagraph();
            estimationResult = section.AddParagraph();
            estimationResult.Format.Alignment = ParagraphAlignment.Left;
            estimationResult.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationResult.AddText(string.Format("Koszt wody: {0} zł netto\n", waterResult.Water.ToString()));
            estimationResult.AddText(string.Format("Koszt ścieków: {0} zł netto\n", waterResult.Sewage.ToString()));
            estimationResult.AddText(string.Format("Koszt abonamentu wody: {0} zł netto\n", waterResult.SubscriptionWater.ToString()));
            estimationResult.AddText(string.Format("Koszt abonamentu Ścieków: {0} zł netto\n", waterResult.SubscriptionSewage.ToString()));
            estimationResult.Format.SpaceAfter = Unit.FromPoint(30); //puste miejscemiedzy elementami
            estimationResult.AddText(string.Format("Całkowity koszt netto: {0} zł\n", waterResult.SumNetto.ToString()));
            estimationResult.AddText(string.Format("Vat: {0}%\n", MainForm.WaterTariff.VatValue.ToString()));
            estimationResult.AddText(string.Format("Całkowity koszt brutto: {0} zł", waterResult.SumBrutto.ToString()));
            estimationResult.Format.SpaceAfter = Unit.FromPoint(100); //puste miejscemiedzy elementami
            // podpis prcownika
            Paragraph author = new Paragraph();
            author = section.AddParagraph();
            author.Format.Alignment = ParagraphAlignment.Left;
            author.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            author.AddText("...................................................................\n");
            author.AddSpace(3);
            author.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            author.AddText("(podpis pracownika szacującego koszty)");


            // Zapisywanie dokumentu do formatu PDF
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true); // true - włączenie UTF-8
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            // Okno dialogowe wyboru ścieżki do zapisu pliku PDF
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

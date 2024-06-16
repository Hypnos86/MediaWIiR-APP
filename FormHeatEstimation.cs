using MediaWIiR_APP.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using Unit = MigraDoc.DocumentObjectModel.Unit;

namespace MediaWIiR_APP
{
    public partial class FormHeatEstimation : Form
    {
        public FormHeatEstimation()
        {
            InitializeComponent();

            Service service = new Service();

            HeatResult heatResult = service.estimating_heat(MainForm.HeatData, MainForm.HeatTariff);
            //Dane z MainForm gdzie przechowywane są wartosci zmiennych tylko do wyswietlania
            tariff_text.Text = MainForm.HeatTariff.Tariff.ToString();
            month_text.Text = MainForm.HeatData.Month.ToString();
            gj_text.Text = string.Format("{0} GJ", MainForm.HeatData.Heat.ToString());
            power_text.Text = string.Format("{0} MW", MainForm.HeatData.Power.ToString());
            vat_text.Text = string.Format("{0}%", MainForm.HeatTariff.VatValue.ToString());
            heat_cost_text.Text = string.Format("{0} zł", MainForm.HeatTariff.HeatFee.ToString());
            fixedShippingFee_text.Text = string.Format("{0} zł", MainForm.HeatTariff.FixedShippingFee.ToString());
            variableShippingFee_text.Text = string.Format("{0} zł", MainForm.HeatTariff.VariableShippingFee.ToString());
            subscriptionFee_text.Text = string.Format("{0} zł", MainForm.HeatTariff.SubscriptionFee.ToString());
            carrerFee_text.Text = string.Format("{0} zł", MainForm.HeatTariff.CarrerFee.ToString());
            orderedThermalPower_text.Text = string.Format("{0} zł", MainForm.HeatTariff.OrderedThermalPower.ToString());
            //Dane z rezultatami wyliczeń
            heatFeeResult.Text = string.Format("{0} zł", heatResult.HeatFee.ToString());
            fixedShippingFeeResult.Text = string.Format("{0} zł", heatResult.FixedShippingFee.ToString());
            variableShippingFeeResult.Text = string.Format("{0} zł", heatResult.VariableShippingFee.ToString());
            subscriptionFeeResult.Text = string.Format("{0} zł", heatResult.SubscriptionFee.ToString());
            carrerFeeResult.Text = string.Format("{0} zł", heatResult.CarrerFee.ToString());
            orderedThermalPowerResult.Text = string.Format("{0} zł", heatResult.OrderedThermalPower.ToString());

            sumNettoResult.Text = string.Format("{0} zł", heatResult.SumNetto.ToString());
            SumBruttoResult.Text = string.Format("{0} zł", heatResult.SumBrutto.ToString());
            sumGjResult.Text = string.Format("{0}", heatResult.SumGj.ToString());

            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            // Tworzenie konstruktora serwisu
            Service service = new Service();

            // Tworzenie konsuktora dla wyników szacowania
            HeatResult heatResult = service.estimating_heat(MainForm.HeatData, MainForm.HeatTariff);

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
            unit.AddText(string.Format("Szacowanie kosztów centralnego ogrzewania dla jednostki:\n{0} {1}, {2} {3}\nPowiat: {4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County));
            unit.Format.SpaceAfter = Unit.FromPoint(30); //puste miejscemiedzy elementami

            // Dane do szacowania
            Paragraph estimationData = section.AddParagraph();
            estimationData.Format.Alignment = ParagraphAlignment.Left;
            estimationData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationData.AddText(string.Format("Szacunkowe zużycie na miesiąc: {0} GJ\n", MainForm.HeatData.Heat.ToString()));
            estimationData.AddText(string.Format("Szacowanie na okres {0} miesięcy\n", MainForm.HeatData.Month.ToString()));
            estimationData.AddText(string.Format("Zużycie w ciągu {0} miesięcy: {1} GJ ", MainForm.HeatData.Month.ToString(), heatResult.SumGj.ToString()));
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
            if (!String.IsNullOrEmpty(MainForm.HeatTariff.Tariff))
            {
                feeData.AddText(string.Format("Na podstawie taryfy: {0}\n", MainForm.HeatTariff.Tariff.ToString()));
            }
            if (MainForm.HeatTariff.HeatFee != 0)
            {
                feeData.AddText(string.Format("Koszt 1 GJ netto: {0} zł\n", MainForm.HeatTariff.HeatFee.ToString()));
            }
            if (MainForm.HeatTariff.FixedShippingFee != 0)
            {
                feeData.AddText(string.Format("Opłata za przesył netto: {0} zł\n", MainForm.HeatTariff.FixedShippingFee.ToString()));
            }
            if (MainForm.HeatTariff.VariableShippingFee != 0)
            {
                feeData.AddText(string.Format("Opłata zamienna za przesył netto: {0} zł\n", MainForm.HeatTariff.VariableShippingFee.ToString()));
            }
            if (MainForm.HeatTariff.SubscriptionFee != 0)
            {
                feeData.AddText(string.Format("Opłata za abonament 1 mc netto: {0} zł\n", MainForm.HeatTariff.SubscriptionFee.ToString()));
            }
            if (MainForm.HeatTariff.CarrerFee != 0)
            {
                feeData.AddText(string.Format("Opłata za nośnik netto: {0} zł\n", MainForm.HeatTariff.CarrerFee.ToString()));
            }
            if (MainForm.HeatTariff.OrderedThermalPower != 0)
            {
                feeData.AddText(string.Format("Opłata za zamówioną moc cieplną netto: {0} zł\n", MainForm.HeatTariff.OrderedThermalPower.ToString()));
            }


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
            if (MainForm.HeatTariff.HeatFee != 0)
            {
                estimationResult.AddText(string.Format("Opłata za ciepło: {0} zł netto\n", heatResult.HeatFee.ToString()));
            }
            if (MainForm.HeatTariff.FixedShippingFee != 0)
            {
                estimationResult.AddText(string.Format("Opłata za stały przesył: {0} zł netto\n", heatResult.FixedShippingFee.ToString()));
            }
            if (MainForm.HeatTariff.VariableShippingFee != 0)
            {
                estimationResult.AddText(string.Format("Opłata zmienna za przesył: {0} zł netto\n", heatResult.VariableShippingFee.ToString()));
            }
            if (MainForm.HeatTariff.SubscriptionFee != 0)
            {
                estimationResult.AddText(string.Format("Opłata abonamentowa: {0} zł netto\n", heatResult.SubscriptionFee.ToString()));
            }
            if (MainForm.HeatTariff.CarrerFee != 0)
            {
                estimationResult.AddText(string.Format("Opłata za nośnik: {0} zł netto\n", heatResult.CarrerFee.ToString()));
            }
            if (MainForm.HeatTariff.OrderedThermalPower != 0)
            {
                estimationResult.AddText(string.Format("Opłata za zamówioną moc cieplną: {0} zł netto\n", heatResult.OrderedThermalPower.ToString()));
            }

            estimationResult.Format.SpaceAfter = Unit.FromPoint(30); //puste miejscemiedzy elementami
            estimationResult.AddText(string.Format("Całkowity koszt netto: {0} zł\n", heatResult.SumNetto.ToString()));
            estimationResult.AddText(string.Format("Vat: {0}%\n", MainForm.HeatTariff.VatValue.ToString()));
            estimationResult.AddText(string.Format("Całkowity koszt brutto: {0} zł", heatResult.SumBrutto.ToString()));
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
            saveFileDialog.FileName = String.Format("Szacowanie kosztów C.O. dla {0} {1} - {2}.pdf", MainForm.Unit.UnitType, MainForm.Unit.City, now);

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Zapisywanie pliku PDF
                pdfRenderer.PdfDocument.Save(filePath);
                MessageBox.Show("Plik został zapisany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}

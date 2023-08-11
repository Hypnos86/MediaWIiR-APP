using MediaWIiR_APP.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using Unit = MigraDoc.DocumentObjectModel.Unit;

namespace MediaWIiR_APP
{
    public partial class FormEnergyEstimation : Form
    {
        public FormEnergyEstimation()
        {
            InitializeComponent();

            Service service = new Service();
            EnergyResult energyResult = service.estimating_energy(MainForm.EnergyData, MainForm.EnergyTariff);

            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);
            //Dane z MainForm gdzie przechowywane są wartosci zmiennych tylko do wyswietlania
            kwgInput.Text = string.Format("{0} kWh", MainForm.EnergyData.Kwh.ToString());
            powerInput.Text = string.Format("{0} kW", MainForm.EnergyData.Power.ToString());
            monthInput.Text = MainForm.EnergyData.Month.ToString();

            tariff_text.Text = MainForm.EnergyTariff.Tariff;
            fixedNetworkFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.FixedNetworkFee.ToString()); ;
            transitionFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.TransitionFee.ToString());
            capacirtFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.CapacirtFee.ToString());
            networkVariableFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.NetworkVariableFee.ToString());
            qualityFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.QualityFee.ToString());
            vat_text.Text = string.Format("{0}%", MainForm.EnergyTariff.VatValue.ToString());
            renewableEnergySourcesFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.QualityFee.ToString());
            cogenerationFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.CogenerationFee.ToString());
            subscriptionFee_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.SubscriptionFee.ToString());
            kwhSell_text.Text = string.Format("{0} zł", MainForm.EnergyTariff.KwhSell.ToString());

            //przypisywanie wynikow do wyswietlenia
            cogenerationFee_result.Text = string.Format("{0} zł", energyResult.CogenerationFee.ToString());
            capacirtFee_result.Text = string.Format("{0} zł", energyResult.CapacirtFee.ToString());
            fixedNetworkFee_result.Text = string.Format("{0} zł", energyResult.FixedNetworkFee.ToString());
            networkVariableFee_result.Text = string.Format("{0} zł", energyResult.NetworkVariableFee.ToString());
            qualityFee_result.Text = string.Format("{0} zł", energyResult.QualityFee.ToString());
            subscriptionFee_result.Text = string.Format("{0} zł", energyResult.SubscriptionFee.ToString());
            renewableEnergySourcesFee_result.Text = string.Format("{0} zł", energyResult.RenewableEnergySourcesFee.ToString());
            transitionFee_result.Text = string.Format("{0} zł", energyResult.TransitionFee.ToString());
            kwhSellResultNetto.Text = string.Format("{0} zł", energyResult.SumNettoSell.ToString());
            kwhSellResultBrutto.Text = string.Format("{0} zł", energyResult.SumBruttoSell.ToString());
            kwhOsdResultNetto.Text = string.Format("{0} zł", energyResult.SumNettoOsd.ToString());
            kwhOsdResultBrutto.Text = string.Format("{0} zł", energyResult.SumBruttoOsd.ToString());
            kwh_sum_text.Text = energyResult.SumKwh.ToString();
        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            // Tworzenie konstruktora serwisu
            Service service = new Service();

            // Tworzenie konsuktora dla wyników szacowania
            EnergyResult energyResult = service.estimating_energy(MainForm.EnergyData, MainForm.EnergyTariff);

            // Tworzenie dokumentu
            MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();
            Section section = document.AddSection();
            section.PageSetup.TopMargin = Unit.FromCentimeter(1.25); // Ustawienie marginesow strony
            section.PageSetup.BottomMargin = Unit.FromCentimeter(1.25);

            // Dodawanie paragrafu z tytulem
            Paragraph title = section.AddParagraph();
            title.Format.Alignment = ParagraphAlignment.Center;
            title.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 15); // Nazwa fontu (bez rozszerzenia)
            title.AddText(string.Format("Załącznik do notatki z szacowania z dnia {0} r.", MainForm.estimationDate));
            title.Format.SpaceAfter = Unit.FromPoint(40); //puste miejscemiedzy elementami

            // Dodawanie paragrafu z danymi doszacowania
            Paragraph unit = section.AddParagraph();
            unit.Format.Alignment = ParagraphAlignment.Left;
            unit.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13); ;
            unit.AddText(string.Format("Szacowanie kosztów energii elektrycznej dla jednostki:\n{0} {1}, {2} {3}\nPowiat: {4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County));
            unit.Format.SpaceAfter = Unit.FromPoint(20); //puste miejscemiedzy elementami

            // Dane do szacowania
            Paragraph estimationData = section.AddParagraph();
            estimationData.Format.Alignment = ParagraphAlignment.Left;
            estimationData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            estimationData.AddText(string.Format("Szacunkowe zużycie na miesiąć: {0} kWh\n", MainForm.EnergyData.Kwh.ToString()));
            estimationData.AddText(string.Format("Szacunkowe zapotrzebowanie na moc: {0} kW\n", MainForm.EnergyData.Power.ToString()));
            estimationData.AddText(string.Format("Szacowanie na okres {0} miesięcy\n", MainForm.EnergyData.Month.ToString()));
            estimationData.AddText(string.Format("Zużycie w ciągu {0} miesięcy: {1} kWh ", MainForm.EnergyData.Month, energyResult.SumKwh.ToString()));
            estimationData.Format.SpaceAfter = Unit.FromPoint(20); //puste miejscemiedzy elementami

            // Dane do obliczenia - tytul
            Paragraph feeDataTitle = section.AddParagraph();
            feeDataTitle.Format.Alignment = ParagraphAlignment.Left;
            feeDataTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            feeDataTitle.AddText(string.Format("Składniki kosztów Operatora Systemu Dystrybucji przyjęte do szacowania: "));
            feeDataTitle.Format.SpaceAfter = Unit.FromPoint(10); //puste miejscemiedzy elementami
            feeDataTitle.Format.Font.Bold = true;

            //Dane do obliczen
            Paragraph feeData = section.AddParagraph();
            feeData.Format.Alignment = ParagraphAlignment.Left;
            feeData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            if (!String.IsNullOrEmpty(MainForm.EnergyTariff.Tariff))
            {
                feeData.AddText(string.Format("Na podstawie taryfy: {0}\n", MainForm.EnergyTariff.Tariff.ToString()));
            }
            feeData.AddText(string.Format("Opłata stała sieciowa: {0} zł netto\n", MainForm.EnergyTariff.FixedNetworkFee.ToString()));
            feeData.AddText(string.Format("Opłata przejściowa: {0} zł netto\n", MainForm.EnergyTariff.TransitionFee.ToString()));
            feeData.AddText(string.Format("Opłata mocowa: {0} zł netto\n", MainForm.EnergyTariff.CapacirtFee.ToString()));
            feeData.AddText(string.Format("Opłata zmienna sieciowa: {0} zł netto\n", MainForm.EnergyTariff.NetworkVariableFee.ToString()));
            feeData.AddText(string.Format("Opłata jakościowa: {0} zł netto\n", MainForm.EnergyTariff.QualityFee.ToString()));
            feeData.AddText(string.Format("Opłata OZE: {0} zł netto\n", MainForm.EnergyTariff.RenewableEnergySourcesFee.ToString()));
            feeData.AddText(string.Format("Opłata kogeneracyjna: {0} zł netto\n", MainForm.EnergyTariff.CogenerationFee.ToString()));
            feeData.AddText(string.Format("Opłata abonamentowa: {0} zł netto\n", MainForm.EnergyTariff.SubscriptionFee.ToString()));
            feeData.Format.SpaceAfter = Unit.FromPoint(20);

            //Dodanie tytulu kolejnego akapitu - OSD
            Paragraph estimationTitle = section.AddParagraph();
            estimationTitle.Format.Alignment = ParagraphAlignment.Left;
            estimationTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            estimationTitle.AddText(string.Format("Oszacowanie kosztów OSD:"));
            estimationTitle.Format.SpaceAfter = Unit.FromPoint(10); //puste miejscemiedzy elementami
            estimationTitle.Format.Font.Bold = true;

            // Obliczenia szacunku - OSD
            Paragraph estimationResult = section.AddParagraph();
            estimationResult.Format.Alignment = ParagraphAlignment.Left;
            estimationResult.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationResult.AddText(string.Format("Opłata stała sieciowa: {0} zł netto\n", energyResult.FixedNetworkFee.ToString()));
            estimationResult.AddText(string.Format("Opłata przejściowa {0} zł netto\n", energyResult.TransitionFee.ToString()));
            estimationResult.AddText(string.Format("Opłata mocowa: {0} zł netto\n", energyResult.CapacirtFee.ToString()));
            estimationResult.AddText(string.Format("Opłata zmienna sieciowa: {0} zł netto\n", energyResult.NetworkVariableFee.ToString()));
            estimationResult.AddText(string.Format("Opłata jakościowa netto: {0} zł netto\n", energyResult.QualityFee.ToString()));
            estimationResult.AddText(string.Format("Opłata OZE: {0} zł netto\n", energyResult.RenewableEnergySourcesFee.ToString()));
            estimationResult.AddText(string.Format("Opłata kogeneracyjna: {0} zł netto\n", energyResult.CogenerationFee.ToString()));
            estimationResult.AddText(string.Format("Opłata abonamentowa: {0} zł netto\n", energyResult.SubscriptionFee.ToString()));
            estimationResult.AddText(string.Format("Całkowity koszt netto: {0} zł\n", energyResult.SumNettoOsd.ToString()));
            estimationResult.AddText(string.Format("Vat: {0}%\n", MainForm.EnergyTariff.VatValue.ToString()));
            estimationResult.AddText(string.Format("Całkowity koszt brutto: {0} zł", energyResult.SumBruttoOsd.ToString()));
            estimationResult.Format.SpaceAfter = Unit.FromPoint(20); //puste miejscemiedzy elementami

            //Dodanie tytulu kolejnego akapitu - sprzedaż
            Paragraph estimationTitleSell = section.AddParagraph();
            estimationTitleSell.Format.Alignment = ParagraphAlignment.Left;
            estimationTitleSell.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            estimationTitleSell.AddText(string.Format("Oszacowanie kosztów kWh - sprzedaż:"));
            estimationTitleSell.Format.SpaceAfter = Unit.FromPoint(10); //puste miejscemiedzy elementami
            estimationTitleSell.Format.Font.Bold = true;


            // Obliczenia szacunku - sprzedaż
            Paragraph estimationResultSell = section.AddParagraph();
            estimationResultSell.Format.Alignment = ParagraphAlignment.Left;
            estimationResultSell.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationResultSell.AddText(string.Format("Koszt 1 kWh: {0} zł netto\n", MainForm.EnergyTariff.KwhSell.ToString()));
            estimationResultSell.AddText(string.Format("Całkowity koszt energii netto: {0} zł\n", energyResult.SumNettoSell.ToString()));
            estimationResultSell.AddText(string.Format("Całkowity koszt energii brutto: {0} zł\n", energyResult.SumBruttoSell.ToString()));
            estimationResultSell.Format.SpaceAfter = Unit.FromPoint(80); //puste miejsce miedzy elementami

            // podpis prcownika
            Paragraph author = section.AddParagraph();
            author.Format.Alignment = ParagraphAlignment.Right;
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
            saveFileDialog.FileName = String.Format("Szacowanie kosztów energii elektrycznej dla {0} {1} - {2}.pdf", MainForm.Unit.UnitType, MainForm.Unit.City, now);

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

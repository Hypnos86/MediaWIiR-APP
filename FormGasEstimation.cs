using MediaWIiR_APP.Models;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using Unit = MigraDoc.DocumentObjectModel.Unit;

namespace MediaWIiR_APP
{
    public partial class FormGasEstimation : Form
    {
        public FormGasEstimation()
        {
            InitializeComponent();
            Service service = new Service();
            GasResult gasResult = service.estimating_gas(MainForm.GasData, MainForm.GasTariff);

            // wypisanie podstawowych danych z ktorych bedą obliczenia
            unit_text.Text = String.Format("Jednostka: {0}\n{1}, {2} {3}\nPowiat:{4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County);

            tariff_text.Text = MainForm.GasData.Tariff.ToString();
            month_text.Text = MainForm.GasData.Month.ToString();
            gas_text.Text = string.Format("{0} m3", MainForm.GasData.Gas.ToString());
            power_text.Text = string.Format("{0} kW", MainForm.GasData.Power.ToString());
            confersion_text.Text = MainForm.GasData.Conversion.ToString();

            vat_text.Text = string.Format("{0}%", MainForm.GasTariff.VatValue.ToString());
            gasFee_text.Text = string.Format("{0} zł", MainForm.GasTariff.Gas.ToString());
            subscribeFee_text.Text = string.Format("{0} zł", MainForm.GasTariff.Subscribe.ToString());
            if (MainForm.GasData.Tariff == "W-5")
            {
                fixedDistribution_text.Text = string.Format("{0} gr", MainForm.GasTariff.FixedDistribution.ToString());
            }
            else
            {
                fixedDistribution_text.Text = string.Format("{0} zł", MainForm.GasTariff.FixedDistribution.ToString());
            }
            variableDistribution_text.Text = string.Format("{0} gr", MainForm.GasTariff.VariableDistribution.ToString());

            //wyniki obliczen przekonwertowane i sprawdzone wzgledem taryf
            gasFeeResult.Text = string.Format("{0} zł", gasResult.Gas.ToString());
            subscribeFeeResult.Text = string.Format("{0} zł", gasResult.Subscribe.ToString());
            fixedDistributionResult.Text = string.Format("{0} zł", gasResult.FixedDistribution.ToString());
            variableDistributionResult.Text = string.Format("{0} zł", gasResult.VariableDistribution.ToString());
            ResultNetto.Text = string.Format("{0} zł", gasResult.SumNetto.ToString());
            ResultBrutto.Text = string.Format("{0} zł", gasResult.SumBrutto.ToString());
            sumKwh.Text = string.Format("{0} kWh", gasResult.SumKwh.ToString());
            sumM3.Text = string.Format("{0}", gasResult.SumM3.ToString());


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
            GasResult gasResult = service.estimating_gas(MainForm.GasData, MainForm.GasTariff);

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
            unit.AddText(string.Format("Szacowanie kosztów gazu dla jednostki:\n{0} {1}, {2} {3}\nPowiat: {4}", MainForm.Unit.UnitType, MainForm.Unit.Address, MainForm.Unit.ZipCode, MainForm.Unit.City, MainForm.Unit.County));
            unit.Format.SpaceAfter = Unit.FromPoint(30); //puste miejscemiedzy elementami

            // Dane do szacowania
            Paragraph estimationData = section.AddParagraph();
            estimationData.Format.Alignment = ParagraphAlignment.Left;
            estimationData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            estimationData.AddText(string.Format("Szacunkowe zużycie na miesiąc: {0} m3\n", MainForm.GasData.Gas.ToString()));
            estimationData.AddText(string.Format("Szacowanie na okres {0} miesięcy\n", MainForm.GasData.Month.ToString()));
            estimationData.AddText(string.Format("Zużycie w ciągu {0} miesięcy: {1} m3, co daje {2} kWh\n", MainForm.GasData.Month.ToString(), gasResult.SumM3.ToString(), gasResult.SumKwh));
            estimationData.AddText(string.Format("Zakładany współczynnik konwersji: {0}\n", MainForm.GasData.Conversion.ToString()));

            if (MainForm.GasData.Tariff == "W-5")
            {
                estimationData.AddText(string.Format("Szacowane zapotrzebowanie na moc: {0} kW", MainForm.GasData.Power.ToString()));
            }

            estimationData.Format.SpaceAfter = Unit.FromPoint(40); //puste miejscemiedzy elementami

            // Dane do obliczenia - tytul
            Paragraph feeDataTitle = section.AddParagraph();
            feeDataTitle.Format.Alignment = ParagraphAlignment.Left;
            feeDataTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            feeDataTitle.AddText(string.Format("Wartości kosztów przyjęte do szacowania"));
            feeDataTitle.Format.SpaceAfter = Unit.FromPoint(10); //puste miejscemiedzy elementami
            feeDataTitle.Format.Font.Bold = true;

            //Dane do obliczen
            Paragraph feeData = section.AddParagraph();
            feeData.Format.Alignment = ParagraphAlignment.Left;
            feeData.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            feeData.AddText(string.Format("Na podstawie taryfy: {0}\n", MainForm.GasData.Tariff.ToString()));
            if (MainForm.GasTariff.Gas != 0)
            {
                feeData.AddText(string.Format("Koszt 1 kWh netto: {0} zł\n", MainForm.GasTariff.Gas.ToString()));
            }
            if (MainForm.GasTariff.Subscribe != 0)
            {
                feeData.AddText(string.Format("Opłata abonamentowa - gaz netto: {0} zł\n", MainForm.GasTariff.Subscribe.ToString()));
            }

            if (MainForm.GasData.Tariff == "W-5")
            {
                feeData.AddText(string.Format("Dystrybucja stała netto: {0} gr\n", MainForm.GasTariff.FixedDistribution.ToString()));
            }
            else
            {
                feeData.AddText(string.Format("Dystrybucja stała netto: {0} zł\n", MainForm.GasTariff.FixedDistribution.ToString()));
            }
            if (MainForm.GasTariff.VariableDistribution != 0)
            {
                feeData.AddText(string.Format("Dystrybucja zmienna netto: {0} zł\n", MainForm.GasTariff.VariableDistribution.ToString()));
            }

            feeData.Format.SpaceAfter = Unit.FromPoint(30);

            //Dodanie tytulu kolejnego akapitu
            Paragraph estimationTitle = section.AddParagraph();
            estimationTitle.Format.Alignment = ParagraphAlignment.Left;
            estimationTitle.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 13);
            estimationTitle.AddText(string.Format("Oszacowanie kosztów"));
            estimationTitle.Format.SpaceAfter = Unit.FromPoint(10); //puste miejscemiedzy elementami
            estimationTitle.Format.Font.Bold = true;
            // Obliczenia szacunku
            Paragraph estimationResult = section.AddParagraph();
            estimationResult = section.AddParagraph();
            estimationResult.Format.Alignment = ParagraphAlignment.Left;
            estimationResult.Format.Font = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            if (MainForm.GasTariff.Gas != 0)
            {
                estimationResult.AddText(string.Format("Opłata za gaz: {0} zł netto\n", gasResult.Gas.ToString()));
            }
            if (MainForm.GasTariff.Subscribe != 0)
            {
                estimationResult.AddText(string.Format("Opłata za abonament: {0} zł netto\n", gasResult.Subscribe.ToString()));
            }
            if (MainForm.GasTariff.FixedDistribution != 0)
            {
                estimationResult.AddText(string.Format("Opłata dystrybucyjna stała: {0} zł netto\n", gasResult.FixedDistribution.ToString()));
            }
            if (MainForm.GasTariff.VariableDistribution != 0)
            {
                estimationResult.AddText(string.Format("Opłata dystrybucyjna zmienna: {0} zł netto\n", gasResult.VariableDistribution.ToString()));
            }

            estimationResult.AddText(string.Format("Całkowity koszt netto: {0} zł\n", gasResult.SumNetto.ToString()));
            estimationResult.AddText(string.Format("Vat: {0}%\n", MainForm.GasTariff.VatValue.ToString()));
            estimationResult.AddText(string.Format("Całkowity koszt brutto: {0} zł", gasResult.SumBrutto.ToString()));
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
            saveFileDialog.FileName = String.Format("Szacowanie kosztów gazu dla {0} {1} - {2}.pdf", MainForm.Unit.UnitType, MainForm.Unit.City, now);

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

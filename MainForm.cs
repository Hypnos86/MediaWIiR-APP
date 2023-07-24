using System.Text.RegularExpressions;
using MediaWIiR_APP;

namespace MediaWIiR_APP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void zip_code_input_TextChanged(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            //Walidacja kodu pocztowego
            servis.validating_zip_code(zip_code_input);
        }

        private void unit_type_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            //Walidacja usupenionych selektów
            servis.validating_selectors(unit_type_input, select_county_error);
        }

        private void estimate_click_Click(object sender, EventArgs e)
        {


        }

        private void county_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            //Walidacja usupenionych selektów
            servis.validating_selectors(county_input, select_county_error);
        }

        private void media_type_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servis servis = new Servis();
            //Walidacja usupenionych selektów
            servis.validating_selectors(media_type_input, select_county_error);
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
            //string county = string.Format("Powiat: {0}", county_input.Text);
            //string unit_type = string.Format("Rodzaj jednostki: {0}", unit_type_input.Text);
            //string address = string.Format("Adres: {0}, {1} {2}", address_input.Text, zip_code_input.Text, city_input.Text);

            string county = $"Powiat: {county_input.Text}";
            string unit_type = $"Rodzaj jednostki: {unit_type_input.Text}";
            string address = $"Adres: {address_input.Text}, {zip_code_input.Text} {city_input.Text}";



            // po³¹czone stringi z enterem miêdzy wierszami
            string wroteText = string.Join("\n", county, unit_type, address);

            // Draw the text
            // formatowanie tekstu, bez tego nie wstawi entera
            PdfSharp.Drawing.Layout.XTextFormatter tf = new PdfSharp.Drawing.Layout.XTextFormatter(gfx);

            tf.DrawString(wroteText, font, PdfSharp.Drawing.XBrushes.Black,
              new PdfSharp.Drawing.XRect(
                  // pocz¹tek x (margines lewy)
                  (int)(page.Width * 0.1),
                  // pocz¹tek y (margines górny)
                  (int)(page.Height * 0.1),
                  // wysokoœæ pola
                  (int)(page.Width * 0.8),
                  // szerokoœæ pola
                  (int)(page.Height * 0.8)),
                  // gdzie ma zacz¹æ
                  PdfSharp.Drawing.XStringFormat.TopLeft);

            //gfx.DrawString(textToWrite2, font, PdfSharp.Drawing.XBrushes.Black,
            //    new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height),
            //    PdfSharp.Drawing.XStringFormat.TopLeft);

            // Save the document...
            string filename = "Szacowanie.pdf";
            document.Save(filename);
            MessageBox.Show($"Twój plik {filename} jest gotowy");
            // ...and start a viewer.
            // System.Diagnostics.Process.Start(filename);

        }

        private void address_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
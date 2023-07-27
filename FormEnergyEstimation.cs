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
        }

        private void save_to_pdf_click_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfSharp.Pdf.PdfDocument document = new PdfSharp.Pdf.PdfDocument(); // Create a new PDF doc ument
            PdfSharp.Pdf.PdfPage page = document.AddPage(); // Create an empty page
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromPdfPage(page); // Get an XGraphics object for drawing
            PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular); // Create a font
            /*

            //Elementy na stronie
            DateTime estimateDate = estimation_date.Value;
            string title = $"Załącznik do notatki z szacowania kosztów mediów {estimateDate.ToString("dd.MM.yyyy")}";
            string county = $"Powiat: {county_input.Text}";
            string unit_type = $"Rodzaj jednostki: {unit_type_input.Text}";
            string address = $"Adres: {address_input.Text}, {zip_code_input.Text} {city_input.Text}";



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

            //gfx.DrawString(textToWrite2, font, PdfSharp.Drawing.XBrushes.Black,
            //    new PdfSharp.Drawing.XRect(0, 0, page.Width, page.Height),
            //    PdfSharp.Drawing.XStringFormat.TopLeft);

            // Save the document...
            string filename = $"Szacowanie z dnia {estimateDate.ToString("dd.MM.yyyy")}.pdf";
            document.Save(filename);
            MessageBox.Show($"Twój plik {filename} jest gotowy", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // ...and start a viewer.
            // System.Diagnostics.Process.Start(filename);

            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

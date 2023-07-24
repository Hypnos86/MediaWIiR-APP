using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediaWIiR_APP
{
    internal class Servis
    {
        public void validating_selectors(ComboBox comboBox, Label errorLabel) { 
        if (comboBox.SelectedIndex != -1)
            {
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Wybież element z listy";
            }
        }

        public void validating_zip_code(TextBox zip_code)
        {
            string zipCode = zip_code.Text.Trim();

            // Wzorzec wyrażenia regularnego dla kodu pocztowego w USA (dla 5 cyfr)
            string zipCodePattern = @"^\d{2}-\d{3}$";

            // Utwórz obiekt wyrażenia regularnego
            Regex regex = new Regex(zipCodePattern);

            // Sprawdź, czy kod pocztowy pasuje do wzorca
            if (regex.IsMatch(zipCode))
            {
                // Kod pocztowy jest prawidłowy - zmień kolor tekstu na zielony
                zip_code.ForeColor = Color.Green;
            }
            else
            {
                // Kod pocztowy jest nieprawidłowy - zmień kolor tekstu na czerwony
                zip_code.ForeColor = Color.Red;
            }
        }
    }
}

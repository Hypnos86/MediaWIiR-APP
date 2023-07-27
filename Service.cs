using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediaWIiR_APP
{
    internal class Service
    {
        public bool validating_selectors(ComboBox comboBox, Label errorLabel)
        {
            if (comboBox.SelectedIndex != -1)
            {
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Wybierz element z listy";
                errorLabel.BackColor = Color.Aquamarine;

                return false;
            }
            return true;
        }

        public bool validating_text(TextBox textBox, Label errorLabel)
        {
            //sprawdz czy textbox jest uzupelniony
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                errorLabel.Visible = false;
                return true;
            }
            else
            {
                errorLabel.Visible = true;
                errorLabel.Text = "Uzupełnij pole";
                errorLabel.BackColor = Color.Aquamarine;
                return false;
            }
        }

        public bool validating_zip_code(TextBox zip_code, Label zip_code_error)
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
                zip_code_error.Visible = false;

                return true;
            }
            else
            {
                // Kod pocztowy jest nieprawidłowy - zmień kolor tekstu na czerwony
                zip_code.ForeColor = Color.Red;
                zip_code_error.Visible = true;
                zip_code_error.Text = "Użyj prawidłowego formatu";
                zip_code_error.BackColor = Color.Aquamarine;

                return false;
            }

        }

        public bool validating_data_forms(TextBox textBox, Label label_error, out int validateed_data)
        {
            string inputValue = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(textBox.Text) && int.TryParse(inputValue, out validateed_data))
            {
                label_error.Visible = false;
                return true;
            }
            else
            {
                label_error.Visible = true;
                label_error.Text = "Uzupełnij pole";
                label_error.BackColor = Color.Aquamarine;
                validateed_data = 0;
            }
            return false;
        }

        public bool validating_data_fee(TextBox textBox, Label label_error, out decimal validateed_fee)
        {
            string inputValue = textBox.Text.Trim().Replace(",", ".");
            if (!string.IsNullOrEmpty(textBox.Text) && decimal.TryParse(inputValue, out validateed_fee))
            {
                label_error.Visible = false;
                return true;
            }
            else
            {
                label_error.Visible = true;
                label_error.Text = "Uzupełnij pole";
                label_error.BackColor = Color.Aquamarine;
                validateed_fee = 0;
            }
            return false;
        }
    }
}

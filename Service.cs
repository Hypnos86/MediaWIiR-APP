using MediaWIiR_APP.Models;
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

        public bool validating_data_forms_int(TextBox textBox, Label label_error, out int validateed_data)
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

        public bool validating_data_forms_decimal(TextBox textBox, Label label_error, out decimal validateed_data)
        {
            string inputValue = textBox.Text.Trim();

            if (!string.IsNullOrEmpty(textBox.Text) && decimal.TryParse(inputValue, out validateed_data))
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
            string inputValue = textBox.Text.Trim();
            // nie robic .replace(",",".") - nowy VS sam zamienia separatory
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

        public EnergyResult estimating_energy(EnergyData energyData, EnergyTariff energyTariff)
        {
            EnergyResult energyResult = new EnergyResult();

            if (string.IsNullOrEmpty(energyTariff.Tariff))
            {
                energyResult.Tariff = "BRAK";
            }
            else
            {
                energyResult.Tariff = energyTariff.Tariff.Trim();
            }

            //Obliczanie zmiennych z mocą 
            energyResult.FixedNetworkFee = Math.Round((energyTariff.FixedNetworkFee * energyData.Power) * energyData.Month, 2);
            energyResult.TransitionFee = Math.Round((energyTariff.TransitionFee * energyData.Power) * energyData.Month, 2);

            //oplata mocowa
            energyResult.CapacirtFee = Math.Round(energyTariff.CapacirtFee * energyData.Month, 2);

            //obliczanie zmiennych z kwh
            energyResult.NetworkVariableFee = Math.Round((energyTariff.NetworkVariableFee * energyData.Kwh) * energyData.Month, 2);
            energyResult.QualityFee = Math.Round((energyTariff.QualityFee * energyData.Kwh) * energyData.Month, 2);
            energyResult.RenewableEnergySourcesFee = Math.Round(energyTariff.RenewableEnergySourcesFee * (energyData.Kwh * energyData.Month), 2);
            energyResult.CogenerationFee = Math.Round((energyTariff.CogenerationFee * energyData.Kwh) * energyData.Month, 2);

            //obliczanie abonamentu
            energyResult.SubscriptionFee = Math.Round(energyTariff.SubscriptionFee * energyData.Month, 2);

            // obliczanie sumy netto i brutto dla sprzedazy
            energyResult.SumNettoSell = Math.Round((energyTariff.KwhSell * energyData.Kwh) * energyData.Month, 2);
            energyResult.SumBruttoSell = Math.Round(energyResult.SumNettoSell + (energyResult.SumNettoSell * (energyTariff.VatValue * 0.01m)), 2);

            // obliczanie sumy netto i brutto dla OSD
            energyResult.SumNettoOsd = Math.Round(energyResult.FixedNetworkFee + energyResult.CapacirtFee + energyResult.TransitionFee + energyResult.NetworkVariableFee + energyResult.QualityFee + energyResult.RenewableEnergySourcesFee + energyResult.CogenerationFee + energyResult.SubscriptionFee, 2);
            energyResult.SumBruttoOsd = Math.Round(energyResult.SumNettoOsd + (energyResult.SumNettoOsd * (energyTariff.VatValue * 0.01m)), 2);
            energyResult.SumKwh = energyData.Kwh * energyData.Month;

            return energyResult;
        }

        public WaterResult estimating_water(WaterData waterData, WaterTariff waterTariff)
        {
            WaterResult waterResult = new WaterResult();

            if (string.IsNullOrEmpty(waterTariff.Tariff))
            {
                waterResult.Tariff = "BRAK";
            }
            else
            {
                waterResult.Tariff = waterTariff.Tariff.Trim();
            }
            waterResult.Water = Math.Round((waterTariff.Water * waterData.WaterAmount) * waterData.Month, 2);
            waterResult.Sewage = Math.Round((waterTariff.Sewage * waterData.WaterAmount) * waterData.Month, 2);
            waterResult.SubscriptionWater = Math.Round(waterTariff.SubscriptionWater * waterData.Month, 2);
            waterResult.SubscriptionSewage = Math.Round(waterTariff.SubscriptionSewage * waterData.Month, 2);

            waterResult.SumNetto = Math.Round(waterResult.Water + waterResult.Sewage + waterResult.SubscriptionWater + waterResult.SubscriptionSewage, 2);
            waterResult.SumBrutto = Math.Round(waterResult.SumNetto + (waterResult.SumNetto * (waterTariff.VatValue * 0.01m)), 2);
            waterResult.SumWater = waterData.WaterAmount * waterData.Month;

            return waterResult;
        }
        public HeatResult estimating_heat(HeatData heatData, HeatTariff heatTariff)
        {
            HeatResult heatResult = new HeatResult();
            if (string.IsNullOrEmpty(heatResult.Tariff))
            {
                heatResult.Tariff = "BRAK";
            }
            else
            {
                heatResult.Tariff = heatResult.Tariff.Trim();
            }
            heatResult.HeatFee = Math.Round((heatTariff.HeatFee * heatData.Heat) * heatData.Month, 2);
            heatResult.FixedShippingFee = Math.Round((heatTariff.FixedShippingFee * heatData.Power) * heatData.Month, 2);
            heatResult.VariableShippingFee = Math.Round((heatTariff.VariableShippingFee * heatData.Power) * heatData.Month, 2);
            heatResult.SubscriptionFee = Math.Round(heatTariff.SubscriptionFee * heatData.Month, 2);
            heatResult.CarrerFee = Math.Round((heatTariff.CarrerFee * heatData.Carrier) * heatData.Month, 2);
            heatResult.OrderedThermalPower = Math.Round((heatTariff.OrderedThermalPower * heatData.Power) * heatData.Month, 2);
            heatResult.SumGj = Math.Round(heatData.Heat * heatData.Month,2);
            heatResult.SumNetto = Math.Round(heatResult.HeatFee + heatResult.FixedShippingFee + heatResult.VariableShippingFee + heatResult.SubscriptionFee + heatResult.CarrerFee + heatResult.OrderedThermalPower, 2);
            heatResult.SumBrutto = Math.Round(heatResult.SumNetto + (heatResult.SumNetto * (heatResult.VatValue * 0.01m)), 2);
            return heatResult;
        }

        public string genering_date_now()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("dd.MM.yyyy");
            return date;
        }
    }
}

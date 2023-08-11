namespace MediaWIiR_APP
{
    partial class FormGasEstimation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGasEstimation));
            title = new Label();
            inputDataGroupBox = new GroupBox();
            unit_text = new Label();
            vat_text = new TextBox();
            vat_label = new Label();
            variableDistribution_text = new TextBox();
            fixedDistribution_text = new TextBox();
            subscribeFee_text = new TextBox();
            gasFee_text = new TextBox();
            confersion_text = new TextBox();
            textBox5 = new TextBox();
            power_text = new TextBox();
            gas_text = new TextBox();
            month_text = new TextBox();
            tariff_text = new TextBox();
            tariff_label = new Label();
            month_label = new Label();
            fixedNetworkFee_label = new Label();
            kwh_label = new Label();
            power_label = new Label();
            variableDistribution_label = new Label();
            subscribe_label = new Label();
            gassFee_label = new Label();
            fixedDistribution_label = new Label();
            estimationGroupBox = new GroupBox();
            sumM3 = new Label();
            label2 = new Label();
            sumKwh = new Label();
            kwh = new Label();
            ResultBrutto = new Label();
            brutto = new Label();
            ResultNetto = new Label();
            nettto = new Label();
            variableDistributionResult = new Label();
            fixedDistributionResult = new Label();
            subscribeFeeResult = new Label();
            gasFeeResult = new Label();
            fixedNetworkFee = new Label();
            fixedDistribution = new Label();
            subscribeFee = new Label();
            variableDistribution = new Label();
            cancel_button = new Button();
            save_to_pdf_click = new Button();
            inputDataGroupBox.SuspendLayout();
            estimationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(308, 9);
            title.Name = "title";
            title.Size = new Size(199, 28);
            title.TabIndex = 19;
            title.Text = "Analiza kosztów gazu";
            // 
            // inputDataGroupBox
            // 
            inputDataGroupBox.Controls.Add(unit_text);
            inputDataGroupBox.Controls.Add(vat_text);
            inputDataGroupBox.Controls.Add(vat_label);
            inputDataGroupBox.Controls.Add(variableDistribution_text);
            inputDataGroupBox.Controls.Add(fixedDistribution_text);
            inputDataGroupBox.Controls.Add(subscribeFee_text);
            inputDataGroupBox.Controls.Add(gasFee_text);
            inputDataGroupBox.Controls.Add(confersion_text);
            inputDataGroupBox.Controls.Add(textBox5);
            inputDataGroupBox.Controls.Add(power_text);
            inputDataGroupBox.Controls.Add(gas_text);
            inputDataGroupBox.Controls.Add(month_text);
            inputDataGroupBox.Controls.Add(tariff_text);
            inputDataGroupBox.Controls.Add(tariff_label);
            inputDataGroupBox.Controls.Add(month_label);
            inputDataGroupBox.Controls.Add(fixedNetworkFee_label);
            inputDataGroupBox.Controls.Add(kwh_label);
            inputDataGroupBox.Controls.Add(power_label);
            inputDataGroupBox.Controls.Add(variableDistribution_label);
            inputDataGroupBox.Controls.Add(subscribe_label);
            inputDataGroupBox.Controls.Add(gassFee_label);
            inputDataGroupBox.Controls.Add(fixedDistribution_label);
            inputDataGroupBox.Location = new Point(12, 40);
            inputDataGroupBox.Name = "inputDataGroupBox";
            inputDataGroupBox.Size = new Size(730, 274);
            inputDataGroupBox.TabIndex = 32;
            inputDataGroupBox.TabStop = false;
            inputDataGroupBox.Text = "Dane wejściowe";
            // 
            // unit_text
            // 
            unit_text.AutoSize = true;
            unit_text.Location = new Point(20, 25);
            unit_text.Name = "unit_text";
            unit_text.Size = new Size(28, 15);
            unit_text.TabIndex = 46;
            unit_text.Text = "unit";
            // 
            // vat_text
            // 
            vat_text.Location = new Point(559, 92);
            vat_text.Name = "vat_text";
            vat_text.ReadOnly = true;
            vat_text.Size = new Size(100, 23);
            vat_text.TabIndex = 45;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(524, 95);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 44;
            vat_label.Text = "Vat: ";
            // 
            // variableDistribution_text
            // 
            variableDistribution_text.Location = new Point(559, 227);
            variableDistribution_text.Name = "variableDistribution_text";
            variableDistribution_text.ReadOnly = true;
            variableDistribution_text.Size = new Size(100, 23);
            variableDistribution_text.TabIndex = 40;
            // 
            // fixedDistribution_text
            // 
            fixedDistribution_text.Location = new Point(559, 193);
            fixedDistribution_text.Name = "fixedDistribution_text";
            fixedDistribution_text.ReadOnly = true;
            fixedDistribution_text.Size = new Size(100, 23);
            fixedDistribution_text.TabIndex = 39;
            // 
            // subscribeFee_text
            // 
            subscribeFee_text.Location = new Point(559, 159);
            subscribeFee_text.Name = "subscribeFee_text";
            subscribeFee_text.ReadOnly = true;
            subscribeFee_text.Size = new Size(100, 23);
            subscribeFee_text.TabIndex = 38;
            // 
            // gasFee_text
            // 
            gasFee_text.Location = new Point(559, 126);
            gasFee_text.Name = "gasFee_text";
            gasFee_text.ReadOnly = true;
            gasFee_text.Size = new Size(100, 23);
            gasFee_text.TabIndex = 37;
            // 
            // confersion_text
            // 
            confersion_text.Location = new Point(232, 227);
            confersion_text.Name = "confersion_text";
            confersion_text.ReadOnly = true;
            confersion_text.Size = new Size(100, 23);
            confersion_text.TabIndex = 36;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(547, -23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 35;
            // 
            // power_text
            // 
            power_text.Location = new Point(232, 193);
            power_text.Name = "power_text";
            power_text.ReadOnly = true;
            power_text.Size = new Size(100, 23);
            power_text.TabIndex = 34;
            // 
            // gas_text
            // 
            gas_text.Location = new Point(232, 159);
            gas_text.Name = "gas_text";
            gas_text.ReadOnly = true;
            gas_text.Size = new Size(100, 23);
            gas_text.TabIndex = 33;
            // 
            // month_text
            // 
            month_text.Location = new Point(232, 126);
            month_text.Name = "month_text";
            month_text.ReadOnly = true;
            month_text.Size = new Size(100, 23);
            month_text.TabIndex = 32;
            // 
            // tariff_text
            // 
            tariff_text.Location = new Point(232, 92);
            tariff_text.Name = "tariff_text";
            tariff_text.ReadOnly = true;
            tariff_text.Size = new Size(100, 23);
            tariff_text.TabIndex = 31;
            // 
            // tariff_label
            // 
            tariff_label.AutoSize = true;
            tariff_label.Location = new Point(182, 95);
            tariff_label.Name = "tariff_label";
            tariff_label.Size = new Size(44, 15);
            tariff_label.TabIndex = 19;
            tariff_label.Text = "Taryfa: ";
            // 
            // month_label
            // 
            month_label.AutoSize = true;
            month_label.Location = new Point(131, 129);
            month_label.Name = "month_label";
            month_label.Size = new Size(95, 15);
            month_label.TabIndex = 22;
            month_label.Text = "Liczba miesięcy: ";
            // 
            // fixedNetworkFee_label
            // 
            fixedNetworkFee_label.AutoSize = true;
            fixedNetworkFee_label.Location = new Point(87, 230);
            fixedNetworkFee_label.Name = "fixedNetworkFee_label";
            fixedNetworkFee_label.Size = new Size(139, 15);
            fixedNetworkFee_label.TabIndex = 28;
            fixedNetworkFee_label.Text = "Współczynnik konwersji: ";
            // 
            // kwh_label
            // 
            kwh_label.AutoSize = true;
            kwh_label.Location = new Point(53, 162);
            kwh_label.Name = "kwh_label";
            kwh_label.Size = new Size(173, 15);
            kwh_label.TabIndex = 20;
            kwh_label.Text = "Szacowane zużycie miesięczne: ";
            // 
            // power_label
            // 
            power_label.AutoSize = true;
            power_label.Location = new Point(20, 196);
            power_label.Name = "power_label";
            power_label.Size = new Size(206, 15);
            power_label.TabIndex = 21;
            power_label.Text = "Szacowane zapotrzebowanie na moc: ";
            // 
            // variableDistribution_label
            // 
            variableDistribution_label.AutoSize = true;
            variableDistribution_label.Location = new Point(393, 230);
            variableDistribution_label.Name = "variableDistribution_label";
            variableDistribution_label.Size = new Size(160, 15);
            variableDistribution_label.TabIndex = 26;
            variableDistribution_label.Text = "Opłata dystrybucja zmienna: ";
            // 
            // subscribe_label
            // 
            subscribe_label.AutoSize = true;
            subscribe_label.Location = new Point(419, 162);
            subscribe_label.Name = "subscribe_label";
            subscribe_label.Size = new Size(134, 15);
            subscribe_label.TabIndex = 23;
            subscribe_label.Text = "Opłata abonamentowa: ";
            // 
            // gassFee_label
            // 
            gassFee_label.AutoSize = true;
            gassFee_label.Location = new Point(413, 129);
            gassFee_label.Name = "gassFee_label";
            gassFee_label.Size = new Size(140, 15);
            gassFee_label.TabIndex = 25;
            gassFee_label.Text = "Opłata za paliwo gazowe:";
            // 
            // fixedDistribution_label
            // 
            fixedDistribution_label.AutoSize = true;
            fixedDistribution_label.Location = new Point(404, 196);
            fixedDistribution_label.Name = "fixedDistribution_label";
            fixedDistribution_label.Size = new Size(149, 15);
            fixedDistribution_label.TabIndex = 24;
            fixedDistribution_label.Text = "Opłata dystrybucyjna stała:";
            // 
            // estimationGroupBox
            // 
            estimationGroupBox.Controls.Add(sumM3);
            estimationGroupBox.Controls.Add(label2);
            estimationGroupBox.Controls.Add(sumKwh);
            estimationGroupBox.Controls.Add(kwh);
            estimationGroupBox.Controls.Add(ResultBrutto);
            estimationGroupBox.Controls.Add(brutto);
            estimationGroupBox.Controls.Add(ResultNetto);
            estimationGroupBox.Controls.Add(nettto);
            estimationGroupBox.Controls.Add(variableDistributionResult);
            estimationGroupBox.Controls.Add(fixedDistributionResult);
            estimationGroupBox.Controls.Add(subscribeFeeResult);
            estimationGroupBox.Controls.Add(gasFeeResult);
            estimationGroupBox.Controls.Add(fixedNetworkFee);
            estimationGroupBox.Controls.Add(fixedDistribution);
            estimationGroupBox.Controls.Add(subscribeFee);
            estimationGroupBox.Controls.Add(variableDistribution);
            estimationGroupBox.Location = new Point(12, 320);
            estimationGroupBox.Name = "estimationGroupBox";
            estimationGroupBox.Size = new Size(730, 150);
            estimationGroupBox.TabIndex = 33;
            estimationGroupBox.TabStop = false;
            estimationGroupBox.Text = "Szcunek kosztów";
            // 
            // sumM3
            // 
            sumM3.AutoSize = true;
            sumM3.Location = new Point(559, 109);
            sumM3.Name = "sumM3";
            sumM3.Size = new Size(38, 15);
            sumM3.TabIndex = 55;
            sumM3.Text = "label4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 54;
            label2.Text = "Suma m3: ";
            // 
            // sumKwh
            // 
            sumKwh.AutoSize = true;
            sumKwh.Location = new Point(559, 79);
            sumKwh.Name = "sumKwh";
            sumKwh.Size = new Size(38, 15);
            sumKwh.TabIndex = 53;
            sumKwh.Text = "label4";
            // 
            // kwh
            // 
            kwh.AutoSize = true;
            kwh.Location = new Point(483, 79);
            kwh.Name = "kwh";
            kwh.Size = new Size(70, 15);
            kwh.TabIndex = 52;
            kwh.Text = "Suma kWh: ";
            // 
            // ResultBrutto
            // 
            ResultBrutto.AutoSize = true;
            ResultBrutto.Location = new Point(559, 49);
            ResultBrutto.Name = "ResultBrutto";
            ResultBrutto.Size = new Size(38, 15);
            ResultBrutto.TabIndex = 51;
            ResultBrutto.Text = "label4";
            // 
            // brutto
            // 
            brutto.AutoSize = true;
            brutto.Location = new Point(431, 49);
            brutto.Name = "brutto";
            brutto.Size = new Size(122, 15);
            brutto.TabIndex = 50;
            brutto.Text = "Suma kosztów brutto:";
            // 
            // ResultNetto
            // 
            ResultNetto.AutoSize = true;
            ResultNetto.Location = new Point(559, 19);
            ResultNetto.Name = "ResultNetto";
            ResultNetto.Size = new Size(38, 15);
            ResultNetto.TabIndex = 49;
            ResultNetto.Text = "label3";
            // 
            // nettto
            // 
            nettto.AutoSize = true;
            nettto.Location = new Point(436, 19);
            nettto.Name = "nettto";
            nettto.Size = new Size(117, 15);
            nettto.TabIndex = 48;
            nettto.Text = "Suma kosztów netto:";
            // 
            // variableDistributionResult
            // 
            variableDistributionResult.AutoSize = true;
            variableDistributionResult.Location = new Point(232, 109);
            variableDistributionResult.Name = "variableDistributionResult";
            variableDistributionResult.Size = new Size(44, 15);
            variableDistributionResult.TabIndex = 42;
            variableDistributionResult.Text = "label13";
            // 
            // fixedDistributionResult
            // 
            fixedDistributionResult.AutoSize = true;
            fixedDistributionResult.Location = new Point(232, 79);
            fixedDistributionResult.Name = "fixedDistributionResult";
            fixedDistributionResult.Size = new Size(44, 15);
            fixedDistributionResult.TabIndex = 41;
            fixedDistributionResult.Text = "label12";
            // 
            // subscribeFeeResult
            // 
            subscribeFeeResult.AutoSize = true;
            subscribeFeeResult.Location = new Point(232, 49);
            subscribeFeeResult.Name = "subscribeFeeResult";
            subscribeFeeResult.Size = new Size(44, 15);
            subscribeFeeResult.TabIndex = 40;
            subscribeFeeResult.Text = "label11";
            // 
            // gasFeeResult
            // 
            gasFeeResult.AutoSize = true;
            gasFeeResult.Location = new Point(232, 19);
            gasFeeResult.Name = "gasFeeResult";
            gasFeeResult.Size = new Size(44, 15);
            gasFeeResult.TabIndex = 39;
            gasFeeResult.Text = "label10";
            // 
            // fixedNetworkFee
            // 
            fixedNetworkFee.AutoSize = true;
            fixedNetworkFee.Location = new Point(87, 19);
            fixedNetworkFee.Name = "fixedNetworkFee";
            fixedNetworkFee.Size = new Size(140, 15);
            fixedNetworkFee.TabIndex = 36;
            fixedNetworkFee.Text = "Opłata za paliwo gazowe:";
            // 
            // fixedDistribution
            // 
            fixedDistribution.AutoSize = true;
            fixedDistribution.Location = new Point(77, 79);
            fixedDistribution.Name = "fixedDistribution";
            fixedDistribution.Size = new Size(149, 15);
            fixedDistribution.TabIndex = 31;
            fixedDistribution.Text = "Opłata dystrybucyjna stała:";
            // 
            // subscribeFee
            // 
            subscribeFee.AutoSize = true;
            subscribeFee.Location = new Point(95, 49);
            subscribeFee.Name = "subscribeFee";
            subscribeFee.Size = new Size(131, 15);
            subscribeFee.TabIndex = 33;
            subscribeFee.Text = "Opłata abonamentowa:";
            // 
            // variableDistribution
            // 
            variableDistribution.AutoSize = true;
            variableDistribution.Location = new Point(57, 109);
            variableDistribution.Name = "variableDistribution";
            variableDistribution.Size = new Size(170, 15);
            variableDistribution.TabIndex = 32;
            variableDistribution.Text = "Opłata dystrybucyjna zmienna:";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(592, 484);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 35;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Location = new Point(12, 484);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(150, 25);
            save_to_pdf_click.TabIndex = 34;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // FormGasEstimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 521);
            Controls.Add(cancel_button);
            Controls.Add(save_to_pdf_click);
            Controls.Add(estimationGroupBox);
            Controls.Add(inputDataGroupBox);
            Controls.Add(title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGasEstimation";
            Text = "Analiza szacowania kosztów";
            inputDataGroupBox.ResumeLayout(false);
            inputDataGroupBox.PerformLayout();
            estimationGroupBox.ResumeLayout(false);
            estimationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private GroupBox inputDataGroupBox;
        private Label unit_text;
        private TextBox vat_text;
        private Label vat_label;
        private TextBox variableDistribution_text;
        private TextBox fixedDistribution_text;
        private TextBox subscribeFee_text;
        private TextBox gasFee_text;
        private TextBox confersion_text;
        private TextBox textBox5;
        private TextBox power_text;
        private TextBox gas_text;
        private TextBox month_text;
        private TextBox tariff_text;
        private Label tariff_label;
        private Label month_label;
        private Label fixedNetworkFee_label;
        private Label kwh_label;
        private Label power_label;
        private Label variableDistribution_label;
        private Label subscribe_label;
        private Label gassFee_label;
        private Label fixedDistribution_label;
        private GroupBox estimationGroupBox;
        private Label sumKwh;
        private Label kwh;
        private Label ResultBrutto;
        private Label brutto;
        private Label ResultNetto;
        private Label nettto;
        private Label variableDistributionResult;
        private Label fixedDistributionResult;
        private Label subscribeFeeResult;
        private Label gasFeeResult;
        private Label fixedNetworkFee;
        private Label fixedDistribution;
        private Label subscribeFee;
        private Label variableDistribution;
        private Button cancel_button;
        private Button save_to_pdf_click;
        private Label sumM3;
        private Label label2;
    }
}
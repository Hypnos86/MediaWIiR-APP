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
            qualityFee_text = new TextBox();
            FixedDistribution_text = new TextBox();
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
            qualityFee_label = new Label();
            subscribe_label = new Label();
            gassFee_label = new Label();
            FixedDistribution_label = new Label();
            estimationGroupBox = new GroupBox();
            kwh_sum_text = new Label();
            kwh = new Label();
            kwhOsdResultBrutto = new Label();
            brutto = new Label();
            kwhOsdResultNetto = new Label();
            nettto = new Label();
            qualityFee_result = new Label();
            networkVariableFee_result = new Label();
            capacirtFee_result = new Label();
            transitionFee_result = new Label();
            fixedNetworkFee_result = new Label();
            fixedNetworkFee = new Label();
            qualityFee = new Label();
            capacirtFee = new Label();
            transitionFee = new Label();
            networkVariableFee = new Label();
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
            inputDataGroupBox.Controls.Add(qualityFee_text);
            inputDataGroupBox.Controls.Add(FixedDistribution_text);
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
            inputDataGroupBox.Controls.Add(qualityFee_label);
            inputDataGroupBox.Controls.Add(subscribe_label);
            inputDataGroupBox.Controls.Add(gassFee_label);
            inputDataGroupBox.Controls.Add(FixedDistribution_label);
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
            // qualityFee_text
            // 
            qualityFee_text.Location = new Point(559, 227);
            qualityFee_text.Name = "qualityFee_text";
            qualityFee_text.ReadOnly = true;
            qualityFee_text.Size = new Size(100, 23);
            qualityFee_text.TabIndex = 40;
            // 
            // FixedDistribution_text
            // 
            FixedDistribution_text.Location = new Point(559, 193);
            FixedDistribution_text.Name = "FixedDistribution_text";
            FixedDistribution_text.ReadOnly = true;
            FixedDistribution_text.Size = new Size(100, 23);
            FixedDistribution_text.TabIndex = 39;
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
            // qualityFee_label
            // 
            qualityFee_label.AutoSize = true;
            qualityFee_label.Location = new Point(446, 230);
            qualityFee_label.Name = "qualityFee_label";
            qualityFee_label.Size = new Size(107, 15);
            qualityFee_label.TabIndex = 26;
            qualityFee_label.Text = "opłata jakościowa: ";
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
            // FixedDistribution_label
            // 
            FixedDistribution_label.AutoSize = true;
            FixedDistribution_label.Location = new Point(404, 196);
            FixedDistribution_label.Name = "FixedDistribution_label";
            FixedDistribution_label.Size = new Size(149, 15);
            FixedDistribution_label.TabIndex = 24;
            FixedDistribution_label.Text = "Opłata dystrybucyjna stała:";
            // 
            // estimationGroupBox
            // 
            estimationGroupBox.Controls.Add(kwh_sum_text);
            estimationGroupBox.Controls.Add(kwh);
            estimationGroupBox.Controls.Add(kwhOsdResultBrutto);
            estimationGroupBox.Controls.Add(brutto);
            estimationGroupBox.Controls.Add(kwhOsdResultNetto);
            estimationGroupBox.Controls.Add(nettto);
            estimationGroupBox.Controls.Add(qualityFee_result);
            estimationGroupBox.Controls.Add(networkVariableFee_result);
            estimationGroupBox.Controls.Add(capacirtFee_result);
            estimationGroupBox.Controls.Add(transitionFee_result);
            estimationGroupBox.Controls.Add(fixedNetworkFee_result);
            estimationGroupBox.Controls.Add(fixedNetworkFee);
            estimationGroupBox.Controls.Add(qualityFee);
            estimationGroupBox.Controls.Add(capacirtFee);
            estimationGroupBox.Controls.Add(transitionFee);
            estimationGroupBox.Controls.Add(networkVariableFee);
            estimationGroupBox.Location = new Point(12, 320);
            estimationGroupBox.Name = "estimationGroupBox";
            estimationGroupBox.Size = new Size(730, 200);
            estimationGroupBox.TabIndex = 33;
            estimationGroupBox.TabStop = false;
            estimationGroupBox.Text = "Szcunek kosztów";
            // 
            // kwh_sum_text
            // 
            kwh_sum_text.AutoSize = true;
            kwh_sum_text.Location = new Point(559, 79);
            kwh_sum_text.Name = "kwh_sum_text";
            kwh_sum_text.Size = new Size(38, 15);
            kwh_sum_text.TabIndex = 53;
            kwh_sum_text.Text = "label4";
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
            // kwhOsdResultBrutto
            // 
            kwhOsdResultBrutto.AutoSize = true;
            kwhOsdResultBrutto.Location = new Point(559, 49);
            kwhOsdResultBrutto.Name = "kwhOsdResultBrutto";
            kwhOsdResultBrutto.Size = new Size(38, 15);
            kwhOsdResultBrutto.TabIndex = 51;
            kwhOsdResultBrutto.Text = "label4";
            // 
            // brutto
            // 
            brutto.AutoSize = true;
            brutto.Location = new Point(405, 49);
            brutto.Name = "brutto";
            brutto.Size = new Size(148, 15);
            brutto.TabIndex = 50;
            brutto.Text = "Suma kosztów OSD brutto:";
            // 
            // kwhOsdResultNetto
            // 
            kwhOsdResultNetto.AutoSize = true;
            kwhOsdResultNetto.Location = new Point(559, 19);
            kwhOsdResultNetto.Name = "kwhOsdResultNetto";
            kwhOsdResultNetto.Size = new Size(38, 15);
            kwhOsdResultNetto.TabIndex = 49;
            kwhOsdResultNetto.Text = "label3";
            // 
            // nettto
            // 
            nettto.AutoSize = true;
            nettto.Location = new Point(407, 19);
            nettto.Name = "nettto";
            nettto.Size = new Size(146, 15);
            nettto.TabIndex = 48;
            nettto.Text = "Suma kosztów OSD netto: ";
            // 
            // qualityFee_result
            // 
            qualityFee_result.AutoSize = true;
            qualityFee_result.Location = new Point(232, 139);
            qualityFee_result.Name = "qualityFee_result";
            qualityFee_result.Size = new Size(44, 15);
            qualityFee_result.TabIndex = 43;
            qualityFee_result.Text = "label14";
            // 
            // networkVariableFee_result
            // 
            networkVariableFee_result.AutoSize = true;
            networkVariableFee_result.Location = new Point(232, 109);
            networkVariableFee_result.Name = "networkVariableFee_result";
            networkVariableFee_result.Size = new Size(44, 15);
            networkVariableFee_result.TabIndex = 42;
            networkVariableFee_result.Text = "label13";
            // 
            // capacirtFee_result
            // 
            capacirtFee_result.AutoSize = true;
            capacirtFee_result.Location = new Point(232, 79);
            capacirtFee_result.Name = "capacirtFee_result";
            capacirtFee_result.Size = new Size(44, 15);
            capacirtFee_result.TabIndex = 41;
            capacirtFee_result.Text = "label12";
            // 
            // transitionFee_result
            // 
            transitionFee_result.AutoSize = true;
            transitionFee_result.Location = new Point(232, 49);
            transitionFee_result.Name = "transitionFee_result";
            transitionFee_result.Size = new Size(44, 15);
            transitionFee_result.TabIndex = 40;
            transitionFee_result.Text = "label11";
            // 
            // fixedNetworkFee_result
            // 
            fixedNetworkFee_result.AutoSize = true;
            fixedNetworkFee_result.Location = new Point(232, 19);
            fixedNetworkFee_result.Name = "fixedNetworkFee_result";
            fixedNetworkFee_result.Size = new Size(44, 15);
            fixedNetworkFee_result.TabIndex = 39;
            fixedNetworkFee_result.Text = "label10";
            // 
            // fixedNetworkFee
            // 
            fixedNetworkFee.AutoSize = true;
            fixedNetworkFee.Location = new Point(102, 19);
            fixedNetworkFee.Name = "fixedNetworkFee";
            fixedNetworkFee.Size = new Size(121, 15);
            fixedNetworkFee.TabIndex = 36;
            fixedNetworkFee.Text = "opłata stała sieciowa: ";
            // 
            // qualityFee
            // 
            qualityFee.AutoSize = true;
            qualityFee.Location = new Point(112, 139);
            qualityFee.Name = "qualityFee";
            qualityFee.Size = new Size(107, 15);
            qualityFee.TabIndex = 34;
            qualityFee.Text = "opłata jakościowa: ";
            // 
            // capacirtFee
            // 
            capacirtFee.AutoSize = true;
            capacirtFee.Location = new Point(127, 79);
            capacirtFee.Name = "capacirtFee";
            capacirtFee.Size = new Size(95, 15);
            capacirtFee.TabIndex = 31;
            capacirtFee.Text = "opłata mocowa: ";
            // 
            // transitionFee
            // 
            transitionFee.AutoSize = true;
            transitionFee.Location = new Point(112, 49);
            transitionFee.Name = "transitionFee";
            transitionFee.Size = new Size(110, 15);
            transitionFee.TabIndex = 33;
            transitionFee.Text = "opłata przejściowa: ";
            // 
            // networkVariableFee
            // 
            networkVariableFee.AutoSize = true;
            networkVariableFee.Location = new Point(81, 109);
            networkVariableFee.Name = "networkVariableFee";
            networkVariableFee.Size = new Size(142, 15);
            networkVariableFee.TabIndex = 32;
            networkVariableFee.Text = "opłata zmienna sieciowa: ";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(592, 534);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 35;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Location = new Point(12, 534);
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
            ClientSize = new Size(754, 571);
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
        private TextBox qualityFee_text;
        private TextBox FixedDistribution_text;
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
        private Label qualityFee_label;
        private Label subscribe_label;
        private Label gassFee_label;
        private Label FixedDistribution_label;
        private GroupBox estimationGroupBox;
        private Label kwh_sum_text;
        private Label kwh;
        private Label kwhOsdResultBrutto;
        private Label brutto;
        private Label kwhOsdResultNetto;
        private Label nettto;
        private Label qualityFee_result;
        private Label networkVariableFee_result;
        private Label capacirtFee_result;
        private Label transitionFee_result;
        private Label fixedNetworkFee_result;
        private Label fixedNetworkFee;
        private Label qualityFee;
        private Label capacirtFee;
        private Label transitionFee;
        private Label networkVariableFee;
        private Button cancel_button;
        private Button save_to_pdf_click;
    }
}
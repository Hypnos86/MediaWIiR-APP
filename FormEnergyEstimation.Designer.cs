namespace MediaWIiR_APP
{
    partial class FormEnergyEstimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnergyEstimation));
            save_to_pdf_click = new Button();
            cancel_button = new Button();
            title = new Label();
            tariff_label = new Label();
            kwh_label = new Label();
            power_label = new Label();
            month_label = new Label();
            capacirtFee_input = new Label();
            networkVariableFee_label = new Label();
            transitionFee_label = new Label();
            qualityFee_label = new Label();
            renewableEnergySourcesFee_label = new Label();
            fixedNetworkFee_label = new Label();
            cogenerationFee_label = new Label();
            subscriptionFee_label = new Label();
            inputDataGroupBox = new GroupBox();
            unit_text = new Label();
            vat_text = new TextBox();
            vat_label = new Label();
            subscriptionFee_text = new TextBox();
            cogenerationFee_text = new TextBox();
            renewableEnergySourcesFee_text = new TextBox();
            qualityFee_text = new TextBox();
            networkVariableFee_text = new TextBox();
            capacirtFee_text = new TextBox();
            transitionFee_text = new TextBox();
            fixedNetworkFee_text = new TextBox();
            textBox5 = new TextBox();
            power_text = new TextBox();
            kwh_text = new TextBox();
            month_text = new TextBox();
            tariff_text = new TextBox();
            estimztionGroupBox = new GroupBox();
            kwh_sum_text = new Label();
            kwh = new Label();
            brutto_label = new Label();
            brutto = new Label();
            netto_label = new Label();
            nettto = new Label();
            subscriptionFee_result = new Label();
            subscriptionFee = new Label();
            cogenerationFee_result = new Label();
            renewableEnergySourcesFee_result = new Label();
            qualityFee_result = new Label();
            networkVariableFee_result = new Label();
            capacirtFee_result = new Label();
            transitionFee_result = new Label();
            fixedNetworkFee_result = new Label();
            cogenerationFee = new Label();
            fixedNetworkFee = new Label();
            renewableEnergySourcesFee = new Label();
            qualityFee = new Label();
            capacirtFee = new Label();
            transitionFee = new Label();
            networkVariableFee = new Label();
            inputDataGroupBox.SuspendLayout();
            estimztionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Location = new Point(12, 630);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(150, 25);
            save_to_pdf_click.TabIndex = 16;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(626, 630);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 17;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(223, 9);
            title.Name = "title";
            title.Size = new Size(325, 28);
            title.TabIndex = 18;
            title.Text = "Analiza kosztów energii elektrycznej";
            // 
            // tariff_label
            // 
            tariff_label.AutoSize = true;
            tariff_label.Location = new Point(182, 126);
            tariff_label.Name = "tariff_label";
            tariff_label.Size = new Size(44, 15);
            tariff_label.TabIndex = 19;
            tariff_label.Text = "Taryfa: ";
            // 
            // kwh_label
            // 
            kwh_label.AutoSize = true;
            kwh_label.Location = new Point(53, 193);
            kwh_label.Name = "kwh_label";
            kwh_label.Size = new Size(173, 15);
            kwh_label.TabIndex = 20;
            kwh_label.Text = "Szacowane zużycie miesięczne: ";
            // 
            // power_label
            // 
            power_label.AutoSize = true;
            power_label.Location = new Point(20, 227);
            power_label.Name = "power_label";
            power_label.Size = new Size(206, 15);
            power_label.TabIndex = 21;
            power_label.Text = "Szacowane zapotrzebowanie na moc: ";
            power_label.Click += power_label_Click;
            // 
            // month_label
            // 
            month_label.AutoSize = true;
            month_label.Location = new Point(131, 160);
            month_label.Name = "month_label";
            month_label.Size = new Size(95, 15);
            month_label.TabIndex = 22;
            month_label.Text = "Liczba miesięcy: ";
            // 
            // capacirtFee_input
            // 
            capacirtFee_input.AutoSize = true;
            capacirtFee_input.Location = new Point(458, 92);
            capacirtFee_input.Name = "capacirtFee_input";
            capacirtFee_input.Size = new Size(95, 15);
            capacirtFee_input.TabIndex = 23;
            capacirtFee_input.Text = "opłata mocowa: ";
            // 
            // networkVariableFee_label
            // 
            networkVariableFee_label.AutoSize = true;
            networkVariableFee_label.Location = new Point(411, 126);
            networkVariableFee_label.Name = "networkVariableFee_label";
            networkVariableFee_label.Size = new Size(142, 15);
            networkVariableFee_label.TabIndex = 24;
            networkVariableFee_label.Text = "opłata zmienna sieciowa: ";
            // 
            // transitionFee_label
            // 
            transitionFee_label.AutoSize = true;
            transitionFee_label.Location = new Point(443, 59);
            transitionFee_label.Name = "transitionFee_label";
            transitionFee_label.Size = new Size(110, 15);
            transitionFee_label.TabIndex = 25;
            transitionFee_label.Text = "opłata przejściowa: ";
            // 
            // qualityFee_label
            // 
            qualityFee_label.AutoSize = true;
            qualityFee_label.Location = new Point(446, 160);
            qualityFee_label.Name = "qualityFee_label";
            qualityFee_label.Size = new Size(107, 15);
            qualityFee_label.TabIndex = 26;
            qualityFee_label.Text = "opłata jakościowa: ";
            // 
            // renewableEnergySourcesFee_label
            // 
            renewableEnergySourcesFee_label.AutoSize = true;
            renewableEnergySourcesFee_label.Location = new Point(482, 194);
            renewableEnergySourcesFee_label.Name = "renewableEnergySourcesFee_label";
            renewableEnergySourcesFee_label.Size = new Size(71, 15);
            renewableEnergySourcesFee_label.TabIndex = 27;
            renewableEnergySourcesFee_label.Text = "opłata OZE: ";
            // 
            // fixedNetworkFee_label
            // 
            fixedNetworkFee_label.AutoSize = true;
            fixedNetworkFee_label.Location = new Point(432, 25);
            fixedNetworkFee_label.Name = "fixedNetworkFee_label";
            fixedNetworkFee_label.Size = new Size(121, 15);
            fixedNetworkFee_label.TabIndex = 28;
            fixedNetworkFee_label.Text = "opłata stała sieciowa: ";
            // 
            // cogenerationFee_label
            // 
            cogenerationFee_label.AutoSize = true;
            cogenerationFee_label.Location = new Point(427, 228);
            cogenerationFee_label.Name = "cogenerationFee_label";
            cogenerationFee_label.Size = new Size(126, 15);
            cogenerationFee_label.TabIndex = 29;
            cogenerationFee_label.Text = "opłata kogeneracyjna: ";
            // 
            // subscriptionFee_label
            // 
            subscriptionFee_label.AutoSize = true;
            subscriptionFee_label.Location = new Point(421, 263);
            subscriptionFee_label.Name = "subscriptionFee_label";
            subscriptionFee_label.Size = new Size(132, 15);
            subscriptionFee_label.TabIndex = 30;
            subscriptionFee_label.Text = "opłata abonamentowa: ";
            // 
            // inputDataGroupBox
            // 
            inputDataGroupBox.Controls.Add(unit_text);
            inputDataGroupBox.Controls.Add(vat_text);
            inputDataGroupBox.Controls.Add(vat_label);
            inputDataGroupBox.Controls.Add(subscriptionFee_text);
            inputDataGroupBox.Controls.Add(cogenerationFee_text);
            inputDataGroupBox.Controls.Add(renewableEnergySourcesFee_text);
            inputDataGroupBox.Controls.Add(qualityFee_text);
            inputDataGroupBox.Controls.Add(networkVariableFee_text);
            inputDataGroupBox.Controls.Add(capacirtFee_text);
            inputDataGroupBox.Controls.Add(transitionFee_text);
            inputDataGroupBox.Controls.Add(fixedNetworkFee_text);
            inputDataGroupBox.Controls.Add(textBox5);
            inputDataGroupBox.Controls.Add(power_text);
            inputDataGroupBox.Controls.Add(kwh_text);
            inputDataGroupBox.Controls.Add(month_text);
            inputDataGroupBox.Controls.Add(tariff_text);
            inputDataGroupBox.Controls.Add(tariff_label);
            inputDataGroupBox.Controls.Add(subscriptionFee_label);
            inputDataGroupBox.Controls.Add(cogenerationFee_label);
            inputDataGroupBox.Controls.Add(month_label);
            inputDataGroupBox.Controls.Add(fixedNetworkFee_label);
            inputDataGroupBox.Controls.Add(kwh_label);
            inputDataGroupBox.Controls.Add(renewableEnergySourcesFee_label);
            inputDataGroupBox.Controls.Add(power_label);
            inputDataGroupBox.Controls.Add(qualityFee_label);
            inputDataGroupBox.Controls.Add(capacirtFee_input);
            inputDataGroupBox.Controls.Add(transitionFee_label);
            inputDataGroupBox.Controls.Add(networkVariableFee_label);
            inputDataGroupBox.Location = new Point(12, 40);
            inputDataGroupBox.Name = "inputDataGroupBox";
            inputDataGroupBox.Size = new Size(760, 300);
            inputDataGroupBox.TabIndex = 31;
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
            vat_text.Location = new Point(232, 258);
            vat_text.Name = "vat_text";
            vat_text.ReadOnly = true;
            vat_text.Size = new Size(100, 23);
            vat_text.TabIndex = 45;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(197, 261);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 44;
            vat_label.Text = "Vat: ";
            // 
            // subscriptionFee_text
            // 
            subscriptionFee_text.Location = new Point(559, 260);
            subscriptionFee_text.Name = "subscriptionFee_text";
            subscriptionFee_text.ReadOnly = true;
            subscriptionFee_text.Size = new Size(100, 23);
            subscriptionFee_text.TabIndex = 43;
            // 
            // cogenerationFee_text
            // 
            cogenerationFee_text.Location = new Point(559, 225);
            cogenerationFee_text.Name = "cogenerationFee_text";
            cogenerationFee_text.ReadOnly = true;
            cogenerationFee_text.Size = new Size(100, 23);
            cogenerationFee_text.TabIndex = 42;
            // 
            // renewableEnergySourcesFee_text
            // 
            renewableEnergySourcesFee_text.Location = new Point(559, 191);
            renewableEnergySourcesFee_text.Name = "renewableEnergySourcesFee_text";
            renewableEnergySourcesFee_text.ReadOnly = true;
            renewableEnergySourcesFee_text.Size = new Size(100, 23);
            renewableEnergySourcesFee_text.TabIndex = 41;
            // 
            // qualityFee_text
            // 
            qualityFee_text.Location = new Point(559, 157);
            qualityFee_text.Name = "qualityFee_text";
            qualityFee_text.ReadOnly = true;
            qualityFee_text.Size = new Size(100, 23);
            qualityFee_text.TabIndex = 40;
            // 
            // networkVariableFee_text
            // 
            networkVariableFee_text.Location = new Point(559, 123);
            networkVariableFee_text.Name = "networkVariableFee_text";
            networkVariableFee_text.ReadOnly = true;
            networkVariableFee_text.Size = new Size(100, 23);
            networkVariableFee_text.TabIndex = 39;
            // 
            // capacirtFee_text
            // 
            capacirtFee_text.Location = new Point(559, 89);
            capacirtFee_text.Name = "capacirtFee_text";
            capacirtFee_text.ReadOnly = true;
            capacirtFee_text.Size = new Size(100, 23);
            capacirtFee_text.TabIndex = 38;
            // 
            // transitionFee_text
            // 
            transitionFee_text.Location = new Point(559, 56);
            transitionFee_text.Name = "transitionFee_text";
            transitionFee_text.ReadOnly = true;
            transitionFee_text.Size = new Size(100, 23);
            transitionFee_text.TabIndex = 37;
            // 
            // fixedNetworkFee_text
            // 
            fixedNetworkFee_text.Location = new Point(559, 22);
            fixedNetworkFee_text.Name = "fixedNetworkFee_text";
            fixedNetworkFee_text.ReadOnly = true;
            fixedNetworkFee_text.Size = new Size(100, 23);
            fixedNetworkFee_text.TabIndex = 36;
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
            power_text.Location = new Point(232, 224);
            power_text.Name = "power_text";
            power_text.ReadOnly = true;
            power_text.Size = new Size(100, 23);
            power_text.TabIndex = 34;
            // 
            // kwh_text
            // 
            kwh_text.Location = new Point(232, 190);
            kwh_text.Name = "kwh_text";
            kwh_text.ReadOnly = true;
            kwh_text.Size = new Size(100, 23);
            kwh_text.TabIndex = 33;
            // 
            // month_text
            // 
            month_text.Location = new Point(232, 157);
            month_text.Name = "month_text";
            month_text.ReadOnly = true;
            month_text.Size = new Size(100, 23);
            month_text.TabIndex = 32;
            // 
            // tariff_text
            // 
            tariff_text.Location = new Point(232, 123);
            tariff_text.Name = "tariff_text";
            tariff_text.ReadOnly = true;
            tariff_text.Size = new Size(100, 23);
            tariff_text.TabIndex = 31;
            // 
            // estimztionGroupBox
            // 
            estimztionGroupBox.Controls.Add(kwh_sum_text);
            estimztionGroupBox.Controls.Add(kwh);
            estimztionGroupBox.Controls.Add(brutto_label);
            estimztionGroupBox.Controls.Add(brutto);
            estimztionGroupBox.Controls.Add(netto_label);
            estimztionGroupBox.Controls.Add(nettto);
            estimztionGroupBox.Controls.Add(subscriptionFee_result);
            estimztionGroupBox.Controls.Add(subscriptionFee);
            estimztionGroupBox.Controls.Add(cogenerationFee_result);
            estimztionGroupBox.Controls.Add(renewableEnergySourcesFee_result);
            estimztionGroupBox.Controls.Add(qualityFee_result);
            estimztionGroupBox.Controls.Add(networkVariableFee_result);
            estimztionGroupBox.Controls.Add(capacirtFee_result);
            estimztionGroupBox.Controls.Add(transitionFee_result);
            estimztionGroupBox.Controls.Add(fixedNetworkFee_result);
            estimztionGroupBox.Controls.Add(cogenerationFee);
            estimztionGroupBox.Controls.Add(fixedNetworkFee);
            estimztionGroupBox.Controls.Add(renewableEnergySourcesFee);
            estimztionGroupBox.Controls.Add(qualityFee);
            estimztionGroupBox.Controls.Add(capacirtFee);
            estimztionGroupBox.Controls.Add(transitionFee);
            estimztionGroupBox.Controls.Add(networkVariableFee);
            estimztionGroupBox.Location = new Point(12, 346);
            estimztionGroupBox.Name = "estimztionGroupBox";
            estimztionGroupBox.Size = new Size(760, 268);
            estimztionGroupBox.TabIndex = 32;
            estimztionGroupBox.TabStop = false;
            estimztionGroupBox.Text = "Szcunek kosztów";
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
            // brutto_label
            // 
            brutto_label.AutoSize = true;
            brutto_label.Location = new Point(559, 49);
            brutto_label.Name = "brutto_label";
            brutto_label.Size = new Size(38, 15);
            brutto_label.TabIndex = 51;
            brutto_label.Text = "label4";
            // 
            // brutto
            // 
            brutto.AutoSize = true;
            brutto.Location = new Point(427, 49);
            brutto.Name = "brutto";
            brutto.Size = new Size(126, 15);
            brutto.TabIndex = 50;
            brutto.Text = "Suma wartości Brutto: ";
            // 
            // netto_label
            // 
            netto_label.AutoSize = true;
            netto_label.Location = new Point(559, 19);
            netto_label.Name = "netto_label";
            netto_label.Size = new Size(38, 15);
            netto_label.TabIndex = 49;
            netto_label.Text = "label3";
            // 
            // nettto
            // 
            nettto.AutoSize = true;
            nettto.Location = new Point(425, 19);
            nettto.Name = "nettto";
            nettto.Size = new Size(128, 15);
            nettto.TabIndex = 48;
            nettto.Text = "Suma szacunku Netto: ";
            // 
            // subscriptionFee_result
            // 
            subscriptionFee_result.AutoSize = true;
            subscriptionFee_result.Location = new Point(232, 228);
            subscriptionFee_result.Name = "subscriptionFee_result";
            subscriptionFee_result.Size = new Size(38, 15);
            subscriptionFee_result.TabIndex = 47;
            subscriptionFee_result.Text = "label2";
            // 
            // subscriptionFee
            // 
            subscriptionFee.AutoSize = true;
            subscriptionFee.Location = new Point(91, 228);
            subscriptionFee.Name = "subscriptionFee";
            subscriptionFee.Size = new Size(132, 15);
            subscriptionFee.TabIndex = 46;
            subscriptionFee.Text = "opłata abonamentowa: ";
            // 
            // cogenerationFee_result
            // 
            cogenerationFee_result.AutoSize = true;
            cogenerationFee_result.Location = new Point(232, 199);
            cogenerationFee_result.Name = "cogenerationFee_result";
            cogenerationFee_result.Size = new Size(44, 15);
            cogenerationFee_result.TabIndex = 45;
            cogenerationFee_result.Text = "label16";
            // 
            // renewableEnergySourcesFee_result
            // 
            renewableEnergySourcesFee_result.AutoSize = true;
            renewableEnergySourcesFee_result.Location = new Point(232, 169);
            renewableEnergySourcesFee_result.Name = "renewableEnergySourcesFee_result";
            renewableEnergySourcesFee_result.Size = new Size(44, 15);
            renewableEnergySourcesFee_result.TabIndex = 44;
            renewableEnergySourcesFee_result.Text = "label15";
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
            fixedNetworkFee_result.Click += fixedNetworkFee_result_Click;
            // 
            // cogenerationFee
            // 
            cogenerationFee.AutoSize = true;
            cogenerationFee.Location = new Point(96, 199);
            cogenerationFee.Name = "cogenerationFee";
            cogenerationFee.Size = new Size(126, 15);
            cogenerationFee.TabIndex = 37;
            cogenerationFee.Text = "opłata kogeneracyjna: ";
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
            // renewableEnergySourcesFee
            // 
            renewableEnergySourcesFee.AutoSize = true;
            renewableEnergySourcesFee.Location = new Point(151, 169);
            renewableEnergySourcesFee.Name = "renewableEnergySourcesFee";
            renewableEnergySourcesFee.Size = new Size(71, 15);
            renewableEnergySourcesFee.TabIndex = 35;
            renewableEnergySourcesFee.Text = "opłata OZE: ";
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
            // FormEnergyEstimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 667);
            Controls.Add(estimztionGroupBox);
            Controls.Add(inputDataGroupBox);
            Controls.Add(title);
            Controls.Add(cancel_button);
            Controls.Add(save_to_pdf_click);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEnergyEstimation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analiza szacowania kosztów";
            inputDataGroupBox.ResumeLayout(false);
            inputDataGroupBox.PerformLayout();
            estimztionGroupBox.ResumeLayout(false);
            estimztionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_to_pdf_click;
        private Button cancel_button;
        private Label title;
        private Label tariff_label;
        private Label kwh_label;
        private Label power_label;
        private Label month_label;
        private Label capacirtFee_input;
        private Label networkVariableFee_label;
        private Label transitionFee_label;
        private Label qualityFee_label;
        private Label renewableEnergySourcesFee_label;
        private Label fixedNetworkFee_label;
        private Label cogenerationFee_label;
        private Label subscriptionFee_label;
        private GroupBox inputDataGroupBox;
        private TextBox subscriptionFee_text;
        private TextBox cogenerationFee_text;
        private TextBox renewableEnergySourcesFee_text;
        private TextBox qualityFee_text;
        private TextBox networkVariableFee_text;
        private TextBox capacirtFee_text;
        private TextBox transitionFee_text;
        private TextBox fixedNetworkFee_text;
        private TextBox textBox5;
        private TextBox power_text;
        private TextBox kwh_text;
        private TextBox month_text;
        private TextBox tariff_text;
        private GroupBox estimztionGroupBox;
        private Label cogenerationFee_result;
        private Label renewableEnergySourcesFee_result;
        private Label qualityFee_result;
        private Label networkVariableFee_result;
        private Label capacirtFee_result;
        private Label transitionFee_result;
        private Label fixedNetworkFee_result;
        private Label cogenerationFee;
        private Label fixedNetworkFee;
        private Label renewableEnergySourcesFee;
        private Label qualityFee;
        private Label capacirtFee;
        private Label transitionFee;
        private Label networkVariableFee;
        private TextBox vat_text;
        private Label vat_label;
        private Label subscriptionFee;
        private Label subscriptionFee_result;
        private Label brutto_label;
        private Label brutto;
        private Label netto_label;
        private Label nettto;
        private Label kwh_sum_text;
        private Label kwh;
        private Label unit_text;
    }
}
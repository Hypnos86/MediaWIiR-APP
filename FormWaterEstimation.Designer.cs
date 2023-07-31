namespace MediaWIiR_APP
{
    partial class FormWaterEstimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaterEstimation));
            title = new Label();
            inputDataGroupBox = new GroupBox();
            unit_text = new Label();
            vat_text = new TextBox();
            vat_label = new Label();
            sewage_subscription_text = new TextBox();
            water_subscription_text = new TextBox();
            sewage_text = new TextBox();
            water_text = new TextBox();
            textBox5 = new TextBox();
            estimate_text = new TextBox();
            month_text = new TextBox();
            tariff_text = new TextBox();
            tariff_label = new Label();
            month_label = new Label();
            water_label = new Label();
            kwh_label = new Label();
            water_subscription_label = new Label();
            sewage_label = new Label();
            sewage_subscription_label = new Label();
            estimztionGroupBox = new GroupBox();
            water_sum_text = new Label();
            sumWater = new Label();
            brutto_label = new Label();
            brutto = new Label();
            netto_label = new Label();
            label2 = new Label();
            sewage_subscribtion_result = new Label();
            water_subscribe_result = new Label();
            sewage_result = new Label();
            water_result = new Label();
            water = new Label();
            water_subscription = new Label();
            sewage = new Label();
            sewage_subscription = new Label();
            cancel_button = new Button();
            save_to_pdf_click = new Button();
            inputDataGroupBox.SuspendLayout();
            estimztionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(274, 9);
            title.Name = "title";
            title.Size = new Size(209, 28);
            title.TabIndex = 0;
            title.Text = "Analiza kosztów Wody";
            // 
            // inputDataGroupBox
            // 
            inputDataGroupBox.Controls.Add(unit_text);
            inputDataGroupBox.Controls.Add(vat_text);
            inputDataGroupBox.Controls.Add(vat_label);
            inputDataGroupBox.Controls.Add(sewage_subscription_text);
            inputDataGroupBox.Controls.Add(water_subscription_text);
            inputDataGroupBox.Controls.Add(sewage_text);
            inputDataGroupBox.Controls.Add(water_text);
            inputDataGroupBox.Controls.Add(textBox5);
            inputDataGroupBox.Controls.Add(estimate_text);
            inputDataGroupBox.Controls.Add(month_text);
            inputDataGroupBox.Controls.Add(tariff_text);
            inputDataGroupBox.Controls.Add(tariff_label);
            inputDataGroupBox.Controls.Add(month_label);
            inputDataGroupBox.Controls.Add(water_label);
            inputDataGroupBox.Controls.Add(kwh_label);
            inputDataGroupBox.Controls.Add(water_subscription_label);
            inputDataGroupBox.Controls.Add(sewage_label);
            inputDataGroupBox.Controls.Add(sewage_subscription_label);
            inputDataGroupBox.Location = new Point(12, 40);
            inputDataGroupBox.Name = "inputDataGroupBox";
            inputDataGroupBox.Size = new Size(690, 268);
            inputDataGroupBox.TabIndex = 1;
            inputDataGroupBox.TabStop = false;
            inputDataGroupBox.Text = "Dane wejściowe";
            // 
            // unit_text
            // 
            unit_text.AutoSize = true;
            unit_text.Location = new Point(20, 25);
            unit_text.Name = "unit_text";
            unit_text.Size = new Size(28, 15);
            unit_text.TabIndex = 2;
            unit_text.Text = "unit";
            // 
            // vat_text
            // 
            vat_text.Location = new Point(232, 225);
            vat_text.Name = "vat_text";
            vat_text.ReadOnly = true;
            vat_text.Size = new Size(100, 23);
            vat_text.TabIndex = 6;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(197, 228);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 14;
            vat_label.Text = "Vat: ";
            // 
            // sewage_subscription_text
            // 
            sewage_subscription_text.Location = new Point(525, 224);
            sewage_subscription_text.Name = "sewage_subscription_text";
            sewage_subscription_text.ReadOnly = true;
            sewage_subscription_text.Size = new Size(100, 23);
            sewage_subscription_text.TabIndex = 10;
            // 
            // water_subscription_text
            // 
            water_subscription_text.Location = new Point(525, 190);
            water_subscription_text.Name = "water_subscription_text";
            water_subscription_text.ReadOnly = true;
            water_subscription_text.Size = new Size(100, 23);
            water_subscription_text.TabIndex = 9;
            // 
            // sewage_text
            // 
            sewage_text.Location = new Point(525, 157);
            sewage_text.Name = "sewage_text";
            sewage_text.ReadOnly = true;
            sewage_text.Size = new Size(100, 23);
            sewage_text.TabIndex = 8;
            // 
            // water_text
            // 
            water_text.Location = new Point(525, 123);
            water_text.Name = "water_text";
            water_text.ReadOnly = true;
            water_text.Size = new Size(100, 23);
            water_text.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(547, -23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 35;
            // 
            // estimate_text
            // 
            estimate_text.Location = new Point(232, 190);
            estimate_text.Name = "estimate_text";
            estimate_text.ReadOnly = true;
            estimate_text.Size = new Size(100, 23);
            estimate_text.TabIndex = 5;
            // 
            // month_text
            // 
            month_text.Location = new Point(232, 157);
            month_text.Name = "month_text";
            month_text.ReadOnly = true;
            month_text.Size = new Size(100, 23);
            month_text.TabIndex = 4;
            // 
            // tariff_text
            // 
            tariff_text.Location = new Point(232, 123);
            tariff_text.Name = "tariff_text";
            tariff_text.ReadOnly = true;
            tariff_text.Size = new Size(100, 23);
            tariff_text.TabIndex = 3;
            // 
            // tariff_label
            // 
            tariff_label.AutoSize = true;
            tariff_label.Location = new Point(182, 126);
            tariff_label.Name = "tariff_label";
            tariff_label.Size = new Size(44, 15);
            tariff_label.TabIndex = 11;
            tariff_label.Text = "Taryfa: ";
            // 
            // month_label
            // 
            month_label.AutoSize = true;
            month_label.Location = new Point(131, 160);
            month_label.Name = "month_label";
            month_label.Size = new Size(95, 15);
            month_label.TabIndex = 12;
            month_label.Text = "Liczba miesięcy: ";
            // 
            // water_label
            // 
            water_label.AutoSize = true;
            water_label.Location = new Point(383, 126);
            water_label.Name = "water_label";
            water_label.Size = new Size(136, 15);
            water_label.TabIndex = 15;
            water_label.Text = "Woda - m3 - cene netto:";
            // 
            // kwh_label
            // 
            kwh_label.AutoSize = true;
            kwh_label.Location = new Point(53, 193);
            kwh_label.Name = "kwh_label";
            kwh_label.Size = new Size(173, 15);
            kwh_label.TabIndex = 13;
            kwh_label.Text = "Szacowane zużycie miesięczne: ";
            // 
            // water_subscription_label
            // 
            water_subscription_label.AutoSize = true;
            water_subscription_label.Location = new Point(403, 193);
            water_subscription_label.Name = "water_subscription_label";
            water_subscription_label.Size = new Size(116, 15);
            water_subscription_label.TabIndex = 17;
            water_subscription_label.Text = "Woda - abonament: ";
            // 
            // sewage_label
            // 
            sewage_label.AutoSize = true;
            sewage_label.Location = new Point(384, 160);
            sewage_label.Name = "sewage_label";
            sewage_label.Size = new Size(135, 15);
            sewage_label.TabIndex = 16;
            sewage_label.Text = "Ścieki - m3 - cene netto:";
            // 
            // sewage_subscription_label
            // 
            sewage_subscription_label.AutoSize = true;
            sewage_subscription_label.Location = new Point(404, 228);
            sewage_subscription_label.Name = "sewage_subscription_label";
            sewage_subscription_label.Size = new Size(115, 15);
            sewage_subscription_label.TabIndex = 18;
            sewage_subscription_label.Text = "Ścieki - abonament: ";
            // 
            // estimztionGroupBox
            // 
            estimztionGroupBox.Controls.Add(water_sum_text);
            estimztionGroupBox.Controls.Add(sumWater);
            estimztionGroupBox.Controls.Add(brutto_label);
            estimztionGroupBox.Controls.Add(brutto);
            estimztionGroupBox.Controls.Add(netto_label);
            estimztionGroupBox.Controls.Add(label2);
            estimztionGroupBox.Controls.Add(sewage_subscribtion_result);
            estimztionGroupBox.Controls.Add(water_subscribe_result);
            estimztionGroupBox.Controls.Add(sewage_result);
            estimztionGroupBox.Controls.Add(water_result);
            estimztionGroupBox.Controls.Add(water);
            estimztionGroupBox.Controls.Add(water_subscription);
            estimztionGroupBox.Controls.Add(sewage);
            estimztionGroupBox.Controls.Add(sewage_subscription);
            estimztionGroupBox.Location = new Point(12, 314);
            estimztionGroupBox.Name = "estimztionGroupBox";
            estimztionGroupBox.Size = new Size(690, 169);
            estimztionGroupBox.TabIndex = 19;
            estimztionGroupBox.TabStop = false;
            estimztionGroupBox.Text = "Szcunek kosztów";
            // 
            // water_sum_text
            // 
            water_sum_text.AutoSize = true;
            water_sum_text.Location = new Point(559, 90);
            water_sum_text.Name = "water_sum_text";
            water_sum_text.Size = new Size(38, 15);
            water_sum_text.TabIndex = 33;
            water_sum_text.Text = "label4";
            // 
            // sumWater
            // 
            sumWater.AutoSize = true;
            sumWater.Location = new Point(493, 90);
            sumWater.Name = "sumWater";
            sumWater.Size = new Size(60, 15);
            sumWater.TabIndex = 32;
            sumWater.Text = "Suma m3:";
            // 
            // brutto_label
            // 
            brutto_label.AutoSize = true;
            brutto_label.Location = new Point(559, 60);
            brutto_label.Name = "brutto_label";
            brutto_label.Size = new Size(38, 15);
            brutto_label.TabIndex = 31;
            brutto_label.Text = "label4";
            // 
            // brutto
            // 
            brutto.AutoSize = true;
            brutto.Location = new Point(427, 60);
            brutto.Name = "brutto";
            brutto.Size = new Size(126, 15);
            brutto.TabIndex = 30;
            brutto.Text = "Suma wartości Brutto: ";
            // 
            // netto_label
            // 
            netto_label.AutoSize = true;
            netto_label.Location = new Point(559, 30);
            netto_label.Name = "netto_label";
            netto_label.Size = new Size(38, 15);
            netto_label.TabIndex = 29;
            netto_label.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 30);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 28;
            label2.Text = "Suma szacunku Netto: ";
            // 
            // sewage_subscribtion_result
            // 
            sewage_subscribtion_result.AutoSize = true;
            sewage_subscribtion_result.Location = new Point(232, 120);
            sewage_subscribtion_result.Name = "sewage_subscribtion_result";
            sewage_subscribtion_result.Size = new Size(44, 15);
            sewage_subscribtion_result.TabIndex = 27;
            sewage_subscribtion_result.Text = "label13";
            // 
            // water_subscribe_result
            // 
            water_subscribe_result.AutoSize = true;
            water_subscribe_result.Location = new Point(232, 90);
            water_subscribe_result.Name = "water_subscribe_result";
            water_subscribe_result.Size = new Size(44, 15);
            water_subscribe_result.TabIndex = 25;
            water_subscribe_result.Text = "label12";
            // 
            // sewage_result
            // 
            sewage_result.AutoSize = true;
            sewage_result.Location = new Point(232, 60);
            sewage_result.Name = "sewage_result";
            sewage_result.Size = new Size(44, 15);
            sewage_result.TabIndex = 23;
            sewage_result.Text = "label11";
            // 
            // water_result
            // 
            water_result.AutoSize = true;
            water_result.Location = new Point(232, 30);
            water_result.Name = "water_result";
            water_result.Size = new Size(44, 15);
            water_result.TabIndex = 21;
            water_result.Text = "label10";
            // 
            // water
            // 
            water.AutoSize = true;
            water.Location = new Point(118, 30);
            water.Name = "water";
            water.Size = new Size(108, 15);
            water.TabIndex = 20;
            water.Text = "Woda - m3 - netto:";
            // 
            // water_subscription
            // 
            water_subscription.AutoSize = true;
            water_subscription.Location = new Point(80, 90);
            water_subscription.Name = "water_subscription";
            water_subscription.Size = new Size(146, 15);
            water_subscription.TabIndex = 24;
            water_subscription.Text = "Abonament Woda - netto:";
            // 
            // sewage
            // 
            sewage.AutoSize = true;
            sewage.Location = new Point(120, 60);
            sewage.Name = "sewage";
            sewage.Size = new Size(107, 15);
            sewage.TabIndex = 22;
            sewage.Text = "Ścieki - m3 - netto:";
            // 
            // sewage_subscription
            // 
            sewage_subscription.AutoSize = true;
            sewage_subscription.Location = new Point(82, 120);
            sewage_subscription.Name = "sewage_subscription";
            sewage_subscription.Size = new Size(145, 15);
            sewage_subscription.TabIndex = 26;
            sewage_subscription.Text = "Abonament Ścieki - netto:";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(552, 494);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 35;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Location = new Point(12, 494);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(150, 25);
            save_to_pdf_click.TabIndex = 34;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // FormWaterEstimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 531);
            Controls.Add(cancel_button);
            Controls.Add(save_to_pdf_click);
            Controls.Add(estimztionGroupBox);
            Controls.Add(inputDataGroupBox);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWaterEstimation";
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

        private Label title;
        private GroupBox inputDataGroupBox;
        private Label unit_text;
        private TextBox vat_text;
        private Label vat_label;
        private TextBox subscriptionFee_text;
        private TextBox cogenerationFee_text;
        private TextBox renewableEnergySourcesFee_text;
        private TextBox qualityFee_text;
        private TextBox sewage_subscription_text;
        private TextBox water_subscription_text;
        private TextBox sewage_text;
        private TextBox water_text;
        private TextBox textBox5;
        private TextBox power_text;
        private TextBox estimate_text;
        private TextBox month_text;
        private TextBox tariff_text;
        private Label tariff_label;
        private Label subscriptionFee_label;
        private Label cogenerationFee_label;
        private Label month_label;
        private Label water_label;
        private Label kwh_label;
        private Label renewableEnergySourcesFee_label;
        private Label power_label;
        private Label qualityFee_label;
        private Label water_subscription_label;
        private Label sewage_label;
        private Label sewage_subscription_label;
        private GroupBox estimztionGroupBox;
        private Label water_sum_text;
        private Label sumWater;
        private Label brutto_label;
        private Label brutto;
        private Label netto_label;
        private Label label2;
        private Label sewage_subscribtion_result;
        private Label water_subscribe_result;
        private Label sewage_result;
        private Label water_result;
        private Label water;
        private Label water_subscription;
        private Label sewage;
        private Label sewage_subscription;
        private Button cancel_button;
        private Button save_to_pdf_click;
    }
}
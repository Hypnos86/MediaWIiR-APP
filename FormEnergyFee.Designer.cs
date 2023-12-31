﻿namespace MediaWIiR_APP
{
    partial class FormEnergyFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnergyFee));
            cancel_button = new Button();
            add_button = new Button();
            data_tariff = new GroupBox();
            vat_error = new Label();
            vat_label = new Label();
            vatComboBox = new ComboBox();
            subscription_error = new Label();
            cogeneration_error = new Label();
            oze_error = new Label();
            quality_error = new Label();
            network_variable_error = new Label();
            capacirt_error = new Label();
            transation_error = new Label();
            fixed_network_error = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            fixed_network_fee_input = new TextBox();
            transition_fee_input = new TextBox();
            capacirt_fee_input = new TextBox();
            subscription_fee_input = new TextBox();
            cogeneration_fee_input = new TextBox();
            renewable_energy_sources_fee_input = new TextBox();
            quality_fee_input = new TextBox();
            network_variable_fee_input = new TextBox();
            tariff_input = new TextBox();
            sell_tariff = new GroupBox();
            kwh_sell_error = new Label();
            kwh_sell_label = new Label();
            kWh_sell_input = new TextBox();
            data_tariff.SuspendLayout();
            sell_tariff.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(262, 430);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 13;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // add_button
            // 
            add_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_button.Location = new Point(12, 430);
            add_button.Name = "add_button";
            add_button.Size = new Size(150, 25);
            add_button.TabIndex = 12;
            add_button.Text = "Dodaj dane";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_tariff_button_Click;
            // 
            // data_tariff
            // 
            data_tariff.Controls.Add(vat_error);
            data_tariff.Controls.Add(vat_label);
            data_tariff.Controls.Add(vatComboBox);
            data_tariff.Controls.Add(subscription_error);
            data_tariff.Controls.Add(cogeneration_error);
            data_tariff.Controls.Add(oze_error);
            data_tariff.Controls.Add(quality_error);
            data_tariff.Controls.Add(network_variable_error);
            data_tariff.Controls.Add(capacirt_error);
            data_tariff.Controls.Add(transation_error);
            data_tariff.Controls.Add(fixed_network_error);
            data_tariff.Controls.Add(label9);
            data_tariff.Controls.Add(label8);
            data_tariff.Controls.Add(label7);
            data_tariff.Controls.Add(label6);
            data_tariff.Controls.Add(label5);
            data_tariff.Controls.Add(label4);
            data_tariff.Controls.Add(label3);
            data_tariff.Controls.Add(label2);
            data_tariff.Controls.Add(label1);
            data_tariff.Controls.Add(fixed_network_fee_input);
            data_tariff.Controls.Add(transition_fee_input);
            data_tariff.Controls.Add(capacirt_fee_input);
            data_tariff.Controls.Add(subscription_fee_input);
            data_tariff.Controls.Add(cogeneration_fee_input);
            data_tariff.Controls.Add(renewable_energy_sources_fee_input);
            data_tariff.Controls.Add(quality_fee_input);
            data_tariff.Controls.Add(network_variable_fee_input);
            data_tariff.Controls.Add(tariff_input);
            data_tariff.Location = new Point(12, 12);
            data_tariff.Name = "data_tariff";
            data_tariff.Size = new Size(400, 330);
            data_tariff.TabIndex = 2;
            data_tariff.TabStop = false;
            data_tariff.Text = "Dane taryfy - OSD";
            // 
            // vat_error
            // 
            vat_error.AutoSize = true;
            vat_error.Location = new Point(266, 293);
            vat_error.Name = "vat_error";
            vat_error.Size = new Size(57, 15);
            vat_error.TabIndex = 29;
            vat_error.Text = "text_error";
            vat_error.Visible = false;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(125, 290);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 28;
            vat_label.Text = "Vat: ";
            // 
            // vatComboBox
            // 
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Items.AddRange(new object[] { "0", "5", "8", "23" });
            vatComboBox.Location = new Point(160, 290);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(100, 23);
            vatComboBox.TabIndex = 9;
            // 
            // subscription_error
            // 
            subscription_error.AutoSize = true;
            subscription_error.Location = new Point(266, 264);
            subscription_error.Name = "subscription_error";
            subscription_error.Size = new Size(57, 15);
            subscription_error.TabIndex = 26;
            subscription_error.Text = "text_error";
            subscription_error.Visible = false;
            // 
            // cogeneration_error
            // 
            cogeneration_error.AutoSize = true;
            cogeneration_error.Location = new Point(266, 235);
            cogeneration_error.Name = "cogeneration_error";
            cogeneration_error.Size = new Size(57, 15);
            cogeneration_error.TabIndex = 25;
            cogeneration_error.Text = "text_error";
            cogeneration_error.Visible = false;
            // 
            // oze_error
            // 
            oze_error.AutoSize = true;
            oze_error.Location = new Point(266, 206);
            oze_error.Name = "oze_error";
            oze_error.Size = new Size(57, 15);
            oze_error.TabIndex = 24;
            oze_error.Text = "text_error";
            oze_error.Visible = false;
            // 
            // quality_error
            // 
            quality_error.AutoSize = true;
            quality_error.Location = new Point(266, 177);
            quality_error.Name = "quality_error";
            quality_error.Size = new Size(57, 15);
            quality_error.TabIndex = 23;
            quality_error.Text = "text_error";
            quality_error.Visible = false;
            // 
            // network_variable_error
            // 
            network_variable_error.AutoSize = true;
            network_variable_error.Location = new Point(266, 148);
            network_variable_error.Name = "network_variable_error";
            network_variable_error.Size = new Size(57, 15);
            network_variable_error.TabIndex = 22;
            network_variable_error.Text = "text_error";
            network_variable_error.Visible = false;
            // 
            // capacirt_error
            // 
            capacirt_error.AutoSize = true;
            capacirt_error.Location = new Point(266, 119);
            capacirt_error.Name = "capacirt_error";
            capacirt_error.Size = new Size(57, 15);
            capacirt_error.TabIndex = 21;
            capacirt_error.Text = "text_error";
            capacirt_error.Visible = false;
            // 
            // transation_error
            // 
            transation_error.AutoSize = true;
            transation_error.Location = new Point(266, 90);
            transation_error.Name = "transation_error";
            transation_error.Size = new Size(57, 15);
            transation_error.TabIndex = 20;
            transation_error.Text = "text_error";
            transation_error.Visible = false;
            // 
            // fixed_network_error
            // 
            fixed_network_error.AutoSize = true;
            fixed_network_error.Location = new Point(266, 61);
            fixed_network_error.Name = "fixed_network_error";
            fixed_network_error.Size = new Size(57, 15);
            fixed_network_error.TabIndex = 19;
            fixed_network_error.Text = "text_error";
            fixed_network_error.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 264);
            label9.Name = "label9";
            label9.Size = new Size(131, 15);
            label9.TabIndex = 17;
            label9.Text = "Opłata abonamentowa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 235);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 16;
            label8.Text = "Opłata kogeneracyjna: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 206);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 15;
            label7.Text = "Opłata oze: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 177);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 14;
            label6.Text = "Opłata jakościowa: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 148);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 13;
            label5.Text = "Opłata zmienna sieciowa: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 119);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Opłata mocowa: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 32);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 11;
            label3.Text = "Taryfa: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 10;
            label2.Text = "Opłata przejściowa: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 61);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 9;
            label1.Text = "Opłata stała sieciowa: ";
            // 
            // fixed_network_fee_input
            // 
            fixed_network_fee_input.Location = new Point(160, 58);
            fixed_network_fee_input.Name = "fixed_network_fee_input";
            fixed_network_fee_input.Size = new Size(100, 23);
            fixed_network_fee_input.TabIndex = 1;
            // 
            // transition_fee_input
            // 
            transition_fee_input.Location = new Point(160, 87);
            transition_fee_input.Name = "transition_fee_input";
            transition_fee_input.Size = new Size(100, 23);
            transition_fee_input.TabIndex = 2;
            // 
            // capacirt_fee_input
            // 
            capacirt_fee_input.Location = new Point(160, 116);
            capacirt_fee_input.Name = "capacirt_fee_input";
            capacirt_fee_input.Size = new Size(100, 23);
            capacirt_fee_input.TabIndex = 3;
            // 
            // subscription_fee_input
            // 
            subscription_fee_input.Location = new Point(160, 261);
            subscription_fee_input.Name = "subscription_fee_input";
            subscription_fee_input.Size = new Size(100, 23);
            subscription_fee_input.TabIndex = 8;
            // 
            // cogeneration_fee_input
            // 
            cogeneration_fee_input.Location = new Point(160, 232);
            cogeneration_fee_input.Name = "cogeneration_fee_input";
            cogeneration_fee_input.Size = new Size(100, 23);
            cogeneration_fee_input.TabIndex = 7;
            // 
            // renewable_energy_sources_fee_input
            // 
            renewable_energy_sources_fee_input.Location = new Point(160, 203);
            renewable_energy_sources_fee_input.Name = "renewable_energy_sources_fee_input";
            renewable_energy_sources_fee_input.Size = new Size(100, 23);
            renewable_energy_sources_fee_input.TabIndex = 6;
            // 
            // quality_fee_input
            // 
            quality_fee_input.Location = new Point(160, 174);
            quality_fee_input.Name = "quality_fee_input";
            quality_fee_input.Size = new Size(100, 23);
            quality_fee_input.TabIndex = 5;
            // 
            // network_variable_fee_input
            // 
            network_variable_fee_input.Location = new Point(160, 145);
            network_variable_fee_input.Name = "network_variable_fee_input";
            network_variable_fee_input.Size = new Size(100, 23);
            network_variable_fee_input.TabIndex = 4;
            // 
            // tariff_input
            // 
            tariff_input.Location = new Point(160, 29);
            tariff_input.Name = "tariff_input";
            tariff_input.Size = new Size(100, 23);
            tariff_input.TabIndex = 0;
            // 
            // sell_tariff
            // 
            sell_tariff.Controls.Add(kwh_sell_error);
            sell_tariff.Controls.Add(kwh_sell_label);
            sell_tariff.Controls.Add(kWh_sell_input);
            sell_tariff.Location = new Point(12, 348);
            sell_tariff.Name = "sell_tariff";
            sell_tariff.Size = new Size(400, 66);
            sell_tariff.TabIndex = 10;
            sell_tariff.TabStop = false;
            sell_tariff.Text = "Dane dotyczące sprzedaży";
            // 
            // kwh_sell_error
            // 
            kwh_sell_error.AutoSize = true;
            kwh_sell_error.Location = new Point(266, 25);
            kwh_sell_error.Name = "kwh_sell_error";
            kwh_sell_error.Size = new Size(57, 15);
            kwh_sell_error.TabIndex = 22;
            kwh_sell_error.Text = "text_error";
            kwh_sell_error.Visible = false;
            // 
            // kwh_sell_label
            // 
            kwh_sell_label.AutoSize = true;
            kwh_sell_label.Location = new Point(77, 25);
            kwh_sell_label.Name = "kwh_sell_label";
            kwh_sell_label.Size = new Size(77, 15);
            kwh_sell_label.TabIndex = 21;
            kwh_sell_label.Text = "Koszt 1 kWh: ";
            // 
            // kWh_sell_input
            // 
            kWh_sell_input.Location = new Point(160, 22);
            kWh_sell_input.Name = "kWh_sell_input";
            kWh_sell_input.Size = new Size(100, 23);
            kWh_sell_input.TabIndex = 11;
            // 
            // FormEnergyFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 471);
            Controls.Add(sell_tariff);
            Controls.Add(data_tariff);
            Controls.Add(add_button);
            Controls.Add(cancel_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEnergyFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Energia elektryczna - Taryfa";
            data_tariff.ResumeLayout(false);
            data_tariff.PerformLayout();
            sell_tariff.ResumeLayout(false);
            sell_tariff.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button add_button;
        private GroupBox data_tariff;
        private TextBox transition_fee_input;
        private TextBox capacirt_fee_input;
        private TextBox subscription_fee_input;
        private TextBox cogeneration_fee_input;
        private TextBox renewable_energy_sources_fee_input;
        private TextBox quality_fee_input;
        private TextBox network_variable_fee_input;
        private TextBox tariff_input;
        private TextBox fixed_network_fee_input;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label quality_error;
        private Label network_variable_error;
        private Label capacirt_error;
        private Label transation_error;
        private Label fixed_network_error;
        private Label subscription_error;
        private Label cogeneration_error;
        private Label oze_error;
        private ComboBox vatComboBox;
        private Label vat_label;
        private Label vat_error;
        private GroupBox sell_tariff;
        private Label kwh_sell_error;
        private Label kwh_sell_label;
        private TextBox kWh_sell_input;
    }
}
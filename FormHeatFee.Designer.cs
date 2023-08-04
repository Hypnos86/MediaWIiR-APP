namespace MediaWIiR_APP
{
    partial class FormHeatFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeatFee));
            cancel_button = new Button();
            add_button = new Button();
            estimationGroupBox = new GroupBox();
            vat_error = new Label();
            vat_label = new Label();
            vatComboBox = new ComboBox();
            ordered_thermal_power_input = new TextBox();
            ordered_thermal_power_error = new Label();
            label14 = new Label();
            carrer_fee_input = new TextBox();
            carrer_fee_error = new Label();
            label12 = new Label();
            subscription_fee_input = new TextBox();
            subscription_fee_error = new Label();
            label10 = new Label();
            variable_shipping_fee_input = new TextBox();
            variable_shipping_fee_error = new Label();
            label8 = new Label();
            fixed_shipping_fee_input = new TextBox();
            fixed_shipping_fee_error = new Label();
            label6 = new Label();
            heat_fee_input = new TextBox();
            heat_label = new Label();
            tariff_input = new TextBox();
            heat_fee_error = new Label();
            tariff_label = new Label();
            estimationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(282, 294);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(130, 25);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(12, 294);
            add_button.Name = "add_button";
            add_button.Size = new Size(130, 25);
            add_button.TabIndex = 1;
            add_button.Text = "Dodaj";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // estimationGroupBox
            // 
            estimationGroupBox.Controls.Add(vat_error);
            estimationGroupBox.Controls.Add(vat_label);
            estimationGroupBox.Controls.Add(vatComboBox);
            estimationGroupBox.Controls.Add(ordered_thermal_power_input);
            estimationGroupBox.Controls.Add(ordered_thermal_power_error);
            estimationGroupBox.Controls.Add(label14);
            estimationGroupBox.Controls.Add(carrer_fee_input);
            estimationGroupBox.Controls.Add(carrer_fee_error);
            estimationGroupBox.Controls.Add(label12);
            estimationGroupBox.Controls.Add(subscription_fee_input);
            estimationGroupBox.Controls.Add(subscription_fee_error);
            estimationGroupBox.Controls.Add(label10);
            estimationGroupBox.Controls.Add(variable_shipping_fee_input);
            estimationGroupBox.Controls.Add(variable_shipping_fee_error);
            estimationGroupBox.Controls.Add(label8);
            estimationGroupBox.Controls.Add(fixed_shipping_fee_input);
            estimationGroupBox.Controls.Add(fixed_shipping_fee_error);
            estimationGroupBox.Controls.Add(label6);
            estimationGroupBox.Controls.Add(heat_fee_input);
            estimationGroupBox.Controls.Add(heat_label);
            estimationGroupBox.Controls.Add(tariff_input);
            estimationGroupBox.Controls.Add(heat_fee_error);
            estimationGroupBox.Controls.Add(tariff_label);
            estimationGroupBox.Location = new Point(12, 12);
            estimationGroupBox.Name = "estimationGroupBox";
            estimationGroupBox.Size = new Size(400, 270);
            estimationGroupBox.TabIndex = 2;
            estimationGroupBox.TabStop = false;
            estimationGroupBox.Text = "Dane taryfy";
            // 
            // vat_error
            // 
            vat_error.AutoSize = true;
            vat_error.Location = new Point(316, 228);
            vat_error.Name = "vat_error";
            vat_error.Size = new Size(57, 15);
            vat_error.TabIndex = 32;
            vat_error.Text = "text_error";
            vat_error.Visible = false;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(175, 228);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 31;
            vat_label.Text = "Vat: ";
            // 
            // vatComboBox
            // 
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Items.AddRange(new object[] { "0", "5", "8", "23" });
            vatComboBox.Location = new Point(210, 225);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(100, 23);
            vatComboBox.TabIndex = 30;
            // 
            // ordered_thermal_power_input
            // 
            ordered_thermal_power_input.Location = new Point(210, 196);
            ordered_thermal_power_input.Name = "ordered_thermal_power_input";
            ordered_thermal_power_input.Size = new Size(100, 23);
            ordered_thermal_power_input.TabIndex = 20;
            // 
            // ordered_thermal_power_error
            // 
            ordered_thermal_power_error.AutoSize = true;
            ordered_thermal_power_error.Location = new Point(316, 199);
            ordered_thermal_power_error.Name = "ordered_thermal_power_error";
            ordered_thermal_power_error.Size = new Size(57, 15);
            ordered_thermal_power_error.TabIndex = 19;
            ordered_thermal_power_error.Text = "text_error";
            ordered_thermal_power_error.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 199);
            label14.Name = "label14";
            label14.Size = new Size(191, 15);
            label14.TabIndex = 18;
            label14.Text = "Opłata za zamówioną moc cieplną:";
            // 
            // carrer_fee_input
            // 
            carrer_fee_input.Location = new Point(210, 167);
            carrer_fee_input.Name = "carrer_fee_input";
            carrer_fee_input.Size = new Size(100, 23);
            carrer_fee_input.TabIndex = 17;
            // 
            // carrer_fee_error
            // 
            carrer_fee_error.AutoSize = true;
            carrer_fee_error.Location = new Point(316, 170);
            carrer_fee_error.Name = "carrer_fee_error";
            carrer_fee_error.Size = new Size(57, 15);
            carrer_fee_error.TabIndex = 16;
            carrer_fee_error.Text = "text_error";
            carrer_fee_error.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(107, 170);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 15;
            label12.Text = "Opłata za nośnik:";
            // 
            // subscription_fee_input
            // 
            subscription_fee_input.Location = new Point(210, 138);
            subscription_fee_input.Name = "subscription_fee_input";
            subscription_fee_input.Size = new Size(100, 23);
            subscription_fee_input.TabIndex = 14;
            // 
            // subscription_fee_error
            // 
            subscription_fee_error.AutoSize = true;
            subscription_fee_error.Location = new Point(316, 141);
            subscription_fee_error.Name = "subscription_fee_error";
            subscription_fee_error.Size = new Size(57, 15);
            subscription_fee_error.TabIndex = 13;
            subscription_fee_error.Text = "text_error";
            subscription_fee_error.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 141);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 12;
            label10.Text = "Opłata abonamentowa:";
            // 
            // variable_shipping_fee_input
            // 
            variable_shipping_fee_input.Location = new Point(210, 109);
            variable_shipping_fee_input.Name = "variable_shipping_fee_input";
            variable_shipping_fee_input.Size = new Size(100, 23);
            variable_shipping_fee_input.TabIndex = 11;
            // 
            // variable_shipping_fee_error
            // 
            variable_shipping_fee_error.AutoSize = true;
            variable_shipping_fee_error.Location = new Point(316, 112);
            variable_shipping_fee_error.Name = "variable_shipping_fee_error";
            variable_shipping_fee_error.Size = new Size(57, 15);
            variable_shipping_fee_error.TabIndex = 10;
            variable_shipping_fee_error.Text = "text_error";
            variable_shipping_fee_error.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 112);
            label8.Name = "label8";
            label8.Size = new Size(146, 15);
            label8.TabIndex = 9;
            label8.Text = "Opłata zmianna za przesył:";
            // 
            // fixed_shipping_fee_input
            // 
            fixed_shipping_fee_input.Location = new Point(210, 80);
            fixed_shipping_fee_input.Name = "fixed_shipping_fee_input";
            fixed_shipping_fee_input.Size = new Size(100, 23);
            fixed_shipping_fee_input.TabIndex = 8;
            // 
            // fixed_shipping_fee_error
            // 
            fixed_shipping_fee_error.AutoSize = true;
            fixed_shipping_fee_error.Location = new Point(316, 83);
            fixed_shipping_fee_error.Name = "fixed_shipping_fee_error";
            fixed_shipping_fee_error.Size = new Size(57, 15);
            fixed_shipping_fee_error.TabIndex = 7;
            fixed_shipping_fee_error.Text = "text_error";
            fixed_shipping_fee_error.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 83);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 6;
            label6.Text = "Opłata stała za przesył:";
            // 
            // heat_fee_input
            // 
            heat_fee_input.Location = new Point(210, 51);
            heat_fee_input.Name = "heat_fee_input";
            heat_fee_input.Size = new Size(100, 23);
            heat_fee_input.TabIndex = 5;
            // 
            // heat_label
            // 
            heat_label.AutoSize = true;
            heat_label.Location = new Point(110, 54);
            heat_label.Name = "heat_label";
            heat_label.Size = new Size(94, 15);
            heat_label.TabIndex = 3;
            heat_label.Text = "Opłata za ciepło:";
            // 
            // tariff_input
            // 
            tariff_input.Location = new Point(210, 22);
            tariff_input.Name = "tariff_input";
            tariff_input.Size = new Size(100, 23);
            tariff_input.TabIndex = 2;
            // 
            // heat_fee_error
            // 
            heat_fee_error.AutoSize = true;
            heat_fee_error.Location = new Point(316, 54);
            heat_fee_error.Name = "heat_fee_error";
            heat_fee_error.Size = new Size(57, 15);
            heat_fee_error.TabIndex = 1;
            heat_fee_error.Text = "text_error";
            heat_fee_error.Visible = false;
            // 
            // tariff_label
            // 
            tariff_label.AutoSize = true;
            tariff_label.Location = new Point(163, 25);
            tariff_label.Name = "tariff_label";
            tariff_label.Size = new Size(41, 15);
            tariff_label.TabIndex = 0;
            tariff_label.Text = "Taryfa:";
            // 
            // FormHeatFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 331);
            Controls.Add(estimationGroupBox);
            Controls.Add(add_button);
            Controls.Add(cancel_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHeatFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Energia cieplna - Taryfa";
            estimationGroupBox.ResumeLayout(false);
            estimationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button add_button;
        private GroupBox estimationGroupBox;
        private TextBox tariff_input;
        private Label heat_fee_error;
        private Label tariff_label;
        private TextBox ordered_thermal_power_input;
        private Label ordered_thermal_power_error;
        private Label label14;
        private TextBox carrer_fee_input;
        private Label carrer_fee_error;
        private Label label12;
        private TextBox subscription_fee_input;
        private Label subscription_fee_error;
        private Label label10;
        private TextBox variable_shipping_fee_input;
        private Label variable_shipping_fee_error;
        private Label label8;
        private TextBox fixed_shipping_fee_input;
        private Label fixed_shipping_fee_error;
        private Label label6;
        private TextBox heat_fee_input;
        private Label heat_label;
        private Label vat_error;
        private Label vat_label;
        private ComboBox vatComboBox;
    }
}
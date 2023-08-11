namespace MediaWIiR_APP
{
    partial class FormGasData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGasData));
            dataGroupBox = new GroupBox();
            conversion_error = new Label();
            conversion_input = new TextBox();
            conversion_label = new Label();
            tariff_input = new ComboBox();
            tariff_error = new Label();
            label1 = new Label();
            month_error = new Label();
            power_error = new Label();
            gas_error = new Label();
            month_need_label = new Label();
            month_input = new TextBox();
            power_need_label = new Label();
            power_input = new TextBox();
            gas_label = new Label();
            gas_input = new TextBox();
            cancel_button = new Button();
            add_button = new Button();
            dataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataGroupBox
            // 
            dataGroupBox.Controls.Add(conversion_error);
            dataGroupBox.Controls.Add(conversion_input);
            dataGroupBox.Controls.Add(conversion_label);
            dataGroupBox.Controls.Add(tariff_input);
            dataGroupBox.Controls.Add(tariff_error);
            dataGroupBox.Controls.Add(label1);
            dataGroupBox.Controls.Add(month_error);
            dataGroupBox.Controls.Add(power_error);
            dataGroupBox.Controls.Add(gas_error);
            dataGroupBox.Controls.Add(month_need_label);
            dataGroupBox.Controls.Add(month_input);
            dataGroupBox.Controls.Add(power_need_label);
            dataGroupBox.Controls.Add(power_input);
            dataGroupBox.Controls.Add(gas_label);
            dataGroupBox.Controls.Add(gas_input);
            dataGroupBox.Location = new Point(12, 12);
            dataGroupBox.Name = "dataGroupBox";
            dataGroupBox.Size = new Size(450, 200);
            dataGroupBox.TabIndex = 0;
            dataGroupBox.TabStop = false;
            dataGroupBox.Text = "Dane do szacowania";
            // 
            // conversion_error
            // 
            conversion_error.AutoSize = true;
            conversion_error.ImeMode = ImeMode.NoControl;
            conversion_error.Location = new Point(316, 115);
            conversion_error.Name = "conversion_error";
            conversion_error.Size = new Size(57, 15);
            conversion_error.TabIndex = 12;
            conversion_error.Text = "text_error";
            conversion_error.Visible = false;
            // 
            // conversion_input
            // 
            conversion_input.Location = new Point(210, 112);
            conversion_input.Name = "conversion_input";
            conversion_input.Size = new Size(100, 23);
            conversion_input.TabIndex = 11;
            // 
            // conversion_label
            // 
            conversion_label.AutoSize = true;
            conversion_label.Location = new Point(68, 115);
            conversion_label.Name = "conversion_label";
            conversion_label.Size = new Size(136, 15);
            conversion_label.TabIndex = 10;
            conversion_label.Text = "Współczynnik konwersji:";
            // 
            // tariff_input
            // 
            tariff_input.FormattingEnabled = true;
            tariff_input.Items.AddRange(new object[] { "W-1", "W-2", "W-3", "W-4", "W-5" });
            tariff_input.Location = new Point(210, 22);
            tariff_input.Name = "tariff_input";
            tariff_input.Size = new Size(100, 23);
            tariff_input.TabIndex = 2;
            tariff_input.SelectedIndexChanged += tariff_input_SelectedIndexChanged;
            // 
            // tariff_error
            // 
            tariff_error.AutoSize = true;
            tariff_error.ImeMode = ImeMode.NoControl;
            tariff_error.Location = new Point(316, 25);
            tariff_error.Name = "tariff_error";
            tariff_error.Size = new Size(57, 15);
            tariff_error.TabIndex = 3;
            tariff_error.Text = "text_error";
            tariff_error.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(163, 25);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Taryfa:";
            // 
            // month_error
            // 
            month_error.AutoSize = true;
            month_error.ImeMode = ImeMode.NoControl;
            month_error.Location = new Point(316, 86);
            month_error.Name = "month_error";
            month_error.Size = new Size(57, 15);
            month_error.TabIndex = 9;
            month_error.Text = "text_error";
            month_error.Visible = false;
            // 
            // power_error
            // 
            power_error.AutoSize = true;
            power_error.ImeMode = ImeMode.NoControl;
            power_error.Location = new Point(316, 144);
            power_error.Name = "power_error";
            power_error.Size = new Size(57, 15);
            power_error.TabIndex = 15;
            power_error.Text = "text_error";
            power_error.Visible = false;
            // 
            // gas_error
            // 
            gas_error.AutoSize = true;
            gas_error.ImeMode = ImeMode.NoControl;
            gas_error.Location = new Point(316, 57);
            gas_error.Name = "gas_error";
            gas_error.Size = new Size(57, 15);
            gas_error.TabIndex = 6;
            gas_error.Text = "text_error";
            gas_error.Visible = false;
            // 
            // month_need_label
            // 
            month_need_label.AutoSize = true;
            month_need_label.ImeMode = ImeMode.NoControl;
            month_need_label.Location = new Point(112, 86);
            month_need_label.Name = "month_need_label";
            month_need_label.Size = new Size(92, 15);
            month_need_label.TabIndex = 7;
            month_need_label.Text = "Liczba miesięcy:";
            // 
            // month_input
            // 
            month_input.Location = new Point(210, 83);
            month_input.Name = "month_input";
            month_input.Size = new Size(100, 23);
            month_input.TabIndex = 8;
            // 
            // power_need_label
            // 
            power_need_label.AutoSize = true;
            power_need_label.ImeMode = ImeMode.NoControl;
            power_need_label.Location = new Point(38, 144);
            power_need_label.Name = "power_need_label";
            power_need_label.Size = new Size(166, 15);
            power_need_label.TabIndex = 13;
            power_need_label.Text = "Zpotrzebowanie na moc - kW:";
            power_need_label.Visible = false;
            // 
            // power_input
            // 
            power_input.Location = new Point(210, 141);
            power_input.Name = "power_input";
            power_input.Size = new Size(100, 23);
            power_input.TabIndex = 14;
            power_input.Visible = false;
            // 
            // gas_label
            // 
            gas_label.AutoSize = true;
            gas_label.ImeMode = ImeMode.NoControl;
            gas_label.Location = new Point(47, 57);
            gas_label.Name = "gas_label";
            gas_label.Size = new Size(157, 15);
            gas_label.TabIndex = 4;
            gas_label.Text = "Szacowane miesięczne - m3:";
            // 
            // gas_input
            // 
            gas_input.Location = new Point(210, 54);
            gas_input.Name = "gas_input";
            gas_input.Size = new Size(100, 23);
            gas_input.TabIndex = 5;
            // 
            // cancel_button
            // 
            cancel_button.ImeMode = ImeMode.NoControl;
            cancel_button.Location = new Point(332, 224);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(130, 25);
            cancel_button.TabIndex = 17;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // add_button
            // 
            add_button.ImeMode = ImeMode.NoControl;
            add_button.Location = new Point(12, 224);
            add_button.Name = "add_button";
            add_button.Size = new Size(130, 25);
            add_button.TabIndex = 16;
            add_button.Text = "Dodaj";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // FormGasData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 261);
            Controls.Add(cancel_button);
            Controls.Add(add_button);
            Controls.Add(dataGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGasData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dane do szacowania - Gas";
            dataGroupBox.ResumeLayout(false);
            dataGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox dataGroupBox;
        private Label tariff_error;
        private Label label1;
        private Label month_error;
        private Label power_error;
        private Label gas_error;
        private Label month_need_label;
        private TextBox month_input;
        private Label power_need_label;
        private TextBox power_input;
        private Label gas_label;
        private TextBox gas_input;
        private ComboBox tariff_input;
        private Label conversion_label;
        private Label conversion_error;
        private TextBox conversion_input;
        private Button cancel_button;
        private Button add_button;
    }
}
namespace MediaWIiR_APP
{
    partial class FormEnergyData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnergyData));
            energy_data_groupbox = new GroupBox();
            text_error_month = new Label();
            text_error_power = new Label();
            text_error_kwh = new Label();
            month_need_label = new Label();
            month_input = new TextBox();
            power_need_label = new Label();
            power_input = new TextBox();
            kwh_need_label = new Label();
            kwh_input = new TextBox();
            accept_button = new Button();
            cancel_button = new Button();
            energy_data_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // energy_data_groupbox
            // 
            energy_data_groupbox.Controls.Add(text_error_month);
            energy_data_groupbox.Controls.Add(text_error_power);
            energy_data_groupbox.Controls.Add(text_error_kwh);
            energy_data_groupbox.Controls.Add(month_need_label);
            energy_data_groupbox.Controls.Add(month_input);
            energy_data_groupbox.Controls.Add(power_need_label);
            energy_data_groupbox.Controls.Add(power_input);
            energy_data_groupbox.Controls.Add(kwh_need_label);
            energy_data_groupbox.Controls.Add(kwh_input);
            energy_data_groupbox.Location = new Point(12, 12);
            energy_data_groupbox.Name = "energy_data_groupbox";
            energy_data_groupbox.Size = new Size(380, 130);
            energy_data_groupbox.TabIndex = 17;
            energy_data_groupbox.TabStop = false;
            energy_data_groupbox.Text = "Dane do szacowania";
            // 
            // text_error_month
            // 
            text_error_month.AutoSize = true;
            text_error_month.Location = new Point(281, 96);
            text_error_month.Name = "text_error_month";
            text_error_month.Size = new Size(57, 15);
            text_error_month.TabIndex = 23;
            text_error_month.Text = "text_error";
            text_error_month.Visible = false;
            // 
            // text_error_power
            // 
            text_error_power.AutoSize = true;
            text_error_power.Location = new Point(281, 57);
            text_error_power.Name = "text_error_power";
            text_error_power.Size = new Size(57, 15);
            text_error_power.TabIndex = 22;
            text_error_power.Text = "text_error";
            text_error_power.Visible = false;
            // 
            // text_error_kwh
            // 
            text_error_kwh.AutoSize = true;
            text_error_kwh.Location = new Point(281, 19);
            text_error_kwh.Name = "text_error_kwh";
            text_error_kwh.Size = new Size(57, 15);
            text_error_kwh.TabIndex = 17;
            text_error_kwh.Text = "text_error";
            text_error_kwh.Visible = false;
            // 
            // month_need_label
            // 
            month_need_label.AutoSize = true;
            month_need_label.Location = new Point(78, 96);
            month_need_label.Name = "month_need_label";
            month_need_label.Size = new Size(89, 15);
            month_need_label.TabIndex = 21;
            month_need_label.Text = "Liczba miesięcy";
            // 
            // month_input
            // 
            month_input.Location = new Point(175, 93);
            month_input.Name = "month_input";
            month_input.Size = new Size(100, 23);
            month_input.TabIndex = 20;
            month_input.TextChanged += month_input_TextChanged;
            // 
            // power_need_label
            // 
            power_need_label.AutoSize = true;
            power_need_label.Location = new Point(6, 57);
            power_need_label.Name = "power_need_label";
            power_need_label.Size = new Size(163, 15);
            power_need_label.TabIndex = 19;
            power_need_label.Text = "Zpotrzebowanie na moc - kW";
            // 
            // power_input
            // 
            power_input.Location = new Point(175, 54);
            power_input.Name = "power_input";
            power_input.Size = new Size(100, 23);
            power_input.TabIndex = 18;
            power_input.TextChanged += power_input_TextChanged;
            // 
            // kwh_need_label
            // 
            kwh_need_label.AutoSize = true;
            kwh_need_label.Location = new Point(8, 19);
            kwh_need_label.Name = "kwh_need_label";
            kwh_need_label.Size = new Size(161, 15);
            kwh_need_label.TabIndex = 17;
            kwh_need_label.Text = "Szacowane miesięczne - kWh";
            // 
            // kwh_input
            // 
            kwh_input.Location = new Point(175, 16);
            kwh_input.Name = "kwh_input";
            kwh_input.Size = new Size(100, 23);
            kwh_input.TabIndex = 17;
            kwh_input.TextChanged += kwh_input_TextChanged;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(12, 148);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(150, 25);
            accept_button.TabIndex = 18;
            accept_button.Text = "Dodaj";
            accept_button.UseVisualStyleBackColor = true;
            accept_button.Click += accept_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(242, 148);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 19;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // FormEnergyData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 188);
            Controls.Add(cancel_button);
            Controls.Add(accept_button);
            Controls.Add(energy_data_groupbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEnergyData";
            Text = "Dane do szacowania - Energia elektryczna";
            energy_data_groupbox.ResumeLayout(false);
            energy_data_groupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox energy_data_groupbox;
        private Label text_error_month;
        private Label text_error_power;
        private Label text_error_kwh;
        private Label month_need_label;
        private TextBox month_input;
        private Label power_need_label;
        private TextBox power_input;
        private Label kwh_need_label;
        private TextBox kwh_input;
        private Button accept_button;
        private Button cancel_button;
    }
}
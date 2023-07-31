namespace MediaWIiR_APP
{
    partial class FormWaterFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaterFee));
            cancel_button = new Button();
            accept_button = new Button();
            water_data_froupbox = new GroupBox();
            vat_error = new Label();
            vat_label = new Label();
            vat_input = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            tariff_input = new TextBox();
            subscriptionSewage_error = new Label();
            subscriptionWater_error = new Label();
            sewage_error = new Label();
            water_error = new Label();
            subscriptionWater_label = new Label();
            subscriptionSewage_label = new Label();
            sewage_label = new Label();
            water_label = new Label();
            subscriptionSewage_input = new TextBox();
            subscriptionWater_input = new TextBox();
            sewage_input = new TextBox();
            water_input = new TextBox();
            water_data_froupbox.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(292, 264);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(130, 25);
            cancel_button.TabIndex = 8;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(12, 264);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(130, 25);
            accept_button.TabIndex = 7;
            accept_button.Text = "Dodaj";
            accept_button.UseVisualStyleBackColor = true;
            accept_button.Click += accept_button_Click;
            // 
            // water_data_froupbox
            // 
            water_data_froupbox.Controls.Add(vat_error);
            water_data_froupbox.Controls.Add(vat_label);
            water_data_froupbox.Controls.Add(vat_input);
            water_data_froupbox.Controls.Add(label1);
            water_data_froupbox.Controls.Add(label2);
            water_data_froupbox.Controls.Add(tariff_input);
            water_data_froupbox.Controls.Add(subscriptionSewage_error);
            water_data_froupbox.Controls.Add(subscriptionWater_error);
            water_data_froupbox.Controls.Add(sewage_error);
            water_data_froupbox.Controls.Add(water_error);
            water_data_froupbox.Controls.Add(subscriptionWater_label);
            water_data_froupbox.Controls.Add(subscriptionSewage_label);
            water_data_froupbox.Controls.Add(sewage_label);
            water_data_froupbox.Controls.Add(water_label);
            water_data_froupbox.Controls.Add(subscriptionSewage_input);
            water_data_froupbox.Controls.Add(subscriptionWater_input);
            water_data_froupbox.Controls.Add(sewage_input);
            water_data_froupbox.Controls.Add(water_input);
            water_data_froupbox.Location = new Point(12, 12);
            water_data_froupbox.Name = "water_data_froupbox";
            water_data_froupbox.Size = new Size(410, 240);
            water_data_froupbox.TabIndex = 0;
            water_data_froupbox.TabStop = false;
            water_data_froupbox.Text = "Dane do szacowania";
            // 
            // vat_error
            // 
            vat_error.AutoSize = true;
            vat_error.Location = new Point(266, 200);
            vat_error.Name = "vat_error";
            vat_error.Size = new Size(57, 15);
            vat_error.TabIndex = 31;
            vat_error.Text = "text_error";
            vat_error.Visible = false;
            // 
            // vat_label
            // 
            vat_label.AutoSize = true;
            vat_label.Location = new Point(125, 200);
            vat_label.Name = "vat_label";
            vat_label.Size = new Size(29, 15);
            vat_label.TabIndex = 30;
            vat_label.Text = "Vat: ";
            // 
            // vat_input
            // 
            vat_input.FormattingEnabled = true;
            vat_input.Items.AddRange(new object[] { "0", "5", "8", "23" });
            vat_input.Location = new Point(160, 197);
            vat_input.Name = "vat_input";
            vat_input.Size = new Size(100, 23);
            vat_input.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 14;
            label1.Text = "text_error";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Taryfa: ";
            // 
            // tariff_input
            // 
            tariff_input.Location = new Point(161, 22);
            tariff_input.Name = "tariff_input";
            tariff_input.Size = new Size(100, 23);
            tariff_input.TabIndex = 1;
            // 
            // subscriptionSewage_error
            // 
            subscriptionSewage_error.AutoSize = true;
            subscriptionSewage_error.Location = new Point(266, 164);
            subscriptionSewage_error.Name = "subscriptionSewage_error";
            subscriptionSewage_error.Size = new Size(57, 15);
            subscriptionSewage_error.TabIndex = 11;
            subscriptionSewage_error.Text = "text_error";
            subscriptionSewage_error.Visible = false;
            // 
            // subscriptionWater_error
            // 
            subscriptionWater_error.AutoSize = true;
            subscriptionWater_error.Location = new Point(266, 127);
            subscriptionWater_error.Name = "subscriptionWater_error";
            subscriptionWater_error.Size = new Size(57, 15);
            subscriptionWater_error.TabIndex = 10;
            subscriptionWater_error.Text = "text_error";
            subscriptionWater_error.Visible = false;
            // 
            // sewage_error
            // 
            sewage_error.AutoSize = true;
            sewage_error.Location = new Point(266, 96);
            sewage_error.Name = "sewage_error";
            sewage_error.Size = new Size(57, 15);
            sewage_error.TabIndex = 9;
            sewage_error.Text = "text_error";
            sewage_error.Visible = false;
            // 
            // water_error
            // 
            water_error.AutoSize = true;
            water_error.Location = new Point(266, 61);
            water_error.Name = "water_error";
            water_error.Size = new Size(57, 15);
            water_error.TabIndex = 8;
            water_error.Text = "text_error";
            water_error.Visible = false;
            // 
            // subscriptionWater_label
            // 
            subscriptionWater_label.AutoSize = true;
            subscriptionWater_label.Location = new Point(13, 130);
            subscriptionWater_label.Name = "subscriptionWater_label";
            subscriptionWater_label.Size = new Size(141, 15);
            subscriptionWater_label.TabIndex = 7;
            subscriptionWater_label.Text = "Abonament - woda - mc:";
            // 
            // subscriptionSewage_label
            // 
            subscriptionSewage_label.AutoSize = true;
            subscriptionSewage_label.Location = new Point(13, 164);
            subscriptionSewage_label.Name = "subscriptionSewage_label";
            subscriptionSewage_label.Size = new Size(141, 15);
            subscriptionSewage_label.TabIndex = 6;
            subscriptionSewage_label.Text = "Abonament - ścieki - mc:";
            // 
            // sewage_label
            // 
            sewage_label.AutoSize = true;
            sewage_label.Location = new Point(86, 96);
            sewage_label.Name = "sewage_label";
            sewage_label.Size = new Size(68, 15);
            sewage_label.TabIndex = 5;
            sewage_label.Text = "Ścieki - m3:";
            // 
            // water_label
            // 
            water_label.AutoSize = true;
            water_label.Location = new Point(85, 61);
            water_label.Name = "water_label";
            water_label.Size = new Size(69, 15);
            water_label.TabIndex = 4;
            water_label.Text = "Woda - m3:";
            // 
            // subscriptionSewage_input
            // 
            subscriptionSewage_input.Location = new Point(160, 161);
            subscriptionSewage_input.Name = "subscriptionSewage_input";
            subscriptionSewage_input.Size = new Size(100, 23);
            subscriptionSewage_input.TabIndex = 5;
            // 
            // subscriptionWater_input
            // 
            subscriptionWater_input.Location = new Point(160, 127);
            subscriptionWater_input.Name = "subscriptionWater_input";
            subscriptionWater_input.Size = new Size(100, 23);
            subscriptionWater_input.TabIndex = 4;
            // 
            // sewage_input
            // 
            sewage_input.Location = new Point(160, 93);
            sewage_input.Name = "sewage_input";
            sewage_input.Size = new Size(100, 23);
            sewage_input.TabIndex = 3;
            // 
            // water_input
            // 
            water_input.Location = new Point(160, 58);
            water_input.Name = "water_input";
            water_input.Size = new Size(100, 23);
            water_input.TabIndex = 2;
            // 
            // FormWaterFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(434, 301);
            Controls.Add(water_data_froupbox);
            Controls.Add(cancel_button);
            Controls.Add(accept_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWaterFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dane Woda - Taryfa";
            water_data_froupbox.ResumeLayout(false);
            water_data_froupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button accept_button;
        private GroupBox water_data_froupbox;
        private TextBox subscriptionSewage_input;
        private TextBox subscriptionWater_input;
        private TextBox sewage_input;
        private TextBox water_input;
        private Label subscriptionSewage_error;
        private Label subscriptionWater_error;
        private Label sewage_error;
        private Label water_error;
        private Label subscriptionWater_label;
        private Label subscriptionSewage_label;
        private Label sewage_label;
        private Label water_label;
        private Label label1;
        private Label label2;
        private TextBox tariff_input;
        private Label vat_error;
        private Label vat_label;
        private ComboBox vat_input;
    }
}
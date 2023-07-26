namespace MediaWIiR_APP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            city_input = new TextBox();
            save_to_pdf_click = new Button();
            estimate_click = new Button();
            unit_info_groubpox = new GroupBox();
            city_error = new Label();
            address_error = new Label();
            zip_code_error = new Label();
            select_county_error = new Label();
            select_unit_type_error = new Label();
            county_input = new ComboBox();
            zip_code_input = new TextBox();
            county_label = new Label();
            city_label = new Label();
            zip_code_label = new Label();
            unit_address_label = new Label();
            unit_type_input = new ComboBox();
            address_input = new TextBox();
            unit_type_label = new Label();
            media_type_groupbox = new GroupBox();
            select_media_error = new Label();
            media_type_input = new ComboBox();
            estimation_date = new DateTimePicker();
            estimation_date_groupbox = new GroupBox();
            estimated_data_groupbox = new GroupBox();
            text_error_month = new Label();
            text_error_power = new Label();
            text_error_kwh = new Label();
            month_need_label = new Label();
            month_input = new TextBox();
            power_need_label = new Label();
            power_input = new TextBox();
            kwh_need_label = new Label();
            kwh_input = new TextBox();
            add_fee_button = new Button();
            unit_info_groubpox.SuspendLayout();
            media_type_groupbox.SuspendLayout();
            estimation_date_groupbox.SuspendLayout();
            estimated_data_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // city_input
            // 
            city_input.Location = new Point(6, 122);
            city_input.Name = "city_input";
            city_input.Size = new Size(149, 23);
            city_input.TabIndex = 3;
            city_input.TextChanged += city_input_TextChanged;
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Enabled = false;
            save_to_pdf_click.Location = new Point(513, 422);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(119, 27);
            save_to_pdf_click.TabIndex = 15;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // estimate_click
            // 
            estimate_click.Location = new Point(513, 389);
            estimate_click.Name = "estimate_click";
            estimate_click.Size = new Size(119, 27);
            estimate_click.TabIndex = 14;
            estimate_click.Text = "Szacuj koszty";
            estimate_click.UseVisualStyleBackColor = true;
            estimate_click.Click += estimate_click_Click;
            // 
            // unit_info_groubpox
            // 
            unit_info_groubpox.Controls.Add(city_error);
            unit_info_groubpox.Controls.Add(address_error);
            unit_info_groubpox.Controls.Add(zip_code_error);
            unit_info_groubpox.Controls.Add(select_county_error);
            unit_info_groubpox.Controls.Add(select_unit_type_error);
            unit_info_groubpox.Controls.Add(county_input);
            unit_info_groubpox.Controls.Add(city_input);
            unit_info_groubpox.Controls.Add(zip_code_input);
            unit_info_groubpox.Controls.Add(county_label);
            unit_info_groubpox.Controls.Add(city_label);
            unit_info_groubpox.Controls.Add(zip_code_label);
            unit_info_groubpox.Controls.Add(unit_address_label);
            unit_info_groubpox.Controls.Add(unit_type_input);
            unit_info_groubpox.Controls.Add(address_input);
            unit_info_groubpox.Controls.Add(unit_type_label);
            unit_info_groubpox.Location = new Point(12, 12);
            unit_info_groubpox.Name = "unit_info_groubpox";
            unit_info_groubpox.Size = new Size(432, 185);
            unit_info_groubpox.TabIndex = 0;
            unit_info_groubpox.TabStop = false;
            unit_info_groubpox.Text = "Dane adresowe jednostki";
            unit_info_groubpox.Enter += unit_info_groubpox_Enter;
            // 
            // city_error
            // 
            city_error.AutoSize = true;
            city_error.Location = new Point(6, 148);
            city_error.Name = "city_error";
            city_error.Size = new Size(57, 15);
            city_error.TabIndex = 0;
            city_error.Text = "text_error";
            city_error.Visible = false;
            // 
            // address_error
            // 
            address_error.AutoSize = true;
            address_error.Location = new Point(202, 72);
            address_error.Name = "address_error";
            address_error.Size = new Size(57, 15);
            address_error.TabIndex = 1;
            address_error.Text = "text_error";
            address_error.Visible = false;
            // 
            // zip_code_error
            // 
            zip_code_error.AutoSize = true;
            zip_code_error.Location = new Point(161, 148);
            zip_code_error.Name = "zip_code_error";
            zip_code_error.Size = new Size(88, 15);
            zip_code_error.TabIndex = 2;
            zip_code_error.Text = "select_from_list";
            zip_code_error.Visible = false;
            // 
            // select_county_error
            // 
            select_county_error.AutoSize = true;
            select_county_error.Location = new Point(267, 148);
            select_county_error.Name = "select_county_error";
            select_county_error.Size = new Size(88, 15);
            select_county_error.TabIndex = 3;
            select_county_error.Text = "select_from_list";
            select_county_error.Visible = false;
            // 
            // select_unit_type_error
            // 
            select_unit_type_error.AutoSize = true;
            select_unit_type_error.Location = new Point(6, 72);
            select_unit_type_error.Name = "select_unit_type_error";
            select_unit_type_error.Size = new Size(88, 15);
            select_unit_type_error.TabIndex = 4;
            select_unit_type_error.Text = "select_from_list";
            select_unit_type_error.Visible = false;
            // 
            // county_input
            // 
            county_input.BackColor = SystemColors.Window;
            county_input.FormattingEnabled = true;
            county_input.Items.AddRange(new object[] { "KWP Poznań", "CBŚP", "BSW", "Laboratorium", "Lotnictwo", "Chodzież", "Czarnków", "Gniezno", "Gostyń", "Grodzisk Wlkp.", "Jarocin", "Kalisz", "Kępno", "Koło", "Konin", "Kościan", "Krotoszyn", "Leszno", "Międzychód", "Nowy Tomyśl", "Oborniki", "Ostrów Wlkp.", "Ostrzeszów", "Piła", "Pleszew", "Poznań", "Rawicz", "Słupca", "Śrem", "Środa Wlkp.", "Szamotuły", "Turek", "Wągrowiec", "Wolsztyn", "Września", "Złotów" });
            county_input.Location = new Point(267, 122);
            county_input.Name = "county_input";
            county_input.Size = new Size(149, 23);
            county_input.TabIndex = 5;
            county_input.SelectedIndexChanged += county_input_SelectedIndexChanged;
            // 
            // zip_code_input
            // 
            zip_code_input.Location = new Point(161, 122);
            zip_code_input.Name = "zip_code_input";
            zip_code_input.PlaceholderText = "xx-xxx";
            zip_code_input.Size = new Size(100, 23);
            zip_code_input.TabIndex = 4;
            zip_code_input.TextChanged += zip_code_input_TextChanged;
            // 
            // county_label
            // 
            county_label.AutoSize = true;
            county_label.Location = new Point(267, 104);
            county_label.Name = "county_label";
            county_label.Size = new Size(43, 15);
            county_label.TabIndex = 6;
            county_label.Text = "Powiat";
            // 
            // city_label
            // 
            city_label.AutoSize = true;
            city_label.Location = new Point(6, 104);
            city_label.Name = "city_label";
            city_label.Size = new Size(43, 15);
            city_label.TabIndex = 7;
            city_label.Text = "Miasto";
            // 
            // zip_code_label
            // 
            zip_code_label.AutoSize = true;
            zip_code_label.Location = new Point(161, 104);
            zip_code_label.Name = "zip_code_label";
            zip_code_label.Size = new Size(82, 15);
            zip_code_label.TabIndex = 8;
            zip_code_label.Text = "Kod pocztowy";
            // 
            // unit_address_label
            // 
            unit_address_label.AutoSize = true;
            unit_address_label.Location = new Point(202, 28);
            unit_address_label.Name = "unit_address_label";
            unit_address_label.Size = new Size(37, 15);
            unit_address_label.TabIndex = 9;
            unit_address_label.Text = "Adres";
            // 
            // unit_type_input
            // 
            unit_type_input.FormattingEnabled = true;
            unit_type_input.Items.AddRange(new object[] { "Komenda Wojewdzka Policji", "Komenda Miejska Policji", "Komenda Powiatowa Policji", "Komisariat Policji", "Posterunek Policji", "Rewir Dzielnicowych" });
            unit_type_input.Location = new Point(6, 46);
            unit_type_input.Name = "unit_type_input";
            unit_type_input.Size = new Size(190, 23);
            unit_type_input.TabIndex = 1;
            unit_type_input.SelectedIndexChanged += unit_type_input_SelectedIndexChanged;
            // 
            // address_input
            // 
            address_input.Location = new Point(202, 46);
            address_input.Name = "address_input";
            address_input.Size = new Size(215, 23);
            address_input.TabIndex = 2;
            address_input.TextChanged += address_input_TextChanged;
            // 
            // unit_type_label
            // 
            unit_type_label.AutoSize = true;
            unit_type_label.Location = new Point(6, 28);
            unit_type_label.Name = "unit_type_label";
            unit_type_label.Size = new Size(93, 15);
            unit_type_label.TabIndex = 10;
            unit_type_label.Text = "Rodzaj jednostki";
            // 
            // media_type_groupbox
            // 
            media_type_groupbox.Controls.Add(select_media_error);
            media_type_groupbox.Controls.Add(media_type_input);
            media_type_groupbox.Location = new Point(450, 87);
            media_type_groupbox.Name = "media_type_groupbox";
            media_type_groupbox.Size = new Size(180, 80);
            media_type_groupbox.TabIndex = 13;
            media_type_groupbox.TabStop = false;
            media_type_groupbox.Text = "Rodzaj mediów";
            // 
            // select_media_error
            // 
            select_media_error.AutoSize = true;
            select_media_error.Location = new Point(6, 48);
            select_media_error.Name = "select_media_error";
            select_media_error.Size = new Size(88, 15);
            select_media_error.TabIndex = 0;
            select_media_error.Text = "select_from_list";
            select_media_error.Visible = false;
            select_media_error.Click += select_media_error_Click;
            // 
            // media_type_input
            // 
            media_type_input.FormattingEnabled = true;
            media_type_input.Items.AddRange(new object[] { "Energia elektryczna", "Energia cieplna", "Woda", "Gaz" });
            media_type_input.Location = new Point(6, 22);
            media_type_input.Name = "media_type_input";
            media_type_input.Size = new Size(160, 23);
            media_type_input.TabIndex = 4;
            media_type_input.SelectedIndexChanged += media_type_input_SelectedIndexChanged;
            // 
            // estimation_date
            // 
            estimation_date.Format = DateTimePickerFormat.Short;
            estimation_date.Location = new Point(27, 29);
            estimation_date.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            estimation_date.MinDate = new DateTime(2019, 1, 1, 0, 0, 0, 0);
            estimation_date.Name = "estimation_date";
            estimation_date.Size = new Size(114, 23);
            estimation_date.TabIndex = 20;
            estimation_date.Value = new DateTime(2023, 7, 26, 0, 0, 0, 0);
            // 
            // estimation_date_groupbox
            // 
            estimation_date_groupbox.Controls.Add(estimation_date);
            estimation_date_groupbox.Location = new Point(450, 12);
            estimation_date_groupbox.Name = "estimation_date_groupbox";
            estimation_date_groupbox.Size = new Size(180, 69);
            estimation_date_groupbox.TabIndex = 12;
            estimation_date_groupbox.TabStop = false;
            estimation_date_groupbox.Text = "Data szacowania";
            // 
            // estimated_data_groupbox
            // 
            estimated_data_groupbox.Controls.Add(text_error_month);
            estimated_data_groupbox.Controls.Add(text_error_power);
            estimated_data_groupbox.Controls.Add(text_error_kwh);
            estimated_data_groupbox.Controls.Add(month_need_label);
            estimated_data_groupbox.Controls.Add(month_input);
            estimated_data_groupbox.Controls.Add(power_need_label);
            estimated_data_groupbox.Controls.Add(power_input);
            estimated_data_groupbox.Controls.Add(kwh_need_label);
            estimated_data_groupbox.Controls.Add(kwh_input);
            estimated_data_groupbox.Location = new Point(12, 203);
            estimated_data_groupbox.Name = "estimated_data_groupbox";
            estimated_data_groupbox.Size = new Size(196, 246);
            estimated_data_groupbox.TabIndex = 16;
            estimated_data_groupbox.TabStop = false;
            estimated_data_groupbox.Text = "Dane do szacowania";
            // 
            // text_error_month
            // 
            text_error_month.AutoSize = true;
            text_error_month.Location = new Point(6, 219);
            text_error_month.Name = "text_error_month";
            text_error_month.Size = new Size(57, 15);
            text_error_month.TabIndex = 23;
            text_error_month.Text = "text_error";
            text_error_month.Visible = false;
            // 
            // text_error_power
            // 
            text_error_power.AutoSize = true;
            text_error_power.Location = new Point(6, 143);
            text_error_power.Name = "text_error_power";
            text_error_power.Size = new Size(57, 15);
            text_error_power.TabIndex = 22;
            text_error_power.Text = "text_error";
            text_error_power.Visible = false;
            // 
            // text_error_kwh
            // 
            text_error_kwh.AutoSize = true;
            text_error_kwh.Location = new Point(6, 63);
            text_error_kwh.Name = "text_error_kwh";
            text_error_kwh.Size = new Size(57, 15);
            text_error_kwh.TabIndex = 17;
            text_error_kwh.Text = "text_error";
            text_error_kwh.Visible = false;
            // 
            // month_need_label
            // 
            month_need_label.AutoSize = true;
            month_need_label.Location = new Point(6, 175);
            month_need_label.Name = "month_need_label";
            month_need_label.Size = new Size(89, 15);
            month_need_label.TabIndex = 21;
            month_need_label.Text = "Liczba miesięcy";
            // 
            // month_input
            // 
            month_input.Location = new Point(6, 193);
            month_input.Name = "month_input";
            month_input.Size = new Size(100, 23);
            month_input.TabIndex = 20;
            // 
            // power_need_label
            // 
            power_need_label.AutoSize = true;
            power_need_label.Location = new Point(6, 99);
            power_need_label.Name = "power_need_label";
            power_need_label.Size = new Size(135, 15);
            power_need_label.TabIndex = 19;
            power_need_label.Text = "Zpotrzebowanie na moc";
            // 
            // power_input
            // 
            power_input.Location = new Point(6, 117);
            power_input.Name = "power_input";
            power_input.Size = new Size(100, 23);
            power_input.TabIndex = 18;
            // 
            // kwh_need_label
            // 
            kwh_need_label.AutoSize = true;
            kwh_need_label.Location = new Point(6, 19);
            kwh_need_label.Name = "kwh_need_label";
            kwh_need_label.Size = new Size(153, 15);
            kwh_need_label.TabIndex = 17;
            kwh_need_label.Text = "Szacowane miesięczne kWh";
            // 
            // kwh_input
            // 
            kwh_input.Location = new Point(6, 37);
            kwh_input.Name = "kwh_input";
            kwh_input.Size = new Size(100, 23);
            kwh_input.TabIndex = 17;
            // 
            // add_fee_button
            // 
            add_fee_button.Location = new Point(450, 173);
            add_fee_button.Name = "add_fee_button";
            add_fee_button.Size = new Size(180, 23);
            add_fee_button.TabIndex = 17;
            add_fee_button.Text = "Dodaj opłaty";
            add_fee_button.UseVisualStyleBackColor = true;
            add_fee_button.Click += add_fee_button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 461);
            Controls.Add(add_fee_button);
            Controls.Add(estimated_data_groupbox);
            Controls.Add(estimation_date_groupbox);
            Controls.Add(media_type_groupbox);
            Controls.Add(unit_info_groubpox);
            Controls.Add(estimate_click);
            Controls.Add(save_to_pdf_click);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WIiR - Szacowanie kosztów mediów";
            Load += MainForm_Load;
            unit_info_groubpox.ResumeLayout(false);
            unit_info_groubpox.PerformLayout();
            media_type_groupbox.ResumeLayout(false);
            media_type_groupbox.PerformLayout();
            estimation_date_groupbox.ResumeLayout(false);
            estimated_data_groupbox.ResumeLayout(false);
            estimated_data_groupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button save_to_pdf_click;
        private Button estimate_click;
        private GroupBox unit_info_groubpox;
        private Label unit_type_label;
        private ComboBox unit_type_input;
        private TextBox address_input;
        private Label unit_address_label;
        private Label county_label;
        private Label city_label;
        private Label zip_code_label;
        private TextBox city_input;
        private TextBox zip_code_input;
        private ComboBox county_input;
        private GroupBox media_type_groupbox;
        private ComboBox media_type_input;
        private Label select_county_error;
        private Label select_unit_type_error;
        private Label select_media_error;
        private Label zip_code_error;
        private Label city_error;
        private Label address_error;
        private DateTimePicker estimation_date;
        private GroupBox estimation_date_groupbox;
        private GroupBox estimated_data_groupbox;
        private Label kwh_need_label;
        private TextBox kwh_input;
        private Label power_need_label;
        private TextBox power_input;
        private Label text_error_month;
        private Label text_error_power;
        private Label text_error_kwh;
        private Label month_need_label;
        private TextBox month_input;
        private Button add_fee_button;
    }
}
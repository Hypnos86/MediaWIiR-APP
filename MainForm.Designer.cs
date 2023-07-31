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
            media_type_select = new ComboBox();
            estimation_date = new DateTimePicker();
            estimation_date_groupbox = new GroupBox();
            add_fee_button = new Button();
            add_data_button = new Button();
            stripMenu = new MenuStrip();
            MenuStrip = new ToolStripMenuItem();
            StripMenuItem = new ToolStripMenuItem();
            unit_info_groubpox.SuspendLayout();
            media_type_groupbox.SuspendLayout();
            estimation_date_groupbox.SuspendLayout();
            stripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // city_input
            // 
            resources.ApplyResources(city_input, "city_input");
            city_input.Name = "city_input";
            // 
            // estimate_click
            // 
            resources.ApplyResources(estimate_click, "estimate_click");
            estimate_click.Name = "estimate_click";
            estimate_click.UseVisualStyleBackColor = true;
            estimate_click.Click += estimate_click_Click;
            // 
            // unit_info_groubpox
            // 
            resources.ApplyResources(unit_info_groubpox, "unit_info_groubpox");
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
            unit_info_groubpox.Name = "unit_info_groubpox";
            unit_info_groubpox.TabStop = false;
            // 
            // city_error
            // 
            resources.ApplyResources(city_error, "city_error");
            city_error.Name = "city_error";
            // 
            // address_error
            // 
            resources.ApplyResources(address_error, "address_error");
            address_error.Name = "address_error";
            // 
            // zip_code_error
            // 
            resources.ApplyResources(zip_code_error, "zip_code_error");
            zip_code_error.Name = "zip_code_error";
            // 
            // select_county_error
            // 
            resources.ApplyResources(select_county_error, "select_county_error");
            select_county_error.Name = "select_county_error";
            // 
            // select_unit_type_error
            // 
            resources.ApplyResources(select_unit_type_error, "select_unit_type_error");
            select_unit_type_error.Name = "select_unit_type_error";
            // 
            // county_input
            // 
            resources.ApplyResources(county_input, "county_input");
            county_input.BackColor = SystemColors.Window;
            county_input.FormattingEnabled = true;
            county_input.Items.AddRange(new object[] { resources.GetString("county_input.Items"), resources.GetString("county_input.Items1"), resources.GetString("county_input.Items2"), resources.GetString("county_input.Items3"), resources.GetString("county_input.Items4"), resources.GetString("county_input.Items5"), resources.GetString("county_input.Items6"), resources.GetString("county_input.Items7"), resources.GetString("county_input.Items8"), resources.GetString("county_input.Items9"), resources.GetString("county_input.Items10"), resources.GetString("county_input.Items11"), resources.GetString("county_input.Items12"), resources.GetString("county_input.Items13"), resources.GetString("county_input.Items14"), resources.GetString("county_input.Items15"), resources.GetString("county_input.Items16"), resources.GetString("county_input.Items17"), resources.GetString("county_input.Items18"), resources.GetString("county_input.Items19"), resources.GetString("county_input.Items20"), resources.GetString("county_input.Items21"), resources.GetString("county_input.Items22"), resources.GetString("county_input.Items23"), resources.GetString("county_input.Items24"), resources.GetString("county_input.Items25"), resources.GetString("county_input.Items26"), resources.GetString("county_input.Items27"), resources.GetString("county_input.Items28"), resources.GetString("county_input.Items29"), resources.GetString("county_input.Items30"), resources.GetString("county_input.Items31"), resources.GetString("county_input.Items32"), resources.GetString("county_input.Items33"), resources.GetString("county_input.Items34"), resources.GetString("county_input.Items35") });
            county_input.Name = "county_input";
            // 
            // zip_code_input
            // 
            resources.ApplyResources(zip_code_input, "zip_code_input");
            zip_code_input.Name = "zip_code_input";
            // 
            // county_label
            // 
            resources.ApplyResources(county_label, "county_label");
            county_label.Name = "county_label";
            // 
            // city_label
            // 
            resources.ApplyResources(city_label, "city_label");
            city_label.Name = "city_label";
            // 
            // zip_code_label
            // 
            resources.ApplyResources(zip_code_label, "zip_code_label");
            zip_code_label.Name = "zip_code_label";
            // 
            // unit_address_label
            // 
            resources.ApplyResources(unit_address_label, "unit_address_label");
            unit_address_label.Name = "unit_address_label";
            // 
            // unit_type_input
            // 
            resources.ApplyResources(unit_type_input, "unit_type_input");
            unit_type_input.FormattingEnabled = true;
            unit_type_input.Items.AddRange(new object[] { resources.GetString("unit_type_input.Items"), resources.GetString("unit_type_input.Items1"), resources.GetString("unit_type_input.Items2"), resources.GetString("unit_type_input.Items3"), resources.GetString("unit_type_input.Items4"), resources.GetString("unit_type_input.Items5"), resources.GetString("unit_type_input.Items6"), resources.GetString("unit_type_input.Items7") });
            unit_type_input.Name = "unit_type_input";
            // 
            // address_input
            // 
            resources.ApplyResources(address_input, "address_input");
            address_input.Name = "address_input";
            // 
            // unit_type_label
            // 
            resources.ApplyResources(unit_type_label, "unit_type_label");
            unit_type_label.Name = "unit_type_label";
            // 
            // media_type_groupbox
            // 
            resources.ApplyResources(media_type_groupbox, "media_type_groupbox");
            media_type_groupbox.Controls.Add(select_media_error);
            media_type_groupbox.Controls.Add(media_type_select);
            media_type_groupbox.Name = "media_type_groupbox";
            media_type_groupbox.TabStop = false;
            // 
            // select_media_error
            // 
            resources.ApplyResources(select_media_error, "select_media_error");
            select_media_error.Name = "select_media_error";
            // 
            // media_type_select
            // 
            resources.ApplyResources(media_type_select, "media_type_select");
            media_type_select.FormattingEnabled = true;
            media_type_select.Items.AddRange(new object[] { resources.GetString("media_type_select.Items"), resources.GetString("media_type_select.Items1"), resources.GetString("media_type_select.Items2"), resources.GetString("media_type_select.Items3") });
            media_type_select.Name = "media_type_select";
            media_type_select.SelectedIndexChanged += media_type_select_SelectedIndexChanged;
            // 
            // estimation_date
            // 
            resources.ApplyResources(estimation_date, "estimation_date");
            estimation_date.Format = DateTimePickerFormat.Short;
            estimation_date.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            estimation_date.MinDate = new DateTime(2019, 1, 1, 0, 0, 0, 0);
            estimation_date.Name = "estimation_date";
            estimation_date.Value = new DateTime(2023, 7, 26, 0, 0, 0, 0);
            // 
            // estimation_date_groupbox
            // 
            resources.ApplyResources(estimation_date_groupbox, "estimation_date_groupbox");
            estimation_date_groupbox.Controls.Add(estimation_date);
            estimation_date_groupbox.Name = "estimation_date_groupbox";
            estimation_date_groupbox.TabStop = false;
            // 
            // add_fee_button
            // 
            resources.ApplyResources(add_fee_button, "add_fee_button");
            add_fee_button.Name = "add_fee_button";
            add_fee_button.UseVisualStyleBackColor = true;
            add_fee_button.Click += add_fee_button_Click;
            // 
            // add_data_button
            // 
            resources.ApplyResources(add_data_button, "add_data_button");
            add_data_button.Name = "add_data_button";
            add_data_button.UseVisualStyleBackColor = true;
            add_data_button.Click += add_data_Click;
            // 
            // stripMenu
            // 
            resources.ApplyResources(stripMenu, "stripMenu");
            stripMenu.Items.AddRange(new ToolStripItem[] { MenuStrip });
            stripMenu.Name = "stripMenu";
            // 
            // MenuStrip
            // 
            resources.ApplyResources(MenuStrip, "MenuStrip");
            MenuStrip.DropDownItems.AddRange(new ToolStripItem[] { StripMenuItem });
            MenuStrip.Name = "MenuStrip";
            // 
            // StripMenuItem
            // 
            resources.ApplyResources(StripMenuItem, "StripMenuItem");
            StripMenuItem.Name = "StripMenuItem";
            StripMenuItem.Click += StripMenuItem_Click;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(add_data_button);
            Controls.Add(add_fee_button);
            Controls.Add(estimation_date_groupbox);
            Controls.Add(media_type_groupbox);
            Controls.Add(unit_info_groubpox);
            Controls.Add(estimate_click);
            Controls.Add(stripMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = stripMenu;
            Name = "MainForm";
            unit_info_groubpox.ResumeLayout(false);
            unit_info_groubpox.PerformLayout();
            media_type_groupbox.ResumeLayout(false);
            media_type_groupbox.PerformLayout();
            estimation_date_groupbox.ResumeLayout(false);
            stripMenu.ResumeLayout(false);
            stripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private ComboBox media_type_select;
        private Label select_county_error;
        private Label select_unit_type_error;
        private Label select_media_error;
        private Label zip_code_error;
        private Label city_error;
        private Label address_error;
        private DateTimePicker estimation_date;
        private GroupBox estimation_date_groupbox;
        private Button add_fee_button;
        private Button add_data_button;
        private MenuStrip stripMenu;
        private ToolStripMenuItem MenuStrip;
        private ToolStripMenuItem StripMenuItem;
    }
}
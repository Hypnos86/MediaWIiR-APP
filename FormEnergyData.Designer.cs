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
            add_button = new Button();
            cancel_button = new Button();
            energy_data_groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // energy_data_groupbox
            // 
            resources.ApplyResources(energy_data_groupbox, "energy_data_groupbox");
            energy_data_groupbox.Controls.Add(text_error_month);
            energy_data_groupbox.Controls.Add(text_error_power);
            energy_data_groupbox.Controls.Add(text_error_kwh);
            energy_data_groupbox.Controls.Add(month_need_label);
            energy_data_groupbox.Controls.Add(month_input);
            energy_data_groupbox.Controls.Add(power_need_label);
            energy_data_groupbox.Controls.Add(power_input);
            energy_data_groupbox.Controls.Add(kwh_need_label);
            energy_data_groupbox.Controls.Add(kwh_input);
            energy_data_groupbox.Name = "energy_data_groupbox";
            energy_data_groupbox.TabStop = false;
            // 
            // text_error_month
            // 
            resources.ApplyResources(text_error_month, "text_error_month");
            text_error_month.Name = "text_error_month";
            // 
            // text_error_power
            // 
            resources.ApplyResources(text_error_power, "text_error_power");
            text_error_power.Name = "text_error_power";
            // 
            // text_error_kwh
            // 
            resources.ApplyResources(text_error_kwh, "text_error_kwh");
            text_error_kwh.Name = "text_error_kwh";
            // 
            // month_need_label
            // 
            resources.ApplyResources(month_need_label, "month_need_label");
            month_need_label.Name = "month_need_label";
            // 
            // month_input
            // 
            resources.ApplyResources(month_input, "month_input");
            month_input.Name = "month_input";
            // 
            // power_need_label
            // 
            resources.ApplyResources(power_need_label, "power_need_label");
            power_need_label.Name = "power_need_label";
            // 
            // power_input
            // 
            resources.ApplyResources(power_input, "power_input");
            power_input.Name = "power_input";
            // 
            // kwh_need_label
            // 
            resources.ApplyResources(kwh_need_label, "kwh_need_label");
            kwh_need_label.Name = "kwh_need_label";
            // 
            // kwh_input
            // 
            resources.ApplyResources(kwh_input, "kwh_input");
            kwh_input.Name = "kwh_input";
            // 
            // add_button
            // 
            resources.ApplyResources(add_button, "add_button");
            add_button.Name = "add_button";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += accept_button_Click;
            // 
            // cancel_button
            // 
            resources.ApplyResources(cancel_button, "cancel_button");
            cancel_button.Name = "cancel_button";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // FormEnergyData
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancel_button);
            Controls.Add(add_button);
            Controls.Add(energy_data_groupbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormEnergyData";
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
        private Button add_button;
        private Button cancel_button;
    }
}
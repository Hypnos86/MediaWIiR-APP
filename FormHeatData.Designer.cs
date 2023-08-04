namespace MediaWIiR_APP
{
    partial class FormHeatData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeatData));
            cancel_button = new Button();
            add_button = new Button();
            estimationGroupBox = new GroupBox();
            month_input = new TextBox();
            mont_error = new Label();
            month_label = new Label();
            carrier_input = new TextBox();
            carrer_error = new Label();
            carrier_label = new Label();
            power_input = new TextBox();
            power_error = new Label();
            power_label = new Label();
            heat_input = new TextBox();
            heat_error = new Label();
            heat_label = new Label();
            estimationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(262, 178);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(130, 25);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(12, 178);
            add_button.Name = "add_button";
            add_button.Size = new Size(130, 25);
            add_button.TabIndex = 1;
            add_button.Text = "Dodaj";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // estimationGroupBox
            // 
            estimationGroupBox.Controls.Add(month_input);
            estimationGroupBox.Controls.Add(mont_error);
            estimationGroupBox.Controls.Add(month_label);
            estimationGroupBox.Controls.Add(carrier_input);
            estimationGroupBox.Controls.Add(carrer_error);
            estimationGroupBox.Controls.Add(carrier_label);
            estimationGroupBox.Controls.Add(power_input);
            estimationGroupBox.Controls.Add(power_error);
            estimationGroupBox.Controls.Add(power_label);
            estimationGroupBox.Controls.Add(heat_input);
            estimationGroupBox.Controls.Add(heat_error);
            estimationGroupBox.Controls.Add(heat_label);
            estimationGroupBox.Location = new Point(12, 12);
            estimationGroupBox.Name = "estimationGroupBox";
            estimationGroupBox.Size = new Size(380, 150);
            estimationGroupBox.TabIndex = 2;
            estimationGroupBox.TabStop = false;
            estimationGroupBox.Text = "Dane do szacowania";
            // 
            // month_input
            // 
            month_input.Location = new Point(186, 109);
            month_input.Name = "month_input";
            month_input.Size = new Size(100, 23);
            month_input.TabIndex = 11;
            // 
            // mont_error
            // 
            mont_error.AutoSize = true;
            mont_error.Location = new Point(292, 112);
            mont_error.Name = "mont_error";
            mont_error.Size = new Size(57, 15);
            mont_error.TabIndex = 10;
            mont_error.Text = "text_error";
            mont_error.Visible = false;
            // 
            // month_label
            // 
            month_label.AutoSize = true;
            month_label.Location = new Point(88, 112);
            month_label.Name = "month_label";
            month_label.Size = new Size(92, 15);
            month_label.TabIndex = 9;
            month_label.Text = "Liczba miesięcy:";
            // 
            // carrier_input
            // 
            carrier_input.Location = new Point(186, 80);
            carrier_input.Name = "carrier_input";
            carrier_input.Size = new Size(100, 23);
            carrier_input.TabIndex = 8;
            carrier_input.Text = "0";
            // 
            // carrer_error
            // 
            carrer_error.AutoSize = true;
            carrer_error.Location = new Point(292, 83);
            carrer_error.Name = "carrer_error";
            carrer_error.Size = new Size(57, 15);
            carrer_error.TabIndex = 7;
            carrer_error.Text = "text_error";
            carrer_error.Visible = false;
            // 
            // carrier_label
            // 
            carrier_label.AutoSize = true;
            carrier_label.Location = new Point(105, 83);
            carrier_label.Name = "carrier_label";
            carrier_label.Size = new Size(75, 15);
            carrier_label.TabIndex = 6;
            carrier_label.Text = "Nośnik - m3:";
            // 
            // power_input
            // 
            power_input.Location = new Point(186, 51);
            power_input.Name = "power_input";
            power_input.Size = new Size(100, 23);
            power_input.TabIndex = 5;
            // 
            // power_error
            // 
            power_error.AutoSize = true;
            power_error.Location = new Point(292, 54);
            power_error.Name = "power_error";
            power_error.Size = new Size(57, 15);
            power_error.TabIndex = 4;
            power_error.Text = "text_error";
            power_error.Visible = false;
            // 
            // power_label
            // 
            power_label.AutoSize = true;
            power_label.Location = new Point(9, 54);
            power_label.Name = "power_label";
            power_label.Size = new Size(171, 15);
            power_label.TabIndex = 3;
            power_label.Text = "Zpotrzebowanie na moc - MW:";
            // 
            // heat_input
            // 
            heat_input.Location = new Point(186, 22);
            heat_input.Name = "heat_input";
            heat_input.Size = new Size(100, 23);
            heat_input.TabIndex = 2;
            // 
            // heat_error
            // 
            heat_error.AutoSize = true;
            heat_error.Location = new Point(292, 25);
            heat_error.Name = "heat_error";
            heat_error.Size = new Size(57, 15);
            heat_error.TabIndex = 1;
            heat_error.Text = "text_error";
            heat_error.Visible = false;
            // 
            // heat_label
            // 
            heat_label.AutoSize = true;
            heat_label.Location = new Point(28, 25);
            heat_label.Name = "heat_label";
            heat_label.Size = new Size(152, 15);
            heat_label.TabIndex = 0;
            heat_label.Text = "Szacowane miesięczne - GJ:";
            // 
            // FormHeatData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 211);
            Controls.Add(estimationGroupBox);
            Controls.Add(add_button);
            Controls.Add(cancel_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHeatData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dane do szacowania - Energia cieplna";
            estimationGroupBox.ResumeLayout(false);
            estimationGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button add_button;
        private GroupBox estimationGroupBox;
        private TextBox heat_input;
        private Label heat_error;
        private Label heat_label;
        private TextBox month_input;
        private Label mont_error;
        private Label month_label;
        private TextBox carrier_input;
        private Label carrer_error;
        private Label carrier_label;
        private TextBox power_input;
        private Label power_error;
        private Label power_label;
    }
}
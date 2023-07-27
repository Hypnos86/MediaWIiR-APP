namespace MediaWIiR_APP
{
    partial class FormEnergyEstimation
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
            save_to_pdf_click = new Button();
            button1 = new Button();
            title = new Label();
            tariff_label = new Label();
            kwh_label = new Label();
            power_label = new Label();
            label5 = new Label();
            capacirtFee_input = new Label();
            networkVariableFee_label = new Label();
            transitionFee_label = new Label();
            qualityFee_label = new Label();
            renewableEnergySourcesFee_label = new Label();
            fixedNetworkFee_label = new Label();
            cogenerationFee_label = new Label();
            subscriptionFee_label = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Enabled = false;
            save_to_pdf_click.Location = new Point(12, 424);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(150, 25);
            save_to_pdf_click.TabIndex = 16;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // button1
            // 
            button1.Location = new Point(622, 424);
            button1.Name = "button1";
            button1.Size = new Size(150, 25);
            button1.TabIndex = 17;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(273, 9);
            title.Name = "title";
            title.Size = new Size(248, 28);
            title.TabIndex = 18;
            title.Text = "Analiza energii elektrycznej";
            // 
            // tariff_label
            // 
            tariff_label.AutoSize = true;
            tariff_label.Location = new Point(200, 20);
            tariff_label.Name = "tariff_label";
            tariff_label.Size = new Size(44, 15);
            tariff_label.TabIndex = 19;
            tariff_label.Text = "Taryfa: ";
            // 
            // kwh_label
            // 
            kwh_label.AutoSize = true;
            kwh_label.Location = new Point(87, 71);
            kwh_label.Name = "kwh_label";
            kwh_label.Size = new Size(157, 15);
            kwh_label.TabIndex = 20;
            kwh_label.Text = "Szacowane kWh na miesiąć: ";
            // 
            // power_label
            // 
            power_label.AutoSize = true;
            power_label.Location = new Point(10, 101);
            power_label.Name = "power_label";
            power_label.Size = new Size(234, 15);
            power_label.TabIndex = 21;
            power_label.Text = "Szacowane zapotrzebowanie na moc - kW: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 41);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 22;
            label5.Text = "Liczba miesięcy: ";
            // 
            // capacirtFee_input
            // 
            capacirtFee_input.AutoSize = true;
            capacirtFee_input.Location = new Point(458, 71);
            capacirtFee_input.Name = "capacirtFee_input";
            capacirtFee_input.Size = new Size(95, 15);
            capacirtFee_input.TabIndex = 23;
            capacirtFee_input.Text = "opłata mocowa: ";
            // 
            // networkVariableFee_label
            // 
            networkVariableFee_label.AutoSize = true;
            networkVariableFee_label.Location = new Point(411, 101);
            networkVariableFee_label.Name = "networkVariableFee_label";
            networkVariableFee_label.Size = new Size(142, 15);
            networkVariableFee_label.TabIndex = 24;
            networkVariableFee_label.Text = "opłata zmienna sieciowa: ";
            // 
            // transitionFee_label
            // 
            transitionFee_label.AutoSize = true;
            transitionFee_label.Location = new Point(443, 41);
            transitionFee_label.Name = "transitionFee_label";
            transitionFee_label.Size = new Size(110, 15);
            transitionFee_label.TabIndex = 25;
            transitionFee_label.Text = "opłata przejściowa: ";
            // 
            // qualityFee_label
            // 
            qualityFee_label.AutoSize = true;
            qualityFee_label.Location = new Point(446, 126);
            qualityFee_label.Name = "qualityFee_label";
            qualityFee_label.Size = new Size(107, 15);
            qualityFee_label.TabIndex = 26;
            qualityFee_label.Text = "opłata jakościowa: ";
            // 
            // renewableEnergySourcesFee_label
            // 
            renewableEnergySourcesFee_label.AutoSize = true;
            renewableEnergySourcesFee_label.Location = new Point(482, 154);
            renewableEnergySourcesFee_label.Name = "renewableEnergySourcesFee_label";
            renewableEnergySourcesFee_label.Size = new Size(71, 15);
            renewableEnergySourcesFee_label.TabIndex = 27;
            renewableEnergySourcesFee_label.Text = "opłata OZE: ";
            // 
            // fixedNetworkFee_label
            // 
            fixedNetworkFee_label.AutoSize = true;
            fixedNetworkFee_label.Location = new Point(432, 19);
            fixedNetworkFee_label.Name = "fixedNetworkFee_label";
            fixedNetworkFee_label.Size = new Size(121, 15);
            fixedNetworkFee_label.TabIndex = 28;
            fixedNetworkFee_label.Text = "opłata stała sieciowa: ";
            // 
            // cogenerationFee_label
            // 
            cogenerationFee_label.AutoSize = true;
            cogenerationFee_label.Location = new Point(427, 169);
            cogenerationFee_label.Name = "cogenerationFee_label";
            cogenerationFee_label.Size = new Size(126, 15);
            cogenerationFee_label.TabIndex = 29;
            cogenerationFee_label.Text = "opłata kogeneracyjna: ";
            // 
            // subscriptionFee_label
            // 
            subscriptionFee_label.AutoSize = true;
            subscriptionFee_label.Location = new Point(421, 184);
            subscriptionFee_label.Name = "subscriptionFee_label";
            subscriptionFee_label.Size = new Size(132, 15);
            subscriptionFee_label.TabIndex = 30;
            subscriptionFee_label.Text = "opłata abonamentowa: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tariff_label);
            groupBox1.Controls.Add(subscriptionFee_label);
            groupBox1.Controls.Add(cogenerationFee_label);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(fixedNetworkFee_label);
            groupBox1.Controls.Add(kwh_label);
            groupBox1.Controls.Add(renewableEnergySourcesFee_label);
            groupBox1.Controls.Add(power_label);
            groupBox1.Controls.Add(qualityFee_label);
            groupBox1.Controls.Add(capacirtFee_input);
            groupBox1.Controls.Add(transitionFee_label);
            groupBox1.Controls.Add(networkVariableFee_label);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 227);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane wejściowe";
            // 
            // FormEnergyEstimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox1);
            Controls.Add(title);
            Controls.Add(button1);
            Controls.Add(save_to_pdf_click);
            Name = "FormEnergyEstimation";
            Text = "Analiza szacowania kosztów";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_to_pdf_click;
        private Button button1;
        private Label title;
        private Label tariff_label;
        private Label kwh_label;
        private Label power_label;
        private Label label5;
        private Label capacirtFee_input;
        private Label networkVariableFee_label;
        private Label transitionFee_label;
        private Label qualityFee_label;
        private Label renewableEnergySourcesFee_label;
        private Label fixedNetworkFee_label;
        private Label cogenerationFee_label;
        private Label subscriptionFee_label;
        private GroupBox groupBox1;
    }
}
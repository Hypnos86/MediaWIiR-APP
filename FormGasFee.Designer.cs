namespace MediaWIiR_APP
{
    partial class FormGasFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGasFee));
            tariffGroupBox = new GroupBox();
            vatError = new Label();
            vatLabel = new Label();
            vatComboBox = new ComboBox();
            fixedDistributionFeeError = new Label();
            variableDistributionFeeError = new Label();
            subscribeFeeError = new Label();
            gasError = new Label();
            fixedDistributionFeeLabel = new Label();
            variableDistributionFeeLabel = new Label();
            subscribeFeeLabel = new Label();
            gasFeeLabel = new Label();
            fixedDistributionFeeInput = new TextBox();
            variableDistributionFeeInput = new TextBox();
            subscribeFeeInput = new TextBox();
            gasFeeInput = new TextBox();
            add_button = new Button();
            cancel_button = new Button();
            tariffGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tariffGroupBox
            // 
            tariffGroupBox.Controls.Add(vatError);
            tariffGroupBox.Controls.Add(vatLabel);
            tariffGroupBox.Controls.Add(vatComboBox);
            tariffGroupBox.Controls.Add(fixedDistributionFeeError);
            tariffGroupBox.Controls.Add(variableDistributionFeeError);
            tariffGroupBox.Controls.Add(subscribeFeeError);
            tariffGroupBox.Controls.Add(gasError);
            tariffGroupBox.Controls.Add(fixedDistributionFeeLabel);
            tariffGroupBox.Controls.Add(variableDistributionFeeLabel);
            tariffGroupBox.Controls.Add(subscribeFeeLabel);
            tariffGroupBox.Controls.Add(gasFeeLabel);
            tariffGroupBox.Controls.Add(fixedDistributionFeeInput);
            tariffGroupBox.Controls.Add(variableDistributionFeeInput);
            tariffGroupBox.Controls.Add(subscribeFeeInput);
            tariffGroupBox.Controls.Add(gasFeeInput);
            tariffGroupBox.Location = new Point(12, 12);
            tariffGroupBox.Name = "tariffGroupBox";
            tariffGroupBox.Size = new Size(430, 180);
            tariffGroupBox.TabIndex = 0;
            tariffGroupBox.TabStop = false;
            tariffGroupBox.Text = "Dane taryfy";
            // 
            // vatError
            // 
            vatError.AutoSize = true;
            vatError.Location = new Point(316, 141);
            vatError.Name = "vatError";
            vatError.Size = new Size(57, 15);
            vatError.TabIndex = 15;
            vatError.Text = "text_error";
            vatError.Visible = false;
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new Point(178, 141);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new Size(26, 15);
            vatLabel.TabIndex = 13;
            vatLabel.Text = "Vat:";
            // 
            // vatComboBox
            // 
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Items.AddRange(new object[] { "0", "5", "8", "23" });
            vatComboBox.Location = new Point(207, 138);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(100, 23);
            vatComboBox.TabIndex = 14;
            // 
            // fixedDistributionFeeError
            // 
            fixedDistributionFeeError.AutoSize = true;
            fixedDistributionFeeError.Location = new Point(316, 83);
            fixedDistributionFeeError.Name = "fixedDistributionFeeError";
            fixedDistributionFeeError.Size = new Size(57, 15);
            fixedDistributionFeeError.TabIndex = 9;
            fixedDistributionFeeError.Text = "text_error";
            fixedDistributionFeeError.Visible = false;
            // 
            // variableDistributionFeeError
            // 
            variableDistributionFeeError.AutoSize = true;
            variableDistributionFeeError.Location = new Point(316, 112);
            variableDistributionFeeError.Name = "variableDistributionFeeError";
            variableDistributionFeeError.Size = new Size(57, 15);
            variableDistributionFeeError.TabIndex = 12;
            variableDistributionFeeError.Text = "text_error";
            variableDistributionFeeError.Visible = false;
            // 
            // subscribeFeeError
            // 
            subscribeFeeError.AutoSize = true;
            subscribeFeeError.Location = new Point(316, 54);
            subscribeFeeError.Name = "subscribeFeeError";
            subscribeFeeError.Size = new Size(57, 15);
            subscribeFeeError.TabIndex = 6;
            subscribeFeeError.Text = "text_error";
            subscribeFeeError.Visible = false;
            // 
            // gasError
            // 
            gasError.AutoSize = true;
            gasError.Location = new Point(316, 25);
            gasError.Name = "gasError";
            gasError.Size = new Size(57, 15);
            gasError.TabIndex = 3;
            gasError.Text = "text_error";
            gasError.Visible = false;
            // 
            // fixedDistributionFeeLabel
            // 
            fixedDistributionFeeLabel.AutoSize = true;
            fixedDistributionFeeLabel.Location = new Point(86, 83);
            fixedDistributionFeeLabel.Name = "fixedDistributionFeeLabel";
            fixedDistributionFeeLabel.Size = new Size(118, 15);
            fixedDistributionFeeLabel.TabIndex = 7;
            fixedDistributionFeeLabel.Text = "Dystrybucja stała [zł]:";
            // 
            // variableDistributionFeeLabel
            // 
            variableDistributionFeeLabel.AutoSize = true;
            variableDistributionFeeLabel.Location = new Point(65, 112);
            variableDistributionFeeLabel.Name = "variableDistributionFeeLabel";
            variableDistributionFeeLabel.Size = new Size(139, 15);
            variableDistributionFeeLabel.TabIndex = 10;
            variableDistributionFeeLabel.Text = "Dystrybucja zmienna [zł]:";
            // 
            // subscribeFeeLabel
            // 
            subscribeFeeLabel.AutoSize = true;
            subscribeFeeLabel.Location = new Point(25, 54);
            subscribeFeeLabel.Name = "subscribeFeeLabel";
            subscribeFeeLabel.Size = new Size(179, 15);
            subscribeFeeLabel.TabIndex = 4;
            subscribeFeeLabel.Text = "Opłata abonamentowa - gaz [zł]:";
            // 
            // gasFeeLabel
            // 
            gasFeeLabel.AutoSize = true;
            gasFeeLabel.Location = new Point(45, 25);
            gasFeeLabel.Name = "gasFeeLabel";
            gasFeeLabel.Size = new Size(159, 15);
            gasFeeLabel.TabIndex = 1;
            gasFeeLabel.Text = "Opłata za paliwo gazowe [zł]:";
            // 
            // fixedDistributionFeeInput
            // 
            fixedDistributionFeeInput.Location = new Point(207, 80);
            fixedDistributionFeeInput.Name = "fixedDistributionFeeInput";
            fixedDistributionFeeInput.Size = new Size(100, 23);
            fixedDistributionFeeInput.TabIndex = 8;
            // 
            // variableDistributionFeeInput
            // 
            variableDistributionFeeInput.Location = new Point(207, 109);
            variableDistributionFeeInput.Name = "variableDistributionFeeInput";
            variableDistributionFeeInput.Size = new Size(100, 23);
            variableDistributionFeeInput.TabIndex = 11;
            // 
            // subscribeFeeInput
            // 
            subscribeFeeInput.Location = new Point(207, 51);
            subscribeFeeInput.Name = "subscribeFeeInput";
            subscribeFeeInput.Size = new Size(100, 23);
            subscribeFeeInput.TabIndex = 5;
            // 
            // gasFeeInput
            // 
            gasFeeInput.Location = new Point(207, 22);
            gasFeeInput.Name = "gasFeeInput";
            gasFeeInput.Size = new Size(100, 23);
            gasFeeInput.TabIndex = 2;
            // 
            // add_button
            // 
            add_button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_button.Location = new Point(12, 204);
            add_button.Name = "add_button";
            add_button.Size = new Size(150, 25);
            add_button.TabIndex = 16;
            add_button.Text = "Dodaj dane";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(292, 204);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 17;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // FormGasFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 241);
            Controls.Add(add_button);
            Controls.Add(cancel_button);
            Controls.Add(tariffGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGasFee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gaz - Taryfa";
            tariffGroupBox.ResumeLayout(false);
            tariffGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox tariffGroupBox;
        private Button add_button;
        private Button cancel_button;
        private Label vatError;
        private Label vatLabel;
        private ComboBox vatComboBox;
        private Label fixedDistributionFeeError;
        private Label variableDistributionFeeError;
        private Label subscribeFeeError;
        private Label gasError;
        private Label fixedDistributionFeeLabel;
        private Label variableDistributionFeeLabel;
        private Label subscribeFeeLabel;
        private Label gasFeeLabel;
        private TextBox fixedDistributionFeeInput;
        private TextBox variableDistributionFeeInput;
        private TextBox subscribeFeeInput;
        private TextBox gasFeeInput;
    }
}
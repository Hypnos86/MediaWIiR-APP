namespace MediaWIiR_APP
{
    partial class FormWaterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaterData));
            cancel_button = new Button();
            add_button = new Button();
            water_input = new TextBox();
            month_input = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            water_label = new Label();
            month_error = new Label();
            water_error = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(262, 124);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(130, 25);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // add_button
            // 
            add_button.Location = new Point(12, 124);
            add_button.Name = "add_button";
            add_button.Size = new Size(130, 25);
            add_button.TabIndex = 1;
            add_button.Text = "Dodaj";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // water_input
            // 
            water_input.Location = new Point(175, 21);
            water_input.Name = "water_input";
            water_input.Size = new Size(100, 23);
            water_input.TabIndex = 2;
            // 
            // month_input
            // 
            month_input.Location = new Point(175, 59);
            month_input.Name = "month_input";
            month_input.Size = new Size(100, 23);
            month_input.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(water_label);
            groupBox1.Controls.Add(month_error);
            groupBox1.Controls.Add(water_error);
            groupBox1.Controls.Add(water_input);
            groupBox1.Controls.Add(month_input);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 106);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane do szacowania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 62);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 7;
            label4.Text = "Liczba miesięcy: ";
            // 
            // water_label
            // 
            water_label.AutoSize = true;
            water_label.Location = new Point(6, 24);
            water_label.Name = "water_label";
            water_label.Size = new Size(163, 15);
            water_label.TabIndex = 6;
            water_label.Text = "Szacowanie miesięczne - m3: ";
            // 
            // month_error
            // 
            month_error.AutoSize = true;
            month_error.Location = new Point(281, 62);
            month_error.Name = "month_error";
            month_error.Size = new Size(57, 15);
            month_error.TabIndex = 5;
            month_error.Text = "text_error";
            month_error.Visible = false;
            // 
            // water_error
            // 
            water_error.AutoSize = true;
            water_error.Location = new Point(281, 24);
            water_error.Name = "water_error";
            water_error.Size = new Size(57, 15);
            water_error.TabIndex = 4;
            water_error.Text = "text_error";
            water_error.Visible = false;
            // 
            // FormWaterData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 161);
            Controls.Add(groupBox1);
            Controls.Add(add_button);
            Controls.Add(cancel_button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWaterData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dane do szacowania - Woda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button add_button;
        private TextBox water_input;
        private TextBox month_input;
        private GroupBox groupBox1;
        private Label label4;
        private Label water_label;
        private Label month_error;
        private Label water_error;
    }
}
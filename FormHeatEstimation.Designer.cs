namespace MediaWIiR_APP
{
    partial class FormHeatEstimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHeatEstimation));
            dataInputGroupBox = new GroupBox();
            title = new Label();
            cancel_button = new Button();
            save_to_pdf_click = new Button();
            unit_text = new Label();
            dataInputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dataInputGroupBox
            // 
            dataInputGroupBox.Controls.Add(unit_text);
            dataInputGroupBox.Location = new Point(12, 40);
            dataInputGroupBox.Name = "dataInputGroupBox";
            dataInputGroupBox.Size = new Size(764, 246);
            dataInputGroupBox.TabIndex = 0;
            dataInputGroupBox.TabStop = false;
            dataInputGroupBox.Text = "Dane wejściowe";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(254, 9);
            title.Name = "title";
            title.Size = new Size(299, 28);
            title.TabIndex = 19;
            title.Text = "Analiza kosztów energii cieplenej";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(626, 413);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(150, 25);
            cancel_button.TabIndex = 21;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // save_to_pdf_click
            // 
            save_to_pdf_click.Location = new Point(12, 413);
            save_to_pdf_click.Name = "save_to_pdf_click";
            save_to_pdf_click.Size = new Size(150, 25);
            save_to_pdf_click.TabIndex = 20;
            save_to_pdf_click.Text = "Zapisz do PDF";
            save_to_pdf_click.UseVisualStyleBackColor = true;
            save_to_pdf_click.Click += save_to_pdf_click_Click;
            // 
            // unit_text
            // 
            unit_text.AutoSize = true;
            unit_text.Location = new Point(29, 29);
            unit_text.Name = "unit_text";
            unit_text.Size = new Size(28, 15);
            unit_text.TabIndex = 0;
            unit_text.Text = "unit";
            // 
            // FormHeatEstimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 450);
            Controls.Add(cancel_button);
            Controls.Add(save_to_pdf_click);
            Controls.Add(title);
            Controls.Add(dataInputGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHeatEstimation";
            Text = "Analiza szacowania kosztów";
            dataInputGroupBox.ResumeLayout(false);
            dataInputGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox dataInputGroupBox;
        private Label title;
        private Button cancel_button;
        private Button save_to_pdf_click;
        private Label unit_text;
    }
}
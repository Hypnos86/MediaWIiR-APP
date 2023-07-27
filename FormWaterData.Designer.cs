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
            cancel_button = new Button();
            accept_button = new Button();
            water_data_froupbox = new GroupBox();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(198, 203);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(75, 23);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(21, 203);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(75, 23);
            accept_button.TabIndex = 1;
            accept_button.Text = "Dodaj";
            accept_button.UseVisualStyleBackColor = true;
            // 
            // water_data_froupbox
            // 
            water_data_froupbox.Location = new Point(12, 12);
            water_data_froupbox.Name = "water_data_froupbox";
            water_data_froupbox.Size = new Size(200, 100);
            water_data_froupbox.TabIndex = 2;
            water_data_froupbox.TabStop = false;
            water_data_froupbox.Text = "Dane do szacowania";
            // 
            // FormWaterData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(water_data_froupbox);
            Controls.Add(accept_button);
            Controls.Add(cancel_button);
            Name = "FormWaterData";
            Text = "Dane do szacowania - Woda";
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button accept_button;
        private GroupBox water_data_froupbox;
    }
}
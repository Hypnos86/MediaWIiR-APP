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
            save_to_pdf = new Button();
            estimate = new Button();
            SuspendLayout();
            // 
            // save_to_pdf
            // 
            save_to_pdf.Location = new Point(633, 378);
            save_to_pdf.Name = "save_to_pdf";
            save_to_pdf.Size = new Size(119, 27);
            save_to_pdf.TabIndex = 0;
            save_to_pdf.Text = "Zapisz do PDF";
            save_to_pdf.UseVisualStyleBackColor = true;
            // 
            // estimate
            // 
            estimate.Location = new Point(633, 333);
            estimate.Name = "estimate";
            estimate.Size = new Size(119, 27);
            estimate.TabIndex = 1;
            estimate.Text = "Oszacuj koszty";
            estimate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(estimate);
            Controls.Add(save_to_pdf);
            Name = "MainForm";
            Text = "WIiR - Szacowanie kosztów mediów";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button save_to_pdf;
        private Button estimate;
    }
}
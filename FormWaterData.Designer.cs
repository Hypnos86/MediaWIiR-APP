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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            water_data_froupbox.SuspendLayout();
            SuspendLayout();
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(256, 189);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(136, 25);
            cancel_button.TabIndex = 0;
            cancel_button.Text = "Anuluj";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += cancel_button_Click;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(12, 189);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(132, 25);
            accept_button.TabIndex = 1;
            accept_button.Text = "Dodaj";
            accept_button.UseVisualStyleBackColor = true;
            // 
            // water_data_froupbox
            // 
            water_data_froupbox.Controls.Add(label8);
            water_data_froupbox.Controls.Add(label7);
            water_data_froupbox.Controls.Add(label6);
            water_data_froupbox.Controls.Add(label5);
            water_data_froupbox.Controls.Add(label4);
            water_data_froupbox.Controls.Add(label3);
            water_data_froupbox.Controls.Add(label2);
            water_data_froupbox.Controls.Add(label1);
            water_data_froupbox.Controls.Add(textBox4);
            water_data_froupbox.Controls.Add(textBox3);
            water_data_froupbox.Controls.Add(textBox2);
            water_data_froupbox.Controls.Add(textBox1);
            water_data_froupbox.Location = new Point(12, 12);
            water_data_froupbox.Name = "water_data_froupbox";
            water_data_froupbox.Size = new Size(380, 160);
            water_data_froupbox.TabIndex = 2;
            water_data_froupbox.TabStop = false;
            water_data_froupbox.Text = "Dane do szacowania";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 125);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 60);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 128);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 94);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 25);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "text_error";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 60);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 9;
            label6.Text = "text_error";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(244, 94);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 10;
            label7.Text = "text_error";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 128);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 11;
            label8.Text = "text_error";
            // 
            // FormWaterData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 226);
            Controls.Add(water_data_froupbox);
            Controls.Add(cancel_button);
            Controls.Add(accept_button);
            Name = "FormWaterData";
            Text = "Dane do szacowania - Woda";
            Load += FormWaterData_Load;
            water_data_froupbox.ResumeLayout(false);
            water_data_froupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancel_button;
        private Button accept_button;
        private GroupBox water_data_froupbox;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
﻿namespace MediaWIiR_APP
{
    partial class FormGasData
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
            estimationGroupBox = new GroupBox();
            SuspendLayout();
            // 
            // estimationGroupBox
            // 
            estimationGroupBox.Location = new Point(30, 22);
            estimationGroupBox.Name = "estimationGroupBox";
            estimationGroupBox.Size = new Size(200, 100);
            estimationGroupBox.TabIndex = 0;
            estimationGroupBox.TabStop = false;
            estimationGroupBox.Text = "groupBox1";
            // 
            // FormGasData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(estimationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormGasData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GasDataForm";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox estimationGroupBox;
    }
}
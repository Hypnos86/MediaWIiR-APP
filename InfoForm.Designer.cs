namespace MediaWIiR_APP
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            version = new Label();
            information = new Label();
            author = new Label();
            unit_label = new Label();
            SuspendLayout();
            // 
            // version
            // 
            resources.ApplyResources(version, "version");
            version.Name = "version";
            // 
            // information
            // 
            resources.ApplyResources(information, "information");
            information.Name = "information";
            // 
            // author
            // 
            resources.ApplyResources(author, "author");
            author.Name = "author";
            // 
            // unit_label
            // 
            resources.ApplyResources(unit_label, "unit_label");
            unit_label.Name = "unit_label";
            // 
            // InfoForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(unit_label);
            Controls.Add(author);
            Controls.Add(information);
            Controls.Add(version);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label version;
        private Label information;
        private Label author;
        private Label unit_label;
    }
}
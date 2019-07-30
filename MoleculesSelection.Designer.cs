namespace AutomatedLIBS {
    partial class MoleculesSelection {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lstMolecules = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMolecules
            // 
            this.lstMolecules.FormattingEnabled = true;
            this.lstMolecules.Items.AddRange(new object[] {
            "CN (0,0): 388,29 nm",
            "CN (1,1): 387,08 nm",
            "CN (2,2): 386,14 nm",
            "CN (3,3): 385,44 nm",
            "CN (4,4): 385,03 nm",
            "C2Swan (0,0): 516,42 nm",
            "C2Swan (1,1): 512,80 nm"});
            this.lstMolecules.Location = new System.Drawing.Point(12, 9);
            this.lstMolecules.Name = "lstMolecules";
            this.lstMolecules.Size = new System.Drawing.Size(206, 244);
            this.lstMolecules.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MoleculesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 288);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstMolecules);
            this.Name = "MoleculesSelection";
            this.Text = "Molecules Selection";
            this.Load += new System.EventHandler(this.MoleculesSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstMolecules;
        private System.Windows.Forms.Button btnOK;
    }
}
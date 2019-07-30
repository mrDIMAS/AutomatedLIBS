namespace AutomatedLIBS {
    partial class LineBaseVisualizer {
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
            this.dgwIons = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIons
            // 
            this.dgwIons.AllowUserToDeleteRows = false;
            this.dgwIons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwIons.Location = new System.Drawing.Point(12, 12);
            this.dgwIons.Name = "dgwIons";
            this.dgwIons.ReadOnly = true;
            this.dgwIons.Size = new System.Drawing.Size(560, 386);
            this.dgwIons.TabIndex = 1;
            this.dgwIons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIons_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(C) NIST Atomic Spectra Database. All rights goes to Authors. Compiled by Stepano" +
    "v Dmitriy";
            // 
            // LineBaseVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwIons);
            this.Name = "LineBaseVisualizer";
            this.Text = "Line Base Visualizer";
            this.Load += new System.EventHandler(this.LineBaseVisualizer_Load);
            this.Resize += new System.EventHandler(this.LineBaseVisualizer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIons;
        private System.Windows.Forms.Label label1;
    }
}
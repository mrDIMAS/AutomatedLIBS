namespace AutomatedLIBS {
    partial class ElementVisualizer {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrElements = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrElements)).BeginInit();
            this.SuspendLayout();
            // 
            // chrElements
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chrElements.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrElements.Legends.Add(legend1);
            this.chrElements.Location = new System.Drawing.Point(0, 0);
            this.chrElements.Name = "chrElements";
            this.chrElements.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrElements.Series.Add(series1);
            this.chrElements.Size = new System.Drawing.Size(824, 446);
            this.chrElements.TabIndex = 0;
            this.chrElements.Text = "chart1";
            this.chrElements.Click += new System.EventHandler(this.chrElements_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Data To File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ElementVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 483);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chrElements);
            this.Name = "ElementVisualizer";
            this.Text = "ElementVisualizer";
            this.Load += new System.EventHandler(this.ElementVisualizer_Load);
            this.Resize += new System.EventHandler(this.ElementVisualizer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chrElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrElements;
        private System.Windows.Forms.Button btnSave;
    }
}
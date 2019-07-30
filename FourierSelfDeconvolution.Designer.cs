namespace AutomatedLIBS {
    partial class FourierSelfDeconvolution {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrMainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnApplyAndClose = new System.Windows.Forms.Button();
            this.nudFWHM = new System.Windows.Forms.NumericUpDown();
            this.nudNarrowingFactor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSpectrumNumber = new System.Windows.Forms.NumericUpDown();
            this.chrFourierTransform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrMainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFWHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNarrowingFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrFourierTransform)).BeginInit();
            this.SuspendLayout();
            // 
            // chrMainChart
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 3F;
            this.chrMainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrMainChart.Legends.Add(legend1);
            this.chrMainChart.Location = new System.Drawing.Point(12, 12);
            this.chrMainChart.Name = "chrMainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrMainChart.Series.Add(series1);
            this.chrMainChart.Size = new System.Drawing.Size(464, 436);
            this.chrMainChart.TabIndex = 0;
            this.chrMainChart.Text = "chart1";
            // 
            // btnApplyAndClose
            // 
            this.btnApplyAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyAndClose.Location = new System.Drawing.Point(832, 454);
            this.btnApplyAndClose.Name = "btnApplyAndClose";
            this.btnApplyAndClose.Size = new System.Drawing.Size(92, 23);
            this.btnApplyAndClose.TabIndex = 1;
            this.btnApplyAndClose.Text = "Apply and Close";
            this.btnApplyAndClose.UseVisualStyleBackColor = true;
            this.btnApplyAndClose.Click += new System.EventHandler(this.btnApplyAndClose_Click);
            // 
            // nudFWHM
            // 
            this.nudFWHM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudFWHM.DecimalPlaces = 2;
            this.nudFWHM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudFWHM.Location = new System.Drawing.Point(503, 457);
            this.nudFWHM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFWHM.Name = "nudFWHM";
            this.nudFWHM.Size = new System.Drawing.Size(72, 20);
            this.nudFWHM.TabIndex = 2;
            this.nudFWHM.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            // 
            // nudNarrowingFactor
            // 
            this.nudNarrowingFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudNarrowingFactor.DecimalPlaces = 2;
            this.nudNarrowingFactor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudNarrowingFactor.Location = new System.Drawing.Point(274, 457);
            this.nudNarrowingFactor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNarrowingFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNarrowingFactor.Name = "nudNarrowingFactor";
            this.nudNarrowingFactor.Size = new System.Drawing.Size(53, 20);
            this.nudNarrowingFactor.TabIndex = 3;
            this.nudNarrowingFactor.Value = new decimal(new int[] {
            13,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Narrowing Factor";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Band Full Width At Half Maximum";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(581, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "nm";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(751, 454);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(79, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Recalculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spectrum";
            // 
            // nudSpectrumNumber
            // 
            this.nudSpectrumNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSpectrumNumber.Location = new System.Drawing.Point(70, 457);
            this.nudSpectrumNumber.Name = "nudSpectrumNumber";
            this.nudSpectrumNumber.Size = new System.Drawing.Size(42, 20);
            this.nudSpectrumNumber.TabIndex = 9;
            // 
            // chrFourierTransform
            // 
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 94F;
            chartArea2.Position.Width = 100F;
            chartArea2.Position.Y = 3F;
            this.chrFourierTransform.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrFourierTransform.Legends.Add(legend2);
            this.chrFourierTransform.Location = new System.Drawing.Point(482, 12);
            this.chrFourierTransform.Name = "chrFourierTransform";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrFourierTransform.Series.Add(series2);
            this.chrFourierTransform.Size = new System.Drawing.Size(442, 436);
            this.chrFourierTransform.TabIndex = 10;
            this.chrFourierTransform.Text = "chart1";
            // 
            // FourierSelfDeconvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 489);
            this.Controls.Add(this.chrFourierTransform);
            this.Controls.Add(this.nudSpectrumNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNarrowingFactor);
            this.Controls.Add(this.nudFWHM);
            this.Controls.Add(this.btnApplyAndClose);
            this.Controls.Add(this.chrMainChart);
            this.Name = "FourierSelfDeconvolution";
            this.Text = "Fourier Self-Deconvolution";
            this.Resize += new System.EventHandler(this.FourierSelfDeconvolution_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chrMainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFWHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNarrowingFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrFourierTransform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrMainChart;
        private System.Windows.Forms.Button btnApplyAndClose;
        private System.Windows.Forms.NumericUpDown nudFWHM;
        private System.Windows.Forms.NumericUpDown nudNarrowingFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSpectrumNumber;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrFourierTransform;
    }
}
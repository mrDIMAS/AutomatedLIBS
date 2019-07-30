namespace AutomatedLIBS {
    partial class SplineFitting {
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
            this.chrMainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnApply = new System.Windows.Forms.Button();
            this.nudSubdivisionsCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudShowSpectrumNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpectrumCount = new System.Windows.Forms.Label();
            this.btnSaveSplines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrMainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubdivisionsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowSpectrumNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // chrMainChart
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chrMainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrMainChart.Legends.Add(legend1);
            this.chrMainChart.Location = new System.Drawing.Point(12, 12);
            this.chrMainChart.Name = "chrMainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrMainChart.Series.Add(series1);
            this.chrMainChart.Size = new System.Drawing.Size(686, 437);
            this.chrMainChart.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(591, 462);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(107, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply and Close";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // nudSubdivisionsCount
            // 
            this.nudSubdivisionsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudSubdivisionsCount.Location = new System.Drawing.Point(303, 465);
            this.nudSubdivisionsCount.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudSubdivisionsCount.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSubdivisionsCount.Name = "nudSubdivisionsCount";
            this.nudSubdivisionsCount.Size = new System.Drawing.Size(39, 20);
            this.nudSubdivisionsCount.TabIndex = 2;
            this.nudSubdivisionsCount.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudSubdivisionsCount.ValueChanged += new System.EventHandler(this.nudSubdivisionsCount_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subdivisions Count";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Show Spectrum";
            // 
            // nudShowSpectrumNumber
            // 
            this.nudShowSpectrumNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudShowSpectrumNumber.Location = new System.Drawing.Point(100, 465);
            this.nudShowSpectrumNumber.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShowSpectrumNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShowSpectrumNumber.Name = "nudShowSpectrumNumber";
            this.nudShowSpectrumNumber.Size = new System.Drawing.Size(39, 20);
            this.nudShowSpectrumNumber.TabIndex = 5;
            this.nudShowSpectrumNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShowSpectrumNumber.ValueChanged += new System.EventHandler(this.nudShowSpectrumNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "of";
            // 
            // lblSpectrumCount
            // 
            this.lblSpectrumCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpectrumCount.AutoSize = true;
            this.lblSpectrumCount.Location = new System.Drawing.Point(167, 467);
            this.lblSpectrumCount.Name = "lblSpectrumCount";
            this.lblSpectrumCount.Size = new System.Drawing.Size(13, 13);
            this.lblSpectrumCount.TabIndex = 7;
            this.lblSpectrumCount.Text = "1";
            // 
            // btnSaveSplines
            // 
            this.btnSaveSplines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSplines.Location = new System.Drawing.Point(481, 462);
            this.btnSaveSplines.Name = "btnSaveSplines";
            this.btnSaveSplines.Size = new System.Drawing.Size(104, 23);
            this.btnSaveSplines.TabIndex = 8;
            this.btnSaveSplines.Text = "Save Splines";
            this.btnSaveSplines.UseVisualStyleBackColor = true;
            this.btnSaveSplines.Click += new System.EventHandler(this.btnSaveSplines_Click);
            // 
            // SplineFitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 497);
            this.Controls.Add(this.btnSaveSplines);
            this.Controls.Add(this.lblSpectrumCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudShowSpectrumNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSubdivisionsCount);
            this.Controls.Add(this.chrMainChart);
            this.Name = "SplineFitting";
            this.Text = "SplineFitting";
            this.Load += new System.EventHandler(this.SplineFitting_Load);
            this.Resize += new System.EventHandler(this.SplineFitting_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chrMainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubdivisionsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowSpectrumNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrMainChart;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.NumericUpDown nudSubdivisionsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudShowSpectrumNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpectrumCount;
        private System.Windows.Forms.Button btnSaveSplines;
    }
}
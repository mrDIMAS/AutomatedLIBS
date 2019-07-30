namespace AutomatedLIBS
{
    partial class Plasma
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultsText = new System.Windows.Forms.TextBox();
            this.TemperatureGroup = new System.Windows.Forms.GroupBox();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.ClearResults = new System.Windows.Forms.Button();
            this.SaveToFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.chrTemperatureDistr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chrSahaBoltzmanPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clbLines = new System.Windows.Forms.CheckedListBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.TemperatureGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrTemperatureDistr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSahaBoltzmanPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultsText
            // 
            this.ResultsText.Location = new System.Drawing.Point(6, 19);
            this.ResultsText.Multiline = true;
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.ReadOnly = true;
            this.ResultsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultsText.Size = new System.Drawing.Size(216, 76);
            this.ResultsText.TabIndex = 5;
            // 
            // TemperatureGroup
            // 
            this.TemperatureGroup.Controls.Add(this.SaveToFile);
            this.TemperatureGroup.Controls.Add(this.ClearResults);
            this.TemperatureGroup.Controls.Add(this.ResultsText);
            this.TemperatureGroup.Controls.Add(this.button1);
            this.TemperatureGroup.Location = new System.Drawing.Point(745, 282);
            this.TemperatureGroup.Name = "TemperatureGroup";
            this.TemperatureGroup.Size = new System.Drawing.Size(228, 133);
            this.TemperatureGroup.TabIndex = 6;
            this.TemperatureGroup.TabStop = false;
            this.TemperatureGroup.Text = "Temperature";
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(71, 104);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(48, 23);
            this.SaveToFile.TabIndex = 8;
            this.SaveToFile.Text = "Save";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // ClearResults
            // 
            this.ClearResults.Location = new System.Drawing.Point(121, 104);
            this.ClearResults.Name = "ClearResults";
            this.ClearResults.Size = new System.Drawing.Size(48, 23);
            this.ClearResults.TabIndex = 7;
            this.ClearResults.Text = "Clear";
            this.ClearResults.UseVisualStyleBackColor = true;
            this.ClearResults.Click += new System.EventHandler(this.ClearResults_Click);
            // 
            // chrTemperatureDistr
            // 
            this.chrTemperatureDistr.BackColor = System.Drawing.Color.Beige;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Title = "Delay, μs";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "Temperature, K";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.BackColor = System.Drawing.Color.Beige;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chrTemperatureDistr.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5.825243F;
            legend1.Position.Width = 25F;
            legend1.Position.X = 75F;
            legend1.Position.Y = 7.5F;
            this.chrTemperatureDistr.Legends.Add(legend1);
            this.chrTemperatureDistr.Location = new System.Drawing.Point(0, 0);
            this.chrTemperatureDistr.Name = "chrTemperatureDistr";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrTemperatureDistr.Series.Add(series1);
            this.chrTemperatureDistr.Size = new System.Drawing.Size(396, 430);
            this.chrTemperatureDistr.TabIndex = 7;
            this.chrTemperatureDistr.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Plasma temperature distribution";
            this.chrTemperatureDistr.Titles.Add(title1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 427);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // chrSahaBoltzmanPlot
            // 
            this.chrSahaBoltzmanPlot.BackColor = System.Drawing.Color.Beige;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Title = "Energy, eV";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.Title = "ln(I/A*g)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.BackColor = System.Drawing.Color.Beige;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chrSahaBoltzmanPlot.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 5.825243F;
            legend2.Position.Width = 25F;
            legend2.Position.X = 75F;
            legend2.Position.Y = 7.5F;
            this.chrSahaBoltzmanPlot.Legends.Add(legend2);
            this.chrSahaBoltzmanPlot.Location = new System.Drawing.Point(388, 0);
            this.chrSahaBoltzmanPlot.Name = "chrSahaBoltzmanPlot";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrSahaBoltzmanPlot.Series.Add(series2);
            this.chrSahaBoltzmanPlot.Size = new System.Drawing.Size(351, 424);
            this.chrSahaBoltzmanPlot.TabIndex = 9;
            this.chrSahaBoltzmanPlot.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Saha-Boltzman Plot";
            this.chrSahaBoltzmanPlot.Titles.Add(title2);
            // 
            // clbLines
            // 
            this.clbLines.FormattingEnabled = true;
            this.clbLines.Location = new System.Drawing.Point(745, 30);
            this.clbLines.Name = "clbLines";
            this.clbLines.Size = new System.Drawing.Size(228, 244);
            this.clbLines.TabIndex = 10;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(744, 7);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(78, 13);
            this.lblLines.TabIndex = 11;
            this.lblLines.Text = "Available Lines";
            // 
            // Plasma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 427);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.clbLines);
            this.Controls.Add(this.chrSahaBoltzmanPlot);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chrTemperatureDistr);
            this.Controls.Add(this.TemperatureGroup);
            this.MinimumSize = new System.Drawing.Size(589, 465);
            this.Name = "Plasma";
            this.Text = "Plasma";
            this.Load += new System.EventHandler(this.Plasma_Load);
            this.ResizeEnd += new System.EventHandler(this.Plasma_Resize);
            this.Resize += new System.EventHandler(this.Plasma_Resize);
            this.TemperatureGroup.ResumeLayout(false);
            this.TemperatureGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrTemperatureDistr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrSahaBoltzmanPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultsText;
        private System.Windows.Forms.GroupBox TemperatureGroup;
        private System.Windows.Forms.Button ClearResults;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.SaveFileDialog SaveToFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrTemperatureDistr;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSahaBoltzmanPlot;
        private System.Windows.Forms.CheckedListBox clbLines;
        private System.Windows.Forms.Label lblLines;
    }
}
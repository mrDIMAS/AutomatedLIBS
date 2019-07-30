namespace AutomatedLIBS
{
    partial class Results
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
            this.MatrixRanges = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMatrixUseSingleLine = new System.Windows.Forms.CheckBox();
            this.ExistingMatrixRanges = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMatrixRangeTo = new System.Windows.Forms.NumericUpDown();
            this.nudMatrixRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.MatrixRemoveRange = new System.Windows.Forms.Button();
            this.MatrixAddRange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMaterialUseSingleLine = new System.Windows.Forms.CheckBox();
            this.ExistingMaterialRanges = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaterialRanges = new System.Windows.Forms.ListBox();
            this.nudMaterialRangeTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.MaterialAddRange = new System.Windows.Forms.Button();
            this.MaterialRemoveRange = new System.Windows.Forms.Button();
            this.nudMaterialRangeFrom = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            this.ClearResults = new System.Windows.Forms.Button();
            this.XMaterialNumber = new System.Windows.Forms.RadioButton();
            this.XDelta = new System.Windows.Forms.RadioButton();
            this.SaveAsTable = new System.Windows.Forms.Button();
            this.SaveAsTableDialog = new System.Windows.Forms.SaveFileDialog();
            this.ErrorsText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SortByAverage = new System.Windows.Forms.Button();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLinearFitting = new System.Windows.Forms.Button();
            this.lblSlope = new System.Windows.Forms.Label();
            this.btnPartialSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkUseIrradiance = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixRangeFrom)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialRangeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialRangeFrom)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatrixRanges
            // 
            this.MatrixRanges.FormattingEnabled = true;
            this.MatrixRanges.Location = new System.Drawing.Point(6, 19);
            this.MatrixRanges.Name = "MatrixRanges";
            this.MatrixRanges.ScrollAlwaysVisible = true;
            this.MatrixRanges.Size = new System.Drawing.Size(160, 56);
            this.MatrixRanges.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkMatrixUseSingleLine);
            this.groupBox1.Controls.Add(this.ExistingMatrixRanges);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudMatrixRangeTo);
            this.groupBox1.Controls.Add(this.nudMatrixRangeFrom);
            this.groupBox1.Controls.Add(this.MatrixRemoveRange);
            this.groupBox1.Controls.Add(this.MatrixAddRange);
            this.groupBox1.Controls.Add(this.MatrixRanges);
            this.groupBox1.Location = new System.Drawing.Point(490, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix Ranges";
            // 
            // chkMatrixUseSingleLine
            // 
            this.chkMatrixUseSingleLine.AutoSize = true;
            this.chkMatrixUseSingleLine.Location = new System.Drawing.Point(9, 168);
            this.chkMatrixUseSingleLine.Name = "chkMatrixUseSingleLine";
            this.chkMatrixUseSingleLine.Size = new System.Drawing.Size(100, 17);
            this.chkMatrixUseSingleLine.TabIndex = 12;
            this.chkMatrixUseSingleLine.Text = "Use Single Line";
            this.chkMatrixUseSingleLine.UseVisualStyleBackColor = true;
            this.chkMatrixUseSingleLine.CheckedChanged += new System.EventHandler(this.chkMatrixUseSingleLine_CheckedChanged);
            // 
            // ExistingMatrixRanges
            // 
            this.ExistingMatrixRanges.FormattingEnabled = true;
            this.ExistingMatrixRanges.Location = new System.Drawing.Point(6, 78);
            this.ExistingMatrixRanges.Name = "ExistingMatrixRanges";
            this.ExistingMatrixRanges.ScrollAlwaysVisible = true;
            this.ExistingMatrixRanges.Size = new System.Drawing.Size(160, 56);
            this.ExistingMatrixRanges.TabIndex = 9;
            this.ExistingMatrixRanges.SelectedIndexChanged += new System.EventHandler(this.ExistingMatrixRanges_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "to";
            // 
            // nudMatrixRangeTo
            // 
            this.nudMatrixRangeTo.DecimalPlaces = 1;
            this.nudMatrixRangeTo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMatrixRangeTo.Location = new System.Drawing.Point(118, 140);
            this.nudMatrixRangeTo.Maximum = new decimal(new int[] {
            1333,
            0,
            0,
            0});
            this.nudMatrixRangeTo.Minimum = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMatrixRangeTo.Name = "nudMatrixRangeTo";
            this.nudMatrixRangeTo.Size = new System.Drawing.Size(49, 20);
            this.nudMatrixRangeTo.TabIndex = 6;
            this.nudMatrixRangeTo.Value = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMatrixRangeTo.ValueChanged += new System.EventHandler(this.nudMatrixRangeTo_ValueChanged);
            // 
            // nudMatrixRangeFrom
            // 
            this.nudMatrixRangeFrom.DecimalPlaces = 1;
            this.nudMatrixRangeFrom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMatrixRangeFrom.Location = new System.Drawing.Point(37, 140);
            this.nudMatrixRangeFrom.Maximum = new decimal(new int[] {
            1333,
            0,
            0,
            0});
            this.nudMatrixRangeFrom.Minimum = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMatrixRangeFrom.Name = "nudMatrixRangeFrom";
            this.nudMatrixRangeFrom.Size = new System.Drawing.Size(49, 20);
            this.nudMatrixRangeFrom.TabIndex = 5;
            this.nudMatrixRangeFrom.Value = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMatrixRangeFrom.ValueChanged += new System.EventHandler(this.nudMatrixRangeFrom_ValueChanged);
            // 
            // MatrixRemoveRange
            // 
            this.MatrixRemoveRange.Location = new System.Drawing.Point(92, 191);
            this.MatrixRemoveRange.Name = "MatrixRemoveRange";
            this.MatrixRemoveRange.Size = new System.Drawing.Size(74, 23);
            this.MatrixRemoveRange.TabIndex = 4;
            this.MatrixRemoveRange.Text = "Remove";
            this.MatrixRemoveRange.UseVisualStyleBackColor = true;
            this.MatrixRemoveRange.Click += new System.EventHandler(this.MatrixRemoveRange_Click);
            // 
            // MatrixAddRange
            // 
            this.MatrixAddRange.Location = new System.Drawing.Point(6, 191);
            this.MatrixAddRange.Name = "MatrixAddRange";
            this.MatrixAddRange.Size = new System.Drawing.Size(80, 23);
            this.MatrixAddRange.TabIndex = 3;
            this.MatrixAddRange.Text = "Add";
            this.MatrixAddRange.UseVisualStyleBackColor = true;
            this.MatrixAddRange.Click += new System.EventHandler(this.MatrixAddRange_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkMaterialUseSingleLine);
            this.groupBox2.Controls.Add(this.ExistingMaterialRanges);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MaterialRanges);
            this.groupBox2.Controls.Add(this.nudMaterialRangeTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.MaterialAddRange);
            this.groupBox2.Controls.Add(this.MaterialRemoveRange);
            this.groupBox2.Controls.Add(this.nudMaterialRangeFrom);
            this.groupBox2.Location = new System.Drawing.Point(490, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material Ranges";
            // 
            // chkMaterialUseSingleLine
            // 
            this.chkMaterialUseSingleLine.AutoSize = true;
            this.chkMaterialUseSingleLine.Location = new System.Drawing.Point(9, 163);
            this.chkMaterialUseSingleLine.Name = "chkMaterialUseSingleLine";
            this.chkMaterialUseSingleLine.Size = new System.Drawing.Size(100, 17);
            this.chkMaterialUseSingleLine.TabIndex = 11;
            this.chkMaterialUseSingleLine.Text = "Use Single Line";
            this.chkMaterialUseSingleLine.UseVisualStyleBackColor = true;
            this.chkMaterialUseSingleLine.CheckedChanged += new System.EventHandler(this.chkMaterialUseSingleLine_CheckedChanged);
            // 
            // ExistingMaterialRanges
            // 
            this.ExistingMaterialRanges.FormattingEnabled = true;
            this.ExistingMaterialRanges.Location = new System.Drawing.Point(6, 78);
            this.ExistingMaterialRanges.Name = "ExistingMaterialRanges";
            this.ExistingMaterialRanges.ScrollAlwaysVisible = true;
            this.ExistingMaterialRanges.Size = new System.Drawing.Size(161, 56);
            this.ExistingMaterialRanges.TabIndex = 10;
            this.ExistingMaterialRanges.SelectedIndexChanged += new System.EventHandler(this.ExistingMaterialRanges_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // MaterialRanges
            // 
            this.MaterialRanges.FormattingEnabled = true;
            this.MaterialRanges.Location = new System.Drawing.Point(6, 19);
            this.MaterialRanges.Name = "MaterialRanges";
            this.MaterialRanges.ScrollAlwaysVisible = true;
            this.MaterialRanges.Size = new System.Drawing.Size(161, 56);
            this.MaterialRanges.TabIndex = 2;
            // 
            // nudMaterialRangeTo
            // 
            this.nudMaterialRangeTo.DecimalPlaces = 1;
            this.nudMaterialRangeTo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaterialRangeTo.Location = new System.Drawing.Point(117, 140);
            this.nudMaterialRangeTo.Maximum = new decimal(new int[] {
            1333,
            0,
            0,
            0});
            this.nudMaterialRangeTo.Minimum = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMaterialRangeTo.Name = "nudMaterialRangeTo";
            this.nudMaterialRangeTo.Size = new System.Drawing.Size(49, 20);
            this.nudMaterialRangeTo.TabIndex = 6;
            this.nudMaterialRangeTo.Value = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMaterialRangeTo.ValueChanged += new System.EventHandler(this.nudMaterialRangeTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "to";
            // 
            // MaterialAddRange
            // 
            this.MaterialAddRange.Location = new System.Drawing.Point(6, 182);
            this.MaterialAddRange.Name = "MaterialAddRange";
            this.MaterialAddRange.Size = new System.Drawing.Size(83, 23);
            this.MaterialAddRange.TabIndex = 3;
            this.MaterialAddRange.Text = "Add";
            this.MaterialAddRange.UseVisualStyleBackColor = true;
            this.MaterialAddRange.Click += new System.EventHandler(this.MaterialAddRange_Click);
            // 
            // MaterialRemoveRange
            // 
            this.MaterialRemoveRange.Location = new System.Drawing.Point(94, 182);
            this.MaterialRemoveRange.Name = "MaterialRemoveRange";
            this.MaterialRemoveRange.Size = new System.Drawing.Size(72, 23);
            this.MaterialRemoveRange.TabIndex = 4;
            this.MaterialRemoveRange.Text = "Remove";
            this.MaterialRemoveRange.UseVisualStyleBackColor = true;
            this.MaterialRemoveRange.Click += new System.EventHandler(this.MaterialRemoveRange_Click);
            // 
            // nudMaterialRangeFrom
            // 
            this.nudMaterialRangeFrom.DecimalPlaces = 1;
            this.nudMaterialRangeFrom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMaterialRangeFrom.Location = new System.Drawing.Point(40, 140);
            this.nudMaterialRangeFrom.Maximum = new decimal(new int[] {
            1333,
            0,
            0,
            0});
            this.nudMaterialRangeFrom.Minimum = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMaterialRangeFrom.Name = "nudMaterialRangeFrom";
            this.nudMaterialRangeFrom.Size = new System.Drawing.Size(49, 20);
            this.nudMaterialRangeFrom.TabIndex = 5;
            this.nudMaterialRangeFrom.Value = new decimal(new int[] {
            174,
            0,
            0,
            0});
            this.nudMaterialRangeFrom.ValueChanged += new System.EventHandler(this.nudMaterialRangeFrom_ValueChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(6, 19);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(159, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ClearResults
            // 
            this.ClearResults.Location = new System.Drawing.Point(6, 43);
            this.ClearResults.Name = "ClearResults";
            this.ClearResults.Size = new System.Drawing.Size(159, 23);
            this.ClearResults.TabIndex = 7;
            this.ClearResults.Text = "Clear";
            this.ClearResults.UseVisualStyleBackColor = true;
            this.ClearResults.Click += new System.EventHandler(this.ClearResults_Click);
            // 
            // XMaterialNumber
            // 
            this.XMaterialNumber.AutoSize = true;
            this.XMaterialNumber.Checked = true;
            this.XMaterialNumber.Location = new System.Drawing.Point(6, 19);
            this.XMaterialNumber.Name = "XMaterialNumber";
            this.XMaterialNumber.Size = new System.Drawing.Size(117, 17);
            this.XMaterialNumber.TabIndex = 11;
            this.XMaterialNumber.TabStop = true;
            this.XMaterialNumber.Text = "Experiment Number";
            this.XMaterialNumber.UseVisualStyleBackColor = true;
            this.XMaterialNumber.CheckedChanged += new System.EventHandler(this.XMaterialNumber_CheckedChanged);
            // 
            // XDelta
            // 
            this.XDelta.AutoSize = true;
            this.XDelta.Location = new System.Drawing.Point(125, 19);
            this.XDelta.Name = "XDelta";
            this.XDelta.Size = new System.Drawing.Size(38, 17);
            this.XDelta.TabIndex = 12;
            this.XDelta.TabStop = true;
            this.XDelta.Text = "Δτ";
            this.XDelta.UseVisualStyleBackColor = true;
            this.XDelta.CheckedChanged += new System.EventHandler(this.XDelta_CheckedChanged);
            // 
            // SaveAsTable
            // 
            this.SaveAsTable.Location = new System.Drawing.Point(6, 142);
            this.SaveAsTable.Name = "SaveAsTable";
            this.SaveAsTable.Size = new System.Drawing.Size(159, 23);
            this.SaveAsTable.TabIndex = 14;
            this.SaveAsTable.Text = "Save Table";
            this.SaveAsTable.UseVisualStyleBackColor = true;
            this.SaveAsTable.Click += new System.EventHandler(this.SaveAsTable_Click);
            // 
            // ErrorsText
            // 
            this.ErrorsText.Location = new System.Drawing.Point(6, 19);
            this.ErrorsText.Multiline = true;
            this.ErrorsText.Name = "ErrorsText";
            this.ErrorsText.ReadOnly = true;
            this.ErrorsText.Size = new System.Drawing.Size(159, 102);
            this.ErrorsText.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ErrorsText);
            this.groupBox3.Location = new System.Drawing.Point(673, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 127);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "μ and σ";
            // 
            // SortByAverage
            // 
            this.SortByAverage.Location = new System.Drawing.Point(6, 67);
            this.SortByAverage.Name = "SortByAverage";
            this.SortByAverage.Size = new System.Drawing.Size(159, 23);
            this.SortByAverage.TabIndex = 19;
            this.SortByAverage.Text = "Sort by Average";
            this.SortByAverage.UseVisualStyleBackColor = true;
            this.SortByAverage.Click += new System.EventHandler(this.SortByAverage_Click);
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.Beige;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.Title = "Relative integral";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.LightGray;
            chartArea1.BackColor = System.Drawing.Color.Beige;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(12, 8);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(472, 430);
            this.MainChart.TabIndex = 20;
            this.MainChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Relative integral distribution";
            this.MainChart.Titles.Add(title1);
            // 
            // btnLinearFitting
            // 
            this.btnLinearFitting.Location = new System.Drawing.Point(6, 92);
            this.btnLinearFitting.Name = "btnLinearFitting";
            this.btnLinearFitting.Size = new System.Drawing.Size(159, 23);
            this.btnLinearFitting.TabIndex = 21;
            this.btnLinearFitting.Text = "Linear Fitting";
            this.btnLinearFitting.UseVisualStyleBackColor = true;
            this.btnLinearFitting.Click += new System.EventHandler(this.btnLinearFitting_Click);
            // 
            // lblSlope
            // 
            this.lblSlope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSlope.AutoSize = true;
            this.lblSlope.Location = new System.Drawing.Point(6, 223);
            this.lblSlope.Name = "lblSlope";
            this.lblSlope.Size = new System.Drawing.Size(62, 13);
            this.lblSlope.TabIndex = 22;
            this.lblSlope.Text = "Slope: NaN";
            // 
            // btnPartialSave
            // 
            this.btnPartialSave.Location = new System.Drawing.Point(6, 117);
            this.btnPartialSave.Name = "btnPartialSave";
            this.btnPartialSave.Size = new System.Drawing.Size(159, 23);
            this.btnPartialSave.TabIndex = 23;
            this.btnPartialSave.Text = "Save Only μ and σ";
            this.btnPartialSave.UseVisualStyleBackColor = true;
            this.btnPartialSave.Click += new System.EventHandler(this.btnPartialSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.XMaterialNumber);
            this.groupBox4.Controls.Add(this.XDelta);
            this.groupBox4.Location = new System.Drawing.Point(673, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 45);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "X Value";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.chkUseIrradiance);
            this.groupBox5.Controls.Add(this.Calculate);
            this.groupBox5.Controls.Add(this.SaveAsTable);
            this.groupBox5.Controls.Add(this.lblSlope);
            this.groupBox5.Controls.Add(this.btnPartialSave);
            this.groupBox5.Controls.Add(this.ClearResults);
            this.groupBox5.Controls.Add(this.SortByAverage);
            this.groupBox5.Controls.Add(this.btnLinearFitting);
            this.groupBox5.Location = new System.Drawing.Point(673, 136);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 254);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // chkUseIrradiance
            // 
            this.chkUseIrradiance.AutoSize = true;
            this.chkUseIrradiance.Location = new System.Drawing.Point(9, 172);
            this.chkUseIrradiance.Name = "chkUseIrradiance";
            this.chkUseIrradiance.Size = new System.Drawing.Size(98, 17);
            this.chkUseIrradiance.TabIndex = 24;
            this.chkUseIrradiance.Text = "Use Irradiance ";
            this.chkUseIrradiance.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(865, 437);
            this.Name = "Results";
            this.Text = "Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Results_FormClosed);
            this.Load += new System.EventHandler(this.Results_Load);
            this.ResizeEnd += new System.EventHandler(this.Results_ResizeEnd);
            this.Resize += new System.EventHandler(this.Results_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatrixRangeFrom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialRangeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaterialRangeFrom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MatrixRanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MatrixRemoveRange;
        private System.Windows.Forms.Button MatrixAddRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMatrixRangeTo;
        private System.Windows.Forms.NumericUpDown nudMatrixRangeFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMaterialRangeTo;
        private System.Windows.Forms.NumericUpDown nudMaterialRangeFrom;
        private System.Windows.Forms.Button MaterialRemoveRange;
        private System.Windows.Forms.Button MaterialAddRange;
        private System.Windows.Forms.ListBox MaterialRanges;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button ClearResults;
        private System.Windows.Forms.RadioButton XMaterialNumber;
        private System.Windows.Forms.RadioButton XDelta;
        private System.Windows.Forms.Button SaveAsTable;
        private System.Windows.Forms.SaveFileDialog SaveAsTableDialog;
        private System.Windows.Forms.ListBox ExistingMatrixRanges;
        private System.Windows.Forms.ListBox ExistingMaterialRanges;
        private System.Windows.Forms.TextBox ErrorsText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SortByAverage;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button btnLinearFitting;
        private System.Windows.Forms.Label lblSlope;
        private System.Windows.Forms.Button btnPartialSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkMaterialUseSingleLine;
        private System.Windows.Forms.CheckBox chkMatrixUseSingleLine;
        private System.Windows.Forms.CheckBox chkUseIrradiance;
    }
}
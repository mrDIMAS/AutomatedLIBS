namespace AutomatedLIBS
{
    partial class MainWindow
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrometerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doIrradianceCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plasmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectedMaterial = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.nudIntegrationBeginDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LaserDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LaserWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.IntegrationTime = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DetectionThreshold = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudIntegrationEndDelay = new System.Windows.Forms.NumericUpDown();
            this.IntegrationParameters = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nudPowerSupplyLag = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.MeasurementCount = new System.Windows.Forms.NumericUpDown();
            this.SeriesMeasure = new System.Windows.Forms.RadioButton();
            this.SingleMeasure = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.StartPause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.MeasureControl = new System.Windows.Forms.GroupBox();
            this.btnGetCalibration = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pbExperimentProgress = new System.Windows.Forms.ProgressBar();
            this.Normalize = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.nudMeasurementNumber = new System.Windows.Forms.NumericUpDown();
            this.SpectrumLinear = new System.Windows.Forms.Label();
            this.SaveSpectrums = new System.Windows.Forms.Button();
            this.ClearSpectrums = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.gbMeasurementResultsGroup = new System.Windows.Forms.GroupBox();
            this.btnBoringStuff = new System.Windows.Forms.Button();
            this.btnFourierSelfDeconvolution = new System.Windows.Forms.Button();
            this.nudMaxRemoveNumber = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveWithMaxOver = new System.Windows.Forms.Button();
            this.btnDiscardOutlier = new System.Windows.Forms.Button();
            this.btnSavePlotToFile = new System.Windows.Forms.Button();
            this.btnMergeIntegrals = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.clbAdditionalSpectraPlot = new System.Windows.Forms.CheckedListBox();
            this.lblSpectrumCount = new System.Windows.Forms.Label();
            this.nudLowerLimit = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveWithMaxLower = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SpectrumCountToRemove = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveFirstNSpectrums = new System.Windows.Forms.Button();
            this.nudSpectrumNumber = new System.Windows.Forms.NumericUpDown();
            this.RemoveSaturatedSpectrums = new System.Windows.Forms.Button();
            this.btnBaselineSpline = new System.Windows.Forms.Button();
            this.SmoothSpectrumButton = new System.Windows.Forms.Button();
            this.LoadTable = new System.Windows.Forms.Button();
            this.SaveTable = new System.Windows.Forms.Button();
            this.btnBaselineMin = new System.Windows.Forms.Button();
            this.btnAverageSpectra = new System.Windows.Forms.Button();
            this.AddSpectrumSeries = new System.Windows.Forms.Button();
            this.AddSpectrum = new System.Windows.Forms.Button();
            this.SaveCurrentSpectrum = new System.Windows.Forms.Button();
            this.chkEnableCalibratedYAxis = new System.Windows.Forms.CheckBox();
            this.SaveSpectrumDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSaveCurrentSpectrum = new System.Windows.Forms.SaveFileDialog();
            this.AddNewSpectrumDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddSpectrumSeriesDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mMainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Recognition = new System.Windows.Forms.TabControl();
            this.DataProcessing = new System.Windows.Forms.TabPage();
            this.ExperimentPage = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.chkAskMeBeforeNewExp = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nudRightAccuracyLimit = new System.Windows.Forms.NumericUpDown();
            this.chkShowPeakInfo = new System.Windows.Forms.CheckBox();
            this.btnShowLineBase = new System.Windows.Forms.Button();
            this.btnCalculateIntergralRatios = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nudLeftAccuracyLimit = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.CheckBox();
            this.btnMolecules = new System.Windows.Forms.Button();
            this.lblLinesInBase = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkEuropium = new System.Windows.Forms.CheckBox();
            this.chkNeptunium = new System.Windows.Forms.CheckBox();
            this.chkUranium = new System.Windows.Forms.CheckBox();
            this.chkProtactinium = new System.Windows.Forms.CheckBox();
            this.chkThorium = new System.Windows.Forms.CheckBox();
            this.chkLutetium = new System.Windows.Forms.CheckBox();
            this.chkYtterbium = new System.Windows.Forms.CheckBox();
            this.chkThulium = new System.Windows.Forms.CheckBox();
            this.chkErbium = new System.Windows.Forms.CheckBox();
            this.chkHolmium = new System.Windows.Forms.CheckBox();
            this.chkDysprosium = new System.Windows.Forms.CheckBox();
            this.chkTerbium = new System.Windows.Forms.CheckBox();
            this.chkGadolinium = new System.Windows.Forms.CheckBox();
            this.chkSamarium = new System.Windows.Forms.CheckBox();
            this.chkPromethium = new System.Windows.Forms.CheckBox();
            this.chkNeodymium = new System.Windows.Forms.CheckBox();
            this.chkPraseodymium = new System.Windows.Forms.CheckBox();
            this.chkCerium = new System.Windows.Forms.CheckBox();
            this.chkRadon = new System.Windows.Forms.CheckBox();
            this.chkAstatium = new System.Windows.Forms.CheckBox();
            this.chkPolonium = new System.Windows.Forms.CheckBox();
            this.chkBismuthum = new System.Windows.Forms.CheckBox();
            this.chkPlumbum = new System.Windows.Forms.CheckBox();
            this.chkThallium = new System.Windows.Forms.CheckBox();
            this.chkHydrargyrum = new System.Windows.Forms.CheckBox();
            this.chkAurum = new System.Windows.Forms.CheckBox();
            this.chkPlatinum = new System.Windows.Forms.CheckBox();
            this.chkIridium = new System.Windows.Forms.CheckBox();
            this.chkOsmium = new System.Windows.Forms.CheckBox();
            this.chkRhenium = new System.Windows.Forms.CheckBox();
            this.chkWolframium = new System.Windows.Forms.CheckBox();
            this.chkTantalum = new System.Windows.Forms.CheckBox();
            this.chkHafnium = new System.Windows.Forms.CheckBox();
            this.chkLanthanum = new System.Windows.Forms.CheckBox();
            this.chkBarium = new System.Windows.Forms.CheckBox();
            this.chkCaesium = new System.Windows.Forms.CheckBox();
            this.chkXenon = new System.Windows.Forms.CheckBox();
            this.chkIodum = new System.Windows.Forms.CheckBox();
            this.chkTellurium = new System.Windows.Forms.CheckBox();
            this.chkStibium = new System.Windows.Forms.CheckBox();
            this.chkStannum = new System.Windows.Forms.CheckBox();
            this.chkIndium = new System.Windows.Forms.CheckBox();
            this.chkCadmium = new System.Windows.Forms.CheckBox();
            this.chkArgentum = new System.Windows.Forms.CheckBox();
            this.chkPalladium = new System.Windows.Forms.CheckBox();
            this.chkRhodium = new System.Windows.Forms.CheckBox();
            this.chkRuthenium = new System.Windows.Forms.CheckBox();
            this.chkTechnetium = new System.Windows.Forms.CheckBox();
            this.chkMolybdaenum = new System.Windows.Forms.CheckBox();
            this.chkNiobium = new System.Windows.Forms.CheckBox();
            this.chkZirconium = new System.Windows.Forms.CheckBox();
            this.chkYttrium = new System.Windows.Forms.CheckBox();
            this.chkStrontium = new System.Windows.Forms.CheckBox();
            this.chkRubidium = new System.Windows.Forms.CheckBox();
            this.chkKrypton = new System.Windows.Forms.CheckBox();
            this.chkBromum = new System.Windows.Forms.CheckBox();
            this.chkSelenium = new System.Windows.Forms.CheckBox();
            this.chkArsenicum = new System.Windows.Forms.CheckBox();
            this.chkGermanium = new System.Windows.Forms.CheckBox();
            this.chkGallium = new System.Windows.Forms.CheckBox();
            this.chkZincum = new System.Windows.Forms.CheckBox();
            this.chkCuprum = new System.Windows.Forms.CheckBox();
            this.chkNiccolum = new System.Windows.Forms.CheckBox();
            this.chkCobaltum = new System.Windows.Forms.CheckBox();
            this.chkFerrum = new System.Windows.Forms.CheckBox();
            this.chkManganum = new System.Windows.Forms.CheckBox();
            this.chkChromium = new System.Windows.Forms.CheckBox();
            this.chkVanadium = new System.Windows.Forms.CheckBox();
            this.chkTitanium = new System.Windows.Forms.CheckBox();
            this.chkScandium = new System.Windows.Forms.CheckBox();
            this.chkCalcium = new System.Windows.Forms.CheckBox();
            this.chkKalium = new System.Windows.Forms.CheckBox();
            this.chkArgon = new System.Windows.Forms.CheckBox();
            this.chkChlorum = new System.Windows.Forms.CheckBox();
            this.chkSulfur = new System.Windows.Forms.CheckBox();
            this.chkPhosphorus = new System.Windows.Forms.CheckBox();
            this.chkSilicium = new System.Windows.Forms.CheckBox();
            this.chkAluminium = new System.Windows.Forms.CheckBox();
            this.chkMagnesium = new System.Windows.Forms.CheckBox();
            this.chkNatrium = new System.Windows.Forms.CheckBox();
            this.chkNeon = new System.Windows.Forms.CheckBox();
            this.chkFluorum = new System.Windows.Forms.CheckBox();
            this.chkOxygenium = new System.Windows.Forms.CheckBox();
            this.chkNitrogenium = new System.Windows.Forms.CheckBox();
            this.chkCarboneum = new System.Windows.Forms.CheckBox();
            this.chkBorum = new System.Windows.Forms.CheckBox();
            this.chkBerillium = new System.Windows.Forms.CheckBox();
            this.chkLithium = new System.Windows.Forms.CheckBox();
            this.chkHelium = new System.Windows.Forms.CheckBox();
            this.chkHydrogen = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearRecognized = new System.Windows.Forms.Button();
            this.nudPeakThreshold = new System.Windows.Forms.NumericUpDown();
            this.RecognizedLinesCountText = new System.Windows.Forms.Label();
            this.btnRecognizeLines = new System.Windows.Forms.Button();
            this.bgwIdentification = new System.ComponentModel.BackgroundWorker();
            this.btnSaveCalibrated = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegrationBeginDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectionThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegrationEndDelay)).BeginInit();
            this.IntegrationParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerSupplyLag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementCount)).BeginInit();
            this.MeasureControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasurementNumber)).BeginInit();
            this.gbMeasurementResultsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRemoveNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumCountToRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMainChart)).BeginInit();
            this.Recognition.SuspendLayout();
            this.DataProcessing.SuspendLayout();
            this.ExperimentPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightAccuracyLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftAccuracyLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeakThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.spectrometerToolStripMenuItem,
            this.materialsToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.plasmaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(719, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.exitToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // spectrometerToolStripMenuItem
            // 
            this.spectrometerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.doIrradianceCalibrationToolStripMenuItem});
            this.spectrometerToolStripMenuItem.Name = "spectrometerToolStripMenuItem";
            this.spectrometerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.spectrometerToolStripMenuItem.Text = "Spectrometer";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // doIrradianceCalibrationToolStripMenuItem
            // 
            this.doIrradianceCalibrationToolStripMenuItem.Name = "doIrradianceCalibrationToolStripMenuItem";
            this.doIrradianceCalibrationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.doIrradianceCalibrationToolStripMenuItem.Text = "Do Irradiance Calibration";
            this.doIrradianceCalibrationToolStripMenuItem.Click += new System.EventHandler(this.doIrradianceCalibrationToolStripMenuItem_Click);
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.detectionInfoToolStripMenuItem});
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.materialsToolStripMenuItem.Text = "Materials";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // detectionInfoToolStripMenuItem
            // 
            this.detectionInfoToolStripMenuItem.Name = "detectionInfoToolStripMenuItem";
            this.detectionInfoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.detectionInfoToolStripMenuItem.Text = "Detection Info";
            this.detectionInfoToolStripMenuItem.Click += new System.EventHandler(this.detectionInfoToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.resultsToolStripMenuItem.Text = "Integral Calculation";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // plasmaToolStripMenuItem
            // 
            this.plasmaToolStripMenuItem.Name = "plasmaToolStripMenuItem";
            this.plasmaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.plasmaToolStripMenuItem.Text = "Plasma";
            this.plasmaToolStripMenuItem.Click += new System.EventHandler(this.plasmaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // DetectedMaterial
            // 
            this.DetectedMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetectedMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DetectedMaterial.Location = new System.Drawing.Point(487, 26);
            this.DetectedMaterial.Name = "DetectedMaterial";
            this.DetectedMaterial.Size = new System.Drawing.Size(221, 16);
            this.DetectedMaterial.TabIndex = 2;
            this.DetectedMaterial.Text = "Unknown Material";
            this.DetectedMaterial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.StatusBar.Location = new System.Drawing.Point(0, 560);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(719, 22);
            this.StatusBar.TabIndex = 3;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(129, 17);
            this.StatusText.Text = "Connect Spectrometer!";
            // 
            // nudIntegrationBeginDelay
            // 
            this.nudIntegrationBeginDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntegrationBeginDelay.DecimalPlaces = 2;
            this.nudIntegrationBeginDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudIntegrationBeginDelay.Location = new System.Drawing.Point(41, 46);
            this.nudIntegrationBeginDelay.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudIntegrationBeginDelay.Name = "nudIntegrationBeginDelay";
            this.nudIntegrationBeginDelay.Size = new System.Drawing.Size(53, 20);
            this.nudIntegrationBeginDelay.TabIndex = 4;
            this.nudIntegrationBeginDelay.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "μs";
            // 
            // LaserDelay
            // 
            this.LaserDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaserDelay.Location = new System.Drawing.Point(134, 164);
            this.LaserDelay.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.LaserDelay.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.LaserDelay.Name = "LaserDelay";
            this.LaserDelay.Size = new System.Drawing.Size(58, 20);
            this.LaserDelay.TabIndex = 8;
            this.LaserDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Laser Delay";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TTL Width";
            // 
            // LaserWidth
            // 
            this.LaserWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LaserWidth.DecimalPlaces = 2;
            this.LaserWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LaserWidth.Location = new System.Drawing.Point(134, 190);
            this.LaserWidth.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LaserWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LaserWidth.Name = "LaserWidth";
            this.LaserWidth.Size = new System.Drawing.Size(58, 20);
            this.LaserWidth.TabIndex = 12;
            this.LaserWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ms";
            // 
            // IntegrationTime
            // 
            this.IntegrationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntegrationTime.DecimalPlaces = 2;
            this.IntegrationTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.IntegrationTime.Location = new System.Drawing.Point(134, 138);
            this.IntegrationTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IntegrationTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.IntegrationTime.Name = "IntegrationTime";
            this.IntegrationTime.Size = new System.Drawing.Size(58, 20);
            this.IntegrationTime.TabIndex = 14;
            this.IntegrationTime.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Integration Time";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ms";
            // 
            // DetectionThreshold
            // 
            this.DetectionThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DetectionThreshold.DecimalPlaces = 2;
            this.DetectionThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.DetectionThreshold.Location = new System.Drawing.Point(134, 216);
            this.DetectionThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DetectionThreshold.Name = "DetectionThreshold";
            this.DetectionThreshold.Size = new System.Drawing.Size(58, 20);
            this.DetectionThreshold.TabIndex = 17;
            this.DetectionThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.DetectionThreshold.ValueChanged += new System.EventHandler(this.DetectionThreshold_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detection Threshold";
            // 
            // nudIntegrationEndDelay
            // 
            this.nudIntegrationEndDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntegrationEndDelay.DecimalPlaces = 2;
            this.nudIntegrationEndDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudIntegrationEndDelay.Location = new System.Drawing.Point(120, 46);
            this.nudIntegrationEndDelay.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudIntegrationEndDelay.Name = "nudIntegrationEndDelay";
            this.nudIntegrationEndDelay.Size = new System.Drawing.Size(53, 20);
            this.nudIntegrationEndDelay.TabIndex = 22;
            this.nudIntegrationEndDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // IntegrationParameters
            // 
            this.IntegrationParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IntegrationParameters.Controls.Add(this.label26);
            this.IntegrationParameters.Controls.Add(this.label25);
            this.IntegrationParameters.Controls.Add(this.nudPowerSupplyLag);
            this.IntegrationParameters.Controls.Add(this.label13);
            this.IntegrationParameters.Controls.Add(this.MeasurementCount);
            this.IntegrationParameters.Controls.Add(this.SeriesMeasure);
            this.IntegrationParameters.Controls.Add(this.SingleMeasure);
            this.IntegrationParameters.Controls.Add(this.label11);
            this.IntegrationParameters.Controls.Add(this.nudIntegrationEndDelay);
            this.IntegrationParameters.Controls.Add(this.nudIntegrationBeginDelay);
            this.IntegrationParameters.Controls.Add(this.label1);
            this.IntegrationParameters.Controls.Add(this.label2);
            this.IntegrationParameters.Location = new System.Drawing.Point(15, 9);
            this.IntegrationParameters.Name = "IntegrationParameters";
            this.IntegrationParameters.Size = new System.Drawing.Size(200, 123);
            this.IntegrationParameters.TabIndex = 23;
            this.IntegrationParameters.TabStop = false;
            this.IntegrationParameters.Text = "Delay Before Integration Begins";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "Power Supply Lag ¹";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(178, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "μs";
            // 
            // nudPowerSupplyLag
            // 
            this.nudPowerSupplyLag.DecimalPlaces = 2;
            this.nudPowerSupplyLag.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPowerSupplyLag.Location = new System.Drawing.Point(119, 20);
            this.nudPowerSupplyLag.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPowerSupplyLag.Name = "nudPowerSupplyLag";
            this.nudPowerSupplyLag.Size = new System.Drawing.Size(54, 20);
            this.nudPowerSupplyLag.TabIndex = 29;
            this.nudPowerSupplyLag.Value = new decimal(new int[] {
            1436,
            0,
            0,
            65536});
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Shot Count";
            // 
            // MeasurementCount
            // 
            this.MeasurementCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasurementCount.Location = new System.Drawing.Point(119, 72);
            this.MeasurementCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MeasurementCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MeasurementCount.Name = "MeasurementCount";
            this.MeasurementCount.Size = new System.Drawing.Size(54, 20);
            this.MeasurementCount.TabIndex = 27;
            this.MeasurementCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MeasurementCount.ValueChanged += new System.EventHandler(this.MeasurementCount_ValueChanged);
            // 
            // SeriesMeasure
            // 
            this.SeriesMeasure.AutoSize = true;
            this.SeriesMeasure.Location = new System.Drawing.Point(121, 98);
            this.SeriesMeasure.Name = "SeriesMeasure";
            this.SeriesMeasure.Size = new System.Drawing.Size(54, 17);
            this.SeriesMeasure.TabIndex = 26;
            this.SeriesMeasure.Text = "Series";
            this.SeriesMeasure.UseVisualStyleBackColor = true;
            // 
            // SingleMeasure
            // 
            this.SingleMeasure.AutoSize = true;
            this.SingleMeasure.Checked = true;
            this.SingleMeasure.Location = new System.Drawing.Point(12, 98);
            this.SingleMeasure.Name = "SingleMeasure";
            this.SingleMeasure.Size = new System.Drawing.Size(54, 17);
            this.SingleMeasure.TabIndex = 25;
            this.SingleMeasure.TabStop = true;
            this.SingleMeasure.Text = "Single";
            this.SingleMeasure.UseVisualStyleBackColor = true;
            this.SingleMeasure.CheckedChanged += new System.EventHandler(this.SingleMeasure_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "To";
            // 
            // StartPause
            // 
            this.StartPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPause.Enabled = false;
            this.StartPause.Location = new System.Drawing.Point(6, 19);
            this.StartPause.Name = "StartPause";
            this.StartPause.Size = new System.Drawing.Size(71, 23);
            this.StartPause.TabIndex = 24;
            this.StartPause.Text = "Start";
            this.StartPause.UseVisualStyleBackColor = true;
            this.StartPause.Click += new System.EventHandler(this.StartPause_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(160, 19);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(67, 23);
            this.Stop.TabIndex = 26;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pause.Enabled = false;
            this.Pause.Location = new System.Drawing.Point(83, 19);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(71, 23);
            this.Pause.TabIndex = 27;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // MeasureControl
            // 
            this.MeasureControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasureControl.Controls.Add(this.btnGetCalibration);
            this.MeasureControl.Controls.Add(this.label17);
            this.MeasureControl.Controls.Add(this.pbExperimentProgress);
            this.MeasureControl.Controls.Add(this.StartPause);
            this.MeasureControl.Controls.Add(this.Pause);
            this.MeasureControl.Controls.Add(this.Stop);
            this.MeasureControl.Location = new System.Drawing.Point(6, 302);
            this.MeasureControl.Name = "MeasureControl";
            this.MeasureControl.Size = new System.Drawing.Size(233, 114);
            this.MeasureControl.TabIndex = 28;
            this.MeasureControl.TabStop = false;
            this.MeasureControl.Text = "Spectrometer Control";
            // 
            // btnGetCalibration
            // 
            this.btnGetCalibration.Location = new System.Drawing.Point(6, 48);
            this.btnGetCalibration.Name = "btnGetCalibration";
            this.btnGetCalibration.Size = new System.Drawing.Size(221, 23);
            this.btnGetCalibration.TabIndex = 29;
            this.btnGetCalibration.Text = "Get Calibration From Spectrometer";
            this.btnGetCalibration.UseVisualStyleBackColor = true;
            this.btnGetCalibration.Click += new System.EventHandler(this.btnGetCalibration_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Progress";
            // 
            // pbExperimentProgress
            // 
            this.pbExperimentProgress.Location = new System.Drawing.Point(60, 85);
            this.pbExperimentProgress.Name = "pbExperimentProgress";
            this.pbExperimentProgress.Size = new System.Drawing.Size(167, 23);
            this.pbExperimentProgress.TabIndex = 30;
            // 
            // Normalize
            // 
            this.Normalize.Location = new System.Drawing.Point(140, 45);
            this.Normalize.Name = "Normalize";
            this.Normalize.Size = new System.Drawing.Size(71, 23);
            this.Normalize.TabIndex = 38;
            this.Normalize.Text = "Normalize";
            this.Normalize.UseVisualStyleBackColor = true;
            this.Normalize.Click += new System.EventHandler(this.Normalize_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(465, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Work with Experiment";
            // 
            // nudMeasurementNumber
            // 
            this.nudMeasurementNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMeasurementNumber.Location = new System.Drawing.Point(581, 57);
            this.nudMeasurementNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMeasurementNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMeasurementNumber.Name = "nudMeasurementNumber";
            this.nudMeasurementNumber.Size = new System.Drawing.Size(134, 20);
            this.nudMeasurementNumber.TabIndex = 36;
            this.nudMeasurementNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMeasurementNumber.ValueChanged += new System.EventHandler(this.MeasurementNumber_ValueChanged);
            // 
            // SpectrumLinear
            // 
            this.SpectrumLinear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SpectrumLinear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpectrumLinear.Location = new System.Drawing.Point(486, 41);
            this.SpectrumLinear.Name = "SpectrumLinear";
            this.SpectrumLinear.Size = new System.Drawing.Size(223, 15);
            this.SpectrumLinear.TabIndex = 29;
            this.SpectrumLinear.Text = "Spectrum non-linear";
            this.SpectrumLinear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveSpectrums
            // 
            this.SaveSpectrums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveSpectrums.Location = new System.Drawing.Point(60, 68);
            this.SaveSpectrums.Name = "SaveSpectrums";
            this.SaveSpectrums.Size = new System.Drawing.Size(77, 23);
            this.SaveSpectrums.TabIndex = 32;
            this.SaveSpectrums.Text = "Save Series";
            this.SaveSpectrums.UseVisualStyleBackColor = true;
            this.SaveSpectrums.Click += new System.EventHandler(this.SaveSpectrums_Click);
            // 
            // ClearSpectrums
            // 
            this.ClearSpectrums.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSpectrums.Location = new System.Drawing.Point(140, 114);
            this.ClearSpectrums.Name = "ClearSpectrums";
            this.ClearSpectrums.Size = new System.Drawing.Size(71, 23);
            this.ClearSpectrums.TabIndex = 33;
            this.ClearSpectrums.Text = "Clear";
            this.ClearSpectrums.UseVisualStyleBackColor = true;
            this.ClearSpectrums.Click += new System.EventHandler(this.ClearSpectrums_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Work with Spectrum";
            // 
            // gbMeasurementResultsGroup
            // 
            this.gbMeasurementResultsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMeasurementResultsGroup.Controls.Add(this.btnSaveCalibrated);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnBoringStuff);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnFourierSelfDeconvolution);
            this.gbMeasurementResultsGroup.Controls.Add(this.nudMaxRemoveNumber);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnRemoveWithMaxOver);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnDiscardOutlier);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnSavePlotToFile);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnMergeIntegrals);
            this.gbMeasurementResultsGroup.Controls.Add(this.label21);
            this.gbMeasurementResultsGroup.Controls.Add(this.clbAdditionalSpectraPlot);
            this.gbMeasurementResultsGroup.Controls.Add(this.lblSpectrumCount);
            this.gbMeasurementResultsGroup.Controls.Add(this.nudLowerLimit);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnRemoveWithMaxLower);
            this.gbMeasurementResultsGroup.Controls.Add(this.label10);
            this.gbMeasurementResultsGroup.Controls.Add(this.SpectrumCountToRemove);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnRemoveFirstNSpectrums);
            this.gbMeasurementResultsGroup.Controls.Add(this.nudSpectrumNumber);
            this.gbMeasurementResultsGroup.Controls.Add(this.RemoveSaturatedSpectrums);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnBaselineSpline);
            this.gbMeasurementResultsGroup.Controls.Add(this.Normalize);
            this.gbMeasurementResultsGroup.Controls.Add(this.SmoothSpectrumButton);
            this.gbMeasurementResultsGroup.Controls.Add(this.LoadTable);
            this.gbMeasurementResultsGroup.Controls.Add(this.SaveTable);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnBaselineMin);
            this.gbMeasurementResultsGroup.Controls.Add(this.btnAverageSpectra);
            this.gbMeasurementResultsGroup.Controls.Add(this.AddSpectrumSeries);
            this.gbMeasurementResultsGroup.Controls.Add(this.AddSpectrum);
            this.gbMeasurementResultsGroup.Controls.Add(this.SaveCurrentSpectrum);
            this.gbMeasurementResultsGroup.Controls.Add(this.label14);
            this.gbMeasurementResultsGroup.Controls.Add(this.SaveSpectrums);
            this.gbMeasurementResultsGroup.Controls.Add(this.ClearSpectrums);
            this.gbMeasurementResultsGroup.Location = new System.Drawing.Point(6, 6);
            this.gbMeasurementResultsGroup.Name = "gbMeasurementResultsGroup";
            this.gbMeasurementResultsGroup.Size = new System.Drawing.Size(219, 418);
            this.gbMeasurementResultsGroup.TabIndex = 36;
            this.gbMeasurementResultsGroup.TabStop = false;
            this.gbMeasurementResultsGroup.Text = "Experiment 1 Actions";
            // 
            // btnBoringStuff
            // 
            this.btnBoringStuff.Location = new System.Drawing.Point(6, 300);
            this.btnBoringStuff.Name = "btnBoringStuff";
            this.btnBoringStuff.Size = new System.Drawing.Size(91, 22);
            this.btnBoringStuff.TabIndex = 61;
            this.btnBoringStuff.Text = "Do Boring Stuff";
            this.btnBoringStuff.UseVisualStyleBackColor = true;
            this.btnBoringStuff.Click += new System.EventHandler(this.btnBoringStuff_Click);
            // 
            // btnFourierSelfDeconvolution
            // 
            this.btnFourierSelfDeconvolution.Location = new System.Drawing.Point(6, 275);
            this.btnFourierSelfDeconvolution.Name = "btnFourierSelfDeconvolution";
            this.btnFourierSelfDeconvolution.Size = new System.Drawing.Size(204, 23);
            this.btnFourierSelfDeconvolution.TabIndex = 60;
            this.btnFourierSelfDeconvolution.Text = "Fourier Self-Deconvolution...";
            this.btnFourierSelfDeconvolution.UseVisualStyleBackColor = true;
            this.btnFourierSelfDeconvolution.Click += new System.EventHandler(this.btnFourierSelfDeconvolution_Click);
            // 
            // nudMaxRemoveNumber
            // 
            this.nudMaxRemoveNumber.Location = new System.Drawing.Point(139, 253);
            this.nudMaxRemoveNumber.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudMaxRemoveNumber.Name = "nudMaxRemoveNumber";
            this.nudMaxRemoveNumber.Size = new System.Drawing.Size(71, 20);
            this.nudMaxRemoveNumber.TabIndex = 59;
            this.nudMaxRemoveNumber.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // btnRemoveWithMaxOver
            // 
            this.btnRemoveWithMaxOver.Location = new System.Drawing.Point(6, 252);
            this.btnRemoveWithMaxOver.Name = "btnRemoveWithMaxOver";
            this.btnRemoveWithMaxOver.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveWithMaxOver.TabIndex = 58;
            this.btnRemoveWithMaxOver.Text = "Remove With Max Over";
            this.btnRemoveWithMaxOver.UseVisualStyleBackColor = true;
            this.btnRemoveWithMaxOver.Click += new System.EventHandler(this.btnRemoveWithMaxOver_Click);
            // 
            // btnDiscardOutlier
            // 
            this.btnDiscardOutlier.Location = new System.Drawing.Point(6, 183);
            this.btnDiscardOutlier.Name = "btnDiscardOutlier";
            this.btnDiscardOutlier.Size = new System.Drawing.Size(131, 23);
            this.btnDiscardOutlier.TabIndex = 57;
            this.btnDiscardOutlier.Text = "Discard Outlier Spectra";
            this.btnDiscardOutlier.UseVisualStyleBackColor = true;
            this.btnDiscardOutlier.Click += new System.EventHandler(this.btnDiscardOutlier_Click);
            // 
            // btnSavePlotToFile
            // 
            this.btnSavePlotToFile.Location = new System.Drawing.Point(140, 183);
            this.btnSavePlotToFile.Name = "btnSavePlotToFile";
            this.btnSavePlotToFile.Size = new System.Drawing.Size(71, 23);
            this.btnSavePlotToFile.TabIndex = 56;
            this.btnSavePlotToFile.Text = "Save Plot ";
            this.btnSavePlotToFile.UseVisualStyleBackColor = true;
            this.btnSavePlotToFile.Click += new System.EventHandler(this.btnSavePlotToFile_Click);
            // 
            // btnMergeIntegrals
            // 
            this.btnMergeIntegrals.Location = new System.Drawing.Point(6, 160);
            this.btnMergeIntegrals.Name = "btnMergeIntegrals";
            this.btnMergeIntegrals.Size = new System.Drawing.Size(131, 23);
            this.btnMergeIntegrals.TabIndex = 55;
            this.btnMergeIntegrals.Text = "Merge Intergral Lists";
            this.btnMergeIntegrals.UseVisualStyleBackColor = true;
            this.btnMergeIntegrals.Click += new System.EventHandler(this.btnMergeIntegrals_Click);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 329);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 13);
            this.label21.TabIndex = 53;
            this.label21.Text = "Also plot following spectra:";
            // 
            // clbAdditionalSpectraPlot
            // 
            this.clbAdditionalSpectraPlot.FormattingEnabled = true;
            this.clbAdditionalSpectraPlot.Location = new System.Drawing.Point(6, 344);
            this.clbAdditionalSpectraPlot.Name = "clbAdditionalSpectraPlot";
            this.clbAdditionalSpectraPlot.Size = new System.Drawing.Size(205, 64);
            this.clbAdditionalSpectraPlot.TabIndex = 52;
            this.clbAdditionalSpectraPlot.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbAdditionalSpectraPlot_ItemCheck);
            this.clbAdditionalSpectraPlot.SelectedIndexChanged += new System.EventHandler(this.clbAdditionalSpectraPlot_SelectedIndexChanged);
            // 
            // lblSpectrumCount
            // 
            this.lblSpectrumCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpectrumCount.AutoSize = true;
            this.lblSpectrumCount.Location = new System.Drawing.Point(175, 21);
            this.lblSpectrumCount.Name = "lblSpectrumCount";
            this.lblSpectrumCount.Size = new System.Drawing.Size(25, 13);
            this.lblSpectrumCount.TabIndex = 51;
            this.lblSpectrumCount.Text = "of 0";
            // 
            // nudLowerLimit
            // 
            this.nudLowerLimit.Location = new System.Drawing.Point(152, 208);
            this.nudLowerLimit.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudLowerLimit.Name = "nudLowerLimit";
            this.nudLowerLimit.Size = new System.Drawing.Size(56, 20);
            this.nudLowerLimit.TabIndex = 50;
            this.nudLowerLimit.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            // 
            // btnRemoveWithMaxLower
            // 
            this.btnRemoveWithMaxLower.Location = new System.Drawing.Point(6, 206);
            this.btnRemoveWithMaxLower.Name = "btnRemoveWithMaxLower";
            this.btnRemoveWithMaxLower.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveWithMaxLower.TabIndex = 49;
            this.btnRemoveWithMaxLower.Text = "Remove With Max Lower";
            this.btnRemoveWithMaxLower.UseVisualStyleBackColor = true;
            this.btnRemoveWithMaxLower.Click += new System.EventHandler(this.btnRemoveWithMaxLower_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "spectra";
            // 
            // SpectrumCountToRemove
            // 
            this.SpectrumCountToRemove.Location = new System.Drawing.Point(101, 230);
            this.SpectrumCountToRemove.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SpectrumCountToRemove.Name = "SpectrumCountToRemove";
            this.SpectrumCountToRemove.Size = new System.Drawing.Size(62, 20);
            this.SpectrumCountToRemove.TabIndex = 47;
            this.SpectrumCountToRemove.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnRemoveFirstNSpectrums
            // 
            this.btnRemoveFirstNSpectrums.Location = new System.Drawing.Point(6, 229);
            this.btnRemoveFirstNSpectrums.Name = "btnRemoveFirstNSpectrums";
            this.btnRemoveFirstNSpectrums.Size = new System.Drawing.Size(91, 23);
            this.btnRemoveFirstNSpectrums.TabIndex = 46;
            this.btnRemoveFirstNSpectrums.Text = "Remove First";
            this.btnRemoveFirstNSpectrums.UseVisualStyleBackColor = true;
            this.btnRemoveFirstNSpectrums.Click += new System.EventHandler(this.btnRemoveFirstNSpectrums_Click);
            // 
            // nudSpectrumNumber
            // 
            this.nudSpectrumNumber.Location = new System.Drawing.Point(115, 19);
            this.nudSpectrumNumber.Name = "nudSpectrumNumber";
            this.nudSpectrumNumber.Size = new System.Drawing.Size(54, 20);
            this.nudSpectrumNumber.TabIndex = 45;
            this.nudSpectrumNumber.ValueChanged += new System.EventHandler(this.SpectrumNumber_ValueChanged);
            // 
            // RemoveSaturatedSpectrums
            // 
            this.RemoveSaturatedSpectrums.Location = new System.Drawing.Point(6, 45);
            this.RemoveSaturatedSpectrums.Name = "RemoveSaturatedSpectrums";
            this.RemoveSaturatedSpectrums.Size = new System.Drawing.Size(131, 23);
            this.RemoveSaturatedSpectrums.TabIndex = 44;
            this.RemoveSaturatedSpectrums.Text = "Remove Saturated";
            this.RemoveSaturatedSpectrums.UseVisualStyleBackColor = true;
            this.RemoveSaturatedSpectrums.Click += new System.EventHandler(this.RemoveSaturatedSpectrums_Click);
            // 
            // btnBaselineSpline
            // 
            this.btnBaselineSpline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaselineSpline.Location = new System.Drawing.Point(6, 137);
            this.btnBaselineSpline.Name = "btnBaselineSpline";
            this.btnBaselineSpline.Size = new System.Drawing.Size(131, 23);
            this.btnBaselineSpline.TabIndex = 37;
            this.btnBaselineSpline.Text = "Baseline Spline...";
            this.btnBaselineSpline.UseVisualStyleBackColor = true;
            this.btnBaselineSpline.Click += new System.EventHandler(this.btnBaselineSpline_Click);
            // 
            // SmoothSpectrumButton
            // 
            this.SmoothSpectrumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SmoothSpectrumButton.Location = new System.Drawing.Point(140, 137);
            this.SmoothSpectrumButton.Name = "SmoothSpectrumButton";
            this.SmoothSpectrumButton.Size = new System.Drawing.Size(71, 23);
            this.SmoothSpectrumButton.TabIndex = 43;
            this.SmoothSpectrumButton.Text = "Smooth";
            this.SmoothSpectrumButton.UseVisualStyleBackColor = true;
            this.SmoothSpectrumButton.Click += new System.EventHandler(this.SmoothSpectrumButton_Click);
            // 
            // LoadTable
            // 
            this.LoadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadTable.Location = new System.Drawing.Point(140, 91);
            this.LoadTable.Name = "LoadTable";
            this.LoadTable.Size = new System.Drawing.Size(71, 23);
            this.LoadTable.TabIndex = 42;
            this.LoadTable.Text = "Load Table";
            this.LoadTable.UseVisualStyleBackColor = true;
            this.LoadTable.Click += new System.EventHandler(this.LoadTable_Click);
            // 
            // SaveTable
            // 
            this.SaveTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTable.Location = new System.Drawing.Point(140, 68);
            this.SaveTable.Name = "SaveTable";
            this.SaveTable.Size = new System.Drawing.Size(71, 23);
            this.SaveTable.TabIndex = 41;
            this.SaveTable.Text = "Save Table";
            this.SaveTable.UseVisualStyleBackColor = true;
            this.SaveTable.Click += new System.EventHandler(this.SaveTable_Click);
            // 
            // btnBaselineMin
            // 
            this.btnBaselineMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaselineMin.Location = new System.Drawing.Point(6, 114);
            this.btnBaselineMin.Name = "btnBaselineMin";
            this.btnBaselineMin.Size = new System.Drawing.Size(131, 23);
            this.btnBaselineMin.TabIndex = 40;
            this.btnBaselineMin.Text = "Baseline Min";
            this.btnBaselineMin.UseVisualStyleBackColor = true;
            this.btnBaselineMin.Click += new System.EventHandler(this.btnBaselineMin_Click);
            // 
            // btnAverageSpectra
            // 
            this.btnAverageSpectra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAverageSpectra.Location = new System.Drawing.Point(140, 160);
            this.btnAverageSpectra.Name = "btnAverageSpectra";
            this.btnAverageSpectra.Size = new System.Drawing.Size(71, 23);
            this.btnAverageSpectra.TabIndex = 39;
            this.btnAverageSpectra.Text = "Average";
            this.btnAverageSpectra.UseVisualStyleBackColor = true;
            this.btnAverageSpectra.Click += new System.EventHandler(this.AverageSpectrums_Click);
            // 
            // AddSpectrumSeries
            // 
            this.AddSpectrumSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSpectrumSeries.Location = new System.Drawing.Point(60, 91);
            this.AddSpectrumSeries.Name = "AddSpectrumSeries";
            this.AddSpectrumSeries.Size = new System.Drawing.Size(77, 23);
            this.AddSpectrumSeries.TabIndex = 38;
            this.AddSpectrumSeries.Text = "Load Series";
            this.AddSpectrumSeries.UseVisualStyleBackColor = true;
            this.AddSpectrumSeries.Click += new System.EventHandler(this.AddSpectrumSeries_Click);
            // 
            // AddSpectrum
            // 
            this.AddSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSpectrum.Location = new System.Drawing.Point(6, 91);
            this.AddSpectrum.Name = "AddSpectrum";
            this.AddSpectrum.Size = new System.Drawing.Size(53, 23);
            this.AddSpectrum.TabIndex = 37;
            this.AddSpectrum.Text = "Load";
            this.AddSpectrum.UseVisualStyleBackColor = true;
            this.AddSpectrum.Click += new System.EventHandler(this.AddSpectrum_Click);
            // 
            // SaveCurrentSpectrum
            // 
            this.SaveCurrentSpectrum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCurrentSpectrum.Location = new System.Drawing.Point(6, 68);
            this.SaveCurrentSpectrum.Name = "SaveCurrentSpectrum";
            this.SaveCurrentSpectrum.Size = new System.Drawing.Size(53, 23);
            this.SaveCurrentSpectrum.TabIndex = 36;
            this.SaveCurrentSpectrum.Text = "Save";
            this.SaveCurrentSpectrum.UseVisualStyleBackColor = true;
            this.SaveCurrentSpectrum.Click += new System.EventHandler(this.SaveCurrentSpectrum_Click);
            // 
            // chkEnableCalibratedYAxis
            // 
            this.chkEnableCalibratedYAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnableCalibratedYAxis.AutoSize = true;
            this.chkEnableCalibratedYAxis.Enabled = false;
            this.chkEnableCalibratedYAxis.Location = new System.Drawing.Point(468, 79);
            this.chkEnableCalibratedYAxis.Name = "chkEnableCalibratedYAxis";
            this.chkEnableCalibratedYAxis.Size = new System.Drawing.Size(180, 17);
            this.chkEnableCalibratedYAxis.TabIndex = 56;
            this.chkEnableCalibratedYAxis.Text = "Y-axis is Calibrated μW/(cm²*nm)";
            this.chkEnableCalibratedYAxis.UseVisualStyleBackColor = true;
            this.chkEnableCalibratedYAxis.CheckedChanged += new System.EventHandler(this.chkEnableCalibratedYAxis_CheckedChanged);
            // 
            // AddNewSpectrumDialog
            // 
            this.AddNewSpectrumDialog.FileName = "openFileDialog1";
            // 
            // mMainChart
            // 
            this.mMainChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.mMainChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.mMainChart.BorderlineWidth = 2;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Moccasin;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisX.Title = "Wavelength, nm";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX2.ScrollBar.BackColor = System.Drawing.Color.Moccasin;
            chartArea1.AxisX2.ScrollBar.ButtonColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Moccasin;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.DarkOrange;
            chartArea1.AxisY.Title = "Intensity";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.CursorY.Interval = 0.001D;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 95F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.Y = 5F;
            this.mMainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mMainChart.Legends.Add(legend1);
            this.mMainChart.Location = new System.Drawing.Point(3, 27);
            this.mMainChart.Name = "mMainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mMainChart.Series.Add(series1);
            this.mMainChart.Size = new System.Drawing.Size(456, 527);
            this.mMainChart.TabIndex = 37;
            this.mMainChart.Text = "chart1";
            // 
            // Recognition
            // 
            this.Recognition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Recognition.Controls.Add(this.DataProcessing);
            this.Recognition.Controls.Add(this.ExperimentPage);
            this.Recognition.Controls.Add(this.tabPage1);
            this.Recognition.Location = new System.Drawing.Point(465, 98);
            this.Recognition.Name = "Recognition";
            this.Recognition.SelectedIndex = 0;
            this.Recognition.Size = new System.Drawing.Size(254, 456);
            this.Recognition.TabIndex = 38;
            // 
            // DataProcessing
            // 
            this.DataProcessing.Controls.Add(this.gbMeasurementResultsGroup);
            this.DataProcessing.Location = new System.Drawing.Point(4, 22);
            this.DataProcessing.Name = "DataProcessing";
            this.DataProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.DataProcessing.Size = new System.Drawing.Size(246, 430);
            this.DataProcessing.TabIndex = 1;
            this.DataProcessing.Text = "Data Processing";
            this.DataProcessing.UseVisualStyleBackColor = true;
            // 
            // ExperimentPage
            // 
            this.ExperimentPage.Controls.Add(this.label27);
            this.ExperimentPage.Controls.Add(this.chkAskMeBeforeNewExp);
            this.ExperimentPage.Controls.Add(this.IntegrationParameters);
            this.ExperimentPage.Controls.Add(this.MeasureControl);
            this.ExperimentPage.Controls.Add(this.label7);
            this.ExperimentPage.Controls.Add(this.LaserDelay);
            this.ExperimentPage.Controls.Add(this.label3);
            this.ExperimentPage.Controls.Add(this.label4);
            this.ExperimentPage.Controls.Add(this.label9);
            this.ExperimentPage.Controls.Add(this.label5);
            this.ExperimentPage.Controls.Add(this.DetectionThreshold);
            this.ExperimentPage.Controls.Add(this.LaserWidth);
            this.ExperimentPage.Controls.Add(this.label8);
            this.ExperimentPage.Controls.Add(this.label6);
            this.ExperimentPage.Controls.Add(this.IntegrationTime);
            this.ExperimentPage.Location = new System.Drawing.Point(4, 22);
            this.ExperimentPage.Name = "ExperimentPage";
            this.ExperimentPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExperimentPage.Size = new System.Drawing.Size(246, 430);
            this.ExperimentPage.TabIndex = 0;
            this.ExperimentPage.Text = "Experiment";
            this.ExperimentPage.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.Location = new System.Drawing.Point(12, 243);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(221, 37);
            this.label27.TabIndex = 32;
            this.label27.Text = "¹ - Lag of laser power supply - time between triggering pulse and laser emission";
            // 
            // chkAskMeBeforeNewExp
            // 
            this.chkAskMeBeforeNewExp.AutoSize = true;
            this.chkAskMeBeforeNewExp.Location = new System.Drawing.Point(12, 279);
            this.chkAskMeBeforeNewExp.Name = "chkAskMeBeforeNewExp";
            this.chkAskMeBeforeNewExp.Size = new System.Drawing.Size(200, 17);
            this.chkAskMeBeforeNewExp.TabIndex = 29;
            this.chkAskMeBeforeNewExp.Text = "Ask me before begin new experiment";
            this.chkAskMeBeforeNewExp.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.nudRightAccuracyLimit);
            this.tabPage1.Controls.Add(this.chkShowPeakInfo);
            this.tabPage1.Controls.Add(this.btnShowLineBase);
            this.tabPage1.Controls.Add(this.btnCalculateIntergralRatios);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.nudLeftAccuracyLimit);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.btnAll);
            this.tabPage1.Controls.Add(this.btnMolecules);
            this.tabPage1.Controls.Add(this.lblLinesInBase);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.chkEuropium);
            this.tabPage1.Controls.Add(this.chkNeptunium);
            this.tabPage1.Controls.Add(this.chkUranium);
            this.tabPage1.Controls.Add(this.chkProtactinium);
            this.tabPage1.Controls.Add(this.chkThorium);
            this.tabPage1.Controls.Add(this.chkLutetium);
            this.tabPage1.Controls.Add(this.chkYtterbium);
            this.tabPage1.Controls.Add(this.chkThulium);
            this.tabPage1.Controls.Add(this.chkErbium);
            this.tabPage1.Controls.Add(this.chkHolmium);
            this.tabPage1.Controls.Add(this.chkDysprosium);
            this.tabPage1.Controls.Add(this.chkTerbium);
            this.tabPage1.Controls.Add(this.chkGadolinium);
            this.tabPage1.Controls.Add(this.chkSamarium);
            this.tabPage1.Controls.Add(this.chkPromethium);
            this.tabPage1.Controls.Add(this.chkNeodymium);
            this.tabPage1.Controls.Add(this.chkPraseodymium);
            this.tabPage1.Controls.Add(this.chkCerium);
            this.tabPage1.Controls.Add(this.chkRadon);
            this.tabPage1.Controls.Add(this.chkAstatium);
            this.tabPage1.Controls.Add(this.chkPolonium);
            this.tabPage1.Controls.Add(this.chkBismuthum);
            this.tabPage1.Controls.Add(this.chkPlumbum);
            this.tabPage1.Controls.Add(this.chkThallium);
            this.tabPage1.Controls.Add(this.chkHydrargyrum);
            this.tabPage1.Controls.Add(this.chkAurum);
            this.tabPage1.Controls.Add(this.chkPlatinum);
            this.tabPage1.Controls.Add(this.chkIridium);
            this.tabPage1.Controls.Add(this.chkOsmium);
            this.tabPage1.Controls.Add(this.chkRhenium);
            this.tabPage1.Controls.Add(this.chkWolframium);
            this.tabPage1.Controls.Add(this.chkTantalum);
            this.tabPage1.Controls.Add(this.chkHafnium);
            this.tabPage1.Controls.Add(this.chkLanthanum);
            this.tabPage1.Controls.Add(this.chkBarium);
            this.tabPage1.Controls.Add(this.chkCaesium);
            this.tabPage1.Controls.Add(this.chkXenon);
            this.tabPage1.Controls.Add(this.chkIodum);
            this.tabPage1.Controls.Add(this.chkTellurium);
            this.tabPage1.Controls.Add(this.chkStibium);
            this.tabPage1.Controls.Add(this.chkStannum);
            this.tabPage1.Controls.Add(this.chkIndium);
            this.tabPage1.Controls.Add(this.chkCadmium);
            this.tabPage1.Controls.Add(this.chkArgentum);
            this.tabPage1.Controls.Add(this.chkPalladium);
            this.tabPage1.Controls.Add(this.chkRhodium);
            this.tabPage1.Controls.Add(this.chkRuthenium);
            this.tabPage1.Controls.Add(this.chkTechnetium);
            this.tabPage1.Controls.Add(this.chkMolybdaenum);
            this.tabPage1.Controls.Add(this.chkNiobium);
            this.tabPage1.Controls.Add(this.chkZirconium);
            this.tabPage1.Controls.Add(this.chkYttrium);
            this.tabPage1.Controls.Add(this.chkStrontium);
            this.tabPage1.Controls.Add(this.chkRubidium);
            this.tabPage1.Controls.Add(this.chkKrypton);
            this.tabPage1.Controls.Add(this.chkBromum);
            this.tabPage1.Controls.Add(this.chkSelenium);
            this.tabPage1.Controls.Add(this.chkArsenicum);
            this.tabPage1.Controls.Add(this.chkGermanium);
            this.tabPage1.Controls.Add(this.chkGallium);
            this.tabPage1.Controls.Add(this.chkZincum);
            this.tabPage1.Controls.Add(this.chkCuprum);
            this.tabPage1.Controls.Add(this.chkNiccolum);
            this.tabPage1.Controls.Add(this.chkCobaltum);
            this.tabPage1.Controls.Add(this.chkFerrum);
            this.tabPage1.Controls.Add(this.chkManganum);
            this.tabPage1.Controls.Add(this.chkChromium);
            this.tabPage1.Controls.Add(this.chkVanadium);
            this.tabPage1.Controls.Add(this.chkTitanium);
            this.tabPage1.Controls.Add(this.chkScandium);
            this.tabPage1.Controls.Add(this.chkCalcium);
            this.tabPage1.Controls.Add(this.chkKalium);
            this.tabPage1.Controls.Add(this.chkArgon);
            this.tabPage1.Controls.Add(this.chkChlorum);
            this.tabPage1.Controls.Add(this.chkSulfur);
            this.tabPage1.Controls.Add(this.chkPhosphorus);
            this.tabPage1.Controls.Add(this.chkSilicium);
            this.tabPage1.Controls.Add(this.chkAluminium);
            this.tabPage1.Controls.Add(this.chkMagnesium);
            this.tabPage1.Controls.Add(this.chkNatrium);
            this.tabPage1.Controls.Add(this.chkNeon);
            this.tabPage1.Controls.Add(this.chkFluorum);
            this.tabPage1.Controls.Add(this.chkOxygenium);
            this.tabPage1.Controls.Add(this.chkNitrogenium);
            this.tabPage1.Controls.Add(this.chkCarboneum);
            this.tabPage1.Controls.Add(this.chkBorum);
            this.tabPage1.Controls.Add(this.chkBerillium);
            this.tabPage1.Controls.Add(this.chkLithium);
            this.tabPage1.Controls.Add(this.chkHelium);
            this.tabPage1.Controls.Add(this.chkHydrogen);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnClearRecognized);
            this.tabPage1.Controls.Add(this.nudPeakThreshold);
            this.tabPage1.Controls.Add(this.RecognizedLinesCountText);
            this.tabPage1.Controls.Add(this.btnRecognizeLines);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 430);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Identification";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1, 395);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(230, 13);
            this.label24.TabIndex = 188;
            this.label24.Text = "¹ - Offset relative of real wavelengths from NIST";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(150, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 16);
            this.label23.TabIndex = 187;
            this.label23.Text = "+";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(70, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 16);
            this.label22.TabIndex = 186;
            this.label22.Text = "-";
            // 
            // nudRightAccuracyLimit
            // 
            this.nudRightAccuracyLimit.DecimalPlaces = 3;
            this.nudRightAccuracyLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRightAccuracyLimit.Location = new System.Drawing.Point(169, 57);
            this.nudRightAccuracyLimit.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudRightAccuracyLimit.Name = "nudRightAccuracyLimit";
            this.nudRightAccuracyLimit.Size = new System.Drawing.Size(49, 20);
            this.nudRightAccuracyLimit.TabIndex = 185;
            this.nudRightAccuracyLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // chkShowPeakInfo
            // 
            this.chkShowPeakInfo.AutoSize = true;
            this.chkShowPeakInfo.Location = new System.Drawing.Point(8, 81);
            this.chkShowPeakInfo.Name = "chkShowPeakInfo";
            this.chkShowPeakInfo.Size = new System.Drawing.Size(151, 17);
            this.chkShowPeakInfo.TabIndex = 184;
            this.chkShowPeakInfo.Text = "Show Additional Peak Info";
            this.chkShowPeakInfo.UseVisualStyleBackColor = true;
            this.chkShowPeakInfo.CheckedChanged += new System.EventHandler(this.chkShowPeakInfo_CheckedChanged);
            // 
            // btnShowLineBase
            // 
            this.btnShowLineBase.Location = new System.Drawing.Point(98, 345);
            this.btnShowLineBase.Name = "btnShowLineBase";
            this.btnShowLineBase.Size = new System.Drawing.Size(144, 23);
            this.btnShowLineBase.TabIndex = 183;
            this.btnShowLineBase.Text = "Show Line Base";
            this.btnShowLineBase.UseVisualStyleBackColor = true;
            this.btnShowLineBase.Click += new System.EventHandler(this.btnShowLineBase_Click);
            // 
            // btnCalculateIntergralRatios
            // 
            this.btnCalculateIntergralRatios.Location = new System.Drawing.Point(98, 368);
            this.btnCalculateIntergralRatios.Name = "btnCalculateIntergralRatios";
            this.btnCalculateIntergralRatios.Size = new System.Drawing.Size(144, 23);
            this.btnCalculateIntergralRatios.TabIndex = 182;
            this.btnCalculateIntergralRatios.Text = "Calculate Integral Ratios";
            this.btnCalculateIntergralRatios.UseVisualStyleBackColor = true;
            this.btnCalculateIntergralRatios.Click += new System.EventHandler(this.btnCalculateIntergralRatios_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(221, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 181;
            this.label20.Text = "nm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(221, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 180;
            this.label19.Text = "a.u.";
            // 
            // nudLeftAccuracyLimit
            // 
            this.nudLeftAccuracyLimit.DecimalPlaces = 3;
            this.nudLeftAccuracyLimit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLeftAccuracyLimit.Location = new System.Drawing.Point(85, 57);
            this.nudLeftAccuracyLimit.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLeftAccuracyLimit.Name = "nudLeftAccuracyLimit";
            this.nudLeftAccuracyLimit.Size = new System.Drawing.Size(56, 20);
            this.nudLeftAccuracyLimit.TabIndex = 179;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 178;
            this.label18.Text = "Accuracy ¹";
            // 
            // btnAll
            // 
            this.btnAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAll.Location = new System.Drawing.Point(109, 6);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(61, 23);
            this.btnAll.TabIndex = 176;
            this.btnAll.Text = "Check All";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAll.UseCompatibleTextRendering = true;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.CheckedChanged += new System.EventHandler(this.btnAll_CheckedChanged);
            // 
            // btnMolecules
            // 
            this.btnMolecules.Location = new System.Drawing.Point(172, 6);
            this.btnMolecules.Name = "btnMolecules";
            this.btnMolecules.Size = new System.Drawing.Size(68, 23);
            this.btnMolecules.TabIndex = 175;
            this.btnMolecules.Text = "Molecules";
            this.btnMolecules.UseVisualStyleBackColor = true;
            this.btnMolecules.Click += new System.EventHandler(this.btnMolecules_Click);
            // 
            // lblLinesInBase
            // 
            this.lblLinesInBase.AutoSize = true;
            this.lblLinesInBase.Location = new System.Drawing.Point(104, 118);
            this.lblLinesInBase.Name = "lblLinesInBase";
            this.lblLinesInBase.Size = new System.Drawing.Size(16, 13);
            this.lblLinesInBase.TabIndex = 174;
            this.lblLinesInBase.Text = "0 ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 173;
            this.label16.Text = "Lines in base: ";
            // 
            // chkEuropium
            // 
            this.chkEuropium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEuropium.BackColor = System.Drawing.Color.Transparent;
            this.chkEuropium.Enabled = false;
            this.chkEuropium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkEuropium.Location = new System.Drawing.Point(121, 320);
            this.chkEuropium.Name = "chkEuropium";
            this.chkEuropium.Size = new System.Drawing.Size(25, 24);
            this.chkEuropium.TabIndex = 172;
            this.chkEuropium.Text = "Eu";
            this.chkEuropium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkEuropium.UseCompatibleTextRendering = true;
            this.chkEuropium.UseVisualStyleBackColor = false;
            // 
            // chkNeptunium
            // 
            this.chkNeptunium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNeptunium.BackColor = System.Drawing.Color.Transparent;
            this.chkNeptunium.Enabled = false;
            this.chkNeptunium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNeptunium.Location = new System.Drawing.Point(73, 367);
            this.chkNeptunium.Name = "chkNeptunium";
            this.chkNeptunium.Size = new System.Drawing.Size(25, 24);
            this.chkNeptunium.TabIndex = 161;
            this.chkNeptunium.Text = "Np";
            this.chkNeptunium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNeptunium.UseCompatibleTextRendering = true;
            this.chkNeptunium.UseVisualStyleBackColor = false;
            // 
            // chkUranium
            // 
            this.chkUranium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUranium.BackColor = System.Drawing.Color.Transparent;
            this.chkUranium.Enabled = false;
            this.chkUranium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkUranium.Location = new System.Drawing.Point(49, 367);
            this.chkUranium.Name = "chkUranium";
            this.chkUranium.Size = new System.Drawing.Size(25, 24);
            this.chkUranium.TabIndex = 160;
            this.chkUranium.Text = "U";
            this.chkUranium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUranium.UseVisualStyleBackColor = false;
            // 
            // chkProtactinium
            // 
            this.chkProtactinium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkProtactinium.BackColor = System.Drawing.Color.Transparent;
            this.chkProtactinium.Enabled = false;
            this.chkProtactinium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkProtactinium.Location = new System.Drawing.Point(25, 367);
            this.chkProtactinium.Name = "chkProtactinium";
            this.chkProtactinium.Size = new System.Drawing.Size(25, 24);
            this.chkProtactinium.TabIndex = 159;
            this.chkProtactinium.Text = "Pa";
            this.chkProtactinium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkProtactinium.UseVisualStyleBackColor = false;
            // 
            // chkThorium
            // 
            this.chkThorium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkThorium.BackColor = System.Drawing.Color.Transparent;
            this.chkThorium.Enabled = false;
            this.chkThorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkThorium.Location = new System.Drawing.Point(1, 367);
            this.chkThorium.Name = "chkThorium";
            this.chkThorium.Size = new System.Drawing.Size(25, 24);
            this.chkThorium.TabIndex = 158;
            this.chkThorium.Text = "Th";
            this.chkThorium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkThorium.UseVisualStyleBackColor = false;
            // 
            // chkLutetium
            // 
            this.chkLutetium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLutetium.BackColor = System.Drawing.Color.Transparent;
            this.chkLutetium.Enabled = false;
            this.chkLutetium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLutetium.Location = new System.Drawing.Point(73, 344);
            this.chkLutetium.Name = "chkLutetium";
            this.chkLutetium.Size = new System.Drawing.Size(25, 24);
            this.chkLutetium.TabIndex = 156;
            this.chkLutetium.Text = "Lu";
            this.chkLutetium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLutetium.UseVisualStyleBackColor = false;
            // 
            // chkYtterbium
            // 
            this.chkYtterbium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkYtterbium.BackColor = System.Drawing.Color.Transparent;
            this.chkYtterbium.Enabled = false;
            this.chkYtterbium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkYtterbium.Location = new System.Drawing.Point(49, 344);
            this.chkYtterbium.Name = "chkYtterbium";
            this.chkYtterbium.Size = new System.Drawing.Size(25, 24);
            this.chkYtterbium.TabIndex = 155;
            this.chkYtterbium.Text = "Yb";
            this.chkYtterbium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYtterbium.UseVisualStyleBackColor = false;
            // 
            // chkThulium
            // 
            this.chkThulium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkThulium.BackColor = System.Drawing.Color.Transparent;
            this.chkThulium.Enabled = false;
            this.chkThulium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkThulium.Location = new System.Drawing.Point(25, 344);
            this.chkThulium.Name = "chkThulium";
            this.chkThulium.Size = new System.Drawing.Size(25, 24);
            this.chkThulium.TabIndex = 154;
            this.chkThulium.Text = "Tm";
            this.chkThulium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkThulium.UseCompatibleTextRendering = true;
            this.chkThulium.UseVisualStyleBackColor = false;
            // 
            // chkErbium
            // 
            this.chkErbium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkErbium.BackColor = System.Drawing.Color.Transparent;
            this.chkErbium.Enabled = false;
            this.chkErbium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkErbium.Location = new System.Drawing.Point(1, 344);
            this.chkErbium.Name = "chkErbium";
            this.chkErbium.Size = new System.Drawing.Size(25, 24);
            this.chkErbium.TabIndex = 153;
            this.chkErbium.Text = "Er";
            this.chkErbium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkErbium.UseVisualStyleBackColor = false;
            // 
            // chkHolmium
            // 
            this.chkHolmium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHolmium.BackColor = System.Drawing.Color.Transparent;
            this.chkHolmium.Enabled = false;
            this.chkHolmium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHolmium.Location = new System.Drawing.Point(217, 320);
            this.chkHolmium.Name = "chkHolmium";
            this.chkHolmium.Size = new System.Drawing.Size(25, 24);
            this.chkHolmium.TabIndex = 152;
            this.chkHolmium.Text = "Ho";
            this.chkHolmium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHolmium.UseVisualStyleBackColor = false;
            // 
            // chkDysprosium
            // 
            this.chkDysprosium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDysprosium.BackColor = System.Drawing.Color.Transparent;
            this.chkDysprosium.Enabled = false;
            this.chkDysprosium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkDysprosium.Location = new System.Drawing.Point(193, 320);
            this.chkDysprosium.Name = "chkDysprosium";
            this.chkDysprosium.Size = new System.Drawing.Size(25, 24);
            this.chkDysprosium.TabIndex = 151;
            this.chkDysprosium.Text = "Dy";
            this.chkDysprosium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDysprosium.UseVisualStyleBackColor = false;
            // 
            // chkTerbium
            // 
            this.chkTerbium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTerbium.BackColor = System.Drawing.Color.Transparent;
            this.chkTerbium.Enabled = false;
            this.chkTerbium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTerbium.Location = new System.Drawing.Point(169, 320);
            this.chkTerbium.Name = "chkTerbium";
            this.chkTerbium.Size = new System.Drawing.Size(25, 24);
            this.chkTerbium.TabIndex = 150;
            this.chkTerbium.Text = "Tb";
            this.chkTerbium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTerbium.UseVisualStyleBackColor = false;
            // 
            // chkGadolinium
            // 
            this.chkGadolinium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGadolinium.BackColor = System.Drawing.Color.Transparent;
            this.chkGadolinium.Enabled = false;
            this.chkGadolinium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkGadolinium.Location = new System.Drawing.Point(145, 320);
            this.chkGadolinium.Name = "chkGadolinium";
            this.chkGadolinium.Size = new System.Drawing.Size(25, 24);
            this.chkGadolinium.TabIndex = 149;
            this.chkGadolinium.Text = "Gd";
            this.chkGadolinium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGadolinium.UseCompatibleTextRendering = true;
            this.chkGadolinium.UseVisualStyleBackColor = false;
            // 
            // chkSamarium
            // 
            this.chkSamarium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSamarium.BackColor = System.Drawing.Color.Transparent;
            this.chkSamarium.Enabled = false;
            this.chkSamarium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSamarium.Location = new System.Drawing.Point(97, 320);
            this.chkSamarium.Name = "chkSamarium";
            this.chkSamarium.Size = new System.Drawing.Size(25, 24);
            this.chkSamarium.TabIndex = 148;
            this.chkSamarium.Text = "Sm";
            this.chkSamarium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSamarium.UseCompatibleTextRendering = true;
            this.chkSamarium.UseVisualStyleBackColor = false;
            // 
            // chkPromethium
            // 
            this.chkPromethium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPromethium.BackColor = System.Drawing.Color.Transparent;
            this.chkPromethium.Enabled = false;
            this.chkPromethium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPromethium.Location = new System.Drawing.Point(73, 320);
            this.chkPromethium.Name = "chkPromethium";
            this.chkPromethium.Size = new System.Drawing.Size(25, 24);
            this.chkPromethium.TabIndex = 147;
            this.chkPromethium.Text = "Pm";
            this.chkPromethium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPromethium.UseCompatibleTextRendering = true;
            this.chkPromethium.UseVisualStyleBackColor = false;
            // 
            // chkNeodymium
            // 
            this.chkNeodymium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNeodymium.BackColor = System.Drawing.Color.Transparent;
            this.chkNeodymium.Enabled = false;
            this.chkNeodymium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNeodymium.Location = new System.Drawing.Point(49, 320);
            this.chkNeodymium.Name = "chkNeodymium";
            this.chkNeodymium.Size = new System.Drawing.Size(25, 24);
            this.chkNeodymium.TabIndex = 146;
            this.chkNeodymium.Text = "Nd";
            this.chkNeodymium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNeodymium.UseVisualStyleBackColor = false;
            // 
            // chkPraseodymium
            // 
            this.chkPraseodymium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPraseodymium.BackColor = System.Drawing.Color.Transparent;
            this.chkPraseodymium.Enabled = false;
            this.chkPraseodymium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPraseodymium.Location = new System.Drawing.Point(25, 320);
            this.chkPraseodymium.Name = "chkPraseodymium";
            this.chkPraseodymium.Size = new System.Drawing.Size(25, 24);
            this.chkPraseodymium.TabIndex = 145;
            this.chkPraseodymium.Text = "Pr";
            this.chkPraseodymium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPraseodymium.UseVisualStyleBackColor = false;
            // 
            // chkCerium
            // 
            this.chkCerium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCerium.BackColor = System.Drawing.Color.Transparent;
            this.chkCerium.Enabled = false;
            this.chkCerium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCerium.Location = new System.Drawing.Point(1, 320);
            this.chkCerium.Name = "chkCerium";
            this.chkCerium.Size = new System.Drawing.Size(25, 24);
            this.chkCerium.TabIndex = 144;
            this.chkCerium.Text = "Ce";
            this.chkCerium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCerium.UseVisualStyleBackColor = false;
            // 
            // chkRadon
            // 
            this.chkRadon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRadon.BackColor = System.Drawing.Color.Transparent;
            this.chkRadon.Enabled = false;
            this.chkRadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRadon.Location = new System.Drawing.Point(169, 296);
            this.chkRadon.Name = "chkRadon";
            this.chkRadon.Size = new System.Drawing.Size(25, 24);
            this.chkRadon.TabIndex = 132;
            this.chkRadon.Text = "Rn";
            this.chkRadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRadon.UseVisualStyleBackColor = false;
            // 
            // chkAstatium
            // 
            this.chkAstatium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAstatium.BackColor = System.Drawing.Color.Transparent;
            this.chkAstatium.Enabled = false;
            this.chkAstatium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkAstatium.Location = new System.Drawing.Point(145, 296);
            this.chkAstatium.Name = "chkAstatium";
            this.chkAstatium.Size = new System.Drawing.Size(25, 24);
            this.chkAstatium.TabIndex = 131;
            this.chkAstatium.Text = "At";
            this.chkAstatium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAstatium.UseVisualStyleBackColor = false;
            // 
            // chkPolonium
            // 
            this.chkPolonium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPolonium.BackColor = System.Drawing.Color.Transparent;
            this.chkPolonium.Enabled = false;
            this.chkPolonium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPolonium.Location = new System.Drawing.Point(121, 296);
            this.chkPolonium.Name = "chkPolonium";
            this.chkPolonium.Size = new System.Drawing.Size(25, 24);
            this.chkPolonium.TabIndex = 130;
            this.chkPolonium.Text = "Po";
            this.chkPolonium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPolonium.UseVisualStyleBackColor = false;
            // 
            // chkBismuthum
            // 
            this.chkBismuthum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBismuthum.BackColor = System.Drawing.Color.Transparent;
            this.chkBismuthum.Enabled = false;
            this.chkBismuthum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBismuthum.Location = new System.Drawing.Point(97, 296);
            this.chkBismuthum.Name = "chkBismuthum";
            this.chkBismuthum.Size = new System.Drawing.Size(25, 24);
            this.chkBismuthum.TabIndex = 129;
            this.chkBismuthum.Text = "Bi";
            this.chkBismuthum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBismuthum.UseVisualStyleBackColor = false;
            // 
            // chkPlumbum
            // 
            this.chkPlumbum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPlumbum.BackColor = System.Drawing.Color.Transparent;
            this.chkPlumbum.Enabled = false;
            this.chkPlumbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPlumbum.Location = new System.Drawing.Point(73, 296);
            this.chkPlumbum.Name = "chkPlumbum";
            this.chkPlumbum.Size = new System.Drawing.Size(25, 24);
            this.chkPlumbum.TabIndex = 128;
            this.chkPlumbum.Text = "Pb";
            this.chkPlumbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPlumbum.UseVisualStyleBackColor = false;
            // 
            // chkThallium
            // 
            this.chkThallium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkThallium.BackColor = System.Drawing.Color.Transparent;
            this.chkThallium.Enabled = false;
            this.chkThallium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkThallium.Location = new System.Drawing.Point(49, 296);
            this.chkThallium.Name = "chkThallium";
            this.chkThallium.Size = new System.Drawing.Size(25, 24);
            this.chkThallium.TabIndex = 127;
            this.chkThallium.Text = "Tl";
            this.chkThallium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkThallium.UseVisualStyleBackColor = false;
            // 
            // chkHydrargyrum
            // 
            this.chkHydrargyrum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHydrargyrum.BackColor = System.Drawing.Color.Transparent;
            this.chkHydrargyrum.Enabled = false;
            this.chkHydrargyrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHydrargyrum.Location = new System.Drawing.Point(25, 296);
            this.chkHydrargyrum.Name = "chkHydrargyrum";
            this.chkHydrargyrum.Size = new System.Drawing.Size(25, 24);
            this.chkHydrargyrum.TabIndex = 126;
            this.chkHydrargyrum.Text = "Hg";
            this.chkHydrargyrum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHydrargyrum.UseCompatibleTextRendering = true;
            this.chkHydrargyrum.UseVisualStyleBackColor = false;
            // 
            // chkAurum
            // 
            this.chkAurum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAurum.BackColor = System.Drawing.Color.Transparent;
            this.chkAurum.Enabled = false;
            this.chkAurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkAurum.Location = new System.Drawing.Point(1, 296);
            this.chkAurum.Name = "chkAurum";
            this.chkAurum.Size = new System.Drawing.Size(25, 24);
            this.chkAurum.TabIndex = 125;
            this.chkAurum.Text = "Au";
            this.chkAurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAurum.UseVisualStyleBackColor = false;
            // 
            // chkPlatinum
            // 
            this.chkPlatinum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPlatinum.BackColor = System.Drawing.Color.Transparent;
            this.chkPlatinum.Enabled = false;
            this.chkPlatinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPlatinum.Location = new System.Drawing.Point(217, 273);
            this.chkPlatinum.Name = "chkPlatinum";
            this.chkPlatinum.Size = new System.Drawing.Size(25, 24);
            this.chkPlatinum.TabIndex = 124;
            this.chkPlatinum.Text = "Pt";
            this.chkPlatinum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPlatinum.UseVisualStyleBackColor = false;
            // 
            // chkIridium
            // 
            this.chkIridium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIridium.BackColor = System.Drawing.Color.Transparent;
            this.chkIridium.Enabled = false;
            this.chkIridium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIridium.Location = new System.Drawing.Point(193, 273);
            this.chkIridium.Name = "chkIridium";
            this.chkIridium.Size = new System.Drawing.Size(25, 24);
            this.chkIridium.TabIndex = 123;
            this.chkIridium.Text = "Ir";
            this.chkIridium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIridium.UseVisualStyleBackColor = false;
            // 
            // chkOsmium
            // 
            this.chkOsmium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOsmium.BackColor = System.Drawing.Color.Transparent;
            this.chkOsmium.Enabled = false;
            this.chkOsmium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkOsmium.Location = new System.Drawing.Point(169, 273);
            this.chkOsmium.Name = "chkOsmium";
            this.chkOsmium.Size = new System.Drawing.Size(25, 24);
            this.chkOsmium.TabIndex = 122;
            this.chkOsmium.Text = "Os";
            this.chkOsmium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOsmium.UseVisualStyleBackColor = false;
            // 
            // chkRhenium
            // 
            this.chkRhenium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRhenium.BackColor = System.Drawing.Color.Transparent;
            this.chkRhenium.Enabled = false;
            this.chkRhenium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRhenium.Location = new System.Drawing.Point(145, 273);
            this.chkRhenium.Name = "chkRhenium";
            this.chkRhenium.Size = new System.Drawing.Size(25, 24);
            this.chkRhenium.TabIndex = 121;
            this.chkRhenium.Text = "Re";
            this.chkRhenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRhenium.UseCompatibleTextRendering = true;
            this.chkRhenium.UseVisualStyleBackColor = false;
            // 
            // chkWolframium
            // 
            this.chkWolframium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkWolframium.BackColor = System.Drawing.Color.Transparent;
            this.chkWolframium.Enabled = false;
            this.chkWolframium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkWolframium.Location = new System.Drawing.Point(121, 273);
            this.chkWolframium.Name = "chkWolframium";
            this.chkWolframium.Size = new System.Drawing.Size(25, 24);
            this.chkWolframium.TabIndex = 120;
            this.chkWolframium.Text = "W";
            this.chkWolframium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkWolframium.UseCompatibleTextRendering = true;
            this.chkWolframium.UseVisualStyleBackColor = false;
            // 
            // chkTantalum
            // 
            this.chkTantalum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTantalum.BackColor = System.Drawing.Color.Transparent;
            this.chkTantalum.Enabled = false;
            this.chkTantalum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTantalum.Location = new System.Drawing.Point(97, 273);
            this.chkTantalum.Name = "chkTantalum";
            this.chkTantalum.Size = new System.Drawing.Size(25, 24);
            this.chkTantalum.TabIndex = 119;
            this.chkTantalum.Text = "Ta";
            this.chkTantalum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTantalum.UseVisualStyleBackColor = false;
            // 
            // chkHafnium
            // 
            this.chkHafnium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHafnium.BackColor = System.Drawing.Color.Transparent;
            this.chkHafnium.Enabled = false;
            this.chkHafnium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHafnium.Location = new System.Drawing.Point(73, 273);
            this.chkHafnium.Name = "chkHafnium";
            this.chkHafnium.Size = new System.Drawing.Size(25, 24);
            this.chkHafnium.TabIndex = 118;
            this.chkHafnium.Text = "Hf";
            this.chkHafnium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHafnium.UseVisualStyleBackColor = false;
            // 
            // chkLanthanum
            // 
            this.chkLanthanum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLanthanum.BackColor = System.Drawing.Color.Transparent;
            this.chkLanthanum.Enabled = false;
            this.chkLanthanum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLanthanum.Location = new System.Drawing.Point(49, 273);
            this.chkLanthanum.Name = "chkLanthanum";
            this.chkLanthanum.Size = new System.Drawing.Size(25, 24);
            this.chkLanthanum.TabIndex = 117;
            this.chkLanthanum.Text = "La";
            this.chkLanthanum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLanthanum.UseVisualStyleBackColor = false;
            // 
            // chkBarium
            // 
            this.chkBarium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBarium.BackColor = System.Drawing.Color.Transparent;
            this.chkBarium.Enabled = false;
            this.chkBarium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBarium.Location = new System.Drawing.Point(25, 273);
            this.chkBarium.Name = "chkBarium";
            this.chkBarium.Size = new System.Drawing.Size(25, 24);
            this.chkBarium.TabIndex = 116;
            this.chkBarium.Text = "Ba";
            this.chkBarium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBarium.UseVisualStyleBackColor = false;
            // 
            // chkCaesium
            // 
            this.chkCaesium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCaesium.BackColor = System.Drawing.Color.Transparent;
            this.chkCaesium.Enabled = false;
            this.chkCaesium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCaesium.Location = new System.Drawing.Point(1, 273);
            this.chkCaesium.Name = "chkCaesium";
            this.chkCaesium.Size = new System.Drawing.Size(25, 24);
            this.chkCaesium.TabIndex = 115;
            this.chkCaesium.Text = "Cs";
            this.chkCaesium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCaesium.UseVisualStyleBackColor = false;
            // 
            // chkXenon
            // 
            this.chkXenon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkXenon.BackColor = System.Drawing.Color.Transparent;
            this.chkXenon.Enabled = false;
            this.chkXenon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkXenon.Location = new System.Drawing.Point(169, 250);
            this.chkXenon.Name = "chkXenon";
            this.chkXenon.Size = new System.Drawing.Size(25, 24);
            this.chkXenon.TabIndex = 114;
            this.chkXenon.Text = "Xe";
            this.chkXenon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkXenon.UseVisualStyleBackColor = false;
            // 
            // chkIodum
            // 
            this.chkIodum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIodum.BackColor = System.Drawing.Color.Transparent;
            this.chkIodum.Enabled = false;
            this.chkIodum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIodum.Location = new System.Drawing.Point(145, 250);
            this.chkIodum.Name = "chkIodum";
            this.chkIodum.Size = new System.Drawing.Size(25, 24);
            this.chkIodum.TabIndex = 113;
            this.chkIodum.Text = "I";
            this.chkIodum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIodum.UseVisualStyleBackColor = false;
            // 
            // chkTellurium
            // 
            this.chkTellurium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTellurium.BackColor = System.Drawing.Color.Transparent;
            this.chkTellurium.Enabled = false;
            this.chkTellurium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTellurium.Location = new System.Drawing.Point(121, 250);
            this.chkTellurium.Name = "chkTellurium";
            this.chkTellurium.Size = new System.Drawing.Size(25, 24);
            this.chkTellurium.TabIndex = 112;
            this.chkTellurium.Text = "Te";
            this.chkTellurium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTellurium.UseVisualStyleBackColor = false;
            // 
            // chkStibium
            // 
            this.chkStibium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStibium.BackColor = System.Drawing.Color.Transparent;
            this.chkStibium.Enabled = false;
            this.chkStibium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkStibium.Location = new System.Drawing.Point(97, 250);
            this.chkStibium.Name = "chkStibium";
            this.chkStibium.Size = new System.Drawing.Size(25, 24);
            this.chkStibium.TabIndex = 111;
            this.chkStibium.Text = "Sb";
            this.chkStibium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStibium.UseVisualStyleBackColor = false;
            // 
            // chkStannum
            // 
            this.chkStannum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStannum.BackColor = System.Drawing.Color.Transparent;
            this.chkStannum.Enabled = false;
            this.chkStannum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkStannum.Location = new System.Drawing.Point(73, 250);
            this.chkStannum.Name = "chkStannum";
            this.chkStannum.Size = new System.Drawing.Size(25, 24);
            this.chkStannum.TabIndex = 110;
            this.chkStannum.Text = "Sn";
            this.chkStannum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStannum.UseVisualStyleBackColor = false;
            // 
            // chkIndium
            // 
            this.chkIndium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkIndium.BackColor = System.Drawing.Color.Transparent;
            this.chkIndium.Enabled = false;
            this.chkIndium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkIndium.Location = new System.Drawing.Point(49, 250);
            this.chkIndium.Name = "chkIndium";
            this.chkIndium.Size = new System.Drawing.Size(25, 24);
            this.chkIndium.TabIndex = 109;
            this.chkIndium.Text = "In";
            this.chkIndium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIndium.UseVisualStyleBackColor = false;
            // 
            // chkCadmium
            // 
            this.chkCadmium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCadmium.BackColor = System.Drawing.Color.Transparent;
            this.chkCadmium.Enabled = false;
            this.chkCadmium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCadmium.Location = new System.Drawing.Point(25, 250);
            this.chkCadmium.Name = "chkCadmium";
            this.chkCadmium.Size = new System.Drawing.Size(25, 24);
            this.chkCadmium.TabIndex = 108;
            this.chkCadmium.Text = "Cd";
            this.chkCadmium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCadmium.UseCompatibleTextRendering = true;
            this.chkCadmium.UseVisualStyleBackColor = false;
            // 
            // chkArgentum
            // 
            this.chkArgentum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkArgentum.BackColor = System.Drawing.Color.Transparent;
            this.chkArgentum.Enabled = false;
            this.chkArgentum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkArgentum.Location = new System.Drawing.Point(1, 250);
            this.chkArgentum.Name = "chkArgentum";
            this.chkArgentum.Size = new System.Drawing.Size(25, 24);
            this.chkArgentum.TabIndex = 107;
            this.chkArgentum.Text = "Ag";
            this.chkArgentum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkArgentum.UseVisualStyleBackColor = false;
            // 
            // chkPalladium
            // 
            this.chkPalladium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPalladium.BackColor = System.Drawing.Color.Transparent;
            this.chkPalladium.Enabled = false;
            this.chkPalladium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPalladium.Location = new System.Drawing.Point(217, 227);
            this.chkPalladium.Name = "chkPalladium";
            this.chkPalladium.Size = new System.Drawing.Size(25, 24);
            this.chkPalladium.TabIndex = 106;
            this.chkPalladium.Text = "Pd";
            this.chkPalladium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPalladium.UseVisualStyleBackColor = false;
            // 
            // chkRhodium
            // 
            this.chkRhodium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRhodium.BackColor = System.Drawing.Color.Transparent;
            this.chkRhodium.Enabled = false;
            this.chkRhodium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRhodium.Location = new System.Drawing.Point(193, 227);
            this.chkRhodium.Name = "chkRhodium";
            this.chkRhodium.Size = new System.Drawing.Size(25, 24);
            this.chkRhodium.TabIndex = 105;
            this.chkRhodium.Text = "Rh";
            this.chkRhodium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRhodium.UseVisualStyleBackColor = false;
            // 
            // chkRuthenium
            // 
            this.chkRuthenium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRuthenium.BackColor = System.Drawing.Color.Transparent;
            this.chkRuthenium.Enabled = false;
            this.chkRuthenium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRuthenium.Location = new System.Drawing.Point(169, 227);
            this.chkRuthenium.Name = "chkRuthenium";
            this.chkRuthenium.Size = new System.Drawing.Size(25, 24);
            this.chkRuthenium.TabIndex = 104;
            this.chkRuthenium.Text = "Ru";
            this.chkRuthenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRuthenium.UseVisualStyleBackColor = false;
            // 
            // chkTechnetium
            // 
            this.chkTechnetium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTechnetium.BackColor = System.Drawing.Color.Transparent;
            this.chkTechnetium.Enabled = false;
            this.chkTechnetium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTechnetium.Location = new System.Drawing.Point(145, 227);
            this.chkTechnetium.Name = "chkTechnetium";
            this.chkTechnetium.Size = new System.Drawing.Size(25, 24);
            this.chkTechnetium.TabIndex = 103;
            this.chkTechnetium.Text = "Tc";
            this.chkTechnetium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTechnetium.UseCompatibleTextRendering = true;
            this.chkTechnetium.UseVisualStyleBackColor = false;
            // 
            // chkMolybdaenum
            // 
            this.chkMolybdaenum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMolybdaenum.BackColor = System.Drawing.Color.Transparent;
            this.chkMolybdaenum.Enabled = false;
            this.chkMolybdaenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMolybdaenum.Location = new System.Drawing.Point(121, 227);
            this.chkMolybdaenum.Name = "chkMolybdaenum";
            this.chkMolybdaenum.Size = new System.Drawing.Size(25, 24);
            this.chkMolybdaenum.TabIndex = 102;
            this.chkMolybdaenum.Text = "Mo";
            this.chkMolybdaenum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMolybdaenum.UseCompatibleTextRendering = true;
            this.chkMolybdaenum.UseVisualStyleBackColor = false;
            // 
            // chkNiobium
            // 
            this.chkNiobium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNiobium.BackColor = System.Drawing.Color.Transparent;
            this.chkNiobium.Enabled = false;
            this.chkNiobium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNiobium.Location = new System.Drawing.Point(97, 227);
            this.chkNiobium.Name = "chkNiobium";
            this.chkNiobium.Size = new System.Drawing.Size(25, 24);
            this.chkNiobium.TabIndex = 101;
            this.chkNiobium.Text = "Nb";
            this.chkNiobium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNiobium.UseVisualStyleBackColor = false;
            // 
            // chkZirconium
            // 
            this.chkZirconium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkZirconium.BackColor = System.Drawing.Color.Transparent;
            this.chkZirconium.Enabled = false;
            this.chkZirconium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkZirconium.Location = new System.Drawing.Point(73, 227);
            this.chkZirconium.Name = "chkZirconium";
            this.chkZirconium.Size = new System.Drawing.Size(25, 24);
            this.chkZirconium.TabIndex = 100;
            this.chkZirconium.Text = "Zr";
            this.chkZirconium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkZirconium.UseVisualStyleBackColor = false;
            // 
            // chkYttrium
            // 
            this.chkYttrium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkYttrium.BackColor = System.Drawing.Color.Transparent;
            this.chkYttrium.Enabled = false;
            this.chkYttrium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkYttrium.Location = new System.Drawing.Point(49, 227);
            this.chkYttrium.Name = "chkYttrium";
            this.chkYttrium.Size = new System.Drawing.Size(25, 24);
            this.chkYttrium.TabIndex = 99;
            this.chkYttrium.Text = "Y";
            this.chkYttrium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkYttrium.UseVisualStyleBackColor = false;
            // 
            // chkStrontium
            // 
            this.chkStrontium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStrontium.BackColor = System.Drawing.Color.Transparent;
            this.chkStrontium.Enabled = false;
            this.chkStrontium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkStrontium.Location = new System.Drawing.Point(25, 227);
            this.chkStrontium.Name = "chkStrontium";
            this.chkStrontium.Size = new System.Drawing.Size(25, 24);
            this.chkStrontium.TabIndex = 98;
            this.chkStrontium.Text = "Sr";
            this.chkStrontium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStrontium.UseVisualStyleBackColor = false;
            // 
            // chkRubidium
            // 
            this.chkRubidium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRubidium.BackColor = System.Drawing.Color.Transparent;
            this.chkRubidium.Enabled = false;
            this.chkRubidium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkRubidium.Location = new System.Drawing.Point(1, 227);
            this.chkRubidium.Name = "chkRubidium";
            this.chkRubidium.Size = new System.Drawing.Size(25, 24);
            this.chkRubidium.TabIndex = 97;
            this.chkRubidium.Text = "Rb";
            this.chkRubidium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRubidium.UseVisualStyleBackColor = false;
            // 
            // chkKrypton
            // 
            this.chkKrypton.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKrypton.BackColor = System.Drawing.Color.Transparent;
            this.chkKrypton.Enabled = false;
            this.chkKrypton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkKrypton.Location = new System.Drawing.Point(169, 204);
            this.chkKrypton.Name = "chkKrypton";
            this.chkKrypton.Size = new System.Drawing.Size(25, 24);
            this.chkKrypton.TabIndex = 96;
            this.chkKrypton.Text = "Kr";
            this.chkKrypton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKrypton.UseVisualStyleBackColor = false;
            // 
            // chkBromum
            // 
            this.chkBromum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBromum.BackColor = System.Drawing.Color.Transparent;
            this.chkBromum.Enabled = false;
            this.chkBromum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBromum.Location = new System.Drawing.Point(145, 204);
            this.chkBromum.Name = "chkBromum";
            this.chkBromum.Size = new System.Drawing.Size(25, 24);
            this.chkBromum.TabIndex = 95;
            this.chkBromum.Text = "Br";
            this.chkBromum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBromum.UseVisualStyleBackColor = false;
            // 
            // chkSelenium
            // 
            this.chkSelenium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSelenium.BackColor = System.Drawing.Color.Transparent;
            this.chkSelenium.Enabled = false;
            this.chkSelenium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSelenium.Location = new System.Drawing.Point(121, 204);
            this.chkSelenium.Name = "chkSelenium";
            this.chkSelenium.Size = new System.Drawing.Size(25, 24);
            this.chkSelenium.TabIndex = 94;
            this.chkSelenium.Text = "Se";
            this.chkSelenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSelenium.UseVisualStyleBackColor = false;
            // 
            // chkArsenicum
            // 
            this.chkArsenicum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkArsenicum.BackColor = System.Drawing.Color.Transparent;
            this.chkArsenicum.Enabled = false;
            this.chkArsenicum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkArsenicum.Location = new System.Drawing.Point(97, 204);
            this.chkArsenicum.Name = "chkArsenicum";
            this.chkArsenicum.Size = new System.Drawing.Size(25, 24);
            this.chkArsenicum.TabIndex = 93;
            this.chkArsenicum.Text = "As";
            this.chkArsenicum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkArsenicum.UseVisualStyleBackColor = false;
            // 
            // chkGermanium
            // 
            this.chkGermanium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGermanium.BackColor = System.Drawing.Color.Transparent;
            this.chkGermanium.Enabled = false;
            this.chkGermanium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkGermanium.Location = new System.Drawing.Point(73, 204);
            this.chkGermanium.Name = "chkGermanium";
            this.chkGermanium.Size = new System.Drawing.Size(25, 24);
            this.chkGermanium.TabIndex = 92;
            this.chkGermanium.Text = "Ge";
            this.chkGermanium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGermanium.UseVisualStyleBackColor = false;
            // 
            // chkGallium
            // 
            this.chkGallium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGallium.BackColor = System.Drawing.Color.Transparent;
            this.chkGallium.Enabled = false;
            this.chkGallium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkGallium.Location = new System.Drawing.Point(49, 204);
            this.chkGallium.Name = "chkGallium";
            this.chkGallium.Size = new System.Drawing.Size(25, 24);
            this.chkGallium.TabIndex = 91;
            this.chkGallium.Text = "Ga";
            this.chkGallium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGallium.UseVisualStyleBackColor = false;
            // 
            // chkZincum
            // 
            this.chkZincum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkZincum.BackColor = System.Drawing.Color.Transparent;
            this.chkZincum.Enabled = false;
            this.chkZincum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkZincum.Location = new System.Drawing.Point(25, 204);
            this.chkZincum.Name = "chkZincum";
            this.chkZincum.Size = new System.Drawing.Size(25, 24);
            this.chkZincum.TabIndex = 90;
            this.chkZincum.Text = "Zn";
            this.chkZincum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkZincum.UseCompatibleTextRendering = true;
            this.chkZincum.UseVisualStyleBackColor = false;
            // 
            // chkCuprum
            // 
            this.chkCuprum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCuprum.BackColor = System.Drawing.Color.Transparent;
            this.chkCuprum.Enabled = false;
            this.chkCuprum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCuprum.Location = new System.Drawing.Point(1, 204);
            this.chkCuprum.Name = "chkCuprum";
            this.chkCuprum.Size = new System.Drawing.Size(25, 24);
            this.chkCuprum.TabIndex = 89;
            this.chkCuprum.Text = "Cu";
            this.chkCuprum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCuprum.UseVisualStyleBackColor = false;
            // 
            // chkNiccolum
            // 
            this.chkNiccolum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNiccolum.BackColor = System.Drawing.Color.Transparent;
            this.chkNiccolum.Enabled = false;
            this.chkNiccolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNiccolum.Location = new System.Drawing.Point(217, 181);
            this.chkNiccolum.Name = "chkNiccolum";
            this.chkNiccolum.Size = new System.Drawing.Size(25, 24);
            this.chkNiccolum.TabIndex = 88;
            this.chkNiccolum.Text = "Ni";
            this.chkNiccolum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNiccolum.UseVisualStyleBackColor = false;
            // 
            // chkCobaltum
            // 
            this.chkCobaltum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCobaltum.BackColor = System.Drawing.Color.Transparent;
            this.chkCobaltum.Enabled = false;
            this.chkCobaltum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCobaltum.Location = new System.Drawing.Point(193, 181);
            this.chkCobaltum.Name = "chkCobaltum";
            this.chkCobaltum.Size = new System.Drawing.Size(25, 24);
            this.chkCobaltum.TabIndex = 87;
            this.chkCobaltum.Text = "Co";
            this.chkCobaltum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCobaltum.UseVisualStyleBackColor = false;
            // 
            // chkFerrum
            // 
            this.chkFerrum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFerrum.BackColor = System.Drawing.Color.Transparent;
            this.chkFerrum.Enabled = false;
            this.chkFerrum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFerrum.Location = new System.Drawing.Point(169, 181);
            this.chkFerrum.Name = "chkFerrum";
            this.chkFerrum.Size = new System.Drawing.Size(25, 24);
            this.chkFerrum.TabIndex = 86;
            this.chkFerrum.Text = "Fe";
            this.chkFerrum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFerrum.UseVisualStyleBackColor = false;
            // 
            // chkManganum
            // 
            this.chkManganum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkManganum.BackColor = System.Drawing.Color.Transparent;
            this.chkManganum.Enabled = false;
            this.chkManganum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkManganum.Location = new System.Drawing.Point(145, 181);
            this.chkManganum.Name = "chkManganum";
            this.chkManganum.Size = new System.Drawing.Size(25, 24);
            this.chkManganum.TabIndex = 85;
            this.chkManganum.Text = "Mn";
            this.chkManganum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkManganum.UseCompatibleTextRendering = true;
            this.chkManganum.UseVisualStyleBackColor = false;
            // 
            // chkChromium
            // 
            this.chkChromium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChromium.BackColor = System.Drawing.Color.Transparent;
            this.chkChromium.Enabled = false;
            this.chkChromium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkChromium.Location = new System.Drawing.Point(121, 181);
            this.chkChromium.Name = "chkChromium";
            this.chkChromium.Size = new System.Drawing.Size(25, 24);
            this.chkChromium.TabIndex = 84;
            this.chkChromium.Text = "Cr";
            this.chkChromium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChromium.UseVisualStyleBackColor = false;
            // 
            // chkVanadium
            // 
            this.chkVanadium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkVanadium.BackColor = System.Drawing.Color.Transparent;
            this.chkVanadium.Enabled = false;
            this.chkVanadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkVanadium.Location = new System.Drawing.Point(97, 181);
            this.chkVanadium.Name = "chkVanadium";
            this.chkVanadium.Size = new System.Drawing.Size(25, 24);
            this.chkVanadium.TabIndex = 83;
            this.chkVanadium.Text = "V";
            this.chkVanadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkVanadium.UseVisualStyleBackColor = false;
            // 
            // chkTitanium
            // 
            this.chkTitanium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTitanium.BackColor = System.Drawing.Color.Transparent;
            this.chkTitanium.Enabled = false;
            this.chkTitanium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkTitanium.Location = new System.Drawing.Point(73, 181);
            this.chkTitanium.Name = "chkTitanium";
            this.chkTitanium.Size = new System.Drawing.Size(25, 24);
            this.chkTitanium.TabIndex = 82;
            this.chkTitanium.Text = "Ti";
            this.chkTitanium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTitanium.UseVisualStyleBackColor = false;
            // 
            // chkScandium
            // 
            this.chkScandium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkScandium.BackColor = System.Drawing.Color.Transparent;
            this.chkScandium.Enabled = false;
            this.chkScandium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkScandium.Location = new System.Drawing.Point(49, 181);
            this.chkScandium.Name = "chkScandium";
            this.chkScandium.Size = new System.Drawing.Size(25, 24);
            this.chkScandium.TabIndex = 81;
            this.chkScandium.Text = "Sc";
            this.chkScandium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkScandium.UseVisualStyleBackColor = false;
            // 
            // chkCalcium
            // 
            this.chkCalcium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCalcium.BackColor = System.Drawing.Color.Transparent;
            this.chkCalcium.Enabled = false;
            this.chkCalcium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCalcium.Location = new System.Drawing.Point(25, 181);
            this.chkCalcium.Name = "chkCalcium";
            this.chkCalcium.Size = new System.Drawing.Size(25, 24);
            this.chkCalcium.TabIndex = 80;
            this.chkCalcium.Text = "Ca";
            this.chkCalcium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCalcium.UseVisualStyleBackColor = false;
            // 
            // chkKalium
            // 
            this.chkKalium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKalium.BackColor = System.Drawing.Color.Transparent;
            this.chkKalium.Enabled = false;
            this.chkKalium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkKalium.Location = new System.Drawing.Point(1, 181);
            this.chkKalium.Name = "chkKalium";
            this.chkKalium.Size = new System.Drawing.Size(25, 24);
            this.chkKalium.TabIndex = 79;
            this.chkKalium.Text = "K";
            this.chkKalium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKalium.UseVisualStyleBackColor = false;
            // 
            // chkArgon
            // 
            this.chkArgon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkArgon.BackColor = System.Drawing.Color.Transparent;
            this.chkArgon.Enabled = false;
            this.chkArgon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkArgon.Location = new System.Drawing.Point(169, 158);
            this.chkArgon.Name = "chkArgon";
            this.chkArgon.Size = new System.Drawing.Size(25, 24);
            this.chkArgon.TabIndex = 78;
            this.chkArgon.Text = "Ar";
            this.chkArgon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkArgon.UseVisualStyleBackColor = false;
            // 
            // chkChlorum
            // 
            this.chkChlorum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChlorum.BackColor = System.Drawing.Color.Transparent;
            this.chkChlorum.Enabled = false;
            this.chkChlorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkChlorum.Location = new System.Drawing.Point(145, 158);
            this.chkChlorum.Name = "chkChlorum";
            this.chkChlorum.Size = new System.Drawing.Size(25, 24);
            this.chkChlorum.TabIndex = 77;
            this.chkChlorum.Text = "Cl";
            this.chkChlorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChlorum.UseVisualStyleBackColor = false;
            // 
            // chkSulfur
            // 
            this.chkSulfur.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSulfur.BackColor = System.Drawing.Color.Transparent;
            this.chkSulfur.Enabled = false;
            this.chkSulfur.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSulfur.Location = new System.Drawing.Point(121, 158);
            this.chkSulfur.Name = "chkSulfur";
            this.chkSulfur.Size = new System.Drawing.Size(25, 24);
            this.chkSulfur.TabIndex = 76;
            this.chkSulfur.Text = "S";
            this.chkSulfur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSulfur.UseVisualStyleBackColor = false;
            // 
            // chkPhosphorus
            // 
            this.chkPhosphorus.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPhosphorus.BackColor = System.Drawing.Color.Transparent;
            this.chkPhosphorus.Enabled = false;
            this.chkPhosphorus.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkPhosphorus.Location = new System.Drawing.Point(97, 158);
            this.chkPhosphorus.Name = "chkPhosphorus";
            this.chkPhosphorus.Size = new System.Drawing.Size(25, 24);
            this.chkPhosphorus.TabIndex = 75;
            this.chkPhosphorus.Text = "P";
            this.chkPhosphorus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPhosphorus.UseVisualStyleBackColor = false;
            // 
            // chkSilicium
            // 
            this.chkSilicium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSilicium.BackColor = System.Drawing.Color.Transparent;
            this.chkSilicium.Enabled = false;
            this.chkSilicium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkSilicium.Location = new System.Drawing.Point(73, 158);
            this.chkSilicium.Name = "chkSilicium";
            this.chkSilicium.Size = new System.Drawing.Size(25, 24);
            this.chkSilicium.TabIndex = 74;
            this.chkSilicium.Text = "Si";
            this.chkSilicium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSilicium.UseVisualStyleBackColor = false;
            // 
            // chkAluminium
            // 
            this.chkAluminium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAluminium.BackColor = System.Drawing.Color.Transparent;
            this.chkAluminium.Enabled = false;
            this.chkAluminium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkAluminium.Location = new System.Drawing.Point(49, 158);
            this.chkAluminium.Name = "chkAluminium";
            this.chkAluminium.Size = new System.Drawing.Size(25, 24);
            this.chkAluminium.TabIndex = 73;
            this.chkAluminium.Text = "Al";
            this.chkAluminium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAluminium.UseVisualStyleBackColor = false;
            // 
            // chkMagnesium
            // 
            this.chkMagnesium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMagnesium.BackColor = System.Drawing.Color.Transparent;
            this.chkMagnesium.Enabled = false;
            this.chkMagnesium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkMagnesium.Location = new System.Drawing.Point(25, 158);
            this.chkMagnesium.Name = "chkMagnesium";
            this.chkMagnesium.Size = new System.Drawing.Size(25, 24);
            this.chkMagnesium.TabIndex = 72;
            this.chkMagnesium.Text = "Mg";
            this.chkMagnesium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMagnesium.UseCompatibleTextRendering = true;
            this.chkMagnesium.UseVisualStyleBackColor = false;
            // 
            // chkNatrium
            // 
            this.chkNatrium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNatrium.BackColor = System.Drawing.Color.Transparent;
            this.chkNatrium.Enabled = false;
            this.chkNatrium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNatrium.Location = new System.Drawing.Point(1, 158);
            this.chkNatrium.Name = "chkNatrium";
            this.chkNatrium.Size = new System.Drawing.Size(25, 24);
            this.chkNatrium.TabIndex = 71;
            this.chkNatrium.Text = "Na";
            this.chkNatrium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNatrium.UseVisualStyleBackColor = false;
            // 
            // chkNeon
            // 
            this.chkNeon.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNeon.BackColor = System.Drawing.Color.Transparent;
            this.chkNeon.Enabled = false;
            this.chkNeon.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNeon.Location = new System.Drawing.Point(169, 135);
            this.chkNeon.Name = "chkNeon";
            this.chkNeon.Size = new System.Drawing.Size(25, 24);
            this.chkNeon.TabIndex = 70;
            this.chkNeon.Text = "Ne";
            this.chkNeon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNeon.UseVisualStyleBackColor = false;
            // 
            // chkFluorum
            // 
            this.chkFluorum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFluorum.BackColor = System.Drawing.Color.Transparent;
            this.chkFluorum.Enabled = false;
            this.chkFluorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkFluorum.Location = new System.Drawing.Point(145, 135);
            this.chkFluorum.Name = "chkFluorum";
            this.chkFluorum.Size = new System.Drawing.Size(25, 24);
            this.chkFluorum.TabIndex = 69;
            this.chkFluorum.Text = "F";
            this.chkFluorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFluorum.UseVisualStyleBackColor = false;
            // 
            // chkOxygenium
            // 
            this.chkOxygenium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOxygenium.BackColor = System.Drawing.Color.Transparent;
            this.chkOxygenium.Enabled = false;
            this.chkOxygenium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkOxygenium.Location = new System.Drawing.Point(121, 135);
            this.chkOxygenium.Name = "chkOxygenium";
            this.chkOxygenium.Size = new System.Drawing.Size(25, 24);
            this.chkOxygenium.TabIndex = 68;
            this.chkOxygenium.Text = "O";
            this.chkOxygenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOxygenium.UseVisualStyleBackColor = false;
            // 
            // chkNitrogenium
            // 
            this.chkNitrogenium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNitrogenium.BackColor = System.Drawing.Color.Transparent;
            this.chkNitrogenium.Enabled = false;
            this.chkNitrogenium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkNitrogenium.Location = new System.Drawing.Point(97, 135);
            this.chkNitrogenium.Name = "chkNitrogenium";
            this.chkNitrogenium.Size = new System.Drawing.Size(25, 24);
            this.chkNitrogenium.TabIndex = 67;
            this.chkNitrogenium.Text = "N";
            this.chkNitrogenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNitrogenium.UseVisualStyleBackColor = false;
            // 
            // chkCarboneum
            // 
            this.chkCarboneum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCarboneum.BackColor = System.Drawing.Color.Transparent;
            this.chkCarboneum.Enabled = false;
            this.chkCarboneum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkCarboneum.Location = new System.Drawing.Point(73, 135);
            this.chkCarboneum.Name = "chkCarboneum";
            this.chkCarboneum.Size = new System.Drawing.Size(25, 24);
            this.chkCarboneum.TabIndex = 66;
            this.chkCarboneum.Text = "C";
            this.chkCarboneum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCarboneum.UseVisualStyleBackColor = false;
            // 
            // chkBorum
            // 
            this.chkBorum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBorum.BackColor = System.Drawing.Color.Transparent;
            this.chkBorum.Enabled = false;
            this.chkBorum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBorum.Location = new System.Drawing.Point(49, 135);
            this.chkBorum.Name = "chkBorum";
            this.chkBorum.Size = new System.Drawing.Size(25, 24);
            this.chkBorum.TabIndex = 65;
            this.chkBorum.Text = "B";
            this.chkBorum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBorum.UseVisualStyleBackColor = false;
            // 
            // chkBerillium
            // 
            this.chkBerillium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBerillium.BackColor = System.Drawing.Color.Transparent;
            this.chkBerillium.Enabled = false;
            this.chkBerillium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBerillium.Location = new System.Drawing.Point(25, 135);
            this.chkBerillium.Name = "chkBerillium";
            this.chkBerillium.Size = new System.Drawing.Size(25, 24);
            this.chkBerillium.TabIndex = 64;
            this.chkBerillium.Text = "Be";
            this.chkBerillium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBerillium.UseVisualStyleBackColor = false;
            // 
            // chkLithium
            // 
            this.chkLithium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLithium.BackColor = System.Drawing.Color.Transparent;
            this.chkLithium.Enabled = false;
            this.chkLithium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLithium.Location = new System.Drawing.Point(1, 135);
            this.chkLithium.Name = "chkLithium";
            this.chkLithium.Size = new System.Drawing.Size(25, 24);
            this.chkLithium.TabIndex = 63;
            this.chkLithium.Text = "Li";
            this.chkLithium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLithium.UseVisualStyleBackColor = false;
            // 
            // chkHelium
            // 
            this.chkHelium.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHelium.BackColor = System.Drawing.Color.Transparent;
            this.chkHelium.Enabled = false;
            this.chkHelium.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHelium.Location = new System.Drawing.Point(169, 112);
            this.chkHelium.Name = "chkHelium";
            this.chkHelium.Size = new System.Drawing.Size(25, 24);
            this.chkHelium.TabIndex = 62;
            this.chkHelium.Text = "He";
            this.chkHelium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHelium.UseVisualStyleBackColor = false;
            // 
            // chkHydrogen
            // 
            this.chkHydrogen.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHydrogen.BackColor = System.Drawing.Color.Transparent;
            this.chkHydrogen.Enabled = false;
            this.chkHydrogen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkHydrogen.Location = new System.Drawing.Point(1, 112);
            this.chkHydrogen.Name = "chkHydrogen";
            this.chkHydrogen.Size = new System.Drawing.Size(25, 24);
            this.chkHydrogen.TabIndex = 61;
            this.chkHydrogen.Text = "H";
            this.chkHydrogen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHydrogen.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Peak Detection Threshold";
            // 
            // btnClearRecognized
            // 
            this.btnClearRecognized.Location = new System.Drawing.Point(64, 6);
            this.btnClearRecognized.Name = "btnClearRecognized";
            this.btnClearRecognized.Size = new System.Drawing.Size(43, 23);
            this.btnClearRecognized.TabIndex = 57;
            this.btnClearRecognized.Text = "Clear";
            this.btnClearRecognized.UseVisualStyleBackColor = true;
            this.btnClearRecognized.Click += new System.EventHandler(this.btnClearRecognized_Click);
            // 
            // nudPeakThreshold
            // 
            this.nudPeakThreshold.DecimalPlaces = 4;
            this.nudPeakThreshold.Location = new System.Drawing.Point(143, 34);
            this.nudPeakThreshold.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPeakThreshold.Name = "nudPeakThreshold";
            this.nudPeakThreshold.Size = new System.Drawing.Size(75, 20);
            this.nudPeakThreshold.TabIndex = 56;
            this.nudPeakThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RecognizedLinesCountText
            // 
            this.RecognizedLinesCountText.AutoSize = true;
            this.RecognizedLinesCountText.BackColor = System.Drawing.Color.Transparent;
            this.RecognizedLinesCountText.Location = new System.Drawing.Point(0, 410);
            this.RecognizedLinesCountText.Name = "RecognizedLinesCountText";
            this.RecognizedLinesCountText.Size = new System.Drawing.Size(59, 13);
            this.RecognizedLinesCountText.TabIndex = 55;
            this.RecognizedLinesCountText.Text = "0 Identified";
            // 
            // btnRecognizeLines
            // 
            this.btnRecognizeLines.Location = new System.Drawing.Point(6, 6);
            this.btnRecognizeLines.Name = "btnRecognizeLines";
            this.btnRecognizeLines.Size = new System.Drawing.Size(56, 23);
            this.btnRecognizeLines.TabIndex = 53;
            this.btnRecognizeLines.Text = "Identify";
            this.btnRecognizeLines.UseVisualStyleBackColor = true;
            this.btnRecognizeLines.Click += new System.EventHandler(this.btnRecognizeLines_Click_1);
            // 
            // bgwIdentification
            // 
            this.bgwIdentification.WorkerReportsProgress = true;
            this.bgwIdentification.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwIdentification_DoWork);
            // 
            // btnSaveCalibrated
            // 
            this.btnSaveCalibrated.Location = new System.Drawing.Point(101, 300);
            this.btnSaveCalibrated.Name = "btnSaveCalibrated";
            this.btnSaveCalibrated.Size = new System.Drawing.Size(107, 22);
            this.btnSaveCalibrated.TabIndex = 62;
            this.btnSaveCalibrated.Text = "Save Calibtated";
            this.btnSaveCalibrated.UseVisualStyleBackColor = true;
            this.btnSaveCalibrated.Click += new System.EventHandler(this.btnSaveCalibrated_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 582);
            this.Controls.Add(this.chkEnableCalibratedYAxis);
            this.Controls.Add(this.Recognition);
            this.Controls.Add(this.mMainChart);
            this.Controls.Add(this.SpectrumLinear);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudMeasurementNumber);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.DetectedMaterial);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(714, 411);
            this.Name = "MainWindow";
            this.Text = "Automated LIBS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragEnter);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegrationBeginDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaserWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectionThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntegrationEndDelay)).EndInit();
            this.IntegrationParameters.ResumeLayout(false);
            this.IntegrationParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerSupplyLag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementCount)).EndInit();
            this.MeasureControl.ResumeLayout(false);
            this.MeasureControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasurementNumber)).EndInit();
            this.gbMeasurementResultsGroup.ResumeLayout(false);
            this.gbMeasurementResultsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRemoveNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumCountToRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpectrumNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMainChart)).EndInit();
            this.Recognition.ResumeLayout(false);
            this.DataProcessing.ResumeLayout(false);
            this.ExperimentPage.ResumeLayout(false);
            this.ExperimentPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRightAccuracyLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLeftAccuracyLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeakThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label DetectedMaterial;
        private System.Windows.Forms.ToolStripMenuItem spectrometerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.NumericUpDown nudIntegrationBeginDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LaserDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LaserWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown IntegrationTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown DetectionThreshold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudIntegrationEndDelay;
        private System.Windows.Forms.GroupBox IntegrationParameters;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown MeasurementCount;
        private System.Windows.Forms.RadioButton SeriesMeasure;
        private System.Windows.Forms.RadioButton SingleMeasure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button StartPause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.GroupBox MeasureControl;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectionInfoToolStripMenuItem;
        private System.Windows.Forms.Label SpectrumLinear;
        private System.Windows.Forms.Button SaveSpectrums;
        private System.Windows.Forms.Button ClearSpectrums;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbMeasurementResultsGroup;
        private System.Windows.Forms.FolderBrowserDialog SaveSpectrumDialog;
        private System.Windows.Forms.Button SaveCurrentSpectrum;
        private System.Windows.Forms.SaveFileDialog dlgSaveCurrentSpectrum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudMeasurementNumber;
        private System.Windows.Forms.Button Normalize;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddSpectrumSeries;
        private System.Windows.Forms.Button AddSpectrum;
        private System.Windows.Forms.OpenFileDialog AddNewSpectrumDialog;
        private System.Windows.Forms.FolderBrowserDialog AddSpectrumSeriesDialog;
        private System.Windows.Forms.Button btnAverageSpectra;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.Button btnBaselineMin;
        private System.Windows.Forms.Button LoadTable;
        private System.Windows.Forms.Button SaveTable;
        private System.Windows.Forms.Button SmoothSpectrumButton;
        private System.Windows.Forms.Button btnBaselineSpline;
        private System.Windows.Forms.ToolStripMenuItem plasmaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart mMainChart;
        private System.Windows.Forms.TabControl Recognition;
        private System.Windows.Forms.TabPage ExperimentPage;
        private System.Windows.Forms.TabPage DataProcessing;
        private System.Windows.Forms.Button RemoveSaturatedSpectrums;
        private System.Windows.Forms.NumericUpDown nudSpectrumNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown SpectrumCountToRemove;
        private System.Windows.Forms.Button btnRemoveFirstNSpectrums;
        private System.Windows.Forms.Button btnRemoveWithMaxLower;
        private System.Windows.Forms.NumericUpDown nudLowerLimit;
        private System.Windows.Forms.Label lblSpectrumCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar pbExperimentProgress;
        private System.ComponentModel.BackgroundWorker bgwIdentification;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudLeftAccuracyLimit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox btnAll;
        private System.Windows.Forms.Button btnMolecules;
        private System.Windows.Forms.Label lblLinesInBase;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkEuropium;
        private System.Windows.Forms.CheckBox chkNeptunium;
        private System.Windows.Forms.CheckBox chkUranium;
        private System.Windows.Forms.CheckBox chkProtactinium;
        private System.Windows.Forms.CheckBox chkThorium;
        private System.Windows.Forms.CheckBox chkLutetium;
        private System.Windows.Forms.CheckBox chkYtterbium;
        private System.Windows.Forms.CheckBox chkThulium;
        private System.Windows.Forms.CheckBox chkErbium;
        private System.Windows.Forms.CheckBox chkHolmium;
        private System.Windows.Forms.CheckBox chkDysprosium;
        private System.Windows.Forms.CheckBox chkTerbium;
        private System.Windows.Forms.CheckBox chkGadolinium;
        private System.Windows.Forms.CheckBox chkSamarium;
        private System.Windows.Forms.CheckBox chkPromethium;
        private System.Windows.Forms.CheckBox chkNeodymium;
        private System.Windows.Forms.CheckBox chkPraseodymium;
        private System.Windows.Forms.CheckBox chkCerium;
        private System.Windows.Forms.CheckBox chkRadon;
        private System.Windows.Forms.CheckBox chkAstatium;
        private System.Windows.Forms.CheckBox chkPolonium;
        private System.Windows.Forms.CheckBox chkBismuthum;
        private System.Windows.Forms.CheckBox chkPlumbum;
        private System.Windows.Forms.CheckBox chkThallium;
        private System.Windows.Forms.CheckBox chkHydrargyrum;
        private System.Windows.Forms.CheckBox chkAurum;
        private System.Windows.Forms.CheckBox chkPlatinum;
        private System.Windows.Forms.CheckBox chkIridium;
        private System.Windows.Forms.CheckBox chkOsmium;
        private System.Windows.Forms.CheckBox chkRhenium;
        private System.Windows.Forms.CheckBox chkWolframium;
        private System.Windows.Forms.CheckBox chkTantalum;
        private System.Windows.Forms.CheckBox chkHafnium;
        private System.Windows.Forms.CheckBox chkLanthanum;
        private System.Windows.Forms.CheckBox chkBarium;
        private System.Windows.Forms.CheckBox chkCaesium;
        private System.Windows.Forms.CheckBox chkXenon;
        private System.Windows.Forms.CheckBox chkIodum;
        private System.Windows.Forms.CheckBox chkTellurium;
        private System.Windows.Forms.CheckBox chkStibium;
        private System.Windows.Forms.CheckBox chkStannum;
        private System.Windows.Forms.CheckBox chkIndium;
        private System.Windows.Forms.CheckBox chkCadmium;
        private System.Windows.Forms.CheckBox chkArgentum;
        private System.Windows.Forms.CheckBox chkPalladium;
        private System.Windows.Forms.CheckBox chkRhodium;
        private System.Windows.Forms.CheckBox chkRuthenium;
        private System.Windows.Forms.CheckBox chkTechnetium;
        private System.Windows.Forms.CheckBox chkMolybdaenum;
        private System.Windows.Forms.CheckBox chkNiobium;
        private System.Windows.Forms.CheckBox chkZirconium;
        private System.Windows.Forms.CheckBox chkYttrium;
        private System.Windows.Forms.CheckBox chkStrontium;
        private System.Windows.Forms.CheckBox chkRubidium;
        private System.Windows.Forms.CheckBox chkKrypton;
        private System.Windows.Forms.CheckBox chkBromum;
        private System.Windows.Forms.CheckBox chkSelenium;
        private System.Windows.Forms.CheckBox chkArsenicum;
        private System.Windows.Forms.CheckBox chkGermanium;
        private System.Windows.Forms.CheckBox chkGallium;
        private System.Windows.Forms.CheckBox chkZincum;
        private System.Windows.Forms.CheckBox chkCuprum;
        private System.Windows.Forms.CheckBox chkNiccolum;
        private System.Windows.Forms.CheckBox chkCobaltum;
        private System.Windows.Forms.CheckBox chkFerrum;
        private System.Windows.Forms.CheckBox chkManganum;
        private System.Windows.Forms.CheckBox chkChromium;
        private System.Windows.Forms.CheckBox chkVanadium;
        private System.Windows.Forms.CheckBox chkTitanium;
        private System.Windows.Forms.CheckBox chkScandium;
        private System.Windows.Forms.CheckBox chkCalcium;
        private System.Windows.Forms.CheckBox chkKalium;
        private System.Windows.Forms.CheckBox chkArgon;
        private System.Windows.Forms.CheckBox chkChlorum;
        private System.Windows.Forms.CheckBox chkSulfur;
        private System.Windows.Forms.CheckBox chkPhosphorus;
        private System.Windows.Forms.CheckBox chkSilicium;
        private System.Windows.Forms.CheckBox chkAluminium;
        private System.Windows.Forms.CheckBox chkMagnesium;
        private System.Windows.Forms.CheckBox chkNatrium;
        private System.Windows.Forms.CheckBox chkNeon;
        private System.Windows.Forms.CheckBox chkFluorum;
        private System.Windows.Forms.CheckBox chkOxygenium;
        private System.Windows.Forms.CheckBox chkNitrogenium;
        private System.Windows.Forms.CheckBox chkCarboneum;
        private System.Windows.Forms.CheckBox chkBorum;
        private System.Windows.Forms.CheckBox chkBerillium;
        private System.Windows.Forms.CheckBox chkLithium;
        private System.Windows.Forms.CheckBox chkHelium;
        private System.Windows.Forms.CheckBox chkHydrogen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClearRecognized;
        private System.Windows.Forms.NumericUpDown nudPeakThreshold;
        private System.Windows.Forms.Label RecognizedLinesCountText;
        private System.Windows.Forms.Button btnRecognizeLines;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckedListBox clbAdditionalSpectraPlot;
        private System.Windows.Forms.Button btnCalculateIntergralRatios;
        private System.Windows.Forms.Button btnMergeIntegrals;
        private System.Windows.Forms.Button btnGetCalibration;
        private System.Windows.Forms.ToolStripMenuItem doIrradianceCalibrationToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkEnableCalibratedYAxis;
        private System.Windows.Forms.Button btnShowLineBase;
        private System.Windows.Forms.Button btnSavePlotToFile;
        private System.Windows.Forms.CheckBox chkShowPeakInfo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nudRightAccuracyLimit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnDiscardOutlier;
        private System.Windows.Forms.CheckBox chkAskMeBeforeNewExp;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown nudPowerSupplyLag;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown nudMaxRemoveNumber;
        private System.Windows.Forms.Button btnRemoveWithMaxOver;
        private System.Windows.Forms.Button btnFourierSelfDeconvolution;
        private System.Windows.Forms.Button btnBoringStuff;
        private System.Windows.Forms.Button btnSaveCalibrated;
    }
}


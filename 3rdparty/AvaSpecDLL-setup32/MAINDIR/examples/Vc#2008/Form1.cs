using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Runtime.Serialization; 
using System.Runtime.Serialization.Formatters.Binary; 
using System.Runtime.InteropServices;

namespace C_Sharp_Application
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 
	[Serializable]

	public class Form1 : System.Windows.Forms.Form  
	{

		private System.Windows.Forms.GroupBox gbInfo;
		private System.Windows.Forms.TextBox edtDetectorname;
		private System.Windows.Forms.TextBox edtNrOfPixels;
		private System.Windows.Forms.TextBox edtFPGAver;
		private System.Windows.Forms.TextBox edtFWver;
		private System.Windows.Forms.TextBox edtDLLver;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.TextBox edtStartPixel;
		private System.Windows.Forms.TextBox edtStopPixel;
		private System.Windows.Forms.TextBox edtIntegrationTime;
		private System.Windows.Forms.TextBox edtIntegrationDelay;
		private System.Windows.Forms.TextBox edtNrOfAverages;
		private System.Windows.Forms.TextBox edtSaturationLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox gbTrigger;
		private System.Windows.Forms.GroupBox gbControl;
		private System.Windows.Forms.GroupBox gbSmoothing;
		private System.Windows.Forms.GroupBox gbDarkCorrection;
		private System.Windows.Forms.CheckBox chkEnableDarkCorrection;
		private System.Windows.Forms.TextBox edtDarkHist;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtSmoothModel;
		private System.Windows.Forms.TextBox edtSmoothPix;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.CheckBox chkTrigModeHw;
		private System.Windows.Forms.CheckBox chkTrigModeSw;
		private System.Windows.Forms.CheckBox chkTrigSourceExtHw;
		private System.Windows.Forms.CheckBox chkTrigSourceSync;
		private System.Windows.Forms.CheckBox chkTrigTypeEdge;
		private System.Windows.Forms.CheckBox chkTrigTypeLevel;
        private System.Windows.Forms.CheckBox chkPreScan;
		private System.Windows.Forms.TextBox edtLaserDelay;
		private System.Windows.Forms.TextBox edtLaserWidth;
		private System.Windows.Forms.TextBox edtLaserWavelength;
		private System.Windows.Forms.TextBox edtRamSpectra;
		private System.Windows.Forms.GroupBox gbPrepareMeasSettings;
		private System.Windows.Forms.TextBox edtFlashesPerScan;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button btnReadMeasFromEEProm;
		private System.Windows.Forms.Button btnWriteMeasToEEProm;
		private System.Windows.Forms.GroupBox gbMeasure;
		private System.Windows.Forms.GroupBox gbOutput;
		private System.Windows.Forms.TextBox edtTotalTime;
		private System.Windows.Forms.TextBox edtPerformedScans;
		private System.Windows.Forms.TextBox edtFailures;
		private System.Windows.Forms.TextBox edtAvgTimePerScan;
		private System.Windows.Forms.TextBox edtLastScanTime;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox edtNrOfScans;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Button btnStartMeasurement;
        private System.Windows.Forms.Button btnStopMeasurement;
		private System.Windows.Forms.Button btnCommunication;
		private System.Windows.Forms.Button btnUpdateList;
		private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeactivate;
		private System.Windows.Forms.StatusBar StatusBar1;
		private System.Windows.Forms.StatusBarPanel Panel1;
		private System.Windows.Forms.StatusBarPanel Panel2;
		private System.Windows.Forms.StatusBarPanel Panel3;
		private System.Windows.Forms.ListBox sgShowList;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public long m_DeviceHandle;
		public avaspec.PixelArrayType m_Lambda = new avaspec.PixelArrayType();
		ushort	m_NrPixels;
		ushort  m_StartPixels;
		ushort  m_StopPixels;
		ulong	m_StartTicks;
		uint    m_Measurements;
		uint    m_Failures;
		//bool    m_GraphicsDisabled;
		uint    m_PreviousTimeStamp;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox edtWaveLength;
		private System.Windows.Forms.TextBox edtCounts;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown numUpDown;
        
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edtDetectorname = new System.Windows.Forms.TextBox();
            this.edtNrOfPixels = new System.Windows.Forms.TextBox();
            this.edtFPGAver = new System.Windows.Forms.TextBox();
            this.edtFWver = new System.Windows.Forms.TextBox();
            this.edtDLLver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.Panel1 = new System.Windows.Forms.StatusBarPanel();
            this.Panel2 = new System.Windows.Forms.StatusBarPanel();
            this.Panel3 = new System.Windows.Forms.StatusBarPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.gbPrepareMeasSettings = new System.Windows.Forms.GroupBox();
            this.btnWriteMeasToEEProm = new System.Windows.Forms.Button();
            this.btnReadMeasFromEEProm = new System.Windows.Forms.Button();
            this.gbDarkCorrection = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkEnableDarkCorrection = new System.Windows.Forms.CheckBox();
            this.edtDarkHist = new System.Windows.Forms.TextBox();
            this.gbSmoothing = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.edtSmoothModel = new System.Windows.Forms.TextBox();
            this.edtSmoothPix = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.edtFlashesPerScan = new System.Windows.Forms.TextBox();
            this.edtLaserDelay = new System.Windows.Forms.TextBox();
            this.edtLaserWidth = new System.Windows.Forms.TextBox();
            this.edtLaserWavelength = new System.Windows.Forms.TextBox();
            this.edtRamSpectra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.gbTrigger = new System.Windows.Forms.GroupBox();
            this.chkTrigModeHw = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkTrigModeSw = new System.Windows.Forms.CheckBox();
            this.chkTrigSourceExtHw = new System.Windows.Forms.CheckBox();
            this.chkTrigSourceSync = new System.Windows.Forms.CheckBox();
            this.chkTrigTypeEdge = new System.Windows.Forms.CheckBox();
            this.chkTrigTypeLevel = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtStartPixel = new System.Windows.Forms.TextBox();
            this.edtStopPixel = new System.Windows.Forms.TextBox();
            this.edtIntegrationTime = new System.Windows.Forms.TextBox();
            this.edtIntegrationDelay = new System.Windows.Forms.TextBox();
            this.edtNrOfAverages = new System.Windows.Forms.TextBox();
            this.edtSaturationLevel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sgShowList = new System.Windows.Forms.ListBox();
            this.gbMeasure = new System.Windows.Forms.GroupBox();
            this.chkPreScan = new System.Windows.Forms.CheckBox();
            this.btnStartMeasurement = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.edtNrOfScans = new System.Windows.Forms.TextBox();
            this.btnStopMeasurement = new System.Windows.Forms.Button();
            this.gbOutput = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.edtTotalTime = new System.Windows.Forms.TextBox();
            this.edtPerformedScans = new System.Windows.Forms.TextBox();
            this.edtFailures = new System.Windows.Forms.TextBox();
            this.edtAvgTimePerScan = new System.Windows.Forms.TextBox();
            this.edtLastScanTime = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCommunication = new System.Windows.Forms.Button();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.edtCounts = new System.Windows.Forms.TextBox();
            this.edtWaveLength = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).BeginInit();
            this.gbPrepareMeasSettings.SuspendLayout();
            this.gbDarkCorrection.SuspendLayout();
            this.gbSmoothing.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbTrigger.SuspendLayout();
            this.gbMeasure.SuspendLayout();
            this.gbOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.edtDetectorname);
            this.gbInfo.Controls.Add(this.edtNrOfPixels);
            this.gbInfo.Controls.Add(this.edtFPGAver);
            this.gbInfo.Controls.Add(this.edtFWver);
            this.gbInfo.Controls.Add(this.edtDLLver);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Location = new System.Drawing.Point(7, 304);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(268, 146);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Selected Device Info";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "AS5216 DLL Version";
            // 
            // edtDetectorname
            // 
            this.edtDetectorname.Enabled = false;
            this.edtDetectorname.Location = new System.Drawing.Point(127, 21);
            this.edtDetectorname.Name = "edtDetectorname";
            this.edtDetectorname.Size = new System.Drawing.Size(126, 20);
            this.edtDetectorname.TabIndex = 0;
            // 
            // edtNrOfPixels
            // 
            this.edtNrOfPixels.Enabled = false;
            this.edtNrOfPixels.Location = new System.Drawing.Point(127, 42);
            this.edtNrOfPixels.Name = "edtNrOfPixels";
            this.edtNrOfPixels.Size = new System.Drawing.Size(126, 20);
            this.edtNrOfPixels.TabIndex = 0;
            // 
            // edtFPGAver
            // 
            this.edtFPGAver.Enabled = false;
            this.edtFPGAver.Location = new System.Drawing.Point(127, 62);
            this.edtFPGAver.Name = "edtFPGAver";
            this.edtFPGAver.Size = new System.Drawing.Size(126, 20);
            this.edtFPGAver.TabIndex = 0;
            // 
            // edtFWver
            // 
            this.edtFWver.Enabled = false;
            this.edtFWver.Location = new System.Drawing.Point(127, 83);
            this.edtFWver.Name = "edtFWver";
            this.edtFWver.Size = new System.Drawing.Size(126, 20);
            this.edtFWver.TabIndex = 0;
            // 
            // edtDLLver
            // 
            this.edtDLLver.Enabled = false;
            this.edtDLLver.Location = new System.Drawing.Point(127, 104);
            this.edtDLLver.Name = "edtDLLver";
            this.edtDLLver.Size = new System.Drawing.Size(126, 20);
            this.edtDLLver.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "AS5216 FW Version";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "AS5216 FPGA Version";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nr Of Pixels";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Detector";
            // 
            // StatusBar1
            // 
            this.StatusBar1.Location = new System.Drawing.Point(0, 542);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.Panel1,
            this.Panel2,
            this.Panel3});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(953, 21);
            this.StatusBar1.TabIndex = 1;
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Panel1.Name = "Panel1";
            this.Panel1.Width = 312;
            // 
            // Panel2
            // 
            this.Panel2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Panel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Panel2.Name = "Panel2";
            this.Panel2.Width = 312;
            // 
            // Panel3
            // 
            this.Panel3.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.Panel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.Panel3.Name = "Panel3";
            this.Panel3.Width = 312;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Exit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
            this.menuItem2.Text = "Hardware configuration";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "AnalogIO";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "DigitalIO";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // gbPrepareMeasSettings
            // 
            this.gbPrepareMeasSettings.Controls.Add(this.btnWriteMeasToEEProm);
            this.gbPrepareMeasSettings.Controls.Add(this.btnReadMeasFromEEProm);
            this.gbPrepareMeasSettings.Controls.Add(this.gbDarkCorrection);
            this.gbPrepareMeasSettings.Controls.Add(this.gbSmoothing);
            this.gbPrepareMeasSettings.Controls.Add(this.gbControl);
            this.gbPrepareMeasSettings.Controls.Add(this.gbTrigger);
            this.gbPrepareMeasSettings.Controls.Add(this.label6);
            this.gbPrepareMeasSettings.Controls.Add(this.edtStartPixel);
            this.gbPrepareMeasSettings.Controls.Add(this.edtStopPixel);
            this.gbPrepareMeasSettings.Controls.Add(this.edtIntegrationTime);
            this.gbPrepareMeasSettings.Controls.Add(this.edtIntegrationDelay);
            this.gbPrepareMeasSettings.Controls.Add(this.edtNrOfAverages);
            this.gbPrepareMeasSettings.Controls.Add(this.edtSaturationLevel);
            this.gbPrepareMeasSettings.Controls.Add(this.label7);
            this.gbPrepareMeasSettings.Controls.Add(this.label8);
            this.gbPrepareMeasSettings.Controls.Add(this.label9);
            this.gbPrepareMeasSettings.Controls.Add(this.label10);
            this.gbPrepareMeasSettings.Controls.Add(this.label11);
            this.gbPrepareMeasSettings.Location = new System.Drawing.Point(290, 8);
            this.gbPrepareMeasSettings.Name = "gbPrepareMeasSettings";
            this.gbPrepareMeasSettings.Size = new System.Drawing.Size(426, 443);
            this.gbPrepareMeasSettings.TabIndex = 2;
            this.gbPrepareMeasSettings.TabStop = false;
            this.gbPrepareMeasSettings.Text = "Prepare Measurement Settings";
            // 
            // btnWriteMeasToEEProm
            // 
            this.btnWriteMeasToEEProm.Location = new System.Drawing.Point(217, 371);
            this.btnWriteMeasToEEProm.Name = "btnWriteMeasToEEProm";
            this.btnWriteMeasToEEProm.Size = new System.Drawing.Size(146, 35);
            this.btnWriteMeasToEEProm.TabIndex = 7;
            this.btnWriteMeasToEEProm.Text = "Write Measurement Settings to EEPROM";
            this.btnWriteMeasToEEProm.Click += new System.EventHandler(this.btnWriteMeasToEEProm_Click);
            // 
            // btnReadMeasFromEEProm
            // 
            this.btnReadMeasFromEEProm.Location = new System.Drawing.Point(46, 371);
            this.btnReadMeasFromEEProm.Name = "btnReadMeasFromEEProm";
            this.btnReadMeasFromEEProm.Size = new System.Drawing.Size(147, 35);
            this.btnReadMeasFromEEProm.TabIndex = 6;
            this.btnReadMeasFromEEProm.Text = "Read Measurement Settings from EEPROM";
            this.btnReadMeasFromEEProm.Click += new System.EventHandler(this.btnReadMeasFromEEProm_Click);
            // 
            // gbDarkCorrection
            // 
            this.gbDarkCorrection.Controls.Add(this.label12);
            this.gbDarkCorrection.Controls.Add(this.chkEnableDarkCorrection);
            this.gbDarkCorrection.Controls.Add(this.edtDarkHist);
            this.gbDarkCorrection.Location = new System.Drawing.Point(207, 21);
            this.gbDarkCorrection.Name = "gbDarkCorrection";
            this.gbDarkCorrection.Size = new System.Drawing.Size(213, 77);
            this.gbDarkCorrection.TabIndex = 5;
            this.gbDarkCorrection.TabStop = false;
            this.gbDarkCorrection.Text = "Dark Correction Settings";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(72, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "%";
            // 
            // chkEnableDarkCorrection
            // 
            this.chkEnableDarkCorrection.Location = new System.Drawing.Point(7, 21);
            this.chkEnableDarkCorrection.Name = "chkEnableDarkCorrection";
            this.chkEnableDarkCorrection.Size = new System.Drawing.Size(73, 21);
            this.chkEnableDarkCorrection.TabIndex = 0;
            this.chkEnableDarkCorrection.Text = "Enable";
            // 
            // edtDarkHist
            // 
            this.edtDarkHist.Location = new System.Drawing.Point(6, 48);
            this.edtDarkHist.Name = "edtDarkHist";
            this.edtDarkHist.Size = new System.Drawing.Size(60, 20);
            this.edtDarkHist.TabIndex = 0;
            // 
            // gbSmoothing
            // 
            this.gbSmoothing.Controls.Add(this.label13);
            this.gbSmoothing.Controls.Add(this.edtSmoothModel);
            this.gbSmoothing.Controls.Add(this.edtSmoothPix);
            this.gbSmoothing.Controls.Add(this.label14);
            this.gbSmoothing.Location = new System.Drawing.Point(207, 104);
            this.gbSmoothing.Name = "gbSmoothing";
            this.gbSmoothing.Size = new System.Drawing.Size(213, 76);
            this.gbSmoothing.TabIndex = 4;
            this.gbSmoothing.TabStop = false;
            this.gbSmoothing.Text = "Smoothing Settings";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "Model";
            // 
            // edtSmoothModel
            // 
            this.edtSmoothModel.Location = new System.Drawing.Point(137, 22);
            this.edtSmoothModel.Name = "edtSmoothModel";
            this.edtSmoothModel.Size = new System.Drawing.Size(60, 20);
            this.edtSmoothModel.TabIndex = 0;
            // 
            // edtSmoothPix
            // 
            this.edtSmoothPix.Location = new System.Drawing.Point(137, 43);
            this.edtSmoothPix.Name = "edtSmoothPix";
            this.edtSmoothPix.Size = new System.Drawing.Size(60, 20);
            this.edtSmoothPix.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Nr Of Pixels";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label18);
            this.gbControl.Controls.Add(this.edtFlashesPerScan);
            this.gbControl.Controls.Add(this.edtLaserDelay);
            this.gbControl.Controls.Add(this.edtLaserWidth);
            this.gbControl.Controls.Add(this.edtLaserWavelength);
            this.gbControl.Controls.Add(this.edtRamSpectra);
            this.gbControl.Controls.Add(this.label19);
            this.gbControl.Controls.Add(this.label20);
            this.gbControl.Controls.Add(this.label21);
            this.gbControl.Controls.Add(this.label22);
            this.gbControl.Location = new System.Drawing.Point(207, 187);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(213, 165);
            this.gbControl.TabIndex = 3;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control Settings";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(7, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 14);
            this.label18.TabIndex = 2;
            this.label18.Text = "Flashes per Scan";
            // 
            // edtFlashesPerScan
            // 
            this.edtFlashesPerScan.Location = new System.Drawing.Point(137, 14);
            this.edtFlashesPerScan.Name = "edtFlashesPerScan";
            this.edtFlashesPerScan.Size = new System.Drawing.Size(60, 20);
            this.edtFlashesPerScan.TabIndex = 1;
            this.edtFlashesPerScan.Text = "0";
            // 
            // edtLaserDelay
            // 
            this.edtLaserDelay.Location = new System.Drawing.Point(137, 35);
            this.edtLaserDelay.Name = "edtLaserDelay";
            this.edtLaserDelay.Size = new System.Drawing.Size(60, 20);
            this.edtLaserDelay.TabIndex = 1;
            this.edtLaserDelay.Text = "0";
            // 
            // edtLaserWidth
            // 
            this.edtLaserWidth.Location = new System.Drawing.Point(137, 55);
            this.edtLaserWidth.Name = "edtLaserWidth";
            this.edtLaserWidth.Size = new System.Drawing.Size(60, 20);
            this.edtLaserWidth.TabIndex = 1;
            this.edtLaserWidth.Text = "10000";
            // 
            // edtLaserWavelength
            // 
            this.edtLaserWavelength.Location = new System.Drawing.Point(137, 76);
            this.edtLaserWavelength.Name = "edtLaserWavelength";
            this.edtLaserWavelength.Size = new System.Drawing.Size(60, 20);
            this.edtLaserWavelength.TabIndex = 1;
            this.edtLaserWavelength.Text = "785";
            // 
            // edtRamSpectra
            // 
            this.edtRamSpectra.Location = new System.Drawing.Point(137, 97);
            this.edtRamSpectra.Name = "edtRamSpectra";
            this.edtRamSpectra.Size = new System.Drawing.Size(60, 20);
            this.edtRamSpectra.TabIndex = 1;
            this.edtRamSpectra.Text = "0";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(7, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Laser delay [ns]";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(7, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 14);
            this.label20.TabIndex = 2;
            this.label20.Text = "Laser width [ns]";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(7, 83);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 14);
            this.label21.TabIndex = 2;
            this.label21.Text = "Laser wavelength";
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(7, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 14);
            this.label22.TabIndex = 2;
            this.label22.Text = "Spectra stored to RAM";
            // 
            // gbTrigger
            // 
            this.gbTrigger.Controls.Add(this.chkTrigModeHw);
            this.gbTrigger.Controls.Add(this.label15);
            this.gbTrigger.Controls.Add(this.label16);
            this.gbTrigger.Controls.Add(this.label17);
            this.gbTrigger.Controls.Add(this.chkTrigModeSw);
            this.gbTrigger.Controls.Add(this.chkTrigSourceExtHw);
            this.gbTrigger.Controls.Add(this.chkTrigSourceSync);
            this.gbTrigger.Controls.Add(this.chkTrigTypeEdge);
            this.gbTrigger.Controls.Add(this.chkTrigTypeLevel);
            this.gbTrigger.Location = new System.Drawing.Point(13, 187);
            this.gbTrigger.Name = "gbTrigger";
            this.gbTrigger.Size = new System.Drawing.Size(187, 165);
            this.gbTrigger.TabIndex = 2;
            this.gbTrigger.TabStop = false;
            this.gbTrigger.Text = "Trigger Settings";
            // 
            // chkTrigModeHw
            // 
            this.chkTrigModeHw.Location = new System.Drawing.Point(87, 24);
            this.chkTrigModeHw.Name = "chkTrigModeHw";
            this.chkTrigModeHw.Size = new System.Drawing.Size(73, 20);
            this.chkTrigModeHw.TabIndex = 1;
            this.chkTrigModeHw.Text = "Hardware";
            this.chkTrigModeHw.CheckedChanged += new System.EventHandler(this.chkTrigModeHw_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(7, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "Trigger mode";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(7, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Trigger source";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 21);
            this.label17.TabIndex = 0;
            this.label17.Text = "Trigger type";
            // 
            // chkTrigModeSw
            // 
            this.chkTrigModeSw.Checked = true;
            this.chkTrigModeSw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrigModeSw.Location = new System.Drawing.Point(87, 47);
            this.chkTrigModeSw.Name = "chkTrigModeSw";
            this.chkTrigModeSw.Size = new System.Drawing.Size(73, 18);
            this.chkTrigModeSw.TabIndex = 1;
            this.chkTrigModeSw.Text = "Software";
            this.chkTrigModeSw.CheckedChanged += new System.EventHandler(this.chkTrigModeSw_CheckedChanged);
            // 
            // chkTrigSourceExtHw
            // 
            this.chkTrigSourceExtHw.Checked = true;
            this.chkTrigSourceExtHw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrigSourceExtHw.Location = new System.Drawing.Point(87, 69);
            this.chkTrigSourceExtHw.Name = "chkTrigSourceExtHw";
            this.chkTrigSourceExtHw.Size = new System.Drawing.Size(66, 21);
            this.chkTrigSourceExtHw.TabIndex = 1;
            this.chkTrigSourceExtHw.Text = "External";
            this.chkTrigSourceExtHw.CheckedChanged += new System.EventHandler(this.chkTrigSourceExtHw_CheckedChanged);
            // 
            // chkTrigSourceSync
            // 
            this.chkTrigSourceSync.Location = new System.Drawing.Point(87, 90);
            this.chkTrigSourceSync.Name = "chkTrigSourceSync";
            this.chkTrigSourceSync.Size = new System.Drawing.Size(93, 20);
            this.chkTrigSourceSync.TabIndex = 1;
            this.chkTrigSourceSync.Text = "Synchronized";
            this.chkTrigSourceSync.CheckedChanged += new System.EventHandler(this.chkTrigSourceSync_CheckedChanged);
            // 
            // chkTrigTypeEdge
            // 
            this.chkTrigTypeEdge.Checked = true;
            this.chkTrigTypeEdge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrigTypeEdge.Location = new System.Drawing.Point(87, 110);
            this.chkTrigTypeEdge.Name = "chkTrigTypeEdge";
            this.chkTrigTypeEdge.Size = new System.Drawing.Size(66, 20);
            this.chkTrigTypeEdge.TabIndex = 1;
            this.chkTrigTypeEdge.Text = "Edge";
            this.chkTrigTypeEdge.CheckedChanged += new System.EventHandler(this.chkTrigTypeEdge_CheckedChanged);
            // 
            // chkTrigTypeLevel
            // 
            this.chkTrigTypeLevel.Location = new System.Drawing.Point(87, 131);
            this.chkTrigTypeLevel.Name = "chkTrigTypeLevel";
            this.chkTrigTypeLevel.Size = new System.Drawing.Size(66, 20);
            this.chkTrigTypeLevel.TabIndex = 1;
            this.chkTrigTypeLevel.Text = "Level";
            this.chkTrigTypeLevel.CheckedChanged += new System.EventHandler(this.chkTrigTypeLevel_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Start Pixel";
            // 
            // edtStartPixel
            // 
            this.edtStartPixel.Location = new System.Drawing.Point(133, 21);
            this.edtStartPixel.Name = "edtStartPixel";
            this.edtStartPixel.Size = new System.Drawing.Size(60, 20);
            this.edtStartPixel.TabIndex = 0;
            this.edtStartPixel.Text = "0";
            // 
            // edtStopPixel
            // 
            this.edtStopPixel.Location = new System.Drawing.Point(133, 42);
            this.edtStopPixel.Name = "edtStopPixel";
            this.edtStopPixel.Size = new System.Drawing.Size(60, 20);
            this.edtStopPixel.TabIndex = 0;
            this.edtStopPixel.Text = "2047";
            // 
            // edtIntegrationTime
            // 
            this.edtIntegrationTime.Location = new System.Drawing.Point(133, 62);
            this.edtIntegrationTime.Name = "edtIntegrationTime";
            this.edtIntegrationTime.Size = new System.Drawing.Size(60, 20);
            this.edtIntegrationTime.TabIndex = 0;
            this.edtIntegrationTime.Text = "100";
            // 
            // edtIntegrationDelay
            // 
            this.edtIntegrationDelay.Location = new System.Drawing.Point(133, 83);
            this.edtIntegrationDelay.Name = "edtIntegrationDelay";
            this.edtIntegrationDelay.Size = new System.Drawing.Size(60, 20);
            this.edtIntegrationDelay.TabIndex = 0;
            this.edtIntegrationDelay.Text = "0";
            // 
            // edtNrOfAverages
            // 
            this.edtNrOfAverages.Location = new System.Drawing.Point(133, 104);
            this.edtNrOfAverages.Name = "edtNrOfAverages";
            this.edtNrOfAverages.Size = new System.Drawing.Size(60, 20);
            this.edtNrOfAverages.TabIndex = 0;
            this.edtNrOfAverages.Text = "1";
            // 
            // edtSaturationLevel
            // 
            this.edtSaturationLevel.Location = new System.Drawing.Point(133, 125);
            this.edtSaturationLevel.Name = "edtSaturationLevel";
            this.edtSaturationLevel.Size = new System.Drawing.Size(60, 20);
            this.edtSaturationLevel.TabIndex = 0;
            this.edtSaturationLevel.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(13, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stop Pixel";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Integration Time [ms]";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Integration Delay [ns]";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "Number of averages";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(13, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "Saturation detection";
            // 
            // sgShowList
            // 
            this.sgShowList.ColumnWidth = 10;
            this.sgShowList.Location = new System.Drawing.Point(17, 93);
            this.sgShowList.Name = "sgShowList";
            this.sgShowList.Size = new System.Drawing.Size(66, 82);
            this.sgShowList.TabIndex = 3;
            this.sgShowList.SelectedIndexChanged += new System.EventHandler(this.sgShowList_SelectedIndexChanged);
            // 
            // gbMeasure
            // 
            this.gbMeasure.Controls.Add(this.chkPreScan);
            this.gbMeasure.Controls.Add(this.btnStartMeasurement);
            this.gbMeasure.Controls.Add(this.label28);
            this.gbMeasure.Controls.Add(this.edtNrOfScans);
            this.gbMeasure.Controls.Add(this.btnStopMeasurement);
            this.gbMeasure.Location = new System.Drawing.Point(731, 8);
            this.gbMeasure.Name = "gbMeasure";
            this.gbMeasure.Size = new System.Drawing.Size(210, 235);
            this.gbMeasure.TabIndex = 4;
            this.gbMeasure.TabStop = false;
            this.gbMeasure.Text = "Measure";
            // 
            // chkPreScan
            // 
            this.chkPreScan.AutoSize = true;
            this.chkPreScan.Location = new System.Drawing.Point(18, 165);
            this.chkPreScan.Name = "chkPreScan";
            this.chkPreScan.Size = new System.Drawing.Size(141, 17);
            this.chkPreScan.TabIndex = 3;
            this.chkPreScan.Text = "AvaSpec-3648 PreScan";
            this.chkPreScan.UseVisualStyleBackColor = true;
            this.chkPreScan.Visible = false;
            this.chkPreScan.CheckedChanged += new System.EventHandler(this.chkPreScan_CheckedChanged);
            // 
            // btnStartMeasurement
            // 
            this.btnStartMeasurement.Location = new System.Drawing.Point(27, 62);
            this.btnStartMeasurement.Name = "btnStartMeasurement";
            this.btnStartMeasurement.Size = new System.Drawing.Size(113, 28);
            this.btnStartMeasurement.TabIndex = 2;
            this.btnStartMeasurement.Text = "Start Measurement";
            this.btnStartMeasurement.Click += new System.EventHandler(this.btnStartMeasurement_Click);
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(7, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 28);
            this.label28.TabIndex = 1;
            this.label28.Text = "Nr Of Scans (-1 = infinite)";
            // 
            // edtNrOfScans
            // 
            this.edtNrOfScans.Location = new System.Drawing.Point(87, 21);
            this.edtNrOfScans.Name = "edtNrOfScans";
            this.edtNrOfScans.Size = new System.Drawing.Size(60, 20);
            this.edtNrOfScans.TabIndex = 0;
            this.edtNrOfScans.Text = "-1";
            // 
            // btnStopMeasurement
            // 
            this.btnStopMeasurement.Location = new System.Drawing.Point(27, 97);
            this.btnStopMeasurement.Name = "btnStopMeasurement";
            this.btnStopMeasurement.Size = new System.Drawing.Size(113, 28);
            this.btnStopMeasurement.TabIndex = 2;
            this.btnStopMeasurement.Text = "Stop Measurement";
            this.btnStopMeasurement.Click += new System.EventHandler(this.btnStopMeasurement_Click);
            // 
            // gbOutput
            // 
            this.gbOutput.Controls.Add(this.label23);
            this.gbOutput.Controls.Add(this.edtTotalTime);
            this.gbOutput.Controls.Add(this.edtPerformedScans);
            this.gbOutput.Controls.Add(this.edtFailures);
            this.gbOutput.Controls.Add(this.edtAvgTimePerScan);
            this.gbOutput.Controls.Add(this.edtLastScanTime);
            this.gbOutput.Controls.Add(this.label24);
            this.gbOutput.Controls.Add(this.label25);
            this.gbOutput.Controls.Add(this.label26);
            this.gbOutput.Controls.Add(this.label27);
            this.gbOutput.Location = new System.Drawing.Point(731, 248);
            this.gbOutput.Name = "gbOutput";
            this.gbOutput.Size = new System.Drawing.Size(210, 203);
            this.gbOutput.TabIndex = 5;
            this.gbOutput.TabStop = false;
            this.gbOutput.Text = "Measurement Statistics";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(7, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "Time Since Start [sec]";
            // 
            // edtTotalTime
            // 
            this.edtTotalTime.Location = new System.Drawing.Point(135, 18);
            this.edtTotalTime.Name = "edtTotalTime";
            this.edtTotalTime.Size = new System.Drawing.Size(60, 20);
            this.edtTotalTime.TabIndex = 5;
            // 
            // edtPerformedScans
            // 
            this.edtPerformedScans.Location = new System.Drawing.Point(135, 39);
            this.edtPerformedScans.Name = "edtPerformedScans";
            this.edtPerformedScans.Size = new System.Drawing.Size(60, 20);
            this.edtPerformedScans.TabIndex = 6;
            // 
            // edtFailures
            // 
            this.edtFailures.Location = new System.Drawing.Point(135, 59);
            this.edtFailures.Name = "edtFailures";
            this.edtFailures.Size = new System.Drawing.Size(60, 20);
            this.edtFailures.TabIndex = 4;
            // 
            // edtAvgTimePerScan
            // 
            this.edtAvgTimePerScan.Location = new System.Drawing.Point(135, 80);
            this.edtAvgTimePerScan.Name = "edtAvgTimePerScan";
            this.edtAvgTimePerScan.Size = new System.Drawing.Size(60, 20);
            this.edtAvgTimePerScan.TabIndex = 2;
            // 
            // edtLastScanTime
            // 
            this.edtLastScanTime.Location = new System.Drawing.Point(135, 101);
            this.edtLastScanTime.Name = "edtLastScanTime";
            this.edtLastScanTime.Size = new System.Drawing.Size(60, 20);
            this.edtLastScanTime.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(7, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Nr Of Scans";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(7, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 14);
            this.label25.TabIndex = 7;
            this.label25.Text = "Nr Of Failures";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(7, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(122, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Avg Time / Scan [ms]";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(6, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 14);
            this.label27.TabIndex = 7;
            this.label27.Text = "Last scan in [ms]";
            // 
            // btnCommunication
            // 
            this.btnCommunication.Location = new System.Drawing.Point(17, 8);
            this.btnCommunication.Name = "btnCommunication";
            this.btnCommunication.Size = new System.Drawing.Size(129, 28);
            this.btnCommunication.TabIndex = 6;
            this.btnCommunication.Text = "Open Communication";
            this.btnCommunication.Click += new System.EventHandler(this.btnCommunication_Click);
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(17, 46);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(129, 27);
            this.btnUpdateList.TabIndex = 6;
            this.btnUpdateList.Text = "Update List";
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(17, 209);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(129, 28);
            this.btnActivate.TabIndex = 6;
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(17, 249);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(129, 28);
            this.btnDeactivate.TabIndex = 6;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 10;
            this.listBox1.Enabled = false;
            this.listBox1.Location = new System.Drawing.Point(89, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(171, 82);
            this.listBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.numUpDown);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.edtCounts);
            this.groupBox1.Controls.Add(this.edtWaveLength);
            this.groupBox1.Location = new System.Drawing.Point(6, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Data";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(260, 14);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 20);
            this.label35.TabIndex = 5;
            this.label35.Text = "Pixel Number";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(260, 35);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(87, 20);
            this.numUpDown.TabIndex = 4;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(447, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 20);
            this.label34.TabIndex = 3;
            this.label34.Text = "Counts";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(353, 14);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 20);
            this.label33.TabIndex = 2;
            this.label33.Text = "Wavelength";
            // 
            // edtCounts
            // 
            this.edtCounts.Location = new System.Drawing.Point(447, 35);
            this.edtCounts.Name = "edtCounts";
            this.edtCounts.ReadOnly = true;
            this.edtCounts.Size = new System.Drawing.Size(83, 20);
            this.edtCounts.TabIndex = 1;
            // 
            // edtWaveLength
            // 
            this.edtWaveLength.Location = new System.Drawing.Point(353, 35);
            this.edtWaveLength.Name = "edtWaveLength";
            this.edtWaveLength.ReadOnly = true;
            this.edtWaveLength.Size = new System.Drawing.Size(84, 20);
            this.edtWaveLength.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(953, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCommunication);
            this.Controls.Add(this.gbOutput);
            this.Controls.Add(this.gbMeasure);
            this.Controls.Add(this.sgShowList);
            this.Controls.Add(this.gbPrepareMeasSettings);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.btnDeactivate);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel3)).EndInit();
            this.gbPrepareMeasSettings.ResumeLayout(false);
            this.gbPrepareMeasSettings.PerformLayout();
            this.gbDarkCorrection.ResumeLayout(false);
            this.gbDarkCorrection.PerformLayout();
            this.gbSmoothing.ResumeLayout(false);
            this.gbSmoothing.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbTrigger.ResumeLayout(false);
            this.gbMeasure.ResumeLayout(false);
            this.gbMeasure.PerformLayout();
            this.gbOutput.ResumeLayout(false);
            this.gbOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			m_DeviceHandle=avaspec.INVALID_AVS_HANDLE_VALUE;
			btnUpdateList.Enabled = false;
			btnActivate.Enabled = false;
			btnDeactivate.Enabled = false;
			btnStartMeasurement.Enabled = false;
			btnStopMeasurement.Enabled = false;
			btnReadMeasFromEEProm.Enabled = false;
			btnWriteMeasToEEProm.Enabled =false;
			menuItem3.Enabled = false;
			menuItem4.Enabled = false;
		}
		//---------------------------------------------------------------------------
		private void btnCommunication_Click(object sender, System.EventArgs e)
		{
			
			StatusBar1.Panels[0].Text = "Open communication busy";

			int l_Port = avaspec.AVS_Init(0);
             
			avaspec.AVS_Register(this.Handle);
			if (l_Port > 0)
			{
				StatusBar1.Panels[0].Text = "Connected: USB";
				btnUpdateList.Enabled = true;
				sgShowList.Items.Insert(0,"SerialNr");
				listBox1.Items.Insert(0,"Status");
				btnUpdateList_Click(this,e);
			}
			else
			{
				avaspec.AVS_Done();
				l_Port = avaspec.AVS_Init(-1);   //try Ethernet/USB
				if (l_Port > 0)
				{
					StatusBar1.Panels[0].Text = "Connected: Ethernet / USB" ;
					btnUpdateList.Enabled = true;
					sgShowList.Items.Insert(0,"SerialNr");
					listBox1.Items.Insert(0,"Status");
					btnUpdateList_Click(this,e);
				}
				else
				{
					StatusBar1.Panels[0].Text = "Open communication failed";
					avaspec.AVS_Done();
				}
			}
		}
		//---------------------------------------------------------------------------
		private void btnUpdateList_Click(object sender, System.EventArgs e)
		{
			uint						l_Size = 0;
			uint						l_RequiredSize = 0;
			int							l_NrDevices = 0;
			
			System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
			int	l_Selected = 0;
			l_Selected = sgShowList.SelectedIndex;

			sgShowList.Items.Clear();
			listBox1.Items.Clear();
			sgShowList.Items.Insert(0,"SerialNr");
			listBox1.Items.Insert(0,"Status");
			l_NrDevices = avaspec.AVS_GetNrOfDevices();
			
			avaspec.AvsIdentityType[] l_Id = new avaspec.AvsIdentityType[l_NrDevices];	
			l_RequiredSize = ((uint)l_NrDevices) * (uint)Marshal.SizeOf(typeof(avaspec.AvsIdentityType)); 

			if (l_RequiredSize > 0)
			{
				l_Size = l_RequiredSize;
                l_NrDevices = avaspec.AVS_GetList(l_Size, ref l_RequiredSize, l_Id); 

				for (int i = 0; i < l_NrDevices; i++)
				{	
					switch (l_Id[i].m_Status)
					{
						case avaspec.DEVICE_STATUS.UNKNOWN: 
							sgShowList.Items.Add(l_Id[i].m_SerialNumber);
							listBox1.Items.Add("UNKNOWN");
							break;
						case avaspec.DEVICE_STATUS.USB_AVAILABLE:
							sgShowList.Items.Add(l_Id[i].m_SerialNumber);
							listBox1.Items.Add("USB_AVAILABLE");
							break;
						case avaspec.DEVICE_STATUS.USB_IN_USE_BY_APPLICATION: 
							sgShowList.Items.Add(l_Id[i].m_SerialNumber);
							listBox1.Items.Add("USB_IN_USE_BY_APPLICATION");
							break;
						case avaspec.DEVICE_STATUS.USB_IN_USE_BY_OTHER: 
							sgShowList.Items.Add(l_Id[i].m_SerialNumber);
							listBox1.Items.Add("USB_IN_USE_BY_OTHER");
							break;
                        case avaspec.DEVICE_STATUS.ETH_AVAILABLE:
                            sgShowList.Items.Add(l_Id[i].m_SerialNumber);
                            listBox1.Items.Add("ETH_AVAILABLE");
                            break;
                        case avaspec.DEVICE_STATUS.ETH_IN_USE_BY_APPLICATION:
                            sgShowList.Items.Add(l_Id[i].m_SerialNumber);
                            listBox1.Items.Add("ETH_IN_USE_BY_APPLICATION");
                            break;
                        case avaspec.DEVICE_STATUS.ETH_IN_USE_BY_OTHER:
                            sgShowList.Items.Add(l_Id[i].m_SerialNumber);
                            listBox1.Items.Add("ETH_IN_USE_BY_OTHER");
                            break;
                        case avaspec.DEVICE_STATUS.ETH_ALREADY_IN_USE_USB:
                            sgShowList.Items.Add(l_Id[i].m_SerialNumber);
                            listBox1.Items.Add("ETH_ALREADY_IN_USE_USB");
                            break;
						default:
							sgShowList.Items.Add("??????");
							break;
					}
				}
				sgShowList.SelectedIndex = l_Selected;
			}
			sgShowList_SelectedIndexChanged(this,e);
		}
		//-------------------------------------------------------------------------
		private void sgShowList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int	l_Selected = 0;
			l_Selected = sgShowList.SelectedIndex;
			
			if(l_Selected > 0)
			{
                bool available = (listBox1.Items[l_Selected].ToString() == "USB_AVAILABLE") ||
                                 (listBox1.Items[l_Selected].ToString() == "ETH_AVAILABLE");
                bool in_use_by_application = (listBox1.Items[l_Selected].ToString() == "USB_IN_USE_BY_APPLICATION") ||
                                             (listBox1.Items[l_Selected].ToString() == "ETH_IN_USE_BY_APPLICATION");
                btnActivate.Enabled = available;
                btnDeactivate.Enabled = in_use_by_application;
                menuItem4.Enabled = in_use_by_application;
                menuItem3.Enabled = in_use_by_application;
                btnReadMeasFromEEProm.Enabled = in_use_by_application;
                btnWriteMeasToEEProm.Enabled = in_use_by_application;
                btnStartMeasurement.Enabled = in_use_by_application;
                btnStopMeasurement.Enabled = in_use_by_application;
			}
		}
		//-------------------------------------------------------------------------							   
		private void btnActivate_Click(object sender, System.EventArgs e)
		{
			avaspec.AvsIdentityType l_Active = new avaspec.AvsIdentityType(); 
			long l_hDevice = 0;
			int l_Selected = 0;

			l_Selected = sgShowList.SelectedIndex; 
			
			if(l_Selected > 0)
			{
				l_Active.m_SerialNumber = sgShowList.Items[l_Selected].ToString();
				l_hDevice = (long)avaspec.AVS_Activate(ref l_Active);

				if (avaspec.INVALID_AVS_HANDLE_VALUE == l_hDevice)
				{
					MessageBox.Show ("Error opening device" + l_Active.m_SerialNumber, "Avantes", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					m_DeviceHandle = l_hDevice;
					btnUpdateList_Click(this,e);
					ConnectGui();
					btnReadMeasFromEEProm_Click(this,e);
				}
			}
		}
		//-------------------------------------------------------------------------
		private void btnDeactivate_Click(object sender, System.EventArgs e)
		{
			int	l_Selected = sgShowList.SelectedIndex; 
			
			if(l_Selected > 0)
			{
				avaspec.AVS_Deactivate((IntPtr)m_DeviceHandle);
				m_DeviceHandle = avaspec.INVALID_AVS_HANDLE_VALUE;
				btnUpdateList_Click(this,e);
				DisconnectGui();
			}
		}
		//-------------------------------------------------------------------------
		private void btnStartMeasurement_Click(object sender, System.EventArgs e)
		{
			// prevent second StartMeasurementClick before sequence ends.
			btnStartMeasurement.Enabled = false;
			//Prepare Measurement
			avaspec.MeasConfigType  l_PrepareMeasData = new avaspec.MeasConfigType();
			
			l_PrepareMeasData.m_StartPixel = System.Convert.ToUInt16(edtStartPixel.Text);
			l_PrepareMeasData.m_StopPixel =  System.Convert.ToUInt16(edtStopPixel.Text);
			l_PrepareMeasData.m_IntegrationTime = (float)System.Convert.ToDouble(edtIntegrationTime.Text);
			double l_NanoSec = System.Convert.ToDouble(edtIntegrationDelay.Text);
			uint l_FPGAClkCycles = (uint)(6.0*(l_NanoSec+20.84)/125.0);
			l_PrepareMeasData.m_IntegrationDelay = l_FPGAClkCycles;
			l_PrepareMeasData.m_NrAverages = System.Convert.ToUInt32(edtNrOfAverages.Text);
			l_PrepareMeasData.m_Trigger.m_Mode = (byte)chkTrigModeHw.CheckState;
			l_PrepareMeasData.m_Trigger.m_Source = (byte)chkTrigSourceSync.CheckState;
			l_PrepareMeasData.m_Trigger.m_SourceType = (byte)chkTrigTypeLevel.CheckState;
			l_PrepareMeasData.m_SaturationDetection = System.Convert.ToByte(edtSaturationLevel.Text);
			l_PrepareMeasData.m_CorDynDark.m_Enable = (byte)chkEnableDarkCorrection.CheckState;
			l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage = System.Convert.ToByte(edtDarkHist.Text);
			l_PrepareMeasData.m_Smoothing.m_SmoothPix = System.Convert.ToUInt16(edtSmoothPix.Text);
			l_PrepareMeasData.m_Smoothing.m_SmoothModel = System.Convert.ToByte(edtSmoothModel.Text);
			l_PrepareMeasData.m_Control.m_StrobeControl = System.Convert.ToUInt16(edtFlashesPerScan.Text);
			l_NanoSec = System.Convert.ToDouble(edtLaserDelay.Text);
			l_FPGAClkCycles = (uint)(6.0*l_NanoSec/125.0);
			l_PrepareMeasData.m_Control.m_LaserDelay = l_FPGAClkCycles;
			l_NanoSec = System.Convert.ToDouble(edtLaserWidth.Text);
			l_FPGAClkCycles = (uint)(6.0*l_NanoSec/125.0);
			l_PrepareMeasData.m_Control.m_LaserWidth = l_FPGAClkCycles;
			l_PrepareMeasData.m_Control.m_LaserWaveLength = (float)System.Convert.ToDouble(edtLaserWavelength.Text);
            l_PrepareMeasData.m_Control.m_StoreToRam = System.Convert.ToUInt16(edtRamSpectra.Text);
			
			int l_Res = (int)avaspec.AVS_PrepareMeasure((IntPtr)m_DeviceHandle, ref l_PrepareMeasData);
			if (avaspec.ERR_SUCCESS != l_Res)
			{
				MessageBox.Show ("Error "+l_Res.ToString() , "Avantes", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			//Get Nr Of Scans
			short l_NrOfScans = System.Convert.ToInt16(edtNrOfScans.Text);
            if ((l_PrepareMeasData.m_Control.m_StoreToRam > 0) && (l_NrOfScans != 1))
            {
                edtNrOfScans.Text = "1";
                l_NrOfScans = 1;
                MessageBox.Show(l_PrepareMeasData.m_Control.m_StoreToRam.ToString() + 
                                " scans will be stored to RAM. " +
                                "The number of measurements (a_Nmsr in AVS_Measure) has been set to 1",
                                "Avantes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
			//Start Measurement
			m_StartTicks = (ulong)Environment.TickCount;
			m_Measurements = 0;
			m_Failures = 0;
			edtTotalTime.Text = "0";
			edtPerformedScans.Text = "0";
			edtFailures.Text = "0";
			m_StartPixels = l_PrepareMeasData.m_StartPixel;
			m_StopPixels = l_PrepareMeasData.m_StopPixel;
			numUpDown.Minimum = m_StartPixels;
			numUpDown.Maximum = m_StopPixels;
			
			l_Res = (int)avaspec.AVS_Measure((IntPtr)m_DeviceHandle, this.Handle, l_NrOfScans);
			if (avaspec.ERR_SUCCESS != l_Res)
			{
				switch (l_Res)
				{
					case avaspec.ERR_INVALID_PARAMETER:
						StatusBar1.Panels[1].Text = "Meas.Status: invalid parameter";
						break;
					default:
						StatusBar1.Panels[1].Text = "Meas.Status: start failed, code: " + l_Res.ToString();
						break;
				}
			}
			else
			{
				StatusBar1.Panels[1].Text = "Meas.Status: pending";
			}		
		}

        //-------------------------------------------------------------------------
        private void btnStopMeasurement_Click(object sender, System.EventArgs e)
		{
			 int l_Res = (int)avaspec.AVS_StopMeasure((IntPtr)m_DeviceHandle);
    
			if (avaspec.ERR_SUCCESS != l_Res)
			 {
				MessageBox.Show ("Error "+l_Res.ToString() , "Avantes", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			btnStartMeasurement.Enabled = true;
		}

		//-------------------------------------------------------------------------
		private void btnReadMeasFromEEProm_Click(object sender, System.EventArgs e)
		{
			avaspec.DeviceConfigType l_pDeviceData = new avaspec.DeviceConfigType();
			uint l_Size;

			l_Size = (uint)Marshal.SizeOf(typeof(avaspec.DeviceConfigType));
            int l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			
			if ( l_Res == avaspec.ERR_INVALID_SIZE)
			{
                l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			}

			if (avaspec.ERR_SUCCESS != l_Res)
			{
				MessageBox.Show ("Error " , "Avantes", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			//show measurement settings
			edtStartPixel.Text = l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel.ToString();
			edtStopPixel.Text =	l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel.ToString();
			edtIntegrationTime.Text = string.Format("{0:F}",l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime);
			uint l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay;
			double l_NanoSec = 125.0*(l_FPGAClkCycles-1.0)/6.0;
			edtIntegrationDelay.Text = string.Format("{0:F}",l_NanoSec);
			edtNrOfAverages.Text = l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages.ToString();
			edtSaturationLevel.Text = l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection.ToString();
			chkTrigModeHw.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode == 1);
			chkTrigModeSw.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode == 0);
			chkTrigSourceExtHw.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source == 0);
			chkTrigSourceSync.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source == 1);
			chkTrigTypeEdge.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType == 0);
			chkTrigTypeLevel.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType == 1);
			chkEnableDarkCorrection.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable == 1);
			edtDarkHist.Text = l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage.ToString();
			edtSmoothModel.Text = l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel.ToString();
			edtSmoothPix.Text = l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix.ToString();
			edtFlashesPerScan.Text = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl.ToString();
			l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay;
			l_NanoSec = 125.0*(l_FPGAClkCycles)/6.0;
			edtLaserDelay.Text = string.Format("{0:F}",l_NanoSec);
			l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth;
			l_NanoSec = 125.0*(l_FPGAClkCycles)/6.0;
			edtLaserWidth.Text = string.Format("{0:F}",l_NanoSec);
			edtLaserWavelength.Text = String.Format("{0:F2}",System.Convert.ToString(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength));
            edtRamSpectra.Text = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam.ToString();
			edtNrOfScans.Text = l_pDeviceData.m_StandAlone.m_Nmsr.ToString();
		}

		//-------------------------------------------------------------------------
		private void btnWriteMeasToEEProm_Click(object sender, System.EventArgs e)
		{
			avaspec.DeviceConfigType l_pDeviceData = new avaspec.DeviceConfigType();
			uint l_Size;
            l_Size = (uint)Marshal.SizeOf(typeof(avaspec.DeviceConfigType));

            int l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			
			if ( l_Res == avaspec.ERR_INVALID_SIZE)
			{
                l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			}

			if (avaspec.ERR_SUCCESS != l_Res)
			{
				MessageBox.Show ("AVS_GetParameter, code: "+l_Res.ToString() , "Avantes", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
		
				return;
			}
			//Get measurement parameters from main window
			l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel = System.Convert.ToUInt16(edtStartPixel.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel =  System.Convert.ToUInt16(edtStopPixel.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime = (float)System.Convert.ToDouble(edtIntegrationTime.Text);
			double l_NanoSec = System.Convert.ToDouble(edtIntegrationDelay.Text);
			uint l_FPGAClkCycles = (uint)(6.0*(l_NanoSec+20.84)/125.0);
			l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay = l_FPGAClkCycles;
			l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages = System.Convert.ToUInt16(edtNrOfAverages.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = System.Convert.ToByte(chkTrigModeHw.CheckState);
			l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = System.Convert.ToByte(chkTrigSourceSync.CheckState);
			l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = System.Convert.ToByte(chkTrigTypeLevel.CheckState);
			l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection = System.Convert.ToByte(edtSaturationLevel.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = System.Convert.ToByte(chkEnableDarkCorrection.CheckState);
			l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage = System.Convert.ToByte(edtDarkHist.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix = System.Convert.ToUInt16(edtSmoothPix.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel = System.Convert.ToByte(edtSmoothModel.Text);
			l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl = System.Convert.ToUInt16(edtFlashesPerScan.Text);
			l_NanoSec = (float)System.Convert.ToDouble(edtLaserDelay.Text);
			l_FPGAClkCycles = (uint)(6.0*l_NanoSec/125.0);
			l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay = l_FPGAClkCycles;
			l_NanoSec = (float)System.Convert.ToDouble(edtLaserWidth.Text);
			l_FPGAClkCycles = (uint)(6.0*l_NanoSec/125.0);
			l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth = l_FPGAClkCycles;
			l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength = (float)System.Convert.ToDouble(edtLaserWavelength.Text);
            l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam = System.Convert.ToUInt16(edtRamSpectra.Text);
			l_pDeviceData.m_StandAlone.m_Nmsr =  System.Convert.ToInt16(edtNrOfScans.Text);

			//Write measurement parameters
			l_Res = (int)avaspec.AVS_SetParameter((IntPtr)m_DeviceHandle,ref l_pDeviceData);
			if (avaspec.ERR_SUCCESS != l_Res)
			{
				MessageBox.Show ("AVS_SetParameter, code: "+l_Res.ToString() , "Avantes", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// l_Data = null;
		}

		//---------------------------------------------------------------------------
		private void ConnectGui()
		{
			avaspec.DeviceConfigType l_pDeviceData = new avaspec.DeviceConfigType();
			
			uint l_Size = 0;
            avaspec.String16Type a_Fpga = new avaspec.String16Type();
            avaspec.String16Type a_As5216 = new avaspec.String16Type();
			avaspec.String16Type a_Dll = new avaspec.String16Type();
            			
			System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
			
			int l_Res = (int)avaspec.AVS_GetVersionInfo((IntPtr)m_DeviceHandle, ref a_Fpga, ref a_As5216, ref a_Dll);
			
			if (avaspec.ERR_SUCCESS == l_Res)
			{
				edtFPGAver.Text = a_Fpga.String16;
				edtFWver.Text =	a_As5216.String16;
				edtDLLver.Text = a_Dll.String16;
			}

			if (avaspec.ERR_SUCCESS == (int)avaspec.AVS_GetNumPixels((IntPtr)m_DeviceHandle, ref m_NrPixels))
			{
				edtNrOfPixels.Text = System.Convert.ToString(m_NrPixels);
			}

            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.DetectorType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.IrradianceType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.SpectrumCalibrationType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.SpectrumCorrectionType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.StandAloneType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.TecControlType));
            //l_Size = (uint)Marshal.SizeOf(typeof(AVS5216.ProcessControlType));
            
            l_Size = (uint)Marshal.SizeOf(typeof(avaspec.DeviceConfigType));
            l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			
			if ( l_Res == avaspec.ERR_INVALID_SIZE)
			{
                l_Res = (int)avaspec.AVS_GetParameter((IntPtr)m_DeviceHandle, l_Size, ref l_Size, ref l_pDeviceData);
			}
			
			if (l_Res != avaspec.ERR_SUCCESS)
			{
				DisconnectGui();
				return;
			}
			switch (l_pDeviceData.m_Detector.m_SensorType)
			{
				case (byte)avaspec.SENS_TYPE.SENS_HAMS8378_256: edtDetectorname.Text = "HAMS8378_256";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_HAMS8378_1024 : edtDetectorname.Text = "HAMS8378_1024";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_ILX554 : edtDetectorname.Text = "ILX554";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_HAMS9201 : edtDetectorname.Text = "HAMS9201";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_TCD1304 : edtDetectorname.Text = "TCD1304";
                    chkPreScan.Visible = true;
                    chkPreScan.Checked = true;
                    l_Res = avaspec.AVS_SetPrescanMode( (IntPtr)m_DeviceHandle, chkPreScan.Checked);
					break;
				case (byte)avaspec.SENS_TYPE.SENS_TSL1301 : edtDetectorname.Text = "TSL1301";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_TSL1401 : edtDetectorname.Text = "TSL1401";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_HAMS8378_512 : edtDetectorname.Text = "HAMS8378_512";
					break;
				case (byte)avaspec.SENS_TYPE.SENS_HAMS9840: edtDetectorname.Text = "HAMS9840";
					break;
                case (byte)avaspec.SENS_TYPE.SENS_ILX511: edtDetectorname.Text = "ILX511";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS10420_2048X64: edtDetectorname.Text = "HAMS10420_2048X64";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS11071_2048X64: edtDetectorname.Text = "HAMS11071_2048X64";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS7031_1024X122: edtDetectorname.Text = "HAMS7031_1024X122";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS7031_1024X58: edtDetectorname.Text = "HAMS7031_1024X58";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS11071_2048X16: edtDetectorname.Text = "HAMS11071_2048X16";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS11155: edtDetectorname.Text = "HAMS11155";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_SU256LSB: edtDetectorname.Text = "SU256LSB";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_SU512LDB: edtDetectorname.Text = "SU512LDB";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS11638: edtDetectorname.Text = "HAMS11638";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS11639: edtDetectorname.Text = "HAMS11639";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMS12443: edtDetectorname.Text = "HAMS12443";
                    break;
                case (byte)avaspec.SENS_TYPE.SENS_HAMG9208_512: edtDetectorname.Text = "HAMG9208_512";
                    break;
				default : edtDetectorname.Text = "???????";
					break;
			}
			m_StartPixels = l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel;
			m_StopPixels = l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel;
			numUpDown.Minimum = m_StartPixels;
			numUpDown.Maximum = m_StopPixels;
			numUpDown.Value = m_StartPixels;
            avaspec.PixelArrayType m_Lambda = new avaspec.PixelArrayType();
			if (avaspec.ERR_SUCCESS == (int)avaspec.AVS_GetLambda((IntPtr)m_DeviceHandle,ref m_Lambda))
			{

			}
		}

		//-------------------------------------------------------------------------
		private void DisconnectGui()
		{
			//if (null != m_Lambda)
			//{
			//	m_Lambda = null;
			//}
			edtDetectorname.Text   = "";
			edtNrOfPixels.Text = "";
			edtFPGAver.Text = "";
			edtFWver.Text = "";
			edtDLLver.Text = "";
		}
		//-------------------------------------------------------------------------
		private void chkTrigModeHw_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigModeSw.Checked = !chkTrigModeHw.Checked;
		}
		//-------------------------------------------------------------------------
		private void chkTrigModeSw_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigModeHw.Checked = !chkTrigModeSw.Checked;
		}
		//-------------------------------------------------------------------------
		private void chkTrigSourceExtHw_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigSourceSync.Checked = !chkTrigSourceExtHw.Checked;
		}
		//-------------------------------------------------------------------------
		private void chkTrigSourceSync_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigSourceExtHw.Checked = !chkTrigSourceSync.Checked;
		}
		//-------------------------------------------------------------------------
		private void chkTrigTypeEdge_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigTypeLevel.Checked = !chkTrigTypeEdge.Checked;
		}
		//-------------------------------------------------------------------------
		private void chkTrigTypeLevel_CheckedChanged(object sender, System.EventArgs e)
		{
			chkTrigTypeEdge.Checked = !chkTrigTypeLevel.Checked;
		}
		//-------------------------------------------------------------------------
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		//-------------------------------------------------------------------------
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			AnalogIO AFrame = new AnalogIO();
			AFrame.m_DeviceHandle = m_DeviceHandle;	
			AFrame.ShowDialog();
		}
		//-------------------------------------------------------------------------
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			DigitalIO DFrame = new DigitalIO();
			DFrame.m_DeviceHandle = m_DeviceHandle;
			DFrame.ShowDialog();
		}
		//-------------------------------------------------------------------------
		
		private const int WM_USER = 0x400;
		private const int WM_MEAS_READY = WM_USER + 1;
		private const int WM_DBG_INFOAs = WM_USER + 2;
		private const int WM_DEVICE_RESET = WM_USER + 3;
		
		protected override void WndProc(ref Message a_WinMess)
		{
			ulong l_Ticks = 0;
            double l_AvgScantimeRAM;
			
			if (a_WinMess.Msg == WM_MEAS_READY)
			{
                if ((int)a_WinMess.WParam >= avaspec.ERR_SUCCESS)
                {
                    if (avaspec.ERR_SUCCESS == (int)a_WinMess.WParam) // normal measurements
                    {
                        StatusBar1.Panels[1].Text = "Meas.Status: success";

                        if (m_NrPixels > 0)
                        {
                            avaspec.PixelArrayType l_pSpectrum = new avaspec.PixelArrayType();
                            avaspec.SaturatedArrayType l_pSaturated = new avaspec.SaturatedArrayType();
                            avaspec.PixelArrayType m_Lambda = new avaspec.PixelArrayType();

                            if (0 == (int)avaspec.AVS_GetLambda((IntPtr)m_DeviceHandle, ref m_Lambda))
                            {
                                ;
                            }
                            uint l_Time = 0;
                            if (avaspec.ERR_SUCCESS == (int)avaspec.AVS_GetScopeData((IntPtr)m_DeviceHandle, ref l_Time, ref l_pSpectrum))
                            {
                                double l_Dif = (l_Time - m_PreviousTimeStamp) / 100.0;  //l_Time in 10 us ticks
                                m_PreviousTimeStamp = l_Time;
                                if (l_Dif != 0)
                                {
                                    edtLastScanTime.Text = string.Format("{0:F}", l_Dif); // millisec
                                }
                                avaspec.AVS_GetSaturatedPixels((IntPtr)m_DeviceHandle, ref l_pSaturated);

                                if ((numUpDown.Value >= m_StartPixels) && (numUpDown.Value <= m_StopPixels))
                                {
                                    edtWaveLength.Text = string.Format("{0:F2}", m_Lambda.Value[(int)numUpDown.Value]);
                                    edtCounts.Text = string.Format("{0:F2}", l_pSpectrum.Value[(int)numUpDown.Value]);
                                }
                            }
                            else
                            {
                                StatusBar1.Panels[1].Text = "Meas.Status: no data avail.";
                            }
                        }
                        m_Measurements++;
                        l_Ticks = (ulong)Environment.TickCount;
                        edtTotalTime.Text = System.Convert.ToString((l_Ticks - m_StartTicks) / 1000);
                        edtPerformedScans.Text = m_Measurements.ToString();
                        edtAvgTimePerScan.Text = string.Format("{0:F}", (1.0 * (l_Ticks - m_StartTicks) / m_Measurements));

                        if (System.Convert.ToInt32(edtNrOfScans.Text) > 0)
                            btnStartMeasurement.Enabled = (System.Convert.ToUInt32(edtNrOfScans.Text) == m_Measurements);
                    }
                    else    // a WParam > 0 indicates a response to StoreToRam
                            // using StoreToRAM requires firmware version 0.20.0.0 or later
                            // a_WinMess.WParam holds the number of scans stored in RAM
                            // import into application by call to AVS_GetScopeData for each scan
                    {
                        StatusBar1.Panels[1].Text = "Meas.Status: Reading RAM";
                        l_AvgScantimeRAM = 0.0;
                        for (int j = 1; j <= a_WinMess.WParam.ToInt32(); j++)
                        {
                            avaspec.PixelArrayType l_pSpectrum = new avaspec.PixelArrayType();
                            uint l_Time = 0;
                            if (avaspec.ERR_SUCCESS == avaspec.AVS_GetScopeData((IntPtr)m_DeviceHandle, ref l_Time, ref l_pSpectrum))
                            {
                                double l_Dif = l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
                                m_PreviousTimeStamp = l_Time;
                                if (l_Dif != 0)
                                {
                                    edtLastScanTime.Text = (l_Dif / 100.0).ToString("#####0.00"); //millisec
                                }
                                // calculate average scan duration from TimeStamp
                                if (j > 1)
                                {
                                    l_AvgScantimeRAM = (l_AvgScantimeRAM * (j - 2) + l_Dif / 100.0) / (j - 1);
                                    edtAvgTimePerScan.Text = l_AvgScantimeRAM.ToString("#####0.00");
                                }
                            }
                            else
                            {
                                StatusBar1.Panels[1].Text = "Meas.Status: no data avail.";
                            }
                            // l_pSpectrum = null;
                            l_Ticks = (ulong)Environment.TickCount;
                            edtTotalTime.Text = ((l_Ticks - m_StartTicks) / 1000.0).ToString();
                            edtPerformedScans.Text = j.ToString();
                        }
                        StatusBar1.Panels[1].Text = "Finished Reading RAM";
                        btnStartMeasurement.Enabled = true;
                    }
                }
                else // message.WParam < 0 indicates error 
                {
                    StatusBar1.Panels[1].Text = "Meas.Status: failed. Error " + a_WinMess.WParam.ToString();
                    m_Failures++;
                }
                edtFailures.Text = m_Failures.ToString();
//				base.WndProc(ref a_WinMess);
			}
			else
			{
				base.WndProc(ref a_WinMess);
			}
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			if (m_DeviceHandle!=avaspec.INVALID_AVS_HANDLE_VALUE)
			{
				int l_Res = (int)avaspec.AVS_StopMeasure((IntPtr)m_DeviceHandle);
		
				if (avaspec.ERR_SUCCESS != l_Res)
				{
					MessageBox.Show ("Error in AVS_StopMeasure, code: " + l_Res.ToString(), "Avantes", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			avaspec.AVS_Done();
		}

        private void chkPreScan_CheckedChanged(object sender, EventArgs e)
        {
            int l_Res = avaspec.AVS_SetPrescanMode((IntPtr)m_DeviceHandle, chkPreScan.Checked);
            if (l_Res != avaspec.ERR_SUCCESS)
            {
                MessageBox.Show("Error in AVS_SetPrescanMode, code: " + l_Res.ToString(), "Avantes",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}

#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include <vcclr.h>
#include <time.h>
#include <string>
#include <windows.h>
#include "avaspec.h"
#include "DigitalIO.h"
#include "AnalogIO.h"
#pragma once

namespace Test {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Runtime::InteropServices;	
	/// <summary>
	/// Summary for Form1
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^  gbMeasure;
	private: System::Windows::Forms::Button^  btnStopMeasurement;
	private: System::Windows::Forms::Button^  btnStartMeasurement;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  tbLastScanTime;
	private: System::Windows::Forms::TextBox^  tbAvgTimePerScan;
	private: System::Windows::Forms::TextBox^  tbFailures;
	private: System::Windows::Forms::TextBox^  tbPerformedScans;
	private: System::Windows::Forms::TextBox^  tbTotalTime;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::TextBox^  tbNrOfScans;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::MenuStrip^  menuStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^  exitToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  configureHardwareToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  analogIOToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^  digitalIOToolStripMenuItem;
	private: System::Windows::Forms::GroupBox^  gbInfo;
	private: System::Windows::Forms::TextBox^  edtNrOfPixels;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::TextBox^  edtDetectorname;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::GroupBox^  gbOutput;
	private: System::Windows::Forms::GroupBox^  gbVersionInfo;
	private: System::Windows::Forms::TextBox^  edtDLLver;
	private: System::Windows::Forms::TextBox^  edtFWver;
	private: System::Windows::Forms::TextBox^  edtFPGAver;
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::GroupBox^  gbPrepareMeasSettings;
	private: System::Windows::Forms::TextBox^  edtStopPixel;
	private: System::Windows::Forms::TextBox^  edtIntegrationTime;
	private: System::Windows::Forms::TextBox^  edtIntegrationDelay;
	private: System::Windows::Forms::TextBox^  edtNrOfAverages;
	private: System::Windows::Forms::TextBox^  edtSaturationLevel;
	private: System::Windows::Forms::TextBox^  edtStartPixel;
	private: System::Windows::Forms::Label^  label18;
	private: System::Windows::Forms::Label^  label17;
	private: System::Windows::Forms::Label^  label16;
	private: System::Windows::Forms::Label^  label15;
	private: System::Windows::Forms::Label^  label14;
	private: System::Windows::Forms::Label^  label13;
	private: System::Windows::Forms::GroupBox^  gbTrigger;
    private: System::Windows::Forms::CheckBox^  chkPrescan;
	private: System::Windows::Forms::GroupBox^  gbControl;
	private: System::Windows::Forms::GroupBox^  gbSmoothing;
	private: System::Windows::Forms::GroupBox^  gbDarkCorrection;
	private: System::Windows::Forms::Label^  label24;
	private: System::Windows::Forms::Label^  label23;
	private: System::Windows::Forms::TextBox^  edtSmoothPix;
	private: System::Windows::Forms::TextBox^  edtSmoothModel;
	private: System::Windows::Forms::Label^  label22;
	private: System::Windows::Forms::CheckBox^  chkEnableDarkCorrection;
	private: System::Windows::Forms::TextBox^  edtDarkHist;
	private: System::Windows::Forms::Label^  label26;
	private: System::Windows::Forms::Label^  label25;
	private: System::Windows::Forms::TextBox^  edtRamSpectra;
	private: System::Windows::Forms::TextBox^  edtLaserWavelength;
	private: System::Windows::Forms::TextBox^  edtLaserWidth;
	private: System::Windows::Forms::TextBox^  edtLaserDelay;
	private: System::Windows::Forms::TextBox^  edtFlashesPerScan;
	private: System::Windows::Forms::Label^  label30;
	private: System::Windows::Forms::Label^  label29;
	private: System::Windows::Forms::Label^  label28;
	private: System::Windows::Forms::Label^  label27;
	private: System::Windows::Forms::Label^  label31;
	private: System::Windows::Forms::Label^  label34;
	private: System::Windows::Forms::Label^  label33;
	private: System::Windows::Forms::Label^  label32;
	private: System::Windows::Forms::StatusStrip^  StatusBar;
	private: System::Windows::Forms::ToolStripStatusLabel^  Status1;
	private: System::Windows::Forms::ToolStripStatusLabel^  Status2;
	private: System::Windows::Forms::ToolStripStatusLabel^  Status3;
	private: System::Windows::Forms::ListBox^  lbList1;
	private: System::Windows::Forms::ListBox^  lbList2;
	private: System::Windows::Forms::Button^  btnActivate;
	private: System::Windows::Forms::Button^  btnDeactivate;
	
	protected: 
		
	private:
		AnalogIO			dlgAnalogIO;
		DigitalIO			dlgDigitalIO;
		long				m_DeviceHandle;
		int					m_NrDevices;
		unsigned int		m_NrOfPixels;
		uint16				m_StartPixel;
		uint16				m_StopPixel;
		double				*m_pLambda;
		unsigned long		m_StartTicks;
		unsigned int		m_Measurements;
		bool				m_GraphicsDisabled;
		unsigned int		m_PreviousTimeStamp;
		AvsIdentityType*    l_pId;
		char*               l_pData;
		bool				m_stopscan;
		long				m_Failures;
		short				m_OldValue;
		unsigned char		m_MeasuringDevices ;
private: System::Windows::Forms::GroupBox^  gbDataAcqui;


private: System::Windows::Forms::Label^  label35;
private: System::Windows::Forms::Label^  Wavelenght;
private: System::Windows::Forms::TextBox^  tbWaveLen;
private: System::Windows::Forms::TextBox^  tbCounts;
private: System::Windows::Forms::Label^  label36;
private: System::Windows::Forms::NumericUpDown^  nudPixel;
private: System::Windows::Forms::Label^  lSepcSerNr;
private: System::Windows::Forms::Button^  btnReadMeasFromEEProm;
private: System::Windows::Forms::Button^  btnWriteMeasToEEProm;
private: System::Windows::Forms::Timer^  timer1;
private: System::Windows::Forms::GroupBox^  groupBox1;
private: System::Windows::Forms::RadioButton^  SoftwareRBtn;
private: System::Windows::Forms::RadioButton^  HardwareRBtn;
private: System::Windows::Forms::GroupBox^  groupBox2;
private: System::Windows::Forms::RadioButton^  SynchronizedRBtn;
private: System::Windows::Forms::RadioButton^  ExternalRBtn;
private: System::Windows::Forms::GroupBox^  groupBox3;
private: System::Windows::Forms::RadioButton^  LevelRBtn;
private: System::Windows::Forms::RadioButton^  EdgeRBtn;
private: System::ComponentModel::IContainer^  components;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		
#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->gbMeasure = (gcnew System::Windows::Forms::GroupBox());
			this->chkPrescan = (gcnew System::Windows::Forms::CheckBox());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->tbNrOfScans = (gcnew System::Windows::Forms::TextBox());
			this->btnStopMeasurement = (gcnew System::Windows::Forms::Button());
			this->btnStartMeasurement = (gcnew System::Windows::Forms::Button());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->tbLastScanTime = (gcnew System::Windows::Forms::TextBox());
			this->tbAvgTimePerScan = (gcnew System::Windows::Forms::TextBox());
			this->tbFailures = (gcnew System::Windows::Forms::TextBox());
			this->tbPerformedScans = (gcnew System::Windows::Forms::TextBox());
			this->tbTotalTime = (gcnew System::Windows::Forms::TextBox());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->exitToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->configureHardwareToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->analogIOToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->digitalIOToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->gbInfo = (gcnew System::Windows::Forms::GroupBox());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->edtNrOfPixels = (gcnew System::Windows::Forms::TextBox());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->edtDetectorname = (gcnew System::Windows::Forms::TextBox());
			this->gbOutput = (gcnew System::Windows::Forms::GroupBox());
			this->gbVersionInfo = (gcnew System::Windows::Forms::GroupBox());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->edtDLLver = (gcnew System::Windows::Forms::TextBox());
			this->edtFWver = (gcnew System::Windows::Forms::TextBox());
			this->edtFPGAver = (gcnew System::Windows::Forms::TextBox());
			this->gbPrepareMeasSettings = (gcnew System::Windows::Forms::GroupBox());
			this->label26 = (gcnew System::Windows::Forms::Label());
			this->label25 = (gcnew System::Windows::Forms::Label());
			this->gbControl = (gcnew System::Windows::Forms::GroupBox());
			this->label34 = (gcnew System::Windows::Forms::Label());
			this->label33 = (gcnew System::Windows::Forms::Label());
			this->label32 = (gcnew System::Windows::Forms::Label());
			this->label31 = (gcnew System::Windows::Forms::Label());
			this->label30 = (gcnew System::Windows::Forms::Label());
			this->label29 = (gcnew System::Windows::Forms::Label());
			this->label28 = (gcnew System::Windows::Forms::Label());
			this->label27 = (gcnew System::Windows::Forms::Label());
			this->edtRamSpectra = (gcnew System::Windows::Forms::TextBox());
			this->edtLaserWavelength = (gcnew System::Windows::Forms::TextBox());
			this->edtLaserWidth = (gcnew System::Windows::Forms::TextBox());
			this->edtLaserDelay = (gcnew System::Windows::Forms::TextBox());
			this->edtFlashesPerScan = (gcnew System::Windows::Forms::TextBox());
			this->gbSmoothing = (gcnew System::Windows::Forms::GroupBox());
			this->label24 = (gcnew System::Windows::Forms::Label());
			this->label23 = (gcnew System::Windows::Forms::Label());
			this->edtSmoothPix = (gcnew System::Windows::Forms::TextBox());
			this->edtSmoothModel = (gcnew System::Windows::Forms::TextBox());
			this->gbDarkCorrection = (gcnew System::Windows::Forms::GroupBox());
			this->label22 = (gcnew System::Windows::Forms::Label());
			this->chkEnableDarkCorrection = (gcnew System::Windows::Forms::CheckBox());
			this->edtDarkHist = (gcnew System::Windows::Forms::TextBox());
			this->gbTrigger = (gcnew System::Windows::Forms::GroupBox());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->LevelRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->EdgeRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->SynchronizedRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->ExternalRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->SoftwareRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->HardwareRBtn = (gcnew System::Windows::Forms::RadioButton());
			this->label18 = (gcnew System::Windows::Forms::Label());
			this->label17 = (gcnew System::Windows::Forms::Label());
			this->label16 = (gcnew System::Windows::Forms::Label());
			this->label15 = (gcnew System::Windows::Forms::Label());
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->edtStopPixel = (gcnew System::Windows::Forms::TextBox());
			this->edtIntegrationTime = (gcnew System::Windows::Forms::TextBox());
			this->edtIntegrationDelay = (gcnew System::Windows::Forms::TextBox());
			this->edtNrOfAverages = (gcnew System::Windows::Forms::TextBox());
			this->edtSaturationLevel = (gcnew System::Windows::Forms::TextBox());
			this->edtStartPixel = (gcnew System::Windows::Forms::TextBox());
			this->StatusBar = (gcnew System::Windows::Forms::StatusStrip());
			this->Status1 = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->Status2 = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->Status3 = (gcnew System::Windows::Forms::ToolStripStatusLabel());
			this->lbList1 = (gcnew System::Windows::Forms::ListBox());
			this->lbList2 = (gcnew System::Windows::Forms::ListBox());
			this->btnActivate = (gcnew System::Windows::Forms::Button());
			this->btnDeactivate = (gcnew System::Windows::Forms::Button());
			this->gbDataAcqui = (gcnew System::Windows::Forms::GroupBox());
			this->lSepcSerNr = (gcnew System::Windows::Forms::Label());
			this->nudPixel = (gcnew System::Windows::Forms::NumericUpDown());
			this->label36 = (gcnew System::Windows::Forms::Label());
			this->label35 = (gcnew System::Windows::Forms::Label());
			this->Wavelenght = (gcnew System::Windows::Forms::Label());
			this->tbWaveLen = (gcnew System::Windows::Forms::TextBox());
			this->tbCounts = (gcnew System::Windows::Forms::TextBox());
			this->btnReadMeasFromEEProm = (gcnew System::Windows::Forms::Button());
			this->btnWriteMeasToEEProm = (gcnew System::Windows::Forms::Button());
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->gbMeasure->SuspendLayout();
			this->menuStrip1->SuspendLayout();
			this->gbInfo->SuspendLayout();
			this->gbOutput->SuspendLayout();
			this->gbVersionInfo->SuspendLayout();
			this->gbPrepareMeasSettings->SuspendLayout();
			this->gbControl->SuspendLayout();
			this->gbSmoothing->SuspendLayout();
			this->gbDarkCorrection->SuspendLayout();
			this->gbTrigger->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox1->SuspendLayout();
			this->StatusBar->SuspendLayout();
			this->gbDataAcqui->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->nudPixel))->BeginInit();
			this->SuspendLayout();
			// 
			// gbMeasure
			// 
			this->gbMeasure->Controls->Add(this->chkPrescan);
			this->gbMeasure->Controls->Add(this->label7);
			this->gbMeasure->Controls->Add(this->label6);
			this->gbMeasure->Controls->Add(this->tbNrOfScans);
			this->gbMeasure->Controls->Add(this->btnStopMeasurement);
			this->gbMeasure->Controls->Add(this->btnStartMeasurement);
			this->gbMeasure->Location = System::Drawing::Point(649, 24);
			this->gbMeasure->Margin = System::Windows::Forms::Padding(2);
			this->gbMeasure->Name = L"gbMeasure";
			this->gbMeasure->Padding = System::Windows::Forms::Padding(2);
			this->gbMeasure->Size = System::Drawing::Size(190, 168);
			this->gbMeasure->TabIndex = 0;
			this->gbMeasure->TabStop = false;
			this->gbMeasure->Text = L"Measure";
			// 
			// chkPrescan
			// 
			this->chkPrescan->AutoSize = true;
			this->chkPrescan->Location = System::Drawing::Point(16, 137);
			this->chkPrescan->Name = L"chkPrescan";
			this->chkPrescan->Size = System::Drawing::Size(141, 17);
			this->chkPrescan->TabIndex = 15;
			this->chkPrescan->Text = L"AvaSpec-3648 PreScan";
			this->chkPrescan->UseVisualStyleBackColor = true;
			this->chkPrescan->Visible = false;
			this->chkPrescan->CheckedChanged += gcnew System::EventHandler(this, &Form1::chkPrescan_CheckedChanged);
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(13, 33);
			this->label7->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(64, 13);
			this->label7->TabIndex = 14;
			this->label7->Text = L"(-1 = infinite)";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(13, 20);
			this->label6->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(61, 13);
			this->label6->TabIndex = 13;
			this->label6->Text = L"Nr of scans";
			// 
			// tbNrOfScans
			// 
			this->tbNrOfScans->Location = System::Drawing::Point(80, 17);
			this->tbNrOfScans->Margin = System::Windows::Forms::Padding(2);
			this->tbNrOfScans->Name = L"tbNrOfScans";
			this->tbNrOfScans->Size = System::Drawing::Size(76, 20);
			this->tbNrOfScans->TabIndex = 12;
			this->tbNrOfScans->Text = L"-1";
			// 
			// btnStopMeasurement
			// 
			this->btnStopMeasurement->Location = System::Drawing::Point(39, 87);
			this->btnStopMeasurement->Margin = System::Windows::Forms::Padding(2);
			this->btnStopMeasurement->Name = L"btnStopMeasurement";
			this->btnStopMeasurement->Size = System::Drawing::Size(130, 35);
			this->btnStopMeasurement->TabIndex = 1;
			this->btnStopMeasurement->Text = L"Stop Measurement";
			this->btnStopMeasurement->UseVisualStyleBackColor = true;
			this->btnStopMeasurement->Click += gcnew System::EventHandler(this, &Form1::btnStopMeasurement_Click);
			// 
			// btnStartMeasurement
			// 
			this->btnStartMeasurement->Location = System::Drawing::Point(39, 48);
			this->btnStartMeasurement->Margin = System::Windows::Forms::Padding(2);
			this->btnStartMeasurement->Name = L"btnStartMeasurement";
			this->btnStartMeasurement->Size = System::Drawing::Size(130, 35);
			this->btnStartMeasurement->TabIndex = 0;
			this->btnStartMeasurement->Text = L"Start Measurement";
			this->btnStartMeasurement->UseVisualStyleBackColor = true;
			this->btnStartMeasurement->Click += gcnew System::EventHandler(this, &Form1::btnStartMeasurement_Click);
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(36, 110);
			this->label5->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(64, 13);
			this->label5->TabIndex = 11;
			this->label5->Text = L"Last scan in";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(18, 88);
			this->label4->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(85, 13);
			this->label4->TabIndex = 10;
			this->label4->Text = L"AVG Time/Scan";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(32, 65);
			this->label3->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(66, 13);
			this->label3->TabIndex = 9;
			this->label3->Text = L"Nr of failures";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(39, 44);
			this->label2->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(61, 13);
			this->label2->TabIndex = 8;
			this->label2->Text = L"Nr of scans";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(18, 20);
			this->label1->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(81, 13);
			this->label1->TabIndex = 7;
			this->label1->Text = L"Time since start";
			// 
			// tbLastScanTime
			// 
			this->tbLastScanTime->Location = System::Drawing::Point(104, 108);
			this->tbLastScanTime->Margin = System::Windows::Forms::Padding(2);
			this->tbLastScanTime->Name = L"tbLastScanTime";
			this->tbLastScanTime->Size = System::Drawing::Size(53, 20);
			this->tbLastScanTime->TabIndex = 6;
			// 
			// tbAvgTimePerScan
			// 
			this->tbAvgTimePerScan->Location = System::Drawing::Point(104, 85);
			this->tbAvgTimePerScan->Margin = System::Windows::Forms::Padding(2);
			this->tbAvgTimePerScan->Name = L"tbAvgTimePerScan";
			this->tbAvgTimePerScan->Size = System::Drawing::Size(53, 20);
			this->tbAvgTimePerScan->TabIndex = 5;
			// 
			// tbFailures
			// 
			this->tbFailures->Location = System::Drawing::Point(104, 63);
			this->tbFailures->Margin = System::Windows::Forms::Padding(2);
			this->tbFailures->Name = L"tbFailures";
			this->tbFailures->Size = System::Drawing::Size(53, 20);
			this->tbFailures->TabIndex = 4;
			// 
			// tbPerformedScans
			// 
			this->tbPerformedScans->Location = System::Drawing::Point(104, 40);
			this->tbPerformedScans->Margin = System::Windows::Forms::Padding(2);
			this->tbPerformedScans->Name = L"tbPerformedScans";
			this->tbPerformedScans->Size = System::Drawing::Size(53, 20);
			this->tbPerformedScans->TabIndex = 3;
			// 
			// tbTotalTime
			// 
			this->tbTotalTime->Location = System::Drawing::Point(104, 17);
			this->tbTotalTime->Margin = System::Windows::Forms::Padding(2);
			this->tbTotalTime->Name = L"tbTotalTime";
			this->tbTotalTime->Size = System::Drawing::Size(53, 20);
			this->tbTotalTime->TabIndex = 2;
			// 
			// menuStrip1
			// 
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {this->exitToolStripMenuItem, 
				this->configureHardwareToolStripMenuItem});
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Padding = System::Windows::Forms::Padding(4, 2, 0, 2);
			this->menuStrip1->Size = System::Drawing::Size(863, 24);
			this->menuStrip1->TabIndex = 1;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this->exitToolStripMenuItem->Name = L"exitToolStripMenuItem";
			this->exitToolStripMenuItem->Size = System::Drawing::Size(37, 20);
			this->exitToolStripMenuItem->Text = L"Exit";
			this->exitToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::exitToolStripMenuItem_Click);
			// 
			// configureHardwareToolStripMenuItem
			// 
			this->configureHardwareToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {this->analogIOToolStripMenuItem, 
				this->digitalIOToolStripMenuItem});
			this->configureHardwareToolStripMenuItem->Name = L"configureHardwareToolStripMenuItem";
			this->configureHardwareToolStripMenuItem->Size = System::Drawing::Size(116, 20);
			this->configureHardwareToolStripMenuItem->Text = L"Configure Hardware";
			// 
			// analogIOToolStripMenuItem
			// 
			this->analogIOToolStripMenuItem->Name = L"analogIOToolStripMenuItem";
			this->analogIOToolStripMenuItem->Size = System::Drawing::Size(133, 22);
			this->analogIOToolStripMenuItem->Text = L"Analog IO";
			this->analogIOToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::analogIOToolStripMenuItem_Click);
			// 
			// digitalIOToolStripMenuItem
			// 
			this->digitalIOToolStripMenuItem->Name = L"digitalIOToolStripMenuItem";
			this->digitalIOToolStripMenuItem->Size = System::Drawing::Size(133, 22);
			this->digitalIOToolStripMenuItem->Text = L"Digital IO";
			this->digitalIOToolStripMenuItem->Click += gcnew System::EventHandler(this, &Form1::digitalIOToolStripMenuItem_Click);
			// 
			// gbInfo
			// 
			this->gbInfo->Controls->Add(this->label9);
			this->gbInfo->Controls->Add(this->edtNrOfPixels);
			this->gbInfo->Controls->Add(this->label8);
			this->gbInfo->Controls->Add(this->edtDetectorname);
			this->gbInfo->Location = System::Drawing::Point(649, 196);
			this->gbInfo->Margin = System::Windows::Forms::Padding(2);
			this->gbInfo->Name = L"gbInfo";
			this->gbInfo->Padding = System::Windows::Forms::Padding(2);
			this->gbInfo->Size = System::Drawing::Size(189, 76);
			this->gbInfo->TabIndex = 12;
			this->gbInfo->TabStop = false;
			this->gbInfo->Text = L"Selected Device Info";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(4, 46);
			this->label9->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(62, 13);
			this->label9->TabIndex = 3;
			this->label9->Text = L"Nr Of Pixels";
			// 
			// edtNrOfPixels
			// 
			this->edtNrOfPixels->Location = System::Drawing::Point(125, 41);
			this->edtNrOfPixels->Margin = System::Windows::Forms::Padding(2);
			this->edtNrOfPixels->Name = L"edtNrOfPixels";
			this->edtNrOfPixels->ReadOnly = true;
			this->edtNrOfPixels->Size = System::Drawing::Size(60, 20);
			this->edtNrOfPixels->TabIndex = 2;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(4, 20);
			this->label8->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(48, 13);
			this->label8->TabIndex = 1;
			this->label8->Text = L"Detector";
			// 
			// edtDetectorname
			// 
			this->edtDetectorname->Location = System::Drawing::Point(56, 17);
			this->edtDetectorname->Margin = System::Windows::Forms::Padding(2);
			this->edtDetectorname->Name = L"edtDetectorname";
			this->edtDetectorname->ReadOnly = true;
			this->edtDetectorname->Size = System::Drawing::Size(129, 20);
			this->edtDetectorname->TabIndex = 0;
			// 
			// gbOutput
			// 
			this->gbOutput->Controls->Add(this->tbTotalTime);
			this->gbOutput->Controls->Add(this->tbPerformedScans);
			this->gbOutput->Controls->Add(this->tbFailures);
			this->gbOutput->Controls->Add(this->tbAvgTimePerScan);
			this->gbOutput->Controls->Add(this->label5);
			this->gbOutput->Controls->Add(this->label1);
			this->gbOutput->Controls->Add(this->label4);
			this->gbOutput->Controls->Add(this->label2);
			this->gbOutput->Controls->Add(this->label3);
			this->gbOutput->Controls->Add(this->tbLastScanTime);
			this->gbOutput->Location = System::Drawing::Point(649, 290);
			this->gbOutput->Margin = System::Windows::Forms::Padding(2);
			this->gbOutput->Name = L"gbOutput";
			this->gbOutput->Padding = System::Windows::Forms::Padding(2);
			this->gbOutput->Size = System::Drawing::Size(190, 133);
			this->gbOutput->TabIndex = 13;
			this->gbOutput->TabStop = false;
			this->gbOutput->Text = L"Measurement Statistics";
			// 
			// gbVersionInfo
			// 
			this->gbVersionInfo->Controls->Add(this->label12);
			this->gbVersionInfo->Controls->Add(this->label11);
			this->gbVersionInfo->Controls->Add(this->label10);
			this->gbVersionInfo->Controls->Add(this->edtDLLver);
			this->gbVersionInfo->Controls->Add(this->edtFWver);
			this->gbVersionInfo->Controls->Add(this->edtFPGAver);
			this->gbVersionInfo->Location = System::Drawing::Point(9, 331);
			this->gbVersionInfo->Margin = System::Windows::Forms::Padding(2);
			this->gbVersionInfo->Name = L"gbVersionInfo";
			this->gbVersionInfo->Padding = System::Windows::Forms::Padding(2);
			this->gbVersionInfo->Size = System::Drawing::Size(228, 92);
			this->gbVersionInfo->TabIndex = 14;
			this->gbVersionInfo->TabStop = false;
			this->gbVersionInfo->Text = L"Version Info";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(26, 65);
			this->label12->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(65, 13);
			this->label12->TabIndex = 5;
			this->label12->Text = L"DLL Version";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(3, 42);
			this->label11->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(87, 13);
			this->label11->TabIndex = 4;
			this->label11->Text = L"Firmware Version";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(18, 20);
			this->label10->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(73, 13);
			this->label10->TabIndex = 3;
			this->label10->Text = L"FPGA Version";
			// 
			// edtDLLver
			// 
			this->edtDLLver->Location = System::Drawing::Point(95, 63);
			this->edtDLLver->Margin = System::Windows::Forms::Padding(2);
			this->edtDLLver->Name = L"edtDLLver";
			this->edtDLLver->ReadOnly = true;
			this->edtDLLver->Size = System::Drawing::Size(129, 20);
			this->edtDLLver->TabIndex = 2;
			// 
			// edtFWver
			// 
			this->edtFWver->Location = System::Drawing::Point(95, 40);
			this->edtFWver->Margin = System::Windows::Forms::Padding(2);
			this->edtFWver->Name = L"edtFWver";
			this->edtFWver->ReadOnly = true;
			this->edtFWver->Size = System::Drawing::Size(129, 20);
			this->edtFWver->TabIndex = 1;
			// 
			// edtFPGAver
			// 
			this->edtFPGAver->Location = System::Drawing::Point(95, 17);
			this->edtFPGAver->Margin = System::Windows::Forms::Padding(2);
			this->edtFPGAver->Name = L"edtFPGAver";
			this->edtFPGAver->ReadOnly = true;
			this->edtFPGAver->Size = System::Drawing::Size(129, 20);
			this->edtFPGAver->TabIndex = 0;
			// 
			// gbPrepareMeasSettings
			// 
			this->gbPrepareMeasSettings->Controls->Add(this->label26);
			this->gbPrepareMeasSettings->Controls->Add(this->label25);
			this->gbPrepareMeasSettings->Controls->Add(this->gbControl);
			this->gbPrepareMeasSettings->Controls->Add(this->gbSmoothing);
			this->gbPrepareMeasSettings->Controls->Add(this->gbDarkCorrection);
			this->gbPrepareMeasSettings->Controls->Add(this->gbTrigger);
			this->gbPrepareMeasSettings->Controls->Add(this->label18);
			this->gbPrepareMeasSettings->Controls->Add(this->label17);
			this->gbPrepareMeasSettings->Controls->Add(this->label16);
			this->gbPrepareMeasSettings->Controls->Add(this->label15);
			this->gbPrepareMeasSettings->Controls->Add(this->label14);
			this->gbPrepareMeasSettings->Controls->Add(this->label13);
			this->gbPrepareMeasSettings->Controls->Add(this->edtStopPixel);
			this->gbPrepareMeasSettings->Controls->Add(this->edtIntegrationTime);
			this->gbPrepareMeasSettings->Controls->Add(this->edtIntegrationDelay);
			this->gbPrepareMeasSettings->Controls->Add(this->edtNrOfAverages);
			this->gbPrepareMeasSettings->Controls->Add(this->edtSaturationLevel);
			this->gbPrepareMeasSettings->Controls->Add(this->edtStartPixel);
			this->gbPrepareMeasSettings->Location = System::Drawing::Point(241, 24);
			this->gbPrepareMeasSettings->Margin = System::Windows::Forms::Padding(2);
			this->gbPrepareMeasSettings->Name = L"gbPrepareMeasSettings";
			this->gbPrepareMeasSettings->Padding = System::Windows::Forms::Padding(2);
			this->gbPrepareMeasSettings->Size = System::Drawing::Size(404, 399);
			this->gbPrepareMeasSettings->TabIndex = 15;
			this->gbPrepareMeasSettings->TabStop = false;
			this->gbPrepareMeasSettings->Text = L"Prepare Measurement Settings";
			// 
			// label26
			// 
			this->label26->AutoSize = true;
			this->label26->Location = System::Drawing::Point(191, 88);
			this->label26->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label26->Name = L"label26";
			this->label26->Size = System::Drawing::Size(18, 13);
			this->label26->TabIndex = 29;
			this->label26->Text = L"ns";
			// 
			// label25
			// 
			this->label25->AutoSize = true;
			this->label25->Location = System::Drawing::Point(191, 65);
			this->label25->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label25->Name = L"label25";
			this->label25->Size = System::Drawing::Size(20, 13);
			this->label25->TabIndex = 29;
			this->label25->Text = L"ms";
			// 
			// gbControl
			// 
			this->gbControl->Controls->Add(this->label34);
			this->gbControl->Controls->Add(this->label33);
			this->gbControl->Controls->Add(this->label32);
			this->gbControl->Controls->Add(this->label31);
			this->gbControl->Controls->Add(this->label30);
			this->gbControl->Controls->Add(this->label29);
			this->gbControl->Controls->Add(this->label28);
			this->gbControl->Controls->Add(this->label27);
			this->gbControl->Controls->Add(this->edtRamSpectra);
			this->gbControl->Controls->Add(this->edtLaserWavelength);
			this->gbControl->Controls->Add(this->edtLaserWidth);
			this->gbControl->Controls->Add(this->edtLaserDelay);
			this->gbControl->Controls->Add(this->edtFlashesPerScan);
			this->gbControl->Location = System::Drawing::Point(204, 220);
			this->gbControl->Margin = System::Windows::Forms::Padding(2);
			this->gbControl->Name = L"gbControl";
			this->gbControl->Padding = System::Windows::Forms::Padding(2);
			this->gbControl->Size = System::Drawing::Size(196, 164);
			this->gbControl->TabIndex = 28;
			this->gbControl->TabStop = false;
			this->gbControl->Text = L"Control Settings";
			// 
			// label34
			// 
			this->label34->AutoSize = true;
			this->label34->Location = System::Drawing::Point(165, 86);
			this->label34->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label34->Name = L"label34";
			this->label34->Size = System::Drawing::Size(21, 13);
			this->label34->TabIndex = 29;
			this->label34->Text = L"nm";
			// 
			// label33
			// 
			this->label33->AutoSize = true;
			this->label33->Location = System::Drawing::Point(165, 63);
			this->label33->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label33->Name = L"label33";
			this->label33->Size = System::Drawing::Size(18, 13);
			this->label33->TabIndex = 29;
			this->label33->Text = L"ns";
			// 
			// label32
			// 
			this->label32->AutoSize = true;
			this->label32->Location = System::Drawing::Point(165, 41);
			this->label32->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label32->Name = L"label32";
			this->label32->Size = System::Drawing::Size(18, 13);
			this->label32->TabIndex = 29;
			this->label32->Text = L"ns";
			// 
			// label31
			// 
			this->label31->AutoSize = true;
			this->label31->Location = System::Drawing::Point(15, 109);
			this->label31->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label31->Name = L"label31";
			this->label31->Size = System::Drawing::Size(83, 13);
			this->label31->TabIndex = 7;
			this->label31->Text = L"Spectra to RAM";
			// 
			// label30
			// 
			this->label30->AutoSize = true;
			this->label30->Location = System::Drawing::Point(6, 86);
			this->label30->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label30->Name = L"label30";
			this->label30->Size = System::Drawing::Size(91, 13);
			this->label30->TabIndex = 6;
			this->label30->Text = L"Laser wavelength";
			// 
			// label29
			// 
			this->label29->AutoSize = true;
			this->label29->Location = System::Drawing::Point(35, 63);
			this->label29->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label29->Name = L"label29";
			this->label29->Size = System::Drawing::Size(61, 13);
			this->label29->TabIndex = 5;
			this->label29->Text = L"Laser width";
			// 
			// label28
			// 
			this->label28->AutoSize = true;
			this->label28->Location = System::Drawing::Point(34, 41);
			this->label28->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label28->Name = L"label28";
			this->label28->Size = System::Drawing::Size(61, 13);
			this->label28->TabIndex = 4;
			this->label28->Text = L"Laser delay";
			// 
			// label27
			// 
			this->label27->AutoSize = true;
			this->label27->Location = System::Drawing::Point(7, 20);
			this->label27->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label27->Name = L"label27";
			this->label27->Size = System::Drawing::Size(89, 13);
			this->label27->TabIndex = 3;
			this->label27->Text = L"Flashes per Scan";
			// 
			// edtRamSpectra
			// 
			this->edtRamSpectra->Location = System::Drawing::Point(100, 106);
			this->edtRamSpectra->Margin = System::Windows::Forms::Padding(2);
			this->edtRamSpectra->Name = L"edtRamSpectra";
			this->edtRamSpectra->Size = System::Drawing::Size(62, 20);
			this->edtRamSpectra->TabIndex = 2;
			this->edtRamSpectra->Text = L"0";
			// 
			// edtLaserWavelength
			// 
			this->edtLaserWavelength->Location = System::Drawing::Point(100, 84);
			this->edtLaserWavelength->Margin = System::Windows::Forms::Padding(2);
			this->edtLaserWavelength->Name = L"edtLaserWavelength";
			this->edtLaserWavelength->Size = System::Drawing::Size(62, 20);
			this->edtLaserWavelength->TabIndex = 2;
			this->edtLaserWavelength->Text = L"785";
			// 
			// edtLaserWidth
			// 
			this->edtLaserWidth->Location = System::Drawing::Point(100, 61);
			this->edtLaserWidth->Margin = System::Windows::Forms::Padding(2);
			this->edtLaserWidth->Name = L"edtLaserWidth";
			this->edtLaserWidth->Size = System::Drawing::Size(62, 20);
			this->edtLaserWidth->TabIndex = 2;
			this->edtLaserWidth->Text = L"10000";
			// 
			// edtLaserDelay
			// 
			this->edtLaserDelay->Location = System::Drawing::Point(100, 38);
			this->edtLaserDelay->Margin = System::Windows::Forms::Padding(2);
			this->edtLaserDelay->Name = L"edtLaserDelay";
			this->edtLaserDelay->Size = System::Drawing::Size(62, 20);
			this->edtLaserDelay->TabIndex = 2;
			this->edtLaserDelay->Text = L"0";
			// 
			// edtFlashesPerScan
			// 
			this->edtFlashesPerScan->Location = System::Drawing::Point(100, 17);
			this->edtFlashesPerScan->Margin = System::Windows::Forms::Padding(2);
			this->edtFlashesPerScan->Name = L"edtFlashesPerScan";
			this->edtFlashesPerScan->Size = System::Drawing::Size(62, 20);
			this->edtFlashesPerScan->TabIndex = 2;
			this->edtFlashesPerScan->Text = L"0";
			// 
			// gbSmoothing
			// 
			this->gbSmoothing->Controls->Add(this->label24);
			this->gbSmoothing->Controls->Add(this->label23);
			this->gbSmoothing->Controls->Add(this->edtSmoothPix);
			this->gbSmoothing->Controls->Add(this->edtSmoothModel);
			this->gbSmoothing->Location = System::Drawing::Point(213, 67);
			this->gbSmoothing->Margin = System::Windows::Forms::Padding(2);
			this->gbSmoothing->Name = L"gbSmoothing";
			this->gbSmoothing->Padding = System::Windows::Forms::Padding(2);
			this->gbSmoothing->Size = System::Drawing::Size(187, 63);
			this->gbSmoothing->TabIndex = 27;
			this->gbSmoothing->TabStop = false;
			this->gbSmoothing->Text = L"Smoothing Settings";
			// 
			// label24
			// 
			this->label24->AutoSize = true;
			this->label24->Location = System::Drawing::Point(14, 42);
			this->label24->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label24->Name = L"label24";
			this->label24->Size = System::Drawing::Size(62, 13);
			this->label24->TabIndex = 4;
			this->label24->Text = L"Nr Of Pixels";
			// 
			// label23
			// 
			this->label23->AutoSize = true;
			this->label23->Location = System::Drawing::Point(41, 20);
			this->label23->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label23->Name = L"label23";
			this->label23->Size = System::Drawing::Size(36, 13);
			this->label23->TabIndex = 3;
			this->label23->Text = L"Model";
			// 
			// edtSmoothPix
			// 
			this->edtSmoothPix->Location = System::Drawing::Point(80, 40);
			this->edtSmoothPix->Margin = System::Windows::Forms::Padding(2);
			this->edtSmoothPix->Name = L"edtSmoothPix";
			this->edtSmoothPix->Size = System::Drawing::Size(62, 20);
			this->edtSmoothPix->TabIndex = 2;
			this->edtSmoothPix->Text = L"100";
			// 
			// edtSmoothModel
			// 
			this->edtSmoothModel->Location = System::Drawing::Point(80, 17);
			this->edtSmoothModel->Margin = System::Windows::Forms::Padding(2);
			this->edtSmoothModel->Name = L"edtSmoothModel";
			this->edtSmoothModel->Size = System::Drawing::Size(62, 20);
			this->edtSmoothModel->TabIndex = 1;
			this->edtSmoothModel->Text = L"100";
			// 
			// gbDarkCorrection
			// 
			this->gbDarkCorrection->Controls->Add(this->label22);
			this->gbDarkCorrection->Controls->Add(this->chkEnableDarkCorrection);
			this->gbDarkCorrection->Controls->Add(this->edtDarkHist);
			this->gbDarkCorrection->Location = System::Drawing::Point(213, 17);
			this->gbDarkCorrection->Margin = System::Windows::Forms::Padding(2);
			this->gbDarkCorrection->Name = L"gbDarkCorrection";
			this->gbDarkCorrection->Padding = System::Windows::Forms::Padding(2);
			this->gbDarkCorrection->Size = System::Drawing::Size(187, 46);
			this->gbDarkCorrection->TabIndex = 26;
			this->gbDarkCorrection->TabStop = false;
			this->gbDarkCorrection->Text = L"Dark Correction Settings";
			// 
			// label22
			// 
			this->label22->AutoSize = true;
			this->label22->Location = System::Drawing::Point(146, 20);
			this->label22->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label22->Name = L"label22";
			this->label22->Size = System::Drawing::Size(15, 13);
			this->label22->TabIndex = 2;
			this->label22->Text = L"%";
			// 
			// chkEnableDarkCorrection
			// 
			this->chkEnableDarkCorrection->AutoSize = true;
			this->chkEnableDarkCorrection->Location = System::Drawing::Point(4, 19);
			this->chkEnableDarkCorrection->Margin = System::Windows::Forms::Padding(2);
			this->chkEnableDarkCorrection->Name = L"chkEnableDarkCorrection";
			this->chkEnableDarkCorrection->Size = System::Drawing::Size(59, 17);
			this->chkEnableDarkCorrection->TabIndex = 1;
			this->chkEnableDarkCorrection->Text = L"Enable";
			this->chkEnableDarkCorrection->UseVisualStyleBackColor = true;
			// 
			// edtDarkHist
			// 
			this->edtDarkHist->Location = System::Drawing::Point(80, 17);
			this->edtDarkHist->Margin = System::Windows::Forms::Padding(2);
			this->edtDarkHist->Name = L"edtDarkHist";
			this->edtDarkHist->Size = System::Drawing::Size(62, 20);
			this->edtDarkHist->TabIndex = 0;
			this->edtDarkHist->Text = L"100";
			// 
			// gbTrigger
			// 
			this->gbTrigger->Controls->Add(this->groupBox3);
			this->gbTrigger->Controls->Add(this->groupBox2);
			this->gbTrigger->Controls->Add(this->groupBox1);
			this->gbTrigger->Location = System::Drawing::Point(7, 180);
			this->gbTrigger->Margin = System::Windows::Forms::Padding(2);
			this->gbTrigger->Name = L"gbTrigger";
			this->gbTrigger->Padding = System::Windows::Forms::Padding(2);
			this->gbTrigger->Size = System::Drawing::Size(193, 204);
			this->gbTrigger->TabIndex = 25;
			this->gbTrigger->TabStop = false;
			this->gbTrigger->Text = L"Trigger Settings";
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->LevelRBtn);
			this->groupBox3->Controls->Add(this->EdgeRBtn);
			this->groupBox3->Location = System::Drawing::Point(10, 136);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(171, 59);
			this->groupBox3->TabIndex = 11;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"Trigger Type";
			// 
			// LevelRBtn
			// 
			this->LevelRBtn->AutoSize = true;
			this->LevelRBtn->Location = System::Drawing::Point(79, 37);
			this->LevelRBtn->Name = L"LevelRBtn";
			this->LevelRBtn->Size = System::Drawing::Size(51, 17);
			this->LevelRBtn->TabIndex = 7;
			this->LevelRBtn->TabStop = true;
			this->LevelRBtn->Text = L"Level";
			this->LevelRBtn->UseVisualStyleBackColor = true;
			// 
			// EdgeRBtn
			// 
			this->EdgeRBtn->AutoSize = true;
			this->EdgeRBtn->Location = System::Drawing::Point(79, 14);
			this->EdgeRBtn->Name = L"EdgeRBtn";
			this->EdgeRBtn->Size = System::Drawing::Size(50, 17);
			this->EdgeRBtn->TabIndex = 6;
			this->EdgeRBtn->TabStop = true;
			this->EdgeRBtn->Text = L"Edge";
			this->EdgeRBtn->UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->SynchronizedRBtn);
			this->groupBox2->Controls->Add(this->ExternalRBtn);
			this->groupBox2->Location = System::Drawing::Point(10, 73);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(171, 59);
			this->groupBox2->TabIndex = 10;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Trigger Source";
			// 
			// SynchronizedRBtn
			// 
			this->SynchronizedRBtn->AutoSize = true;
			this->SynchronizedRBtn->Location = System::Drawing::Point(79, 36);
			this->SynchronizedRBtn->Name = L"SynchronizedRBtn";
			this->SynchronizedRBtn->Size = System::Drawing::Size(89, 17);
			this->SynchronizedRBtn->TabIndex = 5;
			this->SynchronizedRBtn->TabStop = true;
			this->SynchronizedRBtn->Text = L"Synchronized";
			this->SynchronizedRBtn->UseVisualStyleBackColor = true;
			// 
			// ExternalRBtn
			// 
			this->ExternalRBtn->AutoSize = true;
			this->ExternalRBtn->Location = System::Drawing::Point(79, 16);
			this->ExternalRBtn->Name = L"ExternalRBtn";
			this->ExternalRBtn->Size = System::Drawing::Size(63, 17);
			this->ExternalRBtn->TabIndex = 4;
			this->ExternalRBtn->TabStop = true;
			this->ExternalRBtn->Text = L"External";
			this->ExternalRBtn->UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->SoftwareRBtn);
			this->groupBox1->Controls->Add(this->HardwareRBtn);
			this->groupBox1->Location = System::Drawing::Point(9, 16);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(171, 55);
			this->groupBox1->TabIndex = 9;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Trigger Mode";
			// 
			// SoftwareRBtn
			// 
			this->SoftwareRBtn->AutoSize = true;
			this->SoftwareRBtn->Location = System::Drawing::Point(80, 32);
			this->SoftwareRBtn->Name = L"SoftwareRBtn";
			this->SoftwareRBtn->Size = System::Drawing::Size(67, 17);
			this->SoftwareRBtn->TabIndex = 3;
			this->SoftwareRBtn->TabStop = true;
			this->SoftwareRBtn->Text = L"Software";
			this->SoftwareRBtn->UseVisualStyleBackColor = true;
			// 
			// HardwareRBtn
			// 
			this->HardwareRBtn->AutoSize = true;
			this->HardwareRBtn->Location = System::Drawing::Point(80, 11);
			this->HardwareRBtn->Name = L"HardwareRBtn";
			this->HardwareRBtn->Size = System::Drawing::Size(71, 17);
			this->HardwareRBtn->TabIndex = 2;
			this->HardwareRBtn->TabStop = true;
			this->HardwareRBtn->Text = L"Hardware";
			this->HardwareRBtn->UseVisualStyleBackColor = true;
			// 
			// label18
			// 
			this->label18->AutoSize = true;
			this->label18->Location = System::Drawing::Point(55, 20);
			this->label18->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label18->Name = L"label18";
			this->label18->Size = System::Drawing::Size(53, 13);
			this->label18->TabIndex = 24;
			this->label18->Text = L"Start pixel";
			// 
			// label17
			// 
			this->label17->AutoSize = true;
			this->label17->Location = System::Drawing::Point(25, 65);
			this->label17->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label17->Name = L"label17";
			this->label17->Size = System::Drawing::Size(83, 13);
			this->label17->TabIndex = 23;
			this->label17->Text = L"Integration Time";
			// 
			// label16
			// 
			this->label16->AutoSize = true;
			this->label16->Location = System::Drawing::Point(21, 88);
			this->label16->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label16->Name = L"label16";
			this->label16->Size = System::Drawing::Size(87, 13);
			this->label16->TabIndex = 22;
			this->label16->Text = L"Integration Delay";
			// 
			// label15
			// 
			this->label15->AutoSize = true;
			this->label15->Location = System::Drawing::Point(4, 110);
			this->label15->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label15->Name = L"label15";
			this->label15->Size = System::Drawing::Size(103, 13);
			this->label15->TabIndex = 21;
			this->label15->Text = L"Number of averages";
			// 
			// label14
			// 
			this->label14->AutoSize = true;
			this->label14->Location = System::Drawing::Point(6, 133);
			this->label14->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(102, 13);
			this->label14->TabIndex = 20;
			this->label14->Text = L"Saturation detection";
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(56, 42);
			this->label13->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(53, 13);
			this->label13->TabIndex = 19;
			this->label13->Text = L"Stop pixel";
			// 
			// edtStopPixel
			// 
			this->edtStopPixel->Location = System::Drawing::Point(112, 40);
			this->edtStopPixel->Margin = System::Windows::Forms::Padding(2);
			this->edtStopPixel->Name = L"edtStopPixel";
			this->edtStopPixel->Size = System::Drawing::Size(76, 20);
			this->edtStopPixel->TabIndex = 18;
			this->edtStopPixel->Text = L"2047";
			// 
			// edtIntegrationTime
			// 
			this->edtIntegrationTime->Location = System::Drawing::Point(112, 63);
			this->edtIntegrationTime->Margin = System::Windows::Forms::Padding(2);
			this->edtIntegrationTime->Name = L"edtIntegrationTime";
			this->edtIntegrationTime->Size = System::Drawing::Size(76, 20);
			this->edtIntegrationTime->TabIndex = 17;
			this->edtIntegrationTime->Text = L"100";
			// 
			// edtIntegrationDelay
			// 
			this->edtIntegrationDelay->Location = System::Drawing::Point(112, 85);
			this->edtIntegrationDelay->Margin = System::Windows::Forms::Padding(2);
			this->edtIntegrationDelay->Name = L"edtIntegrationDelay";
			this->edtIntegrationDelay->Size = System::Drawing::Size(76, 20);
			this->edtIntegrationDelay->TabIndex = 16;
			this->edtIntegrationDelay->Text = L"0";
			// 
			// edtNrOfAverages
			// 
			this->edtNrOfAverages->Location = System::Drawing::Point(112, 108);
			this->edtNrOfAverages->Margin = System::Windows::Forms::Padding(2);
			this->edtNrOfAverages->Name = L"edtNrOfAverages";
			this->edtNrOfAverages->Size = System::Drawing::Size(76, 20);
			this->edtNrOfAverages->TabIndex = 15;
			this->edtNrOfAverages->Text = L"1";
			// 
			// edtSaturationLevel
			// 
			this->edtSaturationLevel->Location = System::Drawing::Point(112, 131);
			this->edtSaturationLevel->Margin = System::Windows::Forms::Padding(2);
			this->edtSaturationLevel->Name = L"edtSaturationLevel";
			this->edtSaturationLevel->Size = System::Drawing::Size(76, 20);
			this->edtSaturationLevel->TabIndex = 14;
			this->edtSaturationLevel->Text = L"0";
			// 
			// edtStartPixel
			// 
			this->edtStartPixel->Location = System::Drawing::Point(112, 17);
			this->edtStartPixel->Margin = System::Windows::Forms::Padding(2);
			this->edtStartPixel->Name = L"edtStartPixel";
			this->edtStartPixel->Size = System::Drawing::Size(76, 20);
			this->edtStartPixel->TabIndex = 13;
			this->edtStartPixel->Text = L"0";
			// 
			// StatusBar
			// 
			this->StatusBar->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(3) {this->Status1, this->Status2, 
				this->Status3});
			this->StatusBar->Location = System::Drawing::Point(0, 443);
			this->StatusBar->Name = L"StatusBar";
			this->StatusBar->Padding = System::Windows::Forms::Padding(1, 0, 10, 0);
			this->StatusBar->Size = System::Drawing::Size(863, 22);
			this->StatusBar->TabIndex = 16;
			this->StatusBar->Text = L"Avantes";
			// 
			// Status1
			// 
			this->Status1->Name = L"Status1";
			this->Status1->Size = System::Drawing::Size(13, 17);
			this->Status1->Text = L"  ";
			// 
			// Status2
			// 
			this->Status2->Name = L"Status2";
			this->Status2->Size = System::Drawing::Size(13, 17);
			this->Status2->Text = L"  ";
			// 
			// Status3
			// 
			this->Status3->Name = L"Status3";
			this->Status3->Size = System::Drawing::Size(13, 17);
			this->Status3->Text = L"  ";
			// 
			// lbList1
			// 
			this->lbList1->FormattingEnabled = true;
			this->lbList1->Location = System::Drawing::Point(9, 24);
			this->lbList1->Margin = System::Windows::Forms::Padding(2);
			this->lbList1->Name = L"lbList1";
			this->lbList1->Size = System::Drawing::Size(78, 82);
			this->lbList1->TabIndex = 17;
			this->lbList1->SelectedIndexChanged += gcnew System::EventHandler(this, &Form1::lbList1_SelectedIndexChanged);
			// 
			// lbList2
			// 
			this->lbList2->Enabled = false;
			this->lbList2->FormattingEnabled = true;
			this->lbList2->Location = System::Drawing::Point(91, 24);
			this->lbList2->Margin = System::Windows::Forms::Padding(2);
			this->lbList2->Name = L"lbList2";
			this->lbList2->Size = System::Drawing::Size(146, 82);
			this->lbList2->TabIndex = 18;
			// 
			// btnActivate
			// 
			this->btnActivate->Location = System::Drawing::Point(9, 110);
			this->btnActivate->Margin = System::Windows::Forms::Padding(2);
			this->btnActivate->Name = L"btnActivate";
			this->btnActivate->Size = System::Drawing::Size(71, 23);
			this->btnActivate->TabIndex = 19;
			this->btnActivate->Text = L"Activate";
			this->btnActivate->UseVisualStyleBackColor = true;
			this->btnActivate->Click += gcnew System::EventHandler(this, &Form1::btnActivate_Click);
			// 
			// btnDeactivate
			// 
			this->btnDeactivate->Location = System::Drawing::Point(91, 110);
			this->btnDeactivate->Margin = System::Windows::Forms::Padding(2);
			this->btnDeactivate->Name = L"btnDeactivate";
			this->btnDeactivate->Size = System::Drawing::Size(71, 23);
			this->btnDeactivate->TabIndex = 20;
			this->btnDeactivate->Text = L"Deactivate";
			this->btnDeactivate->UseVisualStyleBackColor = true;
			this->btnDeactivate->Click += gcnew System::EventHandler(this, &Form1::btnDeactivate_Click);
			// 
			// gbDataAcqui
			// 
			this->gbDataAcqui->Controls->Add(this->lSepcSerNr);
			this->gbDataAcqui->Controls->Add(this->nudPixel);
			this->gbDataAcqui->Controls->Add(this->label36);
			this->gbDataAcqui->Controls->Add(this->label35);
			this->gbDataAcqui->Controls->Add(this->Wavelenght);
			this->gbDataAcqui->Controls->Add(this->tbWaveLen);
			this->gbDataAcqui->Controls->Add(this->tbCounts);
			this->gbDataAcqui->Location = System::Drawing::Point(9, 150);
			this->gbDataAcqui->Margin = System::Windows::Forms::Padding(2);
			this->gbDataAcqui->Name = L"gbDataAcqui";
			this->gbDataAcqui->Padding = System::Windows::Forms::Padding(2);
			this->gbDataAcqui->Size = System::Drawing::Size(228, 110);
			this->gbDataAcqui->TabIndex = 21;
			this->gbDataAcqui->TabStop = false;
			this->gbDataAcqui->Text = L"Data Acquisition";
			// 
			// lSepcSerNr
			// 
			this->lSepcSerNr->AutoSize = true;
			this->lSepcSerNr->Location = System::Drawing::Point(7, 12);
			this->lSepcSerNr->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->lSepcSerNr->Name = L"lSepcSerNr";
			this->lSepcSerNr->Size = System::Drawing::Size(0, 13);
			this->lSepcSerNr->TabIndex = 7;
			// 
			// nudPixel
			// 
			this->nudPixel->Location = System::Drawing::Point(108, 30);
			this->nudPixel->Margin = System::Windows::Forms::Padding(2);
			this->nudPixel->Name = L"nudPixel";
			this->nudPixel->Size = System::Drawing::Size(78, 20);
			this->nudPixel->TabIndex = 6;
			// 
			// label36
			// 
			this->label36->AutoSize = true;
			this->label36->Location = System::Drawing::Point(7, 30);
			this->label36->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label36->Name = L"label36";
			this->label36->Size = System::Drawing::Size(43, 13);
			this->label36->TabIndex = 5;
			this->label36->Text = L"Pixel Nr";
			// 
			// label35
			// 
			this->label35->AutoSize = true;
			this->label35->Location = System::Drawing::Point(7, 78);
			this->label35->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label35->Name = L"label35";
			this->label35->Size = System::Drawing::Size(40, 13);
			this->label35->TabIndex = 3;
			this->label35->Text = L"Counts";
			// 
			// Wavelenght
			// 
			this->Wavelenght->AutoSize = true;
			this->Wavelenght->Location = System::Drawing::Point(7, 54);
			this->Wavelenght->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->Wavelenght->Name = L"Wavelenght";
			this->Wavelenght->Size = System::Drawing::Size(88, 13);
			this->Wavelenght->TabIndex = 2;
			this->Wavelenght->Text = L"Wavelenght [nm]";
			// 
			// tbWaveLen
			// 
			this->tbWaveLen->Location = System::Drawing::Point(108, 54);
			this->tbWaveLen->Margin = System::Windows::Forms::Padding(2);
			this->tbWaveLen->Name = L"tbWaveLen";
			this->tbWaveLen->Size = System::Drawing::Size(78, 20);
			this->tbWaveLen->TabIndex = 1;
			// 
			// tbCounts
			// 
			this->tbCounts->Location = System::Drawing::Point(108, 78);
			this->tbCounts->Margin = System::Windows::Forms::Padding(2);
			this->tbCounts->Name = L"tbCounts";
			this->tbCounts->Size = System::Drawing::Size(78, 20);
			this->tbCounts->TabIndex = 0;
			// 
			// btnReadMeasFromEEProm
			// 
			this->btnReadMeasFromEEProm->Location = System::Drawing::Point(13, 278);
			this->btnReadMeasFromEEProm->Margin = System::Windows::Forms::Padding(2);
			this->btnReadMeasFromEEProm->Name = L"btnReadMeasFromEEProm";
			this->btnReadMeasFromEEProm->Size = System::Drawing::Size(91, 25);
			this->btnReadMeasFromEEProm->TabIndex = 22;
			this->btnReadMeasFromEEProm->Text = L"Read EEPROM";
			this->btnReadMeasFromEEProm->UseVisualStyleBackColor = true;
			this->btnReadMeasFromEEProm->Click += gcnew System::EventHandler(this, &Form1::btnReadMeasFromEEProm_Click);
			// 
			// btnWriteMeasToEEProm
			// 
			this->btnWriteMeasToEEProm->Location = System::Drawing::Point(124, 278);
			this->btnWriteMeasToEEProm->Margin = System::Windows::Forms::Padding(2);
			this->btnWriteMeasToEEProm->Name = L"btnWriteMeasToEEProm";
			this->btnWriteMeasToEEProm->Size = System::Drawing::Size(91, 25);
			this->btnWriteMeasToEEProm->TabIndex = 23;
			this->btnWriteMeasToEEProm->Text = L"Write EEPROM";
			this->btnWriteMeasToEEProm->UseVisualStyleBackColor = true;
			this->btnWriteMeasToEEProm->Click += gcnew System::EventHandler(this, &Form1::btnWriteMeasToEEProm_Click);
			// 
			// timer1
			// 
			this->timer1->Enabled = true;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(863, 465);
			this->Controls->Add(this->btnWriteMeasToEEProm);
			this->Controls->Add(this->btnReadMeasFromEEProm);
			this->Controls->Add(this->gbDataAcqui);
			this->Controls->Add(this->btnDeactivate);
			this->Controls->Add(this->btnActivate);
			this->Controls->Add(this->lbList2);
			this->Controls->Add(this->lbList1);
			this->Controls->Add(this->StatusBar);
			this->Controls->Add(this->gbPrepareMeasSettings);
			this->Controls->Add(this->gbVersionInfo);
			this->Controls->Add(this->gbOutput);
			this->Controls->Add(this->gbInfo);
			this->Controls->Add(this->gbMeasure);
			this->Controls->Add(this->menuStrip1);
			this->MainMenuStrip = this->menuStrip1;
			this->Margin = System::Windows::Forms::Padding(2);
			this->Name = L"Form1";
			this->Text = L"VC++ 2008";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &Form1::Form1_FormClosed);
			this->gbMeasure->ResumeLayout(false);
			this->gbMeasure->PerformLayout();
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->gbInfo->ResumeLayout(false);
			this->gbInfo->PerformLayout();
			this->gbOutput->ResumeLayout(false);
			this->gbOutput->PerformLayout();
			this->gbVersionInfo->ResumeLayout(false);
			this->gbVersionInfo->PerformLayout();
			this->gbPrepareMeasSettings->ResumeLayout(false);
			this->gbPrepareMeasSettings->PerformLayout();
			this->gbControl->ResumeLayout(false);
			this->gbControl->PerformLayout();
			this->gbSmoothing->ResumeLayout(false);
			this->gbSmoothing->PerformLayout();
			this->gbDarkCorrection->ResumeLayout(false);
			this->gbDarkCorrection->PerformLayout();
			this->gbTrigger->ResumeLayout(false);
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->StatusBar->ResumeLayout(false);
			this->StatusBar->PerformLayout();
			this->gbDataAcqui->ResumeLayout(false);
			this->gbDataAcqui->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->nudPixel))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	
	private: System::Void Form1_Load(System::Object^  sender, System::EventArgs^  e) 
	{
		/*******************************************************************************
							find connected spectrometers
		*******************************************************************************/ 
		this->btnStartMeasurement->Enabled = false;
		this->btnStopMeasurement->Enabled = false;
		m_OldValue = 0;
		m_NrDevices = 0;
		m_MeasuringDevices = 0;
		m_DeviceHandle = INVALID_AVS_HANDLE_VALUE;
		this->Status1->Text = "Open communication busy";
		long l_Port = AVS_Init(0);
		long l_Res = 0;//

		if (l_Port > 0) 
		{
			this->Status1->Text = "Connected: USB";
			UpdateList();
		}
		else
		{
			l_Res = AVS_Done();
			l_Port = AVS_Init(-1);
			//try Ethernet / USB
			if (l_Port > 0)
			{
				this->Status1->Text = "Connected: Ethernet / USB";
				UpdateList();
			}
			else
			{
				this->Status1->Text = "Open communication failed";
				l_Res = AVS_Done();
				MessageBox::Show("Open communication failed"); 
				Form1::Close();	
			}
		}
	}

	void Test::Form1::UpdateList(void)
	{
		unsigned int        l_Size = 0;
		unsigned int        l_RequiredSize = 0;		
		long l_Res = 0;

		l_pData = 0;
		l_pId = 0;
	
		m_NrDevices = AVS_GetNrOfDevices();
		l_RequiredSize = m_NrDevices * sizeof(AvsIdentityType);
    
		if (l_RequiredSize > 0) 
		{
			delete [] l_pData;
            l_pData = new char[l_RequiredSize];
            l_Size = l_RequiredSize;
            l_pId = (AvsIdentityType*)l_pData;
			m_NrDevices = AVS_GetList(l_Size, &l_RequiredSize, l_pId);

			this->lbList1->Items->Clear();
			this->lbList2->Items->Clear();

            for (int i = 0; i < m_NrDevices; i++)
            {
				lbList1->Items->Add(gcnew String(l_pId->SerialNumber));

                switch (l_pId->Status)
                {
                   case UNKNOWN                  : Status1->Text = "Unknown Device found!";
											       lbList2->Items->Add("UNKNOWN DEVICE FOUND");		
                                                   break;
				   case USB_AVAILABLE			 : Status1->Text = "Spectrometer found!";
											       lbList2->Items->Add("USB_AVAILABLE");					   
                                                   break;
				   case USB_IN_USE_BY_APPLICATION: Status1->Text = "Spectrometer is used by the application";
											       lbList2->Items->Add("USB_IN USE BY APPLICATION");					   	
                                                   break;
                   case USB_IN_USE_BY_OTHER      : Status1->Text = "Device is used by other application";
											       lbList2->Items->Add("USB_IN USE BY OTHER");					   	
                                                   break;
				   case ETH_AVAILABLE            : Status1->Text = "Spectrometer found!"; 
											       lbList2->Items->Add("ETH_AVAILABLE");					   
                                                   break;
                   case ETH_IN_USE_BY_APPLICATION: Status1->Text = "Spectrometer is used by the application";
											       lbList2->Items->Add("ETH_IN USE BY APPLICATION");					   	
                                                   break;
				   case	ETH_IN_USE_BY_OTHER      : Status1->Text = "Device is used by other application";
											       lbList2->Items->Add("ETH_IN USE BY OTHER");					   	
                                                   break;
                   default                       : Status1->Text = "??????";
											       lbList2->Items->Add("??????");					   	
                                                   break;
                }
                l_pId++;
            }
			if (this->lbList1->Items->Count == 1)
				this->lbList1->SelectedIndex = 0;
			this->lbList1->Refresh();
			this->lbList2->Refresh();
		}
	}

	void Test::Form1::ConnectGui(int a_DeviceHandle)
	{
		DeviceConfigType*  l_pDeviceData = NULL;
		unsigned short	l_NrOfPixel = 0;
		unsigned int    l_Size;
	
		char a_Fpga[16];
		char a_As5216[16];
		char a_Dll[16];
		
		m_pLambda = NULL;

		int l_Res = AVS_GetVersionInfo(a_DeviceHandle, a_Fpga, a_As5216, a_Dll);
    
		if (ERR_SUCCESS == l_Res)
		{
			edtFPGAver->Text= (gcnew String(a_Fpga));
			edtFWver->Text = (gcnew String(a_As5216));
			edtDLLver->Text = (gcnew String(a_Dll));
		}

		if (ERR_SUCCESS == AVS_GetNumPixels(a_DeviceHandle, &l_NrOfPixel))
		{
			m_NrOfPixels = l_NrOfPixel;
			edtNrOfPixels->Text = l_NrOfPixel.ToString();
		}

		l_Res = AVS_GetParameter(a_DeviceHandle, 0, &l_Size, l_pDeviceData);

		if ( l_Res == ERR_INVALID_SIZE)
		{
			l_pDeviceData = (DeviceConfigType*)new char[l_Size];
		}

		l_Res = AVS_GetParameter(a_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
  
		if (l_Res != ERR_SUCCESS)
		{
			DisconnectGui();
			return;
		}

		switch (l_pDeviceData->m_Detector.m_SensorType)
		{
			case SENS_HAMS8378_256      : edtDetectorname->Text = "HAMS8378_256";
								          break;
			case SENS_HAMS8378_1024     : edtDetectorname->Text = "HAMS8378_1024";
							              break;
			case SENS_ILX554            : edtDetectorname->Text = "ILX554";
						                  break;
			case SENS_HAMS9201          : edtDetectorname->Text = "HAMS9201";
					                      break;
			case SENS_TCD1304           : edtDetectorname->Text = "TCD1304";
                                          chkPrescan->Visible=true;
								          chkPrescan->Checked=true;
								          l_Res = AVS_SetPrescanMode(m_DeviceHandle, chkPrescan->Checked);
				                          break;
			case SENS_TSL1301           : edtDetectorname->Text = "TSL1301";
								          break;
			case SENS_TSL1401           : edtDetectorname->Text = "TSL1401";
							              break;
			case SENS_HAMS8378_512      : edtDetectorname->Text = "HAMS8378_512";
						                  break;
			case SENS_HAMS9840          : edtDetectorname->Text = "HAMS9840";
					                      break;
			case SENS_ILX511            : edtDetectorname->Text = "ILX511";
						                  break;
			case SENS_HAMS10420_2048X64 : edtDetectorname->Text = "HAMS10420_2048X64";
								          break;
			case SENS_HAMS11071_2048X64 : edtDetectorname->Text = "HAMS11071_2048X64";
								          break;
			case SENS_HAMS7031_1024X122 : edtDetectorname->Text = "HAMS7031_1024X122";
								          break;
			case SENS_HAMS7031_1024X58  : edtDetectorname->Text = "HAMS7031_1024X58";
							              break;
			case SENS_HAMS11071_2048X16 : edtDetectorname->Text = "HAMS11071_2048X16";
								          break;
            case SENS_HAMS11155_2048    : edtDetectorname->Text = "HAMS11155";
								          break;
			case SENS_SU256LSB          : edtDetectorname->Text = "SU256LSB";
								          break;
			case SENS_SU512LDB          : edtDetectorname->Text = "SU512LDB";
								          break;
			case SENS_HAMS11638         : edtDetectorname->Text = "HAMS11638";
				                          break;   
			case SENS_HAMS11639         : edtDetectorname->Text = "HAMS11639";
				                          break;
			case SENS_HAMS12443         : edtDetectorname->Text = "HAMS12443";
				                          break;
			case SENS_HAMG9208_512      : edtDetectorname->Text = "HAMG9208_512";
				                          break;
			default                     : edtDetectorname->Text = "???????";
				                          break;
		}

		m_StartPixel = l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel;
		m_StopPixel = l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel;
		edtStartPixel->Text = m_StartPixel.ToString() ;
		edtStopPixel->Text = m_StopPixel.ToString();

		m_StartTicks = Environment::TickCount;
		m_Measurements = 0;
		m_Failures = 0;
		tbTotalTime->Text = "0.0";
		tbPerformedScans->Text = "0";
		tbFailures->Text = "0";		

		if (NULL != m_pLambda)
		{
			// delete old structure because number of pixels can be changed.
			delete [] m_pLambda;
			m_pLambda = NULL;
		}
		m_pLambda = new double[m_NrOfPixels];

		if (ERR_SUCCESS == AVS_GetLambda(a_DeviceHandle, m_pLambda))
		{
			//do something e.g. initiate Chart for example
		}
		ShowMeasurementSettings(l_pDeviceData);
		delete [] l_pDeviceData;
	}

	void Test::Form1::DisconnectGui(void)
	{
		edtStartPixel->Text = " ";
		edtStopPixel->Text = " ";
		edtDetectorname->Text = " ";
		edtFPGAver->Text = " ";
		edtFWver->Text = " ";
		edtDLLver->Text = " ";
		edtNrOfPixels->Text = " ";
	}

	private: System::Void btnActivate_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		/*********************************************************************************
		                        Activate Spectrometer
		*********************************************************************************/
		long l_hDevice = 0;
		
		if (lbList1->SelectedIndex >= 0) 
		{		
			l_pId = (AvsIdentityType*)l_pData;
			l_hDevice = AVS_Activate(&l_pId[lbList1->SelectedIndex]);
         
			if (INVALID_AVS_HANDLE_VALUE == l_hDevice) 
			{
				MessageBox::Show ("Spectrometer already activated or invalid Handle: " + l_hDevice.ToString());
			}
			else
			{
				m_DeviceHandle = l_hDevice;
				UpdateList();
				ConnectGui(l_hDevice);
				btnStartMeasurement->Enabled = true;
				btnStopMeasurement->Enabled = true;
			}
		}
		else
		{
			MessageBox::Show ("Choose a spectrometer in the Listbox!");
		}
	}

	private: System::Void btnDeactivate_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		if (lbList1->SelectedIndex >= 0)
		{
			AVS_StopMeasure(m_DeviceHandle);
			AVS_Deactivate(m_DeviceHandle);
			m_DeviceHandle = INVALID_AVS_HANDLE_VALUE;
			UpdateList();
			DisconnectGui();
		}
		else
		{
			MessageBox::Show("Choose a spectrometer in the Listbox!");
		}
	}
	void Test::Form1::ShowMeasurementSettings(DeviceConfigType* a_pDeviceData)
	{
		double l_NanoSec = 0.0;
		long l_FPGAClkCycles = 0;
    
		//show measurement settings
		edtStartPixel->Text = a_pDeviceData->m_StandAlone.m_Meas.m_StartPixel.ToString();
		edtStopPixel->Text = a_pDeviceData->m_StandAlone.m_Meas.m_StopPixel.ToString();
		edtIntegrationTime->Text = a_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime.ToString();
		l_FPGAClkCycles = a_pDeviceData->m_StandAlone.m_Meas.m_IntegrationDelay;
		l_NanoSec = 125.0 * ((l_FPGAClkCycles - 1) / 6.0);
		edtIntegrationDelay->Text = l_NanoSec.ToString("#####0.00");
		edtNrOfAverages->Text = a_pDeviceData->m_StandAlone.m_Meas.m_NrAverages.ToString();
		edtSaturationLevel->Text = a_pDeviceData->m_StandAlone.m_Meas.m_SaturationDetection.ToString();

		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode == HW_TRIGGER_MODE) 
		{
			HardwareRBtn->Checked = true;
			SoftwareRBtn->Checked = false;
		}

		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode == SW_TRIGGER_MODE) 
		{
			HardwareRBtn->Checked = false;
			SoftwareRBtn->Checked = true;
		}
        
		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source == 0)
		{
			ExternalRBtn->Checked = true;
			SynchronizedRBtn->Checked = false;
		}

		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source == 1)
		{
			ExternalRBtn->Checked = false;
			SynchronizedRBtn->Checked = true;
		}
        
		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType == EDGE_TRIGGER_SOURCE)
		{
			EdgeRBtn->Checked = true;
			LevelRBtn->Checked = false;
		}
        
		if (a_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType == LEVEL_TRIGGER_SOURCE) 
		{
			EdgeRBtn->Checked = false;
			LevelRBtn->Checked = true;
		}
        
		if (a_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_Enable == 1)
			chkEnableDarkCorrection->Checked = 1;
		else
			chkEnableDarkCorrection->Checked = 0;
        
		edtDarkHist->Text = a_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage.ToString();
		edtSmoothModel->Text = a_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel.ToString();
		edtSmoothPix->Text = a_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix.ToString();
		edtFlashesPerScan->Text = a_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StrobeControl.ToString();
		l_FPGAClkCycles = a_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserDelay;
		l_NanoSec = 125.0 * l_FPGAClkCycles / 6.0;
		edtLaserDelay->Text = l_NanoSec.ToString();
		l_FPGAClkCycles = a_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWidth;
		l_NanoSec = 125.0 * (l_FPGAClkCycles) / 6.0;
		edtLaserWidth->Text = l_NanoSec.ToString();
		edtLaserWavelength->Text = a_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWaveLength.ToString();
		edtRamSpectra->Text = a_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam.ToString();
//		tbNrOfScans->Text = a_pDeviceData->m_StandAlone.m_Nmsr.ToString();
        
		nudPixel->Minimum = a_pDeviceData->m_StandAlone.m_Meas.m_StartPixel;
		nudPixel->Maximum = a_pDeviceData->m_StandAlone.m_Meas.m_StopPixel;
	}

	private: System::Void lbList1_SelectedIndexChanged(System::Object^  sender, System::EventArgs^  e) 
	{	
		l_pId = (AvsIdentityType*)l_pData;
		unsigned char l_Status = l_pId[lbList1->SelectedIndex].Status;

		if ((l_Status == USB_IN_USE_BY_APPLICATION) || (l_Status == ETH_IN_USE_BY_APPLICATION))
		{
			ConnectGui (m_DeviceHandle);		
			lSepcSerNr->Text = "Active Spectrometer: " + lbList1->SelectedItem->ToString();
		}
	}

	private: System::Void exitToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		Form1::Close();		 
	}

	private: System::Void analogIOToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
	{	
		if (lbList1->SelectedIndex >= 0)
		{
			dlgAnalogIO.label1->Text = "Analog I/O of Spectrometer " + lbList1->SelectedItem->ToString();
			dlgAnalogIO.m_DeviceHandle = m_DeviceHandle; 
			dlgAnalogIO.ShowDialog();
		}
		else
		{
			MessageBox::Show("Choose a spectrometer in the Listbox!");
		}	
	}

	private: System::Void digitalIOToolStripMenuItem_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		if (lbList1->SelectedIndex >= 0)
		{
			dlgDigitalIO.label16->Text = "Digital I/O of Spectrometer " + lbList1->SelectedItem->ToString();
			dlgDigitalIO.m_DeviceHandle = m_DeviceHandle; 
			dlgDigitalIO.ShowDialog();
		}
		else
		{
			MessageBox::Show("Choose a spectrometer in the Listbox!");
		}		
	}
	private: System::Void btnStartMeasurement_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		double l_NanoSec = 0.0;
		long l_Ticks = 0;
		long l_Dif = 0;
		unsigned int l_Time = 0;
		double* l_pSpectrum = NULL;
		uint8* l_pSaturated = NULL;
		uint32 l_FPGAClkCycles = 0;
		long l_Res = 0;
		unsigned char l_Status = 0;
		MeasConfigType l_PrepareMeasData;
		
		m_OldValue =  System::Convert::ToInt16(nudPixel->Value);

		if(lbList1->SelectedIndex >= 0)
		{
			l_pId = (AvsIdentityType*)l_pData;

			//for( int i = 0;i< m_NrDevices;i++)
			//{
				
				//l_Status = l_pId[i].Status;
				l_Status = l_pId[lbList1->SelectedIndex].Status;
				if ((l_Status == USB_IN_USE_BY_APPLICATION) || (l_Status == ETH_IN_USE_BY_APPLICATION))
				{
			//		ConnectGui (m_DeviceHandle);		        
					// StartPixel				
					l_PrepareMeasData.m_StartPixel = Convert::ToInt32(edtStartPixel->Text);
					// StopPixel
					l_PrepareMeasData.m_StopPixel = Convert::ToInt32(edtStopPixel->Text);
					// IntegrationTime			
					l_PrepareMeasData.m_IntegrationTime = Convert::ToSingle(edtIntegrationTime->Text);
					// IntegrationDelay
					l_NanoSec = Convert::ToDouble(edtIntegrationDelay->Text);
					l_FPGAClkCycles = (uint32)(6.0 * (l_NanoSec + 20.84) / 125.0);					
					l_PrepareMeasData.m_IntegrationDelay = l_FPGAClkCycles;
					// Number of Averages
					l_PrepareMeasData.m_NrAverages = Convert::ToInt32(edtNrOfAverages->Text);
					// DarkCorrectionType
					if (chkEnableDarkCorrection->Checked)
						l_PrepareMeasData.m_CorDynDark.m_Enable = 1;
					else
						l_PrepareMeasData.m_CorDynDark.m_Enable = 0;
					
					l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage = Convert::ToByte(edtDarkHist->Text);
					
					// SmoothingType
					l_PrepareMeasData.m_Smoothing.m_SmoothPix = Convert::ToInt16(edtSmoothPix->Text);				
					l_PrepareMeasData.m_Smoothing.m_SmoothModel = Convert::ToByte(edtSmoothModel->Text);
				
					// SaturationDetection
					l_PrepareMeasData.m_SaturationDetection = Convert::ToByte(edtSaturationLevel->Text);
					
					// TriggerType
					if (HardwareRBtn->Checked)
						l_PrepareMeasData.m_Trigger.m_Mode = 1;
					else
						l_PrepareMeasData.m_Trigger.m_Mode = 0;
					
					if (ExternalRBtn->Checked)
						l_PrepareMeasData.m_Trigger.m_Source = 0;
					else
						l_PrepareMeasData.m_Trigger.m_Source = 1;
					
					if (EdgeRBtn->Checked)
						l_PrepareMeasData.m_Trigger.m_SourceType = 0;
					else
						l_PrepareMeasData.m_Trigger.m_SourceType = 1;
					
					// ControlSettingsType
					l_PrepareMeasData.m_Control.m_StrobeControl = Convert::ToInt16(edtFlashesPerScan->Text);
					
					l_NanoSec = Convert::ToDouble(edtLaserDelay->Text);
					l_FPGAClkCycles = (uint32)(6.0 * l_NanoSec / 125.0);
					l_PrepareMeasData.m_Control.m_LaserDelay = l_FPGAClkCycles;

					
					l_NanoSec = Convert::ToDouble(edtLaserWidth->Text);
					l_FPGAClkCycles = (uint32)(6.0 * l_NanoSec / 125.0);
					l_PrepareMeasData.m_Control.m_LaserWidth = l_FPGAClkCycles;
							    
					l_PrepareMeasData.m_Control.m_LaserWaveLength = Convert::ToSingle(edtLaserWavelength->Text);				
					l_PrepareMeasData.m_Control.m_StoreToRam = Convert::ToInt16(edtRamSpectra->Text);
					
			        l_Res = AVS_PrepareMeasure(m_DeviceHandle, &l_PrepareMeasData);
			    
					if (ERR_SUCCESS != l_Res)
						MessageBox::Show("code:" +  l_Res.ToString());
					
					//Get Nr Of Scans
					int16 l_NrOfScans = Convert::ToInt16(tbNrOfScans->Text);
					if ((l_PrepareMeasData.m_Control.m_StoreToRam>0) && (l_NrOfScans!=1))
                    {
                      tbNrOfScans->Text = "1";
                      l_NrOfScans=1;
					  MessageBox::Show( l_PrepareMeasData.m_Control.m_StoreToRam.ToString() + " scans will be stored to RAM. " +
                               "The number of measurements (a_Nmsr in AVS_Measure) has been set to 1");
                    }
					
					// Start Measurement
					m_StartPixel = l_PrepareMeasData.m_StartPixel;
					m_StopPixel = l_PrepareMeasData.m_StopPixel;
					m_StartTicks = Environment::TickCount;
					m_Measurements = 0;
					m_Failures = 0;
					tbTotalTime->Text = "0.0";
					tbPerformedScans->Text = "0";
					tbFailures->Text = "0";				
			       
					nudPixel->Maximum = l_PrepareMeasData.m_StartPixel;
					nudPixel->Maximum = l_PrepareMeasData.m_StopPixel;

					if((m_OldValue > l_PrepareMeasData.m_StopPixel)||(m_OldValue < l_PrepareMeasData.m_StartPixel))
						nudPixel->Value = (l_PrepareMeasData.m_StopPixel - l_PrepareMeasData.m_StartPixel)/2;
					else
						nudPixel->Value = m_OldValue;

					void* hwnd = (void*) this->Handle;
					l_Res = AVS_Measure(m_DeviceHandle, hwnd, l_NrOfScans);
			        
					if (ERR_SUCCESS != l_Res)
					{
						switch (l_Res)
						{
							case ERR_INVALID_PARAMETER : Status1->Text = "Meas.Status: invalid parameter";
								 break;
							default:					 Status1->Text = "Meas.Status: start failed, code: " + l_Res.ToString();
								break;
						}
					}
					else
					{
						Status1->Text = "Meas.Status: pending";	
						m_MeasuringDevices++;
					}
		   		}
			//}
		}
		else
		{
			MessageBox::Show("Choose a spectrometer in the Listbox!");
		} 	
		btnActivate->Enabled = false;
		btnDeactivate->Enabled = false;
	}

	private: System::Void btnStopMeasurement_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		long l_Res = 0;
		unsigned char l_Status = 0;
		Status1->Text = "Meas.Status: stop";
		l_pId = (AvsIdentityType*)l_pData;
		l_Status = l_pId[lbList1->SelectedIndex].Status;
			
		if ((l_Status == USB_IN_USE_BY_APPLICATION) || (l_Status == ETH_IN_USE_BY_APPLICATION))
		{
			l_Res = AVS_StopMeasure(m_DeviceHandle);
			if(ERR_SUCCESS != l_Res)
			{
				MessageBox::Show("code:" + l_Res.ToString() + "Error");
			}
			else
			{
				m_MeasuringDevices--;
			}
		}
		if(m_MeasuringDevices==0)
		{
			btnDeactivate->Enabled = true;
			btnActivate->Enabled = true;
		}
	}
	
protected:
[System::Security::Permissions::PermissionSet(System::Security::Permissions::SecurityAction::Demand, Name="FullTrust")]
	virtual void WndProc( Message% m ) override
	{
		double temp = 0.0;
		// Listen for operating system messages.
		//const Int32 DBT_DEVTYP_DEVICEINTERFACE = 0x5;		//device interface class
		const Int32 DBT_DEVICEARRIVAL = 0x8000;            //system detected a new device
		//const Int32 DBT_DEVICEQUERYREMOVE = 0x8001;        //wants to remove, may fail
		//const Int32 DBT_DEVICEQUERYREMOVEFAILED = 0x8002;  //removal aborted
		//const Int32 DBT_DEVICEREMOVEPENDING = 0x8003;      //about to remove, still avail.
		const Int32 DBT_DEVICEREMOVECOMPLETE = 0x8004;     //device is gone
		//const Int32 DBT_DEVICETYPESPECIFIC = 0x8005;       //type specific event

		
		
		if(m.Msg ==  WM_DEVICECHANGE ) 
		{
			switch(m.WParam.ToInt32())
			{
			case DBT_DEVICEREMOVECOMPLETE:
               UpdateList();
			   break;
                                
			case DBT_DEVICEARRIVAL:
               UpdateList();
               break;

			default:
				break;
			}
		}
		

		switch (m.Msg) 
		{
			case WM_MEAS_READY:
				long l_Ticks;
				double l_AvgScantimeRAM;
				double* l_pSpectrum;

 				if (m.WParam.ToInt32() >= ERR_SUCCESS)
				{	
					uint8* l_pSaturated;
					uint32 l_Time = 0;
    
					if ( m.WParam.ToInt32() == ERR_SUCCESS)  //normal measurements
                    {
					Status1->Text = "Meas.Status: success";
					
				      if (lbList1->SelectedIndex >= 0)
					  {
						l_pSpectrum = new double[m_NrOfPixels];
						l_pSaturated = new uint8[m_NrOfPixels];
						m_pLambda = new double[m_NrOfPixels];
						long hwnd = long( m.LParam.ToInt64() );

						AVS_GetLambda(hwnd, m_pLambda);
						UInt32 l_Time;

						if (ERR_SUCCESS == AVS_GetScopeData(hwnd, &l_Time, l_pSpectrum))
						{
							
							AVS_GetSaturatedPixels(hwnd,l_pSaturated);
	                        
							if (hwnd == m_DeviceHandle)	
							{  
								double l_Dif = (l_Time - m_PreviousTimeStamp)/100.0; //l_Time in 10 us ticks
								
								if (l_Dif > 0)								
									tbLastScanTime->Text = l_Dif.ToString("#####0.00"); //millisec
                        
								m_PreviousTimeStamp = l_Time;
								m_Measurements++;
								
								tbCounts->Text = l_pSpectrum[System::Convert::ToInt32(nudPixel->Value)].ToString("#####0.00");
								tbWaveLen->Text = m_pLambda[System::Convert::ToInt32(nudPixel->Value)].ToString("####0.0");

								l_Ticks = Environment::TickCount & Int32::MaxValue;
								tbTotalTime->Text = ((l_Ticks - m_StartTicks) / 1000).ToString();
								tbPerformedScans->Text = m_Measurements.ToString();
								tbAvgTimePerScan->Text = (1.0 * (l_Ticks - m_StartTicks) / m_Measurements).ToString("#####0.00");
								tbFailures->Text = m_Failures.ToString(); 
							}      
						}
						else
						{
							Status1->Text = "Meas.Status: no data avail.";
						}
						delete[] l_pSpectrum;
						delete[] l_pSaturated;
						delete[] m_pLambda;
					}
					
				}
				else // a WParam > 0 indicates a response to StoreToRam
				     // using StoreToRAM requires firmware version 0.20.0.0 or later
                     // a_WinMess.WParam holds the number of scans stored in RAM
                     // import into application by call to AVS_GetScopeData for each scan
				{
					 Status1->Text = "Meas.Status: Reading RAM";
                     l_AvgScantimeRAM = 0.0;
                     for (int j = 1; j <= m.WParam.ToInt32(); j++)
                     {
                       l_pSpectrum = new double[m_NrOfPixels]; 
                       if (ERR_SUCCESS == AVS_GetScopeData(m_DeviceHandle, &l_Time, l_pSpectrum))
                       {
                         double l_Dif = l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
                         m_PreviousTimeStamp = l_Time;
                         if (l_Dif != 0)
                         {
                           tbLastScanTime->Text =(l_Dif/100.0).ToString(); //millisec
                         }
                         //calculate average scan duration from TimeStamp
                         if (j>1)
                         {
                           l_AvgScantimeRAM = (l_AvgScantimeRAM*(j-2)+l_Dif/100.0) / (j-1);
                           tbAvgTimePerScan->Text = l_AvgScantimeRAM.ToString();
                         }
                       }
                       else
                       {
						   Status1->Text = "Meas.Status: no data avail.";
                       }
					   delete[] l_pSpectrum;
                       l_Ticks = GetTickCount();
                       tbTotalTime->Text =  ((l_Ticks - m_StartTicks)/ 1000).ToString();
                       tbPerformedScans->Text = j.ToString();
                   }
                   Status1->Text = "Finished Reading RAM";
                   btnStartMeasurement->Enabled=true;
				}
			  }
			  else //message.WParam < 0 indicates error
              {
       			Status1->Text = "Meas.Status: failed. Error " + m.WParam.ToString();
				m_Failures++;
	          }  
		   	break;
		default:
			break;
		}
		Form::WndProc(m);
	}

	
	private: System::Void btnReadMeasFromEEProm_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		DeviceConfigType*  l_pDeviceData = NULL;
		unsigned short	l_NrOfPixel = 0;
		unsigned int    l_Size;
		
		int l_Res = AVS_GetParameter(m_DeviceHandle, 0, &l_Size, l_pDeviceData);
    
		if ( l_Res == ERR_INVALID_SIZE)
		{
			l_pDeviceData = (DeviceConfigType*)new char[l_Size];
		}

		l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
  
		if (l_Res != ERR_SUCCESS)
		{
			MessageBox::Show("code:" + l_Res.ToString() + "Error");
			return;
		}
   
		ShowMeasurementSettings(l_pDeviceData);
		delete [] l_pDeviceData;
	}


	private: System::Void btnWriteMeasToEEProm_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		DeviceConfigType*  l_pDeviceData = NULL;
		unsigned short	l_NrOfPixel = 0;
		unsigned int    l_Size;
		double l_NanoSec = 0.0;
		uint32 l_FPGAClkCycles = 0;

		int l_Res = AVS_GetParameter(m_DeviceHandle, 0, &l_Size, l_pDeviceData);
    
		if ( l_Res == ERR_INVALID_SIZE)
		{
			l_pDeviceData = (DeviceConfigType*)new char[l_Size];
		}

		l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
  
		if (l_Res != ERR_SUCCESS)
		{
			MessageBox::Show("AVS_GetParameter code:" + l_Res.ToString() + "Error");
			return;
		}

		 //Get measurement parameters from main window
		l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel = Convert::ToInt32(edtStartPixel->Text);
		l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel = Convert::ToInt32(edtStopPixel->Text);
		l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime = Convert::ToSingle(edtIntegrationTime->Text);
		l_NanoSec = Convert::ToDouble(edtIntegrationDelay->Text);
		l_FPGAClkCycles = (uint32)(6.0 * (l_NanoSec + 20.84) / 125.0);
		l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationDelay = l_FPGAClkCycles;
		l_pDeviceData->m_StandAlone.m_Meas.m_NrAverages = Convert::ToInt32(edtNrOfAverages->Text);
		
		if (HardwareRBtn->Checked)
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode = 1;
		else
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode = 0;
				
		if (SynchronizedRBtn->Checked)
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source = 1;
		else
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source = 0;
				
		if (LevelRBtn->Checked)
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType = 1;
		else
			l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType = 0;

		if (chkEnableDarkCorrection->Checked)
			l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1;
		else
			l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 0;
				
		l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage = Convert::ToByte(edtDarkHist->Text);			
		l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix = Convert::ToInt16(edtSmoothPix->Text);				
		l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel = Convert::ToByte(edtSmoothModel->Text);
		l_pDeviceData->m_StandAlone.m_Meas.m_SaturationDetection = Convert::ToByte(edtSaturationLevel->Text);
		l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StrobeControl = Convert::ToInt16(edtFlashesPerScan->Text);		
		l_NanoSec = Convert::ToDouble(edtLaserDelay->Text);
		l_FPGAClkCycles = (uint32)(6.0 * l_NanoSec / 125.0);
		l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserDelay = l_FPGAClkCycles;
		l_NanoSec = Convert::ToDouble(edtLaserWidth->Text);
		l_FPGAClkCycles = (uint32)(6.0 * l_NanoSec / 125.0);
		l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWidth = l_FPGAClkCycles;						    
		l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWaveLength = Convert::ToSingle(edtLaserWavelength->Text);				
		l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam = Convert::ToInt16(edtRamSpectra->Text);	
		l_pDeviceData->m_StandAlone.m_Nmsr = Convert::ToInt16(tbNrOfScans->Text);
		l_Res = AVS_SetParameter(m_DeviceHandle, l_pDeviceData);
    
		if (ERR_SUCCESS != l_Res)
			MessageBox::Show("AVS_SetParameter code:" + l_Res.ToString() + "Error");
	}

	private: System::Void Form1_FormClosed(System::Object^  sender, System::Windows::Forms::FormClosedEventArgs^  e) 
	{
		if (m_DeviceHandle != INVALID_AVS_HANDLE_VALUE)
		{
			long l_Res = AVS_StopMeasure(m_DeviceHandle);
			if (ERR_SUCCESS != l_Res)
				MessageBox::Show("code:" + l_Res.ToString() + "Error");
		}
		AVS_Done();
	}

private: System::Void chkPrescan_CheckedChanged(System::Object^  sender, System::EventArgs^  e) {
			 int l_Res = AVS_SetPrescanMode(m_DeviceHandle, chkPrescan->Checked);
             if (l_Res!=ERR_SUCCESS)
               MessageBox::Show("Error in AVS_SetPrescanMode, code "+ l_Res.ToString());
		 }

};

}



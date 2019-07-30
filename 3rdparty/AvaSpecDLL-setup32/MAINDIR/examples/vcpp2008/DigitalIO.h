#include "StdAfx.h"
#include "avaspec.h"
#pragma once

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;


namespace Test {

	/// <summary>
	/// Summary for DigitalIO
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class DigitalIO : public System::Windows::Forms::Form
	{
	public:
		DigitalIO(void)
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
		~DigitalIO()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::CheckBox^  chkDO1;
	private: System::Windows::Forms::CheckBox^  chkDO2;
	private: System::Windows::Forms::CheckBox^  chkDO3;
	private: System::Windows::Forms::CheckBox^  chkDO4;
	private: System::Windows::Forms::CheckBox^  chkDO5;
	private: System::Windows::Forms::CheckBox^  chkDO6;
	private: System::Windows::Forms::CheckBox^  chkDO7;
	private: System::Windows::Forms::CheckBox^  chkDO8;
	private: System::Windows::Forms::CheckBox^  chkDO9;
	private: System::Windows::Forms::CheckBox^  chkDO10;
	private: System::Windows::Forms::CheckBox^  chkPWM1;
	private: System::Windows::Forms::CheckBox^  chkPWM2;
	private: System::Windows::Forms::CheckBox^  chkPWM3;
	private: System::Windows::Forms::CheckBox^  chkPWM5;
	private: System::Windows::Forms::CheckBox^  chkPWM6;
	private: System::Windows::Forms::CheckBox^  chkPWM7;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::TextBox^  edtDuty1;
	private: System::Windows::Forms::TextBox^  edtDuty2;
	private: System::Windows::Forms::TextBox^  edtDuty3;
	private: System::Windows::Forms::TextBox^  edtDuty5;
	private: System::Windows::Forms::TextBox^  edtDuty6;
	private: System::Windows::Forms::TextBox^  edtDuty7;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::TextBox^  edtFreq123;
	private: System::Windows::Forms::TextBox^  edtFreq567;
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::GroupBox^  groupBox2;
	private: System::Windows::Forms::Button^  btnGetDigIn;
	private: System::Windows::Forms::Label^  label15;
	private: System::Windows::Forms::CheckBox^  chkDI3;
	private: System::Windows::Forms::CheckBox^  chkDI2;
	private: System::Windows::Forms::CheckBox^  chkDI1;
	private: System::Windows::Forms::Label^  label14;
	private: System::Windows::Forms::Label^  label13;
	public: System::Windows::Forms::Label^  label16;
	public:long m_DeviceHandle; 
	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->chkDO1 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO2 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO3 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO4 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO5 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO6 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO7 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO8 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO9 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDO10 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM1 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM2 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM3 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM5 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM6 = (gcnew System::Windows::Forms::CheckBox());
			this->chkPWM7 = (gcnew System::Windows::Forms::CheckBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->edtDuty1 = (gcnew System::Windows::Forms::TextBox());
			this->edtDuty2 = (gcnew System::Windows::Forms::TextBox());
			this->edtDuty3 = (gcnew System::Windows::Forms::TextBox());
			this->edtDuty5 = (gcnew System::Windows::Forms::TextBox());
			this->edtDuty6 = (gcnew System::Windows::Forms::TextBox());
			this->edtDuty7 = (gcnew System::Windows::Forms::TextBox());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->edtFreq123 = (gcnew System::Windows::Forms::TextBox());
			this->edtFreq567 = (gcnew System::Windows::Forms::TextBox());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->btnGetDigIn = (gcnew System::Windows::Forms::Button());
			this->label15 = (gcnew System::Windows::Forms::Label());
			this->chkDI3 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDI2 = (gcnew System::Windows::Forms::CheckBox());
			this->chkDI1 = (gcnew System::Windows::Forms::CheckBox());
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->label16 = (gcnew System::Windows::Forms::Label());
			this->groupBox1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->SuspendLayout();
			// 
			// chkDO1
			// 
			this->chkDO1->AutoSize = true;
			this->chkDO1->Location = System::Drawing::Point(72, 36);
			this->chkDO1->Name = L"chkDO1";
			this->chkDO1->Size = System::Drawing::Size(60, 21);
			this->chkDO1->TabIndex = 0;
			this->chkDO1->Text = L"DO 1";
			this->chkDO1->UseVisualStyleBackColor = true;
			this->chkDO1->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO1_CheckedChanged);
			// 
			// chkDO2
			// 
			this->chkDO2->AutoSize = true;
			this->chkDO2->Location = System::Drawing::Point(72, 63);
			this->chkDO2->Name = L"chkDO2";
			this->chkDO2->Size = System::Drawing::Size(60, 21);
			this->chkDO2->TabIndex = 1;
			this->chkDO2->Text = L"DO 2";
			this->chkDO2->UseVisualStyleBackColor = true;
			this->chkDO2->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO2_CheckedChanged);
			// 
			// chkDO3
			// 
			this->chkDO3->AutoSize = true;
			this->chkDO3->Location = System::Drawing::Point(72, 89);
			this->chkDO3->Name = L"chkDO3";
			this->chkDO3->Size = System::Drawing::Size(60, 21);
			this->chkDO3->TabIndex = 2;
			this->chkDO3->Text = L"DO 3";
			this->chkDO3->UseVisualStyleBackColor = true;
			this->chkDO3->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO3_CheckedChanged);
			// 
			// chkDO4
			// 
			this->chkDO4->AutoSize = true;
			this->chkDO4->Location = System::Drawing::Point(72, 116);
			this->chkDO4->Name = L"chkDO4";
			this->chkDO4->Size = System::Drawing::Size(60, 21);
			this->chkDO4->TabIndex = 3;
			this->chkDO4->Text = L"DO 4";
			this->chkDO4->UseVisualStyleBackColor = true;
			this->chkDO4->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO4_CheckedChanged);
			// 
			// chkDO5
			// 
			this->chkDO5->AutoSize = true;
			this->chkDO5->Location = System::Drawing::Point(72, 143);
			this->chkDO5->Name = L"chkDO5";
			this->chkDO5->Size = System::Drawing::Size(60, 21);
			this->chkDO5->TabIndex = 4;
			this->chkDO5->Text = L"DO 5";
			this->chkDO5->UseVisualStyleBackColor = true;
			this->chkDO5->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO5_CheckedChanged);
			// 
			// chkDO6
			// 
			this->chkDO6->AutoSize = true;
			this->chkDO6->Location = System::Drawing::Point(72, 170);
			this->chkDO6->Name = L"chkDO6";
			this->chkDO6->Size = System::Drawing::Size(60, 21);
			this->chkDO6->TabIndex = 5;
			this->chkDO6->Text = L"DO 6";
			this->chkDO6->UseVisualStyleBackColor = true;
			this->chkDO6->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO6_CheckedChanged);
			// 
			// chkDO7
			// 
			this->chkDO7->AutoSize = true;
			this->chkDO7->Location = System::Drawing::Point(72, 197);
			this->chkDO7->Name = L"chkDO7";
			this->chkDO7->Size = System::Drawing::Size(60, 21);
			this->chkDO7->TabIndex = 6;
			this->chkDO7->Text = L"DO 7";
			this->chkDO7->UseVisualStyleBackColor = true;
			this->chkDO7->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO7_CheckedChanged);
			// 
			// chkDO8
			// 
			this->chkDO8->AutoSize = true;
			this->chkDO8->Location = System::Drawing::Point(72, 224);
			this->chkDO8->Name = L"chkDO8";
			this->chkDO8->Size = System::Drawing::Size(60, 21);
			this->chkDO8->TabIndex = 7;
			this->chkDO8->Text = L"DO 8";
			this->chkDO8->UseVisualStyleBackColor = true;
			this->chkDO8->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO8_CheckedChanged);
			// 
			// chkDO9
			// 
			this->chkDO9->AutoSize = true;
			this->chkDO9->Location = System::Drawing::Point(72, 251);
			this->chkDO9->Name = L"chkDO9";
			this->chkDO9->Size = System::Drawing::Size(60, 21);
			this->chkDO9->TabIndex = 8;
			this->chkDO9->Text = L"DO 9";
			this->chkDO9->UseVisualStyleBackColor = true;
			this->chkDO9->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO9_CheckedChanged);
			// 
			// chkDO10
			// 
			this->chkDO10->AutoSize = true;
			this->chkDO10->Location = System::Drawing::Point(72, 278);
			this->chkDO10->Name = L"chkDO10";
			this->chkDO10->Size = System::Drawing::Size(68, 21);
			this->chkDO10->TabIndex = 9;
			this->chkDO10->Text = L"DO 10";
			this->chkDO10->UseVisualStyleBackColor = true;
			this->chkDO10->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkDO10_CheckedChanged);
			// 
			// chkPWM1
			// 
			this->chkPWM1->AutoSize = true;
			this->chkPWM1->Location = System::Drawing::Point(148, 35);
			this->chkPWM1->Name = L"chkPWM1";
			this->chkPWM1->Size = System::Drawing::Size(60, 21);
			this->chkPWM1->TabIndex = 10;
			this->chkPWM1->Text = L"PWM";
			this->chkPWM1->UseVisualStyleBackColor = true;
			this->chkPWM1->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM1_CheckedChanged);
			// 
			// chkPWM2
			// 
			this->chkPWM2->AutoSize = true;
			this->chkPWM2->Location = System::Drawing::Point(148, 63);
			this->chkPWM2->Name = L"chkPWM2";
			this->chkPWM2->Size = System::Drawing::Size(60, 21);
			this->chkPWM2->TabIndex = 11;
			this->chkPWM2->Text = L"PWM";
			this->chkPWM2->UseVisualStyleBackColor = true;
			this->chkPWM2->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM2_CheckedChanged);
			// 
			// chkPWM3
			// 
			this->chkPWM3->AutoSize = true;
			this->chkPWM3->Location = System::Drawing::Point(148, 89);
			this->chkPWM3->Name = L"chkPWM3";
			this->chkPWM3->Size = System::Drawing::Size(60, 21);
			this->chkPWM3->TabIndex = 12;
			this->chkPWM3->Text = L"PWM";
			this->chkPWM3->UseVisualStyleBackColor = true;
			this->chkPWM3->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM3_CheckedChanged);
			// 
			// chkPWM5
			// 
			this->chkPWM5->AutoSize = true;
			this->chkPWM5->Location = System::Drawing::Point(148, 143);
			this->chkPWM5->Name = L"chkPWM5";
			this->chkPWM5->Size = System::Drawing::Size(60, 21);
			this->chkPWM5->TabIndex = 13;
			this->chkPWM5->Text = L"PWM";
			this->chkPWM5->UseVisualStyleBackColor = true;
			this->chkPWM5->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM5_CheckedChanged);
			// 
			// chkPWM6
			// 
			this->chkPWM6->AutoSize = true;
			this->chkPWM6->Location = System::Drawing::Point(148, 170);
			this->chkPWM6->Name = L"chkPWM6";
			this->chkPWM6->Size = System::Drawing::Size(60, 21);
			this->chkPWM6->TabIndex = 14;
			this->chkPWM6->Text = L"PWM";
			this->chkPWM6->UseVisualStyleBackColor = true;
			this->chkPWM6->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM6_CheckedChanged);
			// 
			// chkPWM7
			// 
			this->chkPWM7->AutoSize = true;
			this->chkPWM7->Location = System::Drawing::Point(148, 197);
			this->chkPWM7->Name = L"chkPWM7";
			this->chkPWM7->Size = System::Drawing::Size(60, 21);
			this->chkPWM7->TabIndex = 15;
			this->chkPWM7->Text = L"PWM";
			this->chkPWM7->UseVisualStyleBackColor = true;
			this->chkPWM7->CheckedChanged += gcnew System::EventHandler(this, &DigitalIO::chkPWM7_CheckedChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(19, 36);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(47, 17);
			this->label1->TabIndex = 16;
			this->label1->Text = L"pin 11";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(19, 64);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(39, 17);
			this->label2->TabIndex = 17;
			this->label2->Text = L"pin 2";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(19, 90);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(47, 17);
			this->label3->TabIndex = 18;
			this->label3->Text = L"pin 20";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(19, 117);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(47, 17);
			this->label4->TabIndex = 19;
			this->label4->Text = L"pin 12";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(19, 147);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(39, 17);
			this->label5->TabIndex = 20;
			this->label5->Text = L"pin 3";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(19, 171);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(47, 17);
			this->label6->TabIndex = 21;
			this->label6->Text = L"pin 21";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(19, 198);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(47, 17);
			this->label7->TabIndex = 22;
			this->label7->Text = L"pin 13";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(19, 224);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(39, 17);
			this->label8->TabIndex = 23;
			this->label8->Text = L"pin 4";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(19, 252);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(47, 17);
			this->label9->TabIndex = 24;
			this->label9->Text = L"pin 22";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(19, 278);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(47, 17);
			this->label10->TabIndex = 25;
			this->label10->Text = L"pin 25";
			// 
			// edtDuty1
			// 
			this->edtDuty1->Location = System::Drawing::Point(214, 36);
			this->edtDuty1->Name = L"edtDuty1";
			this->edtDuty1->Size = System::Drawing::Size(100, 22);
			this->edtDuty1->TabIndex = 26;
			this->edtDuty1->Text = L"50";
			// 
			// edtDuty2
			// 
			this->edtDuty2->Location = System::Drawing::Point(214, 64);
			this->edtDuty2->Name = L"edtDuty2";
			this->edtDuty2->Size = System::Drawing::Size(100, 22);
			this->edtDuty2->TabIndex = 27;
			this->edtDuty2->Text = L"50";
			// 
			// edtDuty3
			// 
			this->edtDuty3->Location = System::Drawing::Point(214, 92);
			this->edtDuty3->Name = L"edtDuty3";
			this->edtDuty3->Size = System::Drawing::Size(100, 22);
			this->edtDuty3->TabIndex = 28;
			this->edtDuty3->Text = L"50";
			// 
			// edtDuty5
			// 
			this->edtDuty5->Location = System::Drawing::Point(214, 144);
			this->edtDuty5->Name = L"edtDuty5";
			this->edtDuty5->Size = System::Drawing::Size(100, 22);
			this->edtDuty5->TabIndex = 29;
			this->edtDuty5->Text = L"50";
			// 
			// edtDuty6
			// 
			this->edtDuty6->Location = System::Drawing::Point(214, 168);
			this->edtDuty6->Name = L"edtDuty6";
			this->edtDuty6->Size = System::Drawing::Size(100, 22);
			this->edtDuty6->TabIndex = 30;
			this->edtDuty6->Text = L"50";
			// 
			// edtDuty7
			// 
			this->edtDuty7->Location = System::Drawing::Point(214, 195);
			this->edtDuty7->Name = L"edtDuty7";
			this->edtDuty7->Size = System::Drawing::Size(100, 22);
			this->edtDuty7->TabIndex = 31;
			this->edtDuty7->Text = L"50";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(211, 16);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(101, 17);
			this->label11->TabIndex = 32;
			this->label11->Text = L"Duty Cycle (%)";
			// 
			// edtFreq123
			// 
			this->edtFreq123->Location = System::Drawing::Point(320, 61);
			this->edtFreq123->Name = L"edtFreq123";
			this->edtFreq123->Size = System::Drawing::Size(100, 22);
			this->edtFreq123->TabIndex = 33;
			this->edtFreq123->Text = L"1000";
			// 
			// edtFreq567
			// 
			this->edtFreq567->Location = System::Drawing::Point(320, 168);
			this->edtFreq567->Name = L"edtFreq567";
			this->edtFreq567->Size = System::Drawing::Size(100, 22);
			this->edtFreq567->TabIndex = 34;
			this->edtFreq567->Text = L"1000";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(320, 35);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(187, 17);
			this->label12->TabIndex = 35;
			this->label12->Text = L"Frequency (500-300000 Hz)";
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->label12);
			this->groupBox1->Controls->Add(this->edtFreq567);
			this->groupBox1->Controls->Add(this->edtFreq123);
			this->groupBox1->Controls->Add(this->label11);
			this->groupBox1->Controls->Add(this->edtDuty7);
			this->groupBox1->Controls->Add(this->edtDuty6);
			this->groupBox1->Controls->Add(this->edtDuty5);
			this->groupBox1->Controls->Add(this->edtDuty3);
			this->groupBox1->Controls->Add(this->edtDuty2);
			this->groupBox1->Controls->Add(this->edtDuty1);
			this->groupBox1->Controls->Add(this->label10);
			this->groupBox1->Controls->Add(this->label9);
			this->groupBox1->Controls->Add(this->label8);
			this->groupBox1->Controls->Add(this->label7);
			this->groupBox1->Controls->Add(this->label6);
			this->groupBox1->Controls->Add(this->label5);
			this->groupBox1->Controls->Add(this->label4);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Controls->Add(this->chkPWM7);
			this->groupBox1->Controls->Add(this->chkPWM6);
			this->groupBox1->Controls->Add(this->chkPWM5);
			this->groupBox1->Controls->Add(this->chkPWM3);
			this->groupBox1->Controls->Add(this->chkPWM2);
			this->groupBox1->Controls->Add(this->chkPWM1);
			this->groupBox1->Controls->Add(this->chkDO10);
			this->groupBox1->Controls->Add(this->chkDO9);
			this->groupBox1->Controls->Add(this->chkDO8);
			this->groupBox1->Controls->Add(this->chkDO7);
			this->groupBox1->Controls->Add(this->chkDO6);
			this->groupBox1->Controls->Add(this->chkDO5);
			this->groupBox1->Controls->Add(this->chkDO4);
			this->groupBox1->Controls->Add(this->chkDO3);
			this->groupBox1->Controls->Add(this->chkDO2);
			this->groupBox1->Controls->Add(this->chkDO1);
			this->groupBox1->Location = System::Drawing::Point(12, 40);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(514, 313);
			this->groupBox1->TabIndex = 36;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Digital Outputs";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->btnGetDigIn);
			this->groupBox2->Controls->Add(this->label15);
			this->groupBox2->Controls->Add(this->chkDI3);
			this->groupBox2->Controls->Add(this->chkDI2);
			this->groupBox2->Controls->Add(this->chkDI1);
			this->groupBox2->Controls->Add(this->label14);
			this->groupBox2->Controls->Add(this->label13);
			this->groupBox2->Location = System::Drawing::Point(12, 359);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(514, 132);
			this->groupBox2->TabIndex = 37;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Digital Inputs";
			// 
			// btnGetDigIn
			// 
			this->btnGetDigIn->Location = System::Drawing::Point(148, 52);
			this->btnGetDigIn->Name = L"btnGetDigIn";
			this->btnGetDigIn->Size = System::Drawing::Size(130, 30);
			this->btnGetDigIn->TabIndex = 32;
			this->btnGetDigIn->Text = L"Get Digital Inputs";
			this->btnGetDigIn->UseVisualStyleBackColor = true;
			this->btnGetDigIn->Click += gcnew System::EventHandler(this, &DigitalIO::btnGetDigIn_Click);
			// 
			// label15
			// 
			this->label15->AutoSize = true;
			this->label15->Location = System::Drawing::Point(19, 86);
			this->label15->Name = L"label15";
			this->label15->Size = System::Drawing::Size(47, 17);
			this->label15->TabIndex = 31;
			this->label15->Text = L"pin 16";
			// 
			// chkDI3
			// 
			this->chkDI3->AutoSize = true;
			this->chkDI3->Location = System::Drawing::Point(72, 85);
			this->chkDI3->Name = L"chkDI3";
			this->chkDI3->Size = System::Drawing::Size(52, 21);
			this->chkDI3->TabIndex = 30;
			this->chkDI3->Text = L"DI 3";
			this->chkDI3->UseVisualStyleBackColor = true;
			// 
			// chkDI2
			// 
			this->chkDI2->AutoSize = true;
			this->chkDI2->Location = System::Drawing::Point(72, 58);
			this->chkDI2->Name = L"chkDI2";
			this->chkDI2->Size = System::Drawing::Size(52, 21);
			this->chkDI2->TabIndex = 29;
			this->chkDI2->Text = L"DI 2";
			this->chkDI2->UseVisualStyleBackColor = true;
			// 
			// chkDI1
			// 
			this->chkDI1->AutoSize = true;
			this->chkDI1->Location = System::Drawing::Point(72, 31);
			this->chkDI1->Name = L"chkDI1";
			this->chkDI1->Size = System::Drawing::Size(52, 21);
			this->chkDI1->TabIndex = 28;
			this->chkDI1->Text = L"DI 1";
			this->chkDI1->UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this->label14->AutoSize = true;
			this->label14->Location = System::Drawing::Point(19, 59);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(39, 17);
			this->label14->TabIndex = 27;
			this->label14->Text = L"pin 7";
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(19, 32);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(47, 17);
			this->label13->TabIndex = 26;
			this->label13->Text = L"pin 24";
			// 
			// label16
			// 
			this->label16->AutoSize = true;
			this->label16->Location = System::Drawing::Point(12, 9);
			this->label16->Name = L"label16";
			this->label16->Size = System::Drawing::Size(54, 17);
			this->label16->TabIndex = 38;
			this->label16->Text = L"label16";
			// 
			// DigitalIO
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(538, 503);
			this->Controls->Add(this->label16);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Name = L"DigitalIO";
			this->Text = L"DigitalIO";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnGetDigIn_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		
		const uint8 NR_OF_DIGITAL_INPUTS = 3;
		const uint8 DIG_IN0 = 0;
		const uint8 DIG_IN1 = 1;
		const uint8 DIG_IN2 = 2;
		long l_Res = 0;
		bool l_bNoError = true;
		uint8 l_Value[3];


		for(uint8 i = 0; i < NR_OF_DIGITAL_INPUTS; i++)
		{
			if (ERR_SUCCESS != AVS_GetDigIn(m_DeviceHandle, i, &l_Value[i]))
			{
				l_bNoError = false;
				break;
			}
		}

		if (l_bNoError)
		{
			chkDI1->Enabled = true;
			if (l_Value[DIG_IN0] == 1)
				chkDI1->Checked = 1;
			else
				chkDI1->Checked = 0;

			chkDI1->Enabled = false;
	        
			chkDI2->Enabled = true;
			if (l_Value[DIG_IN1] == 1)
				chkDI2->Checked = 1;
			else
				chkDI2->Checked = 0;
			
			chkDI2->Enabled = false;

			chkDI3->Enabled = true;
			if(l_Value[DIG_IN2] == 1)
				chkDI3->Checked = 1;
			else
				chkDI3->Checked = 0;
			
			chkDI3->Enabled = false;
		}
		else
			MessageBox::Show("Communication Error");		
	}

	void Test::DigitalIO::OutputClick(uint8 a_Id, uint8 a_Value)
	{
		long l_Res = 0;
		long l_Freq = 0;
		uint8 l_Perc = 0;

		if(a_Value > 0)
			a_Value = 1;
		
		if(((a_Id == 0) || (a_Id == 1) || (a_Id == 2) || (a_Id == 4) || (a_Id == 5) || (a_Id == 6)) && (a_Value == 1))
		{
			switch (a_Id)
			{
			case 0 : if(chkPWM1->Checked)
					 {
						l_Perc = Convert::ToByte(edtDuty1->Text);
						l_Freq = Convert::ToInt32(edtFreq123->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					 }
					 else
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
					
				break;
			
			case 1:	if (chkPWM2->Checked)
					{
						l_Perc = Convert::ToByte(edtDuty2->Text);
						l_Freq = Convert::ToInt32(edtFreq123->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					}
					else
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
				break;
					

			case 2:	if (chkPWM3->Checked)
					{					
						l_Perc = Convert::ToByte(edtDuty3->Text);
						l_Freq = Convert::ToInt32(edtFreq123->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					}
					else
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
				
				break;

			case 4:	if(chkPWM5->Checked)
					{
						l_Perc = Convert::ToByte(edtDuty5->Text);
						l_Freq = Convert::ToInt32(edtFreq567->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					}
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
					
				break;

			case 5:	if(chkPWM6->Checked)
					{
						l_Perc = Convert::ToByte(edtDuty6->Text);
						l_Freq = Convert::ToInt32(edtFreq567->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					}
					else
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
					
					break;

			case 6:	if(chkPWM7->Checked)
					{
						l_Perc = Convert::ToByte(edtDuty7->Text);
						l_Freq = Convert::ToInt32(edtFreq567->Text);
						l_Res = AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
					}
					else
						l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
				break;

			default:
				break;

			}
		}
		else
		{
			l_Res = AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
		}

		if (l_Res != ERR_SUCCESS)
			MessageBox::Show("Error:" + l_Res.ToString());

	}
			 
	private: System::Void chkDO1_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(0, Convert::ToByte(chkDO1->Checked));
	}
	private: System::Void chkDO2_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(1, Convert::ToByte(chkDO2->Checked));
	}
	private: System::Void chkDO3_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(2, Convert::ToByte(chkDO3->Checked));
	}
	private: System::Void chkDO4_CheckedChanged(System::Object^  sender, System::EventArgs^  e)
	{
			OutputClick(3, Convert::ToByte(chkDO4->Checked));
	}
	private: System::Void chkDO5_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(4, Convert::ToByte(chkDO5->Checked));
	}
	private: System::Void chkDO6_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(5, Convert::ToByte(chkDO6->Checked));
	}
	private: System::Void chkDO7_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(6, Convert::ToByte(chkDO7->Checked));
	}	
	private: System::Void chkDO8_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(7, Convert::ToByte(chkDO8->Checked));
	}
	private: System::Void chkDO9_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(8, Convert::ToByte(chkDO9->Checked));
	}
	private: System::Void chkDO10_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(9, Convert::ToByte(chkDO10->Checked));
	}
	private: System::Void chkPWM1_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(0, Convert::ToByte(chkDO1->Checked));
	}
	private: System::Void chkPWM2_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(1, Convert::ToByte(chkDO2->Checked));
	}
	private: System::Void chkPWM3_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(2, Convert::ToByte(chkDO3->Checked));
	}
	private: System::Void chkPWM5_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(4, Convert::ToByte(chkDO5->Checked));
	}
	private: System::Void chkPWM6_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(5, Convert::ToByte(chkDO6->Checked));
	}
	private: System::Void chkPWM7_CheckedChanged(System::Object^  sender, System::EventArgs^  e) 
	{
		OutputClick(6, Convert::ToByte(chkDO7->Checked));
	}
};
}

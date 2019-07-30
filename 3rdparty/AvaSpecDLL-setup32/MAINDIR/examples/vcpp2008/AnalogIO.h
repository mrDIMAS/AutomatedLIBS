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
	/// Summary for AnalogIO
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class AnalogIO : public System::Windows::Forms::Form
	{
	public:
		AnalogIO(void)
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
		~AnalogIO()
		{
			if (components)
			{
				delete components;
			}
		}

	public:long m_DeviceHandle; 
	private: System::Windows::Forms::GroupBox^  groupBox1;
	private: System::Windows::Forms::Button^  btnSetAnalogOut;
	private: System::Windows::Forms::TextBox^  edtAO2;
	private: System::Windows::Forms::TextBox^  edtAO1;
	private: System::Windows::Forms::GroupBox^  groupBox2;
	private: System::Windows::Forms::Button^  btnGetAnalogInClick;
	private: System::Windows::Forms::TextBox^  edtAI4;
	private: System::Windows::Forms::TextBox^  edtAI5;
	private: System::Windows::Forms::GroupBox^  groupBox3;
	private: System::Windows::Forms::Button^  btnGetOnboardAI;
	private: System::Windows::Forms::TextBox^  edtAI7;
	private: System::Windows::Forms::TextBox^  edtAI6;
	private: System::Windows::Forms::TextBox^  edtAI3;
	private: System::Windows::Forms::TextBox^  edtAI2;
	private: System::Windows::Forms::TextBox^  edtAI1;
	private: System::Windows::Forms::TextBox^  edtAI0;
	public: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label6;
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
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->btnSetAnalogOut = (gcnew System::Windows::Forms::Button());
			this->edtAO2 = (gcnew System::Windows::Forms::TextBox());
			this->edtAO1 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->btnGetAnalogInClick = (gcnew System::Windows::Forms::Button());
			this->edtAI4 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI5 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->btnGetOnboardAI = (gcnew System::Windows::Forms::Button());
			this->edtAI7 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI6 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI3 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI2 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI1 = (gcnew System::Windows::Forms::TextBox());
			this->edtAI0 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->groupBox1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->btnSetAnalogOut);
			this->groupBox1->Controls->Add(this->edtAO2);
			this->groupBox1->Controls->Add(this->edtAO1);
			this->groupBox1->Location = System::Drawing::Point(12, 37);
			this->groupBox1->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Padding = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox1->Size = System::Drawing::Size(295, 70);
			this->groupBox1->TabIndex = 0;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Analog Output";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(10, 42);
			this->label3->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(66, 13);
			this->label3->TabIndex = 4;
			this->label3->Text = L"pin 26 (AO2)";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(10, 20);
			this->label2->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(66, 13);
			this->label2->TabIndex = 3;
			this->label2->Text = L"pin 17 (AO1)";
			// 
			// btnSetAnalogOut
			// 
			this->btnSetAnalogOut->Location = System::Drawing::Point(182, 20);
			this->btnSetAnalogOut->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->btnSetAnalogOut->Name = L"btnSetAnalogOut";
			this->btnSetAnalogOut->Size = System::Drawing::Size(106, 27);
			this->btnSetAnalogOut->TabIndex = 2;
			this->btnSetAnalogOut->Text = L"Set Analog Out";
			this->btnSetAnalogOut->UseVisualStyleBackColor = true;
			this->btnSetAnalogOut->Click += gcnew System::EventHandler(this, &AnalogIO::btnSetAnalogOut_Click);
			// 
			// edtAO2
			// 
			this->edtAO2->Location = System::Drawing::Point(81, 40);
			this->edtAO2->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAO2->Name = L"edtAO2";
			this->edtAO2->Size = System::Drawing::Size(87, 20);
			this->edtAO2->TabIndex = 1;
			this->edtAO2->Text = L"0.0";
			// 
			// edtAO1
			// 
			this->edtAO1->Location = System::Drawing::Point(81, 17);
			this->edtAO1->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAO1->Name = L"edtAO1";
			this->edtAO1->Size = System::Drawing::Size(87, 20);
			this->edtAO1->TabIndex = 0;
			this->edtAO1->Text = L"0.0";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->label5);
			this->groupBox2->Controls->Add(this->label4);
			this->groupBox2->Controls->Add(this->btnGetAnalogInClick);
			this->groupBox2->Controls->Add(this->edtAI4);
			this->groupBox2->Controls->Add(this->edtAI5);
			this->groupBox2->Location = System::Drawing::Point(12, 112);
			this->groupBox2->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Padding = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox2->Size = System::Drawing::Size(295, 67);
			this->groupBox2->TabIndex = 1;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Analog Input SUBD26-F connector";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(16, 42);
			this->label5->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(61, 13);
			this->label5->TabIndex = 5;
			this->label5->Text = L"pin 18 (AI2)";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(22, 18);
			this->label4->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(55, 13);
			this->label4->TabIndex = 4;
			this->label4->Text = L"pin 9 (AI1)";
			// 
			// btnGetAnalogInClick
			// 
			this->btnGetAnalogInClick->Location = System::Drawing::Point(185, 18);
			this->btnGetAnalogInClick->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->btnGetAnalogInClick->Name = L"btnGetAnalogInClick";
			this->btnGetAnalogInClick->Size = System::Drawing::Size(106, 24);
			this->btnGetAnalogInClick->TabIndex = 3;
			this->btnGetAnalogInClick->Text = L"Get Analog In";
			this->btnGetAnalogInClick->UseVisualStyleBackColor = true;
			this->btnGetAnalogInClick->Click += gcnew System::EventHandler(this, &AnalogIO::btnGetAnalogInClick_Click);
			// 
			// edtAI4
			// 
			this->edtAI4->Location = System::Drawing::Point(81, 40);
			this->edtAI4->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI4->Name = L"edtAI4";
			this->edtAI4->Size = System::Drawing::Size(87, 20);
			this->edtAI4->TabIndex = 2;
			// 
			// edtAI5
			// 
			this->edtAI5->Location = System::Drawing::Point(81, 15);
			this->edtAI5->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI5->Name = L"edtAI5";
			this->edtAI5->Size = System::Drawing::Size(87, 20);
			this->edtAI5->TabIndex = 1;
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->label11);
			this->groupBox3->Controls->Add(this->label10);
			this->groupBox3->Controls->Add(this->label9);
			this->groupBox3->Controls->Add(this->label8);
			this->groupBox3->Controls->Add(this->label7);
			this->groupBox3->Controls->Add(this->label6);
			this->groupBox3->Controls->Add(this->btnGetOnboardAI);
			this->groupBox3->Controls->Add(this->edtAI7);
			this->groupBox3->Controls->Add(this->edtAI6);
			this->groupBox3->Controls->Add(this->edtAI3);
			this->groupBox3->Controls->Add(this->edtAI2);
			this->groupBox3->Controls->Add(this->edtAI1);
			this->groupBox3->Controls->Add(this->edtAI0);
			this->groupBox3->Location = System::Drawing::Point(9, 184);
			this->groupBox3->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Padding = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->groupBox3->Size = System::Drawing::Size(295, 157);
			this->groupBox3->TabIndex = 1;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"Onboard Analog Input";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(31, 133);
			this->label11->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(51, 13);
			this->label11->TabIndex = 12;
			this->label11->Text = L"NTC2 X9";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(31, 110);
			this->label10->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(51, 13);
			this->label10->TabIndex = 11;
			this->label10->Text = L"NTC1 X8";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(40, 88);
			this->label9->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(42, 13);
			this->label9->TabIndex = 10;
			this->label9->Text = L"5VUSB";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(50, 67);
			this->label8->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(31, 13);
			this->label8->TabIndex = 9;
			this->label8->Text = L"5VIO";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(55, 42);
			this->label7->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(26, 13);
			this->label7->TabIndex = 8;
			this->label7->Text = L"1V2";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(4, 20);
			this->label6->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(78, 13);
			this->label6->TabIndex = 7;
			this->label6->Text = L"Thermistor X11";
			// 
			// btnGetOnboardAI
			// 
			this->btnGetOnboardAI->Location = System::Drawing::Point(188, 17);
			this->btnGetOnboardAI->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->btnGetOnboardAI->Name = L"btnGetOnboardAI";
			this->btnGetOnboardAI->Size = System::Drawing::Size(103, 27);
			this->btnGetOnboardAI->TabIndex = 4;
			this->btnGetOnboardAI->Text = L"Get Onboard AI";
			this->btnGetOnboardAI->UseVisualStyleBackColor = true;
			this->btnGetOnboardAI->Click += gcnew System::EventHandler(this, &AnalogIO::btnGetOnboardAI_Click);
			// 
			// edtAI7
			// 
			this->edtAI7->Location = System::Drawing::Point(84, 131);
			this->edtAI7->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI7->Name = L"edtAI7";
			this->edtAI7->Size = System::Drawing::Size(87, 20);
			this->edtAI7->TabIndex = 6;
			// 
			// edtAI6
			// 
			this->edtAI6->Location = System::Drawing::Point(84, 108);
			this->edtAI6->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI6->Name = L"edtAI6";
			this->edtAI6->Size = System::Drawing::Size(87, 20);
			this->edtAI6->TabIndex = 5;
			// 
			// edtAI3
			// 
			this->edtAI3->Location = System::Drawing::Point(84, 85);
			this->edtAI3->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI3->Name = L"edtAI3";
			this->edtAI3->Size = System::Drawing::Size(87, 20);
			this->edtAI3->TabIndex = 4;
			// 
			// edtAI2
			// 
			this->edtAI2->Location = System::Drawing::Point(84, 63);
			this->edtAI2->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI2->Name = L"edtAI2";
			this->edtAI2->Size = System::Drawing::Size(87, 20);
			this->edtAI2->TabIndex = 3;
			// 
			// edtAI1
			// 
			this->edtAI1->Location = System::Drawing::Point(84, 40);
			this->edtAI1->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI1->Name = L"edtAI1";
			this->edtAI1->Size = System::Drawing::Size(87, 20);
			this->edtAI1->TabIndex = 2;
			// 
			// edtAI0
			// 
			this->edtAI0->Location = System::Drawing::Point(84, 17);
			this->edtAI0->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->edtAI0->Name = L"edtAI0";
			this->edtAI0->Size = System::Drawing::Size(87, 20);
			this->edtAI0->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(17, 7);
			this->label1->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"label1";
			// 
			// AnalogIO
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(316, 434);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->groupBox3);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Margin = System::Windows::Forms::Padding(2, 2, 2, 2);
			this->Name = L"AnalogIO";
			this->Text = L"AnalogIO";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void btnSetAnalogOut_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		const uint8 NR_OF_ANALOG_OUTPUTS = 2;

		float l_Value[NR_OF_ANALOG_OUTPUTS];
		bool l_bNoError = true;
		long l_Res = 0;
	    
		l_bNoError = true;

		l_Value[0] = Convert::ToSingle(edtAO1->Text);
		l_Value[1] = Convert::ToSingle(edtAO2->Text);

		for(uint8 i = 0;i < NR_OF_ANALOG_OUTPUTS; i++)
		{
			l_Res = AVS_SetAnalogOut(m_DeviceHandle, i, l_Value[i]);

			if (l_Res != ERR_SUCCESS)
			{
				l_bNoError = false;
				MessageBox::Show("Communication Error: " + l_Res.ToString());     
				break;
			}
		}
	}
	private: System::Void btnGetAnalogInClick_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		const uint8 NR_OF_ANALOG_INPUTS = 2;
		float l_Value[NR_OF_ANALOG_INPUTS];
		long l_Res = 0;

		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 5, &l_Value[0]);

		if (l_Res != ERR_SUCCESS)
			MessageBox::Show("Error ID=5 (pin 9): " + l_Res.ToString());
		else
			edtAI5->Text = l_Value[0].ToString() + " V";
		
		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 4, &l_Value[1]);
		
		if (l_Res != ERR_SUCCESS)
			MessageBox::Show("Error ID=5 (pin 18): " + l_Res.ToString());
		else
			edtAI4->Text = l_Value[0].ToString() + " V";
	}

	private: System::Void btnGetOnboardAI_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		float l_Value = 0.0;
		long l_Res = 0;
    
		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 0, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI0->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI0->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=0 : " + l_Res.ToString());
				break;
		}

		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 1, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI1->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI1->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=1 : " + l_Res.ToString());
				break;
		}
    
		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 2, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI2->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI2->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=2 : " + l_Res.ToString());
				break;
		}

		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 3, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI3->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI3->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=3 : " + l_Res.ToString());
				break;
		}

		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 6, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI6->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI6->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=6 : " + l_Res.ToString());
				break;
		}

		l_Res = AVS_GetAnalogIn(m_DeviceHandle, 7, &l_Value);
		switch(l_Res) {
			case ERR_SUCCESS:
				edtAI7->Text = l_Value.ToString() + " V";
				break;
			case ERR_INVALID_PARAMETER:
				edtAI7->Text = "Not Available";
				break;
			default:
				MessageBox::Show("Error ID=7 : " + l_Res.ToString());
				break;
		}
	}
};
}

//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include "main.h"
#include "anio.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TfrmAnIO *frmAnIO;
//---------------------------------------------------------------------------
__fastcall TfrmAnIO::TfrmAnIO(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TfrmAnIO::btnSetAnalogOutClick(TObject *Sender)
{
#define NR_OF_ANALOG_OUTPUTS     2

    float   l_Value[NR_OF_ANALOG_OUTPUTS];
    bool    l_bNoError = true;

    l_Value[0] = (float)edtAO1->Text.ToDouble();
    l_Value[1] = (float)edtAO2->Text.ToDouble();
    for (int i = 0; (i < NR_OF_ANALOG_OUTPUTS) && l_bNoError; ++i)
    {
        int l_Res = AVS_SetAnalogOut(MainForm->m_DeviceHandle, i, l_Value[i]);
        if (l_Res != ERR_SUCCESS)
        {
            l_bNoError = false;
            char    buf[80];
            wsprintf(buf, "Error: %d", l_Res);
            Application->MessageBox(buf, "Error", MB_OK);
        }
    }
}
//---------------------------------------------------------------------------

void __fastcall TfrmAnIO::btnGetAnalogInClick(TObject *Sender)
{
#define NR_OF_ANALOG_INPUTS     2

    float   l_Value[NR_OF_ANALOG_INPUTS];
    int l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 5, &l_Value[0]);
    if (l_Res != ERR_SUCCESS)
    {
            char    buf[80];
            wsprintf(buf, "Error ID=5 (pin 9): %d", l_Res);
            Application->MessageBox(buf, "Error", MB_OK);
    }
    else
        edtAI5->Text = AnsiString::FormatFloat("0.00", l_Value[0]);
    l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 4, &l_Value[1]);
    if (l_Res != ERR_SUCCESS)
    {
            char    buf[80];
            wsprintf(buf, "Error ID=4 (pin 18): %d", l_Res);
            Application->MessageBox(buf, "Error", MB_OK);
    }
    else
        edtAI4->Text = AnsiString::FormatFloat("0.00", l_Value[1]);

}
//---------------------------------------------------------------------------

void __fastcall TfrmAnIO::btnGetOnboardAIClick(TObject *Sender)
{
	float   l_Value;
	char buf[80];
	int l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 0, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI0->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI0->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=0: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}

	l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 1, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI1->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI1->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=1: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}

	l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 2, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI2->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI2->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=2: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}

	l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 3, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI3->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI3->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=3: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}

	l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 6, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI6->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI6->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=6: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}

	l_Res = AVS_GetAnalogIn(MainForm->m_DeviceHandle, 7, &l_Value);
	switch(l_Res) {
		case ERR_SUCCESS:
			edtAI7->Text = AnsiString::FormatFloat("0.00", l_Value);
			break;
		case ERR_INVALID_PARAMETER:
			edtAI7->Text = "Not Available";
			break;
		default:
			wsprintf(buf, "Error ID=7: %d", l_Res);
			Application->MessageBox(buf, "Error", MB_OK);
			break;
	}
}


//---------------------------------------------------------------------------


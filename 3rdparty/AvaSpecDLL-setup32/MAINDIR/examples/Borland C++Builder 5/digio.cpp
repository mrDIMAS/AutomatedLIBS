//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
#include "main.h"
#include "digio.h"

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TfrmDigIO *frmDigIO;
//---------------------------------------------------------------------------
__fastcall TfrmDigIO::TfrmDigIO(TComponent* Owner)
        : TForm(Owner)

{
}


void __fastcall TfrmDigIO::OutputClick(unsigned char a_Id, unsigned char a_Value)
{
    int l_Res;
    unsigned long l_Freq;
    unsigned char l_Perc;

    if (((a_Id==0)||(a_Id==1)||(a_Id==2)||(a_Id==4)||(a_Id==5)||(a_Id==6)) && (a_Value==1))
    {
       switch (a_Id)
       {
              case 0 : if (chkPWM1->Checked)
                       {
                          l_Perc = edtDuty1->Text.ToInt();
                          l_Freq = edtFreq123->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
              case 1 : if (chkPWM2->Checked)
                       {
                          l_Perc = edtDuty2->Text.ToInt();
                          l_Freq = edtFreq123->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
              case 2 : if (chkPWM3->Checked)
                       {
                          l_Perc = edtDuty3->Text.ToInt();
                          l_Freq = edtFreq123->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
              case 4 : if (chkPWM5->Checked)
                       {
                          l_Perc = edtDuty5->Text.ToInt();
                          l_Freq = edtFreq567->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
              case 5 : if (chkPWM6->Checked)
                       {
                          l_Perc = edtDuty6->Text.ToInt();
                          l_Freq = edtFreq567->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
              case 6 : if (chkPWM7->Checked)
                       {
                          l_Perc = edtDuty7->Text.ToInt();
                          l_Freq = edtFreq567->Text.ToInt();
                          l_Res = AVS_SetPwmOut(MainForm->m_DeviceHandle, a_Id, l_Freq, l_Perc);
                       }
                       else
                          l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
                       break;
       }
    }
    else
    {
        l_Res = AVS_SetDigOut(MainForm->m_DeviceHandle, a_Id, a_Value);
    }
    if (l_Res != ERR_SUCCESS)
    {
            char    buf[80];
            wsprintf(buf, "Error: %d", l_Res);
            Application->MessageBox(buf, "Error", MB_OK);
    }
}
//---------------------------------------------------------------------------
void __fastcall TfrmDigIO::chkDO1Click(TObject *Sender)
{
 OutputClick(0, chkDO1->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM1Click(TObject *Sender)
{
 OutputClick(0, chkDO1->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO2Click(TObject *Sender)
{
 OutputClick(1, chkDO2->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM2Click(TObject *Sender)
{
 OutputClick(1, chkDO2->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO3Click(TObject *Sender)
{
 OutputClick(2, chkDO3->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM3Click(TObject *Sender)
{
 OutputClick(2, chkDO3->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO4Click(TObject *Sender)
{
 OutputClick(3, chkDO4->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO5Click(TObject *Sender)
{
 OutputClick(4, chkDO5->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM5Click(TObject *Sender)
{
 OutputClick(4, chkDO5->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO6Click(TObject *Sender)
{
 OutputClick(5, chkDO6->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM6Click(TObject *Sender)
{
 OutputClick(5, chkDO6->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO7Click(TObject *Sender)
{
 OutputClick(6, chkDO7->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkPWM7Click(TObject *Sender)
{
 OutputClick(6, chkDO7->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO8Click(TObject *Sender)
{
 OutputClick(7, chkDO8->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO9Click(TObject *Sender)
{
 OutputClick(8, chkDO9->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::chkDO10Click(TObject *Sender)
{
 OutputClick(9, chkDO10->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TfrmDigIO::btnGetDigInClick(TObject *Sender)
{
#define NR_OF_DIGITAL_INPUTS    3
#define DIG_IN0                 0
#define DIG_IN1                 1
#define DIG_IN2                 2

    unsigned char   l_Value[NR_OF_DIGITAL_INPUTS];
    bool            l_bNoError = true;

    for (int i = 0; (i < NR_OF_DIGITAL_INPUTS) && l_bNoError; ++i)
    {
        l_bNoError = (ERR_SUCCESS == AVS_GetDigIn(MainForm->m_DeviceHandle, i, &l_Value[i]));
    }

    if (l_bNoError)
    {
        chkDI1->Enabled = true;
        chkDI1->State = (l_Value[DIG_IN0] & 0x01) ? cbChecked : cbUnchecked;
        chkDI1->Enabled = false;
        chkDI2->Enabled = true;
        chkDI2->State = (l_Value[DIG_IN1] & 0x01) ? cbChecked : cbUnchecked;
        chkDI2->Enabled = false;
        chkDI3->Enabled = true;
        chkDI3->State = (l_Value[DIG_IN2] & 0x01) ? cbChecked : cbUnchecked;
        chkDI3->Enabled = false;
    }
    else
    {
        Application->MessageBox("Communication Error", "Error", MB_OK );
    }

}
//---------------------------------------------------------------------------


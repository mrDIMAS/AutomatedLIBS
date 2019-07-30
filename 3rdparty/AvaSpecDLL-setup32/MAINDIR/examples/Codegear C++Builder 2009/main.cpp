//---------------------------------------------------------------------------

#include <vcl.h>
#include <dbt.h>

#pragma hdrstop

#include "main.h"
#include "convert.h"
#include "digio.h"
#include "anio.h"
#include "eeprom.h"

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TMainForm *MainForm;

//---------------------------------------------------------------------------
__fastcall TMainForm::TMainForm(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::btnCommunicationClick(TObject *Sender)
{
    Screen->Cursor = crHourGlass;
    StatusBar1->Panels->Items[0]->Text = "Open communication busy";

    int l_Port = AVS_Init(0);

    AVS_Register(Handle);
    if (l_Port > 0)
    {
        StatusBar1->Panels->Items[0]->Text = "Connected: USB";
        btnUpdateList->Enabled = true;
        sgShowList->Cells[0][0] = "SerialNr";
        sgShowList->Cells[1][0] = "Status";
        btnUpdateListClick(this);
    }
    else
    {
        AVS_Done();
		l_Port = AVS_Init(-1);
        if (l_Port > 0)
        {
		  StatusBar1->Panels->Items[0]->Text = "Connected: Ethernet/USB" ;
          btnUpdateList->Enabled = true;
		  sgShowList->Cells[0][0] = "SerialNr";
          sgShowList->Cells[1][0] = "Status";
          btnUpdateListClick(this);
        }
        else
        {
            StatusBar1->Panels->Items[0]->Text = "Open communication failed";
            AVS_Done();
        }
    }
    Screen->Cursor = crDefault;
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::FormClose(TObject *Sender, TCloseAction &Action)
{
    if (m_DeviceHandle!=INVALID_AVS_HANDLE_VALUE)
    {
      int l_Res = AVS_StopMeasure(m_DeviceHandle);
      if (ERR_SUCCESS != l_Res)
      {
		  wchar_t buf[80];
		  wsprintfW(buf, L"Error in AVS_StopMeasure, code: %d", l_Res);
		  Application->MessageBox(buf, L"Error", MB_OK);
      }
    }
    if (m_pLambda != NULL)
    {
        delete [] m_pLambda;
        m_pLambda = NULL;
        m_NrPixels = 0;
    }
    AVS_Done();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnUpdateListClick(TObject *Sender)
{
    unsigned int        l_Size = 0;
    unsigned int        l_RequiredSize = 0;
    int                 l_NrDevices;
    char*               l_pData = NULL;
    AvsIdentityType*    l_pId;


	Screen->Cursor = crHourGlass;
	for (int i=0;i< sgShowList->ColCount;i++)
		for (int j=1;j< sgShowList->RowCount;j++)
			sgShowList->Cells[i][j]="";
	l_NrDevices = AVS_GetNrOfDevices();
	l_RequiredSize = l_NrDevices * sizeof(AvsIdentityType);
	if (l_RequiredSize > 0)
	{
		   delete [] l_pData;
		   l_pData = new char[l_RequiredSize];
		   l_pId = (AvsIdentityType*)l_pData;
		   l_Size = l_RequiredSize;
		   l_NrDevices = AVS_GetList(l_Size, &l_RequiredSize, l_pId);
		   for (int i = 0; i < l_NrDevices; i++)
		   {
				sgShowList->Cells[0][i+1]=l_pId->SerialNumber;
				switch (l_pId->Status)
				{
				   case UNKNOWN                  : sgShowList->Cells[1][i+1] = "UNKNOWN";
												   break;
				   case USB_AVAILABLE            : sgShowList->Cells[1][i+1] = "USB_AVAILABLE";
												   break;
				   case USB_IN_USE_BY_APPLICATION: sgShowList->Cells[1][i+1] = "USB_IN_USE_BY_APPLICATION";
												   break;
				   case USB_IN_USE_BY_OTHER      : sgShowList->Cells[1][i+1] = "USB_IN_USE_BY_OTHER";
												   break;
				   case ETH_AVAILABLE            : sgShowList->Cells[1][i+1] = "ETH_AVAILABLE";
												   break;
				   case ETH_IN_USE_BY_APPLICATION: sgShowList->Cells[1][i+1] = "ETH_IN_USE_BY_APPLICATION";
												   break;
				   case ETH_IN_USE_BY_OTHER      : sgShowList->Cells[1][i+1] = "ETH_IN_USE_BY_OTHER";
												   break;
				   case ETH_ALREADY_IN_USE_USB   : sgShowList->Cells[1][i+1] = "ETH_ALREADY_IN_USE_USB";
												   break;
				   default                       : sgShowList->Cells[1][i+1] = "??????";
												   break;
				}
				l_pId++;
		   }
		   delete [] l_pData;

	}
	Screen->Cursor = crDefault;
	sgShowListClick(this);
}
//---------------------------------------------------------------------------


void __fastcall TMainForm::OnDeviceChange(TMessage& a_WndMsg)
{
	DWORD   wParm = a_WndMsg.WParam;

    DEV_BROADCAST_HDR*  l_pData = (DEV_BROADCAST_HDR*)a_WndMsg.LParam;

    if (NULL != l_pData)
    {
        if (l_pData->dbch_devicetype ==  DBT_DEVTYP_DEVICEINTERFACE)
        {
            switch (wParm)
            {
              case DBT_DEVICEARRIVAL:
                  // system detected a new device
                  StatusBar1->Panels->Items[1]->Text = "Device arrival";
                  btnUpdateListClick(this);

                  break;
              case DBT_DEVICEREMOVECOMPLETE:
                  // device is gone
                  StatusBar1->Panels->Items[1]->Text = "Device removed";
                  btnUpdateListClick(this);
                  break;
              default:
                  break;
            }
        }
    }
}
//---------------------------------------------------------------------------
void __fastcall TMainForm::HandleMeasResult(TMessage& a_WinMess)
{
    DWORD  l_Ticks;
    unsigned int l_Time, l_Dif, i;
    String l_Line;
    double l_AvgScantimeRAM;

    if ( a_WinMess.WParam >= ERR_SUCCESS)
    {
        double* l_pSpectrum;
        unsigned char* l_pSaturated;
        int     l_Res;

        if (m_NrPixels > 0)
        {
            l_pSpectrum = new double[m_NrPixels];
            l_pSaturated = new unsigned char[m_NrPixels];
            if (NULL == m_pLambda)
            {
                m_pLambda = new double[m_NrPixels];
            }
            if (ERR_SUCCESS == AVS_GetLambda(m_DeviceHandle, m_pLambda))
            {
                ;
            }
            if ( a_WinMess.WParam == ERR_SUCCESS)  //normal measurements
            {
               l_Line = "Meas.Status: success";
               StatusBar1->Panels->Items[1]->Text = l_Line;
               m_Measurements++;
               if (ERR_SUCCESS == AVS_GetScopeData(m_DeviceHandle, &l_Time, l_pSpectrum))
               {
                  l_Dif = l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
                  m_PreviousTimeStamp = l_Time;
                  if (l_Dif != 0)
                  {
                    edtLastScanTime->Text = FloatToStrF(l_Dif/100.0,ffFixed,7,2); //millisec
                  }
                  AVS_GetSaturatedPixels(m_DeviceHandle, l_pSaturated);
                  if (!m_GraphicsDisabled)
                  {
                    Series1->Clear();
                    for (i = 0; i < (m_StopPixels- m_StartPixels + 1); i++)
                    {
                        if ((i>0)&&(l_pSaturated[i]>0)&&(l_pSaturated[i-1]>0))
                        {
                            Series1->AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],"",TColor(clRed));
                        }
                        else
                        {
                            Series1->AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],"",TColor(clBlack));
                        }
                    }
                    Repaint();  // time consuming but gives feedback to user
                  }
               }
               else
               {
                 Series1->Clear();
                 l_Line = "Meas.Status: no data avail.";
                 StatusBar1->Panels->Items[1]->Text = l_Line;
               }
               l_Ticks = GetTickCount();
			   edtTotalTime->Text =  IntToStr(int(l_Ticks - m_StartTicks)/ 1000);
			   edtPerformedScans->Text = IntToStr(int(m_Measurements));
               edtAvgTimePerScan->Text = FloatToStrF(1.0*(l_Ticks - m_StartTicks)/m_Measurements,ffFixed,7,2);
               if (StrToInt(edtNrOfScans->Text)>0)
                  btnStartMeasurement->Enabled = (StrToInt(edtNrOfScans->Text)== m_Measurements);
			}
            else   //a_WinMess.WParam > 0 indicates response to StoreToRAM,
                   //using StoreToRAM requires firmware version 0.20.0.0 or later
                   //a_WinMess.WParam holds the number of scans stored in RAM
                   //import into application by call to AVS_GetScopeData for each scan
            {
               l_Line = "Meas.Status: Reading RAM";
               StatusBar1->Panels->Items[1]->Text = l_Line;
               l_AvgScantimeRAM = 0.0;
               for (int j = 1; j <= a_WinMess.WParam; j++)
               {
                   if (ERR_SUCCESS == AVS_GetScopeData(m_DeviceHandle, &l_Time, l_pSpectrum))
                   {
                      l_Dif = l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
                      m_PreviousTimeStamp = l_Time;
                      if (l_Dif != 0)
                      {
                         edtLastScanTime->Text = FloatToStrF(l_Dif/100.0,ffFixed,7,2); //millisec
                      }
                      //calculate average scan duration from TimeStamp
                      if (j>1)
                      {
                        l_AvgScantimeRAM = (l_AvgScantimeRAM*(j-2)+l_Dif/100.0) / (j-1);
                        edtAvgTimePerScan->Text = FloatToStrF(l_AvgScantimeRAM,ffFixed,7,3);
                      }

                      AVS_GetSaturatedPixels(m_DeviceHandle, l_pSaturated);
                      if (!m_GraphicsDisabled)
                      {
                         Series1->Clear();
                         for (i = 0; i < (m_StopPixels- m_StartPixels + 1); i++)
                         {
                             if ((i>0)&&(l_pSaturated[i]>0)&&(l_pSaturated[i-1]>0))
                             {
                                Series1->AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],"",TColor(clRed));
                             }
                             else
                             {
                                Series1->AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],"",TColor(clBlack));
                             }
                         }
                         Repaint();  // time consuming but gives feedback to user
                      }
                   }
                   else
                   {
                     Series1->Clear();
                     l_Line = "Meas.Status: no data avail.";
                     StatusBar1->Panels->Items[1]->Text = l_Line;
                   }
                   l_Ticks = GetTickCount();
				   edtTotalTime->Text =  IntToStr(int(l_Ticks - m_StartTicks)/ 1000);
                   edtPerformedScans->Text = IntToStr(j);
               }
               l_Line = "Finished Reading RAM";
               StatusBar1->Panels->Items[1]->Text = l_Line;
               btnStartMeasurement->Enabled=true;
            }
            delete [] l_pSpectrum;
            delete [] l_pSaturated;
        }
    }
    else //message.WParam < 0 indicates error
    {
        l_Line = "Meas.Status: failed. Error "+ IntToStr(a_WinMess.WParam);
        StatusBar1->Panels->Items[1]->Text = l_Line;
        m_Failures++;
    }
	edtFailures->Text = IntToStr(int(m_Failures));
}

void __fastcall TMainForm::sgShowListClick(TObject *Sender)
{
        String teststring = sgShowList->Cells[1][sgShowList->Selection.Top];
        btnActivate->Enabled = (teststring == "USB_AVAILABLE") || (teststring == "ETH_AVAILABLE");
        btnDeactivate->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
        btnDigIO->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
        btnAnIO->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
        btnShowEEProm->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
        btnReadMeasFromEEProm->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
		btnWriteMeasToEEProm->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
        btnStartMeasurement->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
		btnStopMeasurement->Enabled = (teststring == "USB_IN_USE_BY_APPLICATION") || (teststring == "ETH_IN_USE_BY_APPLICATION");
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnActivateClick(TObject *Sender)
{
    AvsIdentityType l_Active ;
	AvsHandle   l_hDevice ;
	int i, l_len;
	AnsiString s = sgShowList->Cells[0][sgShowList->Selection.Top];
	l_len = s.Length();
	for (i = 0; i < l_len; i++)
	{
	  l_Active.SerialNumber[i] = s[i+1];
	}
	l_Active.SerialNumber[i] = '\0';


	l_hDevice = AVS_Activate(&l_Active);
	if (INVALID_AVS_HANDLE_VALUE == l_hDevice)
    {
           ShowMessage(AnsiString("Error opening device ") + l_Active.SerialNumber);
    }
    else
    {
            //char l_Test[10];
            //strncpy(l_Test, l_Active.SerialNumber, 9);
            //l_Test[10] = 0x00;
            //l_hDevice = AVS_GetHandleFromSerial(l_Test);

            m_DeviceHandle = l_hDevice;
			btnUpdateListClick(this);
            ConnectGui();
            btnReadMeasFromEEPromClick(this);
    }
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDeactivateClick(TObject *Sender)
{
     AVS_Deactivate(m_DeviceHandle);
     m_DeviceHandle  = INVALID_AVS_HANDLE_VALUE;
     btnUpdateListClick(this);
     DisconnectGui();
}
//---------------------------------------------------------------------------
void TMainForm::ConnectGui()
{
    DeviceConfigType*  l_pDeviceData = NULL;
    unsigned int       l_Size;
    char a_Fpga[16];
    char a_As5216[16];
    char a_Dll[16];

    int l_Res = AVS_GetVersionInfo(m_DeviceHandle, a_Fpga, a_As5216, a_Dll);
    if (ERR_SUCCESS == l_Res)
    {
        edtFPGAver->Text =   CharToString(a_Fpga);
        edtFWver->Text = CharToString(a_As5216);
        edtDLLver->Text =    CharToString(a_Dll);
    }

    if (ERR_SUCCESS == AVS_GetNumPixels(m_DeviceHandle, &m_NrPixels))
    {
        edtNrOfPixels->Text = IntToStr(m_NrPixels);
    }
    l_Res = AVS_GetParameter(m_DeviceHandle, 0, &l_Size, l_pDeviceData);

    if ( l_Res == ERR_INVALID_SIZE)
    {
        l_pDeviceData = (DeviceConfigType*)new char[l_Size];
	}
	l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
	if (l_Res != ERR_SUCCESS)
	{
		DisconnectGui();
		return;
	}
    switch (l_pDeviceData->m_Detector.m_SensorType)
    {
        case SENS_HAMS8378_256     : edtDetectorname->Text = "HAMS8378_256";
                                     break;
        case SENS_HAMS8378_1024    : edtDetectorname->Text = "HAMS8378_1024";
                                     break;
        case SENS_ILX554           : edtDetectorname->Text = "ILX554";
                                     break;
        case SENS_HAMS9201         : edtDetectorname->Text = "HAMS9201";
                                     rdgSetSensitivityMode->Visible = true;
                                     rdgSetSensitivityMode->ItemIndex=0; //LowNoise default for HAMS9201
                                     l_Res = AVS_SetSensitivityMode(m_DeviceHandle, 0);
                                     break;
        case SENS_TCD1304          : edtDetectorname->Text = "TCD1304";
                                     chkPreScan->Visible=true;
                                     chkPreScan->Checked=true;
                                     l_Res = AVS_SetPrescanMode(m_DeviceHandle, chkPreScan->Checked);
                                     break;
        case SENS_TSL1301          : edtDetectorname->Text = "TSL1301";
                                     break;
        case SENS_TSL1401          : edtDetectorname->Text = "TSL1401";
                                     break;
        case SENS_HAMS8378_512     : edtDetectorname->Text = "HAMS8378_512";
                                     break;
        case SENS_HAMS9840         : edtDetectorname->Text = "HAMS9840";
                                     break;
        case SENS_ILX511           : edtDetectorname->Text = "ILX511";
                                     break;
        case SENS_HAMS10420_2048X64: edtDetectorname->Text = "HAMS10420_2048X64";
                                     break;
        case SENS_HAMS11071_2048X64: edtDetectorname->Text = "HAMS11071_2048X64";
                                     break;
        case SENS_HAMS7031_1024X122: edtDetectorname->Text = "HAMS7031_1024X122";
                                     break;
        case SENS_HAMS7031_1024X58 : edtDetectorname->Text = "HAMS7031_1024X58";
                                     break;
        case SENS_HAMS11071_2048X16: edtDetectorname->Text = "HAMS11071_2048X16";
                                     break;
        case SENS_HAMS11155_2048   : edtDetectorname->Text = "HAMS11155";
                                     break;
        case SENS_SU256LSB         : edtDetectorname->Text = "SU256LSB";
                                     rdgSetSensitivityMode->Visible = true;
                                     rdgSetSensitivityMode->ItemIndex=1; //High Sensitive default for SU256LSB
                                     l_Res = AVS_SetSensitivityMode(m_DeviceHandle, 1);
                                     break;
        case SENS_SU512LDB         : edtDetectorname->Text = "SU512LDB";
                                     rdgSetSensitivityMode->Visible = true;
                                     rdgSetSensitivityMode->ItemIndex=1; //High Sensitive default for SU512LDB
                                     l_Res = AVS_SetSensitivityMode(m_DeviceHandle, 1);
                                     break;
		case SENS_HAMS11638        : edtDetectorname->Text = "HAMS11638";
                                     break;
        case SENS_HAMS11639        : edtDetectorname->Text = "HAMS11639";
                                     break;
        case SENS_HAMS12443        : edtDetectorname->Text = "HAMS12443";
                                     break;
        case SENS_HAMG9208_512     : edtDetectorname->Text = "HAMG9208_512";
                                     break;
        default                    : edtDetectorname->Text = "???????";
                                     break;
	}
    m_StartPixels = l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel;
    m_StopPixels = l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel;
    if (NULL != m_pLambda)
    {
        // delete old structure because number of pixels can be changed.
        delete [] m_pLambda;
        m_pLambda = NULL;
    }
    m_pLambda = new double[m_NrPixels];

    if (ERR_SUCCESS == AVS_GetLambda(m_DeviceHandle, m_pLambda))
    {
        Chart1->BottomAxis->SetMinMax(m_pLambda[m_StartPixels],m_pLambda[m_StopPixels]);
    }
    delete [] l_pDeviceData;
}

void TMainForm::DisconnectGui(void)
{
    if (NULL != m_pLambda)
    {
        delete [] m_pLambda;
        m_pLambda = NULL;
    }
    Chart1->BottomAxis->SetMinMax(0,0);
	edtDetectorname->Text = "";
    edtNrOfPixels->Text = "";
    edtFPGAver->Text = "";
    edtFWver->Text = "";
    edtDLLver->Text = "";
}

void __fastcall TMainForm::chkTrigModeHwClick(TObject *Sender)
{
    chkTrigModeSw->Checked = !chkTrigModeHw->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkTrigModeSwClick(TObject *Sender)
{
    chkTrigModeHw->Checked = !chkTrigModeSw->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkTrigSourceExtHwClick(TObject *Sender)
{
    chkTrigSourceSync->Checked = !chkTrigSourceExtHw->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkTrigSourceSyncClick(TObject *Sender)
{
    chkTrigSourceExtHw->Checked = !chkTrigSourceSync->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkTrigTypeEdgeClick(TObject *Sender)
{
    chkTrigTypeLevel->Checked = !chkTrigTypeEdge->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkTrigTypeLevelClick(TObject *Sender)
{
    chkTrigTypeEdge->Checked = !chkTrigTypeLevel->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStartMeasurementClick(TObject *Sender)
{
    // prevent second StartMeasurementClick before sequence ends.
    btnStartMeasurement->Enabled = false;
    //Prepare Measurement
    MeasConfigType   l_PrepareMeasData;
    String l_Line;

    l_PrepareMeasData.m_StartPixel = edtStartPixel->Text.ToInt();
    l_PrepareMeasData.m_StopPixel =  edtStopPixel->Text.ToInt();
    l_PrepareMeasData.m_IntegrationTime = edtIntegrationTime->Text.ToDouble();
    double l_NanoSec = edtIntegrationDelay->Text.ToDouble();
    unsigned int l_FPGAClkCycles = (unsigned int)(6.0*(l_NanoSec+20.84)/125.0);
    l_PrepareMeasData.m_IntegrationDelay = l_FPGAClkCycles;
    l_PrepareMeasData.m_NrAverages = edtNrOfAverages->Text.ToInt();
    l_PrepareMeasData.m_Trigger.m_Mode = chkTrigModeHw->Checked;
    l_PrepareMeasData.m_Trigger.m_Source = chkTrigSourceSync->Checked;
    l_PrepareMeasData.m_Trigger.m_SourceType = chkTrigTypeLevel->Checked;
    l_PrepareMeasData.m_SaturationDetection = edtSaturationLevel->Text.ToInt();
    l_PrepareMeasData.m_CorDynDark.m_Enable = chkEnableDarkCorrection->Checked;
    l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage = edtDarkHist->Text.ToInt();
    l_PrepareMeasData.m_Smoothing.m_SmoothPix = edtSmoothPix->Text.ToInt();
    l_PrepareMeasData.m_Smoothing.m_SmoothModel = edtSmoothModel->Text.ToInt();
    l_PrepareMeasData.m_Control.m_StrobeControl = edtFlashesPerScan->Text.ToInt();
    l_NanoSec = edtLaserDelay->Text.ToDouble();
    l_FPGAClkCycles = (unsigned int)(6.0*l_NanoSec/125.0);
    l_PrepareMeasData.m_Control.m_LaserDelay = l_FPGAClkCycles;
    l_NanoSec = edtLaserWidth->Text.ToDouble();
    l_FPGAClkCycles = (unsigned int)(6.0*l_NanoSec/125.0);
    l_PrepareMeasData.m_Control.m_LaserWidth = l_FPGAClkCycles;
    l_PrepareMeasData.m_Control.m_LaserWaveLength = edtLaserWavelength->Text.ToDouble();
    l_PrepareMeasData.m_Control.m_StoreToRam = edtRamSpectra->Text.ToInt();

    int l_Res = AVS_PrepareMeasure(m_DeviceHandle, &l_PrepareMeasData);
    if (ERR_SUCCESS != l_Res)
    {
		wchar_t buf[80];
		wsprintfW(buf, L"code: %d", l_Res);
		Application->MessageBox(buf, L"Error", MB_OK);
    }
    //Get Nr Of Scans
    short l_NrOfScans = edtNrOfScans->Text.ToInt();
    if ((l_PrepareMeasData.m_Control.m_StoreToRam>0) && (l_NrOfScans!=1))
    {
         edtNrOfScans->Text =IntToStr(1);
         l_NrOfScans=1;
         ShowMessage( IntToStr(l_PrepareMeasData.m_Control.m_StoreToRam)+ " scans will be stored to RAM. " +
                      "The number of measurements (a_Nmsr in AVS_Measure) has been set to 1");
    }
	//Start Measurement
    m_StartTicks = GetTickCount();
    m_Measurements = 0;
    m_Failures = 0;
    edtTotalTime->Text = "0";
    edtPerformedScans->Text = "0";
    edtFailures->Text = "0";
    m_StartPixels = l_PrepareMeasData.m_StartPixel;
    m_StopPixels = l_PrepareMeasData.m_StopPixel;

    l_Res = AVS_Measure(m_DeviceHandle, this->Handle, l_NrOfScans);
    if (ERR_SUCCESS != l_Res)
    {
        switch (l_Res)
        {
        case ERR_INVALID_PARAMETER:
            l_Line = "Meas.Status: invalid parameter";
            StatusBar1->Panels->Items[1]->Text = l_Line;
            break;
        default:
            l_Line = "Meas.Status: start failed, code: " + l_Res;
            StatusBar1->Panels->Items[1]->Text = l_Line;
            break;
        }
    }
    else
    {
        l_Line = "Meas.Status: pending";
        StatusBar1->Panels->Items[1]->Text = l_Line;
    }
}

//---------------------------------------------------------------------------

void __fastcall TMainForm::btnStopMeasurementClick(TObject *Sender)
{
    int l_Res = AVS_StopMeasure(m_DeviceHandle);
    if (ERR_SUCCESS != l_Res)
    {
		wchar_t buf[80];
		wsprintfW(buf, L"code: %d", l_Res);
		Application->MessageBox(buf, L"Error", MB_OK);
    }
    btnStartMeasurement->Enabled = true;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkDisableGraphClick(TObject *Sender)
{
    m_GraphicsDisabled = (chkDisableGraph->Checked);
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnDigIOClick(TObject *Sender)
{
    frmDigIO->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnAnIOClick(TObject *Sender)
{
    frmAnIO->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnShowEEPromClick(TObject *Sender)
{
    frmEEprom->ShowModal();
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnReadMeasFromEEPromClick(TObject *Sender)
{
    DeviceConfigType*  l_pDeviceData = NULL;
    unsigned int       l_Size;

	int l_Res = AVS_GetParameter(m_DeviceHandle, 0, &l_Size, l_pDeviceData);
	if ( l_Res == ERR_INVALID_SIZE)
    {
        l_pDeviceData = (DeviceConfigType*)new char[l_Size];
    }
    l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
		wchar_t buf[80];
		wsprintfW(buf, L"code: %d", l_Res);
		Application->MessageBox(buf, L"Error", MB_OK);
        delete [] l_pDeviceData;
        return;
    }
	//show measurement settings
    edtStartPixel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel);
    edtStopPixel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel);
    edtIntegrationTime->Text = FloatToStrF(l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime,ffFixed,7,2);
    unsigned int l_FPGAClkCycles = l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationDelay;
    double l_NanoSec = 125.0*(l_FPGAClkCycles-1.0)/6.0;
    edtIntegrationDelay->Text = FloatToStrF(l_NanoSec,ffFixed,7,0);
	edtNrOfAverages->Text = IntToStr(int(l_pDeviceData->m_StandAlone.m_Meas.m_NrAverages));
    edtSaturationLevel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_SaturationDetection);
    chkTrigModeHw->Checked =  (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode == 1);
    chkTrigModeSw->Checked =  (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode == 0);
    chkTrigSourceExtHw->Checked =  (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source == 0);
    chkTrigSourceSync->Checked =   (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source == 1);
    chkTrigTypeEdge->Checked = (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType == 0);
    chkTrigTypeLevel->Checked = (l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType == 1);
    chkEnableDarkCorrection->Checked = (l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_Enable == 1);
    edtDarkHist->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage);
    edtSmoothModel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel);
    edtSmoothPix->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix);
    edtFlashesPerScan->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StrobeControl);
    l_FPGAClkCycles = l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserDelay;
    l_NanoSec = 125.0*(l_FPGAClkCycles)/6.0;
	edtLaserDelay->Text = FloatToStrF(l_NanoSec,ffFixed,7,0);
    l_FPGAClkCycles = l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWidth;
    l_NanoSec = 125.0*(l_FPGAClkCycles)/6.0;
    edtLaserWidth->Text = FloatToStrF(l_NanoSec,ffFixed,7,0);
    edtLaserWavelength->Text = FloatToStrF(l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWaveLength,ffFixed,7,3);
    edtRamSpectra->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam);
    edtNrOfScans->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Nmsr);
	delete [] l_pDeviceData;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::btnWriteMeasToEEPromClick(TObject *Sender)
{
    DeviceConfigType*  l_pDeviceData = NULL;
    unsigned int       l_Size;

	int l_Res = AVS_GetParameter(m_DeviceHandle, 0, &l_Size, l_pDeviceData);

    if ( l_Res == ERR_INVALID_SIZE)
    {
        l_pDeviceData = (DeviceConfigType*)new char[l_Size];
    }
    l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
		wchar_t buf[80];
		wsprintfW(buf, L"AVS_GetParameter, code: %d", l_Res);
		Application->MessageBox(buf, L"Error", MB_OK);
        delete [] l_pDeviceData;
        return;
    }
    //Get measurement parameters from main window
    l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel = edtStartPixel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel =  edtStopPixel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime = edtIntegrationTime->Text.ToDouble();
    double l_NanoSec = edtIntegrationDelay->Text.ToDouble();
    unsigned int l_FPGAClkCycles = (unsigned int)(6.0*(l_NanoSec+20.84)/125.0);
    l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationDelay = l_FPGAClkCycles;
    l_pDeviceData->m_StandAlone.m_Meas.m_NrAverages = edtNrOfAverages->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Mode = chkTrigModeHw->Checked;
    l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_Source = chkTrigSourceSync->Checked;
    l_pDeviceData->m_StandAlone.m_Meas.m_Trigger.m_SourceType = chkTrigTypeLevel->Checked;
    l_pDeviceData->m_StandAlone.m_Meas.m_SaturationDetection = edtSaturationLevel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_Enable = chkEnableDarkCorrection->Checked;
    l_pDeviceData->m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage = edtDarkHist->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix = edtSmoothPix->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel = edtSmoothModel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StrobeControl = edtFlashesPerScan->Text.ToInt();
    l_NanoSec = edtLaserDelay->Text.ToDouble();
    l_FPGAClkCycles = (unsigned int)(6.0*l_NanoSec/125.0);
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserDelay = l_FPGAClkCycles;
    l_NanoSec = edtLaserWidth->Text.ToDouble();
    l_FPGAClkCycles = (unsigned int)(6.0*l_NanoSec/125.0);
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWidth = l_FPGAClkCycles;
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_LaserWaveLength = edtLaserWavelength->Text.ToDouble();
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam = edtRamSpectra->Text.ToInt();
	l_pDeviceData->m_StandAlone.m_Nmsr =  edtNrOfScans->Text.ToInt();
	//Write measurement parameters
    l_Res = AVS_SetParameter(MainForm->m_DeviceHandle, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
		wchar_t buf[80];
		wsprintfW(buf, L"AVS_SetParameter, code: %d", l_Res);
		Application->MessageBox(buf, L"Error", MB_OK);
    }
    delete [] l_pDeviceData;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::FormCreate(TObject *Sender)
{
     m_DeviceHandle=INVALID_AVS_HANDLE_VALUE;
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::chkPreScanClick(TObject *Sender)
{
	 int l_Res = AVS_SetPrescanMode(m_DeviceHandle, chkPreScan->Checked);
	 if (l_Res!=ERR_SUCCESS)
         ShowMessage("Error in AVS_SetPrescanMode, code "+ IntToStr(l_Res));
}
//---------------------------------------------------------------------------

void __fastcall TMainForm::rdgSetSensitivityModeClick(TObject *Sender)
{
	 int l_Res =  AVS_SetSensitivityMode(m_DeviceHandle,rdgSetSensitivityMode->ItemIndex);
     if (l_Res!=ERR_SUCCESS)
         ShowMessage("Error in AVS_SetSensitivityMode, code "+ IntToStr(l_Res));
}
//---------------------------------------------------------------------------


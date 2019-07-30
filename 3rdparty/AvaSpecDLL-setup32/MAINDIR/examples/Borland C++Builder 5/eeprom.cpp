//---------------------------------------------------------------------------

#include <vcl.h>
#include <float.h>
#pragma hdrstop
#include "main.h"
#include "convert.h"
#include "eeprom.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TfrmEEprom *frmEEprom;
uint8 const SENSOR_OFFSET = 1;

//---------------------------------------------------------------------------
__fastcall TfrmEEprom::TfrmEEprom(TComponent* Owner)
        : TForm(Owner)
{
  _control87(MCW_EM,MCW_EM);
}
//---------------------------------------------------------------------------
void __fastcall TfrmEEprom::FormShow(TObject *Sender)
{
    DeviceConfigType*  l_pDeviceData = NULL;
    unsigned int       l_Size;


    int l_Res = AVS_GetParameter(MainForm->m_DeviceHandle, 0, &l_Size, l_pDeviceData);

    if ( l_Res == ERR_INVALID_SIZE)
    {
        l_pDeviceData = (DeviceConfigType*)new char[l_Size];
    }
    l_Res = AVS_GetParameter(MainForm->m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
        char buf[80];
        wsprintf(buf, "code: %d", l_Res);
        Application->MessageBox(buf, "Error", MB_OK);
        delete [] l_pDeviceData;
        return;
    }
    //show parameters
    edtLength->Text = IntToStr(l_pDeviceData->m_Len);
    edtVersion->Text = IntToStr(l_pDeviceData->m_ConfigVersion);
    edtUserFriendly->Text = CharToString(l_pDeviceData->m_aUserFriendlyId);
    //show detectortype parameters
    cbDetectorType->ItemIndex  = l_pDeviceData->m_Detector.m_SensorType - SENSOR_OFFSET;
    edtNrOfPixels->Text = IntToStr(l_pDeviceData->m_Detector.m_NrPixels);
    edtWLX0->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aFit[0],ffFixed,8,6);
    edtWLX1->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aFit[1],ffFixed,8,6);
    edtWLX2->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aFit[2],ffExponent,8,6);
    edtWLX3->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aFit[3],ffExponent,8,6);
    edtWLX4->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aFit[4],ffExponent,8,6);
    edtGain1->Text = FloatToStrF(l_pDeviceData->m_Detector.m_Gain[0],ffFixed,7,2);
    edtGain2->Text = FloatToStrF(l_pDeviceData->m_Detector.m_Gain[1],ffFixed,7,2);
    edtOffset1->Text = FloatToStrF(l_pDeviceData->m_Detector.m_Offset[0],ffFixed,7,2);
    edtOffset2->Text = FloatToStrF(l_pDeviceData->m_Detector.m_Offset[1],ffFixed,7,2);
    edtExtOffset->Text = FloatToStrF(l_pDeviceData->m_Detector.m_ExtOffset,ffFixed,7,2);
    edtNLX0->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[0],ffExponent,8,6);
    edtNLX1->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[1],ffExponent,8,6);
    edtNLX2->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[2],ffExponent,8,6);
    edtNLX3->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[3],ffExponent,8,6);
    edtNLX4->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[4],ffExponent,8,6);
    edtNLX5->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[5],ffExponent,8,6);
    edtNLX6->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[6],ffExponent,8,6);
    edtNLX7->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aNLCorrect[7],ffExponent,8,6);
    edtNLLow->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aLowNLCounts,ffExponent,8,6);
    edtNLHigh->Text = FloatToStrF(l_pDeviceData->m_Detector.m_aHighNLCounts,ffExponent,8,6);
    chkEnableNL->Checked = l_pDeviceData->m_Detector.m_NLEnable;

    mmDefPixels->Clear();
    mmDefPixels->Lines->BeginUpdate();
    for (unsigned short i = 0; i < NR_DEFECTIVE_PIXELS; i++)
    {
        mmDefPixels->Lines->Add(IntToStr(l_pDeviceData->m_Detector.m_DefectivePixels[i]));
    }
    mmDefPixels->Lines->EndUpdate();

    //show standalone parameters
    chkEnableStandAlone->Checked = l_pDeviceData->m_StandAlone.m_Enable;
    edtStartPixel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel);
    edtStopPixel->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel);
    edtIntegrationTime->Text = FloatToStrF(l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime,ffFixed,7,2);
    unsigned int l_FPGAClkCycles = l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationDelay;
    double l_NanoSec = 125.0*(l_FPGAClkCycles-1.0)/6.0;
    edtIntegrationDelay->Text = FloatToStrF(l_NanoSec,ffFixed,7,0);
    edtNrOfAverages->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_NrAverages);
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
    edtRamSpectra->Text = 0; //IntToStr(l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam);
                             //prepared for future version
    edtNrOfMeas->Text = IntToStr(l_pDeviceData->m_StandAlone.m_Nmsr);

    //show irradiance parameters
    edtIrradSmoothModel->Text = IntToStr(l_pDeviceData->m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel);
    edtIrradSmoothPixels->Text = IntToStr(l_pDeviceData->m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix);
    edtIrradInttime->Text = FloatToStrF(l_pDeviceData->m_Irradiance.m_IntensityCalib.m_CalInttime,ffFixed,7,2);
    mmIrradConversion->Clear();
    mmIrradConversion->Lines->BeginUpdate();
    for (unsigned short i = 0; i < MAX_NR_PIXELS; i++)
    {
        mmIrradConversion->Lines->Add(FloatToStrF(l_pDeviceData->m_Irradiance.m_IntensityCalib.m_aCalibConvers[i],ffExponent,7,5));
    }
    mmIrradConversion->Lines->EndUpdate();
    edtIrradCalibrationType->Text = IntToStr(l_pDeviceData->m_Irradiance.m_CalibrationType);
    edtIrradFiberDiameter->Text = IntToStr(l_pDeviceData->m_Irradiance.m_FiberDiameter);

    //show reflectance parameters
    edtReflectanceSmoothModel->Text = IntToStr(l_pDeviceData->m_Reflectance.m_Smoothing.m_SmoothModel);
    edtReflectanceSmoothPixels->Text = IntToStr(l_pDeviceData->m_Reflectance.m_Smoothing.m_SmoothPix);
    edtReflectanceInttime->Text = FloatToStrF(l_pDeviceData->m_Reflectance.m_CalInttime,ffFixed,7,2);
    mmReflectanceConversion->Clear();
    mmReflectanceConversion->Lines->BeginUpdate();
    for (unsigned short i = 0; i < MAX_NR_PIXELS; i++)
    {
        mmReflectanceConversion->Lines->Add(FloatToStrF(l_pDeviceData->m_Reflectance.m_aCalibConvers[i],ffExponent,7,5));
    }
    mmReflectanceConversion->Lines->EndUpdate();

    //show correction parameters
    mmCorrection->Clear();
    mmCorrection->Lines->BeginUpdate();
    for (unsigned short i = 0; i < MAX_NR_PIXELS; i++)
    {
        mmCorrection->Lines->Add(FloatToStrF(l_pDeviceData->m_SpectrumCorrect.m_aSpectrumCorrect[i],ffExponent,7,5));
    }
    mmCorrection->Lines->EndUpdate();

    //show thermistor parameters
    edtNTC1X0->Text = FloatToStrF(l_pDeviceData->m_aTemperature[0].m_aFit[0],ffExponent,8,6);
    edtNTC1X1->Text = FloatToStrF(l_pDeviceData->m_aTemperature[0].m_aFit[1],ffExponent,8,6);
    edtNTC1X2->Text = FloatToStrF(l_pDeviceData->m_aTemperature[0].m_aFit[2],ffExponent,8,6);
    edtNTC1X3->Text = FloatToStrF(l_pDeviceData->m_aTemperature[0].m_aFit[3],ffExponent,8,6);
    edtNTC1X4->Text = FloatToStrF(l_pDeviceData->m_aTemperature[0].m_aFit[4],ffExponent,8,6);

    edtNTC2X0->Text = FloatToStrF(l_pDeviceData->m_aTemperature[1].m_aFit[0],ffExponent,8,6);
    edtNTC2X1->Text = FloatToStrF(l_pDeviceData->m_aTemperature[1].m_aFit[1],ffExponent,8,6);
    edtNTC2X2->Text = FloatToStrF(l_pDeviceData->m_aTemperature[1].m_aFit[2],ffExponent,8,6);
    edtNTC2X3->Text = FloatToStrF(l_pDeviceData->m_aTemperature[1].m_aFit[3],ffExponent,8,6);
    edtNTC2X4->Text = FloatToStrF(l_pDeviceData->m_aTemperature[1].m_aFit[4],ffExponent,8,6);

    edtThermistorX0->Text = FloatToStrF(l_pDeviceData->m_aTemperature[2].m_aFit[0],ffExponent,8,6);
    edtThermistorX1->Text = FloatToStrF(l_pDeviceData->m_aTemperature[2].m_aFit[1],ffExponent,8,6);
    edtThermistorX2->Text = FloatToStrF(l_pDeviceData->m_aTemperature[2].m_aFit[2],ffExponent,8,6);
    edtThermistorX3->Text = FloatToStrF(l_pDeviceData->m_aTemperature[2].m_aFit[3],ffExponent,8,6);
    edtThermistorX4->Text = FloatToStrF(l_pDeviceData->m_aTemperature[2].m_aFit[4],ffExponent,8,6);

    //show TEC Control parameters
    chkEnableTec->Checked =  l_pDeviceData->m_TecControl.m_Enable;
    edtSetPoint->Text = FloatToStrF(l_pDeviceData->m_TecControl.m_Setpoint,ffFixed,7,1);
    edtTecX0->Text = FloatToStrF(l_pDeviceData->m_TecControl.m_aFit[0],ffFixed,7,3);
    edtTecX1->Text = FloatToStrF(l_pDeviceData->m_TecControl.m_aFit[1],ffFixed,7,3);

    delete [] l_pDeviceData;
}
//---------------------------------------------------------------------------


void __fastcall TfrmEEprom::btnSaveToEEPromClick(TObject *Sender)
{
    DeviceConfigType*  l_pDeviceData = NULL;
    unsigned int       l_Size;


    int l_Res = AVS_GetParameter(MainForm->m_DeviceHandle, 0, &l_Size, l_pDeviceData);

    if ( l_Res == ERR_INVALID_SIZE)
    {
        l_pDeviceData = (DeviceConfigType*)new char[l_Size];
    }
    l_Res = AVS_GetParameter(MainForm->m_DeviceHandle, l_Size, &l_Size, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
        char buf[80];
        wsprintf(buf, "AVS_GetParameter, code: %d", l_Res);
        Application->MessageBox(buf, "Error", MB_OK);
        delete [] l_pDeviceData;
        return;
    }
    //Get parameters
    l_pDeviceData->m_ConfigVersion = edtVersion->Text.ToInt();
    strcpy(l_pDeviceData->m_aUserFriendlyId, edtUserFriendly->Text.c_str());

    //Get detector parameters
    l_pDeviceData->m_Detector.m_SensorType = cbDetectorType->ItemIndex + SENSOR_OFFSET;
    l_pDeviceData->m_Detector.m_NrPixels = edtNrOfPixels->Text.ToInt();
    l_pDeviceData->m_Detector.m_aFit[0] = edtWLX0->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aFit[1] = edtWLX1->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aFit[2] = edtWLX2->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aFit[3] = edtWLX3->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aFit[4] = edtWLX4->Text.ToDouble();
    l_pDeviceData->m_Detector.m_Gain[0] = edtGain1->Text.ToDouble();
    l_pDeviceData->m_Detector.m_Gain[1] = edtGain2->Text.ToDouble();
    l_pDeviceData->m_Detector.m_Offset[0] = edtOffset1->Text.ToDouble();
    l_pDeviceData->m_Detector.m_Offset[1] = edtOffset2->Text.ToDouble();
    l_pDeviceData->m_Detector.m_ExtOffset = edtExtOffset->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[0] = edtNLX0->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[1] = edtNLX1->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[2] = edtNLX2->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[3] = edtNLX3->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[4] = edtNLX4->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[5] = edtNLX5->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[6] = edtNLX6->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aNLCorrect[7] = edtNLX7->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aLowNLCounts  = edtNLLow->Text.ToDouble();
    l_pDeviceData->m_Detector.m_aHighNLCounts = edtNLHigh->Text.ToDouble();
    l_pDeviceData->m_Detector.m_NLEnable      = chkEnableNL->Checked;

    for (unsigned short i = 0; (i < NR_DEFECTIVE_PIXELS) && (i<mmDefPixels->Lines->Count); i++)
    {
        l_pDeviceData->m_Detector.m_DefectivePixels[i] = mmDefPixels->Lines->Strings[i].ToInt();
    }
    //Get standalone parameters
    l_pDeviceData->m_StandAlone.m_Enable = chkEnableStandAlone->Checked;
    l_pDeviceData->m_StandAlone.m_Meas.m_StartPixel = edtStartPixel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_StopPixel =  edtStopPixel->Text.ToInt();
    l_pDeviceData->m_StandAlone.m_Meas.m_IntegrationTime = edtIntegrationTime->Text.ToDouble();
    double l_NanoSec = edtIntegrationDelay->Text.ToDouble();
    unsigned int l_FPGAClkCycles = (unsigned int)(0.5+6.0*(l_NanoSec+20.84)/125.0);
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
    l_pDeviceData->m_StandAlone.m_Meas.m_Control.m_StoreToRam = 0; //edtRamSpectra->Text.ToInt();
                                                                   //prepared for future version
    l_pDeviceData->m_StandAlone.m_Nmsr =  edtNrOfMeas->Text.ToInt();

    //Get Irradiance parameters
    l_pDeviceData->m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel = edtIrradSmoothModel->Text.ToInt();
    l_pDeviceData->m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix = edtIrradSmoothPixels->Text.ToInt();
    l_pDeviceData->m_Irradiance.m_IntensityCalib.m_CalInttime = edtIrradInttime->Text.ToDouble();
    for (unsigned short i = 0; (i < MAX_NR_PIXELS) && (i<mmIrradConversion->Lines->Count); i++)
    {
        l_pDeviceData->m_Irradiance.m_IntensityCalib.m_aCalibConvers[i] = mmIrradConversion->Lines->Strings[i].ToDouble();
    }
    l_pDeviceData->m_Irradiance.m_CalibrationType = edtIrradCalibrationType->Text.ToInt();
    l_pDeviceData->m_Irradiance.m_FiberDiameter = edtIrradFiberDiameter->Text.ToInt();

    //Get Reflectance parameters
    l_pDeviceData->m_Reflectance.m_Smoothing.m_SmoothModel = edtReflectanceSmoothModel->Text.ToInt();
    l_pDeviceData->m_Reflectance.m_Smoothing.m_SmoothPix = edtReflectanceSmoothPixels->Text.ToInt();
    l_pDeviceData->m_Reflectance.m_CalInttime = edtReflectanceInttime->Text.ToDouble();
    for (unsigned short i = 0; (i < MAX_NR_PIXELS) && (i<mmReflectanceConversion->Lines->Count); i++)
    {
        l_pDeviceData->m_Reflectance.m_aCalibConvers[i] = mmReflectanceConversion->Lines->Strings[i].ToDouble();
    }

    //Get Correction parameters
    for (unsigned short i = 0; (i < MAX_NR_PIXELS) && (i<mmCorrection->Lines->Count); i++)
    {
        l_pDeviceData->m_SpectrumCorrect.m_aSpectrumCorrect[i] = mmCorrection->Lines->Strings[i].ToDouble();
    }

    //Get Thermistor parameters
    l_pDeviceData->m_aTemperature[0].m_aFit[0] = edtNTC1X0->Text.ToDouble();
    l_pDeviceData->m_aTemperature[0].m_aFit[1] = edtNTC1X1->Text.ToDouble();
    l_pDeviceData->m_aTemperature[0].m_aFit[2] = edtNTC1X2->Text.ToDouble();
    l_pDeviceData->m_aTemperature[0].m_aFit[3] = edtNTC1X3->Text.ToDouble();
    l_pDeviceData->m_aTemperature[0].m_aFit[4] = edtNTC1X4->Text.ToDouble();
    l_pDeviceData->m_aTemperature[1].m_aFit[0] = edtNTC2X0->Text.ToDouble();
    l_pDeviceData->m_aTemperature[1].m_aFit[1] = edtNTC2X1->Text.ToDouble();
    l_pDeviceData->m_aTemperature[1].m_aFit[2] = edtNTC2X2->Text.ToDouble();
    l_pDeviceData->m_aTemperature[1].m_aFit[3] = edtNTC2X3->Text.ToDouble();
    l_pDeviceData->m_aTemperature[1].m_aFit[4] = edtNTC2X4->Text.ToDouble();
    l_pDeviceData->m_aTemperature[2].m_aFit[0] = edtThermistorX0->Text.ToDouble();
    l_pDeviceData->m_aTemperature[2].m_aFit[1] = edtThermistorX1->Text.ToDouble();
    l_pDeviceData->m_aTemperature[2].m_aFit[2] = edtThermistorX2->Text.ToDouble();
    l_pDeviceData->m_aTemperature[2].m_aFit[3] = edtThermistorX3->Text.ToDouble();
    l_pDeviceData->m_aTemperature[2].m_aFit[4] = edtThermistorX4->Text.ToDouble();

    //Get Tec Control parameters
    l_pDeviceData->m_TecControl.m_Enable   = chkEnableTec->Checked ;
    l_pDeviceData->m_TecControl.m_Setpoint = edtSetPoint->Text.ToDouble() ;
    l_pDeviceData->m_TecControl.m_aFit[0]  = edtTecX0->Text.ToDouble() ;
    l_pDeviceData->m_TecControl.m_aFit[1]  = edtTecX1->Text.ToDouble() ;



    //Write parameters
    l_Res = AVS_SetParameter(MainForm->m_DeviceHandle, l_pDeviceData);
    if (ERR_SUCCESS != l_Res)
    {
        char buf[80];
        wsprintf(buf, "AVS_SetParameter, code: %d", l_Res);
        Application->MessageBox(buf, "Error", MB_OK);
    }

    delete [] l_pDeviceData;

}

//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigModeHwClick(TObject *Sender)
{
  chkTrigModeSw->Checked = !chkTrigModeHw->Checked;        
}
//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigModeSwClick(TObject *Sender)
{
   chkTrigModeHw->Checked = !chkTrigModeSw->Checked;        
}
//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigSourceExtHwClick(TObject *Sender)
{
    chkTrigSourceSync->Checked = !chkTrigSourceExtHw->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigSourceSyncClick(TObject *Sender)
{
    chkTrigSourceExtHw->Checked = !chkTrigSourceSync->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigTypeEdgeClick(TObject *Sender)
{
    chkTrigTypeLevel->Checked = !chkTrigTypeEdge->Checked;
}
//---------------------------------------------------------------------------

void __fastcall TfrmEEprom::chkTrigTypeLevelClick(TObject *Sender)
{
    chkTrigTypeEdge->Checked = !chkTrigTypeLevel->Checked;
}
//---------------------------------------------------------------------------


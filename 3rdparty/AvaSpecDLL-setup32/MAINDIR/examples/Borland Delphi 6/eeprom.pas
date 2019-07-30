unit eeprom;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ExtCtrls, StdCtrls, ComCtrls, Buttons;

type
  TfrmEEprom = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label66: TLabel;
    btnSaveToEEProm: TBitBtn;
    btnCancel: TBitBtn;
    pcEEprom: TPageControl;
    tsDetector: TTabSheet;
    Label4: TLabel;
    Label5: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    Label86: TLabel;
    Label87: TLabel;
    Label88: TLabel;
    Label89: TLabel;
    edtNrOfPixels: TEdit;
    gbWaveLengthCalibration: TGroupBox;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    edtWLX0: TEdit;
    edtWLX1: TEdit;
    edtWLX2: TEdit;
    edtWLX3: TEdit;
    edtWLX4: TEdit;
    edtGain1: TEdit;
    edtOffset1: TEdit;
    gbDefPixels: TGroupBox;
    mmDefPixels: TMemo;
    gbNLCalibration: TGroupBox;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label17: TLabel;
    Label18: TLabel;
    Label19: TLabel;
    Label20: TLabel;
    edtNLX0: TEdit;
    edtNLX1: TEdit;
    edtNLX2: TEdit;
    edtNLX3: TEdit;
    edtNLX4: TEdit;
    edtNLX5: TEdit;
    edtNLX6: TEdit;
    edtNLX7: TEdit;
    chkEnableNL: TCheckBox;
    cbDetectorType: TComboBox;
    edtGain2: TEdit;
    edtOffset2: TEdit;
    tsStandAlone: TTabSheet;
    Label43: TLabel;
    gbPrepareMeasSettings: TGroupBox;
    Label21: TLabel;
    Label22: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    edtStartPixel: TEdit;
    edtStopPixel: TEdit;
    edtIntegrationTime: TEdit;
    edtIntegrationDelay: TEdit;
    edtNrOfAverages: TEdit;
    gbTrigger: TGroupBox;
    Label29: TLabel;
    Label31: TLabel;
    Label32: TLabel;
    chkTrigTypeLevel: TCheckBox;
    chkTrigTypeEdge: TCheckBox;
    chkTrigSourceSync: TCheckBox;
    chkTrigSourceExtHw: TCheckBox;
    chkTrigModeSw: TCheckBox;
    chkTrigModeHw: TCheckBox;
    gbDarkCorrection: TGroupBox;
    Label30: TLabel;
    chkEnableDarkCorrection: TCheckBox;
    edtDarkHist: TEdit;
    gbSmoothing: TGroupBox;
    Label33: TLabel;
    Label34: TLabel;
    edtSmoothModel: TEdit;
    edtSmoothPix: TEdit;
    edtSaturationLevel: TEdit;
    gbControl: TGroupBox;
    Label35: TLabel;
    Label36: TLabel;
    Label37: TLabel;
    Label38: TLabel;
    Label39: TLabel;
    Label40: TLabel;
    Label41: TLabel;
    Label42: TLabel;
    edtFlashesPerScan: TEdit;
    edtLaserDelay: TEdit;
    edtLaserWidth: TEdit;
    edtLaserWavelength: TEdit;
    edtRamSpectra: TEdit;
    chkEnableStandAlone: TCheckBox;
    edtNrOfMeas: TEdit;
    tsIrradianceCalibration: TTabSheet;
    Label58: TLabel;
    Label59: TLabel;
    Label60: TLabel;
    edtIrradCalibrationType: TEdit;
    edtIrradFiberDiameter: TEdit;
    gbIrradCalibration: TGroupBox;
    Label55: TLabel;
    Label56: TLabel;
    Label57: TLabel;
    mmIrradConversion: TMemo;
    gbIrradSmooth: TGroupBox;
    Label53: TLabel;
    Label54: TLabel;
    edtIrradSmoothModel: TEdit;
    edtIrradSmoothPixels: TEdit;
    edtIrradInttime: TEdit;
    tsReflectanceCalibration: TTabSheet;
    gbReflectanceCalibration: TGroupBox;
    Label61: TLabel;
    Label62: TLabel;
    Label63: TLabel;
    mmReflectanceConversion: TMemo;
    gbReflectanceSmooth: TGroupBox;
    Label64: TLabel;
    Label65: TLabel;
    edtReflectanceSmoothModel: TEdit;
    edtReflectanceSmoothPixels: TEdit;
    edtReflectanceInttime: TEdit;
    tsCorrection: TTabSheet;
    gbCorrection: TGroupBox;
    mmCorrection: TMemo;
    tsTempSensor: TTabSheet;
    gbNTC1: TGroupBox;
    Label71: TLabel;
    Label72: TLabel;
    Label73: TLabel;
    Label74: TLabel;
    Label75: TLabel;
    edtNTC1X0: TEdit;
    edtNTC1X1: TEdit;
    edtNTC1X2: TEdit;
    edtNTC1X3: TEdit;
    edtNTC1X4: TEdit;
    gbNTC2: TGroupBox;
    Label76: TLabel;
    Label77: TLabel;
    Label78: TLabel;
    Label79: TLabel;
    Label80: TLabel;
    edtNTC2X0: TEdit;
    edtNTC2X1: TEdit;
    edtNTC2X2: TEdit;
    edtNTC2X3: TEdit;
    edtNTC2X4: TEdit;
    gbThermistor: TGroupBox;
    Label81: TLabel;
    Label82: TLabel;
    Label83: TLabel;
    Label84: TLabel;
    Label85: TLabel;
    edtThermistorX0: TEdit;
    edtThermistorX1: TEdit;
    edtThermistorX2: TEdit;
    edtThermistorX3: TEdit;
    edtThermistorX4: TEdit;
    edtLength: TEdit;
    edtVersion: TEdit;
    edtUserFriendly: TEdit;
    edtExtOffset: TEdit;
    Ext: TLabel;
    Label67: TLabel;
    edtNLLow: TEdit;
    edtNLHigh: TEdit;
    Label68: TLabel;
    tsTecControl: TTabSheet;
    chkEnableTec: TCheckBox;
    Label90: TLabel;
    edtSetPoint: TEdit;
    Label70: TLabel;
    GroupBox1: TGroupBox;
    Label91: TLabel;
    Label92: TLabel;
    edtTecX0: TEdit;
    edtTecX1: TEdit;
    procedure FormShow(Sender: TObject);
    procedure btnSaveToEEPromClick(Sender: TObject);
    procedure chkTrigModeHwClick(Sender: TObject);
    procedure chkTrigModeSwClick(Sender: TObject);
    procedure chkTrigSourceExtHwClick(Sender: TObject);
    procedure chkTrigSourceSyncClick(Sender: TObject);
    procedure chkTrigTypeEdgeClick(Sender: TObject);
    procedure chkTrigTypeLevelClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmEEprom: TfrmEEprom;

implementation

{$R *.dfm}

uses main, avaspec;

procedure TfrmEEprom.FormShow(Sender: TObject);
var
   l_Res: longint;
   l_pDeviceData: pDeviceConfigType;
   l_RequiredSize: DWord;
   l_string:string;
   i:smallint;
   l_FPGAClkCycles:DWord;
   l_NanoSec:double;
begin
    l_pDeviceData:=nil;
    l_Res := AVS_GetParameter(m_DeviceHandle, 0, l_RequiredSize, l_pDeviceData);
    if ( l_Res = ERR_INVALID_SIZE) then
    begin
         GetMem(l_pDeviceData, l_RequiredSize);
         l_Res := AVS_GetParameter(m_DeviceHandle, l_RequiredSize, l_RequiredSize, l_pDeviceData);
    end;
    if (l_Res <> ERR_SUCCESS) then
    begin
         ShowMessage('Error in AVS_GetParameter, code '+ IntToStr(l_Res));
    end
    else
    begin
         //show parameters
         edtLength.Text := IntToStr(l_pDeviceData.m_Len);
         edtVersion.Text := IntToStr(l_pDeviceData.m_ConfigVersion);
         l_string := l_pDeviceData.m_aUserFriendlyId;
         edtUserFriendly.Text := l_string;

         //show detectortype parameters
         case l_pDeviceData.m_Detector.m_SensorType of
              SENS_HAMS8378_256      : cbDetectorType.ItemIndex   := 0;
              SENS_HAMS8378_1024     : cbDetectorType.ItemIndex   := 1;
              SENS_ILX554            : cbDetectorType.ItemIndex   := 2;
              SENS_HAMS9201          : cbDetectorType.ItemIndex   := 3;
              SENS_TCD1304           : cbDetectorType.ItemIndex   := 4;
              SENS_TSL1301           : cbDetectorType.ItemIndex   := 5;
              SENS_TSL1401           : cbDetectorType.ItemIndex   := 6;
              SENS_HAMS8378_512      : cbDetectorType.ItemIndex   := 7;
              SENS_HAMS9840          : cbDetectorType.ItemIndex   := 8;
              SENS_ILX511            : cbDetectorType.ItemIndex   := 9;
              SENS_HAMS10420_2048X64 : cbDetectorType.ItemIndex   := 10;
              SENS_HAMS11071_2048X64 : cbDetectorType.ItemIndex   := 11;
              SENS_HAMS7031_1024X122 : cbDetectorType.ItemIndex   := 12;
              SENS_HAMS7031_1024X58  : cbDetectorType.ItemIndex   := 13;
              SENS_HAMS11071_2048X16 : cbDetectorType.ItemIndex   := 14;
              SENS_HAMS11155         : cbDetectorType.ItemIndex   := 15;
              SENS_SU256LSB          : cbDetectorType.ItemIndex   := 16;
              SENS_SU512LDB          : cbDetectorType.ItemIndex   := 17;



         end;
         edtNrOfPixels.Text := IntToStr(l_pDeviceData.m_Detector.m_NrPixels);
         edtWLX0.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aFit[0],ffFixed,8,6);
         edtWLX1.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aFit[1],ffFixed,8,6);
         edtWLX2.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aFit[2],ffExponent,8,6);
         edtWLX3.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aFit[3],ffExponent,8,6);
         edtWLX4.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aFit[4],ffExponent,8,6);
         edtGain1.Text := FloatToStrF(l_pDeviceData.m_Detector.m_Gain[0],ffFixed,7,2);
         edtGain2.Text := FloatToStrF(l_pDeviceData.m_Detector.m_Gain[1],ffFixed,7,2);
         edtOffset1.Text := FloatToStrF(l_pDeviceData.m_Detector.m_Offset[0],ffFixed,7,2);
         edtOffset2.Text := FloatToStrF(l_pDeviceData.m_Detector.m_Offset[1],ffFixed,7,2);
         edtExtOffset.Text := FloatToStrF(l_pDeviceData.m_Detector.m_ExtOffset,ffFixed,7,2);
         edtNLX0.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[0],ffExponent,8,6);
         edtNLX1.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[1],ffExponent,8,6);
         edtNLX2.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[2],ffExponent,8,6);
         edtNLX3.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[3],ffExponent,8,6);
         edtNLX4.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[4],ffExponent,8,6);
         edtNLX5.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[5],ffExponent,8,6);
         edtNLX6.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[6],ffExponent,8,6);
         edtNLX7.Text := FloatToStrF(l_pDeviceData.m_Detector.m_aNLCorrect[7],ffExponent,8,6);
         edtNLLow.Text:= FloatToStrF(l_pDeviceData.m_Detector.m_aLowNLCounts,ffFixed,7,2);
         edtNLHigh.Text:= FloatToStrF(l_pDeviceData.m_Detector.m_aHighNLCounts,ffFixed,7,2);
         chkEnableNL.Checked := l_pDeviceData.m_Detector.m_NLEnable;
         mmDefPixels.Clear;
         mmDefPixels.Lines.BeginUpdate;
         for i := 0 to (NR_DEFECTIVE_PIXELS-1) do
         begin
              mmDefPixels.Lines.Add(IntToStr(l_pDeviceData.m_Detector.m_DefectivePixels[i]));
         end;
         mmDefPixels.Lines.EndUpdate;

         //show standalone parameters
         chkEnableStandAlone.Checked := l_pDeviceData.m_StandAlone.m_Enable;
         edtStartPixel.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel);
         edtStopPixel.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel);
         edtIntegrationTime.Text := FloatToStrF(l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime,ffFixed,7,2);
         l_FPGAClkCycles := l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay;
         l_NanoSec := 125.0*(l_FPGAClkCycles-1.0)/6.0;
         edtIntegrationDelay.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
         edtNrOfAverages.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages);
         edtSaturationLevel.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection);
         chkTrigModeHw.Checked :=  (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 1);
         chkTrigModeSw.Checked :=  (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 0);
         chkTrigSourceExtHw.Checked :=  (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0);
         chkTrigSourceSync.Checked :=   (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1);
         chkTrigTypeEdge.Checked := (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 0);
         chkTrigTypeLevel.Checked := (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 1);
         chkEnableDarkCorrection.Checked := (l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1);
         edtDarkHist.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage);
         edtSmoothModel.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel);
         edtSmoothPix.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix);
         edtFlashesPerScan.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl);
         l_FPGAClkCycles := l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay;
         l_NanoSec := 125.0*(l_FPGAClkCycles)/6.0;
         edtLaserDelay.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
         l_FPGAClkCycles := l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth;
         l_NanoSec := 125.0*(l_FPGAClkCycles)/6.0;
         edtLaserWidth.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
         edtLaserWavelength.Text := FloatToStrF(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength,ffFixed,7,3);
         edtRamSpectra.Text :=  '0'; //IntToStr(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam);
                                     //prepared for future versions
         edtNrOfMeas.Text := IntToStr(l_pDeviceData.m_StandAlone.m_Nmsr);

         //show irradiance parameters
         edtIrradSmoothModel.Text := IntToStr(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel);
         edtIrradSmoothPixels.Text := IntToStr(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix);
         edtIrradInttime.Text := FloatToStrF(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_CalInttime,ffFixed,7,2);
         mmIrradConversion.Clear;
         mmIrradConversion.Lines.BeginUpdate;
         for i := 0 to MAX_NR_PIXELS-1 do
             mmIrradConversion.Lines.Add(FloatToStrF(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_aCalibConvers[i],ffExponent,7,5));
         mmIrradConversion.Lines.EndUpdate;
         edtIrradCalibrationType.Text := IntToStr(l_pDeviceData.m_Irradiance.m_CalibrationType);
         edtIrradFiberDiameter.Text := IntToStr(l_pDeviceData.m_Irradiance.m_FiberDiameter);

         //show reflectance parameters
         edtReflectanceSmoothModel.Text := IntToStr(l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothModel);
         edtReflectanceSmoothPixels.Text := IntToStr(l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothPix);
         edtReflectanceInttime.Text := FloatToStrF(l_pDeviceData.m_Reflectance.m_CalInttime,ffFixed,7,2);
         mmReflectanceConversion.Clear;
         mmReflectanceConversion.Lines.BeginUpdate;
         for i := 0 to MAX_NR_PIXELS-1 do
             mmReflectanceConversion.Lines.Add(FloatToStrF(l_pDeviceData.m_Reflectance.m_aCalibConvers[i],ffExponent,7,5));
         mmReflectanceConversion.Lines.EndUpdate;

         //show correction parameters
         mmCorrection.Clear;
         mmCorrection.Lines.BeginUpdate;
         for i := 0 to MAX_NR_PIXELS-1 do
             mmCorrection.Lines.Add(FloatToStrF(l_pDeviceData.m_SpectrumCorrect.m_aSpectrumCorrect[i],ffExponent,7,5));
         mmCorrection.Lines.EndUpdate;

         //show thermistor parameters
         edtNTC1X0.Text := FloatToStrF(l_pDeviceData.m_aTemperature[0].m_aFit[0],ffExponent,8,6);
         edtNTC1X1.Text := FloatToStrF(l_pDeviceData.m_aTemperature[0].m_aFit[1],ffExponent,8,6);
         edtNTC1X2.Text := FloatToStrF(l_pDeviceData.m_aTemperature[0].m_aFit[2],ffExponent,8,6);
         edtNTC1X3.Text := FloatToStrF(l_pDeviceData.m_aTemperature[0].m_aFit[3],ffExponent,8,6);
         edtNTC1X4.Text := FloatToStrF(l_pDeviceData.m_aTemperature[0].m_aFit[4],ffExponent,8,6);

         edtNTC2X0.Text := FloatToStrF(l_pDeviceData.m_aTemperature[1].m_aFit[0],ffExponent,8,6);
         edtNTC2X1.Text := FloatToStrF(l_pDeviceData.m_aTemperature[1].m_aFit[1],ffExponent,8,6);
         edtNTC2X2.Text := FloatToStrF(l_pDeviceData.m_aTemperature[1].m_aFit[2],ffExponent,8,6);
         edtNTC2X3.Text := FloatToStrF(l_pDeviceData.m_aTemperature[1].m_aFit[3],ffExponent,8,6);
         edtNTC2X4.Text := FloatToStrF(l_pDeviceData.m_aTemperature[1].m_aFit[4],ffExponent,8,6);

         edtThermistorX0.Text := FloatToStrF(l_pDeviceData.m_aTemperature[2].m_aFit[0],ffExponent,8,6);
         edtThermistorX1.Text := FloatToStrF(l_pDeviceData.m_aTemperature[2].m_aFit[1],ffExponent,8,6);
         edtThermistorX2.Text := FloatToStrF(l_pDeviceData.m_aTemperature[2].m_aFit[2],ffExponent,8,6);
         edtThermistorX3.Text := FloatToStrF(l_pDeviceData.m_aTemperature[2].m_aFit[3],ffExponent,8,6);
         edtThermistorX4.Text := FloatToStrF(l_pDeviceData.m_aTemperature[2].m_aFit[4],ffExponent,8,6);

         //show TEC Control parameters
         chkEnableTec.Checked :=  l_pDeviceData.m_TecControl.m_Enable;
         edtSetPoint.Text := FloatToStrF(l_pDeviceData.m_TecControl.m_Setpoint,ffFixed,7,1);
         edtTecX0.Text := FloatToStrF(l_pDeviceData.m_TecControl.m_aFit[0],ffFixed,7,3);
         edtTecX1.Text := FloatToStrF(l_pDeviceData.m_TecControl.m_aFit[1],ffFixed,7,3);


    end;
    FreeMem(l_pDeviceData);

end;

procedure TfrmEEprom.btnSaveToEEPromClick(Sender: TObject);
var
   l_Res: longint;
   l_pDeviceData: pDeviceConfigType;
   l_RequiredSize: DWord;
   i:smallint;
   l_FPGAClkCycles:DWord;
   l_NanoSec:double;

begin
    l_pDeviceData:=nil;
    l_Res := AVS_GetParameter(m_DeviceHandle, 0, l_RequiredSize, l_pDeviceData);
    if ( l_Res = ERR_INVALID_SIZE) then
    begin
         GetMem(l_pDeviceData, l_RequiredSize);
         l_Res := AVS_GetParameter(m_DeviceHandle, l_RequiredSize, l_RequiredSize, l_pDeviceData);
    end;
    if (l_Res <> ERR_SUCCESS) then
    begin
         ShowMessage('Error in AVS_GetParameter, code '+ IntToStr(l_Res));
    end
    else
    begin
         //Get parameters
         l_pDeviceData.m_ConfigVersion := StrToInt(edtVersion.Text);
         StrPCopy(l_pDeviceData.m_aUserFriendlyId, edtUserFriendly.Text);

         //Get detector parameters
         case cbDetectorType.ItemIndex of
         0: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS8378_256;
         1: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS8378_1024;
         2: l_pDeviceData.m_Detector.m_SensorType:=SENS_ILX554;
         3: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS9201;
         4: l_pDeviceData.m_Detector.m_SensorType:=SENS_TCD1304;
         5: l_pDeviceData.m_Detector.m_SensorType:=SENS_TSL1301;
         6: l_pDeviceData.m_Detector.m_SensorType:=SENS_TSL1401;
         7: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS8378_512;
         8: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS9840;
         9: l_pDeviceData.m_Detector.m_SensorType:=SENS_ILX511;
         10: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS10420_2048X64;
         11: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS11071_2048X64;
         12: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS7031_1024X122;
         13: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS7031_1024X58;
         14: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS11071_2048X16;
         15: l_pDeviceData.m_Detector.m_SensorType:=SENS_HAMS11155;
         16: l_pDeviceData.m_Detector.m_SensorType:=SENS_SU256LSB;
         17: l_pDeviceData.m_Detector.m_SensorType:=SENS_SU512LDB;

         else
             l_pDeviceData.m_Detector.m_SensorType:=SENS_ILX554;
         end;
         l_pDeviceData.m_Detector.m_NrPixels := StrToInt(edtNrOfPixels.Text);
         l_pDeviceData.m_Detector.m_aFit[0] := StrToFloat(edtWLX0.Text);
         l_pDeviceData.m_Detector.m_aFit[1] := StrToFloat(edtWLX1.Text);
         l_pDeviceData.m_Detector.m_aFit[2] := StrToFloat(edtWLX2.Text);
         l_pDeviceData.m_Detector.m_aFit[3] := StrToFloat(edtWLX3.Text);
         l_pDeviceData.m_Detector.m_aFit[4] := StrToFloat(edtWLX4.Text);
         l_pDeviceData.m_Detector.m_Gain[0] := StrToFloat(edtGain1.Text);
         l_pDeviceData.m_Detector.m_Gain[1] := StrToFloat(edtGain2.Text);
         l_pDeviceData.m_Detector.m_Offset[0] := StrToFloat(edtOffset1.Text);
         l_pDeviceData.m_Detector.m_Offset[1] := StrToFloat(edtOffset2.Text);
         l_pDeviceData.m_Detector.m_ExtOffset := StrToFloat(edtExtOffset.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[0] := StrToFloat(edtNLX0.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[1] := StrToFloat(edtNLX1.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[2] := StrToFloat(edtNLX2.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[3] := StrToFloat(edtNLX3.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[4] := StrToFloat(edtNLX4.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[5] := StrToFloat(edtNLX5.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[6] := StrToFloat(edtNLX6.Text);
         l_pDeviceData.m_Detector.m_aNLCorrect[7] := StrToFloat(edtNLX7.Text);
         if (chkEnableNL.Checked) then
            l_pDeviceData.m_Detector.m_NLEnable := true
         else
             l_pDeviceData.m_Detector.m_NLEnable := false;
         l_pDeviceData.m_Detector.m_aLowNLCounts:=StrToFloat(edtNLLow.Text);
         l_pDeviceData.m_Detector.m_aHighNLCounts:=StrToFloat(edtNLHigh.Text);
         i:=0;
         while ((i < NR_DEFECTIVE_PIXELS) and (i<mmDefPixels.Lines.Count)) do
         begin
             l_pDeviceData.m_Detector.m_DefectivePixels[i] := StrToInt(mmDefPixels.Lines.Strings[i]);
             i:=i+1;
         end;

         //Get standalone parameters
         l_pDeviceData.m_StandAlone.m_Enable := chkEnableStandAlone.Checked;
         l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel := StrToInt(edtStartPixel.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel :=  StrToInt(edtStopPixel.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime := StrToFloat(edtIntegrationTime.Text);
         l_NanoSec := StrToFloat(edtIntegrationDelay.Text);
         l_FPGAClkCycles := round(0.5+6.0*(l_NanoSec+20.84)/125.0);
         l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay := l_FPGAClkCycles;
         l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages := StrToInt(edtNrOfAverages.Text);
         if chkTrigModeHw.Checked then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode := 1
         else
             l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode := 0;
         if chkTrigSourceSync.Checked then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source := 1
         else
             l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source := 0;
         if chkTrigTypeLevel.Checked then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType := 1
         else
             l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType := 0;
         l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection := StrToInt(edtSaturationLevel.Text);
         if chkEnableDarkCorrection.Checked then
            l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable := 1
         else
             l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable := 0;
         l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage := StrToInt(edtDarkHist.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix := StrToInt(edtSmoothPix.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel := StrToInt(edtSmoothModel.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl := StrToInt(edtFlashesPerScan.Text);
         l_NanoSec := StrToFloat(edtLaserDelay.Text);
         l_FPGAClkCycles := round(0.5+6.0*l_NanoSec/125.0);
         l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay := l_FPGAClkCycles;
         l_NanoSec := StrToFloat(edtLaserWidth.Text);
         l_FPGAClkCycles := round(0.5+6.0*l_NanoSec/125.0);
         l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth := l_FPGAClkCycles;
         l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength := StrToFloat(edtLaserWavelength.Text);
         l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam := 0; //StrToInt(edtRamSpectra.Text);
                                                                        //prepared for future versions
         l_pDeviceData.m_StandAlone.m_Nmsr :=  StrToInt(edtNrOfMeas.Text);

         //Get Irradiance parameters
         l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel := StrToInt(edtIrradSmoothModel.Text);
         l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix := StrToInt(edtIrradSmoothPixels.Text);
         l_pDeviceData.m_Irradiance.m_IntensityCalib.m_CalInttime := StrToFloat(edtIrradInttime.Text);
         i:=0;
         while ((i < MAX_NR_PIXELS) and (i<mmIrradConversion.Lines.Count)) do
         begin
             l_pDeviceData.m_Irradiance.m_IntensityCalib.m_aCalibConvers[i] := StrToFloat(mmIrradConversion.Lines.Strings[i]);
             i:=i+1;
         end;
         l_pDeviceData.m_Irradiance.m_CalibrationType := StrToInt(edtIrradCalibrationType.Text);
         l_pDeviceData.m_Irradiance.m_FiberDiameter := StrToInt(edtIrradFiberDiameter.Text);

         //Get Reflectance parameters
         l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothModel := StrToInt(edtReflectanceSmoothModel.Text);
         l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothPix := StrToInt(edtReflectanceSmoothPixels.Text);
         l_pDeviceData.m_Reflectance.m_CalInttime := StrToFloat(edtReflectanceInttime.Text);
         i:=0;
         while ((i < MAX_NR_PIXELS) and (i<mmReflectanceConversion.Lines.Count)) do
         begin
             l_pDeviceData.m_Reflectance.m_aCalibConvers[i] := StrToFloat(mmReflectanceConversion.Lines.Strings[i]);
             i:=i+1;
         end;

         //Get Correction parameters
         i:=0;
         while ((i < MAX_NR_PIXELS) and (i<mmCorrection.Lines.Count)) do
         begin
              l_pDeviceData.m_SpectrumCorrect.m_aSpectrumCorrect[i] := StrToFloat(mmCorrection.Lines.Strings[i]);
              i:=i+1;
         end;

         //Get Thermistor parameters
         l_pDeviceData.m_aTemperature[0].m_aFit[0] := StrToFloat(edtNTC1X0.Text);
         l_pDeviceData.m_aTemperature[0].m_aFit[1] := StrToFloat(edtNTC1X1.Text);
         l_pDeviceData.m_aTemperature[0].m_aFit[2] := StrToFloat(edtNTC1X2.Text);
         l_pDeviceData.m_aTemperature[0].m_aFit[3] := StrToFloat(edtNTC1X3.Text);
         l_pDeviceData.m_aTemperature[0].m_aFit[4] := StrToFloat(edtNTC1X4.Text);
         l_pDeviceData.m_aTemperature[1].m_aFit[0] := StrToFloat(edtNTC2X0.Text);
         l_pDeviceData.m_aTemperature[1].m_aFit[1] := StrToFloat(edtNTC2X1.Text);
         l_pDeviceData.m_aTemperature[1].m_aFit[2] := StrToFloat(edtNTC2X2.Text);
         l_pDeviceData.m_aTemperature[1].m_aFit[3] := StrToFloat(edtNTC2X3.Text);
         l_pDeviceData.m_aTemperature[1].m_aFit[4] := StrToFloat(edtNTC2X4.Text);
         l_pDeviceData.m_aTemperature[2].m_aFit[0] := StrToFloat(edtThermistorX0.Text);
         l_pDeviceData.m_aTemperature[2].m_aFit[1] := StrToFloat(edtThermistorX1.Text);
         l_pDeviceData.m_aTemperature[2].m_aFit[2] := StrToFloat(edtThermistorX2.Text);
         l_pDeviceData.m_aTemperature[2].m_aFit[3] := StrToFloat(edtThermistorX3.Text);
         l_pDeviceData.m_aTemperature[2].m_aFit[4] := StrToFloat(edtThermistorX4.Text);

         //Get Tec Control parameters
         l_pDeviceData.m_TecControl.m_Enable   := chkEnableTec.Checked ;
         l_pDeviceData.m_TecControl.m_Setpoint := StrToFloat(edtSetPoint.Text) ;
         l_pDeviceData.m_TecControl.m_aFit[0]  := StrToFloat(edtTecX0.Text) ;
         l_pDeviceData.m_TecControl.m_aFit[1]  := StrToFloat(edtTecX1.Text) ;


         //Write parameters
         l_Res := AVS_SetParameter(m_DeviceHandle, l_pDeviceData);
         if (ERR_SUCCESS <> l_Res) then
            ShowMessage('Error in AVS_SetParameter, code '+ IntToStr(l_Res));

    end;
    FreeMem(l_pDeviceData);


end;

procedure TfrmEEprom.chkTrigModeHwClick(Sender: TObject);
begin
     chkTrigModeSw.Checked := not chkTrigModeHw.Checked;
end;

procedure TfrmEEprom.chkTrigModeSwClick(Sender: TObject);
begin
     chkTrigModeHw.Checked := not chkTrigModeSw.Checked;
end;

procedure TfrmEEprom.chkTrigSourceExtHwClick(Sender: TObject);
begin
     chkTrigSourceSync.Checked := not chkTrigSourceExtHw.Checked;
end;

procedure TfrmEEprom.chkTrigSourceSyncClick(Sender: TObject);
begin
     chkTrigSourceExtHw.Checked := not chkTrigSourceSync.Checked;
end;

procedure TfrmEEprom.chkTrigTypeEdgeClick(Sender: TObject);
begin
     chkTrigTypeLevel.Checked := not chkTrigTypeEdge.Checked;
end;

procedure TfrmEEprom.chkTrigTypeLevelClick(Sender: TObject);
begin
     chkTrigTypeEdge.Checked := not chkTrigTypeLevel.Checked;
end;

end.

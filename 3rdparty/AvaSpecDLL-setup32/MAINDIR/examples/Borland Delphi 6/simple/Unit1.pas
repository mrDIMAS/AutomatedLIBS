unit Unit1;

// Minimal Delphi application, for a single spectrometer channel
//
// It is possible to make this application unresponsive, if you enter a
// value of -1 for Number of Measurements (meaning continuous) and combine
// this with a Number of Averages of 1 and the smallest Integration Time allowed
// (e.g. 0.01 ms for the AvaSpec 3648, 1.1 ms for the AvaSpec 2048 etc.)
// This combination will not allow you to press another button after starting,
// meaning you can only stop the program with the Task Manager, or the Delphi
// IDE. To correct this situation, you will need some advanced programming
// techniques that are not present in this demo, e.g. a separate thread that
// receives the spectrometer data, or screen updates that are triggered with
// a timer, not by incoming data.

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, avaspec, ExtCtrls, TeeProcs, TeEngine, Chart, Series, StdCtrls,
  Buttons;

type
  TForm1 = class(TForm)
    Chart1: TChart;
    Series1: TFastLineSeries;
    OpenCommButton: TBitBtn;
    CloseCommButton: TBitBtn;
    GroupBox1: TGroupBox;
    EdtIntTime: TEdit;
    EdtAvg: TEdit;
    EdtNrms: TEdit;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    StartMeasBtn: TButton;
    StopMeasBtn: TButton;
    procedure FormCreate(Sender: TObject);
    procedure OpenCommButtonClick(Sender: TObject);
    procedure CloseCommButtonClick(Sender: TObject);
    procedure StartMeasBtnClick(Sender: TObject);
    procedure StopMeasBtnClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  protected
    procedure AVSDataIsHere(var Avs_Message:TMessage);message WM_MEAS_READY;
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

var m_DeviceHandle:AvsHandle;
    m_NrPixels:Word;
    m_pLambda:array[0..4095] of double;

procedure TForm1.AVSDataIsHere(var Avs_Message:TMessage);
var i:smallint;
    l_Time:DWORD;
    l_pSpectrum:array [0..MAX_NR_PIXELS-1] of double;
begin
  if (ERR_SUCCESS=Avs_Message.WParam) then
  begin
    if (ERR_SUCCESS=AVS_GetScopeData(m_DeviceHandle,l_Time,@l_pSpectrum[0])) then
    begin
      Series1.Clear;
      for i := 0 to m_Nrpixels-1 do
        Series1.AddXY(m_pLambda[i],l_pSpectrum[i],'',TColor(clBlack));
      Repaint();  // time consuming but gives feedback to user
    end;
  end;  
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  Chart1.Title.Visible:=false;
  Chart1.View3D:=false;
  Chart1.Legend.Visible:=false;
  Chart1.BottomAxis.Title.Caption:='Wavelength [nm]';
  Chart1.LeftAxis.Title.Caption:='Counts';
  EdtIntTime.Text:=format('%5.1f',[5.0]);
  EdtAvg.Text:=format('%2.0d',[1]);
  EdtNrms.Text:=format('%2.0d',[1]);
  StartMeasBtn.Enabled:=false;
  StopMeasBtn.Enabled:=false;
end;

procedure TForm1.OpenCommButtonClick(Sender: TObject);
var l_Port:longint;
    l_hDevice:AvsHandle;
    l_Active:array of AvsIdentityType;
    l_reqsize:cardinal;
begin
  l_Port:=AVS_Init(0);
  if l_Port>0 then
    ShowMessage(IntToStr(l_Port)+ ' spectrometer(s) detected')
  else
    ShowMessage('AVS_Init failed');
  SetLength(l_Active,l_Port);
  if AVS_GetList(l_Port*sizeof(AVSIdentityType),l_reqsize,l_Active[0]) <1 then
    ShowMessage('AVS_GetList failed');
  AVS_Register(0);
  l_hDevice:=AVS_Activate(l_Active[0]);
  m_DeviceHandle:=l_hDevice;
  CloseCommButton.Enabled:=true;
  StartMeasBtn.Enabled:=true;
  StopMeasBtn.Enabled:=true;
  AVS_GetNumPixels(m_DeviceHandle,m_NrPixels);
  if (AVS_GetLambda(m_DeviceHandle,@m_pLambda[0])<>ERR_SUCCESS) then
    ShowMessage('AVS_GetLambda failed');
end;

procedure TForm1.CloseCommButtonClick(Sender: TObject);
var l_Res:boolean;
begin
  l_Res:=AVS_Deactivate(m_DeviceHandle);
  AVS_Done;
end;

procedure TForm1.StartMeasBtnClick(Sender: TObject);
var l_PrepareMeasData:MeasConfigType;
    l_Res:longint;
    l_NrOfScans:smallint;
begin
  l_PrepareMeasData.m_StartPixel:=0;
  l_PrepareMeasData.m_StopPixel:=m_NrPixels-1;
  l_PrepareMeasData.m_IntegrationTime:=StrToFloat(edtInttime.Text);
  l_PrepareMeasData.m_IntegrationDelay:=0;
  l_PrepareMeasData.m_NrAverages:=StrToInt(edtAvg.Text);
  l_PrepareMeasData.m_CorDynDark.m_Enable:=0;
  l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage:=0;
  l_PrepareMeasData.m_Smoothing.m_SmoothPix:=0;
  l_PrepareMeasData.m_Smoothing.m_SmoothModel:=0;
  l_PrepareMeasData.m_SaturationDetection:=0;
  l_PrepareMeasData.m_Trigger.m_Mode:=0;
  l_PrepareMeasData.m_Trigger.m_Source:=0;
  l_PrepareMeasData.m_Trigger.m_SourceType:=0;
  l_PrepareMeasData.m_Control.m_StrobeControl:=0;
  l_PrepareMeasData.m_Control.m_LaserDelay:=0;
  l_PrepareMeasData.m_Control.m_LaserWidth:=0;
  l_PrepareMeasData.m_Control.m_LaserWaveLength:=0;
  l_PrepareMeasData.m_Control.m_StoreToRam:=0;
  l_Res:=AVS_PrepareMeasure(m_DeviceHandle,l_PrepareMeasData);
  if (ERR_SUCCESS<>l_Res) then
    ShowMessage('Error in AVS_PrepareMeasData, code '+ IntToStr(l_Res));
  l_NrOfScans:=StrToInt(edtNrms.Text);
  // Start Measurement
  l_Res:=AVS_Measure(m_DeviceHandle,Form1.Handle,l_NrOfScans);
  if l_NrOfScans=-1 // continuous
  then StartmeasBtn.Enabled:=false;
  if (ERR_SUCCESS<>l_Res) then
    ShowMessage('Error in AVS_Measure, code '+ IntToStr(l_Res));
end;

procedure TForm1.StopMeasBtnClick(Sender: TObject);
var l_Res:longint;
begin
  l_Res:=AVS_StopMeasure(m_DeviceHandle);
  if (ERR_SUCCESS<>l_Res) then
    ShowMessage('Error in AVS_StopMeasure, code '+IntToStr(l_Res));
  StartmeasBtn.Enabled:=true;
end;

end.

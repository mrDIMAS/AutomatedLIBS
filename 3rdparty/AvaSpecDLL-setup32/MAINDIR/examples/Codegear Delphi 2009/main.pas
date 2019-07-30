unit main;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, avaspec, Menus, StdCtrls, TeEngine, Series, ExtCtrls, TeeProcs, Chart,
  Grids, ComCtrls,u_Usb;

type
  TForm1 = class(TForm)
    btnCommunication: TButton;
    StatusBar1: TStatusBar;
    sgShowList: TStringGrid;
    btnUpdateList: TButton;
    Chart1: TChart;
    Series1: TLineSeries;
    gbPrepareMeasSettings: TGroupBox;
    Label3: TLabel;
    Label5: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    Label16: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    edtStartPixel: TEdit;
    edtStopPixel: TEdit;
    edtIntegrationTime: TEdit;
    edtIntegrationDelay: TEdit;
    edtNrOfAverages: TEdit;
    gbTrigger: TGroupBox;
    Label20: TLabel;
    Label31: TLabel;
    Label32: TLabel;
    chkTrigTypeLevel: TCheckBox;
    chkTrigTypeEdge: TCheckBox;
    chkTrigSourceSync: TCheckBox;
    chkTrigSourceExtHw: TCheckBox;
    chkTrigModeSw: TCheckBox;
    chkTrigModeHw: TCheckBox;
    gbDarkCorrection: TGroupBox;
    Label1: TLabel;
    chkEnableDarkCorrection: TCheckBox;
    edtDarkHist: TEdit;
    gbSmoothing: TGroupBox;
    Label2: TLabel;
    Label4: TLabel;
    edtSmoothModel: TEdit;
    edtSmoothPix: TEdit;
    edtSaturationLevel: TEdit;
    gbControl: TGroupBox;
    Label33: TLabel;
    Label34: TLabel;
    Label35: TLabel;
    Label36: TLabel;
    Label37: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    edtFlashesPerScan: TEdit;
    edtLaserDelay: TEdit;
    edtLaserWidth: TEdit;
    edtLaserWavelength: TEdit;
    edtRamSpectra: TEdit;
    btnReadMeasFromEEProm: TButton;
    btnWriteMeasToEEProm: TButton;
    gbOutput: TGroupBox;
    Label19: TLabel;
    Label22: TLabel;
    Label21: TLabel;
    Label23: TLabel;
    Label24: TLabel;
    Label25: TLabel;
    Label26: TLabel;
    Label27: TLabel;
    edtTotalTime: TEdit;
    edtPerformedScans: TEdit;
    edtFailures: TEdit;
    edtAvgTimePerScan: TEdit;
    edtLastScanTime: TEdit;
    gbMeasure: TGroupBox;
    Label17: TLabel;
    Label18: TLabel;
    btnStartMeasurement: TButton;
    edtNrOfScans: TEdit;
    btnStopMeasurement: TButton;
    btnActivate: TButton;
    btnDeactivate: TButton;
    gbInfo: TGroupBox;
    Label12: TLabel;
    Label13: TLabel;
    edtDetectorname: TEdit;
    edtNrOfPixels: TEdit;
    chkDisableGraph: TCheckBox;
    btnDigIO: TButton;
    btnAnIO: TButton;
    btnShowEEProm: TButton;
    MainMenu1: TMainMenu;
    edtFPGAver: TEdit;
    edtFWver: TEdit;
    edtDLLver: TEdit;
    Label28: TLabel;
    Label29: TLabel;
    Label30: TLabel;
    chkPreScan: TCheckBox;
    rdgSetSensitivityMode: TRadioGroup;
    ConnectRGrp: TRadioGroup;
    procedure btnCommunicationClick(Sender: TObject);
    procedure btnUpdateListClick(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure sgShowListClick(Sender: TObject);
    procedure OnDeviceChange(var message: Tmessage);message WM_DEVICECHANGE;
    procedure btnActivateClick(Sender: TObject);
    procedure ConnectGui;
    procedure DisConnectGui;
    procedure FormCreate(Sender: TObject);
    procedure btnDeactivateClick(Sender: TObject);
    procedure chkTrigModeHwClick(Sender: TObject);
    procedure chkTrigModeSwClick(Sender: TObject);
    procedure chkTrigSourceExtHwClick(Sender: TObject);
    procedure chkTrigSourceSyncClick(Sender: TObject);
    procedure chkTrigTypeEdgeClick(Sender: TObject);
    procedure chkTrigTypeLevelClick(Sender: TObject);
    procedure btnStartMeasurementClick(Sender: TObject);
    procedure btnStopMeasurementClick(Sender: TObject);
    procedure chkDisableGraphClick(Sender: TObject);
    procedure btnDigIOClick(Sender: TObject);
    procedure btnAnIOClick(Sender: TObject);
    procedure btnShowEEPromClick(Sender: TObject);
    procedure btnReadMeasFromEEPromClick(Sender: TObject);
    procedure btnWriteMeasToEEPromClick(Sender: TObject);
    procedure chkPreScanClick(Sender: TObject);
    procedure rdgSetSensitivityModeClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  protected
    procedure AVSDataIsHere(var Message:TMessage);message WM_MEAS_READY;
  end;

var
  Form1: TForm1;
  m_Identity: AvsIdentityType;
  m_DeviceHandle: AvsHandle;
  m_NrPixels:Word;
  m_pLambda:array of double;
  m_StartPixels:word;
  m_StopPixels:word;
  m_StartTicks: DWord;
  m_Measurements: DWord;
  m_Failures:  DWord;
  m_PreviousTimeStamp: DWord;
  m_GraphicsDisabled:boolean;
  versionstring:AnsiString='xxx.xxx.xxx.xxx'#0;
  DeviceData: DeviceConfigType;

implementation

{$R *.dfm}

uses digio,anio,eeprom;

procedure TForm1.AVSDataIsHere(var message:TMessage);
var i:smallint;
    j:word;
    l_Ticks:DWORD;
    l_Time:DWORD;
    l_Dif:DWORD;
    l_pSpectrum: array of double;
    l_pSaturated: array of byte;
    l_AvgScantimeRAM:double;
begin
  SetLength(l_pSpectrum,m_NrPixels);
  SetLength(l_pSaturated,m_NrPixels);
  if (message.WParam = ERR_SUCCESS ) then
  begin
    StatusBar1.Panels.Items[1].Text := 'Meas.Status: success';
    m_Measurements:=m_Measurements+1;
    if (ERR_SUCCESS = AVS_GetScopeData(m_DeviceHandle, l_Time, @l_pSpectrum[0])) then
    begin
      l_Dif := l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
      m_PreviousTimeStamp := l_Time;
      if (l_Dif <> 0) then
        edtLastScanTime.Text := FloatToStrF(l_Dif/100.0,ffFixed,7,2); //millisec
      AVS_GetSaturatedPixels(m_DeviceHandle, @l_pSaturated[0]);
      if not m_GraphicsDisabled then
      begin
        Series1.Clear;
        for i := 0 to (m_StopPixels- m_StartPixels) do
        begin
          if ((i>0) and (l_pSaturated[i]>0) and (l_pSaturated[i-1]>0)) then
            Series1.AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],'',TColor(clRed))
          else
            Series1.AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],'',TColor(clBlack));
        end;
        Repaint();  // time consuming but gives feedback to user
      end;
    end
    else
    begin
      Series1.Clear;
      StatusBar1.Panels.Items[1].Text := 'Meas.Status: no data avail.';
    end;
    l_Ticks := GetTickCount;
    edtTotalTime.Text :=  IntToStr(round((l_Ticks - m_StartTicks)/ 1000));
    edtPerformedScans.Text := IntToStr(m_Measurements);
    edtAvgTimePerScan.Text := FloatToStrF(1.0*(l_Ticks - m_StartTicks)/m_Measurements,ffFixed,7,2);
    if (StrToInt(edtNrOfScans.Text)>0) then //finite nr of measurements
      btnStartMeasurement.Enabled := (DWORD(StrToInt(edtNrOfScans.Text))= m_Measurements); //enable startbutton when ready

  end
  else if (message.WParam > 0 ) then // response to StoreToRAM,
                                     // using StoreToRAM requires firmware version 0.20.0.0 or later
                                     // message.WParam hold the number of scans stored in RAM
                                     // import into application by call to AVS_GetScopeData for each scan
  begin
    StatusBar1.Panels.Items[1].Text := 'Meas.Status: Reading RAM';
    l_AvgScantimeRAM:=0.0;
    for j:=1 to message.WParam do
    begin
      if (ERR_SUCCESS = AVS_GetScopeData(m_DeviceHandle, l_Time, @l_pSpectrum[0])) then
      begin
        l_Dif := l_Time - m_PreviousTimeStamp;  //l_Time in 10 us ticks
        m_PreviousTimeStamp := l_Time;
        if (l_Dif <> 0) then
          edtLastScanTime.Text := FloatToStrF(l_Dif/100.0,ffFixed,7,2); //millisec
        //calculate average scan duration from TimeStamp
        if j>1 then
        begin
          l_AvgScantimeRAM:=(l_AvgScantimeRAM*(j-2)+l_Dif/100.0)/(j-1);
          edtAvgTimePerScan.Text := FloatToStrF(l_AvgScantimeRAM,ffFixed,7,3);
        end;
        AVS_GetSaturatedPixels(m_DeviceHandle, @l_pSaturated[0]);
        if not m_GraphicsDisabled then
        begin
          Series1.Clear;
          for i := 0 to (m_StopPixels- m_StartPixels) do
          begin
            if ((i>0) and (l_pSaturated[i]>0) and (l_pSaturated[i-1]>0)) then
              Series1.AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],'',TColor(clRed))
            else
              Series1.AddXY(m_pLambda[i+m_StartPixels], l_pSpectrum[i],'',TColor(clBlack));
          end;
          Repaint();  // time consuming but gives feedback to user
        end;
      end
      else
      begin
        Series1.Clear;
        StatusBar1.Panels.Items[1].Text := 'Meas.Status: no data avail.';
      end;
      l_Ticks := GetTickCount;
      edtTotalTime.Text :=  IntToStr(round((l_Ticks - m_StartTicks)/ 1000));
      edtPerformedScans.Text := IntToStr(j);
    end;
    StatusBar1.Panels.Items[1].Text := 'Finished Reading RAM';
    btnStartMeasurement.Enabled:=true;
  end  // reading scans from RAM
  else //message.WParam < 0 (errorcode)
  begin
    StatusBar1.Panels.Items[1].Text :='Meas.Status: failed. Error '+ IntToStr(message.WParam);
    m_Failures:=m_Failures+1;
  end;
  edtFailures.Text := IntToStr(m_Failures);
  l_pSpectrum:= nil;
  l_pSaturated:=nil;
end;

procedure TForm1.btnCommunicationClick(Sender: TObject);
var l_Ret,l_Port:longint;
begin
  Screen.Cursor:=crHourGlass;
  StatusBar1.Panels.Items[0].Text:='Open Communication Busy';
  l_Port:=0;
  AVS_Done();
  case ConnectRGrp.ItemIndex of
    0:l_Port:=0;
    1:l_Port:=-1;
  end; { case }
  l_Ret:=AVS_Init(l_Port);
  if (l_Ret>0) then
  begin
    case ConnectRGrp.ItemIndex of
      0:StatusBar1.Panels.Items[0].Text:='Connected: USB';
      1:StatusBar1.Panels.Items[0].Text:='Connected: Ethernet/USB';
    end; { case }
    AVS_Register(Handle);
    btnUpdateList.Enabled:=true;
    sgShowList.Cells[0,0]:='SerialNr';
    sgShowList.Cells[1,0]:='Status';
    btnUpdateListClick(self);
  end
  else
  begin
    StatusBar1.Panels.Items[0].Text:='Open communication failed';
    AVS_Done();
  end;
  Screen.Cursor:=crDefault;
end;

procedure TForm1.btnUpdateListClick(Sender: TObject);
var l_Size: DWord;
    l_RequiredSize: DWord;
    l_NrDevices:Longint;
    l_pId: array of AvsIdentityType;
    i,j:smallint;
begin
  Screen.Cursor := crHourGlass;
  for i:=0 to sgShowList.ColCount-1 do
    for j:=1 to sgShowList.RowCount-1 do
      sgShowList.Cells[i,j]:='';
  l_RequiredSize := 0;
  l_NrDevices := AVS_GetNrOfDevices;
  l_RequiredSize := l_NrDevices * sizeof(AvsIdentityType);
  if (l_RequiredSize > 0)  then
  begin
    SetLength(l_pId,l_RequiredSize);
    l_Size := l_RequiredSize;
    l_NrDevices := AVS_GetList(l_Size, l_RequiredSize,l_pId[0]);
    for i := 0 to l_NrDevices-1 do
    begin
      sgShowList.Cells[0,i+1]:=WideString(l_pId[i].SerialNumber);
      case l_pId[i].Status of
        UNKNOWN                  : sgShowList.Cells[1,i+1]:='UNKNOWN';
        USB_AVAILABLE            : sgShowList.Cells[1,i+1]:='USB_AVAILABLE';
        USB_IN_USE_BY_APPLICATION: sgShowList.Cells[1,i+1]:='USB_IN_USE_BY_APPLICATION';
        USB_IN_USE_BY_OTHER      : sgShowList.Cells[1,i+1]:='USB_IN_USE_BY_OTHER';
        ETH_AVAILABLE            : sgShowList.Cells[1,i+1]:='ETH_AVAILABLE';
        ETH_IN_USE_BY_APPLICATION: sgShowList.Cells[1,i+1]:='ETH_IN_USE_BY_APPLICATION';
        ETH_IN_USE_BY_OTHER      : sgShowList.Cells[1,i+1]:='ETH_IN_USE_BY_OTHER';
        ETH_ALREADY_IN_USE_USB   : sgShowList.Cells[1,i+1]:='ETH_ALREADY_IN_USE_USB';
        else
          sgShowList.Cells[1,i+1]:= '??????';
      end; //case
    end;
    l_pId:=nil;
  end;
  Screen.Cursor := crDefault;
  sgShowListClick(Self);
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
var l_Res:Longint;
begin
  if (m_DeviceHandle<>INVALID_AVS_HANDLE_VALUE)  then
  begin
    l_Res := AVS_StopMeasure(m_DeviceHandle);
    if (ERR_SUCCESS <> l_Res) then
      ShowMessage('Error in AVS_StopMeasure, code = '+IntToStr(l_Res));
    AVS_Deactivate(m_DeviceHandle);
  end;
  DisConnectGui;
  AVS_Done;
end;

procedure TForm1.sgShowListClick(Sender: TObject);
var teststring:AnsiString;
begin
  teststring:=sgShowList.Cells[1,sgShowList.Selection.Top];
  btnActivate.Enabled:=(teststring='USB_AVAILABLE') or (teststring='ETH_AVAILABLE');
  btnDeactivate.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnDigIO.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnAnIO.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnShowEEProm.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');;
  btnReadMeasFromEEProm.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnWriteMeasToEEProm.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnStartMeasurement.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
  btnStopMeasurement.Enabled:=(teststring='USB_IN_USE_BY_APPLICATION') or (teststring='ETH_IN_USE_BY_APPLICATION');
end;

procedure TForm1.OnDeviceChange(var message: Tmessage);
var l_pData: PDevBroadcastHdr;
begin
  l_pData := PDevBroadcastHdr( message.LParam);
  if (l_pData<>nil) then
  begin
    if (l_pData.dbch_devicetype = DBT_DEVTYP_DEVICEINTERFACE) then
    begin
      case (message.WParam) of
        DBT_DEVICEARRIVAL: begin  // system detected a new device
                             StatusBar1.Panels.Items[1].Text := 'Device arrival';
                             btnUpdateListClick(Self);
                           end;
        DBT_DEVICEREMOVECOMPLETE: begin // device is gone
                                    StatusBar1.Panels.Items[1].Text := 'Device removed';
                                    btnUpdateListClick(Self);
                                  end;
      end; //case
    end;
  end;
end;

procedure TForm1.rdgSetSensitivityModeClick(Sender: TObject);
var l_Res:Longint;
begin
  l_Res := 0;
  if rdgSetSensitivityMode.Items[rdgSetSensitivityMode.ItemIndex] = 'Low Noise' then
    l_Res := AVS_SetSensitivityMode(m_DeviceHandle,0)
  else if rdgSetSensitivityMode.Items[rdgSetSensitivityMode.ItemIndex] = 'High Sensitivity' then
    l_Res := AVS_SetSensitivityMode(m_DeviceHandle,1);
  if l_Res<>ERR_SUCCESS then
    ShowMessage('Error in AVS_SetSensitivityMode, code '+ IntToStr(l_Res));
end;

procedure TForm1.btnActivateClick(Sender: TObject);
var l_Active: AvsIdentityType;
    l_hDevice: AvsHandle;
    inbetween: AnsiString;
begin
  inbetween:=AnsiString(sgShowList.Cells[0,sgShowList.Selection.Top]);
  StrPCopy(l_Active.SerialNumber,inbetween);
  l_hDevice := AVS_Activate(l_Active);
  if (INVALID_AVS_HANDLE_VALUE = l_hDevice) then
    ShowMessage('Error opening device '+l_Active.SerialNumber)
  else
  begin
    m_Identity:=l_Active;
    m_DeviceHandle := l_hDevice;
    btnUpdateListClick(Self);
    ConnectGui;
    btnReadMeasFromEEPromClick(Self);
    // test error message
    AVS_SetPwmOut(m_DeviceHandle,0,500,100);
  end;
end;

procedure TForm1.ConnectGui;
var l_Res: longint;
    l_RequiredSize: DWord;
    l_FPGAver,l_FWver,l_DLLver:array[0..15] of AnsiChar;
begin
  l_Res:=AVS_GetVersionInfo(m_DeviceHandle, l_FPGAver,l_FWver,l_DLLver);
  if (l_Res=ERR_SUCCESS) then
  begin
    edtFPGAver.Text := WideString(l_FPGAver);
    edtFWver.Text := WideString(l_FWver);
    edtDLLver.Text := WideString(l_DLLver);
  end;
  if (ERR_SUCCESS = AVS_GetNumPixels(m_DeviceHandle, m_NrPixels)) then
    edtNrOfPixels.Text := IntToStr(m_NrPixels);
  l_RequiredSize:=sizeof(DeviceData);
  l_Res := AVS_GetParameter(m_DeviceHandle,l_RequiredSize,l_RequiredSize,@DeviceData);

  chkPreScan.Visible:=false;
  if (l_Res = ERR_SUCCESS) then
  begin
    case (DeviceData.m_Detector.m_SensorType) of
      SENS_HAMS8378_256       : edtDetectorname.Text   := 'HAMS8378_256';
      SENS_HAMS8378_1024      : edtDetectorname.Text   := 'HAMS8378_1024';
      SENS_ILX554             : edtDetectorname.Text   := 'ILX554';
      SENS_HAMS9201           : begin
                                  edtDetectorname.Text   := 'HAMS9201';
                                  rdgSetSensitivityMode.Visible := true;
                                  rdgSetSensitivityMode.ItemIndex:=0; //LowNoise default for HAMS9201
                                  AVS_SetSensitivityMode(m_DeviceHandle, 0);
                                end;
      SENS_TCD1304            : begin
                                  edtDetectorname.Text   := 'TCD1304';
                                  chkPreScan.Visible:=true;
                                  chkPreScan.Checked:=true;
                                  AVS_SetPreScanMode(m_DeviceHandle, chkPreScan.Checked);
                                end;
      SENS_TSL1301            : edtDetectorname.Text   := 'TSL1301';
      SENS_TSL1401            : edtDetectorname.Text   := 'TSL1401';
      SENS_HAMS8378_512       : edtDetectorname.Text   := 'HAMS8378_256';
      SENS_HAMS9840           : edtDetectorname.Text   := 'HAMS9840';
      SENS_ILX511             : edtDetectorname.Text   := 'ILX511';
      SENS_HAMS10420_2048X64  : edtDetectorname.Text   := 'HAMS10420_2048x64';
      SENS_HAMS11071_2048X16  : edtDetectorname.Text   := 'HAMS11071_2048x16';
      SENS_HAMS11071_2048X64  : edtDetectorname.Text   := 'HAMS11071_2048x64';
      SENS_HAMS7031_1024X58   : edtDetectorname.Text   := 'HAMS7031_1024x58';
      SENS_HAMS7031_1024X122  : edtDetectorname.Text   := 'HAMS7031_1024x122';
      SENS_HAMS11155          : edtDetectorname.Text   := 'HAMS11155';
      SENS_SU256LSB           : begin
                                  edtDetectorname.Text   := 'SU256LSB';
                                  rdgSetSensitivityMode.Visible := true;
                                  rdgSetSensitivityMode.ItemIndex:=1; //High Sensitive default for SU256LSB
                                  AVS_SetSensitivityMode(m_DeviceHandle, 1);
                                end;
      SENS_SU512LDB           : begin
                                  edtDetectorname.Text   := 'SU512LDB';
                                  rdgSetSensitivityMode.Visible := true;
                                  rdgSetSensitivityMode.ItemIndex:=1; //High Sensitive default for SU512LDB
                                  AVS_SetSensitivityMode(m_DeviceHandle, 1);
                                end;
      SENS_HAMS11638          : edtDetectorname.Text   := 'HAMS11638';
      SENS_HAMS11639          : edtDetectorname.Text   := 'HAMS11639';
      SENS_HAMS12443          : edtDetectorname.Text   := 'HAMS12443';
      SENS_HAMG9208_512       : edtDetectorname.Text   := 'HAMG9208_512';
      else
        edtDetectorname.Text  := '???????';
    end;  { case }
    m_StartPixels := DeviceData.m_StandAlone.m_Meas.m_StartPixel;
    m_StopPixels := DeviceData.m_StandAlone.m_Meas.m_StopPixel;
    SetLength(m_pLambda, m_NrPixels);
    if (ERR_SUCCESS = AVS_GetLambda(m_DeviceHandle, @m_pLambda[0])) then
      Chart1.BottomAxis.SetMinMax(m_pLambda[m_StartPixels],m_pLambda[m_StopPixels]);
  end
  else
    DisconnectGui;
end;

procedure TForm1.DisConnectGui;
begin
  m_pLambda := nil;
  Chart1.BottomAxis.SetMinMax(0,0);
  edtDetectorname.Text := '';
  edtNrOfPixels.Text := '';
  edtFPGAver.Text := '';
  edtFWver.Text := '';
  edtDLLver.Text := '';
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  m_pLambda:=nil;
  m_DeviceHandle:=INVALID_AVS_HANDLE_VALUE;
  ConnectRGrp.ItemIndex:=0;  // USB
end;

procedure TForm1.btnDeactivateClick(Sender: TObject);
begin
  AVS_Deactivate(m_DeviceHandle);  //for now only use one Active Device, in future extend to multiple devices/handles
  btnUpdateListClick(self);
  DisconnectGui;
  m_DeviceHandle := INVALID_AVS_HANDLE_VALUE;
end;


procedure TForm1.chkTrigModeHwClick(Sender: TObject);
begin
  chkTrigModeSw.Checked := not chkTrigModeHw.Checked;
end;

procedure TForm1.chkTrigModeSwClick(Sender: TObject);
begin
  chkTrigModeHw.Checked := not chkTrigModeSw.Checked;
end;

procedure TForm1.chkTrigSourceExtHwClick(Sender: TObject);
begin
  chkTrigSourceSync.Checked := not chkTrigSourceExtHw.Checked;
end;

procedure TForm1.chkTrigSourceSyncClick(Sender: TObject);
begin
  chkTrigSourceExtHw.Checked := not chkTrigSourceSync.Checked;
end;

procedure TForm1.chkTrigTypeEdgeClick(Sender: TObject);
begin
  chkTrigTypeLevel.Checked := not chkTrigTypeEdge.Checked;
end;

procedure TForm1.chkTrigTypeLevelClick(Sender: TObject);
begin
  chkTrigTypeEdge.Checked := not chkTrigTypeLevel.Checked;
end;

procedure TForm1.btnStartMeasurementClick(Sender: TObject);
var l_PrepareMeasData:MeasConfigType;
    l_NanoSec:double;
    l_FPGAClkCycles:DWord;
    l_Res:longint;
    l_NrOfScans:smallint;
begin
  // prevent second StartMeasurementClick before sequence ends.
  btnStartMeasurement.Enabled := false;
  //Prepare Measurement

  l_PrepareMeasData.m_StartPixel := StrToInt(edtStartPixel.Text);
  l_PrepareMeasData.m_StopPixel :=  StrToInt(edtStopPixel.Text);
  l_PrepareMeasData.m_IntegrationTime := StrToFloat(edtIntegrationTime.Text);
  l_NanoSec := StrToFloat(edtIntegrationDelay.Text);
  l_FPGAClkCycles := round(6.0*(l_NanoSec+20.84)/125.0);
  l_PrepareMeasData.m_IntegrationDelay := l_FPGAClkCycles;
  l_PrepareMeasData.m_NrAverages := StrToInt(edtNrOfAverages.Text);
  if chkTrigModeHw.Checked then l_PrepareMeasData.m_Trigger.m_Mode := 1 else l_PrepareMeasData.m_Trigger.m_Mode := 0;
  if chkTrigSourceSync.Checked then l_PrepareMeasData.m_Trigger.m_Source := 1 else l_PrepareMeasData.m_Trigger.m_Source := 0;
  if chkTrigTypeLevel.Checked then l_PrepareMeasData.m_Trigger.m_SourceType := 1 else l_PrepareMeasData.m_Trigger.m_SourceType := 0;
  l_PrepareMeasData.m_SaturationDetection := StrToInt(edtSaturationLevel.Text);
  if chkEnableDarkCorrection.Checked then
    l_PrepareMeasData.m_CorDynDark.m_Enable := 1
  else
    l_PrepareMeasData.m_CorDynDark.m_Enable := 0;
  l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage := StrToInt(edtDarkHist.Text);
  l_PrepareMeasData.m_Smoothing.m_SmoothPix := StrToInt(edtSmoothPix.Text);
  l_PrepareMeasData.m_Smoothing.m_SmoothModel := StrToInt(edtSmoothModel.Text);
  l_PrepareMeasData.m_Control.m_StrobeControl := StrToInt(edtFlashesPerScan.Text);
  l_NanoSec := StrToFloat(edtLaserDelay.Text);
  l_FPGAClkCycles := round(6.0*l_NanoSec/125.0);
  l_PrepareMeasData.m_Control.m_LaserDelay := l_FPGAClkCycles;
  l_NanoSec := StrToFloat(edtLaserWidth.Text);
  l_FPGAClkCycles := round(6.0*l_NanoSec/125.0);
  l_PrepareMeasData.m_Control.m_LaserWidth := l_FPGAClkCycles;
  l_PrepareMeasData.m_Control.m_LaserWaveLength := StrToFloat(edtLaserWavelength.Text);
  l_PrepareMeasData.m_Control.m_StoreToRam := StrToInt(edtRamSpectra.Text);
  l_Res := AVS_PrepareMeasure(m_DeviceHandle, l_PrepareMeasData);
  if (ERR_SUCCESS <> l_Res) then
    ShowMessage('error in AVS_PrepareMeasData, code '+ IntToStr(l_Res));
  m_StartPixels := l_PrepareMeasData.m_StartPixel;
  m_StopPixels := l_PrepareMeasData.m_StopPixel;
  //Get Nr Of Scans
  l_NrOfScans := StrToInt(edtNrOfScans.Text);
  if ((l_PrepareMeasData.m_Control.m_StoreToRam>0) and (l_NrOfScans<>1)) then
  begin
    edtNrOfScans.Text:=IntToStr(1);
    l_NrOfScans:=1;
    ShowMessage( IntToStr(l_PrepareMeasData.m_Control.m_StoreToRam)+ ' scans will be stored to RAM '+ #13 +
                 'The number of measurements (a_Nmsr in AVS_Measure) has been set to 1');
  end;
  //Start Measurement
  m_StartTicks := GetTickCount;
  m_Measurements := 0;
  m_Failures := 0;
  edtTotalTime.Text := '0';
  edtPerformedScans.Text := '0';
  edtFailures.Text := '0';
  l_Res := AVS_Measure(m_DeviceHandle, self.Handle, l_NrOfScans);
  if (ERR_SUCCESS <> l_Res) then
  begin
    if (l_Res=ERR_INVALID_PARAMETER) then
      StatusBar1.Panels.Items[1].Text := 'Meas.Status: invalid parameter'
    else
      StatusBar1.Panels.Items[1].Text := 'Meas.Status: start failed, code: '+IntToStr(l_Res);
  end
  else
    StatusBar1.Panels.Items[1].Text := 'Meas.Status: pending';
end;

procedure TForm1.btnStopMeasurementClick(Sender: TObject);
var l_Res:longint;
begin
  l_Res := AVS_StopMeasure(m_DeviceHandle);
  if (ERR_SUCCESS <> l_Res) then
    ShowMessage('error in AVS_StopMeasure, code '+ IntToStr(l_Res));
  btnStartMeasurement.Enabled := true;
end;

procedure TForm1.chkDisableGraphClick(Sender: TObject);
begin
  m_GraphicsDisabled := (chkDisableGraph.Checked);
end;

procedure TForm1.btnDigIOClick(Sender: TObject);
begin
  frmDigIO.ShowModal;
end;

procedure TForm1.btnAnIOClick(Sender: TObject);
begin
  frmAnIO.ShowModal;
end;

procedure TForm1.btnShowEEPromClick(Sender: TObject);
begin
  frmeeprom.ShowModal;
end;

procedure TForm1.btnReadMeasFromEEPromClick(Sender: TObject);
var l_Res: longint;
    l_RequiredSize: DWord;
    l_NanoSec:double;
    l_FPGAClkCycles:DWord;
begin
  l_RequiredSize:=sizeof(DeviceConfigType);
  l_Res := AVS_GetParameter(m_DeviceHandle, l_RequiredSize, l_RequiredSize, @DeviceData);
  if (l_Res = ERR_SUCCESS) then
  begin
    //show measurement settings
    edtStartPixel.Text := format('%d',[DeviceData.m_StandAlone.m_Meas.m_StartPixel]);
    edtStopPixel.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_StopPixel);
    edtIntegrationTime.Text := FloatToStrF(DeviceData.m_StandAlone.m_Meas.m_IntegrationTime,ffFixed,7,2);
    l_FPGAClkCycles := DeviceData.m_StandAlone.m_Meas.m_IntegrationDelay;
    l_NanoSec := 125.0*(l_FPGAClkCycles-1.0)/6.0;
    edtIntegrationDelay.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
    edtNrOfAverages.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_NrAverages);
    edtSaturationLevel.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_SaturationDetection);
    chkTrigModeHw.Checked :=  (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 1);
    chkTrigModeSw.Checked :=  (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 0);
    chkTrigSourceExtHw.Checked :=  (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0);
    chkTrigSourceSync.Checked :=   (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1);
    chkTrigTypeEdge.Checked := (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 0);
    chkTrigTypeLevel.Checked := (DeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 1);
    chkEnableDarkCorrection.Checked := (DeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1);
    edtDarkHist.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage);
    edtSmoothModel.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel);
    edtSmoothPix.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix);
    edtFlashesPerScan.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl);
    l_FPGAClkCycles := DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay;
    l_NanoSec := 125.0*(l_FPGAClkCycles)/6.0;
    edtLaserDelay.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
    l_FPGAClkCycles := DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth;
    l_NanoSec := 125.0*(l_FPGAClkCycles)/6.0;
    edtLaserWidth.Text := FloatToStrF(l_NanoSec,ffFixed,7,0);
    edtLaserWavelength.Text := FloatToStrF(DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength,ffFixed,7,3);
    edtRamSpectra.Text := IntToStr(DeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam);
    edtNrOfScans.Text := IntToStr(DeviceData.m_StandAlone.m_Nmsr);
  end
  else
    ShowMessage('Error in AVS_GetParameter, code '+ IntToStr(l_Res));
end;

procedure TForm1.btnWriteMeasToEEPromClick(Sender: TObject);
var l_Res: longint;
    l_RequiredSize: DWord;
    l_NanoSec:double;
    l_FPGAClkCycles:DWord;
begin
  l_RequiredSize:=sizeof(DeviceData);
  l_Res := AVS_GetParameter(m_DeviceHandle, l_RequiredSize, l_RequiredSize, @DeviceData);
  if (l_Res = ERR_SUCCESS) then
  begin
    //get measurement settings
    DeviceData.m_StandAlone.m_Meas.m_StartPixel := StrToInt(edtStartPixel.Text);
    DeviceData.m_StandAlone.m_Meas.m_StopPixel :=  StrToInt(edtStopPixel.Text);
    DeviceData.m_StandAlone.m_Meas.m_IntegrationTime := StrToFloat(edtIntegrationTime.Text);
    l_NanoSec := StrToFloat(edtIntegrationDelay.Text);
    l_FPGAClkCycles := round(6.0*(l_NanoSec+20.84)/125.0);
    DeviceData.m_StandAlone.m_Meas.m_IntegrationDelay := l_FPGAClkCycles;
    DeviceData.m_StandAlone.m_Meas.m_NrAverages := StrToInt(edtNrOfAverages.Text);
    if chkTrigModeHw.Checked then
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode := 1
    else
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode := 0;
    if chkTrigSourceSync.Checked then
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source := 1
    else
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source := 0;
    if chkTrigTypeLevel.Checked then
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType := 1
    else
      DeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType := 0;
    DeviceData.m_StandAlone.m_Meas.m_SaturationDetection := StrToInt(edtSaturationLevel.Text);
    if chkEnableDarkCorrection.Checked then
      DeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable := 1
    else
      DeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable := 0;
    DeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage := StrToInt(edtDarkHist.Text);
    DeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix := StrToInt(edtSmoothPix.Text);
    DeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel := StrToInt(edtSmoothModel.Text);
    DeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl := StrToInt(edtFlashesPerScan.Text);
    l_NanoSec := StrToFloat(edtLaserDelay.Text);
    l_FPGAClkCycles := round(6.0*l_NanoSec/125.0);
    DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay := l_FPGAClkCycles;
    l_NanoSec := StrToFloat(edtLaserWidth.Text);
    l_FPGAClkCycles := round(6.0*l_NanoSec/125.0);
    DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth := l_FPGAClkCycles;
    DeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength := StrToFloat(edtLaserWavelength.Text);
    DeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam := StrToInt(edtRamSpectra.Text);
    DeviceData.m_StandAlone.m_Nmsr :=  StrToInt(edtNrOfScans.Text);
    //Write parameters
    l_Res := AVS_SetParameter(m_DeviceHandle, @DeviceData);
    if (ERR_SUCCESS <> l_Res) then
      ShowMessage('Error in AVS_SetParameter, code '+ IntToStr(l_Res));
  end
  else
    ShowMessage('Error in AVS_GetParameter, code '+ IntToStr(l_Res));
end;


procedure TForm1.chkPreScanClick(Sender: TObject);
var l_Res:Longint;
begin
  l_Res := AVS_SetPreScanMode(m_DeviceHandle, chkPreScan.Checked);
  if l_Res<>ERR_SUCCESS then
    ShowMessage('Error in AVS_SetPreScanMode, code '+ IntToStr(l_Res));
end;

end.

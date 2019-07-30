unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Grids, avaspec, U_Usb, ComCtrls, TeEngine, Series,
  ExtCtrls, TeeProcs, Chart;

type
  TForm1 = class(TForm)
    GroupBox1: TGroupBox;
    sgShowList: TStringGrid;
    btnActivate: TButton;
    btnCommunication: TButton;
    StatusBar1: TStatusBar;
    GroupBox2: TGroupBox;
    sgMeasData: TStringGrid;
    GroupBox3: TGroupBox;
    Label18: TLabel;
    Label17: TLabel;
    edtNrOfScans: TEdit;
    btnStartMeasurement: TButton;
    btnStopMeasurement: TButton;
    chkSync: TCheckBox;
    cbMaster: TComboBox;
    Label1: TLabel;
    Chart1: TChart;
    Series1: TLineSeries;
    Series2: TLineSeries;
    Series3: TLineSeries;
    Series4: TLineSeries;
    Series5: TLineSeries;
    gbOutput: TGroupBox;
    chkDisableGraph: TCheckBox;
    sgTimeInfo: TStringGrid;
    Label2: TLabel;
    edtTotalTime: TEdit;
    Label3: TLabel;
    Label4: TLabel;
    edtUpdateRate: TEdit;
    Label5: TLabel;
    Series6: TLineSeries;
    Series7: TLineSeries;
    Series8: TLineSeries;
    Series9: TLineSeries;
    Series10: TLineSeries;
    Series11: TLineSeries;
    Series12: TLineSeries;
    Series13: TLineSeries;
    Series14: TLineSeries;
    Series15: TLineSeries;
    Series16: TLineSeries;
    chkPreScan: TCheckBox;
    ConnectRGrp: TRadioGroup;
    procedure btnCommunicationClick(Sender: TObject);
    procedure UpdateList(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure btnActivateClick(Sender: TObject);
    procedure OnDeviceChange(var message: Tmessage);message WM_DEVICECHANGE;
    procedure GetDeviceData(Sender: TObject);
    procedure chkSyncClick(Sender: TObject);
    procedure btnStartMeasurementClick(Sender: TObject);
    procedure btnStopMeasurementClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure chkPreScanClick(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  protected
    procedure AVSDataIsHere(var Message:TMessage);message WM_MEAS_READY;
    procedure HandleDeviceReset(var Message:TMessage);message WM_DEVICE_RESET;
  end;

  TDevice = record
              avsID: AvsIdentityType;
              avsDeviceHandle: AvsHandle;
              E_Settings:EthernetSettingsType;
              avsparam: DeviceConfigType;
              PrepareMeasParam: MeasConfigType;
              NrMeas: DWord;
              PreviousTimeStamp: DWord;
              m_Failures: DWord;
            end;

  TDeviceArray = array[0..MAX_NR_DEVICES-1] of TDevice;

var
  Form1: TForm1;
  m_Device: TDeviceArray;
  m_NrOfDevices:longint;
  m_StartTicks: DWord;
  m_TotalFailures: DWord;

implementation

{$R *.dfm}

procedure TForm1.HandleDeviceReset(var message:TMessage);
var l_Msg:string;
    a_Reason: byte;
begin
  a_Reason := message.wparam;
  l_Msg := 'Reset indication received: ';
  if (a_Reason and $01) = $01 then
    l_Msg := l_Msg + 'Reason: PLL loss-of-lock ';
  if (a_Reason and $02) = $02 then
    l_Msg := l_Msg + 'Reason: PLL loss-of-clock ';
  if (a_Reason and $04) = $04 then
    l_Msg := l_Msg + 'Reason: external reset ';
  if (a_Reason and $08) = $08 then
    l_Msg := l_Msg + 'Reason: power-on reset ';
  if (a_Reason and $10) = $10 then
    l_Msg := l_Msg + 'Reason: watchdog reset ';
  if (a_Reason and $20) = $20 then
    l_Msg := l_Msg + 'Reason: software reset ';
  if (a_Reason and $40) = $40 then
    l_Msg := l_Msg + 'Reason: low-voltage detect reset ';
  ShowMessage(l_Msg);
end;

procedure TForm1.AVSDataIsHere(var message:TMessage);
var l_found,l_Ready:boolean;
    i,j:byte;
    k,l_StartPix, l_StopPix:word;
    l_Time:DWORD;
    l_Ticks:DWORD;
    l_Dif:DWORD;
    l_pSpectrum,l_pLambda: array of double;
    l_Series:TLineseries;
    l_ToBeDone:smallint;
    l_Res: longint;
begin
  if message.wparam=0 then
  begin
    //message.lparam is the devicehandle for which data has arrived
    i:=0;
    l_found:=false;
    while ((not l_found) and (i<m_NrOfDevices)) do
    begin
      if message.lparam = m_Device[i].avsDeviceHandle then
        l_found:=true
      else
        i:=i+1;
    end;
    if l_found then
    begin
      //process data for device i
      m_Device[i].NrMeas:= m_Device[i].NrMeas+1;
      SetLength(l_pSpectrum,m_Device[i].avsparam.m_Detector.m_NrPixels);
      if (ERR_SUCCESS = AVS_GetScopeData(m_Device[i].avsDeviceHandle, l_Time,@l_pSpectrum[0])) then
      begin
        l_Dif := l_Time - m_Device[i].PreviousTimeStamp;  //l_Time in 10 us ticks
        m_Device[i].PreviousTimeStamp := l_Time;
        //write only to timetable if m_Device[i].NrMeas is a multiple of updaterate
        if (m_Device[i].NrMeas mod StrToInt(edtUpdateRate.Text))=0 then
        begin
          sgTimeInfo.Cells[1,i+1]:=IntToStr(m_Device[i].NrMeas);
          if ((l_Dif <> 0) and (m_Device[i].NrMeas>1)) then
            sgTimeInfo.Cells[3,i+1] := FloatToStrF(l_Dif/100.0,ffFixed,7,2); //millisec
          l_Ticks := GetTickCount;
          edtTotalTime.Text :=  IntToStr(round((l_Ticks - m_StartTicks)/ 1000));
          sgTimeInfo.Cells[2,i+1] := FloatToStrF(1.0*(l_Ticks - m_StartTicks)/m_Device[i].NrMeas,ffFixed,7,2);
        end;
        if not chkDisableGraph.Checked then
        begin
          SetLength(l_pLambda, m_Device[i].avsparam.m_Detector.m_NrPixels);
          AVS_GetLambda(m_Device[i].avsDeviceHandle, @l_pLambda[0]);
          case i of
            0: l_Series:= Series1;
            1: l_Series:= Series2;
            2: l_Series:= Series3;
            3: l_Series:= Series4;
            4: l_Series:= Series5;
            5: l_Series:= Series6;
            6: l_Series:= Series7;
            7: l_Series:= Series8;
            8: l_Series:= Series9;
            9: l_Series:= Series10;
            10: l_Series:= Series11;
            11: l_Series:= Series12;
            12: l_Series:= Series13;
            13: l_Series:= Series14;
            14: l_Series:= Series15;
            15: l_Series:= Series16;
          end;
          l_Series.Clear;
          l_StartPix:= m_Device[i].PrepareMeasParam.m_StartPixel;
          l_StopPix:= m_Device[i].PrepareMeasParam.m_StopPixel;
          for k := 0 to (l_StopPix- l_StartPix) do
            l_Series.AddXY(l_pLambda[k+l_StartPix], l_pSpectrum[k],'');
          Repaint;
          l_pLambda:=nil;
        end;
      end;
      l_pSpectrum:= nil;
      if (StrToInt(edtNrOfScans.Text)>0)  then
      begin
        l_Ready:=true;
        for j:= 0 to m_NrOfDevices-1 do
          if m_Device[i].NrMeas< StrToInt(edtNrOfScans.Text) then
            l_Ready := false;
        btnStartMeasurement.Enabled := l_Ready;
        chkSync.Enabled := l_Ready;
      end;
    end;
  end
  else if message.wparam<0 then
  begin
    m_TotalFailures:=m_TotalFailures+1;
    StatusBar1.Panels.Items[2].Text := 'Failures: '+IntToStr(m_TotalFailures);
  end;
end;

procedure TForm1.btnCommunicationClick(Sender: TObject);
var l_Ret,l_Port:longint;
begin
  Screen.Cursor := crHourGlass;
  StatusBar1.Panels.Items[0].Text := 'Open Communication Busy';
  AVS_Register(Handle);
  l_Port:=0;
  AVS_Done();
  case ConnectRGrp.ItemIndex of
    0:l_Port:=0;
    1:l_Port:=256;
    2:l_Port:=-1;
  end; { case }
  l_Ret:=AVS_Init(l_Port);
  if (l_Ret>0) then
  begin
    case ConnectRGrp.ItemIndex of
      0:StatusBar1.Panels.Items[0].Text:='Connected: USB';
      1:StatusBar1.Panels.Items[0].Text:='Connected: Ethernet';
      2:StatusBar1.Panels.Items[0].Text:='Connected: USB/Ethernet';
    end; { case }
    sgShowList.Cells[0,0]:='SerialNr';
    sgShowList.Cells[1,0]:='Status';
    sgShowList.Cells[2,0]:='IP Address';
    UpdateList(Self);
  end
  else
  begin
    AVS_Done();
    StatusBar1.Panels.Items[0].Text := 'Open Communication Failed';
  end;
  Screen.Cursor := crDefault;
end;

procedure TForm1.UpdateList(Sender: TObject);
var l_Size: DWord;
    l_RequiredSize: DWord;
    l_pId: array of AvsIdentityType;
    i,j:smallint;
begin
  Screen.Cursor := crHourGlass;
  for i:=0 to sgShowList.ColCount-1 do
    for j:=1 to sgShowList.RowCount-1 do
      sgShowList.Cells[i,j]:='';
  l_RequiredSize := 0;
  m_NrOfDevices := AVS_GetNrOfDevices;
  l_RequiredSize := m_NrOfDevices * sizeof(AvsIdentityType);
  if (l_RequiredSize > 0)  then
  begin
    SetLength(l_pId,l_RequiredSize);
    l_Size := l_RequiredSize;
    m_NrOfDevices := AVS_GetList(l_Size, l_RequiredSize,l_pId[0]);
    for i := 0 to m_NrOfDevices-1 do
    begin
      m_Device[i].avsID.SerialNumber:=l_pId[i].SerialNumber;
      m_Device[i].avsID.UserFriendlyName:= l_pId[i].UserFriendlyName;
      m_Device[i].avsID.Status:=l_pId[i].Status;
      sgShowList.Cells[0,i+1]:=l_pId[i].SerialNumber;
      case l_pId[i].Status of
        UNKNOWN                  : sgShowList.Cells[1,i+1]:='UNKNOWN';
        USB_AVAILABLE            : begin
                                     sgShowList.Cells[1,i+1]:='USB_AVAILABLE';
                                     btnActivate.Enabled:=true;
                                   end;
        USB_IN_USE_BY_APPLICATION: sgShowList.Cells[1,i+1]:='USB_IN_USE_BY_APPLICATION';
        USB_IN_USE_BY_OTHER      : sgShowList.Cells[1,i+1]:='USB_IN_USE_BY_OTHER';
        ETH_AVAILABLE            : begin
                                     sgShowList.Cells[1,i+1]:='ETH_AVAILABLE';
                                     btnActivate.Enabled:=true;
                                   end;
        ETH_IN_USE_BY_APPLICATION: begin
                                     sgShowList.Cells[1,i+1]:='ETH_IN_USE_BY_APPLICATION';
                                     if ConnectRGrp.ItemIndex<>0 then
                                     begin
                                       AVS_GetIpConfig(m_Device[i].avsDeviceHandle,@m_Device[i].E_Settings);
                                       sgShowList.Cells[2,i+1]:=format('%d.%d.%d.%d',[ m_Device[i].E_Settings.m_IpAddr and $FF,
                                                                                      (m_Device[i].E_Settings.m_IpAddr shr 8) and $FF,
                                                                                      (m_Device[i].E_Settings.m_IpAddr shr 16) and $FF,
                                                                                       m_Device[i].E_Settings.m_IpAddr shr 24 ]);
                                     end;
                                   end;
        ETH_IN_USE_BY_OTHER      : sgShowList.Cells[1,i+1]:='ETH_IN_USE_BY_OTHER';
        ETH_ALREADY_IN_USE_USB   : sgShowList.Cells[1,i+1]:='ETH_ALREADY_IN_USE_USB';
      else
        sgShowList.Cells[1,i+1]:= '??????';
      end; //case
    end;
    l_pId:=nil;
  end;
  Screen.Cursor := crDefault;
end;

procedure TForm1.FormClose(Sender: TObject; var Action: TCloseAction);
var i:smallint;
l_Res: longint;
begin
  //if running Stop Measurement
  for i:= 0 to m_NrOfDevices-1 do
  begin
    l_Res := AVS_StopMeasure(m_Device[i].avsDeviceHandle);
    if (ERR_SUCCESS <> l_Res) then
    ShowMessage('error in AVS_StopMeasure, code '+ IntToStr(l_Res));
  end;
  AVS_Done;
end;

procedure TForm1.btnActivateClick(Sender: TObject);
var l_hDevice: AvsHandle;
    i:integer;
begin
  for i:= 0 to m_NrOfDevices-1 do
  begin
    l_hDevice := AVS_Activate(m_Device[i].avsID);
    if (INVALID_AVS_HANDLE_VALUE = l_hDevice) then
      ShowMessage('Error opening device ' + m_Device[i].avsID.SerialNumber)
    else
    begin
      m_Device[i].avsDeviceHandle := l_hDevice;
      //default state is ASync Mode
      AVS_SetSyncMode(m_Device[i].avsDeviceHandle,0);
    end;
  end;
  UpdateList(Self);
  GetDeviceData(Self);
end;

procedure TForm1.OnDeviceChange(var message: Tmessage);
var l_pData: PDevBroadcastHdr;
    i:longint;
begin
  l_pData := PDevBroadcastHdr( message.LParam);
  if (l_pData<>nil) then
  begin
    if (l_pData.dbch_devicetype = DBT_DEVTYP_DEVICEINTERFACE) then
    begin
      case (message.WParam) of
        DBT_DEVICEARRIVAL:        begin   // system detected a new device
                                    StatusBar1.Panels.Items[1].Text := 'Device arrival';
                                    for i:=0 to m_NrOfDevices -1 do
                                    begin
                                      AVS_DeActivate(m_Device[i].avsDeviceHandle);
                                      m_Device[i].avsDeviceHandle:=INVALID_AVS_HANDLE_VALUE;
                                    end;
                                    UpdateList(Self);
                                    btnActivateClick(Self);
                                  end;
        DBT_DEVICEREMOVECOMPLETE: begin  // device is gone
                                    StatusBar1.Panels.Items[1].Text := 'Device removed';
                                    for i:=0 to m_NrOfDevices -1 do
                                    begin
                                      AVS_DeActivate(m_Device[i].avsDeviceHandle);
                                      m_Device[i].avsDeviceHandle:=INVALID_AVS_HANDLE_VALUE;
                                    end;
                                    UpdateList(Self);
                                    btnActivateClick(Self);
                                  end;
      end; //case
    end;
  end;
end;

procedure TForm1.GetDeviceData(Sender: TObject);
var l_Res: longint;
    l_pDeviceData: pDeviceConfigType;
    l_RequiredSize: DWord;
    i,j:longint;
    minwav,maxwav,calcwav:double;
    teststring: AnsiString;
begin
  sgMeasData.Cells[0,0]:='Serialnr';
  sgMeasData.Cells[1,0]:='Det.Type';
  sgMeasData.Cells[2,0]:='TotalPixels';
  sgMeasData.Cells[3,0]:='Startpixel';
  sgMeasData.Cells[4,0]:='StopPixel';
  sgMeasData.Cells[5,0]:='Inttime';
  sgMeasData.Cells[6,0]:='Average';
  sgMeasData.Cells[7,0]:='NrSmoothpix';
  sgTimeInfo.Cells[0,0]:='Serialnr';
  sgTimeInfo.Cells[1,0]:='NrOfScans';
  sgTimeInfo.Cells[2,0]:='Avg.Time [ms]';
  sgTimeInfo.Cells[3,0]:='Last Scan [ms]';
  for i:=0 to m_NrOfDevices-1 do
  begin
    l_pDeviceData:=nil;
    l_Res := AVS_GetParameter(m_Device[i].avsDeviceHandle, 0, l_RequiredSize, l_pDeviceData);
    if ( l_Res = ERR_INVALID_SIZE) then
    begin
      GetMem(l_pDeviceData, l_RequiredSize);
      l_Res := AVS_GetParameter(m_Device[i].avsDeviceHandle, l_RequiredSize, l_RequiredSize, l_pDeviceData);
    end;
    if (l_Res = ERR_SUCCESS) then
      m_Device[i].avsparam:=l_pDeviceData^
    else
      ShowMessage('Error reading eeprom structure device '+m_Device[i].avsID.SerialNumber);
    FreeMem(l_pDeviceData);
    //fill record in preparemeasurement table
    sgMeasData.Cells[0,i+1]:= m_Device[i].avsID.SerialNumber;
    chkPreScan.Visible:=false;
    case m_Device[i].avsparam.m_Detector.m_SensorType of
      SENS_HAMS8378_256: sgMeasData.cells[1,i+1]:='Ham8378_256';
      SENS_HAMS8378_1024:sgMeasData.cells[1,i+1]:='Ham8378_1024';
      SENS_ILX554:sgMeasData.cells[1,i+1]:='Sony-ILX554';
      SENS_HAMS9201: sgMeasData.cells[1,i+1]:='Ham92xx';
      SENS_TCD1304 : begin
                       sgMeasData.cells[1,i+1]:='TCD1304';
                       chkPreScan.Visible:=true;
                       chkPreScan.Checked:=true;
                       l_Res := AVS_SetPreScanMode(m_Device[i].avsDeviceHandle, chkPreScan.Checked);
                     end;
      SENS_TSL1301:sgMeasData.cells[1,i+1]:='TSL1301';
      SENS_TSL1401:sgMeasData.cells[1,i+1]:='TSL1401';
      SENS_HAMS8378_512:sgMeasData.cells[1,i+1]:='Ham8378_512';
      SENS_HAMS9840:sgMeasData.cells[1,i+1]:='Ham9840';
      SENS_ILX511:sgMeasData.cells[1,i+1]:='Sony-ILX511';
      SENS_HAMS10420_2048X64:sgMeasData.cells[1,i+1]:='H2048x64LN';
      SENS_HAMS11071_2048X64:sgMeasData.cells[1,i+1]:='Ham2048x64';
      SENS_HAMS7031_1024X122:sgMeasData.cells[1,i+1]:='Ham1024x122';
      SENS_HAMS7031_1024X58:sgMeasData.cells[1,i+1]:='Ham1024x58';
      SENS_HAMS11071_2048X16:sgMeasData.cells[1,i+1]:='Ham2048x64';
      SENS_HAMS11155:sgMeasData.cells[1,i+1]:= 'Hams11155';
      SENS_SU256LSB :sgMeasData.cells[1,i+1]:= 'SU256LSB';
      SENS_SU512LDB :sgMeasData.cells[1,i+1]:= 'SU512LDB';
      SENS_HAMS11638: sgMeasData.cells[1,i+1]:='HAMS11638';
      SENS_HAMS11639: sgMeasData.cells[1,i+1]:='HAMS11639';
      SENS_HAMS12443: sgMeasData.cells[1,i+1]:='HAMS12443';
      SENS_HAMG9208_512: sgMeasData.cells[1,i+1]:='HAMG9208_512';
    end; //case
    sgMeasData.cells[2,i+1]:=IntToStr(m_Device[i].avsparam.m_Detector.m_NrPixels);
    sgMeasData.cells[3,i+1]:=IntToStr(m_Device[i].avsparam.m_StandAlone.m_Meas.m_StartPixel);
    sgMeasData.cells[4,i+1]:=IntToStr(m_Device[i].avsparam.m_StandAlone.m_Meas.m_StopPixel);
    sgMeasData.cells[5,i+1]:=FloatToStrF(m_Device[i].avsparam.m_StandAlone.m_Meas.m_IntegrationTime,ffFixed,7,2);
    sgMeasData.cells[6,i+1]:=IntToStr(m_Device[i].avsparam.m_StandAlone.m_Meas.m_NrAverages);
    sgMeasData.cells[7,i+1]:=IntToStr(m_Device[i].avsparam.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix);
    sgTimeInfo.Cells[0,i+1]:=m_Device[i].avsID.SerialNumber;
  end;
  for i:=m_NrOfDevices to sgMeasData.RowCount-2 do
      for j:= 0 to sgMeasData.ColCount-1 do
          sgMeasData.cells[j,i+1]:='';
  for i:=m_NrOfDevices to sgTimeInfo.RowCount-2 do
      for j:= 0 to sgTimeInfo.ColCount-1 do
          sgTimeInfo.cells[j,i+1]:='';

  //add series to chart
  series1.active:=(m_NrOfDevices>0);
  series2.active:=(m_NrOfDevices>1);
  series3.active:=(m_NrOfDevices>2);
  series4.active:=(m_NrOfDevices>3);
  series5.active:=(m_NrOfDevices>4);
  series6.active:=(m_NrOfDevices>5);
  series7.active:=(m_NrOfDevices>6);
  series8.active:=(m_NrOfDevices>7);
  series9.active:=(m_NrOfDevices>8);
  series10.active:=(m_NrOfDevices>9);
  series11.active:=(m_NrOfDevices>10);
  series12.active:=(m_NrOfDevices>11);
  series13.active:=(m_NrOfDevices>12);
  series14.active:=(m_NrOfDevices>13);
  series15.active:=(m_NrOfDevices>14);
  series16.active:=(m_NrOfDevices>15);

  if m_NrOfDevices>0 then series1.Title:=m_Device[0].avsID.SerialNumber;
  if m_NrOfDevices>1 then series2.Title:=m_Device[1].avsID.SerialNumber;
  if m_NrOfDevices>2 then series3.Title:=m_Device[2].avsID.SerialNumber;
  if m_NrOfDevices>3 then series4.Title:=m_Device[3].avsID.SerialNumber;
  if m_NrOfDevices>4 then series5.Title:=m_Device[4].avsID.SerialNumber;
  if m_NrOfDevices>5 then series6.Title:=m_Device[5].avsID.SerialNumber;
  if m_NrOfDevices>6 then series7.Title:=m_Device[6].avsID.SerialNumber;
  if m_NrOfDevices>7 then series8.Title:=m_Device[7].avsID.SerialNumber;
  if m_NrOfDevices>8 then series9.Title:=m_Device[8].avsID.SerialNumber;
  if m_NrOfDevices>9 then series10.Title:=m_Device[9].avsID.SerialNumber;
  if m_NrOfDevices>10 then series11.Title:=m_Device[10].avsID.SerialNumber;
  if m_NrOfDevices>11 then series12.Title:=m_Device[11].avsID.SerialNumber;
  if m_NrOfDevices>12 then series13.Title:=m_Device[12].avsID.SerialNumber;
  if m_NrOfDevices>13 then series14.Title:=m_Device[13].avsID.SerialNumber;
  if m_NrOfDevices>14 then series15.Title:=m_Device[14].avsID.SerialNumber;
  if m_NrOfDevices>15 then series16.Title:=m_Device[15].avsID.SerialNumber;
  //set wavelength range for chart
  minwav:=1.0e4;
  maxwav:=0.0;
  for i:=0 to m_NrOfDevices-1 do
  begin
    j:=m_Device[i].avsparam.m_StandAlone.m_Meas.m_StartPixel;
    calcwav:= m_Device[i].avsparam.m_Detector.m_aFit[0]+
              j * m_Device[i].avsparam.m_Detector.m_aFit[1]+
              j*j * m_Device[i].avsparam.m_Detector.m_aFit[2]+
              j*j*j * m_Device[i].avsparam.m_Detector.m_aFit[3]+
              j*j*j*j * m_Device[i].avsparam.m_Detector.m_aFit[4];
    if calcwav<minwav then minwav:=calcwav;
    j:=m_Device[i].avsparam.m_StandAlone.m_Meas.m_StopPixel;
    calcwav:= m_Device[i].avsparam.m_Detector.m_aFit[0]+
              j * m_Device[i].avsparam.m_Detector.m_aFit[1]+
              j*j * m_Device[i].avsparam.m_Detector.m_aFit[2]+
              j*j*j * m_Device[i].avsparam.m_Detector.m_aFit[3]+
              j*j*j*j * m_Device[i].avsparam.m_Detector.m_aFit[4];
    if calcwav>maxwav then maxwav:=calcwav;
  end;
  Chart1.BottomAxis.SetMinMax(minwav,maxwav);
  teststring:=sgShowList.Cells[1,sgShowList.Selection.Top];
  btnStartMeasurement.Enabled:=(teststring = 'USB_IN_USE_BY_APPLICATION') or (teststring = 'ETH_IN_USE_BY_APPLICATION');
  btnStopMeasurement.Enabled:=(teststring = 'USB_IN_USE_BY_APPLICATION') or (teststring = 'ETH_IN_USE_BY_APPLICATION');
  chkSync.Enabled:=((m_NrOfDevices>1) and
                    ((teststring = 'USB_IN_USE_BY_APPLICATION') or (teststring = 'ETH_IN_USE_BY_APPLICATION')));
  chart1.Legend.Visible:= m_NrOfDevices>1;
end;

procedure TForm1.chkSyncClick(Sender: TObject);
var i:integer;
begin
  if chkSync.Checked then
  begin
    cbMaster.Clear;
    for i:= 0 to m_NrOfDevices-1 do
      cbMaster.Items.Add(m_Device[i].avsID.SerialNumber);
    cbMaster.ItemIndex:=0;
    cbMaster.Text:=m_Device[0].avsID.SerialNumber;
  end
  else
  begin
    cbMaster.Clear;
    cbMaster.ItemIndex:=-1;
    cbMaster.Text:='';
    for i:= 0 to m_NrOfDevices-1 do
      AVS_SetSyncMode(m_Device[i].avsDeviceHandle,0);
  end;
end;

procedure TForm1.btnStartMeasurementClick(Sender: TObject);
var i:byte;
    l_Res:longint;
    l_NrOfScans:smallint;
begin
  m_TotalFailures:=0;
  // prevent second StartMeasurementClick before sequence ends.
  btnStartMeasurement.Enabled := false;
  // prevent switching to sync during run
  chkSync.Enabled:= false;
  //Fill Prepare Measurement Settings Structure
  for i:=0 to m_NrOfDevices-1 do
  begin
    m_Device[i].m_Failures:=0;
    if (m_Device[i].avsDeviceHandle<> INVALID_AVS_HANDLE_VALUE) then
    begin
      m_Device[i].PrepareMeasParam.m_StartPixel:= StrToInt(sgMeasData.cells[3,i+1]);
      m_Device[i].PrepareMeasParam.m_StopPixel :=  StrToInt(sgMeasData.cells[4,i+1]);
      m_Device[i].PrepareMeasParam.m_IntegrationTime := StrToFloat(sgMeasData.cells[5,i+1]);
      m_Device[i].PrepareMeasParam.m_IntegrationDelay := 0;
      m_Device[i].PrepareMeasParam.m_NrAverages := StrToInt(sgMeasData.cells[6,i+1]);
      m_Device[i].PrepareMeasParam.m_SaturationDetection := 0;
      m_Device[i].PrepareMeasParam.m_CorDynDark.m_Enable := 0;
      m_Device[i].PrepareMeasParam.m_CorDynDark.m_ForgetPercentage := 100;
      m_Device[i].PrepareMeasParam.m_Smoothing.m_SmoothPix := StrToInt(sgMeasData.cells[7,i+1]);
      m_Device[i].PrepareMeasParam.m_Smoothing.m_SmoothModel := 0;
      m_Device[i].PrepareMeasParam.m_Control.m_StrobeControl := 0;
      m_Device[i].PrepareMeasParam.m_Control.m_LaserDelay := 0;
      m_Device[i].PrepareMeasParam.m_Control.m_LaserWidth := 0;
      m_Device[i].PrepareMeasParam.m_Control.m_LaserWaveLength := 0.0;
      m_Device[i].PrepareMeasParam.m_Control.m_StoreToRam := 0;
      m_Device[i].PrepareMeasParam.m_Trigger.m_SourceType := 0; //edge triggered
      if chkSync.Checked then
      begin //itemindex of cbMaster matches device i -> device "i=itemindex" is the Master
        if i = cbMaster.ItemIndex then
        begin
          m_Device[i].PrepareMeasParam.m_Trigger.m_Mode :=  0; //start by software trigger
          m_Device[i].PrepareMeasParam.m_Trigger.m_Source := 0;  //only relevant if m_Mode=1, in that case 0=pin6/DB26, 1 = SYNCinput
          //tell dll that spectrometers are in syncmode and device i is the Master
          AVS_SetSyncMode(m_Device[i].avsDeviceHandle,1);
        end
        else
        begin //Set slave spectrometers into hardware trigger by SYNC mode
          m_Device[i].PrepareMeasParam.m_Trigger.m_Mode :=  1; //start by hardware trigger
          m_Device[i].PrepareMeasParam.m_Trigger.m_Source := 1;  //SYNCinput
        end;
      end
      else
      begin
        m_Device[i].PrepareMeasParam.m_Trigger.m_Mode :=  0;
        m_Device[i].PrepareMeasParam.m_Trigger.m_Source := 0;
      end;
      l_Res := AVS_PrepareMeasure(m_Device[i].avsDeviceHandle, m_Device[i].PrepareMeasParam);
      if (ERR_SUCCESS <> l_Res) then
        ShowMessage('error in AVS_PrepareMeasData, code '+ IntToStr(l_Res));
      m_Device[i].NrMeas:=0;
    end;
  end;
  //Now Start Measuring. If Syncmode then start master as last channel
  l_NrOfScans := StrToInt(edtNrOfScans.Text);
  m_StartTicks := GetTickCount;
  if chkSync.Checked then
  begin
    for i:=0 to m_NrOfDevices-1 do
      if ((i<>cbMaster.ItemIndex) and (m_Device[i].avsDeviceHandle<> INVALID_AVS_HANDLE_VALUE)) then
    AVS_Measure(m_Device[i].avsDeviceHandle,self.Handle, l_NrOfScans);
    //start master as last channel in syncmode
    if (m_Device[cbMaster.ItemIndex].avsDeviceHandle<> INVALID_AVS_HANDLE_VALUE) then
    AVS_Measure(m_Device[cbMaster.ItemIndex].avsDeviceHandle,self.Handle,l_NrOfScans);
  end
  else  //not syncmode
  begin
    for i:=0 to m_NrOfDevices-1 do
      if (m_Device[i].avsDeviceHandle<> INVALID_AVS_HANDLE_VALUE) then
    AVS_Measure(m_Device[i].avsDeviceHandle,self.Handle, l_NrOfScans);
  end;
end;

procedure TForm1.btnStopMeasurementClick(Sender: TObject);
var i,l_Res:longint;
begin
  for i:= 0 to m_NrOfDevices-1 do
  begin
    if (m_Device[i].avsDeviceHandle<> INVALID_AVS_HANDLE_VALUE) then
    begin
      l_Res := AVS_StopMeasure(m_Device[i].avsDeviceHandle);
      if (ERR_SUCCESS <> l_Res) then
        ShowMessage('error in AVS_StopMeasure, code '+ IntToStr(l_Res));
    end;
  end;
  btnStartMeasurement.Enabled := true;
  chkSync.Enabled:=true;
end;

procedure TForm1.FormCreate(Sender: TObject);
var i:byte;
begin
  m_NrOfDevices:=0;
  for i:= 0 to MAX_NR_DEVICES-1 do
    m_Device[i].avsDeviceHandle := INVALID_AVS_HANDLE_VALUE;
  ConnectRGrp.ItemIndex:=0;  // USB
end;

procedure TForm1.chkPreScanClick(Sender: TObject);
var i:byte;
    l_Res:Longint;
begin
  for i:=0 to m_NrOfDevices-1 do
  begin
    if m_Device[i].avsparam.m_Detector.m_SensorType = SENS_TCD1304 then
    begin
      l_Res := AVS_SetPreScanMode(m_Device[i].avsDeviceHandle, chkPreScan.Checked);
      if l_Res<>ERR_SUCCESS then
        ShowMessage('Error in AVS_SetPreScanMode, code '+ IntToStr(l_Res));
    end;
  end;
end;

end.

unit anio;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TfrmAnIO = class(TForm)
    gbAnalogOut: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    edtAO1: TEdit;
    edtAO2: TEdit;
    btnSetAnalogOut: TButton;
    gbAnalogInput26: TGroupBox;
    Label3: TLabel;
    Label4: TLabel;
    btnGetAnalogIn: TButton;
    edtAI5: TEdit;
    edtAI4: TEdit;
    btnClose: TButton;
    gbAnalogInOnboard: TGroupBox;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    edtAI0: TEdit;
    edtAI1: TEdit;
    edtAI2: TEdit;
    edtAI3: TEdit;
    edtAI6: TEdit;
    edtAI7: TEdit;
    btnGetOnboardAI: TButton;
    procedure btnSetAnalogOutClick(Sender: TObject);
    procedure btnGetAnalogInClick(Sender: TObject);
    procedure btnGetOnboardAIClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmAnIO: TfrmAnIO;

implementation

{$R *.dfm}

uses main, avaspec;

procedure TfrmAnIO.btnSetAnalogOutClick(Sender: TObject);
var l_Value: array[0..NR_OF_ANALOG_OUTPUTS-1] of single;
    l_bNoError:boolean;
    i:byte;
    l_Res: longint;
begin
  l_bNoError := true;
  l_Value[0] := StrToFloat(edtAO1.Text);
  l_Value[1] := StrToFloat(edtAO2.Text);
  i:=0;
  while ((i < NR_OF_ANALOG_OUTPUTS) and (l_bNoError)) do
  begin
    l_Res := AVS_SetAnalogOut(m_DeviceHandle, i, l_Value[i]);
    if (l_Res <> ERR_SUCCESS) then
    begin
      l_bNoError := false;
      ShowMessage('error in AVS_SetAnalogOut, code '+ IntToStr(l_Res));
    end;
    i:=i+1;
  end;
end;

procedure TfrmAnIO.btnGetAnalogInClick(Sender: TObject);
var l_Value: single;
    l_Res : longint;
begin
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 5, l_Value);
  if (l_Res <> ERR_SUCCESS) then
    ShowMessage('Error ID=5 (pin 9), code '+ IntToStr(l_Res))
  else
    edtAI5.Text := FloatToStrF(l_Value,ffFixed,7,2);
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 4, l_Value);
  if (l_Res <> ERR_SUCCESS) then
    ShowMessage('Error ID=4 (pin 18), code '+ IntToStr(l_Res))
  else
    edtAI4.Text := FloatToStrF(l_Value,ffFixed,7,2);
end;

procedure TfrmAnIO.btnGetOnboardAIClick(Sender: TObject);
var l_Value: single;
    l_Res : longint;
begin
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 0, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI0.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI0.Text := 'Not Available';
    else ShowMessage('Error ID=0, code '+ IntToStr(l_Res));
  end; { case }
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 1, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI1.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI1.Text := 'Not Available';
    else ShowMessage('Error ID=1, code '+ IntToStr(l_Res));
  end; { case }
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 2, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI2.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI2.Text := 'Not Available';
    else ShowMessage('Error ID=2, code '+ IntToStr(l_Res));
  end; { case }
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 3, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI3.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI3.Text := 'Not Available';
    else ShowMessage('Error ID=3, code '+ IntToStr(l_Res));
  end; { case }
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 6, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI6.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI6.Text := 'Not Available';
    else ShowMessage('Error ID=6, code '+ IntToStr(l_Res));
  end;{ case }
  l_Res := AVS_GetAnalogIn(m_DeviceHandle, 7, l_Value);
  case l_Res of
    ERR_SUCCESS:           edtAI7.Text := FloatToStrF(l_Value,ffFixed,7,2);
    ERR_INVALID_PARAMETER: edtAI7.Text := 'Not Available';
    else ShowMessage('Error ID=7, code '+ IntToStr(l_Res));
  end; { case }
end;

end.

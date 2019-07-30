unit digio;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TfrmDigIO = class(TForm)
    gbOutputs: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Label10: TLabel;
    Label11: TLabel;
    Label12: TLabel;
    chkDO1: TCheckBox;
    chkDO2: TCheckBox;
    chkDO3: TCheckBox;
    chkDO4: TCheckBox;
    chkDO7: TCheckBox;
    chkDO8: TCheckBox;
    chkDO9: TCheckBox;
    chkDO10: TCheckBox;
    chkDO5: TCheckBox;
    chkDO6: TCheckBox;
    chkPWM1: TCheckBox;
    chkPWM2: TCheckBox;
    chkPWM3: TCheckBox;
    chkPWM5: TCheckBox;
    chkPWM6: TCheckBox;
    chkPWM7: TCheckBox;
    edtDuty1: TEdit;
    edtDuty2: TEdit;
    edtDuty3: TEdit;
    edtDuty5: TEdit;
    edtDuty6: TEdit;
    edtDuty7: TEdit;
    edtFreq123: TEdit;
    edtFreq567: TEdit;
    gbInputs: TGroupBox;
    Label13: TLabel;
    Label14: TLabel;
    Label15: TLabel;
    chkDI1: TCheckBox;
    chkDI2: TCheckBox;
    chkDI3: TCheckBox;
    btnGetDigIn: TButton;
    btnClose: TButton;
    procedure OutputClick(a_Id: byte; a_Value:byte);
    procedure chkDO1Click(Sender: TObject);
    procedure chkPWM1Click(Sender: TObject);
    procedure chkDO2Click(Sender: TObject);
    procedure chkPWM2Click(Sender: TObject);
    procedure chkDO3Click(Sender: TObject);
    procedure chkPWM3Click(Sender: TObject);
    procedure chkDO4Click(Sender: TObject);
    procedure chkDO5Click(Sender: TObject);
    procedure chkPWM5Click(Sender: TObject);
    procedure chkDO6Click(Sender: TObject);
    procedure chkPWM6Click(Sender: TObject);
    procedure chkDO7Click(Sender: TObject);
    procedure chkPWM7Click(Sender: TObject);
    procedure chkDO8Click(Sender: TObject);
    procedure chkDO9Click(Sender: TObject);
    procedure chkDO10Click(Sender: TObject);
    procedure btnGetDigInClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmDigIO: TfrmDigIO;

implementation

{$R *.dfm}

uses main,avaspec;

procedure TfrmDigIO.OutputClick(a_Id: byte; a_Value:byte);
var
    l_Res:longint;
    l_Freq:DWord;
    l_Perc:Byte;

begin
     l_Res := ERR_SUCCESS;
     if (((a_Id=0) or (a_Id=1) or (a_Id=2) or (a_Id=4) or (a_Id=5) or (a_Id=6)) and (a_Value=1)) then
     begin
          case a_Id of

               0 : if (chkPWM1.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty1.Text);
                          l_Freq := StrToInt(edtFreq123.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

               1 : if (chkPWM2.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty2.Text);
                          l_Freq := StrToInt(edtFreq123.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

               2 : if (chkPWM3.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty3.Text);
                          l_Freq := StrToInt(edtFreq123.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

               4 : if (chkPWM5.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty5.Text);
                          l_Freq := StrToInt(edtFreq567.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

               5 : if (chkPWM6.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty6.Text);
                          l_Freq := StrToInt(edtFreq567.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

               6 : if (chkPWM7.Checked) then
                   begin
                          l_Perc := StrToInt(edtDuty7.Text);
                          l_Freq := StrToInt(edtFreq567.Text);
                          l_Res := AVS_SetPwmOut(m_DeviceHandle, a_Id, l_Freq, l_Perc);
                   end
                   else
                          l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);
          end;//case
     end
     else
         l_Res := AVS_SetDigOut(m_DeviceHandle, a_Id, a_Value);

     if (l_Res <> ERR_SUCCESS) then
        ShowMessage('error, code '+ IntToStr(l_Res));
end;

procedure TfrmDigIO.chkDO1Click(Sender: TObject);
begin
     if chkDO1.Checked then
        OutputClick(0,1)
     else
         OutputClick(0,0);
end;

procedure TfrmDigIO.chkPWM1Click(Sender: TObject);
begin
     chkDO1Click(Self);
end;

procedure TfrmDigIO.chkDO2Click(Sender: TObject);
begin
     if chkDO2.Checked then
        OutputClick(1,1)
     else
         OutputClick(1,0);
end;

procedure TfrmDigIO.chkPWM2Click(Sender: TObject);
begin
     chkDO2Click(Self);
end;

procedure TfrmDigIO.chkDO3Click(Sender: TObject);
begin
     if chkDO3.Checked then
        OutputClick(2,1)
     else
         OutputClick(2,0);

end;

procedure TfrmDigIO.chkPWM3Click(Sender: TObject);
begin
     chkDO3Click(Self);
end;

procedure TfrmDigIO.chkDO4Click(Sender: TObject);
begin
     if chkDO4.Checked then
        OutputClick(3,1)
     else
         OutputClick(3,0);
end;

procedure TfrmDigIO.chkDO5Click(Sender: TObject);
begin
     if chkDO5.Checked then
        OutputClick(4,1)
     else
         OutputClick(4,0);
end;


procedure TfrmDigIO.chkPWM5Click(Sender: TObject);
begin
     chkDO5Click(Self);
end;

procedure TfrmDigIO.chkDO6Click(Sender: TObject);
begin
     if chkDO6.Checked then
        OutputClick(5,1)
     else
         OutputClick(5,0);
end;

procedure TfrmDigIO.chkPWM6Click(Sender: TObject);
begin
     chkDO6Click(Self);
end;

procedure TfrmDigIO.chkDO7Click(Sender: TObject);
begin
     if chkDO7.Checked then
        OutputClick(6,1)
     else
         OutputClick(6,0);
end;

procedure TfrmDigIO.chkPWM7Click(Sender: TObject);
begin
     chkDO7Click(Self);
end;

procedure TfrmDigIO.chkDO8Click(Sender: TObject);
begin
     if chkDO8.Checked then
        OutputClick(7,1)
     else
         OutputClick(7,0);
end;

procedure TfrmDigIO.chkDO9Click(Sender: TObject);
begin
     if chkDO9.Checked then
        OutputClick(8,1)
     else
         OutputClick(8,0);
end;

procedure TfrmDigIO.chkDO10Click(Sender: TObject);
begin
     if chkDO10.Checked then
        OutputClick(9,1)
     else
         OutputClick(9,0);
end;

procedure TfrmDigIO.btnGetDigInClick(Sender: TObject);
var
   l_Value: array[0..NR_OF_DIGITAL_INPUTS-1] of byte;
   l_bNoError:boolean;
   i:byte;
begin
     l_bNoError:= true;
     i:=0;
     while ((i < NR_OF_DIGITAL_INPUTS) and (l_bNoError)) do
     begin
          l_bNoError := (ERR_SUCCESS = AVS_GetDigIn(m_DeviceHandle, i, l_Value[i]));
          i:=i+1;
     end;
     if (l_bNoError) then
     begin
          chkDI1.Enabled := true;
          chkDI1.Checked := l_Value[DIG_IN0] = 1;
          chkDI1.Enabled := false;
          chkDI2.Enabled := true;
          chkDI2.Checked := l_Value[DIG_IN1] = 1;
          chkDI2.Enabled := false;
          chkDI3.Enabled := true;
          chkDI3.Checked := l_Value[DIG_IN2] = 1;
          chkDI3.Enabled := false;
     end
     else
         ShowMessage('error in AVS_GetDigIn');
end;

end.

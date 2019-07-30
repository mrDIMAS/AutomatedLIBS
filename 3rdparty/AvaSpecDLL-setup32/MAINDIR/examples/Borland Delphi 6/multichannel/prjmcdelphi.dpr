program prjmcdelphi;

uses
  Forms,
  Unit1 in 'Unit1.pas' {Form1},
  avaspec in 'avaspec.pas',
  U_Usb in 'U_Usb.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.

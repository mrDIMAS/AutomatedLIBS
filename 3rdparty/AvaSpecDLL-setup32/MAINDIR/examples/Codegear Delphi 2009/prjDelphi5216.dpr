program prjDelphi5216;

uses
  Forms,
  main in 'main.pas' {Form1},
  U_Usb in 'U_Usb.pas',
  avaspec in 'avaspec.pas',
  digio in 'digio.pas' {frmDigIO},
  anio in 'anio.pas' {frmAnIO},
  eeprom in 'eeprom.pas' {frmEEprom};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TfrmDigIO, frmDigIO);
  Application.CreateForm(TfrmAnIO, frmAnIO);
  Application.CreateForm(TfrmEEprom, frmEEprom);
  Application.Run;
end.

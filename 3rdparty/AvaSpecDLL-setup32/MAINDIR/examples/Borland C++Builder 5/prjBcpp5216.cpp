//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop
USERES("prjBcpp5216.res");
USEFORM("main.cpp", MainForm);
USELIB("avaspec.lib");
USEFORM("digio.cpp", frmDigIO);
USEFORM("anio.cpp", frmAnIO);
USEFORM("eeprom.cpp", frmEEprom);
USEUNIT("convert.cpp");
//---------------------------------------------------------------------------
WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
        try
        {
                 Application->Initialize();
                 Application->CreateForm(__classid(TMainForm), &MainForm);
                 Application->CreateForm(__classid(TfrmDigIO), &frmDigIO);
                 Application->CreateForm(__classid(TfrmAnIO), &frmAnIO);
                 Application->CreateForm(__classid(TfrmEEprom), &frmEEprom);
                 Application->Run();
        }
        catch (Exception &exception)
        {
                 Application->ShowException(&exception);
        }
        return 0;
}
//---------------------------------------------------------------------------

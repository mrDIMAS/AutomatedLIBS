//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include "avaspec.h"
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ComCtrls.hpp>
#include <Grids.hpp>
#include <Chart.hpp>
#include <ExtCtrls.hpp>
#include <Series.hpp>
#include <TeEngine.hpp>
#include <TeeProcs.hpp>
#include <Menus.hpp>
#include <Mask.hpp>
//---------------------------------------------------------------------------
class TMainForm : public TForm
{
__published:	// IDE-managed Components
        TButton *btnCommunication;
        TStatusBar *StatusBar1;
        TStringGrid *sgShowList;
        TButton *btnUpdateList;
        TChart *Chart1;
        TGroupBox *gbPrepareMeasSettings;
        TGroupBox *gbOutput;
        TEdit *edtStartPixel;
        TLabel *Label3;
        TLabel *Label5;
        TEdit *edtStopPixel;
        TLabel *Label14;
        TEdit *edtIntegrationTime;
        TLabel *Label15;
        TEdit *edtIntegrationDelay;
        TLabel *Label16;
        TEdit *edtNrOfAverages;
        TGroupBox *gbTrigger;
        TLabel *Label20;
        TLabel *Label31;
        TLabel *Label32;
        TCheckBox *chkTrigTypeLevel;
        TCheckBox *chkTrigTypeEdge;
        TCheckBox *chkTrigSourceSync;
        TCheckBox *chkTrigSourceExtHw;
        TCheckBox *chkTrigModeSw;
        TCheckBox *chkTrigModeHw;
        TGroupBox *gbDarkCorrection;
        TCheckBox *chkEnableDarkCorrection;
        TEdit *edtDarkHist;
        TLabel *Label1;
        TGroupBox *gbSmoothing;
        TLabel *Label2;
        TEdit *edtSmoothModel;
        TEdit *edtSmoothPix;
        TLabel *Label4;
        TLabel *Label6;
        TEdit *edtSaturationLevel;
        TLabel *Label7;
        TLabel *Label8;
        TGroupBox *gbControl;
        TLabel *Label33;
        TLabel *Label34;
        TLabel *Label35;
        TLabel *Label36;
        TLabel *Label37;
        TEdit *edtFlashesPerScan;
        TEdit *edtLaserDelay;
        TEdit *edtLaserWidth;
        TEdit *edtLaserWavelength;
        TEdit *edtRamSpectra;
        TLabel *Label9;
        TLabel *Label10;
        TLabel *Label11;
        TGroupBox *gbMeasure;
        TButton *btnActivate;
        TButton *btnDeactivate;
        TGroupBox *gbInfo;
        TLabel *Label12;
        TEdit *edtDetectorname;
        TLabel *Label13;
        TEdit *edtNrOfPixels;
        TButton *btnStartMeasurement;
        TLabel *Label17;
        TEdit *edtNrOfScans;
        TLabel *Label18;
        TButton *btnStopMeasurement;
        TLabel *Label19;
        TEdit *edtTotalTime;
        TLabel *Label22;
        TEdit *edtPerformedScans;
        TLabel *Label21;
        TEdit *edtFailures;
        TEdit *edtAvgTimePerScan;
        TLabel *Label23;
        TLabel *Label24;
        TEdit *edtLastScanTime;
        TLabel *Label25;
        TLabel *Label26;
        TCheckBox *chkDisableGraph;
        TLabel *Label27;
        TMainMenu *MainMenu1;
        TButton *btnDigIO;
        TButton *btnAnIO;
        TButton *btnReadMeasFromEEProm;
        TButton *btnWriteMeasToEEProm;
        TButton *btnShowEEProm;
        TLineSeries *Series1;
        TEdit *edtFPGAver;
        TEdit *edtFWver;
        TEdit *edtDLLver;
        TLabel *Label28;
        TLabel *Label29;
        TLabel *Label30;
        TCheckBox *chkPreScan;
        TRadioGroup *rdgSetSensitivityMode;
        void __fastcall btnCommunicationClick(TObject *Sender);
        void __fastcall FormClose(TObject *Sender, TCloseAction &Action);
        void __fastcall btnUpdateListClick(TObject *Sender);
        void __fastcall sgShowListClick(TObject *Sender);
        void __fastcall btnActivateClick(TObject *Sender);
        void __fastcall btnDeactivateClick(TObject *Sender);
        void __fastcall chkTrigModeHwClick(TObject *Sender);
        void __fastcall chkTrigModeSwClick(TObject *Sender);
        void __fastcall chkTrigSourceExtHwClick(TObject *Sender);
        void __fastcall chkTrigSourceSyncClick(TObject *Sender);
        void __fastcall chkTrigTypeEdgeClick(TObject *Sender);
        void __fastcall chkTrigTypeLevelClick(TObject *Sender);
        void __fastcall btnStartMeasurementClick(TObject *Sender);
        void __fastcall btnStopMeasurementClick(TObject *Sender);
        void __fastcall chkDisableGraphClick(TObject *Sender);
        void __fastcall btnDigIOClick(TObject *Sender);
        void __fastcall btnAnIOClick(TObject *Sender);
        void __fastcall btnShowEEPromClick(TObject *Sender);
        void __fastcall btnReadMeasFromEEPromClick(TObject *Sender);
        void __fastcall btnWriteMeasToEEPromClick(TObject *Sender);
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall chkPreScanClick(TObject *Sender);
        void __fastcall rdgSetSensitivityModeClick(TObject *Sender);
private:	// User declarations

        void __fastcall HandleMeasResult(TMessage& a_WinMess);
        void __fastcall OnDeviceChange(TMessage& a_WndMsg);
        BEGIN_MESSAGE_MAP
          MESSAGE_HANDLER(WM_MEAS_READY, TMessage, HandleMeasResult)
          MESSAGE_HANDLER(WM_DEVICECHANGE, TMessage, OnDeviceChange)
        END_MESSAGE_MAP(TForm)

    double          *m_pLambda;
    unsigned short  m_NrPixels;
    unsigned short  m_StartPixels;
    unsigned short  m_StopPixels;
    DWORD           m_StartTicks;
    unsigned int    m_Measurements;
    unsigned int    m_Failures;
    bool            m_GraphicsDisabled;
    unsigned int    m_PreviousTimeStamp;

    void    DisconnectGui(void);
    void    ConnectGui();

public:		// User declarations
        __fastcall TMainForm(TComponent* Owner);
        AvsHandle       m_DeviceHandle;


};
//---------------------------------------------------------------------------
extern PACKAGE TMainForm *MainForm;
//---------------------------------------------------------------------------
#endif

//---------------------------------------------------------------------------

#ifndef anioH
#define anioH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TfrmAnIO : public TForm
{
__published:	// IDE-managed Components
        TGroupBox *gbAnalogOut;
        TGroupBox *gbAnalogInput26;
        TButton *btnClose;
        TEdit *edtAO1;
        TEdit *edtAO2;
        TButton *btnSetAnalogOut;
        TLabel *Label1;
        TLabel *Label2;
        TButton *btnGetAnalogIn;
        TEdit *edtAI5;
        TEdit *edtAI4;
        TLabel *Label3;
        TLabel *Label4;
        TGroupBox *gbAnalogInOnboard;
        TLabel *Label5;
        TLabel *Label6;
        TEdit *edtAI0;
        TEdit *edtAI1;
        TLabel *Label7;
        TEdit *edtAI2;
        TEdit *edtAI3;
        TEdit *edtAI6;
        TEdit *edtAI7;
        TLabel *Label8;
        TLabel *Label9;
        TLabel *Label10;
        TButton *btnGetOnboardAI;
        void __fastcall btnSetAnalogOutClick(TObject *Sender);
        void __fastcall btnGetAnalogInClick(TObject *Sender);
        void __fastcall btnGetOnboardAIClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TfrmAnIO(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmAnIO *frmAnIO;
//---------------------------------------------------------------------------
#endif

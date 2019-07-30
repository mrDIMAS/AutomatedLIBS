//---------------------------------------------------------------------------

#ifndef digioH
#define digioH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TfrmDigIO : public TForm
{
__published:	// IDE-managed Components
        TGroupBox *gbOutputs;
        TCheckBox *chkDO1;
        TCheckBox *chkDO2;
        TCheckBox *chkDO3;
        TCheckBox *chkDO4;
        TCheckBox *chkDO7;
        TCheckBox *chkDO8;
        TCheckBox *chkDO9;
        TCheckBox *chkDO10;
        TCheckBox *chkDO5;
        TCheckBox *chkDO6;
        TCheckBox *chkPWM1;
        TCheckBox *chkPWM2;
        TCheckBox *chkPWM3;
        TCheckBox *chkPWM5;
        TCheckBox *chkPWM6;
        TCheckBox *chkPWM7;
        TEdit *edtDuty1;
        TEdit *edtDuty2;
        TEdit *edtDuty3;
        TEdit *edtDuty5;
        TEdit *edtDuty6;
        TEdit *edtDuty7;
        TEdit *edtFreq123;
        TEdit *edtFreq567;
        TLabel *Label1;
        TLabel *Label2;
        TLabel *Label3;
        TLabel *Label4;
        TLabel *Label5;
        TLabel *Label6;
        TLabel *Label7;
        TLabel *Label8;
        TLabel *Label9;
        TLabel *Label10;
        TLabel *Label11;
        TLabel *Label12;
        TGroupBox *gbInputs;
        TCheckBox *chkDI1;
        TCheckBox *chkDI2;
        TCheckBox *chkDI3;
        TLabel *Label13;
        TLabel *Label14;
        TLabel *Label15;
        TButton *btnGetDigIn;
        TButton *btnClose;
        void __fastcall chkDO1Click(TObject *Sender);
        void __fastcall chkPWM1Click(TObject *Sender);
        void __fastcall chkDO2Click(TObject *Sender);
        void __fastcall chkPWM2Click(TObject *Sender);
        void __fastcall chkDO3Click(TObject *Sender);
        void __fastcall chkPWM3Click(TObject *Sender);
        void __fastcall chkDO4Click(TObject *Sender);
        void __fastcall chkDO5Click(TObject *Sender);
        void __fastcall chkPWM5Click(TObject *Sender);
        void __fastcall chkDO6Click(TObject *Sender);
        void __fastcall chkPWM6Click(TObject *Sender);
        void __fastcall chkDO7Click(TObject *Sender);
        void __fastcall chkPWM7Click(TObject *Sender);
        void __fastcall chkDO8Click(TObject *Sender);
        void __fastcall chkDO9Click(TObject *Sender);
        void __fastcall chkDO10Click(TObject *Sender);
        void __fastcall btnGetDigInClick(TObject *Sender);
private:	// User declarations
        void __fastcall OutputClick(unsigned char a_Id, unsigned char a_Value);
public:		// User declarations
        __fastcall TfrmDigIO(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfrmDigIO *frmDigIO;
//---------------------------------------------------------------------------
#endif

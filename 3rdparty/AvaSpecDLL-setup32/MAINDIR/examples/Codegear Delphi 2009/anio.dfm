object frmAnIO: TfrmAnIO
  Left = 192
  Top = 107
  Caption = 'Test Analog IO'
  ClientHeight = 480
  ClientWidth = 328
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object gbAnalogOut: TGroupBox
    Left = 16
    Top = 16
    Width = 297
    Height = 81
    Caption = 'Analog Output'
    TabOrder = 0
    object Label1: TLabel
      Left = 16
      Top = 32
      Width = 59
      Height = 13
      Caption = 'pin 17 (AO1)'
    end
    object Label2: TLabel
      Left = 16
      Top = 56
      Width = 59
      Height = 13
      Caption = 'pin 26 (AO2)'
    end
    object edtAO1: TEdit
      Left = 88
      Top = 24
      Width = 73
      Height = 21
      TabOrder = 0
      Text = '0'
    end
    object edtAO2: TEdit
      Left = 88
      Top = 48
      Width = 73
      Height = 21
      TabOrder = 1
      Text = '0'
    end
    object btnSetAnalogOut: TButton
      Left = 184
      Top = 32
      Width = 89
      Height = 25
      Caption = 'Set Analog Out'
      TabOrder = 2
      OnClick = btnSetAnalogOutClick
    end
  end
  object gbAnalogInput26: TGroupBox
    Left = 16
    Top = 144
    Width = 297
    Height = 81
    Caption = 'Analog Input SUBD26-F connector'
    TabOrder = 1
    object Label3: TLabel
      Left = 16
      Top = 32
      Width = 48
      Height = 13
      Caption = 'pin 9 (AI1)'
    end
    object Label4: TLabel
      Left = 16
      Top = 56
      Width = 54
      Height = 13
      Caption = 'pin 18 (AI2)'
    end
    object btnGetAnalogIn: TButton
      Left = 184
      Top = 32
      Width = 89
      Height = 25
      Caption = 'Get Analog In'
      TabOrder = 0
      OnClick = btnGetAnalogInClick
    end
    object edtAI5: TEdit
      Left = 88
      Top = 24
      Width = 73
      Height = 21
      TabOrder = 1
    end
    object edtAI4: TEdit
      Left = 88
      Top = 48
      Width = 73
      Height = 21
      TabOrder = 2
    end
  end
  object btnClose: TButton
    Left = 136
    Top = 448
    Width = 75
    Height = 25
    Caption = 'Close'
    ModalResult = 2
    TabOrder = 2
  end
  object gbAnalogInOnboard: TGroupBox
    Left = 16
    Top = 248
    Width = 297
    Height = 177
    Caption = 'Onboard Analog Input'
    TabOrder = 3
    object Label5: TLabel
      Left = 16
      Top = 32
      Width = 67
      Height = 13
      Caption = 'thermistor X11'
    end
    object Label6: TLabel
      Left = 16
      Top = 56
      Width = 19
      Height = 13
      Caption = '1V2'
    end
    object Label7: TLabel
      Left = 16
      Top = 80
      Width = 24
      Height = 13
      Caption = '5VIO'
    end
    object Label8: TLabel
      Left = 16
      Top = 104
      Width = 35
      Height = 13
      Caption = '5VUSB'
    end
    object Label9: TLabel
      Left = 16
      Top = 128
      Width = 44
      Height = 13
      Caption = 'NTC1 X8'
    end
    object Label10: TLabel
      Left = 16
      Top = 152
      Width = 44
      Height = 13
      Caption = 'NTC2 X9'
    end
    object edtAI0: TEdit
      Left = 88
      Top = 24
      Width = 73
      Height = 21
      TabOrder = 0
    end
    object edtAI1: TEdit
      Left = 88
      Top = 48
      Width = 73
      Height = 21
      TabOrder = 1
    end
    object edtAI2: TEdit
      Left = 88
      Top = 72
      Width = 73
      Height = 21
      TabOrder = 2
    end
    object edtAI3: TEdit
      Left = 88
      Top = 96
      Width = 73
      Height = 21
      TabOrder = 3
    end
    object edtAI6: TEdit
      Left = 88
      Top = 120
      Width = 73
      Height = 21
      TabOrder = 4
    end
    object edtAI7: TEdit
      Left = 88
      Top = 144
      Width = 73
      Height = 21
      TabOrder = 5
    end
    object btnGetOnboardAI: TButton
      Left = 184
      Top = 80
      Width = 89
      Height = 25
      Caption = 'Get Onboard AI'
      TabOrder = 6
      OnClick = btnGetOnboardAIClick
    end
  end
end

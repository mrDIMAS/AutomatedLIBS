object frmDigIO: TfrmDigIO
  Left = 192
  Top = 107
  Width = 480
  Height = 528
  Caption = 'Test Digital IO'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object gbOutputs: TGroupBox
    Left = 16
    Top = 16
    Width = 417
    Height = 281
    Caption = 'Digital Outputs'
    TabOrder = 0
    object Label1: TLabel
      Left = 256
      Top = 16
      Width = 132
      Height = 13
      Caption = 'Frequency (500-300000 Hz)'
    end
    object Label2: TLabel
      Left = 184
      Top = 16
      Width = 59
      Height = 13
      Caption = 'DutyCycle %'
    end
    object Label3: TLabel
      Left = 8
      Top = 32
      Width = 29
      Height = 13
      Caption = 'pin 11'
    end
    object Label4: TLabel
      Left = 8
      Top = 56
      Width = 23
      Height = 13
      Caption = 'pin 2'
    end
    object Label5: TLabel
      Left = 8
      Top = 80
      Width = 29
      Height = 13
      Caption = 'pin 20'
    end
    object Label6: TLabel
      Left = 8
      Top = 104
      Width = 29
      Height = 13
      Caption = 'pin 12'
    end
    object Label7: TLabel
      Left = 8
      Top = 128
      Width = 23
      Height = 13
      Caption = 'pin 3'
    end
    object Label8: TLabel
      Left = 8
      Top = 152
      Width = 29
      Height = 13
      Caption = 'pin 21'
    end
    object Label9: TLabel
      Left = 8
      Top = 176
      Width = 29
      Height = 13
      Caption = 'pin 13'
    end
    object Label10: TLabel
      Left = 8
      Top = 200
      Width = 23
      Height = 13
      Caption = 'pin 4'
    end
    object Label11: TLabel
      Left = 8
      Top = 224
      Width = 29
      Height = 13
      Caption = 'pin 22'
    end
    object Label12: TLabel
      Left = 8
      Top = 248
      Width = 29
      Height = 13
      Caption = 'pin 25'
    end
    object chkDO1: TCheckBox
      Left = 56
      Top = 32
      Width = 57
      Height = 17
      Caption = 'DO1'
      TabOrder = 0
      OnClick = chkDO1Click
    end
    object chkDO2: TCheckBox
      Left = 56
      Top = 56
      Width = 97
      Height = 17
      Caption = 'DO2'
      TabOrder = 1
      OnClick = chkDO2Click
    end
    object chkDO3: TCheckBox
      Left = 56
      Top = 80
      Width = 97
      Height = 17
      Caption = 'DO3'
      TabOrder = 2
      OnClick = chkDO3Click
    end
    object chkDO4: TCheckBox
      Left = 56
      Top = 104
      Width = 97
      Height = 17
      Caption = 'DO4'
      TabOrder = 3
      OnClick = chkDO4Click
    end
    object chkDO7: TCheckBox
      Left = 56
      Top = 176
      Width = 57
      Height = 17
      Caption = 'DO7'
      TabOrder = 4
      OnClick = chkDO7Click
    end
    object chkDO8: TCheckBox
      Left = 56
      Top = 200
      Width = 57
      Height = 17
      Caption = 'DO8'
      TabOrder = 5
      OnClick = chkDO8Click
    end
    object chkDO9: TCheckBox
      Left = 56
      Top = 224
      Width = 65
      Height = 17
      Caption = 'DO9'
      TabOrder = 6
      OnClick = chkDO9Click
    end
    object chkDO10: TCheckBox
      Left = 56
      Top = 248
      Width = 57
      Height = 17
      Caption = 'DO10'
      TabOrder = 7
      OnClick = chkDO10Click
    end
    object chkDO5: TCheckBox
      Left = 56
      Top = 128
      Width = 49
      Height = 17
      Caption = 'DO5'
      TabOrder = 8
      OnClick = chkDO5Click
    end
    object chkDO6: TCheckBox
      Left = 56
      Top = 152
      Width = 57
      Height = 17
      Caption = 'DO6'
      TabOrder = 9
      OnClick = chkDO6Click
    end
    object chkPWM1: TCheckBox
      Left = 120
      Top = 32
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 10
      OnClick = chkPWM1Click
    end
    object chkPWM2: TCheckBox
      Left = 120
      Top = 56
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 11
      OnClick = chkPWM2Click
    end
    object chkPWM3: TCheckBox
      Left = 120
      Top = 80
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 12
      OnClick = chkPWM3Click
    end
    object chkPWM5: TCheckBox
      Left = 120
      Top = 128
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 13
      OnClick = chkPWM5Click
    end
    object chkPWM6: TCheckBox
      Left = 120
      Top = 152
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 14
      OnClick = chkPWM6Click
    end
    object chkPWM7: TCheckBox
      Left = 120
      Top = 176
      Width = 65
      Height = 17
      Caption = 'PWM'
      TabOrder = 15
      OnClick = chkPWM7Click
    end
    object edtDuty1: TEdit
      Left = 184
      Top = 32
      Width = 57
      Height = 21
      TabOrder = 16
      Text = '50'
    end
    object edtDuty2: TEdit
      Left = 184
      Top = 56
      Width = 57
      Height = 21
      TabOrder = 17
      Text = '50'
    end
    object edtDuty3: TEdit
      Left = 184
      Top = 80
      Width = 57
      Height = 21
      TabOrder = 18
      Text = '50'
    end
    object edtDuty5: TEdit
      Left = 184
      Top = 128
      Width = 57
      Height = 21
      TabOrder = 19
      Text = '50'
    end
    object edtDuty6: TEdit
      Left = 184
      Top = 152
      Width = 57
      Height = 21
      TabOrder = 20
      Text = '50'
    end
    object edtDuty7: TEdit
      Left = 184
      Top = 176
      Width = 57
      Height = 21
      TabOrder = 21
      Text = '50'
    end
    object edtFreq123: TEdit
      Left = 256
      Top = 40
      Width = 57
      Height = 49
      AutoSize = False
      TabOrder = 22
      Text = '1000'
    end
    object edtFreq567: TEdit
      Left = 256
      Top = 134
      Width = 57
      Height = 51
      AutoSize = False
      TabOrder = 23
      Text = '1000'
    end
  end
  object gbInputs: TGroupBox
    Left = 16
    Top = 320
    Width = 417
    Height = 105
    Caption = 'Digital Inputs'
    TabOrder = 1
    object Label13: TLabel
      Left = 8
      Top = 24
      Width = 29
      Height = 13
      Caption = 'pin 24'
    end
    object Label14: TLabel
      Left = 8
      Top = 48
      Width = 23
      Height = 13
      Caption = 'pin 7'
    end
    object Label15: TLabel
      Left = 8
      Top = 72
      Width = 29
      Height = 13
      Caption = 'pin 16'
    end
    object chkDI1: TCheckBox
      Left = 56
      Top = 24
      Width = 97
      Height = 17
      Caption = 'DI1'
      Enabled = False
      TabOrder = 0
    end
    object chkDI2: TCheckBox
      Left = 56
      Top = 48
      Width = 97
      Height = 17
      Caption = 'DI2'
      Enabled = False
      TabOrder = 1
    end
    object chkDI3: TCheckBox
      Left = 56
      Top = 72
      Width = 97
      Height = 17
      Caption = 'DI3'
      Enabled = False
      TabOrder = 2
    end
    object btnGetDigIn: TButton
      Left = 112
      Top = 40
      Width = 121
      Height = 25
      Caption = 'Get Digital Inputs'
      TabOrder = 3
      OnClick = btnGetDigInClick
    end
  end
  object btnClose: TButton
    Left = 184
    Top = 448
    Width = 75
    Height = 25
    Caption = 'Close'
    ModalResult = 2
    TabOrder = 2
  end
end

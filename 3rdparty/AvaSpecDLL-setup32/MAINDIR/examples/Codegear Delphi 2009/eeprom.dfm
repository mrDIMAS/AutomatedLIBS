object frmEEprom: TfrmEEprom
  Left = 229
  Top = 116
  Caption = 'EEprom Settings'
  ClientHeight = 675
  ClientWidth = 819
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 16
    Width = 79
    Height = 13
    Caption = 'Structure Length'
  end
  object Label2: TLabel
    Left = 16
    Top = 40
    Width = 81
    Height = 13
    Caption = 'Structure Version'
  end
  object Label3: TLabel
    Left = 16
    Top = 64
    Width = 52
    Height = 13
    Caption = 'Information'
  end
  object Label66: TLabel
    Left = 240
    Top = 16
    Width = 25
    Height = 13
    Caption = 'bytes'
  end
  object btnSaveToEEProm: TBitBtn
    Left = 256
    Top = 640
    Width = 131
    Height = 25
    Caption = 'Save To EEProm'
    Default = True
    Glyph.Data = {
      DE010000424DDE01000000000000760000002800000024000000120000000100
      0400000000006801000000000000000000001000000000000000000000000000
      80000080000000808000800000008000800080800000C0C0C000808080000000
      FF0000FF000000FFFF00FF000000FF00FF00FFFF0000FFFFFF00333333333333
      3333333333333333333333330000333333333333333333333333F33333333333
      00003333344333333333333333388F3333333333000033334224333333333333
      338338F3333333330000333422224333333333333833338F3333333300003342
      222224333333333383333338F3333333000034222A22224333333338F338F333
      8F33333300003222A3A2224333333338F3838F338F33333300003A2A333A2224
      33333338F83338F338F33333000033A33333A222433333338333338F338F3333
      0000333333333A222433333333333338F338F33300003333333333A222433333
      333333338F338F33000033333333333A222433333333333338F338F300003333
      33333333A222433333333333338F338F00003333333333333A22433333333333
      3338F38F000033333333333333A223333333333333338F830000333333333333
      333A333333333333333338330000333333333333333333333333333333333333
      0000}
    ModalResult = 1
    NumGlyphs = 2
    TabOrder = 0
    OnClick = btnSaveToEEPromClick
  end
  object btnCancel: TBitBtn
    Left = 408
    Top = 640
    Width = 113
    Height = 25
    Kind = bkCancel
    TabOrder = 1
  end
  object pcEEprom: TPageControl
    Left = 24
    Top = 96
    Width = 745
    Height = 529
    ActivePage = tsStandAlone
    TabOrder = 2
    object tsDetector: TTabSheet
      Caption = 'Detector'
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object Label4: TLabel
        Left = 16
        Top = 32
        Width = 33
        Height = 13
        Caption = 'Sensor'
      end
      object Label5: TLabel
        Left = 16
        Top = 56
        Width = 55
        Height = 13
        Caption = 'Nr Of Pixels'
      end
      object Label11: TLabel
        Left = 264
        Top = 320
        Width = 28
        Height = 13
        Caption = 'Gain1'
      end
      object Label12: TLabel
        Left = 264
        Top = 376
        Width = 34
        Height = 13
        Caption = 'Offset1'
      end
      object Label86: TLabel
        Left = 264
        Top = 344
        Width = 28
        Height = 13
        Caption = 'Gain2'
      end
      object Label87: TLabel
        Left = 264
        Top = 400
        Width = 34
        Height = 13
        Caption = 'Offset2'
      end
      object Label88: TLabel
        Left = 448
        Top = 344
        Width = 165
        Height = 13
        Caption = '(only used for SU512LDB detector)'
      end
      object Label89: TLabel
        Left = 448
        Top = 400
        Width = 165
        Height = 13
        Caption = '(only used for SU512LDB detector)'
      end
      object Ext: TLabel
        Left = 264
        Top = 432
        Width = 49
        Height = 13
        Caption = 'Ext. Offset'
      end
      object edtNrOfPixels: TEdit
        Left = 80
        Top = 48
        Width = 105
        Height = 21
        TabOrder = 0
      end
      object gbWaveLengthCalibration: TGroupBox
        Left = 16
        Top = 96
        Width = 185
        Height = 137
        Caption = 'WaveLength Calibration'
        TabOrder = 1
        object Label6: TLabel
          Left = 8
          Top = 24
          Width = 42
          Height = 13
          Caption = 'Intercept'
        end
        object Label7: TLabel
          Left = 8
          Top = 48
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object Label8: TLabel
          Left = 8
          Top = 72
          Width = 13
          Height = 13
          Caption = 'X2'
        end
        object Label9: TLabel
          Left = 8
          Top = 96
          Width = 13
          Height = 13
          Caption = 'X3'
        end
        object Label10: TLabel
          Left = 8
          Top = 120
          Width = 13
          Height = 13
          Caption = 'X4'
        end
        object edtWLX0: TEdit
          Left = 64
          Top = 16
          Width = 105
          Height = 21
          TabOrder = 0
        end
        object edtWLX1: TEdit
          Left = 64
          Top = 40
          Width = 105
          Height = 21
          TabOrder = 1
        end
        object edtWLX2: TEdit
          Left = 64
          Top = 64
          Width = 105
          Height = 21
          TabOrder = 2
        end
        object edtWLX3: TEdit
          Left = 64
          Top = 88
          Width = 105
          Height = 21
          TabOrder = 3
        end
        object edtWLX4: TEdit
          Left = 64
          Top = 112
          Width = 105
          Height = 21
          TabOrder = 4
        end
      end
      object edtGain1: TEdit
        Left = 328
        Top = 312
        Width = 105
        Height = 21
        TabOrder = 2
      end
      object edtOffset1: TEdit
        Left = 328
        Top = 368
        Width = 105
        Height = 21
        TabOrder = 3
      end
      object gbDefPixels: TGroupBox
        Left = 16
        Top = 256
        Width = 185
        Height = 209
        Caption = 'Defective Pixels'
        TabOrder = 4
        object mmDefPixels: TMemo
          Left = 64
          Top = 24
          Width = 105
          Height = 169
          ScrollBars = ssVertical
          TabOrder = 0
        end
      end
      object gbNLCalibration: TGroupBox
        Left = 264
        Top = 8
        Width = 185
        Height = 289
        Caption = 'Nonlinearity Calibration'
        TabOrder = 5
        object Label13: TLabel
          Left = 8
          Top = 24
          Width = 42
          Height = 13
          Caption = 'Intercept'
        end
        object Label14: TLabel
          Left = 8
          Top = 48
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object Label15: TLabel
          Left = 8
          Top = 72
          Width = 13
          Height = 13
          Caption = 'X2'
        end
        object Label16: TLabel
          Left = 8
          Top = 96
          Width = 13
          Height = 13
          Caption = 'X3'
        end
        object Label17: TLabel
          Left = 8
          Top = 120
          Width = 13
          Height = 13
          Caption = 'X4'
        end
        object Label18: TLabel
          Left = 8
          Top = 144
          Width = 13
          Height = 13
          Caption = 'X5'
        end
        object Label19: TLabel
          Left = 8
          Top = 168
          Width = 13
          Height = 13
          Caption = 'X6'
        end
        object Label20: TLabel
          Left = 8
          Top = 192
          Width = 13
          Height = 13
          Caption = 'X7'
        end
        object Label67: TLabel
          Left = 8
          Top = 216
          Width = 45
          Height = 13
          Caption = 'LoCounts'
        end
        object Label68: TLabel
          Left = 8
          Top = 240
          Width = 43
          Height = 13
          Caption = 'HiCounts'
        end
        object edtNLX0: TEdit
          Left = 64
          Top = 16
          Width = 105
          Height = 21
          TabOrder = 0
        end
        object edtNLX1: TEdit
          Left = 64
          Top = 40
          Width = 105
          Height = 21
          TabOrder = 1
        end
        object edtNLX2: TEdit
          Left = 64
          Top = 64
          Width = 105
          Height = 21
          TabOrder = 2
        end
        object edtNLX3: TEdit
          Left = 64
          Top = 88
          Width = 105
          Height = 21
          TabOrder = 3
        end
        object edtNLX4: TEdit
          Left = 64
          Top = 112
          Width = 105
          Height = 21
          TabOrder = 4
        end
        object edtNLX5: TEdit
          Left = 64
          Top = 136
          Width = 105
          Height = 21
          TabOrder = 5
        end
        object edtNLX6: TEdit
          Left = 64
          Top = 160
          Width = 105
          Height = 21
          TabOrder = 6
        end
        object edtNLX7: TEdit
          Left = 64
          Top = 184
          Width = 105
          Height = 21
          TabOrder = 7
        end
        object chkEnableNL: TCheckBox
          Left = 8
          Top = 264
          Width = 169
          Height = 17
          Caption = 'Enable NonLinearity Correction'
          TabOrder = 8
        end
        object edtNLLow: TEdit
          Left = 64
          Top = 208
          Width = 105
          Height = 21
          TabOrder = 9
        end
        object edtNLHigh: TEdit
          Left = 64
          Top = 232
          Width = 105
          Height = 21
          TabOrder = 10
        end
      end
      object cbDetectorType: TComboBox
        Left = 80
        Top = 24
        Width = 133
        Height = 21
        ItemHeight = 13
        TabOrder = 6
        Items.Strings = (
          'HAMS8378_256'
          'HAMS8378_1024'
          'ILX554'
          'HAMS9201'
          'TCD1304'
          'TSL1301'
          'TSL1401'
          'HAMS8378_512'
          'HAMS9840'
          'ILX511'
          'HAMS10420_2048X64'
          'HAMS11071_2048X64'
          'HAMS7031_1024X122'
          'HAMS7031_1024X58'
          'HAMS11071_2048X16'
          'HAMS11155'
          'SU256LSB'
          'SU512LDB')
      end
      object edtGain2: TEdit
        Left = 328
        Top = 336
        Width = 105
        Height = 21
        TabOrder = 7
      end
      object edtOffset2: TEdit
        Left = 328
        Top = 392
        Width = 105
        Height = 21
        TabOrder = 8
      end
      object edtExtOffset: TEdit
        Left = 328
        Top = 424
        Width = 105
        Height = 21
        TabOrder = 9
      end
    end
    object tsStandAlone: TTabSheet
      Caption = 'StandAlone'
      ImageIndex = 1
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object Label43: TLabel
        Left = 16
        Top = 432
        Width = 97
        Height = 13
        Caption = 'Nr Of Measurements'
      end
      object gbPrepareMeasSettings: TGroupBox
        Left = 16
        Top = 40
        Width = 481
        Height = 361
        Caption = 'Measurement Settings'
        TabOrder = 0
        object Label21: TLabel
          Left = 24
          Top = 20
          Width = 46
          Height = 13
          Caption = 'Start pixel'
        end
        object Label22: TLabel
          Left = 24
          Top = 44
          Width = 46
          Height = 13
          Caption = 'Stop pixel'
        end
        object Label23: TLabel
          Left = 24
          Top = 68
          Width = 72
          Height = 13
          Caption = 'Integration time'
        end
        object Label24: TLabel
          Left = 24
          Top = 92
          Width = 80
          Height = 13
          Caption = 'Integration Delay'
        end
        object Label25: TLabel
          Left = 24
          Top = 116
          Width = 96
          Height = 13
          Caption = 'Number of averages'
        end
        object Label26: TLabel
          Left = 24
          Top = 140
          Width = 95
          Height = 13
          Caption = 'Saturation detection'
        end
        object Label27: TLabel
          Left = 208
          Top = 72
          Width = 13
          Height = 13
          Caption = 'ms'
        end
        object Label28: TLabel
          Left = 208
          Top = 96
          Width = 11
          Height = 13
          Caption = 'ns'
        end
        object edtStartPixel: TEdit
          Left = 128
          Top = 16
          Width = 73
          Height = 21
          TabOrder = 0
        end
        object edtStopPixel: TEdit
          Left = 128
          Top = 40
          Width = 73
          Height = 21
          TabOrder = 1
        end
        object edtIntegrationTime: TEdit
          Left = 128
          Top = 64
          Width = 73
          Height = 21
          TabOrder = 2
        end
        object edtIntegrationDelay: TEdit
          Left = 128
          Top = 88
          Width = 73
          Height = 21
          TabOrder = 3
        end
        object edtNrOfAverages: TEdit
          Left = 128
          Top = 112
          Width = 73
          Height = 21
          TabOrder = 4
        end
        object gbTrigger: TGroupBox
          Left = 24
          Top = 168
          Width = 201
          Height = 153
          Caption = 'Trigger Settings'
          TabOrder = 5
          object Label29: TLabel
            Left = 16
            Top = 26
            Width = 62
            Height = 13
            Caption = 'Trigger mode'
          end
          object Label31: TLabel
            Left = 16
            Top = 66
            Width = 68
            Height = 13
            Caption = 'Trigger source'
          end
          object Label32: TLabel
            Left = 16
            Top = 106
            Width = 56
            Height = 13
            Caption = 'Trigger type'
          end
          object chkTrigTypeLevel: TCheckBox
            Left = 96
            Top = 120
            Width = 90
            Height = 17
            Caption = 'Level'
            TabOrder = 0
            OnClick = chkTrigTypeLevelClick
          end
          object chkTrigTypeEdge: TCheckBox
            Left = 96
            Top = 104
            Width = 90
            Height = 17
            Caption = 'Edge'
            TabOrder = 1
            OnClick = chkTrigTypeEdgeClick
          end
          object chkTrigSourceSync: TCheckBox
            Left = 96
            Top = 80
            Width = 90
            Height = 17
            Caption = 'Synchronized'
            TabOrder = 2
            OnClick = chkTrigSourceSyncClick
          end
          object chkTrigSourceExtHw: TCheckBox
            Left = 96
            Top = 64
            Width = 90
            Height = 17
            Caption = 'External'
            TabOrder = 3
            OnClick = chkTrigSourceExtHwClick
          end
          object chkTrigModeSw: TCheckBox
            Left = 96
            Top = 40
            Width = 90
            Height = 17
            Caption = 'Software'
            TabOrder = 4
            OnClick = chkTrigModeSwClick
          end
          object chkTrigModeHw: TCheckBox
            Left = 96
            Top = 24
            Width = 90
            Height = 17
            Caption = 'Hardware'
            TabOrder = 5
            OnClick = chkTrigModeHwClick
          end
        end
        object gbDarkCorrection: TGroupBox
          Left = 256
          Top = 16
          Width = 209
          Height = 73
          Caption = 'Dark Correction Settings'
          TabOrder = 6
          object Label30: TLabel
            Left = 72
            Top = 48
            Width = 11
            Height = 13
            Caption = '% '
          end
          object chkEnableDarkCorrection: TCheckBox
            Left = 8
            Top = 20
            Width = 97
            Height = 17
            Caption = 'Enable'
            TabOrder = 0
          end
          object edtDarkHist: TEdit
            Left = 8
            Top = 40
            Width = 49
            Height = 21
            TabOrder = 1
          end
        end
        object gbSmoothing: TGroupBox
          Left = 256
          Top = 96
          Width = 209
          Height = 65
          Caption = 'Smoothing Settings'
          TabOrder = 7
          object Label33: TLabel
            Left = 8
            Top = 24
            Width = 29
            Height = 13
            Caption = 'Model'
          end
          object Label34: TLabel
            Left = 8
            Top = 40
            Width = 55
            Height = 13
            Caption = 'Nr Of Pixels'
          end
          object edtSmoothModel: TEdit
            Left = 120
            Top = 16
            Width = 57
            Height = 21
            TabOrder = 0
          end
          object edtSmoothPix: TEdit
            Left = 120
            Top = 40
            Width = 57
            Height = 21
            TabOrder = 1
          end
        end
        object edtSaturationLevel: TEdit
          Left = 128
          Top = 136
          Width = 73
          Height = 21
          TabOrder = 8
        end
        object gbControl: TGroupBox
          Left = 256
          Top = 168
          Width = 209
          Height = 153
          Caption = 'Control Settings'
          TabOrder = 9
          object Label35: TLabel
            Left = 8
            Top = 20
            Width = 82
            Height = 13
            Caption = 'Flashes per Scan'
          end
          object Label36: TLabel
            Left = 8
            Top = 44
            Width = 54
            Height = 13
            Caption = 'Laser delay'
          end
          object Label37: TLabel
            Left = 8
            Top = 68
            Width = 54
            Height = 13
            Caption = 'Laser width'
          end
          object Label38: TLabel
            Left = 8
            Top = 92
            Width = 84
            Height = 13
            Caption = 'Laser wavelength'
          end
          object Label39: TLabel
            Left = 8
            Top = 116
            Width = 108
            Height = 13
            Caption = 'Spectra stored to RAM'
            Enabled = False
          end
          object Label40: TLabel
            Left = 184
            Top = 48
            Width = 11
            Height = 13
            Caption = 'ns'
          end
          object Label41: TLabel
            Left = 184
            Top = 72
            Width = 11
            Height = 13
            Caption = 'ns'
          end
          object Label42: TLabel
            Left = 184
            Top = 96
            Width = 14
            Height = 13
            Caption = 'nm'
          end
          object edtFlashesPerScan: TEdit
            Left = 120
            Top = 16
            Width = 57
            Height = 21
            TabOrder = 0
          end
          object edtLaserDelay: TEdit
            Left = 120
            Top = 40
            Width = 57
            Height = 21
            TabOrder = 1
          end
          object edtLaserWidth: TEdit
            Left = 120
            Top = 64
            Width = 57
            Height = 21
            TabOrder = 2
          end
          object edtLaserWavelength: TEdit
            Left = 120
            Top = 88
            Width = 57
            Height = 21
            TabOrder = 3
          end
          object edtRamSpectra: TEdit
            Left = 120
            Top = 112
            Width = 57
            Height = 21
            Enabled = False
            TabOrder = 4
          end
        end
      end
      object chkEnableStandAlone: TCheckBox
        Left = 16
        Top = 8
        Width = 97
        Height = 17
        Caption = 'Enable'
        TabOrder = 1
      end
      object edtNrOfMeas: TEdit
        Left = 120
        Top = 424
        Width = 65
        Height = 21
        TabOrder = 2
      end
    end
    object tsIrradianceCalibration: TTabSheet
      Caption = 'Irradiance Calibration'
      ImageIndex = 2
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object Label58: TLabel
        Left = 312
        Top = 32
        Width = 126
        Height = 13
        Caption = 'Irradiance Calibration Type'
      end
      object Label59: TLabel
        Left = 312
        Top = 112
        Width = 118
        Height = 13
        Caption = 'Irradiance Fiber Diameter'
      end
      object Label60: TLabel
        Left = 520
        Top = 112
        Width = 31
        Height = 13
        Caption = 'micron'
      end
      object edtIrradCalibrationType: TEdit
        Left = 448
        Top = 24
        Width = 65
        Height = 21
        TabOrder = 0
      end
      object edtIrradFiberDiameter: TEdit
        Left = 448
        Top = 104
        Width = 65
        Height = 21
        TabOrder = 1
      end
      object gbIrradCalibration: TGroupBox
        Left = 24
        Top = 12
        Width = 249
        Height = 433
        Caption = 'Scope to Irradiance Conversion'
        TabOrder = 2
        object Label55: TLabel
          Left = 24
          Top = 392
          Width = 49
          Height = 13
          Caption = 'Calibration'
        end
        object Label56: TLabel
          Left = 24
          Top = 408
          Width = 69
          Height = 13
          Caption = 'Integrationtime'
        end
        object Label57: TLabel
          Left = 176
          Top = 400
          Width = 13
          Height = 13
          Caption = 'ms'
        end
        object mmIrradConversion: TMemo
          Left = 24
          Top = 24
          Width = 145
          Height = 257
          ScrollBars = ssVertical
          TabOrder = 0
        end
        object gbIrradSmooth: TGroupBox
          Left = 24
          Top = 304
          Width = 169
          Height = 65
          Caption = 'Calibration Smoothing Settings'
          TabOrder = 1
          object Label53: TLabel
            Left = 8
            Top = 24
            Width = 29
            Height = 13
            Caption = 'Model'
          end
          object Label54: TLabel
            Left = 8
            Top = 40
            Width = 55
            Height = 13
            Caption = 'Nr Of Pixels'
          end
          object edtIrradSmoothModel: TEdit
            Left = 88
            Top = 16
            Width = 57
            Height = 21
            TabOrder = 0
          end
          object edtIrradSmoothPixels: TEdit
            Left = 88
            Top = 40
            Width = 57
            Height = 21
            TabOrder = 1
          end
        end
        object edtIrradInttime: TEdit
          Left = 112
          Top = 392
          Width = 57
          Height = 21
          TabOrder = 2
        end
      end
    end
    object tsReflectanceCalibration: TTabSheet
      Caption = 'Reflectance Calibration'
      ImageIndex = 3
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object gbReflectanceCalibration: TGroupBox
        Left = 24
        Top = 12
        Width = 249
        Height = 433
        Caption = 'Scope to Reflectance Conversion'
        TabOrder = 0
        object Label61: TLabel
          Left = 24
          Top = 392
          Width = 49
          Height = 13
          Caption = 'Calibration'
        end
        object Label62: TLabel
          Left = 24
          Top = 408
          Width = 69
          Height = 13
          Caption = 'Integrationtime'
        end
        object Label63: TLabel
          Left = 176
          Top = 400
          Width = 13
          Height = 13
          Caption = 'ms'
        end
        object mmReflectanceConversion: TMemo
          Left = 24
          Top = 24
          Width = 145
          Height = 257
          ScrollBars = ssVertical
          TabOrder = 0
        end
        object gbReflectanceSmooth: TGroupBox
          Left = 24
          Top = 304
          Width = 169
          Height = 65
          Caption = 'Calibration Smoothing Settings'
          TabOrder = 1
          object Label64: TLabel
            Left = 8
            Top = 24
            Width = 29
            Height = 13
            Caption = 'Model'
          end
          object Label65: TLabel
            Left = 8
            Top = 40
            Width = 55
            Height = 13
            Caption = 'Nr Of Pixels'
          end
          object edtReflectanceSmoothModel: TEdit
            Left = 88
            Top = 16
            Width = 57
            Height = 21
            TabOrder = 0
          end
          object edtReflectanceSmoothPixels: TEdit
            Left = 88
            Top = 40
            Width = 57
            Height = 21
            TabOrder = 1
          end
        end
        object edtReflectanceInttime: TEdit
          Left = 112
          Top = 392
          Width = 57
          Height = 21
          TabOrder = 2
        end
      end
    end
    object tsCorrection: TTabSheet
      Caption = 'Spectrum Correction'
      ImageIndex = 4
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object gbCorrection: TGroupBox
        Left = 24
        Top = 12
        Width = 201
        Height = 433
        Caption = 'Pixel Correction Values'
        TabOrder = 0
        object mmCorrection: TMemo
          Left = 24
          Top = 24
          Width = 145
          Height = 385
          ScrollBars = ssVertical
          TabOrder = 0
        end
      end
    end
    object tsTempSensor: TTabSheet
      Caption = 'Temperature Sensors'
      ImageIndex = 5
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object gbNTC1: TGroupBox
        Left = 32
        Top = 40
        Width = 185
        Height = 153
        Caption = 'NTC1 Calibration'
        TabOrder = 0
        object Label71: TLabel
          Left = 8
          Top = 32
          Width = 42
          Height = 13
          Caption = 'Intercept'
        end
        object Label72: TLabel
          Left = 8
          Top = 56
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object Label73: TLabel
          Left = 8
          Top = 80
          Width = 13
          Height = 13
          Caption = 'X2'
        end
        object Label74: TLabel
          Left = 8
          Top = 104
          Width = 13
          Height = 13
          Caption = 'X3'
        end
        object Label75: TLabel
          Left = 8
          Top = 128
          Width = 13
          Height = 13
          Caption = 'X4'
        end
        object edtNTC1X0: TEdit
          Left = 64
          Top = 24
          Width = 105
          Height = 21
          TabOrder = 0
        end
        object edtNTC1X1: TEdit
          Left = 64
          Top = 48
          Width = 105
          Height = 21
          TabOrder = 1
        end
        object edtNTC1X2: TEdit
          Left = 64
          Top = 72
          Width = 105
          Height = 21
          TabOrder = 2
        end
        object edtNTC1X3: TEdit
          Left = 64
          Top = 96
          Width = 105
          Height = 21
          TabOrder = 3
        end
        object edtNTC1X4: TEdit
          Left = 64
          Top = 120
          Width = 105
          Height = 21
          TabOrder = 4
        end
      end
      object gbNTC2: TGroupBox
        Left = 232
        Top = 40
        Width = 185
        Height = 153
        Caption = 'NTC2 Calibration'
        TabOrder = 1
        object Label76: TLabel
          Left = 8
          Top = 32
          Width = 42
          Height = 13
          Caption = 'Intercept'
        end
        object Label77: TLabel
          Left = 8
          Top = 56
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object Label78: TLabel
          Left = 8
          Top = 80
          Width = 13
          Height = 13
          Caption = 'X2'
        end
        object Label79: TLabel
          Left = 8
          Top = 104
          Width = 13
          Height = 13
          Caption = 'X3'
        end
        object Label80: TLabel
          Left = 8
          Top = 128
          Width = 13
          Height = 13
          Caption = 'X4'
        end
        object edtNTC2X0: TEdit
          Left = 64
          Top = 24
          Width = 105
          Height = 21
          TabOrder = 0
        end
        object edtNTC2X1: TEdit
          Left = 64
          Top = 48
          Width = 105
          Height = 21
          TabOrder = 1
        end
        object edtNTC2X2: TEdit
          Left = 64
          Top = 72
          Width = 105
          Height = 21
          TabOrder = 2
        end
        object edtNTC2X3: TEdit
          Left = 64
          Top = 96
          Width = 105
          Height = 21
          TabOrder = 3
        end
        object edtNTC2X4: TEdit
          Left = 64
          Top = 120
          Width = 105
          Height = 21
          TabOrder = 4
        end
      end
      object gbThermistor: TGroupBox
        Left = 440
        Top = 40
        Width = 185
        Height = 153
        Caption = 'Thermistor Calibration'
        TabOrder = 2
        object Label81: TLabel
          Left = 8
          Top = 32
          Width = 42
          Height = 13
          Caption = 'Intercept'
        end
        object Label82: TLabel
          Left = 8
          Top = 56
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object Label83: TLabel
          Left = 8
          Top = 80
          Width = 13
          Height = 13
          Caption = 'X2'
        end
        object Label84: TLabel
          Left = 8
          Top = 104
          Width = 13
          Height = 13
          Caption = 'X3'
        end
        object Label85: TLabel
          Left = 8
          Top = 128
          Width = 13
          Height = 13
          Caption = 'X4'
        end
        object edtThermistorX0: TEdit
          Left = 64
          Top = 24
          Width = 105
          Height = 21
          TabOrder = 0
        end
        object edtThermistorX1: TEdit
          Left = 64
          Top = 48
          Width = 105
          Height = 21
          TabOrder = 1
        end
        object edtThermistorX2: TEdit
          Left = 64
          Top = 72
          Width = 105
          Height = 21
          TabOrder = 2
        end
        object edtThermistorX3: TEdit
          Left = 64
          Top = 96
          Width = 105
          Height = 21
          TabOrder = 3
        end
        object edtThermistorX4: TEdit
          Left = 64
          Top = 120
          Width = 105
          Height = 21
          TabOrder = 4
        end
      end
    end
    object tsTecControl: TTabSheet
      Caption = 'Tec Control'
      ImageIndex = 6
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object Label90: TLabel
        Left = 136
        Top = 64
        Width = 43
        Height = 13
        Caption = 'degree C'
      end
      object Label70: TLabel
        Left = 16
        Top = 64
        Width = 40
        Height = 13
        Caption = 'SetPoint'
      end
      object chkEnableTec: TCheckBox
        Left = 16
        Top = 24
        Width = 97
        Height = 17
        Caption = 'Enable'
        TabOrder = 0
      end
      object edtSetPoint: TEdit
        Left = 72
        Top = 56
        Width = 57
        Height = 21
        TabOrder = 1
      end
      object GroupBox1: TGroupBox
        Left = 16
        Top = 96
        Width = 169
        Height = 105
        Caption = 'DAC Coefficients'
        TabOrder = 2
        object Label91: TLabel
          Left = 16
          Top = 28
          Width = 13
          Height = 13
          Caption = 'X0'
        end
        object Label92: TLabel
          Left = 16
          Top = 57
          Width = 13
          Height = 13
          Caption = 'X1'
        end
        object edtTecX0: TEdit
          Left = 56
          Top = 24
          Width = 57
          Height = 21
          TabOrder = 0
        end
        object edtTecX1: TEdit
          Left = 56
          Top = 56
          Width = 57
          Height = 21
          TabOrder = 1
        end
      end
    end
    object tsEthernet: TTabSheet
      Caption = 'Ethernet Settings'
      ImageIndex = 7
      ExplicitLeft = 0
      ExplicitTop = 0
      ExplicitWidth = 0
      ExplicitHeight = 0
      object GroupBox2: TGroupBox
        Left = 19
        Top = 16
        Width = 302
        Height = 201
        Caption = 'Ethernet Settings'
        TabOrder = 0
        object Label69: TLabel
          Left = 45
          Top = 35
          Width = 51
          Height = 13
          Caption = 'IP Address'
        end
        object Label93: TLabel
          Left = 45
          Top = 62
          Width = 46
          Height = 13
          Caption = 'Net Mask'
        end
        object Label94: TLabel
          Left = 45
          Top = 89
          Width = 42
          Height = 13
          Caption = 'Gateway'
        end
        object Label95: TLabel
          Left = 45
          Top = 116
          Width = 43
          Height = 13
          Caption = 'TCP Port'
        end
        object EdtIpAddress: TEdit
          Left = 133
          Top = 32
          Width = 89
          Height = 21
          TabOrder = 0
        end
        object EdtNetMask: TEdit
          Left = 133
          Top = 59
          Width = 89
          Height = 21
          TabOrder = 1
        end
        object EdtGateway: TEdit
          Left = 133
          Top = 86
          Width = 89
          Height = 21
          TabOrder = 2
        end
        object EdtTcpPort: TEdit
          Left = 133
          Top = 113
          Width = 89
          Height = 21
          TabOrder = 3
        end
        object ChkDhcpEnabled: TCheckBox
          Left = 45
          Top = 140
          Width = 104
          Height = 17
          Alignment = taLeftJustify
          Caption = 'DHCP Enabled'
          TabOrder = 4
        end
        object ChkLinkStatus: TCheckBox
          Left = 45
          Top = 163
          Width = 104
          Height = 17
          Alignment = taLeftJustify
          Caption = 'Link Status'
          TabOrder = 5
        end
      end
    end
  end
  object edtLength: TEdit
    Left = 104
    Top = 8
    Width = 121
    Height = 21
    Color = clBtnFace
    ReadOnly = True
    TabOrder = 3
  end
  object edtVersion: TEdit
    Left = 104
    Top = 32
    Width = 121
    Height = 21
    Color = clBtnFace
    ReadOnly = True
    TabOrder = 4
  end
  object edtUserFriendly: TEdit
    Left = 104
    Top = 56
    Width = 625
    Height = 21
    MaxLength = 64
    TabOrder = 5
  end
end

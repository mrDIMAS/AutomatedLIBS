object Form1: TForm1
  Left = 316
  Top = 263
  Width = 1026
  Height = 758
  Caption = 'MainForm'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  Menu = MainMenu1
  OldCreateOrder = False
  OnClose = FormClose
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object btnCommunication: TButton
    Left = 8
    Top = 16
    Width = 121
    Height = 25
    Caption = 'Open Communication'
    TabOrder = 0
    OnClick = btnCommunicationClick
  end
  object StatusBar1: TStatusBar
    Left = 0
    Top = 701
    Width = 1010
    Height = 19
    Panels = <
      item
        Width = 200
      end
      item
        Width = 200
      end
      item
        Width = 200
      end>
    SimplePanel = False
  end
  object sgShowList: TStringGrid
    Left = 8
    Top = 80
    Width = 300
    Height = 209
    ColCount = 2
    DefaultRowHeight = 16
    FixedCols = 0
    RowCount = 25
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRowSelect]
    TabOrder = 2
    OnClick = sgShowListClick
    ColWidths = (
      96
      174)
  end
  object btnUpdateList: TButton
    Left = 8
    Top = 48
    Width = 121
    Height = 25
    Caption = 'Update List'
    Enabled = False
    TabOrder = 3
    OnClick = btnUpdateListClick
  end
  object Chart1: TChart
    Left = 320
    Top = 368
    Width = 481
    Height = 313
    BackWall.Brush.Color = clWhite
    BackWall.Brush.Style = bsClear
    Legend.Visible = False
    Title.Text.Strings = (
      'Scope Values')
    Title.Visible = False
    LeftAxis.Automatic = False
    LeftAxis.AutomaticMaximum = False
    LeftAxis.AutomaticMinimum = False
    LeftAxis.ExactDateTime = False
    LeftAxis.LabelsSeparation = 1
    LeftAxis.Maximum = 16500
    LeftAxis.Minimum = -100
    View3D = False
    TabOrder = 4
    object Series1: TLineSeries
      Marks.Arrow.Visible = True
      Marks.Callout.Brush.Color = clBlack
      Marks.Callout.Arrow.Visible = True
      Marks.Visible = False
      Pointer.InflateMargins = True
      Pointer.Style = psRectangle
      Pointer.Visible = False
      XValues.Name = 'X'
      XValues.Order = loAscending
      YValues.Name = 'Y'
      YValues.Order = loNone
    end
  end
  object gbPrepareMeasSettings: TGroupBox
    Left = 320
    Top = 8
    Width = 481
    Height = 361
    Caption = 'Prepare Measurement Settings'
    TabOrder = 5
    object Label3: TLabel
      Left = 24
      Top = 20
      Width = 46
      Height = 13
      Caption = 'Start pixel'
    end
    object Label5: TLabel
      Left = 24
      Top = 44
      Width = 46
      Height = 13
      Caption = 'Stop pixel'
    end
    object Label14: TLabel
      Left = 24
      Top = 68
      Width = 72
      Height = 13
      Caption = 'Integration time'
    end
    object Label15: TLabel
      Left = 24
      Top = 92
      Width = 80
      Height = 13
      Caption = 'Integration Delay'
    end
    object Label16: TLabel
      Left = 24
      Top = 116
      Width = 96
      Height = 13
      Caption = 'Number of averages'
    end
    object Label6: TLabel
      Left = 24
      Top = 140
      Width = 95
      Height = 13
      Caption = 'Saturation detection'
    end
    object Label7: TLabel
      Left = 208
      Top = 72
      Width = 13
      Height = 13
      Caption = 'ms'
    end
    object Label8: TLabel
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
      Text = '0'
    end
    object edtStopPixel: TEdit
      Left = 128
      Top = 40
      Width = 73
      Height = 21
      TabOrder = 1
      Text = '2047'
    end
    object edtIntegrationTime: TEdit
      Left = 128
      Top = 64
      Width = 73
      Height = 21
      TabOrder = 2
      Text = '100'
    end
    object edtIntegrationDelay: TEdit
      Left = 128
      Top = 88
      Width = 73
      Height = 21
      TabOrder = 3
      Text = '0'
    end
    object edtNrOfAverages: TEdit
      Left = 128
      Top = 112
      Width = 73
      Height = 21
      TabOrder = 4
      Text = '1'
    end
    object gbTrigger: TGroupBox
      Left = 24
      Top = 168
      Width = 201
      Height = 153
      Caption = 'Trigger Settings'
      TabOrder = 5
      object Label20: TLabel
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
        Checked = True
        State = cbChecked
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
        Checked = True
        State = cbChecked
        TabOrder = 3
        OnClick = chkTrigSourceExtHwClick
      end
      object chkTrigModeSw: TCheckBox
        Left = 96
        Top = 40
        Width = 90
        Height = 17
        Caption = 'Software'
        Checked = True
        State = cbChecked
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
      Left = 264
      Top = 16
      Width = 201
      Height = 73
      Caption = 'Dark Correction Settings'
      TabOrder = 6
      object Label1: TLabel
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
        Text = '100'
      end
    end
    object gbSmoothing: TGroupBox
      Left = 264
      Top = 96
      Width = 201
      Height = 65
      Caption = 'Smoothing Settings'
      TabOrder = 7
      object Label2: TLabel
        Left = 8
        Top = 24
        Width = 29
        Height = 13
        Caption = 'Model'
      end
      object Label4: TLabel
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
        Text = '0'
      end
      object edtSmoothPix: TEdit
        Left = 120
        Top = 40
        Width = 57
        Height = 21
        TabOrder = 1
        Text = '0'
      end
    end
    object edtSaturationLevel: TEdit
      Left = 128
      Top = 136
      Width = 73
      Height = 21
      TabOrder = 8
      Text = '0'
    end
    object gbControl: TGroupBox
      Left = 264
      Top = 168
      Width = 201
      Height = 153
      Caption = 'Control Settings'
      TabOrder = 9
      object Label33: TLabel
        Left = 8
        Top = 20
        Width = 82
        Height = 13
        Caption = 'Flashes per Scan'
      end
      object Label34: TLabel
        Left = 8
        Top = 44
        Width = 54
        Height = 13
        Caption = 'Laser delay'
      end
      object Label35: TLabel
        Left = 8
        Top = 68
        Width = 54
        Height = 13
        Caption = 'Laser width'
      end
      object Label36: TLabel
        Left = 8
        Top = 92
        Width = 84
        Height = 13
        Caption = 'Laser wavelength'
      end
      object Label37: TLabel
        Left = 8
        Top = 116
        Width = 108
        Height = 13
        Caption = 'Spectra stored to RAM'
      end
      object Label9: TLabel
        Left = 184
        Top = 48
        Width = 11
        Height = 13
        Caption = 'ns'
      end
      object Label10: TLabel
        Left = 184
        Top = 72
        Width = 11
        Height = 13
        Caption = 'ns'
      end
      object Label11: TLabel
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
        Text = '0'
      end
      object edtLaserDelay: TEdit
        Left = 120
        Top = 40
        Width = 57
        Height = 21
        TabOrder = 1
        Text = '0'
      end
      object edtLaserWidth: TEdit
        Left = 120
        Top = 64
        Width = 57
        Height = 21
        TabOrder = 2
        Text = '10000'
      end
      object edtLaserWavelength: TEdit
        Left = 120
        Top = 88
        Width = 57
        Height = 21
        TabOrder = 3
        Text = '785'
      end
      object edtRamSpectra: TEdit
        Left = 120
        Top = 112
        Width = 57
        Height = 21
        TabOrder = 4
        Text = '0'
      end
    end
    object btnReadMeasFromEEProm: TButton
      Left = 24
      Top = 328
      Width = 217
      Height = 25
      Caption = 'Read Measurement Settings from EEPROM'
      Enabled = False
      TabOrder = 10
      OnClick = btnReadMeasFromEEPromClick
    end
    object btnWriteMeasToEEProm: TButton
      Left = 248
      Top = 328
      Width = 217
      Height = 25
      Caption = 'Write Measurement Settings to EEPROM'
      Enabled = False
      TabOrder = 11
      OnClick = btnWriteMeasToEEPromClick
    end
  end
  object gbOutput: TGroupBox
    Left = 824
    Top = 368
    Width = 169
    Height = 313
    Caption = 'Measurement Statistics'
    TabOrder = 6
    object Label19: TLabel
      Left = 8
      Top = 32
      Width = 78
      Height = 13
      Caption = 'Time Since Start'
    end
    object Label22: TLabel
      Left = 8
      Top = 56
      Width = 58
      Height = 13
      Caption = 'Nr Of Scans'
    end
    object Label21: TLabel
      Left = 8
      Top = 80
      Width = 64
      Height = 13
      Caption = 'Nr Of Failures'
    end
    object Label23: TLabel
      Left = 8
      Top = 104
      Width = 78
      Height = 13
      Caption = 'Avg Time /Scan'
    end
    object Label24: TLabel
      Left = 152
      Top = 104
      Width = 13
      Height = 13
      Caption = 'ms'
    end
    object Label25: TLabel
      Left = 152
      Top = 128
      Width = 13
      Height = 13
      Caption = 'ms'
    end
    object Label26: TLabel
      Left = 8
      Top = 128
      Width = 57
      Height = 13
      Caption = 'Last scan in'
    end
    object Label27: TLabel
      Left = 152
      Top = 32
      Width = 5
      Height = 13
      Caption = 's'
    end
    object edtTotalTime: TEdit
      Left = 88
      Top = 24
      Width = 65
      Height = 21
      TabOrder = 0
    end
    object edtPerformedScans: TEdit
      Left = 88
      Top = 48
      Width = 65
      Height = 21
      TabOrder = 1
    end
    object edtFailures: TEdit
      Left = 88
      Top = 72
      Width = 65
      Height = 21
      TabOrder = 2
    end
    object edtAvgTimePerScan: TEdit
      Left = 88
      Top = 96
      Width = 65
      Height = 21
      TabOrder = 3
    end
    object edtLastScanTime: TEdit
      Left = 88
      Top = 120
      Width = 65
      Height = 21
      TabOrder = 4
    end
  end
  object gbMeasure: TGroupBox
    Left = 824
    Top = 8
    Width = 169
    Height = 353
    Caption = 'Measure'
    TabOrder = 7
    object Label17: TLabel
      Left = 16
      Top = 32
      Width = 58
      Height = 13
      Caption = 'Nr Of Scans'
    end
    object Label18: TLabel
      Left = 16
      Top = 44
      Width = 57
      Height = 13
      Caption = '(-1 = infinite)'
    end
    object btnStartMeasurement: TButton
      Left = 16
      Top = 72
      Width = 137
      Height = 25
      Caption = 'Start Measurement'
      Enabled = False
      TabOrder = 0
      OnClick = btnStartMeasurementClick
    end
    object edtNrOfScans: TEdit
      Left = 80
      Top = 32
      Width = 73
      Height = 21
      TabOrder = 1
      Text = '-1'
    end
    object btnStopMeasurement: TButton
      Left = 16
      Top = 104
      Width = 137
      Height = 25
      Caption = 'Stop Measurement'
      Enabled = False
      TabOrder = 2
      OnClick = btnStopMeasurementClick
    end
    object chkPreScan: TCheckBox
      Left = 16
      Top = 160
      Width = 137
      Height = 17
      Caption = 'AvaSpec-3648 PreScan'
      TabOrder = 3
      Visible = False
      OnClick = chkPreScanClick
    end
    object rdgSetSensitivityMode: TRadioGroup
      Left = 16
      Top = 192
      Width = 145
      Height = 57
      Caption = 'Set NIR Sensitivity Mode'
      ItemIndex = 0
      Items.Strings = (
        'Low Noise'
        'High Sensitivity')
      TabOrder = 4
      Visible = False
      OnClick = rdgSetSensitivityModeClick
    end
  end
  object btnActivate: TButton
    Left = 8
    Top = 304
    Width = 129
    Height = 25
    Caption = 'Activate'
    Enabled = False
    TabOrder = 8
    OnClick = btnActivateClick
  end
  object btnDeactivate: TButton
    Left = 8
    Top = 336
    Width = 129
    Height = 25
    Caption = 'Deactivate'
    Enabled = False
    TabOrder = 9
    OnClick = btnDeactivateClick
  end
  object gbInfo: TGroupBox
    Left = 8
    Top = 376
    Width = 265
    Height = 161
    Caption = 'Selected Device Info'
    TabOrder = 10
    object Label12: TLabel
      Left = 4
      Top = 24
      Width = 41
      Height = 13
      Caption = 'Detector'
    end
    object Label13: TLabel
      Left = 4
      Top = 48
      Width = 55
      Height = 13
      Caption = 'Nr Of Pixels'
    end
    object Label28: TLabel
      Left = 4
      Top = 80
      Width = 66
      Height = 13
      Caption = 'FPGA Version'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
    end
    object Label29: TLabel
      Left = 4
      Top = 103
      Width = 96
      Height = 13
      Caption = 'AS5216 FW Version'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
    end
    object Label30: TLabel
      Left = 4
      Top = 128
      Width = 99
      Height = 13
      Caption = 'AS5216 DLL Version'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'MS Sans Serif'
      Font.Style = []
      ParentFont = False
    end
    object edtDetectorname: TEdit
      Left = 110
      Top = 16
      Width = 140
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 0
    end
    object edtNrOfPixels: TEdit
      Left = 110
      Top = 40
      Width = 140
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 1
    end
    object edtFPGAver: TEdit
      Left = 110
      Top = 72
      Width = 140
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 2
    end
    object edtFWver: TEdit
      Left = 110
      Top = 96
      Width = 140
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 3
    end
    object edtDLLver: TEdit
      Left = 110
      Top = 120
      Width = 140
      Height = 21
      Color = clBtnFace
      ReadOnly = True
      TabOrder = 4
    end
  end
  object chkDisableGraph: TCheckBox
    Left = 320
    Top = 672
    Width = 145
    Height = 17
    Caption = 'Disable Graphical Output'
    TabOrder = 11
    OnClick = chkDisableGraphClick
  end
  object btnDigIO: TButton
    Left = 8
    Top = 560
    Width = 129
    Height = 25
    Caption = 'Digital IO...'
    Enabled = False
    TabOrder = 12
    OnClick = btnDigIOClick
  end
  object btnAnIO: TButton
    Left = 8
    Top = 592
    Width = 129
    Height = 25
    Caption = 'Analog IO...'
    Enabled = False
    TabOrder = 13
    OnClick = btnAnIOClick
  end
  object btnShowEEProm: TButton
    Left = 8
    Top = 632
    Width = 129
    Height = 25
    Caption = 'Show EEProm parameters'
    Enabled = False
    TabOrder = 14
    OnClick = btnShowEEPromClick
  end
  object MainMenu1: TMainMenu
    Left = 8
    Top = 32
  end
end

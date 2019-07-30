object Form1: TForm1
  Left = 225
  Top = 126
  Width = 742
  Height = 496
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object Chart1: TChart
    Left = 200
    Top = 64
    Width = 505
    Height = 377
    BackWall.Brush.Color = clWhite
    BackWall.Brush.Style = bsClear
    Title.Text.Strings = (
      'TChart')
    TabOrder = 0
    object Series1: TFastLineSeries
      Marks.ArrowLength = 8
      Marks.Visible = False
      SeriesColor = clRed
      LinePen.Color = clRed
      XValues.DateTime = False
      XValues.Name = 'X'
      XValues.Multiplier = 1
      XValues.Order = loAscending
      YValues.DateTime = False
      YValues.Name = 'Y'
      YValues.Multiplier = 1
      YValues.Order = loNone
    end
  end
  object OpenCommButton: TBitBtn
    Left = 24
    Top = 64
    Width = 153
    Height = 25
    Caption = 'Open Communication'
    TabOrder = 1
    OnClick = OpenCommButtonClick
  end
  object CloseCommButton: TBitBtn
    Left = 24
    Top = 104
    Width = 153
    Height = 25
    Caption = 'Close Communication'
    TabOrder = 2
    OnClick = CloseCommButtonClick
  end
  object GroupBox1: TGroupBox
    Left = 24
    Top = 160
    Width = 153
    Height = 185
    Caption = 'Measurement Parameters'
    TabOrder = 3
    object Label1: TLabel
      Left = 16
      Top = 32
      Width = 98
      Height = 13
      Caption = 'Integration Time [ms]'
    end
    object Label2: TLabel
      Left = 16
      Top = 80
      Width = 97
      Height = 13
      Caption = 'Number of Averages'
    end
    object Label3: TLabel
      Left = 16
      Top = 128
      Width = 121
      Height = 13
      Caption = 'Number of Measurements'
    end
    object EdtIntTime: TEdit
      Left = 16
      Top = 52
      Width = 57
      Height = 21
      TabOrder = 0
    end
    object EdtAvg: TEdit
      Left = 16
      Top = 100
      Width = 57
      Height = 21
      TabOrder = 1
    end
    object EdtNrms: TEdit
      Left = 16
      Top = 148
      Width = 57
      Height = 21
      TabOrder = 2
    end
  end
  object StartMeasBtn: TButton
    Left = 24
    Top = 376
    Width = 153
    Height = 25
    Caption = 'Start Measurements'
    TabOrder = 4
    OnClick = StartMeasBtnClick
  end
  object StopMeasBtn: TButton
    Left = 24
    Top = 416
    Width = 153
    Height = 25
    Caption = 'Stop Measurements'
    TabOrder = 5
    OnClick = StopMeasBtnClick
  end
end

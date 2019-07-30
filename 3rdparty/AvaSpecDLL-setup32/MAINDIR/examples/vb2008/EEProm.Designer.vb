<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EEProm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSaveToEEProm = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pcEEprom = New System.Windows.Forms.TabControl
        Me.tsDetector = New System.Windows.Forms.TabPage
        Me.cbDetectorType = New System.Windows.Forms.ComboBox
        Me.gbNLCalibration = New System.Windows.Forms.GroupBox
        Me.chkEnableNL = New System.Windows.Forms.CheckBox
        Me.edtNLHigh = New System.Windows.Forms.TextBox
        Me.edtNLLow = New System.Windows.Forms.TextBox
        Me.edtNLX7 = New System.Windows.Forms.TextBox
        Me.edtNLX6 = New System.Windows.Forms.TextBox
        Me.edtNLX5 = New System.Windows.Forms.TextBox
        Me.edtNLX4 = New System.Windows.Forms.TextBox
        Me.edtNLX3 = New System.Windows.Forms.TextBox
        Me.edtNLX2 = New System.Windows.Forms.TextBox
        Me.edtNLX1 = New System.Windows.Forms.TextBox
        Me.edtNLX0 = New System.Windows.Forms.TextBox
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.gbDefPixels = New System.Windows.Forms.GroupBox
        Me.tbDefPixels = New System.Windows.Forms.TextBox
        Me.edtExtOffset = New System.Windows.Forms.TextBox
        Me.edtOffset2 = New System.Windows.Forms.TextBox
        Me.edtOffset1 = New System.Windows.Forms.TextBox
        Me.edtGain2 = New System.Windows.Forms.TextBox
        Me.edtGain1 = New System.Windows.Forms.TextBox
        Me.gbWaveLengthCalibration = New System.Windows.Forms.GroupBox
        Me.edtWLX4 = New System.Windows.Forms.TextBox
        Me.edtWLX3 = New System.Windows.Forms.TextBox
        Me.edtWLX2 = New System.Windows.Forms.TextBox
        Me.edtWLX1 = New System.Windows.Forms.TextBox
        Me.edtWLX0 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.edtNrOfPixels = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tsStandAlone = New System.Windows.Forms.TabPage
        Me.edtNrOfMeas = New System.Windows.Forms.TextBox
        Me.chkEnableStandAlone = New System.Windows.Forms.CheckBox
        Me.gbPrepareMeasSettings = New System.Windows.Forms.GroupBox
        Me.gbControl = New System.Windows.Forms.GroupBox
        Me.edtRamSpectra = New System.Windows.Forms.TextBox
        Me.edtLaserWavelength = New System.Windows.Forms.TextBox
        Me.edtLaserWidth = New System.Windows.Forms.TextBox
        Me.edtLaserDelay = New System.Windows.Forms.TextBox
        Me.edtFlashesPerScan = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.gbSmoothing = New System.Windows.Forms.GroupBox
        Me.edtSmoothPix = New System.Windows.Forms.TextBox
        Me.edtSmoothModel = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.gbDarkCorrection = New System.Windows.Forms.GroupBox
        Me.edtDarkHist = New System.Windows.Forms.TextBox
        Me.chkEnableDarkCorrection = New System.Windows.Forms.CheckBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.gbTrigger = New System.Windows.Forms.GroupBox
        Me.chkTrigModeHw = New System.Windows.Forms.CheckBox
        Me.chkTrigModeSw = New System.Windows.Forms.CheckBox
        Me.chkTrigSourceExtHw = New System.Windows.Forms.CheckBox
        Me.chkTrigSourceSync = New System.Windows.Forms.CheckBox
        Me.chkTrigTypeEdge = New System.Windows.Forms.CheckBox
        Me.chkTrigTypeLevel = New System.Windows.Forms.CheckBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.edtSaturationLevel = New System.Windows.Forms.TextBox
        Me.edtNrOfAverages = New System.Windows.Forms.TextBox
        Me.edtIntegrationDelay = New System.Windows.Forms.TextBox
        Me.edtIntegrationTime = New System.Windows.Forms.TextBox
        Me.edtStopPixel = New System.Windows.Forms.TextBox
        Me.edtStartPixel = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.tsIrradianceCalibration = New System.Windows.Forms.TabPage
        Me.gbIrradCalibration = New System.Windows.Forms.GroupBox
        Me.mmIrradConversion = New System.Windows.Forms.TextBox
        Me.gbIrradSmooth = New System.Windows.Forms.GroupBox
        Me.edtIrradSmoothPixels = New System.Windows.Forms.TextBox
        Me.edtIrradSmoothModel = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.edtIrradInttime = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.edtIrradFiberDiameter = New System.Windows.Forms.TextBox
        Me.edtIrradCalibrationType = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.tsReflectanceCalibration = New System.Windows.Forms.TabPage
        Me.gbReflectanceCalibration = New System.Windows.Forms.GroupBox
        Me.mmReflectanceConversion = New System.Windows.Forms.TextBox
        Me.gbReflectanceSmooth = New System.Windows.Forms.GroupBox
        Me.edtReflectanceSmoothPixels = New System.Windows.Forms.TextBox
        Me.edtReflectanceSmoothModel = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.edtReflectanceInttime = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.tsCorrection = New System.Windows.Forms.TabPage
        Me.gbCorrection = New System.Windows.Forms.GroupBox
        Me.mmCorrection = New System.Windows.Forms.TextBox
        Me.tsTempSensor = New System.Windows.Forms.TabPage
        Me.gbThermistor = New System.Windows.Forms.GroupBox
        Me.edtThermistorX4 = New System.Windows.Forms.TextBox
        Me.edtThermistorX3 = New System.Windows.Forms.TextBox
        Me.edtThermistorX2 = New System.Windows.Forms.TextBox
        Me.edtThermistorX1 = New System.Windows.Forms.TextBox
        Me.edtThermistorX0 = New System.Windows.Forms.TextBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.gbNTC2 = New System.Windows.Forms.GroupBox
        Me.edtNTC2X4 = New System.Windows.Forms.TextBox
        Me.edtNTC2X3 = New System.Windows.Forms.TextBox
        Me.edtNTC2X2 = New System.Windows.Forms.TextBox
        Me.edtNTC2X1 = New System.Windows.Forms.TextBox
        Me.edtNTC2X0 = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.gbNTC1 = New System.Windows.Forms.GroupBox
        Me.edtNTC1X4 = New System.Windows.Forms.TextBox
        Me.edtNTC1X3 = New System.Windows.Forms.TextBox
        Me.edtNTC1X2 = New System.Windows.Forms.TextBox
        Me.edtNTC1X1 = New System.Windows.Forms.TextBox
        Me.edtNTC1X0 = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.tsTecControl = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.edtTecX1 = New System.Windows.Forms.TextBox
        Me.edtTecX0 = New System.Windows.Forms.TextBox
        Me.Label90 = New System.Windows.Forms.Label
        Me.edtSetPoint = New System.Windows.Forms.TextBox
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.chkEnableTec = New System.Windows.Forms.CheckBox
        Me.edtLength = New System.Windows.Forms.TextBox
        Me.edtVersion = New System.Windows.Forms.TextBox
        Me.edtUserFriendly = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pcEEprom.SuspendLayout()
        Me.tsDetector.SuspendLayout()
        Me.gbNLCalibration.SuspendLayout()
        Me.gbDefPixels.SuspendLayout()
        Me.gbWaveLengthCalibration.SuspendLayout()
        Me.tsStandAlone.SuspendLayout()
        Me.gbPrepareMeasSettings.SuspendLayout()
        Me.gbControl.SuspendLayout()
        Me.gbSmoothing.SuspendLayout()
        Me.gbDarkCorrection.SuspendLayout()
        Me.gbTrigger.SuspendLayout()
        Me.tsIrradianceCalibration.SuspendLayout()
        Me.gbIrradCalibration.SuspendLayout()
        Me.gbIrradSmooth.SuspendLayout()
        Me.tsReflectanceCalibration.SuspendLayout()
        Me.gbReflectanceCalibration.SuspendLayout()
        Me.gbReflectanceSmooth.SuspendLayout()
        Me.tsCorrection.SuspendLayout()
        Me.gbCorrection.SuspendLayout()
        Me.tsTempSensor.SuspendLayout()
        Me.gbThermistor.SuspendLayout()
        Me.gbNTC2.SuspendLayout()
        Me.gbNTC1.SuspendLayout()
        Me.tsTecControl.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.93295!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.06705!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSaveToEEProm, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(233, 626)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(202, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(129, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSaveToEEProm
        '
        Me.btnSaveToEEProm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveToEEProm.Location = New System.Drawing.Point(12, 3)
        Me.btnSaveToEEProm.Name = "btnSaveToEEProm"
        Me.btnSaveToEEProm.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveToEEProm.TabIndex = 0
        Me.btnSaveToEEProm.Text = "Save To EEProm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Structure Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Structure Version"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "bytes"
        '
        'pcEEprom
        '
        Me.pcEEprom.Controls.Add(Me.tsDetector)
        Me.pcEEprom.Controls.Add(Me.tsStandAlone)
        Me.pcEEprom.Controls.Add(Me.tsIrradianceCalibration)
        Me.pcEEprom.Controls.Add(Me.tsReflectanceCalibration)
        Me.pcEEprom.Controls.Add(Me.tsCorrection)
        Me.pcEEprom.Controls.Add(Me.tsTempSensor)
        Me.pcEEprom.Controls.Add(Me.tsTecControl)
        Me.pcEEprom.Location = New System.Drawing.Point(17, 106)
        Me.pcEEprom.Margin = New System.Windows.Forms.Padding(2)
        Me.pcEEprom.Name = "pcEEprom"
        Me.pcEEprom.SelectedIndex = 0
        Me.pcEEprom.Size = New System.Drawing.Size(646, 514)
        Me.pcEEprom.TabIndex = 5
        '
        'tsDetector
        '
        Me.tsDetector.Controls.Add(Me.cbDetectorType)
        Me.tsDetector.Controls.Add(Me.gbNLCalibration)
        Me.tsDetector.Controls.Add(Me.gbDefPixels)
        Me.tsDetector.Controls.Add(Me.edtExtOffset)
        Me.tsDetector.Controls.Add(Me.edtOffset2)
        Me.tsDetector.Controls.Add(Me.edtOffset1)
        Me.tsDetector.Controls.Add(Me.edtGain2)
        Me.tsDetector.Controls.Add(Me.edtGain1)
        Me.tsDetector.Controls.Add(Me.gbWaveLengthCalibration)
        Me.tsDetector.Controls.Add(Me.edtNrOfPixels)
        Me.tsDetector.Controls.Add(Me.Label12)
        Me.tsDetector.Controls.Add(Me.Label11)
        Me.tsDetector.Controls.Add(Me.Label10)
        Me.tsDetector.Controls.Add(Me.Label9)
        Me.tsDetector.Controls.Add(Me.Label8)
        Me.tsDetector.Controls.Add(Me.Label7)
        Me.tsDetector.Controls.Add(Me.Label6)
        Me.tsDetector.Controls.Add(Me.Label5)
        Me.tsDetector.Location = New System.Drawing.Point(4, 22)
        Me.tsDetector.Margin = New System.Windows.Forms.Padding(2)
        Me.tsDetector.Name = "tsDetector"
        Me.tsDetector.Padding = New System.Windows.Forms.Padding(2)
        Me.tsDetector.Size = New System.Drawing.Size(638, 488)
        Me.tsDetector.TabIndex = 0
        Me.tsDetector.Text = "Detector"
        Me.tsDetector.UseVisualStyleBackColor = True
        '
        'cbDetectorType
        '
        Me.cbDetectorType.FormattingEnabled = True
        Me.cbDetectorType.Items.AddRange(New Object() {"HAMS8378-256", "HAMS8378-1024", "ILX554", "HAMS9201", "TCD1304", "TSL1301", "TSL1401", "HAMS8378_512", "HAMS9840", "ILX511", "HAMS10420_2048X64", "HAMS11071_2048X64", "HAMS7031_1024X122", "HAMS7031_1024X58", "HAMS11071_2048X16", "HAMS11155", "SU256LSB", "SU512LDB"})
        Me.cbDetectorType.Location = New System.Drawing.Point(81, 30)
        Me.cbDetectorType.Margin = New System.Windows.Forms.Padding(2)
        Me.cbDetectorType.MaxDropDownItems = 15
        Me.cbDetectorType.Name = "cbDetectorType"
        Me.cbDetectorType.Size = New System.Drawing.Size(134, 21)
        Me.cbDetectorType.TabIndex = 7
        Me.cbDetectorType.Text = "HAMS8378-256"
        '
        'gbNLCalibration
        '
        Me.gbNLCalibration.Controls.Add(Me.chkEnableNL)
        Me.gbNLCalibration.Controls.Add(Me.edtNLHigh)
        Me.gbNLCalibration.Controls.Add(Me.edtNLLow)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX7)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX6)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX5)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX4)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX3)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX2)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX1)
        Me.gbNLCalibration.Controls.Add(Me.edtNLX0)
        Me.gbNLCalibration.Controls.Add(Me.Label88)
        Me.gbNLCalibration.Controls.Add(Me.Label87)
        Me.gbNLCalibration.Controls.Add(Me.Label25)
        Me.gbNLCalibration.Controls.Add(Me.Label24)
        Me.gbNLCalibration.Controls.Add(Me.Label23)
        Me.gbNLCalibration.Controls.Add(Me.Label22)
        Me.gbNLCalibration.Controls.Add(Me.Label21)
        Me.gbNLCalibration.Controls.Add(Me.Label20)
        Me.gbNLCalibration.Controls.Add(Me.Label19)
        Me.gbNLCalibration.Controls.Add(Me.Label18)
        Me.gbNLCalibration.Location = New System.Drawing.Point(244, 8)
        Me.gbNLCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.gbNLCalibration.Name = "gbNLCalibration"
        Me.gbNLCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.gbNLCalibration.Size = New System.Drawing.Size(212, 299)
        Me.gbNLCalibration.TabIndex = 6
        Me.gbNLCalibration.TabStop = False
        Me.gbNLCalibration.Text = "Nonlinearity Calibration"
        '
        'chkEnableNL
        '
        Me.chkEnableNL.AutoSize = True
        Me.chkEnableNL.Location = New System.Drawing.Point(5, 279)
        Me.chkEnableNL.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnableNL.Name = "chkEnableNL"
        Me.chkEnableNL.Size = New System.Drawing.Size(172, 17)
        Me.chkEnableNL.TabIndex = 2
        Me.chkEnableNL.Text = "Enable NonLinearity Correction"
        Me.chkEnableNL.UseVisualStyleBackColor = True
        '
        'edtNLHigh
        '
        Me.edtNLHigh.Location = New System.Drawing.Point(81, 245)
        Me.edtNLHigh.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLHigh.Name = "edtNLHigh"
        Me.edtNLHigh.Size = New System.Drawing.Size(89, 20)
        Me.edtNLHigh.TabIndex = 1
        '
        'edtNLLow
        '
        Me.edtNLLow.Location = New System.Drawing.Point(81, 221)
        Me.edtNLLow.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLLow.Name = "edtNLLow"
        Me.edtNLLow.Size = New System.Drawing.Size(89, 20)
        Me.edtNLLow.TabIndex = 1
        '
        'edtNLX7
        '
        Me.edtNLX7.Location = New System.Drawing.Point(59, 190)
        Me.edtNLX7.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX7.Name = "edtNLX7"
        Me.edtNLX7.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX7.TabIndex = 1
        '
        'edtNLX6
        '
        Me.edtNLX6.Location = New System.Drawing.Point(59, 166)
        Me.edtNLX6.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX6.Name = "edtNLX6"
        Me.edtNLX6.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX6.TabIndex = 1
        '
        'edtNLX5
        '
        Me.edtNLX5.Location = New System.Drawing.Point(59, 141)
        Me.edtNLX5.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX5.Name = "edtNLX5"
        Me.edtNLX5.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX5.TabIndex = 1
        '
        'edtNLX4
        '
        Me.edtNLX4.Location = New System.Drawing.Point(59, 118)
        Me.edtNLX4.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX4.Name = "edtNLX4"
        Me.edtNLX4.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX4.TabIndex = 1
        '
        'edtNLX3
        '
        Me.edtNLX3.Location = New System.Drawing.Point(59, 93)
        Me.edtNLX3.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX3.Name = "edtNLX3"
        Me.edtNLX3.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX3.TabIndex = 1
        '
        'edtNLX2
        '
        Me.edtNLX2.Location = New System.Drawing.Point(59, 69)
        Me.edtNLX2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX2.Name = "edtNLX2"
        Me.edtNLX2.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX2.TabIndex = 1
        '
        'edtNLX1
        '
        Me.edtNLX1.Location = New System.Drawing.Point(59, 46)
        Me.edtNLX1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX1.Name = "edtNLX1"
        Me.edtNLX1.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX1.TabIndex = 1
        '
        'edtNLX0
        '
        Me.edtNLX0.Location = New System.Drawing.Point(59, 23)
        Me.edtNLX0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNLX0.Name = "edtNLX0"
        Me.edtNLX0.Size = New System.Drawing.Size(95, 20)
        Me.edtNLX0.TabIndex = 1
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(8, 248)
        Me.Label88.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(73, 13)
        Me.Label88.TabIndex = 0
        Me.Label88.Text = "NL higher limit"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(8, 223)
        Me.Label87.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(69, 13)
        Me.Label87.TabIndex = 0
        Me.Label87.Text = "NL lower limit"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 193)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(20, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "X7"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 168)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(20, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "X6"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 144)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "X5"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 120)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(20, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "X4"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 96)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "X3"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 72)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(20, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "X2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 48)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "X1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 24)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Intercept"
        '
        'gbDefPixels
        '
        Me.gbDefPixels.Controls.Add(Me.tbDefPixels)
        Me.gbDefPixels.Location = New System.Drawing.Point(15, 256)
        Me.gbDefPixels.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDefPixels.Name = "gbDefPixels"
        Me.gbDefPixels.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDefPixels.Size = New System.Drawing.Size(170, 209)
        Me.gbDefPixels.TabIndex = 5
        Me.gbDefPixels.TabStop = False
        Me.gbDefPixels.Text = "Defective Pixels"
        '
        'tbDefPixels
        '
        Me.tbDefPixels.Location = New System.Drawing.Point(59, 24)
        Me.tbDefPixels.Multiline = True
        Me.tbDefPixels.Name = "tbDefPixels"
        Me.tbDefPixels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDefPixels.Size = New System.Drawing.Size(98, 157)
        Me.tbDefPixels.TabIndex = 3
        '
        'edtExtOffset
        '
        Me.edtExtOffset.Location = New System.Drawing.Point(303, 447)
        Me.edtExtOffset.Margin = New System.Windows.Forms.Padding(2)
        Me.edtExtOffset.Name = "edtExtOffset"
        Me.edtExtOffset.Size = New System.Drawing.Size(82, 20)
        Me.edtExtOffset.TabIndex = 4
        '
        'edtOffset2
        '
        Me.edtOffset2.Location = New System.Drawing.Point(302, 407)
        Me.edtOffset2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtOffset2.Name = "edtOffset2"
        Me.edtOffset2.Size = New System.Drawing.Size(82, 20)
        Me.edtOffset2.TabIndex = 4
        '
        'edtOffset1
        '
        Me.edtOffset1.Location = New System.Drawing.Point(303, 384)
        Me.edtOffset1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtOffset1.Name = "edtOffset1"
        Me.edtOffset1.Size = New System.Drawing.Size(82, 20)
        Me.edtOffset1.TabIndex = 4
        '
        'edtGain2
        '
        Me.edtGain2.Location = New System.Drawing.Point(303, 351)
        Me.edtGain2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtGain2.Name = "edtGain2"
        Me.edtGain2.Size = New System.Drawing.Size(82, 20)
        Me.edtGain2.TabIndex = 4
        '
        'edtGain1
        '
        Me.edtGain1.Location = New System.Drawing.Point(303, 327)
        Me.edtGain1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtGain1.Name = "edtGain1"
        Me.edtGain1.Size = New System.Drawing.Size(82, 20)
        Me.edtGain1.TabIndex = 4
        '
        'gbWaveLengthCalibration
        '
        Me.gbWaveLengthCalibration.Controls.Add(Me.edtWLX4)
        Me.gbWaveLengthCalibration.Controls.Add(Me.edtWLX3)
        Me.gbWaveLengthCalibration.Controls.Add(Me.edtWLX2)
        Me.gbWaveLengthCalibration.Controls.Add(Me.edtWLX1)
        Me.gbWaveLengthCalibration.Controls.Add(Me.edtWLX0)
        Me.gbWaveLengthCalibration.Controls.Add(Me.Label17)
        Me.gbWaveLengthCalibration.Controls.Add(Me.Label16)
        Me.gbWaveLengthCalibration.Controls.Add(Me.Label15)
        Me.gbWaveLengthCalibration.Controls.Add(Me.Label14)
        Me.gbWaveLengthCalibration.Controls.Add(Me.Label13)
        Me.gbWaveLengthCalibration.Location = New System.Drawing.Point(15, 96)
        Me.gbWaveLengthCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.gbWaveLengthCalibration.Name = "gbWaveLengthCalibration"
        Me.gbWaveLengthCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.gbWaveLengthCalibration.Size = New System.Drawing.Size(170, 148)
        Me.gbWaveLengthCalibration.TabIndex = 3
        Me.gbWaveLengthCalibration.TabStop = False
        Me.gbWaveLengthCalibration.Text = "WaveLength Calibration"
        '
        'edtWLX4
        '
        Me.edtWLX4.Location = New System.Drawing.Point(59, 115)
        Me.edtWLX4.Margin = New System.Windows.Forms.Padding(2)
        Me.edtWLX4.Name = "edtWLX4"
        Me.edtWLX4.Size = New System.Drawing.Size(98, 20)
        Me.edtWLX4.TabIndex = 1
        '
        'edtWLX3
        '
        Me.edtWLX3.Location = New System.Drawing.Point(59, 92)
        Me.edtWLX3.Margin = New System.Windows.Forms.Padding(2)
        Me.edtWLX3.Name = "edtWLX3"
        Me.edtWLX3.Size = New System.Drawing.Size(98, 20)
        Me.edtWLX3.TabIndex = 1
        '
        'edtWLX2
        '
        Me.edtWLX2.Location = New System.Drawing.Point(59, 70)
        Me.edtWLX2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtWLX2.Name = "edtWLX2"
        Me.edtWLX2.Size = New System.Drawing.Size(98, 20)
        Me.edtWLX2.TabIndex = 1
        '
        'edtWLX1
        '
        Me.edtWLX1.Location = New System.Drawing.Point(59, 45)
        Me.edtWLX1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtWLX1.Name = "edtWLX1"
        Me.edtWLX1.Size = New System.Drawing.Size(98, 20)
        Me.edtWLX1.TabIndex = 1
        '
        'edtWLX0
        '
        Me.edtWLX0.Location = New System.Drawing.Point(59, 22)
        Me.edtWLX0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtWLX0.Name = "edtWLX0"
        Me.edtWLX0.Size = New System.Drawing.Size(98, 20)
        Me.edtWLX0.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 120)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "X4"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 96)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "X3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 72)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "X2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 47)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "X1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Intercept"
        '
        'edtNrOfPixels
        '
        Me.edtNrOfPixels.Location = New System.Drawing.Point(81, 56)
        Me.edtNrOfPixels.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfPixels.Name = "edtNrOfPixels"
        Me.edtNrOfPixels.Size = New System.Drawing.Size(134, 20)
        Me.edtNrOfPixels.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(244, 449)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Ext. Offset"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(387, 410)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "(only used for HAMS9201 detector)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(387, 385)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "(only used for HAMS9201 detector)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(244, 410)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Offset2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 385)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Offset1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 353)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Gain2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 329)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Gain1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nr Of Pixels"
        '
        'tsStandAlone
        '
        Me.tsStandAlone.Controls.Add(Me.edtNrOfMeas)
        Me.tsStandAlone.Controls.Add(Me.chkEnableStandAlone)
        Me.tsStandAlone.Controls.Add(Me.gbPrepareMeasSettings)
        Me.tsStandAlone.Controls.Add(Me.Label26)
        Me.tsStandAlone.Location = New System.Drawing.Point(4, 22)
        Me.tsStandAlone.Margin = New System.Windows.Forms.Padding(2)
        Me.tsStandAlone.Name = "tsStandAlone"
        Me.tsStandAlone.Padding = New System.Windows.Forms.Padding(2)
        Me.tsStandAlone.Size = New System.Drawing.Size(638, 488)
        Me.tsStandAlone.TabIndex = 1
        Me.tsStandAlone.Text = "StandAlone"
        Me.tsStandAlone.UseVisualStyleBackColor = True
        '
        'edtNrOfMeas
        '
        Me.edtNrOfMeas.Location = New System.Drawing.Point(124, 430)
        Me.edtNrOfMeas.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfMeas.Name = "edtNrOfMeas"
        Me.edtNrOfMeas.Size = New System.Drawing.Size(73, 20)
        Me.edtNrOfMeas.TabIndex = 3
        '
        'chkEnableStandAlone
        '
        Me.chkEnableStandAlone.AutoSize = True
        Me.chkEnableStandAlone.Location = New System.Drawing.Point(15, 8)
        Me.chkEnableStandAlone.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnableStandAlone.Name = "chkEnableStandAlone"
        Me.chkEnableStandAlone.Size = New System.Drawing.Size(59, 17)
        Me.chkEnableStandAlone.TabIndex = 2
        Me.chkEnableStandAlone.Text = "Enable"
        Me.chkEnableStandAlone.UseVisualStyleBackColor = True
        '
        'gbPrepareMeasSettings
        '
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbControl)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbSmoothing)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbDarkCorrection)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbTrigger)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtSaturationLevel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtNrOfAverages)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtIntegrationDelay)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtIntegrationTime)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtStopPixel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtStartPixel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label32)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label31)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label34)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label30)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label33)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label29)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label28)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label27)
        Me.gbPrepareMeasSettings.Location = New System.Drawing.Point(15, 40)
        Me.gbPrepareMeasSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.gbPrepareMeasSettings.Name = "gbPrepareMeasSettings"
        Me.gbPrepareMeasSettings.Padding = New System.Windows.Forms.Padding(2)
        Me.gbPrepareMeasSettings.Size = New System.Drawing.Size(444, 362)
        Me.gbPrepareMeasSettings.TabIndex = 1
        Me.gbPrepareMeasSettings.TabStop = False
        Me.gbPrepareMeasSettings.Text = "Measurement Settings"
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.edtRamSpectra)
        Me.gbControl.Controls.Add(Me.edtLaserWavelength)
        Me.gbControl.Controls.Add(Me.edtLaserWidth)
        Me.gbControl.Controls.Add(Me.edtLaserDelay)
        Me.gbControl.Controls.Add(Me.edtFlashesPerScan)
        Me.gbControl.Controls.Add(Me.Label47)
        Me.gbControl.Controls.Add(Me.Label44)
        Me.gbControl.Controls.Add(Me.Label43)
        Me.gbControl.Controls.Add(Me.Label42)
        Me.gbControl.Controls.Add(Me.Label48)
        Me.gbControl.Controls.Add(Me.Label46)
        Me.gbControl.Controls.Add(Me.Label45)
        Me.gbControl.Controls.Add(Me.Label41)
        Me.gbControl.Location = New System.Drawing.Point(236, 168)
        Me.gbControl.Margin = New System.Windows.Forms.Padding(2)
        Me.gbControl.Name = "gbControl"
        Me.gbControl.Padding = New System.Windows.Forms.Padding(2)
        Me.gbControl.Size = New System.Drawing.Size(192, 153)
        Me.gbControl.TabIndex = 5
        Me.gbControl.TabStop = False
        Me.gbControl.Text = "Control Settings"
        '
        'edtRamSpectra
        '
        Me.edtRamSpectra.Enabled = False
        Me.edtRamSpectra.Location = New System.Drawing.Point(125, 114)
        Me.edtRamSpectra.Margin = New System.Windows.Forms.Padding(2)
        Me.edtRamSpectra.Name = "edtRamSpectra"
        Me.edtRamSpectra.Size = New System.Drawing.Size(42, 20)
        Me.edtRamSpectra.TabIndex = 1
        '
        'edtLaserWavelength
        '
        Me.edtLaserWavelength.Location = New System.Drawing.Point(100, 89)
        Me.edtLaserWavelength.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserWavelength.Name = "edtLaserWavelength"
        Me.edtLaserWavelength.Size = New System.Drawing.Size(66, 20)
        Me.edtLaserWavelength.TabIndex = 1
        '
        'edtLaserWidth
        '
        Me.edtLaserWidth.Location = New System.Drawing.Point(100, 66)
        Me.edtLaserWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserWidth.Name = "edtLaserWidth"
        Me.edtLaserWidth.Size = New System.Drawing.Size(66, 20)
        Me.edtLaserWidth.TabIndex = 1
        '
        'edtLaserDelay
        '
        Me.edtLaserDelay.Location = New System.Drawing.Point(100, 41)
        Me.edtLaserDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserDelay.Name = "edtLaserDelay"
        Me.edtLaserDelay.Size = New System.Drawing.Size(66, 20)
        Me.edtLaserDelay.TabIndex = 1
        '
        'edtFlashesPerScan
        '
        Me.edtFlashesPerScan.Location = New System.Drawing.Point(100, 18)
        Me.edtFlashesPerScan.Margin = New System.Windows.Forms.Padding(2)
        Me.edtFlashesPerScan.Name = "edtFlashesPerScan"
        Me.edtFlashesPerScan.Size = New System.Drawing.Size(66, 20)
        Me.edtFlashesPerScan.TabIndex = 1
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Enabled = False
        Me.Label47.Location = New System.Drawing.Point(8, 116)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(115, 13)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "Spectra stored to RAM"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(8, 92)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(91, 13)
        Me.Label44.TabIndex = 0
        Me.Label44.Text = "Laser wavelength"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 68)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(61, 13)
        Me.Label43.TabIndex = 0
        Me.Label43.Text = "Laser width"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(8, 44)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(61, 13)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "Laser delay"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(170, 92)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(21, 13)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "nm"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(170, 68)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(18, 13)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "ns"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(170, 44)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(18, 13)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "ns"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(8, 20)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(89, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Flashes per Scan"
        '
        'gbSmoothing
        '
        Me.gbSmoothing.Controls.Add(Me.edtSmoothPix)
        Me.gbSmoothing.Controls.Add(Me.edtSmoothModel)
        Me.gbSmoothing.Controls.Add(Me.Label40)
        Me.gbSmoothing.Controls.Add(Me.Label39)
        Me.gbSmoothing.Location = New System.Drawing.Point(236, 96)
        Me.gbSmoothing.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSmoothing.Name = "gbSmoothing"
        Me.gbSmoothing.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSmoothing.Size = New System.Drawing.Size(193, 65)
        Me.gbSmoothing.TabIndex = 4
        Me.gbSmoothing.TabStop = False
        Me.gbSmoothing.Text = "Smoothing Settings"
        '
        'edtSmoothPix
        '
        Me.edtSmoothPix.Location = New System.Drawing.Point(74, 41)
        Me.edtSmoothPix.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSmoothPix.Name = "edtSmoothPix"
        Me.edtSmoothPix.Size = New System.Drawing.Size(56, 20)
        Me.edtSmoothPix.TabIndex = 1
        '
        'edtSmoothModel
        '
        Me.edtSmoothModel.Location = New System.Drawing.Point(74, 18)
        Me.edtSmoothModel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSmoothModel.Name = "edtSmoothModel"
        Me.edtSmoothModel.Size = New System.Drawing.Size(56, 20)
        Me.edtSmoothModel.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 44)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(62, 13)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Nr Of Pixels"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(8, 20)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(36, 13)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Model"
        '
        'gbDarkCorrection
        '
        Me.gbDarkCorrection.Controls.Add(Me.edtDarkHist)
        Me.gbDarkCorrection.Controls.Add(Me.chkEnableDarkCorrection)
        Me.gbDarkCorrection.Controls.Add(Me.Label38)
        Me.gbDarkCorrection.Location = New System.Drawing.Point(236, 16)
        Me.gbDarkCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDarkCorrection.Name = "gbDarkCorrection"
        Me.gbDarkCorrection.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDarkCorrection.Size = New System.Drawing.Size(193, 73)
        Me.gbDarkCorrection.TabIndex = 3
        Me.gbDarkCorrection.TabStop = False
        Me.gbDarkCorrection.Text = "Dark Correction Settings"
        '
        'edtDarkHist
        '
        Me.edtDarkHist.Location = New System.Drawing.Point(8, 46)
        Me.edtDarkHist.Margin = New System.Windows.Forms.Padding(2)
        Me.edtDarkHist.Name = "edtDarkHist"
        Me.edtDarkHist.Size = New System.Drawing.Size(54, 20)
        Me.edtDarkHist.TabIndex = 2
        '
        'chkEnableDarkCorrection
        '
        Me.chkEnableDarkCorrection.AutoSize = True
        Me.chkEnableDarkCorrection.Location = New System.Drawing.Point(8, 20)
        Me.chkEnableDarkCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnableDarkCorrection.Name = "chkEnableDarkCorrection"
        Me.chkEnableDarkCorrection.Size = New System.Drawing.Size(59, 17)
        Me.chkEnableDarkCorrection.TabIndex = 1
        Me.chkEnableDarkCorrection.Text = "Enable"
        Me.chkEnableDarkCorrection.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(67, 48)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(15, 13)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "%"
        '
        'gbTrigger
        '
        Me.gbTrigger.Controls.Add(Me.chkTrigModeHw)
        Me.gbTrigger.Controls.Add(Me.chkTrigModeSw)
        Me.gbTrigger.Controls.Add(Me.chkTrigSourceExtHw)
        Me.gbTrigger.Controls.Add(Me.chkTrigSourceSync)
        Me.gbTrigger.Controls.Add(Me.chkTrigTypeEdge)
        Me.gbTrigger.Controls.Add(Me.chkTrigTypeLevel)
        Me.gbTrigger.Controls.Add(Me.Label36)
        Me.gbTrigger.Controls.Add(Me.Label37)
        Me.gbTrigger.Controls.Add(Me.Label35)
        Me.gbTrigger.Location = New System.Drawing.Point(22, 168)
        Me.gbTrigger.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTrigger.Name = "gbTrigger"
        Me.gbTrigger.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTrigger.Size = New System.Drawing.Size(185, 153)
        Me.gbTrigger.TabIndex = 2
        Me.gbTrigger.TabStop = False
        Me.gbTrigger.Text = "Trigger Settings"
        '
        'chkTrigModeHw
        '
        Me.chkTrigModeHw.AutoSize = True
        Me.chkTrigModeHw.Location = New System.Drawing.Point(95, 25)
        Me.chkTrigModeHw.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigModeHw.Name = "chkTrigModeHw"
        Me.chkTrigModeHw.Size = New System.Drawing.Size(72, 17)
        Me.chkTrigModeHw.TabIndex = 1
        Me.chkTrigModeHw.Text = "Hardware"
        Me.chkTrigModeHw.UseVisualStyleBackColor = True
        '
        'chkTrigModeSw
        '
        Me.chkTrigModeSw.AutoSize = True
        Me.chkTrigModeSw.Location = New System.Drawing.Point(95, 43)
        Me.chkTrigModeSw.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigModeSw.Name = "chkTrigModeSw"
        Me.chkTrigModeSw.Size = New System.Drawing.Size(68, 17)
        Me.chkTrigModeSw.TabIndex = 1
        Me.chkTrigModeSw.Text = "Software"
        Me.chkTrigModeSw.UseVisualStyleBackColor = True
        '
        'chkTrigSourceExtHw
        '
        Me.chkTrigSourceExtHw.AutoSize = True
        Me.chkTrigSourceExtHw.Location = New System.Drawing.Point(95, 65)
        Me.chkTrigSourceExtHw.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigSourceExtHw.Name = "chkTrigSourceExtHw"
        Me.chkTrigSourceExtHw.Size = New System.Drawing.Size(64, 17)
        Me.chkTrigSourceExtHw.TabIndex = 1
        Me.chkTrigSourceExtHw.Text = "External"
        Me.chkTrigSourceExtHw.UseVisualStyleBackColor = True
        '
        'chkTrigSourceSync
        '
        Me.chkTrigSourceSync.AutoSize = True
        Me.chkTrigSourceSync.Location = New System.Drawing.Point(95, 83)
        Me.chkTrigSourceSync.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigSourceSync.Name = "chkTrigSourceSync"
        Me.chkTrigSourceSync.Size = New System.Drawing.Size(90, 17)
        Me.chkTrigSourceSync.TabIndex = 1
        Me.chkTrigSourceSync.Text = "Synchronized"
        Me.chkTrigSourceSync.UseVisualStyleBackColor = True
        '
        'chkTrigTypeEdge
        '
        Me.chkTrigTypeEdge.AutoSize = True
        Me.chkTrigTypeEdge.Location = New System.Drawing.Point(95, 105)
        Me.chkTrigTypeEdge.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigTypeEdge.Name = "chkTrigTypeEdge"
        Me.chkTrigTypeEdge.Size = New System.Drawing.Size(51, 17)
        Me.chkTrigTypeEdge.TabIndex = 1
        Me.chkTrigTypeEdge.Text = "Edge"
        Me.chkTrigTypeEdge.UseVisualStyleBackColor = True
        '
        'chkTrigTypeLevel
        '
        Me.chkTrigTypeLevel.AutoSize = True
        Me.chkTrigTypeLevel.Location = New System.Drawing.Point(95, 123)
        Me.chkTrigTypeLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigTypeLevel.Name = "chkTrigTypeLevel"
        Me.chkTrigTypeLevel.Size = New System.Drawing.Size(52, 17)
        Me.chkTrigTypeLevel.TabIndex = 1
        Me.chkTrigTypeLevel.Text = "Level"
        Me.chkTrigTypeLevel.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(15, 26)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Trigger mode"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(15, 106)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(63, 13)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Trigger type"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(15, 66)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "Trigger source"
        '
        'edtSaturationLevel
        '
        Me.edtSaturationLevel.Location = New System.Drawing.Point(124, 137)
        Me.edtSaturationLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSaturationLevel.Name = "edtSaturationLevel"
        Me.edtSaturationLevel.Size = New System.Drawing.Size(65, 20)
        Me.edtSaturationLevel.TabIndex = 1
        '
        'edtNrOfAverages
        '
        Me.edtNrOfAverages.Location = New System.Drawing.Point(124, 114)
        Me.edtNrOfAverages.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfAverages.Name = "edtNrOfAverages"
        Me.edtNrOfAverages.Size = New System.Drawing.Size(65, 20)
        Me.edtNrOfAverages.TabIndex = 1
        '
        'edtIntegrationDelay
        '
        Me.edtIntegrationDelay.Location = New System.Drawing.Point(124, 89)
        Me.edtIntegrationDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIntegrationDelay.Name = "edtIntegrationDelay"
        Me.edtIntegrationDelay.Size = New System.Drawing.Size(65, 20)
        Me.edtIntegrationDelay.TabIndex = 1
        '
        'edtIntegrationTime
        '
        Me.edtIntegrationTime.Location = New System.Drawing.Point(124, 66)
        Me.edtIntegrationTime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIntegrationTime.Name = "edtIntegrationTime"
        Me.edtIntegrationTime.Size = New System.Drawing.Size(65, 20)
        Me.edtIntegrationTime.TabIndex = 1
        '
        'edtStopPixel
        '
        Me.edtStopPixel.Location = New System.Drawing.Point(124, 41)
        Me.edtStopPixel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtStopPixel.Name = "edtStopPixel"
        Me.edtStopPixel.Size = New System.Drawing.Size(65, 20)
        Me.edtStopPixel.TabIndex = 1
        '
        'edtStartPixel
        '
        Me.edtStartPixel.Location = New System.Drawing.Point(124, 18)
        Me.edtStartPixel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtStartPixel.Name = "edtStartPixel"
        Me.edtStartPixel.Size = New System.Drawing.Size(65, 20)
        Me.edtStartPixel.TabIndex = 1
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(22, 140)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 13)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Saturation detection"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(22, 116)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(103, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Number of averages"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(192, 92)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(18, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "ns"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(22, 92)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(87, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Integration Delay"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(192, 68)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(20, 13)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "ms"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(22, 68)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Integration time"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(22, 44)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(53, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Stop pixel"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(22, 20)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Start pixel"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(15, 432)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Nr Of Measurements"
        '
        'tsIrradianceCalibration
        '
        Me.tsIrradianceCalibration.Controls.Add(Me.gbIrradCalibration)
        Me.tsIrradianceCalibration.Controls.Add(Me.edtIrradFiberDiameter)
        Me.tsIrradianceCalibration.Controls.Add(Me.edtIrradCalibrationType)
        Me.tsIrradianceCalibration.Controls.Add(Me.Label61)
        Me.tsIrradianceCalibration.Controls.Add(Me.Label60)
        Me.tsIrradianceCalibration.Controls.Add(Me.Label59)
        Me.tsIrradianceCalibration.Location = New System.Drawing.Point(4, 22)
        Me.tsIrradianceCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.tsIrradianceCalibration.Name = "tsIrradianceCalibration"
        Me.tsIrradianceCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.tsIrradianceCalibration.Size = New System.Drawing.Size(638, 488)
        Me.tsIrradianceCalibration.TabIndex = 2
        Me.tsIrradianceCalibration.Text = "Irradiance Calibration"
        Me.tsIrradianceCalibration.UseVisualStyleBackColor = True
        '
        'gbIrradCalibration
        '
        Me.gbIrradCalibration.Controls.Add(Me.mmIrradConversion)
        Me.gbIrradCalibration.Controls.Add(Me.gbIrradSmooth)
        Me.gbIrradCalibration.Controls.Add(Me.edtIrradInttime)
        Me.gbIrradCalibration.Controls.Add(Me.Label64)
        Me.gbIrradCalibration.Controls.Add(Me.Label63)
        Me.gbIrradCalibration.Controls.Add(Me.Label62)
        Me.gbIrradCalibration.Location = New System.Drawing.Point(22, 12)
        Me.gbIrradCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.gbIrradCalibration.Name = "gbIrradCalibration"
        Me.gbIrradCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.gbIrradCalibration.Size = New System.Drawing.Size(242, 465)
        Me.gbIrradCalibration.TabIndex = 2
        Me.gbIrradCalibration.TabStop = False
        Me.gbIrradCalibration.Text = "Scope to Irradiance Conversion"
        '
        'mmIrradConversion
        '
        Me.mmIrradConversion.Location = New System.Drawing.Point(22, 24)
        Me.mmIrradConversion.Margin = New System.Windows.Forms.Padding(2)
        Me.mmIrradConversion.Multiline = True
        Me.mmIrradConversion.Name = "mmIrradConversion"
        Me.mmIrradConversion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mmIrradConversion.Size = New System.Drawing.Size(157, 258)
        Me.mmIrradConversion.TabIndex = 3
        '
        'gbIrradSmooth
        '
        Me.gbIrradSmooth.Controls.Add(Me.edtIrradSmoothPixels)
        Me.gbIrradSmooth.Controls.Add(Me.edtIrradSmoothModel)
        Me.gbIrradSmooth.Controls.Add(Me.Label66)
        Me.gbIrradSmooth.Controls.Add(Me.Label65)
        Me.gbIrradSmooth.Location = New System.Drawing.Point(22, 304)
        Me.gbIrradSmooth.Margin = New System.Windows.Forms.Padding(2)
        Me.gbIrradSmooth.Name = "gbIrradSmooth"
        Me.gbIrradSmooth.Padding = New System.Windows.Forms.Padding(2)
        Me.gbIrradSmooth.Size = New System.Drawing.Size(190, 72)
        Me.gbIrradSmooth.TabIndex = 3
        Me.gbIrradSmooth.TabStop = False
        Me.gbIrradSmooth.Text = "Calibration Smoothing Settings"
        '
        'edtIrradSmoothPixels
        '
        Me.edtIrradSmoothPixels.Location = New System.Drawing.Point(74, 45)
        Me.edtIrradSmoothPixels.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIrradSmoothPixels.Name = "edtIrradSmoothPixels"
        Me.edtIrradSmoothPixels.Size = New System.Drawing.Size(76, 20)
        Me.edtIrradSmoothPixels.TabIndex = 1
        '
        'edtIrradSmoothModel
        '
        Me.edtIrradSmoothModel.Location = New System.Drawing.Point(74, 22)
        Me.edtIrradSmoothModel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIrradSmoothModel.Name = "edtIrradSmoothModel"
        Me.edtIrradSmoothModel.Size = New System.Drawing.Size(76, 20)
        Me.edtIrradSmoothModel.TabIndex = 1
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(8, 47)
        Me.Label66.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(62, 13)
        Me.Label66.TabIndex = 0
        Me.Label66.Text = "Nr Of Pixels"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(8, 24)
        Me.Label65.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(36, 13)
        Me.Label65.TabIndex = 0
        Me.Label65.Text = "Model"
        '
        'edtIrradInttime
        '
        Me.edtIrradInttime.Location = New System.Drawing.Point(103, 404)
        Me.edtIrradInttime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIrradInttime.Name = "edtIrradInttime"
        Me.edtIrradInttime.Size = New System.Drawing.Size(66, 20)
        Me.edtIrradInttime.TabIndex = 1
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(172, 408)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(20, 13)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "ms"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(22, 408)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(76, 13)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Integrationtime"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(22, 392)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(56, 13)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "Calibration"
        '
        'edtIrradFiberDiameter
        '
        Me.edtIrradFiberDiameter.Location = New System.Drawing.Point(418, 110)
        Me.edtIrradFiberDiameter.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIrradFiberDiameter.Name = "edtIrradFiberDiameter"
        Me.edtIrradFiberDiameter.Size = New System.Drawing.Size(61, 20)
        Me.edtIrradFiberDiameter.TabIndex = 1
        '
        'edtIrradCalibrationType
        '
        Me.edtIrradCalibrationType.Location = New System.Drawing.Point(426, 32)
        Me.edtIrradCalibrationType.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIrradCalibrationType.Name = "edtIrradCalibrationType"
        Me.edtIrradCalibrationType.Size = New System.Drawing.Size(61, 20)
        Me.edtIrradCalibrationType.TabIndex = 1
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(483, 112)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(38, 13)
        Me.Label61.TabIndex = 0
        Me.Label61.Text = "micron"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(288, 112)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(125, 13)
        Me.Label60.TabIndex = 0
        Me.Label60.Text = "Irradiance Fiber Diameter"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(288, 34)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(133, 13)
        Me.Label59.TabIndex = 0
        Me.Label59.Text = "Irradiance Calibration Type"
        '
        'tsReflectanceCalibration
        '
        Me.tsReflectanceCalibration.Controls.Add(Me.gbReflectanceCalibration)
        Me.tsReflectanceCalibration.Location = New System.Drawing.Point(4, 22)
        Me.tsReflectanceCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.tsReflectanceCalibration.Name = "tsReflectanceCalibration"
        Me.tsReflectanceCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.tsReflectanceCalibration.Size = New System.Drawing.Size(638, 488)
        Me.tsReflectanceCalibration.TabIndex = 3
        Me.tsReflectanceCalibration.Text = "Reflectance Calibration"
        Me.tsReflectanceCalibration.UseVisualStyleBackColor = True
        '
        'gbReflectanceCalibration
        '
        Me.gbReflectanceCalibration.Controls.Add(Me.mmReflectanceConversion)
        Me.gbReflectanceCalibration.Controls.Add(Me.gbReflectanceSmooth)
        Me.gbReflectanceCalibration.Controls.Add(Me.edtReflectanceInttime)
        Me.gbReflectanceCalibration.Controls.Add(Me.Label69)
        Me.gbReflectanceCalibration.Controls.Add(Me.Label70)
        Me.gbReflectanceCalibration.Controls.Add(Me.Label71)
        Me.gbReflectanceCalibration.Location = New System.Drawing.Point(22, 12)
        Me.gbReflectanceCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.gbReflectanceCalibration.Name = "gbReflectanceCalibration"
        Me.gbReflectanceCalibration.Padding = New System.Windows.Forms.Padding(2)
        Me.gbReflectanceCalibration.Size = New System.Drawing.Size(230, 433)
        Me.gbReflectanceCalibration.TabIndex = 0
        Me.gbReflectanceCalibration.TabStop = False
        Me.gbReflectanceCalibration.Text = "Scope to Reflectance Conversion"
        '
        'mmReflectanceConversion
        '
        Me.mmReflectanceConversion.Location = New System.Drawing.Point(22, 24)
        Me.mmReflectanceConversion.Margin = New System.Windows.Forms.Padding(2)
        Me.mmReflectanceConversion.Multiline = True
        Me.mmReflectanceConversion.Name = "mmReflectanceConversion"
        Me.mmReflectanceConversion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mmReflectanceConversion.Size = New System.Drawing.Size(157, 258)
        Me.mmReflectanceConversion.TabIndex = 1
        '
        'gbReflectanceSmooth
        '
        Me.gbReflectanceSmooth.Controls.Add(Me.edtReflectanceSmoothPixels)
        Me.gbReflectanceSmooth.Controls.Add(Me.edtReflectanceSmoothModel)
        Me.gbReflectanceSmooth.Controls.Add(Me.Label67)
        Me.gbReflectanceSmooth.Controls.Add(Me.Label68)
        Me.gbReflectanceSmooth.Location = New System.Drawing.Point(22, 304)
        Me.gbReflectanceSmooth.Margin = New System.Windows.Forms.Padding(2)
        Me.gbReflectanceSmooth.Name = "gbReflectanceSmooth"
        Me.gbReflectanceSmooth.Padding = New System.Windows.Forms.Padding(2)
        Me.gbReflectanceSmooth.Size = New System.Drawing.Size(190, 72)
        Me.gbReflectanceSmooth.TabIndex = 9
        Me.gbReflectanceSmooth.TabStop = False
        Me.gbReflectanceSmooth.Text = "Calibration Smoothing Settings"
        '
        'edtReflectanceSmoothPixels
        '
        Me.edtReflectanceSmoothPixels.Location = New System.Drawing.Point(74, 45)
        Me.edtReflectanceSmoothPixels.Margin = New System.Windows.Forms.Padding(2)
        Me.edtReflectanceSmoothPixels.Name = "edtReflectanceSmoothPixels"
        Me.edtReflectanceSmoothPixels.Size = New System.Drawing.Size(76, 20)
        Me.edtReflectanceSmoothPixels.TabIndex = 1
        '
        'edtReflectanceSmoothModel
        '
        Me.edtReflectanceSmoothModel.Location = New System.Drawing.Point(74, 22)
        Me.edtReflectanceSmoothModel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtReflectanceSmoothModel.Name = "edtReflectanceSmoothModel"
        Me.edtReflectanceSmoothModel.Size = New System.Drawing.Size(76, 20)
        Me.edtReflectanceSmoothModel.TabIndex = 1
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(8, 47)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(62, 13)
        Me.Label67.TabIndex = 0
        Me.Label67.Text = "Nr Of Pixels"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(8, 24)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(36, 13)
        Me.Label68.TabIndex = 0
        Me.Label68.Text = "Model"
        '
        'edtReflectanceInttime
        '
        Me.edtReflectanceInttime.Location = New System.Drawing.Point(103, 404)
        Me.edtReflectanceInttime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtReflectanceInttime.Name = "edtReflectanceInttime"
        Me.edtReflectanceInttime.Size = New System.Drawing.Size(66, 20)
        Me.edtReflectanceInttime.TabIndex = 7
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(172, 408)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(20, 13)
        Me.Label69.TabIndex = 4
        Me.Label69.Text = "ms"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(22, 408)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(76, 13)
        Me.Label70.TabIndex = 5
        Me.Label70.Text = "Integrationtime"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(22, 392)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(56, 13)
        Me.Label71.TabIndex = 6
        Me.Label71.Text = "Calibration"
        '
        'tsCorrection
        '
        Me.tsCorrection.Controls.Add(Me.gbCorrection)
        Me.tsCorrection.Location = New System.Drawing.Point(4, 22)
        Me.tsCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.tsCorrection.Name = "tsCorrection"
        Me.tsCorrection.Padding = New System.Windows.Forms.Padding(2)
        Me.tsCorrection.Size = New System.Drawing.Size(638, 488)
        Me.tsCorrection.TabIndex = 4
        Me.tsCorrection.Text = "Spectrum Correction"
        Me.tsCorrection.UseVisualStyleBackColor = True
        '
        'gbCorrection
        '
        Me.gbCorrection.Controls.Add(Me.mmCorrection)
        Me.gbCorrection.Location = New System.Drawing.Point(22, 12)
        Me.gbCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.gbCorrection.Name = "gbCorrection"
        Me.gbCorrection.Padding = New System.Windows.Forms.Padding(2)
        Me.gbCorrection.Size = New System.Drawing.Size(230, 433)
        Me.gbCorrection.TabIndex = 1
        Me.gbCorrection.TabStop = False
        Me.gbCorrection.Text = "Pixel Correction Values"
        '
        'mmCorrection
        '
        Me.mmCorrection.Location = New System.Drawing.Point(22, 24)
        Me.mmCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.mmCorrection.Multiline = True
        Me.mmCorrection.Name = "mmCorrection"
        Me.mmCorrection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mmCorrection.Size = New System.Drawing.Size(157, 385)
        Me.mmCorrection.TabIndex = 2
        '
        'tsTempSensor
        '
        Me.tsTempSensor.Controls.Add(Me.gbThermistor)
        Me.tsTempSensor.Controls.Add(Me.gbNTC2)
        Me.tsTempSensor.Controls.Add(Me.gbNTC1)
        Me.tsTempSensor.Location = New System.Drawing.Point(4, 22)
        Me.tsTempSensor.Margin = New System.Windows.Forms.Padding(2)
        Me.tsTempSensor.Name = "tsTempSensor"
        Me.tsTempSensor.Padding = New System.Windows.Forms.Padding(2)
        Me.tsTempSensor.Size = New System.Drawing.Size(638, 488)
        Me.tsTempSensor.TabIndex = 5
        Me.tsTempSensor.Text = "Temperature Sensors"
        Me.tsTempSensor.UseVisualStyleBackColor = True
        '
        'gbThermistor
        '
        Me.gbThermistor.Controls.Add(Me.edtThermistorX4)
        Me.gbThermistor.Controls.Add(Me.edtThermistorX3)
        Me.gbThermistor.Controls.Add(Me.edtThermistorX2)
        Me.gbThermistor.Controls.Add(Me.edtThermistorX1)
        Me.gbThermistor.Controls.Add(Me.edtThermistorX0)
        Me.gbThermistor.Controls.Add(Me.Label82)
        Me.gbThermistor.Controls.Add(Me.Label83)
        Me.gbThermistor.Controls.Add(Me.Label84)
        Me.gbThermistor.Controls.Add(Me.Label85)
        Me.gbThermistor.Controls.Add(Me.Label86)
        Me.gbThermistor.Location = New System.Drawing.Point(388, 32)
        Me.gbThermistor.Margin = New System.Windows.Forms.Padding(2)
        Me.gbThermistor.Name = "gbThermistor"
        Me.gbThermistor.Padding = New System.Windows.Forms.Padding(2)
        Me.gbThermistor.Size = New System.Drawing.Size(171, 154)
        Me.gbThermistor.TabIndex = 0
        Me.gbThermistor.TabStop = False
        Me.gbThermistor.Text = "Thermistor Calibration"
        '
        'edtThermistorX4
        '
        Me.edtThermistorX4.Location = New System.Drawing.Point(56, 108)
        Me.edtThermistorX4.Margin = New System.Windows.Forms.Padding(2)
        Me.edtThermistorX4.Name = "edtThermistorX4"
        Me.edtThermistorX4.Size = New System.Drawing.Size(86, 20)
        Me.edtThermistorX4.TabIndex = 1
        '
        'edtThermistorX3
        '
        Me.edtThermistorX3.Location = New System.Drawing.Point(56, 85)
        Me.edtThermistorX3.Margin = New System.Windows.Forms.Padding(2)
        Me.edtThermistorX3.Name = "edtThermistorX3"
        Me.edtThermistorX3.Size = New System.Drawing.Size(86, 20)
        Me.edtThermistorX3.TabIndex = 1
        '
        'edtThermistorX2
        '
        Me.edtThermistorX2.Location = New System.Drawing.Point(56, 63)
        Me.edtThermistorX2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtThermistorX2.Name = "edtThermistorX2"
        Me.edtThermistorX2.Size = New System.Drawing.Size(86, 20)
        Me.edtThermistorX2.TabIndex = 1
        '
        'edtThermistorX1
        '
        Me.edtThermistorX1.Location = New System.Drawing.Point(56, 40)
        Me.edtThermistorX1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtThermistorX1.Name = "edtThermistorX1"
        Me.edtThermistorX1.Size = New System.Drawing.Size(86, 20)
        Me.edtThermistorX1.TabIndex = 1
        '
        'edtThermistorX0
        '
        Me.edtThermistorX0.Location = New System.Drawing.Point(56, 17)
        Me.edtThermistorX0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtThermistorX0.Name = "edtThermistorX0"
        Me.edtThermistorX0.Size = New System.Drawing.Size(86, 20)
        Me.edtThermistorX0.TabIndex = 1
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(4, 110)
        Me.Label82.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(20, 13)
        Me.Label82.TabIndex = 0
        Me.Label82.Text = "X4"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(4, 88)
        Me.Label83.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(20, 13)
        Me.Label83.TabIndex = 0
        Me.Label83.Text = "X3"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(4, 65)
        Me.Label84.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(20, 13)
        Me.Label84.TabIndex = 0
        Me.Label84.Text = "X2"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(4, 42)
        Me.Label85.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(20, 13)
        Me.Label85.TabIndex = 0
        Me.Label85.Text = "X1"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(4, 20)
        Me.Label86.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(49, 13)
        Me.Label86.TabIndex = 0
        Me.Label86.Text = "Intercept"
        '
        'gbNTC2
        '
        Me.gbNTC2.Controls.Add(Me.edtNTC2X4)
        Me.gbNTC2.Controls.Add(Me.edtNTC2X3)
        Me.gbNTC2.Controls.Add(Me.edtNTC2X2)
        Me.gbNTC2.Controls.Add(Me.edtNTC2X1)
        Me.gbNTC2.Controls.Add(Me.edtNTC2X0)
        Me.gbNTC2.Controls.Add(Me.Label77)
        Me.gbNTC2.Controls.Add(Me.Label78)
        Me.gbNTC2.Controls.Add(Me.Label79)
        Me.gbNTC2.Controls.Add(Me.Label80)
        Me.gbNTC2.Controls.Add(Me.Label81)
        Me.gbNTC2.Location = New System.Drawing.Point(212, 32)
        Me.gbNTC2.Margin = New System.Windows.Forms.Padding(2)
        Me.gbNTC2.Name = "gbNTC2"
        Me.gbNTC2.Padding = New System.Windows.Forms.Padding(2)
        Me.gbNTC2.Size = New System.Drawing.Size(171, 154)
        Me.gbNTC2.TabIndex = 0
        Me.gbNTC2.TabStop = False
        Me.gbNTC2.Text = "NTC2 Calibration"
        '
        'edtNTC2X4
        '
        Me.edtNTC2X4.Location = New System.Drawing.Point(56, 108)
        Me.edtNTC2X4.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC2X4.Name = "edtNTC2X4"
        Me.edtNTC2X4.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC2X4.TabIndex = 1
        '
        'edtNTC2X3
        '
        Me.edtNTC2X3.Location = New System.Drawing.Point(56, 85)
        Me.edtNTC2X3.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC2X3.Name = "edtNTC2X3"
        Me.edtNTC2X3.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC2X3.TabIndex = 1
        '
        'edtNTC2X2
        '
        Me.edtNTC2X2.Location = New System.Drawing.Point(56, 63)
        Me.edtNTC2X2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC2X2.Name = "edtNTC2X2"
        Me.edtNTC2X2.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC2X2.TabIndex = 1
        '
        'edtNTC2X1
        '
        Me.edtNTC2X1.Location = New System.Drawing.Point(56, 40)
        Me.edtNTC2X1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC2X1.Name = "edtNTC2X1"
        Me.edtNTC2X1.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC2X1.TabIndex = 1
        '
        'edtNTC2X0
        '
        Me.edtNTC2X0.Location = New System.Drawing.Point(56, 17)
        Me.edtNTC2X0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC2X0.Name = "edtNTC2X0"
        Me.edtNTC2X0.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC2X0.TabIndex = 1
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(4, 110)
        Me.Label77.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(20, 13)
        Me.Label77.TabIndex = 0
        Me.Label77.Text = "X4"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(4, 88)
        Me.Label78.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(20, 13)
        Me.Label78.TabIndex = 0
        Me.Label78.Text = "X3"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(4, 65)
        Me.Label79.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(20, 13)
        Me.Label79.TabIndex = 0
        Me.Label79.Text = "X2"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(4, 42)
        Me.Label80.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(20, 13)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "X1"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(4, 20)
        Me.Label81.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(49, 13)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "Intercept"
        '
        'gbNTC1
        '
        Me.gbNTC1.Controls.Add(Me.edtNTC1X4)
        Me.gbNTC1.Controls.Add(Me.edtNTC1X3)
        Me.gbNTC1.Controls.Add(Me.edtNTC1X2)
        Me.gbNTC1.Controls.Add(Me.edtNTC1X1)
        Me.gbNTC1.Controls.Add(Me.edtNTC1X0)
        Me.gbNTC1.Controls.Add(Me.Label76)
        Me.gbNTC1.Controls.Add(Me.Label75)
        Me.gbNTC1.Controls.Add(Me.Label74)
        Me.gbNTC1.Controls.Add(Me.Label73)
        Me.gbNTC1.Controls.Add(Me.Label72)
        Me.gbNTC1.Location = New System.Drawing.Point(37, 32)
        Me.gbNTC1.Margin = New System.Windows.Forms.Padding(2)
        Me.gbNTC1.Name = "gbNTC1"
        Me.gbNTC1.Padding = New System.Windows.Forms.Padding(2)
        Me.gbNTC1.Size = New System.Drawing.Size(171, 154)
        Me.gbNTC1.TabIndex = 0
        Me.gbNTC1.TabStop = False
        Me.gbNTC1.Text = "NTC1 Calibration"
        '
        'edtNTC1X4
        '
        Me.edtNTC1X4.Location = New System.Drawing.Point(56, 108)
        Me.edtNTC1X4.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC1X4.Name = "edtNTC1X4"
        Me.edtNTC1X4.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC1X4.TabIndex = 1
        '
        'edtNTC1X3
        '
        Me.edtNTC1X3.Location = New System.Drawing.Point(56, 85)
        Me.edtNTC1X3.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC1X3.Name = "edtNTC1X3"
        Me.edtNTC1X3.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC1X3.TabIndex = 1
        '
        'edtNTC1X2
        '
        Me.edtNTC1X2.Location = New System.Drawing.Point(56, 63)
        Me.edtNTC1X2.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC1X2.Name = "edtNTC1X2"
        Me.edtNTC1X2.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC1X2.TabIndex = 1
        '
        'edtNTC1X1
        '
        Me.edtNTC1X1.Location = New System.Drawing.Point(56, 40)
        Me.edtNTC1X1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC1X1.Name = "edtNTC1X1"
        Me.edtNTC1X1.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC1X1.TabIndex = 1
        '
        'edtNTC1X0
        '
        Me.edtNTC1X0.Location = New System.Drawing.Point(56, 17)
        Me.edtNTC1X0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNTC1X0.Name = "edtNTC1X0"
        Me.edtNTC1X0.Size = New System.Drawing.Size(86, 20)
        Me.edtNTC1X0.TabIndex = 1
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(4, 110)
        Me.Label76.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(20, 13)
        Me.Label76.TabIndex = 0
        Me.Label76.Text = "X4"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(4, 88)
        Me.Label75.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(20, 13)
        Me.Label75.TabIndex = 0
        Me.Label75.Text = "X3"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(4, 65)
        Me.Label74.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(20, 13)
        Me.Label74.TabIndex = 0
        Me.Label74.Text = "X2"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(4, 42)
        Me.Label73.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(20, 13)
        Me.Label73.TabIndex = 0
        Me.Label73.Text = "X1"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(4, 20)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(49, 13)
        Me.Label72.TabIndex = 0
        Me.Label72.Text = "Intercept"
        '
        'tsTecControl
        '
        Me.tsTecControl.Controls.Add(Me.GroupBox1)
        Me.tsTecControl.Controls.Add(Me.Label90)
        Me.tsTecControl.Controls.Add(Me.edtSetPoint)
        Me.tsTecControl.Controls.Add(Me.Label93)
        Me.tsTecControl.Controls.Add(Me.Label89)
        Me.tsTecControl.Controls.Add(Me.chkEnableTec)
        Me.tsTecControl.Location = New System.Drawing.Point(4, 22)
        Me.tsTecControl.Margin = New System.Windows.Forms.Padding(2)
        Me.tsTecControl.Name = "tsTecControl"
        Me.tsTecControl.Padding = New System.Windows.Forms.Padding(2)
        Me.tsTecControl.Size = New System.Drawing.Size(638, 488)
        Me.tsTecControl.TabIndex = 6
        Me.tsTecControl.Text = "Tec Control"
        Me.tsTecControl.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label92)
        Me.GroupBox1.Controls.Add(Me.Label91)
        Me.GroupBox1.Controls.Add(Me.edtTecX1)
        Me.GroupBox1.Controls.Add(Me.edtTecX0)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(149, 101)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAC Coefficients"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(13, 57)
        Me.Label92.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(20, 13)
        Me.Label92.TabIndex = 1
        Me.Label92.Text = "X1"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(13, 34)
        Me.Label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(20, 13)
        Me.Label91.TabIndex = 1
        Me.Label91.Text = "X0"
        '
        'edtTecX1
        '
        Me.edtTecX1.Location = New System.Drawing.Point(53, 54)
        Me.edtTecX1.Margin = New System.Windows.Forms.Padding(2)
        Me.edtTecX1.Name = "edtTecX1"
        Me.edtTecX1.Size = New System.Drawing.Size(73, 20)
        Me.edtTecX1.TabIndex = 0
        '
        'edtTecX0
        '
        Me.edtTecX0.Location = New System.Drawing.Point(53, 32)
        Me.edtTecX0.Margin = New System.Windows.Forms.Padding(2)
        Me.edtTecX0.Name = "edtTecX0"
        Me.edtTecX0.Size = New System.Drawing.Size(73, 20)
        Me.edtTecX0.TabIndex = 0
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(152, 54)
        Me.Label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(18, 13)
        Me.Label90.TabIndex = 3
        Me.Label90.Text = "°C"
        '
        'edtSetPoint
        '
        Me.edtSetPoint.Location = New System.Drawing.Point(76, 52)
        Me.edtSetPoint.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSetPoint.Name = "edtSetPoint"
        Me.edtSetPoint.Size = New System.Drawing.Size(72, 20)
        Me.edtSetPoint.TabIndex = 2
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(22, 54)
        Me.Label93.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(47, 13)
        Me.Label93.TabIndex = 1
        Me.Label93.Text = "SetPoint"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(20, 55)
        Me.Label89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(47, 13)
        Me.Label89.TabIndex = 1
        Me.Label89.Text = "SetPoint"
        '
        'chkEnableTec
        '
        Me.chkEnableTec.AutoSize = True
        Me.chkEnableTec.Location = New System.Drawing.Point(25, 21)
        Me.chkEnableTec.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnableTec.Name = "chkEnableTec"
        Me.chkEnableTec.Size = New System.Drawing.Size(59, 17)
        Me.chkEnableTec.TabIndex = 0
        Me.chkEnableTec.Text = "Enable"
        Me.chkEnableTec.UseVisualStyleBackColor = True
        '
        'edtLength
        '
        Me.edtLength.Location = New System.Drawing.Point(108, 14)
        Me.edtLength.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLength.Name = "edtLength"
        Me.edtLength.ReadOnly = True
        Me.edtLength.Size = New System.Drawing.Size(76, 20)
        Me.edtLength.TabIndex = 6
        '
        'edtVersion
        '
        Me.edtVersion.Location = New System.Drawing.Point(108, 37)
        Me.edtVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.edtVersion.Name = "edtVersion"
        Me.edtVersion.ReadOnly = True
        Me.edtVersion.Size = New System.Drawing.Size(119, 20)
        Me.edtVersion.TabIndex = 7
        '
        'edtUserFriendly
        '
        Me.edtUserFriendly.Location = New System.Drawing.Point(108, 62)
        Me.edtUserFriendly.Margin = New System.Windows.Forms.Padding(2)
        Me.edtUserFriendly.Name = "edtUserFriendly"
        Me.edtUserFriendly.Size = New System.Drawing.Size(470, 20)
        Me.edtUserFriendly.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'EEProm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(674, 666)
        Me.Controls.Add(Me.edtUserFriendly)
        Me.Controls.Add(Me.edtVersion)
        Me.Controls.Add(Me.edtLength)
        Me.Controls.Add(Me.pcEEprom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EEProm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EEprom settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pcEEprom.ResumeLayout(False)
        Me.tsDetector.ResumeLayout(False)
        Me.tsDetector.PerformLayout()
        Me.gbNLCalibration.ResumeLayout(False)
        Me.gbNLCalibration.PerformLayout()
        Me.gbDefPixels.ResumeLayout(False)
        Me.gbDefPixels.PerformLayout()
        Me.gbWaveLengthCalibration.ResumeLayout(False)
        Me.gbWaveLengthCalibration.PerformLayout()
        Me.tsStandAlone.ResumeLayout(False)
        Me.tsStandAlone.PerformLayout()
        Me.gbPrepareMeasSettings.ResumeLayout(False)
        Me.gbPrepareMeasSettings.PerformLayout()
        Me.gbControl.ResumeLayout(False)
        Me.gbControl.PerformLayout()
        Me.gbSmoothing.ResumeLayout(False)
        Me.gbSmoothing.PerformLayout()
        Me.gbDarkCorrection.ResumeLayout(False)
        Me.gbDarkCorrection.PerformLayout()
        Me.gbTrigger.ResumeLayout(False)
        Me.gbTrigger.PerformLayout()
        Me.tsIrradianceCalibration.ResumeLayout(False)
        Me.tsIrradianceCalibration.PerformLayout()
        Me.gbIrradCalibration.ResumeLayout(False)
        Me.gbIrradCalibration.PerformLayout()
        Me.gbIrradSmooth.ResumeLayout(False)
        Me.gbIrradSmooth.PerformLayout()
        Me.tsReflectanceCalibration.ResumeLayout(False)
        Me.gbReflectanceCalibration.ResumeLayout(False)
        Me.gbReflectanceCalibration.PerformLayout()
        Me.gbReflectanceSmooth.ResumeLayout(False)
        Me.gbReflectanceSmooth.PerformLayout()
        Me.tsCorrection.ResumeLayout(False)
        Me.gbCorrection.ResumeLayout(False)
        Me.gbCorrection.PerformLayout()
        Me.tsTempSensor.ResumeLayout(False)
        Me.gbThermistor.ResumeLayout(False)
        Me.gbThermistor.PerformLayout()
        Me.gbNTC2.ResumeLayout(False)
        Me.gbNTC2.PerformLayout()
        Me.gbNTC1.ResumeLayout(False)
        Me.gbNTC1.PerformLayout()
        Me.tsTecControl.ResumeLayout(False)
        Me.tsTecControl.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnSaveToEEProm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pcEEprom As System.Windows.Forms.TabControl
    Friend WithEvents tsDetector As System.Windows.Forms.TabPage
    Friend WithEvents tsStandAlone As System.Windows.Forms.TabPage
    Friend WithEvents tsIrradianceCalibration As System.Windows.Forms.TabPage
    Friend WithEvents tsReflectanceCalibration As System.Windows.Forms.TabPage
    Friend WithEvents tsCorrection As System.Windows.Forms.TabPage
    Friend WithEvents tsTempSensor As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbWaveLengthCalibration As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents edtNrOfPixels As System.Windows.Forms.TextBox
    Friend WithEvents edtWLX4 As System.Windows.Forms.TextBox
    Friend WithEvents edtWLX3 As System.Windows.Forms.TextBox
    Friend WithEvents edtWLX2 As System.Windows.Forms.TextBox
    Friend WithEvents edtWLX1 As System.Windows.Forms.TextBox
    Friend WithEvents edtWLX0 As System.Windows.Forms.TextBox
    Friend WithEvents edtOffset2 As System.Windows.Forms.TextBox
    Friend WithEvents edtOffset1 As System.Windows.Forms.TextBox
    Friend WithEvents edtGain2 As System.Windows.Forms.TextBox
    Friend WithEvents edtGain1 As System.Windows.Forms.TextBox
    Friend WithEvents gbDefPixels As System.Windows.Forms.GroupBox
    Friend WithEvents edtExtOffset As System.Windows.Forms.TextBox
    Friend WithEvents gbNLCalibration As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents edtNLX7 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX6 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX5 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX4 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX3 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX2 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX1 As System.Windows.Forms.TextBox
    Friend WithEvents edtNLX0 As System.Windows.Forms.TextBox
    Friend WithEvents cbDetectorType As System.Windows.Forms.ComboBox
    Friend WithEvents chkEnableNL As System.Windows.Forms.CheckBox
    Friend WithEvents gbPrepareMeasSettings As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents edtStartPixel As System.Windows.Forms.TextBox
    Friend WithEvents gbTrigger As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents edtNrOfAverages As System.Windows.Forms.TextBox
    Friend WithEvents edtIntegrationDelay As System.Windows.Forms.TextBox
    Friend WithEvents edtIntegrationTime As System.Windows.Forms.TextBox
    Friend WithEvents edtStopPixel As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents edtSaturationLevel As System.Windows.Forms.TextBox
    Friend WithEvents chkTrigTypeLevel As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigModeHw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigModeSw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigSourceExtHw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigSourceSync As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigTypeEdge As System.Windows.Forms.CheckBox
    Friend WithEvents gbDarkCorrection As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableDarkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents gbSmoothing As System.Windows.Forms.GroupBox
    Friend WithEvents edtSmoothModel As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents edtDarkHist As System.Windows.Forms.TextBox
    Friend WithEvents edtSmoothPix As System.Windows.Forms.TextBox
    Friend WithEvents gbControl As System.Windows.Forms.GroupBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents edtRamSpectra As System.Windows.Forms.TextBox
    Friend WithEvents edtLaserWavelength As System.Windows.Forms.TextBox
    Friend WithEvents edtLaserWidth As System.Windows.Forms.TextBox
    Friend WithEvents edtLaserDelay As System.Windows.Forms.TextBox
    Friend WithEvents edtFlashesPerScan As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents edtNrOfMeas As System.Windows.Forms.TextBox
    Friend WithEvents chkEnableStandAlone As System.Windows.Forms.CheckBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents gbIrradCalibration As System.Windows.Forms.GroupBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents edtIrradFiberDiameter As System.Windows.Forms.TextBox
    Friend WithEvents edtIrradCalibrationType As System.Windows.Forms.TextBox
    Friend WithEvents gbIrradSmooth As System.Windows.Forms.GroupBox
    Friend WithEvents edtIrradInttime As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents edtIrradSmoothPixels As System.Windows.Forms.TextBox
    Friend WithEvents edtIrradSmoothModel As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents gbReflectanceCalibration As System.Windows.Forms.GroupBox
    Friend WithEvents gbReflectanceSmooth As System.Windows.Forms.GroupBox
    Friend WithEvents edtReflectanceSmoothPixels As System.Windows.Forms.TextBox
    Friend WithEvents edtReflectanceSmoothModel As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents edtReflectanceInttime As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents gbCorrection As System.Windows.Forms.GroupBox
    Friend WithEvents gbNTC1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents gbNTC2 As System.Windows.Forms.GroupBox
    Friend WithEvents edtNTC2X4 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC2X3 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC2X2 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC2X1 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC2X0 As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents edtNTC1X4 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC1X3 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC1X2 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC1X1 As System.Windows.Forms.TextBox
    Friend WithEvents edtNTC1X0 As System.Windows.Forms.TextBox
    Friend WithEvents gbThermistor As System.Windows.Forms.GroupBox
    Friend WithEvents edtThermistorX4 As System.Windows.Forms.TextBox
    Friend WithEvents edtThermistorX3 As System.Windows.Forms.TextBox
    Friend WithEvents edtThermistorX2 As System.Windows.Forms.TextBox
    Friend WithEvents edtThermistorX1 As System.Windows.Forms.TextBox
    Friend WithEvents edtThermistorX0 As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents edtLength As System.Windows.Forms.TextBox
    Friend WithEvents edtVersion As System.Windows.Forms.TextBox
    Friend WithEvents edtUserFriendly As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mmCorrection As System.Windows.Forms.TextBox
    Friend WithEvents mmReflectanceConversion As System.Windows.Forms.TextBox
    Friend WithEvents mmIrradConversion As System.Windows.Forms.TextBox
    Friend WithEvents tbDefPixels As System.Windows.Forms.TextBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents edtNLHigh As System.Windows.Forms.TextBox
    Friend WithEvents edtNLLow As System.Windows.Forms.TextBox
    Friend WithEvents tsTecControl As System.Windows.Forms.TabPage
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents chkEnableTec As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents edtTecX1 As System.Windows.Forms.TextBox
    Friend WithEvents edtTecX0 As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents edtSetPoint As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label

End Class

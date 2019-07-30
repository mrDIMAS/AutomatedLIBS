<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigureHardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnalogIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DigiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EEPromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gbPrepareMeasSettings = New System.Windows.Forms.GroupBox
        Me.btnWriteMeasToEEProm = New System.Windows.Forms.Button
        Me.btnReadMeasFromEEProm = New System.Windows.Forms.Button
        Me.gbControl = New System.Windows.Forms.GroupBox
        Me.edtRamSpectra = New System.Windows.Forms.TextBox
        Me.edtLaserWavelength = New System.Windows.Forms.TextBox
        Me.edtLaserWidth = New System.Windows.Forms.TextBox
        Me.edtLaserDelay = New System.Windows.Forms.TextBox
        Me.edtFlashesPerScan = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.edtSaturationLevel = New System.Windows.Forms.TextBox
        Me.gbSmoothing = New System.Windows.Forms.GroupBox
        Me.edtSmoothPix = New System.Windows.Forms.TextBox
        Me.edtSmoothModel = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gbDarkCorrection = New System.Windows.Forms.GroupBox
        Me.edtDarkHist = New System.Windows.Forms.TextBox
        Me.chkEnableDarkCorrection = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbTrigger = New System.Windows.Forms.GroupBox
        Me.chkTrigModeSw = New System.Windows.Forms.CheckBox
        Me.chkTrigModeHw = New System.Windows.Forms.CheckBox
        Me.chkTrigSourceExtHw = New System.Windows.Forms.CheckBox
        Me.chkTrigSourceSync = New System.Windows.Forms.CheckBox
        Me.chkTrigTypeEdge = New System.Windows.Forms.CheckBox
        Me.chkTrigTypeLevel = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.edtNrOfAverages = New System.Windows.Forms.TextBox
        Me.edtIntegrationDelay = New System.Windows.Forms.TextBox
        Me.edtIntegrationTime = New System.Windows.Forms.TextBox
        Me.edtStopPixel = New System.Windows.Forms.TextBox
        Me.edtStartPixel = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbOutput = New System.Windows.Forms.GroupBox
        Me.edtLastScanTime = New System.Windows.Forms.TextBox
        Me.edtAvgTimePerScan = New System.Windows.Forms.TextBox
        Me.edtFailures = New System.Windows.Forms.TextBox
        Me.edtPerformedScans = New System.Windows.Forms.TextBox
        Me.edtTotalTime = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.gbMeasure = New System.Windows.Forms.GroupBox
        Me.chkPreScan = New System.Windows.Forms.CheckBox
        Me.btnStopMeasurement = New System.Windows.Forms.Button
        Me.edtNrOfScans = New System.Windows.Forms.TextBox
        Me.btnStartMeasurement = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.gbInfo = New System.Windows.Forms.GroupBox
        Me.edtNrOfPixels = New System.Windows.Forms.TextBox
        Me.edtDetectorname = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.gbVersionInfo = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.edtDLLver = New System.Windows.Forms.TextBox
        Me.edtFWver = New System.Windows.Forms.TextBox
        Me.edtFPGAver = New System.Windows.Forms.TextBox
        Me.nudPixel = New System.Windows.Forms.NumericUpDown
        Me.tbCounts = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.StatusBar = New System.Windows.Forms.StatusStrip
        Me.Status1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.Status3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.Status2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.gbPrepareMeasSettings.SuspendLayout()
        Me.gbControl.SuspendLayout()
        Me.gbSmoothing.SuspendLayout()
        Me.gbDarkCorrection.SuspendLayout()
        Me.gbTrigger.SuspendLayout()
        Me.gbOutput.SuspendLayout()
        Me.gbMeasure.SuspendLayout()
        Me.gbInfo.SuspendLayout()
        Me.gbVersionInfo.SuspendLayout()
        CType(Me.nudPixel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ConfigureHardwareToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "Menu1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConfigureHardwareToolStripMenuItem
        '
        Me.ConfigureHardwareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnalogIOToolStripMenuItem, Me.DigiToolStripMenuItem, Me.EEPromToolStripMenuItem})
        Me.ConfigureHardwareToolStripMenuItem.Name = "ConfigureHardwareToolStripMenuItem"
        Me.ConfigureHardwareToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ConfigureHardwareToolStripMenuItem.Text = "Configure Hardware"
        '
        'AnalogIOToolStripMenuItem
        '
        Me.AnalogIOToolStripMenuItem.Name = "AnalogIOToolStripMenuItem"
        Me.AnalogIOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AnalogIOToolStripMenuItem.Text = "Analog IO"
        '
        'DigiToolStripMenuItem
        '
        Me.DigiToolStripMenuItem.Name = "DigiToolStripMenuItem"
        Me.DigiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DigiToolStripMenuItem.Text = "Digital IO"
        '
        'EEPromToolStripMenuItem
        '
        Me.EEPromToolStripMenuItem.Name = "EEPromToolStripMenuItem"
        Me.EEPromToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EEPromToolStripMenuItem.Text = "EEProm"
        '
        'gbPrepareMeasSettings
        '
        Me.gbPrepareMeasSettings.Controls.Add(Me.btnWriteMeasToEEProm)
        Me.gbPrepareMeasSettings.Controls.Add(Me.btnReadMeasFromEEProm)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbControl)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtSaturationLevel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbSmoothing)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbDarkCorrection)
        Me.gbPrepareMeasSettings.Controls.Add(Me.gbTrigger)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtNrOfAverages)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtIntegrationDelay)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtIntegrationTime)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtStopPixel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.edtStartPixel)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label6)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label5)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label8)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label4)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label7)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label3)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label2)
        Me.gbPrepareMeasSettings.Controls.Add(Me.Label1)
        Me.gbPrepareMeasSettings.Location = New System.Drawing.Point(9, 24)
        Me.gbPrepareMeasSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.gbPrepareMeasSettings.Name = "gbPrepareMeasSettings"
        Me.gbPrepareMeasSettings.Padding = New System.Windows.Forms.Padding(2)
        Me.gbPrepareMeasSettings.Size = New System.Drawing.Size(458, 374)
        Me.gbPrepareMeasSettings.TabIndex = 4
        Me.gbPrepareMeasSettings.TabStop = False
        Me.gbPrepareMeasSettings.Text = "Prepare Measurement Settings"
        '
        'btnWriteMeasToEEProm
        '
        Me.btnWriteMeasToEEProm.Location = New System.Drawing.Point(218, 322)
        Me.btnWriteMeasToEEProm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWriteMeasToEEProm.Name = "btnWriteMeasToEEProm"
        Me.btnWriteMeasToEEProm.Size = New System.Drawing.Size(219, 35)
        Me.btnWriteMeasToEEProm.TabIndex = 7
        Me.btnWriteMeasToEEProm.Text = "Write Measurement Settings to EEPROM"
        Me.btnWriteMeasToEEProm.UseVisualStyleBackColor = True
        '
        'btnReadMeasFromEEProm
        '
        Me.btnReadMeasFromEEProm.Location = New System.Drawing.Point(7, 322)
        Me.btnReadMeasFromEEProm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReadMeasFromEEProm.Name = "btnReadMeasFromEEProm"
        Me.btnReadMeasFromEEProm.Size = New System.Drawing.Size(207, 35)
        Me.btnReadMeasFromEEProm.TabIndex = 7
        Me.btnReadMeasFromEEProm.Text = "Read Measurement Settings from EEPROM"
        Me.btnReadMeasFromEEProm.UseVisualStyleBackColor = True
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.edtRamSpectra)
        Me.gbControl.Controls.Add(Me.edtLaserWavelength)
        Me.gbControl.Controls.Add(Me.edtLaserWidth)
        Me.gbControl.Controls.Add(Me.edtLaserDelay)
        Me.gbControl.Controls.Add(Me.edtFlashesPerScan)
        Me.gbControl.Controls.Add(Me.Label19)
        Me.gbControl.Controls.Add(Me.Label18)
        Me.gbControl.Controls.Add(Me.Label17)
        Me.gbControl.Controls.Add(Me.Label16)
        Me.gbControl.Controls.Add(Me.Label15)
        Me.gbControl.Controls.Add(Me.Label22)
        Me.gbControl.Controls.Add(Me.Label21)
        Me.gbControl.Controls.Add(Me.Label20)
        Me.gbControl.Location = New System.Drawing.Point(236, 165)
        Me.gbControl.Margin = New System.Windows.Forms.Padding(2)
        Me.gbControl.Name = "gbControl"
        Me.gbControl.Padding = New System.Windows.Forms.Padding(2)
        Me.gbControl.Size = New System.Drawing.Size(201, 153)
        Me.gbControl.TabIndex = 6
        Me.gbControl.TabStop = False
        Me.gbControl.Text = "Control Settings"
        '
        'edtRamSpectra
        '
        Me.edtRamSpectra.Location = New System.Drawing.Point(121, 108)
        Me.edtRamSpectra.Margin = New System.Windows.Forms.Padding(2)
        Me.edtRamSpectra.Name = "edtRamSpectra"
        Me.edtRamSpectra.Size = New System.Drawing.Size(54, 20)
        Me.edtRamSpectra.TabIndex = 1
        Me.edtRamSpectra.Text = "0"
        '
        'edtLaserWavelength
        '
        Me.edtLaserWavelength.Location = New System.Drawing.Point(121, 85)
        Me.edtLaserWavelength.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserWavelength.Name = "edtLaserWavelength"
        Me.edtLaserWavelength.Size = New System.Drawing.Size(54, 20)
        Me.edtLaserWavelength.TabIndex = 1
        Me.edtLaserWavelength.Text = "785"
        '
        'edtLaserWidth
        '
        Me.edtLaserWidth.Location = New System.Drawing.Point(121, 63)
        Me.edtLaserWidth.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserWidth.Name = "edtLaserWidth"
        Me.edtLaserWidth.Size = New System.Drawing.Size(54, 20)
        Me.edtLaserWidth.TabIndex = 1
        Me.edtLaserWidth.Text = "10000"
        '
        'edtLaserDelay
        '
        Me.edtLaserDelay.Location = New System.Drawing.Point(121, 40)
        Me.edtLaserDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLaserDelay.Name = "edtLaserDelay"
        Me.edtLaserDelay.Size = New System.Drawing.Size(54, 20)
        Me.edtLaserDelay.TabIndex = 1
        Me.edtLaserDelay.Text = "0"
        '
        'edtFlashesPerScan
        '
        Me.edtFlashesPerScan.Location = New System.Drawing.Point(121, 17)
        Me.edtFlashesPerScan.Margin = New System.Windows.Forms.Padding(2)
        Me.edtFlashesPerScan.Name = "edtFlashesPerScan"
        Me.edtFlashesPerScan.Size = New System.Drawing.Size(54, 20)
        Me.edtFlashesPerScan.TabIndex = 1
        Me.edtFlashesPerScan.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 110)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Spectra stored to RAM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 88)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Laser wavelength"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 65)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Laser width"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 42)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Laser delay"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Flashes per Scan"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(178, 88)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "nm"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(178, 65)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "ns"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(178, 42)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "ns"
        '
        'edtSaturationLevel
        '
        Me.edtSaturationLevel.Location = New System.Drawing.Point(118, 138)
        Me.edtSaturationLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSaturationLevel.Name = "edtSaturationLevel"
        Me.edtSaturationLevel.Size = New System.Drawing.Size(76, 20)
        Me.edtSaturationLevel.TabIndex = 5
        Me.edtSaturationLevel.Text = "0"
        '
        'gbSmoothing
        '
        Me.gbSmoothing.Controls.Add(Me.edtSmoothPix)
        Me.gbSmoothing.Controls.Add(Me.edtSmoothModel)
        Me.gbSmoothing.Controls.Add(Me.Label14)
        Me.gbSmoothing.Controls.Add(Me.Label13)
        Me.gbSmoothing.Location = New System.Drawing.Point(236, 95)
        Me.gbSmoothing.Margin = New System.Windows.Forms.Padding(2)
        Me.gbSmoothing.Name = "gbSmoothing"
        Me.gbSmoothing.Padding = New System.Windows.Forms.Padding(2)
        Me.gbSmoothing.Size = New System.Drawing.Size(201, 65)
        Me.gbSmoothing.TabIndex = 4
        Me.gbSmoothing.TabStop = False
        Me.gbSmoothing.Text = "Smoothing Settings"
        '
        'edtSmoothPix
        '
        Me.edtSmoothPix.Location = New System.Drawing.Point(121, 37)
        Me.edtSmoothPix.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSmoothPix.Name = "edtSmoothPix"
        Me.edtSmoothPix.Size = New System.Drawing.Size(54, 20)
        Me.edtSmoothPix.TabIndex = 1
        Me.edtSmoothPix.Text = "0"
        '
        'edtSmoothModel
        '
        Me.edtSmoothModel.Location = New System.Drawing.Point(121, 15)
        Me.edtSmoothModel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtSmoothModel.Name = "edtSmoothModel"
        Me.edtSmoothModel.Size = New System.Drawing.Size(54, 20)
        Me.edtSmoothModel.TabIndex = 1
        Me.edtSmoothModel.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 40)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Nr Of Pixels"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 17)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Model"
        '
        'gbDarkCorrection
        '
        Me.gbDarkCorrection.Controls.Add(Me.edtDarkHist)
        Me.gbDarkCorrection.Controls.Add(Me.chkEnableDarkCorrection)
        Me.gbDarkCorrection.Controls.Add(Me.Label12)
        Me.gbDarkCorrection.Location = New System.Drawing.Point(236, 17)
        Me.gbDarkCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDarkCorrection.Name = "gbDarkCorrection"
        Me.gbDarkCorrection.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDarkCorrection.Size = New System.Drawing.Size(201, 73)
        Me.gbDarkCorrection.TabIndex = 3
        Me.gbDarkCorrection.TabStop = False
        Me.gbDarkCorrection.Text = "Dark Correction Settings"
        '
        'edtDarkHist
        '
        Me.edtDarkHist.Location = New System.Drawing.Point(4, 46)
        Me.edtDarkHist.Margin = New System.Windows.Forms.Padding(2)
        Me.edtDarkHist.Name = "edtDarkHist"
        Me.edtDarkHist.Size = New System.Drawing.Size(59, 20)
        Me.edtDarkHist.TabIndex = 2
        Me.edtDarkHist.Text = "100"
        '
        'chkEnableDarkCorrection
        '
        Me.chkEnableDarkCorrection.AutoSize = True
        Me.chkEnableDarkCorrection.Location = New System.Drawing.Point(4, 17)
        Me.chkEnableDarkCorrection.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEnableDarkCorrection.Name = "chkEnableDarkCorrection"
        Me.chkEnableDarkCorrection.Size = New System.Drawing.Size(59, 17)
        Me.chkEnableDarkCorrection.TabIndex = 1
        Me.chkEnableDarkCorrection.Text = "Enable"
        Me.chkEnableDarkCorrection.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(67, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "%"
        '
        'gbTrigger
        '
        Me.gbTrigger.Controls.Add(Me.chkTrigModeSw)
        Me.gbTrigger.Controls.Add(Me.chkTrigModeHw)
        Me.gbTrigger.Controls.Add(Me.chkTrigSourceExtHw)
        Me.gbTrigger.Controls.Add(Me.chkTrigSourceSync)
        Me.gbTrigger.Controls.Add(Me.chkTrigTypeEdge)
        Me.gbTrigger.Controls.Add(Me.chkTrigTypeLevel)
        Me.gbTrigger.Controls.Add(Me.Label11)
        Me.gbTrigger.Controls.Add(Me.Label10)
        Me.gbTrigger.Controls.Add(Me.Label9)
        Me.gbTrigger.Location = New System.Drawing.Point(7, 165)
        Me.gbTrigger.Margin = New System.Windows.Forms.Padding(2)
        Me.gbTrigger.Name = "gbTrigger"
        Me.gbTrigger.Padding = New System.Windows.Forms.Padding(2)
        Me.gbTrigger.Size = New System.Drawing.Size(187, 153)
        Me.gbTrigger.TabIndex = 2
        Me.gbTrigger.TabStop = False
        Me.gbTrigger.Text = "Trigger Settings"
        '
        'chkTrigModeSw
        '
        Me.chkTrigModeSw.AutoSize = True
        Me.chkTrigModeSw.Checked = True
        Me.chkTrigModeSw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrigModeSw.Location = New System.Drawing.Point(88, 42)
        Me.chkTrigModeSw.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigModeSw.Name = "chkTrigModeSw"
        Me.chkTrigModeSw.Size = New System.Drawing.Size(68, 17)
        Me.chkTrigModeSw.TabIndex = 1
        Me.chkTrigModeSw.Text = "Software"
        Me.chkTrigModeSw.UseVisualStyleBackColor = True
        '
        'chkTrigModeHw
        '
        Me.chkTrigModeHw.AutoSize = True
        Me.chkTrigModeHw.Location = New System.Drawing.Point(88, 24)
        Me.chkTrigModeHw.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigModeHw.Name = "chkTrigModeHw"
        Me.chkTrigModeHw.Size = New System.Drawing.Size(72, 17)
        Me.chkTrigModeHw.TabIndex = 1
        Me.chkTrigModeHw.Text = "Hardware"
        Me.chkTrigModeHw.UseVisualStyleBackColor = True
        '
        'chkTrigSourceExtHw
        '
        Me.chkTrigSourceExtHw.AutoSize = True
        Me.chkTrigSourceExtHw.Checked = True
        Me.chkTrigSourceExtHw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrigSourceExtHw.Location = New System.Drawing.Point(88, 64)
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
        Me.chkTrigSourceSync.Location = New System.Drawing.Point(88, 80)
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
        Me.chkTrigTypeEdge.Checked = True
        Me.chkTrigTypeEdge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrigTypeEdge.Location = New System.Drawing.Point(88, 104)
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
        Me.chkTrigTypeLevel.Location = New System.Drawing.Point(88, 120)
        Me.chkTrigTypeLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTrigTypeLevel.Name = "chkTrigTypeLevel"
        Me.chkTrigTypeLevel.Size = New System.Drawing.Size(52, 17)
        Me.chkTrigTypeLevel.TabIndex = 1
        Me.chkTrigTypeLevel.Text = "Level"
        Me.chkTrigTypeLevel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 105)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Trigger type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Trigger source"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Trigger mode"
        '
        'edtNrOfAverages
        '
        Me.edtNrOfAverages.Location = New System.Drawing.Point(118, 115)
        Me.edtNrOfAverages.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfAverages.Name = "edtNrOfAverages"
        Me.edtNrOfAverages.Size = New System.Drawing.Size(76, 20)
        Me.edtNrOfAverages.TabIndex = 1
        Me.edtNrOfAverages.Text = "1"
        '
        'edtIntegrationDelay
        '
        Me.edtIntegrationDelay.Location = New System.Drawing.Point(118, 93)
        Me.edtIntegrationDelay.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIntegrationDelay.Name = "edtIntegrationDelay"
        Me.edtIntegrationDelay.Size = New System.Drawing.Size(76, 20)
        Me.edtIntegrationDelay.TabIndex = 1
        Me.edtIntegrationDelay.Text = "0"
        '
        'edtIntegrationTime
        '
        Me.edtIntegrationTime.Location = New System.Drawing.Point(118, 70)
        Me.edtIntegrationTime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtIntegrationTime.Name = "edtIntegrationTime"
        Me.edtIntegrationTime.Size = New System.Drawing.Size(76, 20)
        Me.edtIntegrationTime.TabIndex = 1
        Me.edtIntegrationTime.Text = "100"
        '
        'edtStopPixel
        '
        Me.edtStopPixel.Location = New System.Drawing.Point(118, 47)
        Me.edtStopPixel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtStopPixel.Name = "edtStopPixel"
        Me.edtStopPixel.Size = New System.Drawing.Size(76, 20)
        Me.edtStopPixel.TabIndex = 1
        Me.edtStopPixel.Text = "2047"
        '
        'edtStartPixel
        '
        Me.edtStartPixel.Location = New System.Drawing.Point(118, 24)
        Me.edtStartPixel.Margin = New System.Windows.Forms.Padding(2)
        Me.edtStartPixel.Name = "edtStartPixel"
        Me.edtStartPixel.Size = New System.Drawing.Size(76, 20)
        Me.edtStartPixel.TabIndex = 1
        Me.edtStartPixel.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Saturation detection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Number of averages"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 95)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ns"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Integration Delay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Integration time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stop pixel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start pixel"
        '
        'gbOutput
        '
        Me.gbOutput.Controls.Add(Me.edtLastScanTime)
        Me.gbOutput.Controls.Add(Me.edtAvgTimePerScan)
        Me.gbOutput.Controls.Add(Me.edtFailures)
        Me.gbOutput.Controls.Add(Me.edtPerformedScans)
        Me.gbOutput.Controls.Add(Me.edtTotalTime)
        Me.gbOutput.Controls.Add(Me.Label27)
        Me.gbOutput.Controls.Add(Me.Label26)
        Me.gbOutput.Controls.Add(Me.Label25)
        Me.gbOutput.Controls.Add(Me.Label24)
        Me.gbOutput.Controls.Add(Me.Label23)
        Me.gbOutput.Location = New System.Drawing.Point(469, 297)
        Me.gbOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.gbOutput.Name = "gbOutput"
        Me.gbOutput.Padding = New System.Windows.Forms.Padding(2)
        Me.gbOutput.Size = New System.Drawing.Size(209, 141)
        Me.gbOutput.TabIndex = 5
        Me.gbOutput.TabStop = False
        Me.gbOutput.Text = "Measurement Statistics"
        '
        'edtLastScanTime
        '
        Me.edtLastScanTime.Location = New System.Drawing.Point(122, 107)
        Me.edtLastScanTime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtLastScanTime.Name = "edtLastScanTime"
        Me.edtLastScanTime.Size = New System.Drawing.Size(76, 20)
        Me.edtLastScanTime.TabIndex = 8
        '
        'edtAvgTimePerScan
        '
        Me.edtAvgTimePerScan.Location = New System.Drawing.Point(122, 84)
        Me.edtAvgTimePerScan.Margin = New System.Windows.Forms.Padding(2)
        Me.edtAvgTimePerScan.Name = "edtAvgTimePerScan"
        Me.edtAvgTimePerScan.Size = New System.Drawing.Size(76, 20)
        Me.edtAvgTimePerScan.TabIndex = 7
        '
        'edtFailures
        '
        Me.edtFailures.Location = New System.Drawing.Point(122, 62)
        Me.edtFailures.Margin = New System.Windows.Forms.Padding(2)
        Me.edtFailures.Name = "edtFailures"
        Me.edtFailures.Size = New System.Drawing.Size(76, 20)
        Me.edtFailures.TabIndex = 6
        '
        'edtPerformedScans
        '
        Me.edtPerformedScans.Location = New System.Drawing.Point(122, 39)
        Me.edtPerformedScans.Margin = New System.Windows.Forms.Padding(2)
        Me.edtPerformedScans.Name = "edtPerformedScans"
        Me.edtPerformedScans.Size = New System.Drawing.Size(76, 20)
        Me.edtPerformedScans.TabIndex = 5
        '
        'edtTotalTime
        '
        Me.edtTotalTime.Location = New System.Drawing.Point(122, 16)
        Me.edtTotalTime.Margin = New System.Windows.Forms.Padding(2)
        Me.edtTotalTime.Name = "edtTotalTime"
        Me.edtTotalTime.Size = New System.Drawing.Size(76, 20)
        Me.edtTotalTime.TabIndex = 4
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(4, 110)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Last scan in"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 88)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Avg Time /Scan"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 65)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Nr Of Failures"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 42)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Nr Of Scans"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 20)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Time Since Start"
        '
        'gbMeasure
        '
        Me.gbMeasure.Controls.Add(Me.chkPreScan)
        Me.gbMeasure.Controls.Add(Me.btnStopMeasurement)
        Me.gbMeasure.Controls.Add(Me.edtNrOfScans)
        Me.gbMeasure.Controls.Add(Me.btnStartMeasurement)
        Me.gbMeasure.Controls.Add(Me.Label29)
        Me.gbMeasure.Controls.Add(Me.Label28)
        Me.gbMeasure.Location = New System.Drawing.Point(472, 24)
        Me.gbMeasure.Margin = New System.Windows.Forms.Padding(2)
        Me.gbMeasure.Name = "gbMeasure"
        Me.gbMeasure.Padding = New System.Windows.Forms.Padding(2)
        Me.gbMeasure.Size = New System.Drawing.Size(206, 181)
        Me.gbMeasure.TabIndex = 6
        Me.gbMeasure.TabStop = False
        Me.gbMeasure.Text = "Measure"
        '
        'chkPreScan
        '
        Me.chkPreScan.AutoSize = True
        Me.chkPreScan.Location = New System.Drawing.Point(11, 131)
        Me.chkPreScan.Name = "chkPreScan"
        Me.chkPreScan.Size = New System.Drawing.Size(141, 17)
        Me.chkPreScan.TabIndex = 5
        Me.chkPreScan.Text = "AvaSpec-3648 PreScan"
        Me.chkPreScan.UseVisualStyleBackColor = True
        Me.chkPreScan.Visible = False
        '
        'btnStopMeasurement
        '
        Me.btnStopMeasurement.Location = New System.Drawing.Point(11, 90)
        Me.btnStopMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStopMeasurement.Name = "btnStopMeasurement"
        Me.btnStopMeasurement.Size = New System.Drawing.Size(103, 23)
        Me.btnStopMeasurement.TabIndex = 4
        Me.btnStopMeasurement.Text = "Stop Measurement"
        Me.btnStopMeasurement.UseVisualStyleBackColor = True
        '
        'edtNrOfScans
        '
        Me.edtNrOfScans.Location = New System.Drawing.Point(76, 17)
        Me.edtNrOfScans.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfScans.Name = "edtNrOfScans"
        Me.edtNrOfScans.Size = New System.Drawing.Size(76, 20)
        Me.edtNrOfScans.TabIndex = 3
        Me.edtNrOfScans.Text = "-1"
        '
        'btnStartMeasurement
        '
        Me.btnStartMeasurement.Location = New System.Drawing.Point(11, 60)
        Me.btnStartMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartMeasurement.Name = "btnStartMeasurement"
        Me.btnStartMeasurement.Size = New System.Drawing.Size(103, 23)
        Me.btnStartMeasurement.TabIndex = 2
        Me.btnStartMeasurement.Text = "Start Measurement"
        Me.btnStartMeasurement.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 34)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 13)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "(-1 = infinite)"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 20)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nr Of Scans"
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.edtNrOfPixels)
        Me.gbInfo.Controls.Add(Me.edtDetectorname)
        Me.gbInfo.Controls.Add(Me.Label31)
        Me.gbInfo.Controls.Add(Me.Label30)
        Me.gbInfo.Location = New System.Drawing.Point(472, 209)
        Me.gbInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.gbInfo.Size = New System.Drawing.Size(206, 84)
        Me.gbInfo.TabIndex = 7
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Selected Device Info"
        '
        'edtNrOfPixels
        '
        Me.edtNrOfPixels.Location = New System.Drawing.Point(68, 40)
        Me.edtNrOfPixels.Margin = New System.Windows.Forms.Padding(2)
        Me.edtNrOfPixels.Name = "edtNrOfPixels"
        Me.edtNrOfPixels.ReadOnly = True
        Me.edtNrOfPixels.Size = New System.Drawing.Size(127, 20)
        Me.edtNrOfPixels.TabIndex = 3
        '
        'edtDetectorname
        '
        Me.edtDetectorname.Location = New System.Drawing.Point(68, 17)
        Me.edtDetectorname.Margin = New System.Windows.Forms.Padding(2)
        Me.edtDetectorname.Name = "edtDetectorname"
        Me.edtDetectorname.ReadOnly = True
        Me.edtDetectorname.Size = New System.Drawing.Size(127, 20)
        Me.edtDetectorname.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(4, 42)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Nr Of Pixels"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 20)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(48, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Detector"
        '
        'gbVersionInfo
        '
        Me.gbVersionInfo.Controls.Add(Me.Label34)
        Me.gbVersionInfo.Controls.Add(Me.Label33)
        Me.gbVersionInfo.Controls.Add(Me.Label32)
        Me.gbVersionInfo.Controls.Add(Me.edtDLLver)
        Me.gbVersionInfo.Controls.Add(Me.edtFWver)
        Me.gbVersionInfo.Controls.Add(Me.edtFPGAver)
        Me.gbVersionInfo.Location = New System.Drawing.Point(6, 446)
        Me.gbVersionInfo.Name = "gbVersionInfo"
        Me.gbVersionInfo.Size = New System.Drawing.Size(634, 37)
        Me.gbVersionInfo.TabIndex = 25
        Me.gbVersionInfo.TabStop = False
        Me.gbVersionInfo.Text = "Version Info"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(457, 14)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(65, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "DLL Version"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(218, 14)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(87, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Firmware Version"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(13, 14)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(73, 13)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "FPGA Version"
        '
        'edtDLLver
        '
        Me.edtDLLver.Location = New System.Drawing.Point(528, 11)
        Me.edtDLLver.Name = "edtDLLver"
        Me.edtDLLver.ReadOnly = True
        Me.edtDLLver.Size = New System.Drawing.Size(100, 20)
        Me.edtDLLver.TabIndex = 2
        '
        'edtFWver
        '
        Me.edtFWver.Location = New System.Drawing.Point(311, 11)
        Me.edtFWver.Name = "edtFWver"
        Me.edtFWver.ReadOnly = True
        Me.edtFWver.Size = New System.Drawing.Size(100, 20)
        Me.edtFWver.TabIndex = 1
        '
        'edtFPGAver
        '
        Me.edtFPGAver.Location = New System.Drawing.Point(97, 11)
        Me.edtFPGAver.Name = "edtFPGAver"
        Me.edtFPGAver.ReadOnly = True
        Me.edtFPGAver.Size = New System.Drawing.Size(100, 20)
        Me.edtFPGAver.TabIndex = 0
        '
        'nudPixel
        '
        Me.nudPixel.Location = New System.Drawing.Point(137, 422)
        Me.nudPixel.Name = "nudPixel"
        Me.nudPixel.Size = New System.Drawing.Size(72, 20)
        Me.nudPixel.TabIndex = 26
        '
        'tbCounts
        '
        Me.tbCounts.Location = New System.Drawing.Point(227, 421)
        Me.tbCounts.Name = "tbCounts"
        Me.tbCounts.ReadOnly = True
        Me.tbCounts.Size = New System.Drawing.Size(101, 20)
        Me.tbCounts.TabIndex = 27
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(224, 405)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 13)
        Me.Label35.TabIndex = 28
        Me.Label35.Text = "Counts"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(134, 405)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(46, 13)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = "Pixel Nr."
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status1, Me.ToolStripSplitButton1, Me.Status3, Me.ToolStripSplitButton2, Me.Status2})
        Me.StatusBar.Location = New System.Drawing.Point(0, 486)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusBar.Size = New System.Drawing.Size(708, 22)
        Me.StatusBar.TabIndex = 30
        Me.StatusBar.Text = "Avantes"
        '
        'Status1
        '
        Me.Status1.Name = "Status1"
        Me.Status1.Size = New System.Drawing.Size(13, 17)
        Me.Status1.Text = "  "
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(16, 20)
        '
        'Status3
        '
        Me.Status3.Name = "Status3"
        Me.Status3.Size = New System.Drawing.Size(13, 17)
        Me.Status3.Text = "  "
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(16, 20)
        '
        'Status2
        '
        Me.Status2.Name = "Status2"
        Me.Status2.Size = New System.Drawing.Size(13, 17)
        Me.Status2.Text = "  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(708, 508)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.tbCounts)
        Me.Controls.Add(Me.nudPixel)
        Me.Controls.Add(Me.gbVersionInfo)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.gbMeasure)
        Me.Controls.Add(Me.gbOutput)
        Me.Controls.Add(Me.gbPrepareMeasSettings)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "VB_App"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
        Me.gbOutput.ResumeLayout(False)
        Me.gbOutput.PerformLayout()
        Me.gbMeasure.ResumeLayout(False)
        Me.gbMeasure.PerformLayout()
        Me.gbInfo.ResumeLayout(False)
        Me.gbInfo.PerformLayout()
        Me.gbVersionInfo.ResumeLayout(False)
        Me.gbVersionInfo.PerformLayout()
        CType(Me.nudPixel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigureHardwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalogIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DigiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EEPromToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbPrepareMeasSettings As System.Windows.Forms.GroupBox
    Friend WithEvents edtStartPixel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbTrigger As System.Windows.Forms.GroupBox
    Friend WithEvents edtNrOfAverages As System.Windows.Forms.TextBox
    Friend WithEvents edtIntegrationDelay As System.Windows.Forms.TextBox
    Friend WithEvents edtIntegrationTime As System.Windows.Forms.TextBox
    Friend WithEvents edtStopPixel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkTrigTypeLevel As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkTrigModeSw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigModeHw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigSourceExtHw As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigSourceSync As System.Windows.Forms.CheckBox
    Friend WithEvents chkTrigTypeEdge As System.Windows.Forms.CheckBox
    Friend WithEvents gbDarkCorrection As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbSmoothing As System.Windows.Forms.GroupBox
    Friend WithEvents edtSmoothModel As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents edtDarkHist As System.Windows.Forms.TextBox
    Friend WithEvents chkEnableDarkCorrection As System.Windows.Forms.CheckBox
    Friend WithEvents edtSaturationLevel As System.Windows.Forms.TextBox
    Friend WithEvents edtSmoothPix As System.Windows.Forms.TextBox
    Friend WithEvents gbControl As System.Windows.Forms.GroupBox
    Friend WithEvents edtLaserDelay As System.Windows.Forms.TextBox
    Friend WithEvents edtFlashesPerScan As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents edtRamSpectra As System.Windows.Forms.TextBox
    Friend WithEvents edtLaserWavelength As System.Windows.Forms.TextBox
    Friend WithEvents edtLaserWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnReadMeasFromEEProm As System.Windows.Forms.Button
    Friend WithEvents btnWriteMeasToEEProm As System.Windows.Forms.Button
    Friend WithEvents gbOutput As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents edtLastScanTime As System.Windows.Forms.TextBox
    Friend WithEvents edtAvgTimePerScan As System.Windows.Forms.TextBox
    Friend WithEvents edtFailures As System.Windows.Forms.TextBox
    Friend WithEvents edtPerformedScans As System.Windows.Forms.TextBox
    Friend WithEvents edtTotalTime As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents gbMeasure As System.Windows.Forms.GroupBox
    Friend WithEvents edtNrOfScans As System.Windows.Forms.TextBox
    Friend WithEvents btnStartMeasurement As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnStopMeasurement As System.Windows.Forms.Button
    Friend WithEvents gbInfo As System.Windows.Forms.GroupBox
    Friend WithEvents edtNrOfPixels As System.Windows.Forms.TextBox
    Friend WithEvents edtDetectorname As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label

    Friend WithEvents gbVersionInfo As System.Windows.Forms.GroupBox
    Friend WithEvents edtFPGAver As System.Windows.Forms.TextBox
    Friend WithEvents edtFWver As System.Windows.Forms.TextBox
    Friend WithEvents edtDLLver As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents nudPixel As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbCounts As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label

    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents Status1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Status3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Status2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkPreScan As System.Windows.Forms.CheckBox

End Class

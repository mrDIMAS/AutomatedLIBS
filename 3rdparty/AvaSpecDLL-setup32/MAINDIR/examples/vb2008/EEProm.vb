Imports System.Windows.Forms
Imports System.Text

Public Class EEProm
    Const SENSOR_OFFSET As Byte = 1

    Private Sub EEProm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim l_pDeviceData As DeviceConfigType = Nothing
        Dim l_Data(0) As Byte
        Dim l_Size As UInteger = 0
        Dim l_Res As Integer = 0
        Dim i As UShort
        Dim enc As Encoding = Encoding.GetEncoding("us-ascii")

        l_Res = AVS_GetParameter(Form1.m_DeviceHandle, 0, l_Size, l_pDeviceData)

        If (l_Res = ERR_INVALID_SIZE) Then
            Erase l_Data
            ReDim l_Data(l_Size - 1)
        End If

        l_Res = AVS_GetParameter(Form1.m_DeviceHandle, l_Size, l_Size, l_pDeviceData)

        If (ERR_SUCCESS <> l_Res) Then
            Erase l_Data
            MsgBox("AVS_GetParameter code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        ' ByteToConfigType(l_Data, l_pDeviceData)
        Erase l_Data

        'show parameters
        edtLength.Text = Str(l_pDeviceData.m_Len)
        edtVersion.Text = Str(l_pDeviceData.m_ConfigVersion)
        edtUserFriendly.Text = enc.GetString(l_pDeviceData.m_aUserFriendlyId)

        'show detectortype parameters
        cbDetectorType.SelectedIndex = l_pDeviceData.m_Detector.m_SensorType - SENSOR_OFFSET
        edtNrOfPixels.Text = Str(l_pDeviceData.m_Detector.m_NrPixels)
        edtWLX0.Text = Format(l_pDeviceData.m_Detector.m_aFit(0), "0.0000000E+0")
        edtWLX1.Text = Format(l_pDeviceData.m_Detector.m_aFit(1), "0.0000000E+0")
        edtWLX2.Text = Format(l_pDeviceData.m_Detector.m_aFit(2), "0.0000000E+0")
        edtWLX3.Text = Format(l_pDeviceData.m_Detector.m_aFit(3), "0.0000000E+0")
        edtWLX4.Text = Format(l_pDeviceData.m_Detector.m_aFit(4), "0.0000000E+0")

        edtGain1.Text = Format(l_pDeviceData.m_Detector.m_Gain(0), "0.000###")
        edtGain2.Text = Format(l_pDeviceData.m_Detector.m_Gain(1), "####0.00")
        edtOffset1.Text = Format(l_pDeviceData.m_Detector.m_Offset(0), "####0.00")
        edtOffset2.Text = Format(l_pDeviceData.m_Detector.m_Offset(1), "####0.00")
        edtExtOffset.Text = Format(l_pDeviceData.m_Detector.m_ExtOffset, "####0.00")

        edtNLX0.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(0), "0.0000000E+0")
        edtNLX1.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(1), "0.0000000E+0")
        edtNLX2.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(2), "0.0000000E+0")
        edtNLX3.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(3), "0.0000000E+0")
        edtNLX4.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(4), "0.0000000E+0")
        edtNLX5.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(5), "0.0000000E+0")
        edtNLX6.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(6), "0.0000000E+0")
        edtNLX7.Text = Format(l_pDeviceData.m_Detector.m_aNLCorrect(7), "0.0000000E+0")

        edtNLLow.Text = Format(l_pDeviceData.m_Detector.m_aLowNLCounts, "0.0000000E+0")
        edtNLHigh.Text = Format(l_pDeviceData.m_Detector.m_aHighNLCounts, "0.0000000E+0")

        chkEnableNL.Checked = l_pDeviceData.m_Detector.m_NLEnable

        'Dim l_EnableNL As Byte = l_pDeviceData.m_Detector.m_NLEnable

        tbDefPixels.Clear()
        For i = 0 To NR_DEFECTIVE_PIXELS - 1
            tbDefPixels.Text += Format(l_pDeviceData.m_Detector.m_DefectivePixels(i), "0.000000E+0") & System.Environment.NewLine
        Next

        'show standalone parameters
        chkEnableStandAlone.Checked = l_pDeviceData.m_StandAlone.m_Enable
        edtStartPixel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel)
        edtStopPixel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel)
        edtIntegrationTime.Text = Format(l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime, "####0.00")
        Dim l_FPGAClkCycles As Integer = l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay
        Dim l_NanoSec As Double = 125.0 * (l_FPGAClkCycles - 1.0) / 6.0
        edtIntegrationDelay.Text = Format(l_NanoSec, "######0")
        edtNrOfAverages.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages)
        edtSaturationLevel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection)

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = HW_TRIGGER_MODE) Then
            chkTrigModeHw.CheckState = CheckState.Checked
            chkTrigModeSw.CheckState = CheckState.Unchecked
        End If

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = SW_TRIGGER_MODE) Then
            chkTrigModeHw.CheckState = CheckState.Unchecked
            chkTrigModeSw.CheckState = CheckState.Checked
        End If
        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0) Then
            chkTrigSourceExtHw.CheckState = CheckState.Checked
            chkTrigSourceSync.CheckState = CheckState.Unchecked
        End If

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1) Then
            chkTrigSourceExtHw.CheckState = CheckState.Unchecked
            chkTrigSourceSync.CheckState = CheckState.Checked
        End If
        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = EDGE_TRIGGER_SOURCE) Then
            chkTrigTypeEdge.CheckState = CheckState.Checked
            chkTrigTypeLevel.CheckState = CheckState.Unchecked
        End If
        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = LEVEL_TRIGGER_SOURCE) Then
            chkTrigTypeEdge.CheckState = CheckState.Unchecked
            chkTrigTypeLevel.CheckState = CheckState.Checked
        End If
        If (l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1) Then
            chkEnableDarkCorrection.CheckState = CheckState.Checked
        Else
            chkEnableDarkCorrection.CheckState = CheckState.Unchecked
        End If

        edtDarkHist.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage)
        edtSmoothModel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel)
        edtSmoothPix.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix)
        edtFlashesPerScan.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl)
        l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay
        l_NanoSec = 125.0 * (l_FPGAClkCycles) / 6.0
        edtLaserDelay.Text = Format(l_NanoSec, "######0")
        l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth
        l_NanoSec = 125.0 * (l_FPGAClkCycles) / 6.0
        edtLaserWidth.Text = Format(l_NanoSec, "######0")
        edtLaserWavelength.Text = Format(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength, "###0.000")
        edtRamSpectra.Text = 0
        'Str(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam)
        'repared for future version
        edtNrOfMeas.Text = Str(l_pDeviceData.m_StandAlone.m_Nmsr)

        'show irradiance parameters
        edtIrradSmoothModel.Text = Str(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel)
        edtIrradSmoothPixels.Text = Str(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix)
        edtIrradInttime.Text = Format(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_CalInttime, "####0.00")
        mmIrradConversion.Clear()


        For i = 0 To (MAX_NR_PIXELS - 1)
            mmIrradConversion.Text += Format(l_pDeviceData.m_Irradiance.m_IntensityCalib.m_aCalibConvers(i), "0.000000E+0") & System.Environment.NewLine

            '   InStr()
            'Dim XYZ$ Dim LB(1 To 4) As String XYZ=text1.text For i=1 To 3 A=instr(XYZ,vbcrlf) LB(i)=left(xyz,A) xyz=right(xyz,len(xyz)-A) 
            '  mmIrradConversion.Lines(i)
            '  GetTextBoxCurrentLine()
            '   & vbCrLf
        Next
        mmIrradConversion.Refresh()

        edtIrradCalibrationType.Text = Str(l_pDeviceData.m_Irradiance.m_CalibrationType)
        edtIrradFiberDiameter.Text = Str(l_pDeviceData.m_Irradiance.m_FiberDiameter)

        'show reflectance parameters
        edtReflectanceSmoothModel.Text = Str(l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothModel)
        edtReflectanceSmoothPixels.Text = Str(l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothPix)
        edtReflectanceInttime.Text = Format(l_pDeviceData.m_Reflectance.m_CalInttime, "####0.00")

        mmReflectanceConversion.Clear()
        For i = 0 To (MAX_NR_PIXELS - 1)
            mmReflectanceConversion.Text += Format(l_pDeviceData.m_Reflectance.m_aCalibConvers(i), "0.000000E+0") & System.Environment.NewLine
        Next
        mmReflectanceConversion.Refresh()

        'show correction parameters
        mmCorrection.Clear()
        For i = 0 To (MAX_NR_PIXELS - 1)
            mmCorrection.Text += Format(l_pDeviceData.m_SpectrumCorrect.m_aSpectrumCorrect(i), "0.000000E+0") & System.Environment.NewLine
        Next
        mmCorrection.Refresh()

        'show thermistor parameters
        edtNTC1X0.Text = Format(l_pDeviceData.m_aTemperature(0).m_aFit(0), "0.0000000E+0")
        edtNTC1X1.Text = Format(l_pDeviceData.m_aTemperature(0).m_aFit(1), "0.0000000E+0")
        edtNTC1X2.Text = Format(l_pDeviceData.m_aTemperature(0).m_aFit(2), "0.0000000E+0")
        edtNTC1X3.Text = Format(l_pDeviceData.m_aTemperature(0).m_aFit(3), "0.0000000E+0")
        edtNTC1X4.Text = Format(l_pDeviceData.m_aTemperature(0).m_aFit(4), "0.0000000E+0")

        edtNTC2X0.Text = Format(l_pDeviceData.m_aTemperature(1).m_aFit(0), "0.0000000E+0")
        edtNTC2X1.Text = Format(l_pDeviceData.m_aTemperature(1).m_aFit(1), "0.0000000E+0")
        edtNTC2X2.Text = Format(l_pDeviceData.m_aTemperature(1).m_aFit(2), "0.0000000E+0")
        edtNTC2X3.Text = Format(l_pDeviceData.m_aTemperature(1).m_aFit(3), "0.0000000E+0")
        edtNTC2X4.Text = Format(l_pDeviceData.m_aTemperature(1).m_aFit(4), "0.0000000E+0")

        edtThermistorX0.Text = Format(l_pDeviceData.m_aTemperature(2).m_aFit(0), "0.0000000E+0")
        edtThermistorX1.Text = Format(l_pDeviceData.m_aTemperature(2).m_aFit(1), "0.0000000E+0")
        edtThermistorX2.Text = Format(l_pDeviceData.m_aTemperature(2).m_aFit(2), "0.0000000E+0")
        edtThermistorX3.Text = Format(l_pDeviceData.m_aTemperature(2).m_aFit(3), "0.0000000E+0")
        edtThermistorX4.Text = Format(l_pDeviceData.m_aTemperature(2).m_aFit(4), "0.0000000E+0")

        'show TEC Control parameters
        chkEnableTec.Checked = l_pDeviceData.m_TecControl.m_Enable
        edtSetPoint.Text = Format(l_pDeviceData.m_TecControl.m_Setpoint, "#####0.0")
        edtTecX0.Text = Format(l_pDeviceData.m_TecControl.m_aFit(0), "####0.00")
        edtTecX1.Text = Format(l_pDeviceData.m_TecControl.m_aFit(1), "####0.00")

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToEEProm.Click

        Dim l_pDeviceData As DeviceConfigType = Nothing
        Dim l_Size As UInteger = 0
        Dim l_Res As Integer = 0
        Dim i As UShort
        Dim enc As Encoding = Encoding.GetEncoding("us-ascii")

        l_Res = AVS_GetParameter(Form1.m_DeviceHandle, 0, l_Size, l_pDeviceData)

        If (l_Res = ERR_INVALID_SIZE) Then
            l_Res = AVS_GetParameter(Form1.m_DeviceHandle, l_Size, l_Size, l_pDeviceData)
        End If

        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("AVS_GetParameter code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        'Get parameters
        l_pDeviceData.m_ConfigVersion = CShort(edtVersion.Text)

        Dim ByteArray() As Byte = enc.GetBytes(edtUserFriendly.Text)
        Dim StringLen As Integer = edtUserFriendly.Text.Length
        For i = 0 To (USER_ID_LEN - 1)
            If (i < StringLen) Then
                l_pDeviceData.m_aUserFriendlyId(i) = ByteArray(i)
            Else
                l_pDeviceData.m_aUserFriendlyId(i) = 0
            End If
        Next i

        'Get detector parameters
        l_pDeviceData.m_Detector.m_SensorType = cbDetectorType.SelectedIndex + SENSOR_OFFSET
        l_pDeviceData.m_Detector.m_NrPixels = CShort(edtNrOfPixels.Text)
        l_pDeviceData.m_Detector.m_aFit(0) = CSng(edtWLX0.Text)
        l_pDeviceData.m_Detector.m_aFit(1) = CSng(edtWLX1.Text)
        l_pDeviceData.m_Detector.m_aFit(2) = CSng(edtWLX2.Text)
        l_pDeviceData.m_Detector.m_aFit(3) = CSng(edtWLX3.Text)
        l_pDeviceData.m_Detector.m_aFit(4) = CSng(edtWLX4.Text)
        l_pDeviceData.m_Detector.m_Gain(0) = CSng(edtGain1.Text)
        l_pDeviceData.m_Detector.m_Gain(1) = CSng(edtGain2.Text)
        l_pDeviceData.m_Detector.m_Offset(0) = CSng(edtOffset1.Text)
        l_pDeviceData.m_Detector.m_Offset(1) = CSng(edtOffset2.Text)
        l_pDeviceData.m_Detector.m_ExtOffset = CSng(edtExtOffset.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(0) = CDbl(edtNLX0.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(1) = CDbl(edtNLX1.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(2) = CDbl(edtNLX2.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(3) = CDbl(edtNLX3.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(4) = CDbl(edtNLX4.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(5) = CDbl(edtNLX5.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(6) = CDbl(edtNLX6.Text)
        l_pDeviceData.m_Detector.m_aNLCorrect(7) = CDbl(edtNLX7.Text)

        l_pDeviceData.m_Detector.m_aLowNLCounts = CDbl(edtNLLow.Text)
        l_pDeviceData.m_Detector.m_aHighNLCounts = CDbl(edtNLHigh.Text)

        If (chkEnableNL.Checked) Then

            l_pDeviceData.m_Detector.m_NLEnable = True
        Else
            l_pDeviceData.m_Detector.m_NLEnable = False
        End If

        Dim Array() As String = tbDefPixels.Lines
        Dim MaxLen As Integer = Array.Length

        For i = 0 To NR_DEFECTIVE_PIXELS - 1 And (i < MaxLen - 2)
            l_pDeviceData.m_Detector.m_DefectivePixels(i) = CUShort(Array(i))
        Next i

        'Get standalone parameters
        l_pDeviceData.m_StandAlone.m_Enable = chkEnableStandAlone.Checked
        l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel = CUShort(edtStartPixel.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel = CUShort(edtStopPixel.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime = CSng(edtIntegrationTime.Text)
        Dim l_NanoSec As Double = CDbl(edtIntegrationDelay.Text)
        Dim l_FPGAClkCycles As UInteger = CUInt(0.5 + 6.0 * (l_NanoSec + 20.84) / 125.0)
        l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay = l_FPGAClkCycles
        l_pDeviceData.m_StandAlone.m_Meas.m_NrAverages = CUInt(edtNrOfAverages.Text)

        If (chkTrigModeHw.Checked) Then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 1
        Else
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 0
        End If

        If (chkTrigSourceSync.Checked) Then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1
        Else
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0
        End If

        If (chkTrigTypeLevel.Checked) Then
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 1
        Else
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = 0
        End If

        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = chkTrigModeHw.Checked
        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = chkTrigSourceSync.Checked
        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = chkTrigSourceSync.Checked

        l_pDeviceData.m_StandAlone.m_Meas.m_SaturationDetection = CByte(edtSaturationLevel.Text)

        If (chkEnableDarkCorrection.Checked) Then
            l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1
        Else
            l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 0
        End If

        'l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = chkEnableDarkCorrection.Checked
        l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage = CByte(edtDarkHist.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix = CUShort(edtSmoothPix.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel = CByte(edtSmoothModel.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl = CUShort(edtFlashesPerScan.Text)
        l_NanoSec = CDbl(edtLaserDelay.Text)
        l_FPGAClkCycles = CUInt(6.0 * l_NanoSec / 125.0)
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay = l_FPGAClkCycles
        l_NanoSec = CDbl(edtLaserWidth.Text)
        l_FPGAClkCycles = CUInt(6.0 * l_NanoSec / 125.0)
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth = l_FPGAClkCycles
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength = CSng(edtLaserWavelength.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam = 0
        'CUShort(edtRamSpectra.Text)' prepared for future version
        l_pDeviceData.m_StandAlone.m_Nmsr = CShort(edtNrOfMeas.Text)

        'Get Irradiance parameters
        l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothModel = CByte(edtIrradSmoothModel.Text)
        l_pDeviceData.m_Irradiance.m_IntensityCalib.m_Smoothing.m_SmoothPix = CUShort(edtIrradSmoothPixels.Text)
        l_pDeviceData.m_Irradiance.m_IntensityCalib.m_CalInttime = CSng(edtIrradInttime.Text)


        Erase Array
        Array = mmIrradConversion.Lines
        MaxLen = Array.Length

        For i = 0 To MAX_NR_PIXELS - 1 And (i < MaxLen - 2)
            l_pDeviceData.m_Irradiance.m_IntensityCalib.m_aCalibConvers(i) = CSng(Array(i))
        Next i

        l_pDeviceData.m_Irradiance.m_CalibrationType = CByte(edtIrradCalibrationType.Text)
        l_pDeviceData.m_Irradiance.m_FiberDiameter = CInt(edtIrradFiberDiameter.Text)

        'Get Reflectance parameters
        l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothModel = CByte(edtReflectanceSmoothModel.Text)
        l_pDeviceData.m_Reflectance.m_Smoothing.m_SmoothPix = CUShort(edtReflectanceSmoothPixels.Text)
        l_pDeviceData.m_Reflectance.m_CalInttime = CSng(edtReflectanceInttime.Text)

        Erase Array
        Array = mmReflectanceConversion.Lines
        MaxLen = Array.Length


        For i = 0 To MAX_NR_PIXELS - 1 And (i < MaxLen - 2)
            l_pDeviceData.m_Reflectance.m_aCalibConvers(i) = CSng(Array(i))
        Next i

        Erase Array
        Array = mmCorrection.Lines
        MaxLen = Array.Length


        For i = 0 To MAX_NR_PIXELS - 1 And (i < MaxLen - 2)
            l_pDeviceData.m_SpectrumCorrect.m_aSpectrumCorrect(i) = CSng(Array(i))
        Next i

        'Get Thermistor parameters
        l_pDeviceData.m_aTemperature(0).m_aFit(0) = CSng(edtNTC1X0.Text)
        l_pDeviceData.m_aTemperature(0).m_aFit(1) = CSng(edtNTC1X1.Text)
        l_pDeviceData.m_aTemperature(0).m_aFit(2) = CSng(edtNTC1X2.Text)
        l_pDeviceData.m_aTemperature(0).m_aFit(3) = CSng(edtNTC1X3.Text)
        l_pDeviceData.m_aTemperature(0).m_aFit(4) = CSng(edtNTC1X4.Text)
        l_pDeviceData.m_aTemperature(1).m_aFit(0) = CSng(edtNTC2X0.Text)
        l_pDeviceData.m_aTemperature(1).m_aFit(1) = CSng(edtNTC2X1.Text)
        l_pDeviceData.m_aTemperature(1).m_aFit(2) = CSng(edtNTC2X2.Text)
        l_pDeviceData.m_aTemperature(1).m_aFit(3) = CSng(edtNTC2X3.Text)
        l_pDeviceData.m_aTemperature(1).m_aFit(4) = CSng(edtNTC2X4.Text)
        l_pDeviceData.m_aTemperature(2).m_aFit(0) = CSng(edtThermistorX0.Text)
        l_pDeviceData.m_aTemperature(2).m_aFit(1) = CSng(edtThermistorX1.Text)
        l_pDeviceData.m_aTemperature(2).m_aFit(2) = CSng(edtThermistorX2.Text)
        l_pDeviceData.m_aTemperature(2).m_aFit(3) = CSng(edtThermistorX3.Text)
        l_pDeviceData.m_aTemperature(2).m_aFit(4) = CSng(edtThermistorX4.Text)


        'Get Tec Control parameters
        l_pDeviceData.m_TecControl.m_Enable = chkEnableTec.Checked
        l_pDeviceData.m_TecControl.m_Setpoint = CSng(edtSetPoint.Text)
        l_pDeviceData.m_TecControl.m_aFit(0) = CSng(edtTecX0.Text)
        l_pDeviceData.m_TecControl.m_aFit(1) = CSng(edtTecX1.Text)

        'Write parameters
        l_Res = AVS_SetParameter(Form1.m_DeviceHandle, l_pDeviceData)

        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("AVS_SetParameter code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    '    Private Declare Function SendMessage Lib "user32" _
    '  Alias "SendMessageA" _
    ' (ByVal hwnd As Long, _
    'ByVal wMsg As Long, _
    'ByVal wParam As Long, _
    ' ByVal lParam As Any) As Long

    'Private Declare Sub CopyMemory Lib "kernel32.dll" _
    ' Alias "RtlMoveMemory" _
    ' (ByVal Destination As Variable, _
    'ByVal Source As Any, _
    '  ByVal Length As Long)

    ' Private Const EM_GETLINECOUNT = &HBA
    ' Private Const EM_LINEINDEX = &HBB
    ' Private Const EM_LINELENGTH = &HC1
    ' Private Const EM_GETLINE = &HC4

    'Function GetTextboxLine(ByVal txtTextbox As Control, Optional ByVal lngLineNumber As Long = 1) As String
    'Dim intLineLength As Integer
    'Dim lngIndexChar As Long
    'Dim lngRetValue As Long
    'Dim lngLineCount As Long
    'Dim strLine As String

    'get total number of lines 
    'lngLineCount = SendMessage(txtTextbox.hwnd, EM_GETLINECOUNT, 0&, ByVal 0&) 
    'If the line requested is beyond the end or before the beginning of the text box 
    'If lngLineNumber > lngLineCount Or lngLineNumber < 1 Then
    'return an empty string 
    '           GetTextboxLine = ""
    '          Exit Function
    '     End If

    'subtract 1 from requested line number because the API uses 0 based line numbers 
    '    lngLineNumber = lngLineNumber - 1

    'get the text position of the first char in requested line 
    'lngIndexChar = SendMessage(txtTextbox.hwnd, EM_LINEINDEX, ByVal lngLineNumber, ByVal 0&) 
    'get the length of that line 
    'intLineLength = SendMessage(txtTextbox.hwnd, EM_LINELENGTH, ByVal lngIndexChar, ByVal 0&) 
    'fill a buffer string with spaces- minimum length of 2 required for the next line 
    '    strLine = Space$(IIf(intLineLength >= 2, intLineLength, 2))
    'copy the binary value of linelength into the beginning of the buffer string 
    ' this is necessary becuase the last argument for this call needs to contain the length 
    ' and is also used to return the string. 
    'CopyMemory ByVal strLine, intLineLength, Len(intLineLength) 
    'put the text of the line into the string buffer - strLine contains the length 
    'lngRetValue = SendMessage(txtTextbox.hwnd, EM_GETLINE, ByVal lngLineNumber, ByVal strLine) 
    'trim ending null char if the line is only 1 char long 
    '   If intLineLength = 1 Then strLine = Left(strLine, 1)
    'return the line 
    '    GetTextboxLine = strLine
    ' End Function



    Private Sub chkTrigModeHw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigModeHw.CheckedChanged
        chkTrigModeSw.Checked = Not (chkTrigModeHw.Checked)
    End Sub

    Private Sub chkTrigModeSw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigModeSw.CheckedChanged
        chkTrigModeHw.Checked = Not (chkTrigModeSw.Checked)
    End Sub

    Private Sub chkTrigSourceExtHw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigSourceExtHw.CheckedChanged
        chkTrigSourceSync.Checked = Not (chkTrigSourceExtHw.Checked)
    End Sub

    Private Sub chkTrigSourceSync_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigSourceSync.CheckedChanged
        chkTrigSourceExtHw.Checked = Not (chkTrigSourceSync.Checked)
    End Sub

    Private Sub chkTrigTypeEdge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigTypeEdge.CheckedChanged
        chkTrigTypeLevel.Checked = Not (chkTrigTypeEdge.Checked)
    End Sub

    Private Sub chkTrigTypeLevel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigTypeLevel.CheckedChanged
        chkTrigTypeEdge.Checked = Not (chkTrigTypeLevel.Checked)
    End Sub
End Class




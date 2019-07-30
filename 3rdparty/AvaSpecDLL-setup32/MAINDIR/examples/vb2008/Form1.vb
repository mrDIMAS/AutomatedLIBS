
Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports Microsoft.VisualBasic

Public Class Form1

    Public m_pLambda = New PixelArrayType
    Public m_NrPixels As UShort
    Public m_StartPixels As UShort
    Public m_StopPixels As UShort
    Public m_StartTicks As ULong
    Public m_Measurements As UInteger
    Public m_Failures As UInteger
    Public m_GraphicsDisabled As Boolean
    Public m_PreviousTimeStamp As UInteger
    Public m_DeviceHandle As IntPtr
    Public m_StopScan As Integer = 0

    Const TIMEOUT As Integer = 10000

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' AVS_Done()
        'TODO: clean up
        Me.Close()
        End
    End Sub

    Private Sub AnalogIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalogIOToolStripMenuItem.Click
        Dim MyAnalogIO As New AnalogIO()
        MyAnalogIO.ShowDialog()
    End Sub

    Private Sub DigiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DigiToolStripMenuItem.Click
        Dim MyDigitalIO As New DigitalIO()
        MyDigitalIO.ShowDialog()
    End Sub

    Private Sub EEPromToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EEPromToolStripMenuItem.Click
        Dim MyEEProm As New EEProm()
        MyEEProm.ShowDialog()
    End Sub


    Private Sub btnStartMeasurement_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartMeasurement.Click
        Dim l_NanoSec As Double
        Dim l_FPGAClkCycles As UInteger
        Dim l_Res As Integer
        Dim l_PrepareMeasData As MeasConfigType

        'prevent second StartMeasurementClick before sequence ends.
        btnStartMeasurement.Enabled = False
        'Prepare(Measurement)
        '   StartPixel
        l_PrepareMeasData.m_StartPixel = CUShort(edtStartPixel.Text)
        '   StopPixel
        l_PrepareMeasData.m_StopPixel = CUShort(edtStopPixel.Text)
        '   IntegrationTime
        l_PrepareMeasData.m_IntegrationTime = CSng(edtIntegrationTime.Text)
        '   IntegrationDelay
        l_NanoSec = CDbl(edtIntegrationDelay.Text)
        l_FPGAClkCycles = CUInt(6.0 * (l_NanoSec + 20.84) / 125.0)
        l_PrepareMeasData.m_IntegrationDelay = l_FPGAClkCycles
        '   Number of Averages
        l_PrepareMeasData.m_NrAverages = CUInt(edtNrOfAverages.Text)
        '   DarkCorrectionType
        If (chkEnableDarkCorrection.Checked) Then
            l_PrepareMeasData.m_CorDynDark.m_Enable = 1
        Else
            l_PrepareMeasData.m_CorDynDark.m_Enable = 0
        End If
        l_PrepareMeasData.m_CorDynDark.m_ForgetPercentage = CByte(edtDarkHist.Text)
        '   SmoothingType   
        l_PrepareMeasData.m_Smoothing.m_SmoothPix = CUShort(edtSmoothPix.Text)
        l_PrepareMeasData.m_Smoothing.m_SmoothModel = CByte(edtSmoothModel.Text)
        '   SaturationDetection
        l_PrepareMeasData.m_SaturationDetection = CByte(edtSaturationLevel.Text)
        '   TriggerType
        If (chkTrigModeHw.Checked) Then
            l_PrepareMeasData.m_Trigger.m_Mode = 1
        Else
            l_PrepareMeasData.m_Trigger.m_Mode = 0
        End If
        If (chkTrigSourceSync.Checked) Then
            l_PrepareMeasData.m_Trigger.m_Source = 1
        Else
            l_PrepareMeasData.m_Trigger.m_Source = 0
        End If
        If (chkTrigTypeLevel.Checked) Then
            l_PrepareMeasData.m_Trigger.m_SourceType = 1
        Else
            l_PrepareMeasData.m_Trigger.m_SourceType = 0
        End If
        '   ControlSettingsType
        l_PrepareMeasData.m_Control.m_StrobeControl = CUShort(edtFlashesPerScan.Text)
        l_NanoSec = CDbl(edtLaserDelay.Text)
        l_FPGAClkCycles = CUInt(6.0 * l_NanoSec / 125.0)
        l_PrepareMeasData.m_Control.m_LaserDelay = l_FPGAClkCycles
        l_NanoSec = CDbl(edtLaserWidth.Text)
        l_FPGAClkCycles = CUInt(6.0 * l_NanoSec / 125.0)
        l_PrepareMeasData.m_Control.m_LaserWidth = l_FPGAClkCycles
        l_PrepareMeasData.m_Control.m_LaserWaveLength = CSng(edtLaserWavelength.Text)
        l_PrepareMeasData.m_Control.m_StoreToRam = CUShort(edtRamSpectra.Text)
        l_Res = AVS_PrepareMeasure(m_DeviceHandle, l_PrepareMeasData)

        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("code:" & Str(l_Res), MsgBoxStyle.Exclamation, "Error")
        End If

        'Get Nr Of Scans
        Dim l_NrOfScans As Short = CShort(edtNrOfScans.Text)
        If ((l_PrepareMeasData.m_Control.m_StoreToRam > 0) And (l_NrOfScans <> 1)) Then
            edtNrOfScans.Text = "1"
            l_NrOfScans = 1
            MsgBox(Str(l_PrepareMeasData.m_Control.m_StoreToRam) & " scans will be stored to RAM. " _
            & "The number of measurements (a_Nmsr in AVS_Measure) has been set to 1", _
            MsgBoxStyle.Information, "Information")
        End If

        'Start Measurement
        m_StartTicks = My.Computer.Clock.TickCount
        m_Measurements = 0
        m_Failures = 0
        edtTotalTime.Text = "0"
        edtPerformedScans.Text = "0"
        edtFailures.Text = "0"
        m_StartPixels = l_PrepareMeasData.m_StartPixel
        m_StopPixels = l_PrepareMeasData.m_StopPixel
        nudPixel.Minimum = l_PrepareMeasData.m_StartPixel
        nudPixel.Maximum = l_PrepareMeasData.m_StopPixel


        l_Res = AVS_Measure(m_DeviceHandle, Handle, l_NrOfScans)

        If (ERR_SUCCESS <> l_Res) Then
            Select Case l_Res
                Case ERR_INVALID_PARAMETER
                    Status2.Text = "Meas.Status: invalid parameter"
                Case Else
                    Status2.Text = "Meas.Status: start failed, code: " & Str(l_Res)
            End Select
        Else
            Status2.Text = "Meas.Status: pending"
        End If
    End Sub

    <System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
   Protected Overrides Sub WndProc(ByRef a_WinMess As Message)
        Dim l_Ticks As Long
        Dim l_AvgScantimeRam As Double

        If (a_WinMess.Msg = WM_MEAS_READY) Then
            If (a_WinMess.WParam.ToInt32() >= ERR_SUCCESS) Then
                If (ERR_SUCCESS = a_WinMess.WParam) Then

                    Dim l_pSpectrum As PixelArrayType = Nothing
                    Dim l_pSaturated As SaturatedArrayType = Nothing

                    Status2.Text = "Meas.Status: success"

                    If (m_NrPixels > 0) Then
                        If (0 = AVS_GetLambda(m_DeviceHandle, m_pLambda)) Then
                            'do nothing
                        End If

                        Dim l_Time As UInteger

                        If (ERR_SUCCESS = AVS_GetScopeData(m_DeviceHandle, l_Time, l_pSpectrum)) Then

                            Dim l_Dif As UInteger = l_Time - m_PreviousTimeStamp 'l_Time in 10 us ticks
                            m_PreviousTimeStamp = l_Time

                            If (l_Dif <> 0) Then
                                edtLastScanTime.Text = Format(l_Dif / 100.0, "####0.00") 'millisec
                            End If

                            AVS_GetSaturatedPixels(m_DeviceHandle, l_pSaturated)
                            tbCounts.Text = Format(l_pSpectrum.Value(nudPixel.Value), "#####0.0")
                        Else
                            Status2.Text = "Meas.Status: no data avail."
                        End If
                    End If
                    m_Measurements += 1
                    l_Ticks = My.Computer.Clock.TickCount
                    edtTotalTime.Text = Str((l_Ticks - m_StartTicks) / 1000)
                    edtPerformedScans.Text = Str(m_Measurements)
                    edtAvgTimePerScan.Text = Format(1.0 * (l_Ticks - m_StartTicks) / m_Measurements, "####0.00")
                    If (CShort(edtNrOfScans.Text) > 0) Then
                        btnStartMeasurement.Enabled = (CShort(edtNrOfScans.Text) = m_Measurements)
                    End If
                Else
                    ' a WParam > 0 indicates a response to StoreToRam
                    ' using StoreToRAM requires firmware version 0.20.0.0 or later
                    ' a_WinMess.WParam holds the number of scans stored in RAM
                    ' import into application by call to AVS_GetScopeData for each scan
                    Status2.Text = "Meas.Status: Reading RAM"
                    l_AvgScantimeRam = 0.0
                    Dim j As Integer
                    Dim l_Dif As Double
                    For j = 1 To a_WinMess.WParam.ToInt32()
                        Dim l_pSpectrum As PixelArrayType = Nothing
                        Dim l_Time As UInteger = 0
                        If AVS_GetScopeData(m_DeviceHandle, l_Time, l_pSpectrum) = ERR_SUCCESS Then
                            l_Dif = l_Time - m_PreviousTimeStamp
                            m_PreviousTimeStamp = l_Time
                            If (l_Dif <> 0) Then
                                edtLastScanTime.Text = (l_Dif / 100.0).ToString("####0.00")
                            End If
                            If (j > 1) Then
                                l_AvgScantimeRam = (l_AvgScantimeRam * (j - 2) + l_Dif / 100.0) / (j - 1)
                                edtAvgTimePerScan.Text = l_AvgScantimeRam.ToString("####0.00")
                            End If
                        Else
                            Status2.Text = "Meas.Status: no data avail."
                        End If
                        l_Ticks = My.Computer.Clock.TickCount
                        edtTotalTime.Text = ((l_Ticks - m_StartTicks) / 1000.0).ToString
                        edtPerformedScans.Text = j.ToString
                    Next
                    Status2.Text = "Finished Reading RAM"
                    btnStartMeasurement.Enabled = True
                End If
            Else
                Status2.Text = "Meas.Status: failed. Error " & a_WinMess.WParam.ToString
                m_Failures += 1
            End If
            edtFailures.Text = Str(m_Failures)
        End If
        MyBase.WndProc(a_WinMess)
    End Sub

    Private Sub btnStopMeasurement_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopMeasurement.Click
        Status2.Text = "Meas.Status: stop "
        Dim l_Res As Integer = AVS_StopMeasure(m_DeviceHandle)

        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
        End If

        btnStartMeasurement.Enabled = True
    End Sub

    Private Sub btnReadMeasFromEEProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadMeasFromEEProm.Click

        Dim l_pDeviceData As DeviceConfigType = Nothing
        Dim l_Size As UInteger
        Dim l_Res As Integer

        l_Res = AVS_GetParameter(m_DeviceHandle, 0, l_Size, l_pDeviceData)
        If (l_Res = ERR_INVALID_SIZE) Then
            l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, l_Size, l_pDeviceData)
        End If
        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        ShowMeasurementSettings(l_pDeviceData)
    End Sub

    Private Sub btnWriteMeasToEEProm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteMeasToEEProm.Click

        Dim l_pDeviceData As DeviceConfigType = Nothing
        Dim l_Size As UInteger = 0
        Dim l_Res As Integer = 0

        l_Res = AVS_GetParameter(m_DeviceHandle, 0, l_Size, l_pDeviceData)

        If (l_Res = ERR_INVALID_SIZE) Then
            l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, l_Size, l_pDeviceData)
        End If

        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("AVS_GetParameter code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        'Get measurement parameters from main window
        l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel = CUShort(edtStartPixel.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel = CUShort(edtStopPixel.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime = CSng(edtIntegrationTime.Text)

        Dim l_NanoSec As Double = CDbl(edtIntegrationDelay.Text)
        Dim l_FPGAClkCycles As UInteger = CUInt(6.0 * (l_NanoSec + 20.84) / 125.0)

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
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1
        Else
            l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0
        End If

        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = chkTrigModeHw.Checked
        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = chkTrigSourceSync.Checked
        'l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = chkTrigTypeLevel.Checked
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
        l_FPGAClkCycles = CUInt((6.0 * l_NanoSec / 125.0))
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay = l_FPGAClkCycles
        l_NanoSec = CDbl(edtLaserWidth.Text)
        l_FPGAClkCycles = CUInt((6.0 * l_NanoSec / 125.0))
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth = l_FPGAClkCycles
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength = CSng(edtLaserWavelength.Text)
        l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam = CUShort(edtRamSpectra.Text)
        l_pDeviceData.m_StandAlone.m_Nmsr = CShort(edtNrOfScans.Text)
        l_Res = AVS_SetParameter(Me.m_DeviceHandle, l_pDeviceData)
        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("AVS_SetParameter code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            Return
        End If
    End Sub

    Private Sub chkTrigTypeEdge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigTypeEdge.CheckedChanged
        chkTrigTypeLevel.Checked = Not (chkTrigTypeEdge.Checked)
    End Sub

    Private Sub chkTrigTypeLevel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTrigTypeLevel.CheckedChanged
        chkTrigTypeEdge.Checked = Not (chkTrigTypeLevel.Checked)
    End Sub

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

    Private Sub DisconnectGui()
        edtDetectorname.Text = ""
        edtNrOfPixels.Text = ""
        edtFPGAver.Text = ""
        edtFWver.Text = ""
        edtDLLver.Text = ""
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_DeviceHandle = INVALID_AVS_HANDLE_VALUE
        m_StopScan = 0
        Me.Cursor = Cursors.WaitCursor()
        StatusBar.Text = "Open communication busy"
        Status1.Text = "Open communication busy"
        Dim l_Active As AvsIdentityType = Nothing

        Dim l_Port As Integer = AVS_Init(0)

        AVS_Register(Handle)

        If (l_Port > 0) Then
            Status1.Text = "Connected: USB"
            UpdateList(l_Active)
        Else
            AVS_Done()
            l_Port = AVS_Init(-1)
            ' try Ethernet/USB autodetect
            If (l_Port > 0) Then
                Status1.Text = "Connected: Ethernet/USB"
                UpdateList(l_Active)
            Else
                Status1.Text = "Open communication failed"
                AVS_Done()
                Me.Cursor = Cursors.Default
                MsgBox("Open communication failed", MsgBoxStyle.Exclamation, "Error")
                Me.Close()
                Return
            End If
        End If

        '*******************************************************************************
        '                               Activate Spectrometer
        '*******************************************************************************

        Dim l_hDevice As IntPtr
        Dim l_ByteArray(74) As Byte

        'Array.Copy(l_Active.SerialNumber, 0, l_ByteArray, 0, AVS_SERIAL_LEN)
        'Array.Copy(l_Active.UserFriendlyName, 0, l_ByteArray, AVS_SERIAL_LEN, USER_ID_LEN)
        l_ByteArray(74) = l_Active.Status

        l_hDevice = AVS_Activate(l_Active)

        'm_DeviceHandle = l_hDevice
        'UpdateList(l_Active)
        'ConnectGui()

        If (INVALID_AVS_HANDLE_VALUE = l_hDevice) Then
            MsgBox("Error opening device " & l_Active.SerialNumber, MsgBoxStyle.Exclamation, "Error")
        Else
            m_DeviceHandle = l_hDevice
            UpdateList(l_Active)
            ConnectGui()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    '*******************************************************************************
    '                       Find first available spectrometer
    '*******************************************************************************
    Private Sub UpdateList(ByRef l_Id As AvsIdentityType)

        Dim i As Integer = 0
        Dim l_Size As UInteger = 0
        Dim l_RequiredSize As UInteger = 0
        Dim l_NrDevices As Integer
        Dim l_pId() As AvsIdentityType

        l_NrDevices = AVS_GetNrOfDevices()
        l_RequiredSize = l_NrDevices * 75

        If (l_RequiredSize > 0) Then
            l_pId = New AvsIdentityType(l_NrDevices - 1) {}
            l_Size = l_RequiredSize
            l_NrDevices = AVS_GetList(l_Size, l_RequiredSize, l_pId)
            For i = 0 To (l_NrDevices - 1)
                Select Case l_pId(i).Status
                    Case DEVICE_STATUS.UNKNOWN
                        Status3.Text = "Unknown Device found!"
                    Case DEVICE_STATUS.USB_AVAILABLE, DEVICE_STATUS.ETH_AVAILABLE
                        l_Id.SerialNumber = l_pId(i).SerialNumber
                        l_Id.Status = l_pId(i).Status
                        l_Id.UserFriendlyName = l_pId(i).UserFriendlyName
                        Status3.Text = "Spectrometer " & l_pId(i).SerialNumber & " found!"
                        Exit For
                    Case DEVICE_STATUS.USB_IN_USE_BY_APPLICATION, DEVICE_STATUS.ETH_IN_USE_BY_APPLICATION
                        Status3.Text = "Spectrometer is used by the application "
                        Exit For
                    Case DEVICE_STATUS.USB_IN_USE_BY_OTHER, DEVICE_STATUS.ETH_IN_USE_BY_OTHER
                        Status3.Text = "Device is used by other"
                    Case Else
                        Status3.Text = "??????"
                End Select
            Next i
            Erase l_pId
        End If
    End Sub
    '*******************************************************************************
    '                      ConnectGui
    '*******************************************************************************
    Private Sub ConnectGui()

        Dim l_Res As Integer
        Dim l_Size As UInteger ' = 63484
        Dim a_Fpga As String16Type = Nothing
        Dim a_As5216 As String16Type = Nothing
        Dim a_Dll As String16Type = Nothing

        Dim l_pDeviceData As DeviceConfigType = Nothing
        l_Res = AVS_GetVersionInfo(m_DeviceHandle, a_Fpga, a_As5216, a_Dll)

        If (ERR_SUCCESS = l_Res) Then
            edtFPGAver.Text = a_Fpga.String16
            edtFWver.Text = a_As5216.String16
            edtDLLver.Text = a_Dll.String16
        End If

        If (ERR_SUCCESS = AVS_GetNumPixels(m_DeviceHandle, m_NrPixels)) Then
            edtNrOfPixels.Text = Str(m_NrPixels)
        End If

        'Dim test As DetectorType
        'Dim test As IrradianceType
        'Dim test As SpectrumCalibrationType
        'Dim test As SpectrumCorrectionType
        'Dim test As SDCardType
        'Dim test As StandAloneType
        'Dim test As TecControlType
        'Dim test As ProcessControlType
        'Dim test As DeviceConfigType
        'l_Size = Marshal.SizeOf(test)

        l_Res = AVS_GetParameter(m_DeviceHandle, 0, l_Size, l_pDeviceData)

        If (l_Res = ERR_INVALID_SIZE) Then
            l_Res = AVS_GetParameter(m_DeviceHandle, l_Size, l_Size, l_pDeviceData)
        End If

        If (l_Res <> ERR_SUCCESS) Then
            DisconnectGui()
            'Erase l_Data
            Return
        End If

        Select Case l_pDeviceData.m_Detector.m_SensorType
            Case SENS_TYPE.SENS_HAMS8378_256
                edtDetectorname.Text = "HAMS8378_256"
            Case SENS_TYPE.SENS_HAMS8378_1024
                edtDetectorname.Text = "HAMS8378_1024"
            Case SENS_TYPE.SENS_ILX554
                edtDetectorname.Text = "ILX554"
            Case SENS_TYPE.SENS_HAMS9201
                edtDetectorname.Text = "HAMS9201"
            Case SENS_TYPE.SENS_TCD1304
                edtDetectorname.Text = "TCD1304"
                chkPreScan.Visible = True
                chkPreScan.Checked = True
                l_Res = AVS_SetPrescanMode(m_DeviceHandle, chkPreScan.Checked)
            Case SENS_TYPE.SENS_TSL1301
                edtDetectorname.Text = "TSL1301"
            Case SENS_TYPE.SENS_TSL1401
                edtDetectorname.Text = "TSL1401"
            Case SENS_TYPE.SENS_HAMS8378_512
                edtDetectorname.Text = "HAMS8378_512"
            Case SENS_TYPE.SENS_HAMS9840
                edtDetectorname.Text = "HAMS9840"
            Case SENS_TYPE.SENS_ILX511
                edtDetectorname.Text = "ILX511"
            Case SENS_TYPE.SENS_HAMS10420_2048X64
                edtDetectorname.Text = "HAMS10420_2048X64"
            Case SENS_TYPE.SENS_HAMS11071_2048X64
                edtDetectorname.Text = "HAMS11071_2048X64"
            Case SENS_TYPE.SENS_HAMS7031_1024X122
                edtDetectorname.Text = "HAMS7031_1024X122"
            Case SENS_TYPE.SENS_HAMS7031_1024X58
                edtDetectorname.Text = "HAMS7031_1024X58"
            Case SENS_TYPE.SENS_HAMS11071_2048X16
                edtDetectorname.Text = "HAMS11071_2048X16"
            Case SENS_TYPE.SENS_HAMS11155
                edtDetectorname.Text = "HAMS11155"
            Case SENS_TYPE.SENS_SU256LSB
                edtDetectorname.Text = "SU256LSB"
            Case SENS_TYPE.SENS_SU512LDB
                edtDetectorname.Text = "SU512LDB"
            Case SENS_TYPE.SENS_HAMS11638
                edtDetectorname.Text = "HAMS11638"
            Case SENS_TYPE.SENS_HAMS11639
                edtDetectorname.Text = "HAMS11639"
            Case SENS_TYPE.SENS_HAMS12443
                edtDetectorname.Text = "HAMS12443"
            Case SENS_TYPE.SENS_HAMG9208_512
                edtDetectorname.Text = "HAMG9208_512"
            Case Else
                edtDetectorname.Text = "???????"
        End Select

        m_StartPixels = l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel
        m_StopPixels = l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel
        If (ERR_SUCCESS = AVS_GetLambda(m_DeviceHandle, m_pLambda)) Then
            'Chart1.BottomAxis.SetMinMax(m_pLambda[m_StartPixels],m_pLambda[m_StopPixels]);
        End If
        ShowMeasurementSettings(l_pDeviceData)
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If (m_DeviceHandle <> INVALID_AVS_HANDLE_VALUE) Then
            Dim l_Res As Integer = AVS_StopMeasure(m_DeviceHandle)
            If (ERR_SUCCESS <> l_Res) Then
                MsgBox("Error in AVS_StopMeasure, code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
            End If
        End If
        Erase m_pLambda
        m_NrPixels = 0
        AVS_Done()
    End Sub

    Private Sub ShowMeasurementSettings(ByVal l_pDeviceData As DeviceConfigType)

        'show measurement settings
        edtStartPixel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_StartPixel)
        edtStopPixel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_StopPixel)

        edtIntegrationTime.Text = Format(l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationTime, "####0.00")
        Dim l_FPGAClkCycles As UInteger = l_pDeviceData.m_StandAlone.m_Meas.m_IntegrationDelay
        Dim l_NanoSec As Double = CDbl(125.0 * (l_FPGAClkCycles - 1.0) / 6.0)
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
        ' chkTrigModeHw.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 1)
        ' chkTrigModeSw.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Mode = 0)

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 0) Then
            chkTrigSourceExtHw.CheckState = CheckState.Checked
            chkTrigSourceSync.CheckState = CheckState.Unchecked
        End If

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source = 1) Then
            chkTrigSourceExtHw.CheckState = CheckState.Unchecked
            chkTrigSourceSync.CheckState = CheckState.Checked
        End If
        ' chkTrigSourceExtHw.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source == 0)
        ' chkTrigSourceSync.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_Source == 1)

        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = EDGE_TRIGGER_SOURCE) Then
            chkTrigTypeEdge.CheckState = CheckState.Checked
            chkTrigTypeLevel.CheckState = CheckState.Unchecked
        End If
        If (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType = LEVEL_TRIGGER_SOURCE) Then
            chkTrigTypeEdge.CheckState = CheckState.Unchecked
            chkTrigTypeLevel.CheckState = CheckState.Checked
        End If
        ' chkTrigTypeEdge.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType == 0)
        ' chkTrigTypeLevel.CheckState = (l_pDeviceData.m_StandAlone.m_Meas.m_Trigger.m_SourceType == 1)

        If (l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable = 1) Then
            chkEnableDarkCorrection.CheckState = CheckState.Checked
        Else
            chkEnableDarkCorrection.CheckState = CheckState.Unchecked
        End If
        ' chkEnableDarkCorrection.Checked = (l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_Enable == 1)

        edtDarkHist.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_CorDynDark.m_ForgetPercentage)
        edtSmoothModel.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothModel)
        edtSmoothPix.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Smoothing.m_SmoothPix)
        edtFlashesPerScan.Text = Str(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StrobeControl)
        l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserDelay
        l_NanoSec = 125.0 * l_FPGAClkCycles / 6.0
        edtLaserDelay.Text = Format(l_NanoSec, "######0")
        l_FPGAClkCycles = l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWidth
        l_NanoSec = 125.0 * (l_FPGAClkCycles) / 6.0
        edtLaserWidth.Text = Format(l_NanoSec, "######0")
        edtLaserWavelength.Text = Format(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_LaserWaveLength, "####0.00")
        edtRamSpectra.Text = Format(l_pDeviceData.m_StandAlone.m_Meas.m_Control.m_StoreToRam, "######0")
        edtNrOfScans.Text = Str(l_pDeviceData.m_StandAlone.m_Nmsr)
    End Sub


    Private Sub chkPreScan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPreScan.CheckedChanged
        Dim l_Res As Integer = AVS_SetPrescanMode(m_DeviceHandle, chkPreScan.Checked)
        If (ERR_SUCCESS <> l_Res) Then
            MsgBox("Error in AVS_SetPrescanMode, code:" & Str(l_Res), MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class


Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices

Module Module1
    Public Const WM_USER As Integer = &H400
    Public Const WM_MEAS_READY As Integer = WM_USER + 1
    Public Const WM_DBG_INFOAs As Integer = WM_USER + 2
    Public Const WM_DEVICE_RESET As Integer = WM_USER + 3
	
	Public Const USB_STATE_ATTACHED As Short = 0
	Public Const USB_STATE_DETACHED As Short = 1
	
	Public Const NR_FIT_COEF As Short = 5
	Public Const MAX_NR_CHANNELS As Short = 8
	Public Const MAX_NR_PIXELS_PER_CHANNEL As Short = 2048
	
	Public Const SUCCESS As Short = 0
	Public Const INVALID_PARAMETER As Short = -1
	Public Const INVALID_PIXEL_RANGE As Short = -2
	Public Const NO_INT_DELAY_SUPPORT As Short = -3
	
    ' Return error codes
    Public Const ERR_SUCCESS As Integer = 0
    Public Const ERR_INVALID_PARAMETER As Integer = -1
    Public Const ERR_OPERATION_NOT_SUPPORTED As Integer = -2
    Public Const ERR_DEVICE_NOT_FOUND As Integer = -3
    Public Const ERR_INVALID_DEVICE_ID As Integer = -4
    Public Const ERR_OPERATION_PENDING As Integer = -5
    Public Const ERR_TIMEOUT As Integer = -6
    Public Const ERR_INVALID_PASSWORD As Integer = -7
    Public Const ERR_INVALID_MEAS_DATA As Integer = -8
    Public Const ERR_INVALID_SIZE As Integer = -9
    Public Const ERR_INVALID_PIXEL_RANGE As Integer = -10
    Public Const ERR_INVALID_INT_TIME As Integer = -11
    Public Const ERR_INVALID_COMBINATION As Integer = -12
    Public Const ERR_INVALID_CONFIGURATION As Integer = -13
    Public Const ERR_NO_MEAS_BUFFER_AVAIL As Integer = -14
    Public Const ERR_UNKNOWN As Integer = -15
    Public Const ERR_COMMUNICATION As Integer = -16
    Public Const ERR_NO_SPECTRA_IN_RAM As Integer = -17
    Public Const ERR_INVALID_DLL_VERSION As Integer = -18
    Public Const ERR_NO_MEMORY As Integer = -19
    Public Const ERR_DLL_INITIALISATION As Integer = -20
    Public Const ERR_INVALID_STATE As Integer = -21

    ' Return error codes; DeviceData check
    Public Const ERR_INVALID_PARAMETER_NR_PIXELS As Integer = -100
    Public Const ERR_INVALID_PARAMETER_ADC_GAIN As Integer = -101
    Public Const ERR_INVALID_PARAMETER_ADC_OFFSET As Integer = -102

    ' Return error codes; PrepareMeasurement check
    Public Const ERR_INVALID_MEASPARAM_AVG_SAT2 As Integer = -110
    Public Const ERR_INVALID_MEASPARAM_AVG_RAM As Integer = -111
    Public Const ERR_INVALID_MEASPARAM_SYNC_RAM As Integer = -112
    Public Const ERR_INVALID_MEASPARAM_LEVEL_RAM As Integer = -113
    Public Const ERR_INVALID_MEASPARAM_SAT2_RAM As Integer = -114
    Public Const ERR_INVALID_MEASPARAM_FWVER_RAM As Integer = -115

    'StoreToRAM in 0.20.0.0 and later
    Public Const ERR_INVALID_MEASPARAM_DYNDARK As Integer = -116

    'Return error codes; SetSensitivityMode check
    Public Const ERR_NOT_SUPPORTED_BY_SENSOR_TYPE As Integer = -120
    Public Const ERR_NOT_SUPPORTED_BY_FW_VER As Integer = -121
    Public Const ERR_NOT_SUPPORTED_BY_FPGA_VER As Integer = -122

    Public Const UNCONFIGURED_DEVICE_OFFSET As Integer = 256
    Public Const INVALID_AVS_HANDLE_VALUE As Long = 1000L

    Public Const USER_ID_LEN As Byte = 64
    Public Const NR_WAVELEN_POL_COEF As Byte = 5
    Public Const NR_NONLIN_POL_COEF As Byte = 8
    Public Const NR_DEFECTIVE_PIXELS As Byte = 30
    Public Const MAX_NR_PIXELS As UShort = 4096
    Public Const NR_TEMP_POL_COEF As Byte = 5
    Public Const MAX_TEMP_SENSORS As Byte = 3
    Public Const ROOT_NAME_LEN As Byte = 6
    Public Const AVS_SERIAL_LEN As Byte = 10
    Public Const MAX_PIXEL_VALUE As UShort = &HFFFC
    Public Const MAX_VIDEO_CHANNELS As Byte = 2
    Public Const MAX_LASER_WIDTH As UShort = &HFFFF

    Public Const HW_TRIGGER_MODE As Byte = 1
    Public Const SW_TRIGGER_MODE As Byte = 0

    Public Const Ext_TRIGGER_MODE As Byte = 1
    Public Const SYNCH_TRIGGER_MODE As Byte = 0

    Public Const EDGE_TRIGGER_SOURCE As Byte = 0
    Public Const LEVEL_TRIGGER_SOURCE As Byte = 1

    Public Const MAX_TRIGGER_MODE As Byte = 1
    Public Const MAX_TRIGGER_SOURCE As Byte = 1
    Public Const MAX_TRIGGER_SOURCE_TYPE As Byte = 1
    Public Const MAX_INTEGRATION_TIME As UInteger = 600000    ' 600 seconds

    Public Const SAT_DISABLE_DET As Byte = 0
    Public Const SAT_ENABLE_DET As Byte = 1
    Public Const SAT_PEAK_INVERSION As Byte = 2
    Public Const NR_DAC_POL_COEF As Byte = 2

    Private Const UINT32_LEN As UInteger = 4
    Private Const UINT16_LEN As UShort = 2
    Private Const DETECTOR_TYPE_LEN As UShort = 1 + 2 + 4 * NR_WAVELEN_POL_COEF + 1 + 8 * NR_NONLIN_POL_COEF + 2 * 8 + 4 * MAX_VIDEO_CHANNELS + 4 + 4 * MAX_VIDEO_CHANNELS + 4 + 2 * NR_DEFECTIVE_PIXELS
    Private Const IRRADIANCE_TYPE_LEN As UShort = 2 + 1 + 4 + 4 * MAX_NR_PIXELS + 1 + 4
    Private Const SPECTRUM_CALIBRATION_TYPE_LEN As UShort = 2 + 1 + 4 + 4 * MAX_NR_PIXELS
    Private Const SPECTRUM_CORRECTION_TYPE_LEN As UShort = 4 * MAX_NR_PIXELS

    Private Const STAND_ALONE_TYPE_LEN As UShort = 1 + 2 + 2 + 4 + 4 + 4 + 1 + 1 + 2 + 1 + 1 + 1 + 1 + 1 + 2 + 4 + 4 + 4 + 2 + 2
    Private Const DYNAMIC_STORAGE_TYPE_LEN As UShort = 4 + 8

    Private Const TEMP_SENSOR_TYPE_LEN As UShort = 4 * NR_TEMP_POL_COEF
    Private Const TEC_CONTROL_TYPE_LEN As UShort = 1 + 4 + 4 * NR_DAC_POL_COEF
    Private Const PROC_CONTROL_TYPE_LEN As UShort = 96 '24*4
    Private Const ETHERNET_SETTINGS_TYPE_LEN As UShort = 16

    Public Const SETTINGS_RESERVED_LEN As UShort = ((62 * 1024) - UINT32_LEN - _
                                                                    (UINT16_LEN + _
                                                                     UINT16_LEN + _
                                                                     USER_ID_LEN + _
                                                                     DETECTOR_TYPE_LEN + _
                                                                     IRRADIANCE_TYPE_LEN + _
                                                                     SPECTRUM_CALIBRATION_TYPE_LEN + _
                                                                     SPECTRUM_CORRECTION_TYPE_LEN + _
                                                                     STAND_ALONE_TYPE_LEN + _
                                                                     DYNAMIC_STORAGE_TYPE_LEN + _
                                                                    (TEMP_SENSOR_TYPE_LEN) * MAX_TEMP_SENSORS + _
                                                                     TEC_CONTROL_TYPE_LEN + _
                                                                     PROC_CONTROL_TYPE_LEN + _
                                                                     ETHERNET_SETTINGS_TYPE_LEN))

    ' Structures needed to pass arrays

    Enum SENS_TYPE
        SENS_HAMS8378_256 = 1
        SENS_HAMS8378_1024 = 2
        SENS_ILX554 = 3
        SENS_HAMS9201 = 4
        SENS_TCD1304 = 5
        SENS_TSL1301 = 6
        SENS_TSL1401 = 7
        SENS_HAMS8378_512 = 8
        SENS_HAMS9840 = 9
        SENS_ILX511 = 10
        SENS_HAMS10420_2048X64 = 11
        SENS_HAMS11071_2048X64 = 12
        SENS_HAMS7031_1024X122 = 13
        SENS_HAMS7031_1024X58 = 14
        SENS_HAMS11071_2048X16 = 15
        SENS_HAMS11155 = 16
        SENS_SU256LSB = 17
        SENS_SU512LDB = 18
        SENS_HAMS11638 = 21
        SENS_HAMS11639 = 22
        SENS_HAMS12443 = 23
        SENS_HAMG9208_512 = 24
    End Enum 'SENS_TYPE

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure String16Type
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=16)> _
        Public String16 As String
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure PixelArrayType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_NR_PIXELS)> _
        Public Value() As Double
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure SaturatedArrayType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_NR_PIXELS)> _
        Public Value() As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure ControlSettingsType
        Public m_StrobeControl As UShort
        Public m_LaserDelay As UInteger
        Public m_LaserWidth As UInteger
        Public m_LaserWaveLength As Single
        Public m_StoreToRam As UShort
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1, CharSet:=CharSet.Ansi)> _
    Public Structure BroadcastAnswerType
        Public InterfaceType As Byte
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=10)> _
        Public SerialNumber As String
        Public port As UShort
        Public status As Byte
        Public RemoteHostIp As UInteger
        Public LocalIP As UInteger
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> _
        Public reserved() As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure DarkCorrectionType
        Public m_Enable As Byte
        Public m_ForgetPercentage As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure DetectorType
        Public m_SensorType As Byte
        Public m_NrPixels As UShort
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NR_WAVELEN_POL_COEF)> _
        Public m_aFit() As Single
        Public m_NLEnable As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NR_NONLIN_POL_COEF)> _
        Public m_aNLCorrect() As Double
        Public m_aLowNLCounts As Double
        Public m_aHighNLCounts As Double
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_VIDEO_CHANNELS)> _
        Public m_Gain() As Single
        Public m_Reserved As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_VIDEO_CHANNELS)> _
        Public m_Offset() As Single
        Public m_ExtOffset As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NR_DEFECTIVE_PIXELS)> _
        Public m_DefectivePixels() As UShort
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure SmoothingType
        Public m_SmoothPix As UShort
        Public m_SmoothModel As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure SpectrumCalibrationType
        Public m_Smoothing As SmoothingType
        Public m_CalInttime As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_NR_PIXELS)> _
        Public m_aCalibConvers() As Single
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure IrradianceType
        Public m_IntensityCalib As SpectrumCalibrationType
        Public m_CalibrationType As Byte
        Public m_FiberDiameter As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TriggerType
        Public m_Mode As Byte
        Public m_Source As Byte
        Public m_SourceType As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure MeasConfigType
        Public m_StartPixel As UShort
        Public m_StopPixel As UShort
        Public m_IntegrationTime As Single
        Public m_IntegrationDelay As UInteger
        Public m_NrAverages As UInteger
        Public m_CorDynDark As DarkCorrectionType
        Public m_Smoothing As SmoothingType
        Public m_SaturationDetection As Byte
        Public m_Trigger As TriggerType
        Public m_Control As ControlSettingsType
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TimeStampType
        Public m_Date As UShort
        Public m_Time As UShort
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure SpectrumCorrectionType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_NR_PIXELS)> _
        Public m_aSpectrumCorrect() As Single
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure StandAloneType
        Public m_Enable As Byte
        Public m_Meas As MeasConfigType
        Public m_Nmsr As Short
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure DynamicStorageType
        Public m_Nmsr As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
        Public reserved() As Byte
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TempSensorType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NR_TEMP_POL_COEF)> _
        Public m_aFit() As Single
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure TecControlType
        Public m_Enable As Byte
        Public m_Setpoint As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=NR_DAC_POL_COEF)> _
        Public m_aFit() As Single
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure ProcessControlType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> _
        Public AnalogLow() As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=2)> _
        Public AnalogHigh() As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> _
        Public DigitalLow() As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=10)> _
        Public DigitalHigh() As Single
    End Structure

    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure EthernetSettingsType
        Public m_IpAddr As UInteger
        Public m_NetMask As UInteger
        Public m_Gateway As UInteger
        Public m_DhcpEnabled As Byte
        Public m_TcpPort As UShort
        Public m_LinkStatus As Byte
    End Structure


    <StructLayout(LayoutKind.Sequential, Pack:=1)> _
    Public Structure DeviceConfigType
        Public m_Len As UShort '2
        Public m_ConfigVersion As UShort '2
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=USER_ID_LEN)> _
        Public m_aUserFriendlyId() As Byte '1
        Public m_Detector As DetectorType '188
        Public m_Irradiance As IrradianceType '16396
        Public m_Reflectance As SpectrumCalibrationType '16391
        Public m_SpectrumCorrect As SpectrumCorrectionType '16384
        Public m_StandAlone As StandAloneType '50
        Public m_DynamicStorage As DynamicStorageType '12
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=MAX_TEMP_SENSORS)> _
        Public m_aTemperature() As TempSensorType '20*3=60
        Public m_TecControl As TecControlType '13
        Public m_ProcessControl As ProcessControlType
        Public m_EthernetSettings As EthernetSettingsType
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=SETTINGS_RESERVED_LEN)> _
        Public m_aReserved() As Byte
    End Structure

    Enum DEVICE_STATUS
        UNKNOWN = 0
        USB_AVAILABLE = 1
        USB_IN_USE_BY_APPLICATION = 2
        USB_IN_USE_BY_OTHER = 3
        ETH_AVAILABLE = 4
        ETH_IN_USE_BY_APPLICATION = 5
        ETH_IN_USE_BY_OTHER = 6
        ETH_ALREADY_IN_USE_USB = 7
    End Enum

    <StructLayout(LayoutKind.Sequential, Pack:=1, CharSet:=CharSet.Ansi)> _
    Public Structure AvsIdentityType
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=10)> _
        Public SerialNumber As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=64)> _
        Public UserFriendlyName As String
        Public Status As Byte
    End Structure

    ' Function prototypes

    Declare Function AVS_Init Lib "avaspec" Alias "AVS_Init" (ByVal COMPort As Integer) As Integer
    Declare Function AVS_Done Lib "avaspec" Alias "AVS_Done" () As Integer
    Declare Function AVS_GetNrOfDevices Lib "avaspec" Alias "AVS_GetNrOfDevices" () As Integer
    Declare Function AVS_UpdateUSBDevices Lib "avaspec" Alias "AVS_UpdateUSBDevices" () As Integer
    Declare Function AVS_UpdateETHDevices Lib "avaspec" Alias "AVS_UpdateETHDevices" (ByVal ListSize As UInteger, ByRef RequiredSize As UInteger, <[In](), Out()> ByVal List As BroadcastAnswerType()) As Integer
    Declare Function AVS_GetList Lib "avaspec" Alias "AVS_GetList" (ByVal ListSize As UInteger, ByRef RequiredSize As UInteger, <[In](), Out()> ByVal List As AvsIdentityType()) As Integer
    Declare Function AVS_Activate Lib "avaspec" Alias "AVS_Activate" (ByRef a_DeviceId As AvsIdentityType) As Integer
    Declare Function AVS_Deactivate Lib "avaspec" Alias "AVS_Deactivate" (ByVal DeviceHandle As IntPtr) As Integer
    Declare Function AVS_GetHandleFromSerial Lib "avaspec" Alias "AVS_GetHandleFromSerial" (ByRef Serial As Byte) As Integer
    Declare Function AVS_Register Lib "avaspec" Alias "AVS_Register" (ByVal winID As Integer) As Integer
    Declare Function AVS_PrepareMeasure Lib "avaspec" Alias "AVS_PrepareMeasure" (ByVal DeviceHandle As IntPtr, ByRef MeasConfig As MeasConfigType) As Integer
    Declare Function AVS_Measure Lib "avaspec" Alias "AVS_Measure" (ByVal DeviceHandle As IntPtr, ByVal winID As Integer, ByVal Nmsr As Short) As Integer
    Declare Function AVS_GetLambda Lib "avaspec" Alias "AVS_GetLambda" (ByVal DeviceHandle As IntPtr, ByRef WaveLength As PixelArrayType) As Integer
    Declare Function AVS_GetNumPixels Lib "avaspec" Alias "AVS_GetNumPixels" (ByVal DeviceHandle As IntPtr, ByRef NumPixels As UShort) As Integer
    Declare Function AVS_GetParameter Lib "avaspec" Alias "AVS_GetParameter" (ByVal DeviceHandle As IntPtr, ByVal Size As UInteger, ByRef RequiredSize As UInteger, ByRef DeviceParm As DeviceConfigType) As Integer
    Declare Function AVS_GetSecure Lib "avaspec" Alias "AVS_GetSecure" () As Integer
    Declare Function AVS_GetScopeData Lib "avaspec" Alias "AVS_GetScopeData" (ByVal DeviceHandle As IntPtr, ByRef TimeLabel As UInteger, ByRef pSpectrum As PixelArrayType) As Integer
    Declare Function AVS_GetSaturatedPixels Lib "avaspec" Alias "AVS_GetSaturatedPixels" (ByVal DeviceHandle As IntPtr, ByRef a_pSaturated As SaturatedArrayType) As Integer
    Declare Function AVS_GetAnalogIn Lib "avaspec" Alias "AVS_GetAnalogIn" (ByVal DeviceHandle As IntPtr, ByVal AnalogInId As Byte, ByRef AnalogIn As Single) As Integer
    Declare Function AVS_GetDigIn Lib "avaspec" Alias "AVS_GetDigIn" (ByVal DeviceHandle As IntPtr, ByVal DigInId As Byte, ByRef DigIn As Byte) As Integer
    Declare Function AVS_GetDLLVersion Lib "avaspec" Alias "AVS_GetDLLVersion" () As Integer
    Declare Function AVS_GetVersionInfo Lib "avaspec" Alias "AVS_GetVersionInfo" (ByVal DeviceHandle As IntPtr, ByRef FPGAVersion As String16Type, ByRef FirmwareVersion As String16Type, ByRef DLLVersion As String16Type) As Integer
    Declare Function AVS_SetParameter Lib "avaspec" Alias "AVS_SetParameter" (ByVal DeviceHandle As IntPtr, ByRef DeviceParm As DeviceConfigType) As Integer
    Declare Function AVS_SetSecure Lib "avaspec" Alias "AVS_SetSecure" () As Integer
    Declare Function AVS_SetAnalogOut Lib "avaspec" Alias "AVS_SetAnalogOut" (ByVal DeviceHandle As IntPtr, ByVal PortId As Byte, ByVal Value As Single) As Integer
    Declare Function AVS_SetDigOut Lib "avaspec" Alias "AVS_SetDigOut" (ByVal DeviceHandle As IntPtr, ByVal PortId As Byte, ByVal Status As Byte) As Integer
    Declare Function AVS_PollScan Lib "avaspec" Alias "AVS_PollScan" (ByVal DeviceHandle As IntPtr) As Integer
    Declare Function AVS_SetPwmOut Lib "avaspec" Alias "AVS_SetPwmOut" (ByVal DeviceHandle As IntPtr, ByVal PortId As Byte, ByVal Freq As UInteger, ByVal Duty As Byte) As Integer
    Declare Function AVS_StopMeasure Lib "avaspec" Alias "AVS_StopMeasure" (ByVal DeviceHandle As IntPtr) As Integer
    Declare Function AVS_SetSyncMode Lib "avaspec" Alias "AVS_SetSyncMode" (ByVal DeviceHandle As IntPtr, ByVal Enable As Byte) As Integer
    Declare Function AVS_SetPrescanMode Lib "avaspec" Alias "AVS_SetPrescanMode" (ByVal a_hDevice As IntPtr, ByVal a_Prescan As Boolean) As Integer
    Declare Function AVS_UseHighResAdc Lib "avaspec" Alias "AVS_UseHighResAdc" (ByVal a_hDevice As IntPtr, ByVal a_Enable As Boolean) As Integer
    Declare Function AVS_SetSensitivityMode Lib "avaspec" Alias "AVS_SetSensitivityMode" (ByVal a_hDevice As IntPtr, ByVal a_SensitivityMode As UInteger) As Integer
    Declare Function AVS_GetIpConfig Lib "avaspec" Alias "AVS_GetIpConfig" (ByVal a_hDevice As IntPtr, ByRef a_Data As EthernetSettingsType) As Integer

End Module
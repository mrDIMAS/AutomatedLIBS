unit avaspec;

{$ALIGN OFF}

interface

uses wintypes,messages;

const avsdll = 'avaspec.dll';
const USER_ID_LEN             = 64;
const NR_WAVELEN_POL_COEF     = 5;
const NR_NONLIN_POL_COEF      = 8;
const NR_DEFECTIVE_PIXELS     = 30;
const MAX_NR_PIXELS           = 4096;
const NR_TEMP_POL_COEF        = 5;
const MAX_TEMP_SENSORS        = 3;
const ROOT_NAME_LEN           = 6;
const AVS_SERIAL_LEN          = 10;
const MAX_PIXEL_VALUE         = $FFFC;
const MAX_VIDEO_CHANNELS      = 2;
const MAX_LASER_WIDTH         = $FFFF;
const HW_TRIGGER_MODE         = 0;
const SW_TRIGGER_MODE         = 1;
const EDGE_TRIGGER_SOURCE     = 0;
const LEVEL_TRIGGER_SOURCE    = 1;
const MAX_TRIGGER_MODE        = 1;
const MAX_TRIGGER_SOURCE      = 1;
const MAX_TRIGGER_SOURCE_TYPE = 1;
const MAX_INTEGRATION_TIME    = 600000;    // 600 seconds
const SAT_DISABLE_DET         = 0;
const SAT_ENABLE_DET          = 1;
const SAT_PEAK_INVERSION      = 2;
const DIG_IN0                 = 0;
const DIG_IN1                 = 1;
const DIG_IN2                 = 2;
const NR_OF_DIGITAL_INPUTS    = 3;
const NR_OF_DIGITAL_OUTPUTS   = 10;
const NR_OF_ANALOG_OUTPUTS    = 2;
const NR_OF_ANALOG_INPUTS     = 2;
const NR_DAC_POL_COEF         = 2;
const MAX_NR_DEVICES          = 16; //increase if needed to max 127

// Return error codes
const ERR_SUCCESS                   = 0;
const ERR_INVALID_PARAMETER         = -1;
const ERR_OPERATION_NOT_SUPPORTED   = -2;
const ERR_DEVICE_NOT_FOUND          = -3;
const ERR_INVALID_DEVICE_ID         = -4;
const ERR_OPERATION_PENDING         = -5;
const ERR_TIMEOUT                   = -6;
const ERR_INVALID_PASSWORD          = -7;
const ERR_INVALID_MEAS_DATA         = -8;
const ERR_INVALID_SIZE              = -9;
const ERR_INVALID_PIXEL_RANGE       = -10;
const ERR_INVALID_INT_TIME          = -11;
const ERR_INVALID_COMBINATION       = -12;
const ERR_INVALID_CONFIGURATION     = -13;
const ERR_NO_MEAS_BUFFER_AVAIL      = -14;
const ERR_UNKNOWN                   = -15;
const ERR_COMMUNICATION             = -16;
const ERR_NO_SPECTRA_IN_RAM         = -17;
const ERR_INVALID_DLL_VERSION       = -18;
const ERR_NO_MEMORY                 = -19;
const ERR_DLL_INITIALISATION        = -20;
const ERR_INVALID_STATE             = -21;

// Return error codes; DeviceData check
const ERR_INVALID_PARAMETER_NR_PIXELS   = -100;
const ERR_INVALID_PARAMETER_ADC_GAIN    = -101;
const ERR_INVALID_PARAMETER_ADC_OFFSET  = -102;

// Return error codes; PrepareMeasurement check
const ERR_INVALID_MEASPARAM_AVG_SAT2    = -110;
const ERR_INVALID_MEASPARAM_AVG_RAM     = -111;
const ERR_INVALID_MEASPARAM_SYNC_RAM    = -112;
const ERR_INVALID_MEASPARAM_LEVEL_RAM   = -113;
const ERR_INVALID_MEASPARAM_SAT2_RAM    = -114;
const ERR_INVALID_MEASPARAM_FWVER_RAM   = -115; //StoreToRAM in 0.20.0.0 and later
const ERR_INVALID_MEASPARAM_DYNDARK     = -116;

// Return error codes; SetSensitivityMode check
const ERR_NOT_SUPPORTED_BY_SENSOR_TYPE  = -120;
const ERR_NOT_SUPPORTED_BY_FW_VER       = -121;
const ERR_NOT_SUPPORTED_BY_FPGA_VER     = -122;



const INVALID_AVS_HANDLE_VALUE      = 1000;

// Notification constants
const WM_MEAS_READY                 = WM_USER + 1;
const WM_DEVICE_RESET               = WM_USER + 3;

type
      int8                          = shortint;
      uint8                         = byte;
      int16                         = smallint;
      uint16                        = word;
      int32                         = integer;
      uint32                        = dword;
      ptrDWord                      = ^DWord;

      AvsHandle                     = longint;
      FRNType                       = array[0..ROOT_NAME_LEN-1] of ansichar;

      DEVICE_STATUS                 =  ( UNKNOWN,
                                         USB_AVAILABLE,
                                         USB_IN_USE_BY_APPLICATION,
                                         USB_IN_USE_BY_OTHER,
		                                     ETH_AVAILABLE,
		                                     ETH_IN_USE_BY_APPLICATION,
		                                     ETH_IN_USE_BY_OTHER,
		                                     ETH_ALREADY_IN_USE_USB );

      SENS_TYPE                     =  ( SENS_HAMS8378_256=1,
                                         SENS_HAMS8378_1024,
                                         SENS_ILX554,
                                         SENS_HAMS9201,
                                         SENS_TCD1304,
                                         SENS_TSL1301,
                                         SENS_TSL1401,
                                         SENS_HAMS8378_512,
                                         SENS_HAMS9840,
                                         SENS_ILX511,
                                         SENS_HAMS10420_2048X64,
                                         SENS_HAMS11071_2048X64,
                                         SENS_HAMS7031_1024X122,
                                         SENS_HAMS7031_1024X58,
                                         SENS_HAMS11071_2048X16,
                                         SENS_HAMS11155,
                                         SENS_SU256LSB,
                                         SENS_SU512LDB,
                                         SENS_HAMS11638=21,
                                         SENS_HAMS11639,
                                         SENS_HAMS12443,
                                         SENS_HAMG9208_512 );

      AvsIdentityType               = record
                                        SerialNumber: array[0..AVS_SERIAL_LEN-1] of ansichar;
                                        UserFriendlyName: array[0..USER_ID_LEN-1] of ansichar;
                                        Status: DEVICE_STATUS;
                                      end;

      ControlSettingsType           = record
                                        m_StrobeControl: uint16;
                                        m_LaserDelay: uint32;
                                        m_LaserWidth: uint32;
                                        m_LaserWaveLength: single;
                                        m_StoreToRam:uint16; //prepared for future versions
                                      end;

      DarkCorrectionType            = record
                                        m_Enable: uint8;
                                        m_ForgetPercentage: uint8;
                                      end;

      DetectorType                  = record
                                        m_SensorType: SENS_TYPE;
                                        m_NrPixels: uint16;
                                        m_aFit: array[0..NR_WAVELEN_POL_COEF-1] of single;
                                        m_NLEnable: boolean;
                                        m_aNLCorrect: array[0..NR_NONLIN_POL_COEF-1] of double;
                                        m_aLowNLCounts:double;
                                        m_aHighNLCounts:double;
                                        m_Gain: array[0..MAX_VIDEO_CHANNELS-1] of single;
                                        m_Reserved: single;
                                        m_Offset: array[0..MAX_VIDEO_CHANNELS-1] of single;
                                        m_ExtOffset: single;
                                        m_DefectivePixels: array[0..NR_DEFECTIVE_PIXELS-1] of uint16;
                                      end;

      SmoothingType                 = record
                                        m_SmoothPix: uint16;
                                        m_SmoothModel: uint8;
                                      end;

      SpectrumCalibrationType       = record
                                        m_Smoothing: SmoothingType;
                                        m_CalInttime: single;
                                        m_aCalibConvers: array[0..MAX_NR_PIXELS-1] of single;
                                      end;

      IrradianceType                = record
                                        m_IntensityCalib: SpectrumCalibrationType;
                                        m_CalibrationType: uint8;
                                        m_FiberDiameter: uint32;
                                      end;

      TriggerType                   = record
                                        m_Mode: uint8;
                                        m_Source: uint8;
                                        m_SourceType:uint8;
                                      end;

      MeasConfigType                = record
                                        m_StartPixel: uint16;
                                        m_StopPixel: uint16;
                                        m_IntegrationTime: single;
                                        m_IntegrationDelay: uint32;
                                        m_NrAverages: uint32;
                                        m_CorDynDark: DarkCorrectionType;
                                        m_Smoothing: SmoothingType;
                                        m_SaturationDetection: uint8;
                                        m_Trigger: TriggerType;
                                        m_Control: ControlSettingsType;
                                      end;

      TimeStampType                 = record
                                        m_Date: uint16;
                                        m_Time: uint16;
                                      end;

      SpectrumCorrectionType        = record
                                        m_aSpectrumCorrect: array[0..MAX_NR_PIXELS-1] of single;
                                      end;

      StandAloneType                = record
                                        m_Enable: boolean;
                                        m_Meas: MeasConfigType;
                                        m_Nmsr: int16;
                                      end;

      DynamicStorageType            = record
                                        m_Nmsr: int32;
                                        reserved: array[0..7] of uint8;
                                      end;

      TempSensorType                = record
                                        m_aFit: array[0..NR_TEMP_POL_COEF-1] of single;
                                      end;

      TecControlType                = record
                                        m_Enable: boolean;
                                        m_Setpoint: single;   // [degree Celsius]
                                        m_aFit:array[0..NR_DAC_POL_COEF-1] of single;
                                      end;

      ProcessControlType            = record
                                        m_AnalogLow: array[0..NR_OF_ANALOG_OUTPUTS-1] of single;
                                        m_AnalogHigh: array[0..NR_OF_ANALOG_OUTPUTS-1] of single;
                                        m_DigitalLow: array[0..NR_OF_DIGITAL_OUTPUTS-1] of single;
                                        m_DigitalHigh: array[0..NR_OF_DIGITAL_OUTPUTS-1] of single;
                                      end;

      EthernetSettingsType          = record
                                        m_IpAddr: uint32;
                                        m_NetMask: uint32;
                                        m_Gateway: uint32;
                                        m_DhcpEnabled: uint8;
                                        m_TcpPort: uint16;
                                        m_LinkStatus: uint8;
                                      end;

      pEthernetSettingsType         = ^EthernetSettingsType;

const SETTINGS_RESERVED_LEN         = ((62*1024) -  sizeof(uint32) -
                                                        (sizeof(uint16) +   // m_Len
                                                         sizeof(uint16) +   // m_ConfigVersion
                                                         USER_ID_LEN +
                                                         sizeof(DetectorType) +
                                                         sizeof(IrradianceType) +
                                                         sizeof(SpectrumCalibrationType) +
                                                         sizeof(SpectrumCorrectionType) +
                                                         sizeof(StandAloneType) +
                                                         sizeof(DynamicStorageType) +
                                                        (sizeof(TempSensorType)*MAX_TEMP_SENSORS)+
                                                         sizeof(TecControlType)+
                                                         sizeof(ProcessControlType)+
                                                         sizeof(EthernetSettingsType)
                                                        )
                                      );


type  DeviceConfigType          = record
                                    m_Len: uint16;
                                    m_ConfigVersion: uint16;
                                    m_aUserFriendlyId: array[0..USER_ID_LEN-1] of ansichar;
                                    m_Detector: DetectorType;
                                    m_Irradiance: IrradianceType;
                                    m_Reflectance: SpectrumCalibrationType;
                                    m_SpectrumCorrect: SpectrumCorrectionType;
                                    m_StandAlone: StandAloneType;
                                    m_DynamicStorage: DynamicStorageType; 
                                    m_aTemperature: array[0..MAX_TEMP_SENSORS-1] of TempSensorType;
                                    m_TecControl: TecControlType;
                                    m_ProcessControl: ProcessControlType;
                                    m_EthernetSettings: EthernetSettingsType;
                                    m_aReserved: array[0..SETTINGS_RESERVED_LEN-1] of uint8;
                                  end;

      pDeviceConfigType         = ^DeviceConfigType;

function AVS_Init(COMPort:smallint):longint;stdcall;
function AVS_Done:longint;stdcall;
function AVS_GetNrOfDevices:longint;stdcall;
function AVS_GetList(a_ListSize:DWord;var a_pRequiredSize:DWord; var a_pList:AvsIdentityType):longint;stdcall;
function AVS_Activate(var a_pDeviceId:AvsIdentityType):AvsHandle;stdcall;
function AVS_Deactivate(a_hHandle:AvsHandle):boolean;stdcall;
function AVS_Register(a_hWnd:HWND):boolean;stdcall;
function AVS_PrepareMeasure(a_hHandle:AvsHandle;var a_pMeasConfig:MeasConfigType):longint;stdcall;
function AVS_Measure(a_hHandle:AvsHandle;a_hWnd:HWND;a_Nmsr:smallint):longint;stdcall;
function AVS_GetLambda(a_hHandle:AvsHandle;a_pWaveLength:pDouble):longint;stdcall;
function AVS_GetNumPixels(a_hHandle:AvsHandle;var a_pTotalPixels:Word):longint;stdcall;
function AVS_GetParameter(a_hHandle:AvsHandle;a_Size:DWord;var a_pRequiredSize:DWord;pData:pDeviceConfigType):longint;stdcall;
function AVS_PollScan(a_hHandle:AvsHandle):longint;stdcall;
function AVS_GetScopeData(a_hHandle:AvsHandle;var a_pTimeLabel:DWord;a_pSpectrum:pDouble):longint;stdcall;
function AVS_GetSaturatedPixels(a_hHandle:AvsHandle; a_pSaturated:pByte):longint;stdcall;
function AVS_GetAnalogIn(a_hHandle:AvsHandle;a_AnalogInId:byte;var a_pAnalogIn:single):longint;stdcall;
function AVS_GetDigIn(a_hHandle:AvsHandle;a_DigInId:byte;var a_pDigIn:byte):longint;stdcall;
function AVS_GetVersionInfo(a_hHandle:AvsHandle;a_pFPGAVersion, a_pFirmwareVersion, a_pDLLVersion:PAnsiChar):longint;stdcall;

function AVS_SetParameter(a_hHandle:AvsHandle;pData:pDeviceConfigType):longint; stdcall;
function AVS_SetAnalogOut(a_hHandle:AvsHandle;a_PortId:byte; a_Value:single):longint;stdcall;
function AVS_SetDigOut(a_hHandle:AvsHandle;a_PortId, a_Value:byte):longint;stdcall;
function AVS_SetPwmOut(a_hHandle:AvsHandle;a_PortId:byte;a_Frequency:DWORD; a_DutyCycle:byte):longint;stdcall;
function AVS_SetSyncMode(a_hHandle:AvsHandle;a_Enable:byte):longint;stdcall;
function AVS_StopMeasure(a_hHandle:AvsHandle):longint;stdcall;
function AVS_SetPrescanMode(a_hHandle:AvsHandle;a_Prescan:boolean):longint; stdcall;
function AVS_UseHighResAdc(a_hHandle:AvsHandle;a_Enable:boolean):longint; stdcall;
function AVS_SetSensitivityMode(a_hHandle:AvsHandle;a_SensitivityMode:uint32):longint; stdcall;
function AVS_GetIpConfig(a_hHandle:AvsHandle;pData:pEthernetSettingsType):longint; stdcall;

implementation

function AVS_Init;                 external avsdll name 'AVS_Init';
function AVS_Done;                 external avsdll name 'AVS_Done';
function AVS_GetNrOfDevices;       external avsdll name 'AVS_GetNrOfDevices';
function AVS_GetList;              external avsdll name 'AVS_GetList';
function AVS_Activate;             external avsdll name 'AVS_Activate';
function AVS_Deactivate;           external avsdll name 'AVS_Deactivate';
function AVS_Register;             external avsdll name 'AVS_Register';
function AVS_PrepareMeasure;       external avsdll name 'AVS_PrepareMeasure';
function AVS_Measure;              external avsdll name 'AVS_Measure';
function AVS_GetLambda;            external avsdll name 'AVS_GetLambda';
function AVS_GetNumPixels;         external avsdll name 'AVS_GetNumPixels';
function AVS_GetParameter;         external avsdll name 'AVS_GetParameter';
function AVS_PollScan;             external avsdll name 'AVS_PollScan';
function AVS_GetScopeData;         external avsdll name 'AVS_GetScopeData';
function AVS_GetSaturatedPixels;   external avsdll name 'AVS_GetSaturatedPixels';
function AVS_GetAnalogIn;          external avsdll name 'AVS_GetAnalogIn';
function AVS_GetDigIn;             external avsdll name 'AVS_GetDigIn';
function AVS_GetVersionInfo;       external avsdll name 'AVS_GetVersionInfo';

function AVS_SetParameter;         external avsdll name 'AVS_SetParameter';
function AVS_SetAnalogOut;         external avsdll name 'AVS_SetAnalogOut';
function AVS_SetDigOut;            external avsdll name 'AVS_SetDigOut';
function AVS_SetPwmOut;            external avsdll name 'AVS_SetPwmOut';
function AVS_SetSyncMode;          external avsdll name 'AVS_SetSyncMode';
function AVS_StopMeasure;          external avsdll name 'AVS_StopMeasure';
function AVS_SetPrescanMode;       external avsdll name 'AVS_SetPrescanMode';
function AVS_UseHighResAdc;        external avsdll name 'AVS_UseHighResAdc';
function AVS_SetSensitivityMode;   external avsdll name 'AVS_SetSensitivityMode';
function AVS_GetIpConfig;          external avsdll name 'AVS_GetIpConfig';

end.

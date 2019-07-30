using System;
using System.Runtime.InteropServices;


namespace C_Sharp_Application
{		  
	/// <summary>
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential,Pack=1)]
	[Serializable]

	public class avaspec
	{
		public const short USB_STATE_ATTACHED = 0;
		public const short USB_STATE_DETACHED = 1;
		public const short NR_FIT_COEF = 5;
		public const short MAX_NR_CHANNELS = 8;
		public const short MAX_NR_PIXELS_PER_CHANNEL = 2048;
		public const short SUCCESS = 0;
		public const short INVALID_PARAMETER = -1;
		public const short INVALID_PIXEL_RANGE = -2;
		public const short NO_INT_DELAY_SUPPORT = -3;
		public const int ERR_SUCCESS = 0;
		public const int ERR_INVALID_PARAMETER = -1;
		public const int ERR_OPERATION_NOT_SUPPORTED = -2;
		public const int ERR_DEVICE_NOT_FOUND = -3;
		public const int ERR_INVALID_DEVICE_ID = -4;
		public const int ERR_OPERATION_PENDING = -5;
		public const int ERR_TIMEOUT = -6;
		public const int ERR_INVALID_PASSWORD = -7;
		public const int ERR_INVALID_MEAS_DATA = -8;
		public const int ERR_INVALID_SIZE = -9;
		public const int ERR_INVALID_PIXEL_RANGE = -10;
		public const int ERR_INVALID_INT_TIME = -11;
		public const int ERR_INVALID_COMBINATION = -12;
		public const int ERR_INVALID_CONFIGURATION = -13;
		public const int ERR_NO_MEAS_BUFFER_AVAIL = -14;
		public const int ERR_UNKNOWN = -15;
		public const int ERR_COMMUNICATION = -16;
		public const int ERR_NO_SPECTRA_IN_RAM = -17;
		public const int ERR_INVALID_DLL_VERSION = -18;
		public const int ERR_NO_MEMORY = -19;
		public const int ERR_DLL_INITIALISATION = -20;
		public const int ERR_INVALID_STATE = -21;
		// Return error codes; DeviceData check
		public const int ERR_INVALID_PARAMETER_NR_PIXELS   = -100;
		public const int ERR_INVALID_PARAMETER_ADC_GAIN    = -101;
		public const int ERR_INVALID_PARAMETER_ADC_OFFSET  = -102;
        
        // Return error codes; PrepareMeasurement check
        public const int ERR_INVALID_MEASPARAM_AVG_SAT2    = -110;
        public const int ERR_INVALID_MEASPARAM_AVG_RAM     = -111;
        public const int ERR_INVALID_MEASPARAM_SYNC_RAM    = -112;
        public const int ERR_INVALID_MEASPARAM_LEVEL_RAM   = -113;
        public const int ERR_INVALID_MEASPARAM_SAT2_RAM    = -114;
        public const int ERR_INVALID_MEASPARAM_FWVER_RAM   = -115; //StoreToRAM in 0.20.0.0 and later
        public const int ERR_INVALID_MEASPARAM_DYNDARK     = -116;

        // Return error codes; SetSensitivityMode check
        public const int ERR_NOT_SUPPORTED_BY_SENSOR_TYPE  = -120;
        public const int ERR_NOT_SUPPORTED_BY_FW_VER       = -121;
        public const int ERR_NOT_SUPPORTED_BY_FPGA_VER     = -122;
        
		public const int UNCONFIGURED_DEVICE_OFFSET = 256;
		public const long INVALID_AVS_HANDLE_VALUE=1000L;		
		public const ushort MAX_PIXEL_VALUE = 65532;
		public const ushort MAX_LASER_WIDTH = 65535;
		public const byte HW_TRIGGER_MODE = 1;
		public const byte SW_TRIGGER_MODE = 0;
		public const byte Ext_TRIGGER_MODE = 1;
		public const byte SYNCH_TRIGGER_MODE = 0;
		public const byte EDGE_TRIGGER_SOURCE = 0;
		public const byte LEVEL_TRIGGER_SOURCE = 1;
		public const byte MAX_TRIGGER_MODE = 1;
		public const byte MAX_TRIGGER_SOURCE = 1;
		public const byte MAX_TRIGGER_SOURCE_TYPE = 1;
		public const System.UInt32 MAX_INTEGRATION_TIME = 600000;
		public const byte SAT_DISABLE_DET = 0;
		public const byte SAT_ENABLE_DET = 1;
		public const byte SAT_PEAK_INVERSION = 2;

		public const byte     USER_ID_LEN             = 64;
		public const byte     NR_WAVELEN_POL_COEF     = 5;
		public const byte     NR_NONLIN_POL_COEF      = 8;
		public const byte     NR_DEFECTIVE_PIXELS     = 30;
		public const ushort   MAX_NR_PIXELS           = 4096;
		public const byte     NR_TEMP_POL_COEF        = 5;
		public const byte     MAX_TEMP_SENSORS        = 3;
		public const byte     ROOT_NAME_LEN           = 6;
		public const byte     AVS_SERIAL_LEN          = 10;
		public const byte     MAX_VIDEO_CHANNELS      = 2;
		public const byte     NR_DAC_POL_COEF         = 2;

		//---- enumerations ---------------------------------------------------
		
		public enum DEVICE_STATUS : byte
		{
			UNKNOWN = 0,
			USB_AVAILABLE = 1,
			USB_IN_USE_BY_APPLICATION = 2,
			USB_IN_USE_BY_OTHER = 3,
            ETH_AVAILABLE = 4,
            ETH_IN_USE_BY_APPLICATION = 5,
            ETH_IN_USE_BY_OTHER = 6,
            ETH_ALREADY_IN_USE_USB = 7
		} ;
		
		public enum SENS_TYPE : byte
		{
			SENS_HAMS8378_256 = 1,
			SENS_HAMS8378_1024 = 2,
			SENS_ILX554 = 3,
			SENS_HAMS9201 = 4,
			SENS_TCD1304 = 5,
			SENS_TSL1301 = 6,
			SENS_TSL1401 = 7,
			SENS_HAMS8378_512 = 8,
			SENS_HAMS9840 = 9,
			SENS_ILX511 = 10,
			SENS_HAMS10420_2048X64 = 11,
			SENS_HAMS11071_2048X64 = 12,
			SENS_HAMS7031_1024X122 = 13,
			SENS_HAMS7031_1024X58 = 14,
			SENS_HAMS11071_2048X16 = 15,
            SENS_HAMS11155 = 16,
            SENS_SU256LSB = 17,
            SENS_SU512LDB = 18,
            SENS_HAMS11638 = 21,
            SENS_HAMS11639 = 22,
            SENS_HAMS12443 = 23,
            SENS_HAMG9208_512 = 24
		} ;
		//---------------------------------------------------------------------

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct PixelArrayType
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_NR_PIXELS)]
            public double[] Value;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SaturatedArrayType
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_NR_PIXELS)]
            public byte[] Value;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct String16Type
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string String16;
        }
        
		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct AvsIdentityType
		{
			[MarshalAs (UnmanagedType.ByValTStr, SizeConst=10)]
			public string m_SerialNumber;
			[MarshalAs (UnmanagedType.ByValTStr, SizeConst=64)]
			public string m_UserFriendlyName;
			public DEVICE_STATUS	m_Status;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct DetectorType
		{
			public byte			m_SensorType;
			public ushort		m_NrPixels;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=NR_WAVELEN_POL_COEF)]
			public float[]		m_aFit;
			public byte			m_NLEnable;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=NR_NONLIN_POL_COEF)]
			public double[]		m_aNLCorrect;
			public double		m_aLowNLCounts;
			public double		m_aHighNLCounts;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=MAX_VIDEO_CHANNELS)]
			public float[]		m_Gain;
			public float		m_Reserved;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=MAX_VIDEO_CHANNELS)]
			public float[]		m_Offset;
			public float		m_ExtOffset;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=NR_DEFECTIVE_PIXELS)]
			public ushort[]		m_DefectivePixels;
		};
		
		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct IrradianceType
		{
			public SpectrumCalibrationType m_IntensityCalib;
			public byte					m_CalibrationType;
			public uint					m_FiberDiameter;
		} ;
		
		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct SpectrumCalibrationType
		{
			public SmoothingType           m_Smoothing;
			public float                   m_CalInttime;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=MAX_NR_PIXELS)]
			public float[] m_aCalibConvers;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct SmoothingType
		{
			public ushort				m_SmoothPix;
			public byte					m_SmoothModel;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct SpectrumCorrectionType
		{
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=MAX_NR_PIXELS)]
			public float[]              m_aSpectrumCorrect;
		};
	
		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct StandAloneType
		{
			public byte                 m_Enable;
			public MeasConfigType       m_Meas;		
			public short                m_Nmsr;
		} ;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DynamicStorageType
        {
            public int                  m_Nmsr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[]               reserved;
        } ;

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct MeasConfigType
		{
			public ushort               m_StartPixel;
			public ushort               m_StopPixel;
			public float                m_IntegrationTime;
			public uint					m_IntegrationDelay;
			public uint					m_NrAverages;
			public DarkCorrectionType   m_CorDynDark;
			public SmoothingType        m_Smoothing;
			public byte					m_SaturationDetection;
			public TriggerType          m_Trigger;
			public ControlSettingsType  m_Control;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct TimeStampType
		{
			public ushort				m_Date;
			public ushort				m_Time;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct DarkCorrectionType
		{
			public byte                 m_Enable;
			public byte					m_ForgetPercentage;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct TriggerType
		{
			public byte		           m_Mode;
			public byte                m_Source;
			public byte                m_SourceType;
		};

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct ControlSettingsType
		{
			public ushort               m_StrobeControl;
			public uint		            m_LaserDelay;
			public uint	                m_LaserWidth;
			public float                m_LaserWaveLength;
			public ushort				m_StoreToRam;
		};

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BroadcastAnswerType
        {
            public byte   InterfaceType;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
            public string serial;
            public ushort port;
            public byte   status;
            public uint   RemoteHostIp;
            public uint   LocalIp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte   reserved;
        };

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct TecControlType
		{
			public byte             m_Enable;
			public float			m_Setpoint;     // [degree Celsius]
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=NR_DAC_POL_COEF)]
			public float[]          m_aFit;
		} ;

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct ProcessControlType
		{
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=2)]
			public float[]                 AnalogLow;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=2)]
			public float[]                 AnalogHigh;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
			public float[]                 DigitalLow;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=10)]
			public float[]                 DigitalHigh;
		} ;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct EthernetSettingsType
        {
            public uint                     m_IpAddr;
            public uint                     m_NetMask;
            public uint                     m_Gateway;
            public byte                     m_DhcpEnabled;
            public short                    m_TcpPort;
            public byte                     m_LinkStatus;
        };

		const ushort SETTINGS_RESERVED_LEN  = 13816; 

		[StructLayout(LayoutKind.Sequential,Pack=1)]
		public struct DeviceConfigType
		{
			public ushort					m_Len;
			public ushort					m_ConfigVersion;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=USER_ID_LEN)]
			public byte[]					m_aUserFriendlyId;
			public DetectorType				m_Detector;
			public IrradianceType			m_Irradiance;
			public SpectrumCalibrationType	m_Reflectance;
			public SpectrumCorrectionType	m_SpectrumCorrect;
			public StandAloneType			m_StandAlone;
            public DynamicStorageType       m_DynamicStorage;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=15)]//(MAX_TEMP_SENSORS*NR_TEMP_POL_COEF)
			public float[]					m_aTemperature;
			public TecControlType           m_TecControl;
			public ProcessControlType       m_ProcessControl;
            public EthernetSettingsType     m_EthernetSettings;
			[MarshalAs(UnmanagedType.ByValArray,SizeConst=SETTINGS_RESERVED_LEN)]
			public byte[]					m_aReserved;
		}
		
		[DllImport("avaspec.dll")]
		public static extern int AVS_Init(short a_Port);

		[DllImport("avaspec.dll")]
		public static extern int AVS_Done();

		[DllImport("avaspec.dll")]
		public static extern int AVS_StopMeasure(IntPtr a_hDevice);

		[DllImport("avaspec.dll")]
		public static extern int AVS_PollScan(IntPtr a_hDevice);
		
		[DllImport("avaspec.dll")]
		public static extern bool AVS_Register(IntPtr a_hWnd);
		
		[DllImport("avaspec.dll")]
		public static extern int AVS_GetNrOfDevices();

        [DllImport("avaspec.dll")]
        public static extern int AVS_UpdateUSBDevices();

        [DllImport("avaspec.dll")]
        public static extern int AVS_UpdateETHDevices(uint a_ListSize, ref uint a_pRequiredSize, [In, Out] BroadcastAnswerType[] a_pList);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_GetVersionInfo(IntPtr a_hDevice, ref String16Type a_pFpgaVer, ref String16Type a_pFirmwareVer, ref String16Type a_pDllVer);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_Deactivate(IntPtr a_pDeviceId);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_Activate(ref AvsIdentityType a_DeviceId);
		
		[DllImport("avaspec.dll")]
        public static extern int AVS_GetList(uint a_ListSize, ref uint a_pRequiredSize, [In, Out] AvsIdentityType[] a_pList);
		
		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_PrepareMeasure(IntPtr a_hDevice, ref MeasConfigType a_pMeasConfig);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_Measure(IntPtr a_hDevice, IntPtr a_hWnd, short a_Nmsr);
		
		[DllImport("avaspec.dll")]
        public static extern IntPtr AVS_GetLambda(IntPtr a_hDevice, ref PixelArrayType a_pWavelength);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_GetNumPixels(IntPtr a_hDevice, ref ushort a_pNumPixel);

		[DllImport("avaspec.dll")]
        public static extern IntPtr AVS_GetParameter(IntPtr a_hDevice, uint a_Size, ref uint a_pRqdSize, ref DeviceConfigType a_pData);

		[DllImport("avaspec.dll")]
		public static extern IntPtr AVS_SetParameter(IntPtr a_hDevice,ref DeviceConfigType a_pDeviceParm);

		[DllImport("avaspec.dll")]
		public static extern int AVS_GetScopeData(IntPtr a_hDevice, ref uint a_pTimeLabel,ref PixelArrayType a_pSpectrum);

		[DllImport("avaspec.dll")]
		public static extern int AVS_GetSaturatedPixels(IntPtr a_hDevice, ref SaturatedArrayType a_pSaturated);
		
		[DllImport("avaspec.dll")]
		public static extern int AVS_SetAnalogOut(IntPtr a_hDevice, byte a_PortId, float a_Value);
		
		[DllImport("avaspec.dll")]
		public static extern int AVS_SetDigOut(IntPtr a_hHandle, byte a_PortId, byte a_Status);

		[DllImport("avaspec.dll")]
		public static extern int AVS_SetPwmOut(IntPtr a_hHandle, byte a_PortId, uint a_Freq, byte a_Duty);

		[DllImport("avaspec.dll")]
		public static extern int AVS_GetAnalogIn(IntPtr a_hDevice, byte a_AnalogInId, ref float a_pAnalogIn);

		[DllImport("avaspec.dll")]
		public static extern int AVS_GetDigIn(IntPtr a_hHandle, byte a_DigInId, ref byte a_pDigIn);

		[DllImport("avaspec.dll")]
		public static extern int AVS_UseHighResAdc(IntPtr a_hDevice, bool a_Enable);

        [DllImport("avaspec.dll")]
        public static extern int AVS_SetPrescanMode(IntPtr a_hDevice, bool a_Prescan);

        [DllImport("avaspec.dll")]
        public static extern int AVS_SetSensitivityMode(IntPtr a_hDevice, UInt32 a_SensitivityMode);

        [DllImport("avaspec.dll")]
        public static extern int AVS_GetIpConfig(IntPtr a_hDevice, ref EthernetSettingsType a_pData);

		public avaspec()
		{

		}
	}
}

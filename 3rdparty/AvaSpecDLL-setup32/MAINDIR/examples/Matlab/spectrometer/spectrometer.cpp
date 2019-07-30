
#include <windows.h>
#include <math.h>
#include <string>
#include <strstream>
#include "mex.h"
#include "avaspec.h"
#include "utility.h"

//#define _DEBUG

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Types
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
typedef void(*Handler) (int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);

typedef struct {
	char *pCommand;
	Handler pHandler;
} CommandHandler;

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
//  Forward Declarations
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
void ThrowString(char * szError);
bool ArrayToString(const mxArray *pArray, std::string &str);
int GetDoubleFieldValue(double *val, char *fieldname, const mxArray *prhs[]);
int GetStringFieldValue(char *val, char *fieldname, const mxArray *prhs[]);
void CommandDispatch(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetNumPixels(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetLambda(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetVersion(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetDigOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetPwmOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetAnalogOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnMeasureConfig(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnMeasure(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnStopMeasure(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetData(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetSaturated(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnDataReady(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetParameter(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetParameter(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnUseHighRes(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetPrescanMode(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetDigIn(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnGetAnalogIn(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);
void OnSetSensitivityMode(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);

// ------------------------
// Globals
// ------------------------

bool bFirstTime = true;
AvsHandle g_hDevice ;
unsigned short g_startpixel;
unsigned short g_stoppixel;
MeasConfigType config;
DeviceConfigType devcon;

CommandHandler commands[] = {
		"getnumpixels", OnGetNumPixels,
		"getlambda", OnGetLambda,
		"getversion", OnGetVersion,
		"setdigout", OnSetDigOut,
		"setpwmout", OnSetPwmOut,
		"setanalogout", OnSetAnalogOut,
		"measconfig", OnMeasureConfig,
		"measure", OnMeasure,
		"stop", OnStopMeasure,
		"getdata", OnGetData,
		"getsaturated", OnGetSaturated,
		"ready", OnDataReady,
		"getparameter", OnGetParameter,
		"setparameter", OnSetParameter,
		"usehighres", OnUseHighRes,
		"setprescanmode", OnSetPrescanMode,
		"getdigin", OnGetDigIn,
		"getanalogin", OnGetAnalogIn,
		"setsensitivitymode", OnSetSensitivityMode
};

void DebugStringMessage(char * msg)
{
#ifdef _DEBUG
	mexPrintf("AS5216 debug message: %s\n", msg);
#endif
}

void DebugIntegerMessage(int intval)
{
#ifdef _DEBUG
	mexPrintf("AS5216 debug message: %d\n", intval);
#endif
}

void ErrorMessage(char * msg)
{
	mexPrintf("AS5216 ERROR message: %s\n", msg);
}

void CheckRet(int retval)
{
	switch(retval)
	{
	case 0:
		//		return;  Do Nothing
		break;
	case -1:
		ErrorMessage("Invalid parameter");
		break;
	case -2:
		ErrorMessage("Operation not supported");
		break;
	case -3:
		ErrorMessage("Device not found");
		break;
	case -4:
		ErrorMessage("Invalid device ID");
		break;
	case -5:
		ErrorMessage("Operation pending");
		break;
	case -6:
		ErrorMessage("Timeout");
		break;
	case -7:
		ErrorMessage("Invalid password");
		break;
	case -8:
		ErrorMessage("Invalid measurement data");
		break;	
	case -9:
		ErrorMessage("Invalid size");
		break;
	case -10:
		ErrorMessage("Invalid pixel range");
		break;	
	case -11:
		ErrorMessage("Invalid integration time");
		break;	
	case -12:
		ErrorMessage("Invalid combination");
		break;	
	case -13:
		ErrorMessage("Invalid configuration");
		break;
	case -14:
		ErrorMessage("No measurement buffer available");
		break;
	case -15:
		ErrorMessage("Unknown error");
		break;
	case -16:
		ErrorMessage("Communication error");
		break;
	case -17:
		ErrorMessage("No spectra in RAM");
		break;
	case -18:
		ErrorMessage("Invalid DLL version");
		break;
	case -19:
		ErrorMessage("No memory");
		break;
	case -20:
		ErrorMessage("DLL initialisation failed");
		break;
	case -21:
		ErrorMessage("Invalid state");
		break;
	}
}

static void ExitFunction(void)
{
	DebugStringMessage("Closing communication");
	CheckRet(AVS_StopMeasure(g_hDevice));
	CheckRet(AVS_Deactivate(g_hDevice));
	CheckRet(AVS_Done());
}

bool ArrayToString(const mxArray *pArray, std::string &str)
{
	bool okay = true;
	int buflen;
	int status;
	
	if (mxIsChar(pArray) != 1) {
		str = "vfm: requires a string";
		okay = false;
	}
	
	buflen = mxGetN(pArray) + 1;
	char *pStr = (char*)mxCalloc (buflen, sizeof(char));
	status = mxGetString (pArray, pStr, buflen);
	if (status != 0)
		mexWarnMsgTxt ("Not enough space. String truncated.");
	
	str = pStr;
	mxFree(pStr);
	return okay;
}

void mexFunction(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	if (bFirstTime)
	{
		// Load the library and initialize communication
		
		
		/*******************************************************************************
		Looks for connected spectrometers
		*******************************************************************************/
		AvsIdentityType l_Active ;
		unsigned int l_reqsize;
		
		DebugStringMessage("Open communication busy");
		
		// int l_Port; 
		DebugStringMessage("AVS_Init");
		CheckRet(AVS_Init(0));
		DebugStringMessage("AVS_GetList");
		CheckRet(AVS_GetList(sizeof(AvsIdentityType), &l_reqsize, & l_Active));
		
		/*******************************************************************************
		Activate Spectrometer
		*******************************************************************************/
		DebugStringMessage("AVS_Activate");
		g_hDevice = AVS_Activate(&l_Active);
		
		if (g_hDevice == INVALID_AVS_HANDLE_VALUE )
			ErrorMessage("Error opening device"); 
		
		DebugStringMessage("Open communication finished");
		mexAtExit(ExitFunction);
		bFirstTime = false;
	}
	
	if (nrhs == 0)
		return;
	
	try
	{
		CommandDispatch(nlhs, plhs, nrhs, prhs);
	}
	catch (std::string *pStr)
	{
		mexWarnMsgTxt(pStr->c_str());
		delete_ptr (pStr);
	}
	
	return;
}

void CommandDispatch(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	std::string str;
	
	if (!ArrayToString (prhs[0], str)) {
		mexWarnMsgTxt(str.c_str());
		return;
	}
	if (nlhs == 0) nlhs++;
	WORD wItems = sizeof (commands) / sizeof(CommandHandler);
	bool bFound = false;
	
	for (WORD wIndex = 0; wIndex < wItems && !bFound; wIndex++)
	{
		if (str == commands[wIndex].pCommand) {
			bFound = true;
			commands[wIndex].pHandler(nlhs, plhs, nrhs-1, prhs+1);
		}
	}
	
	std::ostrstream error;
	
	if (!bFound) {
		error << "Unrecognised command: " << str.data() << std::ends;
		ThrowString (error.str());
	}
}

inline void ThrowString(char * szError)
{
	std::string *pError = new std::string (szError);
	throw (pError);
}

void OnGetNumPixels(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned short numpixels;
	unsigned short *np;
	const int dims[]={1,1};

	DebugStringMessage("OnGetNumPixels");
	// error checking for arguments
	if (nrhs > 0) {
		ThrowString("wrong # of arguments - should be 'getnumpixels' ");
	}
	plhs[0]=mxCreateNumericArray(2, dims, mxUINT16_CLASS, mxREAL);
	np=(unsigned short*) mxGetData(plhs[0]);
	CheckRet(AVS_GetNumPixels(g_hDevice, &numpixels));
	*np=numpixels;
}

void OnGetLambda(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned short numpixels;
	double * lambda;
	
	DebugStringMessage("OnGetLambda");
	// error checking for arguments
	if (nrhs > 0) {
		ThrowString ("wrong # of arguments - should be 'getlambda' ");
	}
	CheckRet(AVS_GetNumPixels(g_hDevice, &numpixels));
	plhs[0]=mxCreateDoubleMatrix(numpixels, 1, mxREAL);
	lambda=mxGetPr(plhs[0]);
	CheckRet(AVS_GetLambda(g_hDevice, lambda));
}

void OnGetVersion(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	char fpga[16];
	char firmware[16];
	char dll[16];
	int dims[2]={1, 1};
	const char *field_names[] = {"fpga", "firmware", "dll"};
	
	DebugStringMessage("OnGetVersionInfo");
	// error checking for arguments
	if (nrhs > 0) {
		ThrowString ("wrong # of arguments - should be 'getversioninfo' ");
	}
	
	CheckRet(AVS_GetVersionInfo(g_hDevice, fpga, firmware, dll));
	
	DebugStringMessage(fpga);
	DebugStringMessage(firmware);
	DebugStringMessage(dll);
	
	plhs[0] = mxCreateStructArray(2, dims, 3, field_names);
	mxSetFieldByNumber(plhs[0], 0, 0, mxCreateString(fpga));
	mxSetFieldByNumber(plhs[0], 0, 1, mxCreateString(firmware));
	mxSetFieldByNumber(plhs[0], 0, 2, mxCreateString(dll));
}

void OnSetDigOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned char port;
	unsigned char value;
	char msg[256];
	DebugStringMessage("OnSetDigOut");
	// error checking for arguments
	if (nrhs != 2) 
		ThrowString ("wrong # of arguments - should be 'setdigout', port, value ");
	
	port=(unsigned char) mxGetScalar(prhs[0]);
	value=(unsigned char) mxGetScalar(prhs[1]);
	
	sprintf(msg, "port: %i, value: %i", port, value);
	DebugStringMessage(msg);
	
	CheckRet(AVS_SetDigOut(g_hDevice, port, value));
}

void OnSetPwmOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned char port;
	unsigned long frequency;
	unsigned char duty;
	char msg[256];
	
	DebugStringMessage("OnSetPwmOut");
	// error checking for arguments
	if (nrhs != 3) 
		ThrowString ("wrong # of arguments - should be 'setpwmout', port, frequency, dutycycle ");
	
	port=(unsigned char) mxGetScalar(prhs[0]);
	frequency=(unsigned long) mxGetScalar(prhs[1]);
	duty=(unsigned char) mxGetScalar(prhs[2]);
	
	sprintf(msg, "port: %d, frequency: %d, duty: %d", port, frequency, duty);
	DebugStringMessage(msg);
	
	CheckRet(AVS_SetPwmOut(g_hDevice, port, frequency, duty));
}

void OnSetAnalogOut(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned char port;
	float voltage;
	
	DebugStringMessage("OnSetAnalogOut");
	// error checking for arguments
	if (nrhs != 2) 
		ThrowString ("wrong # of arguments - should be 'setanalogout', port, voltage ");
	
	port=(unsigned char) mxGetScalar(prhs[0]);
	voltage=(float) mxGetScalar(prhs[1]);
	
	CheckRet(AVS_SetAnalogOut(g_hDevice, port, voltage));
}

void OnMeasureConfig(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	double val;
	DarkCorrectionType darkcorrection;
	SmoothingType smoothing;
	TriggerType trigger;
	ControlSettingsType controlsettings;
	
	// Set default values
	config.m_StartPixel=0;
	CheckRet(AVS_GetNumPixels(g_hDevice, &g_stoppixel));
	config.m_StopPixel=g_stoppixel-1;
	config.m_IntegrationTime=500;
	config.m_IntegrationDelay=0;
	config.m_NrAverages=1;
	darkcorrection.m_Enable=1;
	darkcorrection.m_ForgetPercentage=100;
	
	smoothing.m_SmoothModel=0;
	smoothing.m_SmoothPix=2;
	config.m_Smoothing=smoothing;
	config.m_SaturationDetection=1;
	trigger.m_Mode=0;
	trigger.m_Source=0;
	trigger.m_SourceType=0;
	controlsettings.m_StrobeControl=0;
	controlsettings.m_LaserDelay=0;
	controlsettings.m_LaserWidth=0;
	controlsettings.m_LaserWaveLength=0;
	controlsettings.m_StoreToRam=0;
	
	DebugStringMessage("OnMeasureConfig");
	if (nrhs > 1) 
		ThrowString ("wrong # of arguments - should be 'measconfig' [, settings]");
	
	// Check for settings
	if (nrhs==1)
	{
		if (GetDoubleFieldValue(&val, "IntegrationTime", prhs)) 
			config.m_IntegrationTime=(float) val;
		if (GetDoubleFieldValue(&val, "StartPixel", prhs))
			config.m_StartPixel=(uint16) val;
		if (GetDoubleFieldValue(&val, "StopPixel", prhs)) 
			config.m_StopPixel=(uint16) val;
		if (GetDoubleFieldValue(&val, "IntegrationDelay", prhs)) 
			config.m_IntegrationDelay=(uint32) val;
		if (GetDoubleFieldValue(&val, "NrAverages", prhs)) 
			config.m_NrAverages=(uint32) val;
		if (GetDoubleFieldValue(&val, "CorDynDark", prhs)) 
			darkcorrection.m_Enable=(uint8) val;
		if (GetDoubleFieldValue(&val, "Smoothing", prhs)) 
			smoothing.m_SmoothPix=(uint16) val;
		if (GetDoubleFieldValue(&val, "TriggerMode", prhs)) 
			trigger.m_Mode=(uint8) val;
		if (GetDoubleFieldValue(&val, "TriggerSource", prhs)) 
			trigger.m_Source=(uint8) val;
		if (GetDoubleFieldValue(&val, "TriggerSourceType", prhs)) 
			trigger.m_SourceType=(uint8) val;
		if (GetDoubleFieldValue(&val, "SaturationDetection", prhs)) 
			config.m_SaturationDetection=(uint8) val;
		if (GetDoubleFieldValue(&val, "NrStoreToRam", prhs))
			controlsettings.m_StoreToRam=(uint16) val;
	}
	
#ifdef _DEBUG
	mexPrintf("NrAverages: %i\n", config.m_NrAverages);
#endif
	
	config.m_CorDynDark=darkcorrection;
	config.m_Smoothing=smoothing;
	config.m_Trigger=trigger;
	config.m_Control=controlsettings;
	
	DebugStringMessage("OnMeasureConfig");
	
	CheckRet(AVS_PrepareMeasure(g_hDevice, &config));
	g_startpixel=config.m_StartPixel;
	g_stoppixel=config.m_StopPixel;
}

int GetDoubleFieldValue(double *val, char *fieldname, const mxArray *prhs[])
{
	mxArray * tmp;
	
	if (!mxIsStruct(prhs[0]))
		ErrorMessage("settings must be a struct");
	tmp=mxGetField(prhs[0], 0, fieldname);
	if (tmp==NULL)
	{
#ifdef _DEBUG
		mexPrintf("GetDoubleFieldValue: Empty field, %s\n", fieldname);
#endif
		return(0);
	}
	else
	{
		if (!mxIsNumeric(tmp))
			mexErrMsgTxt("Non-numeric field\n");
		*val=mxGetScalar(tmp);
#ifdef _DEBUG
		mexPrintf("GetDoubleFieldValue: %s: %4.3f\n", fieldname, *val);
#endif
		return(1);
	}
}

int GetStringFieldValue(char *val, char *fieldname, const mxArray *prhs[])
{
	mxArray * tmp;
	
	if (!mxIsStruct(prhs[0]))
		ErrorMessage("settings must be a struct");
	tmp=mxGetField(prhs[0], 0, fieldname);
	if (tmp==NULL)
	{
#ifdef _DEBUG
		mexPrintf("GetStringFieldValue: Empty field, %s\n", fieldname);
#endif
		return(0);
	}
	else
	{
		if (!mxIsChar(tmp))
			mexErrMsgTxt("Non-string field\n");
		mxGetString(tmp, val, 64);
#ifdef _DEBUG
		mexPrintf("GetStringFieldValue: %s: %s\n", fieldname, val);
#endif
		return(1);
	}
}


void OnMeasure(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	short number=1;
	int ready;
	DWORD timeout;
	int result;
	
	if (nrhs > 1) 
		ThrowString ("wrong # of arguments - should be 'measure'[, number]");
	
	if (nrhs==1) number=(short) mxGetScalar(prhs[0]);
	
	DebugStringMessage("OnMeasure");
	CheckRet(AVS_Measure(g_hDevice, NULL, number));
	ready=0;
	timeout=(DWORD) config.m_IntegrationTime*config.m_NrAverages+5000;
	// in milliseconds, 5 seconds over expected value
	DWORD time1=GetTickCount();
	DWORD time2=GetTickCount();
	while ((!ready) && ((time2-time1)<timeout))
	{
		time2=GetTickCount();
		ready=AVS_PollScan(g_hDevice);
		Sleep(1);
		// test on time-out (integrationtime * averages)
		if ((time2-time1)>=timeout)
		{
			ErrorMessage("Timeout while waiting for data");
			break;
		}
	}
}

void OnStopMeasure(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	if (nrhs > 0) 
		ThrowString ("wrong # of arguments - should be 'stop'");
	
	DebugStringMessage("OnStopMeasure");
	
	CheckRet(AVS_StopMeasure(g_hDevice));
}

void OnGetData(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	int npix;
	unsigned int timelabel;
	double * data;

	DebugStringMessage("OnGetData");
	if (nrhs > 0) 
		ThrowString ("wrong # of arguments - should be 'getdata'");
	
	npix=1+g_stoppixel-g_startpixel;
	
	plhs[0]=mxCreateDoubleMatrix(npix, 1, mxREAL);
	data=mxGetPr(plhs[0]);
	CheckRet(AVS_GetScopeData(g_hDevice, &timelabel, data));
}

void OnGetSaturated(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	int npix;
	int dims[2];
	unsigned char * sat;

	DebugStringMessage("OnGetSaturated");
	if (nrhs > 0) 
		ThrowString ("wrong # of arguments - should be 'getsaturated'");

	npix=1+g_stoppixel-g_startpixel;
	dims[0]=1;
	dims[1]=npix;
	plhs[0]=mxCreateNumericArray(2, dims, mxUINT8_CLASS, mxREAL);
	sat=(unsigned char*) mxGetData(plhs[0]);
	CheckRet(AVS_GetSaturatedPixels(g_hDevice, sat));
}

void OnDataReady(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	int ready;
	double * d;
	
	DebugStringMessage("OnDataReady");
	if (nrhs > 0) 
		ThrowString ("wrong # of arguments - should be 'ready'");
	
	plhs[0]=mxCreateDoubleMatrix(1, 1, mxREAL);
	ready=AVS_PollScan(g_hDevice);
	if (ready<0)	// Error encountered
		CheckRet(ready);
	
	d=mxGetPr(plhs[0]);
	*d = ready;
}

void OnGetParameter(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned int l_Size;
	int dims[2]={1, 1};
	const char *field_names[] = {"FriendlyName", "SensorType"};
	mxArray *fout;
	char friendly[64];
	unsigned char sensortype;
	unsigned char *st;

    CheckRet(AVS_GetParameter(g_hDevice, sizeof(devcon), &l_Size, &devcon));
	plhs[0] = mxCreateStructArray(2, dims, 2, field_names);
	strcpy(friendly,devcon.m_aUserFriendlyId);
	sensortype=devcon.m_Detector.m_SensorType;
	DebugStringMessage(friendly);
	DebugIntegerMessage(sensortype);

	mxSetFieldByNumber(plhs[0], 0, 0, mxCreateString(friendly));
	fout=mxCreateNumericArray(2, dims, mxUINT8_CLASS, mxREAL);
	st=(unsigned char*) mxGetData(fout);
	*st=sensortype;
	mxSetFieldByNumber(plhs[0], 0, 1, fout);
}

void OnSetParameter(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned int l_Size;
	char friendly[64];

    CheckRet(AVS_GetParameter(g_hDevice, sizeof(devcon), &l_Size, &devcon));
	if (nrhs==1)
	{
		if (GetStringFieldValue(&friendly[0], "FriendlyName", prhs)) 
			strcpy(devcon.m_aUserFriendlyId,friendly);
		DebugStringMessage(friendly);
		CheckRet(AVS_SetParameter(g_hDevice, &devcon));
	}
}

void OnUseHighRes(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	bool enable;

	DebugStringMessage("OnUseHighRes");
	if (nrhs!=1)
		ThrowString ("wrong # of arguments - should be 'usehighres', true(1) or false(0)");

	enable=(mxGetScalar(prhs[0])!=0);
	CheckRet(AVS_UseHighResAdc(g_hDevice, enable));
}

void OnSetPrescanMode(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	bool enable;

	DebugStringMessage("OnSetPrescanMode");
	if (nrhs!=1)
		ThrowString ("wrong # of arguments - should be 'setprescanmode', true(1) or false(0)");

	enable=(mxGetScalar(prhs[0])!=0);
	CheckRet(AVS_SetPrescanMode(g_hDevice, enable));
}

void OnGetDigIn(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned char digin;
	unsigned char status;
	unsigned char *stat;
	const int dims[]={1,1};

	DebugStringMessage("OnGetDigIn");
	if (nrhs!=1)
		ThrowString ("wrong # of arguments - should be 'getdigin', DI# (0..2)");

	digin=(unsigned char) mxGetScalar(prhs[0]);
	CheckRet(AVS_GetDigIn(g_hDevice, digin, &status));

	plhs[0]=mxCreateNumericArray(2, dims, mxUINT8_CLASS, mxREAL);
	stat=(unsigned char*) mxGetData(plhs[0]);
	*stat=status;
}

void OnGetAnalogIn(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned char analogin;
	float value;
	float *val;
	const int dims[]={1,1};

	DebugStringMessage("OnGetAnalogIn");
	if (nrhs!=1)
		ThrowString ("wrong # of arguments - should be 'getanalogin', AI# (0..7)");

	analogin=(unsigned char) mxGetScalar(prhs[0]);
	CheckRet(AVS_GetAnalogIn(g_hDevice, analogin, &value));

	plhs[0]=mxCreateNumericArray(2, dims, mxSINGLE_CLASS, mxREAL);
	val=(float*) mxGetData(plhs[0]);
	*val=value;
}

void OnSetSensitivityMode(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
	unsigned int a_SensitivityMode;
	char msg[256];

	DebugStringMessage("OnSetSensitivityMode");
	// error checking for arguments
	if (nrhs != 1) 
		ThrowString ("wrong # of arguments - should be 'setsensitivitymode', true(1) or false(0) ");
	a_SensitivityMode=(unsigned int) mxGetScalar(prhs[0]);

	sprintf(msg, "sensitivitymode: %d", a_SensitivityMode);
	DebugStringMessage(msg);
	
	CheckRet(AVS_SetSensitivityMode(g_hDevice, a_SensitivityMode));
}
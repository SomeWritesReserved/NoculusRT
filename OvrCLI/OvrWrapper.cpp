#include "OvrWrapper.h"

ovrResult ovrw_Start(ovrInitFlags initFlags, ovrSession* session)
{
	ovrInitParams initParams = { };
	initParams.Flags = (initFlags | ovrInitFlags::ovrInit_RequestVersion);
	initParams.RequestedMinorVersion = OVR_MINOR_VERSION;
	initParams.LogCallback = nullptr;
	ovrResult result = ovr_Initialize(&initParams);
	if (OVR_FAILURE(result)) { return result; }

	ovrGraphicsLuid graphicsLuid;
	result = ovr_Create(session, &graphicsLuid);
	if (OVR_FAILURE(result)) { ovr_Shutdown(); }

	return result;
}

void ovrw_Stop(ovrSession session)
{
	ovr_Destroy(session);
	ovr_Shutdown();
}

ovrResult ovrw_GetSessionStatus(ovrSession session, ovrwSessionStatus* sessionStatus)
{
	ovrSessionStatus ovrSessionStatus;
	ovrResult result = ovr_GetSessionStatus(session, &ovrSessionStatus);
}
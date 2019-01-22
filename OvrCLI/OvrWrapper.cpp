#include "OVR_CAPI_D3D.h"
#include "OvrCLI.h"

ovrResult ovrw_start(ovrInitFlags initFlags)
{
	ovrInitParams initParams = { initFlags, OVR_MINOR_VERSION, nullptr, 0, 0 };
	ovrResult result = ovr_Initialize(&initParams);
	if (OVR_FAILURE(result)) { return result; }

	ovrSession session;
	ovrGraphicsLuid graphicsLuid;
	result = ovr_Create(&session, &graphicsLuid);
	if (OVR_FAILURE(result)) { ovr_Shutdown(); }

	return result;
}
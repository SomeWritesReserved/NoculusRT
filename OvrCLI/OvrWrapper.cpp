#include "OVR_CAPI_D3D.h"
#include "OvrCLI.h"

void start()
{
	ovrInitParams initParams = { ovrInit_RequestVersion | ovrInit_Invisible, OVR_MINOR_VERSION, nullptr, 0, 0 };
	ovrResult result = ovr_Initialize(&initParams);
	if (OVR_FAILURE(result)) { return; }

	ovrSession session;
	ovrGraphicsLuid graphicsLuid;
	result = ovr_Create(&session, &graphicsLuid);
	if (OVR_FAILURE(result)) { ovr_Shutdown(); return; }

}
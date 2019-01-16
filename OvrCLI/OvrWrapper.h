#pragma once

#include "OVR_CAPI_D3D.h"

ovrResult ovrcli_Initialize()
{
	ovrInitParams initParams = { ovrInitFlags::ovrInit_RequestVersion | ovrInitFlags::ovrInit_Invisible, OVR_MINOR_VERSION, nullptr, 0, 0 };
	return ovr_Initialize(&initParams);
}
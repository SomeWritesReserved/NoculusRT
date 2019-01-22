#pragma once

#include "OVR_CAPI_D3D.h"

#define DECL_STRUCT(name) struct name##_Native
#include "StructsCore.h"

namespace OvrCLI
{
#define DECL_STRUCT(name) public value struct name
#define IS_CLI
#include "StructsCore.h"
}

ovrResult ovrw_Start(ovrInitFlags initFlags, ovrSession* session);
void ovrw_Stop(ovrSession session);
#include "OVR_CAPI_D3D.h"
#include "OvrCLI.h"

using namespace System;

namespace OvrCLI
{
	public ref class OculusSession : IDisposable
	{
	private:
		OculusSession(ovrSession pSession)
		{
			this->pSession = pSession;
		}

		ovrSession pSession;

	public:
		static OculusSession^ Create()
		{
			ovrInitParams* initParams = ovrMallocStruct(ovrInitParams);
			initParams->Flags = ovrInitFlags::ovrInit_RequestVersion | ovrInitFlags::ovrInit_Invisible;
			initParams->RequestedMinorVersion = OVR_MINOR_VERSION;
			ovrCall(ovr_Initialize(initParams));
			ovrFreeStruct(initParams);

			ovrSession session;
			ovrGraphicsLuid* pLuid = ovrMallocStruct(ovrGraphicsLuid);
			ovrCall(ovr_Create(&session, pLuid));

			return gcnew OculusSession(session);
		}

		~OculusSession()
		{
			ovr_Destroy(this->pSession);
			ovr_Shutdown();
		}
	};
}

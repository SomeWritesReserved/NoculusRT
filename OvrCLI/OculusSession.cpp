#include "OVR_CAPI_D3D.h"
#include "OvrWrapper.h"
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
			ovrCall(ovrcli_Initialize());

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

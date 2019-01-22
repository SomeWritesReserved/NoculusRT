#include "OvrWrapper.h"

using namespace System;

namespace OvrCLI
{
	public ref class OculusSession : IDisposable
	{
	private:
		OculusSession(ovrSession session)
		{
			this->session = session;
		}

		~OculusSession()
		{
			ovrw_Stop(this->session);
		}

		ovrSession session;

	public:
		static OculusSession^ Create()
		{
			ovrSession session;
			ovrw_Start(ovrInitFlags::ovrInit_Invisible, &session);
			return gcnew OculusSession(session);
		}
	};
}

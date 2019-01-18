#include "OVR_CAPI_D3D.h"
#include "OvrCLI.h"

using namespace System;

namespace OvrCLI
{
	public ref class OculusSession
	{
	public:
		OculusSession(HmdDescription_Native asd2)
		{
			HmdDescription dss;
			dss.CopyFrom(asd2);
			HmdDescription_Native native2;
			dss.CopyTo(native2);
			this->MyHmdDescription.CopyFrom(native2);
		}

		HmdDescription MyHmdDescription;


		static OculusSession^ Create(short b)
		{
			HmdDescription_Native asd;
			asd.a = 67;
			asd.b = b;
			asd.c = 3236984;
			return gcnew OculusSession(asd);
		}
	};
}

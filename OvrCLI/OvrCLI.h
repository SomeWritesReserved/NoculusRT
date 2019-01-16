using namespace System;

namespace OvrCLI
{
	public ref class OvrException : Exception
	{
	public:
		OvrException(int resultCode)
		{
			this->ResultCode = resultCode;
		}

		property int ResultCode;
	};
}

#define ovrCall(func) { ovrResult result = func; if (!OVR_SUCCESS(result)) { throw gcnew OvrCLI::OvrException(result); } }

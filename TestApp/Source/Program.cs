using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoculusRT;
using NoculusRT.Native64;

namespace TestApp
{
	public class Program
	{
		#region Methods

		public static void Main(string[] args)
		{
			ovrInitParams initParams = new ovrInitParams();
			initParams.Flags = ovrInitFlags.ovrInit_Invisible | ovrInitFlags.ovrInit_RequestVersion;
			initParams.RequestedMinorVersion = 26;

			ovrResult initResult = NativeFunctions.ovr_Initialize(ref initParams);

			IntPtr sessionPointer = IntPtr.Zero;
			ovrGraphicsLuid graphicsLuid = new ovrGraphicsLuid();
			ovrResult createResult = NativeFunctions.ovr_Create(ref sessionPointer, ref graphicsLuid);

			ovrHmdDesc hmdDesc = NativeFunctions.ovr_GetHmdDesc(sessionPointer);

			ovrSizei size = NativeFunctions.ovr_GetFovTextureSize(sessionPointer, 0, hmdDesc.DefaultEyeFov0, 1.0f);

			ovrResult setTrackingResult = NativeFunctions.ovr_SetTrackingOriginType(sessionPointer, ovrTrackingOrigin.ovrTrackingOrigin_FloorLevel);

			while (true)
			{
				ovrSessionStatus sessionStatus = new ovrSessionStatus();
				ovrResult sessionStatusResult = NativeFunctions.ovr_GetSessionStatus(sessionPointer, ref sessionStatus);
				break;
			}

			NativeFunctions.ovr_Destroy(sessionPointer);
			NativeFunctions.ovr_Shutdown();
		}

		#endregion Methods
	}
}

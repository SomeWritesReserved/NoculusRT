using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NoculusRT;
using NoculusRT.Native64;
using OvrCLI;

namespace TestApp
{
	public class Program
	{
		#region Methods

		public static void Main(string[] args)
		{
			/*ovrInitParams initParams = new ovrInitParams();
			initParams.Flags = ovrInitFlags.ovrInit_RequestVersion | ovrInitFlags.ovrInit_Invisible;
			initParams.RequestedMinorVersion = 26;

			ovrResult initResult = NativeFunctions.ovr_Initialize(ref initParams);

			IntPtr sessionPointer = IntPtr.Zero;
			ovrGraphicsLuid graphicsLuid = new ovrGraphicsLuid();
			ovrResult createResult = NativeFunctions.ovr_Create(ref sessionPointer, ref graphicsLuid);

			ovrHmdDesc hmdDesc = NativeFunctions.ovr_GetHmdDesc(sessionPointer);

			ovrSizei sizeLeft = NativeFunctions.ovr_GetFovTextureSize(sessionPointer, ovrEyeType.Left, hmdDesc.DefaultEyeFovLeft, 1.0f);
			ovrSizei sizeRight = NativeFunctions.ovr_GetFovTextureSize(sessionPointer, ovrEyeType.Right, hmdDesc.DefaultEyeFovRight, 1.0f);

			ovrResult setTrackingResult = NativeFunctions.ovr_SetTrackingOriginType(sessionPointer, ovrTrackingOrigin.ovrTrackingOrigin_FloorLevel);

			long frameIndex = 0;
			while (true)
			{
				ovrSessionStatus sessionStatus = new ovrSessionStatus();
				ovrResult sessionStatusResult = NativeFunctions.ovr_GetSessionStatus(sessionPointer, ref sessionStatus);

				ovrEyeRenderDesc eyeRenderDescLeft = NativeFunctions.ovr_GetRenderDesc(sessionPointer, ovrEyeType.Left, hmdDesc.DefaultEyeFovLeft);
				ovrEyeRenderDesc eyeRenderDescRight = NativeFunctions.ovr_GetRenderDesc(sessionPointer, ovrEyeType.Right, hmdDesc.DefaultEyeFovRight);

				ovrPosef[] hmdToEyePose = new ovrPosef[] { eyeRenderDescLeft.HmdToEyePose, eyeRenderDescRight.HmdToEyePose };
				ovrPosef[] outEyePoses = new ovrPosef[2];
				double sensorSampleTime = 0;
				NativeFunctions.ovr_GetEyePoses(sessionPointer, frameIndex, true, hmdToEyePose, outEyePoses, ref sensorSampleTime);

				ovrMatrix4f projectionLeft = NativeFunctions.ovrMatrix4f_Projection(eyeRenderDescLeft.Fov, 0.2f, 1000.0f, ovrProjectionModifier.ovrProjection_None);
				ovrTimewarpProjectionDesc timewarpProjectionDesc = NativeFunctions.ovrTimewarpProjectionDesc_FromProjection(projectionLeft, ovrProjectionModifier.ovrProjection_None);

				Console.WriteLine($"{outEyePoses[0].Position.X} {outEyePoses[0].Position.Y} {outEyePoses[0].Position.Z}");
				//Console.WriteLine($"{outEyePoses[0].Orientation.X} {outEyePoses[0].Orientation.Y} {outEyePoses[0].Orientation.Z} {outEyePoses[0].Orientation.W}");

				if (Console.KeyAvailable) { Console.ReadKey(true); break; }

				frameIndex++;
				Thread.Sleep(11);
			}

			NativeFunctions.ovr_Destroy(sessionPointer);
			NativeFunctions.ovr_Shutdown();
			Console.WriteLine("Done");
			Console.ReadKey(true);*/
		}

		#endregion Methods
	}
}

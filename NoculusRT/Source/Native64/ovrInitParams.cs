using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Parameters for ovr_Initialize.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ovrInitParams
	{
		/// <summary>
		/// Flags from ovrInitFlags to override default behavior.
		/// </summary>
		public ovrInitFlags Flags;

		/// <summary>
		/// Requests a specific minor version of the LibOVR runtime. Flags must include ovrInit_RequestVersion or this will be ignored and OVR_MINOR_VERSION
		/// will be used. If you are directly calling the LibOVRRT version of ovr_Initialize in the LibOVRRT DLL then this must be valid and include ovrInit_RequestVersion.
		/// </summary>
		public uint RequestedMinorVersion;

		/// <summary>
		/// User-supplied log callback function, which may be called at any time asynchronously from multiple threads until ovr_Shutdown completes. Use NULL to specify no log callback.
		/// </summary>
		public IntPtr LogCallback;

		/// <summary>
		/// User-supplied data which is passed as-is to LogCallback. Typically this is used to store an application-specific pointer which is read in the callback function.
		/// </summary>
		public IntPtr UserData;

		/// <summary>
		/// Relative number of milliseconds to wait for a connection to the server before failing. Use 0 for the default timeout.
		/// </summary>
		public uint ConnectionTimeoutMS;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] Pad;
	}

	/// <summary>
	/// Initialization flags.
	/// </summary>
	public enum ovrInitFlags : uint
	{
		/// <summary>
		/// Use all defaults.
		/// </summary>
		Defaults = 0,

		/// <summary>
		/// When a debug library is requested, a slower debugging version of the library will run which can be used to help solve problems in the library and debug application code.
		/// </summary>
		ovrInit_Debug = 0x00000001,

		/// <summary>
		/// When a version is requested, the LibOVR runtime respects the RequestedMinorVersion field and verifies that the RequestedMinorVersion is supported. Normally when you
		/// specify this flag you simply use OVR_MINOR_VERSION for ovrInitParams::RequestedMinorVersion, though you could use a lower version than OVR_MINOR_VERSION to specify previous
		/// version behavior.
		/// </summary>
		ovrInit_RequestVersion = 0x00000004,

		/// <summary>
		/// This client will not be visible in the HMD. Typically set by diagnostic or debugging utilities.
		/// </summary>
		ovrInit_Invisible = 0x00000010,

		/// <summary>
		/// This client will alternate between VR and 2D rendering. Typically set by game engine editors and VR-enabled web browsers.
		/// </summary>
		ovrInit_MixedRendering = 0x00000020,

		/// <summary>
		/// This client is aware of ovrSessionStatus focus states (e.g. ovrSessionStatus::HasInputFocus), and responds to them appropriately (e.g. pauses and stops drawing hands when lacking focus).
		/// </summary>
		ovrInit_FocusAware = 0x00000040,
	}
}

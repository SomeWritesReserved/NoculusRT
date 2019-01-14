using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Houses all the P/Invoke calls into the Oculus VR Runtime dll.
	/// </summary>
	public static class NativeFunctions
	{
		#region Methods

		/// <summary>
		/// Initializes LibOVR. Initialize LibOVR for application usage. This includes finding and loading the LibOVRRT shared library. No LibOVR API functions, other than
		/// ovr_GetLastErrorInfo and ovr_Detect, can be called unless ovr_Initialize succeeds. A successful call to ovr_Initialize must be eventually followed by a call to
		/// ovr_Shutdown. ovr_Initialize calls are idempotent. Calling ovr_Initialize twice does not require two matching calls to ovr_Shutdown.
		/// If already initialized, the return value is ovr_Success.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Initialize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_Initialize(ref ovrInitParams ovrInitParams);

		/// <summary>
		/// Shuts down LibOVR. A successful call to ovr_Initialize must be eventually matched by a call to ovr_Shutdown. After calling ovr_Shutdown, no LibOVR functions can be called
		/// except ovr_GetLastErrorInfo or another ovr_Initialize. ovr_Shutdown invalidates all pointers, references, and created objects previously returned by LibOVR functions.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Shutdown", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern void ovr_Shutdown();

		/// <summary>
		/// Returns information about the most recent failed return value by the current thread for this library.
		/// This function itself can never generate an error. The last error is never cleared by LibOVR, but will be overwritten by new errors.
		/// Do not use this call to determine if there was an error in the last API call as successful API calls don't clear the last ovrErrorInfo.
		/// To avoid any inconsistency, ovr_GetLastErrorInfo should be called immediately after an API function that returned a failed ovrResult, with no other API
		/// functions called in the interim.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetLastErrorInfo", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern void ovr_GetLastErrorInfo(ref ovrErrorInfo ovrErrorInfo);

		/// <summary>
		/// Creates a handle to a VR session. Upon success the returned ovrSession must be eventually freed with ovr_Destroy when it is no longer needed. A second call to
		/// ovr_Create will result in an error return value if the previous session has not been destroyed.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Create", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_Create(ref IntPtr opaqueSessionPointer, ref ovrGraphicsLuid ovrGraphicsLuid);

		/// <summary>
		/// Destroys the session.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Destroy", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern void ovr_Destroy(IntPtr opaqueSessionPointer);

		/// <summary>
		/// Specifies status information for the current session.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetSessionStatus", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_GetSessionStatus(IntPtr opaqueSessionPointer, ref ovrSessionStatus ovrSessionStatus);

		/// <summary>
		/// Sets the tracking origin type. When the tracking origin is changed, all of the calls that either provide or accept ovrPosef will use the new tracking origin provided.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_SetTrackingOriginType", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_SetTrackingOriginType(IntPtr opaqueSessionPointer, ovrTrackingOrigin ovrTrackingOrigin);

		/// <summary>
		/// Returns information about the current HMD. ovr_Initialize must be called prior to calling this function, otherwise ovrHmdDesc::Type will be set to ovrHmd_None without
		/// checking for the HMD presence.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetHmdDesc", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrHmdDesc ovr_GetHmdDesc(IntPtr opaqueSessionPointer);

		/// <summary>
		/// Calculates the recommended viewport size for rendering a given eye within the HMD with a given FOV cone.
		/// Higher FOV will generally require larger textures to maintain quality. Apps packing multiple eye views together on the same texture should ensure there are
		/// at least 8 pixels of padding between them to prevent texture filtering and chromatic aberration causing images to leak between the two eye views.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetFovTextureSize", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrSizei ovr_GetFovTextureSize(IntPtr opaqueSessionPointer, ovrEyeType eye, ovrFovPort fov, float pixelsPerDisplayPixel);

		/// <summary>
		/// Computes the distortion viewport, view adjust, and other rendering parameters for the specified eye.
		/// </summary>
		/// <remarks>https://forums.oculus.com/developer/discussion/comment/562711#Comment_562711 call ovr_GetRenderDesc2.</remarks>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetRenderDesc2", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrEyeRenderDesc ovr_GetRenderDesc(IntPtr opaqueSessionPointer, ovrEyeType eye, ovrFovPort fov);

		/// <summary>
		/// Returns the predicted head pose in outHmdTrackingState and offset eye poses in outEyePoses. This is a thread-safe function where caller should increment frameIndex
		/// with every frame and pass that index where applicable to functions called on the rendering thread. Assuming outEyePoses are used for rendering, it should be passed
		/// as a part of ovrLayerEyeFov. The caller does not need to worry about applying HmdToEyePose to the returned outEyePoses variables.
		/// </summary>
		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetEyePoses", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern void ovr_GetEyePoses(IntPtr opaqueSessionPointer, long frameIndex, [MarshalAs(UnmanagedType.U1)] bool latencyMarker, [MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] ovrPosef[] hmdToEyePose, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 2)] ovrPosef[] outEyePoses, ref double outSensorSampleTime);

		#endregion Methods
	}

	[StructLayout(LayoutKind.Sequential, Size = 24)]
	public struct NativeBlob24
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 64)]
	public struct NativeBlob64
	{
	}
}

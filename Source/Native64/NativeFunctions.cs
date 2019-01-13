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
	internal static class NativeFunctions
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

		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Create", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_Create(ref IntPtr opaqueSessionPointer, ref ovrGraphicsLuid ovrGraphicsLuid);

		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_Destroy", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern void ovr_Destroy(IntPtr opaqueSessionPointer);

		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetSessionStatus", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrResult ovr_GetSessionStatus(IntPtr opaqueSessionPointer, ref ovrSessionStatus ovrSessionStatus);

		[SuppressUnmanagedCodeSecurity]
		[DllImport("LibOVRRT64_1.dll", EntryPoint = "ovr_GetHmdDesc", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl, SetLastError = false, CharSet = CharSet.Ansi)]
		public static extern ovrHmdDesc ovr_GetHmdDesc(IntPtr opaqueSessionPointer);

		#endregion Methods
	}
}

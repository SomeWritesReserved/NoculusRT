using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Specifies status information for the current session.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrSessionStatus
	{
		/// <summary>
		/// True if the process has VR focus and thus is visible in the HMD.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool IsVisible;
		
		/// <summary>
		/// True if an HMD is present.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool HmdPresent;
		
		/// <summary>
		/// True if the HMD is on the user's head.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool HmdMounted;
		
		/// <summary>
		/// True if the session is in a display-lost state. See ovr_SubmitFrame.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool DisplayLost;
		
		/// <summary>
		/// True if the application should initiate shutdown.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool ShouldQuit;
		
		/// <summary>
		/// True if UX has requested re-centering. Must call ovr_ClearShouldRecenterFlag, ovr_RecenterTrackingOrigin or ovr_SpecifyTrackingOrigin.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool ShouldRecenter;
		
		/// <summary>
		/// True if the application is the foreground application and receives input (e.g. Touch controller state). If this is false then the application
		/// is in the background (but possibly still visible) should hide any input representations such as hands.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool HasInputFocus;
		
		/// <summary>
		/// True if a system overlay is present, such as a dashboard. In this case the application (if visible) should pause while still drawing, avoid
		/// drawing near-field graphics so they don't visually fight with the system overlay, and consume fewer CPU and GPU resources.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool OverlayPresent;
		
		/// <summary>
		/// True if runtime is requesting that the application provide depth buffers with projection layers.
		/// </summary>
		[MarshalAs(UnmanagedType.U1)]
		public bool DepthRequested;
	}
}

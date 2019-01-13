using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Specifies the coordinate system ovrTrackingState returns tracking poses in. Used with ovr_SetTrackingOriginType().
	/// </summary>
	public enum ovrTrackingOrigin
	{
		/// <summary>
		/// Tracking system origin reported at eye (HMD) height.
		/// </summary>
		/// <remarks>
		/// Prefer using this origin when your application requires matching user's current physical head pose to a virtual head pose without any regards to a
		/// the height of the floor. Cockpit-based, or 3rd-person experiences are ideal candidates. When used, all poses in ovrTrackingState are reported as an offset
		/// transform from the profile calibrated or recentered HMD pose. It is recommended that apps using this origin type call ovr_RecenterTrackingOrigin
		/// prior to starting the VR experience, but notify the user before doing so to make sure the user is in a comfortable pose, facing a comfortable.
		/// </remarks>
		ovrTrackingOrigin_EyeLevel = 0,

		/// <summary>
		/// Tracking system origin reported at floor height.
		/// </summary>
		/// <remarks>
		/// Prefer using this origin when your application requires the physical floor height to match the virtual floor height, such as standing experiences.
		/// When used, all poses in ovrTrackingState are reported as an offset transform from the profile calibrated floor pose. Calling ovr_RecenterTrackingOrigin
		/// will recenter the X & Z axes as well as yaw, but the Y-axis (i.e. height) will continue to be reported using the floor height as the origin for all poses.
		/// </remarks>
		ovrTrackingOrigin_FloorLevel = 1,
	}
}

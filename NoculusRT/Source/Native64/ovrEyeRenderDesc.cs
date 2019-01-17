using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Rendering information for each eye. Computed by ovr_GetRenderDesc() based on the specified FOV. Note that the rendering viewport is not included
	/// here as it can be specified separately and modified per frame by passing different Viewport values in the layer structure.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrEyeRenderDesc
	{
		/// <summary>
		/// The eye index to which this instance corresponds.
		/// </summary>
		public ovrEyeType Eye;

		/// <summary>
		/// The field of view.
		/// </summary>
		public ovrFovPort Fov;

		/// <summary>
		/// Distortion viewport
		/// </summary>
		public ovrRecti DistortedViewport;

		/// <summary>
		/// How many display pixels will fit in tan(angle) = 1.
		/// </summary>
		public ovrVector2f PixelsPerTanAngleAtCenter;

		/// <summary>
		/// Transform of eye from the HMD center, in meters.
		/// </summary>
		public ovrPosef HmdToEyePose;
	}
}

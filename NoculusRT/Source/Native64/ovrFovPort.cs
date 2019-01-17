using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Describes the up, down, left, and right angles of the field of view. Field Of View (FOV) tangent of the angle units.
	/// For a standard 90 degree vertical FOV, we would have: { UpTan = tan(90 degrees / 2), DownTan = tan(90 degrees / 2) }.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrFovPort
	{
		/// <summary>
		/// Tangent of the angle between the viewing vector and top edge of the FOV.
		/// </summary>
		public float UpTan;

		/// <summary>
		/// Tangent of the angle between the viewing vector and bottom edge of the FOV.
		/// </summary>
		public float DownTan;

		/// <summary>
		/// Tangent of the angle between the viewing vector and left edge of the FOV.
		/// </summary>
		public float LeftTan;

		/// <summary>
		/// Tangent of the angle between the viewing vector and right edge of the FOV.
		/// </summary>
		public float RightTan;
	}
}

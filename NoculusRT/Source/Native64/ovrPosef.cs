using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Position and orientation together. The coordinate system used is right-handed Cartesian.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrPosef
	{
		public ovrQuatf Orientation;
		public ovrVector3f Position;
	}
}

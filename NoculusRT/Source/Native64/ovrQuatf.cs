using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// A quaternion rotation.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct ovrQuatf
	{
		public float X;
		public float Y;
		public float Z;
		public float W;
	}
}

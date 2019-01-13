using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Identifies a graphics device in a platform-specific way. For Windows this is a LUID type.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ovrGraphicsLuid
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] Reserved;
	}
}

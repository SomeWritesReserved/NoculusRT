using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// A 2D vector with float components.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrVector2f
	{
		public float X;
		public float Y;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// A 2D size with integer components.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct ovrSizei
	{
		public int Width;
		public int Height;
	}
}

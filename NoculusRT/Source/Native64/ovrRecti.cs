using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// A 2D rectangle with a position and size. All components are integers.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrRecti
	{
		public int PositionX;
		public int PositionY;
		public int SizeWidth;
		public int SizeHeight;
	}
}

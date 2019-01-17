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
	public struct ovrMatrix4f
	{
		public float M00;
		public float M01;
		public float M02;
		public float M03;
		public float M10;
		public float M11;
		public float M12;
		public float M13;
		public float M20;
		public float M21;
		public float M22;
		public float M23;
		public float M30;
		public float M31;
		public float M32;
		public float M33;
	}
}

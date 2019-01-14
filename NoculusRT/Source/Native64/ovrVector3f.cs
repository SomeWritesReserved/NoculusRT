﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// A 3D vector with float components.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack =4)]
	public struct ovrVector3f
	{
		public float X;
		public float Y;
		public float Z;
	}
}

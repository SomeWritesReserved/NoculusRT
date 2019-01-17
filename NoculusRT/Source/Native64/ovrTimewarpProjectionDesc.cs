using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Projection information for ovrLayerEyeFovDepth. Use the utility function ovrTimewarpProjectionDesc_FromProjection to
	/// generate this structure from the application's projection matrix.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrTimewarpProjectionDesc
	{
		/// <summary>
		/// Projection matrix element [2][2].
		/// </summary>
		public float Projection22;

		/// <summary>
		/// Projection matrix element [2][3].
		/// </summary>
		public float Projection23;

		/// <summary>
		/// Projection matrix element [3][2].
		/// </summary>
		public float Projection32;
	}
}

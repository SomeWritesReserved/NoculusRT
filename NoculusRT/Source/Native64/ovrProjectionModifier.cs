using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Enumerates modifications to the projection matrix based on the application's needs.
	/// </summary>
	public enum ovrProjectionModifier : uint
	{
		/// <summary>
		/// Use for generating a default projection matrix that is: Right-handed, near depth values stored in the depth buffer are smaller than far depth values,
		/// both near and far are explicitly defined, with a clipping range that is (0 to w).
		/// </summary>
		ovrProjection_None = 0x00,

		/// <summary>
		/// Enable if using left-handed transformations in your application.
		/// </summary>
		ovrProjection_LeftHanded = 0x01,

		/// <summary>
		/// After the projection transform is applied, far values stored in the depth buffer will be less than closer depth values.
		/// NOTE: Enable only if the application is using a floating-point depth buffer for proper precision.
		/// </summary>
		ovrProjection_FarLessThanNear = 0x02,

		/// <summary>
		/// When this flag is used, the zfar value pushed into ovrMatrix4f_Projection() will be ignored
		/// NOTE: Enable only if ovrProjection_FarLessThanNear is also enabled where the far clipping plane will be pushed to infinity.
		/// </summary>
		ovrProjection_FarClipAtInfinity = 0x04,

		/// <summary>
		/// Enable if the application is rendering with OpenGL and expects a projection matrix with a clipping range of (-w to w).
		/// Ignore this flag if your application already handles the conversion from D3D range (0 to w) to OpenGL.
		/// </summary>
		ovrProjection_ClipRangeOpenGL = 0x08,
	}
}

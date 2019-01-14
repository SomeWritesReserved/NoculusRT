using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Specifies which eye is being used for rendering. This type explicitly does not include a third "NoStereo" monoscopic option, as such is not required for an HMD-centered API.
	/// </summary>
	public enum ovrEyeType : int
	{
		Left = 0,
		Right = 1,
	}
}

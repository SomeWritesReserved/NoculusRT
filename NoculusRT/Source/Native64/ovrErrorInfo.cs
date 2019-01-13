using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	/// <summary>
	/// Provides information about the last error.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct ovrErrorInfo
	{
		/// <summary>
		/// The result from the last API call that generated an error ovrResult.
		/// </summary>
		public ovrResult Result;

		/// <summary>
		/// A UTF8-encoded null-terminated English string describing the problem.
		/// The format of this string is subject to change in future versions.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		public string ErrorString;
	}
}

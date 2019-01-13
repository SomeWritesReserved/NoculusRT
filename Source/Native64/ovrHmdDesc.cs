using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoculusRT.Native64
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct ovrHmdDesc
	{
		/// <summary>
		/// The type of HMD.
		/// </summary>
		public ovrHmdType Type;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] Pad0;

		/// <summary>
		/// UTF8-encoded product identification string (e.g. "Oculus Rift DK1").
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] // TODO: Unicode here vs the ansi we set for the pinvokes?
		public string ProductName;

		/// <summary>
		/// UTF8-encoded HMD manufacturer identification string.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string Manufacturer;

		/// <summary>
		/// HID (USB) vendor identifier of the device.
		/// </summary>
		public short VendorID;

		/// <summary>
		/// HID (USB) product identifier of the device.
		/// </summary>
		public short ProductID;

		/// <summary>
		/// HMD serial number.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
		public string SerialNumber;

		/// <summary>
		/// HMD firmware major version.
		/// </summary>
		public short FirmwareMajor;

		/// <summary>
		/// HMD firmware minor version.
		/// </summary>
		public short FirmwareMinor;

		/// <summary>
		/// Available ovrHmdCaps bits.
		/// </summary>
		public uint AvailableHmdCaps;

		/// <summary>
		/// Default ovrHmdCaps bits.
		/// </summary>
		public uint DefaultHmdCaps;

		/// <summary>
		/// Available ovrTrackingCaps bits.
		/// </summary>
		public uint AvailableTrackingCaps;

		/// <summary>
		/// Default ovrTrackingCaps bits.
		/// </summary>
		public uint DefaultTrackingCaps;

		/// <summary>
		/// Defines the recommended FOVs for the HMD.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public ovrFovPort[] DefaultEyeFov;
		
		/// <summary>
		/// Defines the maximum FOVs for the HMD.
		/// </summary>
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public ovrFovPort[] MaxEyeFov;

		/// <summary>
		/// Resolution of the full HMD screen (both eyes) in pixels.
		/// </summary>
		public ovrSizei Resolution;

		/// <summary>
		/// Refresh rate of the display in cycles per second.
		/// </summary>
		public float DisplayRefreshRate;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] Pad1;
	}

	public enum ovrHmdType : int
	{
		ovrHmd_None = 0,
		ovrHmd_DK1 = 3,
		ovrHmd_DKHD = 4,
		ovrHmd_DK2 = 6,
		ovrHmd_CB = 8,
		ovrHmd_Other = 9,
		ovrHmd_E3_2015 = 10,
		ovrHmd_ES06 = 11,
		ovrHmd_ES09 = 12,
		ovrHmd_ES11 = 13,
		ovrHmd_CV1 = 14,
	}
}

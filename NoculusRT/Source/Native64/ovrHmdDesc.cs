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

		/// <summary>
		/// Reserved padding.
		/// </summary>
		public int Pad0;

		/// <summary>
		/// UTF8-encoded product identification string (e.g. "Oculus Rift DK1").
		/// </summary>
		public NativeBlob64 ProductName;

		/// <summary>
		/// UTF8-encoded HMD manufacturer identification string.
		/// </summary>
		public NativeBlob64 Manufacturer;

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
		public NativeBlob24 SerialNumber;

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
		/// Defines the recommended FOVs for the HMD for eye 0.
		/// </summary>
		public ovrFovPort DefaultEyeFov0;

		/// <summary>
		/// Defines the recommended FOVs for the HMD for eye 1.
		/// </summary>
		public ovrFovPort DefaultEyeFov1;

		/// <summary>
		/// Defines the maximum FOVs for the HMD for eye 0.
		/// </summary>
		public ovrFovPort MaxEyeFov0;

		/// <summary>
		/// Defines the maximum FOVs for the HMD for eye 0.
		/// </summary>
		public ovrFovPort MaxEyeFov1;

		/// <summary>
		/// Resolution of the full HMD screen (both eyes) in pixels.
		/// </summary>
		public ovrSizei Resolution;

		/// <summary>
		/// Refresh rate of the display in cycles per second.
		/// </summary>
		public float DisplayRefreshRate;

		/// <summary>
		/// Reserved padding.
		/// </summary>
		public int Pad1;
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

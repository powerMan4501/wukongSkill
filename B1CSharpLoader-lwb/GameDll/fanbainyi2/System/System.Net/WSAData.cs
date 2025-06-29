using System.Runtime.InteropServices;

namespace System.Net;

internal struct WSAData
{
	internal short wVersion;

	internal short wHighVersion;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
	internal string szDescription;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
	internal string szSystemStatus;

	internal short iMaxSockets;

	internal short iMaxUdpDg;

	internal IntPtr lpVendorInfo;
}

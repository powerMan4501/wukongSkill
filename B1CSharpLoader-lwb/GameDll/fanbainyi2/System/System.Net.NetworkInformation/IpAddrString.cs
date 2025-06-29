using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct IpAddrString
{
	internal IntPtr Next;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
	internal string IpAddress;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
	internal string IpMask;

	internal uint Context;
}

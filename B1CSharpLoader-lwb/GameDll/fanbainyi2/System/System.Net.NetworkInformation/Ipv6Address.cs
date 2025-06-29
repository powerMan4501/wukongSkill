using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Ipv6Address
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
	internal byte[] Goo;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] Address;

	internal uint ScopeID;
}

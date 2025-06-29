using System.Runtime.InteropServices;

namespace System.Net;

internal struct IPv6MulticastRequest
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] MulticastAddress;

	internal int InterfaceIndex;

	internal static readonly int Size = Marshal.SizeOf(typeof(IPv6MulticastRequest));
}

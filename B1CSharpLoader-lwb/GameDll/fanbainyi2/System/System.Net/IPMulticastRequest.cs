using System.Runtime.InteropServices;

namespace System.Net;

internal struct IPMulticastRequest
{
	internal int MulticastAddress;

	internal int InterfaceAddress;

	internal static readonly int Size = Marshal.SizeOf(typeof(IPMulticastRequest));
}

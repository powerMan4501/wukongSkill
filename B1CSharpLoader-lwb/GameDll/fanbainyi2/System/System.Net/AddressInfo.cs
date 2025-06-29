using System.Net.Sockets;

namespace System.Net;

internal struct AddressInfo
{
	internal AddressInfoHints ai_flags;

	internal AddressFamily ai_family;

	internal SocketType ai_socktype;

	internal ProtocolFamily ai_protocol;

	internal int ai_addrlen;

	internal unsafe sbyte* ai_canonname;

	internal unsafe byte* ai_addr;

	internal unsafe AddressInfo* ai_next;
}

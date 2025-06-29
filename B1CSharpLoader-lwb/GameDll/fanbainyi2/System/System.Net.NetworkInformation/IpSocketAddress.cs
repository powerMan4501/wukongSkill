using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct IpSocketAddress
{
	internal IntPtr address;

	internal int addressLength;

	internal IPAddress MarshalIPAddress()
	{
		AddressFamily family = ((addressLength > 16) ? AddressFamily.InterNetworkV6 : AddressFamily.InterNetwork);
		SocketAddress socketAddress = new SocketAddress(family, addressLength);
		Marshal.Copy(address, socketAddress.m_Buffer, 0, addressLength);
		return socketAddress.GetIPAddress();
	}
}

namespace System.Net.NetworkInformation;

internal struct Icmp6EchoReply
{
	internal Ipv6Address Address;

	internal uint Status;

	internal uint RoundTripTime;

	internal IntPtr data;
}

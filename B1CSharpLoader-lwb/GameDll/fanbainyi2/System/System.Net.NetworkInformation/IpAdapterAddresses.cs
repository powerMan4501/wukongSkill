using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct IpAdapterAddresses
{
	internal const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

	internal uint length;

	internal uint index;

	internal IntPtr next;

	[MarshalAs(UnmanagedType.LPStr)]
	internal string AdapterName;

	internal IntPtr firstUnicastAddress;

	internal IntPtr firstAnycastAddress;

	internal IntPtr firstMulticastAddress;

	internal IntPtr firstDnsServerAddress;

	internal string dnsSuffix;

	internal string description;

	internal string friendlyName;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	internal byte[] address;

	internal uint addressLength;

	internal AdapterFlags flags;

	internal uint mtu;

	internal NetworkInterfaceType type;

	internal OperationalStatus operStatus;

	internal uint ipv6Index;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal uint[] zoneIndices;

	internal IntPtr firstPrefix;

	internal ulong transmitLinkSpeed;

	internal ulong receiveLinkSpeed;

	internal IntPtr firstWinsServerAddress;

	internal IntPtr firstGatewayAddress;

	internal uint ipv4Metric;

	internal uint ipv6Metric;

	internal ulong luid;

	internal IpSocketAddress dhcpv4Server;

	internal uint compartmentId;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] networkGuid;

	internal InterfaceConnectionType connectionType;

	internal InterfaceTunnelType tunnelType;

	internal IpSocketAddress dhcpv6Server;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 130)]
	internal byte[] dhcpv6ClientDuid;

	internal uint dhcpv6ClientDuidLength;

	internal uint dhcpV6Iaid;
}

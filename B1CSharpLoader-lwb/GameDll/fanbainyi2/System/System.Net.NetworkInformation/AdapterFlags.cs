namespace System.Net.NetworkInformation;

[Flags]
internal enum AdapterFlags
{
	DnsEnabled = 1,
	RegisterAdapterSuffix = 2,
	DhcpEnabled = 4,
	ReceiveOnly = 8,
	NoMulticast = 0x10,
	Ipv6OtherStatefulConfig = 0x20,
	NetBiosOverTcp = 0x40,
	IPv4Enabled = 0x80,
	IPv6Enabled = 0x100,
	IPv6ManagedAddressConfigurationSupported = 0x200
}

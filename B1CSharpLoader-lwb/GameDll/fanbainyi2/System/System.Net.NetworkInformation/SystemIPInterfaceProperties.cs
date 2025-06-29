using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class SystemIPInterfaceProperties : IPInterfaceProperties
{
	private bool dnsEnabled;

	private bool dynamicDnsEnabled;

	private IPAddressCollection dnsAddresses;

	private UnicastIPAddressInformationCollection unicastAddresses;

	private MulticastIPAddressInformationCollection multicastAddresses;

	private IPAddressInformationCollection anycastAddresses;

	private AdapterFlags adapterFlags;

	private string dnsSuffix;

	private SystemIPv4InterfaceProperties ipv4Properties;

	private SystemIPv6InterfaceProperties ipv6Properties;

	private IPAddressCollection winsServersAddresses;

	private GatewayIPAddressInformationCollection gatewayAddresses;

	private IPAddressCollection dhcpServers;

	public override bool IsDnsEnabled => dnsEnabled;

	public override bool IsDynamicDnsEnabled => dynamicDnsEnabled;

	public override string DnsSuffix => dnsSuffix;

	public override IPAddressInformationCollection AnycastAddresses => anycastAddresses;

	public override UnicastIPAddressInformationCollection UnicastAddresses => unicastAddresses;

	public override MulticastIPAddressInformationCollection MulticastAddresses => multicastAddresses;

	public override IPAddressCollection DnsAddresses => dnsAddresses;

	public override GatewayIPAddressInformationCollection GatewayAddresses => gatewayAddresses;

	public override IPAddressCollection DhcpServerAddresses => dhcpServers;

	public override IPAddressCollection WinsServersAddresses => winsServersAddresses;

	internal SystemIPInterfaceProperties(FixedInfo fixedInfo, IpAdapterAddresses ipAdapterAddresses)
	{
		adapterFlags = ipAdapterAddresses.flags;
		dnsSuffix = ipAdapterAddresses.dnsSuffix;
		dnsEnabled = fixedInfo.EnableDns;
		dynamicDnsEnabled = (ipAdapterAddresses.flags & AdapterFlags.DnsEnabled) > (AdapterFlags)0;
		multicastAddresses = SystemMulticastIPAddressInformation.ToMulticastIpAddressInformationCollection(IpAdapterAddress.MarshalIpAddressInformationCollection(ipAdapterAddresses.firstMulticastAddress));
		dnsAddresses = IpAdapterAddress.MarshalIpAddressCollection(ipAdapterAddresses.firstDnsServerAddress);
		anycastAddresses = IpAdapterAddress.MarshalIpAddressInformationCollection(ipAdapterAddresses.firstAnycastAddress);
		unicastAddresses = SystemUnicastIPAddressInformation.MarshalUnicastIpAddressInformationCollection(ipAdapterAddresses.firstUnicastAddress);
		winsServersAddresses = IpAdapterAddress.MarshalIpAddressCollection(ipAdapterAddresses.firstWinsServerAddress);
		gatewayAddresses = SystemGatewayIPAddressInformation.ToGatewayIpAddressInformationCollection(IpAdapterAddress.MarshalIpAddressCollection(ipAdapterAddresses.firstGatewayAddress));
		dhcpServers = new IPAddressCollection();
		if (ipAdapterAddresses.dhcpv4Server.address != IntPtr.Zero)
		{
			dhcpServers.InternalAdd(ipAdapterAddresses.dhcpv4Server.MarshalIPAddress());
		}
		if (ipAdapterAddresses.dhcpv6Server.address != IntPtr.Zero)
		{
			dhcpServers.InternalAdd(ipAdapterAddresses.dhcpv6Server.MarshalIPAddress());
		}
		if ((adapterFlags & AdapterFlags.IPv4Enabled) != 0)
		{
			ipv4Properties = new SystemIPv4InterfaceProperties(fixedInfo, ipAdapterAddresses);
		}
		if ((adapterFlags & AdapterFlags.IPv6Enabled) != 0)
		{
			ipv6Properties = new SystemIPv6InterfaceProperties(ipAdapterAddresses.ipv6Index, ipAdapterAddresses.mtu, ipAdapterAddresses.zoneIndices);
		}
	}

	public override IPv4InterfaceProperties GetIPv4Properties()
	{
		if ((adapterFlags & AdapterFlags.IPv4Enabled) == 0)
		{
			throw new NetworkInformationException(SocketError.ProtocolNotSupported);
		}
		return ipv4Properties;
	}

	public override IPv6InterfaceProperties GetIPv6Properties()
	{
		if ((adapterFlags & AdapterFlags.IPv6Enabled) == 0)
		{
			throw new NetworkInformationException(SocketError.ProtocolNotSupported);
		}
		return ipv6Properties;
	}
}

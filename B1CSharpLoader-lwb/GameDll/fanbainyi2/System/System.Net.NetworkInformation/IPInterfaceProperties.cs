namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPInterfaceProperties
{
	[global::__DynamicallyInvokable]
	public abstract bool IsDnsEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract string DnsSuffix
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool IsDynamicDnsEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract UnicastIPAddressInformationCollection UnicastAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract MulticastIPAddressInformationCollection MulticastAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPAddressInformationCollection AnycastAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPAddressCollection DnsAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract GatewayIPAddressInformationCollection GatewayAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPAddressCollection DhcpServerAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPAddressCollection WinsServersAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract IPv4InterfaceProperties GetIPv4Properties();

	[global::__DynamicallyInvokable]
	public abstract IPv6InterfaceProperties GetIPv6Properties();

	[global::__DynamicallyInvokable]
	protected IPInterfaceProperties()
	{
	}
}

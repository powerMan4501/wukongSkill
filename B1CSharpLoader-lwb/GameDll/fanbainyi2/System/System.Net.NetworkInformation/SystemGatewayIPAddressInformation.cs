namespace System.Net.NetworkInformation;

internal class SystemGatewayIPAddressInformation : GatewayIPAddressInformation
{
	private IPAddress address;

	public override IPAddress Address => address;

	private SystemGatewayIPAddressInformation(IPAddress address)
	{
		this.address = address;
	}

	internal static GatewayIPAddressInformationCollection ToGatewayIpAddressInformationCollection(IPAddressCollection addresses)
	{
		GatewayIPAddressInformationCollection gatewayIPAddressInformationCollection = new GatewayIPAddressInformationCollection();
		foreach (IPAddress address in addresses)
		{
			gatewayIPAddressInformationCollection.InternalAdd(new SystemGatewayIPAddressInformation(address));
		}
		return gatewayIPAddressInformationCollection;
	}
}

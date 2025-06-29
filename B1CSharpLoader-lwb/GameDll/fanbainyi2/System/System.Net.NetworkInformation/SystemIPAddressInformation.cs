namespace System.Net.NetworkInformation;

internal class SystemIPAddressInformation : IPAddressInformation
{
	private IPAddress address;

	internal bool transient;

	internal bool dnsEligible = true;

	public override IPAddress Address => address;

	public override bool IsTransient => transient;

	public override bool IsDnsEligible => dnsEligible;

	internal SystemIPAddressInformation(IPAddress address, AdapterAddressFlags flags)
	{
		this.address = address;
		transient = (flags & AdapterAddressFlags.Transient) > (AdapterAddressFlags)0;
		dnsEligible = (flags & AdapterAddressFlags.DnsEligible) > (AdapterAddressFlags)0;
	}
}

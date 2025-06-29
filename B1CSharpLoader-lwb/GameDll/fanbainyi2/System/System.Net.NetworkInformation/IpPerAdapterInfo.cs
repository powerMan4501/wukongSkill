namespace System.Net.NetworkInformation;

internal struct IpPerAdapterInfo
{
	internal bool autoconfigEnabled;

	internal bool autoconfigActive;

	internal IntPtr currentDnsServer;

	internal IpAddrString dnsServerList;
}

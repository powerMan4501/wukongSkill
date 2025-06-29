using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct FIXED_INFO
{
	internal const int MAX_HOSTNAME_LEN = 128;

	internal const int MAX_DOMAIN_NAME_LEN = 128;

	internal const int MAX_SCOPE_ID_LEN = 256;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
	internal string hostName;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
	internal string domainName;

	internal uint currentDnsServer;

	internal IpAddrString DnsServerList;

	internal NetBiosNodeType nodeType;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	internal string scopeId;

	internal bool enableRouting;

	internal bool enableProxy;

	internal bool enableDns;
}

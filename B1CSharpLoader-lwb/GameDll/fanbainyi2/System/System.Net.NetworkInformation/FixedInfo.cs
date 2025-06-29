namespace System.Net.NetworkInformation;

internal struct FixedInfo
{
	internal FIXED_INFO info;

	internal string HostName => info.hostName;

	internal string DomainName => info.domainName;

	internal NetBiosNodeType NodeType => info.nodeType;

	internal string ScopeId => info.scopeId;

	internal bool EnableRouting => info.enableRouting;

	internal bool EnableProxy => info.enableProxy;

	internal bool EnableDns => info.enableDns;

	internal FixedInfo(FIXED_INFO info)
	{
		this.info = info;
	}
}

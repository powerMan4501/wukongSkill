namespace System.Net.NetworkInformation;

[Flags]
internal enum GetAdaptersAddressesFlags
{
	SkipUnicast = 1,
	SkipAnycast = 2,
	SkipMulticast = 4,
	SkipDnsServer = 8,
	IncludePrefix = 0x10,
	SkipFriendlyName = 0x20,
	IncludeWins = 0x40,
	IncludeGateways = 0x80,
	IncludeAllInterfaces = 0x100,
	IncludeAllCompartments = 0x200,
	IncludeTunnelBindingOrder = 0x400
}

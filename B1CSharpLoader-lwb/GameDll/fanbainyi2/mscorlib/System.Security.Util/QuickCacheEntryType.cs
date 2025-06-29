namespace System.Security.Util;

[Serializable]
[Flags]
internal enum QuickCacheEntryType
{
	FullTrustZoneMyComputer = 0x1000000,
	FullTrustZoneIntranet = 0x2000000,
	FullTrustZoneInternet = 0x4000000,
	FullTrustZoneTrusted = 0x8000000,
	FullTrustZoneUntrusted = 0x10000000,
	FullTrustAll = 0x20000000
}

namespace System.Net;

[Flags]
internal enum NameInfoFlags
{
	NI_NOFQDN = 1,
	NI_NUMERICHOST = 2,
	NI_NAMEREQD = 4,
	NI_NUMERICSERV = 8,
	NI_DGRAM = 0x10
}

namespace System.Net;

[Flags]
internal enum SchProtocols
{
	Zero = 0,
	PctClient = 2,
	PctServer = 1,
	Pct = 3,
	Ssl2Client = 8,
	Ssl2Server = 4,
	Ssl2 = 0xC,
	Ssl3Client = 0x20,
	Ssl3Server = 0x10,
	Ssl3 = 0x30,
	Tls10Client = 0x80,
	Tls10Server = 0x40,
	Tls10 = 0xC0,
	Tls11Client = 0x200,
	Tls11Server = 0x100,
	Tls11 = 0x300,
	Tls12Client = 0x800,
	Tls12Server = 0x400,
	Tls12 = 0xC00,
	Tls13Client = 0x2000,
	Tls13Server = 0x1000,
	Tls13 = 0x3000,
	Ssl3Tls = 0xF0,
	UniClient = int.MinValue,
	UniServer = 0x40000000,
	Unified = -1073741824,
	ClientMask = -2147472726,
	ServerMask = 0x40001555
}

namespace System.Net;

[Flags]
internal enum Alg
{
	Any = 0,
	ClassSignture = 0x2000,
	ClassEncrypt = 0x6000,
	ClassHash = 0x8000,
	ClassKeyXch = 0xA000,
	TypeRSA = 0x400,
	TypeBlock = 0x600,
	TypeStream = 0x800,
	TypeDH = 0xA00,
	NameDES = 1,
	NameRC2 = 2,
	Name3DES = 3,
	NameAES_128 = 0xE,
	NameAES_192 = 0xF,
	NameAES_256 = 0x10,
	NameAES = 0x11,
	NameRC4 = 1,
	NameMD5 = 3,
	NameSHA = 4,
	NameSHA256 = 0xC,
	NameSHA384 = 0xD,
	NameSHA512 = 0xE,
	NameDH_Ephem = 2
}

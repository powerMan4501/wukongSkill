using System.Net.Security;

namespace System.Net;

internal struct SecureCredential2
{
	[Flags]
	public enum Flags
	{
		Zero = 0,
		NoSystemMapper = 2,
		NoNameCheck = 4,
		ValidateManual = 8,
		NoDefaultCred = 0x10,
		ValidateAuto = 0x20,
		SendAuxRecord = 0x200000,
		UseStrongCrypto = 0x400000,
		UsePresharedKeyOnly = 0x800000,
		AllowNullEencryption = 0x2000000
	}

	public const int CurrentVersion = 5;

	public int version;

	public int dwCredformat;

	public int cCreds;

	public unsafe void** certContextArray;

	private readonly IntPtr rootStore;

	public int cMappers;

	private readonly IntPtr phMappers;

	public int dwSessionLifespan;

	public Flags dwFlags;

	public int cTlsParameters;

	public unsafe TlsParamaters* pTlsParameters;

	public unsafe SecureCredential2(Flags flags, SchProtocols protocols, EncryptionPolicy policy)
	{
		rootStore = (phMappers = IntPtr.Zero);
		pTlsParameters = null;
		certContextArray = null;
		cCreds = (cMappers = (cTlsParameters = (dwCredformat = 0)));
		dwSessionLifespan = 0;
		version = 5;
		dwFlags = flags;
		if (policy == EncryptionPolicy.AllowNoEncryption)
		{
			dwFlags |= Flags.AllowNullEencryption;
		}
	}
}

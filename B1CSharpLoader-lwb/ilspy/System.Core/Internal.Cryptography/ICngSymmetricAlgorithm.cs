using System.Security;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Internal.Cryptography;

internal interface ICngSymmetricAlgorithm
{
	int BlockSize { get; }

	CipherMode Mode { get; }

	PaddingMode Padding { get; }

	byte[] IV { get; set; }

	KeySizes[] LegalKeySizes { get; }

	byte[] BaseKey { get; set; }

	int BaseKeySize { get; set; }

	bool IsWeakKey(byte[] key);

	string GetNCryptAlgorithmIdentifier();

	[SecurityCritical]
	SafeBCryptAlgorithmHandle GetEphemeralModeHandle();
}

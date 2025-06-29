namespace System.Security.Cryptography.X509Certificates;

internal static class Oids
{
	internal static readonly byte[] Pkcs7Data = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 7, 1 };

	internal static readonly byte[] Pkcs7Encrypted = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 7, 6 };

	internal static readonly byte[] Pkcs12ShroudedKeyBag = new byte[11]
	{
		42, 134, 72, 134, 247, 13, 1, 12, 10, 1,
		2
	};

	internal static readonly byte[] PasswordBasedEncryptionScheme2 = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 13 };

	internal static readonly byte[] Pbkdf2 = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 12 };

	internal static readonly byte[] PbeWithMD5AndDESCBC = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 3 };

	internal static readonly byte[] PbeWithMD5AndRC2CBC = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 6 };

	internal static readonly byte[] PbeWithSha1AndDESCBC = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 10 };

	internal static readonly byte[] PbeWithSha1AndRC2CBC = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 5, 11 };

	internal static readonly byte[] Pkcs12PbeWithShaAnd3Key3Des = new byte[10] { 42, 134, 72, 134, 247, 13, 1, 12, 1, 3 };

	internal static readonly byte[] Pkcs12PbeWithShaAnd2Key3Des = new byte[10] { 42, 134, 72, 134, 247, 13, 1, 12, 1, 4 };

	internal static readonly byte[] Pkcs12PbeWithShaAnd128BitRC2 = new byte[10] { 42, 134, 72, 134, 247, 13, 1, 12, 1, 5 };

	internal static readonly byte[] Pkcs12PbeWithShaAnd40BitRC2 = new byte[10] { 42, 134, 72, 134, 247, 13, 1, 12, 1, 6 };

	internal static readonly byte[] Aes128Cbc = new byte[9] { 96, 134, 72, 1, 101, 3, 4, 1, 2 };

	internal static readonly byte[] Aes192Cbc = new byte[9] { 96, 134, 72, 1, 101, 3, 4, 1, 22 };

	internal static readonly byte[] Aes256Cbc = new byte[9] { 96, 134, 72, 1, 101, 3, 4, 1, 42 };

	internal static readonly byte[] TripleDesCbc = new byte[8] { 42, 134, 72, 134, 247, 13, 3, 7 };

	internal static readonly byte[] Rc2Cbc = new byte[8] { 42, 134, 72, 134, 247, 13, 3, 2 };

	internal static readonly byte[] DesCbc = new byte[5] { 43, 14, 3, 2, 7 };

	internal static readonly byte[] HmacWithSha1 = new byte[8] { 42, 134, 72, 134, 247, 13, 2, 7 };

	internal static readonly byte[] HmacWithSha256 = new byte[8] { 42, 134, 72, 134, 247, 13, 2, 9 };

	internal static readonly byte[] HmacWithSha384 = new byte[8] { 42, 134, 72, 134, 247, 13, 2, 10 };

	internal static readonly byte[] HmacWithSha512 = new byte[8] { 42, 134, 72, 134, 247, 13, 2, 11 };
}

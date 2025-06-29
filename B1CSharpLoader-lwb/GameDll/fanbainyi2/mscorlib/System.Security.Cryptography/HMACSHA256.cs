using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class HMACSHA256 : HMAC
{
	public HMACSHA256()
		: this(Utils.GenerateRandom(64))
	{
	}

	public HMACSHA256(byte[] key)
	{
		m_hashName = "SHA256";
		HashSizeValue = 256;
		if (GetType() == typeof(HMACSHA256))
		{
			m_impl = new NativeHmac(CapiNative.AlgorithmID.Sha256);
		}
		else
		{
			m_hash1 = InstantiateHash();
			m_hash2 = InstantiateHash();
		}
		InitializeKey(key);
	}

	internal sealed override HashAlgorithm InstantiateHash()
	{
		return HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA256Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA256CryptoServiceProvider"));
	}
}

using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class HMACMD5 : HMAC
{
	public HMACMD5()
		: this(Utils.GenerateRandom(64))
	{
	}

	public HMACMD5(byte[] key)
	{
		m_hashName = "MD5";
		HashSizeValue = 128;
		if (GetType() == typeof(HMACMD5))
		{
			m_impl = new NativeHmac(CapiNative.AlgorithmID.Md5);
		}
		else
		{
			m_hash1 = new MD5CryptoServiceProvider();
			m_hash2 = new MD5CryptoServiceProvider();
		}
		InitializeKey(key);
	}

	internal sealed override HashAlgorithm InstantiateHash()
	{
		return new MD5CryptoServiceProvider();
	}
}

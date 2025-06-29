using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class HMACSHA512 : HMAC
{
	private bool m_useLegacyBlockSize = Utils._ProduceLegacyHmacValues();

	private int BlockSize
	{
		get
		{
			if (!m_useLegacyBlockSize)
			{
				return 128;
			}
			return 64;
		}
	}

	public bool ProduceLegacyHmacValues
	{
		get
		{
			return m_useLegacyBlockSize;
		}
		set
		{
			m_useLegacyBlockSize = value;
			if (m_impl != null && value)
			{
				if (m_hashing)
				{
					throw new CryptographicException(Environment.GetResourceString("Cryptography_HashNameSet"));
				}
				m_impl.Dispose();
				m_impl = null;
				m_hash1 = InstantiateHash();
				m_hash2 = InstantiateHash();
			}
			base.BlockSizeValue = BlockSize;
			if (m_impl == null)
			{
				InitializeKey(KeyValue);
			}
		}
	}

	public HMACSHA512()
		: this(Utils.GenerateRandom(128))
	{
	}

	[SecuritySafeCritical]
	public HMACSHA512(byte[] key)
	{
		m_hashName = "SHA512";
		HashSizeValue = 512;
		base.BlockSizeValue = BlockSize;
		if (GetType() == typeof(HMACSHA512) && !m_useLegacyBlockSize)
		{
			m_impl = new NativeHmac(CapiNative.AlgorithmID.Sha512);
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
		return HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA512Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA512CryptoServiceProvider"));
	}
}

using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public class HMACSHA384 : HMAC
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

	public HMACSHA384()
		: this(Utils.GenerateRandom(128))
	{
	}

	[SecuritySafeCritical]
	public HMACSHA384(byte[] key)
	{
		m_hashName = "SHA384";
		HashSizeValue = 384;
		base.BlockSizeValue = BlockSize;
		if (GetType() == typeof(HMACSHA384) && !m_useLegacyBlockSize)
		{
			m_impl = new NativeHmac(CapiNative.AlgorithmID.Sha384);
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
		return HMAC.GetHashAlgorithmWithFipsFallback(() => new SHA384Managed(), () => HashAlgorithm.Create("System.Security.Cryptography.SHA384CryptoServiceProvider"));
	}
}

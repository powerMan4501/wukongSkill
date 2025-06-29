namespace System.Security.Cryptography;

public sealed class AesManaged : Aes
{
	private SymmetricAlgorithm m_impl;

	public override int FeedbackSize
	{
		get
		{
			return m_impl.FeedbackSize;
		}
		set
		{
			m_impl.FeedbackSize = value;
		}
	}

	public override byte[] IV
	{
		get
		{
			return m_impl.IV;
		}
		set
		{
			m_impl.IV = value;
		}
	}

	public override byte[] Key
	{
		get
		{
			return m_impl.Key;
		}
		set
		{
			m_impl.Key = value;
		}
	}

	public override int KeySize
	{
		get
		{
			return m_impl.KeySize;
		}
		set
		{
			m_impl.KeySize = value;
		}
	}

	public override CipherMode Mode
	{
		get
		{
			return m_impl.Mode;
		}
		set
		{
			if (value == CipherMode.CFB || value == CipherMode.OFB)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidCipherMode"));
			}
			m_impl.Mode = value;
		}
	}

	public override PaddingMode Padding
	{
		get
		{
			return m_impl.Padding;
		}
		set
		{
			m_impl.Padding = value;
		}
	}

	public AesManaged()
	{
		if (CryptoConfig.AllowOnlyFipsAlgorithms && System.LocalAppContextSwitches.UseLegacyFipsThrow)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_NonCompliantFIPSAlgorithm"));
		}
		m_impl = new AesCng();
		m_impl.BlockSize = BlockSize;
		m_impl.KeySize = KeySize;
		m_impl.FeedbackSize = 128;
	}

	public override ICryptoTransform CreateDecryptor()
	{
		return m_impl.CreateDecryptor();
	}

	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		return m_impl.CreateDecryptor(key, iv);
	}

	public override ICryptoTransform CreateEncryptor()
	{
		return m_impl.CreateEncryptor();
	}

	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!ValidKeySize(key.Length * 8))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize"), "key");
		}
		if (iv != null && iv.Length * 8 != BlockSizeValue)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidIVSize"), "iv");
		}
		return m_impl.CreateEncryptor(key, iv);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				((IDisposable)m_impl).Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void GenerateIV()
	{
		m_impl.GenerateIV();
	}

	public override void GenerateKey()
	{
		m_impl.GenerateKey();
	}
}

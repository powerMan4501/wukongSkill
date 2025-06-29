using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class RC2CryptoServiceProvider : RC2
{
	private bool m_use40bitSalt;

	private static KeySizes[] s_legalKeySizes = new KeySizes[1]
	{
		new KeySizes(40, 128, 8)
	};

	public override int EffectiveKeySize
	{
		get
		{
			return KeySizeValue;
		}
		set
		{
			if (value != KeySizeValue)
			{
				throw new CryptographicUnexpectedOperationException(Environment.GetResourceString("Cryptography_RC2_EKSKS2"));
			}
		}
	}

	[ComVisible(false)]
	public bool UseSalt
	{
		get
		{
			return m_use40bitSalt;
		}
		set
		{
			m_use40bitSalt = value;
		}
	}

	[SecuritySafeCritical]
	public RC2CryptoServiceProvider()
	{
		if (CryptoConfig.AllowOnlyFipsAlgorithms && AppContextSwitches.UseLegacyFipsThrow)
		{
			throw new InvalidOperationException(Environment.GetResourceString("Cryptography_NonCompliantFIPSAlgorithm"));
		}
		if (!Utils.HasAlgorithm(26114, 0))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_AlgorithmNotAvailable"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		FeedbackSizeValue = 8;
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return _NewEncryptor(rgbKey, ModeValue, rgbIV, EffectiveKeySizeValue, FeedbackSizeValue, CryptoAPITransformMode.Encrypt);
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return _NewEncryptor(rgbKey, ModeValue, rgbIV, EffectiveKeySizeValue, FeedbackSizeValue, CryptoAPITransformMode.Decrypt);
	}

	public override void GenerateKey()
	{
		KeyValue = new byte[KeySizeValue / 8];
		Utils.StaticRandomNumberGenerator.GetBytes(KeyValue);
	}

	public override void GenerateIV()
	{
		IVValue = new byte[8];
		Utils.StaticRandomNumberGenerator.GetBytes(IVValue);
	}

	[SecurityCritical]
	private ICryptoTransform _NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int effectiveKeySize, int feedbackSize, CryptoAPITransformMode encryptMode)
	{
		int num = 0;
		int[] array = new int[10];
		object[] array2 = new object[10];
		switch (mode)
		{
		case CipherMode.OFB:
			throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_OFBNotSupported"));
		case CipherMode.CFB:
			if (feedbackSize != 8)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_CFBSizeNotSupported"));
			}
			break;
		}
		if (rgbKey == null)
		{
			rgbKey = new byte[KeySizeValue / 8];
			Utils.StaticRandomNumberGenerator.GetBytes(rgbKey);
		}
		int num2 = rgbKey.Length * 8;
		if (!ValidKeySize(num2))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKeySize"));
		}
		array[num] = 19;
		if (EffectiveKeySizeValue == 0)
		{
			array2[num] = num2;
		}
		else
		{
			array2[num] = effectiveKeySize;
		}
		num++;
		if (mode != CipherMode.CBC)
		{
			array[num] = 4;
			array2[num] = mode;
			num++;
		}
		if (mode != CipherMode.ECB)
		{
			if (rgbIV == null)
			{
				rgbIV = new byte[8];
				Utils.StaticRandomNumberGenerator.GetBytes(rgbIV);
			}
			if (rgbIV.Length < 8)
			{
				throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidIVSize"));
			}
			array[num] = 1;
			array2[num] = rgbIV;
			num++;
		}
		if (mode == CipherMode.OFB || mode == CipherMode.CFB)
		{
			array[num] = 5;
			array2[num] = feedbackSize;
			num++;
		}
		if (!Utils.HasAlgorithm(26114, num2))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_AlgKeySizeNotAvailable", num2));
		}
		return new CryptoAPITransform(26114, num, array, array2, rgbKey, PaddingValue, mode, BlockSizeValue, feedbackSize, m_use40bitSalt, encryptMode);
	}
}

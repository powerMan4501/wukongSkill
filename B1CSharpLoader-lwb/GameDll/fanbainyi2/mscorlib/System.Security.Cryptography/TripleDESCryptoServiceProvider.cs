using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class TripleDESCryptoServiceProvider : TripleDES
{
	[SecuritySafeCritical]
	public TripleDESCryptoServiceProvider()
	{
		if (!Utils.HasAlgorithm(26115, 0))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_AlgorithmNotAvailable"));
		}
		FeedbackSizeValue = 8;
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (TripleDES.IsWeakKey(rgbKey))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKey_Weak"), "TripleDES");
		}
		return _NewEncryptor(rgbKey, ModeValue, rgbIV, FeedbackSizeValue, CryptoAPITransformMode.Encrypt);
	}

	[SecuritySafeCritical]
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		if (TripleDES.IsWeakKey(rgbKey))
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKey_Weak"), "TripleDES");
		}
		return _NewEncryptor(rgbKey, ModeValue, rgbIV, FeedbackSizeValue, CryptoAPITransformMode.Decrypt);
	}

	public override void GenerateKey()
	{
		KeyValue = new byte[KeySizeValue / 8];
		Utils.StaticRandomNumberGenerator.GetBytes(KeyValue);
		while (TripleDES.IsWeakKey(KeyValue))
		{
			Utils.StaticRandomNumberGenerator.GetBytes(KeyValue);
		}
	}

	public override void GenerateIV()
	{
		IVValue = new byte[8];
		Utils.StaticRandomNumberGenerator.GetBytes(IVValue);
	}

	[SecurityCritical]
	private ICryptoTransform _NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, CryptoAPITransformMode encryptMode)
	{
		int num = 0;
		int[] array = new int[10];
		object[] array2 = new object[10];
		int algid = 26115;
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
		if (rgbKey.Length == 16)
		{
			algid = 26121;
		}
		return new CryptoAPITransform(algid, num, array, array2, rgbKey, PaddingValue, mode, BlockSizeValue, feedbackSize, useSalt: false, encryptMode);
	}
}

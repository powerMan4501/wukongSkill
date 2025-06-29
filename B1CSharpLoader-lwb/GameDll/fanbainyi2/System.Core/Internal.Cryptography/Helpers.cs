using System.Security.Cryptography;

namespace Internal.Cryptography;

internal static class Helpers
{
	public static byte[] CloneByteArray(this byte[] src)
	{
		if (src != null)
		{
			return (byte[])src.Clone();
		}
		return null;
	}

	public static bool UsesIv(this CipherMode cipherMode)
	{
		return cipherMode != CipherMode.ECB;
	}

	public static byte[] GetCipherIv(this CipherMode cipherMode, byte[] iv)
	{
		if (cipherMode.UsesIv())
		{
			if (iv == null)
			{
				throw new CryptographicException("Cryptography_MissingIV");
			}
			return iv;
		}
		return null;
	}

	public static CryptographicException ToCryptographicException(this global::Interop.NCrypt.ErrorCode errorCode)
	{
		return ((int)errorCode).ToCryptographicException();
	}

	public static bool IsLegalSize(this int size, KeySizes[] legalSizes)
	{
		for (int i = 0; i < legalSizes.Length; i++)
		{
			if (legalSizes[i].SkipSize == 0)
			{
				if (legalSizes[i].MinSize == size)
				{
					return true;
				}
				continue;
			}
			for (int j = legalSizes[i].MinSize; j <= legalSizes[i].MaxSize; j += legalSizes[i].SkipSize)
			{
				if (j == size)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static int BitSizeToByteSize(this int bits)
	{
		return (bits + 7) / 8;
	}

	public static byte[] GenerateRandom(int count)
	{
		byte[] array = new byte[count];
		using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		randomNumberGenerator.GetBytes(array);
		return array;
	}
}

using System;
using System.Security.Cryptography;

namespace Internal.Cryptography;

internal sealed class UniversalCryptoEncryptor : UniversalCryptoTransform
{
	private static volatile RNGCryptoServiceProvider s_rng;

	public UniversalCryptoEncryptor(PaddingMode paddingMode, BasicSymmetricCipher basicSymmetricCipher)
		: base(paddingMode, basicSymmetricCipher)
	{
	}

	protected sealed override int UncheckedTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		return base.BasicSymmetricCipher.Transform(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
	}

	protected sealed override byte[] UncheckedTransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		byte[] array = PadBlock(inputBuffer, inputOffset, inputCount);
		return base.BasicSymmetricCipher.TransformFinal(array, 0, array.Length);
	}

	private byte[] PadBlock(byte[] block, int offset, int count)
	{
		int num = base.InputBlockSize - count % base.InputBlockSize;
		byte[] array;
		switch (base.PaddingMode)
		{
		case PaddingMode.None:
			if (count % base.InputBlockSize != 0)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_PartialBlock"));
			}
			array = new byte[count];
			Buffer.BlockCopy(block, offset, array, 0, array.Length);
			break;
		case PaddingMode.PKCS7:
		{
			array = new byte[count + num];
			Buffer.BlockCopy(block, offset, array, 0, count);
			for (int i = count; i < array.Length; i++)
			{
				array[i] = (byte)num;
			}
			break;
		}
		case PaddingMode.ANSIX923:
		{
			array = new byte[count + num];
			Buffer.BlockCopy(block, offset, array, 0, count);
			for (int j = count; j < array.Length - 1; j++)
			{
				array[j] = 0;
			}
			array[array.Length - 1] = (byte)num;
			break;
		}
		case PaddingMode.ISO10126:
			array = new byte[count + num];
			Buffer.BlockCopy(block, offset, array, 0, count);
			if (num > 1)
			{
				if (s_rng == null)
				{
					s_rng = new RNGCryptoServiceProvider();
				}
				s_rng.GetBytes(array, count, num - 1);
			}
			array[array.Length - 1] = (byte)num;
			break;
		case PaddingMode.Zeros:
			if (num == base.InputBlockSize)
			{
				num = 0;
			}
			array = new byte[count + num];
			Buffer.BlockCopy(block, offset, array, 0, count);
			break;
		default:
			throw new CryptographicException(System.SR.GetString("Cryptography_UnknownPaddingMode"));
		}
		return array;
	}
}

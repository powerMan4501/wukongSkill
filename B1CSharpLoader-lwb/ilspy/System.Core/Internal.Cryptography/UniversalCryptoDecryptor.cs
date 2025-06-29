using System;
using System.Security.Cryptography;

namespace Internal.Cryptography;

internal sealed class UniversalCryptoDecryptor : UniversalCryptoTransform
{
	private byte[] _heldoverCipher;

	private bool DepaddingRequired
	{
		get
		{
			if (base.PaddingMode != PaddingMode.None)
			{
				return base.PaddingMode != PaddingMode.Zeros;
			}
			return false;
		}
	}

	public UniversalCryptoDecryptor(PaddingMode paddingMode, BasicSymmetricCipher basicSymmetricCipher)
		: base(paddingMode, basicSymmetricCipher)
	{
	}

	protected sealed override int UncheckedTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		int num = 0;
		if (DepaddingRequired)
		{
			if (_heldoverCipher != null)
			{
				int num2 = base.BasicSymmetricCipher.Transform(_heldoverCipher, 0, _heldoverCipher.Length, outputBuffer, outputOffset);
				outputOffset += num2;
				num += num2;
			}
			else
			{
				_heldoverCipher = new byte[base.InputBlockSize];
			}
			int srcOffset = inputOffset + inputCount - _heldoverCipher.Length;
			Buffer.BlockCopy(inputBuffer, srcOffset, _heldoverCipher, 0, _heldoverCipher.Length);
			inputCount -= _heldoverCipher.Length;
		}
		if (inputCount > 0)
		{
			num += base.BasicSymmetricCipher.Transform(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
		}
		return num;
	}

	protected sealed override byte[] UncheckedTransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		if (inputCount % base.InputBlockSize != 0)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_PartialBlock"));
		}
		byte[] array = null;
		if (_heldoverCipher == null)
		{
			array = new byte[inputCount];
			Buffer.BlockCopy(inputBuffer, inputOffset, array, 0, inputCount);
		}
		else
		{
			array = new byte[_heldoverCipher.Length + inputCount];
			Buffer.BlockCopy(_heldoverCipher, 0, array, 0, _heldoverCipher.Length);
			Buffer.BlockCopy(inputBuffer, inputOffset, array, _heldoverCipher.Length, inputCount);
		}
		byte[] array2 = base.BasicSymmetricCipher.TransformFinal(array, 0, array.Length);
		byte[] result = ((array.Length == 0) ? new byte[0] : DepadBlock(array2, 0, array2.Length));
		Reset();
		return result;
	}

	protected sealed override void Dispose(bool disposing)
	{
		if (disposing)
		{
			byte[] heldoverCipher = _heldoverCipher;
			_heldoverCipher = null;
			if (heldoverCipher != null)
			{
				Array.Clear(heldoverCipher, 0, heldoverCipher.Length);
			}
		}
		base.Dispose(disposing);
	}

	private void Reset()
	{
		if (_heldoverCipher != null)
		{
			Array.Clear(_heldoverCipher, 0, _heldoverCipher.Length);
			_heldoverCipher = null;
		}
	}

	private byte[] DepadBlock(byte[] block, int offset, int count)
	{
		int num = 0;
		switch (base.PaddingMode)
		{
		case PaddingMode.PKCS7:
		{
			num = block[offset + count - 1];
			if (num <= 0 || num > base.InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			for (int j = offset + count - num; j < offset + count; j++)
			{
				if (block[j] != num)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
				}
			}
			break;
		}
		case PaddingMode.ISO10126:
			num = block[offset + count - 1];
			if (num <= 0 || num > base.InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			break;
		case PaddingMode.ANSIX923:
		{
			num = block[offset + count - 1];
			if (num <= 0 || num > base.InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			int num2 = offset + count - 1;
			for (int i = offset + count - num; i < num2; i++)
			{
				if (block[i] != 0)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
				}
			}
			break;
		}
		case PaddingMode.None:
		case PaddingMode.Zeros:
			num = 0;
			break;
		default:
			throw new CryptographicException(System.SR.GetString("Cryptography_UnknownPaddingMode"));
		}
		byte[] array = new byte[count - num];
		Buffer.BlockCopy(block, offset, array, 0, array.Length);
		return array;
	}
}

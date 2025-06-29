using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class CapiSymmetricAlgorithm : ICryptoTransform, IDisposable
{
	private int m_blockSize;

	private byte[] m_depadBuffer;

	private EncryptionMode m_encryptionMode;

	[SecurityCritical]
	private SafeCapiKeyHandle m_key;

	private PaddingMode m_paddingMode;

	[SecurityCritical]
	private Microsoft.Win32.SafeHandles.SafeCspHandle m_provider;

	public bool CanReuseTransform => true;

	public bool CanTransformMultipleBlocks => true;

	public int InputBlockSize => m_blockSize / 8;

	public int OutputBlockSize => m_blockSize / 8;

	[SecurityCritical]
	public CapiSymmetricAlgorithm(int blockSize, int feedbackSize, Microsoft.Win32.SafeHandles.SafeCspHandle provider, SafeCapiKeyHandle key, byte[] iv, CipherMode cipherMode, PaddingMode paddingMode, EncryptionMode encryptionMode)
	{
		m_blockSize = blockSize;
		m_encryptionMode = encryptionMode;
		m_paddingMode = paddingMode;
		m_provider = provider.Duplicate();
		m_key = SetupKey(key, ProcessIV(iv, blockSize, cipherMode), cipherMode, feedbackSize);
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		if (m_key != null)
		{
			m_key.Dispose();
		}
		if (m_provider != null)
		{
			m_provider.Dispose();
		}
		if (m_depadBuffer != null)
		{
			Array.Clear(m_depadBuffer, 0, m_depadBuffer.Length);
		}
	}

	[SecuritySafeCritical]
	private int DecryptBlocks(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		int num = 0;
		if (m_paddingMode != PaddingMode.None && m_paddingMode != PaddingMode.Zeros)
		{
			if (m_depadBuffer != null)
			{
				int num2 = RawDecryptBlocks(m_depadBuffer, 0, m_depadBuffer.Length);
				Buffer.BlockCopy(m_depadBuffer, 0, outputBuffer, outputOffset, num2);
				Array.Clear(m_depadBuffer, 0, m_depadBuffer.Length);
				outputOffset += num2;
				num += num2;
			}
			else
			{
				m_depadBuffer = new byte[InputBlockSize];
			}
			Buffer.BlockCopy(inputBuffer, inputOffset + inputCount - m_depadBuffer.Length, m_depadBuffer, 0, m_depadBuffer.Length);
			inputCount -= m_depadBuffer.Length;
		}
		if (inputCount > 0)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			num += RawDecryptBlocks(outputBuffer, outputOffset, inputCount);
		}
		return num;
	}

	private byte[] DepadBlock(byte[] block, int offset, int count)
	{
		int num = 0;
		switch (m_paddingMode)
		{
		case PaddingMode.ANSIX923:
		{
			num = block[offset + count - 1];
			if (num <= 0 || num > InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			for (int j = offset + count - num; j < offset + count - 1; j++)
			{
				if (block[j] != 0)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
				}
			}
			break;
		}
		case PaddingMode.ISO10126:
			num = block[offset + count - 1];
			if (num <= 0 || num > InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			break;
		case PaddingMode.PKCS7:
		{
			num = block[offset + count - 1];
			if (num <= 0 || num > InputBlockSize)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPadding"));
			}
			for (int i = offset + count - num; i < offset + count; i++)
			{
				if (block[i] != num)
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

	[SecurityCritical]
	private unsafe int EncryptBlocks(byte[] buffer, int offset, int count)
	{
		int pdwDataLen = count;
		fixed (byte* value = &buffer[offset])
		{
			if (!CapiNative.UnsafeNativeMethods.CryptEncrypt(m_key, SafeCapiHashHandle.InvalidHandle, Final: false, 0, new IntPtr(value), ref pdwDataLen, buffer.Length - offset))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return pdwDataLen;
	}

	[SecuritySafeCritical]
	private byte[] PadBlock(byte[] block, int offset, int count)
	{
		byte[] array = null;
		int num = InputBlockSize - count % InputBlockSize;
		switch (m_paddingMode)
		{
		case PaddingMode.ANSIX923:
			array = new byte[count + num];
			Buffer.BlockCopy(block, 0, array, 0, count);
			array[array.Length - 1] = (byte)num;
			break;
		case PaddingMode.ISO10126:
			array = new byte[count + num];
			CapiNative.UnsafeNativeMethods.CryptGenRandom(m_provider, array.Length - 1, array);
			Buffer.BlockCopy(block, 0, array, 0, count);
			array[array.Length - 1] = (byte)num;
			break;
		case PaddingMode.None:
			if (count % InputBlockSize != 0)
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
		case PaddingMode.Zeros:
			if (num == InputBlockSize)
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

	private static byte[] ProcessIV(byte[] iv, int blockSize, CipherMode cipherMode)
	{
		byte[] array = null;
		if (iv != null)
		{
			if (blockSize / 8 > iv.Length)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_InvalidIVSize"));
			}
			array = new byte[blockSize / 8];
			Buffer.BlockCopy(iv, 0, array, 0, array.Length);
		}
		else if (cipherMode != CipherMode.ECB)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_MissingIV"));
		}
		return array;
	}

	[SecurityCritical]
	private unsafe int RawDecryptBlocks(byte[] buffer, int offset, int count)
	{
		int pdwDataLen = count;
		fixed (byte* value = &buffer[offset])
		{
			if (!CapiNative.UnsafeNativeMethods.CryptDecrypt(m_key, SafeCapiHashHandle.InvalidHandle, Final: false, 0, new IntPtr(value), ref pdwDataLen))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return pdwDataLen;
	}

	[SecuritySafeCritical]
	private unsafe void Reset()
	{
		byte[] array = new byte[OutputBlockSize];
		int pdwDataLen = 0;
		fixed (byte* value = array)
		{
			if (m_encryptionMode == EncryptionMode.Encrypt)
			{
				CapiNative.UnsafeNativeMethods.CryptEncrypt(m_key, SafeCapiHashHandle.InvalidHandle, Final: true, 0, new IntPtr(value), ref pdwDataLen, array.Length);
			}
			else
			{
				if (!System.LocalAppContextSwitches.AesCryptoServiceProviderDontCorrectlyResetDecryptor)
				{
					pdwDataLen = array.Length;
				}
				CapiNative.UnsafeNativeMethods.CryptDecrypt(m_key, SafeCapiHashHandle.InvalidHandle, Final: true, 0, new IntPtr(value), ref pdwDataLen);
			}
		}
		if (m_depadBuffer != null)
		{
			Array.Clear(m_depadBuffer, 0, m_depadBuffer.Length);
			m_depadBuffer = null;
		}
	}

	[SecuritySafeCritical]
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputBuffer == null)
		{
			throw new ArgumentNullException("inputBuffer");
		}
		if (inputOffset < 0)
		{
			throw new ArgumentOutOfRangeException("inputOffset");
		}
		if (inputCount <= 0)
		{
			throw new ArgumentOutOfRangeException("inputCount");
		}
		if (inputCount % InputBlockSize != 0)
		{
			throw new ArgumentOutOfRangeException("inputCount", System.SR.GetString("Cryptography_MustTransformWholeBlock"));
		}
		if (inputCount > inputBuffer.Length - inputOffset)
		{
			throw new ArgumentOutOfRangeException("inputCount", System.SR.GetString("Cryptography_TransformBeyondEndOfBuffer"));
		}
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (inputCount > outputBuffer.Length - outputOffset)
		{
			throw new ArgumentOutOfRangeException("outputOffset", System.SR.GetString("Cryptography_TransformBeyondEndOfBuffer"));
		}
		if (m_encryptionMode == EncryptionMode.Encrypt)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			return EncryptBlocks(outputBuffer, outputOffset, inputCount);
		}
		return DecryptBlocks(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
	}

	[SecuritySafeCritical]
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
	{
		if (inputBuffer == null)
		{
			throw new ArgumentNullException("inputBuffer");
		}
		if (inputOffset < 0)
		{
			throw new ArgumentOutOfRangeException("inputOffset");
		}
		if (inputCount < 0)
		{
			throw new ArgumentOutOfRangeException("inputCount");
		}
		if (inputCount > inputBuffer.Length - inputOffset)
		{
			throw new ArgumentOutOfRangeException("inputCount", System.SR.GetString("Cryptography_TransformBeyondEndOfBuffer"));
		}
		byte[] array = null;
		if (m_encryptionMode == EncryptionMode.Encrypt)
		{
			array = PadBlock(inputBuffer, inputOffset, inputCount);
			if (array.Length != 0)
			{
				EncryptBlocks(array, 0, array.Length);
			}
		}
		else
		{
			if (inputCount % InputBlockSize != 0)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_PartialBlock"));
			}
			byte[] array2 = null;
			if (m_depadBuffer == null)
			{
				array2 = new byte[inputCount];
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, 0, inputCount);
			}
			else
			{
				array2 = new byte[m_depadBuffer.Length + inputCount];
				Buffer.BlockCopy(m_depadBuffer, 0, array2, 0, m_depadBuffer.Length);
				Buffer.BlockCopy(inputBuffer, inputOffset, array2, m_depadBuffer.Length, inputCount);
			}
			if (array2.Length != 0)
			{
				int count = RawDecryptBlocks(array2, 0, array2.Length);
				array = DepadBlock(array2, 0, count);
			}
			else
			{
				array = new byte[0];
			}
		}
		Reset();
		return array;
	}

	[SecurityCritical]
	private static SafeCapiKeyHandle SetupKey(SafeCapiKeyHandle key, byte[] iv, CipherMode cipherMode, int feedbackSize)
	{
		SafeCapiKeyHandle safeCapiKeyHandle = key.Duplicate();
		CapiNative.SetKeyParameter(safeCapiKeyHandle, CapiNative.KeyParameter.Mode, (int)cipherMode);
		if (cipherMode != CipherMode.ECB)
		{
			CapiNative.SetKeyParameter(safeCapiKeyHandle, CapiNative.KeyParameter.IV, iv);
		}
		if (cipherMode == CipherMode.CFB || cipherMode == CipherMode.OFB)
		{
			CapiNative.SetKeyParameter(safeCapiKeyHandle, CapiNative.KeyParameter.ModeBits, feedbackSize);
		}
		return safeCapiKeyHandle;
	}
}

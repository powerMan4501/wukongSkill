using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class CryptoAPITransform : ICryptoTransform, IDisposable
{
	private int BlockSizeValue;

	private byte[] IVValue;

	private CipherMode ModeValue;

	private PaddingMode PaddingValue;

	private CryptoAPITransformMode encryptOrDecrypt;

	private byte[] _rgbKey;

	private byte[] _depadBuffer;

	[SecurityCritical]
	private SafeKeyHandle _safeKeyHandle;

	[SecurityCritical]
	private SafeProvHandle _safeProvHandle;

	public IntPtr KeyHandle
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return _safeKeyHandle.DangerousGetHandle();
		}
	}

	public int InputBlockSize => BlockSizeValue / 8;

	public int OutputBlockSize => BlockSizeValue / 8;

	public bool CanTransformMultipleBlocks => true;

	public bool CanReuseTransform => true;

	private CryptoAPITransform()
	{
	}

	[SecurityCritical]
	internal CryptoAPITransform(int algid, int cArgs, int[] rgArgIds, object[] rgArgValues, byte[] rgbKey, PaddingMode padding, CipherMode cipherChainingMode, int blockSize, int feedbackSize, bool useSalt, CryptoAPITransformMode encDecMode)
	{
		BlockSizeValue = blockSize;
		ModeValue = cipherChainingMode;
		PaddingValue = padding;
		encryptOrDecrypt = encDecMode;
		int[] array = new int[rgArgIds.Length];
		Array.Copy(rgArgIds, array, rgArgIds.Length);
		_rgbKey = new byte[rgbKey.Length];
		Array.Copy(rgbKey, _rgbKey, rgbKey.Length);
		object[] array2 = new object[rgArgValues.Length];
		for (int i = 0; i < rgArgValues.Length; i++)
		{
			if (rgArgValues[i] is byte[])
			{
				byte[] array3 = (byte[])rgArgValues[i];
				byte[] array4 = new byte[array3.Length];
				Array.Copy(array3, array4, array3.Length);
				array2[i] = array4;
			}
			else if (rgArgValues[i] is int)
			{
				array2[i] = (int)rgArgValues[i];
			}
			else if (rgArgValues[i] is CipherMode)
			{
				array2[i] = (int)rgArgValues[i];
			}
		}
		_safeProvHandle = Utils.AcquireProvHandle(new CspParameters(24));
		SafeKeyHandle hKey = SafeKeyHandle.InvalidHandle;
		Utils._ImportBulkKey(_safeProvHandle, algid, useSalt, _rgbKey, ref hKey);
		_safeKeyHandle = hKey;
		for (int j = 0; j < cArgs; j++)
		{
			int dwValue;
			switch (rgArgIds[j])
			{
			case 1:
			{
				IVValue = (byte[])array2[j];
				byte[] iVValue = IVValue;
				Utils.SetKeyParamRgb(_safeKeyHandle, array[j], iVValue, iVValue.Length);
				break;
			}
			case 4:
				ModeValue = (CipherMode)array2[j];
				dwValue = (int)array2[j];
				goto IL_01ab;
			case 5:
				dwValue = (int)array2[j];
				goto IL_01ab;
			case 19:
				dwValue = (int)array2[j];
				goto IL_01ab;
			default:
				{
					throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidKeyParameter"), "_rgArgIds[i]");
				}
				IL_01ab:
				Utils.SetKeyParamDw(_safeKeyHandle, array[j], dwValue);
				break;
			}
		}
	}

	public void Dispose()
	{
		Clear();
	}

	[SecuritySafeCritical]
	public void Clear()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	private void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (_rgbKey != null)
			{
				Array.Clear(_rgbKey, 0, _rgbKey.Length);
				_rgbKey = null;
			}
			if (IVValue != null)
			{
				Array.Clear(IVValue, 0, IVValue.Length);
				IVValue = null;
			}
			if (_depadBuffer != null)
			{
				Array.Clear(_depadBuffer, 0, _depadBuffer.Length);
				_depadBuffer = null;
			}
			if (_safeKeyHandle != null && !_safeKeyHandle.IsClosed)
			{
				_safeKeyHandle.Dispose();
			}
			if (_safeProvHandle != null && !_safeProvHandle.IsClosed)
			{
				_safeProvHandle.Dispose();
			}
		}
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void Reset()
	{
		_depadBuffer = null;
		byte[] outputBuffer = null;
		Utils._EncryptData(_safeKeyHandle, EmptyArray<byte>.Value, 0, 0, ref outputBuffer, 0, PaddingValue, fDone: true);
	}

	[SecuritySafeCritical]
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
	{
		if (inputBuffer == null)
		{
			throw new ArgumentNullException("inputBuffer");
		}
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (inputOffset < 0)
		{
			throw new ArgumentOutOfRangeException("inputOffset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (inputCount <= 0 || inputCount % InputBlockSize != 0 || inputCount > inputBuffer.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidValue"));
		}
		if (inputBuffer.Length - inputCount < inputOffset)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (encryptOrDecrypt == CryptoAPITransformMode.Encrypt)
		{
			return Utils._EncryptData(_safeKeyHandle, inputBuffer, inputOffset, inputCount, ref outputBuffer, outputOffset, PaddingValue, fDone: false);
		}
		if (PaddingValue == PaddingMode.Zeros || PaddingValue == PaddingMode.None)
		{
			return Utils._DecryptData(_safeKeyHandle, inputBuffer, inputOffset, inputCount, ref outputBuffer, outputOffset, PaddingValue, fDone: false);
		}
		if (_depadBuffer == null)
		{
			_depadBuffer = new byte[InputBlockSize];
			int num = inputCount - InputBlockSize;
			Buffer.InternalBlockCopy(inputBuffer, inputOffset + num, _depadBuffer, 0, InputBlockSize);
			return Utils._DecryptData(_safeKeyHandle, inputBuffer, inputOffset, num, ref outputBuffer, outputOffset, PaddingValue, fDone: false);
		}
		int num2 = Utils._DecryptData(_safeKeyHandle, _depadBuffer, 0, _depadBuffer.Length, ref outputBuffer, outputOffset, PaddingValue, fDone: false);
		outputOffset += OutputBlockSize;
		int num3 = inputCount - InputBlockSize;
		Buffer.InternalBlockCopy(inputBuffer, inputOffset + num3, _depadBuffer, 0, InputBlockSize);
		num2 = Utils._DecryptData(_safeKeyHandle, inputBuffer, inputOffset, num3, ref outputBuffer, outputOffset, PaddingValue, fDone: false);
		return OutputBlockSize + num2;
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
			throw new ArgumentOutOfRangeException("inputOffset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (inputCount < 0 || inputCount > inputBuffer.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidValue"));
		}
		if (inputBuffer.Length - inputCount < inputOffset)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (encryptOrDecrypt == CryptoAPITransformMode.Encrypt)
		{
			byte[] outputBuffer = null;
			Utils._EncryptData(_safeKeyHandle, inputBuffer, inputOffset, inputCount, ref outputBuffer, 0, PaddingValue, fDone: true);
			Reset();
			return outputBuffer;
		}
		if (inputCount % InputBlockSize != 0)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_SSD_InvalidDataSize"));
		}
		if (_depadBuffer == null)
		{
			byte[] outputBuffer2 = null;
			Utils._DecryptData(_safeKeyHandle, inputBuffer, inputOffset, inputCount, ref outputBuffer2, 0, PaddingValue, fDone: true);
			Reset();
			return outputBuffer2;
		}
		byte[] array = new byte[_depadBuffer.Length + inputCount];
		Buffer.InternalBlockCopy(_depadBuffer, 0, array, 0, _depadBuffer.Length);
		Buffer.InternalBlockCopy(inputBuffer, inputOffset, array, _depadBuffer.Length, inputCount);
		byte[] outputBuffer3 = null;
		Utils._DecryptData(_safeKeyHandle, array, 0, array.Length, ref outputBuffer3, 0, PaddingValue, fDone: true);
		Reset();
		return outputBuffer3;
	}
}

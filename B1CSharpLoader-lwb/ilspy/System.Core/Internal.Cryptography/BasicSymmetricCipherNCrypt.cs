using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Internal.Cryptography;

internal sealed class BasicSymmetricCipherNCrypt : BasicSymmetricCipher
{
	private CngKey _cngKey;

	private readonly bool _encrypting;

	private static readonly CngProperty s_ECBMode = CreateCngPropertyForCipherMode("ChainingModeECB");

	private static readonly CngProperty s_CBCMode = CreateCngPropertyForCipherMode("ChainingModeCBC");

	public BasicSymmetricCipherNCrypt(Func<CngKey> cngKeyFactory, CipherMode cipherMode, int blockSizeInBytes, byte[] iv, bool encrypting)
		: base(iv, blockSizeInBytes)
	{
		_encrypting = encrypting;
		_cngKey = cngKeyFactory();
		CngProperty property = cipherMode switch
		{
			CipherMode.ECB => s_ECBMode, 
			CipherMode.CBC => s_CBCMode, 
			_ => throw new CryptographicException(System.SR.GetString("Cryptography_InvalidCipherMode")), 
		};
		_cngKey.SetProperty(property);
		Reset();
	}

	[SecuritySafeCritical]
	public unsafe sealed override int Transform(byte[] input, int inputOffset, int count, byte[] output, int outputOffset)
	{
		fixed (byte* ptr = input)
		{
			fixed (byte* ptr2 = output)
			{
				int pcbResult;
				global::Interop.NCrypt.ErrorCode errorCode = ((!_encrypting) ? global::Interop.NCrypt.NCryptDecrypt(_cngKey.Handle, ptr + inputOffset, count, null, ptr2 + outputOffset, count, out pcbResult, global::Interop.NCrypt.AsymmetricPaddingMode.None) : global::Interop.NCrypt.NCryptEncrypt(_cngKey.Handle, ptr + inputOffset, count, null, ptr2 + outputOffset, count, out pcbResult, global::Interop.NCrypt.AsymmetricPaddingMode.None));
				if (errorCode != global::Interop.NCrypt.ErrorCode.ERROR_SUCCESS)
				{
					throw errorCode.ToCryptographicException();
				}
				if (pcbResult != count)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_UnexpectedTransformTruncation"));
				}
				return pcbResult;
			}
		}
	}

	public sealed override byte[] TransformFinal(byte[] input, int inputOffset, int count)
	{
		byte[] array = new byte[count];
		if (count != 0)
		{
			int num = Transform(input, inputOffset, count, array, 0);
		}
		Reset();
		return array;
	}

	protected sealed override void Dispose(bool disposing)
	{
		if (disposing && _cngKey != null)
		{
			_cngKey.Dispose();
			_cngKey = null;
		}
		base.Dispose(disposing);
	}

	private void Reset()
	{
		if (base.IV != null)
		{
			CngProperty property = new CngProperty("IV", base.IV, CngPropertyOptions.None);
			_cngKey.SetProperty(property);
		}
	}

	private static CngProperty CreateCngPropertyForCipherMode(string cipherMode)
	{
		byte[] bytes = Encoding.Unicode.GetBytes((cipherMode + "\0").ToCharArray());
		return new CngProperty("Chaining Mode", bytes, CngPropertyOptions.None);
	}
}

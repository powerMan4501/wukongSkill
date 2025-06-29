using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

public sealed class RSACng : RSA
{
	private static KeySizes[] s_legalKeySizes = new KeySizes[1]
	{
		new KeySizes(512, 16384, 64)
	};

	private static CngKeyBlobFormat s_rsaFullPrivateBlob = new CngKeyBlobFormat("RSAFULLPRIVATEBLOB");

	private static CngKeyBlobFormat s_rsaPrivateBlob = new CngKeyBlobFormat("RSAPRIVATEBLOB");

	private static CngKeyBlobFormat s_rsaPublicBlob = new CngKeyBlobFormat("RSAPUBLICBLOB");

	private CngKey _key;

	public CngKey Key
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		get
		{
			if (_key != null && _key.KeySize != KeySize)
			{
				_key.Dispose();
				_key = null;
			}
			if (_key == null)
			{
				CngKeyCreationParameters cngKeyCreationParameters = new CngKeyCreationParameters
				{
					ExportPolicy = CngExportPolicies.AllowPlaintextExport
				};
				CngProperty item = new CngProperty("Length", BitConverter.GetBytes(KeySize), CngPropertyOptions.None);
				cngKeyCreationParameters.Parameters.Add(item);
				_key = CngKey.Create(CngAlgorithm.Rsa, null, cngKeyCreationParameters);
			}
			return _key;
		}
		private set
		{
			if (value.AlgorithmGroup != CngAlgorithmGroup.Rsa)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_ArgRSAaRequiresRSAKey"), "value");
			}
			if (_key != null)
			{
				_key.Dispose();
			}
			_key = value;
			KeySizeValue = _key.KeySize;
		}
	}

	private SafeNCryptKeyHandle KeyHandle
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		get
		{
			return Key.Handle;
		}
	}

	public override string KeyExchangeAlgorithm => "RSA";

	public override string SignatureAlgorithm => "RSA";

	public RSACng()
		: this(2048)
	{
	}

	public RSACng(int keySize)
	{
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	public RSACng(CngKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.AlgorithmGroup != CngAlgorithmGroup.Rsa)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgRSAaRequiresRSAKey"), "key");
		}
		LegalKeySizesValue = s_legalKeySizes;
		Key = CngKey.Open(key.Handle, key.IsEphemeral ? CngKeyHandleOpenOptions.EphemeralKey : CngKeyHandleOpenOptions.None);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && _key != null)
		{
			_key.Dispose();
		}
	}

	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashCore(data, offset, count);
		return bCryptHashAlgorithm.HashFinal();
	}

	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		return bCryptHashAlgorithm.HashFinal();
	}

	private void CheckMagicValueOfKey(int magic, bool includePrivateParameters)
	{
		if (!includePrivateParameters)
		{
			if (magic != 826364754 && magic != 843141970 && magic != 859919186)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_NotValidPublicOrPrivateKey"));
			}
		}
		else if (magic != 843141970 && magic != 859919186)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_NotValidPrivateKey"));
		}
	}

	[SecuritySafeCritical]
	public unsafe override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		byte[] array = Key.Export(includePrivateParameters ? s_rsaFullPrivateBlob : s_rsaPublicBlob);
		RSAParameters result = default(RSAParameters);
		int magic = BitConverter.ToInt32(new byte[4]
		{
			array[0],
			array[1],
			array[2],
			array[3]
		}, 0);
		CheckMagicValueOfKey(magic, includePrivateParameters);
		fixed (byte* ptr = array)
		{
			BCryptNative.BCRYPT_RSAKEY_BLOB* ptr2 = (BCryptNative.BCRYPT_RSAKEY_BLOB*)ptr;
			int num = Marshal.SizeOf(typeof(BCryptNative.BCRYPT_RSAKEY_BLOB));
			result.Exponent = new byte[ptr2->cbPublicExp];
			Buffer.BlockCopy(array, num, result.Exponent, 0, result.Exponent.Length);
			num += ptr2->cbPublicExp;
			result.Modulus = new byte[ptr2->cbModulus];
			Buffer.BlockCopy(array, num, result.Modulus, 0, result.Modulus.Length);
			num += ptr2->cbModulus;
			if (includePrivateParameters)
			{
				result.P = new byte[ptr2->cbPrime1];
				Buffer.BlockCopy(array, num, result.P, 0, result.P.Length);
				num += ptr2->cbPrime1;
				result.Q = new byte[ptr2->cbPrime2];
				Buffer.BlockCopy(array, num, result.Q, 0, result.Q.Length);
				num += ptr2->cbPrime2;
				result.DP = new byte[ptr2->cbPrime1];
				Buffer.BlockCopy(array, num, result.DP, 0, result.DP.Length);
				num += ptr2->cbPrime1;
				result.DQ = new byte[ptr2->cbPrime2];
				Buffer.BlockCopy(array, num, result.DQ, 0, result.DQ.Length);
				num += ptr2->cbPrime2;
				result.InverseQ = new byte[ptr2->cbPrime1];
				Buffer.BlockCopy(array, num, result.InverseQ, 0, result.InverseQ.Length);
				num += ptr2->cbPrime1;
				result.D = new byte[ptr2->cbModulus];
				Buffer.BlockCopy(array, num, result.D, 0, result.D.Length);
				num += ptr2->cbModulus;
			}
		}
		return result;
	}

	[SecuritySafeCritical]
	public unsafe override void ImportParameters(RSAParameters parameters)
	{
		if (parameters.Exponent == null || parameters.Modulus == null)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_InvalidRsaParameters"));
		}
		bool flag = parameters.P == null || parameters.Q == null;
		int num = Marshal.SizeOf(typeof(BCryptNative.BCRYPT_RSAKEY_BLOB)) + parameters.Exponent.Length + parameters.Modulus.Length;
		if (!flag)
		{
			num += parameters.P.Length + parameters.Q.Length;
		}
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			BCryptNative.BCRYPT_RSAKEY_BLOB* ptr2 = (BCryptNative.BCRYPT_RSAKEY_BLOB*)ptr;
			ptr2->Magic = (flag ? BCryptNative.KeyBlobMagicNumber.RsaPublic : BCryptNative.KeyBlobMagicNumber.RsaPrivate);
			ptr2->BitLength = parameters.Modulus.Length * 8;
			ptr2->cbPublicExp = parameters.Exponent.Length;
			ptr2->cbModulus = parameters.Modulus.Length;
			if (!flag)
			{
				ptr2->cbPrime1 = parameters.P.Length;
				ptr2->cbPrime2 = parameters.Q.Length;
			}
			int num2 = Marshal.SizeOf(typeof(BCryptNative.BCRYPT_RSAKEY_BLOB));
			Buffer.BlockCopy(parameters.Exponent, 0, array, num2, parameters.Exponent.Length);
			num2 += parameters.Exponent.Length;
			Buffer.BlockCopy(parameters.Modulus, 0, array, num2, parameters.Modulus.Length);
			num2 += parameters.Modulus.Length;
			if (!flag)
			{
				Buffer.BlockCopy(parameters.P, 0, array, num2, parameters.P.Length);
				num2 += parameters.P.Length;
				Buffer.BlockCopy(parameters.Q, 0, array, num2, parameters.Q.Length);
				num2 += parameters.Q.Length;
			}
		}
		CngKey cngKey = CngKey.Import(array, flag ? s_rsaPublicBlob : s_rsaPrivateBlob);
		cngKey.ExportPolicy |= CngExportPolicies.AllowPlaintextExport;
		Key = cngKey;
	}

	[SecuritySafeCritical]
	public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		SafeNCryptKeyHandle keyHandle = KeyHandle;
		if (padding == RSAEncryptionPadding.Pkcs1)
		{
			return NCryptNative.DecryptDataPkcs1(keyHandle, data);
		}
		if (padding.Mode == RSAEncryptionPaddingMode.Oaep)
		{
			return NCryptNative.DecryptDataOaep(keyHandle, data, padding.OaepHashAlgorithm.Name);
		}
		throw new CryptographicException(System.SR.GetString("Cryptography_UnsupportedPaddingMode"));
	}

	[SecuritySafeCritical]
	public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding == RSAEncryptionPadding.Pkcs1)
		{
			return NCryptNative.EncryptDataPkcs1(KeyHandle, data);
		}
		if (padding.Mode == RSAEncryptionPaddingMode.Oaep)
		{
			return NCryptNative.EncryptDataOaep(KeyHandle, data, padding.OaepHashAlgorithm.Name);
		}
		throw new CryptographicException(System.SR.GetString("Cryptography_UnsupportedPaddingMode"));
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
	public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		CngKey key = Key;
		SafeNCryptKeyHandle handle = key.Handle;
		if (padding == RSASignaturePadding.Pkcs1)
		{
			return NCryptNative.SignHashPkcs1(handle, hash, hashAlgorithm.Name);
		}
		if (padding == RSASignaturePadding.Pss)
		{
			return NCryptNative.SignHashPss(handle, hash, hashAlgorithm.Name, hash.Length);
		}
		throw new CryptographicException(System.SR.GetString("Cryptography_UnsupportedPaddingMode"));
	}

	[SecuritySafeCritical]
	public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding == RSASignaturePadding.Pkcs1)
		{
			return NCryptNative.VerifySignaturePkcs1(KeyHandle, hash, hashAlgorithm.Name, signature);
		}
		if (padding == RSASignaturePadding.Pss)
		{
			return NCryptNative.VerifySignaturePss(KeyHandle, hash, hashAlgorithm.Name, hash.Length, signature);
		}
		throw new CryptographicException(System.SR.GetString("Cryptography_UnsupportedPaddingMode"));
	}

	public override byte[] DecryptValue(byte[] rgb)
	{
		throw new NotSupportedException("NotSupported_Method");
	}

	public override byte[] EncryptValue(byte[] rgb)
	{
		throw new NotSupportedException("NotSupported_Method");
	}
}

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class BCryptNative
{
	internal static class AlgorithmName
	{
		public const string ECDH = "ECDH";

		public const string ECDHP256 = "ECDH_P256";

		public const string ECDHP384 = "ECDH_P384";

		public const string ECDHP521 = "ECDH_P521";

		public const string ECDsa = "ECDSA";

		public const string ECDsaP256 = "ECDSA_P256";

		public const string ECDsaP384 = "ECDSA_P384";

		public const string ECDsaP521 = "ECDSA_P521";

		public const string MD5 = "MD5";

		public const string Sha1 = "SHA1";

		public const string Sha256 = "SHA256";

		public const string Sha384 = "SHA384";

		public const string Sha512 = "SHA512";

		internal const string Rsa = "RSA";
	}

	internal static class KeyBlobType
	{
		internal const string RsaFullPrivateBlob = "RSAFULLPRIVATEBLOB";

		internal const string RsaPrivateBlob = "RSAPRIVATEBLOB";

		internal const string RsaPublicBlob = "RSAPUBLICBLOB";
	}

	internal struct BCRYPT_RSAKEY_BLOB
	{
		internal KeyBlobMagicNumber Magic;

		internal int BitLength;

		internal int cbPublicExp;

		internal int cbModulus;

		internal int cbPrime1;

		internal int cbPrime2;
	}

	internal enum ErrorCode
	{
		Success = 0,
		BufferToSmall = -1073741789,
		ObjectNameNotFound = -1073741772
	}

	internal static class HashPropertyName
	{
		public const string HashLength = "HashDigestLength";
	}

	internal enum KeyBlobMagicNumber
	{
		DsaPublic = 1112560452,
		DsaPublicV2 = 843206724,
		DsaPrivate = 1448104772,
		DsaPrivateV2 = 844517444,
		ECDHPublicP256 = 827016005,
		ECDHPublicP384 = 860570437,
		ECDHPublicP521 = 894124869,
		ECDsaPublicP256 = 827540293,
		ECDsaPublicP384 = 861094725,
		ECDsaPublicP521 = 894649157,
		RsaPublic = 826364754,
		RsaPrivate = 843141970,
		RsaFullPrivateMagic = 859919186,
		KeyDataBlob = 1296188491
	}

	internal struct BCRYPT_OAEP_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pszAlgId;

		internal IntPtr pbLabel;

		internal int cbLabel;
	}

	internal struct BCRYPT_PKCS1_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pszAlgId;
	}

	internal struct BCRYPT_PSS_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pszAlgId;

		internal int cbSalt;
	}

	private struct BCRYPT_KEY_DATA_BLOB_HEADER
	{
		public uint dwMagic;

		public uint dwVersion;

		public uint cbKeyData;

		public const uint BCRYPT_KEY_DATA_BLOB_MAGIC = 1296188491u;

		public const uint BCRYPT_KEY_DATA_BLOB_VERSION1 = 1u;
	}

	internal static class KeyDerivationFunction
	{
		public const string Hash = "HASH";

		public const string Hmac = "HMAC";

		public const string Tls = "TLS_PRF";
	}

	internal static class ProviderName
	{
		public const string MicrosoftPrimitiveProvider = "Microsoft Primitive Provider";
	}

	internal static class ObjectPropertyName
	{
		public const string ObjectLength = "ObjectLength";
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptCreateHash(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hAlgorithm, out SafeBCryptHashHandle phHash, IntPtr pbHashObject, int cbHashObject, IntPtr pbSecret, int cbSecret, int dwFlags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptGetProperty(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptGetProperty(SafeBCryptKeyHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, int flags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "BCryptGetProperty")]
		internal static extern ErrorCode BCryptGetAlgorithmProperty(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "BCryptGetProperty")]
		internal static extern ErrorCode BCryptGetHashProperty(SafeBCryptHashHandle hObject, string pszProperty, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, [In][Out] ref int pcbResult, int flags);

		[DllImport("bcrypt.dll")]
		internal static extern ErrorCode BCryptFinishHash(SafeBCryptHashHandle hHash, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, int dwFlags);

		[DllImport("bcrypt.dll")]
		internal unsafe static extern ErrorCode BCryptHashData(SafeBCryptHashHandle hHash, byte* pbInput, int cbInput, int dwFlags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode BCryptOpenAlgorithmProvider(out Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle phAlgorithm, string pszAlgId, string pszImplementation, int dwFlags);

		[DllImport("bcrypt.dll", SetLastError = true)]
		internal static extern ErrorCode BCryptExportKey([In] SafeBCryptKeyHandle hKey, [In] IntPtr hExportKey, [In][MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, [In] int cbOutput, out int pcbResult, [In] int dwFlags);

		[DllImport("crypt32.dll", SetLastError = true)]
		internal static extern int CryptImportPublicKeyInfoEx2([In] uint dwCertEncodingType, [In] ref X509Native.CERT_PUBLIC_KEY_INFO pInfo, [In] int dwFlags, [In] IntPtr pvAuxInfo, out SafeBCryptKeyHandle phKey);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		internal static extern ErrorCode BCryptImportKey(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hAlgorithm, IntPtr hImportKey, string pszBlobType, out SafeBCryptKeyHandle hKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, int dwFlags);

		[DllImport("bcrypt.dll", SetLastError = true)]
		public unsafe static extern ErrorCode BCryptEncrypt(SafeBCryptKeyHandle hKey, byte* pbInput, int cbInput, IntPtr paddingInfo, [In][Out] byte[] pbIV, int cbIV, byte* pbOutput, int cbOutput, out int cbResult, int dwFlags);

		[DllImport("bcrypt.dll", SetLastError = true)]
		public unsafe static extern ErrorCode BCryptDecrypt(SafeBCryptKeyHandle hKey, byte* pbInput, int cbInput, IntPtr paddingInfo, [In][Out] byte[] pbIV, int cbIV, byte* pbOutput, int cbOutput, out int cbResult, int dwFlags);

		[DllImport("bcrypt.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern ErrorCode BCryptSetProperty(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hObject, string pszProperty, string pbInput, int cbInput, int dwFlags);
	}

	[SecuritySafeCritical]
	internal static class AesBCryptModes
	{
		[SecurityCritical]
		private static readonly Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle s_hAlgCbc = OpenAesAlgorithm("ChainingModeCBC");

		[SecurityCritical]
		private static readonly Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle s_hAlgEcb = OpenAesAlgorithm("ChainingModeECB");

		internal static Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle GetSharedHandle(CipherMode cipherMode)
		{
			return cipherMode switch
			{
				CipherMode.CBC => s_hAlgCbc, 
				CipherMode.ECB => s_hAlgEcb, 
				_ => throw new NotSupportedException(), 
			};
		}

		private static Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle OpenAesAlgorithm(string cipherMode)
		{
			Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle safeBCryptAlgorithmHandle = OpenAlgorithm("AES", null);
			SetCipherMode(safeBCryptAlgorithmHandle, cipherMode);
			return safeBCryptAlgorithmHandle;
		}
	}

	[SecuritySafeCritical]
	internal static class TripleDesBCryptModes
	{
		[SecurityCritical]
		private static readonly Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle s_hAlgCbc = OpenAesAlgorithm("ChainingModeCBC");

		[SecurityCritical]
		private static readonly Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle s_hAlgEcb = OpenAesAlgorithm("ChainingModeECB");

		internal static Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle GetSharedHandle(CipherMode cipherMode)
		{
			return cipherMode switch
			{
				CipherMode.CBC => s_hAlgCbc, 
				CipherMode.ECB => s_hAlgEcb, 
				_ => throw new NotSupportedException(), 
			};
		}

		private static Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle OpenAesAlgorithm(string cipherMode)
		{
			Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle safeBCryptAlgorithmHandle = OpenAlgorithm("3DES", null);
			SetCipherMode(safeBCryptAlgorithmHandle, cipherMode);
			return safeBCryptAlgorithmHandle;
		}
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	private delegate ErrorCode BCryptPropertyGetter<T>(T hObject, string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags) where T : SafeHandle;

	internal const string BCRYPT_ECCPUBLIC_BLOB = "ECCPUBLICBLOB";

	internal const string BCRYPT_ECCPRIVATE_BLOB = "ECCPRIVATEBLOB";

	internal const string BCRYPT_ECC_CURVE_NISTP256 = "nistP256";

	internal const string BCRYPT_ECC_CURVE_NISTP384 = "nistP384";

	internal const string BCRYPT_ECC_CURVE_NISTP521 = "nistP521";

	private static volatile bool s_haveBcryptSupported;

	private static volatile bool s_bcryptSupported;

	internal static bool BCryptSupported
	{
		[SecuritySafeCritical]
		get
		{
			if (!s_haveBcryptSupported)
			{
				using SafeLibraryHandle safeLibraryHandle = Microsoft.Win32.UnsafeNativeMethods.LoadLibraryEx("bcrypt", IntPtr.Zero, 0);
				s_bcryptSupported = !safeLibraryHandle.IsInvalid;
				s_haveBcryptSupported = true;
			}
			return s_bcryptSupported;
		}
	}

	[SecurityCritical]
	internal static int GetInt32Property<T>(T algorithm, string property) where T : SafeHandle
	{
		return BitConverter.ToInt32(GetProperty(algorithm, property), 0);
	}

	[SecurityCritical]
	internal static byte[] GetProperty<T>(T algorithm, string property) where T : SafeHandle
	{
		BCryptPropertyGetter<T> bCryptPropertyGetter = null;
		if (typeof(T) == typeof(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle))
		{
			bCryptPropertyGetter = new BCryptPropertyGetter<Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle>(UnsafeNativeMethods.BCryptGetAlgorithmProperty) as BCryptPropertyGetter<T>;
		}
		else if (typeof(T) == typeof(SafeBCryptHashHandle))
		{
			bCryptPropertyGetter = new BCryptPropertyGetter<SafeBCryptHashHandle>(UnsafeNativeMethods.BCryptGetHashProperty) as BCryptPropertyGetter<T>;
		}
		int pcbResult = 0;
		ErrorCode errorCode = bCryptPropertyGetter(algorithm, property, null, 0, ref pcbResult, 0);
		if (errorCode != ErrorCode.BufferToSmall && errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = bCryptPropertyGetter(algorithm, property, array, array.Length, ref pcbResult, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	internal static void MapAlgorithmIdToMagic(string algorithm, out KeyBlobMagicNumber algorithmMagic, out int keySize)
	{
		switch (algorithm)
		{
		case "ECDH_P256":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP256;
			keySize = 256;
			break;
		case "ECDH_P384":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP384;
			keySize = 384;
			break;
		case "ECDH_P521":
			algorithmMagic = KeyBlobMagicNumber.ECDHPublicP521;
			keySize = 521;
			break;
		case "ECDSA_P256":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP256;
			keySize = 256;
			break;
		case "ECDSA_P384":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP384;
			keySize = 384;
			break;
		case "ECDSA_P521":
			algorithmMagic = KeyBlobMagicNumber.ECDsaPublicP521;
			keySize = 521;
			break;
		default:
			throw new ArgumentException(System.SR.GetString("Cryptography_UnknownEllipticCurveAlgorithm"));
		}
	}

	[SecurityCritical]
	internal static Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle OpenAlgorithm(string algorithm, string implementation)
	{
		Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle phAlgorithm = null;
		ErrorCode errorCode = UnsafeNativeMethods.BCryptOpenAlgorithmProvider(out phAlgorithm, algorithm, implementation, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phAlgorithm;
	}

	[SecuritySafeCritical]
	internal static SafeBCryptKeyHandle ImportAsymmetricPublicKey(X509Native.CERT_PUBLIC_KEY_INFO certPublicKeyInfo, int dwFlag)
	{
		SafeBCryptKeyHandle phKey = null;
		if (UnsafeNativeMethods.CryptImportPublicKeyInfoEx2(1u, ref certPublicKeyInfo, dwFlag, IntPtr.Zero, out phKey) == 0)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phKey;
	}

	[SecuritySafeCritical]
	internal static byte[] ExportBCryptKey(SafeBCryptKeyHandle hKey, string blobType)
	{
		byte[] array = null;
		int pcbResult;
		ErrorCode errorCode = UnsafeNativeMethods.BCryptExportKey(hKey, IntPtr.Zero, blobType, null, 0, out pcbResult, 0);
		if (errorCode != ErrorCode.BufferToSmall && errorCode != ErrorCode.Success)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		array = new byte[pcbResult];
		if (UnsafeNativeMethods.BCryptExportKey(hKey, IntPtr.Zero, blobType, array, pcbResult, out pcbResult, 0) != ErrorCode.Success)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return array;
	}

	[SecuritySafeCritical]
	internal unsafe static SafeBCryptKeyHandle BCryptImportKey(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hAlg, byte[] key)
	{
		int num = key.Length;
		int num2 = sizeof(BCRYPT_KEY_DATA_BLOB_HEADER) + num;
		byte[] array = new byte[num2];
		fixed (byte* ptr = array)
		{
			BCRYPT_KEY_DATA_BLOB_HEADER* ptr2 = (BCRYPT_KEY_DATA_BLOB_HEADER*)ptr;
			ptr2->dwMagic = 1296188491u;
			ptr2->dwVersion = 1u;
			ptr2->cbKeyData = (uint)num;
		}
		Buffer.BlockCopy(key, 0, array, sizeof(BCRYPT_KEY_DATA_BLOB_HEADER), num);
		SafeBCryptKeyHandle hKey;
		ErrorCode errorCode = UnsafeNativeMethods.BCryptImportKey(hAlg, IntPtr.Zero, "KeyDataBlob", out hKey, IntPtr.Zero, 0, array, num2, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return hKey;
	}

	[SecuritySafeCritical]
	public unsafe static int BCryptEncrypt(SafeBCryptKeyHandle hKey, byte[] input, int inputOffset, int inputCount, byte[] iv, byte[] output, int outputOffset, int outputCount)
	{
		fixed (byte* ptr = input)
		{
			fixed (byte* ptr2 = output)
			{
				int cbResult;
				ErrorCode errorCode = UnsafeNativeMethods.BCryptEncrypt(hKey, ptr + inputOffset, inputCount, IntPtr.Zero, iv, (iv != null) ? iv.Length : 0, ptr2 + outputOffset, outputCount, out cbResult, 0);
				if (errorCode != ErrorCode.Success)
				{
					throw new CryptographicException((int)errorCode);
				}
				return cbResult;
			}
		}
	}

	[SecuritySafeCritical]
	public unsafe static int BCryptDecrypt(SafeBCryptKeyHandle hKey, byte[] input, int inputOffset, int inputCount, byte[] iv, byte[] output, int outputOffset, int outputCount)
	{
		fixed (byte* ptr = input)
		{
			fixed (byte* ptr2 = output)
			{
				int cbResult;
				ErrorCode errorCode = UnsafeNativeMethods.BCryptDecrypt(hKey, ptr + inputOffset, inputCount, IntPtr.Zero, iv, (iv != null) ? iv.Length : 0, ptr2 + outputOffset, outputCount, out cbResult, 0);
				if (errorCode != ErrorCode.Success)
				{
					throw new CryptographicException((int)errorCode);
				}
				return cbResult;
			}
		}
	}

	[SecurityCritical]
	public static void SetCipherMode(Microsoft.Win32.SafeHandles.SafeBCryptAlgorithmHandle hAlg, string cipherMode)
	{
		ErrorCode errorCode = UnsafeNativeMethods.BCryptSetProperty(hAlg, "ChainingMode", cipherMode, (cipherMode.Length + 1) * 2, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
	}
}

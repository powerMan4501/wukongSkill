using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class CapiNative
{
	internal enum AlgorithmClass
	{
		DataEncryption = 24576,
		Hash = 32768
	}

	internal enum AlgorithmType
	{
		Any = 0,
		Block = 1536
	}

	internal enum AlgorithmSubId
	{
		MD5 = 3,
		Sha1 = 4,
		Sha256 = 12,
		Sha384 = 13,
		Sha512 = 14,
		Aes128 = 14,
		Aes192 = 15,
		Aes256 = 16
	}

	internal enum AlgorithmId
	{
		None = 0,
		Aes128 = 26126,
		Aes192 = 26127,
		Aes256 = 26128,
		MD5 = 32771,
		Sha1 = 32772,
		Sha256 = 32780,
		Sha384 = 32781,
		Sha512 = 32782
	}

	[Flags]
	internal enum CryptAcquireContextFlags
	{
		None = 0,
		VerifyContext = -268435456
	}

	internal enum ErrorCode
	{
		Success = 0,
		MoreData = 234,
		NoMoreItems = 259,
		BadData = -2146893819,
		BadAlgorithmId = -2146893816,
		ProviderTypeNotDefined = -2146893801,
		KeysetNotDefined = -2146893799
	}

	internal enum HashParameter
	{
		None = 0,
		AlgorithmId = 1,
		HashValue = 2,
		HashSize = 4
	}

	internal enum KeyBlobType : byte
	{
		PlainText = 8
	}

	[Flags]
	internal enum KeyFlags
	{
		None = 0,
		Exportable = 1
	}

	internal enum KeyParameter
	{
		None = 0,
		IV = 1,
		Mode = 4,
		ModeBits = 5
	}

	internal static class ProviderNames
	{
		public const string MicrosoftEnhancedRsaAes = "Microsoft Enhanced RSA and AES Cryptographic Provider";

		public const string MicrosoftEnhancedRsaAesPrototype = "Microsoft Enhanced RSA and AES Cryptographic Provider (Prototype)";
	}

	internal enum ProviderParameter
	{
		None,
		EnumerateAlgorithms
	}

	[Flags]
	internal enum ProviderParameterFlags
	{
		None = 0,
		RestartEnumeration = 1
	}

	internal enum ProviderType
	{
		None = 0,
		RsaAes = 24
	}

	internal struct BLOBHEADER
	{
		public KeyBlobType bType;

		public byte bVersion;

		public short reserved;

		public AlgorithmId aiKeyAlg;
	}

	internal struct CRYPTOAPI_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	internal struct CERT_DSS_PARAMETERS
	{
		public CRYPTOAPI_BLOB p;

		public CRYPTOAPI_BLOB q;

		public CRYPTOAPI_BLOB g;
	}

	internal struct PROV_ENUMALGS
	{
		public AlgorithmId aiAlgId;

		public int dwBitLen;

		public int dwNameLen;

		public unsafe fixed byte szName[20];
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_OID_INFO
	{
		internal uint cbSize;

		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszOID;

		internal string pwszName;

		internal uint dwGroupId;

		internal uint Algid;

		internal CRYPTOAPI_BLOB ExtraInfo;

		internal CRYPT_OID_INFO(int size)
		{
			cbSize = (uint)size;
			pszOID = null;
			pwszName = null;
			dwGroupId = 0u;
			Algid = 0u;
			ExtraInfo = default(CRYPTOAPI_BLOB);
		}
	}

	[SecurityCritical(SecurityCriticalScope.Everything)]
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[DllImport("clr")]
		public static extern int _AxlPublicKeyBlobToPublicKeyToken(ref CRYPTOAPI_BLOB pCspPublicKeyBlob, out SafeAxlBufferHandle ppwszPublicKeyToken);

		[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptAcquireContext(out Microsoft.Win32.SafeHandles.SafeCspHandle phProv, string pszContainer, string pszProvider, ProviderType dwProvType, CryptAcquireContextFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptCreateHash(Microsoft.Win32.SafeHandles.SafeCspHandle hProv, AlgorithmId Algid, SafeCapiKeyHandle hKey, int dwFlags, out SafeCapiHashHandle phHash);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptDecrypt(SafeCapiKeyHandle hKey, SafeCapiHashHandle hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, int dwFlags, IntPtr pbData, [In][Out] ref int pdwDataLen);

		[DllImport("advapi32")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptDuplicateKey(SafeCapiKeyHandle hKey, IntPtr pdwReserved, int dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptEncrypt(SafeCapiKeyHandle hKey, SafeCapiHashHandle hHash, [MarshalAs(UnmanagedType.Bool)] bool Final, int dwFlags, IntPtr pbData, [In][Out] ref int pdwDataLen, int dwBufLen);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptExportKey(SafeCapiKeyHandle hKey, SafeCapiKeyHandle hExpKey, int dwBlobType, int dwExportFlags, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGenKey(Microsoft.Win32.SafeHandles.SafeCspHandle hProv, AlgorithmId Algid, KeyFlags dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGenRandom(Microsoft.Win32.SafeHandles.SafeCspHandle hProv, int dwLen, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbBuffer);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGetHashParam(SafeCapiHashHandle hHash, HashParameter dwParam, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptGetProvParam(Microsoft.Win32.SafeHandles.SafeCspHandle hProv, ProviderParameter dwParam, IntPtr pbData, [In][Out] ref int pdwDataLen, ProviderParameterFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public unsafe static extern bool CryptHashData(SafeCapiHashHandle hHash, byte* pbData, int dwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptImportKey(Microsoft.Win32.SafeHandles.SafeCspHandle hProv, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwDataLen, SafeCapiKeyHandle hPubKey, KeyFlags dwFlags, out SafeCapiKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CryptSetKeyParam(SafeCapiKeyHandle hKey, KeyParameter dwParam, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwFlags);

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CryptFindOIDInfo([In] uint dwKeyType, [In] IntPtr pvKey, [In] OidGroup dwGroupId);

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern IntPtr CryptFindOIDInfo([In] uint dwKeyType, [In] System.Security.Cryptography.SafeLocalAllocHandle pvKey, [In] OidGroup dwGroupId);

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern bool CryptDecodeObject([In] uint dwCertEncodingType, [In] IntPtr lpszStructType, [In] IntPtr pbEncoded, [In] uint cbEncoded, [In] uint dwFlags, [In][Out] System.Security.Cryptography.SafeLocalAllocHandle pvStructInfo, [In][Out] IntPtr pcbStructInfo);

		[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern bool CryptDecodeObject([In] uint dwCertEncodingType, [In] IntPtr lpszStructType, [In] byte[] pbEncoded, [In] uint cbEncoded, [In] uint dwFlags, [In][Out] System.Security.Cryptography.SafeLocalAllocHandle pvStructInfo, [In][Out] IntPtr pcbStructInfo);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		internal static extern System.Security.Cryptography.SafeLocalAllocHandle LocalAlloc([In] uint uFlags, [In] IntPtr sizetdwBytes);
	}

	internal const uint ALG_CLASS_SIGNATURE = 8192u;

	internal const uint ALG_TYPE_RSA = 1024u;

	internal const uint ALG_SID_RSA_ANY = 0u;

	internal const uint ALG_SID_DSS_ANY = 0u;

	internal const uint ALG_TYPE_DSS = 512u;

	internal const uint ALG_CLASS_KEY_EXCHANGE = 40960u;

	internal const uint CALG_RSA_SIGN = 9216u;

	internal const uint CALG_DSS_SIGN = 8704u;

	internal const uint CALG_RSA_KEYX = 41984u;

	internal const uint CNG_RSA_PUBLIC_KEY_BLOB = 72u;

	internal const uint X509_DSS_PUBLICKEY = 38u;

	internal const uint X509_DSS_PARAMETERS = 39u;

	internal const uint X509_ASN_ENCODING = 1u;

	internal const uint PKCS_7_ASN_ENCODING = 65536u;

	internal const uint CRYPT_OID_INFO_OID_KEY = 1u;

	internal const uint LMEM_FIXED = 0u;

	internal const uint LMEM_ZEROINIT = 64u;

	[SecurityCritical]
	internal static Microsoft.Win32.SafeHandles.SafeCspHandle AcquireCsp(string keyContainer, string providerName, ProviderType providerType, CryptAcquireContextFlags flags, bool throwPlatformException)
	{
		Microsoft.Win32.SafeHandles.SafeCspHandle phProv = null;
		if (!UnsafeNativeMethods.CryptAcquireContext(out phProv, keyContainer, providerName, providerType, flags))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (throwPlatformException && (lastWin32Error == -2146893801 || lastWin32Error == -2146893799))
			{
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
			}
			throw new CryptographicException(lastWin32Error);
		}
		return phProv;
	}

	[SecurityCritical]
	internal static byte[] ExportSymmetricKey(SafeCapiKeyHandle key)
	{
		int pdwDataLen = 0;
		if (!UnsafeNativeMethods.CryptExportKey(key, SafeCapiKeyHandle.InvalidHandle, 8, 0, null, ref pdwDataLen))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 234)
			{
				throw new CryptographicException(lastWin32Error);
			}
		}
		byte[] array = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptExportKey(key, SafeCapiKeyHandle.InvalidHandle, 8, 0, array, ref pdwDataLen))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		int srcOffset = Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int));
		int num = BitConverter.ToInt32(array, Marshal.SizeOf(typeof(BLOBHEADER)));
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, srcOffset, array2, 0, array2.Length);
		return array2;
	}

	internal static string GetAlgorithmName(AlgorithmId algorithm)
	{
		return algorithm.ToString().ToUpper(CultureInfo.InvariantCulture);
	}

	[SecurityCritical]
	internal static byte[] GetHashParameter(SafeCapiHashHandle hashHandle, HashParameter parameter)
	{
		int pdwDataLen = 0;
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, parameter, null, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		byte[] array = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, parameter, array, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if (pdwDataLen != array.Length)
		{
			byte[] array2 = new byte[pdwDataLen];
			Buffer.BlockCopy(array, 0, array2, 0, pdwDataLen);
			array = array2;
		}
		return array;
	}

	[SecurityCritical]
	internal static T GetProviderParameterStruct<T>(Microsoft.Win32.SafeHandles.SafeCspHandle provider, ProviderParameter parameter, ProviderParameterFlags flags) where T : struct
	{
		int pdwDataLen = 0;
		IntPtr intPtr = IntPtr.Zero;
		if (!UnsafeNativeMethods.CryptGetProvParam(provider, parameter, intPtr, ref pdwDataLen, flags))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			switch (lastWin32Error)
			{
			case 259:
				return new T();
			default:
				throw new CryptographicException(lastWin32Error);
			case 234:
				break;
			}
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.AllocCoTaskMem(pdwDataLen);
			}
			if (!UnsafeNativeMethods.CryptGetProvParam(provider, parameter, intPtr, ref pdwDataLen, flags))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			return (T)Marshal.PtrToStructure(intPtr, typeof(T));
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
	}

	internal static int HResultForVerificationResult(SignatureVerificationResult verificationResult)
	{
		switch (verificationResult)
		{
		case SignatureVerificationResult.AssemblyIdentityMismatch:
		case SignatureVerificationResult.PublicKeyTokenMismatch:
		case SignatureVerificationResult.PublisherMismatch:
			return -2146762749;
		case SignatureVerificationResult.ContainingSignatureInvalid:
			return -2146869232;
		default:
			return (int)verificationResult;
		}
	}

	[SecurityCritical]
	internal unsafe static SafeCapiKeyHandle ImportSymmetricKey(Microsoft.Win32.SafeHandles.SafeCspHandle provider, AlgorithmId algorithm, byte[] key)
	{
		int num = Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int)) + key.Length;
		byte[] array = new byte[num];
		fixed (byte* ptr = array)
		{
			BLOBHEADER* ptr2 = (BLOBHEADER*)ptr;
			ptr2->bType = KeyBlobType.PlainText;
			ptr2->bVersion = 2;
			ptr2->reserved = 0;
			ptr2->aiKeyAlg = algorithm;
			int* ptr3 = (int*)(ptr + Marshal.SizeOf((object)(*ptr2)));
			*ptr3 = key.Length;
		}
		Buffer.BlockCopy(key, 0, array, Marshal.SizeOf(typeof(BLOBHEADER)) + Marshal.SizeOf(typeof(int)), key.Length);
		SafeCapiKeyHandle phKey = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!UnsafeNativeMethods.CryptImportKey(provider, array, array.Length, SafeCapiKeyHandle.InvalidHandle, KeyFlags.Exportable, out phKey))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		finally
		{
			if (phKey != null && !phKey.IsInvalid)
			{
				phKey.SetParentCsp(provider);
			}
		}
		return phKey;
	}

	[SecurityCritical]
	internal static void SetKeyParameter(SafeCapiKeyHandle key, KeyParameter parameter, int value)
	{
		SetKeyParameter(key, parameter, BitConverter.GetBytes(value));
	}

	[SecurityCritical]
	internal static void SetKeyParameter(SafeCapiKeyHandle key, KeyParameter parameter, byte[] value)
	{
		if (!UnsafeNativeMethods.CryptSetKeyParam(key, parameter, value, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
	}

	[SecuritySafeCritical]
	internal static System.Security.Cryptography.SafeLocalAllocHandle LocalAlloc(uint uFlags, IntPtr sizetdwBytes)
	{
		System.Security.Cryptography.SafeLocalAllocHandle safeLocalAllocHandle = UnsafeNativeMethods.LocalAlloc(uFlags, sizetdwBytes);
		if (safeLocalAllocHandle == null || safeLocalAllocHandle.IsInvalid)
		{
			throw new OutOfMemoryException();
		}
		return safeLocalAllocHandle;
	}

	[SecuritySafeCritical]
	internal unsafe static bool DecodeObject(IntPtr pszStructType, IntPtr pbEncoded, uint cbEncoded, out System.Security.Cryptography.SafeLocalAllocHandle decodedValue, out uint cbDecodedValue)
	{
		decodedValue = System.Security.Cryptography.SafeLocalAllocHandle.InvalidHandle;
		cbDecodedValue = 0u;
		uint num = 0u;
		System.Security.Cryptography.SafeLocalAllocHandle invalidHandle = System.Security.Cryptography.SafeLocalAllocHandle.InvalidHandle;
		if (!UnsafeNativeMethods.CryptDecodeObject(65537u, pszStructType, pbEncoded, cbEncoded, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!UnsafeNativeMethods.CryptDecodeObject(65537u, pszStructType, pbEncoded, cbEncoded, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		decodedValue = invalidHandle;
		cbDecodedValue = num;
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool DecodeObject(IntPtr pszStructType, byte[] pbEncoded, out System.Security.Cryptography.SafeLocalAllocHandle decodedValue, out uint cbDecodedValue)
	{
		decodedValue = System.Security.Cryptography.SafeLocalAllocHandle.InvalidHandle;
		cbDecodedValue = 0u;
		uint num = 0u;
		System.Security.Cryptography.SafeLocalAllocHandle invalidHandle = System.Security.Cryptography.SafeLocalAllocHandle.InvalidHandle;
		if (!UnsafeNativeMethods.CryptDecodeObject(65537u, pszStructType, pbEncoded, (uint)pbEncoded.Length, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!UnsafeNativeMethods.CryptDecodeObject(65537u, pszStructType, pbEncoded, (uint)pbEncoded.Length, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		decodedValue = invalidHandle;
		cbDecodedValue = num;
		return true;
	}

	[SecuritySafeCritical]
	internal static CRYPT_OID_INFO CryptFindOIDInfo([In] uint dwKeyType, [In] IntPtr pvKey, [In] OidGroup dwGroupId)
	{
		if (pvKey == IntPtr.Zero)
		{
			throw new ArgumentNullException("pvKey");
		}
		CRYPT_OID_INFO result = new CRYPT_OID_INFO(Marshal.SizeOf(typeof(CRYPT_OID_INFO)));
		IntPtr intPtr = UnsafeNativeMethods.CryptFindOIDInfo(dwKeyType, pvKey, dwGroupId);
		if (intPtr != IntPtr.Zero)
		{
			return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr, typeof(CRYPT_OID_INFO));
		}
		return result;
	}

	[SecuritySafeCritical]
	internal static CRYPT_OID_INFO CryptFindOIDInfo([In] uint dwKeyType, [In] System.Security.Cryptography.SafeLocalAllocHandle pvKey, [In] OidGroup dwGroupId)
	{
		if (pvKey == null)
		{
			throw new ArgumentNullException("pvKey");
		}
		if (pvKey.IsInvalid)
		{
			throw new CryptographicException("SR.GetString(SR.Cryptography_InvalidHandle)", "pvKey");
		}
		CRYPT_OID_INFO result = new CRYPT_OID_INFO(Marshal.SizeOf(typeof(CRYPT_OID_INFO)));
		IntPtr intPtr = UnsafeNativeMethods.CryptFindOIDInfo(dwKeyType, pvKey, dwGroupId);
		if (intPtr != IntPtr.Zero)
		{
			return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr, typeof(CRYPT_OID_INFO));
		}
		return result;
	}
}

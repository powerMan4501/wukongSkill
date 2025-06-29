using System.Runtime.InteropServices;

namespace System.Security.Cryptography;

internal static class CapiNative
{
	internal enum AlgorithmClass
	{
		Any = 0,
		Signature = 8192,
		DataEncrypt = 24576,
		Hash = 32768,
		KeyExchange = 40960
	}

	internal enum AlgorithmType
	{
		Any = 0,
		Rsa = 1024,
		Block = 1536
	}

	internal enum AlgorithmSubId
	{
		Any = 0,
		RsaAny = 0,
		Rc2 = 2,
		Md5 = 3,
		Sha1 = 4,
		Sha256 = 12,
		Sha384 = 13,
		Sha512 = 14,
		Hmac = 9
	}

	internal enum AlgorithmID
	{
		None = 0,
		RsaSign = 9216,
		RsaKeyExchange = 41984,
		Rc2 = 26114,
		Md5 = 32771,
		Sha1 = 32772,
		Sha256 = 32780,
		Sha384 = 32781,
		Sha512 = 32782,
		Hmac = 32777
	}

	[Flags]
	internal enum CryptAcquireContextFlags
	{
		None = 0,
		NewKeyset = 8,
		DeleteKeyset = 0x10,
		MachineKeyset = 0x20,
		Silent = 0x40,
		VerifyContext = -268435456
	}

	internal enum ErrorCode
	{
		Ok = 0,
		MoreData = 234,
		BadHash = -2146893822,
		BadData = -2146893819,
		BadSignature = -2146893818,
		NoKey = -2146893811
	}

	internal enum HashProperty
	{
		None = 0,
		HashValue = 2,
		HashSize = 4,
		HmacInfo = 5
	}

	[Flags]
	internal enum KeyGenerationFlags
	{
		None = 0,
		Exportable = 1,
		UserProtected = 2,
		Archivable = 0x4000
	}

	internal enum KeyProperty
	{
		None = 0,
		AlgorithmID = 7,
		KeyLength = 9
	}

	internal enum KeySpec
	{
		KeyExchange = 1,
		Signature
	}

	internal static class ProviderNames
	{
		internal const string MicrosoftEnhanced = "Microsoft Enhanced Cryptographic Provider v1.0";
	}

	internal enum ProviderType
	{
		RsaFull = 1,
		RsaAes = 24
	}

	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	internal static class SafeNativeMethods
	{
		internal static readonly Lazy<SafeCspHandle> DefaultProvider = new Lazy<SafeCspHandle>(delegate
		{
			if (!CryptAcquireContext(out var phProv, IntPtr.Zero, IntPtr.Zero, ProviderType.RsaAes, CryptAcquireContextFlags.VerifyContext))
			{
				Exception ex = new CryptographicException(Marshal.GetLastWin32Error());
				phProv.Dispose();
				throw ex;
			}
			return phProv;
		});

		[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptAcquireContext(out SafeCspHandle phProv, IntPtr pszContainer, IntPtr pszProvider, ProviderType dwProvType, CryptAcquireContextFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptCreateHash(SafeCspHandle hProv, AlgorithmID Algid, IntPtr hKey, int dwFlags, out SafeCspHashHandle phHash);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptGetHashParam(SafeCspHashHandle hHash, HashProperty dwParam, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptHashData(SafeCspHashHandle hHash, IntPtr pbData, int dwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptImportKey(SafeCspHandle hProv, IntPtr pbData, int dwDataLen, IntPtr hPubKey, KeyGenerationFlags dwFlags, out SafeCspKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptSetHashParam(SafeCspHashHandle hHash, HashProperty dwParam, IntPtr pbData, int dwFlags);
	}

	[SecurityCritical]
	internal static class UnsafeNativeMethods
	{
		[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptAcquireContext(out SafeCspHandle phProv, string pszContainer, string pszProvider, ProviderType dwProvType, CryptAcquireContextFlags dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptCreateHash(SafeCspHandle hProv, AlgorithmID Algid, IntPtr hKey, int dwFlags, out SafeCspHashHandle phHash);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptGenKey(SafeCspHandle hProv, int Algid, uint dwFlags, out SafeCspKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptGenRandom(SafeCspHandle hProv, int dwLen, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbBuffer);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal unsafe static extern bool CryptGenRandom(SafeCspHandle hProv, int dwLen, byte* pbBuffer);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptGetHashParam(SafeCspHashHandle hHash, HashProperty dwParam, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptGetKeyParam(SafeCspKeyHandle hKey, KeyProperty dwParam, [In][Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, [In][Out] ref int pdwDataLen, int dwFlags);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptImportKey(SafeCspHandle hProv, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int pdwDataLen, IntPtr hPubKey, KeyGenerationFlags dwFlags, out SafeCspKeyHandle phKey);

		[DllImport("advapi32", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptSetHashParam(SafeCspHashHandle hHash, HashProperty dwParam, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int dwFlags);

		[DllImport("advapi32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptVerifySignature(SafeCspHashHandle hHash, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int dwSigLen, SafeCspKeyHandle hPubKey, string sDescription, int dwFlags);
	}

	[SecurityCritical]
	internal static SafeCspHandle AcquireCsp(string keyContainer, string providerName, ProviderType providerType, CryptAcquireContextFlags flags)
	{
		if ((flags & CryptAcquireContextFlags.VerifyContext) == CryptAcquireContextFlags.VerifyContext && (flags & CryptAcquireContextFlags.MachineKeyset) == CryptAcquireContextFlags.MachineKeyset)
		{
			flags &= ~CryptAcquireContextFlags.MachineKeyset;
		}
		SafeCspHandle phProv = null;
		if (!UnsafeNativeMethods.CryptAcquireContext(out phProv, keyContainer, providerName, providerType, flags))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phProv;
	}

	[SecurityCritical]
	internal static SafeCspHashHandle CreateHashAlgorithm(SafeCspHandle cspHandle, AlgorithmID algorithm)
	{
		SafeCspHashHandle phHash = null;
		if (!UnsafeNativeMethods.CryptCreateHash(cspHandle, algorithm, IntPtr.Zero, 0, out phHash))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phHash;
	}

	[SecurityCritical]
	internal static void GenerateRandomBytes(SafeCspHandle cspHandle, byte[] buffer)
	{
		if (!UnsafeNativeMethods.CryptGenRandom(cspHandle, buffer.Length, buffer))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
	}

	[SecurityCritical]
	internal unsafe static void GenerateRandomBytes(SafeCspHandle cspHandle, byte[] buffer, int offset, int count)
	{
		fixed (byte* pbBuffer = &buffer[offset])
		{
			if (!UnsafeNativeMethods.CryptGenRandom(cspHandle, count, pbBuffer))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
	}

	[SecurityCritical]
	internal static int GetHashPropertyInt32(SafeCspHashHandle hashHandle, HashProperty property)
	{
		byte[] hashProperty = GetHashProperty(hashHandle, property);
		if (hashProperty.Length != 4)
		{
			return 0;
		}
		return BitConverter.ToInt32(hashProperty, 0);
	}

	[SecurityCritical]
	internal static byte[] GetHashProperty(SafeCspHashHandle hashHandle, HashProperty property)
	{
		int pdwDataLen = 0;
		byte[] pbData = null;
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, property, pbData, ref pdwDataLen, 0))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 234)
			{
				throw new CryptographicException(lastWin32Error);
			}
		}
		pbData = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptGetHashParam(hashHandle, property, pbData, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return pbData;
	}

	[SecurityCritical]
	internal static int GetKeyPropertyInt32(SafeCspKeyHandle keyHandle, KeyProperty property)
	{
		byte[] keyProperty = GetKeyProperty(keyHandle, property);
		if (keyProperty.Length != 4)
		{
			return 0;
		}
		return BitConverter.ToInt32(keyProperty, 0);
	}

	[SecurityCritical]
	internal static byte[] GetKeyProperty(SafeCspKeyHandle keyHandle, KeyProperty property)
	{
		int pdwDataLen = 0;
		byte[] pbData = null;
		if (!UnsafeNativeMethods.CryptGetKeyParam(keyHandle, property, pbData, ref pdwDataLen, 0))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 234)
			{
				throw new CryptographicException(lastWin32Error);
			}
		}
		pbData = new byte[pdwDataLen];
		if (!UnsafeNativeMethods.CryptGetKeyParam(keyHandle, property, pbData, ref pdwDataLen, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return pbData;
	}

	[SecurityCritical]
	internal static void SetHashProperty(SafeCspHashHandle hashHandle, HashProperty property, byte[] value)
	{
		if (!UnsafeNativeMethods.CryptSetHashParam(hashHandle, property, value, 0))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
	}

	[SecurityCritical]
	internal static bool VerifySignature(SafeCspHandle cspHandle, SafeCspKeyHandle keyHandle, AlgorithmID signatureAlgorithm, AlgorithmID hashAlgorithm, byte[] hashValue, byte[] signature)
	{
		byte[] array = new byte[signature.Length];
		Array.Copy(signature, array, array.Length);
		Array.Reverse(array);
		using SafeCspHashHandle safeCspHashHandle = CreateHashAlgorithm(cspHandle, hashAlgorithm);
		if (hashValue.Length != GetHashPropertyInt32(safeCspHashHandle, HashProperty.HashSize))
		{
			throw new CryptographicException(-2146893822);
		}
		SetHashProperty(safeCspHashHandle, HashProperty.HashValue, hashValue);
		if (UnsafeNativeMethods.CryptVerifySignature(safeCspHashHandle, array, array.Length, keyHandle, null, 0))
		{
			return true;
		}
		int lastWin32Error = Marshal.GetLastWin32Error();
		if (lastWin32Error != -2146893818)
		{
			throw new CryptographicException(lastWin32Error);
		}
		return false;
	}
}

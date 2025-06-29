using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography.X509Certificates;

[SuppressUnmanagedCodeSecurity]
internal static class Pbkdf2
{
	internal const string BCRYPT_LIB = "bcrypt.dll";

	private const string MS_PRIMITIVE_PROVIDER = "Microsoft Primitive Provider";

	private const int NtStatusSuccess = 0;

	[SecurityCritical]
	internal static readonly SafeBCryptAlgorithmHandle _sha1;

	[SecurityCritical]
	internal static readonly SafeBCryptAlgorithmHandle _sha256;

	[SecurityCritical]
	internal static readonly SafeBCryptAlgorithmHandle _sha384;

	[SecurityCritical]
	internal static readonly SafeBCryptAlgorithmHandle _sha512;

	[SecuritySafeCritical]
	static Pbkdf2()
	{
		if (BCryptOpenAlgorithmProvider(out _sha1, "SHA1", "Microsoft Primitive Provider", OpenAlgorithmProviderFlags.BCRYPT_ALG_HANDLE_HMAC_FLAG) != 0)
		{
			throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "A provider could not be found for algorithm '{0}'.", "SHA1"));
		}
		if (BCryptOpenAlgorithmProvider(out _sha256, "SHA256", "Microsoft Primitive Provider", OpenAlgorithmProviderFlags.BCRYPT_ALG_HANDLE_HMAC_FLAG) != 0)
		{
			throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "A provider could not be found for algorithm '{0}'.", "SHA256"));
		}
		if (BCryptOpenAlgorithmProvider(out _sha384, "SHA384", "Microsoft Primitive Provider", OpenAlgorithmProviderFlags.BCRYPT_ALG_HANDLE_HMAC_FLAG) != 0)
		{
			throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "A provider could not be found for algorithm '{0}'.", "SHA384"));
		}
		if (BCryptOpenAlgorithmProvider(out _sha512, "SHA512", "Microsoft Primitive Provider", OpenAlgorithmProviderFlags.BCRYPT_ALG_HANDLE_HMAC_FLAG) != 0)
		{
			throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "A provider could not be found for algorithm '{0}'.", "SHA512"));
		}
	}

	[DllImport("bcrypt.dll")]
	[SecurityCritical]
	private static extern int BCryptOpenAlgorithmProvider(out SafeBCryptAlgorithmHandle phAlgorithm, [In][MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [In][MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, [In] OpenAlgorithmProviderFlags dwFlags);

	[SecuritySafeCritical]
	internal unsafe static byte[] Derive(string hashAlgorithm, byte[] password, byte[] salt, int iterations, int length)
	{
		if (length <= 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (iterations <= 0)
		{
			throw new ArgumentOutOfRangeException("iterations");
		}
		KdfWorkLimiter.RecordIterations(iterations);
		byte[] array = new byte[length];
		SafeBCryptAlgorithmHandle hPrf = hashAlgorithm switch
		{
			"SHA1" => _sha1, 
			"SHA256" => _sha256, 
			"SHA384" => _sha384, 
			"SHA512" => _sha512, 
			_ => throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "'{0}' is not a known hash algorithm.", hashAlgorithm)), 
		};
		fixed (byte* ptr = password)
		{
			fixed (byte* ptr2 = salt)
			{
				fixed (byte* pbDerivedKey = array)
				{
					byte b = 0;
					int num = BCryptDeriveKeyPBKDF2(hPrf, (ptr != null) ? ptr : (&b), password.Length, (ptr2 != null) ? ptr2 : (&b), salt.Length, (ulong)iterations, pbDerivedKey, array.Length, 0u);
					if (num != 0)
					{
						throw new CryptographicException(string.Format(CultureInfo.CurrentCulture, "A call to BCryptDeriveKeyPBKDF2 failed with code '{0}'.", num));
					}
				}
			}
		}
		return array;
	}

	[DllImport("bcrypt.dll")]
	[SecurityCritical]
	internal unsafe static extern int BCryptDeriveKeyPBKDF2(SafeBCryptAlgorithmHandle hPrf, byte* pbPassword, int cbPassword, byte* pbSalt, int cbSalt, ulong cIterations, byte* pbDerivedKey, int cbDerivedKey, uint dwFlags);
}

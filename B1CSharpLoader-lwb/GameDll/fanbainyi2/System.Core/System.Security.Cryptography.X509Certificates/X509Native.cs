using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal static class X509Native
{
	[Flags]
	public enum AxlVerificationFlags
	{
		None = 0,
		NoRevocationCheck = 1,
		RevocationCheckEndCertOnly = 2,
		RevocationCheckEntireChain = 4,
		UrlOnlyCacheRetrieval = 8,
		LifetimeSigning = 0x10,
		TrustMicrosoftRootOnly = 0x20
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_CONTEXT
	{
		internal uint dwCertEncodingType;

		internal IntPtr pbCertEncoded;

		internal uint cbCertEncoded;

		internal IntPtr pCertInfo;

		internal IntPtr hCertStore;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_PUBLIC_KEY_INFO
	{
		internal CRYPT_ALGORITHM_IDENTIFIER Algorithm;

		internal CRYPT_BIT_BLOB PublicKey;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CERT_INFO
	{
		internal uint dwVersion;

		internal CRYPTOAPI_BLOB SerialNumber;

		internal CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

		internal CRYPTOAPI_BLOB Issuer;

		internal System.Runtime.InteropServices.ComTypes.FILETIME NotBefore;

		internal System.Runtime.InteropServices.ComTypes.FILETIME NotAfter;

		internal CRYPTOAPI_BLOB Subject;

		internal CERT_PUBLIC_KEY_INFO SubjectPublicKeyInfo;

		internal CRYPT_BIT_BLOB IssuerUniqueId;

		internal CRYPT_BIT_BLOB SubjectUniqueId;

		internal uint cExtension;

		internal IntPtr rgExtension;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_ALGORITHM_IDENTIFIER
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string pszObjId;

		internal CRYPTOAPI_BLOB Parameters;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPT_BIT_BLOB
	{
		internal uint cbData;

		internal IntPtr pbData;

		internal uint cUnusedBits;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPTOAPI_BLOB
	{
		internal uint cbData;

		internal IntPtr pbData;
	}

	internal enum AcquireCertificateKeyOptions
	{
		None = 0,
		AcquireOnlyNCryptKeys = 0x40000
	}

	internal enum CertificateProperty
	{
		KeyProviderInfo = 2,
		KeyContext = 5,
		NCryptKeyHandle = 78
	}

	[Flags]
	internal enum CertSetPropertyFlags
	{
		CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG = 0x40000000,
		None = 0
	}

	internal enum ErrorCode
	{
		Success = 0,
		MoreData = 234
	}

	internal struct CRYPT_KEY_PROV_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pwszContainerName;

		[MarshalAs(UnmanagedType.LPWStr)]
		internal string pwszProvName;

		internal int dwProvType;

		internal int dwFlags;

		internal int cProvParam;

		internal IntPtr rgProvParam;

		internal int dwKeySpec;
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct AXL_AUTHENTICODE_SIGNER_INFO
	{
		public int cbSize;

		public int dwError;

		public CapiNative.AlgorithmId algHash;

		public IntPtr pwszHash;

		public IntPtr pwszDescription;

		public IntPtr pwszDescriptionUrl;

		public IntPtr pChainContext;
	}

	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct AXL_AUTHENTICODE_TIMESTAMPER_INFO
	{
		public int cbsize;

		public int dwError;

		public CapiNative.AlgorithmId algHash;

		public System.Runtime.InteropServices.ComTypes.FILETIME ftTimestamp;

		public IntPtr pChainContext;
	}

	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical(SecurityCriticalScope.Everything)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public static class UnsafeNativeMethods
	{
		[DllImport("clr")]
		public static extern int _AxlGetIssuerPublicKeyHash(IntPtr pCertContext, out SafeAxlBufferHandle ppwszPublicKeyHash);

		[DllImport("clr")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int CertFreeAuthenticodeSignerInfo(ref AXL_AUTHENTICODE_SIGNER_INFO pSignerInfo);

		[DllImport("clr")]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int CertFreeAuthenticodeTimestamperInfo(ref AXL_AUTHENTICODE_TIMESTAMPER_INFO pTimestamperInfo);

		[DllImport("clr")]
		public static extern int CertVerifyAuthenticodeLicense(ref CapiNative.CRYPTOAPI_BLOB pLicenseBlob, AxlVerificationFlags dwFlags, [In][Out] ref AXL_AUTHENTICODE_SIGNER_INFO pSignerInfo, [In][Out] ref AXL_AUTHENTICODE_TIMESTAMPER_INFO pTimestamperInfo);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CertGetCertificateContextProperty(SafeCertContextHandle pCertContext, CertificateProperty dwPropId, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pvData, [In][Out] ref int pcbData);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CertGetCertificateContextProperty(SafeCertContextHandle pCertContext, CertificateProperty dwPropId, out IntPtr pvData, [In][Out] ref int pcbData);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CertSetCertificateContextProperty(SafeCertContextHandle pCertContext, CertificateProperty dwPropId, CertSetPropertyFlags dwFlags, [In] ref CRYPT_KEY_PROV_INFO pvData);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CertSetCertificateContextProperty(SafeCertContextHandle pCertContext, CertificateProperty dwPropId, CertSetPropertyFlags dwFlags, [In] SafeNCryptKeyHandle pvData);

		[DllImport("crypt32.dll")]
		internal static extern SafeCertContextHandle CertDuplicateCertificateContext(IntPtr certContext);

		[DllImport("crypt32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CryptAcquireCertificatePrivateKey(SafeCertContextHandle pCert, AcquireCertificateKeyOptions dwFlags, IntPtr pvReserved, out SafeNCryptKeyHandle phCryptProvOrNCryptKey, out int dwKeySpec, [MarshalAs(UnmanagedType.Bool)] out bool pfCallerFreeProvOrNCryptKey);
	}

	internal const uint X509_ASN_ENCODING = 1u;

	internal const string szOID_ECC_PUBLIC_KEY = "1.2.840.10045.2.1";

	internal const int CRYPT_MACHINE_KEYSET = 32;

	[SecuritySafeCritical]
	internal static bool HasCertificateProperty(SafeCertContextHandle certificateContext, CertificateProperty property)
	{
		byte[] pvData = null;
		int pcbData = 0;
		if (!UnsafeNativeMethods.CertGetCertificateContextProperty(certificateContext, property, pvData, ref pcbData))
		{
			return Marshal.GetLastWin32Error() == 234;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal static SafeNCryptKeyHandle TryAcquireCngPrivateKey(SafeCertContextHandle certificateContext, out CngKeyHandleOpenOptions openOptions)
	{
		int pcbData = IntPtr.Size;
		if (UnsafeNativeMethods.CertGetCertificateContextProperty(certificateContext, CertificateProperty.NCryptKeyHandle, out var pvData, ref pcbData))
		{
			openOptions = CngKeyHandleOpenOptions.EphemeralKey;
			return new SafeNCryptKeyHandle(pvData, certificateContext);
		}
		openOptions = CngKeyHandleOpenOptions.None;
		bool pfCallerFreeProvOrNCryptKey = true;
		SafeNCryptKeyHandle phCryptProvOrNCryptKey = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			int dwKeySpec = 0;
			if (!UnsafeNativeMethods.CryptAcquireCertificatePrivateKey(certificateContext, AcquireCertificateKeyOptions.AcquireOnlyNCryptKeys, IntPtr.Zero, out phCryptProvOrNCryptKey, out dwKeySpec, out pfCallerFreeProvOrNCryptKey))
			{
				pfCallerFreeProvOrNCryptKey = false;
				phCryptProvOrNCryptKey?.SetHandleAsInvalid();
				return null;
			}
		}
		finally
		{
			if (!pfCallerFreeProvOrNCryptKey && phCryptProvOrNCryptKey != null && !phCryptProvOrNCryptKey.IsInvalid)
			{
				SafeNCryptKeyHandle safeNCryptKeyHandle = new SafeNCryptKeyHandle(phCryptProvOrNCryptKey.DangerousGetHandle(), certificateContext);
				phCryptProvOrNCryptKey.SetHandleAsInvalid();
				phCryptProvOrNCryptKey = safeNCryptKeyHandle;
				pfCallerFreeProvOrNCryptKey = true;
			}
		}
		return phCryptProvOrNCryptKey;
	}

	[SecuritySafeCritical]
	internal static byte[] GetCertificateProperty(SafeCertContextHandle certificateContext, CertificateProperty property)
	{
		byte[] pvData = null;
		int pcbData = 0;
		if (!UnsafeNativeMethods.CertGetCertificateContextProperty(certificateContext, property, pvData, ref pcbData))
		{
			ErrorCode lastWin32Error = (ErrorCode)Marshal.GetLastWin32Error();
			if (lastWin32Error != ErrorCode.MoreData)
			{
				throw new CryptographicException((int)lastWin32Error);
			}
		}
		pvData = new byte[pcbData];
		if (!UnsafeNativeMethods.CertGetCertificateContextProperty(certificateContext, property, pvData, ref pcbData))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return pvData;
	}

	[SecurityCritical]
	internal unsafe static T GetCertificateProperty<T>(SafeCertContextHandle certificateContext, CertificateProperty property) where T : struct
	{
		byte[] certificateProperty = GetCertificateProperty(certificateContext, property);
		fixed (byte* value = &certificateProperty[0])
		{
			return (T)Marshal.PtrToStructure(new IntPtr(value), typeof(T));
		}
	}

	[SecurityCritical]
	internal static bool SetCertificateKeyProvInfo(SafeCertContextHandle certificateContext, ref CRYPT_KEY_PROV_INFO provInfo)
	{
		return UnsafeNativeMethods.CertSetCertificateContextProperty(certificateContext, CertificateProperty.KeyProviderInfo, CertSetPropertyFlags.None, ref provInfo);
	}

	[SecurityCritical]
	internal static bool SetCertificateNCryptKeyHandle(SafeCertContextHandle certificateContext, SafeNCryptKeyHandle keyHandle)
	{
		return UnsafeNativeMethods.CertSetCertificateContextProperty(certificateContext, CertificateProperty.NCryptKeyHandle, CertSetPropertyFlags.CERT_SET_PROPERTY_INHIBIT_PERSIST_FLAG, keyHandle);
	}

	[SecuritySafeCritical]
	internal static SafeCertContextHandle DuplicateCertContext(IntPtr context)
	{
		return UnsafeNativeMethods.CertDuplicateCertificateContext(context);
	}

	[SecuritySafeCritical]
	internal static SafeCertContextHandle GetCertificateContext(X509Certificate certificate)
	{
		SafeCertContextHandle result = DuplicateCertContext(certificate.Handle);
		GC.KeepAlive(certificate);
		return result;
	}
}

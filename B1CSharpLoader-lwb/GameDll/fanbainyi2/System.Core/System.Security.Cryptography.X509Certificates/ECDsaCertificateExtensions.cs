using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

public static class ECDsaCertificateExtensions
{
	[SecuritySafeCritical]
	public static ECDsa GetECDsaPrivateKey(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!certificate.HasPrivateKey || !IsECDsa(certificate))
		{
			return null;
		}
		using SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(certificate);
		CngKeyHandleOpenOptions openOptions;
		using SafeNCryptKeyHandle keyHandle = X509Native.TryAcquireCngPrivateKey(certificateContext, out openOptions);
		CngKey key = CngKey.Open(keyHandle, openOptions);
		return new ECDsaCng(key);
	}

	[SecuritySafeCritical]
	private static SafeBCryptKeyHandle ImportPublicKeyInfo(SafeCertContextHandle certContext)
	{
		IntPtr ptr = certContext.DangerousGetHandle();
		IntPtr ptr2 = new IntPtr((long)((X509Native.CERT_CONTEXT)Marshal.PtrToStructure(ptr, typeof(X509Native.CERT_CONTEXT))).pCertInfo + (long)Marshal.OffsetOf(typeof(X509Native.CERT_INFO), "SubjectPublicKeyInfo"));
		X509Native.CERT_PUBLIC_KEY_INFO certPublicKeyInfo = (X509Native.CERT_PUBLIC_KEY_INFO)Marshal.PtrToStructure(ptr2, typeof(X509Native.CERT_PUBLIC_KEY_INFO));
		SafeBCryptKeyHandle result = BCryptNative.ImportAsymmetricPublicKey(certPublicKeyInfo, 0);
		GC.KeepAlive(certContext);
		return result;
	}

	[SecuritySafeCritical]
	public static ECDsa GetECDsaPublicKey(this X509Certificate2 certificate)
	{
		if (System.LocalAppContextSwitches.UseLegacyPublicKeyBehavior)
		{
			return LegacyGetECDsaPublicKey(certificate);
		}
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!IsECDsa(certificate))
		{
			return null;
		}
		using SafeCertContextHandle certContext = X509Native.GetCertificateContext(certificate);
		using SafeBCryptKeyHandle safeBCryptKeyHandle = ImportPublicKeyInfo(certContext);
		if (safeBCryptKeyHandle.IsInvalid)
		{
			throw new CryptographicException("SR.GetString(SR.Cryptography_OpenInvalidHandle)");
		}
		string curveName = GetCurveName(safeBCryptKeyHandle);
		if (curveName == null)
		{
			CngKeyBlobFormat cngKeyBlobFormat = (HasExplicitParameters(safeBCryptKeyHandle) ? CngKeyBlobFormat.EccFullPublicBlob : CngKeyBlobFormat.EccPublicBlob);
			byte[] keyBlob = BCryptNative.ExportBCryptKey(safeBCryptKeyHandle, cngKeyBlobFormat.Format);
			using CngKey key = CngKey.Import(keyBlob, cngKeyBlobFormat);
			return new ECDsaCng(key);
		}
		CngKeyBlobFormat eccPublicBlob = CngKeyBlobFormat.EccPublicBlob;
		byte[] ecBlob = BCryptNative.ExportBCryptKey(safeBCryptKeyHandle, eccPublicBlob.Format);
		ECParameters ecParams = default(ECParameters);
		ExportNamedCurveParameters(ref ecParams, ecBlob, includePrivateParameters: false);
		ecParams.Curve = ECCurve.CreateFromFriendlyName(curveName);
		ECDsaCng eCDsaCng = new ECDsaCng();
		eCDsaCng.ImportParameters(ecParams);
		return eCDsaCng;
	}

	[SecuritySafeCritical]
	private static ECDsa LegacyGetECDsaPublicKey(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!IsECDsa(certificate))
		{
			return null;
		}
		SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(certificate);
		IntPtr ptr = certificateContext.DangerousGetHandle();
		IntPtr ptr2 = new IntPtr((long)((X509Native.CERT_CONTEXT)Marshal.PtrToStructure(ptr, typeof(X509Native.CERT_CONTEXT))).pCertInfo + (long)Marshal.OffsetOf(typeof(X509Native.CERT_INFO), "SubjectPublicKeyInfo"));
		X509Native.CERT_PUBLIC_KEY_INFO certPublicKeyInfo = (X509Native.CERT_PUBLIC_KEY_INFO)Marshal.PtrToStructure(ptr2, typeof(X509Native.CERT_PUBLIC_KEY_INFO));
		CngKey key;
		using (SafeBCryptKeyHandle safeBCryptKeyHandle = BCryptNative.ImportAsymmetricPublicKey(certPublicKeyInfo, 0))
		{
			if (safeBCryptKeyHandle.IsInvalid)
			{
				throw new CryptographicException("SR.GetString(SR.Cryptography_OpenInvalidHandle)");
			}
			key = LegacyBCryptHandleToNCryptHandle(safeBCryptKeyHandle);
		}
		GC.KeepAlive(certificateContext);
		return new ECDsaCng(key);
	}

	[SecuritySafeCritical]
	public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, ECDsa privateKey)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (certificate.HasPrivateKey)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_Cert_AlreadyHasPrivateKey"));
		}
		using (ECDsa eCDsa = certificate.GetECDsaPublicKey())
		{
			if (eCDsa == null)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_WrongAlgorithm"));
			}
			if (!IsSameKey(eCDsa, privateKey))
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_DoesNotMatch"), "privateKey");
			}
		}
		ECDsaCng eCDsaCng = privateKey as ECDsaCng;
		X509Certificate2 x509Certificate = null;
		if (eCDsaCng != null)
		{
			x509Certificate = CertificateExtensionsCommon.CopyWithPersistedCngKey(certificate, eCDsaCng.Key);
		}
		if (x509Certificate == null)
		{
			ECParameters parameters = privateKey.ExportParameters(includePrivateParameters: true);
			using (PinAndClear.Track(parameters.D))
			{
				using (eCDsaCng = new ECDsaCng())
				{
					eCDsaCng.ImportParameters(parameters);
					x509Certificate = CertificateExtensionsCommon.CopyWithEphemeralCngKey(certificate, eCDsaCng.Key);
				}
			}
		}
		return x509Certificate;
	}

	private static bool IsSameKey(ECDsa a, ECDsa b)
	{
		ECParameters eCParameters = a.ExportParameters(includePrivateParameters: false);
		ECParameters eCParameters2 = b.ExportParameters(includePrivateParameters: false);
		if (eCParameters.Curve.CurveType != eCParameters2.Curve.CurveType)
		{
			return false;
		}
		if (!eCParameters.Q.X.SequenceEqual(eCParameters2.Q.X) || !eCParameters.Q.Y.SequenceEqual(eCParameters2.Q.Y))
		{
			return false;
		}
		ECCurve curve = eCParameters.Curve;
		ECCurve curve2 = eCParameters2.Curve;
		if (curve.IsNamed)
		{
			if (curve.Oid.Value == curve2.Oid.Value)
			{
				return curve.Oid.FriendlyName == curve2.Oid.FriendlyName;
			}
			return false;
		}
		if (!curve.IsExplicit)
		{
			return false;
		}
		if (!curve.G.X.SequenceEqual(curve2.G.X) || !curve.G.Y.SequenceEqual(curve2.G.Y) || !curve.Order.SequenceEqual(curve2.Order) || !curve.A.SequenceEqual(curve2.A) || !curve.B.SequenceEqual(curve2.B))
		{
			return false;
		}
		if (curve.IsPrime)
		{
			return curve.Prime.SequenceEqual(curve2.Prime);
		}
		if (curve.IsCharacteristic2)
		{
			return curve.Polynomial.SequenceEqual(curve2.Polynomial);
		}
		return false;
	}

	private static bool HasExplicitParameters(SafeBCryptKeyHandle bcryptHandle)
	{
		return HasProperty(bcryptHandle, "ECCParameters");
	}

	private static string GetCurveName(SafeBCryptKeyHandle bcryptHandle)
	{
		return GetPropertyAsString(bcryptHandle, "ECCCurveName");
	}

	[SecuritySafeCritical]
	private unsafe static string GetPropertyAsString(SafeBCryptKeyHandle cryptHandle, string propertyName)
	{
		byte[] property = GetProperty(cryptHandle, propertyName);
		if (property == null || property.Length == 0)
		{
			return null;
		}
		fixed (byte* ptr = &property[0])
		{
			return Marshal.PtrToStringUni((IntPtr)ptr);
		}
	}

	[SecuritySafeCritical]
	private unsafe static void ExportNamedCurveParameters(ref ECParameters ecParams, byte[] ecBlob, bool includePrivateParameters)
	{
		fixed (byte* ptr = &ecBlob[0])
		{
			global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB* ptr2 = (global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB*)ptr;
			int offset = sizeof(global::Interop.BCrypt.BCRYPT_ECCKEY_BLOB);
			ecParams.Q = new ECPoint
			{
				X = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey),
				Y = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey)
			};
			if (includePrivateParameters)
			{
				ecParams.D = global::Interop.BCrypt.Consume(ecBlob, ref offset, ptr2->cbKey);
			}
		}
	}

	[SecuritySafeCritical]
	private static byte[] GetProperty(SafeBCryptKeyHandle cryptHandle, string propertyName)
	{
		if (BCryptNative.UnsafeNativeMethods.BCryptGetProperty(cryptHandle, propertyName, null, 0, out var pcbResult, 0) != BCryptNative.ErrorCode.Success)
		{
			return null;
		}
		byte[] array = new byte[pcbResult];
		if (BCryptNative.UnsafeNativeMethods.BCryptGetProperty(cryptHandle, propertyName, array, array.Length, out pcbResult, 0) != BCryptNative.ErrorCode.Success)
		{
			return null;
		}
		Array.Resize(ref array, pcbResult);
		return array;
	}

	[SecuritySafeCritical]
	private static bool HasProperty(SafeBCryptKeyHandle cryptHandle, string propertyName)
	{
		if (BCryptNative.UnsafeNativeMethods.BCryptGetProperty(cryptHandle, propertyName, null, 0, out var pcbResult, 0) == BCryptNative.ErrorCode.Success)
		{
			return pcbResult > 0;
		}
		return false;
	}

	private static CngKey LegacyBCryptHandleToNCryptHandle(SafeBCryptKeyHandle bcryptKeyHandle)
	{
		byte[] keyBlob = BCryptNative.ExportBCryptKey(bcryptKeyHandle, "ECCPUBLICBLOB");
		return CngKey.Import(keyBlob, CngKeyBlobFormat.EccPublicBlob);
	}

	private static bool IsECDsa(X509Certificate2 certificate)
	{
		string friendlyName = certificate.PublicKey.Oid.FriendlyName;
		string value = certificate.PublicKey.Oid.Value;
		if (value != "1.2.840.10045.2.1")
		{
			return false;
		}
		X509ExtensionEnumerator enumerator = certificate.Extensions.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Extension current = enumerator.Current;
			if (current.Oid.Value == "2.5.29.15")
			{
				X509KeyUsageExtension x509KeyUsageExtension = (X509KeyUsageExtension)current;
				if (!x509KeyUsageExtension.KeyUsages.HasFlag(X509KeyUsageFlags.KeyAgreement))
				{
					return true;
				}
				if (x509KeyUsageExtension.KeyUsages.HasFlag(X509KeyUsageFlags.DigitalSignature) || x509KeyUsageExtension.KeyUsages.HasFlag(X509KeyUsageFlags.NonRepudiation) || x509KeyUsageExtension.KeyUsages.HasFlag(X509KeyUsageFlags.KeyCertSign) || x509KeyUsageExtension.KeyUsages.HasFlag(X509KeyUsageFlags.CrlSign))
				{
					return true;
				}
				return false;
			}
		}
		return true;
	}
}

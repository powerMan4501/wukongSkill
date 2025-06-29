using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

public static class RSACertificateExtensions
{
	[SecuritySafeCritical]
	public static RSA GetRSAPublicKey(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!IsRSA(certificate))
		{
			return null;
		}
		PublicKey publicKey = certificate.PublicKey;
		AsnEncodedData encodedKeyValue = publicKey.EncodedKeyValue;
		IntPtr pszStructType = new IntPtr(72L);
		if (!CapiNative.DecodeObject(pszStructType, encodedKeyValue.RawData, out var decodedValue, out var cbDecodedValue))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		byte[] array = new byte[cbDecodedValue];
		using (decodedValue)
		{
			Marshal.Copy(decodedValue.DangerousGetHandle(), array, 0, array.Length);
		}
		CngKey key = CngKey.Import(array, CngKeyBlobFormat.GenericPublicBlob);
		return new RSACng(key);
	}

	[SecuritySafeCritical]
	public static RSA GetRSAPrivateKey(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!certificate.HasPrivateKey || !IsRSA(certificate))
		{
			return null;
		}
		using SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(certificate);
		CngKeyHandleOpenOptions openOptions;
		using SafeNCryptKeyHandle safeNCryptKeyHandle = X509Native.TryAcquireCngPrivateKey(certificateContext, out openOptions);
		if (safeNCryptKeyHandle == null)
		{
			if (System.LocalAppContextSwitches.DontReliablyClonePrivateKey)
			{
				return (RSA)certificate.PrivateKey;
			}
			RSACryptoServiceProvider cspAlgorithm = (RSACryptoServiceProvider)certificate.PrivateKey;
			CspParameters parameters = DSACertificateExtensions.CopyCspParameters(cspAlgorithm);
			return new RSACryptoServiceProvider(parameters);
		}
		CngKey key = CngKey.Open(safeNCryptKeyHandle, openOptions);
		return new RSACng(key);
	}

	[SecuritySafeCritical]
	public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, RSA privateKey)
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
		using (RSA rSA = certificate.GetRSAPublicKey())
		{
			if (rSA == null)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_WrongAlgorithm"));
			}
			RSAParameters rSAParameters = rSA.ExportParameters(includePrivateParameters: false);
			RSAParameters rSAParameters2 = privateKey.ExportParameters(includePrivateParameters: false);
			if (!rSAParameters.Modulus.SequenceEqual(rSAParameters2.Modulus) || !rSAParameters.Exponent.SequenceEqual(rSAParameters2.Exponent))
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_DoesNotMatch"), "privateKey");
			}
		}
		RSACng rSACng = privateKey as RSACng;
		X509Certificate2 x509Certificate = null;
		if (rSACng != null)
		{
			x509Certificate = CertificateExtensionsCommon.CopyWithPersistedCngKey(certificate, rSACng.Key);
		}
		if (x509Certificate == null && privateKey is RSACryptoServiceProvider rSACryptoServiceProvider)
		{
			x509Certificate = CertificateExtensionsCommon.CopyWithPersistedCapiKey(certificate, rSACryptoServiceProvider.CspKeyContainerInfo);
		}
		if (x509Certificate == null)
		{
			RSAParameters parameters = privateKey.ExportParameters(includePrivateParameters: true);
			using (PinAndClear.Track(parameters.D))
			{
				using (PinAndClear.Track(parameters.P))
				{
					using (PinAndClear.Track(parameters.Q))
					{
						using (PinAndClear.Track(parameters.DP))
						{
							using (PinAndClear.Track(parameters.DQ))
							{
								using (PinAndClear.Track(parameters.InverseQ))
								{
									using (rSACng = new RSACng())
									{
										rSACng.ImportParameters(parameters);
										x509Certificate = CertificateExtensionsCommon.CopyWithEphemeralCngKey(certificate, rSACng.Key);
									}
								}
							}
						}
					}
				}
			}
		}
		return x509Certificate;
	}

	private static bool IsRSA(X509Certificate2 certificate)
	{
		uint num = OidToAlgorithmId(certificate.PublicKey.Oid);
		if (num == 9216 || num == 41984)
		{
			return true;
		}
		return false;
	}

	private static uint OidToAlgorithmId(Oid oid)
	{
		using System.Security.Cryptography.SafeLocalAllocHandle pvKey = X509Utils.StringToAnsiPtr(oid.Value);
		return CapiNative.CryptFindOIDInfo(1u, pvKey, System.Security.Cryptography.OidGroup.All).Algid;
	}
}

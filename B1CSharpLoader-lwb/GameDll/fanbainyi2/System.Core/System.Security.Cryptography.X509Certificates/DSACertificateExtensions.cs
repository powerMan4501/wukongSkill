using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

public static class DSACertificateExtensions
{
	[SecuritySafeCritical]
	public unsafe static DSA GetDSAPublicKey(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!IsDSA(certificate))
		{
			return null;
		}
		DSAParameters parameters = default(DSAParameters);
		System.Security.Cryptography.SafeLocalAllocHandle decodedValue = null;
		try
		{
			byte[] rawData = certificate.PublicKey.EncodedKeyValue.RawData;
			if (!CapiNative.DecodeObject((IntPtr)38L, rawData, out decodedValue, out var cbDecodedValue))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			if (cbDecodedValue < Marshal.SizeOf(typeof(CapiNative.CRYPTOAPI_BLOB)))
			{
				throw new CryptographicException();
			}
			CapiNative.CRYPTOAPI_BLOB* ptr = (CapiNative.CRYPTOAPI_BLOB*)(void*)decodedValue.DangerousGetHandle();
			parameters.Y = ToBigEndianByteArray(*ptr);
		}
		finally
		{
			if (decodedValue != null)
			{
				decodedValue.Dispose();
				decodedValue = null;
			}
		}
		System.Security.Cryptography.SafeLocalAllocHandle decodedValue2 = null;
		try
		{
			byte[] keyAlgorithmParameters = certificate.GetKeyAlgorithmParameters();
			if (!CapiNative.DecodeObject((IntPtr)39L, keyAlgorithmParameters, out decodedValue2, out var cbDecodedValue2))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			if (cbDecodedValue2 < Marshal.SizeOf(typeof(CapiNative.CERT_DSS_PARAMETERS)))
			{
				throw new CryptographicException();
			}
			CapiNative.CERT_DSS_PARAMETERS* ptr2 = (CapiNative.CERT_DSS_PARAMETERS*)(void*)decodedValue2.DangerousGetHandle();
			parameters.P = ToBigEndianByteArray(ptr2->p);
			parameters.Q = ToBigEndianByteArray(ptr2->q);
			parameters.G = ToBigEndianByteArray(ptr2->g);
		}
		finally
		{
			if (decodedValue2 != null)
			{
				decodedValue2.Dispose();
				decodedValue2 = null;
			}
		}
		DSACng dSACng = new DSACng();
		dSACng.ImportParameters(parameters);
		return dSACng;
	}

	[SecuritySafeCritical]
	public static DSA GetDSAPrivateKey(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!certificate.HasPrivateKey || !IsDSA(certificate))
		{
			return null;
		}
		using SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(certificate);
		CngKeyHandleOpenOptions openOptions;
		using SafeNCryptKeyHandle safeNCryptKeyHandle = X509Native.TryAcquireCngPrivateKey(certificateContext, out openOptions);
		if (safeNCryptKeyHandle == null)
		{
			DSACryptoServiceProvider cspAlgorithm = (DSACryptoServiceProvider)certificate.PrivateKey;
			CspParameters parameters = CopyCspParameters(cspAlgorithm);
			return new DSACryptoServiceProvider(parameters);
		}
		CngKey key = CngKey.Open(safeNCryptKeyHandle, openOptions);
		return new DSACng(key);
	}

	[SecuritySafeCritical]
	public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, DSA privateKey)
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
		using (DSA dSA = certificate.GetDSAPublicKey())
		{
			if (dSA == null)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_WrongAlgorithm"));
			}
			DSAParameters dSAParameters = dSA.ExportParameters(includePrivateParameters: false);
			DSAParameters dSAParameters2 = privateKey.ExportParameters(includePrivateParameters: false);
			if (!dSAParameters.G.SequenceEqual(dSAParameters2.G) || !dSAParameters.P.SequenceEqual(dSAParameters2.P) || !dSAParameters.Q.SequenceEqual(dSAParameters2.Q) || !dSAParameters.Y.SequenceEqual(dSAParameters2.Y))
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_PrivateKey_DoesNotMatch"), "privateKey");
			}
		}
		DSACng dSACng = privateKey as DSACng;
		X509Certificate2 x509Certificate = null;
		if (dSACng != null)
		{
			x509Certificate = CertificateExtensionsCommon.CopyWithPersistedCngKey(certificate, dSACng.Key);
		}
		if (x509Certificate == null && privateKey is DSACryptoServiceProvider dSACryptoServiceProvider)
		{
			x509Certificate = CertificateExtensionsCommon.CopyWithPersistedCapiKey(certificate, dSACryptoServiceProvider.CspKeyContainerInfo);
		}
		if (x509Certificate == null)
		{
			DSAParameters parameters = privateKey.ExportParameters(includePrivateParameters: true);
			using (PinAndClear.Track(parameters.X))
			{
				using (dSACng = new DSACng())
				{
					dSACng.ImportParameters(parameters);
					x509Certificate = CertificateExtensionsCommon.CopyWithEphemeralCngKey(certificate, dSACng.Key);
				}
			}
		}
		return x509Certificate;
	}

	private static bool IsDSA(X509Certificate2 certificate)
	{
		return certificate.PublicKey.Oid.Value == "1.2.840.10040.4.1";
	}

	internal static CspParameters CopyCspParameters(ICspAsymmetricAlgorithm cspAlgorithm)
	{
		CspKeyContainerInfo cspKeyContainerInfo = cspAlgorithm.CspKeyContainerInfo;
		CspParameters cspParameters = new CspParameters(cspKeyContainerInfo.ProviderType, cspKeyContainerInfo.ProviderName, cspKeyContainerInfo.KeyContainerName)
		{
			Flags = CspProviderFlags.UseExistingKey,
			KeyNumber = (int)cspKeyContainerInfo.KeyNumber
		};
		if (cspKeyContainerInfo.MachineKeyStore)
		{
			cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
		}
		return cspParameters;
	}

	[SecuritySafeCritical]
	private static byte[] ToBigEndianByteArray(CapiNative.CRYPTOAPI_BLOB blob)
	{
		int cbData = blob.cbData;
		byte[] array = new byte[cbData];
		Marshal.Copy(blob.pbData, array, 0, cbData);
		Array.Reverse(array);
		return array;
	}
}

using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal static class CertificateExtensionsCommon
{
	[SecurityCritical]
	internal static X509Certificate2 CopyWithPersistedCngKey(X509Certificate2 publicCert, CngKey cngKey)
	{
		if (string.IsNullOrEmpty(cngKey.KeyName))
		{
			return null;
		}
		X509Certificate2 x509Certificate = new X509Certificate2(publicCert.RawData);
		CngProvider provider = cngKey.Provider;
		string keyName = cngKey.KeyName;
		bool isMachineKey = cngKey.IsMachineKey;
		int dwKeySpec = GuessKeySpec(provider, keyName, isMachineKey, cngKey.AlgorithmGroup);
		X509Native.CRYPT_KEY_PROV_INFO provInfo = new X509Native.CRYPT_KEY_PROV_INFO
		{
			pwszContainerName = cngKey.KeyName,
			pwszProvName = cngKey.Provider.Provider,
			dwFlags = (isMachineKey ? 32 : 0),
			dwKeySpec = dwKeySpec
		};
		using SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(x509Certificate);
		if (!X509Native.SetCertificateKeyProvInfo(certificateContext, ref provInfo))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			x509Certificate.Dispose();
			throw new CryptographicException(lastWin32Error);
		}
		return x509Certificate;
	}

	[SecurityCritical]
	internal static X509Certificate2 CopyWithPersistedCapiKey(X509Certificate2 publicCert, CspKeyContainerInfo keyContainerInfo)
	{
		if (string.IsNullOrEmpty(keyContainerInfo.KeyContainerName))
		{
			return null;
		}
		X509Certificate2 x509Certificate = new X509Certificate2(publicCert.RawData);
		X509Native.CRYPT_KEY_PROV_INFO provInfo = new X509Native.CRYPT_KEY_PROV_INFO
		{
			pwszContainerName = keyContainerInfo.KeyContainerName,
			pwszProvName = keyContainerInfo.ProviderName,
			dwProvType = keyContainerInfo.ProviderType,
			dwKeySpec = (int)keyContainerInfo.KeyNumber,
			dwFlags = (keyContainerInfo.MachineKeyStore ? 32 : 0)
		};
		using SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(x509Certificate);
		if (!X509Native.SetCertificateKeyProvInfo(certificateContext, ref provInfo))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			x509Certificate.Dispose();
			throw new CryptographicException(lastWin32Error);
		}
		return x509Certificate;
	}

	[SecurityCritical]
	internal static X509Certificate2 CopyWithEphemeralCngKey(X509Certificate2 publicCert, CngKey cngKey)
	{
		X509Certificate2 x509Certificate = new X509Certificate2(publicCert.RawData);
		SafeNCryptKeyHandle handle = cngKey.Handle;
		using (SafeCertContextHandle certificateContext = X509Native.GetCertificateContext(x509Certificate))
		{
			if (!X509Native.SetCertificateNCryptKeyHandle(certificateContext, handle))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				x509Certificate.Dispose();
				throw new CryptographicException(lastWin32Error);
			}
		}
		handle.SetHandleAsInvalid();
		return x509Certificate;
	}

	private static int GuessKeySpec(CngProvider provider, string keyName, bool machineKey, CngAlgorithmGroup algorithmGroup)
	{
		if (provider == CngProvider.MicrosoftSoftwareKeyStorageProvider || provider == CngProvider.MicrosoftSmartCardKeyStorageProvider)
		{
			return 0;
		}
		try
		{
			CngKeyOpenOptions openOptions = (machineKey ? CngKeyOpenOptions.MachineKey : CngKeyOpenOptions.None);
			using (CngKey.Open(keyName, provider, openOptions))
			{
				return 0;
			}
		}
		catch (CryptographicException)
		{
			CspParameters cspParameters = new CspParameters
			{
				ProviderName = provider.Provider,
				KeyContainerName = keyName,
				Flags = CspProviderFlags.UseExistingKey,
				KeyNumber = 2
			};
			if (machineKey)
			{
				cspParameters.Flags |= CspProviderFlags.UseMachineKeyStore;
			}
			if (TryGuessKeySpec(cspParameters, algorithmGroup, out var keySpec))
			{
				return keySpec;
			}
			throw;
		}
	}

	private static bool TryGuessKeySpec(CspParameters cspParameters, CngAlgorithmGroup algorithmGroup, out int keySpec)
	{
		if (algorithmGroup == CngAlgorithmGroup.Rsa)
		{
			return TryGuessRsaKeySpec(cspParameters, out keySpec);
		}
		if (algorithmGroup == CngAlgorithmGroup.Dsa)
		{
			return TryGuessDsaKeySpec(cspParameters, out keySpec);
		}
		keySpec = 0;
		return false;
	}

	private static bool TryGuessRsaKeySpec(CspParameters cspParameters, out int keySpec)
	{
		int[] array = new int[4] { 1, 24, 12, 2 };
		int[] array2 = array;
		foreach (int providerType in array2)
		{
			cspParameters.ProviderType = providerType;
			try
			{
				using (new RSACryptoServiceProvider(cspParameters))
				{
					keySpec = cspParameters.KeyNumber;
					return true;
				}
			}
			catch (CryptographicException)
			{
			}
		}
		keySpec = 0;
		return false;
	}

	private static bool TryGuessDsaKeySpec(CspParameters cspParameters, out int keySpec)
	{
		int[] array = new int[2] { 13, 3 };
		int[] array2 = array;
		foreach (int providerType in array2)
		{
			cspParameters.ProviderType = providerType;
			try
			{
				using (new DSACryptoServiceProvider(cspParameters))
				{
					keySpec = cspParameters.KeyNumber;
					return true;
				}
			}
			catch (CryptographicException)
			{
			}
		}
		keySpec = 0;
		return false;
	}
}

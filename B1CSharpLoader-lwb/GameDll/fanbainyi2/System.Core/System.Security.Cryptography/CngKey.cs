using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class CngKey : IDisposable
{
	private SafeNCryptKeyHandle m_keyHandle;

	private SafeNCryptProviderHandle m_kspHandle;

	public CngAlgorithmGroup AlgorithmGroup
	{
		[SecuritySafeCritical]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Algorithm Group", CngPropertyOptions.None);
			if (propertyAsString == null)
			{
				return null;
			}
			return new CngAlgorithmGroup(propertyAsString);
		}
	}

	public CngAlgorithm Algorithm
	{
		[SecuritySafeCritical]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Algorithm Name", CngPropertyOptions.None);
			return new CngAlgorithm(propertyAsString);
		}
	}

	public CngExportPolicies ExportPolicy
	{
		[SecuritySafeCritical]
		get
		{
			return (CngExportPolicies)NCryptNative.GetPropertyAsDWord(m_keyHandle, "Export Policy", CngPropertyOptions.None);
		}
		internal set
		{
			CngProperty property = new CngProperty("Export Policy", BitConverter.GetBytes((int)value), CngPropertyOptions.Persist);
			SetProperty(property);
		}
	}

	public SafeNCryptKeyHandle Handle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		get
		{
			return m_keyHandle.Duplicate();
		}
	}

	public bool IsEphemeral
	{
		[SecuritySafeCritical]
		get
		{
			byte[] array = null;
			bool foundProperty;
			try
			{
				array = NCryptNative.GetProperty(m_keyHandle, "CLR IsEphemeral", CngPropertyOptions.CustomProperty, out foundProperty);
			}
			catch (CryptographicException)
			{
				return false;
			}
			if (foundProperty && array != null && array.Length == 1)
			{
				return array[0] == 1;
			}
			return false;
		}
		[SecurityCritical]
		private set
		{
			NCryptNative.SetProperty(m_keyHandle, "CLR IsEphemeral", new byte[1] { (byte)(value ? 1 : 0) }, CngPropertyOptions.CustomProperty);
		}
	}

	public bool IsMachineKey
	{
		[SecuritySafeCritical]
		get
		{
			int propertyAsDWord = NCryptNative.GetPropertyAsDWord(m_keyHandle, "Key Type", CngPropertyOptions.None);
			return (propertyAsDWord & 0x20) == 32;
		}
	}

	public string KeyName
	{
		[SecuritySafeCritical]
		get
		{
			if (IsEphemeral)
			{
				return null;
			}
			return NCryptNative.GetPropertyAsString(m_keyHandle, "Name", CngPropertyOptions.None);
		}
	}

	public int KeySize
	{
		[SecuritySafeCritical]
		get
		{
			int propertyValue = 0;
			if (NCryptNative.GetPropertyAsInt(m_keyHandle, "PublicKeyLength", CngPropertyOptions.None, ref propertyValue) == NCryptNative.ErrorCode.Success)
			{
				return propertyValue;
			}
			return NCryptNative.GetPropertyAsDWord(m_keyHandle, "Length", CngPropertyOptions.None);
		}
	}

	public CngKeyUsages KeyUsage
	{
		[SecuritySafeCritical]
		get
		{
			return (CngKeyUsages)NCryptNative.GetPropertyAsDWord(m_keyHandle, "Key Usage", CngPropertyOptions.None);
		}
	}

	public IntPtr ParentWindowHandle
	{
		[SecuritySafeCritical]
		get
		{
			return NCryptNative.GetPropertyAsIntPtr(m_keyHandle, "HWND Handle", CngPropertyOptions.None);
		}
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		set
		{
			NCryptNative.SetProperty(m_keyHandle, "HWND Handle", value, CngPropertyOptions.None);
		}
	}

	public CngProvider Provider
	{
		[SecuritySafeCritical]
		get
		{
			string propertyAsString = NCryptNative.GetPropertyAsString(m_kspHandle, "Name", CngPropertyOptions.None);
			if (propertyAsString == null)
			{
				return null;
			}
			return new CngProvider(propertyAsString);
		}
	}

	public SafeNCryptProviderHandle ProviderHandle
	{
		[SecurityCritical]
		[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
		get
		{
			return m_kspHandle.Duplicate();
		}
	}

	public string UniqueName
	{
		[SecuritySafeCritical]
		get
		{
			if (IsEphemeral)
			{
				return null;
			}
			return NCryptNative.GetPropertyAsString(m_keyHandle, "Unique Name", CngPropertyOptions.None);
		}
	}

	public CngUIPolicy UIPolicy
	{
		[SecuritySafeCritical]
		get
		{
			NCryptNative.NCRYPT_UI_POLICY propertyAsStruct = NCryptNative.GetPropertyAsStruct<NCryptNative.NCRYPT_UI_POLICY>(m_keyHandle, "UI Policy", CngPropertyOptions.None);
			string propertyAsString = NCryptNative.GetPropertyAsString(m_keyHandle, "Use Context", CngPropertyOptions.None);
			return new CngUIPolicy(propertyAsStruct.dwFlags, propertyAsStruct.pszFriendlyName, propertyAsStruct.pszDescription, propertyAsString, propertyAsStruct.pszCreationTitle);
		}
	}

	[SecurityCritical]
	private CngKey(SafeNCryptProviderHandle kspHandle, SafeNCryptKeyHandle keyHandle)
	{
		m_keyHandle = keyHandle;
		m_kspHandle = kspHandle;
	}

	[SecuritySafeCritical]
	internal KeyContainerPermission BuildKeyContainerPermission(KeyContainerPermissionFlags flags)
	{
		KeyContainerPermission keyContainerPermission = null;
		if (!IsEphemeral)
		{
			string text = null;
			string providerName = null;
			try
			{
				text = KeyName;
				providerName = NCryptNative.GetPropertyAsString(m_kspHandle, "Name", CngPropertyOptions.None);
			}
			catch (CryptographicException)
			{
			}
			if (text != null)
			{
				KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = new KeyContainerPermissionAccessEntry(text, flags);
				keyContainerPermissionAccessEntry.ProviderName = providerName;
				keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
				keyContainerPermission.AccessEntries.Add(keyContainerPermissionAccessEntry);
			}
			else
			{
				keyContainerPermission = new KeyContainerPermission(flags);
			}
		}
		return keyContainerPermission;
	}

	public static CngKey Create(CngAlgorithm algorithm)
	{
		return Create(algorithm, null);
	}

	public static CngKey Create(CngAlgorithm algorithm, string keyName)
	{
		return Create(algorithm, keyName, null);
	}

	[SecuritySafeCritical]
	public static CngKey Create(CngAlgorithm algorithm, string keyName, CngKeyCreationParameters creationParameters)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (creationParameters == null)
		{
			creationParameters = new CngKeyCreationParameters();
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		if (keyName != null)
		{
			KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = new KeyContainerPermissionAccessEntry(keyName, KeyContainerPermissionFlags.Create);
			keyContainerPermissionAccessEntry.ProviderName = creationParameters.Provider.Provider;
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			keyContainerPermission.AccessEntries.Add(keyContainerPermissionAccessEntry);
			keyContainerPermission.Demand();
		}
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(creationParameters.Provider.Provider);
		SafeNCryptKeyHandle safeNCryptKeyHandle = NCryptNative.CreatePersistedKey(safeNCryptProviderHandle, algorithm.Algorithm, keyName, creationParameters.KeyCreationOptions);
		SetKeyProperties(safeNCryptKeyHandle, creationParameters);
		NCryptNative.FinalizeKey(safeNCryptKeyHandle);
		CngKey cngKey = new CngKey(safeNCryptProviderHandle, safeNCryptKeyHandle);
		if (keyName == null)
		{
			cngKey.IsEphemeral = true;
		}
		return cngKey;
	}

	[SecuritySafeCritical]
	public void Delete()
	{
		BuildKeyContainerPermission(KeyContainerPermissionFlags.Delete)?.Demand();
		NCryptNative.DeleteKey(m_keyHandle);
		Dispose();
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		if (m_kspHandle != null)
		{
			m_kspHandle.Dispose();
		}
		if (m_keyHandle != null)
		{
			m_keyHandle.Dispose();
		}
	}

	public static bool Exists(string keyName)
	{
		return Exists(keyName, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	public static bool Exists(string keyName, CngProvider provider)
	{
		return Exists(keyName, provider, CngKeyOpenOptions.None);
	}

	[SecuritySafeCritical]
	public static bool Exists(string keyName, CngProvider provider, CngKeyOpenOptions options)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		using SafeNCryptProviderHandle hProvider = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle phKey = null;
		try
		{
			NCryptNative.ErrorCode errorCode = NCryptNative.UnsafeNativeMethods.NCryptOpenKey(hProvider, out phKey, keyName, 0, options);
			bool flag = errorCode == NCryptNative.ErrorCode.KeyDoesNotExist || errorCode == NCryptNative.ErrorCode.NotFound;
			if (errorCode != NCryptNative.ErrorCode.Success && !flag)
			{
				throw new CryptographicException((int)errorCode);
			}
			return errorCode == NCryptNative.ErrorCode.Success;
		}
		finally
		{
			phKey?.Dispose();
		}
	}

	public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format)
	{
		return Import(keyBlob, format, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	internal static CngKey Import(byte[] keyBlob, string curveName, CngKeyBlobFormat format)
	{
		return Import(keyBlob, curveName, format, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	public static CngKey Import(byte[] keyBlob, CngKeyBlobFormat format, CngProvider provider)
	{
		return Import(keyBlob, null, format, provider);
	}

	[SecuritySafeCritical]
	internal static CngKey Import(byte[] keyBlob, string curveName, CngKeyBlobFormat format, CngProvider provider)
	{
		if (keyBlob == null)
		{
			throw new ArgumentNullException("keyBlob");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		if (!(format == CngKeyBlobFormat.EccPublicBlob) && !(format == CngKeyBlobFormat.EccFullPublicBlob) && !(format == CngKeyBlobFormat.GenericPublicBlob))
		{
			new KeyContainerPermission(KeyContainerPermissionFlags.Import).Demand();
		}
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle keyHandle = ((curveName != null) ? ECCng.ImportKeyBlob(format.Format, keyBlob, curveName, safeNCryptProviderHandle) : NCryptNative.ImportKey(safeNCryptProviderHandle, keyBlob, format.Format));
		CngKey cngKey = new CngKey(safeNCryptProviderHandle, keyHandle);
		cngKey.IsEphemeral = format != CngKeyBlobFormat.OpaqueTransportBlob;
		return cngKey;
	}

	[SecuritySafeCritical]
	public byte[] Export(CngKeyBlobFormat format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		BuildKeyContainerPermission(KeyContainerPermissionFlags.Export)?.Demand();
		return NCryptNative.ExportKey(m_keyHandle, format.Format);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public CngProperty GetProperty(string name, CngPropertyOptions options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		bool foundProperty;
		byte[] property = NCryptNative.GetProperty(m_keyHandle, name, options, out foundProperty);
		if (!foundProperty)
		{
			throw new CryptographicException(-2146893807);
		}
		return new CngProperty(name, property, options);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public bool HasProperty(string name, CngPropertyOptions options)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		NCryptNative.GetProperty(m_keyHandle, name, options, out var foundProperty);
		return foundProperty;
	}

	public static CngKey Open(string keyName)
	{
		return Open(keyName, CngProvider.MicrosoftSoftwareKeyStorageProvider);
	}

	public static CngKey Open(string keyName, CngProvider provider)
	{
		return Open(keyName, provider, CngKeyOpenOptions.None);
	}

	[SecuritySafeCritical]
	public static CngKey Open(string keyName, CngProvider provider, CngKeyOpenOptions openOptions)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		KeyContainerPermissionAccessEntry keyContainerPermissionAccessEntry = new KeyContainerPermissionAccessEntry(keyName, KeyContainerPermissionFlags.Open);
		keyContainerPermissionAccessEntry.ProviderName = provider.Provider;
		KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
		keyContainerPermission.AccessEntries.Add(keyContainerPermissionAccessEntry);
		keyContainerPermission.Demand();
		SafeNCryptProviderHandle safeNCryptProviderHandle = NCryptNative.OpenStorageProvider(provider.Provider);
		SafeNCryptKeyHandle keyHandle = NCryptNative.OpenKey(safeNCryptProviderHandle, keyName, openOptions);
		return new CngKey(safeNCryptProviderHandle, keyHandle);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public static CngKey Open(SafeNCryptKeyHandle keyHandle, CngKeyHandleOpenOptions keyHandleOpenOptions)
	{
		if (keyHandle == null)
		{
			throw new ArgumentNullException("keyHandle");
		}
		if (keyHandle.IsClosed || keyHandle.IsInvalid)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_OpenInvalidHandle"), "keyHandle");
		}
		SafeNCryptKeyHandle keyHandle2 = keyHandle.Duplicate();
		SafeNCryptProviderHandle safeNCryptProviderHandle = new SafeNCryptProviderHandle();
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			IntPtr propertyAsIntPtr = NCryptNative.GetPropertyAsIntPtr(keyHandle, "Provider Handle", CngPropertyOptions.None);
			safeNCryptProviderHandle.SetHandleValue(propertyAsIntPtr);
		}
		CngKey cngKey = null;
		bool flag = false;
		try
		{
			cngKey = new CngKey(safeNCryptProviderHandle, keyHandle2);
			bool flag2 = (keyHandleOpenOptions & CngKeyHandleOpenOptions.EphemeralKey) == CngKeyHandleOpenOptions.EphemeralKey;
			if (!cngKey.IsEphemeral && flag2)
			{
				cngKey.IsEphemeral = true;
			}
			else if (cngKey.IsEphemeral && !flag2)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_OpenEphemeralKeyHandleWithoutEphemeralFlag"), "keyHandleOpenOptions");
			}
			flag = true;
		}
		finally
		{
			if (!flag)
			{
				cngKey?.Dispose();
			}
		}
		return cngKey;
	}

	[SecurityCritical]
	private static void SetKeyProperties(SafeNCryptKeyHandle keyHandle, CngKeyCreationParameters creationParameters)
	{
		if (creationParameters.ExportPolicy.HasValue)
		{
			NCryptNative.SetProperty(keyHandle, "Export Policy", (int)creationParameters.ExportPolicy.Value, CngPropertyOptions.Persist);
		}
		if (creationParameters.KeyUsage.HasValue)
		{
			NCryptNative.SetProperty(keyHandle, "Key Usage", (int)creationParameters.KeyUsage.Value, CngPropertyOptions.Persist);
		}
		if (creationParameters.ParentWindowHandle != IntPtr.Zero)
		{
			NCryptNative.SetProperty(keyHandle, "HWND Handle", creationParameters.ParentWindowHandle, CngPropertyOptions.None);
		}
		if (creationParameters.UIPolicy != null)
		{
			NCryptNative.SetProperty(keyHandle, "UI Policy", new NCryptNative.NCRYPT_UI_POLICY
			{
				dwVersion = 1,
				dwFlags = creationParameters.UIPolicy.ProtectionLevel,
				pszCreationTitle = creationParameters.UIPolicy.CreationTitle,
				pszFriendlyName = creationParameters.UIPolicy.FriendlyName,
				pszDescription = creationParameters.UIPolicy.Description
			}, CngPropertyOptions.Persist);
			if (creationParameters.UIPolicy.UseContext != null)
			{
				NCryptNative.SetProperty(keyHandle, "Use Context", creationParameters.UIPolicy.UseContext, CngPropertyOptions.Persist);
			}
		}
		foreach (CngProperty item in creationParameters.ParametersNoDemand)
		{
			NCryptNative.SetProperty(keyHandle, item.Name, item.Value, item.Options);
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public void SetProperty(CngProperty property)
	{
		NCryptNative.SetProperty(m_keyHandle, property.Name, property.Value, property.Options);
	}

	internal bool IsECNamedCurve()
	{
		return IsECNamedCurve(Algorithm.Algorithm);
	}

	internal static bool IsECNamedCurve(string algorithm)
	{
		if (!(algorithm == CngAlgorithm.ECDiffieHellman.Algorithm))
		{
			return algorithm == CngAlgorithm.ECDsa.Algorithm;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal string GetCurveName()
	{
		if (IsECNamedCurve())
		{
			return NCryptNative.GetPropertyAsString(m_keyHandle, "ECCCurveName", CngPropertyOptions.None);
		}
		return GetECSpecificCurveName();
	}

	private string GetECSpecificCurveName()
	{
		string algorithm = Algorithm.Algorithm;
		if (algorithm == CngAlgorithm.ECDiffieHellmanP256.Algorithm || algorithm == CngAlgorithm.ECDsaP256.Algorithm)
		{
			return "nistP256";
		}
		if (algorithm == CngAlgorithm.ECDiffieHellmanP384.Algorithm || algorithm == CngAlgorithm.ECDsaP384.Algorithm)
		{
			return "nistP384";
		}
		if (algorithm == CngAlgorithm.ECDiffieHellmanP521.Algorithm || algorithm == CngAlgorithm.ECDsaP521.Algorithm)
		{
			return "nistP521";
		}
		throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", algorithm));
	}

	internal static CngProperty GetPropertyFromNamedCurve(ECCurve curve)
	{
		string text = curve.Oid.FriendlyName ?? "";
		byte[] array = new byte[(text.Length + 1) * 2];
		Encoding.Unicode.GetBytes(text, 0, text.Length, array, 0);
		return new CngProperty("ECCCurveName", array, CngPropertyOptions.None);
	}

	internal static CngAlgorithm EcdsaCurveNameToAlgorithm(string name)
	{
		switch (name)
		{
		case "nistP256":
		case "ECDSA_P256":
			return CngAlgorithm.ECDsaP256;
		case "nistP384":
		case "ECDSA_P384":
			return CngAlgorithm.ECDsaP384;
		case "nistP521":
		case "ECDSA_P521":
			return CngAlgorithm.ECDsaP521;
		default:
			return CngAlgorithm.ECDsa;
		}
	}

	internal static CngAlgorithm EcdhCurveNameToAlgorithm(string name)
	{
		switch (name)
		{
		case "nistP256":
		case "ECDH_P256":
			return CngAlgorithm.ECDiffieHellmanP256;
		case "nistP384":
		case "ECDH_P384":
			return CngAlgorithm.ECDiffieHellmanP384;
		case "nistP521":
		case "ECDH_P521":
			return CngAlgorithm.ECDiffieHellmanP521;
		default:
			return CngAlgorithm.ECDiffieHellman;
		}
	}

	internal static CngKey Create(ECCurve curve, Func<string, CngAlgorithm> algorithmResolver)
	{
		curve.Validate();
		CngKeyCreationParameters cngKeyCreationParameters = new CngKeyCreationParameters
		{
			ExportPolicy = CngExportPolicies.AllowPlaintextExport
		};
		CngAlgorithm cngAlgorithm;
		if (curve.IsNamed)
		{
			cngAlgorithm = algorithmResolver(curve.Oid.FriendlyName);
			if (IsECNamedCurve(cngAlgorithm.Algorithm))
			{
				cngKeyCreationParameters.Parameters.Add(GetPropertyFromNamedCurve(curve));
			}
			else if (!(cngAlgorithm == CngAlgorithm.ECDsaP256) && !(cngAlgorithm == CngAlgorithm.ECDiffieHellmanP256) && !(cngAlgorithm == CngAlgorithm.ECDsaP384) && !(cngAlgorithm == CngAlgorithm.ECDiffieHellmanP384) && !(cngAlgorithm == CngAlgorithm.ECDsaP521) && !(cngAlgorithm == CngAlgorithm.ECDiffieHellmanP521))
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_InvalidKeySize"));
			}
		}
		else
		{
			if (!curve.IsPrime)
			{
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", curve.CurveType.ToString()));
			}
			byte[] primeCurveParameterBlob = ECCng.GetPrimeCurveParameterBlob(ref curve);
			CngProperty item = new CngProperty("ECCParameters", primeCurveParameterBlob, CngPropertyOptions.None);
			cngKeyCreationParameters.Parameters.Add(item);
			cngAlgorithm = algorithmResolver(null);
		}
		try
		{
			return Create(cngAlgorithm, null, cngKeyCreationParameters);
		}
		catch (CryptographicException ex)
		{
			global::Interop.NCrypt.ErrorCode hResult = (global::Interop.NCrypt.ErrorCode)ex.HResult;
			if (hResult == global::Interop.NCrypt.ErrorCode.NTE_INVALID_PARAMETER || hResult == global::Interop.NCrypt.ErrorCode.NTE_NOT_SUPPORTED)
			{
				string text = (curve.IsNamed ? curve.Oid.FriendlyName : curve.CurveType.ToString());
				throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_CurveNotSupported", text), ex);
			}
			throw;
		}
	}
}

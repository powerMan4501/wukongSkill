using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;

namespace System.Security.Cryptography.X509Certificates;

public class X509Certificate2Collection : X509CertificateCollection
{
	internal delegate int FindProcDelegate(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData);

	private delegate void EnforceIterationCountLimitDelegate(byte[] pkcs12, bool readingFromFile, bool passwordProvided);

	private const uint X509_STORE_CONTENT_FLAGS = 5938u;

	private static EnforceIterationCountLimitDelegate s_enforceIterationCountLimitDelegate;

	private static volatile bool s_enforceIterationCountLimitMethodInitialized;

	public new X509Certificate2 this[int index]
	{
		get
		{
			return (X509Certificate2)base.List[index];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			base.List[index] = value;
		}
	}

	public X509Certificate2Collection()
	{
	}

	public X509Certificate2Collection(X509Certificate2 certificate)
	{
		Add(certificate);
	}

	public X509Certificate2Collection(X509Certificate2Collection certificates)
	{
		AddRange(certificates);
	}

	public X509Certificate2Collection(X509Certificate2[] certificates)
	{
		AddRange(certificates);
	}

	public int Add(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return base.List.Add(certificate);
	}

	public void AddRange(X509Certificate2[] certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int i = 0;
		try
		{
			for (; i < certificates.Length; i++)
			{
				Add(certificates[i]);
			}
		}
		catch
		{
			for (int j = 0; j < i; j++)
			{
				Remove(certificates[j]);
			}
			throw;
		}
	}

	public void AddRange(X509Certificate2Collection certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int num = 0;
		try
		{
			X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				Add(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Remove(certificates[i]);
			}
			throw;
		}
	}

	public bool Contains(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return base.List.Contains(certificate);
	}

	public void Insert(int index, X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		base.List.Insert(index, certificate);
	}

	public new X509Certificate2Enumerator GetEnumerator()
	{
		return new X509Certificate2Enumerator(this);
	}

	public void Remove(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		base.List.Remove(certificate);
	}

	public void RemoveRange(X509Certificate2[] certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int i = 0;
		try
		{
			for (; i < certificates.Length; i++)
			{
				Remove(certificates[i]);
			}
		}
		catch
		{
			for (int j = 0; j < i; j++)
			{
				Add(certificates[j]);
			}
			throw;
		}
	}

	public void RemoveRange(X509Certificate2Collection certificates)
	{
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		int num = 0;
		try
		{
			X509Certificate2Enumerator enumerator = certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				Remove(current);
				num++;
			}
		}
		catch
		{
			for (int i = 0; i < num; i++)
			{
				Add(certificates[i]);
			}
			throw;
		}
	}

	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
	{
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AllFlags);
		storePermission.Assert();
		System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle = X509Utils.ExportToMemoryStore(this);
		System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle2 = FindCertInStore(safeCertStoreHandle, findType, findValue, validOnly);
		X509Certificate2Collection certificates = X509Utils.GetCertificates(safeCertStoreHandle2);
		safeCertStoreHandle2.Dispose();
		safeCertStoreHandle.Dispose();
		return certificates;
	}

	public void Import(byte[] rawData)
	{
		ImportFromBlob(rawData, null, X509KeyStorageFlags.DefaultKeySet, passwordProvided: false);
	}

	public void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
	{
		ImportFromBlob(rawData, password, keyStorageFlags, passwordProvided: true);
	}

	private void ImportFromBlob(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool passwordProvided)
	{
		uint dwFlags = X509Utils.MapKeyStorageFlags(keyStorageFlags);
		System.Security.Cryptography.SafeCertStoreHandle invalidHandle = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AllFlags);
		storePermission.Assert();
		invalidHandle = LoadStoreFromBlob(rawData, password, dwFlags, (keyStorageFlags & X509KeyStorageFlags.PersistKeySet) != 0, passwordProvided);
		X509Certificate2Collection certificates = X509Utils.GetCertificates(invalidHandle);
		invalidHandle.Dispose();
		X509Certificate2[] array = new X509Certificate2[certificates.Count];
		X509Certificate[] array2 = array;
		certificates.CopyTo(array2, 0);
		AddRange(array);
	}

	public void Import(string fileName)
	{
		Import(fileName, null, X509KeyStorageFlags.DefaultKeySet);
	}

	public void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
	{
		uint dwFlags = X509Utils.MapKeyStorageFlags(keyStorageFlags);
		System.Security.Cryptography.SafeCertStoreHandle invalidHandle = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AllFlags);
		storePermission.Assert();
		invalidHandle = LoadStoreFromFile(fileName, password, dwFlags, (keyStorageFlags & X509KeyStorageFlags.PersistKeySet) != 0);
		X509Certificate2Collection certificates = X509Utils.GetCertificates(invalidHandle);
		invalidHandle.Dispose();
		X509Certificate2[] array = new X509Certificate2[certificates.Count];
		X509Certificate[] array2 = array;
		certificates.CopyTo(array2, 0);
		AddRange(array);
	}

	public byte[] Export(X509ContentType contentType)
	{
		return Export(contentType, null);
	}

	public byte[] Export(X509ContentType contentType, string password)
	{
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AllFlags);
		storePermission.Assert();
		System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle = X509Utils.ExportToMemoryStore(this);
		byte[] result = ExportCertificatesToBlob(safeCertStoreHandle, contentType, password);
		safeCertStoreHandle.Dispose();
		return result;
	}

	private unsafe static byte[] ExportCertificatesToBlob(System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle, X509ContentType contentType, string password)
	{
		System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle = System.Security.Cryptography.SafeCertContextHandle.InvalidHandle;
		uint dwSaveAs = 2u;
		byte[] array = null;
		CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CAPIBase.CRYPTOAPI_BLOB);
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		switch (contentType)
		{
		case X509ContentType.Cert:
			safeCertContextHandle = CAPI.CertEnumCertificatesInStore(safeCertStoreHandle, safeCertContextHandle);
			if (safeCertContextHandle != null && !safeCertContextHandle.IsInvalid)
			{
				CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
				array = new byte[cERT_CONTEXT.cbCertEncoded];
				Marshal.Copy(cERT_CONTEXT.pbCertEncoded, array, 0, array.Length);
			}
			break;
		case X509ContentType.SerializedCert:
		{
			safeCertContextHandle = CAPI.CertEnumCertificatesInStore(safeCertStoreHandle, safeCertContextHandle);
			uint num = 0u;
			if (safeCertContextHandle != null && !safeCertContextHandle.IsInvalid)
			{
				if (!CAPISafe.CertSerializeCertificateStoreElement(safeCertContextHandle, 0u, safeLocalAllocHandle, new IntPtr(&num)))
				{
					throw new CryptographicException(Marshal.GetLastWin32Error());
				}
				safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(num));
				if (!CAPISafe.CertSerializeCertificateStoreElement(safeCertContextHandle, 0u, safeLocalAllocHandle, new IntPtr(&num)))
				{
					throw new CryptographicException(Marshal.GetLastWin32Error());
				}
				array = new byte[num];
				Marshal.Copy(safeLocalAllocHandle.DangerousGetHandle(), array, 0, array.Length);
			}
			break;
		}
		case X509ContentType.Pfx:
			if (!CAPI.PFXExportCertStore(safeCertStoreHandle, new IntPtr(&cRYPTOAPI_BLOB), password, 6u))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(cRYPTOAPI_BLOB.cbData));
			cRYPTOAPI_BLOB.pbData = safeLocalAllocHandle.DangerousGetHandle();
			if (!CAPI.PFXExportCertStore(safeCertStoreHandle, new IntPtr(&cRYPTOAPI_BLOB), password, 6u))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			array = new byte[cRYPTOAPI_BLOB.cbData];
			Marshal.Copy(cRYPTOAPI_BLOB.pbData, array, 0, array.Length);
			break;
		case X509ContentType.SerializedStore:
			dwSaveAs = 1u;
			goto case X509ContentType.Pkcs7;
		case X509ContentType.Pkcs7:
			if (!CAPI.CertSaveStore(safeCertStoreHandle, 65537u, dwSaveAs, 2u, new IntPtr(&cRYPTOAPI_BLOB), 0u))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(cRYPTOAPI_BLOB.cbData));
			cRYPTOAPI_BLOB.pbData = safeLocalAllocHandle.DangerousGetHandle();
			if (!CAPI.CertSaveStore(safeCertStoreHandle, 65537u, dwSaveAs, 2u, new IntPtr(&cRYPTOAPI_BLOB), 0u))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
			array = new byte[cRYPTOAPI_BLOB.cbData];
			Marshal.Copy(cRYPTOAPI_BLOB.pbData, array, 0, array.Length);
			break;
		default:
			throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidContentType"));
		}
		safeLocalAllocHandle.Dispose();
		safeCertContextHandle.Dispose();
		return array;
	}

	private unsafe static System.Security.Cryptography.SafeCertStoreHandle FindCertInStore(System.Security.Cryptography.SafeCertStoreHandle safeSourceStoreHandle, X509FindType findType, object findValue, bool validOnly)
	{
		if (findValue == null)
		{
			throw new ArgumentNullException("findValue");
		}
		IntPtr pvFindPara = IntPtr.Zero;
		object obj = null;
		object pvCallbackData = null;
		FindProcDelegate pfnCertCallback = null;
		FindProcDelegate pfnCertCallback2 = null;
		uint dwFindType = 0u;
		CAPIBase.CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CAPIBase.CRYPTOAPI_BLOB);
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		System.Runtime.InteropServices.ComTypes.FILETIME fILETIME = default(System.Runtime.InteropServices.ComTypes.FILETIME);
		string text = null;
		switch (findType)
		{
		case X509FindType.FindByThumbprint:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			byte[] array2 = X509Utils.DecodeHexString((string)findValue);
			safeLocalAllocHandle = X509Utils.ByteToPtr(array2);
			cRYPTOAPI_BLOB.pbData = safeLocalAllocHandle.DangerousGetHandle();
			cRYPTOAPI_BLOB.cbData = (uint)array2.Length;
			dwFindType = 65536u;
			pvFindPara = new IntPtr(&cRYPTOAPI_BLOB);
			break;
		}
		case X509FindType.FindBySubjectName:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			string text2 = (string)findValue;
			dwFindType = 524295u;
			safeLocalAllocHandle = X509Utils.StringToUniPtr(text2);
			pvFindPara = safeLocalAllocHandle.DangerousGetHandle();
			break;
		}
		case X509FindType.FindBySubjectDistinguishedName:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			string text2 = (string)findValue;
			pfnCertCallback = FindSubjectDistinguishedNameCallback;
			obj = text2;
			break;
		}
		case X509FindType.FindByIssuerName:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			string s = (string)findValue;
			dwFindType = 524292u;
			safeLocalAllocHandle = X509Utils.StringToUniPtr(s);
			pvFindPara = safeLocalAllocHandle.DangerousGetHandle();
			break;
		}
		case X509FindType.FindByIssuerDistinguishedName:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			string s = (string)findValue;
			pfnCertCallback = FindIssuerDistinguishedNameCallback;
			obj = s;
			break;
		}
		case X509FindType.FindBySerialNumber:
		{
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			pfnCertCallback = FindSerialNumberCallback;
			pfnCertCallback2 = FindSerialNumberCallback;
			BigInt bigInt = new BigInt();
			bigInt.FromHexadecimal((string)findValue);
			obj = bigInt.ToByteArray();
			bigInt.FromDecimal((string)findValue);
			pvCallbackData = bigInt.ToByteArray();
			break;
		}
		case X509FindType.FindByTimeValid:
			if (findValue.GetType() != typeof(DateTime))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			*(long*)(&fILETIME) = ((DateTime)findValue).ToFileTime();
			pfnCertCallback = FindTimeValidCallback;
			obj = fILETIME;
			break;
		case X509FindType.FindByTimeNotYetValid:
			if (findValue.GetType() != typeof(DateTime))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			*(long*)(&fILETIME) = ((DateTime)findValue).ToFileTime();
			pfnCertCallback = FindTimeNotBeforeCallback;
			obj = fILETIME;
			break;
		case X509FindType.FindByTimeExpired:
			if (findValue.GetType() != typeof(DateTime))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			*(long*)(&fILETIME) = ((DateTime)findValue).ToFileTime();
			pfnCertCallback = FindTimeNotAfterCallback;
			obj = fILETIME;
			break;
		case X509FindType.FindByTemplateName:
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			obj = (string)findValue;
			pfnCertCallback = FindTemplateNameCallback;
			break;
		case X509FindType.FindByApplicationPolicy:
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			text = X509Utils.FindOidInfoWithFallback(2u, (string)findValue, System.Security.Cryptography.OidGroup.Policy);
			if (text == null)
			{
				text = (string)findValue;
				X509Utils.ValidateOidValue(text);
			}
			obj = text;
			pfnCertCallback = FindApplicationPolicyCallback;
			break;
		case X509FindType.FindByCertificatePolicy:
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			text = X509Utils.FindOidInfoWithFallback(2u, (string)findValue, System.Security.Cryptography.OidGroup.Policy);
			if (text == null)
			{
				text = (string)findValue;
				X509Utils.ValidateOidValue(text);
			}
			obj = text;
			pfnCertCallback = FindCertificatePolicyCallback;
			break;
		case X509FindType.FindByExtension:
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			text = X509Utils.FindOidInfoWithFallback(2u, (string)findValue, System.Security.Cryptography.OidGroup.ExtensionOrAttribute);
			if (text == null)
			{
				text = (string)findValue;
				X509Utils.ValidateOidValue(text);
			}
			obj = text;
			pfnCertCallback = FindExtensionCallback;
			break;
		case X509FindType.FindByKeyUsage:
			if (findValue.GetType() == typeof(string))
			{
				CAPIBase.KEY_USAGE_STRUCT[] array = new CAPIBase.KEY_USAGE_STRUCT[9]
				{
					new CAPIBase.KEY_USAGE_STRUCT("DigitalSignature", 128u),
					new CAPIBase.KEY_USAGE_STRUCT("NonRepudiation", 64u),
					new CAPIBase.KEY_USAGE_STRUCT("KeyEncipherment", 32u),
					new CAPIBase.KEY_USAGE_STRUCT("DataEncipherment", 16u),
					new CAPIBase.KEY_USAGE_STRUCT("KeyAgreement", 8u),
					new CAPIBase.KEY_USAGE_STRUCT("KeyCertSign", 4u),
					new CAPIBase.KEY_USAGE_STRUCT("CrlSign", 2u),
					new CAPIBase.KEY_USAGE_STRUCT("EncipherOnly", 1u),
					new CAPIBase.KEY_USAGE_STRUCT("DecipherOnly", 32768u)
				};
				for (uint num = 0u; num < array.Length; num++)
				{
					if (string.Compare(array[num].pwszKeyUsage, (string)findValue, StringComparison.OrdinalIgnoreCase) == 0)
					{
						obj = array[num].dwKeyUsageBit;
						break;
					}
				}
				if (obj == null)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindType"));
				}
			}
			else if (findValue.GetType() == typeof(X509KeyUsageFlags))
			{
				obj = findValue;
			}
			else
			{
				if (!(findValue.GetType() == typeof(uint)) && !(findValue.GetType() == typeof(int)))
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindType"));
				}
				obj = findValue;
			}
			pfnCertCallback = FindKeyUsageCallback;
			break;
		case X509FindType.FindBySubjectKeyIdentifier:
			if (findValue.GetType() != typeof(string))
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindValue"));
			}
			obj = X509Utils.DecodeHexString((string)findValue);
			pfnCertCallback = FindSubjectKeyIdentifierCallback;
			break;
		default:
			throw new CryptographicException(System.SR.GetString("Cryptography_X509_InvalidFindType"));
		}
		System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle = CAPI.CertOpenStore(new IntPtr(2L), 65537u, IntPtr.Zero, 8704u, null);
		if (safeCertStoreHandle == null || safeCertStoreHandle.IsInvalid)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		FindByCert(safeSourceStoreHandle, dwFindType, pvFindPara, validOnly, pfnCertCallback, pfnCertCallback2, obj, pvCallbackData, safeCertStoreHandle);
		safeLocalAllocHandle.Dispose();
		return safeCertStoreHandle;
	}

	private static void FindByCert(System.Security.Cryptography.SafeCertStoreHandle safeSourceStoreHandle, uint dwFindType, IntPtr pvFindPara, bool validOnly, FindProcDelegate pfnCertCallback1, FindProcDelegate pfnCertCallback2, object pvCallbackData1, object pvCallbackData2, System.Security.Cryptography.SafeCertStoreHandle safeTargetStoreHandle)
	{
		int num = 0;
		System.Security.Cryptography.SafeCertContextHandle invalidHandle = System.Security.Cryptography.SafeCertContextHandle.InvalidHandle;
		for (invalidHandle = CAPI.CertFindCertificateInStore(safeSourceStoreHandle, 65537u, 0u, dwFindType, pvFindPara, invalidHandle); invalidHandle != null && !invalidHandle.IsInvalid; GC.SuppressFinalize(invalidHandle), invalidHandle = CAPI.CertFindCertificateInStore(safeSourceStoreHandle, 65537u, 0u, dwFindType, pvFindPara, invalidHandle))
		{
			if (pfnCertCallback1 != null)
			{
				num = pfnCertCallback1(invalidHandle, pvCallbackData1);
				if (num == 1)
				{
					if (pfnCertCallback2 != null)
					{
						num = pfnCertCallback2(invalidHandle, pvCallbackData2);
					}
					if (num == 1)
					{
						continue;
					}
				}
				if (num != 0)
				{
					break;
				}
			}
			if (validOnly)
			{
				num = X509Utils.VerifyCertificate(invalidHandle, null, null, X509RevocationMode.NoCheck, X509RevocationFlag.ExcludeRoot, DateTime.Now, new TimeSpan(0, 0, 0), null, new IntPtr(1L), IntPtr.Zero);
				if (num == 1)
				{
					continue;
				}
				if (num != 0)
				{
					break;
				}
			}
			if (!CAPI.CertAddCertificateLinkToStore(safeTargetStoreHandle, invalidHandle, 4u, System.Security.Cryptography.SafeCertContextHandle.InvalidHandle))
			{
				num = Marshal.GetHRForLastWin32Error();
				break;
			}
		}
		if (invalidHandle != null && !invalidHandle.IsInvalid)
		{
			invalidHandle.Dispose();
		}
		if (num != 1 && num != 0)
		{
			throw new CryptographicException(num);
		}
	}

	private static int FindSubjectDistinguishedNameCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		string certNameInfo = CAPI.GetCertNameInfo(safeCertContextHandle, 0u, 2u);
		if (string.Compare(certNameInfo, (string)pvCallbackData, StringComparison.OrdinalIgnoreCase) != 0)
		{
			return 1;
		}
		return 0;
	}

	private static int FindIssuerDistinguishedNameCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		string certNameInfo = CAPI.GetCertNameInfo(safeCertContextHandle, 1u, 2u);
		if (string.Compare(certNameInfo, (string)pvCallbackData, StringComparison.OrdinalIgnoreCase) != 0)
		{
			return 1;
		}
		return 0;
	}

	private unsafe static int FindSerialNumberCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		CAPIBase.CERT_INFO cERT_INFO = (CAPIBase.CERT_INFO)Marshal.PtrToStructure(cERT_CONTEXT.pCertInfo, typeof(CAPIBase.CERT_INFO));
		byte[] array = new byte[cERT_INFO.SerialNumber.cbData];
		Marshal.Copy(cERT_INFO.SerialNumber.pbData, array, 0, array.Length);
		int hexArraySize = X509Utils.GetHexArraySize(array);
		byte[] array2 = (byte[])pvCallbackData;
		if (array2.Length != hexArraySize)
		{
			return 1;
		}
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i] != array[i])
			{
				return 1;
			}
		}
		return 0;
	}

	private unsafe static int FindTimeValidCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		System.Runtime.InteropServices.ComTypes.FILETIME pTimeToVerify = (System.Runtime.InteropServices.ComTypes.FILETIME)pvCallbackData;
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		if (CAPISafe.CertVerifyTimeValidity(ref pTimeToVerify, cERT_CONTEXT.pCertInfo) == 0)
		{
			return 0;
		}
		return 1;
	}

	private unsafe static int FindTimeNotAfterCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		System.Runtime.InteropServices.ComTypes.FILETIME pTimeToVerify = (System.Runtime.InteropServices.ComTypes.FILETIME)pvCallbackData;
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		if (CAPISafe.CertVerifyTimeValidity(ref pTimeToVerify, cERT_CONTEXT.pCertInfo) == 1)
		{
			return 0;
		}
		return 1;
	}

	private unsafe static int FindTimeNotBeforeCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		System.Runtime.InteropServices.ComTypes.FILETIME pTimeToVerify = (System.Runtime.InteropServices.ComTypes.FILETIME)pvCallbackData;
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		if (CAPISafe.CertVerifyTimeValidity(ref pTimeToVerify, cERT_CONTEXT.pCertInfo) == -1)
		{
			return 0;
		}
		return 1;
	}

	private unsafe static int FindTemplateNameCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		IntPtr zero = IntPtr.Zero;
		IntPtr zero2 = IntPtr.Zero;
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		CAPIBase.CERT_INFO cERT_INFO = (CAPIBase.CERT_INFO)Marshal.PtrToStructure(cERT_CONTEXT.pCertInfo, typeof(CAPIBase.CERT_INFO));
		zero = CAPISafe.CertFindExtension("1.3.6.1.4.1.311.20.2", cERT_INFO.cExtension, cERT_INFO.rgExtension);
		zero2 = CAPISafe.CertFindExtension("1.3.6.1.4.1.311.21.7", cERT_INFO.cExtension, cERT_INFO.rgExtension);
		if (zero == IntPtr.Zero && zero2 == IntPtr.Zero)
		{
			return 1;
		}
		if (zero != IntPtr.Zero)
		{
			CAPIBase.CERT_EXTENSION cERT_EXTENSION = (CAPIBase.CERT_EXTENSION)Marshal.PtrToStructure(zero, typeof(CAPIBase.CERT_EXTENSION));
			byte[] array = new byte[cERT_EXTENSION.Value.cbData];
			Marshal.Copy(cERT_EXTENSION.Value.pbData, array, 0, array.Length);
			uint cbDecodedValue = 0u;
			SafeLocalAllocHandle decodedValue = null;
			if (CAPI.DecodeObject(new IntPtr(24L), array, out decodedValue, out cbDecodedValue))
			{
				string strA = Marshal.PtrToStringUni(((CAPIBase.CERT_NAME_VALUE)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CERT_NAME_VALUE))).Value.pbData);
				if (string.Compare(strA, (string)pvCallbackData, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return 0;
				}
			}
		}
		if (zero2 != IntPtr.Zero)
		{
			CAPIBase.CERT_EXTENSION cERT_EXTENSION2 = (CAPIBase.CERT_EXTENSION)Marshal.PtrToStructure(zero2, typeof(CAPIBase.CERT_EXTENSION));
			byte[] array2 = new byte[cERT_EXTENSION2.Value.cbData];
			Marshal.Copy(cERT_EXTENSION2.Value.pbData, array2, 0, array2.Length);
			uint cbDecodedValue2 = 0u;
			SafeLocalAllocHandle decodedValue2 = null;
			if (CAPI.DecodeObject(new IntPtr(64L), array2, out decodedValue2, out cbDecodedValue2))
			{
				CAPIBase.CERT_TEMPLATE_EXT cERT_TEMPLATE_EXT = (CAPIBase.CERT_TEMPLATE_EXT)Marshal.PtrToStructure(decodedValue2.DangerousGetHandle(), typeof(CAPIBase.CERT_TEMPLATE_EXT));
				string text = X509Utils.FindOidInfoWithFallback(2u, (string)pvCallbackData, System.Security.Cryptography.OidGroup.Template);
				if (text == null)
				{
					text = (string)pvCallbackData;
				}
				if (string.Compare(cERT_TEMPLATE_EXT.pszObjId, text, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return 0;
				}
			}
		}
		return 1;
	}

	private unsafe static int FindApplicationPolicyCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		string text = (string)pvCallbackData;
		if (text.Length == 0)
		{
			return 1;
		}
		IntPtr intPtr = safeCertContextHandle.DangerousGetHandle();
		int num = 0;
		uint num2 = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CertGetValidUsages(1u, new IntPtr(&intPtr), new IntPtr(&num), invalidHandle, new IntPtr(&num2)))
		{
			return 1;
		}
		invalidHandle = CAPI.LocalAlloc(0u, new IntPtr(num2));
		if (!CAPISafe.CertGetValidUsages(1u, new IntPtr(&intPtr), new IntPtr(&num), invalidHandle, new IntPtr(&num2)))
		{
			return 1;
		}
		if (num == -1)
		{
			return 0;
		}
		for (int i = 0; i < num; i++)
		{
			IntPtr ptr = Marshal.ReadIntPtr(new IntPtr((long)invalidHandle.DangerousGetHandle() + i * Marshal.SizeOf(typeof(IntPtr))));
			string strB = Marshal.PtrToStringAnsi(ptr);
			if (string.Compare(text, strB, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return 0;
			}
		}
		return 1;
	}

	private unsafe static int FindCertificatePolicyCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		string text = (string)pvCallbackData;
		if (text.Length == 0)
		{
			return 1;
		}
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		CAPIBase.CERT_INFO cERT_INFO = (CAPIBase.CERT_INFO)Marshal.PtrToStructure(cERT_CONTEXT.pCertInfo, typeof(CAPIBase.CERT_INFO));
		IntPtr intPtr = CAPISafe.CertFindExtension("2.5.29.32", cERT_INFO.cExtension, cERT_INFO.rgExtension);
		if (intPtr == IntPtr.Zero)
		{
			return 1;
		}
		CAPIBase.CERT_EXTENSION cERT_EXTENSION = (CAPIBase.CERT_EXTENSION)Marshal.PtrToStructure(intPtr, typeof(CAPIBase.CERT_EXTENSION));
		byte[] array = new byte[cERT_EXTENSION.Value.cbData];
		Marshal.Copy(cERT_EXTENSION.Value.pbData, array, 0, array.Length);
		uint cbDecodedValue = 0u;
		SafeLocalAllocHandle decodedValue = null;
		if (CAPI.DecodeObject(new IntPtr(16L), array, out decodedValue, out cbDecodedValue))
		{
			CAPIBase.CERT_POLICIES_INFO cERT_POLICIES_INFO = (CAPIBase.CERT_POLICIES_INFO)Marshal.PtrToStructure(decodedValue.DangerousGetHandle(), typeof(CAPIBase.CERT_POLICIES_INFO));
			for (int i = 0; i < cERT_POLICIES_INFO.cPolicyInfo; i++)
			{
				IntPtr ptr = new IntPtr((long)cERT_POLICIES_INFO.rgPolicyInfo + i * Marshal.SizeOf(typeof(CAPIBase.CERT_POLICY_INFO)));
				if (string.Compare(text, ((CAPIBase.CERT_POLICY_INFO)Marshal.PtrToStructure(ptr, typeof(CAPIBase.CERT_POLICY_INFO))).pszPolicyIdentifier, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return 0;
				}
			}
		}
		return 1;
	}

	private unsafe static int FindExtensionCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		CAPIBase.CERT_INFO cERT_INFO = (CAPIBase.CERT_INFO)Marshal.PtrToStructure(cERT_CONTEXT.pCertInfo, typeof(CAPIBase.CERT_INFO));
		IntPtr intPtr = CAPISafe.CertFindExtension((string)pvCallbackData, cERT_INFO.cExtension, cERT_INFO.rgExtension);
		if (intPtr == IntPtr.Zero)
		{
			return 1;
		}
		return 0;
	}

	private unsafe static int FindKeyUsageCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		CAPIBase.CERT_CONTEXT cERT_CONTEXT = *(CAPIBase.CERT_CONTEXT*)(void*)safeCertContextHandle.DangerousGetHandle();
		uint num = 0u;
		if (!CAPISafe.CertGetIntendedKeyUsage(65537u, cERT_CONTEXT.pCertInfo, new IntPtr(&num), 4u))
		{
			return 0;
		}
		uint num2 = Convert.ToUInt32(pvCallbackData, null);
		if ((num & num2) == num2)
		{
			return 0;
		}
		return 1;
	}

	private static int FindSubjectKeyIdentifierCallback(System.Security.Cryptography.SafeCertContextHandle safeCertContextHandle, object pvCallbackData)
	{
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		uint pcbData = 0u;
		if (!CAPISafe.CertGetCertificateContextProperty(safeCertContextHandle, 20u, invalidHandle, ref pcbData))
		{
			return 1;
		}
		invalidHandle = CAPI.LocalAlloc(0u, new IntPtr(pcbData));
		if (!CAPISafe.CertGetCertificateContextProperty(safeCertContextHandle, 20u, invalidHandle, ref pcbData))
		{
			return 1;
		}
		byte[] array = (byte[])pvCallbackData;
		if (array.Length != pcbData)
		{
			return 1;
		}
		byte[] array2 = new byte[pcbData];
		Marshal.Copy(invalidHandle.DangerousGetHandle(), array2, 0, array2.Length);
		invalidHandle.Dispose();
		for (uint num = 0u; num < pcbData; num++)
		{
			if (array[num] != array2[num])
			{
				return 1;
			}
		}
		return 0;
	}

	private unsafe static System.Security.Cryptography.SafeCertStoreHandle LoadStoreFromBlob(byte[] rawData, string password, uint dwFlags, bool persistKeyContainers, bool passwordProvided)
	{
		uint num = 0u;
		System.Security.Cryptography.SafeCertStoreHandle phCertStore = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		if (!CAPI.CryptQueryObject(2u, rawData, 5938u, 14u, 0u, IntPtr.Zero, new IntPtr(&num), IntPtr.Zero, ref phCertStore, IntPtr.Zero, IntPtr.Zero))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if (num == 12)
		{
			EnforceIterationCountLimit(rawData, readingFromFile: false, passwordProvided);
			phCertStore.Dispose();
			phCertStore = CAPI.PFXImportCertStore(2u, rawData, password, dwFlags, persistKeyContainers);
		}
		if (phCertStore == null || phCertStore.IsInvalid)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phCertStore;
	}

	private unsafe static System.Security.Cryptography.SafeCertStoreHandle LoadStoreFromFile(string fileName, string password, uint dwFlags, bool persistKeyContainers)
	{
		uint num = 0u;
		System.Security.Cryptography.SafeCertStoreHandle phCertStore = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		if (!CAPI.CryptQueryObject(1u, fileName, 5938u, 14u, 0u, IntPtr.Zero, new IntPtr(&num), IntPtr.Zero, ref phCertStore, IntPtr.Zero, IntPtr.Zero))
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		if (num == 12)
		{
			phCertStore.Dispose();
			phCertStore = CAPI.PFXImportCertStore(1u, fileName, password, dwFlags, persistKeyContainers);
		}
		if (phCertStore == null || phCertStore.IsInvalid)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		return phCertStore;
	}

	private static void EnforceIterationCountLimit(byte[] pkcs12, bool readingFromFile, bool passwordProvided)
	{
		if (!s_enforceIterationCountLimitMethodInitialized)
		{
			InitializeEnforceIterationCountLimitMethod();
		}
		if (s_enforceIterationCountLimitDelegate != null)
		{
			s_enforceIterationCountLimitDelegate(pkcs12, readingFromFile, passwordProvided);
		}
	}

	[ReflectionPermission(SecurityAction.Assert, Unrestricted = true)]
	private static void InitializeEnforceIterationCountLimitMethod()
	{
		Assembly assembly = typeof(X509Certificate).Assembly;
		if (assembly != null)
		{
			Type type = assembly.GetType("System.Security.Cryptography.X509Certificates.IterationCountLimitEnforcer");
			if (type != null)
			{
				BindingFlags bindingAttr = BindingFlags.Static | BindingFlags.NonPublic;
				Type[] types = new Type[3]
				{
					typeof(byte[]),
					typeof(bool),
					typeof(bool)
				};
				MethodInfo method = type.GetMethod("EnforceIterationCountLimit", bindingAttr, null, types, null);
				if (method != null)
				{
					s_enforceIterationCountLimitDelegate = (EnforceIterationCountLimitDelegate)Delegate.CreateDelegate(typeof(EnforceIterationCountLimitDelegate), method);
				}
			}
		}
		s_enforceIterationCountLimitMethodInitialized = true;
	}
}

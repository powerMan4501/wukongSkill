using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Security.Cryptography;

internal sealed class CAPI : CAPIMethods
{
	internal static byte[] BlobToByteArray(IntPtr pBlob)
	{
		CRYPTOAPI_BLOB blob = (CRYPTOAPI_BLOB)Marshal.PtrToStructure(pBlob, typeof(CRYPTOAPI_BLOB));
		if (blob.cbData == 0)
		{
			return new byte[0];
		}
		return BlobToByteArray(blob);
	}

	internal static byte[] BlobToByteArray(CRYPTOAPI_BLOB blob)
	{
		if (blob.cbData == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[blob.cbData];
		Marshal.Copy(blob.pbData, array, 0, array.Length);
		return array;
	}

	internal unsafe static bool DecodeObject(IntPtr pszStructType, IntPtr pbEncoded, uint cbEncoded, out SafeLocalAllocHandle decodedValue, out uint cbDecodedValue)
	{
		decodedValue = SafeLocalAllocHandle.InvalidHandle;
		cbDecodedValue = 0u;
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptDecodeObject(65537u, pszStructType, pbEncoded, cbEncoded, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptDecodeObject(65537u, pszStructType, pbEncoded, cbEncoded, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		decodedValue = invalidHandle;
		cbDecodedValue = num;
		return true;
	}

	internal unsafe static bool DecodeObject(IntPtr pszStructType, byte[] pbEncoded, out SafeLocalAllocHandle decodedValue, out uint cbDecodedValue)
	{
		decodedValue = SafeLocalAllocHandle.InvalidHandle;
		cbDecodedValue = 0u;
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptDecodeObject(65537u, pszStructType, pbEncoded, (uint)pbEncoded.Length, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptDecodeObject(65537u, pszStructType, pbEncoded, (uint)pbEncoded.Length, 0u, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		decodedValue = invalidHandle;
		cbDecodedValue = num;
		return true;
	}

	internal unsafe static bool EncodeObject(IntPtr lpszStructType, IntPtr pvStructInfo, out byte[] encodedData)
	{
		encodedData = new byte[0];
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptEncodeObject(65537u, lpszStructType, pvStructInfo, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptEncodeObject(65537u, lpszStructType, pvStructInfo, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		encodedData = new byte[num];
		Marshal.Copy(invalidHandle.DangerousGetHandle(), encodedData, 0, (int)num);
		invalidHandle.Dispose();
		return true;
	}

	internal unsafe static bool EncodeObject(string lpszStructType, IntPtr pvStructInfo, out byte[] encodedData)
	{
		encodedData = new byte[0];
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptEncodeObject(65537u, lpszStructType, pvStructInfo, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptEncodeObject(65537u, lpszStructType, pvStructInfo, invalidHandle, new IntPtr(&num)))
		{
			return false;
		}
		encodedData = new byte[num];
		Marshal.Copy(invalidHandle.DangerousGetHandle(), encodedData, 0, (int)num);
		invalidHandle.Dispose();
		return true;
	}

	internal unsafe static string GetCertNameInfo([In] SafeCertContextHandle safeCertContext, [In] uint dwFlags, [In] uint dwDisplayType)
	{
		if (safeCertContext == null)
		{
			throw new ArgumentNullException("pCertContext");
		}
		if (safeCertContext.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "safeCertContext");
		}
		uint num = 33554435u;
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		if (dwDisplayType == 3)
		{
			safeLocalAllocHandle = X509Utils.StringToAnsiPtr("2.5.4.3");
		}
		uint num2 = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		num2 = CAPISafe.CertGetNameStringW(safeCertContext, dwDisplayType, dwFlags, (dwDisplayType == 3) ? safeLocalAllocHandle.DangerousGetHandle() : new IntPtr(&num), invalidHandle, 0u);
		if (num2 == 0)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(2 * num2));
		if (CAPISafe.CertGetNameStringW(safeCertContext, dwDisplayType, dwFlags, (dwDisplayType == 3) ? safeLocalAllocHandle.DangerousGetHandle() : new IntPtr(&num), invalidHandle, num2) == 0)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		string result = Marshal.PtrToStringUni(invalidHandle.DangerousGetHandle());
		invalidHandle.Dispose();
		safeLocalAllocHandle.Dispose();
		return result;
	}

	internal new static SafeLocalAllocHandle LocalAlloc(uint uFlags, IntPtr sizetdwBytes)
	{
		SafeLocalAllocHandle safeLocalAllocHandle = CAPISafe.LocalAlloc(uFlags, sizetdwBytes);
		if (safeLocalAllocHandle == null || safeLocalAllocHandle.IsInvalid)
		{
			throw new OutOfMemoryException();
		}
		return safeLocalAllocHandle;
	}

	internal new static bool CryptAcquireContext([In][Out] ref SafeCryptProvHandle hCryptProv, [In][MarshalAs(UnmanagedType.LPStr)] string pwszContainer, [In][MarshalAs(UnmanagedType.LPStr)] string pwszProvider, [In] uint dwProvType, [In] uint dwFlags)
	{
		CspParameters cspParameters = new CspParameters();
		cspParameters.ProviderName = pwszProvider;
		cspParameters.KeyContainerName = pwszContainer;
		cspParameters.ProviderType = (int)dwProvType;
		cspParameters.KeyNumber = -1;
		cspParameters.Flags = (((dwFlags & 0x20) == 32) ? CspProviderFlags.UseMachineKeyStore : CspProviderFlags.NoFlags);
		if (!CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(cspParameters, KeyContainerPermissionFlags.Open);
			keyContainerPermission.AccessEntries.Add(accessEntry);
			keyContainerPermission.Demand();
		}
		bool flag = CAPIUnsafe.CryptAcquireContext(ref hCryptProv, pwszContainer, pwszProvider, dwProvType, dwFlags);
		if (!flag && Marshal.GetLastWin32Error() == -2146893802)
		{
			flag = CAPIUnsafe.CryptAcquireContext(ref hCryptProv, pwszContainer, pwszProvider, dwProvType, dwFlags | 8);
		}
		return flag;
	}

	internal static bool CryptAcquireContext(ref SafeCryptProvHandle hCryptProv, IntPtr pwszContainer, IntPtr pwszProvider, uint dwProvType, uint dwFlags)
	{
		string pwszContainer2 = null;
		if (pwszContainer != IntPtr.Zero)
		{
			pwszContainer2 = Marshal.PtrToStringUni(pwszContainer);
		}
		string pwszProvider2 = null;
		if (pwszProvider != IntPtr.Zero)
		{
			pwszProvider2 = Marshal.PtrToStringUni(pwszProvider);
		}
		return CryptAcquireContext(ref hCryptProv, pwszContainer2, pwszProvider2, dwProvType, dwFlags);
	}

	internal new static CRYPT_OID_INFO CryptFindOIDInfo([In] uint dwKeyType, [In] IntPtr pvKey, [In] OidGroup dwGroupId)
	{
		if (pvKey == IntPtr.Zero)
		{
			throw new ArgumentNullException("pvKey");
		}
		CRYPT_OID_INFO result = new CRYPT_OID_INFO(Marshal.SizeOf(typeof(CRYPT_OID_INFO)));
		IntPtr intPtr = CAPISafe.CryptFindOIDInfo(dwKeyType, pvKey, dwGroupId);
		if (intPtr != IntPtr.Zero)
		{
			return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr, typeof(CRYPT_OID_INFO));
		}
		return result;
	}

	internal new static CRYPT_OID_INFO CryptFindOIDInfo([In] uint dwKeyType, [In] SafeLocalAllocHandle pvKey, [In] OidGroup dwGroupId)
	{
		if (pvKey == null)
		{
			throw new ArgumentNullException("pvKey");
		}
		if (pvKey.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "pvKey");
		}
		CRYPT_OID_INFO result = new CRYPT_OID_INFO(Marshal.SizeOf(typeof(CRYPT_OID_INFO)));
		IntPtr intPtr = CAPISafe.CryptFindOIDInfo(dwKeyType, pvKey, dwGroupId);
		if (intPtr != IntPtr.Zero)
		{
			return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr, typeof(CRYPT_OID_INFO));
		}
		return result;
	}

	internal unsafe static string CryptFormatObject([In] uint dwCertEncodingType, [In] uint dwFormatStrType, [In] string lpszStructType, [In] byte[] rawData)
	{
		if (rawData == null)
		{
			throw new ArgumentNullException("rawData");
		}
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptFormatObject(dwCertEncodingType, 0u, dwFormatStrType, IntPtr.Zero, lpszStructType, rawData, (uint)rawData.Length, invalidHandle, new IntPtr(&num)))
		{
			return X509Utils.EncodeHexString(rawData);
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptFormatObject(dwCertEncodingType, 0u, dwFormatStrType, IntPtr.Zero, lpszStructType, rawData, (uint)rawData.Length, invalidHandle, new IntPtr(&num)))
		{
			return X509Utils.EncodeHexString(rawData);
		}
		string result = Marshal.PtrToStringUni(invalidHandle.DangerousGetHandle());
		invalidHandle.Dispose();
		return result;
	}

	internal unsafe static string CryptFormatObject([In] uint dwCertEncodingType, [In] uint dwFormatStrType, [In] IntPtr lpszStructType, [In] byte[] rawData)
	{
		if (rawData == null)
		{
			throw new ArgumentNullException("rawData");
		}
		uint num = 0u;
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (!CAPISafe.CryptFormatObject(dwCertEncodingType, 0u, dwFormatStrType, IntPtr.Zero, lpszStructType, rawData, (uint)rawData.Length, invalidHandle, new IntPtr(&num)))
		{
			return X509Utils.EncodeHexString(rawData);
		}
		invalidHandle = LocalAlloc(0u, new IntPtr(num));
		if (!CAPISafe.CryptFormatObject(dwCertEncodingType, 0u, dwFormatStrType, IntPtr.Zero, lpszStructType, rawData, (uint)rawData.Length, invalidHandle, new IntPtr(&num)))
		{
			return X509Utils.EncodeHexString(rawData);
		}
		string result = Marshal.PtrToStringUni(invalidHandle.DangerousGetHandle());
		invalidHandle.Dispose();
		return result;
	}

	internal new static bool CryptMsgControl([In] SafeCryptMsgHandle hCryptMsg, [In] uint dwFlags, [In] uint dwCtrlType, [In] IntPtr pvCtrlPara)
	{
		return CAPIUnsafe.CryptMsgControl(hCryptMsg, dwFlags, dwCtrlType, pvCtrlPara);
	}

	internal new static bool CryptMsgCountersign([In] SafeCryptMsgHandle hCryptMsg, [In] uint dwIndex, [In] uint cCountersigners, [In] IntPtr rgCountersigners)
	{
		return CAPIUnsafe.CryptMsgCountersign(hCryptMsg, dwIndex, cCountersigners, rgCountersigners);
	}

	internal new static SafeCryptMsgHandle CryptMsgOpenToEncode([In] uint dwMsgEncodingType, [In] uint dwFlags, [In] uint dwMsgType, [In] IntPtr pvMsgEncodeInfo, [In] IntPtr pszInnerContentObjID, [In] IntPtr pStreamInfo)
	{
		return CAPIUnsafe.CryptMsgOpenToEncode(dwMsgEncodingType, dwFlags, dwMsgType, pvMsgEncodeInfo, pszInnerContentObjID, pStreamInfo);
	}

	internal new static SafeCryptMsgHandle CryptMsgOpenToEncode([In] uint dwMsgEncodingType, [In] uint dwFlags, [In] uint dwMsgType, [In] IntPtr pvMsgEncodeInfo, [In] string pszInnerContentObjID, [In] IntPtr pStreamInfo)
	{
		return CAPIUnsafe.CryptMsgOpenToEncode(dwMsgEncodingType, dwFlags, dwMsgType, pvMsgEncodeInfo, pszInnerContentObjID, pStreamInfo);
	}

	internal new static bool CertSetCertificateContextProperty([In] IntPtr pCertContext, [In] uint dwPropId, [In] uint dwFlags, [In] IntPtr pvData)
	{
		if (pvData == IntPtr.Zero)
		{
			throw new ArgumentNullException("pvData");
		}
		if (dwPropId != 19 && dwPropId != 11 && dwPropId != 125 && dwPropId != 2)
		{
			throw new ArgumentException(SR.GetString("Security_InvalidValue"), "dwFlags");
		}
		if (dwPropId == 19 || dwPropId == 11 || dwPropId == 2)
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		return CAPIUnsafe.CertSetCertificateContextProperty(pCertContext, dwPropId, dwFlags, pvData);
	}

	internal new static bool CertSetCertificateContextProperty([In] SafeCertContextHandle pCertContext, [In] uint dwPropId, [In] uint dwFlags, [In] IntPtr pvData)
	{
		if (pvData == IntPtr.Zero)
		{
			throw new ArgumentNullException("pvData");
		}
		if (dwPropId != 19 && dwPropId != 11 && dwPropId != 125 && dwPropId != 2)
		{
			throw new ArgumentException(SR.GetString("Security_InvalidValue"), "dwFlags");
		}
		if (dwPropId == 19 || dwPropId == 11 || dwPropId == 2)
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		return CAPIUnsafe.CertSetCertificateContextProperty(pCertContext, dwPropId, dwFlags, pvData);
	}

	internal new static bool CertSetCertificateContextProperty([In] SafeCertContextHandle pCertContext, [In] uint dwPropId, [In] uint dwFlags, [In] SafeLocalAllocHandle safeLocalAllocHandle)
	{
		if (pCertContext == null)
		{
			throw new ArgumentNullException("pCertContext");
		}
		if (pCertContext.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "pCertContext");
		}
		if (dwPropId != 19 && dwPropId != 11 && dwPropId != 125 && dwPropId != 2)
		{
			throw new ArgumentException(SR.GetString("Security_InvalidValue"), "dwFlags");
		}
		if (dwPropId == 19 || dwPropId == 11 || dwPropId == 2)
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		return CAPIUnsafe.CertSetCertificateContextProperty(pCertContext, dwPropId, dwFlags, safeLocalAllocHandle);
	}

	internal new static SafeCertContextHandle CertDuplicateCertificateContext([In] IntPtr pCertContext)
	{
		if (pCertContext == IntPtr.Zero)
		{
			return SafeCertContextHandle.InvalidHandle;
		}
		return CAPISafe.CertDuplicateCertificateContext(pCertContext);
	}

	internal new static SafeCertContextHandle CertDuplicateCertificateContext([In] SafeCertContextHandle pCertContext)
	{
		if (pCertContext == null || pCertContext.IsInvalid)
		{
			return SafeCertContextHandle.InvalidHandle;
		}
		return CAPISafe.CertDuplicateCertificateContext(pCertContext);
	}

	internal new static IntPtr CertEnumCertificatesInStore([In] SafeCertStoreHandle hCertStore, [In] IntPtr pPrevCertContext)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		if (pPrevCertContext == IntPtr.Zero)
		{
			StorePermission storePermission = new StorePermission(StorePermissionFlags.EnumerateCertificates);
			storePermission.Demand();
		}
		IntPtr intPtr = CAPIUnsafe.CertEnumCertificatesInStore(hCertStore, pPrevCertContext);
		if (intPtr == IntPtr.Zero)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != -2146885628)
			{
				CAPISafe.CertFreeCertificateContext(intPtr);
				throw new CryptographicException(lastWin32Error);
			}
		}
		return intPtr;
	}

	internal new static SafeCertContextHandle CertEnumCertificatesInStore([In] SafeCertStoreHandle hCertStore, [In] SafeCertContextHandle pPrevCertContext)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		if (pPrevCertContext.IsInvalid)
		{
			StorePermission storePermission = new StorePermission(StorePermissionFlags.EnumerateCertificates);
			storePermission.Demand();
		}
		SafeCertContextHandle safeCertContextHandle = CAPIUnsafe.CertEnumCertificatesInStore(hCertStore, pPrevCertContext);
		if (safeCertContextHandle == null || safeCertContextHandle.IsInvalid)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != -2146885628)
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return safeCertContextHandle;
	}

	internal unsafe static bool CryptQueryObject([In] uint dwObjectType, [In] object pvObject, [In] uint dwExpectedContentTypeFlags, [In] uint dwExpectedFormatTypeFlags, [In] uint dwFlags, [Out] IntPtr pdwMsgAndCertEncodingType, [Out] IntPtr pdwContentType, [Out] IntPtr pdwFormatType, [In][Out] IntPtr phCertStore, [In][Out] IntPtr phMsg, [In][Out] IntPtr ppvContext)
	{
		bool flag = false;
		GCHandle gCHandle = GCHandle.Alloc(pvObject, GCHandleType.Pinned);
		IntPtr intPtr = gCHandle.AddrOfPinnedObject();
		try
		{
			if (pvObject == null)
			{
				throw new ArgumentNullException("pvObject");
			}
			if (dwObjectType == 1)
			{
				string fullPath = Path.GetFullPath((string)pvObject);
				new FileIOPermission(FileIOPermissionAccess.Read, fullPath).Demand();
			}
			else
			{
				CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CRYPTOAPI_BLOB);
				cRYPTOAPI_BLOB.cbData = (uint)((byte[])pvObject).Length;
				cRYPTOAPI_BLOB.pbData = intPtr;
				intPtr = new IntPtr(&cRYPTOAPI_BLOB);
			}
			return CAPIUnsafe.CryptQueryObject(dwObjectType, intPtr, dwExpectedContentTypeFlags, dwExpectedFormatTypeFlags, dwFlags, pdwMsgAndCertEncodingType, pdwContentType, pdwFormatType, phCertStore, phMsg, ppvContext);
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
	}

	internal unsafe static bool CryptQueryObject([In] uint dwObjectType, [In] object pvObject, [In] uint dwExpectedContentTypeFlags, [In] uint dwExpectedFormatTypeFlags, [In] uint dwFlags, [Out] IntPtr pdwMsgAndCertEncodingType, [Out] IntPtr pdwContentType, [Out] IntPtr pdwFormatType, [In][Out] ref SafeCertStoreHandle phCertStore, [In][Out] IntPtr phMsg, [In][Out] IntPtr ppvContext)
	{
		bool flag = false;
		GCHandle gCHandle = GCHandle.Alloc(pvObject, GCHandleType.Pinned);
		IntPtr intPtr = gCHandle.AddrOfPinnedObject();
		try
		{
			if (pvObject == null)
			{
				throw new ArgumentNullException("pvObject");
			}
			if (dwObjectType == 1)
			{
				string fullPath = Path.GetFullPath((string)pvObject);
				new FileIOPermission(FileIOPermissionAccess.Read, fullPath).Demand();
			}
			else
			{
				CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CRYPTOAPI_BLOB);
				cRYPTOAPI_BLOB.cbData = (uint)((byte[])pvObject).Length;
				cRYPTOAPI_BLOB.pbData = intPtr;
				intPtr = new IntPtr(&cRYPTOAPI_BLOB);
			}
			return CAPIUnsafe.CryptQueryObject(dwObjectType, intPtr, dwExpectedContentTypeFlags, dwExpectedFormatTypeFlags, dwFlags, pdwMsgAndCertEncodingType, pdwContentType, pdwFormatType, ref phCertStore, phMsg, ppvContext);
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
	}

	internal unsafe static SafeCertStoreHandle PFXImportCertStore([In] uint dwObjectType, [In] object pvObject, [In] string szPassword, [In] uint dwFlags, [In] bool persistKeyContainers)
	{
		if (pvObject == null)
		{
			throw new ArgumentNullException("pvObject");
		}
		byte[] array = null;
		array = ((dwObjectType != 1) ? ((byte[])pvObject) : File.ReadAllBytes((string)pvObject));
		if (persistKeyContainers && !CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.Create);
			keyContainerPermission.Demand();
		}
		SafeCertStoreHandle safeCertStoreHandle = SafeCertStoreHandle.InvalidHandle;
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		IntPtr pbData = gCHandle.AddrOfPinnedObject();
		try
		{
			CRYPTOAPI_BLOB cRYPTOAPI_BLOB = default(CRYPTOAPI_BLOB);
			cRYPTOAPI_BLOB.cbData = (uint)array.Length;
			cRYPTOAPI_BLOB.pbData = pbData;
			safeCertStoreHandle = CAPIUnsafe.PFXImportCertStore(new IntPtr(&cRYPTOAPI_BLOB), szPassword, dwFlags);
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
		}
		if (!safeCertStoreHandle.IsInvalid && !persistKeyContainers)
		{
			IntPtr intPtr = CertEnumCertificatesInStore(safeCertStoreHandle, IntPtr.Zero);
			while (intPtr != IntPtr.Zero)
			{
				CRYPTOAPI_BLOB cRYPTOAPI_BLOB2 = default(CRYPTOAPI_BLOB);
				if (!CertSetCertificateContextProperty(intPtr, 125u, 1073741824u, new IntPtr(&cRYPTOAPI_BLOB2)))
				{
					throw new CryptographicException(Marshal.GetLastWin32Error());
				}
				intPtr = CertEnumCertificatesInStore(safeCertStoreHandle, intPtr);
			}
		}
		return safeCertStoreHandle;
	}

	internal new static bool CertAddCertificateContextToStore([In] SafeCertStoreHandle hCertStore, [In] SafeCertContextHandle pCertContext, [In] uint dwAddDisposition, [In][Out] SafeCertContextHandle ppStoreContext)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		if (pCertContext == null)
		{
			throw new ArgumentNullException("pCertContext");
		}
		if (pCertContext.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "pCertContext");
		}
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AddToStore);
		storePermission.Demand();
		return CAPIUnsafe.CertAddCertificateContextToStore(hCertStore, pCertContext, dwAddDisposition, ppStoreContext);
	}

	internal new static bool CertAddCertificateLinkToStore([In] SafeCertStoreHandle hCertStore, [In] SafeCertContextHandle pCertContext, [In] uint dwAddDisposition, [In][Out] SafeCertContextHandle ppStoreContext)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		if (pCertContext == null)
		{
			throw new ArgumentNullException("pCertContext");
		}
		if (pCertContext.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "pCertContext");
		}
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AddToStore);
		storePermission.Demand();
		return CAPIUnsafe.CertAddCertificateLinkToStore(hCertStore, pCertContext, dwAddDisposition, ppStoreContext);
	}

	internal new static bool CertDeleteCertificateFromStore([In] SafeCertContextHandle pCertContext)
	{
		if (pCertContext == null)
		{
			throw new ArgumentNullException("pCertContext");
		}
		if (pCertContext.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "pCertContext");
		}
		StorePermission storePermission = new StorePermission(StorePermissionFlags.RemoveFromStore);
		storePermission.Demand();
		return CAPIUnsafe.CertDeleteCertificateFromStore(pCertContext);
	}

	internal new static SafeCertStoreHandle CertOpenStore([In] IntPtr lpszStoreProvider, [In] uint dwMsgAndCertEncodingType, [In] IntPtr hCryptProv, [In] uint dwFlags, [In] string pvPara)
	{
		if (lpszStoreProvider != new IntPtr(2L) && lpszStoreProvider != new IntPtr(10L))
		{
			throw new ArgumentException(SR.GetString("Security_InvalidValue"), "lpszStoreProvider");
		}
		if (((dwFlags & 0x20000) == 131072 || (dwFlags & 0x80000) == 524288 || (dwFlags & 0x90000) == 589824) && pvPara != null && pvPara.StartsWith("\\\\", StringComparison.Ordinal))
		{
			new PermissionSet(PermissionState.Unrestricted).Demand();
		}
		if ((dwFlags & 0x10) == 16)
		{
			StorePermission storePermission = new StorePermission(StorePermissionFlags.DeleteStore);
			storePermission.Demand();
		}
		else
		{
			StorePermission storePermission2 = new StorePermission(StorePermissionFlags.OpenStore);
			storePermission2.Demand();
		}
		if ((dwFlags & 0x2000) == 8192)
		{
			StorePermission storePermission3 = new StorePermission(StorePermissionFlags.CreateStore);
			storePermission3.Demand();
		}
		if ((dwFlags & 0x4000) == 0)
		{
			StorePermission storePermission4 = new StorePermission(StorePermissionFlags.CreateStore);
			storePermission4.Demand();
		}
		return CAPIUnsafe.CertOpenStore(lpszStoreProvider, dwMsgAndCertEncodingType, hCryptProv, dwFlags | 4, pvPara);
	}

	internal new static SafeCertContextHandle CertFindCertificateInStore([In] SafeCertStoreHandle hCertStore, [In] uint dwCertEncodingType, [In] uint dwFindFlags, [In] uint dwFindType, [In] IntPtr pvFindPara, [In] SafeCertContextHandle pPrevCertContext)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		return CAPIUnsafe.CertFindCertificateInStore(hCertStore, dwCertEncodingType, dwFindFlags, dwFindType, pvFindPara, pPrevCertContext);
	}

	internal new static bool PFXExportCertStore([In] SafeCertStoreHandle hCertStore, [In][Out] IntPtr pPFX, [In] string szPassword, [In] uint dwFlags)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		if (!CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.Open | KeyContainerPermissionFlags.Export);
			keyContainerPermission.Demand();
		}
		return CAPIUnsafe.PFXExportCertStore(hCertStore, pPFX, szPassword, dwFlags);
	}

	internal new static bool CertSaveStore([In] SafeCertStoreHandle hCertStore, [In] uint dwMsgAndCertEncodingType, [In] uint dwSaveAs, [In] uint dwSaveTo, [In][Out] IntPtr pvSaveToPara, [In] uint dwFlags)
	{
		if (hCertStore == null)
		{
			throw new ArgumentNullException("hCertStore");
		}
		if (hCertStore.IsInvalid)
		{
			throw new CryptographicException(SR.GetString("Cryptography_InvalidHandle"), "hCertStore");
		}
		StorePermission storePermission = new StorePermission(StorePermissionFlags.EnumerateCertificates);
		storePermission.Demand();
		if (dwSaveTo == 3 || dwSaveTo == 4)
		{
			throw new ArgumentException(SR.GetString("Security_InvalidValue"), "pvSaveToPara");
		}
		return CAPIUnsafe.CertSaveStore(hCertStore, dwMsgAndCertEncodingType, dwSaveAs, dwSaveTo, pvSaveToPara, dwFlags);
	}
}

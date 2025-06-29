using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace System.Security.Cryptography.X509Certificates;

internal static class X509Utils
{
	private static bool OidGroupWillNotUseActiveDirectory(OidGroup group)
	{
		if (group != OidGroup.HashAlgorithm && group != OidGroup.EncryptionAlgorithm && group != OidGroup.PublicKeyAlgorithm && group != OidGroup.SignatureAlgorithm && group != OidGroup.Attribute && group != OidGroup.ExtensionOrAttribute)
		{
			return group == OidGroup.KeyDerivationFunction;
		}
		return true;
	}

	[SecurityCritical]
	private static CRYPT_OID_INFO FindOidInfo(OidKeyType keyType, string key, OidGroup group)
	{
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			intPtr = ((keyType != OidKeyType.Oid) ? Marshal.StringToCoTaskMemUni(key) : Marshal.StringToCoTaskMemAnsi(key));
			if (!OidGroupWillNotUseActiveDirectory(group))
			{
				OidGroup dwGroupId = group | OidGroup.DisableSearchDS;
				IntPtr intPtr2 = CryptFindOIDInfo(keyType, intPtr, dwGroupId);
				if (intPtr2 != IntPtr.Zero)
				{
					return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr2, typeof(CRYPT_OID_INFO));
				}
			}
			IntPtr intPtr3 = CryptFindOIDInfo(keyType, intPtr, group);
			if (intPtr3 != IntPtr.Zero)
			{
				return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr3, typeof(CRYPT_OID_INFO));
			}
			if (group != OidGroup.AllGroups)
			{
				IntPtr intPtr4 = CryptFindOIDInfo(keyType, intPtr, OidGroup.AllGroups);
				if (intPtr4 != IntPtr.Zero)
				{
					return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr4, typeof(CRYPT_OID_INFO));
				}
			}
			return default(CRYPT_OID_INFO);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int GetAlgIdFromOid(string oid, OidGroup oidGroup)
	{
		if (string.Equals(oid, "2.16.840.1.101.3.4.2.1", StringComparison.Ordinal))
		{
			return 32780;
		}
		if (string.Equals(oid, "2.16.840.1.101.3.4.2.2", StringComparison.Ordinal))
		{
			return 32781;
		}
		if (string.Equals(oid, "2.16.840.1.101.3.4.2.3", StringComparison.Ordinal))
		{
			return 32782;
		}
		return FindOidInfo(OidKeyType.Oid, oid, oidGroup).AlgId;
	}

	[SecuritySafeCritical]
	internal static string GetFriendlyNameFromOid(string oid, OidGroup oidGroup)
	{
		return FindOidInfo(OidKeyType.Oid, oid, oidGroup).pwszName;
	}

	[SecuritySafeCritical]
	internal static string GetOidFromFriendlyName(string friendlyName, OidGroup oidGroup)
	{
		return FindOidInfo(OidKeyType.Name, friendlyName, oidGroup).pszOID;
	}

	internal static int NameOrOidToAlgId(string oid, OidGroup oidGroup)
	{
		if (oid == null)
		{
			return 32772;
		}
		string text = CryptoConfig.MapNameToOID(oid, oidGroup);
		if (text == null)
		{
			text = oid;
		}
		int algIdFromOid = GetAlgIdFromOid(text, oidGroup);
		if (algIdFromOid == 0 || algIdFromOid == -1)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_InvalidOID"));
		}
		return algIdFromOid;
	}

	internal static X509ContentType MapContentType(uint contentType)
	{
		switch (contentType)
		{
		case 1u:
			return X509ContentType.Cert;
		case 4u:
			return X509ContentType.SerializedStore;
		case 5u:
			return X509ContentType.SerializedCert;
		case 8u:
		case 9u:
			return X509ContentType.Pkcs7;
		case 10u:
			return X509ContentType.Authenticode;
		case 12u:
			return X509ContentType.Pfx;
		default:
			return X509ContentType.Unknown;
		}
	}

	internal static uint MapKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
	{
		if ((keyStorageFlags & (X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet)) != keyStorageFlags)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidFlag"), "keyStorageFlags");
		}
		X509KeyStorageFlags x509KeyStorageFlags = keyStorageFlags & (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet);
		if (x509KeyStorageFlags == (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet))
		{
			throw new ArgumentException(Environment.GetResourceString("Cryptography_X509_InvalidFlagCombination", x509KeyStorageFlags), "keyStorageFlags");
		}
		uint num = 0u;
		if ((keyStorageFlags & X509KeyStorageFlags.UserKeySet) == X509KeyStorageFlags.UserKeySet)
		{
			num |= 0x1000;
		}
		else if ((keyStorageFlags & X509KeyStorageFlags.MachineKeySet) == X509KeyStorageFlags.MachineKeySet)
		{
			num |= 0x20;
		}
		if ((keyStorageFlags & X509KeyStorageFlags.Exportable) == X509KeyStorageFlags.Exportable)
		{
			num |= 1;
		}
		if ((keyStorageFlags & X509KeyStorageFlags.UserProtected) == X509KeyStorageFlags.UserProtected)
		{
			num |= 2;
		}
		if ((keyStorageFlags & X509KeyStorageFlags.EphemeralKeySet) == X509KeyStorageFlags.EphemeralKeySet)
		{
			num |= 0x8200;
		}
		return num;
	}

	[SecurityCritical]
	internal static SafeCertStoreHandle ExportCertToMemoryStore(X509Certificate certificate)
	{
		SafeCertStoreHandle invalidHandle = SafeCertStoreHandle.InvalidHandle;
		OpenX509Store(2u, 8704u, null, invalidHandle);
		_AddCertificateToStore(invalidHandle, certificate.CertContext);
		return invalidHandle;
	}

	[SecurityCritical]
	internal static IntPtr PasswordToHGlobalUni(object password)
	{
		if (password != null)
		{
			if (password is string s)
			{
				return Marshal.StringToHGlobalUni(s);
			}
			if (password is SecureString s2)
			{
				return Marshal.SecureStringToGlobalAllocUnicode(s2);
			}
		}
		return IntPtr.Zero;
	}

	[DllImport("crypt32")]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr CryptFindOIDInfo(OidKeyType dwKeyType, IntPtr pvKey, OidGroup dwGroupId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void _AddCertificateToStore(SafeCertStoreHandle safeCertStoreHandle, SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _DuplicateCertContext(IntPtr handle, ref SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _ExportCertificatesToBlob(SafeCertStoreHandle safeCertStoreHandle, X509ContentType contentType, IntPtr password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _GetCertRawData(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void _GetDateNotAfter(SafeCertContextHandle safeCertContext, ref Win32Native.FILE_TIME fileTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void _GetDateNotBefore(SafeCertContextHandle safeCertContext, ref Win32Native.FILE_TIME fileTime);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string _GetIssuerName(SafeCertContextHandle safeCertContext, bool legacyV1Mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string _GetPublicKeyOid(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _GetPublicKeyParameters(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _GetPublicKeyValue(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string _GetSubjectInfo(SafeCertContextHandle safeCertContext, uint displayType, bool legacyV1Mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _GetSerialNumber(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern byte[] _GetThumbprint(SafeCertContextHandle safeCertContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _LoadCertFromBlob(byte[] rawData, IntPtr password, uint dwFlags, bool persistKeySet, ref SafeCertContextHandle pCertCtx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _LoadCertFromFile(string fileName, IntPtr password, uint dwFlags, bool persistKeySet, ref SafeCertContextHandle pCertCtx);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void _OpenX509Store(uint storeType, uint flags, string storeName, ref SafeCertStoreHandle safeCertStoreHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern uint _QueryCertBlobType(byte[] rawData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern uint _QueryCertFileType(string fileName);

	[SecurityCritical]
	internal static void DuplicateCertContext(IntPtr handle, SafeCertContextHandle safeCertContext)
	{
		_DuplicateCertContext(handle, ref safeCertContext);
		if (!safeCertContext.IsInvalid)
		{
			GC.ReRegisterForFinalize(safeCertContext);
		}
	}

	[SecurityCritical]
	internal static void LoadCertFromBlob(byte[] rawData, IntPtr password, uint dwFlags, bool persistKeySet, SafeCertContextHandle pCertCtx)
	{
		_LoadCertFromBlob(rawData, password, dwFlags, persistKeySet, ref pCertCtx);
		if (!pCertCtx.IsInvalid)
		{
			GC.ReRegisterForFinalize(pCertCtx);
		}
	}

	[SecurityCritical]
	internal static void LoadCertFromFile(string fileName, IntPtr password, uint dwFlags, bool persistKeySet, SafeCertContextHandle pCertCtx)
	{
		_LoadCertFromFile(fileName, password, dwFlags, persistKeySet, ref pCertCtx);
		if (!pCertCtx.IsInvalid)
		{
			GC.ReRegisterForFinalize(pCertCtx);
		}
	}

	[SecurityCritical]
	private static void OpenX509Store(uint storeType, uint flags, string storeName, SafeCertStoreHandle safeCertStoreHandle)
	{
		_OpenX509Store(storeType, flags, storeName, ref safeCertStoreHandle);
		if (!safeCertStoreHandle.IsInvalid)
		{
			GC.ReRegisterForFinalize(safeCertStoreHandle);
		}
	}
}

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal class X509Utils
{
	private static readonly char[] hexValues = new char[16]
	{
		'0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
		'A', 'B', 'C', 'D', 'E', 'F'
	};

	private X509Utils()
	{
	}

	internal static bool IsCertRdnCharString(uint dwValueType)
	{
		return (dwValueType & 0xFF) >= 3;
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
		if (System.LocalAppContextSwitches.DoNotValidateX509KeyStorageFlags)
		{
			keyStorageFlags &= X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet;
		}
		if ((keyStorageFlags & (X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.UserProtected | X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet)) != keyStorageFlags)
		{
			throw new ArgumentException(System.SR.GetString("Arg_EnumIllegalVal", (int)keyStorageFlags), "keyStorageFlags");
		}
		X509KeyStorageFlags x509KeyStorageFlags = keyStorageFlags & (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet);
		if (x509KeyStorageFlags == (X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.EphemeralKeySet))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_X509_InvalidFlagCombination", x509KeyStorageFlags), "keyStorageFlags");
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

	internal static uint MapX509StoreFlags(StoreLocation storeLocation, OpenFlags flags)
	{
		uint num = 0u;
		switch ((uint)(flags & (OpenFlags.ReadWrite | OpenFlags.MaxAllowed)))
		{
		case 0u:
			num |= 0x8000;
			break;
		case 2u:
			num |= 0x1000;
			break;
		}
		if ((flags & OpenFlags.OpenExistingOnly) == OpenFlags.OpenExistingOnly)
		{
			num |= 0x4000;
		}
		if ((flags & OpenFlags.IncludeArchived) == OpenFlags.IncludeArchived)
		{
			num |= 0x200;
		}
		switch (storeLocation)
		{
		case StoreLocation.LocalMachine:
			num |= 0x20000;
			break;
		case StoreLocation.CurrentUser:
			num |= 0x10000;
			break;
		}
		return num;
	}

	internal static uint MapNameType(X509NameType nameType)
	{
		uint num = 0u;
		switch (nameType)
		{
		case X509NameType.SimpleName:
			return 4u;
		case X509NameType.EmailName:
			return 1u;
		case X509NameType.UpnName:
			return 8u;
		case X509NameType.DnsName:
		case X509NameType.DnsFromAlternativeName:
			return 6u;
		case X509NameType.UrlName:
			return 7u;
		default:
			throw new ArgumentException(System.SR.GetString("Argument_InvalidNameType"));
		}
	}

	internal static uint MapRevocationFlags(X509RevocationMode revocationMode, X509RevocationFlag revocationFlag)
	{
		uint num = 0u;
		switch (revocationMode)
		{
		case X509RevocationMode.NoCheck:
			return num;
		case X509RevocationMode.Offline:
			num |= 0x80000000u;
			break;
		}
		return revocationFlag switch
		{
			X509RevocationFlag.EndCertificateOnly => num | 0x10000000, 
			X509RevocationFlag.EntireChain => num | 0x20000000, 
			_ => num | 0x40000000, 
		};
	}

	internal static string EncodeHexString(byte[] sArray)
	{
		return EncodeHexString(sArray, 0u, (uint)sArray.Length);
	}

	internal static string EncodeHexString(byte[] sArray, uint start, uint end)
	{
		string result = null;
		if (sArray != null)
		{
			char[] array = new char[(end - start) * 2];
			uint num = start;
			uint num2 = 0u;
			for (; num < end; num++)
			{
				uint num3 = (uint)((sArray[num] & 0xF0) >> 4);
				array[num2++] = hexValues[num3];
				num3 = (uint)(sArray[num] & 0xF);
				array[num2++] = hexValues[num3];
			}
			result = new string(array);
		}
		return result;
	}

	internal static string EncodeHexStringFromInt(byte[] sArray, uint start, uint end)
	{
		string result = null;
		if (sArray != null)
		{
			char[] array = new char[(end - start) * 2];
			uint num = end;
			uint num2 = 0u;
			while (num-- > start)
			{
				uint num3 = (uint)(sArray[num] & 0xF0) >> 4;
				array[num2++] = hexValues[num3];
				num3 = (uint)(sArray[num] & 0xF);
				array[num2++] = hexValues[num3];
			}
			result = new string(array);
		}
		return result;
	}

	internal static byte HexToByte(char val)
	{
		if (val <= '9' && val >= '0')
		{
			return (byte)(val - 48);
		}
		if (val >= 'a' && val <= 'f')
		{
			return (byte)(val - 97 + 10);
		}
		if (val >= 'A' && val <= 'F')
		{
			return (byte)(val - 65 + 10);
		}
		return byte.MaxValue;
	}

	internal static uint AlignedLength(uint length)
	{
		return (length + 7) & 0xFFFFFFF8u;
	}

	internal static string DiscardWhiteSpaces(string inputBuffer)
	{
		return DiscardWhiteSpaces(inputBuffer, 0, inputBuffer.Length);
	}

	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
	{
		int num = 0;
		for (int i = 0; i < inputCount; i++)
		{
			if (char.IsWhiteSpace(inputBuffer[inputOffset + i]))
			{
				num++;
			}
		}
		char[] array = new char[inputCount - num];
		num = 0;
		for (int i = 0; i < inputCount; i++)
		{
			if (!char.IsWhiteSpace(inputBuffer[inputOffset + i]))
			{
				array[num++] = inputBuffer[inputOffset + i];
			}
		}
		return new string(array);
	}

	internal static byte[] DecodeHexString(string s)
	{
		string text = DiscardWhiteSpaces(s);
		uint num = (uint)text.Length / 2u;
		byte[] array = new byte[num];
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			array[i] = (byte)((HexToByte(text[num2]) << 4) | HexToByte(text[num2 + 1]));
			num2 += 2;
		}
		return array;
	}

	internal static int GetHexArraySize(byte[] hex)
	{
		int num = hex.Length;
		while (num-- > 0 && hex[num] == 0)
		{
		}
		return num + 1;
	}

	internal static SafeLocalAllocHandle ByteToPtr(byte[] managed)
	{
		SafeLocalAllocHandle safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(managed.Length));
		Marshal.Copy(managed, 0, safeLocalAllocHandle.DangerousGetHandle(), managed.Length);
		return safeLocalAllocHandle;
	}

	internal unsafe static void memcpy(IntPtr source, IntPtr dest, uint size)
	{
		for (uint num = 0u; num < size; num++)
		{
			*(byte*)((long)dest + num) = Marshal.ReadByte(new IntPtr((long)source + num));
		}
	}

	internal static byte[] PtrToByte(IntPtr unmanaged, uint size)
	{
		byte[] array = new byte[size];
		Marshal.Copy(unmanaged, array, 0, array.Length);
		return array;
	}

	internal unsafe static bool MemEqual(byte* pbBuf1, uint cbBuf1, byte* pbBuf2, uint cbBuf2)
	{
		if (cbBuf1 != cbBuf2)
		{
			return false;
		}
		while (cbBuf1-- != 0)
		{
			if (*(pbBuf1++) != *(pbBuf2++))
			{
				return false;
			}
		}
		return true;
	}

	internal static SafeLocalAllocHandle StringToAnsiPtr(string s)
	{
		byte[] array = new byte[s.Length + 1];
		Encoding.ASCII.GetBytes(s, 0, s.Length, array, 0);
		SafeLocalAllocHandle safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(array.Length));
		Marshal.Copy(array, 0, safeLocalAllocHandle.DangerousGetHandle(), array.Length);
		return safeLocalAllocHandle;
	}

	internal static SafeLocalAllocHandle StringToUniPtr(string s)
	{
		byte[] array = new byte[2 * (s.Length + 1)];
		Encoding.Unicode.GetBytes(s, 0, s.Length, array, 0);
		SafeLocalAllocHandle safeLocalAllocHandle = CAPI.LocalAlloc(0u, new IntPtr(array.Length));
		Marshal.Copy(array, 0, safeLocalAllocHandle.DangerousGetHandle(), array.Length);
		return safeLocalAllocHandle;
	}

	internal static System.Security.Cryptography.SafeCertStoreHandle ExportToMemoryStore(X509Certificate2Collection collection)
	{
		StorePermission storePermission = new StorePermission(StorePermissionFlags.AllFlags);
		storePermission.Assert();
		System.Security.Cryptography.SafeCertStoreHandle invalidHandle = System.Security.Cryptography.SafeCertStoreHandle.InvalidHandle;
		invalidHandle = CAPI.CertOpenStore(new IntPtr(2L), 65537u, IntPtr.Zero, 8704u, null);
		if (invalidHandle == null || invalidHandle.IsInvalid)
		{
			throw new CryptographicException(Marshal.GetLastWin32Error());
		}
		X509Certificate2Enumerator enumerator = collection.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			if (!CAPI.CertAddCertificateLinkToStore(invalidHandle, current.CertContext, 4u, System.Security.Cryptography.SafeCertContextHandle.InvalidHandle))
			{
				throw new CryptographicException(Marshal.GetLastWin32Error());
			}
		}
		return invalidHandle;
	}

	internal static uint OidToAlgId(string value)
	{
		SafeLocalAllocHandle pvKey = StringToAnsiPtr(value);
		return CAPI.CryptFindOIDInfo(1u, pvKey, System.Security.Cryptography.OidGroup.All).Algid;
	}

	internal static string FindOidInfo(uint keyType, string keyValue, System.Security.Cryptography.OidGroup oidGroup)
	{
		if (keyValue == null)
		{
			throw new ArgumentNullException("keyValue");
		}
		if (keyValue.Length == 0)
		{
			return null;
		}
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			switch (keyType)
			{
			case 1u:
				safeLocalAllocHandle = StringToAnsiPtr(keyValue);
				break;
			case 2u:
				safeLocalAllocHandle = StringToUniPtr(keyValue);
				break;
			}
			CAPIBase.CRYPT_OID_INFO cRYPT_OID_INFO = CAPI.CryptFindOIDInfo(keyType, safeLocalAllocHandle, oidGroup);
			if (keyType == 1)
			{
				return cRYPT_OID_INFO.pwszName;
			}
			return cRYPT_OID_INFO.pszOID;
		}
		finally
		{
			safeLocalAllocHandle.Dispose();
		}
	}

	internal static string FindOidInfoWithFallback(uint key, string value, System.Security.Cryptography.OidGroup group)
	{
		string text = FindOidInfo(key, value, group);
		if (text == null && group != System.Security.Cryptography.OidGroup.All)
		{
			text = FindOidInfo(key, value, System.Security.Cryptography.OidGroup.All);
		}
		return text;
	}

	internal static void ValidateOidValue(string keyValue)
	{
		if (keyValue == null)
		{
			throw new ArgumentNullException("keyValue");
		}
		int length = keyValue.Length;
		if (length >= 2)
		{
			char c = keyValue[0];
			if ((c == '0' || c == '1' || c == '2') && keyValue[1] == '.' && keyValue[length - 1] != '.')
			{
				bool flag = false;
				int num = 1;
				while (true)
				{
					if (num < length)
					{
						if (!char.IsDigit(keyValue[num]))
						{
							if (keyValue[num] != '.' || keyValue[num + 1] == '.')
							{
								break;
							}
							flag = true;
						}
						num++;
						continue;
					}
					if (!flag)
					{
						break;
					}
					return;
				}
			}
		}
		throw new ArgumentException(System.SR.GetString("Argument_InvalidOidValue"));
	}

	internal static SafeLocalAllocHandle CopyOidsToUnmanagedMemory(OidCollection oids)
	{
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		if (oids == null || oids.Count == 0)
		{
			return invalidHandle;
		}
		List<string> list = new List<string>();
		OidEnumerator enumerator = oids.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Oid current = enumerator.Current;
			list.Add(current.Value);
		}
		IntPtr zero = IntPtr.Zero;
		checked
		{
			int num = list.Count * Marshal.SizeOf(typeof(IntPtr));
			int num2 = 0;
			foreach (string item in list)
			{
				num2 += item.Length + 1;
			}
			invalidHandle = CAPI.LocalAlloc(64u, new IntPtr((uint)num + (uint)num2));
			zero = new IntPtr((long)invalidHandle.DangerousGetHandle() + num);
		}
		for (int i = 0; i < list.Count; i++)
		{
			Marshal.WriteIntPtr(new IntPtr((long)invalidHandle.DangerousGetHandle() + i * Marshal.SizeOf(typeof(IntPtr))), zero);
			byte[] bytes = Encoding.ASCII.GetBytes(list[i]);
			Marshal.Copy(bytes, 0, zero, bytes.Length);
			zero = new IntPtr((long)zero + list[i].Length + 1);
		}
		return invalidHandle;
	}

	internal static X509Certificate2Collection GetCertificates(System.Security.Cryptography.SafeCertStoreHandle safeCertStoreHandle)
	{
		X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
		IntPtr intPtr = CAPI.CertEnumCertificatesInStore(safeCertStoreHandle, IntPtr.Zero);
		while (intPtr != IntPtr.Zero)
		{
			X509Certificate2 certificate = new X509Certificate2(intPtr);
			x509Certificate2Collection.Add(certificate);
			intPtr = CAPI.CertEnumCertificatesInStore(safeCertStoreHandle, intPtr);
		}
		return x509Certificate2Collection;
	}

	internal unsafe static int VerifyCertificate(System.Security.Cryptography.SafeCertContextHandle pCertContext, OidCollection applicationPolicy, OidCollection certificatePolicy, X509RevocationMode revocationMode, X509RevocationFlag revocationFlag, DateTime verificationTime, TimeSpan timeout, X509Certificate2Collection extraStore, IntPtr pszPolicy, IntPtr pdwErrorStatus)
	{
		if (pCertContext == null || pCertContext.IsInvalid)
		{
			throw new ArgumentException("pCertContext");
		}
		CAPIBase.CERT_CHAIN_POLICY_PARA pPolicyPara = new CAPIBase.CERT_CHAIN_POLICY_PARA(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_POLICY_PARA)));
		CAPIBase.CERT_CHAIN_POLICY_STATUS pPolicyStatus = new CAPIBase.CERT_CHAIN_POLICY_STATUS(Marshal.SizeOf(typeof(CAPIBase.CERT_CHAIN_POLICY_STATUS)));
		SafeX509ChainHandle ppChainContext = SafeX509ChainHandle.InvalidHandle;
		int num = X509Chain.BuildChain(new IntPtr(0L), pCertContext, extraStore, applicationPolicy, certificatePolicy, revocationMode, revocationFlag, verificationTime, timeout, ref ppChainContext);
		if (num != 0)
		{
			return num;
		}
		if (CAPISafe.CertVerifyCertificateChainPolicy(pszPolicy, ppChainContext, ref pPolicyPara, ref pPolicyStatus))
		{
			if (pdwErrorStatus != IntPtr.Zero)
			{
				*(uint*)(void*)pdwErrorStatus = pPolicyStatus.dwError;
			}
			if (pPolicyStatus.dwError != 0)
			{
				return 1;
			}
			return 0;
		}
		return Marshal.GetHRForLastWin32Error();
	}

	internal static string GetSystemErrorString(int hr)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		if (CAPISafe.FormatMessage(4608u, IntPtr.Zero, (uint)hr, 0u, stringBuilder, (uint)stringBuilder.Capacity, IntPtr.Zero) != 0)
		{
			return stringBuilder.ToString();
		}
		return System.SR.GetString("Unknown_Error");
	}
}

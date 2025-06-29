using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

internal static class Interop
{
	internal static class Libraries
	{
		internal const string Crypt32 = "crypt32.dll";

		internal const string NCrypt = "ncrypt.dll";
	}

	internal static class Crypt32
	{
		internal struct CRYPT_OID_INFO
		{
			public int cbSize;

			public IntPtr pszOID;

			public IntPtr pwszName;

			public OidGroup dwGroupId;

			public int AlgId;

			public int cbData;

			public IntPtr pbData;

			public string OID
			{
				[SecuritySafeCritical]
				get
				{
					return Marshal.PtrToStringAnsi(pszOID);
				}
			}

			public string Name
			{
				[SecuritySafeCritical]
				get
				{
					return Marshal.PtrToStringUni(pwszName);
				}
			}
		}

		internal enum CryptOidInfoKeyType
		{
			CRYPT_OID_INFO_OID_KEY = 1,
			CRYPT_OID_INFO_NAME_KEY,
			CRYPT_OID_INFO_ALGID_KEY,
			CRYPT_OID_INFO_SIGN_KEY,
			CRYPT_OID_INFO_CNG_ALGID_KEY,
			CRYPT_OID_INFO_CNG_SIGN_KEY
		}

		[SecuritySafeCritical]
		internal static CRYPT_OID_INFO FindOidInfo(CryptOidInfoKeyType keyType, string key, OidGroup group, bool fallBackToAllGroups)
		{
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = keyType switch
				{
					CryptOidInfoKeyType.CRYPT_OID_INFO_OID_KEY => Marshal.StringToCoTaskMemAnsi(key), 
					CryptOidInfoKeyType.CRYPT_OID_INFO_NAME_KEY => Marshal.StringToCoTaskMemUni(key), 
					_ => throw new NotSupportedException(), 
				};
				if (!OidGroupWillNotUseActiveDirectory(group))
				{
					OidGroup oidGroup = group | (OidGroup)(-2147483648);
					IntPtr intPtr2 = CryptFindOIDInfo(keyType, intPtr, oidGroup);
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
				if (fallBackToAllGroups && group != OidGroup.All)
				{
					IntPtr intPtr4 = CryptFindOIDInfo(keyType, intPtr, OidGroup.All);
					if (intPtr4 != IntPtr.Zero)
					{
						return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr4, typeof(CRYPT_OID_INFO));
					}
				}
				return new CRYPT_OID_INFO
				{
					AlgId = -1
				};
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
		public static CRYPT_OID_INFO FindAlgIdOidInfo(int algId)
		{
			int pvKey = algId;
			IntPtr intPtr = CryptFindOIDInfo(CryptOidInfoKeyType.CRYPT_OID_INFO_ALGID_KEY, ref pvKey, OidGroup.HashAlgorithm);
			if (intPtr != IntPtr.Zero)
			{
				return (CRYPT_OID_INFO)Marshal.PtrToStructure(intPtr, typeof(CRYPT_OID_INFO));
			}
			return new CRYPT_OID_INFO
			{
				AlgId = -1
			};
		}

		private static bool OidGroupWillNotUseActiveDirectory(OidGroup group)
		{
			if (group != OidGroup.HashAlgorithm && group != OidGroup.EncryptionAlgorithm && group != OidGroup.PublicKeyAlgorithm && group != OidGroup.SignatureAlgorithm && group != OidGroup.Attribute && group != OidGroup.ExtensionOrAttribute)
			{
				return group == OidGroup.KeyDerivationFunction;
			}
			return true;
		}

		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		[SecurityCritical]
		private static extern IntPtr CryptFindOIDInfo(CryptOidInfoKeyType dwKeyType, IntPtr pvKey, OidGroup group);

		[DllImport("crypt32.dll", CharSet = CharSet.Unicode)]
		[SecurityCritical]
		private static extern IntPtr CryptFindOIDInfo(CryptOidInfoKeyType dwKeyType, ref int pvKey, OidGroup group);
	}

	internal static class NCrypt
	{
		internal enum ErrorCode
		{
			ERROR_SUCCESS = 0,
			NTE_BAD_SIGNATURE = -2146893818,
			NTE_NOT_FOUND = -2146893807,
			NTE_BAD_KEYSET = -2146893802,
			NTE_INVALID_PARAMETER = -2146893785,
			NTE_BUFFER_TOO_SMALL = -2146893784,
			NTE_NOT_SUPPORTED = -2146893783,
			NTE_NO_MORE_ITEMS = -2146893782,
			E_FAIL = -2147467259
		}

		internal enum AsymmetricPaddingMode
		{
			None = 0,
			NCRYPT_NO_PADDING_FLAG = 1,
			NCRYPT_PAD_PKCS1_FLAG = 2,
			NCRYPT_PAD_OAEP_FLAG = 4,
			NCRYPT_PAD_PSS_FLAG = 8
		}

		internal const string NCRYPT_3DES_ALGORITHM = "3DES";

		internal const string NCRYPT_AES_ALGORITHM = "AES";

		internal const string NCRYPT_CIPHER_KEY_BLOB = "CipherKeyBlob";

		internal const int NCRYPT_CIPHER_KEY_BLOB_MAGIC = 1380470851;

		internal const string NCRYPT_CHAINING_MODE_PROPERTY = "Chaining Mode";

		internal const string NCRYPT_INITIALIZATION_VECTOR = "IV";

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		[SecurityCritical]
		internal unsafe static extern ErrorCode NCryptEncrypt(SafeNCryptKeyHandle hKey, byte* pbInput, int cbInput, void* pPaddingInfo, byte* pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		[SecurityCritical]
		internal unsafe static extern ErrorCode NCryptDecrypt(SafeNCryptKeyHandle hKey, byte* pbInput, int cbInput, void* pPaddingInfo, byte* pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);
	}

	internal class BCrypt
	{
		internal enum KeyBlobMagicNumber
		{
			BCRYPT_ECDH_PUBLIC_P256_MAGIC = 827016005,
			BCRYPT_ECDH_PRIVATE_P256_MAGIC = 843793221,
			BCRYPT_ECDH_PUBLIC_P384_MAGIC = 860570437,
			BCRYPT_ECDH_PRIVATE_P384_MAGIC = 877347653,
			BCRYPT_ECDH_PUBLIC_P521_MAGIC = 894124869,
			BCRYPT_ECDH_PRIVATE_P521_MAGIC = 910902085,
			BCRYPT_ECDH_PUBLIC_GENERIC_MAGIC = 1347109701,
			BCRYPT_ECDH_PRIVATE_GENERIC_MAGIC = 1447772997,
			BCRYPT_ECDSA_PUBLIC_P256_MAGIC = 827540293,
			BCRYPT_ECDSA_PRIVATE_P256_MAGIC = 844317509,
			BCRYPT_ECDSA_PUBLIC_P384_MAGIC = 861094725,
			BCRYPT_ECDSA_PRIVATE_P384_MAGIC = 877871941,
			BCRYPT_ECDSA_PUBLIC_P521_MAGIC = 894649157,
			BCRYPT_ECDSA_PRIVATE_P521_MAGIC = 911426373,
			BCRYPT_ECDSA_PUBLIC_GENERIC_MAGIC = 1346650949,
			BCRYPT_ECDSA_PRIVATE_GENERIC_MAGIC = 1447314245,
			BCRYPT_RSAPUBLIC_MAGIC = 826364754,
			BCRYPT_RSAPRIVATE_MAGIC = 843141970,
			BCRYPT_RSAFULLPRIVATE_MAGIC = 859919186,
			BCRYPT_KEY_DATA_BLOB_MAGIC = 1296188491
		}

		internal struct BCRYPT_ECCKEY_BLOB
		{
			internal KeyBlobMagicNumber Magic;

			internal int cbKey;
		}

		internal enum ECC_CURVE_TYPE_ENUM
		{
			BCRYPT_ECC_PRIME_SHORT_WEIERSTRASS_CURVE = 1,
			BCRYPT_ECC_PRIME_TWISTED_EDWARDS_CURVE,
			BCRYPT_ECC_PRIME_MONTGOMERY_CURVE
		}

		internal enum ECC_CURVE_ALG_ID_ENUM
		{
			BCRYPT_NO_CURVE_GENERATION_ALG_ID
		}

		internal struct BCRYPT_ECCFULLKEY_BLOB
		{
			internal KeyBlobMagicNumber Magic;

			internal int Version;

			internal ECC_CURVE_TYPE_ENUM CurveType;

			internal ECC_CURVE_ALG_ID_ENUM CurveGenerationAlgId;

			internal int cbFieldLength;

			internal int cbSubgroupOrder;

			internal int cbCofactor;

			internal int cbSeed;
		}

		internal enum NCryptBufferDescriptors
		{
			NCRYPTBUFFER_ECC_CURVE_NAME = 60
		}

		internal struct BCryptBuffer
		{
			internal int cbBuffer;

			internal NCryptBufferDescriptors BufferType;

			internal IntPtr pvBuffer;
		}

		internal struct BCryptBufferDesc
		{
			internal int ulVersion;

			internal int cBuffers;

			internal IntPtr pBuffers;
		}

		internal struct BCRYPT_ECC_PARAMETER_HEADER
		{
			internal int Version;

			internal ECC_CURVE_TYPE_ENUM CurveType;

			internal ECC_CURVE_ALG_ID_ENUM CurveGenerationAlgId;

			internal int cbFieldLength;

			internal int cbSubgroupOrder;

			internal int cbCofactor;

			internal int cbSeed;
		}

		internal const string BCRYPT_CHAIN_MODE_CBC = "ChainingModeCBC";

		internal const string BCRYPT_CHAIN_MODE_ECB = "ChainingModeECB";

		internal const int BCRYPT_KEY_DATA_BLOB_MAGIC = 1296188491;

		internal const int BCRYPT_KEY_DATA_BLOB_VERSION1 = 1;

		internal const int BCRYPTBUFFER_VERSION = 0;

		internal const int BCRYPT_ECC_PARAMETER_HEADER_V1 = 1;

		internal static void Emit(byte[] blob, ref int offset, byte[] value)
		{
			Buffer.BlockCopy(value, 0, blob, offset, value.Length);
			offset += value.Length;
		}

		internal static byte[] Consume(byte[] blob, ref int offset, int count)
		{
			byte[] array = new byte[count];
			Buffer.BlockCopy(blob, offset, array, 0, count);
			offset += count;
			return array;
		}
	}
}

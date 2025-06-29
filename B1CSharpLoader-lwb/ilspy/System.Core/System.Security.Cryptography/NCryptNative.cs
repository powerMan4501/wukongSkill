using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal static class NCryptNative
{
	internal enum BufferType
	{
		KdfHashAlgorithm,
		KdfSecretPrepend,
		KdfSecretAppend,
		KdfHmacKey,
		KdfTlsLabel,
		KdfTlsSeed
	}

	internal enum ErrorCode
	{
		Success = 0,
		BadSignature = -2146893818,
		NotFound = -2146893807,
		KeyDoesNotExist = -2146893802,
		BufferTooSmall = -2146893784,
		NoMoreItems = -2146893782
	}

	internal static class KeyPropertyName
	{
		internal const string Algorithm = "Algorithm Name";

		internal const string AlgorithmGroup = "Algorithm Group";

		internal const string ExportPolicy = "Export Policy";

		internal const string KeyType = "Key Type";

		internal const string KeyUsage = "Key Usage";

		internal const string Length = "Length";

		internal const string Name = "Name";

		internal const string ParentWindowHandle = "HWND Handle";

		internal const string PublicKeyLength = "PublicKeyLength";

		internal const string ProviderHandle = "Provider Handle";

		internal const string UIPolicy = "UI Policy";

		internal const string UniqueName = "Unique Name";

		internal const string UseContext = "Use Context";

		internal const string ClrIsEphemeral = "CLR IsEphemeral";
	}

	internal static class ProviderPropertyName
	{
		internal const string Name = "Name";
	}

	[Flags]
	internal enum SecretAgreementFlags
	{
		None = 0,
		UseSecretAsHmacKey = 1
	}

	internal struct NCRYPT_UI_POLICY
	{
		public int dwVersion;

		public CngUIProtectionLevels dwFlags;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszCreationTitle;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszFriendlyName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszDescription;
	}

	internal struct NCryptBuffer
	{
		public int cbBuffer;

		public BufferType BufferType;

		public IntPtr pvBuffer;
	}

	internal struct NCryptBufferDesc
	{
		public int ulVersion;

		public int cBuffers;

		public IntPtr pBuffers;
	}

	[SuppressUnmanagedCodeSecurity]
	[SecurityCritical(SecurityCriticalScope.Everything)]
	internal static class UnsafeNativeMethods
	{
		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptCreatePersistedKey(SafeNCryptProviderHandle hProvider, out SafeNCryptKeyHandle phKey, string pszAlgId, string pszKeyName, int dwLegacyKeySpec, CngKeyCreationOptions dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptDeleteKey(SafeNCryptKeyHandle hKey, int flags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptDeriveKey(SafeNCryptSecretHandle hSharedSecret, string pwszKDF, [In] ref NCryptBufferDesc pParameterList, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbDerivedKey, int cbDerivedKey, out int pcbResult, SecretAgreementFlags dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptExportKey(SafeNCryptKeyHandle hKey, IntPtr hExportKey, string pszBlobType, IntPtr pParameterList, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptFinalizeKey(SafeNCryptKeyHandle hKey, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptGetProperty(SafeNCryptHandle hObject, string pszProperty, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptGetProperty(SafeNCryptHandle hObject, string pszProperty, ref int pbOutput, int cbOutput, out int pcbResult, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal static extern ErrorCode NCryptGetProperty(SafeNCryptHandle hObject, string pszProperty, out IntPtr pbOutput, int cbOutput, out int pcbResult, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptImportKey(SafeNCryptProviderHandle hProvider, IntPtr hImportKey, string pszBlobType, IntPtr pParameterList, out SafeNCryptKeyHandle phKey, [MarshalAs(UnmanagedType.LPArray)] byte[] pbData, int cbData, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptOpenKey(SafeNCryptProviderHandle hProvider, out SafeNCryptKeyHandle phKey, string pszKeyName, int dwLegacyKeySpec, CngKeyOpenOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptOpenStorageProvider(out SafeNCryptProviderHandle phProvider, string pszProviderName, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSecretAgreement(SafeNCryptKeyHandle hPrivKey, SafeNCryptKeyHandle hPubKey, out SafeNCryptSecretHandle phSecret, int dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, [MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, string pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
		internal static extern ErrorCode NCryptSetProperty(SafeNCryptHandle hObject, string pszProperty, IntPtr pbInput, int cbInput, CngPropertyOptions dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSignHash(SafeNCryptKeyHandle hKey, IntPtr pPaddingInfo, [MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, out int pcbResult, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptVerifySignature(SafeNCryptKeyHandle hKey, IntPtr pPaddingInfo, [MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, int dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSignHash(SafeNCryptKeyHandle hKey, [In] ref BCryptNative.BCRYPT_PKCS1_PADDING_INFO pPaddingInfo, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptSignHash(SafeNCryptKeyHandle hKey, [In] ref BCryptNative.BCRYPT_PSS_PADDING_INFO pPaddingInfo, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptVerifySignature(SafeNCryptKeyHandle hKey, [In] ref BCryptNative.BCRYPT_PKCS1_PADDING_INFO pPaddingInfo, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptVerifySignature(SafeNCryptKeyHandle hKey, [In] ref BCryptNative.BCRYPT_PSS_PADDING_INFO pPaddingInfo, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbHashValue, int cbHashValue, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbSignature, int cbSignature, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptDecrypt(SafeNCryptKeyHandle hKey, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, [In] ref BCryptNative.BCRYPT_OAEP_PADDING_INFO pvPadding, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptDecrypt(SafeNCryptKeyHandle hKey, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, IntPtr pvPaddingZero, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptEncrypt(SafeNCryptKeyHandle hKey, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, [In] ref BCryptNative.BCRYPT_OAEP_PADDING_INFO pvPadding, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

		[DllImport("ncrypt.dll")]
		internal static extern ErrorCode NCryptEncrypt(SafeNCryptKeyHandle hKey, [In][MarshalAs(UnmanagedType.LPArray)] byte[] pbInput, int cbInput, IntPtr pvPaddingZero, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);
	}

	[SecuritySafeCritical]
	private delegate ErrorCode NCryptDecryptor<T>(SafeNCryptKeyHandle hKey, byte[] pbInput, int cbInput, ref T pvPadding, byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

	[SecuritySafeCritical]
	private delegate ErrorCode NCryptEncryptor<T>(SafeNCryptKeyHandle hKey, byte[] pbInput, int cbInput, ref T pvPadding, byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

	[SecuritySafeCritical]
	private delegate ErrorCode NCryptHashSigner<T>(SafeNCryptKeyHandle hKey, ref T pvPaddingInfo, byte[] pbHashValue, int cbHashValue, byte[] pbSignature, int cbSignature, out int pcbResult, AsymmetricPaddingMode dwFlags);

	[SecuritySafeCritical]
	private delegate ErrorCode NCryptSignatureVerifier<T>(SafeNCryptKeyHandle hKey, ref T pvPaddingInfo, byte[] pbHashValue, int cbHashValue, byte[] pbSignature, int cbSignature, AsymmetricPaddingMode dwFlags) where T : struct;

	private static volatile bool s_haveNcryptSupported;

	private static volatile bool s_ncryptSupported;

	internal static bool NCryptSupported
	{
		[SecuritySafeCritical]
		get
		{
			if (!s_haveNcryptSupported)
			{
				using SafeLibraryHandle safeLibraryHandle = Microsoft.Win32.UnsafeNativeMethods.LoadLibraryEx("ncrypt", IntPtr.Zero, 0);
				s_ncryptSupported = !safeLibraryHandle.IsInvalid;
				s_haveNcryptSupported = true;
			}
			return s_ncryptSupported;
		}
	}

	[SecuritySafeCritical]
	private static byte[] DecryptData<T>(SafeNCryptKeyHandle key, byte[] data, ref T paddingInfo, AsymmetricPaddingMode paddingMode, NCryptDecryptor<T> decryptor) where T : struct
	{
		int pcbResult = 0;
		ErrorCode errorCode = decryptor(key, data, data.Length, ref paddingInfo, null, 0, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = decryptor(key, data, data.Length, ref paddingInfo, array, array.Length, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		if (array.Length != pcbResult)
		{
			byte[] array2 = array;
			Array.Resize(ref array, pcbResult);
			Array.Clear(array2, 0, array2.Length);
		}
		return array;
	}

	[SecuritySafeCritical]
	internal static byte[] DecryptDataPkcs1(SafeNCryptKeyHandle key, byte[] data)
	{
		BCryptNative.BCRYPT_PKCS1_PADDING_INFO paddingInfo = default(BCryptNative.BCRYPT_PKCS1_PADDING_INFO);
		return DecryptData(key, data, ref paddingInfo, AsymmetricPaddingMode.Pkcs1, Pkcs1PaddingDecryptionWrapper);
	}

	[SecuritySafeCritical]
	internal static byte[] DecryptDataOaep(SafeNCryptKeyHandle key, byte[] data, string hashAlgorithm)
	{
		BCryptNative.BCRYPT_OAEP_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_OAEP_PADDING_INFO
		{
			pszAlgId = hashAlgorithm
		};
		return DecryptData(key, data, ref paddingInfo, AsymmetricPaddingMode.Oaep, UnsafeNativeMethods.NCryptDecrypt);
	}

	[SecurityCritical]
	private static ErrorCode Pkcs1PaddingDecryptionWrapper(SafeNCryptKeyHandle hKey, byte[] pbInput, int cbInput, ref BCryptNative.BCRYPT_PKCS1_PADDING_INFO pvPadding, byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags)
	{
		return UnsafeNativeMethods.NCryptDecrypt(hKey, pbInput, cbInput, IntPtr.Zero, pbOutput, cbOutput, out pcbResult, dwFlags);
	}

	[SecuritySafeCritical]
	private static byte[] EncryptData<T>(SafeNCryptKeyHandle key, byte[] data, ref T paddingInfo, AsymmetricPaddingMode paddingMode, NCryptEncryptor<T> encryptor) where T : struct
	{
		int pcbResult = 0;
		ErrorCode errorCode = encryptor(key, data, data.Length, ref paddingInfo, null, 0, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = encryptor(key, data, data.Length, ref paddingInfo, array, array.Length, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	[SecuritySafeCritical]
	internal static byte[] EncryptDataOaep(SafeNCryptKeyHandle key, byte[] data, string hashAlgorithm)
	{
		BCryptNative.BCRYPT_OAEP_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_OAEP_PADDING_INFO
		{
			pszAlgId = hashAlgorithm
		};
		return EncryptData(key, data, ref paddingInfo, AsymmetricPaddingMode.Oaep, UnsafeNativeMethods.NCryptEncrypt);
	}

	[SecuritySafeCritical]
	internal static byte[] EncryptDataPkcs1(SafeNCryptKeyHandle key, byte[] data)
	{
		BCryptNative.BCRYPT_PKCS1_PADDING_INFO paddingInfo = default(BCryptNative.BCRYPT_PKCS1_PADDING_INFO);
		return EncryptData(key, data, ref paddingInfo, AsymmetricPaddingMode.Pkcs1, Pkcs1PaddingEncryptionWrapper);
	}

	[SecurityCritical]
	private static ErrorCode Pkcs1PaddingEncryptionWrapper(SafeNCryptKeyHandle hKey, byte[] pbInput, int cbInput, ref BCryptNative.BCRYPT_PKCS1_PADDING_INFO pvPadding, byte[] pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags)
	{
		return UnsafeNativeMethods.NCryptEncrypt(hKey, pbInput, cbInput, IntPtr.Zero, pbOutput, cbOutput, out pcbResult, dwFlags);
	}

	[SecuritySafeCritical]
	private static byte[] SignHash<T>(SafeNCryptKeyHandle key, byte[] hash, ref T paddingInfo, AsymmetricPaddingMode paddingMode, NCryptHashSigner<T> signer) where T : struct
	{
		int pcbResult = 0;
		ErrorCode errorCode = signer(key, ref paddingInfo, hash, hash.Length, null, 0, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = signer(key, ref paddingInfo, hash, hash.Length, array, array.Length, out pcbResult, paddingMode);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	[SecuritySafeCritical]
	internal static byte[] SignHashPkcs1(SafeNCryptKeyHandle key, byte[] hash, string hashAlgorithm)
	{
		BCryptNative.BCRYPT_PKCS1_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_PKCS1_PADDING_INFO
		{
			pszAlgId = hashAlgorithm
		};
		return SignHash(key, hash, ref paddingInfo, AsymmetricPaddingMode.Pkcs1, UnsafeNativeMethods.NCryptSignHash);
	}

	[SecuritySafeCritical]
	internal static byte[] SignHashPss(SafeNCryptKeyHandle key, byte[] hash, string hashAlgorithm, int saltBytes)
	{
		BCryptNative.BCRYPT_PSS_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_PSS_PADDING_INFO
		{
			pszAlgId = hashAlgorithm,
			cbSalt = saltBytes
		};
		return SignHash(key, hash, ref paddingInfo, AsymmetricPaddingMode.Pss, UnsafeNativeMethods.NCryptSignHash);
	}

	[SecuritySafeCritical]
	private static bool VerifySignature<T>(SafeNCryptKeyHandle key, byte[] hash, byte[] signature, ref T paddingInfo, AsymmetricPaddingMode paddingMode, NCryptSignatureVerifier<T> verifier) where T : struct
	{
		ErrorCode errorCode = verifier(key, ref paddingInfo, hash, hash.Length, signature, signature.Length, paddingMode);
		return errorCode == ErrorCode.Success;
	}

	[SecuritySafeCritical]
	internal static bool VerifySignaturePkcs1(SafeNCryptKeyHandle key, byte[] hash, string hashAlgorithm, byte[] signature)
	{
		BCryptNative.BCRYPT_PKCS1_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_PKCS1_PADDING_INFO
		{
			pszAlgId = hashAlgorithm
		};
		return VerifySignature(key, hash, signature, ref paddingInfo, AsymmetricPaddingMode.Pkcs1, UnsafeNativeMethods.NCryptVerifySignature);
	}

	[SecuritySafeCritical]
	internal static bool VerifySignaturePss(SafeNCryptKeyHandle key, byte[] hash, string hashAlgorithm, int saltBytes, byte[] signature)
	{
		BCryptNative.BCRYPT_PSS_PADDING_INFO paddingInfo = new BCryptNative.BCRYPT_PSS_PADDING_INFO
		{
			pszAlgId = hashAlgorithm,
			cbSalt = saltBytes
		};
		return VerifySignature(key, hash, signature, ref paddingInfo, AsymmetricPaddingMode.Pss, UnsafeNativeMethods.NCryptVerifySignature);
	}

	internal static byte[] BuildEccPublicBlob(string algorithm, BigInteger x, BigInteger y)
	{
		BCryptNative.MapAlgorithmIdToMagic(algorithm, out var algorithmMagic, out var keySize);
		byte[] array = ReverseBytes(FillKeyParameter(x.ToByteArray(), keySize));
		byte[] array2 = ReverseBytes(FillKeyParameter(y.ToByteArray(), keySize));
		byte[] array3 = new byte[8 + array.Length + array2.Length];
		Buffer.BlockCopy(BitConverter.GetBytes((int)algorithmMagic), 0, array3, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(array.Length), 0, array3, 4, 4);
		Buffer.BlockCopy(array, 0, array3, 8, array.Length);
		Buffer.BlockCopy(array2, 0, array3, 8 + array.Length, array2.Length);
		return array3;
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle CreatePersistedKey(SafeNCryptProviderHandle provider, string algorithm, string name, CngKeyCreationOptions options)
	{
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptCreatePersistedKey(provider, out phKey, algorithm, name, 0, options);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static void DeleteKey(SafeNCryptKeyHandle key)
	{
		ErrorCode errorCode = UnsafeNativeMethods.NCryptDeleteKey(key, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		key.SetHandleAsInvalid();
	}

	[SecurityCritical]
	private unsafe static byte[] DeriveKeyMaterial(SafeNCryptSecretHandle secretAgreement, string kdf, string hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		List<NCryptBuffer> list = new List<NCryptBuffer>();
		IntPtr intPtr = IntPtr.Zero;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				intPtr = Marshal.StringToCoTaskMemUni(hashAlgorithm);
			}
			list.Add(new NCryptBuffer
			{
				cbBuffer = (hashAlgorithm.Length + 1) * 2,
				BufferType = BufferType.KdfHashAlgorithm,
				pvBuffer = intPtr
			});
			fixed (byte* ptr = hmacKey)
			{
				fixed (byte* ptr2 = secretPrepend)
				{
					fixed (byte* ptr3 = secretAppend)
					{
						if (ptr != null)
						{
							list.Add(new NCryptBuffer
							{
								cbBuffer = hmacKey.Length,
								BufferType = BufferType.KdfHmacKey,
								pvBuffer = new IntPtr(ptr)
							});
						}
						if (ptr2 != null)
						{
							list.Add(new NCryptBuffer
							{
								cbBuffer = secretPrepend.Length,
								BufferType = BufferType.KdfSecretPrepend,
								pvBuffer = new IntPtr(ptr2)
							});
						}
						if (ptr3 != null)
						{
							list.Add(new NCryptBuffer
							{
								cbBuffer = secretAppend.Length,
								BufferType = BufferType.KdfSecretAppend,
								pvBuffer = new IntPtr(ptr3)
							});
						}
						return DeriveKeyMaterial(secretAgreement, kdf, list.ToArray(), flags);
					}
				}
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(intPtr);
			}
		}
	}

	[SecurityCritical]
	private unsafe static byte[] DeriveKeyMaterial(SafeNCryptSecretHandle secretAgreement, string kdf, NCryptBuffer[] parameters, SecretAgreementFlags flags)
	{
		fixed (NCryptBuffer* value = parameters)
		{
			NCryptBufferDesc pParameterList = new NCryptBufferDesc
			{
				ulVersion = 0,
				cBuffers = parameters.Length,
				pBuffers = new IntPtr(value)
			};
			int pcbResult = 0;
			ErrorCode errorCode = UnsafeNativeMethods.NCryptDeriveKey(secretAgreement, kdf, ref pParameterList, null, 0, out pcbResult, flags);
			if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
			{
				throw new CryptographicException((int)errorCode);
			}
			byte[] array = new byte[pcbResult];
			errorCode = UnsafeNativeMethods.NCryptDeriveKey(secretAgreement, kdf, ref pParameterList, array, array.Length, out pcbResult, flags);
			if (errorCode != ErrorCode.Success)
			{
				throw new CryptographicException((int)errorCode);
			}
			return array;
		}
	}

	[SecurityCritical]
	internal static byte[] DeriveKeyMaterialHash(SafeNCryptSecretHandle secretAgreement, string hashAlgorithm, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		return DeriveKeyMaterial(secretAgreement, "HASH", hashAlgorithm, null, secretPrepend, secretAppend, flags);
	}

	[SecurityCritical]
	internal static byte[] DeriveKeyMaterialHmac(SafeNCryptSecretHandle secretAgreement, string hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend, SecretAgreementFlags flags)
	{
		return DeriveKeyMaterial(secretAgreement, "HMAC", hashAlgorithm, hmacKey, secretPrepend, secretAppend, flags);
	}

	[SecurityCritical]
	internal unsafe static byte[] DeriveKeyMaterialTls(SafeNCryptSecretHandle secretAgreement, byte[] label, byte[] seed, SecretAgreementFlags flags)
	{
		NCryptBuffer[] array = new NCryptBuffer[2];
		fixed (byte* value = label)
		{
			fixed (byte* value2 = seed)
			{
				array[0] = new NCryptBuffer
				{
					cbBuffer = label.Length,
					BufferType = BufferType.KdfTlsLabel,
					pvBuffer = new IntPtr(value)
				};
				array[1] = new NCryptBuffer
				{
					cbBuffer = seed.Length,
					BufferType = BufferType.KdfTlsSeed,
					pvBuffer = new IntPtr(value2)
				};
				return DeriveKeyMaterial(secretAgreement, "TLS_PRF", array, flags);
			}
		}
	}

	[SecurityCritical]
	internal static SafeNCryptSecretHandle DeriveSecretAgreement(SafeNCryptKeyHandle privateKey, SafeNCryptKeyHandle otherPartyPublicKey)
	{
		SafeNCryptSecretHandle phSecret;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSecretAgreement(privateKey, otherPartyPublicKey, out phSecret, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phSecret;
	}

	[SecurityCritical]
	internal static byte[] ExportKey(SafeNCryptKeyHandle key, string format)
	{
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptExportKey(key, IntPtr.Zero, format, IntPtr.Zero, null, 0, out pcbResult, 0);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = UnsafeNativeMethods.NCryptExportKey(key, IntPtr.Zero, format, IntPtr.Zero, array, array.Length, out pcbResult, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	private static byte[] FillKeyParameter(byte[] key, int keySize)
	{
		int num = keySize / 8 + ((keySize % 8 != 0) ? 1 : 0);
		if (key.Length == num)
		{
			return key;
		}
		byte[] array = new byte[num];
		Buffer.BlockCopy(key, 0, array, 0, Math.Min(key.Length, array.Length));
		return array;
	}

	[SecurityCritical]
	internal static void FinalizeKey(SafeNCryptKeyHandle key)
	{
		ErrorCode errorCode = UnsafeNativeMethods.NCryptFinalizeKey(key, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal static byte[] GetProperty(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions, out bool foundProperty)
	{
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, null, 0, out pcbResult, propertyOptions);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall && errorCode != ErrorCode.NotFound)
		{
			throw new CryptographicException((int)errorCode);
		}
		foundProperty = errorCode != ErrorCode.NotFound;
		byte[] array = null;
		if (errorCode != ErrorCode.NotFound && pcbResult > 0)
		{
			array = new byte[pcbResult];
			errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, array, array.Length, out pcbResult, propertyOptions);
			if (errorCode != ErrorCode.Success)
			{
				throw new CryptographicException((int)errorCode);
			}
			foundProperty = true;
		}
		return array;
	}

	[SecurityCritical]
	internal static int GetPropertyAsDWord(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (!foundProperty || property == null)
		{
			return 0;
		}
		return BitConverter.ToInt32(property, 0);
	}

	[SecurityCritical]
	internal static ErrorCode GetPropertyAsInt(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions, ref int propertyValue)
	{
		int pcbResult;
		return UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, ref propertyValue, 4, out pcbResult, propertyOptions);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static IntPtr GetPropertyAsIntPtr(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		int pcbResult = IntPtr.Size;
		IntPtr pbOutput = IntPtr.Zero;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptGetProperty(ncryptObject, propertyName, out pbOutput, IntPtr.Size, out pcbResult, propertyOptions);
		return errorCode switch
		{
			ErrorCode.NotFound => IntPtr.Zero, 
			ErrorCode.Success => pbOutput, 
			_ => throw new CryptographicException((int)errorCode), 
		};
	}

	[SecurityCritical]
	internal unsafe static string GetPropertyAsString(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions)
	{
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (!foundProperty || property == null)
		{
			return null;
		}
		if (property.Length == 0)
		{
			return string.Empty;
		}
		fixed (byte* value = property)
		{
			return Marshal.PtrToStringUni(new IntPtr(value));
		}
	}

	[SecurityCritical]
	internal unsafe static T GetPropertyAsStruct<T>(SafeNCryptHandle ncryptObject, string propertyName, CngPropertyOptions propertyOptions) where T : struct
	{
		bool foundProperty;
		byte[] property = GetProperty(ncryptObject, propertyName, propertyOptions, out foundProperty);
		if (!foundProperty || property == null)
		{
			return new T();
		}
		fixed (byte* value = property)
		{
			return (T)Marshal.PtrToStructure(new IntPtr(value), typeof(T));
		}
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle ImportKey(SafeNCryptProviderHandle provider, byte[] keyBlob, string format)
	{
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptImportKey(provider, IntPtr.Zero, format, IntPtr.Zero, out phKey, keyBlob, keyBlob.Length, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle ImportKey(SafeNCryptProviderHandle provider, byte[] keyBlob, string format, IntPtr pParametersList)
	{
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptImportKey(provider, IntPtr.Zero, format, pParametersList, out phKey, keyBlob, keyBlob.Length, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static SafeNCryptKeyHandle OpenKey(SafeNCryptProviderHandle provider, string name, CngKeyOpenOptions options)
	{
		SafeNCryptKeyHandle phKey = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptOpenKey(provider, out phKey, name, 0, options);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phKey;
	}

	[SecurityCritical]
	internal static SafeNCryptProviderHandle OpenStorageProvider(string providerName)
	{
		SafeNCryptProviderHandle phProvider = null;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptOpenStorageProvider(out phProvider, providerName, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return phProvider;
	}

	private static byte[] ReverseBytes(byte[] buffer)
	{
		return ReverseBytes(buffer, 0, buffer.Length, padWithZeroByte: false);
	}

	private static byte[] ReverseBytes(byte[] buffer, int offset, int count)
	{
		return ReverseBytes(buffer, offset, count, padWithZeroByte: false);
	}

	private static byte[] ReverseBytes(byte[] buffer, int offset, int count, bool padWithZeroByte)
	{
		byte[] array = ((!padWithZeroByte) ? new byte[count] : new byte[count + 1]);
		int num = offset + count - 1;
		for (int i = 0; i < count; i++)
		{
			array[i] = buffer[num - i];
		}
		return array;
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, int value, CngPropertyOptions propertyOptions)
	{
		SetProperty(ncryptObject, propertyName, BitConverter.GetBytes(value), propertyOptions);
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, string value, CngPropertyOptions propertyOptions)
	{
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSetProperty(ncryptObject, propertyName, value, (value.Length + 1) * 2, propertyOptions);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal unsafe static void SetProperty<T>(SafeNCryptHandle ncryptObject, string propertyName, T value, CngPropertyOptions propertyOptions) where T : struct
	{
		byte[] array = new byte[Marshal.SizeOf(typeof(T))];
		fixed (byte* value2 = array)
		{
			bool flag = false;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					Marshal.StructureToPtr((object)value, new IntPtr(value2), fDeleteOld: false);
					flag = true;
				}
				SetProperty(ncryptObject, propertyName, array, propertyOptions);
			}
			finally
			{
				if (flag)
				{
					Marshal.DestroyStructure(new IntPtr(value2), typeof(T));
				}
			}
		}
	}

	[SecurityCritical]
	internal static void SetProperty(SafeNCryptHandle ncryptObject, string propertyName, byte[] value, CngPropertyOptions propertyOptions)
	{
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSetProperty(ncryptObject, propertyName, value, (value != null) ? value.Length : 0, propertyOptions);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
	}

	[SecurityCritical]
	internal static byte[] SignHash(SafeNCryptKeyHandle key, byte[] hash)
	{
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, null, 0, out pcbResult, 0);
		if (errorCode != ErrorCode.Success && errorCode != ErrorCode.BufferTooSmall)
		{
			throw new CryptographicException((int)errorCode);
		}
		byte[] array = new byte[pcbResult];
		errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, array, array.Length, out pcbResult, 0);
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		return array;
	}

	[SecurityCritical]
	internal static byte[] SignHash(SafeNCryptKeyHandle key, byte[] hash, int expectedSize)
	{
		byte[] array = new byte[expectedSize];
		int pcbResult = 0;
		ErrorCode errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, array, array.Length, out pcbResult, 0);
		if (errorCode == ErrorCode.BufferTooSmall)
		{
			array = new byte[pcbResult];
			errorCode = UnsafeNativeMethods.NCryptSignHash(key, IntPtr.Zero, hash, hash.Length, array, array.Length, out pcbResult, 0);
		}
		if (errorCode != ErrorCode.Success)
		{
			throw new CryptographicException((int)errorCode);
		}
		Array.Resize(ref array, pcbResult);
		return array;
	}

	internal static void UnpackEccPublicBlob(byte[] blob, out BigInteger x, out BigInteger y)
	{
		int num = BitConverter.ToInt32(blob, 4);
		x = new BigInteger(ReverseBytes(blob, 8, num, padWithZeroByte: true));
		y = new BigInteger(ReverseBytes(blob, 8 + num, num, padWithZeroByte: true));
	}

	[SecurityCritical]
	internal static bool VerifySignature(SafeNCryptKeyHandle key, byte[] hash, byte[] signature)
	{
		ErrorCode errorCode = UnsafeNativeMethods.NCryptVerifySignature(key, IntPtr.Zero, hash, hash.Length, signature, signature.Length, 0);
		return errorCode == ErrorCode.Success;
	}
}

using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace System.Security.Cryptography;

[ComVisible(true)]
public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
{
	private int _dwKeySize;

	private CspParameters _parameters;

	private bool _randomKeyContainer;

	[SecurityCritical]
	private SafeProvHandle _safeProvHandle;

	[SecurityCritical]
	private SafeKeyHandle _safeKeyHandle;

	private static volatile CspProviderFlags s_UseMachineKeyStore;

	[ComVisible(false)]
	public bool PublicOnly
	{
		[SecuritySafeCritical]
		get
		{
			GetKeyPair();
			byte[] array = Utils._GetKeyParameter(_safeKeyHandle, 2u);
			return array[0] == 1;
		}
	}

	[ComVisible(false)]
	public CspKeyContainerInfo CspKeyContainerInfo
	{
		[SecuritySafeCritical]
		get
		{
			GetKeyPair();
			return new CspKeyContainerInfo(_parameters, _randomKeyContainer);
		}
	}

	public override int KeySize
	{
		[SecuritySafeCritical]
		get
		{
			GetKeyPair();
			byte[] array = Utils._GetKeyParameter(_safeKeyHandle, 1u);
			_dwKeySize = array[0] | (array[1] << 8) | (array[2] << 16) | (array[3] << 24);
			return _dwKeySize;
		}
	}

	public override string KeyExchangeAlgorithm
	{
		get
		{
			if (_parameters.KeyNumber == 1)
			{
				return "RSA-PKCS1-KeyEx";
			}
			return null;
		}
	}

	public override string SignatureAlgorithm => "http://www.w3.org/2000/09/xmldsig#rsa-sha1";

	public static bool UseMachineKeyStore
	{
		get
		{
			return s_UseMachineKeyStore == CspProviderFlags.UseMachineKeyStore;
		}
		set
		{
			s_UseMachineKeyStore = (value ? CspProviderFlags.UseMachineKeyStore : CspProviderFlags.NoFlags);
		}
	}

	public bool PersistKeyInCsp
	{
		[SecuritySafeCritical]
		get
		{
			if (_safeProvHandle == null)
			{
				lock (this)
				{
					if (_safeProvHandle == null)
					{
						_safeProvHandle = Utils.CreateProvHandle(_parameters, _randomKeyContainer);
					}
				}
			}
			return Utils.GetPersistKeyInCsp(_safeProvHandle);
		}
		[SecuritySafeCritical]
		set
		{
			bool persistKeyInCsp = PersistKeyInCsp;
			if (value == persistKeyInCsp)
			{
				return;
			}
			if (!CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
			{
				KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
				if (!value)
				{
					KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Delete);
					keyContainerPermission.AccessEntries.Add(accessEntry);
				}
				else
				{
					KeyContainerPermissionAccessEntry accessEntry2 = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Create);
					keyContainerPermission.AccessEntries.Add(accessEntry2);
				}
				keyContainerPermission.Demand();
			}
			Utils.SetPersistKeyInCsp(_safeProvHandle, value);
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void DecryptKey(SafeKeyHandle pKeyContext, [MarshalAs(UnmanagedType.LPArray)] byte[] pbEncryptedKey, int cbEncryptedKey, [MarshalAs(UnmanagedType.Bool)] bool fOAEP, ObjectHandleOnStack ohRetDecryptedKey);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void EncryptKey(SafeKeyHandle pKeyContext, [MarshalAs(UnmanagedType.LPArray)] byte[] pbKey, int cbKey, [MarshalAs(UnmanagedType.Bool)] bool fOAEP, ObjectHandleOnStack ohRetEncryptedKey);

	[SecuritySafeCritical]
	public RSACryptoServiceProvider()
		: this(0, new CspParameters(24, null, null, s_UseMachineKeyStore), useDefaultKeySize: true)
	{
	}

	[SecuritySafeCritical]
	public RSACryptoServiceProvider(int dwKeySize)
		: this(dwKeySize, new CspParameters(24, null, null, s_UseMachineKeyStore), useDefaultKeySize: false)
	{
	}

	[SecuritySafeCritical]
	public RSACryptoServiceProvider(CspParameters parameters)
		: this(0, parameters, useDefaultKeySize: true)
	{
	}

	[SecuritySafeCritical]
	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		: this(dwKeySize, parameters, useDefaultKeySize: false)
	{
	}

	[SecurityCritical]
	private RSACryptoServiceProvider(int dwKeySize, CspParameters parameters, bool useDefaultKeySize)
	{
		if (dwKeySize < 0)
		{
			throw new ArgumentOutOfRangeException("dwKeySize", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		_parameters = Utils.SaveCspParameters(CspAlgorithmType.Rsa, parameters, s_UseMachineKeyStore, ref _randomKeyContainer);
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(384, 16384, 8)
		};
		_dwKeySize = (useDefaultKeySize ? 1024 : dwKeySize);
		if (!_randomKeyContainer || Environment.GetCompatibilityFlag(CompatibilityFlag.EagerlyGenerateRandomAsymmKeys))
		{
			GetKeyPair();
		}
	}

	[SecurityCritical]
	private void GetKeyPair()
	{
		if (_safeKeyHandle != null)
		{
			return;
		}
		lock (this)
		{
			if (_safeKeyHandle == null)
			{
				Utils.GetKeyPairHelper(CspAlgorithmType.Rsa, _parameters, _randomKeyContainer, _dwKeySize, ref _safeProvHandle, ref _safeKeyHandle);
			}
		}
	}

	[SecuritySafeCritical]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (_safeKeyHandle != null && !_safeKeyHandle.IsClosed)
		{
			_safeKeyHandle.Dispose();
		}
		if (_safeProvHandle != null && !_safeProvHandle.IsClosed)
		{
			_safeProvHandle.Dispose();
		}
	}

	[SecuritySafeCritical]
	public override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		GetKeyPair();
		if (includePrivateParameters && !CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Export);
			keyContainerPermission.AccessEntries.Add(accessEntry);
			keyContainerPermission.Demand();
		}
		RSACspObject rSACspObject = new RSACspObject();
		int blobType = (includePrivateParameters ? 7 : 6);
		Utils._ExportKey(_safeKeyHandle, blobType, rSACspObject);
		return RSAObjectToStruct(rSACspObject);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public byte[] ExportCspBlob(bool includePrivateParameters)
	{
		GetKeyPair();
		return Utils.ExportCspBlobHelper(includePrivateParameters, _parameters, _safeKeyHandle);
	}

	[SecuritySafeCritical]
	public override void ImportParameters(RSAParameters parameters)
	{
		if (_safeKeyHandle != null && !_safeKeyHandle.IsClosed)
		{
			_safeKeyHandle.Dispose();
			_safeKeyHandle = null;
		}
		RSACspObject cspObject = RSAStructToObject(parameters);
		_safeKeyHandle = SafeKeyHandle.InvalidHandle;
		if (IsPublic(parameters))
		{
			Utils._ImportKey(Utils.StaticProvHandle, 41984, CspProviderFlags.NoFlags, cspObject, ref _safeKeyHandle);
			return;
		}
		if (!CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Import);
			keyContainerPermission.AccessEntries.Add(accessEntry);
			keyContainerPermission.Demand();
		}
		if (_safeProvHandle == null)
		{
			_safeProvHandle = Utils.CreateProvHandle(_parameters, _randomKeyContainer);
		}
		Utils._ImportKey(_safeProvHandle, 41984, _parameters.Flags, cspObject, ref _safeKeyHandle);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public void ImportCspBlob(byte[] keyBlob)
	{
		Utils.ImportCspBlobHelper(CspAlgorithmType.Rsa, keyBlob, IsPublic(keyBlob), ref _parameters, _randomKeyContainer, ref _safeProvHandle, ref _safeKeyHandle);
	}

	public byte[] SignData(Stream inputStream, object halg)
	{
		int calgHash = Utils.ObjToAlgId(halg, OidGroup.HashAlgorithm);
		HashAlgorithm hashAlgorithm = Utils.ObjToHashAlgorithm(halg);
		byte[] rgbHash = hashAlgorithm.ComputeHash(inputStream);
		return SignHash(rgbHash, calgHash);
	}

	public byte[] SignData(byte[] buffer, object halg)
	{
		int calgHash = Utils.ObjToAlgId(halg, OidGroup.HashAlgorithm);
		HashAlgorithm hashAlgorithm = Utils.ObjToHashAlgorithm(halg);
		byte[] rgbHash = hashAlgorithm.ComputeHash(buffer);
		return SignHash(rgbHash, calgHash);
	}

	public byte[] SignData(byte[] buffer, int offset, int count, object halg)
	{
		int calgHash = Utils.ObjToAlgId(halg, OidGroup.HashAlgorithm);
		HashAlgorithm hashAlgorithm = Utils.ObjToHashAlgorithm(halg);
		byte[] rgbHash = hashAlgorithm.ComputeHash(buffer, offset, count);
		return SignHash(rgbHash, calgHash);
	}

	public bool VerifyData(byte[] buffer, object halg, byte[] signature)
	{
		int calgHash = Utils.ObjToAlgId(halg, OidGroup.HashAlgorithm);
		HashAlgorithm hashAlgorithm = Utils.ObjToHashAlgorithm(halg);
		byte[] rgbHash = hashAlgorithm.ComputeHash(buffer);
		return VerifyHash(rgbHash, calgHash, signature);
	}

	public byte[] SignHash(byte[] rgbHash, string str)
	{
		if (rgbHash == null)
		{
			throw new ArgumentNullException("rgbHash");
		}
		if (PublicOnly)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_CSP_NoPrivateKey"));
		}
		int calgHash = X509Utils.NameOrOidToAlgId(str, OidGroup.HashAlgorithm);
		return SignHash(rgbHash, calgHash);
	}

	[SecuritySafeCritical]
	internal byte[] SignHash(byte[] rgbHash, int calgHash)
	{
		GetKeyPair();
		if (!CspKeyContainerInfo.RandomlyGenerated && !CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Sign);
			keyContainerPermission.AccessEntries.Add(accessEntry);
			keyContainerPermission.Demand();
		}
		return Utils.SignValue(_safeKeyHandle, _parameters.KeyNumber, 9216, calgHash, rgbHash);
	}

	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
	{
		if (rgbHash == null)
		{
			throw new ArgumentNullException("rgbHash");
		}
		if (rgbSignature == null)
		{
			throw new ArgumentNullException("rgbSignature");
		}
		int calgHash = X509Utils.NameOrOidToAlgId(str, OidGroup.HashAlgorithm);
		return VerifyHash(rgbHash, calgHash, rgbSignature);
	}

	[SecuritySafeCritical]
	internal bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
	{
		GetKeyPair();
		return Utils.VerifySign(_safeKeyHandle, 9216, calgHash, rgbHash, rgbSignature);
	}

	[SecuritySafeCritical]
	public byte[] Encrypt(byte[] rgb, bool fOAEP)
	{
		if (rgb == null)
		{
			throw new ArgumentNullException("rgb");
		}
		GetKeyPair();
		byte[] o = null;
		EncryptKey(_safeKeyHandle, rgb, rgb.Length, fOAEP, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	[SecuritySafeCritical]
	public byte[] Decrypt(byte[] rgb, bool fOAEP)
	{
		if (rgb == null)
		{
			throw new ArgumentNullException("rgb");
		}
		GetKeyPair();
		if (rgb.Length > KeySize / 8)
		{
			throw new CryptographicException(Environment.GetResourceString("Cryptography_Padding_DecDataTooBig", KeySize / 8));
		}
		if (!CspKeyContainerInfo.RandomlyGenerated && !CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			KeyContainerPermission keyContainerPermission = new KeyContainerPermission(KeyContainerPermissionFlags.NoFlags);
			KeyContainerPermissionAccessEntry accessEntry = new KeyContainerPermissionAccessEntry(_parameters, KeyContainerPermissionFlags.Decrypt);
			keyContainerPermission.AccessEntries.Add(accessEntry);
			keyContainerPermission.Demand();
		}
		byte[] o = null;
		DecryptKey(_safeKeyHandle, rgb, rgb.Length, fOAEP, JitHelpers.GetObjectHandleOnStack(ref o));
		return o;
	}

	public override byte[] DecryptValue(byte[] rgb)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Method"));
	}

	public override byte[] EncryptValue(byte[] rgb)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_Method"));
	}

	private static RSAParameters RSAObjectToStruct(RSACspObject rsaCspObject)
	{
		return new RSAParameters
		{
			Exponent = rsaCspObject.Exponent,
			Modulus = rsaCspObject.Modulus,
			P = rsaCspObject.P,
			Q = rsaCspObject.Q,
			DP = rsaCspObject.DP,
			DQ = rsaCspObject.DQ,
			InverseQ = rsaCspObject.InverseQ,
			D = rsaCspObject.D
		};
	}

	private static RSACspObject RSAStructToObject(RSAParameters rsaParams)
	{
		RSACspObject rSACspObject = new RSACspObject();
		rSACspObject.Exponent = rsaParams.Exponent;
		rSACspObject.Modulus = rsaParams.Modulus;
		rSACspObject.P = rsaParams.P;
		rSACspObject.Q = rsaParams.Q;
		rSACspObject.DP = rsaParams.DP;
		rSACspObject.DQ = rsaParams.DQ;
		rSACspObject.InverseQ = rsaParams.InverseQ;
		rSACspObject.D = rsaParams.D;
		return rSACspObject;
	}

	private static bool IsPublic(byte[] keyBlob)
	{
		if (keyBlob == null)
		{
			throw new ArgumentNullException("keyBlob");
		}
		if (keyBlob[0] != 6)
		{
			return false;
		}
		if (keyBlob[11] != 49 || keyBlob[10] != 65 || keyBlob[9] != 83 || keyBlob[8] != 82)
		{
			return false;
		}
		return true;
	}

	private static bool IsPublic(RSAParameters rsaParams)
	{
		return rsaParams.P == null;
	}

	[SecuritySafeCritical]
	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		using SafeHashHandle hHash = Utils.CreateHash(Utils.StaticProvHandle, GetAlgorithmId(hashAlgorithm));
		Utils.HashData(hHash, data, offset, count);
		return Utils.EndHash(hHash);
	}

	[SecuritySafeCritical]
	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		using SafeHashHandle hHash = Utils.CreateHash(Utils.StaticProvHandle, GetAlgorithmId(hashAlgorithm));
		byte[] array = new byte[4096];
		int num = 0;
		do
		{
			num = data.Read(array, 0, array.Length);
			if (num > 0)
			{
				Utils.HashData(hHash, array, 0, num);
			}
		}
		while (num > 0);
		return Utils.EndHash(hHash);
	}

	private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
	{
		return hashAlgorithm.Name switch
		{
			"MD5" => 32771, 
			"SHA1" => 32772, 
			"SHA256" => 32780, 
			"SHA384" => 32781, 
			"SHA512" => 32782, 
			_ => throw new CryptographicException(Environment.GetResourceString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name)), 
		};
	}

	public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding == RSAEncryptionPadding.Pkcs1)
		{
			return Encrypt(data, fOAEP: false);
		}
		if (padding == RSAEncryptionPadding.OaepSHA1)
		{
			return Encrypt(data, fOAEP: true);
		}
		throw PaddingModeNotSupported();
	}

	public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding == RSAEncryptionPadding.Pkcs1)
		{
			return Decrypt(data, fOAEP: false);
		}
		if (padding == RSAEncryptionPadding.OaepSHA1)
		{
			return Decrypt(data, fOAEP: true);
		}
		throw PaddingModeNotSupported();
	}

	public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw RSA.HashAlgorithmNameNullOrEmpty();
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding != RSASignaturePadding.Pkcs1)
		{
			throw PaddingModeNotSupported();
		}
		return SignHash(hash, GetAlgorithmId(hashAlgorithm));
	}

	public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw RSA.HashAlgorithmNameNullOrEmpty();
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		if (padding != RSASignaturePadding.Pkcs1)
		{
			throw PaddingModeNotSupported();
		}
		return VerifyHash(hash, GetAlgorithmId(hashAlgorithm), signature);
	}

	private static Exception PaddingModeNotSupported()
	{
		return new CryptographicException(Environment.GetResourceString("Cryptography_InvalidPaddingMode"));
	}
}

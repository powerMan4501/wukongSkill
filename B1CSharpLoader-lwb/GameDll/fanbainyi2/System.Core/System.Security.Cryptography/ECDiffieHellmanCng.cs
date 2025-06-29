using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDiffieHellmanCng : ECDiffieHellman
{
	private static KeySizes[] s_legalKeySizes = new KeySizes[2]
	{
		new KeySizes(256, 384, 128),
		new KeySizes(521, 521, 0)
	};

	private CngAlgorithm m_hashAlgorithm = CngAlgorithm.Sha256;

	private byte[] m_hmacKey;

	private CngKey m_key;

	private ECDiffieHellmanKeyDerivationFunction m_kdf;

	private byte[] m_label;

	private byte[] m_secretAppend;

	private byte[] m_secretPrepend;

	private byte[] m_seed;

	public CngAlgorithm HashAlgorithm
	{
		get
		{
			return m_hashAlgorithm;
		}
		set
		{
			if (m_hashAlgorithm == null)
			{
				throw new ArgumentNullException("value");
			}
			m_hashAlgorithm = value;
		}
	}

	public byte[] HmacKey
	{
		get
		{
			return m_hmacKey;
		}
		set
		{
			m_hmacKey = value;
		}
	}

	public ECDiffieHellmanKeyDerivationFunction KeyDerivationFunction
	{
		get
		{
			return m_kdf;
		}
		set
		{
			if (value < ECDiffieHellmanKeyDerivationFunction.Hash || value > ECDiffieHellmanKeyDerivationFunction.Tls)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_kdf = value;
		}
	}

	public byte[] Label
	{
		get
		{
			return m_label;
		}
		set
		{
			m_label = value;
		}
	}

	public byte[] SecretAppend
	{
		get
		{
			return m_secretAppend;
		}
		set
		{
			m_secretAppend = value;
		}
	}

	public byte[] SecretPrepend
	{
		get
		{
			return m_secretPrepend;
		}
		set
		{
			m_secretPrepend = value;
		}
	}

	public byte[] Seed
	{
		get
		{
			return m_seed;
		}
		set
		{
			m_seed = value;
		}
	}

	public CngKey Key
	{
		get
		{
			if (m_key != null && m_key.KeySize != KeySize)
			{
				m_key.Dispose();
				m_key = null;
			}
			if (m_key == null)
			{
				CngAlgorithm algorithm = null;
				switch (KeySize)
				{
				case 256:
					algorithm = CngAlgorithm.ECDiffieHellmanP256;
					break;
				case 384:
					algorithm = CngAlgorithm.ECDiffieHellmanP384;
					break;
				case 521:
					algorithm = CngAlgorithm.ECDiffieHellmanP521;
					break;
				}
				CngKeyCreationParameters creationParameters = new CngKeyCreationParameters
				{
					ExportPolicy = CngExportPolicies.AllowPlaintextExport
				};
				m_key = CngKey.Create(algorithm, null, creationParameters);
			}
			return m_key;
		}
		private set
		{
			if (value.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"));
			}
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = value;
			KeySizeValue = m_key.KeySize;
		}
	}

	public override ECDiffieHellmanPublicKey PublicKey => ECDiffieHellmanCngPublicKey.FromKey(Key);

	public bool UseSecretAgreementAsHmacKey => HmacKey == null;

	public ECDiffieHellmanCng()
		: this(521)
	{
	}

	public ECDiffieHellmanCng(int keySize)
	{
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	public ECDiffieHellmanCng(ECCurve curve)
	{
		GenerateKey(curve);
	}

	[SecuritySafeCritical]
	public ECDiffieHellmanCng(CngKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "key");
		}
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		using (SafeNCryptKeyHandle keyHandle = key.Handle)
		{
			Key = CngKey.Open(keyHandle, key.IsEphemeral ? CngKeyHandleOpenOptions.EphemeralKey : CngKeyHandleOpenOptions.None);
		}
		CodeAccessPermission.RevertAssert();
		KeySizeValue = m_key.KeySize;
	}

	public override byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (!(otherPartyPublicKey is ECDiffieHellmanCngPublicKey eCDiffieHellmanCngPublicKey))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgExpectedECDiffieHellmanCngPublicKey"));
		}
		using CngKey otherPartyPublicKey2 = eCDiffieHellmanCngPublicKey.Import();
		return DeriveKeyMaterial(otherPartyPublicKey2);
	}

	[SecuritySafeCritical]
	public byte[] DeriveKeyMaterial(CngKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (otherPartyPublicKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "otherPartyPublicKey");
		}
		if (otherPartyPublicKey.KeySize != KeySize)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHKeySizeMismatch"), "otherPartyPublicKey");
		}
		NCryptNative.SecretAgreementFlags flags = (UseSecretAgreementAsHmacKey ? NCryptNative.SecretAgreementFlags.UseSecretAsHmacKey : NCryptNative.SecretAgreementFlags.None);
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		using SafeNCryptKeyHandle privateKey = Key.Handle;
		using SafeNCryptKeyHandle otherPartyPublicKey2 = otherPartyPublicKey.Handle;
		CodeAccessPermission.RevertAssert();
		using SafeNCryptSecretHandle secretAgreement = NCryptNative.DeriveSecretAgreement(privateKey, otherPartyPublicKey2);
		if (KeyDerivationFunction == ECDiffieHellmanKeyDerivationFunction.Hash)
		{
			byte[] secretAppend = ((SecretAppend == null) ? null : (SecretAppend.Clone() as byte[]));
			byte[] secretPrepend = ((SecretPrepend == null) ? null : (SecretPrepend.Clone() as byte[]));
			return NCryptNative.DeriveKeyMaterialHash(secretAgreement, HashAlgorithm.Algorithm, secretPrepend, secretAppend, flags);
		}
		if (KeyDerivationFunction == ECDiffieHellmanKeyDerivationFunction.Hmac)
		{
			byte[] hmacKey = ((HmacKey == null) ? null : (HmacKey.Clone() as byte[]));
			byte[] secretAppend2 = ((SecretAppend == null) ? null : (SecretAppend.Clone() as byte[]));
			byte[] secretPrepend2 = ((SecretPrepend == null) ? null : (SecretPrepend.Clone() as byte[]));
			return NCryptNative.DeriveKeyMaterialHmac(secretAgreement, HashAlgorithm.Algorithm, hmacKey, secretPrepend2, secretAppend2, flags);
		}
		byte[] array = ((Label == null) ? null : (Label.Clone() as byte[]));
		byte[] array2 = ((Seed == null) ? null : (Seed.Clone() as byte[]));
		if (array == null || array2 == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_TlsRequiresLabelAndSeed"));
		}
		return NCryptNative.DeriveKeyMaterialTls(secretAgreement, array, array2, flags);
	}

	[SecuritySafeCritical]
	public override byte[] DeriveKeyFromHash(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] secretPrepend, byte[] secretAppend)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		using SafeNCryptSecretHandle secretAgreement = DeriveSecretAgreementHandle(otherPartyPublicKey);
		return NCryptNative.DeriveKeyMaterialHash(secretAgreement, hashAlgorithm.Name, secretPrepend, secretAppend, NCryptNative.SecretAgreementFlags.None);
	}

	[SecuritySafeCritical]
	public override byte[] DeriveKeyFromHmac(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		using SafeNCryptSecretHandle secretAgreement = DeriveSecretAgreementHandle(otherPartyPublicKey);
		NCryptNative.SecretAgreementFlags flags = ((hmacKey == null) ? NCryptNative.SecretAgreementFlags.UseSecretAsHmacKey : NCryptNative.SecretAgreementFlags.None);
		return NCryptNative.DeriveKeyMaterialHmac(secretAgreement, hashAlgorithm.Name, hmacKey, secretPrepend, secretAppend, flags);
	}

	[SecuritySafeCritical]
	public override byte[] DeriveKeyTls(ECDiffieHellmanPublicKey otherPartyPublicKey, byte[] prfLabel, byte[] prfSeed)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (prfLabel == null)
		{
			throw new ArgumentNullException("prfLabel");
		}
		if (prfSeed == null)
		{
			throw new ArgumentNullException("prfSeed");
		}
		using SafeNCryptSecretHandle secretAgreement = DeriveSecretAgreementHandle(otherPartyPublicKey);
		return NCryptNative.DeriveKeyMaterialTls(secretAgreement, prfLabel, prfSeed, NCryptNative.SecretAgreementFlags.None);
	}

	public SafeNCryptSecretHandle DeriveSecretAgreementHandle(ECDiffieHellmanPublicKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		ECDiffieHellmanCngPublicKey eCDiffieHellmanCngPublicKey = otherPartyPublicKey as ECDiffieHellmanCngPublicKey;
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgExpectedECDiffieHellmanCngPublicKey"));
		}
		using CngKey otherPartyPublicKey2 = eCDiffieHellmanCngPublicKey.Import();
		return DeriveSecretAgreementHandle(otherPartyPublicKey2);
	}

	[SecurityCritical]
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	public SafeNCryptSecretHandle DeriveSecretAgreementHandle(CngKey otherPartyPublicKey)
	{
		if (otherPartyPublicKey == null)
		{
			throw new ArgumentNullException("otherPartyPublicKey");
		}
		if (otherPartyPublicKey.AlgorithmGroup != CngAlgorithmGroup.ECDiffieHellman)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "otherPartyPublicKey");
		}
		if (otherPartyPublicKey.KeySize != KeySize)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHKeySizeMismatch"), "otherPartyPublicKey");
		}
		using SafeNCryptKeyHandle privateKey = Key.Handle;
		using SafeNCryptKeyHandle otherPartyPublicKey2 = otherPartyPublicKey.Handle;
		return NCryptNative.DeriveSecretAgreement(privateKey, otherPartyPublicKey2);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && m_key != null)
			{
				m_key.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void GenerateKey(ECCurve curve)
	{
		curve.Validate();
		if (m_key != null)
		{
			m_key.Dispose();
			m_key = null;
		}
		KeySizeValue = (m_key = CngKey.Create(curve, (string name) => CngKey.EcdhCurveNameToAlgorithm(name))).KeySize;
	}

	public override void FromXmlString(string xmlString)
	{
		throw new NotImplementedException(System.SR.GetString("Cryptography_ECXmlSerializationFormatRequired"));
	}

	public void FromXmlString(string xml, ECKeyXmlFormat format)
	{
		if (xml == null)
		{
			throw new ArgumentNullException("xml");
		}
		if (format != ECKeyXmlFormat.Rfc4050)
		{
			throw new ArgumentOutOfRangeException("format");
		}
		bool isEcdh;
		ECParameters parameters = Rfc4050KeyFormatter.FromXml(xml, out isEcdh);
		if (!isEcdh)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDHRequiresECDHKey"), "xml");
		}
		ImportParameters(parameters);
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		throw new NotImplementedException(System.SR.GetString("Cryptography_ECXmlSerializationFormatRequired"));
	}

	public string ToXmlString(ECKeyXmlFormat format)
	{
		if (format != ECKeyXmlFormat.Rfc4050)
		{
			throw new ArgumentOutOfRangeException("format");
		}
		ECParameters parameters = ExportParameters(includePrivateParameters: false);
		return Rfc4050KeyFormatter.ToXml(parameters, isEcdh: true);
	}

	public override void ImportParameters(ECParameters parameters)
	{
		Key = ECCng.ImportEcdhParameters(ref parameters);
	}

	public override ECParameters ExportExplicitParameters(bool includePrivateParameters)
	{
		return ECCng.ExportExplicitParameters(Key, includePrivateParameters);
	}

	public override ECParameters ExportParameters(bool includePrivateParameters)
	{
		return ECCng.ExportParameters(Key, includePrivateParameters);
	}
}

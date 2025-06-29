using System.IO;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class ECDsaCng : ECDsa
{
	private static KeySizes[] s_legalKeySizes = new KeySizes[2]
	{
		new KeySizes(256, 384, 128),
		new KeySizes(521, 521, 0)
	};

	private CngKey m_key;

	private CngAlgorithm m_hashAlgorithm = CngAlgorithm.Sha256;

	public CngAlgorithm HashAlgorithm
	{
		get
		{
			return m_hashAlgorithm;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_hashAlgorithm = value;
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
					algorithm = CngAlgorithm.ECDsaP256;
					break;
				case 384:
					algorithm = CngAlgorithm.ECDsaP384;
					break;
				case 521:
					algorithm = CngAlgorithm.ECDsaP521;
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
			if (!IsEccAlgorithmGroup(value.AlgorithmGroup))
			{
				throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDsaRequiresECDsaKey"));
			}
			if (m_key != null)
			{
				m_key.Dispose();
			}
			m_key = value;
			KeySizeValue = m_key.KeySize;
		}
	}

	private SafeNCryptKeyHandle KeyHandle
	{
		[SecuritySafeCritical]
		get
		{
			return Key.Handle;
		}
	}

	public ECDsaCng()
		: this(521)
	{
	}

	public ECDsaCng(int keySize)
	{
		if (!NCryptNative.NCryptSupported)
		{
			throw new PlatformNotSupportedException(System.SR.GetString("Cryptography_PlatformNotSupported"));
		}
		LegalKeySizesValue = s_legalKeySizes;
		KeySize = keySize;
	}

	public ECDsaCng(ECCurve curve)
	{
		GenerateKey(curve);
	}

	[SecuritySafeCritical]
	public ECDsaCng(CngKey key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!IsEccAlgorithmGroup(key.AlgorithmGroup))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_ArgECDsaRequiresECDsaKey"), "key");
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

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (m_key != null)
			{
				m_key.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
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
		ImportParameters(parameters);
	}

	public byte[] SignData(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return SignData(data, 0, data.Length);
	}

	[SecuritySafeCritical]
	public byte[] SignData(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0 || offset > data.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > data.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashCore(data, offset, count);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return SignHash(hash);
	}

	[SecuritySafeCritical]
	public byte[] SignData(Stream data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return SignHash(hash);
	}

	[SecuritySafeCritical]
	public override byte[] SignHash(byte[] hash)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		Key.BuildKeyContainerPermission(KeyContainerPermissionFlags.Sign)?.Demand();
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		using SafeNCryptKeyHandle key = Key.Handle;
		CodeAccessPermission.RevertAssert();
		return NCryptNative.SignHash(key, hash);
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
		return Rfc4050KeyFormatter.ToXml(parameters, isEcdh: false);
	}

	public bool VerifyData(byte[] data, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return VerifyData(data, 0, data.Length, signature);
	}

	[SecuritySafeCritical]
	public bool VerifyData(byte[] data, int offset, int count, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0 || offset > data.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > data.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashCore(data, offset, count);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return VerifyHash(hash, signature);
	}

	[SecuritySafeCritical]
	public bool VerifyData(Stream data, byte[] signature)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(HashAlgorithm, "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		byte[] hash = bCryptHashAlgorithm.HashFinal();
		return VerifyHash(hash, signature);
	}

	[SecuritySafeCritical]
	public override bool VerifyHash(byte[] hash, byte[] signature)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		using SafeNCryptKeyHandle key = Key.Handle;
		CodeAccessPermission.RevertAssert();
		return NCryptNative.VerifySignature(key, hash, signature);
	}

	public override void GenerateKey(ECCurve curve)
	{
		curve.Validate();
		if (m_key != null)
		{
			m_key.Dispose();
			m_key = null;
		}
		KeySizeValue = (m_key = CngKey.Create(curve, (string name) => CngKey.EcdsaCurveNameToAlgorithm(name))).KeySize;
	}

	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashCore(data, offset, count);
		return bCryptHashAlgorithm.HashFinal();
	}

	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		using BCryptHashAlgorithm bCryptHashAlgorithm = new BCryptHashAlgorithm(new CngAlgorithm(hashAlgorithm.Name), "Microsoft Primitive Provider");
		bCryptHashAlgorithm.HashStream(data);
		return bCryptHashAlgorithm.HashFinal();
	}

	private static bool IsEccAlgorithmGroup(CngAlgorithmGroup algorithmGroup)
	{
		if (!(algorithmGroup == CngAlgorithmGroup.ECDsa))
		{
			return algorithmGroup == CngAlgorithmGroup.ECDiffieHellman;
		}
		return true;
	}

	public override void ImportParameters(ECParameters parameters)
	{
		Key = ECCng.ImportECDsaParameters(ref parameters);
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

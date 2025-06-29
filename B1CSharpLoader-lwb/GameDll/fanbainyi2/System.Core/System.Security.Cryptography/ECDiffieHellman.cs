using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ECDiffieHellman : AsymmetricAlgorithm
{
	public override string KeyExchangeAlgorithm => "ECDiffieHellman";

	public override string SignatureAlgorithm => null;

	public abstract ECDiffieHellmanPublicKey PublicKey { get; }

	public new static ECDiffieHellman Create()
	{
		return Create(typeof(ECDiffieHellmanCng).FullName);
	}

	public new static ECDiffieHellman Create(string algorithm)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		return CryptoConfig.CreateFromName(algorithm) as ECDiffieHellman;
	}

	public static ECDiffieHellman Create(ECCurve curve)
	{
		ECDiffieHellman eCDiffieHellman = Create();
		if (eCDiffieHellman != null)
		{
			try
			{
				eCDiffieHellman.GenerateKey(curve);
			}
			catch
			{
				eCDiffieHellman.Dispose();
				throw;
			}
		}
		return eCDiffieHellman;
	}

	public static ECDiffieHellman Create(ECParameters parameters)
	{
		ECDiffieHellman eCDiffieHellman = Create();
		if (eCDiffieHellman != null)
		{
			try
			{
				eCDiffieHellman.ImportParameters(parameters);
			}
			catch
			{
				eCDiffieHellman.Dispose();
				throw;
			}
		}
		return eCDiffieHellman;
	}

	public virtual byte[] DeriveKeyMaterial(ECDiffieHellmanPublicKey otherPartyPublicKey)
	{
		throw DerivedClassMustOverride();
	}

	public byte[] DeriveKeyFromHash(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm)
	{
		return DeriveKeyFromHash(otherPartyPublicKey, hashAlgorithm, null, null);
	}

	public virtual byte[] DeriveKeyFromHash(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] secretPrepend, byte[] secretAppend)
	{
		throw DerivedClassMustOverride();
	}

	public byte[] DeriveKeyFromHmac(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] hmacKey)
	{
		return DeriveKeyFromHmac(otherPartyPublicKey, hashAlgorithm, hmacKey, null, null);
	}

	public virtual byte[] DeriveKeyFromHmac(ECDiffieHellmanPublicKey otherPartyPublicKey, HashAlgorithmName hashAlgorithm, byte[] hmacKey, byte[] secretPrepend, byte[] secretAppend)
	{
		throw DerivedClassMustOverride();
	}

	public virtual byte[] DeriveKeyTls(ECDiffieHellmanPublicKey otherPartyPublicKey, byte[] prfLabel, byte[] prfSeed)
	{
		throw DerivedClassMustOverride();
	}

	private static Exception DerivedClassMustOverride()
	{
		return new NotImplementedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	public virtual ECParameters ExportParameters(bool includePrivateParameters)
	{
		throw DerivedClassMustOverride();
	}

	public virtual ECParameters ExportExplicitParameters(bool includePrivateParameters)
	{
		throw DerivedClassMustOverride();
	}

	public virtual void ImportParameters(ECParameters parameters)
	{
		throw DerivedClassMustOverride();
	}

	public virtual void GenerateKey(ECCurve curve)
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}
}

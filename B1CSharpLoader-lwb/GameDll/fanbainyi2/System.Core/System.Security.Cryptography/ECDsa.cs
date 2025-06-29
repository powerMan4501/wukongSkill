using System.IO;
using System.Security.Permissions;

namespace System.Security.Cryptography;

[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class ECDsa : AsymmetricAlgorithm
{
	public override string KeyExchangeAlgorithm => null;

	public override string SignatureAlgorithm => "ECDsa";

	public new static ECDsa Create()
	{
		return Create(typeof(ECDsaCng).FullName);
	}

	public new static ECDsa Create(string algorithm)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		return CryptoConfig.CreateFromName(algorithm) as ECDsa;
	}

	public static ECDsa Create(ECCurve curve)
	{
		ECDsa eCDsa = Create();
		if (eCDsa != null)
		{
			try
			{
				eCDsa.GenerateKey(curve);
			}
			catch
			{
				eCDsa.Dispose();
				throw;
			}
		}
		return eCDsa;
	}

	public static ECDsa Create(ECParameters parameters)
	{
		ECDsa eCDsa = Create();
		if (eCDsa != null)
		{
			try
			{
				eCDsa.ImportParameters(parameters);
			}
			catch
			{
				eCDsa.Dispose();
				throw;
			}
		}
		return eCDsa;
	}

	public abstract byte[] SignHash(byte[] hash);

	public abstract bool VerifyHash(byte[] hash, byte[] signature);

	protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
	{
		throw DerivedClassMustOverride();
	}

	protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		throw DerivedClassMustOverride();
	}

	public virtual byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return SignData(data, 0, data.Length, hashAlgorithm);
	}

	public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
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
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] hash = HashData(data, offset, count, hashAlgorithm);
		return SignHash(hash);
	}

	public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] hash = HashData(data, hashAlgorithm);
		return SignHash(hash);
	}

	public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return VerifyData(data, 0, data.Length, signature, hashAlgorithm);
	}

	public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
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
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] hash = HashData(data, offset, count, hashAlgorithm);
		return VerifyHash(hash, signature);
	}

	public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw HashAlgorithmNameNullOrEmpty();
		}
		byte[] hash = HashData(data, hashAlgorithm);
		return VerifyHash(hash, signature);
	}

	public virtual ECParameters ExportParameters(bool includePrivateParameters)
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	public virtual ECParameters ExportExplicitParameters(bool includePrivateParameters)
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	public virtual void ImportParameters(ECParameters parameters)
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	public virtual void GenerateKey(ECCurve curve)
	{
		throw new NotSupportedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	private static Exception DerivedClassMustOverride()
	{
		return new NotImplementedException(System.SR.GetString("NotSupported_SubclassOverride"));
	}

	internal static Exception HashAlgorithmNameNullOrEmpty()
	{
		return new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
	}
}

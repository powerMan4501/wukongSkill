using System.Collections.ObjectModel;

namespace System.Security.Cryptography.X509Certificates;

public sealed class CertificateRequest
{
	private readonly AsymmetricAlgorithm _key;

	private readonly X509SignatureGenerator _generator;

	private readonly RSASignaturePadding _rsaPadding;

	public X500DistinguishedName SubjectName { get; }

	public Collection<X509Extension> CertificateExtensions { get; } = new Collection<X509Extension>();

	public PublicKey PublicKey { get; }

	public HashAlgorithmName HashAlgorithm { get; }

	public CertificateRequest(string subjectName, ECDsa key, HashAlgorithmName hashAlgorithm)
	{
		if (subjectName == null)
		{
			throw new ArgumentNullException("subjectName");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		SubjectName = new X500DistinguishedName(subjectName);
		_key = key;
		_generator = X509SignatureGenerator.CreateForECDsa(key);
		PublicKey = _generator.PublicKey;
		HashAlgorithm = hashAlgorithm;
	}

	public CertificateRequest(X500DistinguishedName subjectName, ECDsa key, HashAlgorithmName hashAlgorithm)
	{
		if (subjectName == null)
		{
			throw new ArgumentNullException("subjectName");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		SubjectName = subjectName;
		_key = key;
		_generator = X509SignatureGenerator.CreateForECDsa(key);
		PublicKey = _generator.PublicKey;
		HashAlgorithm = hashAlgorithm;
	}

	public CertificateRequest(string subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (subjectName == null)
		{
			throw new ArgumentNullException("subjectName");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		SubjectName = new X500DistinguishedName(subjectName);
		_key = key;
		_generator = X509SignatureGenerator.CreateForRSA(key, padding);
		_rsaPadding = padding;
		PublicKey = _generator.PublicKey;
		HashAlgorithm = hashAlgorithm;
	}

	public CertificateRequest(X500DistinguishedName subjectName, RSA key, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
	{
		if (subjectName == null)
		{
			throw new ArgumentNullException("subjectName");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		if (padding == null)
		{
			throw new ArgumentNullException("padding");
		}
		SubjectName = subjectName;
		_key = key;
		_generator = X509SignatureGenerator.CreateForRSA(key, padding);
		_rsaPadding = padding;
		PublicKey = _generator.PublicKey;
		HashAlgorithm = hashAlgorithm;
	}

	public CertificateRequest(X500DistinguishedName subjectName, PublicKey publicKey, HashAlgorithmName hashAlgorithm)
	{
		if (subjectName == null)
		{
			throw new ArgumentNullException("subjectName");
		}
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		if (string.IsNullOrEmpty(hashAlgorithm.Name))
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_HashAlgorithmNameNullOrEmpty"), "hashAlgorithm");
		}
		SubjectName = subjectName;
		PublicKey = publicKey;
		HashAlgorithm = hashAlgorithm;
	}

	public byte[] CreateSigningRequest()
	{
		if (_generator == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_CertReq_NoKeyProvided"));
		}
		return CreateSigningRequest(_generator);
	}

	public byte[] CreateSigningRequest(X509SignatureGenerator signatureGenerator)
	{
		if (signatureGenerator == null)
		{
			throw new ArgumentNullException("signatureGenerator");
		}
		X501Attribute[] attributes = null;
		if (CertificateExtensions.Count > 0)
		{
			attributes = new X501Attribute[1]
			{
				new Pkcs9ExtensionRequest(CertificateExtensions)
			};
		}
		Pkcs10CertificationRequestInfo pkcs10CertificationRequestInfo = new Pkcs10CertificationRequestInfo(SubjectName, PublicKey, attributes);
		return pkcs10CertificationRequestInfo.ToPkcs10Request(signatureGenerator, HashAlgorithm);
	}

	public X509Certificate2 CreateSelfSigned(DateTimeOffset notBefore, DateTimeOffset notAfter)
	{
		if (notAfter < notBefore)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_DatesReversed"));
		}
		if (_key == null)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_CertReq_NoKeyProvided"));
		}
		byte[] array = new byte[8];
		using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
		{
			randomNumberGenerator.GetBytes(array);
		}
		using (X509Certificate2 certificate = Create(SubjectName, _generator, notBefore, notAfter, array))
		{
			if (_key is RSA privateKey)
			{
				return certificate.CopyWithPrivateKey(privateKey);
			}
			if (_key is ECDsa privateKey2)
			{
				return certificate.CopyWithPrivateKey(privateKey2);
			}
		}
		throw new CryptographicException();
	}

	public X509Certificate2 Create(X509Certificate2 issuerCertificate, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber)
	{
		if (issuerCertificate == null)
		{
			throw new ArgumentNullException("issuerCertificate");
		}
		if (!issuerCertificate.HasPrivateKey)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_IssuerRequiresPrivateKey"), "issuerCertificate");
		}
		if (notAfter < notBefore)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_DatesReversed"));
		}
		if (serialNumber == null || serialNumber.Length < 1)
		{
			throw new ArgumentException(System.SR.GetString("Arg_EmptyOrNullArray"), "serialNumber");
		}
		if (issuerCertificate.PublicKey.Oid.Value != PublicKey.Oid.Value)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_AlgorithmMustMatch", issuerCertificate.PublicKey.Oid.Value, PublicKey.Oid.Value), "issuerCertificate");
		}
		DateTime localDateTime = notBefore.LocalDateTime;
		if (localDateTime < issuerCertificate.NotBefore)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_NotBeforeNotNested", localDateTime, issuerCertificate.NotBefore), "notBefore");
		}
		DateTime localDateTime2 = notAfter.LocalDateTime;
		long ticks = localDateTime2.Ticks;
		long num = ticks % 10000000;
		ticks -= num;
		localDateTime2 = new DateTime(ticks, localDateTime2.Kind);
		if (localDateTime2 > issuerCertificate.NotAfter)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_NotAfterNotNested", localDateTime2, issuerCertificate.NotAfter), "notAfter");
		}
		X509BasicConstraintsExtension x509BasicConstraintsExtension = (X509BasicConstraintsExtension)issuerCertificate.Extensions["2.5.29.19"];
		X509KeyUsageExtension x509KeyUsageExtension = (X509KeyUsageExtension)issuerCertificate.Extensions["2.5.29.15"];
		if (x509BasicConstraintsExtension == null)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_BasicConstraintsRequired"), "issuerCertificate");
		}
		if (!x509BasicConstraintsExtension.CertificateAuthority)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_IssuerBasicConstraintsInvalid"), "issuerCertificate");
		}
		if (x509KeyUsageExtension != null && (x509KeyUsageExtension.KeyUsages & X509KeyUsageFlags.KeyCertSign) == 0)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_IssuerKeyUsageInvalid"), "issuerCertificate");
		}
		AsymmetricAlgorithm asymmetricAlgorithm = null;
		string keyAlgorithm = issuerCertificate.GetKeyAlgorithm();
		try
		{
			X509SignatureGenerator generator;
			if (!(keyAlgorithm == "1.2.840.113549.1.1.1"))
			{
				if (!(keyAlgorithm == "1.2.840.10045.2.1"))
				{
					throw new ArgumentException(System.SR.GetString("Cryptography_UnknownKeyAlgorithm", keyAlgorithm), "issuerCertificate");
				}
				ECDsa eCDsaPrivateKey = issuerCertificate.GetECDsaPrivateKey();
				asymmetricAlgorithm = eCDsaPrivateKey;
				generator = X509SignatureGenerator.CreateForECDsa(eCDsaPrivateKey);
			}
			else
			{
				if (_rsaPadding == null)
				{
					throw new InvalidOperationException(System.SR.GetString("Cryptography_CertReq_RSAPaddingRequired"));
				}
				RSA rSAPrivateKey = issuerCertificate.GetRSAPrivateKey();
				asymmetricAlgorithm = rSAPrivateKey;
				generator = X509SignatureGenerator.CreateForRSA(rSAPrivateKey, _rsaPadding);
			}
			return Create(issuerCertificate.SubjectName, generator, notBefore, notAfter, serialNumber);
		}
		finally
		{
			asymmetricAlgorithm?.Dispose();
		}
	}

	public X509Certificate2 Create(X500DistinguishedName issuerName, X509SignatureGenerator generator, DateTimeOffset notBefore, DateTimeOffset notAfter, byte[] serialNumber)
	{
		if (issuerName == null)
		{
			throw new ArgumentNullException("issuerName");
		}
		if (generator == null)
		{
			throw new ArgumentNullException("generator");
		}
		if (notAfter < notBefore)
		{
			throw new ArgumentException(System.SR.GetString("Cryptography_CertReq_DatesReversed"));
		}
		if (serialNumber == null || serialNumber.Length < 1)
		{
			throw new ArgumentException(System.SR.GetString("Arg_EmptyOrNullArray"), "serialNumber");
		}
		TbsCertificate tbsCertificate = new TbsCertificate
		{
			Version = 2,
			SerialNumber = serialNumber,
			Issuer = issuerName,
			PublicKey = PublicKey,
			NotBefore = notBefore,
			NotAfter = notAfter,
			Subject = SubjectName
		};
		Collection<X509Extension> extensions = tbsCertificate.Extensions;
		foreach (X509Extension certificateExtension in CertificateExtensions)
		{
			extensions.Add(certificateExtension);
		}
		return new X509Certificate2(tbsCertificate.Sign(generator, HashAlgorithm));
	}
}

namespace System.Security.Cryptography.X509Certificates;

internal sealed class RSAPkcs1X509SignatureGenerator : X509SignatureGenerator
{
	private readonly RSA _key;

	internal RSAPkcs1X509SignatureGenerator(RSA key)
	{
		_key = key;
	}

	public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
	{
		return _key.SignData(data, hashAlgorithm, RSASignaturePadding.Pkcs1);
	}

	protected override PublicKey BuildPublicKey()
	{
		return BuildPublicKey(_key);
	}

	internal static PublicKey BuildPublicKey(RSA rsa)
	{
		RSAParameters rSAParameters = rsa.ExportParameters(includePrivateParameters: false);
		byte[] rawData = DerEncoder.ConstructSequence(DerEncoder.SegmentedEncodeUnsignedInteger(rSAParameters.Modulus), DerEncoder.SegmentedEncodeUnsignedInteger(rSAParameters.Exponent));
		Oid oid = new Oid("1.2.840.113549.1.1.1");
		return new PublicKey(oid, new AsnEncodedData(oid, new byte[2] { 5, 0 }), new AsnEncodedData(oid, rawData));
	}

	public override byte[] GetSignatureAlgorithmIdentifier(HashAlgorithmName hashAlgorithm)
	{
		string oidValue;
		if (hashAlgorithm == HashAlgorithmName.SHA256)
		{
			oidValue = "1.2.840.113549.1.1.11";
		}
		else if (hashAlgorithm == HashAlgorithmName.SHA384)
		{
			oidValue = "1.2.840.113549.1.1.12";
		}
		else
		{
			if (!(hashAlgorithm == HashAlgorithmName.SHA512))
			{
				throw new ArgumentOutOfRangeException("hashAlgorithm", hashAlgorithm, System.SR.GetString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name));
			}
			oidValue = "1.2.840.113549.1.1.13";
		}
		return DerEncoder.ConstructSequence(DerEncoder.SegmentedEncodeOid(oidValue), DerEncoder.SegmentedEncodeNull());
	}
}

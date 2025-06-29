namespace System.Security.Cryptography.X509Certificates;

internal sealed class RSAPssX509SignatureGenerator : X509SignatureGenerator
{
	private readonly RSA _key;

	private readonly RSASignaturePadding _padding;

	internal RSAPssX509SignatureGenerator(RSA key, RSASignaturePadding padding)
	{
		_key = key;
		_padding = padding;
	}

	public override byte[] GetSignatureAlgorithmIdentifier(HashAlgorithmName hashAlgorithm)
	{
		if (_padding != RSASignaturePadding.Pss)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_InvalidPaddingMode"));
		}
		uint value;
		string oidValue;
		if (hashAlgorithm == HashAlgorithmName.SHA256)
		{
			value = 32u;
			oidValue = "2.16.840.1.101.3.4.2.1";
		}
		else if (hashAlgorithm == HashAlgorithmName.SHA384)
		{
			value = 48u;
			oidValue = "2.16.840.1.101.3.4.2.2";
		}
		else
		{
			if (!(hashAlgorithm == HashAlgorithmName.SHA512))
			{
				throw new ArgumentOutOfRangeException("hashAlgorithm", hashAlgorithm, System.SR.GetString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name));
			}
			value = 64u;
			oidValue = "2.16.840.1.101.3.4.2.3";
		}
		byte[][] array = DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid(oidValue));
		byte[][] array2 = DerEncoder.ConstructSegmentedSequence(array);
		array2[0][0] = 160;
		byte[][] array3 = DerEncoder.ConstructSegmentedSequence(DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeOid("1.2.840.113549.1.1.8"), array));
		array3[0][0] = 161;
		byte[][] array4 = DerEncoder.ConstructSegmentedSequence(DerEncoder.SegmentedEncodeUnsignedInteger(value));
		array4[0][0] = 162;
		return DerEncoder.ConstructSequence(DerEncoder.SegmentedEncodeOid("1.2.840.113549.1.1.10"), DerEncoder.ConstructSegmentedSequence(array2, array3, array4));
	}

	public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
	{
		return _key.SignData(data, hashAlgorithm, _padding);
	}

	protected override PublicKey BuildPublicKey()
	{
		return RSAPkcs1X509SignatureGenerator.BuildPublicKey(_key);
	}
}

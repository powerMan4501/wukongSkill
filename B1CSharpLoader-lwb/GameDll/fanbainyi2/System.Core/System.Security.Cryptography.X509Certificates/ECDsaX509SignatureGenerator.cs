namespace System.Security.Cryptography.X509Certificates;

internal sealed class ECDsaX509SignatureGenerator : X509SignatureGenerator
{
	private readonly ECDsa _key;

	internal ECDsaX509SignatureGenerator(ECDsa key)
	{
		_key = key;
	}

	public override byte[] GetSignatureAlgorithmIdentifier(HashAlgorithmName hashAlgorithm)
	{
		string oidValue;
		if (hashAlgorithm == HashAlgorithmName.SHA256)
		{
			oidValue = "1.2.840.10045.4.3.2";
		}
		else if (hashAlgorithm == HashAlgorithmName.SHA384)
		{
			oidValue = "1.2.840.10045.4.3.3";
		}
		else
		{
			if (!(hashAlgorithm == HashAlgorithmName.SHA512))
			{
				throw new ArgumentOutOfRangeException("hashAlgorithm", hashAlgorithm, System.SR.GetString("Cryptography_UnknownHashAlgorithm", hashAlgorithm.Name));
			}
			oidValue = "1.2.840.10045.4.3.4";
		}
		return DerEncoder.ConstructSequence(DerEncoder.SegmentedEncodeOid(oidValue));
	}

	public override byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
	{
		byte[] array = _key.SignData(data, hashAlgorithm);
		int num = array.Length / 2;
		return DerEncoder.ConstructSequence(DerEncoder.SegmentedEncodeUnsignedInteger(array, 0, num), DerEncoder.SegmentedEncodeUnsignedInteger(array, num, num));
	}

	protected override PublicKey BuildPublicKey()
	{
		ECParameters eCParameters = _key.ExportParameters(includePrivateParameters: false);
		if (!eCParameters.Curve.IsNamed)
		{
			throw new InvalidOperationException(System.SR.GetString("Cryptography_ECC_NamedCurvesOnly"));
		}
		string text = eCParameters.Curve.Oid.Value;
		if (string.IsNullOrEmpty(text))
		{
			string friendlyName = eCParameters.Curve.Oid.FriendlyName;
			text = friendlyName switch
			{
				"nistP256" => "1.2.840.10045.3.1.7", 
				"nistP384" => "1.3.132.0.34", 
				"nistP521" => "1.3.132.0.35", 
				_ => new Oid(friendlyName).Value, 
			};
		}
		byte[] array = new byte[1 + eCParameters.Q.X.Length + eCParameters.Q.Y.Length];
		array[0] = 4;
		Buffer.BlockCopy(eCParameters.Q.X, 0, array, 1, eCParameters.Q.X.Length);
		Buffer.BlockCopy(eCParameters.Q.Y, 0, array, 1 + eCParameters.Q.X.Length, eCParameters.Q.Y.Length);
		Oid oid = new Oid("1.2.840.10045.2.1");
		return new PublicKey(oid, new AsnEncodedData(oid, DerEncoder.EncodeOid(text)), new AsnEncodedData(oid, array));
	}
}

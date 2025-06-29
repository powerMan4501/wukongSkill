namespace System.Security.Cryptography.X509Certificates;

internal struct PBES2Params
{
	internal AlgorithmIdentifierAsn KeyDerivationFunc;

	internal AlgorithmIdentifierAsn EncryptionScheme;

	internal static PBES2Params Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static PBES2Params Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		try
		{
			AsnValueReader reader = new AsnValueReader(encoded.Span, ruleSet);
			DecodeCore(ref reader, expectedTag, encoded, out var decoded);
			reader.ThrowIfNotEmpty();
			return decoded;
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out PBES2Params decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PBES2Params decoded)
	{
		try
		{
			DecodeCore(ref reader, expectedTag, rebind, out decoded);
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PBES2Params decoded)
	{
		decoded = default(PBES2Params);
		AsnValueReader reader2 = reader.ReadSequence(expectedTag);
		AlgorithmIdentifierAsn.Decode(ref reader2, rebind, out decoded.KeyDerivationFunc);
		AlgorithmIdentifierAsn.Decode(ref reader2, rebind, out decoded.EncryptionScheme);
		reader2.ThrowIfNotEmpty();
	}
}

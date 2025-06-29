namespace System.Security.Cryptography.X509Certificates;

internal struct EncryptedPrivateKeyInfoAsn
{
	internal AlgorithmIdentifierAsn EncryptionAlgorithm;

	internal ReadOnlyMemory<byte> EncryptedData;

	internal static EncryptedPrivateKeyInfoAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static EncryptedPrivateKeyInfoAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out EncryptedPrivateKeyInfoAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out EncryptedPrivateKeyInfoAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out EncryptedPrivateKeyInfoAsn decoded)
	{
		decoded = default(EncryptedPrivateKeyInfoAsn);
		AsnValueReader reader2 = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		AlgorithmIdentifierAsn.Decode(ref reader2, rebind, out decoded.EncryptionAlgorithm);
		if (reader2.TryReadPrimitiveOctetString(out var value))
		{
			decoded.EncryptedData = (span.Overlaps(value, out var elementOffset) ? rebind.Slice(elementOffset, value.Length) : ((ReadOnlyMemory<byte>)value.ToArray()));
		}
		else
		{
			decoded.EncryptedData = reader2.ReadOctetString();
		}
		reader2.ThrowIfNotEmpty();
	}
}

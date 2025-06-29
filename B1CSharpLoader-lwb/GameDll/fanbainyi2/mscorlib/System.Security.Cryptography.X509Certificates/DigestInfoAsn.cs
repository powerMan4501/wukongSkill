namespace System.Security.Cryptography.X509Certificates;

internal struct DigestInfoAsn
{
	internal AlgorithmIdentifierAsn DigestAlgorithm;

	internal ReadOnlyMemory<byte> Digest;

	internal static DigestInfoAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static DigestInfoAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out DigestInfoAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out DigestInfoAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out DigestInfoAsn decoded)
	{
		decoded = default(DigestInfoAsn);
		AsnValueReader reader2 = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		AlgorithmIdentifierAsn.Decode(ref reader2, rebind, out decoded.DigestAlgorithm);
		if (reader2.TryReadPrimitiveOctetString(out var value))
		{
			decoded.Digest = (span.Overlaps(value, out var elementOffset) ? rebind.Slice(elementOffset, value.Length) : ((ReadOnlyMemory<byte>)value.ToArray()));
		}
		else
		{
			decoded.Digest = reader2.ReadOctetString();
		}
		reader2.ThrowIfNotEmpty();
	}
}

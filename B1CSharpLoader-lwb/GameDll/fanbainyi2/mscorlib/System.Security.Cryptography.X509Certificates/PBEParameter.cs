namespace System.Security.Cryptography.X509Certificates;

internal struct PBEParameter
{
	internal ReadOnlyMemory<byte> Salt;

	internal int IterationCount;

	internal static PBEParameter Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static PBEParameter Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out PBEParameter decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PBEParameter decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out PBEParameter decoded)
	{
		decoded = default(PBEParameter);
		AsnValueReader asnValueReader = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		if (asnValueReader.TryReadPrimitiveOctetString(out var value))
		{
			decoded.Salt = (span.Overlaps(value, out var elementOffset) ? rebind.Slice(elementOffset, value.Length) : ((ReadOnlyMemory<byte>)value.ToArray()));
		}
		else
		{
			decoded.Salt = asnValueReader.ReadOctetString();
		}
		if (!asnValueReader.TryReadInt32(out decoded.IterationCount))
		{
			asnValueReader.ThrowIfNotEmpty();
		}
		asnValueReader.ThrowIfNotEmpty();
	}
}

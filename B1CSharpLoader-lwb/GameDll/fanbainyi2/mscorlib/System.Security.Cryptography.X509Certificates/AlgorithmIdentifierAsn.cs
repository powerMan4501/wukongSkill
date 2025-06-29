namespace System.Security.Cryptography.X509Certificates;

internal struct AlgorithmIdentifierAsn
{
	internal byte[] Algorithm;

	internal ReadOnlyMemory<byte>? Parameters;

	internal static readonly ReadOnlyMemory<byte> ExplicitDerNull = new byte[2] { 5, 0 };

	internal static AlgorithmIdentifierAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static AlgorithmIdentifierAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out AlgorithmIdentifierAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out AlgorithmIdentifierAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out AlgorithmIdentifierAsn decoded)
	{
		decoded = default(AlgorithmIdentifierAsn);
		AsnValueReader asnValueReader = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		decoded.Algorithm = asnValueReader.ReadObjectIdentifier();
		if (asnValueReader.HasData)
		{
			ReadOnlySpan<byte> destination = asnValueReader.ReadEncodedValue();
			decoded.Parameters = (span.Overlaps(destination, out var elementOffset) ? rebind.Slice(elementOffset, destination.Length) : ((ReadOnlyMemory<byte>)destination.ToArray()));
		}
		asnValueReader.ThrowIfNotEmpty();
	}

	internal bool HasNullEquivalentParameters()
	{
		return RepresentsNull(Parameters);
	}

	internal static bool RepresentsNull(ReadOnlyMemory<byte>? parameters)
	{
		if (!parameters.HasValue)
		{
			return true;
		}
		ReadOnlySpan<byte> span = parameters.Value.Span;
		if (span.Length != 2)
		{
			return false;
		}
		if (span[0] != 5)
		{
			return false;
		}
		return span[1] == 0;
	}
}

namespace System.Security.Cryptography.X509Certificates;

internal struct ContentInfoAsn
{
	internal byte[] ContentType;

	internal ReadOnlyMemory<byte> Content;

	internal static ContentInfoAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static ContentInfoAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out ContentInfoAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out ContentInfoAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out ContentInfoAsn decoded)
	{
		decoded = default(ContentInfoAsn);
		AsnValueReader asnValueReader = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		decoded.ContentType = asnValueReader.ReadObjectIdentifier();
		AsnValueReader asnValueReader2 = asnValueReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 0));
		ReadOnlySpan<byte> destination = asnValueReader2.ReadEncodedValue();
		decoded.Content = (span.Overlaps(destination, out var elementOffset) ? rebind.Slice(elementOffset, destination.Length) : ((ReadOnlyMemory<byte>)destination.ToArray()));
		asnValueReader2.ThrowIfNotEmpty();
		asnValueReader.ThrowIfNotEmpty();
	}
}

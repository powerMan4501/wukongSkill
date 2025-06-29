namespace System.Security.Cryptography.X509Certificates;

internal struct EncryptedContentInfoAsn
{
	internal byte[] ContentType;

	internal AlgorithmIdentifierAsn ContentEncryptionAlgorithm;

	internal ReadOnlyMemory<byte>? EncryptedContent;

	internal static EncryptedContentInfoAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static EncryptedContentInfoAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out EncryptedContentInfoAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out EncryptedContentInfoAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out EncryptedContentInfoAsn decoded)
	{
		decoded = default(EncryptedContentInfoAsn);
		AsnValueReader reader2 = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		decoded.ContentType = reader2.ReadObjectIdentifier();
		AlgorithmIdentifierAsn.Decode(ref reader2, rebind, out decoded.ContentEncryptionAlgorithm);
		if (reader2.HasData && reader2.PeekTag().HasSameClassAndValue(new Asn1Tag(TagClass.ContextSpecific, 0)))
		{
			if (reader2.TryReadPrimitiveOctetString(out var value, new Asn1Tag(TagClass.ContextSpecific, 0)))
			{
				decoded.EncryptedContent = (span.Overlaps(value, out var elementOffset) ? rebind.Slice(elementOffset, value.Length) : ((ReadOnlyMemory<byte>)value.ToArray()));
			}
			else
			{
				decoded.EncryptedContent = reader2.ReadOctetString(new Asn1Tag(TagClass.ContextSpecific, 0));
			}
		}
		reader2.ThrowIfNotEmpty();
	}
}

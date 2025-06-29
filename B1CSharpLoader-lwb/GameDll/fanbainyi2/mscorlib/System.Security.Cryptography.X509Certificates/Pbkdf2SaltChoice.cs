namespace System.Security.Cryptography.X509Certificates;

internal struct Pbkdf2SaltChoice
{
	internal ReadOnlyMemory<byte>? Specified;

	internal AlgorithmIdentifierAsn? OtherSource;

	internal static Pbkdf2SaltChoice Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		try
		{
			AsnValueReader reader = new AsnValueReader(encoded.Span, ruleSet);
			DecodeCore(ref reader, encoded, out var decoded);
			reader.ThrowIfNotEmpty();
			return decoded;
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out Pbkdf2SaltChoice decoded)
	{
		try
		{
			DecodeCore(ref reader, rebind, out decoded);
		}
		catch (InvalidOperationException inner)
		{
			throw new CryptographicException("ASN1 corrupted data.", inner);
		}
	}

	private static void DecodeCore(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out Pbkdf2SaltChoice decoded)
	{
		decoded = default(Pbkdf2SaltChoice);
		Asn1Tag asn1Tag = reader.PeekTag();
		ReadOnlySpan<byte> span = rebind.Span;
		if (asn1Tag.HasSameClassAndValue(Asn1Tag.PrimitiveOctetString))
		{
			if (reader.TryReadPrimitiveOctetString(out var value))
			{
				decoded.Specified = (span.Overlaps(value, out var elementOffset) ? rebind.Slice(elementOffset, value.Length) : ((ReadOnlyMemory<byte>)value.ToArray()));
			}
			else
			{
				decoded.Specified = reader.ReadOctetString();
			}
			return;
		}
		if (asn1Tag.HasSameClassAndValue(Asn1Tag.Sequence))
		{
			AlgorithmIdentifierAsn.Decode(ref reader, rebind, out var decoded2);
			decoded.OtherSource = decoded2;
			return;
		}
		throw new CryptographicException();
	}
}

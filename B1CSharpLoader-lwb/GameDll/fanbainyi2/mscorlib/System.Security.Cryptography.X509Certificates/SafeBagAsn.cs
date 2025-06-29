using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates;

internal struct SafeBagAsn
{
	internal byte[] BagId;

	internal ReadOnlyMemory<byte> BagValue;

	internal AttributeAsn[] BagAttributes;

	internal static SafeBagAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static SafeBagAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out SafeBagAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out SafeBagAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out SafeBagAsn decoded)
	{
		decoded = default(SafeBagAsn);
		AsnValueReader asnValueReader = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		decoded.BagId = asnValueReader.ReadObjectIdentifier();
		AsnValueReader asnValueReader2 = asnValueReader.ReadSequence(new Asn1Tag(TagClass.ContextSpecific, 0));
		ReadOnlySpan<byte> destination = asnValueReader2.ReadEncodedValue();
		decoded.BagValue = (span.Overlaps(destination, out var elementOffset) ? rebind.Slice(elementOffset, destination.Length) : ((ReadOnlyMemory<byte>)destination.ToArray()));
		asnValueReader2.ThrowIfNotEmpty();
		if (asnValueReader.HasData && asnValueReader.PeekTag().HasSameClassAndValue(Asn1Tag.SetOf))
		{
			AsnValueReader reader2 = asnValueReader.ReadSetOf();
			List<AttributeAsn> list = new List<AttributeAsn>();
			while (reader2.HasData)
			{
				AttributeAsn.Decode(ref reader2, rebind, out var decoded2);
				list.Add(decoded2);
			}
			decoded.BagAttributes = list.ToArray();
		}
		asnValueReader.ThrowIfNotEmpty();
	}
}

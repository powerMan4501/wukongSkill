using System.Collections.Generic;

namespace System.Security.Cryptography.X509Certificates;

internal struct AttributeAsn
{
	internal byte[] AttrType;

	internal ReadOnlyMemory<byte>[] AttrValues;

	internal static AttributeAsn Decode(ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
	{
		return Decode(Asn1Tag.Sequence, encoded, ruleSet);
	}

	internal static AttributeAsn Decode(Asn1Tag expectedTag, ReadOnlyMemory<byte> encoded, AsnEncodingRules ruleSet)
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

	internal static void Decode(ref AsnValueReader reader, ReadOnlyMemory<byte> rebind, out AttributeAsn decoded)
	{
		Decode(ref reader, Asn1Tag.Sequence, rebind, out decoded);
	}

	internal static void Decode(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out AttributeAsn decoded)
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

	private static void DecodeCore(ref AsnValueReader reader, Asn1Tag expectedTag, ReadOnlyMemory<byte> rebind, out AttributeAsn decoded)
	{
		decoded = default(AttributeAsn);
		AsnValueReader asnValueReader = reader.ReadSequence(expectedTag);
		ReadOnlySpan<byte> span = rebind.Span;
		decoded.AttrType = asnValueReader.ReadObjectIdentifier();
		AsnValueReader asnValueReader2 = asnValueReader.ReadSetOf();
		List<ReadOnlyMemory<byte>> list = new List<ReadOnlyMemory<byte>>();
		while (asnValueReader2.HasData)
		{
			ReadOnlySpan<byte> destination = asnValueReader2.ReadEncodedValue();
			int elementOffset;
			ReadOnlyMemory<byte> item = (span.Overlaps(destination, out elementOffset) ? rebind.Slice(elementOffset, destination.Length) : ((ReadOnlyMemory<byte>)destination.ToArray()));
			list.Add(item);
		}
		decoded.AttrValues = list.ToArray();
		asnValueReader.ThrowIfNotEmpty();
	}
}

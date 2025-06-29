namespace System.Security.Cryptography.X509Certificates;

internal struct AsnValueReader
{
	private static readonly byte[] s_singleByte = new byte[1];

	private ReadOnlySpan<byte> _span;

	private readonly AsnEncodingRules _ruleSet;

	internal bool HasData => !_span.IsEmpty;

	internal AsnValueReader(ReadOnlySpan<byte> span, AsnEncodingRules ruleSet)
	{
		_span = span;
		_ruleSet = ruleSet;
	}

	internal void ThrowIfNotEmpty()
	{
		if (!_span.IsEmpty)
		{
			new AsnReader(s_singleByte, _ruleSet).ThrowIfNotEmpty();
		}
	}

	internal Asn1Tag PeekTag()
	{
		int bytesConsumed;
		return Asn1Tag.Decode(_span, out bytesConsumed);
	}

	internal ReadOnlySpan<byte> PeekContentBytes()
	{
		AsnDecoder.ReadEncodedValue(_span, _ruleSet, out var contentOffset, out var contentLength, out var _);
		return _span.Slice(contentOffset, contentLength);
	}

	internal ReadOnlySpan<byte> PeekEncodedValue()
	{
		AsnDecoder.ReadEncodedValue(_span, _ruleSet, out var _, out var _, out var bytesConsumed);
		return _span.Slice(0, bytesConsumed);
	}

	internal ReadOnlySpan<byte> ReadEncodedValue()
	{
		ReadOnlySpan<byte> result = PeekEncodedValue();
		_span = _span.Slice(result.Length);
		return result;
	}

	internal bool TryReadInt32(out int value)
	{
		return TryReadInt32(out value, null);
	}

	internal bool TryReadInt32(out int value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadInt32(_span, _ruleSet, out value, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal ReadOnlySpan<byte> ReadIntegerBytes()
	{
		return ReadIntegerBytes(null);
	}

	internal ReadOnlySpan<byte> ReadIntegerBytes(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		ReadOnlySpan<byte> result = AsnDecoder.ReadIntegerBytes(_span, _ruleSet, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal bool TryReadPrimitiveBitString(out int unusedBitCount, out ReadOnlySpan<byte> value)
	{
		return TryReadPrimitiveBitString(out unusedBitCount, out value, null);
	}

	internal bool TryReadPrimitiveBitString(out int unusedBitCount, out ReadOnlySpan<byte> value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadPrimitiveBitString(_span, _ruleSet, out unusedBitCount, out value, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal byte[] ReadBitString(out int unusedBitCount)
	{
		return ReadBitString(out unusedBitCount, null);
	}

	internal byte[] ReadBitString(out int unusedBitCount, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadBitString(_span, _ruleSet, out unusedBitCount, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal bool TryReadPrimitiveOctetString(out ReadOnlySpan<byte> value)
	{
		return TryReadPrimitiveOctetString(out value, null);
	}

	internal bool TryReadPrimitiveOctetString(out ReadOnlySpan<byte> value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadPrimitiveOctetString(_span, _ruleSet, out value, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal byte[] ReadOctetString()
	{
		return ReadOctetString(null);
	}

	internal byte[] ReadOctetString(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadOctetString(_span, _ruleSet, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal byte[] ReadObjectIdentifier()
	{
		return ReadObjectIdentifier(null);
	}

	internal byte[] ReadObjectIdentifier(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadObjectIdentifier(_span, _ruleSet, out bytesConsumed, expectedTag);
		_span = _span.Slice(bytesConsumed);
		return result;
	}

	internal AsnValueReader ReadSequence()
	{
		return ReadSequence(null);
	}

	internal AsnValueReader ReadSequence(Asn1Tag? expectedTag)
	{
		AsnDecoder.ReadSequence(_span, _ruleSet, out var contentOffset, out var contentLength, out var bytesConsumed, expectedTag);
		ReadOnlySpan<byte> span = _span.Slice(contentOffset, contentLength);
		_span = _span.Slice(bytesConsumed);
		return new AsnValueReader(span, _ruleSet);
	}

	internal AsnValueReader ReadSetOf()
	{
		return ReadSetOf(null, skipSortOrderValidation: false);
	}

	internal AsnValueReader ReadSetOf(Asn1Tag? expectedTag)
	{
		return ReadSetOf(expectedTag, skipSortOrderValidation: false);
	}

	internal AsnValueReader ReadSetOf(Asn1Tag? expectedTag, bool skipSortOrderValidation)
	{
		AsnDecoder.ReadSetOf(_span, _ruleSet, out var contentOffset, out var contentLength, out var bytesConsumed, skipSortOrderValidation, expectedTag);
		ReadOnlySpan<byte> span = _span.Slice(contentOffset, contentLength);
		_span = _span.Slice(bytesConsumed);
		return new AsnValueReader(span, _ruleSet);
	}
}

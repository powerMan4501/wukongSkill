namespace System.Security.Cryptography.X509Certificates;

internal class AsnReader
{
	internal const int MaxCERSegmentSize = 1000;

	private ReadOnlyMemory<byte> _data;

	private readonly AsnReaderOptions _options;

	private AsnEncodingRules _ruleSet;

	public AsnEncodingRules RuleSet => _ruleSet;

	public bool HasData => !_data.IsEmpty;

	public bool TryReadPrimitiveBitString(out int unusedBitCount, out ReadOnlyMemory<byte> value, Asn1Tag? expectedTag)
	{
		ReadOnlySpan<byte> value2;
		int bytesConsumed;
		bool flag = AsnDecoder.TryReadPrimitiveBitString(_data.Span, RuleSet, out unusedBitCount, out value2, out bytesConsumed, expectedTag);
		if (flag)
		{
			value = AsnDecoder.Slice(_data, value2);
			_data = _data.Slice(bytesConsumed);
		}
		else
		{
			value = default(ReadOnlyMemory<byte>);
		}
		return flag;
	}

	public bool TryReadBitString(Span<byte> destination, out int unusedBitCount, out int bytesWritten, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool flag = AsnDecoder.TryReadBitString(_data.Span, destination, RuleSet, out unusedBitCount, out bytesConsumed, out bytesWritten, expectedTag);
		if (flag)
		{
			_data = _data.Slice(bytesConsumed);
		}
		return flag;
	}

	public byte[] ReadBitString(out int unusedBitCount, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadBitString(_data.Span, RuleSet, out unusedBitCount, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public AsnReader(ReadOnlyMemory<byte> data, AsnEncodingRules ruleSet, AsnReaderOptions options)
	{
		AsnDecoder.CheckEncodingRules(ruleSet);
		_data = data;
		_ruleSet = ruleSet;
		_options = options;
	}

	public AsnReader(ReadOnlyMemory<byte> data, AsnEncodingRules ruleSet)
		: this(data, ruleSet, default(AsnReaderOptions))
	{
	}

	public void ThrowIfNotEmpty()
	{
		if (HasData)
		{
			throw new InvalidOperationException("The last expected value has been read, but the reader still has pending data. This value may be from a newer schema, or is corrupt.");
		}
	}

	public Asn1Tag PeekTag()
	{
		int bytesConsumed;
		return Asn1Tag.Decode(_data.Span, out bytesConsumed);
	}

	public ReadOnlyMemory<byte> PeekEncodedValue()
	{
		AsnDecoder.ReadEncodedValue(_data.Span, RuleSet, out var _, out var _, out var bytesConsumed);
		return _data.Slice(0, bytesConsumed);
	}

	public ReadOnlyMemory<byte> PeekContentBytes()
	{
		AsnDecoder.ReadEncodedValue(_data.Span, RuleSet, out var contentOffset, out var contentLength, out var _);
		return _data.Slice(contentOffset, contentLength);
	}

	public ReadOnlyMemory<byte> ReadEncodedValue()
	{
		ReadOnlyMemory<byte> result = PeekEncodedValue();
		_data = _data.Slice(result.Length);
		return result;
	}

	private AsnReader CloneAtSlice(int start, int length)
	{
		return new AsnReader(_data.Slice(start, length), RuleSet, _options);
	}

	public ReadOnlyMemory<byte> ReadIntegerBytes(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		ReadOnlySpan<byte> smaller = AsnDecoder.ReadIntegerBytes(_data.Span, RuleSet, out bytesConsumed, expectedTag);
		ReadOnlyMemory<byte> result = AsnDecoder.Slice(_data, smaller);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public bool TryReadInt32(out int value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadInt32(_data.Span, RuleSet, out value, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public bool TryReadUInt32(out uint value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadUInt32(_data.Span, RuleSet, out value, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public bool TryReadInt64(out long value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadInt64(_data.Span, RuleSet, out value, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public bool TryReadUInt64(out ulong value, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool result = AsnDecoder.TryReadUInt64(_data.Span, RuleSet, out value, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public void ReadNull(Asn1Tag? expectedTag)
	{
		AsnDecoder.ReadNull(_data.Span, RuleSet, out var bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
	}

	public bool TryReadOctetString(Span<byte> destination, out int bytesWritten, Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		bool flag = AsnDecoder.TryReadOctetString(_data.Span, destination, RuleSet, out bytesConsumed, out bytesWritten, expectedTag);
		if (flag)
		{
			_data = _data.Slice(bytesConsumed);
		}
		return flag;
	}

	public byte[] ReadOctetString(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadOctetString(_data.Span, RuleSet, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public bool TryReadPrimitiveOctetString(out ReadOnlyMemory<byte> contents, Asn1Tag? expectedTag)
	{
		ReadOnlySpan<byte> value;
		int bytesConsumed;
		bool flag = AsnDecoder.TryReadPrimitiveOctetString(_data.Span, RuleSet, out value, out bytesConsumed, expectedTag);
		if (flag)
		{
			contents = AsnDecoder.Slice(_data, value);
			_data = _data.Slice(bytesConsumed);
		}
		else
		{
			contents = default(ReadOnlyMemory<byte>);
		}
		return flag;
	}

	public byte[] ReadObjectIdentifier(Asn1Tag? expectedTag)
	{
		int bytesConsumed;
		byte[] result = AsnDecoder.ReadObjectIdentifier(_data.Span, RuleSet, out bytesConsumed, expectedTag);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public AsnReader ReadSequence(Asn1Tag? expectedTag)
	{
		AsnDecoder.ReadSequence(_data.Span, RuleSet, out var contentOffset, out var contentLength, out var bytesConsumed, expectedTag);
		AsnReader result = CloneAtSlice(contentOffset, contentLength);
		_data = _data.Slice(bytesConsumed);
		return result;
	}

	public AsnReader ReadSetOf(Asn1Tag? expectedTag)
	{
		return ReadSetOf(_options.SkipSetSortOrderVerification, expectedTag);
	}

	public AsnReader ReadSetOf(bool skipSortOrderValidation, Asn1Tag? expectedTag)
	{
		AsnDecoder.ReadSetOf(_data.Span, RuleSet, out var contentOffset, out var contentLength, out var bytesConsumed, skipSortOrderValidation, expectedTag);
		AsnReader result = CloneAtSlice(contentOffset, contentLength);
		_data = _data.Slice(bytesConsumed);
		return result;
	}
}

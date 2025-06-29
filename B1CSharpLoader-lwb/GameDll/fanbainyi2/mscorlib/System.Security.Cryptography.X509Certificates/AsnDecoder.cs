using System.Collections;
using System.Diagnostics;
using System.Globalization;

namespace System.Security.Cryptography.X509Certificates;

internal static class AsnDecoder
{
	private delegate void BitStringCopyAction(ReadOnlySpan<byte> value, byte normalizedLastByte, Span<byte> destination);

	private struct ParseFrame
	{
		private int _offset;

		private int _length;

		private bool _indefinite;

		private int _bytesRead;

		public int Offset => _offset;

		public int Length => _length;

		public bool Indefinite => _indefinite;

		public int BytesRead => _bytesRead;

		public ParseFrame(int offset, int length, bool indefinite, int bytesRead)
		{
			_offset = offset;
			_length = length;
			_indefinite = indefinite;
			_bytesRead = bytesRead;
		}
	}

	private enum LengthDecodeStatus
	{
		NeedMoreData,
		DerIndefinite,
		ReservedValue,
		LengthTooBig,
		LaxEncodingProhibited,
		Success
	}

	private enum LengthValidity
	{
		CerRequiresIndefinite,
		PrimitiveEncodingRequiresDefinite,
		LengthExceedsInput,
		Valid
	}

	internal const int MaxCERSegmentSize = 1000;

	internal const int EndOfContentsEncodedLength = 2;

	public static bool TryReadPrimitiveBitString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int unusedBitCount, out ReadOnlySpan<byte> value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		if (TryReadPrimitiveBitStringCore(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveBitString, out var _, out var _, out var unusedBitCount2, out var value2, out var bytesConsumed2, out var normalizedLastByte) && (value2.Length == 0 || normalizedLastByte == value2[value2.Length - 1]))
		{
			unusedBitCount = unusedBitCount2;
			value = value2;
			bytesConsumed = bytesConsumed2;
			return true;
		}
		unusedBitCount = 0;
		value = default(ReadOnlySpan<byte>);
		bytesConsumed = 0;
		return false;
	}

	public static bool TryReadBitString(ReadOnlySpan<byte> source, Span<byte> destination, AsnEncodingRules ruleSet, out int unusedBitCount, out int bytesConsumed, out int bytesWritten, Asn1Tag? expectedTag)
	{
		if (source.Overlaps(destination))
		{
			throw new ArgumentException("The destination buffer overlaps the source buffer.", "destination");
		}
		if (TryReadPrimitiveBitStringCore(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveBitString, out var contentsLength, out var headerLength, out var unusedBitCount2, out var value, out var bytesConsumed2, out var normalizedLastByte))
		{
			if (value.Length > destination.Length)
			{
				bytesConsumed = 0;
				bytesWritten = 0;
				unusedBitCount = 0;
				return false;
			}
			CopyBitStringValue(value, normalizedLastByte, destination);
			bytesWritten = value.Length;
			bytesConsumed = bytesConsumed2;
			unusedBitCount = unusedBitCount2;
			return true;
		}
		if (TryCopyConstructedBitStringValue(Slice(source, headerLength, contentsLength), ruleSet, destination, !contentsLength.HasValue, out unusedBitCount2, out var bytesRead, out var bytesWritten2))
		{
			unusedBitCount = unusedBitCount2;
			bytesConsumed = headerLength + bytesRead;
			bytesWritten = bytesWritten2;
			return true;
		}
		bytesWritten = (bytesConsumed = (unusedBitCount = 0));
		return false;
	}

	public static byte[] ReadBitString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int unusedBitCount, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		if (TryReadPrimitiveBitStringCore(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveBitString, out var contentsLength, out var headerLength, out var unusedBitCount2, out var value, out var bytesConsumed2, out var normalizedLastByte))
		{
			byte[] array = value.ToArray();
			if (value.Length > 0)
			{
				array[array.Length - 1] = normalizedLastByte;
			}
			unusedBitCount = unusedBitCount2;
			bytesConsumed = bytesConsumed2;
			return array;
		}
		int size = contentsLength ?? SeekEndOfContents(source.Slice(headerLength), ruleSet);
		byte[] array2 = CryptoPool.Rent(size);
		if (TryCopyConstructedBitStringValue(Slice(source, headerLength, contentsLength), ruleSet, array2, !contentsLength.HasValue, out unusedBitCount2, out var bytesRead, out var bytesWritten))
		{
			byte[] result = Utility.GetSpanForArray(array2, 0, bytesWritten).ToArray();
			CryptoPool.Return(array2, bytesWritten);
			unusedBitCount = unusedBitCount2;
			bytesConsumed = headerLength + bytesRead;
			return result;
		}
		throw new InvalidOperationException("TryCopyConstructedBitStringValue failed with a pre-allocated buffer");
	}

	private static void ParsePrimitiveBitStringContents(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int unusedBitCount, out ReadOnlySpan<byte> value, out byte normalizedLastByte)
	{
		if (ruleSet == AsnEncodingRules.CER && source.Length > 1000)
		{
			throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.");
		}
		if (source.Length == 0)
		{
			throw new InvalidOperationException();
		}
		unusedBitCount = source[0];
		if (unusedBitCount > 7)
		{
			throw new InvalidOperationException();
		}
		if (source.Length == 1)
		{
			if (unusedBitCount > 0)
			{
				throw new InvalidOperationException();
			}
			value = ReadOnlySpan<byte>.Empty;
			normalizedLastByte = 0;
			return;
		}
		int num = -1 << unusedBitCount;
		byte b = source[source.Length - 1];
		byte b2 = (byte)(b & num);
		if (b2 != b && (ruleSet == AsnEncodingRules.DER || ruleSet == AsnEncodingRules.CER))
		{
			throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
		}
		normalizedLastByte = b2;
		value = source.Slice(1);
	}

	private static void CopyBitStringValue(ReadOnlySpan<byte> value, byte normalizedLastByte, Span<byte> destination)
	{
		if (value.Length != 0)
		{
			value.CopyTo(destination);
			destination[value.Length - 1] = normalizedLastByte;
		}
	}

	private static int CountConstructedBitString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, bool isIndefinite)
	{
		Span<byte> empty = Span<byte>.Empty;
		int lastUnusedBitCount;
		int bytesRead;
		return ProcessConstructedBitString(source, ruleSet, empty, null, isIndefinite, out lastUnusedBitCount, out bytesRead);
	}

	private static void CopyConstructedBitString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> destination, bool isIndefinite, out int unusedBitCount, out int bytesRead, out int bytesWritten)
	{
		bytesWritten = ProcessConstructedBitString(source, ruleSet, destination, CopyBitStringValue, isIndefinite, out unusedBitCount, out bytesRead);
	}

	private static int ProcessConstructedBitString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> destination, BitStringCopyAction copyAction, bool isIndefinite, out int lastUnusedBitCount, out int bytesRead)
	{
		lastUnusedBitCount = 0;
		bytesRead = 0;
		int num = 1000;
		ReadOnlySpan<byte> readOnlySpan = source;
		Stack stack = null;
		int num2 = 0;
		Asn1Tag asn1Tag = Asn1Tag.ConstructedBitString;
		Span<byte> destination2 = destination;
		while (true)
		{
			if (!readOnlySpan.IsEmpty)
			{
				asn1Tag = ReadTagAndLength(readOnlySpan, ruleSet, out var contentsLength, out var bytesRead2);
				if (asn1Tag == Asn1Tag.PrimitiveBitString)
				{
					if (lastUnusedBitCount != 0)
					{
						throw new InvalidOperationException();
					}
					if (ruleSet == AsnEncodingRules.CER && num != 1000)
					{
						throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.");
					}
					ReadOnlySpan<byte> source2 = Slice(readOnlySpan, bytesRead2, contentsLength.Value);
					ParsePrimitiveBitStringContents(source2, ruleSet, out lastUnusedBitCount, out var value, out var normalizedLastByte);
					int num3 = bytesRead2 + source2.Length;
					readOnlySpan = readOnlySpan.Slice(num3);
					bytesRead += num3;
					num2 += value.Length;
					num = source2.Length;
					if (copyAction != null)
					{
						copyAction(value, normalizedLastByte, destination2);
						destination2 = destination2.Slice(value.Length);
					}
					continue;
				}
				if (!(asn1Tag == Asn1Tag.EndOfContents && isIndefinite))
				{
					if (asn1Tag == Asn1Tag.ConstructedBitString)
					{
						if (ruleSet == AsnEncodingRules.CER)
						{
							throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
						}
						if (stack == null)
						{
							stack = new Stack();
						}
						if (!source.Overlaps(readOnlySpan, out var elementOffset))
						{
							throw new InvalidOperationException();
						}
						stack.Push(new ParseFrame(elementOffset, readOnlySpan.Length, isIndefinite, bytesRead));
						readOnlySpan = Slice(readOnlySpan, bytesRead2, contentsLength);
						bytesRead = bytesRead2;
						isIndefinite = !contentsLength.HasValue;
						continue;
					}
					throw new InvalidOperationException();
				}
				ValidateEndOfContents(asn1Tag, contentsLength, bytesRead2);
				bytesRead += bytesRead2;
				if (stack != null && stack.Count > 0)
				{
					ParseFrame parseFrame = (ParseFrame)stack.Pop();
					readOnlySpan = source.Slice(parseFrame.Offset, parseFrame.Length).Slice(bytesRead);
					bytesRead += parseFrame.BytesRead;
					isIndefinite = parseFrame.Indefinite;
					continue;
				}
			}
			if (isIndefinite && asn1Tag != Asn1Tag.EndOfContents)
			{
				throw new InvalidOperationException();
			}
			if (stack == null || stack.Count <= 0)
			{
				break;
			}
			ParseFrame parseFrame2 = (ParseFrame)stack.Pop();
			readOnlySpan = source.Slice(parseFrame2.Offset, parseFrame2.Length).Slice(bytesRead);
			isIndefinite = parseFrame2.Indefinite;
			bytesRead += parseFrame2.BytesRead;
		}
		return num2;
	}

	private static bool TryCopyConstructedBitStringValue(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> dest, bool isIndefinite, out int unusedBitCount, out int bytesRead, out int bytesWritten)
	{
		int num = CountConstructedBitString(source, ruleSet, isIndefinite);
		if (ruleSet == AsnEncodingRules.CER && num < 1000)
		{
			throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
		}
		if (dest.Length < num)
		{
			unusedBitCount = 0;
			bytesRead = 0;
			bytesWritten = 0;
			return false;
		}
		CopyConstructedBitString(source, ruleSet, dest, isIndefinite, out unusedBitCount, out bytesRead, out bytesWritten);
		return true;
	}

	private static bool TryReadPrimitiveBitStringCore(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag expectedTag, out int? contentsLength, out int headerLength, out int unusedBitCount, out ReadOnlySpan<byte> value, out int bytesConsumed, out byte normalizedLastByte)
	{
		Asn1Tag tag = ReadTagAndLength(source, ruleSet, out contentsLength, out headerLength);
		CheckExpectedTag(tag, expectedTag, UniversalTagNumber.BitString);
		ReadOnlySpan<byte> source2 = Slice(source, headerLength, contentsLength);
		if (tag.IsConstructed)
		{
			if (ruleSet == AsnEncodingRules.DER)
			{
				throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER or CER encoding.");
			}
			unusedBitCount = 0;
			value = default(ReadOnlySpan<byte>);
			normalizedLastByte = 0;
			bytesConsumed = 0;
			return false;
		}
		ParsePrimitiveBitStringContents(source2, ruleSet, out unusedBitCount, out value, out normalizedLastByte);
		bytesConsumed = headerLength + source2.Length;
		return true;
	}

	public static bool TryReadEncodedValue(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out Asn1Tag tag, out int contentOffset, out int contentLength, out int bytesConsumed)
	{
		CheckEncodingRules(ruleSet);
		if (Asn1Tag.TryDecode(source, out var tag2, out var bytesConsumed2) && TryReadLength(source.Slice(bytesConsumed2), ruleSet, out var length, out var bytesRead))
		{
			int num = bytesConsumed2 + bytesRead;
			int actualLength;
			int bytesConsumed3;
			LengthValidity lengthValidity = ValidateLength(source.Slice(num), ruleSet, tag2, length, out actualLength, out bytesConsumed3);
			if (lengthValidity == LengthValidity.Valid)
			{
				tag = tag2;
				contentOffset = num;
				contentLength = actualLength;
				bytesConsumed = num + bytesConsumed3;
				return true;
			}
		}
		tag = default(Asn1Tag);
		contentOffset = (contentLength = (bytesConsumed = 0));
		return false;
	}

	public static Asn1Tag ReadEncodedValue(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int contentOffset, out int contentLength, out int bytesConsumed)
	{
		CheckEncodingRules(ruleSet);
		int bytesConsumed2;
		Asn1Tag asn1Tag = Asn1Tag.Decode(source, out bytesConsumed2);
		int bytesConsumed3;
		int? encodedLength = ReadLength(source.Slice(bytesConsumed2), ruleSet, out bytesConsumed3);
		int num = bytesConsumed2 + bytesConsumed3;
		int actualLength;
		int bytesConsumed4;
		LengthValidity lengthValidity = ValidateLength(source.Slice(num), ruleSet, asn1Tag, encodedLength, out actualLength, out bytesConsumed4);
		if (lengthValidity == LengthValidity.Valid)
		{
			contentOffset = num;
			contentLength = actualLength;
			bytesConsumed = num + bytesConsumed4;
			return asn1Tag;
		}
		throw GetValidityException(lengthValidity);
	}

	private static ReadOnlySpan<byte> GetPrimitiveContentSpan(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag expectedTag, UniversalTagNumber tagNumber, out int bytesConsumed)
	{
		CheckEncodingRules(ruleSet);
		int bytesConsumed2;
		Asn1Tag tag = Asn1Tag.Decode(source, out bytesConsumed2);
		int bytesConsumed3;
		int? num = ReadLength(source.Slice(bytesConsumed2), ruleSet, out bytesConsumed3);
		int num2 = bytesConsumed2 + bytesConsumed3;
		CheckExpectedTag(tag, expectedTag, tagNumber);
		if (tag.IsConstructed)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "The encoded value uses a constructed encoding, which is invalid for '{0}' values.", tagNumber));
		}
		if (!num.HasValue)
		{
			throw new InvalidOperationException();
		}
		ReadOnlySpan<byte> result = Slice(source, num2, num.Value);
		bytesConsumed = num2 + result.Length;
		return result;
	}

	private static bool TryReadLength(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int? length, out int bytesRead)
	{
		return DecodeLength(source, ruleSet, out length, out bytesRead) == LengthDecodeStatus.Success;
	}

	private static int? ReadLength(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int bytesConsumed)
	{
		int? length;
		switch (DecodeLength(source, ruleSet, out length, out bytesConsumed))
		{
		case LengthDecodeStatus.Success:
			return length;
		case LengthDecodeStatus.LengthTooBig:
			throw new InvalidOperationException("The encoded length exceeds the maximum supported by this library (Int32.MaxValue).");
		case LengthDecodeStatus.DerIndefinite:
		case LengthDecodeStatus.LaxEncodingProhibited:
			throw new InvalidOperationException("The encoded length is not valid under the requested encoding rules, the value may be valid under the BER encoding.");
		default:
			throw new InvalidOperationException();
		}
	}

	private static LengthDecodeStatus DecodeLength(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int? length, out int bytesRead)
	{
		length = null;
		bytesRead = 0;
		if (source.IsEmpty)
		{
			return LengthDecodeStatus.NeedMoreData;
		}
		byte b = source[bytesRead];
		bytesRead++;
		if (b == 128)
		{
			if (ruleSet == AsnEncodingRules.DER)
			{
				bytesRead = 0;
				return LengthDecodeStatus.DerIndefinite;
			}
			return LengthDecodeStatus.Success;
		}
		if (b < 128)
		{
			length = b;
			return LengthDecodeStatus.Success;
		}
		if (b == byte.MaxValue)
		{
			bytesRead = 0;
			return LengthDecodeStatus.ReservedValue;
		}
		byte b2 = (byte)(b & -129);
		if (b2 + 1 > source.Length)
		{
			bytesRead = 0;
			return LengthDecodeStatus.NeedMoreData;
		}
		bool flag = ruleSet == AsnEncodingRules.DER || ruleSet == AsnEncodingRules.CER;
		if (flag && b2 > 4)
		{
			bytesRead = 0;
			return LengthDecodeStatus.LengthTooBig;
		}
		uint num = 0u;
		for (int i = 0; i < b2; i++)
		{
			byte b3 = source[bytesRead];
			bytesRead++;
			if (num == 0)
			{
				if (flag && b3 == 0)
				{
					bytesRead = 0;
					return LengthDecodeStatus.LaxEncodingProhibited;
				}
				if (!flag && b3 != 0 && b2 - i > 4)
				{
					bytesRead = 0;
					return LengthDecodeStatus.LengthTooBig;
				}
			}
			num <<= 8;
			num |= b3;
		}
		if (num > int.MaxValue)
		{
			bytesRead = 0;
			return LengthDecodeStatus.LengthTooBig;
		}
		if (flag && num < 128)
		{
			bytesRead = 0;
			return LengthDecodeStatus.LaxEncodingProhibited;
		}
		length = (int)num;
		return LengthDecodeStatus.Success;
	}

	private static Asn1Tag ReadTagAndLength(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int? contentsLength, out int bytesRead)
	{
		int bytesConsumed;
		Asn1Tag result = Asn1Tag.Decode(source, out bytesConsumed);
		int bytesConsumed2;
		int? num = ReadLength(source.Slice(bytesConsumed), ruleSet, out bytesConsumed2);
		int num2 = bytesConsumed + bytesConsumed2;
		if (result.IsConstructed)
		{
			if (ruleSet == AsnEncodingRules.CER && num.HasValue)
			{
				throw GetValidityException(LengthValidity.CerRequiresIndefinite);
			}
		}
		else if (!num.HasValue)
		{
			throw GetValidityException(LengthValidity.PrimitiveEncodingRequiresDefinite);
		}
		bytesRead = num2;
		contentsLength = num;
		return result;
	}

	private static void ValidateEndOfContents(Asn1Tag tag, int? length, int headerLength)
	{
		if (tag.IsConstructed || length != 0 || headerLength != 2)
		{
			throw new InvalidOperationException();
		}
	}

	private static LengthValidity ValidateLength(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag localTag, int? encodedLength, out int actualLength, out int bytesConsumed)
	{
		if (localTag.IsConstructed)
		{
			if (ruleSet == AsnEncodingRules.CER && encodedLength.HasValue)
			{
				actualLength = (bytesConsumed = 0);
				return LengthValidity.CerRequiresIndefinite;
			}
		}
		else if (!encodedLength.HasValue)
		{
			actualLength = (bytesConsumed = 0);
			return LengthValidity.PrimitiveEncodingRequiresDefinite;
		}
		if (encodedLength.HasValue)
		{
			int value = encodedLength.Value;
			int num = value;
			if (num > source.Length)
			{
				actualLength = (bytesConsumed = 0);
				return LengthValidity.LengthExceedsInput;
			}
			actualLength = value;
			bytesConsumed = value;
			return LengthValidity.Valid;
		}
		actualLength = SeekEndOfContents(source, ruleSet);
		bytesConsumed = actualLength + 2;
		return LengthValidity.Valid;
	}

	private static InvalidOperationException GetValidityException(LengthValidity validity)
	{
		return validity switch
		{
			LengthValidity.CerRequiresIndefinite => new InvalidOperationException("A constructed tag used a definite length encoding, which is invalid for CER data. The input may be encoded with BER or DER."), 
			LengthValidity.LengthExceedsInput => new InvalidOperationException("The encoded length exceeds the number of bytes remaining in the input buffer."), 
			_ => new InvalidOperationException(), 
		};
	}

	private static int GetPrimitiveIntegerSize(Type primitiveType)
	{
		if (primitiveType == typeof(byte) || primitiveType == typeof(sbyte))
		{
			return 1;
		}
		if (primitiveType == typeof(short) || primitiveType == typeof(ushort))
		{
			return 2;
		}
		if (primitiveType == typeof(int) || primitiveType == typeof(uint))
		{
			return 4;
		}
		if (primitiveType == typeof(long) || primitiveType == typeof(ulong))
		{
			return 8;
		}
		return 0;
	}

	private static int SeekEndOfContents(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet)
	{
		ReadOnlySpan<byte> source2 = source;
		int num = 0;
		int num2 = 1;
		while (!source2.IsEmpty)
		{
			int? contentsLength;
			int bytesRead;
			Asn1Tag asn1Tag = ReadTagAndLength(source2, ruleSet, out contentsLength, out bytesRead);
			if (asn1Tag == Asn1Tag.EndOfContents)
			{
				ValidateEndOfContents(asn1Tag, contentsLength, bytesRead);
				num2--;
				if (num2 == 0)
				{
					return num;
				}
			}
			if (!contentsLength.HasValue)
			{
				num2++;
				source2 = source2.Slice(bytesRead);
				num += bytesRead;
			}
			else
			{
				ReadOnlySpan<byte> readOnlySpan = Slice(source2, 0, bytesRead + contentsLength.Value);
				source2 = source2.Slice(readOnlySpan.Length);
				num += readOnlySpan.Length;
			}
		}
		throw new InvalidOperationException();
	}

	private static ReadOnlySpan<byte> SliceAtMost(ReadOnlySpan<byte> source, int longestPermitted)
	{
		int length = Math.Min(longestPermitted, source.Length);
		return source.Slice(0, length);
	}

	private static ReadOnlySpan<byte> Slice(ReadOnlySpan<byte> source, int offset, int length)
	{
		if (length < 0 || source.Length - offset < length)
		{
			throw new InvalidOperationException("The encoded length exceeds the number of bytes remaining in the input buffer.");
		}
		return source.Slice(offset, length);
	}

	private static ReadOnlySpan<byte> Slice(ReadOnlySpan<byte> source, int offset, int? length)
	{
		if (!length.HasValue)
		{
			return source.Slice(offset);
		}
		int value = length.Value;
		if (value < 0 || source.Length - offset < value)
		{
			throw new InvalidOperationException("The encoded length exceeds the number of bytes remaining in the input buffer.");
		}
		return source.Slice(offset, value);
	}

	internal static ReadOnlyMemory<byte> Slice(ReadOnlyMemory<byte> bigger, ReadOnlySpan<byte> smaller)
	{
		if (smaller.IsEmpty)
		{
			return default(ReadOnlyMemory<byte>);
		}
		if (bigger.Span.Overlaps(smaller, out var elementOffset))
		{
			return bigger.Slice(elementOffset, smaller.Length);
		}
		throw new InvalidOperationException();
	}

	[Conditional("DEBUG")]
	private static void AssertEncodingRules(AsnEncodingRules ruleSet)
	{
	}

	internal static void CheckEncodingRules(AsnEncodingRules ruleSet)
	{
		if (ruleSet != AsnEncodingRules.BER && ruleSet != AsnEncodingRules.CER && ruleSet != AsnEncodingRules.DER)
		{
			throw new ArgumentOutOfRangeException("ruleSet");
		}
	}

	private static void CheckExpectedTag(Asn1Tag tag, Asn1Tag expectedTag, UniversalTagNumber tagNumber)
	{
		if (expectedTag.TagClass == TagClass.Universal && expectedTag.TagValue != (int)tagNumber)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written.", expectedTag));
		}
		if (expectedTag.TagClass != tag.TagClass || expectedTag.TagValue != tag.TagValue)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "The provided data is tagged with '{0}' class value '{1}', but it should have been '{2}' class value '{3}'.", tag.TagClass, tag.TagValue, expectedTag.TagClass, expectedTag.TagValue));
		}
	}

	public static ReadOnlySpan<byte> ReadIntegerBytes(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		return GetIntegerContents(source, ruleSet, expectedTag ?? Asn1Tag.Integer, UniversalTagNumber.Integer, out bytesConsumed);
	}

	public static bool TryReadInt32(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		if (TryReadSignedInteger(source, ruleSet, 4, expectedTag ?? Asn1Tag.Integer, UniversalTagNumber.Integer, out var value2, out bytesConsumed))
		{
			value = (int)value2;
			return true;
		}
		value = 0;
		return false;
	}

	public static bool TryReadUInt32(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out uint value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		if (TryReadUnsignedInteger(source, ruleSet, 4, expectedTag ?? Asn1Tag.Integer, UniversalTagNumber.Integer, out var value2, out bytesConsumed))
		{
			value = (uint)value2;
			return true;
		}
		value = 0u;
		return false;
	}

	public static bool TryReadInt64(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out long value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		return TryReadSignedInteger(source, ruleSet, 8, expectedTag ?? Asn1Tag.Integer, UniversalTagNumber.Integer, out value, out bytesConsumed);
	}

	public static bool TryReadUInt64(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out ulong value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		return TryReadUnsignedInteger(source, ruleSet, 8, expectedTag ?? Asn1Tag.Integer, UniversalTagNumber.Integer, out value, out bytesConsumed);
	}

	private static ReadOnlySpan<byte> GetIntegerContents(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag expectedTag, UniversalTagNumber tagNumber, out int bytesConsumed)
	{
		int bytesConsumed2;
		ReadOnlySpan<byte> primitiveContentSpan = GetPrimitiveContentSpan(source, ruleSet, expectedTag, tagNumber, out bytesConsumed2);
		if (primitiveContentSpan.IsEmpty)
		{
			throw new InvalidOperationException();
		}
		if (BinaryPrimitives.TryReadUInt16BigEndian(primitiveContentSpan, out var value))
		{
			ushort num = (ushort)(value & 0xFF80);
			if (num == 0 || num == 65408)
			{
				throw new InvalidOperationException();
			}
		}
		bytesConsumed = bytesConsumed2;
		return primitiveContentSpan;
	}

	private static bool TryReadSignedInteger(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, int sizeLimit, Asn1Tag expectedTag, UniversalTagNumber tagNumber, out long value, out int bytesConsumed)
	{
		int bytesConsumed2;
		ReadOnlySpan<byte> integerContents = GetIntegerContents(source, ruleSet, expectedTag, tagNumber, out bytesConsumed2);
		if (integerContents.Length > sizeLimit)
		{
			value = 0L;
			bytesConsumed = 0;
			return false;
		}
		long num = (((integerContents[0] & 0x80) != 0) ? (-1) : 0);
		for (int i = 0; i < integerContents.Length; i++)
		{
			num <<= 8;
			num |= integerContents[i];
		}
		bytesConsumed = bytesConsumed2;
		value = num;
		return true;
	}

	private static bool TryReadUnsignedInteger(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, int sizeLimit, Asn1Tag expectedTag, UniversalTagNumber tagNumber, out ulong value, out int bytesConsumed)
	{
		int bytesConsumed2;
		ReadOnlySpan<byte> readOnlySpan = GetIntegerContents(source, ruleSet, expectedTag, tagNumber, out bytesConsumed2);
		if ((readOnlySpan[0] & 0x80) != 0)
		{
			bytesConsumed = 0;
			value = 0uL;
			return false;
		}
		if (readOnlySpan.Length > 1 && readOnlySpan[0] == 0)
		{
			readOnlySpan = readOnlySpan.Slice(1);
		}
		if (readOnlySpan.Length > sizeLimit)
		{
			bytesConsumed = 0;
			value = 0uL;
			return false;
		}
		ulong num = 0uL;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			num <<= 8;
			num |= readOnlySpan[i];
		}
		bytesConsumed = bytesConsumed2;
		value = num;
		return true;
	}

	public static void ReadNull(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		if (GetPrimitiveContentSpan(source, ruleSet, expectedTag ?? Asn1Tag.Null, UniversalTagNumber.Null, out var bytesConsumed2).Length != 0)
		{
			throw new InvalidOperationException();
		}
		bytesConsumed = bytesConsumed2;
	}

	public static bool TryReadOctetString(ReadOnlySpan<byte> source, Span<byte> destination, AsnEncodingRules ruleSet, out int bytesConsumed, out int bytesWritten, Asn1Tag? expectedTag)
	{
		if (source.Overlaps(destination))
		{
			throw new ArgumentException("The destination buffer overlaps the source buffer.", "destination");
		}
		if (TryReadPrimitiveOctetStringCore(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveOctetString, UniversalTagNumber.OctetString, out var contentLength, out var headerLength, out var contents, out var bytesConsumed2))
		{
			if (contents.Length > destination.Length)
			{
				bytesWritten = 0;
				bytesConsumed = 0;
				return false;
			}
			contents.CopyTo(destination);
			bytesWritten = contents.Length;
			bytesConsumed = bytesConsumed2;
			return true;
		}
		int bytesRead;
		bool flag = TryCopyConstructedOctetStringContents(Slice(source, headerLength, contentLength), ruleSet, destination, !contentLength.HasValue, out bytesRead, out bytesWritten);
		if (flag)
		{
			bytesConsumed = headerLength + bytesRead;
		}
		else
		{
			bytesConsumed = 0;
		}
		return flag;
	}

	public static byte[] ReadOctetString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		byte[] rented = null;
		int bytesConsumed2;
		ReadOnlySpan<byte> octetStringContents = GetOctetStringContents(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveOctetString, UniversalTagNumber.OctetString, out bytesConsumed2, ref rented, default(Span<byte>));
		byte[] result = octetStringContents.ToArray();
		if (rented != null)
		{
			CryptoPool.Return(rented, octetStringContents.Length);
		}
		bytesConsumed = bytesConsumed2;
		return result;
	}

	private static bool TryReadPrimitiveOctetStringCore(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag expectedTag, UniversalTagNumber universalTagNumber, out int? contentLength, out int headerLength, out ReadOnlySpan<byte> contents, out int bytesConsumed)
	{
		Asn1Tag tag = ReadTagAndLength(source, ruleSet, out contentLength, out headerLength);
		CheckExpectedTag(tag, expectedTag, universalTagNumber);
		ReadOnlySpan<byte> readOnlySpan = Slice(source, headerLength, contentLength);
		if (tag.IsConstructed)
		{
			if (ruleSet == AsnEncodingRules.DER)
			{
				throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER or CER encoding.");
			}
			contents = default(ReadOnlySpan<byte>);
			bytesConsumed = 0;
			return false;
		}
		if (ruleSet == AsnEncodingRules.CER && readOnlySpan.Length > 1000)
		{
			throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.");
		}
		contents = readOnlySpan;
		bytesConsumed = headerLength + readOnlySpan.Length;
		return true;
	}

	public static bool TryReadPrimitiveOctetString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out ReadOnlySpan<byte> value, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		int? contentLength;
		int headerLength;
		return TryReadPrimitiveOctetStringCore(source, ruleSet, expectedTag ?? Asn1Tag.PrimitiveOctetString, UniversalTagNumber.OctetString, out contentLength, out headerLength, out value, out bytesConsumed);
	}

	private static int CountConstructedOctetString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, bool isIndefinite)
	{
		int bytesRead;
		int num = CopyConstructedOctetString(source, ruleSet, Span<byte>.Empty, write: false, isIndefinite, out bytesRead);
		if (ruleSet == AsnEncodingRules.CER && num <= 1000)
		{
			throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
		}
		return num;
	}

	private static void CopyConstructedOctetString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> destination, bool isIndefinite, out int bytesRead, out int bytesWritten)
	{
		bytesWritten = CopyConstructedOctetString(source, ruleSet, destination, write: true, isIndefinite, out bytesRead);
	}

	private static int CopyConstructedOctetString(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> destination, bool write, bool isIndefinite, out int bytesRead)
	{
		bytesRead = 0;
		int num = 1000;
		ReadOnlySpan<byte> readOnlySpan = source;
		Stack stack = null;
		int num2 = 0;
		Asn1Tag asn1Tag = Asn1Tag.ConstructedBitString;
		Span<byte> destination2 = destination;
		while (true)
		{
			if (!readOnlySpan.IsEmpty)
			{
				asn1Tag = ReadTagAndLength(readOnlySpan, ruleSet, out var contentsLength, out var bytesRead2);
				if (asn1Tag == Asn1Tag.PrimitiveOctetString)
				{
					if (ruleSet == AsnEncodingRules.CER && num != 1000)
					{
						throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
					}
					ReadOnlySpan<byte> readOnlySpan2 = Slice(readOnlySpan, bytesRead2, contentsLength.Value);
					int num3 = bytesRead2 + readOnlySpan2.Length;
					readOnlySpan = readOnlySpan.Slice(num3);
					bytesRead += num3;
					num2 += readOnlySpan2.Length;
					num = readOnlySpan2.Length;
					if (ruleSet == AsnEncodingRules.CER && num > 1000)
					{
						throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
					}
					if (write)
					{
						readOnlySpan2.CopyTo(destination2);
						destination2 = destination2.Slice(readOnlySpan2.Length);
					}
					continue;
				}
				if (!(asn1Tag == Asn1Tag.EndOfContents && isIndefinite))
				{
					if (asn1Tag == Asn1Tag.ConstructedOctetString)
					{
						if (ruleSet == AsnEncodingRules.CER)
						{
							throw new InvalidOperationException("The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.");
						}
						if (stack == null)
						{
							stack = new Stack();
						}
						if (!source.Overlaps(readOnlySpan, out var elementOffset))
						{
							throw new InvalidOperationException();
						}
						stack.Push(new ParseFrame(elementOffset, readOnlySpan.Length, isIndefinite, bytesRead));
						readOnlySpan = Slice(readOnlySpan, bytesRead2, contentsLength);
						bytesRead = bytesRead2;
						isIndefinite = !contentsLength.HasValue;
						continue;
					}
					throw new InvalidOperationException();
				}
				ValidateEndOfContents(asn1Tag, contentsLength, bytesRead2);
				bytesRead += bytesRead2;
				if (stack != null && stack.Count > 0)
				{
					ParseFrame parseFrame = (ParseFrame)stack.Pop();
					readOnlySpan = source.Slice(parseFrame.Offset, parseFrame.Length).Slice(bytesRead);
					bytesRead += parseFrame.BytesRead;
					isIndefinite = parseFrame.Indefinite;
					continue;
				}
			}
			if (isIndefinite && asn1Tag != Asn1Tag.EndOfContents)
			{
				throw new InvalidOperationException();
			}
			if (stack == null || stack.Count <= 0)
			{
				break;
			}
			ParseFrame parseFrame2 = (ParseFrame)stack.Pop();
			readOnlySpan = source.Slice(parseFrame2.Offset, parseFrame2.Length).Slice(bytesRead);
			isIndefinite = parseFrame2.Indefinite;
			bytesRead += parseFrame2.BytesRead;
		}
		return num2;
	}

	private static bool TryCopyConstructedOctetStringContents(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Span<byte> dest, bool isIndefinite, out int bytesRead, out int bytesWritten)
	{
		bytesRead = 0;
		int num = CountConstructedOctetString(source, ruleSet, isIndefinite);
		if (dest.Length < num)
		{
			bytesWritten = 0;
			return false;
		}
		CopyConstructedOctetString(source, ruleSet, dest, isIndefinite, out bytesRead, out bytesWritten);
		return true;
	}

	private static ReadOnlySpan<byte> GetOctetStringContents(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, Asn1Tag expectedTag, UniversalTagNumber universalTagNumber, out int bytesConsumed, ref byte[] rented, Span<byte> tmpSpace)
	{
		if (TryReadPrimitiveOctetStringCore(source, ruleSet, expectedTag, universalTagNumber, out var contentLength, out var headerLength, out var contents, out bytesConsumed))
		{
			return contents;
		}
		contents = source.Slice(headerLength);
		int num = contentLength ?? SeekEndOfContents(contents, ruleSet);
		if (tmpSpace.Length > 0 && num > tmpSpace.Length)
		{
			bool isIndefinite = !contentLength.HasValue;
			num = CountConstructedOctetString(contents, ruleSet, isIndefinite);
		}
		if (num > tmpSpace.Length)
		{
			rented = CryptoPool.Rent(num);
			tmpSpace = rented;
		}
		if (TryCopyConstructedOctetStringContents(Slice(source, headerLength, contentLength), ruleSet, tmpSpace, !contentLength.HasValue, out var bytesRead, out var bytesWritten))
		{
			bytesConsumed = headerLength + bytesRead;
			return tmpSpace.Slice(0, bytesWritten);
		}
		throw new InvalidOperationException();
	}

	public static byte[] ReadObjectIdentifier(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		int bytesConsumed2;
		ReadOnlySpan<byte> primitiveContentSpan = GetPrimitiveContentSpan(source, ruleSet, expectedTag ?? Asn1Tag.ObjectIdentifier, UniversalTagNumber.ObjectIdentifier, out bytesConsumed2);
		bytesConsumed = bytesConsumed2;
		return primitiveContentSpan.ToArray();
	}

	public static void ReadSequence(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int contentOffset, out int contentLength, out int bytesConsumed, Asn1Tag? expectedTag)
	{
		int? contentsLength;
		int bytesRead;
		Asn1Tag tag = ReadTagAndLength(source, ruleSet, out contentsLength, out bytesRead);
		CheckExpectedTag(tag, expectedTag ?? Asn1Tag.Sequence, UniversalTagNumber.Sequence);
		if (!tag.IsConstructed)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "The encoded value uses a primitive encoding, which is invalid for '{0}' values.", UniversalTagNumber.Sequence));
		}
		if (contentsLength.HasValue)
		{
			if (contentsLength.Value + bytesRead > source.Length)
			{
				throw GetValidityException(LengthValidity.LengthExceedsInput);
			}
			contentLength = contentsLength.Value;
			contentOffset = bytesRead;
			bytesConsumed = contentLength + bytesRead;
		}
		else
		{
			int num = (contentLength = SeekEndOfContents(source.Slice(bytesRead), ruleSet));
			contentOffset = bytesRead;
			bytesConsumed = num + bytesRead + 2;
		}
	}

	public static void ReadSetOf(ReadOnlySpan<byte> source, AsnEncodingRules ruleSet, out int contentOffset, out int contentLength, out int bytesConsumed, bool skipSortOrderValidation, Asn1Tag? expectedTag)
	{
		int? contentsLength;
		int bytesRead;
		Asn1Tag tag = ReadTagAndLength(source, ruleSet, out contentsLength, out bytesRead);
		CheckExpectedTag(tag, expectedTag ?? Asn1Tag.SetOf, UniversalTagNumber.Set);
		if (!tag.IsConstructed)
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, "The encoded value uses a primitive encoding, which is invalid for '{0}' values.", UniversalTagNumber.Set));
		}
		int num;
		ReadOnlySpan<byte> readOnlySpan;
		if (contentsLength.HasValue)
		{
			num = 0;
			readOnlySpan = Slice(source, bytesRead, contentsLength.Value);
		}
		else
		{
			int length = SeekEndOfContents(source.Slice(bytesRead), ruleSet);
			readOnlySpan = Slice(source, bytesRead, length);
			num = 2;
		}
		if (!skipSortOrderValidation && (ruleSet == AsnEncodingRules.DER || ruleSet == AsnEncodingRules.CER))
		{
			ReadOnlySpan<byte> source2 = readOnlySpan;
			ReadOnlySpan<byte> y = default(ReadOnlySpan<byte>);
			while (!source2.IsEmpty)
			{
				ReadEncodedValue(source2, ruleSet, out var _, out var _, out var bytesConsumed2);
				ReadOnlySpan<byte> readOnlySpan2 = source2.Slice(0, bytesConsumed2);
				source2 = source2.Slice(bytesConsumed2);
				if (SetOfValueComparer.Compare(readOnlySpan2, y) < 0)
				{
					throw new InvalidOperationException("The encoded set is not sorted as required by the current encoding rules. The value may be valid under the BER encoding, or you can ignore the sort validation by specifying skipSortValidation=true.");
				}
				y = readOnlySpan2;
			}
		}
		contentOffset = bytesRead;
		contentLength = readOnlySpan.Length;
		bytesConsumed = bytesRead + readOnlySpan.Length + num;
	}
}

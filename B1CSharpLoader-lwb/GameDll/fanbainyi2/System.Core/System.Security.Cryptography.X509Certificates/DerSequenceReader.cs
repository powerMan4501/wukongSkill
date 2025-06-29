using System.Globalization;
using System.Numerics;
using System.Text;
using System.Threading;

namespace System.Security.Cryptography.X509Certificates;

internal class DerSequenceReader
{
	internal enum DerTag : byte
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30
	}

	internal const byte ContextSpecificTagFlag = 128;

	internal const byte ConstructedFlag = 32;

	internal const byte ContextSpecificConstructedTag0 = 160;

	internal const byte ContextSpecificConstructedTag1 = 161;

	internal const byte ContextSpecificConstructedTag2 = 162;

	internal const byte ContextSpecificConstructedTag3 = 163;

	internal const byte ConstructedSequence = 48;

	internal const byte TagClassMask = 192;

	internal const byte TagNumberMask = 31;

	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

	private readonly byte[] _data;

	private readonly int _end;

	private int _position;

	internal int ContentLength { get; private set; }

	internal bool HasData => _position < _end;

	private DerSequenceReader(bool startAtPayload, byte[] data, int offset, int length)
	{
		_data = data;
		_position = offset;
		_end = offset + length;
		ContentLength = length;
	}

	internal DerSequenceReader(byte[] data)
		: this(data, 0, data.Length)
	{
	}

	internal DerSequenceReader(byte[] data, int offset, int length)
		: this(DerTag.Sequence, data, offset, length)
	{
	}

	private DerSequenceReader(DerTag tagToEat, byte[] data, int offset, int length)
	{
		if (offset < 0 || length < 2 || length > data.Length - offset)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		_data = data;
		_end = offset + length;
		_position = offset;
		EatTag(tagToEat);
		int num = (ContentLength = EatLength());
		_end = _position + num;
	}

	internal static DerSequenceReader CreateForPayload(byte[] payload)
	{
		return new DerSequenceReader(startAtPayload: true, payload, 0, payload.Length);
	}

	internal byte PeekTag()
	{
		if (!HasData)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		byte b = _data[_position];
		if ((b & 0x1F) == 31)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		return b;
	}

	internal bool HasTag(DerTag expectedTag)
	{
		return HasTag((byte)expectedTag);
	}

	internal bool HasTag(byte expectedTag)
	{
		if (HasData)
		{
			return _data[_position] == expectedTag;
		}
		return false;
	}

	internal void SkipValue()
	{
		EatTag((DerTag)PeekTag());
		int num = EatLength();
		_position += num;
	}

	internal void ValidateAndSkipDerValue()
	{
		byte b = PeekTag();
		if ((b & 0xC0) == 0)
		{
			if (b == 0 || b == 15)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
			}
			bool flag = false;
			switch (b & 0x1F)
			{
			case 8:
			case 11:
			case 16:
			case 17:
			case 29:
				flag = true;
				break;
			}
			bool flag2 = (b & 0x20) == 32;
			if (flag != flag2)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
			}
		}
		EatTag((DerTag)b);
		int num = EatLength();
		if (num > 0 && (b & 0x20) == 32)
		{
			DerSequenceReader derSequenceReader = new DerSequenceReader(startAtPayload: true, _data, _position, _end - _position);
			while (derSequenceReader.HasData)
			{
				derSequenceReader.ValidateAndSkipDerValue();
			}
		}
		_position += num;
	}

	internal byte[] ReadNextEncodedValue()
	{
		PeekTag();
		int bytesConsumed;
		int num = ScanContentLength(_data, _position + 1, _end, out bytesConsumed);
		int num2 = 1 + bytesConsumed + num;
		byte[] array = new byte[num2];
		Buffer.BlockCopy(_data, _position, array, 0, num2);
		_position += num2;
		return array;
	}

	internal bool ReadBoolean()
	{
		EatTag(DerTag.Boolean);
		int num = EatLength();
		if (num != 1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		bool result = _data[_position] != 0;
		_position += num;
		return result;
	}

	internal int ReadInteger()
	{
		byte[] array = ReadIntegerBytes();
		Array.Reverse(array);
		BigInteger bigInteger = new BigInteger(array);
		return (int)bigInteger;
	}

	internal byte[] ReadIntegerBytes()
	{
		EatTag(DerTag.Integer);
		return ReadContentAsBytes();
	}

	internal byte[] ReadBitString()
	{
		EatTag(DerTag.BitString);
		int num = EatLength();
		if (num < 1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		byte b = _data[_position];
		if (b > 7)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		num--;
		_position++;
		byte[] array = new byte[num];
		Buffer.BlockCopy(_data, _position, array, 0, num);
		_position += num;
		return array;
	}

	internal byte[] ReadOctetString()
	{
		EatTag(DerTag.OctetString);
		return ReadContentAsBytes();
	}

	internal string ReadOidAsString()
	{
		EatTag(DerTag.ObjectIdentifier);
		int num = EatLength();
		if (num < 1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		StringBuilder stringBuilder = new StringBuilder(num * 4);
		byte b = _data[_position];
		byte value = (byte)(b / 40);
		byte value2 = (byte)(b % 40);
		stringBuilder.Append(value);
		stringBuilder.Append('.');
		stringBuilder.Append(value2);
		bool flag = true;
		BigInteger bigInteger = new BigInteger(0);
		for (int i = 1; i < num; i++)
		{
			byte b2 = _data[_position + i];
			byte b3 = (byte)(b2 & 0x7F);
			if (flag)
			{
				stringBuilder.Append('.');
				flag = false;
			}
			bigInteger <<= 7;
			bigInteger += (BigInteger)b3;
			if (b2 == b3)
			{
				stringBuilder.Append(bigInteger);
				bigInteger = 0;
				flag = true;
			}
		}
		_position += num;
		return stringBuilder.ToString();
	}

	internal Oid ReadOid()
	{
		return new Oid(ReadOidAsString());
	}

	internal string ReadUtf8String()
	{
		EatTag(DerTag.UTF8String);
		int num = EatLength();
		string value = Encoding.UTF8.GetString(_data, _position, num);
		_position += num;
		return TrimTrailingNulls(value);
	}

	private DerSequenceReader ReadCollectionWithTag(DerTag expected)
	{
		CheckTag(expected, _data, _position);
		int bytesConsumed;
		int num = ScanContentLength(_data, _position + 1, _end, out bytesConsumed);
		int num2 = 1 + bytesConsumed + num;
		DerSequenceReader result = new DerSequenceReader(expected, _data, _position, num2);
		_position += num2;
		return result;
	}

	internal DerSequenceReader ReadSequence()
	{
		return ReadCollectionWithTag(DerTag.Sequence);
	}

	internal DerSequenceReader ReadSet()
	{
		return ReadCollectionWithTag(DerTag.Set);
	}

	internal string ReadPrintableString()
	{
		EatTag(DerTag.PrintableString);
		int num = EatLength();
		string value = Encoding.ASCII.GetString(_data, _position, num);
		_position += num;
		return TrimTrailingNulls(value);
	}

	internal string ReadIA5String()
	{
		EatTag(DerTag.IA5String);
		int num = EatLength();
		string value = Encoding.ASCII.GetString(_data, _position, num);
		_position += num;
		return TrimTrailingNulls(value);
	}

	internal DateTime ReadX509Date()
	{
		return (DerTag)PeekTag() switch
		{
			DerTag.UTCTime => ReadUtcTime(), 
			DerTag.GeneralizedTime => ReadGeneralizedTime(), 
			_ => throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding")), 
		};
	}

	internal DateTime ReadUtcTime()
	{
		return ReadTime(DerTag.UTCTime, "yyMMddHHmmss'Z'");
	}

	internal DateTime ReadGeneralizedTime()
	{
		return ReadTime(DerTag.GeneralizedTime, "yyyyMMddHHmmss'Z'");
	}

	internal string ReadBMPString()
	{
		EatTag(DerTag.BMPString);
		int num = EatLength();
		string value = Encoding.BigEndianUnicode.GetString(_data, _position, num);
		_position += num;
		return TrimTrailingNulls(value);
	}

	private static string TrimTrailingNulls(string value)
	{
		if (value != null && value.Length > 0)
		{
			int num = value.Length;
			while (num > 0 && value[num - 1] == '\0')
			{
				num--;
			}
			if (num != value.Length)
			{
				return value.Substring(0, num);
			}
		}
		return value;
	}

	private DateTime ReadTime(DerTag timeTag, string formatString)
	{
		EatTag(timeTag);
		int num = EatLength();
		string s = Encoding.ASCII.GetString(_data, _position, num);
		_position += num;
		DateTimeFormatInfo provider = LazyInitializer.EnsureInitialized(ref s_validityDateTimeFormatInfo, delegate
		{
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)CultureInfo.InvariantCulture.DateTimeFormat.Clone();
			dateTimeFormatInfo.Calendar.TwoDigitYearMax = 2049;
			return dateTimeFormatInfo;
		});
		if (!DateTime.TryParseExact(s, formatString, provider, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var result))
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		return result;
	}

	private byte[] ReadContentAsBytes()
	{
		int num = EatLength();
		byte[] array = new byte[num];
		Buffer.BlockCopy(_data, _position, array, 0, num);
		_position += num;
		return array;
	}

	private void EatTag(DerTag expected)
	{
		if (!HasData)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		CheckTag(expected, _data, _position);
		_position++;
	}

	private static void CheckTag(DerTag expected, byte[] data, int position)
	{
		if (position >= data.Length)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		byte b = data[position];
		byte b2 = (byte)(b & 0x1F);
		if (b2 == 31)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		if ((b & 0x80) == 0)
		{
			byte b3 = (byte)(expected & (DerTag)31);
			if (b3 != b2)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
			}
		}
	}

	private int EatLength()
	{
		int bytesConsumed;
		int result = ScanContentLength(_data, _position, _end, out bytesConsumed);
		_position += bytesConsumed;
		return result;
	}

	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed)
	{
		if (offset >= end)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		byte b = data[offset];
		if (b < 128)
		{
			bytesConsumed = 1;
			if (b > end - offset - bytesConsumed)
			{
				throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
			}
			return b;
		}
		int num = b & 0x7F;
		if (num > 4)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		bytesConsumed = 1 + num;
		if (bytesConsumed > end - offset)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		if (bytesConsumed == 1)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		int num2 = offset + bytesConsumed;
		int num3 = 0;
		for (int i = offset + 1; i < num2; i++)
		{
			num3 <<= 8;
			num3 |= data[i];
		}
		if (num3 < 0)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		if (num3 > end - offset - bytesConsumed)
		{
			throw new CryptographicException(System.SR.GetString("Cryptography_Der_Invalid_Encoding"));
		}
		return num3;
	}
}

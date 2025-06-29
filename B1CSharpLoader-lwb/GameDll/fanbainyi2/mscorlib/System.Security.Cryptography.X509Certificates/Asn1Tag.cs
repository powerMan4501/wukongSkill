namespace System.Security.Cryptography.X509Certificates;

internal struct Asn1Tag : IEquatable<Asn1Tag>
{
	internal static readonly Asn1Tag EndOfContents = new Asn1Tag((byte)0, 0);

	public static readonly Asn1Tag Integer = new Asn1Tag((byte)0, 2);

	public static readonly Asn1Tag PrimitiveBitString = new Asn1Tag((byte)0, 3);

	public static readonly Asn1Tag ConstructedBitString = new Asn1Tag(32, 3);

	public static readonly Asn1Tag PrimitiveOctetString = new Asn1Tag((byte)0, 4);

	public static readonly Asn1Tag ConstructedOctetString = new Asn1Tag(32, 4);

	public static readonly Asn1Tag Null = new Asn1Tag((byte)0, 5);

	public static readonly Asn1Tag ObjectIdentifier = new Asn1Tag((byte)0, 6);

	public static readonly Asn1Tag Sequence = new Asn1Tag(32, 16);

	public static readonly Asn1Tag SetOf = new Asn1Tag(32, 17);

	private const byte ClassMask = 192;

	private const byte ConstructedMask = 32;

	private const byte ControlMask = 224;

	private const byte TagNumberMask = 31;

	private readonly byte _controlFlags;

	private int _tagValue;

	public TagClass TagClass => (TagClass)(_controlFlags & 0xC0);

	public bool IsConstructed => (_controlFlags & 0x20) != 0;

	public int TagValue => _tagValue;

	private Asn1Tag(byte controlFlags, int tagValue)
	{
		_controlFlags = (byte)(controlFlags & 0xE0);
		_tagValue = tagValue;
	}

	public Asn1Tag(UniversalTagNumber universalTagNumber, bool isConstructed)
		: this((byte)(isConstructed ? 32 : 0), (int)universalTagNumber)
	{
		if (universalTagNumber < UniversalTagNumber.EndOfContents || universalTagNumber > UniversalTagNumber.RelativeObjectIdentifierIRI || universalTagNumber == (UniversalTagNumber)15)
		{
			throw new ArgumentOutOfRangeException("universalTagNumber");
		}
	}

	public Asn1Tag(TagClass tagClass, int tagValue, bool isConstructed)
		: this((byte)((byte)tagClass | (isConstructed ? 32 : 0)), tagValue)
	{
		switch (tagClass)
		{
		default:
			throw new ArgumentOutOfRangeException("tagClass");
		case TagClass.Universal:
		case TagClass.Application:
		case TagClass.ContextSpecific:
		case TagClass.Private:
			if (tagValue < 0)
			{
				throw new ArgumentOutOfRangeException("tagValue");
			}
			break;
		}
	}

	public Asn1Tag(TagClass tagClass, int tagValue)
		: this(tagClass, tagValue, isConstructed: false)
	{
	}

	public Asn1Tag AsConstructed()
	{
		return new Asn1Tag((byte)(_controlFlags | 0x20), TagValue);
	}

	public static bool TryDecode(ReadOnlySpan<byte> source, out Asn1Tag tag, out int bytesConsumed)
	{
		tag = default(Asn1Tag);
		bytesConsumed = 0;
		if (source.IsEmpty)
		{
			return false;
		}
		byte b = source[bytesConsumed];
		bytesConsumed++;
		uint num = (uint)(b & 0x1F);
		if (num == 31)
		{
			num = 0u;
			byte b2;
			do
			{
				if (source.Length <= bytesConsumed)
				{
					bytesConsumed = 0;
					return false;
				}
				b2 = source[bytesConsumed];
				byte b3 = (byte)(b2 & 0x7F);
				bytesConsumed++;
				if (num >= 33554432)
				{
					bytesConsumed = 0;
					return false;
				}
				num <<= 7;
				num |= b3;
				if (num == 0)
				{
					bytesConsumed = 0;
					return false;
				}
			}
			while ((b2 & 0x80) == 128);
			if (num <= 30)
			{
				bytesConsumed = 0;
				return false;
			}
			if (num > int.MaxValue)
			{
				bytesConsumed = 0;
				return false;
			}
		}
		tag = new Asn1Tag(b, (int)num);
		return true;
	}

	public static Asn1Tag Decode(ReadOnlySpan<byte> source, out int bytesConsumed)
	{
		if (TryDecode(source, out var tag, out bytesConsumed))
		{
			return tag;
		}
		throw new InvalidOperationException("The provided data does not represent a valid tag.");
	}

	public bool Equals(Asn1Tag other)
	{
		if (_controlFlags == other._controlFlags)
		{
			return TagValue == other.TagValue;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj is Asn1Tag)
		{
			return Equals((Asn1Tag)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (_controlFlags << 24) ^ TagValue;
	}

	public static bool operator ==(Asn1Tag left, Asn1Tag right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(Asn1Tag left, Asn1Tag right)
	{
		return !left.Equals(right);
	}

	public bool HasSameClassAndValue(Asn1Tag other)
	{
		if (TagValue == other.TagValue)
		{
			return TagClass == other.TagClass;
		}
		return false;
	}
}

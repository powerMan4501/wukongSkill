using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char>
{
	internal char m_value;

	[__DynamicallyInvokable]
	public const char MaxValue = '\uffff';

	[__DynamicallyInvokable]
	public const char MinValue = '\0';

	private static readonly byte[] categoryForLatin1 = new byte[256]
	{
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		14, 14, 11, 24, 24, 24, 26, 24, 24, 24,
		20, 21, 24, 25, 24, 19, 24, 24, 8, 8,
		8, 8, 8, 8, 8, 8, 8, 8, 24, 24,
		25, 25, 25, 24, 24, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 20, 24, 21, 27, 18, 27, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 20, 25, 21, 25, 14, 14, 14,
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		14, 14, 14, 14, 14, 14, 14, 14, 14, 14,
		11, 24, 26, 26, 26, 26, 28, 28, 27, 28,
		1, 22, 25, 19, 28, 27, 28, 25, 10, 10,
		27, 1, 28, 24, 27, 10, 1, 23, 10, 10,
		10, 24, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 25, 0, 0, 0, 0,
		0, 0, 0, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
		1, 1, 1, 1, 1, 1, 1, 25, 1, 1,
		1, 1, 1, 1, 1, 1
	};

	internal const int UNICODE_PLANE00_END = 65535;

	internal const int UNICODE_PLANE01_START = 65536;

	internal const int UNICODE_PLANE16_END = 1114111;

	internal const int HIGH_SURROGATE_START = 55296;

	internal const int LOW_SURROGATE_END = 57343;

	private static bool IsLatin1(char ch)
	{
		return ch <= 'ÿ';
	}

	private static bool IsAscii(char ch)
	{
		return ch <= '\u007f';
	}

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch)
	{
		return (UnicodeCategory)categoryForLatin1[(uint)ch];
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return (int)(this | ((uint)this << 16));
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is char))
		{
			return false;
		}
		return this == (char)obj;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public bool Equals(char obj)
	{
		return this == obj;
	}

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (!(value is char))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeChar"));
		}
		return this - (char)value;
	}

	[__DynamicallyInvokable]
	public int CompareTo(char value)
	{
		return this - value;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return ToString(this);
	}

	public string ToString(IFormatProvider provider)
	{
		return ToString(this);
	}

	[__DynamicallyInvokable]
	public static string ToString(char c)
	{
		return new string(c, 1);
	}

	[__DynamicallyInvokable]
	public static char Parse(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (s.Length != 1)
		{
			throw new FormatException(Environment.GetResourceString("Format_NeedSingleChar"));
		}
		return s[0];
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out char result)
	{
		result = '\0';
		if (s == null)
		{
			return false;
		}
		if (s.Length != 1)
		{
			return false;
		}
		result = s[0];
		return true;
	}

	[__DynamicallyInvokable]
	public static bool IsDigit(char c)
	{
		if (IsLatin1(c))
		{
			if (c >= '0')
			{
				return c <= '9';
			}
			return false;
		}
		return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;
	}

	internal static bool CheckLetter(UnicodeCategory uc)
	{
		if ((uint)uc <= 4u)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsLetter(char c)
	{
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				c = (char)(c | 0x20);
				if (c >= 'a')
				{
					return c <= 'z';
				}
				return false;
			}
			return CheckLetter(GetLatin1UnicodeCategory(c));
		}
		return CheckLetter(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	private static bool IsWhiteSpaceLatin1(char c)
	{
		switch (c)
		{
		default:
			if (c != '\u00a0' && c != '\u0085')
			{
				return false;
			}
			goto case '\t';
		case '\t':
		case '\n':
		case '\v':
		case '\f':
		case '\r':
		case ' ':
			return true;
		}
	}

	[__DynamicallyInvokable]
	public static bool IsWhiteSpace(char c)
	{
		if (IsLatin1(c))
		{
			return IsWhiteSpaceLatin1(c);
		}
		return CharUnicodeInfo.IsWhiteSpace(c);
	}

	[__DynamicallyInvokable]
	public static bool IsUpper(char c)
	{
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= 'A')
				{
					return c <= 'Z';
				}
				return false;
			}
			return GetLatin1UnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}
		return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
	}

	[__DynamicallyInvokable]
	public static bool IsLower(char c)
	{
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= 'a')
				{
					return c <= 'z';
				}
				return false;
			}
			return GetLatin1UnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}
		return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
	}

	internal static bool CheckPunctuation(UnicodeCategory uc)
	{
		if ((uint)(uc - 18) <= 6u)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsPunctuation(char c)
	{
		if (IsLatin1(c))
		{
			return CheckPunctuation(GetLatin1UnicodeCategory(c));
		}
		return CheckPunctuation(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	internal static bool CheckLetterOrDigit(UnicodeCategory uc)
	{
		if ((uint)uc <= 4u || uc == UnicodeCategory.DecimalDigitNumber)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsLetterOrDigit(char c)
	{
		if (IsLatin1(c))
		{
			return CheckLetterOrDigit(GetLatin1UnicodeCategory(c));
		}
		return CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	[__DynamicallyInvokable]
	public static char ToUpper(char c, CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return culture.TextInfo.ToUpper(c);
	}

	[__DynamicallyInvokable]
	public static char ToUpper(char c)
	{
		return ToUpper(c, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static char ToUpperInvariant(char c)
	{
		return ToUpper(c, CultureInfo.InvariantCulture);
	}

	[__DynamicallyInvokable]
	public static char ToLower(char c, CultureInfo culture)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return culture.TextInfo.ToLower(c);
	}

	[__DynamicallyInvokable]
	public static char ToLower(char c)
	{
		return ToLower(c, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static char ToLowerInvariant(char c)
	{
		return ToLower(c, CultureInfo.InvariantCulture);
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Char;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Boolean"));
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return this;
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return Convert.ToSByte(this);
	}

	[__DynamicallyInvokable]
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Convert.ToByte(this);
	}

	[__DynamicallyInvokable]
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Convert.ToInt16(this);
	}

	[__DynamicallyInvokable]
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return Convert.ToUInt16(this);
	}

	[__DynamicallyInvokable]
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Convert.ToInt32(this);
	}

	[__DynamicallyInvokable]
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return Convert.ToUInt32(this);
	}

	[__DynamicallyInvokable]
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Convert.ToInt64(this);
	}

	[__DynamicallyInvokable]
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return Convert.ToUInt64(this);
	}

	[__DynamicallyInvokable]
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Single"));
	}

	[__DynamicallyInvokable]
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Double"));
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "Decimal"));
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Char", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}

	[__DynamicallyInvokable]
	public static bool IsControl(char c)
	{
		if (IsLatin1(c))
		{
			return GetLatin1UnicodeCategory(c) == UnicodeCategory.Control;
		}
		return CharUnicodeInfo.GetUnicodeCategory(c) == UnicodeCategory.Control;
	}

	[__DynamicallyInvokable]
	public static bool IsControl(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char ch = s[index];
		if (IsLatin1(ch))
		{
			return GetLatin1UnicodeCategory(ch) == UnicodeCategory.Control;
		}
		return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.Control;
	}

	[__DynamicallyInvokable]
	public static bool IsDigit(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			if (c >= '0')
			{
				return c <= '9';
			}
			return false;
		}
		return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.DecimalDigitNumber;
	}

	[__DynamicallyInvokable]
	public static bool IsLetter(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				c = (char)(c | 0x20);
				if (c >= 'a')
				{
					return c <= 'z';
				}
				return false;
			}
			return CheckLetter(GetLatin1UnicodeCategory(c));
		}
		return CheckLetter(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	[__DynamicallyInvokable]
	public static bool IsLetterOrDigit(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char ch = s[index];
		if (IsLatin1(ch))
		{
			return CheckLetterOrDigit(GetLatin1UnicodeCategory(ch));
		}
		return CheckLetterOrDigit(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	[__DynamicallyInvokable]
	public static bool IsLower(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= 'a')
				{
					return c <= 'z';
				}
				return false;
			}
			return GetLatin1UnicodeCategory(c) == UnicodeCategory.LowercaseLetter;
		}
		return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.LowercaseLetter;
	}

	internal static bool CheckNumber(UnicodeCategory uc)
	{
		if ((uint)(uc - 8) <= 2u)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsNumber(char c)
	{
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= '0')
				{
					return c <= '9';
				}
				return false;
			}
			return CheckNumber(GetLatin1UnicodeCategory(c));
		}
		return CheckNumber(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	[__DynamicallyInvokable]
	public static bool IsNumber(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= '0')
				{
					return c <= '9';
				}
				return false;
			}
			return CheckNumber(GetLatin1UnicodeCategory(c));
		}
		return CheckNumber(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	[__DynamicallyInvokable]
	public static bool IsPunctuation(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char ch = s[index];
		if (IsLatin1(ch))
		{
			return CheckPunctuation(GetLatin1UnicodeCategory(ch));
		}
		return CheckPunctuation(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	internal static bool CheckSeparator(UnicodeCategory uc)
	{
		if ((uint)(uc - 11) <= 2u)
		{
			return true;
		}
		return false;
	}

	private static bool IsSeparatorLatin1(char c)
	{
		if (c != ' ')
		{
			return c == '\u00a0';
		}
		return true;
	}

	[__DynamicallyInvokable]
	public static bool IsSeparator(char c)
	{
		if (IsLatin1(c))
		{
			return IsSeparatorLatin1(c);
		}
		return CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	[__DynamicallyInvokable]
	public static bool IsSeparator(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			return IsSeparatorLatin1(c);
		}
		return CheckSeparator(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	[__DynamicallyInvokable]
	public static bool IsSurrogate(char c)
	{
		if (c >= '\ud800')
		{
			return c <= '\udfff';
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsSurrogate(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return IsSurrogate(s[index]);
	}

	internal static bool CheckSymbol(UnicodeCategory uc)
	{
		if ((uint)(uc - 25) <= 3u)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsSymbol(char c)
	{
		if (IsLatin1(c))
		{
			return CheckSymbol(GetLatin1UnicodeCategory(c));
		}
		return CheckSymbol(CharUnicodeInfo.GetUnicodeCategory(c));
	}

	[__DynamicallyInvokable]
	public static bool IsSymbol(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (IsLatin1(s[index]))
		{
			return CheckSymbol(GetLatin1UnicodeCategory(s[index]));
		}
		return CheckSymbol(CharUnicodeInfo.GetUnicodeCategory(s, index));
	}

	[__DynamicallyInvokable]
	public static bool IsUpper(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		char c = s[index];
		if (IsLatin1(c))
		{
			if (IsAscii(c))
			{
				if (c >= 'A')
				{
					return c <= 'Z';
				}
				return false;
			}
			return GetLatin1UnicodeCategory(c) == UnicodeCategory.UppercaseLetter;
		}
		return CharUnicodeInfo.GetUnicodeCategory(s, index) == UnicodeCategory.UppercaseLetter;
	}

	[__DynamicallyInvokable]
	public static bool IsWhiteSpace(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (IsLatin1(s[index]))
		{
			return IsWhiteSpaceLatin1(s[index]);
		}
		return CharUnicodeInfo.IsWhiteSpace(s, index);
	}

	public static UnicodeCategory GetUnicodeCategory(char c)
	{
		if (IsLatin1(c))
		{
			return GetLatin1UnicodeCategory(c);
		}
		return CharUnicodeInfo.InternalGetUnicodeCategory(c);
	}

	public static UnicodeCategory GetUnicodeCategory(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (IsLatin1(s[index]))
		{
			return GetLatin1UnicodeCategory(s[index]);
		}
		return CharUnicodeInfo.InternalGetUnicodeCategory(s, index);
	}

	[__DynamicallyInvokable]
	public static double GetNumericValue(char c)
	{
		return CharUnicodeInfo.GetNumericValue(c);
	}

	[__DynamicallyInvokable]
	public static double GetNumericValue(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if ((uint)index >= (uint)s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return CharUnicodeInfo.GetNumericValue(s, index);
	}

	[__DynamicallyInvokable]
	public static bool IsHighSurrogate(char c)
	{
		if (c >= '\ud800')
		{
			return c <= '\udbff';
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsHighSurrogate(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return IsHighSurrogate(s[index]);
	}

	[__DynamicallyInvokable]
	public static bool IsLowSurrogate(char c)
	{
		if (c >= '\udc00')
		{
			return c <= '\udfff';
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsLowSurrogate(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return IsLowSurrogate(s[index]);
	}

	[__DynamicallyInvokable]
	public static bool IsSurrogatePair(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (index + 1 < s.Length)
		{
			return IsSurrogatePair(s[index], s[index + 1]);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
	{
		if (highSurrogate >= '\ud800' && highSurrogate <= '\udbff')
		{
			if (lowSurrogate >= '\udc00')
			{
				return lowSurrogate <= '\udfff';
			}
			return false;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static string ConvertFromUtf32(int utf32)
	{
		if (utf32 < 0 || utf32 > 1114111 || (utf32 >= 55296 && utf32 <= 57343))
		{
			throw new ArgumentOutOfRangeException("utf32", Environment.GetResourceString("ArgumentOutOfRange_InvalidUTF32"));
		}
		if (utf32 < 65536)
		{
			return ToString((char)utf32);
		}
		utf32 -= 65536;
		return new string(new char[2]
		{
			(char)(utf32 / 1024 + 55296),
			(char)(utf32 % 1024 + 56320)
		});
	}

	[__DynamicallyInvokable]
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
	{
		if (!IsHighSurrogate(highSurrogate))
		{
			throw new ArgumentOutOfRangeException("highSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidHighSurrogate"));
		}
		if (!IsLowSurrogate(lowSurrogate))
		{
			throw new ArgumentOutOfRangeException("lowSurrogate", Environment.GetResourceString("ArgumentOutOfRange_InvalidLowSurrogate"));
		}
		return (highSurrogate - 55296) * 1024 + (lowSurrogate - 56320) + 65536;
	}

	[__DynamicallyInvokable]
	public static int ConvertToUtf32(string s, int index)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (index < 0 || index >= s.Length)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		int num = s[index] - 55296;
		if (num >= 0 && num <= 2047)
		{
			if (num <= 1023)
			{
				if (index < s.Length - 1)
				{
					int num2 = s[index + 1] - 56320;
					if (num2 >= 0 && num2 <= 1023)
					{
						return num * 1024 + num2 + 65536;
					}
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHighSurrogate", index), "s");
				}
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidHighSurrogate", index), "s");
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidLowSurrogate", index), "s");
		}
		return s[index];
	}
}

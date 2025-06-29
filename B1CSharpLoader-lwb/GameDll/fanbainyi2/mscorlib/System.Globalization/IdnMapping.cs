using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.Globalization;

public sealed class IdnMapping
{
	private const int M_labelLimit = 63;

	private const int M_defaultNameLimit = 255;

	private const string M_strAcePrefix = "xn--";

	private static char[] M_Dots = new char[4] { '.', '。', '．', '｡' };

	private bool m_bAllowUnassigned;

	private bool m_bUseStd3AsciiRules;

	private const int punycodeBase = 36;

	private const int tmin = 1;

	private const int tmax = 26;

	private const int skew = 38;

	private const int damp = 700;

	private const int initial_bias = 72;

	private const int initial_n = 128;

	private const char delimiter = '-';

	private const int maxint = 134217727;

	private const int IDN_ALLOW_UNASSIGNED = 1;

	private const int IDN_USE_STD3_ASCII_RULES = 2;

	private const int ERROR_INVALID_NAME = 123;

	public bool AllowUnassigned
	{
		get
		{
			return m_bAllowUnassigned;
		}
		set
		{
			m_bAllowUnassigned = value;
		}
	}

	public bool UseStd3AsciiRules
	{
		get
		{
			return m_bUseStd3AsciiRules;
		}
		set
		{
			m_bUseStd3AsciiRules = value;
		}
	}

	public string GetAscii(string unicode)
	{
		return GetAscii(unicode, 0);
	}

	public string GetAscii(string unicode, int index)
	{
		if (unicode == null)
		{
			throw new ArgumentNullException("unicode");
		}
		return GetAscii(unicode, index, unicode.Length - index);
	}

	public string GetAscii(string unicode, int index, int count)
	{
		if (unicode == null)
		{
			throw new ArgumentNullException("unicode");
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (index > unicode.Length)
		{
			throw new ArgumentOutOfRangeException("byteIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (index > unicode.Length - count)
		{
			throw new ArgumentOutOfRangeException("unicode", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		unicode = unicode.Substring(index, count);
		if (Environment.IsWindows8OrAbove)
		{
			return GetAsciiUsingOS(unicode);
		}
		if (ValidateStd3AndAscii(unicode, UseStd3AsciiRules, bCheckAscii: true))
		{
			return unicode;
		}
		if (unicode[unicode.Length - 1] <= '\u001f')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequence", unicode.Length - 1), "unicode");
		}
		bool flag = unicode.Length > 0 && IsDot(unicode[unicode.Length - 1]);
		unicode = unicode.Normalize(m_bAllowUnassigned ? ((NormalizationForm)13) : ((NormalizationForm)269));
		if (!flag && unicode.Length > 0 && IsDot(unicode[unicode.Length - 1]))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
		}
		if (UseStd3AsciiRules)
		{
			ValidateStd3AndAscii(unicode, bUseStd3: true, bCheckAscii: false);
		}
		return punycode_encode(unicode);
	}

	[SecuritySafeCritical]
	private string GetAsciiUsingOS(string unicode)
	{
		if (unicode.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
		}
		if (unicode[unicode.Length - 1] == '\0')
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequence", unicode.Length - 1), "unicode");
		}
		uint dwFlags = (uint)((AllowUnassigned ? 1 : 0) | (UseStd3AsciiRules ? 2 : 0));
		int num = IdnToAscii(dwFlags, unicode, unicode.Length, null, 0);
		if (num == 0)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 123)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnIllegalName"), "unicode");
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequenceNoIndex"), "unicode");
		}
		char[] array = new char[num];
		num = IdnToAscii(dwFlags, unicode, unicode.Length, array, num);
		if (num == 0)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 123)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnIllegalName"), "unicode");
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequenceNoIndex"), "unicode");
		}
		return new string(array, 0, num);
	}

	public string GetUnicode(string ascii)
	{
		return GetUnicode(ascii, 0);
	}

	public string GetUnicode(string ascii, int index)
	{
		if (ascii == null)
		{
			throw new ArgumentNullException("ascii");
		}
		return GetUnicode(ascii, index, ascii.Length - index);
	}

	public string GetUnicode(string ascii, int index, int count)
	{
		if (ascii == null)
		{
			throw new ArgumentNullException("ascii");
		}
		if (index < 0 || count < 0)
		{
			throw new ArgumentOutOfRangeException((index < 0) ? "index" : "count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (index > ascii.Length)
		{
			throw new ArgumentOutOfRangeException("byteIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (index > ascii.Length - count)
		{
			throw new ArgumentOutOfRangeException("ascii", Environment.GetResourceString("ArgumentOutOfRange_IndexCountBuffer"));
		}
		if (count > 0 && ascii[index + count - 1] == '\0')
		{
			throw new ArgumentException("ascii", Environment.GetResourceString("Argument_IdnBadPunycode"));
		}
		ascii = ascii.Substring(index, count);
		if (Environment.IsWindows8OrAbove)
		{
			return GetUnicodeUsingOS(ascii);
		}
		string text = punycode_decode(ascii);
		if (!ascii.Equals(GetAscii(text), StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnIllegalName"), "ascii");
		}
		return text;
	}

	[SecuritySafeCritical]
	private string GetUnicodeUsingOS(string ascii)
	{
		uint dwFlags = (uint)((AllowUnassigned ? 1 : 0) | (UseStd3AsciiRules ? 2 : 0));
		int num = IdnToUnicode(dwFlags, ascii, ascii.Length, null, 0);
		if (num == 0)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 123)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnIllegalName"), "ascii");
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
		}
		char[] array = new char[num];
		num = IdnToUnicode(dwFlags, ascii, ascii.Length, array, num);
		if (num == 0)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error == 123)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnIllegalName"), "ascii");
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
		}
		return new string(array, 0, num);
	}

	public override bool Equals(object obj)
	{
		if (obj is IdnMapping idnMapping)
		{
			if (m_bAllowUnassigned == idnMapping.m_bAllowUnassigned)
			{
				return m_bUseStd3AsciiRules == idnMapping.m_bUseStd3AsciiRules;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (m_bAllowUnassigned ? 100 : 200) + (m_bUseStd3AsciiRules ? 1000 : 2000);
	}

	private static bool IsSupplementary(int cTest)
	{
		return cTest >= 65536;
	}

	private static bool IsDot(char c)
	{
		if (c != '.' && c != '。' && c != '．')
		{
			return c == '｡';
		}
		return true;
	}

	private static bool ValidateStd3AndAscii(string unicode, bool bUseStd3, bool bCheckAscii)
	{
		if (unicode.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
		}
		int num = -1;
		for (int i = 0; i < unicode.Length; i++)
		{
			if (unicode[i] <= '\u001f')
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequence", i), "unicode");
			}
			if (bCheckAscii && unicode[i] >= '\u007f')
			{
				return false;
			}
			if (IsDot(unicode[i]))
			{
				if (i == num + 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
				}
				if (i - num > 64)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "Unicode");
				}
				if (bUseStd3 && i > 0)
				{
					ValidateStd3(unicode[i - 1], bNextToDot: true);
				}
				num = i;
			}
			else if (bUseStd3)
			{
				ValidateStd3(unicode[i], i == num + 1);
			}
		}
		if (num == -1 && unicode.Length > 63)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
		}
		if (unicode.Length > 255 - ((!IsDot(unicode[unicode.Length - 1])) ? 1 : 0))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadNameSize", 255 - ((!IsDot(unicode[unicode.Length - 1])) ? 1 : 0)), "unicode");
		}
		if (bUseStd3 && !IsDot(unicode[unicode.Length - 1]))
		{
			ValidateStd3(unicode[unicode.Length - 1], bNextToDot: true);
		}
		return true;
	}

	private static void ValidateStd3(char c, bool bNextToDot)
	{
		if (c > ',')
		{
			switch (c)
			{
			default:
				if ((c < '[' || c > '`') && (c < '{' || c > '\u007f') && !(c == '-' && bNextToDot))
				{
					return;
				}
				break;
			case '/':
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				break;
			}
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadStd3", c), "Unicode");
	}

	private static bool HasUpperCaseFlag(char punychar)
	{
		if (punychar >= 'A')
		{
			return punychar <= 'Z';
		}
		return false;
	}

	private static bool basic(uint cp)
	{
		return cp < 128;
	}

	private static int decode_digit(char cp)
	{
		if (cp >= '0' && cp <= '9')
		{
			return cp - 48 + 26;
		}
		if (cp >= 'a' && cp <= 'z')
		{
			return cp - 97;
		}
		if (cp >= 'A' && cp <= 'Z')
		{
			return cp - 65;
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
	}

	private static char encode_digit(int d)
	{
		if (d > 25)
		{
			return (char)(d - 26 + 48);
		}
		return (char)(d + 97);
	}

	private static char encode_basic(char bcp)
	{
		if (HasUpperCaseFlag(bcp))
		{
			bcp = (char)(bcp + 32);
		}
		return bcp;
	}

	private static int adapt(int delta, int numpoints, bool firsttime)
	{
		delta = (firsttime ? (delta / 700) : (delta / 2));
		delta += delta / numpoints;
		uint num = 0u;
		while (delta > 455)
		{
			delta /= 35;
			num += 36;
		}
		return (int)(num + 36 * delta / (delta + 38));
	}

	private static string punycode_encode(string unicode)
	{
		if (unicode.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
		}
		StringBuilder stringBuilder = new StringBuilder(unicode.Length);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (num < unicode.Length)
		{
			num = unicode.IndexOfAny(M_Dots, num2);
			if (num < 0)
			{
				num = unicode.Length;
			}
			if (num == num2)
			{
				if (num == unicode.Length)
				{
					break;
				}
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
			}
			stringBuilder.Append("xn--");
			bool flag = false;
			BidiCategory bidiCategory = CharUnicodeInfo.GetBidiCategory(unicode, num2);
			if (bidiCategory == BidiCategory.RightToLeft || bidiCategory == BidiCategory.RightToLeftArabic)
			{
				flag = true;
				int num4 = num - 1;
				if (char.IsLowSurrogate(unicode, num4))
				{
					num4--;
				}
				bidiCategory = CharUnicodeInfo.GetBidiCategory(unicode, num4);
				if (bidiCategory != BidiCategory.RightToLeft && bidiCategory != BidiCategory.RightToLeftArabic)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadBidi"), "unicode");
				}
			}
			int num5 = 0;
			for (int i = num2; i < num; i++)
			{
				BidiCategory bidiCategory2 = CharUnicodeInfo.GetBidiCategory(unicode, i);
				if (flag && bidiCategory2 == BidiCategory.LeftToRight)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadBidi"), "unicode");
				}
				if (!flag && (bidiCategory2 == BidiCategory.RightToLeft || bidiCategory2 == BidiCategory.RightToLeftArabic))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadBidi"), "unicode");
				}
				if (basic(unicode[i]))
				{
					stringBuilder.Append(encode_basic(unicode[i]));
					num5++;
				}
				else if (char.IsSurrogatePair(unicode, i))
				{
					i++;
				}
			}
			int num6 = num5;
			if (num6 == num - num2)
			{
				stringBuilder.Remove(num3, "xn--".Length);
			}
			else
			{
				if (unicode.Length - num2 >= "xn--".Length && unicode.Substring(num2, "xn--".Length).Equals("xn--", StringComparison.OrdinalIgnoreCase))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "unicode");
				}
				int num7 = 0;
				if (num6 > 0)
				{
					stringBuilder.Append('-');
				}
				int num8 = 128;
				int num9 = 0;
				int num10 = 72;
				while (num5 < num - num2)
				{
					int num11 = 0;
					int num12 = 134217727;
					for (int j = num2; j < num; j += ((!IsSupplementary(num11)) ? 1 : 2))
					{
						num11 = char.ConvertToUtf32(unicode, j);
						if (num11 >= num8 && num11 < num12)
						{
							num12 = num11;
						}
					}
					num9 += (num12 - num8) * (num5 - num7 + 1);
					num8 = num12;
					for (int j = num2; j < num; j += ((!IsSupplementary(num11)) ? 1 : 2))
					{
						num11 = char.ConvertToUtf32(unicode, j);
						if (num11 < num8)
						{
							num9++;
						}
						if (num11 != num8)
						{
							continue;
						}
						int num13 = num9;
						int num14 = 36;
						while (true)
						{
							int num15 = ((num14 <= num10) ? 1 : ((num14 >= num10 + 26) ? 26 : (num14 - num10)));
							if (num13 < num15)
							{
								break;
							}
							stringBuilder.Append(encode_digit(num15 + (num13 - num15) % (36 - num15)));
							num13 = (num13 - num15) / (36 - num15);
							num14 += 36;
						}
						stringBuilder.Append(encode_digit(num13));
						num10 = adapt(num9, num5 - num7 + 1, num5 == num6);
						num9 = 0;
						num5++;
						if (IsSupplementary(num12))
						{
							num5++;
							num7++;
						}
					}
					num9++;
					num8++;
				}
			}
			if (stringBuilder.Length - num3 > 63)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "unicode");
			}
			if (num != unicode.Length)
			{
				stringBuilder.Append('.');
			}
			num2 = num + 1;
			num3 = stringBuilder.Length;
		}
		if (stringBuilder.Length > 255 - ((!IsDot(unicode[unicode.Length - 1])) ? 1 : 0))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadNameSize", 255 - ((!IsDot(unicode[unicode.Length - 1])) ? 1 : 0)), "unicode");
		}
		return stringBuilder.ToString();
	}

	private static string punycode_decode(string ascii)
	{
		if (ascii.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "ascii");
		}
		if (ascii.Length > 255 - ((!IsDot(ascii[ascii.Length - 1])) ? 1 : 0))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadNameSize", 255 - ((!IsDot(ascii[ascii.Length - 1])) ? 1 : 0)), "ascii");
		}
		StringBuilder stringBuilder = new StringBuilder(ascii.Length);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (num < ascii.Length)
		{
			num = ascii.IndexOf('.', num2);
			if (num < 0 || num > ascii.Length)
			{
				num = ascii.Length;
			}
			if (num == num2)
			{
				if (num == ascii.Length)
				{
					break;
				}
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "ascii");
			}
			if (num - num2 > 63)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "ascii");
			}
			if (ascii.Length < "xn--".Length + num2 || !ascii.Substring(num2, "xn--".Length).Equals("xn--", StringComparison.OrdinalIgnoreCase))
			{
				stringBuilder.Append(ascii.Substring(num2, num - num2));
			}
			else
			{
				num2 += "xn--".Length;
				int num4 = ascii.LastIndexOf('-', num - 1);
				if (num4 == num - 1)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
				}
				int num5;
				if (num4 <= num2)
				{
					num5 = 0;
				}
				else
				{
					num5 = num4 - num2;
					for (int i = num2; i < num2 + num5; i++)
					{
						if (ascii[i] > '\u007f')
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
						}
						stringBuilder.Append((char)((ascii[i] >= 'A' && ascii[i] <= 'Z') ? (ascii[i] - 65 + 97) : ascii[i]));
					}
				}
				int num6 = num2 + ((num5 > 0) ? (num5 + 1) : 0);
				int num7 = 128;
				int num8 = 72;
				int num9 = 0;
				int num10 = 0;
				while (num6 < num)
				{
					int num11 = num9;
					int num12 = 1;
					int num13 = 36;
					while (true)
					{
						if (num6 >= num)
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
						}
						int num14 = decode_digit(ascii[num6++]);
						if (num14 > (134217727 - num9) / num12)
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
						}
						num9 += num14 * num12;
						int num15 = ((num13 <= num8) ? 1 : ((num13 >= num8 + 26) ? 26 : (num13 - num8)));
						if (num14 < num15)
						{
							break;
						}
						if (num12 > 134217727 / (36 - num15))
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
						}
						num12 *= 36 - num15;
						num13 += 36;
					}
					num8 = adapt(num9 - num11, stringBuilder.Length - num3 - num10 + 1, num11 == 0);
					if (num9 / (stringBuilder.Length - num3 - num10 + 1) > 134217727 - num7)
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
					}
					num7 += num9 / (stringBuilder.Length - num3 - num10 + 1);
					num9 %= stringBuilder.Length - num3 - num10 + 1;
					if (num7 < 0 || num7 > 1114111 || (num7 >= 55296 && num7 <= 57343))
					{
						throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
					}
					string value = char.ConvertFromUtf32(num7);
					int num17;
					if (num10 > 0)
					{
						int num16 = num9;
						num17 = num3;
						while (num16 > 0)
						{
							if (num17 >= stringBuilder.Length)
							{
								throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadPunycode"), "ascii");
							}
							if (char.IsSurrogate(stringBuilder[num17]))
							{
								num17++;
							}
							num16--;
							num17++;
						}
					}
					else
					{
						num17 = num3 + num9;
					}
					stringBuilder.Insert(num17, value);
					if (IsSupplementary(num7))
					{
						num10++;
					}
					num9++;
				}
				bool flag = false;
				BidiCategory bidiCategory = CharUnicodeInfo.GetBidiCategory(stringBuilder.ToString(), num3);
				if (bidiCategory == BidiCategory.RightToLeft || bidiCategory == BidiCategory.RightToLeftArabic)
				{
					flag = true;
				}
				for (int j = num3; j < stringBuilder.Length; j++)
				{
					if (!char.IsLowSurrogate(stringBuilder.ToString(), j))
					{
						bidiCategory = CharUnicodeInfo.GetBidiCategory(stringBuilder.ToString(), j);
						if ((flag && bidiCategory == BidiCategory.LeftToRight) || (!flag && (bidiCategory == BidiCategory.RightToLeft || bidiCategory == BidiCategory.RightToLeftArabic)))
						{
							throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadBidi"), "ascii");
						}
					}
				}
				if (flag && bidiCategory != BidiCategory.RightToLeft && bidiCategory != BidiCategory.RightToLeftArabic)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadBidi"), "ascii");
				}
			}
			if (num - num2 > 63)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadLabelSize"), "ascii");
			}
			if (num != ascii.Length)
			{
				stringBuilder.Append('.');
			}
			num2 = num + 1;
			num3 = stringBuilder.Length;
		}
		if (stringBuilder.Length > 255 - ((!IsDot(stringBuilder[stringBuilder.Length - 1])) ? 1 : 0))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IdnBadNameSize", 255 - ((!IsDot(stringBuilder[stringBuilder.Length - 1])) ? 1 : 0)), "ascii");
		}
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int IdnToAscii(uint dwFlags, [In][MarshalAs(UnmanagedType.LPWStr)] string lpUnicodeCharStr, int cchUnicodeChar, [Out] char[] lpASCIICharStr, int cchASCIIChar);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern int IdnToUnicode(uint dwFlags, [In][MarshalAs(UnmanagedType.LPWStr)] string lpASCIICharStr, int cchASCIIChar, [Out] char[] lpUnicodeCharStr, int cchUnicodeChar);
}

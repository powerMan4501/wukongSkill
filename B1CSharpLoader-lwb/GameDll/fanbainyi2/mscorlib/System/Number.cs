using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace System;

[FriendAccessAllowed]
internal class Number
{
	[FriendAccessAllowed]
	internal struct NumberBuffer
	{
		public static readonly int NumberBufferBytes = 114 + IntPtr.Size;

		[SecurityCritical]
		private unsafe byte* baseAddress;

		[SecurityCritical]
		public unsafe char* digits;

		public int precision;

		public int scale;

		public bool sign;

		[SecurityCritical]
		public unsafe NumberBuffer(byte* stackBuffer)
		{
			baseAddress = stackBuffer;
			digits = (char*)stackBuffer + 6;
			precision = 0;
			scale = 0;
			sign = false;
		}

		[SecurityCritical]
		public unsafe byte* PackForNative()
		{
			int* ptr = (int*)baseAddress;
			*ptr = precision;
			ptr[1] = scale;
			ptr[2] = (sign ? 1 : 0);
			return baseAddress;
		}
	}

	private const int NumberMaxDigits = 50;

	private const int Int32Precision = 10;

	private const int UInt32Precision = 10;

	private const int Int64Precision = 19;

	private const int UInt64Precision = 20;

	private Number()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatDecimal(decimal value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatDouble(double value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatInt32(int value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatUInt32(uint value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatInt64(long value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatUInt64(ulong value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public static extern string FormatSingle(float value, string format, NumberFormatInfo info);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	public unsafe static extern bool NumberBufferToDecimal(byte* number, ref decimal value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern bool NumberBufferToDouble(byte* number, ref double value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[FriendAccessAllowed]
	[SecurityCritical]
	internal unsafe static extern string FormatNumberBuffer(byte* number, string format, NumberFormatInfo info, char* allDigits);

	private static bool HexNumberToInt32(ref NumberBuffer number, ref int value)
	{
		uint value2 = 0u;
		bool result = HexNumberToUInt32(ref number, ref value2);
		value = (int)value2;
		return result;
	}

	private static bool HexNumberToInt64(ref NumberBuffer number, ref long value)
	{
		ulong value2 = 0uL;
		bool result = HexNumberToUInt64(ref number, ref value2);
		value = (long)value2;
		return result;
	}

	[SecuritySafeCritical]
	private unsafe static bool HexNumberToUInt32(ref NumberBuffer number, ref uint value)
	{
		int num = number.scale;
		if (num > 10 || num < number.precision)
		{
			return false;
		}
		char* ptr = number.digits;
		uint num2 = 0u;
		while (--num >= 0)
		{
			if (num2 > 268435455)
			{
				return false;
			}
			num2 *= 16;
			if (*ptr != 0)
			{
				uint num3 = num2;
				if (*ptr != 0)
				{
					num3 = ((*ptr >= '0' && *ptr <= '9') ? (num3 + (uint)(*ptr - 48)) : ((*ptr < 'A' || *ptr > 'F') ? (num3 + (uint)(*ptr - 97 + 10)) : (num3 + (uint)(*ptr - 65 + 10))));
					ptr++;
				}
				if (num3 < num2)
				{
					return false;
				}
				num2 = num3;
			}
		}
		value = num2;
		return true;
	}

	[SecuritySafeCritical]
	private unsafe static bool HexNumberToUInt64(ref NumberBuffer number, ref ulong value)
	{
		int num = number.scale;
		if (num > 20 || num < number.precision)
		{
			return false;
		}
		char* ptr = number.digits;
		ulong num2 = 0uL;
		while (--num >= 0)
		{
			if (num2 > 1152921504606846975L)
			{
				return false;
			}
			num2 *= 16;
			if (*ptr != 0)
			{
				ulong num3 = num2;
				if (*ptr != 0)
				{
					num3 = ((*ptr >= '0' && *ptr <= '9') ? (num3 + (ulong)(*ptr - 48)) : ((*ptr < 'A' || *ptr > 'F') ? (num3 + (ulong)(*ptr - 97 + 10)) : (num3 + (ulong)(*ptr - 65 + 10))));
					ptr++;
				}
				if (num3 < num2)
				{
					return false;
				}
				num2 = num3;
			}
		}
		value = num2;
		return true;
	}

	private static bool IsWhite(char ch)
	{
		if (ch != ' ')
		{
			if (ch >= '\t')
			{
				return ch <= '\r';
			}
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	private unsafe static bool NumberToInt32(ref NumberBuffer number, ref int value)
	{
		int num = number.scale;
		if (num > 10 || num < number.precision)
		{
			return false;
		}
		char* digits = number.digits;
		int num2 = 0;
		while (--num >= 0)
		{
			if ((uint)num2 > 214748364u)
			{
				return false;
			}
			num2 *= 10;
			if (*digits != 0)
			{
				num2 += *(digits++) - 48;
			}
		}
		if (number.sign)
		{
			num2 = -num2;
			if (num2 > 0)
			{
				return false;
			}
		}
		else if (num2 < 0)
		{
			return false;
		}
		value = num2;
		return true;
	}

	[SecuritySafeCritical]
	private unsafe static bool NumberToInt64(ref NumberBuffer number, ref long value)
	{
		int num = number.scale;
		if (num > 19 || num < number.precision)
		{
			return false;
		}
		char* digits = number.digits;
		long num2 = 0L;
		while (--num >= 0)
		{
			if ((ulong)num2 > 922337203685477580uL)
			{
				return false;
			}
			num2 *= 10;
			if (*digits != 0)
			{
				num2 += *(digits++) - 48;
			}
		}
		if (number.sign)
		{
			num2 = -num2;
			if (num2 > 0)
			{
				return false;
			}
		}
		else if (num2 < 0)
		{
			return false;
		}
		value = num2;
		return true;
	}

	[SecuritySafeCritical]
	private unsafe static bool NumberToUInt32(ref NumberBuffer number, ref uint value)
	{
		int num = number.scale;
		if (num > 10 || num < number.precision || number.sign)
		{
			return false;
		}
		char* digits = number.digits;
		uint num2 = 0u;
		while (--num >= 0)
		{
			if (num2 > 429496729)
			{
				return false;
			}
			num2 *= 10;
			if (*digits != 0)
			{
				uint num3 = num2 + (uint)(*(digits++) - 48);
				if (num3 < num2)
				{
					return false;
				}
				num2 = num3;
			}
		}
		value = num2;
		return true;
	}

	[SecuritySafeCritical]
	private unsafe static bool NumberToUInt64(ref NumberBuffer number, ref ulong value)
	{
		int num = number.scale;
		if (num > 20 || num < number.precision || number.sign)
		{
			return false;
		}
		char* digits = number.digits;
		ulong num2 = 0uL;
		while (--num >= 0)
		{
			if (num2 > 1844674407370955161L)
			{
				return false;
			}
			num2 *= 10;
			if (*digits != 0)
			{
				ulong num3 = num2 + (ulong)(*(digits++) - 48);
				if (num3 < num2)
				{
					return false;
				}
				num2 = num3;
			}
		}
		value = num2;
		return true;
	}

	[SecurityCritical]
	private unsafe static char* MatchChars(char* p, string str)
	{
		fixed (char* str2 = str)
		{
			return MatchChars(p, str2);
		}
	}

	[SecurityCritical]
	private unsafe static char* MatchChars(char* p, char* str)
	{
		if (*str == '\0')
		{
			return null;
		}
		while (*str != 0)
		{
			if (*p != *str && (*str != '\u00a0' || *p != ' '))
			{
				return null;
			}
			p++;
			str++;
		}
		return p;
	}

	[SecuritySafeCritical]
	internal unsafe static decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		decimal value2 = default(decimal);
		StringToNumber(value, options, ref number, numfmt, parseDecimal: true);
		if (!NumberBufferToDecimal(number.PackForNative(), ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Decimal"));
		}
		return value2;
	}

	[SecuritySafeCritical]
	internal unsafe static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		double value2 = 0.0;
		if (!TryStringToNumber(value, options, ref number, numfmt, parseDecimal: false))
		{
			string text = value.Trim();
			if (text.Equals(numfmt.PositiveInfinitySymbol))
			{
				return double.PositiveInfinity;
			}
			if (text.Equals(numfmt.NegativeInfinitySymbol))
			{
				return double.NegativeInfinity;
			}
			if (text.Equals(numfmt.NaNSymbol))
			{
				return double.NaN;
			}
			throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
		}
		if (!NumberBufferToDouble(number.PackForNative(), ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Double"));
		}
		return value2;
	}

	[SecuritySafeCritical]
	internal unsafe static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		int value = 0;
		StringToNumber(s, style, ref number, info, parseDecimal: false);
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToInt32(ref number, ref value))
			{
				throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
			}
		}
		else if (!NumberToInt32(ref number, ref value))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
		}
		return value;
	}

	[SecuritySafeCritical]
	internal unsafe static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		long value2 = 0L;
		StringToNumber(value, options, ref number, numfmt, parseDecimal: false);
		if ((options & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToInt64(ref number, ref value2))
			{
				throw new OverflowException(Environment.GetResourceString("Overflow_Int64"));
			}
		}
		else if (!NumberToInt64(ref number, ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int64"));
		}
		return value2;
	}

	[SecurityCritical]
	private unsafe static bool ParseNumber(ref char* str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
	{
		number.scale = 0;
		number.sign = false;
		string text = null;
		string text2 = null;
		string str2 = null;
		string str3 = null;
		bool flag = false;
		string str4;
		string str5;
		if ((options & NumberStyles.AllowCurrencySymbol) != NumberStyles.None)
		{
			text = numfmt.CurrencySymbol;
			if (numfmt.ansiCurrencySymbol != null)
			{
				text2 = numfmt.ansiCurrencySymbol;
			}
			str2 = numfmt.NumberDecimalSeparator;
			str3 = numfmt.NumberGroupSeparator;
			str4 = numfmt.CurrencyDecimalSeparator;
			str5 = numfmt.CurrencyGroupSeparator;
			flag = true;
		}
		else
		{
			str4 = numfmt.NumberDecimalSeparator;
			str5 = numfmt.NumberGroupSeparator;
		}
		int num = 0;
		bool flag2 = false;
		bool flag3 = sb != null;
		bool flag4 = flag3 && (options & NumberStyles.AllowHexSpecifier) != 0;
		int num2 = (flag3 ? int.MaxValue : 50);
		char* ptr = str;
		char c = *ptr;
		while (true)
		{
			if (!IsWhite(c) || (options & NumberStyles.AllowLeadingWhite) == 0 || ((num & 1) != 0 && ((num & 1) == 0 || ((num & 0x20) == 0 && numfmt.numberNegativePattern != 2))))
			{
				char* ptr2;
				if ((flag2 = (options & NumberStyles.AllowLeadingSign) != NumberStyles.None && (num & 1) == 0) && (ptr2 = MatchChars(ptr, numfmt.positiveSign)) != null)
				{
					num |= 1;
					ptr = ptr2 - 1;
				}
				else if (flag2 && (ptr2 = MatchChars(ptr, numfmt.negativeSign)) != null)
				{
					num |= 1;
					number.sign = true;
					ptr = ptr2 - 1;
				}
				else if (c == '(' && (options & NumberStyles.AllowParentheses) != NumberStyles.None && (num & 1) == 0)
				{
					num |= 3;
					number.sign = true;
				}
				else
				{
					if ((text == null || (ptr2 = MatchChars(ptr, text)) == null) && (text2 == null || (ptr2 = MatchChars(ptr, text2)) == null))
					{
						break;
					}
					num |= 0x20;
					text = null;
					text2 = null;
					ptr = ptr2 - 1;
				}
			}
			c = *(++ptr);
		}
		int num3 = 0;
		int num4 = 0;
		while (true)
		{
			char* ptr2;
			if ((c >= '0' && c <= '9') || ((options & NumberStyles.AllowHexSpecifier) != NumberStyles.None && ((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F'))))
			{
				num |= 4;
				if (c != '0' || (num & 8) != 0 || flag4)
				{
					if (num3 < num2)
					{
						if (flag3)
						{
							sb.Append(c);
						}
						else
						{
							number.digits[num3++] = c;
						}
						if (c != '0' || parseDecimal)
						{
							num4 = num3;
						}
					}
					if ((num & 0x10) == 0)
					{
						number.scale++;
					}
					num |= 8;
				}
				else if ((num & 0x10) != 0)
				{
					number.scale--;
				}
			}
			else if ((options & NumberStyles.AllowDecimalPoint) != NumberStyles.None && (num & 0x10) == 0 && ((ptr2 = MatchChars(ptr, str4)) != null || (flag && (num & 0x20) == 0 && (ptr2 = MatchChars(ptr, str2)) != null)))
			{
				num |= 0x10;
				ptr = ptr2 - 1;
			}
			else
			{
				if ((options & NumberStyles.AllowThousands) == 0 || (num & 4) == 0 || (num & 0x10) != 0 || ((ptr2 = MatchChars(ptr, str5)) == null && (!flag || (num & 0x20) != 0 || (ptr2 = MatchChars(ptr, str3)) == null)))
				{
					break;
				}
				ptr = ptr2 - 1;
			}
			c = *(++ptr);
		}
		bool flag5 = false;
		number.precision = num4;
		if (flag3)
		{
			sb.Append('\0');
		}
		else
		{
			number.digits[num4] = '\0';
		}
		if ((num & 4) != 0)
		{
			if ((c == 'E' || c == 'e') && (options & NumberStyles.AllowExponent) != NumberStyles.None)
			{
				char* ptr3 = ptr;
				c = *(++ptr);
				char* ptr2;
				if ((ptr2 = MatchChars(ptr, numfmt.positiveSign)) != null)
				{
					c = *(ptr = ptr2);
				}
				else if ((ptr2 = MatchChars(ptr, numfmt.negativeSign)) != null)
				{
					c = *(ptr = ptr2);
					flag5 = true;
				}
				if (c >= '0' && c <= '9')
				{
					int num5 = 0;
					do
					{
						num5 = num5 * 10 + (c - 48);
						c = *(++ptr);
						if (num5 > 1000)
						{
							num5 = 9999;
							while (c >= '0' && c <= '9')
							{
								c = *(++ptr);
							}
						}
					}
					while (c >= '0' && c <= '9');
					if (flag5)
					{
						num5 = -num5;
					}
					number.scale += num5;
				}
				else
				{
					ptr = ptr3;
					c = *ptr;
				}
			}
			while (true)
			{
				if (!IsWhite(c) || (options & NumberStyles.AllowTrailingWhite) == 0)
				{
					char* ptr2;
					if ((flag2 = (options & NumberStyles.AllowTrailingSign) != NumberStyles.None && (num & 1) == 0) && (ptr2 = MatchChars(ptr, numfmt.positiveSign)) != null)
					{
						num |= 1;
						ptr = ptr2 - 1;
					}
					else if (flag2 && (ptr2 = MatchChars(ptr, numfmt.negativeSign)) != null)
					{
						num |= 1;
						number.sign = true;
						ptr = ptr2 - 1;
					}
					else if (c == ')' && (num & 2) != 0)
					{
						num &= -3;
					}
					else
					{
						if ((text == null || (ptr2 = MatchChars(ptr, text)) == null) && (text2 == null || (ptr2 = MatchChars(ptr, text2)) == null))
						{
							break;
						}
						text = null;
						text2 = null;
						ptr = ptr2 - 1;
					}
				}
				c = *(++ptr);
			}
			if ((num & 2) == 0)
			{
				if ((num & 8) == 0)
				{
					if (!parseDecimal)
					{
						number.scale = 0;
					}
					if ((num & 0x10) == 0)
					{
						number.sign = false;
					}
				}
				str = ptr;
				return true;
			}
		}
		str = ptr;
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		double value2 = 0.0;
		if (!TryStringToNumber(value, options, ref number, numfmt, parseDecimal: false))
		{
			string text = value.Trim();
			if (text.Equals(numfmt.PositiveInfinitySymbol))
			{
				return float.PositiveInfinity;
			}
			if (text.Equals(numfmt.NegativeInfinitySymbol))
			{
				return float.NegativeInfinity;
			}
			if (text.Equals(numfmt.NaNSymbol))
			{
				return float.NaN;
			}
			throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
		}
		if (!NumberBufferToDouble(number.PackForNative(), ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Single"));
		}
		float num = (float)value2;
		if (float.IsInfinity(num))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Single"));
		}
		return num;
	}

	[SecuritySafeCritical]
	internal unsafe static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		uint value2 = 0u;
		StringToNumber(value, options, ref number, numfmt, parseDecimal: false);
		if ((options & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToUInt32(ref number, ref value2))
			{
				throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
			}
		}
		else if (!NumberToUInt32(ref number, ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return value2;
	}

	[SecuritySafeCritical]
	internal unsafe static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		ulong value2 = 0uL;
		StringToNumber(value, options, ref number, numfmt, parseDecimal: false);
		if ((options & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToUInt64(ref number, ref value2))
			{
				throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
			}
		}
		else if (!NumberToUInt64(ref number, ref value2))
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
		}
		return value2;
	}

	[SecuritySafeCritical]
	private unsafe static void StringToNumber(string str, NumberStyles options, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		if (str == null)
		{
			throw new ArgumentNullException("String");
		}
		fixed (char* ptr = str)
		{
			char* str2 = ptr;
			if (!ParseNumber(ref str2, options, ref number, null, info, parseDecimal) || (str2 - ptr < str.Length && !TrailingZeros(str, (int)(str2 - ptr))))
			{
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
		}
	}

	private static bool TrailingZeros(string s, int index)
	{
		for (int i = index; i < s.Length; i++)
		{
			if (s[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out decimal result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = default(decimal);
		if (!TryStringToNumber(value, options, ref number, numfmt, parseDecimal: true))
		{
			return false;
		}
		if (!NumberBufferToDecimal(number.PackForNative(), ref result))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0.0;
		if (!TryStringToNumber(value, options, ref number, numfmt, parseDecimal: false))
		{
			return false;
		}
		if (!NumberBufferToDouble(number.PackForNative(), ref result))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0;
		if (!TryStringToNumber(s, style, ref number, info, parseDecimal: false))
		{
			return false;
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToInt32(ref number, ref result))
			{
				return false;
			}
		}
		else if (!NumberToInt32(ref number, ref result))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0L;
		if (!TryStringToNumber(s, style, ref number, info, parseDecimal: false))
		{
			return false;
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToInt64(ref number, ref result))
			{
				return false;
			}
		}
		else if (!NumberToInt64(ref number, ref result))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0f;
		double value2 = 0.0;
		if (!TryStringToNumber(value, options, ref number, numfmt, parseDecimal: false))
		{
			return false;
		}
		if (!NumberBufferToDouble(number.PackForNative(), ref value2))
		{
			return false;
		}
		float num = (float)value2;
		if (float.IsInfinity(num))
		{
			return false;
		}
		result = num;
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0u;
		if (!TryStringToNumber(s, style, ref number, info, parseDecimal: false))
		{
			return false;
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToUInt32(ref number, ref result))
			{
				return false;
			}
		}
		else if (!NumberToUInt32(ref number, ref result))
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result)
	{
		byte* stackBuffer = stackalloc byte[(int)(uint)NumberBuffer.NumberBufferBytes];
		NumberBuffer number = new NumberBuffer(stackBuffer);
		result = 0uL;
		if (!TryStringToNumber(s, style, ref number, info, parseDecimal: false))
		{
			return false;
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (!HexNumberToUInt64(ref number, ref result))
			{
				return false;
			}
		}
		else if (!NumberToUInt64(ref number, ref result))
		{
			return false;
		}
		return true;
	}

	internal static bool TryStringToNumber(string str, NumberStyles options, ref NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal)
	{
		return TryStringToNumber(str, options, ref number, null, numfmt, parseDecimal);
	}

	[SecuritySafeCritical]
	[FriendAccessAllowed]
	internal unsafe static bool TryStringToNumber(string str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
	{
		if (str == null)
		{
			return false;
		}
		fixed (char* ptr = str)
		{
			char* str2 = ptr;
			if (!ParseNumber(ref str2, options, ref number, sb, numfmt, parseDecimal) || (str2 - ptr < str.Length && !TrailingZeros(str, (int)(str2 - ptr))))
			{
				return false;
			}
		}
		return true;
	}
}

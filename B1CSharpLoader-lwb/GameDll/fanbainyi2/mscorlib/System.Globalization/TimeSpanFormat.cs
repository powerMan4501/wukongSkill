using System.Security;
using System.Text;

namespace System.Globalization;

internal static class TimeSpanFormat
{
	internal enum Pattern
	{
		None,
		Minimum,
		Full
	}

	internal struct FormatLiterals
	{
		internal string AppCompatLiteral;

		internal int dd;

		internal int hh;

		internal int mm;

		internal int ss;

		internal int ff;

		private string[] literals;

		internal string Start => literals[0];

		internal string DayHourSep => literals[1];

		internal string HourMinuteSep => literals[2];

		internal string MinuteSecondSep => literals[3];

		internal string SecondFractionSep => literals[4];

		internal string End => literals[5];

		internal static FormatLiterals InitInvariant(bool isNegative)
		{
			FormatLiterals result = new FormatLiterals
			{
				literals = new string[6]
			};
			result.literals[0] = (isNegative ? "-" : string.Empty);
			result.literals[1] = ".";
			result.literals[2] = ":";
			result.literals[3] = ":";
			result.literals[4] = ".";
			result.literals[5] = string.Empty;
			result.AppCompatLiteral = ":.";
			result.dd = 2;
			result.hh = 2;
			result.mm = 2;
			result.ss = 2;
			result.ff = 7;
			return result;
		}

		internal void Init(string format, bool useInvariantFieldLengths)
		{
			literals = new string[6];
			for (int i = 0; i < literals.Length; i++)
			{
				literals[i] = string.Empty;
			}
			dd = 0;
			hh = 0;
			mm = 0;
			ss = 0;
			ff = 0;
			StringBuilder stringBuilder = StringBuilderCache.Acquire();
			bool flag = false;
			char c = '\'';
			int num = 0;
			for (int j = 0; j < format.Length; j++)
			{
				switch (format[j])
				{
				case '"':
				case '\'':
					if (flag && c == format[j])
					{
						if (num < 0 || num > 5)
						{
							return;
						}
						literals[num] = stringBuilder.ToString();
						stringBuilder.Length = 0;
						flag = false;
					}
					else if (!flag)
					{
						c = format[j];
						flag = true;
					}
					continue;
				case '\\':
					if (!flag)
					{
						j++;
						continue;
					}
					break;
				case 'd':
					if (!flag)
					{
						num = 1;
						dd++;
					}
					continue;
				case 'h':
					if (!flag)
					{
						num = 2;
						hh++;
					}
					continue;
				case 'm':
					if (!flag)
					{
						num = 3;
						mm++;
					}
					continue;
				case 's':
					if (!flag)
					{
						num = 4;
						ss++;
					}
					continue;
				case 'F':
				case 'f':
					if (!flag)
					{
						num = 5;
						ff++;
					}
					continue;
				}
				stringBuilder.Append(format[j]);
			}
			AppCompatLiteral = MinuteSecondSep + SecondFractionSep;
			if (useInvariantFieldLengths)
			{
				dd = 2;
				hh = 2;
				mm = 2;
				ss = 2;
				ff = 7;
			}
			else
			{
				if (dd < 1 || dd > 2)
				{
					dd = 2;
				}
				if (hh < 1 || hh > 2)
				{
					hh = 2;
				}
				if (mm < 1 || mm > 2)
				{
					mm = 2;
				}
				if (ss < 1 || ss > 2)
				{
					ss = 2;
				}
				if (ff < 1 || ff > 7)
				{
					ff = 7;
				}
			}
			StringBuilderCache.Release(stringBuilder);
		}
	}

	internal static readonly FormatLiterals PositiveInvariantFormatLiterals = FormatLiterals.InitInvariant(isNegative: false);

	internal static readonly FormatLiterals NegativeInvariantFormatLiterals = FormatLiterals.InitInvariant(isNegative: true);

	[SecuritySafeCritical]
	private static string IntToString(int n, int digits)
	{
		return ParseNumbers.IntToString(n, 10, digits, '0', 0);
	}

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
	{
		if (format == null || format.Length == 0)
		{
			format = "c";
		}
		if (format.Length == 1)
		{
			char c = format[0];
			switch (c)
			{
			case 'T':
			case 'c':
			case 't':
				return FormatStandard(value, isInvariant: true, format, Pattern.Minimum);
			case 'G':
			case 'g':
			{
				DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(formatProvider);
				format = ((value._ticks >= 0) ? instance.FullTimeSpanPositivePattern : instance.FullTimeSpanNegativePattern);
				Pattern pattern = ((c == 'g') ? Pattern.Minimum : Pattern.Full);
				return FormatStandard(value, isInvariant: false, format, pattern);
			}
			default:
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
		}
		return FormatCustomized(value, format, DateTimeFormatInfo.GetInstance(formatProvider));
	}

	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, Pattern pattern)
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		int num = (int)(value._ticks / 864000000000L);
		long num2 = value._ticks % 864000000000L;
		if (value._ticks < 0)
		{
			num = -num;
			num2 = -num2;
		}
		int n = (int)(num2 / 36000000000L % 24);
		int n2 = (int)(num2 / 600000000 % 60);
		int n3 = (int)(num2 / 10000000 % 60);
		int num3 = (int)(num2 % 10000000);
		FormatLiterals formatLiterals;
		if (isInvariant)
		{
			formatLiterals = ((value._ticks >= 0) ? PositiveInvariantFormatLiterals : NegativeInvariantFormatLiterals);
		}
		else
		{
			formatLiterals = default(FormatLiterals);
			formatLiterals.Init(format, pattern == Pattern.Full);
		}
		if (num3 != 0)
		{
			num3 = (int)(num3 / (long)Math.Pow(10.0, 7 - formatLiterals.ff));
		}
		stringBuilder.Append(formatLiterals.Start);
		if (pattern == Pattern.Full || num != 0)
		{
			stringBuilder.Append(num);
			stringBuilder.Append(formatLiterals.DayHourSep);
		}
		stringBuilder.Append(IntToString(n, formatLiterals.hh));
		stringBuilder.Append(formatLiterals.HourMinuteSep);
		stringBuilder.Append(IntToString(n2, formatLiterals.mm));
		stringBuilder.Append(formatLiterals.MinuteSecondSep);
		stringBuilder.Append(IntToString(n3, formatLiterals.ss));
		if (!isInvariant && pattern == Pattern.Minimum)
		{
			int num4 = formatLiterals.ff;
			while (num4 > 0 && num3 % 10 == 0)
			{
				num3 /= 10;
				num4--;
			}
			if (num4 > 0)
			{
				stringBuilder.Append(formatLiterals.SecondFractionSep);
				stringBuilder.Append(num3.ToString(DateTimeFormat.fixedNumberFormats[num4 - 1], CultureInfo.InvariantCulture));
			}
		}
		else if (pattern == Pattern.Full || num3 != 0)
		{
			stringBuilder.Append(formatLiterals.SecondFractionSep);
			stringBuilder.Append(IntToString(num3, formatLiterals.ff));
		}
		stringBuilder.Append(formatLiterals.End);
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi)
	{
		int num = (int)(value._ticks / 864000000000L);
		long num2 = value._ticks % 864000000000L;
		if (value._ticks < 0)
		{
			num = -num;
			num2 = -num2;
		}
		int value2 = (int)(num2 / 36000000000L % 24);
		int value3 = (int)(num2 / 600000000 % 60);
		int value4 = (int)(num2 / 10000000 % 60);
		int num3 = (int)(num2 % 10000000);
		long num4 = 0L;
		int i = 0;
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		int num6;
		for (; i < format.Length; i += num6)
		{
			char c = format[i];
			switch (c)
			{
			case 'h':
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 2)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				DateTimeFormat.FormatDigits(stringBuilder, value2, num6);
				break;
			case 'm':
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 2)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				DateTimeFormat.FormatDigits(stringBuilder, value3, num6);
				break;
			case 's':
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 2)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				DateTimeFormat.FormatDigits(stringBuilder, value4, num6);
				break;
			case 'f':
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 7)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				num4 = num3;
				stringBuilder.Append((num4 / (long)Math.Pow(10.0, 7 - num6)).ToString(DateTimeFormat.fixedNumberFormats[num6 - 1], CultureInfo.InvariantCulture));
				break;
			case 'F':
			{
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 7)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				num4 = num3;
				num4 /= (long)Math.Pow(10.0, 7 - num6);
				int num7 = num6;
				while (num7 > 0 && num4 % 10 == 0L)
				{
					num4 /= 10;
					num7--;
				}
				if (num7 > 0)
				{
					stringBuilder.Append(num4.ToString(DateTimeFormat.fixedNumberFormats[num7 - 1], CultureInfo.InvariantCulture));
				}
				break;
			}
			case 'd':
				num6 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num6 > 8)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				DateTimeFormat.FormatDigits(stringBuilder, num, num6, overrideLengthLimit: true);
				break;
			case '"':
			case '\'':
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				num6 = DateTimeFormat.ParseQuoteString(format, i, stringBuilder2);
				stringBuilder.Append(stringBuilder2);
				break;
			}
			case '%':
			{
				int num5 = DateTimeFormat.ParseNextChar(format, i);
				if (num5 >= 0 && num5 != 37)
				{
					stringBuilder.Append(FormatCustomized(value, ((char)num5).ToString(), dtfi));
					num6 = 2;
					break;
				}
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
			case '\\':
			{
				int num5 = DateTimeFormat.ParseNextChar(format, i);
				if (num5 >= 0)
				{
					stringBuilder.Append((char)num5);
					num6 = 2;
					break;
				}
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
			default:
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}
}

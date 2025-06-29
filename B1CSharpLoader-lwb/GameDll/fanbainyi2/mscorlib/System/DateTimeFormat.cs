using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Text;

namespace System;

internal static class DateTimeFormat
{
	internal const int MaxSecondsFractionDigits = 7;

	internal static readonly TimeSpan NullOffset = TimeSpan.MinValue;

	internal static char[] allStandardFormats = new char[19]
	{
		'd', 'D', 'f', 'F', 'g', 'G', 'm', 'M', 'o', 'O',
		'r', 'R', 's', 't', 'T', 'u', 'U', 'y', 'Y'
	};

	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

	internal static readonly DateTimeFormatInfo InvariantFormatInfo = CultureInfo.InvariantCulture.DateTimeFormat;

	internal static readonly string[] InvariantAbbreviatedMonthNames = InvariantFormatInfo.AbbreviatedMonthNames;

	internal static readonly string[] InvariantAbbreviatedDayNames = InvariantFormatInfo.AbbreviatedDayNames;

	internal const string Gmt = "GMT";

	internal static string[] fixedNumberFormats = new string[7] { "0", "00", "000", "0000", "00000", "000000", "0000000" };

	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len)
	{
		FormatDigits(outputBuffer, value, len, overrideLengthLimit: false);
	}

	[SecuritySafeCritical]
	internal unsafe static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
	{
		if (!overrideLengthLimit && len > 2)
		{
			len = 2;
		}
		char* ptr = stackalloc char[16];
		char* ptr2 = ptr + 16;
		int num = value;
		do
		{
			*(--ptr2) = (char)(num % 10 + 48);
			num /= 10;
		}
		while (num != 0 && ptr2 > ptr);
		int i;
		for (i = (int)(ptr + 16 - ptr2); i < len; i++)
		{
			if (ptr2 <= ptr)
			{
				break;
			}
			*(--ptr2) = '0';
		}
		outputBuffer.Append(ptr2, i);
	}

	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
	{
		outputBuffer.Append(HebrewNumber.ToString(digits));
	}

	internal static int ParseRepeatPattern(string format, int pos, char patternChar)
	{
		int length = format.Length;
		int i;
		for (i = pos + 1; i < length && format[i] == patternChar; i++)
		{
		}
		return i - pos;
	}

	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
	{
		if (repeat == 3)
		{
			return dtfi.GetAbbreviatedDayName((DayOfWeek)dayOfWeek);
		}
		return dtfi.GetDayName((DayOfWeek)dayOfWeek);
	}

	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
	{
		if (repeatCount == 3)
		{
			return dtfi.GetAbbreviatedMonthName(month);
		}
		return dtfi.GetMonthName(month);
	}

	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
	{
		if (dtfi.Calendar.IsLeapYear(dtfi.Calendar.GetYear(time)))
		{
			return dtfi.internalGetMonthName(month, MonthNameStyles.LeapYear, repeatCount == 3);
		}
		if (month >= 7)
		{
			month++;
		}
		if (repeatCount == 3)
		{
			return dtfi.GetAbbreviatedMonthName(month);
		}
		return dtfi.GetMonthName(month);
	}

	internal static int ParseQuoteString(string format, int pos, StringBuilder result)
	{
		int length = format.Length;
		int num = pos;
		char c = format[pos++];
		bool flag = false;
		while (pos < length)
		{
			char c2 = format[pos++];
			if (c2 == c)
			{
				flag = true;
				break;
			}
			if (c2 == '\\')
			{
				if (pos >= length)
				{
					throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
				}
				result.Append(format[pos++]);
			}
			else
			{
				result.Append(c2);
			}
		}
		if (!flag)
		{
			throw new FormatException(string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("Format_BadQuote"), c));
		}
		return pos - num;
	}

	internal static int ParseNextChar(string format, int pos)
	{
		if (pos >= format.Length - 1)
		{
			return -1;
		}
		return format[pos + 1];
	}

	private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch)
	{
		int num = 0;
		int num2 = index - 1;
		while (num2 >= 0 && format[num2] != patternToMatch)
		{
			num2--;
		}
		if (num2 >= 0)
		{
			while (--num2 >= 0 && format[num2] == patternToMatch)
			{
				num++;
			}
			if (num <= 1)
			{
				return true;
			}
		}
		for (num2 = index + tokenLen; num2 < format.Length && format[num2] != patternToMatch; num2++)
		{
		}
		if (num2 < format.Length)
		{
			num = 0;
			while (++num2 < format.Length && format[num2] == patternToMatch)
			{
				num++;
			}
			if (num <= 1)
			{
				return true;
			}
		}
		return false;
	}

	private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
	{
		Calendar calendar = dtfi.Calendar;
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		bool flag = calendar.ID == 8;
		bool flag2 = calendar.ID == 3;
		bool timeOnly = true;
		int num;
		for (int i = 0; i < format.Length; i += num)
		{
			char c = format[i];
			switch (c)
			{
			case 'g':
				num = ParseRepeatPattern(format, i, c);
				stringBuilder.Append(dtfi.GetEraName(calendar.GetEra(dateTime)));
				break;
			case 'h':
			{
				num = ParseRepeatPattern(format, i, c);
				int num5 = dateTime.Hour % 12;
				if (num5 == 0)
				{
					num5 = 12;
				}
				FormatDigits(stringBuilder, num5, num);
				break;
			}
			case 'H':
				num = ParseRepeatPattern(format, i, c);
				FormatDigits(stringBuilder, dateTime.Hour, num);
				break;
			case 'm':
				num = ParseRepeatPattern(format, i, c);
				FormatDigits(stringBuilder, dateTime.Minute, num);
				break;
			case 's':
				num = ParseRepeatPattern(format, i, c);
				FormatDigits(stringBuilder, dateTime.Second, num);
				break;
			case 'F':
			case 'f':
				num = ParseRepeatPattern(format, i, c);
				if (num <= 7)
				{
					long num3 = dateTime.Ticks % 10000000;
					num3 /= (long)Math.Pow(10.0, 7 - num);
					if (c == 'f')
					{
						stringBuilder.Append(((int)num3).ToString(fixedNumberFormats[num - 1], CultureInfo.InvariantCulture));
						break;
					}
					int num4 = num;
					while (num4 > 0 && num3 % 10 == 0L)
					{
						num3 /= 10;
						num4--;
					}
					if (num4 > 0)
					{
						stringBuilder.Append(((int)num3).ToString(fixedNumberFormats[num4 - 1], CultureInfo.InvariantCulture));
					}
					else if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '.')
					{
						stringBuilder.Remove(stringBuilder.Length - 1, 1);
					}
					break;
				}
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			case 't':
				num = ParseRepeatPattern(format, i, c);
				if (num == 1)
				{
					if (dateTime.Hour < 12)
					{
						if (dtfi.AMDesignator.Length >= 1)
						{
							stringBuilder.Append(dtfi.AMDesignator[0]);
						}
					}
					else if (dtfi.PMDesignator.Length >= 1)
					{
						stringBuilder.Append(dtfi.PMDesignator[0]);
					}
				}
				else
				{
					stringBuilder.Append((dateTime.Hour < 12) ? dtfi.AMDesignator : dtfi.PMDesignator);
				}
				break;
			case 'd':
				num = ParseRepeatPattern(format, i, c);
				if (num <= 2)
				{
					int dayOfMonth = calendar.GetDayOfMonth(dateTime);
					if (flag)
					{
						HebrewFormatDigits(stringBuilder, dayOfMonth);
					}
					else
					{
						FormatDigits(stringBuilder, dayOfMonth, num);
					}
				}
				else
				{
					int dayOfWeek = (int)calendar.GetDayOfWeek(dateTime);
					stringBuilder.Append(FormatDayOfWeek(dayOfWeek, num, dtfi));
				}
				timeOnly = false;
				break;
			case 'M':
			{
				num = ParseRepeatPattern(format, i, c);
				int month = calendar.GetMonth(dateTime);
				if (num <= 2)
				{
					if (flag)
					{
						HebrewFormatDigits(stringBuilder, month);
					}
					else
					{
						FormatDigits(stringBuilder, month, num);
					}
				}
				else if (flag)
				{
					stringBuilder.Append(FormatHebrewMonthName(dateTime, month, num, dtfi));
				}
				else if ((dtfi.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None && num >= 4)
				{
					stringBuilder.Append(dtfi.internalGetMonthName(month, IsUseGenitiveForm(format, i, num, 'd') ? MonthNameStyles.Genitive : MonthNameStyles.Regular, abbreviated: false));
				}
				else
				{
					stringBuilder.Append(FormatMonth(month, num, dtfi));
				}
				timeOnly = false;
				break;
			}
			case 'y':
			{
				int year = calendar.GetYear(dateTime);
				num = ParseRepeatPattern(format, i, c);
				if (flag2 && !AppContextSwitches.FormatJapaneseFirstYearAsANumber && year == 1 && ((i + num < format.Length && format[i + num] == "年"[0]) || (i + num < format.Length - 1 && format[i + num] == '\'' && format[i + num + 1] == "年"[0])))
				{
					stringBuilder.Append("元"[0]);
				}
				else if (dtfi.HasForceTwoDigitYears)
				{
					FormatDigits(stringBuilder, year, (num <= 2) ? num : 2);
				}
				else if (calendar.ID == 8)
				{
					HebrewFormatDigits(stringBuilder, year);
				}
				else if (num <= 2)
				{
					FormatDigits(stringBuilder, year % 100, num);
				}
				else
				{
					string text = "D" + num;
					stringBuilder.Append(year.ToString(text, CultureInfo.InvariantCulture));
				}
				timeOnly = false;
				break;
			}
			case 'z':
				num = ParseRepeatPattern(format, i, c);
				FormatCustomizedTimeZone(dateTime, offset, format, num, timeOnly, stringBuilder);
				break;
			case 'K':
				num = 1;
				FormatCustomizedRoundripTimeZone(dateTime, offset, stringBuilder);
				break;
			case ':':
				stringBuilder.Append(dtfi.TimeSeparator);
				num = 1;
				break;
			case '/':
				stringBuilder.Append(dtfi.DateSeparator);
				num = 1;
				break;
			case '"':
			case '\'':
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				num = ParseQuoteString(format, i, stringBuilder2);
				stringBuilder.Append(stringBuilder2);
				break;
			}
			case '%':
			{
				int num2 = ParseNextChar(format, i);
				if (num2 >= 0 && num2 != 37)
				{
					stringBuilder.Append(FormatCustomized(dateTime, ((char)num2).ToString(), dtfi, offset));
					num = 2;
					break;
				}
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
			case '\\':
			{
				int num2 = ParseNextChar(format, i);
				if (num2 >= 0)
				{
					stringBuilder.Append((char)num2);
					num = 2;
					break;
				}
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
			default:
				stringBuilder.Append(c);
				num = 1;
				break;
			}
		}
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result)
	{
		if (offset == NullOffset)
		{
			if (timeOnly && dateTime.Ticks < 864000000000L)
			{
				offset = TimeZoneInfo.GetLocalUtcOffset(DateTime.Now, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			else if (dateTime.Kind == DateTimeKind.Utc)
			{
				InvalidFormatForUtc(format, dateTime);
				dateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
				offset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			else
			{
				offset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
		}
		if (offset >= TimeSpan.Zero)
		{
			result.Append('+');
		}
		else
		{
			result.Append('-');
			offset = offset.Negate();
		}
		if (tokenLen <= 1)
		{
			result.AppendFormat(CultureInfo.InvariantCulture, "{0:0}", offset.Hours);
			return;
		}
		result.AppendFormat(CultureInfo.InvariantCulture, "{0:00}", offset.Hours);
		if (tokenLen >= 3)
		{
			result.AppendFormat(CultureInfo.InvariantCulture, ":{0:00}", offset.Minutes);
		}
	}

	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
	{
		if (offset == NullOffset)
		{
			switch (dateTime.Kind)
			{
			case DateTimeKind.Local:
				break;
			case DateTimeKind.Utc:
				result.Append("Z");
				return;
			default:
				return;
			}
			offset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}
		if (offset >= TimeSpan.Zero)
		{
			result.Append('+');
		}
		else
		{
			result.Append('-');
			offset = offset.Negate();
		}
		result.AppendFormat(CultureInfo.InvariantCulture, "{0:00}:{1:00}", offset.Hours, offset.Minutes);
	}

	internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi)
	{
		string text = null;
		switch (format[0])
		{
		case 'd':
			return dtfi.ShortDatePattern;
		case 'D':
			return dtfi.LongDatePattern;
		case 'f':
			return dtfi.LongDatePattern + " " + dtfi.ShortTimePattern;
		case 'F':
			return dtfi.FullDateTimePattern;
		case 'g':
			return dtfi.GeneralShortTimePattern;
		case 'G':
			return dtfi.GeneralLongTimePattern;
		case 'M':
		case 'm':
			return dtfi.MonthDayPattern;
		case 'O':
		case 'o':
			return "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
		case 'R':
		case 'r':
			return dtfi.RFC1123Pattern;
		case 's':
			return dtfi.SortableDateTimePattern;
		case 't':
			return dtfi.ShortTimePattern;
		case 'T':
			return dtfi.LongTimePattern;
		case 'u':
			return dtfi.UniversalSortableDateTimePattern;
		case 'U':
			return dtfi.FullDateTimePattern;
		case 'Y':
		case 'y':
			return dtfi.YearMonthPattern;
		default:
			throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
		}
	}

	private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset)
	{
		switch (format[0])
		{
		case 's':
			dtfi = DateTimeFormatInfo.InvariantInfo;
			break;
		case 'u':
			if (offset != NullOffset)
			{
				dateTime -= offset;
			}
			else if (dateTime.Kind == DateTimeKind.Local)
			{
				InvalidFormatForLocal(format, dateTime);
			}
			dtfi = DateTimeFormatInfo.InvariantInfo;
			break;
		case 'U':
			if (offset != NullOffset)
			{
				throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
			}
			dtfi = (DateTimeFormatInfo)dtfi.Clone();
			if (dtfi.Calendar.GetType() != typeof(GregorianCalendar))
			{
				dtfi.Calendar = GregorianCalendar.GetDefaultInstance();
			}
			dateTime = dateTime.ToUniversalTime();
			break;
		}
		format = GetRealFormat(format, dtfi);
		return format;
	}

	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi)
	{
		return Format(dateTime, format, dtfi, NullOffset);
	}

	internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset)
	{
		if (format == null || format.Length == 0)
		{
			bool flag = false;
			if (dateTime.Ticks < 864000000000L)
			{
				switch (dtfi.Calendar.ID)
				{
				case 3:
				case 4:
				case 6:
				case 8:
				case 13:
				case 22:
				case 23:
					flag = true;
					dtfi = DateTimeFormatInfo.InvariantInfo;
					break;
				}
			}
			format = ((offset == NullOffset) ? ((!flag) ? "G" : "s") : ((!flag) ? dtfi.DateTimeOffsetPattern : "yyyy'-'MM'-'ddTHH':'mm':'ss zzz"));
		}
		if (format.Length == 1)
		{
			switch (format[0])
			{
			case 'O':
			case 'o':
				return StringBuilderCache.GetStringAndRelease(FastFormatRoundtrip(dateTime, offset));
			case 'R':
			case 'r':
				return StringBuilderCache.GetStringAndRelease(FastFormatRfc1123(dateTime, offset, dtfi));
			}
			format = ExpandPredefinedFormat(format, ref dateTime, ref dtfi, ref offset);
		}
		return FormatCustomized(dateTime, format, dtfi, offset);
	}

	internal static StringBuilder FastFormatRfc1123(DateTime dateTime, TimeSpan offset, DateTimeFormatInfo dtfi)
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire(29);
		if (offset != NullOffset)
		{
			dateTime -= offset;
		}
		dateTime.GetDatePart(out var year, out var month, out var day);
		stringBuilder.Append(InvariantAbbreviatedDayNames[(int)dateTime.DayOfWeek]);
		stringBuilder.Append(',');
		stringBuilder.Append(' ');
		AppendNumber(stringBuilder, day, 2);
		stringBuilder.Append(' ');
		stringBuilder.Append(InvariantAbbreviatedMonthNames[month - 1]);
		stringBuilder.Append(' ');
		AppendNumber(stringBuilder, year, 4);
		stringBuilder.Append(' ');
		AppendHHmmssTimeOfDay(stringBuilder, dateTime);
		stringBuilder.Append(' ');
		stringBuilder.Append("GMT");
		return stringBuilder;
	}

	internal static StringBuilder FastFormatRoundtrip(DateTime dateTime, TimeSpan offset)
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire(28);
		dateTime.GetDatePart(out var year, out var month, out var day);
		AppendNumber(stringBuilder, year, 4);
		stringBuilder.Append('-');
		AppendNumber(stringBuilder, month, 2);
		stringBuilder.Append('-');
		AppendNumber(stringBuilder, day, 2);
		stringBuilder.Append('T');
		AppendHHmmssTimeOfDay(stringBuilder, dateTime);
		stringBuilder.Append('.');
		long val = dateTime.Ticks % 10000000;
		AppendNumber(stringBuilder, val, 7);
		FormatCustomizedRoundripTimeZone(dateTime, offset, stringBuilder);
		return stringBuilder;
	}

	private static void AppendHHmmssTimeOfDay(StringBuilder result, DateTime dateTime)
	{
		AppendNumber(result, dateTime.Hour, 2);
		result.Append(':');
		AppendNumber(result, dateTime.Minute, 2);
		result.Append(':');
		AppendNumber(result, dateTime.Second, 2);
	}

	internal static void AppendNumber(StringBuilder builder, long val, int digits)
	{
		for (int i = 0; i < digits; i++)
		{
			builder.Append('0');
		}
		int num = 1;
		while (val > 0 && num <= digits)
		{
			builder[builder.Length - num] = (char)(48 + val % 10);
			val /= 10;
			num++;
		}
	}

	internal static string[] GetAllDateTimes(DateTime dateTime, char format, DateTimeFormatInfo dtfi)
	{
		string[] array = null;
		string[] array2 = null;
		switch (format)
		{
		case 'D':
		case 'F':
		case 'G':
		case 'M':
		case 'T':
		case 'Y':
		case 'd':
		case 'f':
		case 'g':
		case 'm':
		case 't':
		case 'y':
		{
			array = dtfi.GetAllDateTimePatterns(format);
			array2 = new string[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				array2[j] = Format(dateTime, array[j], dtfi);
			}
			break;
		}
		case 'U':
		{
			DateTime dateTime2 = dateTime.ToUniversalTime();
			array = dtfi.GetAllDateTimePatterns(format);
			array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Format(dateTime2, array[i], dtfi);
			}
			break;
		}
		case 'O':
		case 'R':
		case 'o':
		case 'r':
		case 's':
		case 'u':
			array2 = new string[1] { Format(dateTime, new string(new char[1] { format }), dtfi) };
			break;
		default:
			throw new FormatException(Environment.GetResourceString("Format_InvalidString"));
		}
		return array2;
	}

	internal static string[] GetAllDateTimes(DateTime dateTime, DateTimeFormatInfo dtfi)
	{
		List<string> list = new List<string>(132);
		for (int i = 0; i < allStandardFormats.Length; i++)
		{
			string[] allDateTimes = GetAllDateTimes(dateTime, allStandardFormats[i], dtfi);
			for (int j = 0; j < allDateTimes.Length; j++)
			{
				list.Add(allDateTimes[j]);
			}
		}
		string[] array = new string[list.Count];
		list.CopyTo(0, array, 0, list.Count);
		return array;
	}

	internal static void InvalidFormatForLocal(string format, DateTime dateTime)
	{
	}

	[SecuritySafeCritical]
	internal static void InvalidFormatForUtc(string format, DateTime dateTime)
	{
		Mda.DateTimeInvalidLocalFormat();
	}
}

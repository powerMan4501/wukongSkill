using System.Collections.Generic;
using System.Globalization;

namespace System.Net.Mime;

internal class SmtpDateTime
{
	internal const string unknownTimeZoneDefaultOffset = "-0000";

	internal const string utcDefaultTimeZoneOffset = "+0000";

	internal const int offsetLength = 5;

	internal const int maxMinuteValue = 59;

	internal const string dateFormatWithDayOfWeek = "ddd, dd MMM yyyy HH:mm:ss";

	internal const string dateFormatWithoutDayOfWeek = "dd MMM yyyy HH:mm:ss";

	internal const string dateFormatWithDayOfWeekAndNoSeconds = "ddd, dd MMM yyyy HH:mm";

	internal const string dateFormatWithoutDayOfWeekAndNoSeconds = "dd MMM yyyy HH:mm";

	internal static readonly string[] validDateTimeFormats = new string[4] { "ddd, dd MMM yyyy HH:mm:ss", "dd MMM yyyy HH:mm:ss", "ddd, dd MMM yyyy HH:mm", "dd MMM yyyy HH:mm" };

	internal static readonly char[] allowedWhiteSpaceChars = new char[2] { ' ', '\t' };

	internal static readonly IDictionary<string, TimeSpan> timeZoneOffsetLookup = InitializeShortHandLookups();

	internal static readonly long timeSpanMaxTicks = 3599400000000L;

	internal static readonly int offsetMaxValue = 9959;

	private readonly DateTime date;

	private readonly TimeSpan timeZone;

	private readonly bool unknownTimeZone;

	internal DateTime Date
	{
		get
		{
			if (unknownTimeZone)
			{
				return DateTime.SpecifyKind(date, DateTimeKind.Unspecified);
			}
			return new DateTimeOffset(date, timeZone).LocalDateTime;
		}
	}

	internal static IDictionary<string, TimeSpan> InitializeShortHandLookups()
	{
		Dictionary<string, TimeSpan> dictionary = new Dictionary<string, TimeSpan>();
		dictionary.Add("UT", TimeSpan.Zero);
		dictionary.Add("GMT", TimeSpan.Zero);
		dictionary.Add("EDT", new TimeSpan(-4, 0, 0));
		dictionary.Add("EST", new TimeSpan(-5, 0, 0));
		dictionary.Add("CDT", new TimeSpan(-5, 0, 0));
		dictionary.Add("CST", new TimeSpan(-6, 0, 0));
		dictionary.Add("MDT", new TimeSpan(-6, 0, 0));
		dictionary.Add("MST", new TimeSpan(-7, 0, 0));
		dictionary.Add("PDT", new TimeSpan(-7, 0, 0));
		dictionary.Add("PST", new TimeSpan(-8, 0, 0));
		return dictionary;
	}

	internal SmtpDateTime(DateTime value)
	{
		date = value;
		switch (value.Kind)
		{
		case DateTimeKind.Local:
		{
			TimeSpan utcOffset = TimeZoneInfo.Local.GetUtcOffset(value);
			timeZone = ValidateAndGetSanitizedTimeSpan(utcOffset);
			break;
		}
		case DateTimeKind.Unspecified:
			unknownTimeZone = true;
			break;
		case DateTimeKind.Utc:
			timeZone = TimeSpan.Zero;
			break;
		}
	}

	internal SmtpDateTime(string value)
	{
		date = ParseValue(value, out var timeZoneString);
		if (!TryParseTimeZoneString(timeZoneString, out timeZone))
		{
			unknownTimeZone = true;
		}
	}

	public override string ToString()
	{
		if (unknownTimeZone)
		{
			return string.Format("{0} {1}", FormatDate(date), "-0000");
		}
		return $"{FormatDate(date)} {TimeSpanToOffset(timeZone)}";
	}

	internal void ValidateAndGetTimeZoneOffsetValues(string offset, out bool positive, out int hours, out int minutes)
	{
		if (offset.Length != 5)
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		positive = offset.StartsWith("+");
		if (!int.TryParse(offset.Substring(1, 2), NumberStyles.None, CultureInfo.InvariantCulture, out hours))
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		if (!int.TryParse(offset.Substring(3, 2), NumberStyles.None, CultureInfo.InvariantCulture, out minutes))
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		if (minutes > 59)
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
	}

	internal void ValidateTimeZoneShortHandValue(string value)
	{
		for (int i = 0; i < value.Length; i++)
		{
			if (!char.IsLetter(value, i))
			{
				throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter"));
			}
		}
	}

	internal string FormatDate(DateTime value)
	{
		return value.ToString("ddd, dd MMM yyyy HH:mm:ss", CultureInfo.InvariantCulture);
	}

	internal DateTime ParseValue(string data, out string timeZone)
	{
		if (string.IsNullOrEmpty(data))
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		int num = data.IndexOf(':');
		if (num == -1)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter"));
		}
		int num2 = data.IndexOfAny(allowedWhiteSpaceChars, num);
		if (num2 == -1)
		{
			throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter"));
		}
		string s = data.Substring(0, num2).Trim();
		if (!DateTime.TryParseExact(s, validDateTimeFormats, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out var result))
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		string text = data.Substring(num2).Trim();
		int num3 = text.IndexOfAny(allowedWhiteSpaceChars);
		if (num3 != -1)
		{
			text = text.Substring(0, num3);
		}
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		timeZone = text;
		return result;
	}

	internal bool TryParseTimeZoneString(string timeZoneString, out TimeSpan timeZone)
	{
		timeZone = TimeSpan.Zero;
		if (timeZoneString == "-0000")
		{
			return false;
		}
		if (timeZoneString[0] == '+' || timeZoneString[0] == '-')
		{
			ValidateAndGetTimeZoneOffsetValues(timeZoneString, out var positive, out var hours, out var minutes);
			if (!positive)
			{
				if (hours != 0)
				{
					hours *= -1;
				}
				else if (minutes != 0)
				{
					minutes *= -1;
				}
			}
			timeZone = new TimeSpan(hours, minutes, 0);
			return true;
		}
		ValidateTimeZoneShortHandValue(timeZoneString);
		if (timeZoneOffsetLookup.ContainsKey(timeZoneString))
		{
			timeZone = timeZoneOffsetLookup[timeZoneString];
			return true;
		}
		return false;
	}

	internal TimeSpan ValidateAndGetSanitizedTimeSpan(TimeSpan span)
	{
		TimeSpan result = new TimeSpan(span.Days, span.Hours, span.Minutes, 0, 0);
		if (Math.Abs(result.Ticks) > timeSpanMaxTicks)
		{
			throw new FormatException(SR.GetString("MailDateInvalidFormat"));
		}
		return result;
	}

	internal string TimeSpanToOffset(TimeSpan span)
	{
		if (span.Ticks == 0L)
		{
			return "+0000";
		}
		uint num = (uint)Math.Abs(Math.Floor(span.TotalHours));
		uint num2 = (uint)Math.Abs(span.Minutes);
		string text = ((span.Ticks > 0) ? "+" : "-");
		if (num < 10)
		{
			text += "0";
		}
		text += num;
		if (num2 < 10)
		{
			text += "0";
		}
		return text + num2;
	}
}

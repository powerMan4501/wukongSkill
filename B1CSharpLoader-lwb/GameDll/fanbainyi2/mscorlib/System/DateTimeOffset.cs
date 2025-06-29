using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[StructLayout(LayoutKind.Auto)]
[__DynamicallyInvokable]
public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>
{
	internal const long MaxOffset = 504000000000L;

	internal const long MinOffset = -504000000000L;

	private const long UnixEpochTicks = 621355968000000000L;

	private const long UnixEpochSeconds = 62135596800L;

	private const long UnixEpochMilliseconds = 62135596800000L;

	[__DynamicallyInvokable]
	public static readonly DateTimeOffset MinValue = new DateTimeOffset(0L, TimeSpan.Zero);

	[__DynamicallyInvokable]
	public static readonly DateTimeOffset MaxValue = new DateTimeOffset(3155378975999999999L, TimeSpan.Zero);

	private DateTime m_dateTime;

	private short m_offsetMinutes;

	[__DynamicallyInvokable]
	public static DateTimeOffset Now
	{
		[__DynamicallyInvokable]
		get
		{
			return new DateTimeOffset(DateTime.Now);
		}
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset UtcNow
	{
		[__DynamicallyInvokable]
		get
		{
			return new DateTimeOffset(DateTime.UtcNow);
		}
	}

	[__DynamicallyInvokable]
	public DateTime DateTime
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime;
		}
	}

	[__DynamicallyInvokable]
	public DateTime UtcDateTime
	{
		[__DynamicallyInvokable]
		get
		{
			return DateTime.SpecifyKind(m_dateTime, DateTimeKind.Utc);
		}
	}

	[__DynamicallyInvokable]
	public DateTime LocalDateTime
	{
		[__DynamicallyInvokable]
		get
		{
			return UtcDateTime.ToLocalTime();
		}
	}

	private DateTime ClockDateTime => new DateTime((m_dateTime + Offset).Ticks, DateTimeKind.Unspecified);

	[__DynamicallyInvokable]
	public DateTime Date
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Date;
		}
	}

	[__DynamicallyInvokable]
	public int Day
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Day;
		}
	}

	[__DynamicallyInvokable]
	public DayOfWeek DayOfWeek
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.DayOfWeek;
		}
	}

	[__DynamicallyInvokable]
	public int DayOfYear
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.DayOfYear;
		}
	}

	[__DynamicallyInvokable]
	public int Hour
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Hour;
		}
	}

	[__DynamicallyInvokable]
	public int Millisecond
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Millisecond;
		}
	}

	[__DynamicallyInvokable]
	public int Minute
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Minute;
		}
	}

	[__DynamicallyInvokable]
	public int Month
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Month;
		}
	}

	[__DynamicallyInvokable]
	public TimeSpan Offset
	{
		[__DynamicallyInvokable]
		get
		{
			return new TimeSpan(0, m_offsetMinutes, 0);
		}
	}

	[__DynamicallyInvokable]
	public int Second
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Second;
		}
	}

	[__DynamicallyInvokable]
	public long Ticks
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Ticks;
		}
	}

	[__DynamicallyInvokable]
	public long UtcTicks
	{
		[__DynamicallyInvokable]
		get
		{
			return UtcDateTime.Ticks;
		}
	}

	[__DynamicallyInvokable]
	public TimeSpan TimeOfDay
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.TimeOfDay;
		}
	}

	[__DynamicallyInvokable]
	public int Year
	{
		[__DynamicallyInvokable]
		get
		{
			return ClockDateTime.Year;
		}
	}

	[__DynamicallyInvokable]
	public DateTimeOffset(long ticks, TimeSpan offset)
	{
		m_offsetMinutes = ValidateOffset(offset);
		DateTime dateTime = new DateTime(ticks);
		m_dateTime = ValidateDate(dateTime, offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset(DateTime dateTime)
	{
		TimeSpan offset = ((dateTime.Kind == DateTimeKind.Utc) ? new TimeSpan(0L) : TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime));
		m_offsetMinutes = ValidateOffset(offset);
		m_dateTime = ValidateDate(dateTime, offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset(DateTime dateTime, TimeSpan offset)
	{
		if (dateTime.Kind == DateTimeKind.Local)
		{
			if (offset != TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_OffsetLocalMismatch"), "offset");
			}
		}
		else if (dateTime.Kind == DateTimeKind.Utc && offset != TimeSpan.Zero)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetUtcMismatch"), "offset");
		}
		m_offsetMinutes = ValidateOffset(offset);
		m_dateTime = ValidateDate(dateTime, offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
	{
		m_offsetMinutes = ValidateOffset(offset);
		int num = second;
		if (second == 60 && DateTime.s_isLeapSecondsSupportedSystem)
		{
			second = 59;
		}
		m_dateTime = ValidateDate(new DateTime(year, month, day, hour, minute, second), offset);
		if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(m_dateTime.Year, m_dateTime.Month, m_dateTime.Day, m_dateTime.Hour, m_dateTime.Minute, 60, DateTimeKind.Utc))
		{
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond"));
		}
	}

	[__DynamicallyInvokable]
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
	{
		m_offsetMinutes = ValidateOffset(offset);
		int num = second;
		if (second == 60 && DateTime.s_isLeapSecondsSupportedSystem)
		{
			second = 59;
		}
		m_dateTime = ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond), offset);
		if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(m_dateTime.Year, m_dateTime.Month, m_dateTime.Day, m_dateTime.Hour, m_dateTime.Minute, 60, DateTimeKind.Utc))
		{
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond"));
		}
	}

	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
	{
		m_offsetMinutes = ValidateOffset(offset);
		int num = second;
		if (second == 60 && DateTime.s_isLeapSecondsSupportedSystem)
		{
			second = 59;
		}
		m_dateTime = ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond, calendar), offset);
		if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(m_dateTime.Year, m_dateTime.Month, m_dateTime.Day, m_dateTime.Hour, m_dateTime.Minute, 60, DateTimeKind.Utc))
		{
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond"));
		}
	}

	[__DynamicallyInvokable]
	public DateTimeOffset ToOffset(TimeSpan offset)
	{
		return new DateTimeOffset((m_dateTime + offset).Ticks, offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset Add(TimeSpan timeSpan)
	{
		return new DateTimeOffset(ClockDateTime.Add(timeSpan), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddDays(double days)
	{
		return new DateTimeOffset(ClockDateTime.AddDays(days), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddHours(double hours)
	{
		return new DateTimeOffset(ClockDateTime.AddHours(hours), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddMilliseconds(double milliseconds)
	{
		return new DateTimeOffset(ClockDateTime.AddMilliseconds(milliseconds), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddMinutes(double minutes)
	{
		return new DateTimeOffset(ClockDateTime.AddMinutes(minutes), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddMonths(int months)
	{
		return new DateTimeOffset(ClockDateTime.AddMonths(months), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddSeconds(double seconds)
	{
		return new DateTimeOffset(ClockDateTime.AddSeconds(seconds), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddTicks(long ticks)
	{
		return new DateTimeOffset(ClockDateTime.AddTicks(ticks), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset AddYears(int years)
	{
		return new DateTimeOffset(ClockDateTime.AddYears(years), Offset);
	}

	[__DynamicallyInvokable]
	public static int Compare(DateTimeOffset first, DateTimeOffset second)
	{
		return DateTime.Compare(first.UtcDateTime, second.UtcDateTime);
	}

	[__DynamicallyInvokable]
	int IComparable.CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is DateTimeOffset { UtcDateTime: var utcDateTime }))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDateTimeOffset"));
		}
		DateTime utcDateTime2 = UtcDateTime;
		if (utcDateTime2 > utcDateTime)
		{
			return 1;
		}
		if (utcDateTime2 < utcDateTime)
		{
			return -1;
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public int CompareTo(DateTimeOffset other)
	{
		DateTime utcDateTime = other.UtcDateTime;
		DateTime utcDateTime2 = UtcDateTime;
		if (utcDateTime2 > utcDateTime)
		{
			return 1;
		}
		if (utcDateTime2 < utcDateTime)
		{
			return -1;
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj is DateTimeOffset)
		{
			return UtcDateTime.Equals(((DateTimeOffset)obj).UtcDateTime);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Equals(DateTimeOffset other)
	{
		return UtcDateTime.Equals(other.UtcDateTime);
	}

	[__DynamicallyInvokable]
	public bool EqualsExact(DateTimeOffset other)
	{
		if (ClockDateTime == other.ClockDateTime && Offset == other.Offset)
		{
			return ClockDateTime.Kind == other.ClockDateTime.Kind;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool Equals(DateTimeOffset first, DateTimeOffset second)
	{
		return DateTime.Equals(first.UtcDateTime, second.UtcDateTime);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset FromFileTime(long fileTime)
	{
		return new DateTimeOffset(DateTime.FromFileTime(fileTime));
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset FromUnixTimeSeconds(long seconds)
	{
		if (seconds < -62135596800L || seconds > 253402300799L)
		{
			throw new ArgumentOutOfRangeException("seconds", string.Format(Environment.GetResourceString("ArgumentOutOfRange_Range"), -62135596800L, 253402300799L));
		}
		long ticks = seconds * 10000000 + 621355968000000000L;
		return new DateTimeOffset(ticks, TimeSpan.Zero);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds)
	{
		if (milliseconds < -62135596800000L || milliseconds > 253402300799999L)
		{
			throw new ArgumentOutOfRangeException("milliseconds", string.Format(Environment.GetResourceString("ArgumentOutOfRange_Range"), -62135596800000L, 253402300799999L));
		}
		long ticks = milliseconds * 10000 + 621355968000000000L;
		return new DateTimeOffset(ticks, TimeSpan.Zero);
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		try
		{
			m_offsetMinutes = ValidateOffset(Offset);
			m_dateTime = ValidateDate(ClockDateTime, Offset);
		}
		catch (ArgumentException innerException)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
		}
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("DateTime", m_dateTime);
		info.AddValue("OffsetMinutes", m_offsetMinutes);
	}

	private DateTimeOffset(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_dateTime = (DateTime)info.GetValue("DateTime", typeof(DateTime));
		m_offsetMinutes = (short)info.GetValue("OffsetMinutes", typeof(short));
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return UtcDateTime.GetHashCode();
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset Parse(string input)
	{
		TimeSpan offset;
		return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out offset).Ticks, offset);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
	{
		return Parse(input, formatProvider, DateTimeStyles.None);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
	{
		styles = ValidateStyles(styles, "styles");
		TimeSpan offset;
		return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider)
	{
		return ParseExact(input, format, formatProvider, DateTimeStyles.None);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
	{
		styles = ValidateStyles(styles, "styles");
		TimeSpan offset;
		return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset ParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles)
	{
		styles = ValidateStyles(styles, "styles");
		TimeSpan offset;
		return new DateTimeOffset(DateTimeParse.ParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
	}

	[__DynamicallyInvokable]
	public TimeSpan Subtract(DateTimeOffset value)
	{
		return UtcDateTime.Subtract(value.UtcDateTime);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset Subtract(TimeSpan value)
	{
		return new DateTimeOffset(ClockDateTime.Subtract(value), Offset);
	}

	[__DynamicallyInvokable]
	public long ToFileTime()
	{
		return UtcDateTime.ToFileTime();
	}

	[__DynamicallyInvokable]
	public long ToUnixTimeSeconds()
	{
		long num = UtcDateTime.Ticks / 10000000;
		return num - 62135596800L;
	}

	[__DynamicallyInvokable]
	public long ToUnixTimeMilliseconds()
	{
		long num = UtcDateTime.Ticks / 10000;
		return num - 62135596800000L;
	}

	[__DynamicallyInvokable]
	public DateTimeOffset ToLocalTime()
	{
		return ToLocalTime(throwOnOverflow: false);
	}

	internal DateTimeOffset ToLocalTime(bool throwOnOverflow)
	{
		return new DateTimeOffset(UtcDateTime.ToLocalTime(throwOnOverflow));
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return DateTimeFormat.Format(ClockDateTime, null, DateTimeFormatInfo.CurrentInfo, Offset);
	}

	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return DateTimeFormat.Format(ClockDateTime, format, DateTimeFormatInfo.CurrentInfo, Offset);
	}

	[__DynamicallyInvokable]
	public string ToString(IFormatProvider formatProvider)
	{
		return DateTimeFormat.Format(ClockDateTime, null, DateTimeFormatInfo.GetInstance(formatProvider), Offset);
	}

	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return DateTimeFormat.Format(ClockDateTime, format, DateTimeFormatInfo.GetInstance(formatProvider), Offset);
	}

	[__DynamicallyInvokable]
	public DateTimeOffset ToUniversalTime()
	{
		return new DateTimeOffset(UtcDateTime);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string input, out DateTimeOffset result)
	{
		DateTime result3;
		TimeSpan offset;
		bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result3, out offset);
		result = new DateTimeOffset(result3.Ticks, offset);
		return result2;
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		styles = ValidateStyles(styles, "styles");
		DateTime result3;
		TimeSpan offset;
		bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out result3, out offset);
		result = new DateTimeOffset(result3.Ticks, offset);
		return result2;
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		styles = ValidateStyles(styles, "styles");
		DateTime result3;
		TimeSpan offset;
		bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out result3, out offset);
		result = new DateTimeOffset(result3.Ticks, offset);
		return result2;
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		styles = ValidateStyles(styles, "styles");
		DateTime result3;
		TimeSpan offset;
		bool result2 = DateTimeParse.TryParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out result3, out offset);
		result = new DateTimeOffset(result3.Ticks, offset);
		return result2;
	}

	private static short ValidateOffset(TimeSpan offset)
	{
		long ticks = offset.Ticks;
		if (ticks % 600000000 != 0L)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_OffsetPrecision"), "offset");
		}
		if (ticks < -504000000000L || ticks > 504000000000L)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("Argument_OffsetOutOfRange"));
		}
		return (short)(offset.Ticks / 600000000);
	}

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
	{
		long num = dateTime.Ticks - offset.Ticks;
		if (num < 0 || num > 3155378975999999999L)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("Argument_UTCOutOfRange"));
		}
		return new DateTime(num, DateTimeKind.Unspecified);
	}

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
	{
		if ((style & ~(DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDateTimeStyles"), parameterName);
		}
		if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ConflictingDateTimeStyles"), parameterName);
		}
		if ((style & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeOffsetInvalidDateTimeStyles"), parameterName);
		}
		style &= ~DateTimeStyles.RoundtripKind;
		style &= ~DateTimeStyles.AssumeLocal;
		return style;
	}

	[__DynamicallyInvokable]
	public static implicit operator DateTimeOffset(DateTime dateTime)
	{
		return new DateTimeOffset(dateTime);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
	{
		return new DateTimeOffset(dateTimeOffset.ClockDateTime + timeSpan, dateTimeOffset.Offset);
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
	{
		return new DateTimeOffset(dateTimeOffset.ClockDateTime - timeSpan, dateTimeOffset.Offset);
	}

	[__DynamicallyInvokable]
	public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime - right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime == right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime != right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator <(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime < right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator <=(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime <= right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator >(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime > right.UtcDateTime;
	}

	[__DynamicallyInvokable]
	public static bool operator >=(DateTimeOffset left, DateTimeOffset right)
	{
		return left.UtcDateTime >= right.UtcDateTime;
	}
}

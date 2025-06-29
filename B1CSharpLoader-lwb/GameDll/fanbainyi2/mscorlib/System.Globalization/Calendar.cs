using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class Calendar : ICloneable
{
	internal const long TicksPerMillisecond = 10000L;

	internal const long TicksPerSecond = 10000000L;

	internal const long TicksPerMinute = 600000000L;

	internal const long TicksPerHour = 36000000000L;

	internal const long TicksPerDay = 864000000000L;

	internal const int MillisPerSecond = 1000;

	internal const int MillisPerMinute = 60000;

	internal const int MillisPerHour = 3600000;

	internal const int MillisPerDay = 86400000;

	internal const int DaysPerYear = 365;

	internal const int DaysPer4Years = 1461;

	internal const int DaysPer100Years = 36524;

	internal const int DaysPer400Years = 146097;

	internal const int DaysTo10000 = 3652059;

	internal const long MaxMillis = 315537897600000L;

	internal const int CAL_GREGORIAN = 1;

	internal const int CAL_GREGORIAN_US = 2;

	internal const int CAL_JAPAN = 3;

	internal const int CAL_TAIWAN = 4;

	internal const int CAL_KOREA = 5;

	internal const int CAL_HIJRI = 6;

	internal const int CAL_THAI = 7;

	internal const int CAL_HEBREW = 8;

	internal const int CAL_GREGORIAN_ME_FRENCH = 9;

	internal const int CAL_GREGORIAN_ARABIC = 10;

	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

	internal const int CAL_JULIAN = 13;

	internal const int CAL_JAPANESELUNISOLAR = 14;

	internal const int CAL_CHINESELUNISOLAR = 15;

	internal const int CAL_SAKA = 16;

	internal const int CAL_LUNAR_ETO_CHN = 17;

	internal const int CAL_LUNAR_ETO_KOR = 18;

	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

	internal const int CAL_KOREANLUNISOLAR = 20;

	internal const int CAL_TAIWANLUNISOLAR = 21;

	internal const int CAL_PERSIAN = 22;

	internal const int CAL_UMALQURA = 23;

	internal int m_currentEraValue = -1;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	[__DynamicallyInvokable]
	public const int CurrentEra = 0;

	internal int twoDigitYearMax = -1;

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual DateTime MinSupportedDateTime
	{
		[__DynamicallyInvokable]
		get
		{
			return DateTime.MinValue;
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual DateTime MaxSupportedDateTime
	{
		[__DynamicallyInvokable]
		get
		{
			return DateTime.MaxValue;
		}
	}

	internal virtual int ID => -1;

	internal virtual int BaseCalendarID => ID;

	[ComVisible(false)]
	public virtual CalendarAlgorithmType AlgorithmType => CalendarAlgorithmType.Unknown;

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public bool IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return m_isReadOnly;
		}
	}

	internal virtual int CurrentEraValue
	{
		get
		{
			if (m_currentEraValue == -1)
			{
				m_currentEraValue = CalendarData.GetCalendarData(BaseCalendarID).iCurrentEra;
			}
			return m_currentEraValue;
		}
	}

	[__DynamicallyInvokable]
	public abstract int[] Eras
	{
		[__DynamicallyInvokable]
		get;
	}

	protected virtual int DaysInYearBeforeMinSupportedYear => 365;

	[__DynamicallyInvokable]
	public virtual int TwoDigitYearMax
	{
		[__DynamicallyInvokable]
		get
		{
			return twoDigitYearMax;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			twoDigitYearMax = value;
		}
	}

	[__DynamicallyInvokable]
	protected Calendar()
	{
	}

	[ComVisible(false)]
	public virtual object Clone()
	{
		object obj = MemberwiseClone();
		((Calendar)obj).SetReadOnlyState(readOnly: false);
		return obj;
	}

	[ComVisible(false)]
	public static Calendar ReadOnly(Calendar calendar)
	{
		if (calendar == null)
		{
			throw new ArgumentNullException("calendar");
		}
		if (calendar.IsReadOnly)
		{
			return calendar;
		}
		Calendar calendar2 = (Calendar)calendar.MemberwiseClone();
		calendar2.SetReadOnlyState(readOnly: true);
		return calendar2;
	}

	internal void VerifyWritable()
	{
		if (m_isReadOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
		}
	}

	internal void SetReadOnlyState(bool readOnly)
	{
		m_isReadOnly = readOnly;
	}

	internal static void CheckAddResult(long ticks, DateTime minValue, DateTime maxValue)
	{
		if (ticks < minValue.Ticks || ticks > maxValue.Ticks)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("Argument_ResultCalendarRange"), minValue, maxValue));
		}
	}

	internal DateTime Add(DateTime time, double value, int scale)
	{
		double num = value * (double)scale + ((value >= 0.0) ? 0.5 : (-0.5));
		if (!(num > -315537897600000.0) || !(num < 315537897600000.0))
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_AddValue"));
		}
		long num2 = (long)num;
		long ticks = time.Ticks + num2 * 10000;
		CheckAddResult(ticks, MinSupportedDateTime, MaxSupportedDateTime);
		return new DateTime(ticks);
	}

	[__DynamicallyInvokable]
	public virtual DateTime AddMilliseconds(DateTime time, double milliseconds)
	{
		return Add(time, milliseconds, 1);
	}

	[__DynamicallyInvokable]
	public virtual DateTime AddDays(DateTime time, int days)
	{
		return Add(time, days, 86400000);
	}

	[__DynamicallyInvokable]
	public virtual DateTime AddHours(DateTime time, int hours)
	{
		return Add(time, hours, 3600000);
	}

	[__DynamicallyInvokable]
	public virtual DateTime AddMinutes(DateTime time, int minutes)
	{
		return Add(time, minutes, 60000);
	}

	[__DynamicallyInvokable]
	public abstract DateTime AddMonths(DateTime time, int months);

	[__DynamicallyInvokable]
	public virtual DateTime AddSeconds(DateTime time, int seconds)
	{
		return Add(time, seconds, 1000);
	}

	[__DynamicallyInvokable]
	public virtual DateTime AddWeeks(DateTime time, int weeks)
	{
		return AddDays(time, weeks * 7);
	}

	[__DynamicallyInvokable]
	public abstract DateTime AddYears(DateTime time, int years);

	[__DynamicallyInvokable]
	public abstract int GetDayOfMonth(DateTime time);

	[__DynamicallyInvokable]
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	[__DynamicallyInvokable]
	public abstract int GetDayOfYear(DateTime time);

	[__DynamicallyInvokable]
	public virtual int GetDaysInMonth(int year, int month)
	{
		return GetDaysInMonth(year, month, 0);
	}

	[__DynamicallyInvokable]
	public abstract int GetDaysInMonth(int year, int month, int era);

	[__DynamicallyInvokable]
	public virtual int GetDaysInYear(int year)
	{
		return GetDaysInYear(year, 0);
	}

	[__DynamicallyInvokable]
	public abstract int GetDaysInYear(int year, int era);

	[__DynamicallyInvokable]
	public abstract int GetEra(DateTime time);

	[__DynamicallyInvokable]
	public virtual int GetHour(DateTime time)
	{
		return (int)(time.Ticks / 36000000000L % 24);
	}

	[__DynamicallyInvokable]
	public virtual double GetMilliseconds(DateTime time)
	{
		return time.Ticks / 10000 % 1000;
	}

	[__DynamicallyInvokable]
	public virtual int GetMinute(DateTime time)
	{
		return (int)(time.Ticks / 600000000 % 60);
	}

	[__DynamicallyInvokable]
	public abstract int GetMonth(DateTime time);

	[__DynamicallyInvokable]
	public virtual int GetMonthsInYear(int year)
	{
		return GetMonthsInYear(year, 0);
	}

	[__DynamicallyInvokable]
	public abstract int GetMonthsInYear(int year, int era);

	[__DynamicallyInvokable]
	public virtual int GetSecond(DateTime time)
	{
		return (int)(time.Ticks / 10000000 % 60);
	}

	internal int GetFirstDayWeekOfYear(DateTime time, int firstDayOfWeek)
	{
		int num = GetDayOfYear(time) - 1;
		int num2 = (int)(GetDayOfWeek(time) - num % 7);
		int num3 = (num2 - firstDayOfWeek + 14) % 7;
		return (num + num3) / 7 + 1;
	}

	private int GetWeekOfYearFullDays(DateTime time, int firstDayOfWeek, int fullDays)
	{
		int num = GetDayOfYear(time) - 1;
		int num2 = (int)(GetDayOfWeek(time) - num % 7);
		int num3 = (firstDayOfWeek - num2 + 14) % 7;
		if (num3 != 0 && num3 >= fullDays)
		{
			num3 -= 7;
		}
		int num4 = num - num3;
		if (num4 >= 0)
		{
			return num4 / 7 + 1;
		}
		if (time <= MinSupportedDateTime.AddDays(num))
		{
			return GetWeekOfYearOfMinSupportedDateTime(firstDayOfWeek, fullDays);
		}
		return GetWeekOfYearFullDays(time.AddDays(-(num + 1)), firstDayOfWeek, fullDays);
	}

	private int GetWeekOfYearOfMinSupportedDateTime(int firstDayOfWeek, int minimumDaysInFirstWeek)
	{
		int num = GetDayOfYear(MinSupportedDateTime) - 1;
		int num2 = (int)(GetDayOfWeek(MinSupportedDateTime) - num % 7);
		int num3 = (firstDayOfWeek + 7 - num2) % 7;
		if (num3 == 0 || num3 >= minimumDaysInFirstWeek)
		{
			return 1;
		}
		int num4 = DaysInYearBeforeMinSupportedYear - 1;
		int num5 = num2 - 1 - num4 % 7;
		int num6 = (firstDayOfWeek - num5 + 14) % 7;
		int num7 = num4 - num6;
		if (num6 >= minimumDaysInFirstWeek)
		{
			num7 += 7;
		}
		return num7 / 7 + 1;
	}

	[__DynamicallyInvokable]
	public virtual int GetWeekOfYear(DateTime time, CalendarWeekRule rule, DayOfWeek firstDayOfWeek)
	{
		if (firstDayOfWeek < DayOfWeek.Sunday || firstDayOfWeek > DayOfWeek.Saturday)
		{
			throw new ArgumentOutOfRangeException("firstDayOfWeek", Environment.GetResourceString("ArgumentOutOfRange_Range", DayOfWeek.Sunday, DayOfWeek.Saturday));
		}
		return rule switch
		{
			CalendarWeekRule.FirstDay => GetFirstDayWeekOfYear(time, (int)firstDayOfWeek), 
			CalendarWeekRule.FirstFullWeek => GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 7), 
			CalendarWeekRule.FirstFourDayWeek => GetWeekOfYearFullDays(time, (int)firstDayOfWeek, 4), 
			_ => throw new ArgumentOutOfRangeException("rule", Environment.GetResourceString("ArgumentOutOfRange_Range", CalendarWeekRule.FirstDay, CalendarWeekRule.FirstFourDayWeek)), 
		};
	}

	[__DynamicallyInvokable]
	public abstract int GetYear(DateTime time);

	[__DynamicallyInvokable]
	public virtual bool IsLeapDay(int year, int month, int day)
	{
		return IsLeapDay(year, month, day, 0);
	}

	[__DynamicallyInvokable]
	public abstract bool IsLeapDay(int year, int month, int day, int era);

	[__DynamicallyInvokable]
	public virtual bool IsLeapMonth(int year, int month)
	{
		return IsLeapMonth(year, month, 0);
	}

	[__DynamicallyInvokable]
	public abstract bool IsLeapMonth(int year, int month, int era);

	[ComVisible(false)]
	public virtual int GetLeapMonth(int year)
	{
		return GetLeapMonth(year, 0);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual int GetLeapMonth(int year, int era)
	{
		if (!IsLeapYear(year, era))
		{
			return 0;
		}
		int monthsInYear = GetMonthsInYear(year, era);
		for (int i = 1; i <= monthsInYear; i++)
		{
			if (IsLeapMonth(year, i, era))
			{
				return i;
			}
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public virtual bool IsLeapYear(int year)
	{
		return IsLeapYear(year, 0);
	}

	[__DynamicallyInvokable]
	public abstract bool IsLeapYear(int year, int era);

	[__DynamicallyInvokable]
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
	{
		return ToDateTime(year, month, day, hour, minute, second, millisecond, 0);
	}

	[__DynamicallyInvokable]
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
	{
		result = DateTime.MinValue;
		try
		{
			result = ToDateTime(year, month, day, hour, minute, second, millisecond, era);
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	internal virtual bool IsValidYear(int year, int era)
	{
		if (year >= GetYear(MinSupportedDateTime))
		{
			return year <= GetYear(MaxSupportedDateTime);
		}
		return false;
	}

	internal virtual bool IsValidMonth(int year, int month, int era)
	{
		if (IsValidYear(year, era) && month >= 1)
		{
			return month <= GetMonthsInYear(year, era);
		}
		return false;
	}

	internal virtual bool IsValidDay(int year, int month, int day, int era)
	{
		if (IsValidMonth(year, month, era) && day >= 1)
		{
			return day <= GetDaysInMonth(year, month, era);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public virtual int ToFourDigitYear(int year)
	{
		if (year < 0)
		{
			throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (year < 100)
		{
			return (TwoDigitYearMax / 100 - ((year > TwoDigitYearMax % 100) ? 1 : 0)) * 100 + year;
		}
		return year;
	}

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
	{
		if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
		{
			if (millisecond < 0 || millisecond >= 1000)
			{
				throw new ArgumentOutOfRangeException("millisecond", string.Format(CultureInfo.InvariantCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 999));
			}
			return TimeSpan.TimeToTicks(hour, minute, second) + (long)millisecond * 10000L;
		}
		throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond"));
	}

	[SecuritySafeCritical]
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
	{
		int num = CalendarData.nativeGetTwoDigitYearMax(CalID);
		if (num < 0)
		{
			num = defaultYearValue;
		}
		return num;
	}
}

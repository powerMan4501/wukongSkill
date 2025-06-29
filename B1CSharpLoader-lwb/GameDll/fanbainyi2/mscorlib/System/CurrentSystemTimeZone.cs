using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

namespace System;

[Serializable]
internal class CurrentSystemTimeZone : TimeZone
{
	private const long TicksPerMillisecond = 10000L;

	private const long TicksPerSecond = 10000000L;

	private const long TicksPerMinute = 600000000L;

	private Hashtable m_CachedDaylightChanges = new Hashtable();

	private long m_ticksOffset;

	private string m_standardName;

	private string m_daylightName;

	private static object s_InternalSyncObject;

	public override string StandardName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_standardName == null)
			{
				m_standardName = nativeGetStandardName();
			}
			return m_standardName;
		}
	}

	public override string DaylightName
	{
		[SecuritySafeCritical]
		get
		{
			if (m_daylightName == null)
			{
				m_daylightName = nativeGetDaylightName();
				if (m_daylightName == null)
				{
					m_daylightName = StandardName;
				}
			}
			return m_daylightName;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange<object>(ref s_InternalSyncObject, value, (object)null);
			}
			return s_InternalSyncObject;
		}
	}

	[SecuritySafeCritical]
	internal CurrentSystemTimeZone()
	{
		m_ticksOffset = (long)nativeGetTimeZoneMinuteOffset() * 600000000L;
		m_standardName = null;
		m_daylightName = null;
	}

	internal long GetUtcOffsetFromUniversalTime(DateTime time, ref bool isAmbiguousLocalDst)
	{
		TimeSpan timeSpan = new TimeSpan(m_ticksOffset);
		DaylightTime daylightChanges = GetDaylightChanges(time.Year);
		isAmbiguousLocalDst = false;
		if (daylightChanges == null || daylightChanges.Delta.Ticks == 0L)
		{
			return timeSpan.Ticks;
		}
		DateTime dateTime = daylightChanges.Start - timeSpan;
		DateTime dateTime2 = daylightChanges.End - timeSpan - daylightChanges.Delta;
		DateTime dateTime3;
		DateTime dateTime4;
		if (daylightChanges.Delta.Ticks > 0)
		{
			dateTime3 = dateTime2 - daylightChanges.Delta;
			dateTime4 = dateTime2;
		}
		else
		{
			dateTime3 = dateTime;
			dateTime4 = dateTime - daylightChanges.Delta;
		}
		bool flag = false;
		if ((!(dateTime > dateTime2)) ? (time >= dateTime && time < dateTime2) : (time < dateTime2 || time >= dateTime))
		{
			timeSpan += daylightChanges.Delta;
			if (time >= dateTime3 && time < dateTime4)
			{
				isAmbiguousLocalDst = true;
			}
		}
		return timeSpan.Ticks;
	}

	public override DateTime ToLocalTime(DateTime time)
	{
		if (time.Kind == DateTimeKind.Local)
		{
			return time;
		}
		bool isAmbiguousLocalDst = false;
		long utcOffsetFromUniversalTime = GetUtcOffsetFromUniversalTime(time, ref isAmbiguousLocalDst);
		long num = time.Ticks + utcOffsetFromUniversalTime;
		if (num > 3155378975999999999L)
		{
			return new DateTime(3155378975999999999L, DateTimeKind.Local);
		}
		if (num < 0)
		{
			return new DateTime(0L, DateTimeKind.Local);
		}
		return new DateTime(num, DateTimeKind.Local, isAmbiguousLocalDst);
	}

	[SecuritySafeCritical]
	public override DaylightTime GetDaylightChanges(int year)
	{
		if (year < 1 || year > 9999)
		{
			throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("ArgumentOutOfRange_Range", 1, 9999));
		}
		object key = year;
		if (!m_CachedDaylightChanges.Contains(key))
		{
			lock (InternalSyncObject)
			{
				if (!m_CachedDaylightChanges.Contains(key))
				{
					short[] array = nativeGetDaylightChanges(year);
					if (array == null)
					{
						m_CachedDaylightChanges.Add(key, new DaylightTime(DateTime.MinValue, DateTime.MinValue, TimeSpan.Zero));
					}
					else
					{
						DateTime dayOfWeek = GetDayOfWeek(year, array[0] != 0, array[1], array[2], array[3], array[4], array[5], array[6], array[7]);
						DateTime dayOfWeek2 = GetDayOfWeek(year, array[8] != 0, array[9], array[10], array[11], array[12], array[13], array[14], array[15]);
						TimeSpan delta = new TimeSpan((long)array[16] * 600000000L);
						DaylightTime value = new DaylightTime(dayOfWeek, dayOfWeek2, delta);
						m_CachedDaylightChanges.Add(key, value);
					}
				}
			}
		}
		return (DaylightTime)m_CachedDaylightChanges[key];
	}

	public override TimeSpan GetUtcOffset(DateTime time)
	{
		if (time.Kind == DateTimeKind.Utc)
		{
			return TimeSpan.Zero;
		}
		return new TimeSpan(TimeZone.CalculateUtcOffset(time, GetDaylightChanges(time.Year)).Ticks + m_ticksOffset);
	}

	private static DateTime GetDayOfWeek(int year, bool fixedDate, int month, int targetDayOfWeek, int numberOfSunday, int hour, int minute, int second, int millisecond)
	{
		DateTime result;
		if (fixedDate)
		{
			int num = DateTime.DaysInMonth(year, month);
			result = new DateTime(year, month, (num < numberOfSunday) ? num : numberOfSunday, hour, minute, second, millisecond, DateTimeKind.Local);
		}
		else if (numberOfSunday <= 4)
		{
			result = new DateTime(year, month, 1, hour, minute, second, millisecond, DateTimeKind.Local);
			int dayOfWeek = (int)result.DayOfWeek;
			int num2 = targetDayOfWeek - dayOfWeek;
			if (num2 < 0)
			{
				num2 += 7;
			}
			num2 += 7 * (numberOfSunday - 1);
			if (num2 > 0)
			{
				return result.AddDays(num2);
			}
		}
		else
		{
			Calendar defaultInstance = GregorianCalendar.GetDefaultInstance();
			result = new DateTime(year, month, defaultInstance.GetDaysInMonth(year, month), hour, minute, second, millisecond, DateTimeKind.Local);
			int dayOfWeek2 = (int)result.DayOfWeek;
			int num3 = dayOfWeek2 - targetDayOfWeek;
			if (num3 < 0)
			{
				num3 += 7;
			}
			if (num3 > 0)
			{
				return result.AddDays(-num3);
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int nativeGetTimeZoneMinuteOffset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string nativeGetDaylightName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern string nativeGetStandardName();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern short[] nativeGetDaylightChanges(int year);
}

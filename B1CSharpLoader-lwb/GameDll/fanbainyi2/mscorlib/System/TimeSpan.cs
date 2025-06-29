using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable
{
	[__DynamicallyInvokable]
	public const long TicksPerMillisecond = 10000L;

	private const double MillisecondsPerTick = 0.0001;

	[__DynamicallyInvokable]
	public const long TicksPerSecond = 10000000L;

	private const double SecondsPerTick = 1E-07;

	[__DynamicallyInvokable]
	public const long TicksPerMinute = 600000000L;

	private const double MinutesPerTick = 1.6666666666666667E-09;

	[__DynamicallyInvokable]
	public const long TicksPerHour = 36000000000L;

	private const double HoursPerTick = 2.7777777777777777E-11;

	[__DynamicallyInvokable]
	public const long TicksPerDay = 864000000000L;

	private const double DaysPerTick = 1.1574074074074074E-12;

	private const int MillisPerSecond = 1000;

	private const int MillisPerMinute = 60000;

	private const int MillisPerHour = 3600000;

	private const int MillisPerDay = 86400000;

	internal const long MaxSeconds = 922337203685L;

	internal const long MinSeconds = -922337203685L;

	internal const long MaxMilliSeconds = 922337203685477L;

	internal const long MinMilliSeconds = -922337203685477L;

	internal const long TicksPerTenthSecond = 1000000L;

	[__DynamicallyInvokable]
	public static readonly TimeSpan Zero = new TimeSpan(0L);

	[__DynamicallyInvokable]
	public static readonly TimeSpan MaxValue = new TimeSpan(long.MaxValue);

	[__DynamicallyInvokable]
	public static readonly TimeSpan MinValue = new TimeSpan(long.MinValue);

	internal long _ticks;

	private static volatile bool _legacyConfigChecked;

	private static volatile bool _legacyMode;

	[__DynamicallyInvokable]
	public long Ticks
	{
		[__DynamicallyInvokable]
		get
		{
			return _ticks;
		}
	}

	[__DynamicallyInvokable]
	public int Days
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)(_ticks / 864000000000L);
		}
	}

	[__DynamicallyInvokable]
	public int Hours
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)(_ticks / 36000000000L % 24);
		}
	}

	[__DynamicallyInvokable]
	public int Milliseconds
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)(_ticks / 10000 % 1000);
		}
	}

	[__DynamicallyInvokable]
	public int Minutes
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)(_ticks / 600000000 % 60);
		}
	}

	[__DynamicallyInvokable]
	public int Seconds
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)(_ticks / 10000000 % 60);
		}
	}

	[__DynamicallyInvokable]
	public double TotalDays
	{
		[__DynamicallyInvokable]
		get
		{
			return (double)_ticks * 1.1574074074074074E-12;
		}
	}

	[__DynamicallyInvokable]
	public double TotalHours
	{
		[__DynamicallyInvokable]
		get
		{
			return (double)_ticks * 2.7777777777777777E-11;
		}
	}

	[__DynamicallyInvokable]
	public double TotalMilliseconds
	{
		[__DynamicallyInvokable]
		get
		{
			double num = (double)_ticks * 0.0001;
			if (num > 922337203685477.0)
			{
				return 922337203685477.0;
			}
			if (num < -922337203685477.0)
			{
				return -922337203685477.0;
			}
			return num;
		}
	}

	[__DynamicallyInvokable]
	public double TotalMinutes
	{
		[__DynamicallyInvokable]
		get
		{
			return (double)_ticks * 1.6666666666666667E-09;
		}
	}

	[__DynamicallyInvokable]
	public double TotalSeconds
	{
		[__DynamicallyInvokable]
		get
		{
			return (double)_ticks * 1E-07;
		}
	}

	private static bool LegacyMode
	{
		get
		{
			if (!_legacyConfigChecked)
			{
				_legacyMode = GetLegacyFormatMode();
				_legacyConfigChecked = true;
			}
			return _legacyMode;
		}
	}

	[__DynamicallyInvokable]
	public TimeSpan(long ticks)
	{
		_ticks = ticks;
	}

	[__DynamicallyInvokable]
	public TimeSpan(int hours, int minutes, int seconds)
	{
		_ticks = TimeToTicks(hours, minutes, seconds);
	}

	[__DynamicallyInvokable]
	public TimeSpan(int days, int hours, int minutes, int seconds)
		: this(days, hours, minutes, seconds, 0)
	{
	}

	[__DynamicallyInvokable]
	public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
	{
		long num = ((long)days * 3600L * 24 + (long)hours * 3600L + (long)minutes * 60L + seconds) * 1000 + milliseconds;
		if (num > 922337203685477L || num < -922337203685477L)
		{
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Overflow_TimeSpanTooLong"));
		}
		_ticks = num * 10000;
	}

	[__DynamicallyInvokable]
	public TimeSpan Add(TimeSpan ts)
	{
		long num = _ticks + ts._ticks;
		if (_ticks >> 63 == ts._ticks >> 63 && _ticks >> 63 != num >> 63)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
		}
		return new TimeSpan(num);
	}

	[__DynamicallyInvokable]
	public static int Compare(TimeSpan t1, TimeSpan t2)
	{
		if (t1._ticks > t2._ticks)
		{
			return 1;
		}
		if (t1._ticks < t2._ticks)
		{
			return -1;
		}
		return 0;
	}

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (!(value is TimeSpan))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeTimeSpan"));
		}
		long ticks = ((TimeSpan)value)._ticks;
		if (_ticks > ticks)
		{
			return 1;
		}
		if (_ticks < ticks)
		{
			return -1;
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public int CompareTo(TimeSpan value)
	{
		long ticks = value._ticks;
		if (_ticks > ticks)
		{
			return 1;
		}
		if (_ticks < ticks)
		{
			return -1;
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromDays(double value)
	{
		return Interval(value, 86400000);
	}

	[__DynamicallyInvokable]
	public TimeSpan Duration()
	{
		if (Ticks == MinValue.Ticks)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Duration"));
		}
		return new TimeSpan((_ticks >= 0) ? _ticks : (-_ticks));
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is TimeSpan)
		{
			return _ticks == ((TimeSpan)value)._ticks;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool Equals(TimeSpan obj)
	{
		return _ticks == obj._ticks;
	}

	[__DynamicallyInvokable]
	public static bool Equals(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks == t2._ticks;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return (int)_ticks ^ (int)(_ticks >> 32);
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromHours(double value)
	{
		return Interval(value, 3600000);
	}

	private static TimeSpan Interval(double value, int scale)
	{
		if (double.IsNaN(value))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_CannotBeNaN"));
		}
		double num = value * (double)scale;
		double num2 = num + ((value >= 0.0) ? 0.5 : (-0.5));
		if (num2 > 922337203685477.0 || num2 < -922337203685477.0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
		}
		return new TimeSpan((long)num2 * 10000);
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromMilliseconds(double value)
	{
		return Interval(value, 1);
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromMinutes(double value)
	{
		return Interval(value, 60000);
	}

	[__DynamicallyInvokable]
	public TimeSpan Negate()
	{
		if (Ticks == MinValue.Ticks)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_NegateTwosCompNum"));
		}
		return new TimeSpan(-_ticks);
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromSeconds(double value)
	{
		return Interval(value, 1000);
	}

	[__DynamicallyInvokable]
	public TimeSpan Subtract(TimeSpan ts)
	{
		long num = _ticks - ts._ticks;
		if (_ticks >> 63 != ts._ticks >> 63 && _ticks >> 63 != num >> 63)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_TimeSpanTooLong"));
		}
		return new TimeSpan(num);
	}

	[__DynamicallyInvokable]
	public static TimeSpan FromTicks(long value)
	{
		return new TimeSpan(value);
	}

	internal static long TimeToTicks(int hour, int minute, int second)
	{
		long num = (long)hour * 3600L + (long)minute * 60L + second;
		if (num > 922337203685L || num < -922337203685L)
		{
			throw new ArgumentOutOfRangeException(null, Environment.GetResourceString("Overflow_TimeSpanTooLong"));
		}
		return num * 10000000;
	}

	[__DynamicallyInvokable]
	public static TimeSpan Parse(string s)
	{
		return TimeSpanParse.Parse(s, null);
	}

	[__DynamicallyInvokable]
	public static TimeSpan Parse(string input, IFormatProvider formatProvider)
	{
		return TimeSpanParse.Parse(input, formatProvider);
	}

	[__DynamicallyInvokable]
	public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider)
	{
		return TimeSpanParse.ParseExact(input, format, formatProvider, TimeSpanStyles.None);
	}

	[__DynamicallyInvokable]
	public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider)
	{
		return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None);
	}

	[__DynamicallyInvokable]
	public static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		TimeSpanParse.ValidateStyles(styles, "styles");
		return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
	}

	[__DynamicallyInvokable]
	public static TimeSpan ParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		TimeSpanParse.ValidateStyles(styles, "styles");
		return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out TimeSpan result)
	{
		return TimeSpanParse.TryParse(s, null, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result)
	{
		return TimeSpanParse.TryParse(input, formatProvider, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result)
	{
		return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, out TimeSpan result)
	{
		return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		TimeSpanParse.ValidateStyles(styles, "styles");
		return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		TimeSpanParse.ValidateStyles(styles, "styles");
		return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return TimeSpanFormat.Format(this, null, null);
	}

	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return TimeSpanFormat.Format(this, format, null);
	}

	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		if (LegacyMode)
		{
			return TimeSpanFormat.Format(this, null, null);
		}
		return TimeSpanFormat.Format(this, format, formatProvider);
	}

	[__DynamicallyInvokable]
	public static TimeSpan operator -(TimeSpan t)
	{
		if (t._ticks == MinValue._ticks)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_NegateTwosCompNum"));
		}
		return new TimeSpan(-t._ticks);
	}

	[__DynamicallyInvokable]
	public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
	{
		return t1.Subtract(t2);
	}

	[__DynamicallyInvokable]
	public static TimeSpan operator +(TimeSpan t)
	{
		return t;
	}

	[__DynamicallyInvokable]
	public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
	{
		return t1.Add(t2);
	}

	[__DynamicallyInvokable]
	public static bool operator ==(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks == t2._ticks;
	}

	[__DynamicallyInvokable]
	public static bool operator !=(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks != t2._ticks;
	}

	[__DynamicallyInvokable]
	public static bool operator <(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks < t2._ticks;
	}

	[__DynamicallyInvokable]
	public static bool operator <=(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks <= t2._ticks;
	}

	[__DynamicallyInvokable]
	public static bool operator >(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks > t2._ticks;
	}

	[__DynamicallyInvokable]
	public static bool operator >=(TimeSpan t1, TimeSpan t2)
	{
		return t1._ticks >= t2._ticks;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool LegacyFormatMode();

	[SecuritySafeCritical]
	private static bool GetLegacyFormatMode()
	{
		if (LegacyFormatMode())
		{
			return true;
		}
		return CompatibilitySwitches.IsNetFx40TimeSpanLegacyFormatMode;
	}
}

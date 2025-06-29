using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using Microsoft.Win32;

namespace System;

[Serializable]
[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	private enum TimeZoneInfoResult
	{
		Success,
		TimeZoneNotFoundException,
		InvalidTimeZoneException,
		SecurityException
	}

	private class CachedData
	{
		private volatile TimeZoneInfo m_localTimeZone;

		private volatile TimeZoneInfo m_utcTimeZone;

		public Dictionary<string, TimeZoneInfo> m_systemTimeZones;

		public ReadOnlyCollection<TimeZoneInfo> m_readOnlySystemTimeZones;

		public bool m_allSystemTimeZonesRead;

		private volatile OffsetAndRule m_oneYearLocalFromUtc;

		public TimeZoneInfo Local
		{
			get
			{
				TimeZoneInfo timeZoneInfo = m_localTimeZone;
				if (timeZoneInfo == null)
				{
					timeZoneInfo = CreateLocal();
				}
				return timeZoneInfo;
			}
		}

		public TimeZoneInfo Utc
		{
			get
			{
				TimeZoneInfo timeZoneInfo = m_utcTimeZone;
				if (timeZoneInfo == null)
				{
					timeZoneInfo = CreateUtc();
				}
				return timeZoneInfo;
			}
		}

		private TimeZoneInfo CreateLocal()
		{
			lock (this)
			{
				TimeZoneInfo timeZoneInfo = m_localTimeZone;
				if (timeZoneInfo == null)
				{
					timeZoneInfo = GetLocalTimeZone(this);
					timeZoneInfo = (m_localTimeZone = new TimeZoneInfo(timeZoneInfo.m_id, timeZoneInfo.m_baseUtcOffset, timeZoneInfo.m_displayName, timeZoneInfo.m_standardDisplayName, timeZoneInfo.m_daylightDisplayName, timeZoneInfo.m_adjustmentRules, disableDaylightSavingTime: false));
				}
				return timeZoneInfo;
			}
		}

		private TimeZoneInfo CreateUtc()
		{
			lock (this)
			{
				TimeZoneInfo timeZoneInfo = m_utcTimeZone;
				if (timeZoneInfo == null)
				{
					timeZoneInfo = (m_utcTimeZone = CreateCustomTimeZone("UTC", TimeSpan.Zero, "UTC", "UTC"));
				}
				return timeZoneInfo;
			}
		}

		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
		{
			if (timeZone == m_utcTimeZone)
			{
				return DateTimeKind.Utc;
			}
			if (timeZone == m_localTimeZone)
			{
				return DateTimeKind.Local;
			}
			return DateTimeKind.Unspecified;
		}

		[SecuritySafeCritical]
		private static TimeZoneInfo GetCurrentOneYearLocal()
		{
			Win32Native.TimeZoneInformation lpTimeZoneInformation = default(Win32Native.TimeZoneInformation);
			long num = UnsafeNativeMethods.GetTimeZoneInformation(out lpTimeZoneInformation);
			if (num == -1)
			{
				return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
			}
			return GetLocalTimeZoneFromWin32Data(lpTimeZoneInformation, dstDisabled: false);
		}

		public OffsetAndRule GetOneYearLocalFromUtc(int year)
		{
			OffsetAndRule offsetAndRule = m_oneYearLocalFromUtc;
			if (offsetAndRule == null || offsetAndRule.year != year)
			{
				TimeZoneInfo currentOneYearLocal = GetCurrentOneYearLocal();
				AdjustmentRule rule = ((currentOneYearLocal.m_adjustmentRules == null) ? null : currentOneYearLocal.m_adjustmentRules[0]);
				offsetAndRule = (m_oneYearLocalFromUtc = new OffsetAndRule(year, currentOneYearLocal.BaseUtcOffset, rule));
			}
			return offsetAndRule;
		}
	}

	private class OffsetAndRule
	{
		public int year;

		public TimeSpan offset;

		public AdjustmentRule rule;

		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule)
		{
			this.year = year;
			this.offset = offset;
			this.rule = rule;
		}
	}

	[Serializable]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private DateTime m_dateStart;

		private DateTime m_dateEnd;

		private TimeSpan m_daylightDelta;

		private TransitionTime m_daylightTransitionStart;

		private TransitionTime m_daylightTransitionEnd;

		private TimeSpan m_baseUtcOffsetDelta;

		public DateTime DateStart => m_dateStart;

		public DateTime DateEnd => m_dateEnd;

		public TimeSpan DaylightDelta => m_daylightDelta;

		public TransitionTime DaylightTransitionStart => m_daylightTransitionStart;

		public TransitionTime DaylightTransitionEnd => m_daylightTransitionEnd;

		internal TimeSpan BaseUtcOffsetDelta => m_baseUtcOffsetDelta;

		internal bool HasDaylightSaving
		{
			get
			{
				if (!(DaylightDelta != TimeSpan.Zero) && !(DaylightTransitionStart.TimeOfDay != DateTime.MinValue))
				{
					return DaylightTransitionEnd.TimeOfDay != DateTime.MinValue.AddMilliseconds(1.0);
				}
				return true;
			}
		}

		public bool Equals(AdjustmentRule other)
		{
			return other != null && m_dateStart == other.m_dateStart && m_dateEnd == other.m_dateEnd && m_daylightDelta == other.m_daylightDelta && m_baseUtcOffsetDelta == other.m_baseUtcOffsetDelta && m_daylightTransitionEnd.Equals(other.m_daylightTransitionEnd) && m_daylightTransitionStart.Equals(other.m_daylightTransitionStart);
		}

		public override int GetHashCode()
		{
			return m_dateStart.GetHashCode();
		}

		private AdjustmentRule()
		{
		}

		public static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
		{
			ValidateAdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd);
			AdjustmentRule adjustmentRule = new AdjustmentRule();
			adjustmentRule.m_dateStart = dateStart;
			adjustmentRule.m_dateEnd = dateEnd;
			adjustmentRule.m_daylightDelta = daylightDelta;
			adjustmentRule.m_daylightTransitionStart = daylightTransitionStart;
			adjustmentRule.m_daylightTransitionEnd = daylightTransitionEnd;
			adjustmentRule.m_baseUtcOffsetDelta = TimeSpan.Zero;
			return adjustmentRule;
		}

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta)
		{
			AdjustmentRule adjustmentRule = CreateAdjustmentRule(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd);
			adjustmentRule.m_baseUtcOffsetDelta = baseUtcOffsetDelta;
			return adjustmentRule;
		}

		internal bool IsStartDateMarkerForBeginningOfYear()
		{
			if (DaylightTransitionStart.Month == 1 && DaylightTransitionStart.Day == 1 && DaylightTransitionStart.TimeOfDay.Hour == 0 && DaylightTransitionStart.TimeOfDay.Minute == 0 && DaylightTransitionStart.TimeOfDay.Second == 0)
			{
				return m_dateStart.Year == m_dateEnd.Year;
			}
			return false;
		}

		internal bool IsEndDateMarkerForEndOfYear()
		{
			if (DaylightTransitionEnd.Month == 1 && DaylightTransitionEnd.Day == 1 && DaylightTransitionEnd.TimeOfDay.Hour == 0 && DaylightTransitionEnd.TimeOfDay.Minute == 0 && DaylightTransitionEnd.TimeOfDay.Second == 0)
			{
				return m_dateStart.Year == m_dateEnd.Year;
			}
			return false;
		}

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd)
		{
			if (dateStart.Kind != DateTimeKind.Unspecified)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeKindMustBeUnspecified"), "dateStart");
			}
			if (dateEnd.Kind != DateTimeKind.Unspecified)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeKindMustBeUnspecified"), "dateEnd");
			}
			if (daylightTransitionStart.Equals(daylightTransitionEnd))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_TransitionTimesAreIdentical"), "daylightTransitionEnd");
			}
			if (dateStart > dateEnd)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_OutOfOrderDateTimes"), "dateStart");
			}
			if (UtcOffsetOutOfRange(daylightDelta))
			{
				throw new ArgumentOutOfRangeException("daylightDelta", daylightDelta, Environment.GetResourceString("ArgumentOutOfRange_UtcOffset"));
			}
			if (daylightDelta.Ticks % 600000000 != 0L)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_TimeSpanHasSeconds"), "daylightDelta");
			}
			if (dateStart.TimeOfDay != TimeSpan.Zero)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeHasTimeOfDay"), "dateStart");
			}
			if (dateEnd.TimeOfDay != TimeSpan.Zero)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeHasTimeOfDay"), "dateEnd");
			}
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				ValidateAdjustmentRule(m_dateStart, m_dateEnd, m_daylightDelta, m_daylightTransitionStart, m_daylightTransitionEnd);
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
			info.AddValue("DateStart", m_dateStart);
			info.AddValue("DateEnd", m_dateEnd);
			info.AddValue("DaylightDelta", m_daylightDelta);
			info.AddValue("DaylightTransitionStart", m_daylightTransitionStart);
			info.AddValue("DaylightTransitionEnd", m_daylightTransitionEnd);
			info.AddValue("BaseUtcOffsetDelta", m_baseUtcOffsetDelta);
		}

		private AdjustmentRule(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_dateStart = (DateTime)info.GetValue("DateStart", typeof(DateTime));
			m_dateEnd = (DateTime)info.GetValue("DateEnd", typeof(DateTime));
			m_daylightDelta = (TimeSpan)info.GetValue("DaylightDelta", typeof(TimeSpan));
			m_daylightTransitionStart = (TransitionTime)info.GetValue("DaylightTransitionStart", typeof(TransitionTime));
			m_daylightTransitionEnd = (TransitionTime)info.GetValue("DaylightTransitionEnd", typeof(TransitionTime));
			object valueNoThrow = info.GetValueNoThrow("BaseUtcOffsetDelta", typeof(TimeSpan));
			if (valueNoThrow != null)
			{
				m_baseUtcOffsetDelta = (TimeSpan)valueNoThrow;
			}
		}
	}

	[Serializable]
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private DateTime m_timeOfDay;

		private byte m_month;

		private byte m_week;

		private byte m_day;

		private DayOfWeek m_dayOfWeek;

		private bool m_isFixedDateRule;

		public DateTime TimeOfDay => m_timeOfDay;

		public int Month => m_month;

		public int Week => m_week;

		public int Day => m_day;

		public DayOfWeek DayOfWeek => m_dayOfWeek;

		public bool IsFixedDateRule => m_isFixedDateRule;

		public override bool Equals(object obj)
		{
			if (obj is TransitionTime)
			{
				return Equals((TransitionTime)obj);
			}
			return false;
		}

		public static bool operator ==(TransitionTime t1, TransitionTime t2)
		{
			return t1.Equals(t2);
		}

		public static bool operator !=(TransitionTime t1, TransitionTime t2)
		{
			return !t1.Equals(t2);
		}

		public bool Equals(TransitionTime other)
		{
			bool flag = m_isFixedDateRule == other.m_isFixedDateRule && m_timeOfDay == other.m_timeOfDay && m_month == other.m_month;
			if (flag)
			{
				flag = ((!other.m_isFixedDateRule) ? (m_week == other.m_week && m_dayOfWeek == other.m_dayOfWeek) : (m_day == other.m_day));
			}
			return flag;
		}

		public override int GetHashCode()
		{
			return m_month ^ (m_week << 8);
		}

		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			return CreateTransitionTime(timeOfDay, month, 1, day, DayOfWeek.Sunday, isFixedDateRule: true);
		}

		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			return CreateTransitionTime(timeOfDay, month, week, 1, dayOfWeek, isFixedDateRule: false);
		}

		private static TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
			ValidateTransitionTime(timeOfDay, month, week, day, dayOfWeek);
			return new TransitionTime
			{
				m_isFixedDateRule = isFixedDateRule,
				m_timeOfDay = timeOfDay,
				m_dayOfWeek = dayOfWeek,
				m_day = (byte)day,
				m_week = (byte)week,
				m_month = (byte)month
			};
		}

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
			if (timeOfDay.Kind != DateTimeKind.Unspecified)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeKindMustBeUnspecified"), "timeOfDay");
			}
			if (month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException("month", Environment.GetResourceString("ArgumentOutOfRange_MonthParam"));
			}
			if (day < 1 || day > 31)
			{
				throw new ArgumentOutOfRangeException("day", Environment.GetResourceString("ArgumentOutOfRange_DayParam"));
			}
			if (week < 1 || week > 5)
			{
				throw new ArgumentOutOfRangeException("week", Environment.GetResourceString("ArgumentOutOfRange_Week"));
			}
			if (dayOfWeek < DayOfWeek.Sunday || dayOfWeek > DayOfWeek.Saturday)
			{
				throw new ArgumentOutOfRangeException("dayOfWeek", Environment.GetResourceString("ArgumentOutOfRange_DayOfWeek"));
			}
			timeOfDay.GetDatePart(out var year, out var month2, out var day2);
			if (year != 1 || month2 != 1 || day2 != 1 || timeOfDay.Ticks % 10000 != 0L)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeHasTicks"), "timeOfDay");
			}
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				ValidateTransitionTime(m_timeOfDay, m_month, m_week, m_day, m_dayOfWeek);
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
			info.AddValue("TimeOfDay", m_timeOfDay);
			info.AddValue("Month", m_month);
			info.AddValue("Week", m_week);
			info.AddValue("Day", m_day);
			info.AddValue("DayOfWeek", m_dayOfWeek);
			info.AddValue("IsFixedDateRule", m_isFixedDateRule);
		}

		private TransitionTime(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			m_timeOfDay = (DateTime)info.GetValue("TimeOfDay", typeof(DateTime));
			m_month = (byte)info.GetValue("Month", typeof(byte));
			m_week = (byte)info.GetValue("Week", typeof(byte));
			m_day = (byte)info.GetValue("Day", typeof(byte));
			m_dayOfWeek = (DayOfWeek)info.GetValue("DayOfWeek", typeof(DayOfWeek));
			m_isFixedDateRule = (bool)info.GetValue("IsFixedDateRule", typeof(bool));
		}
	}

	private sealed class StringSerializer
	{
		private enum State
		{
			Escaped,
			NotEscaped,
			StartOfToken,
			EndOfLine
		}

		private string m_serializedText;

		private int m_currentTokenStartIndex;

		private State m_state;

		private const int initialCapacityForString = 64;

		private const char esc = '\\';

		private const char sep = ';';

		private const char lhs = '[';

		private const char rhs = ']';

		private const string escString = "\\";

		private const string sepString = ";";

		private const string lhsString = "[";

		private const string rhsString = "]";

		private const string escapedEsc = "\\\\";

		private const string escapedSep = "\\;";

		private const string escapedLhs = "\\[";

		private const string escapedRhs = "\\]";

		private const string dateTimeFormat = "MM:dd:yyyy";

		private const string timeOfDayFormat = "HH:mm:ss.FFF";

		public static string GetSerializedString(TimeZoneInfo zone)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire();
			stringBuilder.Append(SerializeSubstitute(zone.Id));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.BaseUtcOffset.TotalMinutes.ToString(CultureInfo.InvariantCulture)));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.DisplayName));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.StandardName));
			stringBuilder.Append(';');
			stringBuilder.Append(SerializeSubstitute(zone.DaylightName));
			stringBuilder.Append(';');
			AdjustmentRule[] adjustmentRules = zone.GetAdjustmentRules();
			if (adjustmentRules != null && adjustmentRules.Length != 0)
			{
				foreach (AdjustmentRule adjustmentRule in adjustmentRules)
				{
					stringBuilder.Append('[');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DateStart.ToString("MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo)));
					stringBuilder.Append(';');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DateEnd.ToString("MM:dd:yyyy", DateTimeFormatInfo.InvariantInfo)));
					stringBuilder.Append(';');
					stringBuilder.Append(SerializeSubstitute(adjustmentRule.DaylightDelta.TotalMinutes.ToString(CultureInfo.InvariantCulture)));
					stringBuilder.Append(';');
					SerializeTransitionTime(adjustmentRule.DaylightTransitionStart, stringBuilder);
					stringBuilder.Append(';');
					SerializeTransitionTime(adjustmentRule.DaylightTransitionEnd, stringBuilder);
					stringBuilder.Append(';');
					if (adjustmentRule.BaseUtcOffsetDelta != TimeSpan.Zero)
					{
						stringBuilder.Append(SerializeSubstitute(adjustmentRule.BaseUtcOffsetDelta.TotalMinutes.ToString(CultureInfo.InvariantCulture)));
						stringBuilder.Append(';');
					}
					stringBuilder.Append(']');
				}
			}
			stringBuilder.Append(';');
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		public static TimeZoneInfo GetDeserializedTimeZoneInfo(string source)
		{
			StringSerializer stringSerializer = new StringSerializer(source);
			string nextStringValue = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			TimeSpan nextTimeSpanValue = stringSerializer.GetNextTimeSpanValue(canEndWithoutSeparator: false);
			string nextStringValue2 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			string nextStringValue3 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			string nextStringValue4 = stringSerializer.GetNextStringValue(canEndWithoutSeparator: false);
			AdjustmentRule[] nextAdjustmentRuleArrayValue = stringSerializer.GetNextAdjustmentRuleArrayValue(canEndWithoutSeparator: false);
			try
			{
				return CreateCustomTimeZone(nextStringValue, nextTimeSpanValue, nextStringValue2, nextStringValue3, nextStringValue4, nextAdjustmentRuleArrayValue);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
			}
			catch (InvalidTimeZoneException innerException2)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException2);
			}
		}

		private StringSerializer(string str)
		{
			m_serializedText = str;
			m_state = State.StartOfToken;
		}

		private static string SerializeSubstitute(string text)
		{
			text = text.Replace("\\", "\\\\");
			text = text.Replace("[", "\\[");
			text = text.Replace("]", "\\]");
			return text.Replace(";", "\\;");
		}

		private static void SerializeTransitionTime(TransitionTime time, StringBuilder serializedText)
		{
			serializedText.Append('[');
			serializedText.Append((time.IsFixedDateRule ? 1 : 0).ToString(CultureInfo.InvariantCulture));
			serializedText.Append(';');
			if (time.IsFixedDateRule)
			{
				serializedText.Append(SerializeSubstitute(time.TimeOfDay.ToString("HH:mm:ss.FFF", DateTimeFormatInfo.InvariantInfo)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Month.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Day.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
			}
			else
			{
				serializedText.Append(SerializeSubstitute(time.TimeOfDay.ToString("HH:mm:ss.FFF", DateTimeFormatInfo.InvariantInfo)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Month.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(time.Week.ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
				serializedText.Append(SerializeSubstitute(((int)time.DayOfWeek).ToString(CultureInfo.InvariantCulture)));
				serializedText.Append(';');
			}
			serializedText.Append(']');
		}

		private static void VerifyIsEscapableCharacter(char c)
		{
			if (c != '\\' && c != ';' && c != '[' && c != ']')
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidEscapeSequence", c));
			}
		}

		private void SkipVersionNextDataFields(int depth)
		{
			if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			State state = State.NotEscaped;
			for (int i = m_currentTokenStartIndex; i < m_serializedText.Length; i++)
			{
				switch (state)
				{
				case State.Escaped:
					VerifyIsEscapableCharacter(m_serializedText[i]);
					state = State.NotEscaped;
					break;
				case State.NotEscaped:
					switch (m_serializedText[i])
					{
					case '\\':
						state = State.Escaped;
						break;
					case '[':
						depth++;
						break;
					case ']':
						depth--;
						if (depth == 0)
						{
							m_currentTokenStartIndex = i + 1;
							if (m_currentTokenStartIndex >= m_serializedText.Length)
							{
								m_state = State.EndOfLine;
							}
							else
							{
								m_state = State.StartOfToken;
							}
							return;
						}
						break;
					case '\0':
						throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
					}
					break;
				}
			}
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
		}

		private string GetNextStringValue(bool canEndWithoutSeparator)
		{
			if (m_state == State.EndOfLine)
			{
				if (canEndWithoutSeparator)
				{
					return null;
				}
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			State state = State.NotEscaped;
			StringBuilder stringBuilder = StringBuilderCache.Acquire(64);
			for (int i = m_currentTokenStartIndex; i < m_serializedText.Length; i++)
			{
				switch (state)
				{
				case State.Escaped:
					VerifyIsEscapableCharacter(m_serializedText[i]);
					stringBuilder.Append(m_serializedText[i]);
					state = State.NotEscaped;
					break;
				case State.NotEscaped:
					switch (m_serializedText[i])
					{
					case '\\':
						state = State.Escaped;
						break;
					case '[':
						throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
					case ']':
						if (canEndWithoutSeparator)
						{
							m_currentTokenStartIndex = i;
							m_state = State.StartOfToken;
							return stringBuilder.ToString();
						}
						throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
					case ';':
						m_currentTokenStartIndex = i + 1;
						if (m_currentTokenStartIndex >= m_serializedText.Length)
						{
							m_state = State.EndOfLine;
						}
						else
						{
							m_state = State.StartOfToken;
						}
						return StringBuilderCache.GetStringAndRelease(stringBuilder);
					case '\0':
						throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
					default:
						stringBuilder.Append(m_serializedText[i]);
						break;
					}
					break;
				}
			}
			if (state == State.Escaped)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidEscapeSequence", string.Empty));
			}
			if (!canEndWithoutSeparator)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			m_currentTokenStartIndex = m_serializedText.Length;
			m_state = State.EndOfLine;
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		private DateTime GetNextDateTimeValue(bool canEndWithoutSeparator, string format)
		{
			string nextStringValue = GetNextStringValue(canEndWithoutSeparator);
			if (!DateTime.TryParseExact(nextStringValue, format, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var result))
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			return result;
		}

		private TimeSpan GetNextTimeSpanValue(bool canEndWithoutSeparator)
		{
			int nextInt32Value = GetNextInt32Value(canEndWithoutSeparator);
			try
			{
				return new TimeSpan(0, nextInt32Value, 0);
			}
			catch (ArgumentOutOfRangeException innerException)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
			}
		}

		private int GetNextInt32Value(bool canEndWithoutSeparator)
		{
			string nextStringValue = GetNextStringValue(canEndWithoutSeparator);
			if (!int.TryParse(nextStringValue, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out var result))
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			return result;
		}

		private AdjustmentRule[] GetNextAdjustmentRuleArrayValue(bool canEndWithoutSeparator)
		{
			List<AdjustmentRule> list = new List<AdjustmentRule>(1);
			int num = 0;
			for (AdjustmentRule nextAdjustmentRuleValue = GetNextAdjustmentRuleValue(canEndWithoutSeparator: true); nextAdjustmentRuleValue != null; nextAdjustmentRuleValue = GetNextAdjustmentRuleValue(canEndWithoutSeparator: true))
			{
				list.Add(nextAdjustmentRuleValue);
				num++;
			}
			if (!canEndWithoutSeparator)
			{
				if (m_state == State.EndOfLine)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
				}
				if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
				}
			}
			if (num == 0)
			{
				return null;
			}
			return list.ToArray();
		}

		private AdjustmentRule GetNextAdjustmentRuleValue(bool canEndWithoutSeparator)
		{
			if (m_state == State.EndOfLine)
			{
				if (canEndWithoutSeparator)
				{
					return null;
				}
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_serializedText[m_currentTokenStartIndex] == ';')
			{
				return null;
			}
			if (m_serializedText[m_currentTokenStartIndex] != '[')
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			m_currentTokenStartIndex++;
			DateTime nextDateTimeValue = GetNextDateTimeValue(canEndWithoutSeparator: false, "MM:dd:yyyy");
			DateTime nextDateTimeValue2 = GetNextDateTimeValue(canEndWithoutSeparator: false, "MM:dd:yyyy");
			TimeSpan nextTimeSpanValue = GetNextTimeSpanValue(canEndWithoutSeparator: false);
			TransitionTime nextTransitionTimeValue = GetNextTransitionTimeValue(canEndWithoutSeparator: false);
			TransitionTime nextTransitionTimeValue2 = GetNextTransitionTimeValue(canEndWithoutSeparator: false);
			TimeSpan baseUtcOffsetDelta = TimeSpan.Zero;
			if (m_state == State.EndOfLine || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if ((m_serializedText[m_currentTokenStartIndex] >= '0' && m_serializedText[m_currentTokenStartIndex] <= '9') || m_serializedText[m_currentTokenStartIndex] == '-' || m_serializedText[m_currentTokenStartIndex] == '+')
			{
				baseUtcOffsetDelta = GetNextTimeSpanValue(canEndWithoutSeparator: false);
			}
			if (m_state == State.EndOfLine || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_serializedText[m_currentTokenStartIndex] != ']')
			{
				SkipVersionNextDataFields(1);
			}
			else
			{
				m_currentTokenStartIndex++;
			}
			AdjustmentRule result;
			try
			{
				result = AdjustmentRule.CreateAdjustmentRule(nextDateTimeValue, nextDateTimeValue2, nextTimeSpanValue, nextTransitionTimeValue, nextTransitionTimeValue2, baseUtcOffsetDelta);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
			}
			if (m_currentTokenStartIndex >= m_serializedText.Length)
			{
				m_state = State.EndOfLine;
			}
			else
			{
				m_state = State.StartOfToken;
			}
			return result;
		}

		private TransitionTime GetNextTransitionTimeValue(bool canEndWithoutSeparator)
		{
			if (m_state == State.EndOfLine || (m_currentTokenStartIndex < m_serializedText.Length && m_serializedText[m_currentTokenStartIndex] == ']'))
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex < 0 || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_serializedText[m_currentTokenStartIndex] != '[')
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			m_currentTokenStartIndex++;
			int nextInt32Value = GetNextInt32Value(canEndWithoutSeparator: false);
			if (nextInt32Value != 0 && nextInt32Value != 1)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			DateTime nextDateTimeValue = GetNextDateTimeValue(canEndWithoutSeparator: false, "HH:mm:ss.FFF");
			nextDateTimeValue = new DateTime(1, 1, 1, nextDateTimeValue.Hour, nextDateTimeValue.Minute, nextDateTimeValue.Second, nextDateTimeValue.Millisecond);
			int nextInt32Value2 = GetNextInt32Value(canEndWithoutSeparator: false);
			TransitionTime result;
			if (nextInt32Value == 1)
			{
				int nextInt32Value3 = GetNextInt32Value(canEndWithoutSeparator: false);
				try
				{
					result = TransitionTime.CreateFixedDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value3);
				}
				catch (ArgumentException innerException)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
				}
			}
			else
			{
				int nextInt32Value4 = GetNextInt32Value(canEndWithoutSeparator: false);
				int nextInt32Value5 = GetNextInt32Value(canEndWithoutSeparator: false);
				try
				{
					result = TransitionTime.CreateFloatingDateRule(nextDateTimeValue, nextInt32Value2, nextInt32Value4, (DayOfWeek)nextInt32Value5);
				}
				catch (ArgumentException innerException2)
				{
					throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException2);
				}
			}
			if (m_state == State.EndOfLine || m_currentTokenStartIndex >= m_serializedText.Length)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_serializedText[m_currentTokenStartIndex] != ']')
			{
				SkipVersionNextDataFields(1);
			}
			else
			{
				m_currentTokenStartIndex++;
			}
			bool flag = false;
			if (m_currentTokenStartIndex < m_serializedText.Length && m_serializedText[m_currentTokenStartIndex] == ';')
			{
				m_currentTokenStartIndex++;
				flag = true;
			}
			if (!flag && !canEndWithoutSeparator)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"));
			}
			if (m_currentTokenStartIndex >= m_serializedText.Length)
			{
				m_state = State.EndOfLine;
			}
			else
			{
				m_state = State.StartOfToken;
			}
			return result;
		}
	}

	private class TimeZoneInfoComparer : IComparer<TimeZoneInfo>
	{
		int IComparer<TimeZoneInfo>.Compare(TimeZoneInfo x, TimeZoneInfo y)
		{
			int num = x.BaseUtcOffset.CompareTo(y.BaseUtcOffset);
			if (num != 0)
			{
				return num;
			}
			return string.Compare(x.DisplayName, y.DisplayName, StringComparison.Ordinal);
		}
	}

	private string m_id;

	private string m_displayName;

	private string m_standardDisplayName;

	private string m_daylightDisplayName;

	private TimeSpan m_baseUtcOffset;

	private bool m_supportsDaylightSavingTime;

	private AdjustmentRule[] m_adjustmentRules;

	private const string c_timeZonesRegistryHive = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones";

	private const string c_timeZonesRegistryHivePermissionList = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones";

	private const string c_displayValue = "Display";

	private const string c_daylightValue = "Dlt";

	private const string c_standardValue = "Std";

	private const string c_muiDisplayValue = "MUI_Display";

	private const string c_muiDaylightValue = "MUI_Dlt";

	private const string c_muiStandardValue = "MUI_Std";

	private const string c_timeZoneInfoValue = "TZI";

	private const string c_firstEntryValue = "FirstEntry";

	private const string c_lastEntryValue = "LastEntry";

	private const string c_utcId = "UTC";

	private const string c_localId = "Local";

	private const int c_maxKeyLength = 255;

	private const int c_regByteLength = 44;

	private const long c_ticksPerMillisecond = 10000L;

	private const long c_ticksPerSecond = 10000000L;

	private const long c_ticksPerMinute = 600000000L;

	private const long c_ticksPerHour = 36000000000L;

	private const long c_ticksPerDay = 864000000000L;

	private const long c_ticksPerDayRange = 863999990000L;

	private static CachedData s_cachedData = new CachedData();

	private static DateTime s_maxDateOnly = new DateTime(9999, 12, 31);

	private static DateTime s_minDateOnly = new DateTime(1, 1, 2);

	[__DynamicallyInvokable]
	public string Id
	{
		[__DynamicallyInvokable]
		get
		{
			return m_id;
		}
	}

	[__DynamicallyInvokable]
	public string DisplayName
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_displayName != null)
			{
				return m_displayName;
			}
			return string.Empty;
		}
	}

	[__DynamicallyInvokable]
	public string StandardName
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_standardDisplayName != null)
			{
				return m_standardDisplayName;
			}
			return string.Empty;
		}
	}

	[__DynamicallyInvokable]
	public string DaylightName
	{
		[__DynamicallyInvokable]
		get
		{
			if (m_daylightDisplayName != null)
			{
				return m_daylightDisplayName;
			}
			return string.Empty;
		}
	}

	[__DynamicallyInvokable]
	public TimeSpan BaseUtcOffset
	{
		[__DynamicallyInvokable]
		get
		{
			return m_baseUtcOffset;
		}
	}

	[__DynamicallyInvokable]
	public bool SupportsDaylightSavingTime
	{
		[__DynamicallyInvokable]
		get
		{
			return m_supportsDaylightSavingTime;
		}
	}

	[__DynamicallyInvokable]
	public static TimeZoneInfo Local
	{
		[__DynamicallyInvokable]
		get
		{
			return s_cachedData.Local;
		}
	}

	[__DynamicallyInvokable]
	public static TimeZoneInfo Utc
	{
		[__DynamicallyInvokable]
		get
		{
			return s_cachedData.Utc;
		}
	}

	public AdjustmentRule[] GetAdjustmentRules()
	{
		if (m_adjustmentRules == null)
		{
			return new AdjustmentRule[0];
		}
		return (AdjustmentRule[])m_adjustmentRules.Clone();
	}

	[__DynamicallyInvokable]
	public TimeSpan[] GetAmbiguousTimeOffsets(DateTimeOffset dateTimeOffset)
	{
		if (!SupportsDaylightSavingTime)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeOffsetIsNotAmbiguous"), "dateTimeOffset");
		}
		DateTime dateTime = ConvertTime(dateTimeOffset, this).DateTime;
		bool flag = false;
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime);
		if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
		{
			DaylightTimeStruct daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
			flag = GetIsAmbiguousTime(dateTime, adjustmentRuleForTime, daylightTime);
		}
		if (!flag)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeOffsetIsNotAmbiguous"), "dateTimeOffset");
		}
		TimeSpan[] array = new TimeSpan[2];
		TimeSpan timeSpan = m_baseUtcOffset + adjustmentRuleForTime.BaseUtcOffsetDelta;
		if (adjustmentRuleForTime.DaylightDelta > TimeSpan.Zero)
		{
			array[0] = timeSpan;
			array[1] = timeSpan + adjustmentRuleForTime.DaylightDelta;
		}
		else
		{
			array[0] = timeSpan + adjustmentRuleForTime.DaylightDelta;
			array[1] = timeSpan;
		}
		return array;
	}

	[__DynamicallyInvokable]
	public TimeSpan[] GetAmbiguousTimeOffsets(DateTime dateTime)
	{
		if (!SupportsDaylightSavingTime)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeIsNotAmbiguous"), "dateTime");
		}
		DateTime dateTime2;
		if (dateTime.Kind == DateTimeKind.Local)
		{
			CachedData cachedData = s_cachedData;
			dateTime2 = ConvertTime(dateTime, cachedData.Local, this, TimeZoneInfoOptions.None, cachedData);
		}
		else if (dateTime.Kind == DateTimeKind.Utc)
		{
			CachedData cachedData2 = s_cachedData;
			dateTime2 = ConvertTime(dateTime, cachedData2.Utc, this, TimeZoneInfoOptions.None, cachedData2);
		}
		else
		{
			dateTime2 = dateTime;
		}
		bool flag = false;
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
		if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
		{
			DaylightTimeStruct daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
			flag = GetIsAmbiguousTime(dateTime2, adjustmentRuleForTime, daylightTime);
		}
		if (!flag)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeIsNotAmbiguous"), "dateTime");
		}
		TimeSpan[] array = new TimeSpan[2];
		TimeSpan timeSpan = m_baseUtcOffset + adjustmentRuleForTime.BaseUtcOffsetDelta;
		if (adjustmentRuleForTime.DaylightDelta > TimeSpan.Zero)
		{
			array[0] = timeSpan;
			array[1] = timeSpan + adjustmentRuleForTime.DaylightDelta;
		}
		else
		{
			array[0] = timeSpan + adjustmentRuleForTime.DaylightDelta;
			array[1] = timeSpan;
		}
		return array;
	}

	[__DynamicallyInvokable]
	public TimeSpan GetUtcOffset(DateTimeOffset dateTimeOffset)
	{
		return GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this);
	}

	[__DynamicallyInvokable]
	public TimeSpan GetUtcOffset(DateTime dateTime)
	{
		return GetUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime, s_cachedData);
	}

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		CachedData cachedData = s_cachedData;
		return cachedData.Local.GetUtcOffset(dateTime, flags, cachedData);
	}

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return GetUtcOffset(dateTime, flags, s_cachedData);
	}

	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		if (dateTime.Kind == DateTimeKind.Local)
		{
			if (cachedData.GetCorrespondingKind(this) != DateTimeKind.Local)
			{
				DateTime time = ConvertTime(dateTime, cachedData.Local, cachedData.Utc, flags);
				return GetUtcOffsetFromUtc(time, this);
			}
		}
		else if (dateTime.Kind == DateTimeKind.Utc)
		{
			if (cachedData.GetCorrespondingKind(this) == DateTimeKind.Utc)
			{
				return m_baseUtcOffset;
			}
			return GetUtcOffsetFromUtc(dateTime, this);
		}
		return GetUtcOffset(dateTime, this, flags);
	}

	[__DynamicallyInvokable]
	public bool IsAmbiguousTime(DateTimeOffset dateTimeOffset)
	{
		if (!m_supportsDaylightSavingTime)
		{
			return false;
		}
		return IsAmbiguousTime(ConvertTime(dateTimeOffset, this).DateTime);
	}

	[__DynamicallyInvokable]
	public bool IsAmbiguousTime(DateTime dateTime)
	{
		return IsAmbiguousTime(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
	}

	internal bool IsAmbiguousTime(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		if (!m_supportsDaylightSavingTime)
		{
			return false;
		}
		DateTime dateTime2;
		if (dateTime.Kind == DateTimeKind.Local)
		{
			CachedData cachedData = s_cachedData;
			dateTime2 = ConvertTime(dateTime, cachedData.Local, this, flags, cachedData);
		}
		else if (dateTime.Kind == DateTimeKind.Utc)
		{
			CachedData cachedData2 = s_cachedData;
			dateTime2 = ConvertTime(dateTime, cachedData2.Utc, this, flags, cachedData2);
		}
		else
		{
			dateTime2 = dateTime;
		}
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
		if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
		{
			DaylightTimeStruct daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
			return GetIsAmbiguousTime(dateTime2, adjustmentRuleForTime, daylightTime);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool IsDaylightSavingTime(DateTimeOffset dateTimeOffset)
	{
		GetUtcOffsetFromUtc(dateTimeOffset.UtcDateTime, this, out var isDaylightSavings);
		return isDaylightSavings;
	}

	[__DynamicallyInvokable]
	public bool IsDaylightSavingTime(DateTime dateTime)
	{
		return IsDaylightSavingTime(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime, s_cachedData);
	}

	internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return IsDaylightSavingTime(dateTime, flags, s_cachedData);
	}

	private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		if (!m_supportsDaylightSavingTime || m_adjustmentRules == null)
		{
			return false;
		}
		DateTime dateTime2;
		if (dateTime.Kind == DateTimeKind.Local)
		{
			dateTime2 = ConvertTime(dateTime, cachedData.Local, this, flags, cachedData);
		}
		else
		{
			if (dateTime.Kind == DateTimeKind.Utc)
			{
				if (cachedData.GetCorrespondingKind(this) == DateTimeKind.Utc)
				{
					return false;
				}
				GetUtcOffsetFromUtc(dateTime, this, out var isDaylightSavings);
				return isDaylightSavings;
			}
			dateTime2 = dateTime;
		}
		AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime2);
		if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
		{
			DaylightTimeStruct daylightTime = GetDaylightTime(dateTime2.Year, adjustmentRuleForTime);
			return GetIsDaylightSavings(dateTime2, adjustmentRuleForTime, daylightTime, flags);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public bool IsInvalidTime(DateTime dateTime)
	{
		bool result = false;
		if (dateTime.Kind == DateTimeKind.Unspecified || (dateTime.Kind == DateTimeKind.Local && s_cachedData.GetCorrespondingKind(this) == DateTimeKind.Local))
		{
			AdjustmentRule adjustmentRuleForTime = GetAdjustmentRuleForTime(dateTime);
			if (adjustmentRuleForTime != null && adjustmentRuleForTime.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
				result = GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime);
			}
			else
			{
				result = false;
			}
		}
		return result;
	}

	public static void ClearCachedData()
	{
		s_cachedData = new CachedData();
	}

	public static DateTimeOffset ConvertTimeBySystemTimeZoneId(DateTimeOffset dateTimeOffset, string destinationTimeZoneId)
	{
		return ConvertTime(dateTimeOffset, FindSystemTimeZoneById(destinationTimeZoneId));
	}

	public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string destinationTimeZoneId)
	{
		return ConvertTime(dateTime, FindSystemTimeZoneById(destinationTimeZoneId));
	}

	public static DateTime ConvertTimeBySystemTimeZoneId(DateTime dateTime, string sourceTimeZoneId, string destinationTimeZoneId)
	{
		if (dateTime.Kind == DateTimeKind.Local && string.Compare(sourceTimeZoneId, Local.Id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			CachedData cachedData = s_cachedData;
			return ConvertTime(dateTime, cachedData.Local, FindSystemTimeZoneById(destinationTimeZoneId), TimeZoneInfoOptions.None, cachedData);
		}
		if (dateTime.Kind == DateTimeKind.Utc && string.Compare(sourceTimeZoneId, Utc.Id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			CachedData cachedData2 = s_cachedData;
			return ConvertTime(dateTime, cachedData2.Utc, FindSystemTimeZoneById(destinationTimeZoneId), TimeZoneInfoOptions.None, cachedData2);
		}
		return ConvertTime(dateTime, FindSystemTimeZoneById(sourceTimeZoneId), FindSystemTimeZoneById(destinationTimeZoneId));
	}

	[__DynamicallyInvokable]
	public static DateTimeOffset ConvertTime(DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
	{
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		DateTime utcDateTime = dateTimeOffset.UtcDateTime;
		TimeSpan utcOffsetFromUtc = GetUtcOffsetFromUtc(utcDateTime, destinationTimeZone);
		long num = utcDateTime.Ticks + utcOffsetFromUtc.Ticks;
		if (num > DateTimeOffset.MaxValue.Ticks)
		{
			return DateTimeOffset.MaxValue;
		}
		if (num < DateTimeOffset.MinValue.Ticks)
		{
			return DateTimeOffset.MinValue;
		}
		return new DateTimeOffset(num, utcOffsetFromUtc);
	}

	[__DynamicallyInvokable]
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo destinationTimeZone)
	{
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		if (dateTime.Ticks == 0L)
		{
			ClearCachedData();
		}
		CachedData cachedData = s_cachedData;
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return ConvertTime(dateTime, cachedData.Utc, destinationTimeZone, TimeZoneInfoOptions.None, cachedData);
		}
		return ConvertTime(dateTime, cachedData.Local, destinationTimeZone, TimeZoneInfoOptions.None, cachedData);
	}

	[__DynamicallyInvokable]
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone)
	{
		return ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, TimeZoneInfoOptions.None, s_cachedData);
	}

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		return ConvertTime(dateTime, sourceTimeZone, destinationTimeZone, flags, s_cachedData);
	}

	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		if (sourceTimeZone == null)
		{
			throw new ArgumentNullException("sourceTimeZone");
		}
		if (destinationTimeZone == null)
		{
			throw new ArgumentNullException("destinationTimeZone");
		}
		DateTimeKind correspondingKind = cachedData.GetCorrespondingKind(sourceTimeZone);
		if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == 0 && dateTime.Kind != DateTimeKind.Unspecified && dateTime.Kind != correspondingKind)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_ConvertMismatch"), "sourceTimeZone");
		}
		AdjustmentRule adjustmentRuleForTime = sourceTimeZone.GetAdjustmentRuleForTime(dateTime);
		TimeSpan baseUtcOffset = sourceTimeZone.BaseUtcOffset;
		if (adjustmentRuleForTime != null)
		{
			baseUtcOffset += adjustmentRuleForTime.BaseUtcOffsetDelta;
			if (adjustmentRuleForTime.HasDaylightSaving)
			{
				bool flag = false;
				DaylightTimeStruct daylightTime = GetDaylightTime(dateTime.Year, adjustmentRuleForTime);
				if ((flags & TimeZoneInfoOptions.NoThrowOnInvalidTime) == 0 && GetIsInvalidTime(dateTime, adjustmentRuleForTime, daylightTime))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_DateTimeIsInvalid"), "dateTime");
				}
				flag = GetIsDaylightSavings(dateTime, adjustmentRuleForTime, daylightTime, flags);
				baseUtcOffset += (flag ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
			}
		}
		DateTimeKind correspondingKind2 = cachedData.GetCorrespondingKind(destinationTimeZone);
		if (dateTime.Kind != DateTimeKind.Unspecified && correspondingKind != DateTimeKind.Unspecified && correspondingKind == correspondingKind2)
		{
			return dateTime;
		}
		long ticks = dateTime.Ticks - baseUtcOffset.Ticks;
		bool isAmbiguousLocalDst = false;
		DateTime dateTime2 = ConvertUtcToTimeZone(ticks, destinationTimeZone, out isAmbiguousLocalDst);
		if (correspondingKind2 == DateTimeKind.Local)
		{
			return new DateTime(dateTime2.Ticks, DateTimeKind.Local, isAmbiguousLocalDst);
		}
		return new DateTime(dateTime2.Ticks, correspondingKind2);
	}

	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone)
	{
		CachedData cachedData = s_cachedData;
		return ConvertTime(dateTime, cachedData.Utc, destinationTimeZone, TimeZoneInfoOptions.None, cachedData);
	}

	public static DateTime ConvertTimeToUtc(DateTime dateTime)
	{
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return dateTime;
		}
		CachedData cachedData = s_cachedData;
		return ConvertTime(dateTime, cachedData.Local, cachedData.Utc, TimeZoneInfoOptions.None, cachedData);
	}

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		if (dateTime.Kind == DateTimeKind.Utc)
		{
			return dateTime;
		}
		CachedData cachedData = s_cachedData;
		return ConvertTime(dateTime, cachedData.Local, cachedData.Utc, flags, cachedData);
	}

	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
	{
		CachedData cachedData = s_cachedData;
		return ConvertTime(dateTime, sourceTimeZone, cachedData.Utc, TimeZoneInfoOptions.None, cachedData);
	}

	[__DynamicallyInvokable]
	public bool Equals(TimeZoneInfo other)
	{
		if (other != null && string.Compare(m_id, other.m_id, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return HasSameRules(other);
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is TimeZoneInfo other))
		{
			return false;
		}
		return Equals(other);
	}

	public static TimeZoneInfo FromSerializedString(string source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSerializedString", source), "source");
		}
		return StringSerializer.GetDeserializedTimeZoneInfo(source);
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_id.ToUpper(CultureInfo.InvariantCulture).GetHashCode();
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
	{
		CachedData cachedData = s_cachedData;
		lock (cachedData)
		{
			if (cachedData.m_readOnlySystemTimeZones == null)
			{
				PermissionSet permissionSet = new PermissionSet(PermissionState.None);
				permissionSet.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
				permissionSet.Assert();
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey))
				{
					if (registryKey != null)
					{
						string[] subKeyNames = registryKey.GetSubKeyNames();
						foreach (string id in subKeyNames)
						{
							TryGetTimeZone(id, dstDisabled: false, out var _, out var _, cachedData);
						}
					}
					cachedData.m_allSystemTimeZonesRead = true;
				}
				List<TimeZoneInfo> list = ((cachedData.m_systemTimeZones == null) ? new List<TimeZoneInfo>() : new List<TimeZoneInfo>(cachedData.m_systemTimeZones.Values));
				list.Sort(new TimeZoneInfoComparer());
				cachedData.m_readOnlySystemTimeZones = new ReadOnlyCollection<TimeZoneInfo>(list);
			}
		}
		return cachedData.m_readOnlySystemTimeZones;
	}

	public bool HasSameRules(TimeZoneInfo other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (m_baseUtcOffset != other.m_baseUtcOffset || m_supportsDaylightSavingTime != other.m_supportsDaylightSavingTime)
		{
			return false;
		}
		AdjustmentRule[] adjustmentRules = m_adjustmentRules;
		AdjustmentRule[] adjustmentRules2 = other.m_adjustmentRules;
		bool flag = (adjustmentRules == null && adjustmentRules2 == null) || (adjustmentRules != null && adjustmentRules2 != null);
		if (!flag)
		{
			return false;
		}
		if (adjustmentRules != null)
		{
			if (adjustmentRules.Length != adjustmentRules2.Length)
			{
				return false;
			}
			for (int i = 0; i < adjustmentRules.Length; i++)
			{
				if (!adjustmentRules[i].Equals(adjustmentRules2[i]))
				{
					return false;
				}
			}
		}
		return flag;
	}

	public string ToSerializedString()
	{
		return StringSerializer.GetSerializedString(this);
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return DisplayName;
	}

	[SecurityCritical]
	private TimeZoneInfo(Win32Native.TimeZoneInformation zone, bool dstDisabled)
	{
		if (string.IsNullOrEmpty(zone.StandardName))
		{
			m_id = "Local";
		}
		else
		{
			m_id = zone.StandardName;
		}
		m_baseUtcOffset = new TimeSpan(0, -zone.Bias, 0);
		if (!dstDisabled)
		{
			Win32Native.RegistryTimeZoneInformation timeZoneInformation = new Win32Native.RegistryTimeZoneInformation(zone);
			AdjustmentRule adjustmentRule = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, DateTime.MinValue.Date, DateTime.MaxValue.Date, zone.Bias);
			if (adjustmentRule != null)
			{
				m_adjustmentRules = new AdjustmentRule[1];
				m_adjustmentRules[0] = adjustmentRule;
			}
		}
		ValidateTimeZoneInfo(m_id, m_baseUtcOffset, m_adjustmentRules, out m_supportsDaylightSavingTime);
		m_displayName = zone.StandardName;
		m_standardDisplayName = zone.StandardName;
		m_daylightDisplayName = zone.DaylightName;
	}

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
		ValidateTimeZoneInfo(id, baseUtcOffset, adjustmentRules, out var adjustmentRulesSupportDst);
		if (!disableDaylightSavingTime && adjustmentRules != null && adjustmentRules.Length != 0)
		{
			m_adjustmentRules = (AdjustmentRule[])adjustmentRules.Clone();
		}
		m_id = id;
		m_baseUtcOffset = baseUtcOffset;
		m_displayName = displayName;
		m_standardDisplayName = standardDisplayName;
		m_daylightDisplayName = (disableDaylightSavingTime ? null : daylightDisplayName);
		m_supportsDaylightSavingTime = adjustmentRulesSupportDst && !disableDaylightSavingTime;
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, standardDisplayName, null, disableDaylightSavingTime: false);
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, disableDaylightSavingTime: false);
	}

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
		return new TimeZoneInfo(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName, adjustmentRules, disableDaylightSavingTime);
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		try
		{
			ValidateTimeZoneInfo(m_id, m_baseUtcOffset, m_adjustmentRules, out var adjustmentRulesSupportDst);
			if (adjustmentRulesSupportDst != m_supportsDaylightSavingTime)
			{
				throw new SerializationException(Environment.GetResourceString("Serialization_CorruptField", "SupportsDaylightSavingTime"));
			}
		}
		catch (ArgumentException innerException)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException);
		}
		catch (InvalidTimeZoneException innerException2)
		{
			throw new SerializationException(Environment.GetResourceString("Serialization_InvalidData"), innerException2);
		}
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("Id", m_id);
		info.AddValue("DisplayName", m_displayName);
		info.AddValue("StandardName", m_standardDisplayName);
		info.AddValue("DaylightName", m_daylightDisplayName);
		info.AddValue("BaseUtcOffset", m_baseUtcOffset);
		info.AddValue("AdjustmentRules", m_adjustmentRules);
		info.AddValue("SupportsDaylightSavingTime", m_supportsDaylightSavingTime);
	}

	private TimeZoneInfo(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_id = (string)info.GetValue("Id", typeof(string));
		m_displayName = (string)info.GetValue("DisplayName", typeof(string));
		m_standardDisplayName = (string)info.GetValue("StandardName", typeof(string));
		m_daylightDisplayName = (string)info.GetValue("DaylightName", typeof(string));
		m_baseUtcOffset = (TimeSpan)info.GetValue("BaseUtcOffset", typeof(TimeSpan));
		m_adjustmentRules = (AdjustmentRule[])info.GetValue("AdjustmentRules", typeof(AdjustmentRule[]));
		m_supportsDaylightSavingTime = (bool)info.GetValue("SupportsDaylightSavingTime", typeof(bool));
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime)
	{
		if (m_adjustmentRules == null || m_adjustmentRules.Length == 0)
		{
			return null;
		}
		DateTime date = dateTime.Date;
		for (int i = 0; i < m_adjustmentRules.Length; i++)
		{
			if (m_adjustmentRules[i].DateStart <= date && m_adjustmentRules[i].DateEnd >= date)
			{
				return m_adjustmentRules[i];
			}
		}
		return null;
	}

	[SecurityCritical]
	private static bool CheckDaylightSavingTimeNotSupported(Win32Native.TimeZoneInformation timeZone)
	{
		if (timeZone.DaylightDate.Year == timeZone.StandardDate.Year && timeZone.DaylightDate.Month == timeZone.StandardDate.Month && timeZone.DaylightDate.DayOfWeek == timeZone.StandardDate.DayOfWeek && timeZone.DaylightDate.Day == timeZone.StandardDate.Day && timeZone.DaylightDate.Hour == timeZone.StandardDate.Hour && timeZone.DaylightDate.Minute == timeZone.StandardDate.Minute && timeZone.DaylightDate.Second == timeZone.StandardDate.Second)
		{
			return timeZone.DaylightDate.Milliseconds == timeZone.StandardDate.Milliseconds;
		}
		return false;
	}

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
	{
		DateTime time = ((ticks > DateTime.MaxValue.Ticks) ? DateTime.MaxValue : ((ticks >= DateTime.MinValue.Ticks) ? new DateTime(ticks) : DateTime.MinValue));
		ticks += GetUtcOffsetFromUtc(time, destinationTimeZone, out isAmbiguousLocalDst).Ticks;
		if (ticks > DateTime.MaxValue.Ticks)
		{
			return DateTime.MaxValue;
		}
		if (ticks < DateTime.MinValue.Ticks)
		{
			return DateTime.MinValue;
		}
		return new DateTime(ticks);
	}

	[SecurityCritical]
	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(Win32Native.RegistryTimeZoneInformation timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		if (timeZoneInformation.StandardDate.Month == 0)
		{
			if (timeZoneInformation.Bias == defaultBaseUtcOffset)
			{
				return null;
			}
			AdjustmentRule adjustmentRule;
			return adjustmentRule = AdjustmentRule.CreateAdjustmentRule(startDate, endDate, TimeSpan.Zero, TransitionTime.CreateFixedDateRule(DateTime.MinValue, 1, 1), TransitionTime.CreateFixedDateRule(DateTime.MinValue.AddMilliseconds(1.0), 1, 1), new TimeSpan(0, defaultBaseUtcOffset - timeZoneInformation.Bias, 0));
		}
		if (!TransitionTimeFromTimeZoneInformation(timeZoneInformation, out var transitionTime, readStartDate: true))
		{
			return null;
		}
		if (!TransitionTimeFromTimeZoneInformation(timeZoneInformation, out var transitionTime2, readStartDate: false))
		{
			return null;
		}
		if (transitionTime.Equals(transitionTime2))
		{
			return null;
		}
		return AdjustmentRule.CreateAdjustmentRule(startDate, endDate, new TimeSpan(0, -timeZoneInformation.DaylightBias, 0), transitionTime, transitionTime2, new TimeSpan(0, defaultBaseUtcOffset - timeZoneInformation.Bias, 0));
	}

	[SecuritySafeCritical]
	private static string FindIdFromTimeZoneInformation(Win32Native.TimeZoneInformation timeZone, out bool dstDisabled)
	{
		dstDisabled = false;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				return null;
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				if (TryCompareTimeZoneInformationToRegistry(timeZone, text, out dstDisabled))
				{
					return text;
				}
			}
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
		return null;
	}

	private static DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule)
	{
		TimeSpan daylightDelta = rule.DaylightDelta;
		DateTime start = TransitionTimeToDateTime(year, rule.DaylightTransitionStart);
		DateTime end = TransitionTimeToDateTime(year, rule.DaylightTransitionEnd);
		return new DaylightTimeStruct(start, end, daylightDelta);
	}

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
	{
		if (rule == null)
		{
			return false;
		}
		DateTime startTime;
		DateTime endTime;
		if (time.Kind == DateTimeKind.Local)
		{
			startTime = (rule.IsStartDateMarkerForBeginningOfYear() ? new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) : (daylightTime.Start + daylightTime.Delta));
			endTime = (rule.IsEndDateMarkerForEndOfYear() ? new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) : daylightTime.End);
		}
		else
		{
			bool flag = rule.DaylightDelta > TimeSpan.Zero;
			startTime = (rule.IsStartDateMarkerForBeginningOfYear() ? new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) : (daylightTime.Start + (flag ? rule.DaylightDelta : TimeSpan.Zero)));
			endTime = (rule.IsEndDateMarkerForEndOfYear() ? new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) : (daylightTime.End + (flag ? (-rule.DaylightDelta) : TimeSpan.Zero)));
		}
		bool flag2 = CheckIsDst(startTime, time, endTime, ignoreYearAdjustment: false);
		if (flag2 && time.Kind == DateTimeKind.Local && GetIsAmbiguousTime(time, rule, daylightTime))
		{
			flag2 = time.IsAmbiguousDaylightSavingTime();
		}
		return flag2;
	}

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int Year, TimeSpan utc, AdjustmentRule rule, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
	{
		isAmbiguousLocalDst = false;
		if (rule == null)
		{
			return false;
		}
		TimeSpan timeSpan = utc + rule.BaseUtcOffsetDelta;
		DaylightTimeStruct daylightTime = GetDaylightTime(Year, rule);
		bool ignoreYearAdjustment = false;
		DateTime dateTime;
		if (rule.IsStartDateMarkerForBeginningOfYear() && daylightTime.Start.Year > DateTime.MinValue.Year)
		{
			AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(new DateTime(daylightTime.Start.Year - 1, 12, 31));
			if (adjustmentRuleForTime != null && adjustmentRuleForTime.IsEndDateMarkerForEndOfYear())
			{
				dateTime = GetDaylightTime(daylightTime.Start.Year - 1, adjustmentRuleForTime).Start - utc - adjustmentRuleForTime.BaseUtcOffsetDelta;
				ignoreYearAdjustment = true;
			}
			else
			{
				dateTime = new DateTime(daylightTime.Start.Year, 1, 1, 0, 0, 0) - timeSpan;
			}
		}
		else
		{
			dateTime = daylightTime.Start - timeSpan;
		}
		DateTime dateTime2;
		if (rule.IsEndDateMarkerForEndOfYear() && daylightTime.End.Year < DateTime.MaxValue.Year)
		{
			AdjustmentRule adjustmentRuleForTime2 = zone.GetAdjustmentRuleForTime(new DateTime(daylightTime.End.Year + 1, 1, 1));
			if (adjustmentRuleForTime2 != null && adjustmentRuleForTime2.IsStartDateMarkerForBeginningOfYear())
			{
				dateTime2 = ((!adjustmentRuleForTime2.IsEndDateMarkerForEndOfYear()) ? (GetDaylightTime(daylightTime.End.Year + 1, adjustmentRuleForTime2).End - utc - adjustmentRuleForTime2.BaseUtcOffsetDelta - adjustmentRuleForTime2.DaylightDelta) : (new DateTime(daylightTime.End.Year + 1, 12, 31) - utc - adjustmentRuleForTime2.BaseUtcOffsetDelta - adjustmentRuleForTime2.DaylightDelta));
				ignoreYearAdjustment = true;
			}
			else
			{
				dateTime2 = new DateTime(daylightTime.End.Year + 1, 1, 1, 0, 0, 0).AddTicks(-1L) - timeSpan - rule.DaylightDelta;
			}
		}
		else
		{
			dateTime2 = daylightTime.End - timeSpan - rule.DaylightDelta;
		}
		DateTime dateTime3;
		DateTime dateTime4;
		if (daylightTime.Delta.Ticks > 0)
		{
			dateTime3 = dateTime2 - daylightTime.Delta;
			dateTime4 = dateTime2;
		}
		else
		{
			dateTime3 = dateTime;
			dateTime4 = dateTime - daylightTime.Delta;
		}
		bool flag = CheckIsDst(dateTime, time, dateTime2, ignoreYearAdjustment);
		if (flag)
		{
			isAmbiguousLocalDst = time >= dateTime3 && time < dateTime4;
			if (!isAmbiguousLocalDst && dateTime3.Year != dateTime4.Year)
			{
				try
				{
					DateTime dateTime5 = dateTime3.AddYears(1);
					DateTime dateTime6 = dateTime4.AddYears(1);
					isAmbiguousLocalDst = time >= dateTime3 && time < dateTime4;
				}
				catch (ArgumentOutOfRangeException)
				{
				}
				if (!isAmbiguousLocalDst)
				{
					try
					{
						DateTime dateTime5 = dateTime3.AddYears(-1);
						DateTime dateTime6 = dateTime4.AddYears(-1);
						isAmbiguousLocalDst = time >= dateTime3 && time < dateTime4;
					}
					catch (ArgumentOutOfRangeException)
					{
					}
				}
			}
		}
		return flag;
	}

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment)
	{
		if (!ignoreYearAdjustment)
		{
			int year = startTime.Year;
			int year2 = endTime.Year;
			if (year != year2)
			{
				endTime = endTime.AddYears(year - year2);
			}
			int year3 = time.Year;
			if (year != year3)
			{
				time = time.AddYears(year - year3);
			}
		}
		if (startTime > endTime)
		{
			return time < endTime || time >= startTime;
		}
		return time >= startTime && time < endTime;
	}

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		bool result = false;
		if (rule == null || rule.DaylightDelta == TimeSpan.Zero)
		{
			return result;
		}
		DateTime dateTime;
		DateTime dateTime2;
		if (rule.DaylightDelta > TimeSpan.Zero)
		{
			if (rule.IsEndDateMarkerForEndOfYear())
			{
				return false;
			}
			dateTime = daylightTime.End;
			dateTime2 = daylightTime.End - rule.DaylightDelta;
		}
		else
		{
			if (rule.IsStartDateMarkerForBeginningOfYear())
			{
				return false;
			}
			dateTime = daylightTime.Start;
			dateTime2 = daylightTime.Start + rule.DaylightDelta;
		}
		result = time >= dateTime2 && time < dateTime;
		if (!result && dateTime.Year != dateTime2.Year)
		{
			try
			{
				DateTime dateTime3 = dateTime.AddYears(1);
				DateTime dateTime4 = dateTime2.AddYears(1);
				result = time >= dateTime4 && time < dateTime3;
			}
			catch (ArgumentOutOfRangeException)
			{
			}
			if (!result)
			{
				try
				{
					DateTime dateTime3 = dateTime.AddYears(-1);
					DateTime dateTime4 = dateTime2.AddYears(-1);
					result = time >= dateTime4 && time < dateTime3;
				}
				catch (ArgumentOutOfRangeException)
				{
				}
			}
		}
		return result;
	}

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		bool result = false;
		if (rule == null || rule.DaylightDelta == TimeSpan.Zero)
		{
			return result;
		}
		DateTime dateTime;
		DateTime dateTime2;
		if (rule.DaylightDelta < TimeSpan.Zero)
		{
			if (rule.IsEndDateMarkerForEndOfYear())
			{
				return false;
			}
			dateTime = daylightTime.End;
			dateTime2 = daylightTime.End - rule.DaylightDelta;
		}
		else
		{
			if (rule.IsStartDateMarkerForBeginningOfYear())
			{
				return false;
			}
			dateTime = daylightTime.Start;
			dateTime2 = daylightTime.Start + rule.DaylightDelta;
		}
		result = time >= dateTime && time < dateTime2;
		if (!result && dateTime.Year != dateTime2.Year)
		{
			try
			{
				DateTime dateTime3 = dateTime.AddYears(1);
				DateTime dateTime4 = dateTime2.AddYears(1);
				result = time >= dateTime3 && time < dateTime4;
			}
			catch (ArgumentOutOfRangeException)
			{
			}
			if (!result)
			{
				try
				{
					DateTime dateTime3 = dateTime.AddYears(-1);
					DateTime dateTime4 = dateTime2.AddYears(-1);
					result = time >= dateTime3 && time < dateTime4;
				}
				catch (ArgumentOutOfRangeException)
				{
				}
			}
		}
		return result;
	}

	[SecuritySafeCritical]
	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData)
	{
		string text = null;
		Win32Native.DynamicTimeZoneInformation lpDynamicTimeZoneInformation = default(Win32Native.DynamicTimeZoneInformation);
		long num = UnsafeNativeMethods.GetDynamicTimeZoneInformation(out lpDynamicTimeZoneInformation);
		if (num == -1)
		{
			return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
		}
		Win32Native.TimeZoneInformation timeZoneInformation = new Win32Native.TimeZoneInformation(lpDynamicTimeZoneInformation);
		bool dstDisabled = lpDynamicTimeZoneInformation.DynamicDaylightTimeDisabled;
		if (!string.IsNullOrEmpty(lpDynamicTimeZoneInformation.TimeZoneKeyName) && TryGetTimeZone(lpDynamicTimeZoneInformation.TimeZoneKeyName, dstDisabled, out var value, out var _, cachedData) == TimeZoneInfoResult.Success)
		{
			return value;
		}
		text = FindIdFromTimeZoneInformation(timeZoneInformation, out dstDisabled);
		if (text != null && TryGetTimeZone(text, dstDisabled, out var value2, out var _, cachedData) == TimeZoneInfoResult.Success)
		{
			return value2;
		}
		return GetLocalTimeZoneFromWin32Data(timeZoneInformation, dstDisabled);
	}

	[SecurityCritical]
	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(Win32Native.TimeZoneInformation timeZoneInformation, bool dstDisabled)
	{
		try
		{
			return new TimeZoneInfo(timeZoneInformation, dstDisabled);
		}
		catch (ArgumentException)
		{
		}
		catch (InvalidTimeZoneException)
		{
		}
		if (!dstDisabled)
		{
			try
			{
				return new TimeZoneInfo(timeZoneInformation, dstDisabled: true);
			}
			catch (ArgumentException)
			{
			}
			catch (InvalidTimeZoneException)
			{
			}
		}
		return CreateCustomTimeZone("Local", TimeSpan.Zero, "Local", "Local");
	}

	[__DynamicallyInvokable]
	public static TimeZoneInfo FindSystemTimeZoneById(string id)
	{
		if (string.Compare(id, "UTC", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return Utc;
		}
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (id.Length == 0 || id.Length > 255 || id.Contains("\0"))
		{
			throw new TimeZoneNotFoundException(Environment.GetResourceString("TimeZoneNotFound_MissingRegistryData", id));
		}
		CachedData cachedData = s_cachedData;
		TimeZoneInfoResult timeZoneInfoResult;
		TimeZoneInfo value;
		Exception e;
		lock (cachedData)
		{
			timeZoneInfoResult = TryGetTimeZone(id, dstDisabled: false, out value, out e, cachedData);
		}
		return timeZoneInfoResult switch
		{
			TimeZoneInfoResult.Success => value, 
			TimeZoneInfoResult.InvalidTimeZoneException => throw new InvalidTimeZoneException(Environment.GetResourceString("InvalidTimeZone_InvalidRegistryData", id), e), 
			TimeZoneInfoResult.SecurityException => throw new SecurityException(Environment.GetResourceString("Security_CannotReadRegistryData", id), e), 
			_ => throw new TimeZoneNotFoundException(Environment.GetResourceString("TimeZoneNotFound_MissingRegistryData", id), e), 
		};
	}

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
	{
		TimeSpan baseUtcOffset = zone.BaseUtcOffset;
		AdjustmentRule adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(time);
		if (adjustmentRuleForTime != null)
		{
			baseUtcOffset += adjustmentRuleForTime.BaseUtcOffsetDelta;
			if (adjustmentRuleForTime.HasDaylightSaving)
			{
				DaylightTimeStruct daylightTime = GetDaylightTime(time.Year, adjustmentRuleForTime);
				bool isDaylightSavings = GetIsDaylightSavings(time, adjustmentRuleForTime, daylightTime, flags);
				baseUtcOffset += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
			}
		}
		return baseUtcOffset;
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		bool isDaylightSavings;
		return GetUtcOffsetFromUtc(time, zone, out isDaylightSavings);
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		bool isAmbiguousLocalDst;
		return GetUtcOffsetFromUtc(time, zone, out isDaylightSavings, out isAmbiguousLocalDst);
	}

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
	{
		bool flag = false;
		isAmbiguousLocalDst = false;
		int year = time.Year;
		OffsetAndRule oneYearLocalFromUtc = s_cachedData.GetOneYearLocalFromUtc(year);
		TimeSpan offset = oneYearLocalFromUtc.offset;
		if (oneYearLocalFromUtc.rule != null)
		{
			offset += oneYearLocalFromUtc.rule.BaseUtcOffsetDelta;
			if (oneYearLocalFromUtc.rule.HasDaylightSaving)
			{
				flag = GetIsDaylightSavingsFromUtc(time, year, oneYearLocalFromUtc.offset, oneYearLocalFromUtc.rule, out isAmbiguousLocalDst, Local);
				offset += (flag ? oneYearLocalFromUtc.rule.DaylightDelta : TimeSpan.Zero);
			}
		}
		return offset;
	}

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
	{
		isDaylightSavings = false;
		isAmbiguousLocalDst = false;
		TimeSpan baseUtcOffset = zone.BaseUtcOffset;
		AdjustmentRule adjustmentRuleForTime;
		int year;
		if (time > s_maxDateOnly)
		{
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MaxValue);
			year = 9999;
		}
		else if (time < s_minDateOnly)
		{
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(DateTime.MinValue);
			year = 1;
		}
		else
		{
			DateTime dateTime = time + baseUtcOffset;
			year = dateTime.Year;
			adjustmentRuleForTime = zone.GetAdjustmentRuleForTime(dateTime);
		}
		if (adjustmentRuleForTime != null)
		{
			baseUtcOffset += adjustmentRuleForTime.BaseUtcOffsetDelta;
			if (adjustmentRuleForTime.HasDaylightSaving)
			{
				isDaylightSavings = GetIsDaylightSavingsFromUtc(time, year, zone.m_baseUtcOffset, adjustmentRuleForTime, out isAmbiguousLocalDst, zone);
				baseUtcOffset += (isDaylightSavings ? adjustmentRuleForTime.DaylightDelta : TimeSpan.Zero);
			}
		}
		return baseUtcOffset;
	}

	[SecurityCritical]
	private static bool TransitionTimeFromTimeZoneInformation(Win32Native.RegistryTimeZoneInformation timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		if (timeZoneInformation.StandardDate.Month == 0)
		{
			transitionTime = default(TransitionTime);
			return false;
		}
		if (readStartDate)
		{
			if (timeZoneInformation.DaylightDate.Year == 0)
			{
				transitionTime = TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, timeZoneInformation.DaylightDate.Hour, timeZoneInformation.DaylightDate.Minute, timeZoneInformation.DaylightDate.Second, timeZoneInformation.DaylightDate.Milliseconds), timeZoneInformation.DaylightDate.Month, timeZoneInformation.DaylightDate.Day, (DayOfWeek)timeZoneInformation.DaylightDate.DayOfWeek);
			}
			else
			{
				transitionTime = TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, timeZoneInformation.DaylightDate.Hour, timeZoneInformation.DaylightDate.Minute, timeZoneInformation.DaylightDate.Second, timeZoneInformation.DaylightDate.Milliseconds), timeZoneInformation.DaylightDate.Month, timeZoneInformation.DaylightDate.Day);
			}
		}
		else if (timeZoneInformation.StandardDate.Year == 0)
		{
			transitionTime = TransitionTime.CreateFloatingDateRule(new DateTime(1, 1, 1, timeZoneInformation.StandardDate.Hour, timeZoneInformation.StandardDate.Minute, timeZoneInformation.StandardDate.Second, timeZoneInformation.StandardDate.Milliseconds), timeZoneInformation.StandardDate.Month, timeZoneInformation.StandardDate.Day, (DayOfWeek)timeZoneInformation.StandardDate.DayOfWeek);
		}
		else
		{
			transitionTime = TransitionTime.CreateFixedDateRule(new DateTime(1, 1, 1, timeZoneInformation.StandardDate.Hour, timeZoneInformation.StandardDate.Minute, timeZoneInformation.StandardDate.Second, timeZoneInformation.StandardDate.Milliseconds), timeZoneInformation.StandardDate.Month, timeZoneInformation.StandardDate.Day);
		}
		return true;
	}

	private static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		DateTime timeOfDay = transitionTime.TimeOfDay;
		DateTime result;
		if (transitionTime.IsFixedDateRule)
		{
			int num = DateTime.DaysInMonth(year, transitionTime.Month);
			result = new DateTime(year, transitionTime.Month, (num < transitionTime.Day) ? num : transitionTime.Day, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
		}
		else if (transitionTime.Week <= 4)
		{
			result = new DateTime(year, transitionTime.Month, 1, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
			int dayOfWeek = (int)result.DayOfWeek;
			int num2 = (int)(transitionTime.DayOfWeek - dayOfWeek);
			if (num2 < 0)
			{
				num2 += 7;
			}
			num2 += 7 * (transitionTime.Week - 1);
			if (num2 > 0)
			{
				return result.AddDays(num2);
			}
		}
		else
		{
			int day = DateTime.DaysInMonth(year, transitionTime.Month);
			result = new DateTime(year, transitionTime.Month, day, timeOfDay.Hour, timeOfDay.Minute, timeOfDay.Second, timeOfDay.Millisecond);
			int dayOfWeek2 = (int)result.DayOfWeek;
			int num3 = (int)(dayOfWeek2 - transitionTime.DayOfWeek);
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

	[SecurityCritical]
	private static bool TryCreateAdjustmentRules(string id, Win32Native.RegistryTimeZoneInformation defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset)
	{
		e = null;
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}\\Dynamic DST", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				AdjustmentRule adjustmentRule = CreateAdjustmentRuleFromTimeZoneInformation(defaultTimeZoneInformation, DateTime.MinValue.Date, DateTime.MaxValue.Date, defaultBaseUtcOffset);
				if (adjustmentRule == null)
				{
					rules = null;
				}
				else
				{
					rules = new AdjustmentRule[1];
					rules[0] = adjustmentRule;
				}
				return true;
			}
			int num = (int)registryKey.GetValue("FirstEntry", -1, RegistryValueOptions.None);
			int num2 = (int)registryKey.GetValue("LastEntry", -1, RegistryValueOptions.None);
			if (num == -1 || num2 == -1 || num > num2)
			{
				rules = null;
				return false;
			}
			if (!(registryKey.GetValue(num.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None) is byte[] array) || array.Length != 44)
			{
				rules = null;
				return false;
			}
			Win32Native.RegistryTimeZoneInformation timeZoneInformation = new Win32Native.RegistryTimeZoneInformation(array);
			if (num == num2)
			{
				AdjustmentRule adjustmentRule2 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, DateTime.MinValue.Date, DateTime.MaxValue.Date, defaultBaseUtcOffset);
				if (adjustmentRule2 == null)
				{
					rules = null;
				}
				else
				{
					rules = new AdjustmentRule[1];
					rules[0] = adjustmentRule2;
				}
				return true;
			}
			List<AdjustmentRule> list = new List<AdjustmentRule>(1);
			AdjustmentRule adjustmentRule3 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, DateTime.MinValue.Date, new DateTime(num, 12, 31), defaultBaseUtcOffset);
			if (adjustmentRule3 != null)
			{
				list.Add(adjustmentRule3);
			}
			for (int i = num + 1; i < num2; i++)
			{
				if (!(registryKey.GetValue(i.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None) is byte[] array2) || array2.Length != 44)
				{
					rules = null;
					return false;
				}
				timeZoneInformation = new Win32Native.RegistryTimeZoneInformation(array2);
				AdjustmentRule adjustmentRule4 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, new DateTime(i, 1, 1), new DateTime(i, 12, 31), defaultBaseUtcOffset);
				if (adjustmentRule4 != null)
				{
					list.Add(adjustmentRule4);
				}
			}
			byte[] array3 = registryKey.GetValue(num2.ToString(CultureInfo.InvariantCulture), null, RegistryValueOptions.None) as byte[];
			timeZoneInformation = new Win32Native.RegistryTimeZoneInformation(array3);
			if (array3 == null || array3.Length != 44)
			{
				rules = null;
				return false;
			}
			AdjustmentRule adjustmentRule5 = CreateAdjustmentRuleFromTimeZoneInformation(timeZoneInformation, new DateTime(num2, 1, 1), DateTime.MaxValue.Date, defaultBaseUtcOffset);
			if (adjustmentRule5 != null)
			{
				list.Add(adjustmentRule5);
			}
			rules = list.ToArray();
			if (rules != null && rules.Length == 0)
			{
				rules = null;
			}
		}
		catch (InvalidCastException ex)
		{
			rules = null;
			e = ex;
			return false;
		}
		catch (ArgumentOutOfRangeException ex2)
		{
			rules = null;
			e = ex2;
			return false;
		}
		catch (ArgumentException ex3)
		{
			rules = null;
			e = ex3;
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private static bool TryCompareStandardDate(Win32Native.TimeZoneInformation timeZone, Win32Native.RegistryTimeZoneInformation registryTimeZoneInfo)
	{
		if (timeZone.Bias == registryTimeZoneInfo.Bias && timeZone.StandardBias == registryTimeZoneInfo.StandardBias && timeZone.StandardDate.Year == registryTimeZoneInfo.StandardDate.Year && timeZone.StandardDate.Month == registryTimeZoneInfo.StandardDate.Month && timeZone.StandardDate.DayOfWeek == registryTimeZoneInfo.StandardDate.DayOfWeek && timeZone.StandardDate.Day == registryTimeZoneInfo.StandardDate.Day && timeZone.StandardDate.Hour == registryTimeZoneInfo.StandardDate.Hour && timeZone.StandardDate.Minute == registryTimeZoneInfo.StandardDate.Minute && timeZone.StandardDate.Second == registryTimeZoneInfo.StandardDate.Second)
		{
			return timeZone.StandardDate.Milliseconds == registryTimeZoneInfo.StandardDate.Milliseconds;
		}
		return false;
	}

	[SecuritySafeCritical]
	private static bool TryCompareTimeZoneInformationToRegistry(Win32Native.TimeZoneInformation timeZone, string id, out bool dstDisabled)
	{
		dstDisabled = false;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				return false;
			}
			byte[] array = (byte[])registryKey.GetValue("TZI", null, RegistryValueOptions.None);
			if (array == null || array.Length != 44)
			{
				return false;
			}
			Win32Native.RegistryTimeZoneInformation registryTimeZoneInfo = new Win32Native.RegistryTimeZoneInformation(array);
			if (!TryCompareStandardDate(timeZone, registryTimeZoneInfo))
			{
				return false;
			}
			bool flag = dstDisabled || CheckDaylightSavingTimeNotSupported(timeZone) || (timeZone.DaylightBias == registryTimeZoneInfo.DaylightBias && timeZone.DaylightDate.Year == registryTimeZoneInfo.DaylightDate.Year && timeZone.DaylightDate.Month == registryTimeZoneInfo.DaylightDate.Month && timeZone.DaylightDate.DayOfWeek == registryTimeZoneInfo.DaylightDate.DayOfWeek && timeZone.DaylightDate.Day == registryTimeZoneInfo.DaylightDate.Day && timeZone.DaylightDate.Hour == registryTimeZoneInfo.DaylightDate.Hour && timeZone.DaylightDate.Minute == registryTimeZoneInfo.DaylightDate.Minute && timeZone.DaylightDate.Second == registryTimeZoneInfo.DaylightDate.Second && timeZone.DaylightDate.Milliseconds == registryTimeZoneInfo.DaylightDate.Milliseconds);
			if (flag)
			{
				string strA = registryKey.GetValue("Std", string.Empty, RegistryValueOptions.None) as string;
				flag = string.Compare(strA, timeZone.StandardName, StringComparison.Ordinal) == 0;
			}
			return flag;
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
	}

	[SecuritySafeCritical]
	[FileIOPermission(SecurityAction.Assert, AllLocalFiles = FileIOPermissionAccess.PathDiscovery)]
	private static string TryGetLocalizedNameByMuiNativeResource(string resource)
	{
		if (string.IsNullOrEmpty(resource))
		{
			return string.Empty;
		}
		string[] array = resource.Split(new char[1] { ',' }, StringSplitOptions.None);
		if (array.Length != 2)
		{
			return string.Empty;
		}
		string path = Environment.UnsafeGetFolderPath(Environment.SpecialFolder.System);
		string path2 = array[0].TrimStart('@');
		string filePath;
		try
		{
			filePath = Path.Combine(path, path2);
		}
		catch (ArgumentException)
		{
			return string.Empty;
		}
		if (!int.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out var result))
		{
			return string.Empty;
		}
		result = -result;
		try
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(260);
			stringBuilder.Length = 260;
			int fileMuiPathLength = 260;
			int languageLength = 0;
			long enumerator = 0L;
			if (!UnsafeNativeMethods.GetFileMUIPath(16, filePath, null, ref languageLength, stringBuilder, ref fileMuiPathLength, ref enumerator))
			{
				StringBuilderCache.Release(stringBuilder);
				return string.Empty;
			}
			return TryGetLocalizedNameByNativeResource(StringBuilderCache.GetStringAndRelease(stringBuilder), result);
		}
		catch (EntryPointNotFoundException)
		{
			return string.Empty;
		}
	}

	[SecurityCritical]
	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
	{
		using (SafeLibraryHandle safeLibraryHandle = UnsafeNativeMethods.LoadLibraryEx(filePath, IntPtr.Zero, 2))
		{
			if (!safeLibraryHandle.IsInvalid)
			{
				StringBuilder stringBuilder = StringBuilderCache.Acquire(500);
				stringBuilder.Length = 500;
				if (UnsafeNativeMethods.LoadString(safeLibraryHandle, resource, stringBuilder, stringBuilder.Length) != 0)
				{
					return StringBuilderCache.GetStringAndRelease(stringBuilder);
				}
			}
		}
		return string.Empty;
	}

	private static bool TryGetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
	{
		displayName = string.Empty;
		standardName = string.Empty;
		daylightName = string.Empty;
		string text = key.GetValue("MUI_Display", string.Empty, RegistryValueOptions.None) as string;
		string text2 = key.GetValue("MUI_Std", string.Empty, RegistryValueOptions.None) as string;
		string text3 = key.GetValue("MUI_Dlt", string.Empty, RegistryValueOptions.None) as string;
		if (!string.IsNullOrEmpty(text))
		{
			displayName = TryGetLocalizedNameByMuiNativeResource(text);
		}
		if (!string.IsNullOrEmpty(text2))
		{
			standardName = TryGetLocalizedNameByMuiNativeResource(text2);
		}
		if (!string.IsNullOrEmpty(text3))
		{
			daylightName = TryGetLocalizedNameByMuiNativeResource(text3);
		}
		if (string.IsNullOrEmpty(displayName))
		{
			displayName = key.GetValue("Display", string.Empty, RegistryValueOptions.None) as string;
		}
		if (string.IsNullOrEmpty(standardName))
		{
			standardName = key.GetValue("Std", string.Empty, RegistryValueOptions.None) as string;
		}
		if (string.IsNullOrEmpty(daylightName))
		{
			daylightName = key.GetValue("Dlt", string.Empty, RegistryValueOptions.None) as string;
		}
		return true;
	}

	[SecuritySafeCritical]
	private static TimeZoneInfoResult TryGetTimeZoneByRegistryKey(string id, out TimeZoneInfo value, out Exception e)
	{
		e = null;
		try
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(new RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones"));
			permissionSet.Assert();
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Time Zones", id), RegistryKeyPermissionCheck.Default, RegistryRights.ExecuteKey);
			if (registryKey == null)
			{
				value = null;
				return TimeZoneInfoResult.TimeZoneNotFoundException;
			}
			if (!(registryKey.GetValue("TZI", null, RegistryValueOptions.None) is byte[] array) || array.Length != 44)
			{
				value = null;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			Win32Native.RegistryTimeZoneInformation defaultTimeZoneInformation = new Win32Native.RegistryTimeZoneInformation(array);
			if (!TryCreateAdjustmentRules(id, defaultTimeZoneInformation, out var rules, out e, defaultTimeZoneInformation.Bias))
			{
				value = null;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			if (!TryGetLocalizedNamesByRegistryKey(registryKey, out var displayName, out var standardName, out var daylightName))
			{
				value = null;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			try
			{
				value = new TimeZoneInfo(id, new TimeSpan(0, -defaultTimeZoneInformation.Bias, 0), displayName, standardName, daylightName, rules, disableDaylightSavingTime: false);
				return TimeZoneInfoResult.Success;
			}
			catch (ArgumentException ex)
			{
				value = null;
				e = ex;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
			catch (InvalidTimeZoneException ex2)
			{
				value = null;
				e = ex2;
				return TimeZoneInfoResult.InvalidTimeZoneException;
			}
		}
		finally
		{
			PermissionSet.RevertAssert();
		}
	}

	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData)
	{
		TimeZoneInfoResult result = TimeZoneInfoResult.Success;
		e = null;
		TimeZoneInfo value2 = null;
		if (cachedData.m_systemTimeZones != null && cachedData.m_systemTimeZones.TryGetValue(id, out value2))
		{
			if (dstDisabled && value2.m_supportsDaylightSavingTime)
			{
				value = CreateCustomTimeZone(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName);
			}
			else
			{
				value = new TimeZoneInfo(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName, value2.m_daylightDisplayName, value2.m_adjustmentRules, disableDaylightSavingTime: false);
			}
			return result;
		}
		if (!cachedData.m_allSystemTimeZonesRead)
		{
			result = TryGetTimeZoneByRegistryKey(id, out value2, out e);
			if (result == TimeZoneInfoResult.Success)
			{
				if (cachedData.m_systemTimeZones == null)
				{
					cachedData.m_systemTimeZones = new Dictionary<string, TimeZoneInfo>();
				}
				cachedData.m_systemTimeZones.Add(id, value2);
				if (dstDisabled && value2.m_supportsDaylightSavingTime)
				{
					value = CreateCustomTimeZone(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName);
				}
				else
				{
					value = new TimeZoneInfo(value2.m_id, value2.m_baseUtcOffset, value2.m_displayName, value2.m_standardDisplayName, value2.m_daylightDisplayName, value2.m_adjustmentRules, disableDaylightSavingTime: false);
				}
			}
			else
			{
				value = null;
			}
		}
		else
		{
			result = TimeZoneInfoResult.TimeZoneNotFoundException;
			value = null;
		}
		return result;
	}

	internal static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		if (!(offset.TotalHours < -14.0))
		{
			return offset.TotalHours > 14.0;
		}
		return true;
	}

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (id.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidId", id), "id");
		}
		if (UtcOffsetOutOfRange(baseUtcOffset))
		{
			throw new ArgumentOutOfRangeException("baseUtcOffset", Environment.GetResourceString("ArgumentOutOfRange_UtcOffset"));
		}
		if (baseUtcOffset.Ticks % 600000000 != 0L)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TimeSpanHasSeconds"), "baseUtcOffset");
		}
		adjustmentRulesSupportDst = false;
		if (adjustmentRules == null || adjustmentRules.Length == 0)
		{
			return;
		}
		adjustmentRulesSupportDst = true;
		AdjustmentRule adjustmentRule = null;
		AdjustmentRule adjustmentRule2 = null;
		for (int i = 0; i < adjustmentRules.Length; i++)
		{
			adjustmentRule = adjustmentRule2;
			adjustmentRule2 = adjustmentRules[i];
			if (adjustmentRule2 == null)
			{
				throw new InvalidTimeZoneException(Environment.GetResourceString("Argument_AdjustmentRulesNoNulls"));
			}
			if (UtcOffsetOutOfRange(baseUtcOffset + adjustmentRule2.DaylightDelta))
			{
				throw new InvalidTimeZoneException(Environment.GetResourceString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta"));
			}
			if (adjustmentRule != null && adjustmentRule2.DateStart <= adjustmentRule.DateEnd)
			{
				throw new InvalidTimeZoneException(Environment.GetResourceString("Argument_AdjustmentRulesOutOfOrder"));
			}
		}
	}
}

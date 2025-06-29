using System.Text;

namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum TimeSpanThrowStyle
	{
		None,
		All
	}

	private enum ParseFailureKind
	{
		None,
		ArgumentNull,
		Format,
		FormatWithParameter,
		Overflow
	}

	[Flags]
	private enum TimeSpanStandardStyles
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3
	}

	private enum TTT
	{
		None,
		End,
		Num,
		Sep,
		NumOverflow
	}

	private struct TimeSpanToken
	{
		internal TTT ttt;

		internal int num;

		internal int zeroes;

		internal string sep;

		public TimeSpanToken(int number)
		{
			ttt = TTT.Num;
			num = number;
			zeroes = 0;
			sep = null;
		}

		public TimeSpanToken(int leadingZeroes, int number)
		{
			ttt = TTT.Num;
			num = number;
			zeroes = leadingZeroes;
			sep = null;
		}

		public bool IsInvalidNumber(int maxValue, int maxPrecision)
		{
			if (num > maxValue)
			{
				return true;
			}
			if (maxPrecision == -1)
			{
				return false;
			}
			if (zeroes > maxPrecision)
			{
				return true;
			}
			if (num == 0 || zeroes == 0)
			{
				return false;
			}
			return num >= maxValue / (long)Math.Pow(10.0, zeroes - 1);
		}
	}

	private struct TimeSpanTokenizer
	{
		private int m_pos;

		private string m_value;

		internal bool EOL => m_pos >= m_value.Length - 1;

		internal char NextChar
		{
			get
			{
				m_pos++;
				return CurrentChar;
			}
		}

		internal char CurrentChar
		{
			get
			{
				if (m_pos > -1 && m_pos < m_value.Length)
				{
					return m_value[m_pos];
				}
				return '\0';
			}
		}

		internal void Init(string input)
		{
			Init(input, 0);
		}

		internal void Init(string input, int startPosition)
		{
			m_pos = startPosition;
			m_value = input;
		}

		internal TimeSpanToken GetNextToken()
		{
			TimeSpanToken result = default(TimeSpanToken);
			char c = CurrentChar;
			switch (c)
			{
			case '\0':
				result.ttt = TTT.End;
				return result;
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				result.ttt = TTT.Num;
				result.num = 0;
				result.zeroes = 0;
				do
				{
					if ((result.num & 0xF0000000u) != 0L)
					{
						result.ttt = TTT.NumOverflow;
						return result;
					}
					result.num = result.num * 10 + c - 48;
					if (result.num == 0)
					{
						result.zeroes++;
					}
					if (result.num < 0)
					{
						result.ttt = TTT.NumOverflow;
						return result;
					}
					c = NextChar;
				}
				while (c >= '0' && c <= '9');
				return result;
			default:
			{
				result.ttt = TTT.Sep;
				int pos = m_pos;
				int num = 0;
				while (c != 0 && (c < '0' || '9' < c))
				{
					c = NextChar;
					num++;
				}
				result.sep = m_value.Substring(pos, num);
				return result;
			}
			}
		}

		internal void BackOne()
		{
			if (m_pos > 0)
			{
				m_pos--;
			}
		}
	}

	private struct TimeSpanRawInfo
	{
		internal TTT lastSeenTTT;

		internal int tokenCount;

		internal int SepCount;

		internal int NumCount;

		internal string[] literals;

		internal TimeSpanToken[] numbers;

		private TimeSpanFormat.FormatLiterals m_posLoc;

		private TimeSpanFormat.FormatLiterals m_negLoc;

		private bool m_posLocInit;

		private bool m_negLocInit;

		private string m_fullPosPattern;

		private string m_fullNegPattern;

		private const int MaxTokens = 11;

		private const int MaxLiteralTokens = 6;

		private const int MaxNumericTokens = 5;

		internal TimeSpanFormat.FormatLiterals PositiveInvariant => TimeSpanFormat.PositiveInvariantFormatLiterals;

		internal TimeSpanFormat.FormatLiterals NegativeInvariant => TimeSpanFormat.NegativeInvariantFormatLiterals;

		internal TimeSpanFormat.FormatLiterals PositiveLocalized
		{
			get
			{
				if (!m_posLocInit)
				{
					m_posLoc = default(TimeSpanFormat.FormatLiterals);
					m_posLoc.Init(m_fullPosPattern, useInvariantFieldLengths: false);
					m_posLocInit = true;
				}
				return m_posLoc;
			}
		}

		internal TimeSpanFormat.FormatLiterals NegativeLocalized
		{
			get
			{
				if (!m_negLocInit)
				{
					m_negLoc = default(TimeSpanFormat.FormatLiterals);
					m_negLoc.Init(m_fullNegPattern, useInvariantFieldLengths: false);
					m_negLocInit = true;
				}
				return m_negLoc;
			}
		}

		internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 5 && NumCount == 4 && pattern.Start == literals[0] && pattern.DayHourSep == literals[1] && pattern.HourMinuteSep == literals[2] && pattern.AppCompatLiteral == literals[3])
			{
				return pattern.End == literals[4];
			}
			return false;
		}

		internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 4 && NumCount == 3 && pattern.Start == literals[0] && pattern.HourMinuteSep == literals[1] && pattern.AppCompatLiteral == literals[2])
			{
				return pattern.End == literals[3];
			}
			return false;
		}

		internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 6 && NumCount == 5 && pattern.Start == literals[0] && pattern.DayHourSep == literals[1] && pattern.HourMinuteSep == literals[2] && pattern.MinuteSecondSep == literals[3] && pattern.SecondFractionSep == literals[4])
			{
				return pattern.End == literals[5];
			}
			return false;
		}

		internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 2 && NumCount == 1 && pattern.Start == literals[0])
			{
				return pattern.End == literals[1];
			}
			return false;
		}

		internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 3 && NumCount == 2 && pattern.Start == literals[0] && pattern.HourMinuteSep == literals[1])
			{
				return pattern.End == literals[2];
			}
			return false;
		}

		internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 4 && NumCount == 3 && pattern.Start == literals[0] && pattern.DayHourSep == literals[1] && pattern.HourMinuteSep == literals[2])
			{
				return pattern.End == literals[3];
			}
			return false;
		}

		internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 4 && NumCount == 3 && pattern.Start == literals[0] && pattern.HourMinuteSep == literals[1] && pattern.MinuteSecondSep == literals[2])
			{
				return pattern.End == literals[3];
			}
			return false;
		}

		internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 5 && NumCount == 4 && pattern.Start == literals[0] && pattern.DayHourSep == literals[1] && pattern.HourMinuteSep == literals[2] && pattern.MinuteSecondSep == literals[3])
			{
				return pattern.End == literals[4];
			}
			return false;
		}

		internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			if (SepCount == 5 && NumCount == 4 && pattern.Start == literals[0] && pattern.HourMinuteSep == literals[1] && pattern.MinuteSecondSep == literals[2] && pattern.SecondFractionSep == literals[3])
			{
				return pattern.End == literals[4];
			}
			return false;
		}

		internal void Init(DateTimeFormatInfo dtfi)
		{
			lastSeenTTT = TTT.None;
			tokenCount = 0;
			SepCount = 0;
			NumCount = 0;
			literals = new string[6];
			numbers = new TimeSpanToken[5];
			m_fullPosPattern = dtfi.FullTimeSpanPositivePattern;
			m_fullNegPattern = dtfi.FullTimeSpanNegativePattern;
			m_posLocInit = false;
			m_negLocInit = false;
		}

		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result)
		{
			if (tok.ttt == TTT.NumOverflow)
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge", null);
				return false;
			}
			if (tok.ttt != TTT.Sep && tok.ttt != TTT.Num)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan", null);
				return false;
			}
			switch (tok.ttt)
			{
			case TTT.Sep:
				if (!AddSep(tok.sep, ref result))
				{
					return false;
				}
				break;
			case TTT.Num:
				if (tokenCount == 0 && !AddSep(string.Empty, ref result))
				{
					return false;
				}
				if (!AddNum(tok, ref result))
				{
					return false;
				}
				break;
			}
			lastSeenTTT = tok.ttt;
			return true;
		}

		private bool AddSep(string sep, ref TimeSpanResult result)
		{
			if (SepCount >= 6 || tokenCount >= 11)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan", null);
				return false;
			}
			literals[SepCount++] = sep;
			tokenCount++;
			return true;
		}

		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result)
		{
			if (NumCount >= 5 || tokenCount >= 11)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan", null);
				return false;
			}
			numbers[NumCount++] = num;
			tokenCount++;
			return true;
		}
	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan;

		internal TimeSpanThrowStyle throwStyle;

		internal ParseFailureKind m_failure;

		internal string m_failureMessageID;

		internal object m_failureMessageFormatArgument;

		internal string m_failureArgumentName;

		internal void Init(TimeSpanThrowStyle canThrow)
		{
			parsedTimeSpan = default(TimeSpan);
			throwStyle = canThrow;
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
			SetFailure(failure, failureMessageID, null, null);
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
			SetFailure(failure, failureMessageID, failureMessageFormatArgument, null);
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
		{
			m_failure = failure;
			m_failureMessageID = failureMessageID;
			m_failureMessageFormatArgument = failureMessageFormatArgument;
			m_failureArgumentName = failureArgumentName;
			if (throwStyle != TimeSpanThrowStyle.None)
			{
				throw GetTimeSpanParseException();
			}
		}

		internal Exception GetTimeSpanParseException()
		{
			return m_failure switch
			{
				ParseFailureKind.ArgumentNull => new ArgumentNullException(m_failureArgumentName, Environment.GetResourceString(m_failureMessageID)), 
				ParseFailureKind.FormatWithParameter => new FormatException(Environment.GetResourceString(m_failureMessageID, m_failureMessageFormatArgument)), 
				ParseFailureKind.Format => new FormatException(Environment.GetResourceString(m_failureMessageID)), 
				ParseFailureKind.Overflow => new OverflowException(Environment.GetResourceString(m_failureMessageID)), 
				_ => new FormatException(Environment.GetResourceString("Format_InvalidString")), 
			};
		}
	}

	private struct StringParser
	{
		private string str;

		private char ch;

		private int pos;

		private int len;

		internal void NextChar()
		{
			if (pos < len)
			{
				pos++;
			}
			ch = ((pos < len) ? str[pos] : '\0');
		}

		internal char NextNonDigit()
		{
			for (int i = pos; i < len; i++)
			{
				char c = str[i];
				if (c < '0' || c > '9')
				{
					return c;
				}
			}
			return '\0';
		}

		internal bool TryParse(string input, ref TimeSpanResult result)
		{
			result.parsedTimeSpan._ticks = 0L;
			if (input == null)
			{
				result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "input");
				return false;
			}
			str = input;
			len = input.Length;
			pos = -1;
			NextChar();
			SkipBlanks();
			bool flag = false;
			if (ch == '-')
			{
				flag = true;
				NextChar();
			}
			long time;
			if (NextNonDigit() == ':')
			{
				if (!ParseTime(out time, ref result))
				{
					return false;
				}
			}
			else
			{
				if (!ParseInt(10675199, out var i, ref result))
				{
					return false;
				}
				time = i * 864000000000L;
				if (ch == '.')
				{
					NextChar();
					if (!ParseTime(out var time2, ref result))
					{
						return false;
					}
					time += time2;
				}
			}
			if (flag)
			{
				time = -time;
				if (time > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			else if (time < 0)
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
				return false;
			}
			SkipBlanks();
			if (pos < len)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
				return false;
			}
			result.parsedTimeSpan._ticks = time;
			return true;
		}

		internal bool ParseInt(int max, out int i, ref TimeSpanResult result)
		{
			i = 0;
			int num = pos;
			while (ch >= '0' && ch <= '9')
			{
				if ((i & 0xF0000000u) != 0L)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
				i = i * 10 + ch - 48;
				if (i < 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
				NextChar();
			}
			if (num == pos)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
				return false;
			}
			if (i > max)
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
				return false;
			}
			return true;
		}

		internal bool ParseTime(out long time, ref TimeSpanResult result)
		{
			time = 0L;
			if (!ParseInt(23, out var i, ref result))
			{
				return false;
			}
			time = i * 36000000000L;
			if (ch != ':')
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
				return false;
			}
			NextChar();
			if (!ParseInt(59, out i, ref result))
			{
				return false;
			}
			time += (long)i * 600000000L;
			if (ch == ':')
			{
				NextChar();
				if (ch != '.')
				{
					if (!ParseInt(59, out i, ref result))
					{
						return false;
					}
					time += (long)i * 10000000L;
				}
				if (ch == '.')
				{
					NextChar();
					int num = 10000000;
					while (num > 1 && ch >= '0' && ch <= '9')
					{
						num /= 10;
						time += (ch - 48) * num;
						NextChar();
					}
				}
			}
			return true;
		}

		internal void SkipBlanks()
		{
			while (ch == ' ' || ch == '\t')
			{
				NextChar();
			}
		}
	}

	internal const int unlimitedDigits = -1;

	internal const int maxFractionDigits = 7;

	internal const int maxDays = 10675199;

	internal const int maxHours = 23;

	internal const int maxMinutes = 59;

	internal const int maxSeconds = 59;

	internal const int maxFraction = 9999999;

	private static readonly TimeSpanToken zero = new TimeSpanToken(0);

	internal static void ValidateStyles(TimeSpanStyles style, string parameterName)
	{
		if (style != TimeSpanStyles.None && style != TimeSpanStyles.AssumeNegative)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidTimeSpanStyles"), parameterName);
		}
	}

	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result)
	{
		if (days.IsInvalidNumber(10675199, -1) || hours.IsInvalidNumber(23, -1) || minutes.IsInvalidNumber(59, -1) || seconds.IsInvalidNumber(59, -1) || fraction.IsInvalidNumber(9999999, 7))
		{
			result = 0L;
			return false;
		}
		long num = ((long)days.num * 3600L * 24 + (long)hours.num * 3600L + (long)minutes.num * 60L + seconds.num) * 1000;
		if (num > 922337203685477L || num < -922337203685477L)
		{
			result = 0L;
			return false;
		}
		long num2 = fraction.num;
		if (num2 != 0L)
		{
			long num3 = 1000000L;
			if (fraction.zeroes > 0)
			{
				long num4 = (long)Math.Pow(10.0, fraction.zeroes);
				num3 /= num4;
			}
			while (num2 < num3)
			{
				num2 *= 10;
			}
		}
		result = num * 10000 + num2;
		if (positive && result < 0)
		{
			result = 0L;
			return false;
		}
		return true;
	}

	internal static TimeSpan Parse(string input, IFormatProvider formatProvider)
	{
		TimeSpanResult result = default(TimeSpanResult);
		result.Init(TimeSpanThrowStyle.All);
		if (TryParseTimeSpan(input, TimeSpanStandardStyles.Any, formatProvider, ref result))
		{
			return result.parsedTimeSpan;
		}
		throw result.GetTimeSpanParseException();
	}

	internal static bool TryParse(string input, IFormatProvider formatProvider, out TimeSpan result)
	{
		TimeSpanResult result2 = default(TimeSpanResult);
		result2.Init(TimeSpanThrowStyle.None);
		if (TryParseTimeSpan(input, TimeSpanStandardStyles.Any, formatProvider, ref result2))
		{
			result = result2.parsedTimeSpan;
			return true;
		}
		result = default(TimeSpan);
		return false;
	}

	internal static TimeSpan ParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		TimeSpanResult result = default(TimeSpanResult);
		result.Init(TimeSpanThrowStyle.All);
		if (TryParseExactTimeSpan(input, format, formatProvider, styles, ref result))
		{
			return result.parsedTimeSpan;
		}
		throw result.GetTimeSpanParseException();
	}

	internal static bool TryParseExact(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		TimeSpanResult result2 = default(TimeSpanResult);
		result2.Init(TimeSpanThrowStyle.None);
		if (TryParseExactTimeSpan(input, format, formatProvider, styles, ref result2))
		{
			result = result2.parsedTimeSpan;
			return true;
		}
		result = default(TimeSpan);
		return false;
	}

	internal static TimeSpan ParseExactMultiple(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
	{
		TimeSpanResult result = default(TimeSpanResult);
		result.Init(TimeSpanThrowStyle.All);
		if (TryParseExactMultipleTimeSpan(input, formats, formatProvider, styles, ref result))
		{
			return result.parsedTimeSpan;
		}
		throw result.GetTimeSpanParseException();
	}

	internal static bool TryParseExactMultiple(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
	{
		TimeSpanResult result2 = default(TimeSpanResult);
		result2.Init(TimeSpanThrowStyle.None);
		if (TryParseExactMultipleTimeSpan(input, formats, formatProvider, styles, ref result2))
		{
			result = result2.parsedTimeSpan;
			return true;
		}
		result = default(TimeSpan);
		return false;
	}

	private static bool TryParseTimeSpan(string input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result)
	{
		if (input == null)
		{
			result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "input");
			return false;
		}
		input = input.Trim();
		if (input == string.Empty)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		TimeSpanTokenizer timeSpanTokenizer = default(TimeSpanTokenizer);
		timeSpanTokenizer.Init(input);
		TimeSpanRawInfo raw = default(TimeSpanRawInfo);
		raw.Init(DateTimeFormatInfo.GetInstance(formatProvider));
		TimeSpanToken tok = timeSpanTokenizer.GetNextToken();
		while (tok.ttt != TTT.End)
		{
			if (!raw.ProcessToken(ref tok, ref result))
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
				return false;
			}
			tok = timeSpanTokenizer.GetNextToken();
		}
		if (!timeSpanTokenizer.EOL)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		if (!ProcessTerminalState(ref raw, style, ref result))
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		return true;
	}

	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.lastSeenTTT == TTT.Num)
		{
			TimeSpanToken tok = new TimeSpanToken
			{
				ttt = TTT.Sep,
				sep = string.Empty
			};
			if (!raw.ProcessToken(ref tok, ref result))
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
				return false;
			}
		}
		switch (raw.NumCount)
		{
		case 1:
			return ProcessTerminal_D(ref raw, style, ref result);
		case 2:
			return ProcessTerminal_HM(ref raw, style, ref result);
		case 3:
			return ProcessTerminal_HM_S_D(ref raw, style, ref result);
		case 4:
			return ProcessTerminal_HMS_F_D(ref raw, style, ref result);
		case 5:
			return ProcessTerminal_DHMSF(ref raw, style, ref result);
		default:
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
	}

	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.SepCount != 6 || raw.NumCount != 5)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		bool flag = (style & TimeSpanStandardStyles.Invariant) != 0;
		bool flag2 = (style & TimeSpanStandardStyles.Localized) != 0;
		bool flag3 = false;
		bool flag4 = false;
		if (flag)
		{
			if (raw.FullMatch(raw.PositiveInvariant))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullMatch(raw.NegativeInvariant))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		if (flag2)
		{
			if (!flag4 && raw.FullMatch(raw.PositiveLocalized))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullMatch(raw.NegativeLocalized))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		if (flag4)
		{
			if (!TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], raw.numbers[4], out var result2))
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
				return false;
			}
			if (!flag3)
			{
				result2 = -result2;
				if (result2 > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			result.parsedTimeSpan._ticks = result2;
			return true;
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.SepCount != 5 || raw.NumCount != 4 || (style & TimeSpanStandardStyles.RequireFull) != TimeSpanStandardStyles.None)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		bool flag = (style & TimeSpanStandardStyles.Invariant) != 0;
		bool flag2 = (style & TimeSpanStandardStyles.Localized) != 0;
		long result2 = 0L;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		if (flag)
		{
			if (raw.FullHMSFMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMSMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullAppCompatMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullHMSFMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMSMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullAppCompatMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
		}
		if (flag2)
		{
			if (!flag4 && raw.FullHMSFMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMSMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullAppCompatMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullHMSFMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMSMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], raw.numbers[3], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullAppCompatMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, raw.numbers[3], out result2);
				flag5 = flag5 || !flag4;
			}
		}
		if (flag4)
		{
			if (!flag3)
			{
				result2 = -result2;
				if (result2 > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			result.parsedTimeSpan._ticks = result2;
			return true;
		}
		if (flag5)
		{
			result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
			return false;
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.SepCount != 4 || raw.NumCount != 3 || (style & TimeSpanStandardStyles.RequireFull) != TimeSpanStandardStyles.None)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		bool flag = (style & TimeSpanStandardStyles.Invariant) != 0;
		bool flag2 = (style & TimeSpanStandardStyles.Localized) != 0;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		long result2 = 0L;
		if (flag)
		{
			if (raw.FullHMSMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.PartialAppCompatMatch(raw.PositiveInvariant))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], zero, raw.numbers[2], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullHMSMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.PartialAppCompatMatch(raw.NegativeInvariant))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], zero, raw.numbers[2], out result2);
				flag5 = flag5 || !flag4;
			}
		}
		if (flag2)
		{
			if (!flag4 && raw.FullHMSMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.PartialAppCompatMatch(raw.PositiveLocalized))
			{
				flag3 = true;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], zero, raw.numbers[2], out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullHMSMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.FullDHMMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, raw.numbers[0], raw.numbers[1], raw.numbers[2], zero, zero, out result2);
				flag5 = flag5 || !flag4;
			}
			if (!flag4 && raw.PartialAppCompatMatch(raw.NegativeLocalized))
			{
				flag3 = false;
				flag4 = TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], zero, raw.numbers[2], out result2);
				flag5 = flag5 || !flag4;
			}
		}
		if (flag4)
		{
			if (!flag3)
			{
				result2 = -result2;
				if (result2 > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			result.parsedTimeSpan._ticks = result2;
			return true;
		}
		if (flag5)
		{
			result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
			return false;
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}

	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.SepCount != 3 || raw.NumCount != 2 || (style & TimeSpanStandardStyles.RequireFull) != TimeSpanStandardStyles.None)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		bool flag = (style & TimeSpanStandardStyles.Invariant) != 0;
		bool flag2 = (style & TimeSpanStandardStyles.Localized) != 0;
		bool flag3 = false;
		bool flag4 = false;
		if (flag)
		{
			if (raw.FullHMMatch(raw.PositiveInvariant))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullHMMatch(raw.NegativeInvariant))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		if (flag2)
		{
			if (!flag4 && raw.FullHMMatch(raw.PositiveLocalized))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullHMMatch(raw.NegativeLocalized))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		long result2 = 0L;
		if (flag4)
		{
			if (!TryTimeToTicks(flag3, zero, raw.numbers[0], raw.numbers[1], zero, zero, out result2))
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
				return false;
			}
			if (!flag3)
			{
				result2 = -result2;
				if (result2 > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			result.parsedTimeSpan._ticks = result2;
			return true;
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}

	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		if (raw.SepCount != 2 || raw.NumCount != 1 || (style & TimeSpanStandardStyles.RequireFull) != TimeSpanStandardStyles.None)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		bool flag = (style & TimeSpanStandardStyles.Invariant) != 0;
		bool flag2 = (style & TimeSpanStandardStyles.Localized) != 0;
		bool flag3 = false;
		bool flag4 = false;
		if (flag)
		{
			if (raw.FullDMatch(raw.PositiveInvariant))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullDMatch(raw.NegativeInvariant))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		if (flag2)
		{
			if (!flag4 && raw.FullDMatch(raw.PositiveLocalized))
			{
				flag4 = true;
				flag3 = true;
			}
			if (!flag4 && raw.FullDMatch(raw.NegativeLocalized))
			{
				flag4 = true;
				flag3 = false;
			}
		}
		long result2 = 0L;
		if (flag4)
		{
			if (!TryTimeToTicks(flag3, raw.numbers[0], zero, zero, zero, zero, out result2))
			{
				result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
				return false;
			}
			if (!flag3)
			{
				result2 = -result2;
				if (result2 > 0)
				{
					result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
					return false;
				}
			}
			result.parsedTimeSpan._ticks = result2;
			return true;
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}

	private static bool TryParseExactTimeSpan(string input, string format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		if (input == null)
		{
			result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "input");
			return false;
		}
		if (format == null)
		{
			result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "format");
			return false;
		}
		if (format.Length == 0)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadFormatSpecifier");
			return false;
		}
		if (format.Length == 1)
		{
			TimeSpanStandardStyles timeSpanStandardStyles = TimeSpanStandardStyles.None;
			if (format[0] == 'c' || format[0] == 't' || format[0] == 'T')
			{
				return TryParseTimeSpanConstant(input, ref result);
			}
			if (format[0] == 'g')
			{
				timeSpanStandardStyles = TimeSpanStandardStyles.Localized;
			}
			else
			{
				if (format[0] != 'G')
				{
					result.SetFailure(ParseFailureKind.Format, "Format_BadFormatSpecifier");
					return false;
				}
				timeSpanStandardStyles = TimeSpanStandardStyles.Localized | TimeSpanStandardStyles.RequireFull;
			}
			return TryParseTimeSpan(input, timeSpanStandardStyles, formatProvider, ref result);
		}
		return TryParseByFormat(input, format, styles, ref result);
	}

	private static bool TryParseByFormat(string input, string format, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		int result2 = 0;
		int result3 = 0;
		int result4 = 0;
		int result5 = 0;
		int zeroes = 0;
		int result6 = 0;
		int i = 0;
		int returnValue = 0;
		TimeSpanTokenizer tokenizer = default(TimeSpanTokenizer);
		tokenizer.Init(input, -1);
		for (; i < format.Length; i += returnValue)
		{
			char c = format[i];
			switch (c)
			{
			case 'h':
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (returnValue > 2 || flag2 || !ParseExactDigits(ref tokenizer, returnValue, out result3))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				flag2 = true;
				break;
			case 'm':
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (returnValue > 2 || flag3 || !ParseExactDigits(ref tokenizer, returnValue, out result4))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				flag3 = true;
				break;
			case 's':
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (returnValue > 2 || flag4 || !ParseExactDigits(ref tokenizer, returnValue, out result5))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				flag4 = true;
				break;
			case 'f':
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (returnValue > 7 || flag5 || !ParseExactDigits(ref tokenizer, returnValue, returnValue, out zeroes, out result6))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				flag5 = true;
				break;
			case 'F':
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (returnValue > 7 || flag5)
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				ParseExactDigits(ref tokenizer, returnValue, returnValue, out zeroes, out result6);
				flag5 = true;
				break;
			case 'd':
			{
				returnValue = DateTimeFormat.ParseRepeatPattern(format, i, c);
				int zeroes2 = 0;
				if (returnValue > 8 || flag || !ParseExactDigits(ref tokenizer, (returnValue < 2) ? 1 : returnValue, (returnValue < 2) ? 8 : returnValue, out zeroes2, out result2))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				flag = true;
				break;
			}
			case '"':
			case '\'':
			{
				StringBuilder stringBuilder = new StringBuilder();
				if (!DateTimeParse.TryParseQuoteString(format, i, stringBuilder, out returnValue))
				{
					result.SetFailure(ParseFailureKind.FormatWithParameter, "Format_BadQuote", c);
					return false;
				}
				if (!ParseExactLiteral(ref tokenizer, stringBuilder))
				{
					result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
					return false;
				}
				break;
			}
			case '%':
			{
				int num = DateTimeFormat.ParseNextChar(format, i);
				if (num >= 0 && num != 37)
				{
					returnValue = 1;
					break;
				}
				result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
				return false;
			}
			case '\\':
			{
				int num = DateTimeFormat.ParseNextChar(format, i);
				if (num >= 0 && tokenizer.NextChar == (ushort)num)
				{
					returnValue = 2;
					break;
				}
				result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
				return false;
			}
			default:
				result.SetFailure(ParseFailureKind.Format, "Format_InvalidString");
				return false;
			}
		}
		if (!tokenizer.EOL)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		long result7 = 0L;
		bool flag6 = (styles & TimeSpanStyles.AssumeNegative) == 0;
		if (TryTimeToTicks(flag6, new TimeSpanToken(result2), new TimeSpanToken(result3), new TimeSpanToken(result4), new TimeSpanToken(result5), new TimeSpanToken(zeroes, result6), out result7))
		{
			if (!flag6)
			{
				result7 = -result7;
			}
			result.parsedTimeSpan._ticks = result7;
			return true;
		}
		result.SetFailure(ParseFailureKind.Overflow, "Overflow_TimeSpanElementTooLarge");
		return false;
	}

	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, out int result)
	{
		result = 0;
		int zeroes = 0;
		int maxDigitLength = ((minDigitLength == 1) ? 2 : minDigitLength);
		return ParseExactDigits(ref tokenizer, minDigitLength, maxDigitLength, out zeroes, out result);
	}

	private static bool ParseExactDigits(ref TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result)
	{
		result = 0;
		zeroes = 0;
		int i;
		for (i = 0; i < maxDigitLength; i++)
		{
			char nextChar = tokenizer.NextChar;
			if (nextChar < '0' || nextChar > '9')
			{
				tokenizer.BackOne();
				break;
			}
			result = result * 10 + (nextChar - 48);
			if (result == 0)
			{
				zeroes++;
			}
		}
		return i >= minDigitLength;
	}

	private static bool ParseExactLiteral(ref TimeSpanTokenizer tokenizer, StringBuilder enquotedString)
	{
		for (int i = 0; i < enquotedString.Length; i++)
		{
			if (enquotedString[i] != tokenizer.NextChar)
			{
				return false;
			}
		}
		return true;
	}

	private static bool TryParseTimeSpanConstant(string input, ref TimeSpanResult result)
	{
		return default(StringParser).TryParse(input, ref result);
	}

	private static bool TryParseExactMultipleTimeSpan(string input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanResult result)
	{
		if (input == null)
		{
			result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "input");
			return false;
		}
		if (formats == null)
		{
			result.SetFailure(ParseFailureKind.ArgumentNull, "ArgumentNull_String", null, "formats");
			return false;
		}
		if (input.Length == 0)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
			return false;
		}
		if (formats.Length == 0)
		{
			result.SetFailure(ParseFailureKind.Format, "Format_BadFormatSpecifier");
			return false;
		}
		for (int i = 0; i < formats.Length; i++)
		{
			if (formats[i] == null || formats[i].Length == 0)
			{
				result.SetFailure(ParseFailureKind.Format, "Format_BadFormatSpecifier");
				return false;
			}
			TimeSpanResult result2 = default(TimeSpanResult);
			result2.Init(TimeSpanThrowStyle.None);
			if (TryParseExactTimeSpan(input, formats[i], formatProvider, styles, ref result2))
			{
				result.parsedTimeSpan = result2.parsedTimeSpan;
				return true;
			}
		}
		result.SetFailure(ParseFailureKind.Format, "Format_BadTimeSpan");
		return false;
	}
}

using System.Globalization;
using System.Security;
using System.Threading;

namespace System;

internal struct __DTString
{
	internal string Value;

	internal int Index;

	internal int len;

	internal char m_current;

	private CompareInfo m_info;

	private bool m_checkDigitToken;

	private static char[] WhiteSpaceChecks = new char[2] { ' ', '\u00a0' };

	internal CompareInfo CompareInfo => m_info;

	internal __DTString(string str, DateTimeFormatInfo dtfi, bool checkDigitToken)
		: this(str, dtfi)
	{
		m_checkDigitToken = checkDigitToken;
	}

	internal __DTString(string str, DateTimeFormatInfo dtfi)
	{
		Index = -1;
		Value = str;
		len = Value.Length;
		m_current = '\0';
		if (dtfi != null)
		{
			m_info = dtfi.CompareInfo;
			m_checkDigitToken = (dtfi.FormatFlags & DateTimeFormatFlags.UseDigitPrefixInTokens) != 0;
		}
		else
		{
			m_info = Thread.CurrentThread.CurrentCulture.CompareInfo;
			m_checkDigitToken = false;
		}
	}

	internal bool GetNext()
	{
		Index++;
		if (Index < len)
		{
			m_current = Value[Index];
			return true;
		}
		return false;
	}

	internal bool AtEnd()
	{
		if (Index >= len)
		{
			return true;
		}
		return false;
	}

	internal bool Advance(int count)
	{
		Index += count;
		if (Index < len)
		{
			m_current = Value[Index];
			return true;
		}
		return false;
	}

	[SecurityCritical]
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
	{
		tokenValue = 0;
		if (Index >= len)
		{
			tokenType = TokenType.EndOfString;
			return;
		}
		tokenType = TokenType.UnknownToken;
		while (true)
		{
			if (DateTimeParse.IsDigit(m_current))
			{
				tokenValue = m_current - 48;
				int index = Index;
				while (++Index < len)
				{
					m_current = Value[Index];
					int num = m_current - 48;
					if (num < 0 || num > 9)
					{
						break;
					}
					tokenValue = tokenValue * 10 + num;
				}
				if (Index - index > 8)
				{
					tokenType = TokenType.NumberToken;
					tokenValue = -1;
				}
				else if (Index - index < 3)
				{
					tokenType = TokenType.NumberToken;
				}
				else
				{
					tokenType = TokenType.YearNumberToken;
				}
				if (m_checkDigitToken)
				{
					int index2 = Index;
					char current = m_current;
					Index = index;
					m_current = Value[Index];
					if (dtfi.Tokenize(TokenType.RegularTokenMask, out var tokenType2, out var tokenValue2, ref this))
					{
						tokenType = tokenType2;
						tokenValue = tokenValue2;
					}
					else
					{
						Index = index2;
						m_current = current;
					}
				}
				break;
			}
			if (char.IsWhiteSpace(m_current))
			{
				do
				{
					if (++Index < len)
					{
						m_current = Value[Index];
						continue;
					}
					tokenType = TokenType.EndOfString;
					return;
				}
				while (char.IsWhiteSpace(m_current));
				continue;
			}
			dtfi.Tokenize(TokenType.RegularTokenMask, out tokenType, out tokenValue, ref this);
			break;
		}
	}

	[SecurityCritical]
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
	{
		indexBeforeSeparator = Index;
		charBeforeSeparator = m_current;
		if (!SkipWhiteSpaceCurrent())
		{
			return TokenType.SEP_End;
		}
		if (!DateTimeParse.IsDigit(m_current))
		{
			if (!dtfi.Tokenize(TokenType.SeparatorTokenMask, out var tokenType, out var _, ref this))
			{
				return TokenType.SEP_Space;
			}
			return tokenType;
		}
		return TokenType.SEP_Space;
	}

	internal bool MatchSpecifiedWord(string target)
	{
		return MatchSpecifiedWord(target, target.Length + Index);
	}

	internal bool MatchSpecifiedWord(string target, int endIndex)
	{
		int num = endIndex - Index;
		if (num != target.Length)
		{
			return false;
		}
		if (Index + num > len)
		{
			return false;
		}
		return m_info.Compare(Value, Index, num, target, 0, num, CompareOptions.IgnoreCase) == 0;
	}

	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
	{
		int num = Value.Length - Index;
		matchLength = target.Length;
		if (matchLength > num || m_info.Compare(Value, Index, matchLength, target, 0, matchLength, CompareOptions.IgnoreCase) != 0)
		{
			int num2 = 0;
			int num3 = Index;
			int num4 = target.IndexOfAny(WhiteSpaceChecks, num2);
			if (num4 == -1)
			{
				return false;
			}
			do
			{
				int num5 = num4 - num2;
				if (num3 >= Value.Length - num5)
				{
					return false;
				}
				if (num5 == 0)
				{
					matchLength--;
				}
				else
				{
					if (!char.IsWhiteSpace(Value[num3 + num5]))
					{
						return false;
					}
					if (m_info.Compare(Value, num3, num5, target, num2, num5, CompareOptions.IgnoreCase) != 0)
					{
						return false;
					}
					num3 = num3 + num5 + 1;
				}
				num2 = num4 + 1;
				while (num3 < Value.Length && char.IsWhiteSpace(Value[num3]))
				{
					num3++;
					matchLength++;
				}
			}
			while ((num4 = target.IndexOfAny(WhiteSpaceChecks, num2)) >= 0);
			if (num2 < target.Length)
			{
				int num6 = target.Length - num2;
				if (num3 > Value.Length - num6)
				{
					return false;
				}
				if (m_info.Compare(Value, num3, num6, target, num2, num6, CompareOptions.IgnoreCase) != 0)
				{
					return false;
				}
			}
		}
		if (checkWordBoundary)
		{
			int num7 = Index + matchLength;
			if (num7 < Value.Length && char.IsLetter(Value[num7]))
			{
				return false;
			}
		}
		return true;
	}

	internal bool Match(string str)
	{
		if (++Index >= len)
		{
			return false;
		}
		if (str.Length > Value.Length - Index)
		{
			return false;
		}
		if (m_info.Compare(Value, Index, str.Length, str, 0, str.Length, CompareOptions.Ordinal) == 0)
		{
			Index += str.Length - 1;
			return true;
		}
		return false;
	}

	internal bool Match(char ch)
	{
		if (++Index >= len)
		{
			return false;
		}
		if (Value[Index] == ch)
		{
			m_current = ch;
			return true;
		}
		Index--;
		return false;
	}

	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen)
	{
		int result = -1;
		for (int i = 0; i < words.Length; i++)
		{
			string text = words[i];
			int matchLength = text.Length;
			if (MatchSpecifiedWords(text, checkWordBoundary: false, ref matchLength) && matchLength > maxMatchStrLen)
			{
				maxMatchStrLen = matchLength;
				result = i;
			}
		}
		return result;
	}

	internal int GetRepeatCount()
	{
		char c = Value[Index];
		int i;
		for (i = Index + 1; i < len && Value[i] == c; i++)
		{
		}
		int result = i - Index;
		Index = i - 1;
		return result;
	}

	internal bool GetNextDigit()
	{
		if (++Index >= len)
		{
			return false;
		}
		return DateTimeParse.IsDigit(Value[Index]);
	}

	internal char GetChar()
	{
		return Value[Index];
	}

	internal int GetDigit()
	{
		return Value[Index] - 48;
	}

	internal void SkipWhiteSpaces()
	{
		while (Index + 1 < len)
		{
			char c = Value[Index + 1];
			if (!char.IsWhiteSpace(c))
			{
				break;
			}
			Index++;
		}
	}

	internal bool SkipWhiteSpaceCurrent()
	{
		if (Index >= len)
		{
			return false;
		}
		if (!char.IsWhiteSpace(m_current))
		{
			return true;
		}
		while (++Index < len)
		{
			m_current = Value[Index];
			if (!char.IsWhiteSpace(m_current))
			{
				return true;
			}
		}
		return false;
	}

	internal void TrimTail()
	{
		int num = len - 1;
		while (num >= 0 && char.IsWhiteSpace(Value[num]))
		{
			num--;
		}
		Value = Value.Substring(0, num + 1);
		len = Value.Length;
	}

	internal void RemoveTrailingInQuoteSpaces()
	{
		int num = len - 1;
		if (num <= 1)
		{
			return;
		}
		char c = Value[num];
		if ((c == '\'' || c == '"') && char.IsWhiteSpace(Value[num - 1]))
		{
			num--;
			while (num >= 1 && char.IsWhiteSpace(Value[num - 1]))
			{
				num--;
			}
			Value = Value.Remove(num, Value.Length - 1 - num);
			len = Value.Length;
		}
	}

	internal void RemoveLeadingInQuoteSpaces()
	{
		if (len <= 2)
		{
			return;
		}
		int i = 0;
		char c = Value[i];
		if (c == '\'' || c == '"')
		{
			for (; i + 1 < len && char.IsWhiteSpace(Value[i + 1]); i++)
			{
			}
			if (i != 0)
			{
				Value = Value.Remove(1, i);
				len = Value.Length;
			}
		}
	}

	internal DTSubString GetSubString()
	{
		DTSubString result = new DTSubString
		{
			index = Index,
			s = Value
		};
		while (Index + result.length < len)
		{
			char c = Value[Index + result.length];
			DTSubStringType dTSubStringType = ((c < '0' || c > '9') ? DTSubStringType.Other : DTSubStringType.Number);
			if (result.length == 0)
			{
				result.type = dTSubStringType;
			}
			else if (result.type != dTSubStringType)
			{
				break;
			}
			result.length++;
			if (dTSubStringType != DTSubStringType.Number)
			{
				break;
			}
			if (result.length > 8)
			{
				result.type = DTSubStringType.Invalid;
				return result;
			}
			int num = c - 48;
			result.value = result.value * 10 + num;
		}
		if (result.length == 0)
		{
			result.type = DTSubStringType.End;
			return result;
		}
		return result;
	}

	internal void ConsumeSubString(DTSubString sub)
	{
		Index = sub.index + sub.length;
		if (Index < len)
		{
			m_current = Value[Index];
		}
	}
}

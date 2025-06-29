using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexBoyerMoore
{
	internal int[] _positive;

	internal int[] _negativeASCII;

	internal int[][] _negativeUnicode;

	internal string _pattern;

	internal int _lowASCII;

	internal int _highASCII;

	internal bool _rightToLeft;

	internal bool _caseInsensitive;

	internal CultureInfo _culture;

	internal const int infinite = int.MaxValue;

	internal RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
	{
		if (caseInsensitive)
		{
			StringBuilder stringBuilder = new StringBuilder(pattern.Length);
			for (int i = 0; i < pattern.Length; i++)
			{
				stringBuilder.Append(char.ToLower(pattern[i], culture));
			}
			pattern = stringBuilder.ToString();
		}
		_pattern = pattern;
		_rightToLeft = rightToLeft;
		_caseInsensitive = caseInsensitive;
		_culture = culture;
		int num;
		int num2;
		int num3;
		if (!rightToLeft)
		{
			num = -1;
			num2 = pattern.Length - 1;
			num3 = 1;
		}
		else
		{
			num = pattern.Length;
			num2 = 0;
			num3 = -1;
		}
		_positive = new int[pattern.Length];
		int num4 = num2;
		char c = pattern[num4];
		_positive[num4] = num3;
		num4 -= num3;
		while (num4 != num)
		{
			if (pattern[num4] != c)
			{
				num4 -= num3;
				continue;
			}
			int num5 = num2;
			int num6 = num4;
			while (num6 != num && pattern[num5] == pattern[num6])
			{
				num6 -= num3;
				num5 -= num3;
			}
			if (_positive[num5] == 0)
			{
				_positive[num5] = num5 - num6;
			}
			num4 -= num3;
		}
		for (int num5 = num2 - num3; num5 != num; num5 -= num3)
		{
			if (_positive[num5] == 0)
			{
				_positive[num5] = num3;
			}
		}
		_negativeASCII = new int[128];
		for (int j = 0; j < 128; j++)
		{
			_negativeASCII[j] = num2 - num;
		}
		_lowASCII = 127;
		_highASCII = 0;
		for (num4 = num2; num4 != num; num4 -= num3)
		{
			c = pattern[num4];
			if (c < '\u0080')
			{
				if (_lowASCII > c)
				{
					_lowASCII = c;
				}
				if (_highASCII < c)
				{
					_highASCII = c;
				}
				if (_negativeASCII[(uint)c] == num2 - num)
				{
					_negativeASCII[(uint)c] = num2 - num4;
				}
			}
			else
			{
				int num7 = (int)c >> 8;
				int num8 = c & 0xFF;
				if (_negativeUnicode == null)
				{
					_negativeUnicode = new int[256][];
				}
				if (_negativeUnicode[num7] == null)
				{
					int[] array = new int[256];
					for (int k = 0; k < 256; k++)
					{
						array[k] = num2 - num;
					}
					if (num7 == 0)
					{
						Array.Copy(_negativeASCII, array, 128);
						_negativeASCII = array;
					}
					_negativeUnicode[num7] = array;
				}
				if (_negativeUnicode[num7][num8] == num2 - num)
				{
					_negativeUnicode[num7][num8] = num2 - num4;
				}
			}
		}
	}

	private bool MatchPattern(string text, int index)
	{
		if (_caseInsensitive)
		{
			if (text.Length - index < _pattern.Length)
			{
				return false;
			}
			TextInfo textInfo = _culture.TextInfo;
			for (int i = 0; i < _pattern.Length; i++)
			{
				if (textInfo.ToLower(text[index + i]) != _pattern[i])
				{
					return false;
				}
			}
			return true;
		}
		return string.CompareOrdinal(_pattern, 0, text, index, _pattern.Length) == 0;
	}

	internal bool IsMatch(string text, int index, int beglimit, int endlimit)
	{
		if (!_rightToLeft)
		{
			if (index < beglimit || endlimit - index < _pattern.Length)
			{
				return false;
			}
			return MatchPattern(text, index);
		}
		if (index > endlimit || index - beglimit < _pattern.Length)
		{
			return false;
		}
		return MatchPattern(text, index - _pattern.Length);
	}

	internal int Scan(string text, int index, int beglimit, int endlimit)
	{
		int num;
		int num2;
		int num3;
		int num4;
		int num5;
		if (!_rightToLeft)
		{
			num = _pattern.Length;
			num2 = _pattern.Length - 1;
			num3 = 0;
			num4 = index + num - 1;
			num5 = 1;
		}
		else
		{
			num = -_pattern.Length;
			num2 = 0;
			num3 = -num - 1;
			num4 = index + num;
			num5 = -1;
		}
		char c = _pattern[num2];
		while (num4 < endlimit && num4 >= beglimit)
		{
			char c2 = text[num4];
			if (_caseInsensitive)
			{
				c2 = char.ToLower(c2, _culture);
			}
			int num6;
			if (c2 != c)
			{
				int[] array;
				num6 = ((c2 < '\u0080') ? _negativeASCII[(uint)c2] : ((_negativeUnicode == null || (array = _negativeUnicode[(int)c2 >> 8]) == null) ? num : array[c2 & 0xFF]));
				num4 += num6;
				continue;
			}
			int num7 = num4;
			int num8 = num2;
			do
			{
				if (num8 == num3)
				{
					if (!_rightToLeft)
					{
						return num7;
					}
					return num7 + 1;
				}
				num8 -= num5;
				num7 -= num5;
				c2 = text[num7];
				if (_caseInsensitive)
				{
					c2 = char.ToLower(c2, _culture);
				}
			}
			while (c2 == _pattern[num8]);
			num6 = _positive[num8];
			if ((c2 & 0xFF80) == 0)
			{
				num7 = num8 - num2 + _negativeASCII[(uint)c2];
			}
			else
			{
				int[] array;
				if (_negativeUnicode == null || (array = _negativeUnicode[(int)c2 >> 8]) == null)
				{
					num4 += num6;
					continue;
				}
				num7 = num8 - num2 + array[c2 & 0xFF];
			}
			if (_rightToLeft ? (num7 < num6) : (num7 > num6))
			{
				num6 = num7;
			}
			num4 += num6;
		}
		return -1;
	}

	public override string ToString()
	{
		return _pattern;
	}
}

using System.Collections;
using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal sealed class RegexReplacement
{
	internal string _rep;

	internal List<string> _strings;

	internal List<int> _rules;

	internal const int Specials = 4;

	internal const int LeftPortion = -1;

	internal const int RightPortion = -2;

	internal const int LastGroup = -3;

	internal const int WholeString = -4;

	internal string Pattern => _rep;

	internal RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
	{
		_rep = rep;
		if (concat.Type() != 25)
		{
			throw new ArgumentException(SR.GetString("ReplacementError"));
		}
		StringBuilder stringBuilder = new StringBuilder();
		List<string> list = new List<string>();
		List<int> list2 = new List<int>();
		for (int i = 0; i < concat.ChildCount(); i++)
		{
			RegexNode regexNode = concat.Child(i);
			switch (regexNode.Type())
			{
			case 12:
				stringBuilder.Append(regexNode._str);
				break;
			case 9:
				stringBuilder.Append(regexNode._ch);
				break;
			case 13:
			{
				if (stringBuilder.Length > 0)
				{
					list2.Add(list.Count);
					list.Add(stringBuilder.ToString());
					stringBuilder.Length = 0;
				}
				int num = regexNode._m;
				if (_caps != null && num >= 0)
				{
					num = (int)_caps[num];
				}
				list2.Add(-5 - num);
				break;
			}
			default:
				throw new ArgumentException(SR.GetString("ReplacementError"));
			}
		}
		if (stringBuilder.Length > 0)
		{
			list2.Add(list.Count);
			list.Add(stringBuilder.ToString());
		}
		_strings = list;
		_rules = list2;
	}

	private void ReplacementImpl(StringBuilder sb, Match match)
	{
		for (int i = 0; i < _rules.Count; i++)
		{
			int num = _rules[i];
			if (num >= 0)
			{
				sb.Append(_strings[num]);
				continue;
			}
			if (num < -4)
			{
				sb.Append(match.GroupToStringImpl(-5 - num));
				continue;
			}
			switch (-5 - num)
			{
			case -1:
				sb.Append(match.GetLeftSubstring());
				break;
			case -2:
				sb.Append(match.GetRightSubstring());
				break;
			case -3:
				sb.Append(match.LastGroupToStringImpl());
				break;
			case -4:
				sb.Append(match.GetOriginalString());
				break;
			}
		}
	}

	private void ReplacementImplRTL(List<string> al, Match match)
	{
		for (int num = _rules.Count - 1; num >= 0; num--)
		{
			int num2 = _rules[num];
			if (num2 >= 0)
			{
				al.Add(_strings[num2]);
			}
			else if (num2 < -4)
			{
				al.Add(match.GroupToStringImpl(-5 - num2));
			}
			else
			{
				switch (-5 - num2)
				{
				case -1:
					al.Add(match.GetLeftSubstring());
					break;
				case -2:
					al.Add(match.GetRightSubstring());
					break;
				case -3:
					al.Add(match.LastGroupToStringImpl());
					break;
				case -4:
					al.Add(match.GetOriginalString());
					break;
				}
			}
		}
	}

	internal string Replacement(Match match)
	{
		StringBuilder stringBuilder = new StringBuilder();
		ReplacementImpl(stringBuilder, match);
		return stringBuilder.ToString();
	}

	internal string Replace(Regex regex, string input, int count, int startat)
	{
		if (count < -1)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("CountTooSmall"));
		}
		if (startat < 0 || startat > input.Length)
		{
			throw new ArgumentOutOfRangeException("startat", SR.GetString("BeginIndexNotNegative"));
		}
		if (count == 0)
		{
			return input;
		}
		Match match = regex.Match(input, startat);
		if (!match.Success)
		{
			return input;
		}
		StringBuilder stringBuilder;
		if (!regex.RightToLeft)
		{
			stringBuilder = new StringBuilder();
			int num = 0;
			do
			{
				if (match.Index != num)
				{
					stringBuilder.Append(input, num, match.Index - num);
				}
				num = match.Index + match.Length;
				ReplacementImpl(stringBuilder, match);
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			if (num < input.Length)
			{
				stringBuilder.Append(input, num, input.Length - num);
			}
		}
		else
		{
			List<string> list = new List<string>();
			int num2 = input.Length;
			do
			{
				if (match.Index + match.Length != num2)
				{
					list.Add(input.Substring(match.Index + match.Length, num2 - match.Index - match.Length));
				}
				num2 = match.Index;
				ReplacementImplRTL(list, match);
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			stringBuilder = new StringBuilder();
			if (num2 > 0)
			{
				stringBuilder.Append(input, 0, num2);
			}
			for (int num3 = list.Count - 1; num3 >= 0; num3--)
			{
				stringBuilder.Append(list[num3]);
			}
		}
		return stringBuilder.ToString();
	}

	internal static string Replace(MatchEvaluator evaluator, Regex regex, string input, int count, int startat)
	{
		if (evaluator == null)
		{
			throw new ArgumentNullException("evaluator");
		}
		if (count < -1)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("CountTooSmall"));
		}
		if (startat < 0 || startat > input.Length)
		{
			throw new ArgumentOutOfRangeException("startat", SR.GetString("BeginIndexNotNegative"));
		}
		if (count == 0)
		{
			return input;
		}
		Match match = regex.Match(input, startat);
		if (!match.Success)
		{
			return input;
		}
		StringBuilder stringBuilder;
		if (!regex.RightToLeft)
		{
			stringBuilder = new StringBuilder();
			int num = 0;
			do
			{
				if (match.Index != num)
				{
					stringBuilder.Append(input, num, match.Index - num);
				}
				num = match.Index + match.Length;
				stringBuilder.Append(evaluator(match));
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			if (num < input.Length)
			{
				stringBuilder.Append(input, num, input.Length - num);
			}
		}
		else
		{
			List<string> list = new List<string>();
			int num2 = input.Length;
			do
			{
				if (match.Index + match.Length != num2)
				{
					list.Add(input.Substring(match.Index + match.Length, num2 - match.Index - match.Length));
				}
				num2 = match.Index;
				list.Add(evaluator(match));
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			stringBuilder = new StringBuilder();
			if (num2 > 0)
			{
				stringBuilder.Append(input, 0, num2);
			}
			for (int num3 = list.Count - 1; num3 >= 0; num3--)
			{
				stringBuilder.Append(list[num3]);
			}
		}
		return stringBuilder.ToString();
	}

	internal static string[] Split(Regex regex, string input, int count, int startat)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", SR.GetString("CountTooSmall"));
		}
		if (startat < 0 || startat > input.Length)
		{
			throw new ArgumentOutOfRangeException("startat", SR.GetString("BeginIndexNotNegative"));
		}
		if (count == 1)
		{
			return new string[1] { input };
		}
		count--;
		Match match = regex.Match(input, startat);
		if (!match.Success)
		{
			return new string[1] { input };
		}
		List<string> list = new List<string>();
		if (!regex.RightToLeft)
		{
			int num = 0;
			do
			{
				list.Add(input.Substring(num, match.Index - num));
				num = match.Index + match.Length;
				for (int i = 1; i < match.Groups.Count; i++)
				{
					if (match.IsMatched(i))
					{
						list.Add(match.Groups[i].ToString());
					}
				}
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			list.Add(input.Substring(num, input.Length - num));
		}
		else
		{
			int num2 = input.Length;
			do
			{
				list.Add(input.Substring(match.Index + match.Length, num2 - match.Index - match.Length));
				num2 = match.Index;
				for (int j = 1; j < match.Groups.Count; j++)
				{
					if (match.IsMatched(j))
					{
						list.Add(match.Groups[j].ToString());
					}
				}
				if (--count == 0)
				{
					break;
				}
				match = match.NextMatch();
			}
			while (match.Success);
			list.Add(input.Substring(0, num2));
			list.Reverse(0, list.Count);
		}
		return list.ToArray();
	}
}

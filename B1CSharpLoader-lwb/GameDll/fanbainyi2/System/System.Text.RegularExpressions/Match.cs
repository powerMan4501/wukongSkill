using System.Security.Permissions;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class Match : Group
{
	internal static Match _empty = new Match(null, 1, string.Empty, 0, 0, 0);

	internal GroupCollection _groupcoll;

	internal Regex _regex;

	internal int _textbeg;

	internal int _textpos;

	internal int _textend;

	internal int _textstart;

	internal int[][] _matches;

	internal int[] _matchcount;

	internal bool _balancing;

	[global::__DynamicallyInvokable]
	public static Match Empty
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _empty;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual GroupCollection Groups
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_groupcoll == null)
			{
				_groupcoll = new GroupCollection(this, null);
			}
			return _groupcoll;
		}
	}

	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
		: base(text, new int[2], 0, "0")
	{
		_regex = regex;
		_matchcount = new int[capcount];
		_matches = new int[capcount][];
		_matches[0] = _caps;
		_textbeg = begpos;
		_textend = begpos + len;
		_textstart = startpos;
		_balancing = false;
	}

	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
	{
		_regex = regex;
		_text = text;
		_textbeg = textbeg;
		_textend = textend;
		_textstart = textstart;
		for (int i = 0; i < _matchcount.Length; i++)
		{
			_matchcount[i] = 0;
		}
		_balancing = false;
	}

	[global::__DynamicallyInvokable]
	public Match NextMatch()
	{
		if (_regex == null)
		{
			return this;
		}
		return _regex.Run(quick: false, _length, _text, _textbeg, _textend - _textbeg, _textpos);
	}

	[global::__DynamicallyInvokable]
	public virtual string Result(string replacement)
	{
		if (replacement == null)
		{
			throw new ArgumentNullException("replacement");
		}
		if (_regex == null)
		{
			throw new NotSupportedException(SR.GetString("NoResultOnFailed"));
		}
		RegexReplacement regexReplacement = (RegexReplacement)_regex.replref.Get();
		if (regexReplacement == null || !regexReplacement.Pattern.Equals(replacement))
		{
			regexReplacement = RegexParser.ParseReplacement(replacement, _regex.caps, _regex.capsize, _regex.capnames, _regex.roptions);
			_regex.replref.Cache(regexReplacement);
		}
		return regexReplacement.Replacement(this);
	}

	internal virtual string GroupToStringImpl(int groupnum)
	{
		int num = _matchcount[groupnum];
		if (num == 0)
		{
			return string.Empty;
		}
		int[] array = _matches[groupnum];
		return _text.Substring(array[(num - 1) * 2], array[num * 2 - 1]);
	}

	internal string LastGroupToStringImpl()
	{
		return GroupToStringImpl(_matchcount.Length - 1);
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static Match Synchronized(Match inner)
	{
		if (inner == null)
		{
			throw new ArgumentNullException("inner");
		}
		int num = inner._matchcount.Length;
		for (int i = 0; i < num; i++)
		{
			Group inner2 = inner.Groups[i];
			Group.Synchronized(inner2);
		}
		return inner;
	}

	internal virtual void AddMatch(int cap, int start, int len)
	{
		if (_matches[cap] == null)
		{
			_matches[cap] = new int[2];
		}
		int num = _matchcount[cap];
		if (num * 2 + 2 > _matches[cap].Length)
		{
			int[] array = _matches[cap];
			int[] array2 = new int[num * 8];
			for (int i = 0; i < num * 2; i++)
			{
				array2[i] = array[i];
			}
			_matches[cap] = array2;
		}
		_matches[cap][num * 2] = start;
		_matches[cap][num * 2 + 1] = len;
		_matchcount[cap] = num + 1;
	}

	internal virtual void BalanceMatch(int cap)
	{
		_balancing = true;
		int num = _matchcount[cap];
		int num2 = num * 2 - 2;
		if (_matches[cap][num2] < 0)
		{
			num2 = -3 - _matches[cap][num2];
		}
		num2 -= 2;
		if (num2 >= 0 && _matches[cap][num2] < 0)
		{
			AddMatch(cap, _matches[cap][num2], _matches[cap][num2 + 1]);
		}
		else
		{
			AddMatch(cap, -3 - num2, -4 - num2);
		}
	}

	internal virtual void RemoveMatch(int cap)
	{
		_matchcount[cap]--;
	}

	internal virtual bool IsMatched(int cap)
	{
		if (cap < _matchcount.Length && _matchcount[cap] > 0)
		{
			return _matches[cap][_matchcount[cap] * 2 - 1] != -2;
		}
		return false;
	}

	internal virtual int MatchIndex(int cap)
	{
		int num = _matches[cap][_matchcount[cap] * 2 - 2];
		if (num >= 0)
		{
			return num;
		}
		return _matches[cap][-3 - num];
	}

	internal virtual int MatchLength(int cap)
	{
		int num = _matches[cap][_matchcount[cap] * 2 - 1];
		if (num >= 0)
		{
			return num;
		}
		return _matches[cap][-3 - num];
	}

	internal virtual void Tidy(int textpos)
	{
		int[] array = _matches[0];
		_index = array[0];
		_length = array[1];
		_textpos = textpos;
		_capcount = _matchcount[0];
		if (!_balancing)
		{
			return;
		}
		for (int i = 0; i < _matchcount.Length; i++)
		{
			int num = _matchcount[i] * 2;
			int[] array2 = _matches[i];
			int num2 = 0;
			for (num2 = 0; num2 < num && array2[num2] >= 0; num2++)
			{
			}
			int num3 = num2;
			for (; num2 < num; num2++)
			{
				if (array2[num2] < 0)
				{
					num3--;
					continue;
				}
				if (num2 != num3)
				{
					array2[num3] = array2[num2];
				}
				num3++;
			}
			_matchcount[i] = num3 / 2;
		}
		_balancing = false;
	}
}

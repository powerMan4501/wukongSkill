using System.Collections;

namespace System.Text.RegularExpressions;

[Serializable]
internal class MatchEnumerator : IEnumerator
{
	internal MatchCollection _matchcoll;

	internal Match _match;

	internal int _curindex;

	internal bool _done;

	public object Current
	{
		get
		{
			if (_match == null)
			{
				throw new InvalidOperationException(SR.GetString("EnumNotStarted"));
			}
			return _match;
		}
	}

	internal MatchEnumerator(MatchCollection matchcoll)
	{
		_matchcoll = matchcoll;
	}

	public bool MoveNext()
	{
		if (_done)
		{
			return false;
		}
		_match = _matchcoll.GetMatch(_curindex);
		_curindex++;
		if (_match == null)
		{
			_done = true;
			return false;
		}
		return true;
	}

	public void Reset()
	{
		_curindex = 0;
		_done = false;
		_match = null;
	}
}

using System.Collections;

namespace System.Text.RegularExpressions;

[Serializable]
internal class CaptureEnumerator : IEnumerator
{
	internal CaptureCollection _rcc;

	internal int _curindex;

	public object Current => Capture;

	public Capture Capture
	{
		get
		{
			if (_curindex < 0 || _curindex >= _rcc.Count)
			{
				throw new InvalidOperationException(SR.GetString("EnumNotStarted"));
			}
			return _rcc[_curindex];
		}
	}

	internal CaptureEnumerator(CaptureCollection rcc)
	{
		_curindex = -1;
		_rcc = rcc;
	}

	public bool MoveNext()
	{
		int count = _rcc.Count;
		if (_curindex >= count)
		{
			return false;
		}
		_curindex++;
		return _curindex < count;
	}

	public void Reset()
	{
		_curindex = -1;
	}
}

using System.Collections;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class CaptureCollection : ICollection, IEnumerable
{
	internal Group _group;

	internal int _capcount;

	internal Capture[] _captures;

	public object SyncRoot => _group;

	public bool IsSynchronized => false;

	public bool IsReadOnly => true;

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _capcount;
		}
	}

	[global::__DynamicallyInvokable]
	public Capture this[int i]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetCapture(i);
		}
	}

	internal CaptureCollection(Group group)
	{
		_group = group;
		_capcount = _group._capcount;
	}

	public void CopyTo(Array array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int num = arrayIndex;
		for (int i = 0; i < Count; i++)
		{
			array.SetValue(this[i], num);
			num++;
		}
	}

	[global::__DynamicallyInvokable]
	public IEnumerator GetEnumerator()
	{
		return new CaptureEnumerator(this);
	}

	internal Capture GetCapture(int i)
	{
		if (i == _capcount - 1 && i >= 0)
		{
			return _group;
		}
		if (i >= _capcount || i < 0)
		{
			throw new ArgumentOutOfRangeException("i");
		}
		if (_captures == null)
		{
			_captures = new Capture[_capcount];
			for (int j = 0; j < _capcount - 1; j++)
			{
				_captures[j] = new Capture(_group._text, _group._caps[j * 2], _group._caps[j * 2 + 1]);
			}
		}
		return _captures[i];
	}
}

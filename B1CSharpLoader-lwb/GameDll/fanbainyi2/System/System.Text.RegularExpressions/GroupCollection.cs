using System.Collections;

namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class GroupCollection : ICollection, IEnumerable
{
	internal Match _match;

	internal Hashtable _captureMap;

	internal Group[] _groups;

	public object SyncRoot => _match;

	public bool IsSynchronized => false;

	public bool IsReadOnly => true;

	[global::__DynamicallyInvokable]
	public int Count
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _match._matchcount.Length;
		}
	}

	[global::__DynamicallyInvokable]
	public Group this[int groupnum]
	{
		[global::__DynamicallyInvokable]
		get
		{
			return GetGroup(groupnum);
		}
	}

	[global::__DynamicallyInvokable]
	public Group this[string groupname]
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_match._regex == null)
			{
				return Group._emptygroup;
			}
			return GetGroup(_match._regex.GroupNumberFromName(groupname));
		}
	}

	internal GroupCollection(Match match, Hashtable caps)
	{
		_match = match;
		_captureMap = caps;
	}

	internal Group GetGroup(int groupnum)
	{
		if (_captureMap != null)
		{
			object obj = _captureMap[groupnum];
			if (obj == null)
			{
				return Group._emptygroup;
			}
			return GetGroupImpl((int)obj);
		}
		if (groupnum >= _match._matchcount.Length || groupnum < 0)
		{
			return Group._emptygroup;
		}
		return GetGroupImpl(groupnum);
	}

	internal Group GetGroupImpl(int groupnum)
	{
		if (groupnum == 0)
		{
			return _match;
		}
		if (_groups == null)
		{
			_groups = new Group[_match._matchcount.Length - 1];
			for (int i = 0; i < _groups.Length; i++)
			{
				string name = _match._regex.GroupNameFromNumber(i + 1);
				_groups[i] = new Group(_match._text, _match._matches[i + 1], _match._matchcount[i + 1], name);
			}
		}
		return _groups[groupnum - 1];
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
		return new GroupEnumerator(this);
	}
}

using System.Collections;

namespace System.Configuration;

public class SettingsPropertyValueCollection : IEnumerable, ICloneable, ICollection
{
	private Hashtable _Indices;

	private ArrayList _Values;

	private bool _ReadOnly;

	public SettingsPropertyValue this[string name]
	{
		get
		{
			object obj = _Indices[name];
			if (obj == null || !(obj is int num))
			{
				return null;
			}
			if (num >= _Values.Count)
			{
				return null;
			}
			return (SettingsPropertyValue)_Values[num];
		}
	}

	public int Count => _Values.Count;

	public bool IsSynchronized => false;

	public object SyncRoot => this;

	public SettingsPropertyValueCollection()
	{
		_Indices = new Hashtable(10, StringComparer.CurrentCultureIgnoreCase);
		_Values = new ArrayList();
	}

	public void Add(SettingsPropertyValue property)
	{
		if (_ReadOnly)
		{
			throw new NotSupportedException();
		}
		int num = _Values.Add(property);
		try
		{
			_Indices.Add(property.Name, num);
		}
		catch (Exception)
		{
			_Values.RemoveAt(num);
			throw;
		}
	}

	public void Remove(string name)
	{
		if (_ReadOnly)
		{
			throw new NotSupportedException();
		}
		object obj = _Indices[name];
		if (obj == null || !(obj is int num) || num >= _Values.Count)
		{
			return;
		}
		_Values.RemoveAt(num);
		_Indices.Remove(name);
		ArrayList arrayList = new ArrayList();
		foreach (DictionaryEntry index in _Indices)
		{
			if ((int)index.Value > num)
			{
				arrayList.Add(index.Key);
			}
		}
		foreach (string item in arrayList)
		{
			_Indices[item] = (int)_Indices[item] - 1;
		}
	}

	public IEnumerator GetEnumerator()
	{
		return _Values.GetEnumerator();
	}

	public object Clone()
	{
		return new SettingsPropertyValueCollection(_Indices, _Values);
	}

	public void SetReadOnly()
	{
		if (!_ReadOnly)
		{
			_ReadOnly = true;
			_Values = ArrayList.ReadOnly(_Values);
		}
	}

	public void Clear()
	{
		_Values.Clear();
		_Indices.Clear();
	}

	public void CopyTo(Array array, int index)
	{
		_Values.CopyTo(array, index);
	}

	private SettingsPropertyValueCollection(Hashtable indices, ArrayList values)
	{
		_Indices = (Hashtable)indices.Clone();
		_Values = (ArrayList)values.Clone();
	}
}

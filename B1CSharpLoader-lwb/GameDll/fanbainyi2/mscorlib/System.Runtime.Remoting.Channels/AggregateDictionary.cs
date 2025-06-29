using System.Collections;

namespace System.Runtime.Remoting.Channels;

internal class AggregateDictionary : IDictionary, ICollection, IEnumerable
{
	private ICollection _dictionaries;

	public virtual object this[object key]
	{
		get
		{
			foreach (IDictionary dictionary in _dictionaries)
			{
				if (dictionary.Contains(key))
				{
					return dictionary[key];
				}
			}
			return null;
		}
		set
		{
			foreach (IDictionary dictionary in _dictionaries)
			{
				if (dictionary.Contains(key))
				{
					dictionary[key] = value;
				}
			}
		}
	}

	public virtual ICollection Keys
	{
		get
		{
			ArrayList arrayList = new ArrayList();
			foreach (IDictionary dictionary in _dictionaries)
			{
				ICollection keys = dictionary.Keys;
				if (keys == null)
				{
					continue;
				}
				foreach (object item in keys)
				{
					arrayList.Add(item);
				}
			}
			return arrayList;
		}
	}

	public virtual ICollection Values
	{
		get
		{
			ArrayList arrayList = new ArrayList();
			foreach (IDictionary dictionary in _dictionaries)
			{
				ICollection values = dictionary.Values;
				if (values == null)
				{
					continue;
				}
				foreach (object item in values)
				{
					arrayList.Add(item);
				}
			}
			return arrayList;
		}
	}

	public virtual bool IsReadOnly => false;

	public virtual bool IsFixedSize => true;

	public virtual int Count
	{
		get
		{
			int num = 0;
			foreach (IDictionary dictionary in _dictionaries)
			{
				num += dictionary.Count;
			}
			return num;
		}
	}

	public virtual object SyncRoot => this;

	public virtual bool IsSynchronized => false;

	public AggregateDictionary(ICollection dictionaries)
	{
		_dictionaries = dictionaries;
	}

	public virtual bool Contains(object key)
	{
		foreach (IDictionary dictionary in _dictionaries)
		{
			if (dictionary.Contains(key))
			{
				return true;
			}
		}
		return false;
	}

	public virtual void Add(object key, object value)
	{
		throw new NotSupportedException();
	}

	public virtual void Clear()
	{
		throw new NotSupportedException();
	}

	public virtual void Remove(object key)
	{
		throw new NotSupportedException();
	}

	public virtual IDictionaryEnumerator GetEnumerator()
	{
		return new DictionaryEnumeratorByKeys(this);
	}

	public virtual void CopyTo(Array array, int index)
	{
		throw new NotSupportedException();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new DictionaryEnumeratorByKeys(this);
	}
}

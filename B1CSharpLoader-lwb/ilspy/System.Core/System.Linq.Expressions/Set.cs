using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Expressions;

internal sealed class Set<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly Dictionary<T, object> _data;

	public int Count => _data.Count;

	public bool IsReadOnly => false;

	internal Set()
	{
		_data = new Dictionary<T, object>();
	}

	internal Set(IEqualityComparer<T> comparer)
	{
		_data = new Dictionary<T, object>(comparer);
	}

	internal Set(IList<T> list)
	{
		_data = new Dictionary<T, object>(list.Count);
		foreach (T item in list)
		{
			Add(item);
		}
	}

	internal Set(IEnumerable<T> list)
	{
		_data = new Dictionary<T, object>();
		foreach (T item in list)
		{
			Add(item);
		}
	}

	internal Set(int capacity)
	{
		_data = new Dictionary<T, object>(capacity);
	}

	public void Add(T item)
	{
		_data[item] = null;
	}

	public void Clear()
	{
		_data.Clear();
	}

	public bool Contains(T item)
	{
		return _data.ContainsKey(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		_data.Keys.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return _data.Remove(item);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _data.Keys.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _data.Keys.GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
internal sealed class DictionaryKeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> dictionary;

	public int Count => dictionary.Count;

	bool ICollection<TKey>.IsReadOnly => true;

	public DictionaryKeyCollection(IDictionary<TKey, TValue> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		this.dictionary = dictionary;
	}

	public void CopyTo(TKey[] array, int index)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (array.Length <= index && Count > 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_IndexOutOfRangeException"));
		}
		if (array.Length - index < dictionary.Count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InsufficientSpaceToCopyCollection"));
		}
		int num = index;
		foreach (KeyValuePair<TKey, TValue> item in dictionary)
		{
			array[num++] = item.Key;
		}
	}

	void ICollection<TKey>.Add(TKey item)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_KeyCollectionSet"));
	}

	void ICollection<TKey>.Clear()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_KeyCollectionSet"));
	}

	public bool Contains(TKey item)
	{
		return dictionary.ContainsKey(item);
	}

	bool ICollection<TKey>.Remove(TKey item)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_KeyCollectionSet"));
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TKey>)this).GetEnumerator();
	}

	public IEnumerator<TKey> GetEnumerator()
	{
		return new DictionaryKeyEnumerator<TKey, TValue>(dictionary);
	}
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Runtime.InteropServices.WindowsRuntime;

[Serializable]
[DebuggerDisplay("Count = {Count}")]
internal sealed class DictionaryValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable
{
	private readonly IDictionary<TKey, TValue> dictionary;

	public int Count => dictionary.Count;

	bool ICollection<TValue>.IsReadOnly => true;

	public DictionaryValueCollection(IDictionary<TKey, TValue> dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		this.dictionary = dictionary;
	}

	public void CopyTo(TValue[] array, int index)
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
			array[num++] = item.Value;
		}
	}

	void ICollection<TValue>.Add(TValue item)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_ValueCollectionSet"));
	}

	void ICollection<TValue>.Clear()
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_ValueCollectionSet"));
	}

	public bool Contains(TValue item)
	{
		EqualityComparer<TValue> equalityComparer = EqualityComparer<TValue>.Default;
		using (IEnumerator<TValue> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				TValue current = enumerator.Current;
				if (equalityComparer.Equals(item, current))
				{
					return true;
				}
			}
		}
		return false;
	}

	bool ICollection<TValue>.Remove(TValue item)
	{
		throw new NotSupportedException(Environment.GetResourceString("NotSupported_ValueCollectionSet"));
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TValue>)this).GetEnumerator();
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return new DictionaryValueEnumerator<TKey, TValue>(dictionary);
	}
}

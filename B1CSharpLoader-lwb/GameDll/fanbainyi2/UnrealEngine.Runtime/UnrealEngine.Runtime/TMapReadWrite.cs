using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TMapReadWrite<TKey, TValue> : TMapBase<TKey, TValue>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	public TValue this[TKey key]
	{
		get
		{
			return Get(key);
		}
		set
		{
			AddInternal(key, value);
		}
	}

	public bool IsReadOnly => false;

	public KeyEnumerator Keys => new KeyEnumerator(this);

	ICollection<TKey> IDictionary<TKey, TValue>.Keys => new KeyEnumerator(this);

	public ValueCollection Values => new ValueCollection(this);

	ICollection<TValue> IDictionary<TKey, TValue>.Values => new ValueCollection(this);

	public TMapReadWrite(UObject owner, FFieldAddress mapProperty, IntPtr address, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TKey>.ToNative keyToNative, MarshalingDelegates<TValue>.FromNative valueFromNative, MarshalingDelegates<TValue>.ToNative valueToNative)
		: base(owner, mapProperty, address, keyFromNative, keyToNative, valueFromNative, valueToNative)
	{
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
		AddInternal(item.Key, item.Value);
	}

	public void Add(TKey key, TValue value)
	{
		AddInternal(key, value);
	}

	public void Clear()
	{
		ClearInternal();
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return ContainsKey(item.Key);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		int maxIndex = MapHelper.GetMaxIndex();
		int num = arrayIndex;
		for (int i = 0; i < maxIndex; i++)
		{
			if (MapHelper.IsValidIndex(i))
			{
				array[num++] = GetAt(i);
			}
		}
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return RemoveInternal(item.Key);
	}

	public bool Remove(TKey key)
	{
		return RemoveInternal(key);
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		return TryGetInternal(key, out value);
	}

	public Dictionary<TKey, TValue> ToDictionary()
	{
		return new Dictionary<TKey, TValue>(this);
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TMapReadOnly<TKey, TValue> : TMapBase<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	public TValue this[TKey key] => Get(key);

	public KeyEnumerator Keys => new KeyEnumerator(this);

	IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys => new KeyEnumerator(this);

	public ValueCollection Values => new ValueCollection(this);

	IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values => new ValueCollection(this);

	public TMapReadOnly(UObject owner, FFieldAddress mapProperty, IntPtr address, MarshalingDelegates<TKey>.FromNative keyFromNative, MarshalingDelegates<TValue>.FromNative valueFromNative)
		: base(owner, mapProperty, address, keyFromNative, (MarshalingDelegates<TKey>.ToNative)null, valueFromNative, (MarshalingDelegates<TValue>.ToNative)null)
	{
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		int num = IndexOf(key);
		if (num >= 0)
		{
			value = GetAt(num).Value;
			return true;
		}
		value = default(TValue);
		return false;
	}
}

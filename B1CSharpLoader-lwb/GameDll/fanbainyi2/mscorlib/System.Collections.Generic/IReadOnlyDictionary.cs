namespace System.Collections.Generic;

[__DynamicallyInvokable]
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	[__DynamicallyInvokable]
	TValue this[TKey key]
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	IEnumerable<TKey> Keys
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	IEnumerable<TValue> Values
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	bool ContainsKey(TKey key);

	[__DynamicallyInvokable]
	bool TryGetValue(TKey key, out TValue value);
}

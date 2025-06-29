using System.Text;

namespace System.Collections.Generic;

[Serializable]
[__DynamicallyInvokable]
public struct KeyValuePair<TKey, TValue>
{
	private TKey key;

	private TValue value;

	[__DynamicallyInvokable]
	public TKey Key
	{
		[__DynamicallyInvokable]
		get
		{
			return key;
		}
	}

	[__DynamicallyInvokable]
	public TValue Value
	{
		[__DynamicallyInvokable]
		get
		{
			return value;
		}
	}

	[__DynamicallyInvokable]
	public KeyValuePair(TKey key, TValue value)
	{
		this.key = key;
		this.value = value;
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		StringBuilder stringBuilder = StringBuilderCache.Acquire();
		stringBuilder.Append('[');
		if (Key != null)
		{
			stringBuilder.Append(Key.ToString());
		}
		stringBuilder.Append(", ");
		if (Value != null)
		{
			stringBuilder.Append(Value.ToString());
		}
		stringBuilder.Append(']');
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}
}

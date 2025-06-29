using System.Runtime.InteropServices;

namespace System.Collections;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct DictionaryEntry
{
	private object _key;

	private object _value;

	[__DynamicallyInvokable]
	public object Key
	{
		[__DynamicallyInvokable]
		get
		{
			return _key;
		}
		[__DynamicallyInvokable]
		set
		{
			_key = value;
		}
	}

	[__DynamicallyInvokable]
	public object Value
	{
		[__DynamicallyInvokable]
		get
		{
			return _value;
		}
		[__DynamicallyInvokable]
		set
		{
			_value = value;
		}
	}

	[__DynamicallyInvokable]
	public DictionaryEntry(object key, object value)
	{
		_key = key;
		_value = value;
	}
}

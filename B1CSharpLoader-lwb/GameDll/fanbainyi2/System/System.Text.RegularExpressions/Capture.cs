namespace System.Text.RegularExpressions;

[Serializable]
[global::__DynamicallyInvokable]
public class Capture
{
	internal string _text;

	internal int _index;

	internal int _length;

	[global::__DynamicallyInvokable]
	public int Index
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _index;
		}
	}

	[global::__DynamicallyInvokable]
	public int Length
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _length;
		}
	}

	[global::__DynamicallyInvokable]
	public string Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _text.Substring(_index, _length);
		}
	}

	internal Capture(string text, int i, int l)
	{
		_text = text;
		_index = i;
		_length = l;
	}

	[global::__DynamicallyInvokable]
	public override string ToString()
	{
		return Value;
	}

	internal string GetOriginalString()
	{
		return _text;
	}

	internal string GetLeftSubstring()
	{
		return _text.Substring(0, _index);
	}

	internal string GetRightSubstring()
	{
		return _text.Substring(_index + _length, _text.Length - _index - _length);
	}
}

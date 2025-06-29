namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class EncoderReplacementFallback : EncoderFallback
{
	private string strDefault;

	[__DynamicallyInvokable]
	public string DefaultString
	{
		[__DynamicallyInvokable]
		get
		{
			return strDefault;
		}
	}

	[__DynamicallyInvokable]
	public override int MaxCharCount
	{
		[__DynamicallyInvokable]
		get
		{
			return strDefault.Length;
		}
	}

	[__DynamicallyInvokable]
	public EncoderReplacementFallback()
		: this("?")
	{
	}

	[__DynamicallyInvokable]
	public EncoderReplacementFallback(string replacement)
	{
		if (replacement == null)
		{
			throw new ArgumentNullException("replacement");
		}
		bool flag = false;
		for (int i = 0; i < replacement.Length; i++)
		{
			if (char.IsSurrogate(replacement, i))
			{
				if (char.IsHighSurrogate(replacement, i))
				{
					if (flag)
					{
						break;
					}
					flag = true;
					continue;
				}
				if (!flag)
				{
					flag = true;
					break;
				}
				flag = false;
			}
			else if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequenceNoIndex", "replacement"));
		}
		strDefault = replacement;
	}

	[__DynamicallyInvokable]
	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return new EncoderReplacementFallbackBuffer(this);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is EncoderReplacementFallback encoderReplacementFallback)
		{
			return strDefault == encoderReplacementFallback.strDefault;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return strDefault.GetHashCode();
	}
}

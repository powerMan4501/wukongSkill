namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class DecoderReplacementFallback : DecoderFallback
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
	public DecoderReplacementFallback()
		: this("?")
	{
	}

	[__DynamicallyInvokable]
	public DecoderReplacementFallback(string replacement)
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
	public override DecoderFallbackBuffer CreateFallbackBuffer()
	{
		return new DecoderReplacementFallbackBuffer(this);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is DecoderReplacementFallback decoderReplacementFallback)
		{
			return strDefault == decoderReplacementFallback.strDefault;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return strDefault.GetHashCode();
	}
}

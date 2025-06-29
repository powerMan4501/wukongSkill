namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class EncoderExceptionFallback : EncoderFallback
{
	[__DynamicallyInvokable]
	public override int MaxCharCount
	{
		[__DynamicallyInvokable]
		get
		{
			return 0;
		}
	}

	[__DynamicallyInvokable]
	public EncoderExceptionFallback()
	{
	}

	[__DynamicallyInvokable]
	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return new EncoderExceptionFallbackBuffer();
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is EncoderExceptionFallback)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return 654;
	}
}

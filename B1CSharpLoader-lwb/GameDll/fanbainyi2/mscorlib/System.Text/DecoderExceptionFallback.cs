namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class DecoderExceptionFallback : DecoderFallback
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
	public DecoderExceptionFallback()
	{
	}

	[__DynamicallyInvokable]
	public override DecoderFallbackBuffer CreateFallbackBuffer()
	{
		return new DecoderExceptionFallbackBuffer();
	}

	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is DecoderExceptionFallback)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return 879;
	}
}

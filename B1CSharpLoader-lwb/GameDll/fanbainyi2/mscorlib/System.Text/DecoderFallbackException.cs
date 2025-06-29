using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
[__DynamicallyInvokable]
public sealed class DecoderFallbackException : ArgumentException
{
	private byte[] bytesUnknown;

	private int index;

	[__DynamicallyInvokable]
	public byte[] BytesUnknown
	{
		[__DynamicallyInvokable]
		get
		{
			return bytesUnknown;
		}
	}

	[__DynamicallyInvokable]
	public int Index
	{
		[__DynamicallyInvokable]
		get
		{
			return index;
		}
	}

	[__DynamicallyInvokable]
	public DecoderFallbackException()
		: base(Environment.GetResourceString("Arg_ArgumentException"))
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public DecoderFallbackException(string message)
		: base(message)
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public DecoderFallbackException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024809);
	}

	internal DecoderFallbackException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[__DynamicallyInvokable]
	public DecoderFallbackException(string message, byte[] bytesUnknown, int index)
		: base(message)
	{
		this.bytesUnknown = bytesUnknown;
		this.index = index;
	}
}

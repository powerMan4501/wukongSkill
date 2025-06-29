using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class EndOfStreamException : IOException
{
	[__DynamicallyInvokable]
	public EndOfStreamException()
		: base(Environment.GetResourceString("Arg_EndOfStreamException"))
	{
		SetErrorCode(-2147024858);
	}

	[__DynamicallyInvokable]
	public EndOfStreamException(string message)
		: base(message)
	{
		SetErrorCode(-2147024858);
	}

	[__DynamicallyInvokable]
	public EndOfStreamException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024858);
	}

	protected EndOfStreamException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

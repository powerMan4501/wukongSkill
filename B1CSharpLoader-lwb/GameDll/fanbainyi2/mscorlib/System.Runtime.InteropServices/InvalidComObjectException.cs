using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class InvalidComObjectException : SystemException
{
	[__DynamicallyInvokable]
	public InvalidComObjectException()
		: base(Environment.GetResourceString("Arg_InvalidComObjectException"))
	{
		SetErrorCode(-2146233049);
	}

	[__DynamicallyInvokable]
	public InvalidComObjectException(string message)
		: base(message)
	{
		SetErrorCode(-2146233049);
	}

	[__DynamicallyInvokable]
	public InvalidComObjectException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233049);
	}

	protected InvalidComObjectException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

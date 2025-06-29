using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class InvalidCastException : SystemException
{
	[__DynamicallyInvokable]
	public InvalidCastException()
		: base(Environment.GetResourceString("Arg_InvalidCastException"))
	{
		SetErrorCode(-2147467262);
	}

	[__DynamicallyInvokable]
	public InvalidCastException(string message)
		: base(message)
	{
		SetErrorCode(-2147467262);
	}

	[__DynamicallyInvokable]
	public InvalidCastException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147467262);
	}

	protected InvalidCastException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[__DynamicallyInvokable]
	public InvalidCastException(string message, int errorCode)
		: base(message)
	{
		SetErrorCode(errorCode);
	}
}

using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class InvalidOperationException : SystemException
{
	[__DynamicallyInvokable]
	public InvalidOperationException()
		: base(Environment.GetResourceString("Arg_InvalidOperationException"))
	{
		SetErrorCode(-2146233079);
	}

	[__DynamicallyInvokable]
	public InvalidOperationException(string message)
		: base(message)
	{
		SetErrorCode(-2146233079);
	}

	[__DynamicallyInvokable]
	public InvalidOperationException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233079);
	}

	protected InvalidOperationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

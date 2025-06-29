using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class TimeoutException : SystemException
{
	[__DynamicallyInvokable]
	public TimeoutException()
		: base(Environment.GetResourceString("Arg_TimeoutException"))
	{
		SetErrorCode(-2146233083);
	}

	[__DynamicallyInvokable]
	public TimeoutException(string message)
		: base(message)
	{
		SetErrorCode(-2146233083);
	}

	[__DynamicallyInvokable]
	public TimeoutException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233083);
	}

	protected TimeoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

using System.Runtime.Serialization;

namespace System;

[Serializable]
[__DynamicallyInvokable]
public sealed class InsufficientExecutionStackException : SystemException
{
	[__DynamicallyInvokable]
	public InsufficientExecutionStackException()
		: base(Environment.GetResourceString("Arg_InsufficientExecutionStackException"))
	{
		SetErrorCode(-2146232968);
	}

	[__DynamicallyInvokable]
	public InsufficientExecutionStackException(string message)
		: base(message)
	{
		SetErrorCode(-2146232968);
	}

	[__DynamicallyInvokable]
	public InsufficientExecutionStackException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146232968);
	}

	private InsufficientExecutionStackException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

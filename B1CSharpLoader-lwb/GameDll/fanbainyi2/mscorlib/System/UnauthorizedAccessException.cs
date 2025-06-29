using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class UnauthorizedAccessException : SystemException
{
	[__DynamicallyInvokable]
	public UnauthorizedAccessException()
		: base(Environment.GetResourceString("Arg_UnauthorizedAccessException"))
	{
		SetErrorCode(-2147024891);
	}

	[__DynamicallyInvokable]
	public UnauthorizedAccessException(string message)
		: base(message)
	{
		SetErrorCode(-2147024891);
	}

	[__DynamicallyInvokable]
	public UnauthorizedAccessException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147024891);
	}

	protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
